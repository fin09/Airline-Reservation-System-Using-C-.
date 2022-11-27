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
    public partial class SignUp : Form
    {
        SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            bool flag = true;
            if (flag)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtCPassword.UseSystemPasswordChar = true;

            }
            flag = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // save data
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SignIn frm=new SignIn();
            this.Hide();
            frm.ShowDialog();
        }
        void check()
        {


            if (btnHide1.Visible == true)
            {
                btnEye1.Visible = true;
                btnHide1.Visible = false;
                txtPassword.UseSystemPasswordChar = false;
                txtCPassword.UseSystemPasswordChar = false;

            }
            else if (btnEye1.Visible == true)
            {
                btnHide1.Visible = true;
                btnEye1.Visible = false;
                txtPassword.UseSystemPasswordChar = true;
                txtCPassword.UseSystemPasswordChar = true;

            }
        }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            check();
        }

        private void btnEye1_Click(object sender, EventArgs e)
        {
            check();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into loginData1 values(@User_Name,@Email_Address,@Password,@Genter,@Phone_Number,@Traveler_Address) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@User_Name", textboxuser.Text);
                cmd.Parameters.AddWithValue("@Email_Address", emailtextbox.Text);
                if (txtPassword.Text == txtCPassword.Text)
                {
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                }
                else
                {
                    MessageBox.Show("Error in Password");
                }
                if (malerb.Checked)
                {
                    cmd.Parameters.AddWithValue("@Genter", malerb.Text);

                }
                else if (femalerb.Checked)
                {
                    cmd.Parameters.AddWithValue("@Genter", femalerb.Text);
                }
                cmd.Parameters.AddWithValue("@Phone_Number", int.Parse(phonetextbox.Text));
                cmd.Parameters.AddWithValue("@Traveler_Address", adresstextbox.Text);
                if (conn.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("successfully registered");


                }
                else if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("successfully registered");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
