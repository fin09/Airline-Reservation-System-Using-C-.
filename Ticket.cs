using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace final
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            LblDate.Text = Booking.Set_date;
            LblFrom.Text = Booking.Set_From;
            LblTo.Text = Booking.Set_To;
            LblFrom2.Text = Booking.Set_From;
            LblTo2.Text = Booking.Set_To;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1Ticket_Click(object sender, EventArgs e)
        {
            panel2Ticket.Visible = true;
            panel1Ticket.Visible=false;
          
        }

        private void panel2Ticket_Click(object sender, EventArgs e)
        {
            Ticket frm=new Ticket();
            frm.ShowDialog();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1Ticket_Paint(object sender, PaintEventArgs e)
        {
            LblName.Text = UserInfo.SetName;
            LblName2.Text = UserInfo.SetName;
            LblClass.Text = Booking.SetClass;
        }
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
       
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bitmap = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics g2 = Graphics.FromImage(bitmap);
            g2.CopyFromScreen(this.Location.X,this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }

        private void BtnPrint_Click_1(object sender, EventArgs e)
        {
            
           
                Graphics myGraphics = this.CreateGraphics();
                Size s = this.Size;
                bitmap = new Bitmap(s.Width, s.Height, myGraphics);
                Graphics memoryGraphics = Graphics.FromImage(bitmap);
                memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialog1.ShowDialog();
        }
    }
}
