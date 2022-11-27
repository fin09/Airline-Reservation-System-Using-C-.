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
    public partial class Booking : Form
    {
        //inherit
        public static string Set_From = "";
        public static string  Set_To= "";
        public static string Set_date = "";
        public static string SetClass = "";
        public Booking()
        {
            InitializeComponent();
        }
        

      

        private void label10_Click(object sender, EventArgs e)
        {
            roundtrip.Checked = true;
            onewayrb.Checked = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            onewayrb.Checked = true;
            roundtrip.Checked = false;
        }

        private void guna2PictureBox2_MouseHover(object sender, EventArgs e)
        {
            picPlane.Size = new Size(165, 125);
        }

        private void picPlane_MouseLeave(object sender, EventArgs e)
        {
            picPlane.Size = new Size(160, 120);
        }

        private void picAdults_MouseHover(object sender, EventArgs e)
        {
            picAdults.Size = new Size(40, 40);
        }

        private void PicChildren_MouseHover(object sender, EventArgs e)
        {
            PicChildren.Size = new Size(40, 40);
        }

        private void picInfants_MouseHover(object sender, EventArgs e)
        {
            picInfants.Size = new Size(40, 40);
        }


        private void Booking_Load(object sender, EventArgs e)
        {
            departing.Text = DateTime.Now.ToString();
            DateReturning.Text = (DateTime.Now).ToString();
        }

        private void picAdults_MouseLeave(object sender, EventArgs e)
        {
            picAdults.Size = new Size(30, 30);
        }

        private void PicChildren_MouseLeave(object sender, EventArgs e)
        {
            PicChildren.Size = new Size(30, 30);
        }

        private void picInfants_MouseLeave(object sender, EventArgs e)
        {
            picInfants.Size = new Size(30, 30);
        }



        private void cBoxFrom_MouseHover(object sender, EventArgs e)
        {
            cBoxFrom.ForeColor = Color.Blue;
            cBoxFrom.BorderColor = Color.Blue;
        }

        private void cBoxFrom_MouseLeave(object sender, EventArgs e)
        {
            cBoxFrom.ForeColor = Color.DarkGray;
            cBoxFrom.BorderColor = Color.DarkGray;
        }
        private void cBoxTo_MouseHover(object sender, EventArgs e)
        {
            cBoxTo.ForeColor = Color.Blue;
            cBoxTo.BorderColor = Color.Blue;
        }

        private void cBoxTo_MouseLeave(object sender, EventArgs e)
        {
            cBoxTo.ForeColor = Color.DarkGray;
            cBoxTo.BorderColor = Color.DarkGray;
        }

        private void cBoxDgree_MouseHover(object sender, EventArgs e)
        {
            cBoxDgree.BorderColor = Color.Blue;
            cBoxDgree.ForeColor = Color.Blue;
        }

        private void cBoxDgree_MouseLeave(object sender, EventArgs e)
        {
            cBoxDgree.BorderColor = Color.DarkGray;
            cBoxDgree.ForeColor = Color.DarkGray;
        }


        // booking new
        private void BookNow_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection("server=(LocalDB)\\MSSQLLocalDB;database=fady;Trusted_Connection = True");
            string sql = "insert into booking4 values (@kind_trip,@form,@to,@deprating,@returning, @charis,@promo,@class,@Passport)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                Set_From = cBoxFrom.Text;
                Set_To= cBoxTo.Text;
                Set_date = departing.Text;
                SetClass = cBoxDgree.Text;

                int x = 0;
                int NumberOfChrais = 0;
                BookingClass booking = new BookingClass();

                if (Convert.ToInt32(adults.Value) > 0 || Convert.ToInt32(child.Value) > 0 || Convert.ToInt32(infants.Value) > 0)
                {

                    x = Convert.ToInt32(adults.Value) + Convert.ToInt32(child.Value) + Convert.ToInt32(infants.Value);
                    NumberOfChrais = x;
                    string source = cBoxFrom.Text;
                    string destination = cBoxTo.Text;
                    string kindTrip = onewayrb.Text;
                    string kindTrip2 = roundtrip.Text;
                    string promoCode = prometb.Text;
                    string class_type = cBoxDgree.Text;
                    string Passport = passport.Text;

                    string TOD = departing.Text;
                    string TOR = DateReturning.Text;
                    


                    if (source == destination)
                    {


                        cBoxFrom.Text = cBoxTo.Text = null;
                        MessageBox.Show("Enter a valid value");
                    }
                    else
                    {
                        if (onewayrb.Checked)
                        {
                            
                            booking.place(source, destination, class_type);
                            
                            booking.flightInfo(TOD, TOR,Passport);
                            booking.InfoTrip(kindTrip, promoCode, NumberOfChrais);
                        }
                        else if (roundtrip.Checked)
                        {
                            try
                            {

                                if (TOD != TOR)
                                {
                                    booking.place(source, destination, class_type);
                                    booking.flightInfo(TOD, TOR, Passport);
                                    booking.InfoTrip(kindTrip2, promoCode, NumberOfChrais);

                                }
                                else
                                {
                                    throw new ArgumentNullException(paramName: nameof(DateReturning), message: "Parameter can't be valid"); 
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Enter Postive Number");
                }


                //cmd.Parameters.AddWithValue("@Traveler_ID", gunaTextBox1.Text);
                if (onewayrb.Checked)
                {
                    cmd.Parameters.AddWithValue("@kind_trip", booking.Get_Kind_trip());
                    cmd.Parameters.AddWithValue("@deprating", booking.Get_Time_Of_Departing());

                    cmd.Parameters.AddWithValue("@returning", 0);




                }
                else if (roundtrip.Checked)
                {
                    cmd.Parameters.AddWithValue("@kind_trip", booking.Get_Kind_trip());
                    cmd.Parameters.AddWithValue("@deprating", booking.Get_Time_Of_Departing());
                    cmd.Parameters.AddWithValue("@returning", booking.Get_Time_Of_Returing());
                }

                cmd.Parameters.AddWithValue("@form", booking.Get_Source());
                cmd.Parameters.AddWithValue("@to", booking.Get_Destination());
                //cmd.Parameters.AddWithValue("@deprating", departing.Text);
                cmd.Parameters.AddWithValue("@charis", booking.Get_Number_Of_Chairs());
                //cmd.Parameters.AddWithValue("@returning", returning.Text);
                cmd.Parameters.AddWithValue("@promo", booking.Get_PromoCode());
                cmd.Parameters.AddWithValue("@class", booking.Get_Class_type());
                cmd.Parameters.AddWithValue("@passport", booking.Get_Passport());
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
       

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void ClientPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userInfo = new UserInfo();
            userInfo.ShowDialog();
        }

        private void client_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userInfo = new UserInfo();
            userInfo.ShowDialog();
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
            UpdataDataUser userInfo = new UpdataDataUser();
            userInfo.ShowDialog();
        }

        private void UpdateUserInfo_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdataDataUser userInfo = new UpdataDataUser();
            userInfo.ShowDialog();
        }

        private void UpdateBookingPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking updatabooking = new Updatabooking();
            updatabooking.ShowDialog();
        }

        private void UpdataBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking updatabooking = new Updatabooking();
            updatabooking.ShowDialog();
        }

        private void passport_TextChanged(object sender, EventArgs e)
        {

        }

        //goto Dashboard
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
        //marking visiable
        private void onewayrb_Click(object sender, EventArgs e)
        {
            DateReturning.Visible = false;
            Returning1.Visible = false;
        }

        private void roundtrip_Click(object sender, EventArgs e)
        {
            DateReturning.Visible = true;
            Returning1.Visible = true;
        }
           //
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            cBoxFrom.Text = Dashboard.setFromCountry;
            cBoxTo.Text = Dashboard.setToCountry;
            
        }

        private void oneWay_Click(object sender, EventArgs e)
        {
            DateReturning.Visible = false;
            Returning1.Visible = false;
            onewayrb.Checked=true;

        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            DateReturning.Visible = true;
            Returning1.Visible = true;
            roundtrip.Checked=true;
               

        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard=new Dashboard();
            dashboard.ShowDialog();
        }
        //goto contact us
        private void BtnContactUS_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contactUs = new ContactUs();
            contactUs.ShowDialog();
        }

        private void ContactPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contactUs = new ContactUs();
            contactUs.ShowDialog();
        }

     

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}