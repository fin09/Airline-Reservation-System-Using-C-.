using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace final
{
    public partial class UserInfo : Form
    {
        public static string SetName = "";
        SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");
        string img = "";
        

        public UserInfo()
        {
            InitializeComponent();
        }

      

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter ="png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*)";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img=dialog.FileName.ToString();
                userphoto.ImageLocation=img;

            }
        }


        private void UpdataUserinfo_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdataDataUser updataData=new UpdataDataUser();
            updataData.ShowDialog();
        }

        private void UpdataBooking_Click(object sender, EventArgs e)
        {
            this.Close();
            Updatabooking updatabooking= new Updatabooking();
            updatabooking.ShowDialog();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            SetName=firstname.Text+" "+lastname.Text;
        }


        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           

          

        }
        //save data
        private void BtnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                UserInfoClass userInfo = new UserInfoClass();

                userInfo.Full_Name(firstname.Text,lastname.Text);
                if (int.Parse(id.Text) > 0)
                {
                    userInfo.User_Info(nationallity.Text, int.Parse(id.Text), passport.Text);
                }
                else
                {
                    throw new ArgumentNullException(paramName: nameof(id.Text), message: "Personal ID can't be a negative value.Try again"); 
                }
                Byte[] imges = null;
                FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                imges = br.ReadBytes((int)stream.Length);
                string sql = "insert into TravelerDataBase2 values (@Frist_Name,@Last_Name,@Passport,@Nationallity,@Presonal_ID,@photo)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@Traveler_ID", gunaTextBox1.Text);
                cmd.Parameters.AddWithValue("@Frist_Name", userInfo.GET_FirstName());
                cmd.Parameters.AddWithValue("@Last_Name", userInfo.GET_LastName());
                cmd.Parameters.AddWithValue("@Passport", userInfo.GET_passport());
                cmd.Parameters.AddWithValue("@Nationallity", userInfo.GET_nationality());
                cmd.Parameters.AddWithValue("@Presonal_ID", userInfo.GET_PersonalID());
                cmd.Parameters.AddWithValue("@photo", imges);

                if (conn.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("thank you");


                }
                else if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("thank you");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPrintTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket frm = new Ticket();
            frm.ShowDialog();
           

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void travelerDataBase2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.travelerDataBase2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fadyDataSet4);

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fadyDataSet4.TravelerDataBase2' table. You can move, or remove it, as needed.
            this.travelerDataBase2TableAdapter.Fill(this.fadyDataSet4.TravelerDataBase2);

        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contactUs = new ContactUs();
            contactUs.ShowDialog();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userInfo = new UserInfo();
            userInfo.ShowDialog();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.ShowDialog();
        }
    }
}
