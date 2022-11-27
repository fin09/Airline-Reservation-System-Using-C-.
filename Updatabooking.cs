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
    public partial class Updatabooking : Form
    {
        SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");

        public Updatabooking()
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
            MessageBox.Show("Edited successfully");

        }

        private void booking4DataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (booking4DataGridView.CurrentRow != null)
            {
                kindtrip.Text = booking4DataGridView.CurrentRow.Cells[0].Value.ToString();
                from.Text = booking4DataGridView.CurrentRow.Cells[1].Value.ToString();
                to.Text = booking4DataGridView.CurrentRow.Cells[2].Value.ToString();
                chrais.Text = booking4DataGridView.CurrentRow.Cells[5].Value.ToString();
                cBoxDgree.Text = booking4DataGridView.CurrentRow.Cells[7].Value.ToString();
                if (booking4DataGridView.CurrentRow.Cells[6].Value != null)
                {
                    cost.Text = (Int32.Parse(chrais.Text) * 1600 - 900).ToString();
                }
                else
                {
                    cost.Text = (Int32.Parse(chrais.Text) * 1600).ToString();
                }
            }
        }

        private void booking4DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void client_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userInfo=new UserInfo();
            userInfo.ShowDialog();
        }

        private void booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking= new Booking();
            booking.ShowDialog();
        }

      
        private void UpdateBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking updatabooking= new Updatabooking();
            updatabooking.ShowDialog();
        }

        private void UpdateUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdataDataUser userInfo=new UpdataDataUser();
            userInfo.ShowDialog();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {








                string temp = " ";
                if (booking4DataGridView.CurrentRow.Cells[6].Value != null)
                {

                    if ((Int32.Parse(chrais.Text) * 1600 - 900) > 0)
                    {
                        temp = (Int32.Parse(chrais.Text) * 1600 - 900).ToString();
                    }
                    else
                    {
                        MessageBox.Show("error in cost");
                    }

                }
                else
                {
                    if ((Int32.Parse(chrais.Text) * 1600) > 0)
                    {
                        temp = (Int32.Parse(chrais.Text) * 1600).ToString();
                    }
                    else
                    {
                        MessageBox.Show("error in chrais");
                    }

                }
                string source = from.Text;
                string destination = to.Text;
                string kindTrip = kindtrip.Text;

                string promoCode = "";
                string class_type = cBoxDgree.Text;
                string Passport = search.Text;
                int NumberOfChrais = int.Parse(chrais.Text);
                string TOD = "";
                string TOR = "";
                UpdateBookingClass updateBooking = new UpdateBookingClass();
                updateBooking.place(source, destination, class_type);
                updateBooking.flightInfo(TOD, TOR, Passport);
                updateBooking.InfoTrip(kindTrip, promoCode, NumberOfChrais);
                if (int.Parse(temp) > 0)
                {
                    updateBooking.Set_Cost(int.Parse(temp));

                }
                else
                {
                    updateBooking.Set_Cost(1);

                }


                if (booking4DataGridView.CurrentRow != null)
                {

                    booking4DataGridView.CurrentRow.Cells[0].Value = updateBooking.Get_Kind_trip();
                    booking4DataGridView.CurrentRow.Cells[1].Value = updateBooking.Get_Source();
                    booking4DataGridView.CurrentRow.Cells[2].Value = updateBooking.Get_Destination();
                    booking4DataGridView.CurrentRow.Cells[5].Value = updateBooking.Get_Number_Of_Chairs();
                    booking4DataGridView.CurrentRow.Cells[7].Value = updateBooking.Get_Class_type();

                }





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void BtnSearch_Click(object sender, EventArgs e)
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

        private void BtnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contactUs = new ContactUs();
            contactUs.ShowDialog();
        }
    }
}
