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

namespace final
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        // send message
        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");
            string sql = "insert into ContactUs values (@First_Name,@Last_Name,@Email,@Phone,@Message)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@First_Name", fristname.Text);
                cmd.Parameters.AddWithValue("@Last_Name", lastname.Text);
                cmd.Parameters.AddWithValue("@Email", emailtextbox.Text);
                cmd.Parameters.AddWithValue("@Phone", phonetextbox.Text);
                cmd.Parameters.AddWithValue("@Message", Message.Text);
                if (conn.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("We will contact you as soon as possible");


                }
                else if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("We will contact you as soon as possible");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard=new Dashboard();
            dashboard.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void ClientPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userinfo = new UserInfo();
            userinfo.ShowDialog();
        }

        private void client_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userinfo = new UserInfo();
            userinfo.ShowDialog();

        }

        private void BookingPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        private void booking1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        private void updateUserInfoPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdataDataUser userinfo = new UpdataDataUser();
            userinfo.ShowDialog();
        }

        private void UpdateUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdataDataUser userinfo = new UpdataDataUser();
            userinfo.ShowDialog();
        }

        private void UpdataBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking update= new Updatabooking();
            update.ShowDialog();
        }

        private void UpdateBookingPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking update = new Updatabooking();
            update.ShowDialog();
        }

        private void ContectPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contactUs = new ContactUs();
            contactUs.ShowDialog();
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contactUs = new ContactUs();
            contactUs.ShowDialog();
        }
    }
}
