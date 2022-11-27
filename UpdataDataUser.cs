using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace final
{
    public partial class UpdataDataUser : Form
    {
        SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");
        string img = "";
        public UpdataDataUser()
        {
            InitializeComponent();
        }

        private void travelerDataBase2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            { 
                this.Validate();
            this.travelerDataBase2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fadyDataSet4);
            MessageBox.Show("Edited successfully");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void test3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fadyDataSet4.TravelerDataBase2' table. You can move, or remove it, as needed.
            this.travelerDataBase2TableAdapter.Fill(this.fadyDataSet4.TravelerDataBase2);

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //SelectionChanged

        private void travelerDataBase2DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (travelerDataBase2DataGridView.CurrentRow != null)
                {
                    firstname1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[0].Value.ToString();
                    lastname2.Text = travelerDataBase2DataGridView.CurrentRow.Cells[1].Value.ToString();
                    passport1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[2].Value.ToString();
                    nationality1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[3].Value.ToString();
                    id1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[4].Value.ToString();
                    byte[] img = (byte[])travelerDataBase2DataGridView.CurrentRow.Cells[5].Value;
                    MemoryStream memoryStream = new MemoryStream(img);
                    userphoto.Image = Image.FromStream(memoryStream);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
          
        }
        //upload photo
        public  void getvlues()
        {
            DataTable dt = new DataTable();
            conn.Open();
            string sql = "select * From TravelerDataBase2";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
        }
        public byte [] setphoto()
        {
            MemoryStream ms=new MemoryStream();
            userphoto.Image.Save(ms,userphoto.Image.RawFormat);
            return ms.GetBuffer();
        }

        //sreach
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            SqlCommand cmd = new SqlCommand("Select * From TravelerDataBase2 where @Passport=Passport", conn);
            cmd.Parameters.AddWithValue("Passport", search.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            int final = Convert.ToInt32(cmd.ExecuteScalar());
            if (final>0)
            {
            DataTable dt = new DataTable();
            da.Fill(dt);
            travelerDataBase2DataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("data not found ");
            }
            
        }

        private void client_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userInfo = new UserInfo();
            userInfo.ShowDialog();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        private void UpdataUserInfo_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdataDataUser userInfo = new UpdataDataUser();
            userInfo.ShowDialog();
        }

        private void UpdtateBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking updatabooking = new Updatabooking();
            updatabooking.ShowDialog();
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                UserInfoClass updateuser = new UserInfoClass();
                updateuser.Full_Name(firstname1.Text, lastname2.Text);
                updateuser.User_Info(nationality1.Text, int.Parse(id1.Text), passport1.Text);
                if (travelerDataBase2DataGridView.CurrentRow != null)
                {
                    {
                        travelerDataBase2DataGridView.CurrentRow.Cells[0].Value = updateuser.GET_FirstName();
                        travelerDataBase2DataGridView.CurrentRow.Cells[1].Value = updateuser.GET_LastName();
                        travelerDataBase2DataGridView.CurrentRow.Cells[2].Value = updateuser.GET_passport();
                        travelerDataBase2DataGridView.CurrentRow.Cells[3].Value = updateuser.GET_nationality();
                        travelerDataBase2DataGridView.CurrentRow.Cells[4].Value = updateuser.GET_PersonalID();


                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contact=new ContactUs();
            contact.ShowDialog();
        }
    }
}
