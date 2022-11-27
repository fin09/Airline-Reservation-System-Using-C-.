using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace final
{
    public partial class SignIn : Form
    {
        System.Data.SqlClient.SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");

        public SignIn()
        {
            InitializeComponent();
        }
         
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SignUp f=new SignUp();
            this.Close();
            f.ShowDialog();
        }
        void check()
        {


            if (btnHide1.Visible == true)
            {
                btnEye1.Visible = true;
                btnHide1.Visible = false;
                txtPassword.UseSystemPasswordChar = false;

            }
            else if (btnEye1.Visible == true)
            {
                btnHide1.Visible = true;
                btnEye1.Visible = false;
                txtPassword.UseSystemPasswordChar = true;

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

        private void SignIn_Load(object sender, EventArgs e)
        {
            bool flag = true;
            if (flag)
            {
                txtPassword.UseSystemPasswordChar = true;

            }
            flag = false;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            SignUp f = new SignUp();
            this.Close();
            f.ShowDialog();
        }

        private void signin2_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "SELECT count(*) from loginData1 where Email_Address = '" + txtEmail.Text + "' and Password ='" + (txtPassword.Text) + " '";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int final = Convert.ToInt32(cmd.ExecuteScalar());

                if (final > 0)
                {
                    MessageBox.Show("hello my friend ");
                    Dashboard frm = new Dashboard();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {

                    MessageBox.Show("try again");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
