using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Dashboard : Form
    {
        public static string setFromCountry = "";
        public static string setToCountry = "";
   
        public class temp: Booking
        {

        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void picDark_Click(object sender, EventArgs e)
        {
            panel1.FillColor = Color.FromArgb(130, 104, 238);
            Panel2.FillColor = Color.FromArgb(130, 104, 238);
            BackColor = Color.FromArgb(130, 104, 238);
            picLight.Visible = true;
        }

        private void picLight_Click(object sender, EventArgs e)
        {
            panel1.FillColor = Color.FromArgb(34, 34, 34);
            Panel2.FillColor = Color.FromArgb(34, 34, 34);

            picLight.Visible = false;
            picDark.Visible = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string[] Country = { "Germany", "Brazil", "China" };
            cBoxCountry.Items.AddRange(Country);
            cBoxCountry.Text = "Germany";

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCountry.Text == "Brazil")
            {

                panelChina.Visible = false;
                panelGermany.Visible = false;
                panelBrazil.Visible = true;
            }
            else if (cBoxCountry.Text == "China")
            {

                panelChina.Visible = true;
                panelBrazil.Visible = false;
                panelGermany.Visible = false;
            }
            else
            {

                panelGermany.Visible = true;
                panelChina.Visible = false;
                panelBrazil.Visible = false;

            }
        }


        /*  void picHover(string picName)
          {
              picName.Size = new Size(230, 115);
          }*/
        private void pic1Germany_MouseLeave(object sender, EventArgs e)
        {
            pic1Germany.Size = new Size(210, 110);
        }

        private void pic1Germany_MouseHover(object sender, EventArgs e)
        {
            pic1Germany.Size = new Size(230, 115);
        }

        private void pic2Germany_MouseHover(object sender, EventArgs e)
        {
            pic2Germany.Size = new Size(230, 115);
        }

        private void pic2Germany_MouseLeave(object sender, EventArgs e)
        {
            pic2Germany.Size = new Size(210, 110);
        }

        private void pic3Germany_MouseHover(object sender, EventArgs e)
        {
            pic3Germany.Size = new Size(230, 115);
        }

        private void pic3Germany_MouseLeave(object sender, EventArgs e)
        {
            pic3Germany.Size = new Size(210, 110);
        }

        private void pic4Germany_MouseHover(object sender, EventArgs e)
        {
            pic4Germany.Size = new Size(230, 115);
        }

        private void pic4Germany_MouseLeave(object sender, EventArgs e)
        {
            pic4Germany.Size = new Size(210, 110);
        }

        private void pic5Germany_MouseHover(object sender, EventArgs e)
        {
            pic5Germany.Size = new Size(230, 115);
        }

        private void pic5Germany_MouseLeave(object sender, EventArgs e)
        {
            pic5Germany.Size = new Size(210, 110);
        }
        //resize 
        private void pic6Germany_MouseHover(object sender, EventArgs e)
        {
            pic6Germany.Size = new Size(230, 115);
        }

        private void pic6Germany_MouseLeave(object sender, EventArgs e)
        {
            pic6Germany.Size = new Size(210, 110);
        }

        //resize 
        private void pic2Brazil_MouseHover(object sender, EventArgs e)
        {
            pic2Brazil.Size = new Size(270, 115);
        }
        //resize 
        private void pic3Brazil_MouseHover(object sender, EventArgs e)
        {
            pic3Brazil.Size = new Size(270, 115);
        }

        private void pic4Brazil_MouseHover(object sender, EventArgs e)
        {
            pic4Brazil.Size = new Size(270, 115);
        }

        private void pic2Brazil_MouseLeave(object sender, EventArgs e)
        {
            pic2Brazil.Size = new Size(250, 110);
        }
        //resize 
        private void pic3Brazil_MouseLeave(object sender, EventArgs e)
        {
            pic3Brazil.Size = new Size(250, 110);
        }

        private void pic4Brazil_MouseLeave(object sender, EventArgs e)
        {
            pic4Brazil.Size = new Size(250, 110);
        }

        private void pic1China_MouseHover(object sender, EventArgs e)
        {
            pic1China.Size = new Size(270, 115);
        }

        private void pic2China_MouseHover(object sender, EventArgs e)
        {
            pic2China.Size = new Size(270, 115);
        }

        private void pic3China_MouseHover(object sender, EventArgs e)
        {
            pic3China.Size = new Size(270, 115);
        }

        private void pic4China_MouseHover(object sender, EventArgs e)
        {
            pic4China.Size = new Size(270, 115);
        }

        private void pic1China_MouseLeave(object sender, EventArgs e)
        {
            pic1China.Size = new Size(250, 110);
        }

        private void pic2China_MouseLeave(object sender, EventArgs e)
        {
            pic2China.Size = new Size(250, 110);
        }

        private void pic3China_MouseLeave(object sender, EventArgs e)
        {
            pic3China.Size = new Size(250, 110);
        }



        private void pic4China_MouseLeave(object sender, EventArgs e)
        {
            pic4China.Size = new Size(250, 110);
        }

        private void cilent_Click(object sender, EventArgs e)
        {
           
            this.Hide();
           UserInfo userInfo = new UserInfo();
             userInfo.ShowDialog();
           
        }

        private void cilentPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo userInfo = new UserInfo();
            userInfo.ShowDialog();
        
        }
        //goto booking
        private void bookingPic_Click(object sender, EventArgs e)
        {
                    this.Hide();
                   Booking booking = new Booking();
                   booking.ShowDialog();
           
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.ShowDialog();
        
        }

        private void UpdateBookingPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking updatabooking = new Updatabooking();
            updatabooking.ShowDialog();
           
        }
        //goto Updatebooking
        private void UpdateBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatabooking updatabooking = new Updatabooking();
            updatabooking.ShowDialog();
            
        }
        //goto UpdateserInfo
        private void UpdateUserInfo_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdataDataUser updataDataUser = new UpdataDataUser();
            updataDataUser.ShowDialog();
           
        }

        private void UpdateUserInfoPic_Click(object sender, EventArgs e)
        {

            this.Hide();
            UpdataDataUser updataDataUser = new UpdataDataUser();
            updataDataUser.ShowDialog();
         
        }

        private void ContactPic_Click(object sender, EventArgs e)
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
        public void sendData()
        {
            this.Hide();
            setFromCountry = cBoxCountry.Text;
            Booking frm = new Booking();
            frm.ShowDialog();
         
        }

        private void pic1Germany_Click(object sender, EventArgs e) 
        {
            setToCountry = LblFrance.Text;
            sendData();
        }

        private void pic2Germany_Click(object sender, EventArgs e)
        {
            setToCountry = LblMaldives.Text;
            sendData();
        }

        private void pic3Germany_Click(object sender, EventArgs e)
        {
            setToCountry = LblLondon.Text;
            sendData();
        }
        //goto booking 
        private void pic4Germany_Click(object sender, EventArgs e)
        {
            setToCountry = LblEgypt.Text;
            sendData();
        }

        private void pic5Germany_Click(object sender, EventArgs e)
        {
            setToCountry = LblCanda.Text;
            sendData();
        }

        private void pic6Germany_Click(object sender, EventArgs e)
        {
            
            setToCountry = LblSpain.Text;
            sendData();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void pic2Brazil_Click(object sender, EventArgs e)
        {
            setToCountry = LblGermany.Text;
            sendData();
        }

        private void pic3Brazil_Click(object sender, EventArgs e)
        {
            setToCountry = LblRussia.Text;
            sendData();
        }

        private void pic4Brazil_Click(object sender, EventArgs e)
        {
            setToCountry = LblLondon2.Text;
            sendData();
        }

        private void pic1China_Click(object sender, EventArgs e)
        {
            setToCountry = LblEgypt2.Text;
            sendData();
        }

        private void pic2China_Click(object sender, EventArgs e)
        {
            setToCountry = lblGermany3.Text;
            sendData();
        }

        private void pic3China_Click(object sender, EventArgs e)
        {
            setToCountry = LblRussia2.Text;
            sendData();
        }

   

        private void UpdateBookingPic_MouseLeave(object sender, EventArgs e)
        {

        }

  
        private void pic1Brazil_Click(object sender, EventArgs e)
        {
            setToCountry = LblCanda2.Text;
            sendData();
        }

        private void pic4China_Click(object sender, EventArgs e)
        {
            setToCountry = LblAustralia.Text;
            sendData();
        }

        private void Pic1Brazil_Click_1(object sender, EventArgs e)
        {
            setToCountry = LblCanda2.Text;
            sendData();
        }
    }
}
