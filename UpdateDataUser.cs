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
    public partial class UpdateDataUser : Form
    {
        SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");
        string img = "";
        public UpdateDataUser()
        {
            InitializeComponent();
        }

        private void travelerDataBase2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.travelerDataBase2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fadyDataSet4);

        }

        private void test3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fadyDataSet4.TravelerDataBase2' table. You can move, or remove it, as needed.
            this.travelerDataBase2TableAdapter.Fill(this.fadyDataSet4.TravelerDataBase2);

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*)";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img = dialog.FileName.ToString();
                userphoto.ImageLocation = img;

            }
        }

        private void travelerDataBase2DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            if (travelerDataBase2DataGridView.CurrentRow != null)
            {
                fristname1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[1].Value.ToString();
                lastname2.Text = travelerDataBase2DataGridView.CurrentRow.Cells[2].Value.ToString();
                passport1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[3].Value.ToString();
                nationallity1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[4].Value.ToString();
                id1.Text = travelerDataBase2DataGridView.CurrentRow.Cells[5].Value.ToString();
                byte [] img=(byte [])travelerDataBase2DataGridView.CurrentRow.Cells[6].Value;
                MemoryStream memoryStream = new MemoryStream(img);
                userphoto.Image=Image.FromStream(memoryStream);




            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (travelerDataBase2DataGridView.CurrentRow != null)
            {
                {
                    travelerDataBase2DataGridView.CurrentRow.Cells[1].Value = fristname1.Text;
                    travelerDataBase2DataGridView.CurrentRow.Cells[2].Value = lastname2.Text;
                    travelerDataBase2DataGridView.CurrentRow.Cells[3].Value = passport1.Text;
                    travelerDataBase2DataGridView.CurrentRow.Cells[4].Value = nationallity1.Text;
                    travelerDataBase2DataGridView.CurrentRow.Cells[5].Value = id1.Text;


                }
            }
          
        }
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
            this.Close();
            UserInfo userInfo = new UserInfo();
            userInfo.ShowDialog();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            this.Close();
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        private void UpdataUserInfo_Click(object sender, EventArgs e)
        {

            this.Close();
            UpdateDataUser userInfo = new UpdateDataUser();
            userInfo.ShowDialog();
        }

        private void UpdtateBooking_Click(object sender, EventArgs e)
        {
            this.Close();
            Updatebooking updatabooking = new Updatebooking();
            updatabooking.ShowDialog();
        }
    }
}
