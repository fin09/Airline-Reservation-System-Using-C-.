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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startTime += 5;
            proBar.Value = startTime;
            label2.Text = proBar.Value.ToString() + "%";
            if (proBar.Value > 100)
            {
                proBar.Value = 0;
                timer1.Stop();
                SignIn f = new SignIn();
                this.Hide();
                f.Show();
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
