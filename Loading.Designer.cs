namespace final
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Guna2PictureBox picPlane1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox13 = new Guna.UI2.WinForms.Guna2PictureBox();
            picPlane1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picPlane1)).BeginInit();
            this.proBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlane1
            // 
            picPlane1.BackColor = System.Drawing.Color.Transparent;
            picPlane1.FillColor = System.Drawing.Color.Transparent;
            picPlane1.Image = ((System.Drawing.Image)(resources.GetObject("picPlane1.Image")));
            picPlane1.ImageRotate = 0F;
            picPlane1.Location = new System.Drawing.Point(76, 72);
            picPlane1.Name = "picPlane1";
            picPlane1.Size = new System.Drawing.Size(200, 200);
            picPlane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPlane1.TabIndex = 0;
            picPlane1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(154, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "percent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(300, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Airline Reservation System";
            // 
            // proBar
            // 
            this.proBar.AnimationSpeed = 0.8F;
            this.proBar.BackColor = System.Drawing.Color.Transparent;
            this.proBar.Controls.Add(picPlane1);
            this.proBar.Controls.Add(this.label2);
            this.proBar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.proBar.FillThickness = 10;
            this.proBar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proBar.ForeColor = System.Drawing.Color.White;
            this.proBar.Location = new System.Drawing.Point(300, 95);
            this.proBar.Maximum = 101;
            this.proBar.Minimum = 0;
            this.proBar.Name = "proBar";
            this.proBar.ProgressColor = System.Drawing.Color.Red;
            this.proBar.ProgressColor2 = System.Drawing.Color.Red;
            this.proBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.proBar.ProgressThickness = 10;
            this.proBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.proBar.Size = new System.Drawing.Size(356, 356);
            this.proBar.TabIndex = 15;
            this.proBar.Text = "guna2CircleProgressBar1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2PictureBox13
            // 
            this.guna2PictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox13.Image")));
            this.guna2PictureBox13.ImageRotate = 0F;
            this.guna2PictureBox13.Location = new System.Drawing.Point(-164, -9);
            this.guna2PictureBox13.Name = "guna2PictureBox13";
            this.guna2PictureBox13.Size = new System.Drawing.Size(108, 67);
            this.guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox13.TabIndex = 122;
            this.guna2PictureBox13.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 499);
            this.Controls.Add(this.guna2PictureBox13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(picPlane1)).EndInit();
            this.proBar.ResumeLayout(false);
            this.proBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar proBar;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox13;
    }
}