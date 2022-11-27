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
    public partial class Updatebooking : Form
    {
        SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");

        public Updatebooking()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fadyDataSet3.booking4' table. You can move, or remove it, as needed.
            this.booking4TableAdapter.Fill(this.fadyDataSet3.booking4);

        }

        private void booking4BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booking4BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fadyDataSet3);

        }

        private void booking4DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (booking4DataGridView.CurrentRow != null)
            {
                kindtrip.Text = booking4DataGridView.CurrentRow.Cells[1].Value.ToString();
                form.Text = booking4DataGridView.CurrentRow.Cells[2].Value.ToString();
                to.Text = booking4DataGridView.CurrentRow.Cells[3].Value.ToString();
                charis.Text = booking4DataGridView.CurrentRow.Cells[6].Value.ToString();
                cBoxDgree.Text = booking4DataGridView.CurrentRow.Cells[8].Value.ToString();
                if (booking4DataGridView.CurrentRow.Cells[7].Value != null)
                {
                    cost.Text = (Int32.Parse(charis.Text) * 1600 - 900).ToString();
                }
                else
                {
                    cost.Text = (Int32.Parse(charis.Text) * 1600).ToString();
                }
            }
        }

        private void booking4DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (booking4DataGridView.CurrentRow != null)
            {

                booking4DataGridView.CurrentRow.Cells[1].Value = kindtrip.Text;
                booking4DataGridView.CurrentRow.Cells[2].Value = form.Text;
                booking4DataGridView.CurrentRow.Cells[3].Value = to.Text;
                booking4DataGridView.CurrentRow.Cells[6].Value = charis.Text;
                booking4DataGridView.CurrentRow.Cells[8].Value = cBoxDgree.Text;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            SqlCommand cmd = new SqlCommand("Select * From booking4 where @Passport=Passport", conn);
            cmd.Parameters.AddWithValue("Passport", search.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            int final = Convert.ToInt32(cmd.ExecuteScalar());
            if (final > 0)
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                booking4DataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("data not found ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void client_Click(object sender, EventArgs e)
        {
            this.Close();
            UserInfo userInfo=new UserInfo();
            userInfo.ShowDialog();
        }

        private void booking_Click(object sender, EventArgs e)
        {
            this.Close();
            Booking booking= new Booking();
            booking.ShowDialog();
        }

      
        private void UpdateBooking_Click(object sender, EventArgs e)
        {
            this.Close();
            Updatebooking updatabooking= new Updatebooking();
            updatabooking.ShowDialog();
        }

        private void UpdateUserInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateDataUser userInfo=new UpdateDataUser();
            userInfo.ShowDialog();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
