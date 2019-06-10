namespace PingPongGame
{
    partial class fGameCouple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGameCouple));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.SoudOff = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.May = new System.Windows.Forms.PictureBox();
            this.NguoiChoi = new System.Windows.Forms.PictureBox();
            this.diemm = new System.Windows.Forms.Label();
            this.diemc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.May)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(322, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 471);
            this.progressBar1.TabIndex = 3;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Yellow;
            this.Ball.Location = new System.Drawing.Point(204, 113);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(22, 20);
            this.Ball.TabIndex = 6;
            this.Ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.Color.White;
            this.Player2.Location = new System.Drawing.Point(118, 9);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(69, 22);
            this.Player2.TabIndex = 3;
            this.Player2.Text = "Player";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.Color.White;
            this.Player1.Location = new System.Drawing.Point(449, 9);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(96, 22);
            this.Player1.TabIndex = 2;
            this.Player1.Text = "Computer";
            // 
            // SoudOff
            // 
            this.SoudOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoudOff.BackgroundImage")));
            this.SoudOff.Location = new System.Drawing.Point(296, 426);
            this.SoudOff.Name = "SoudOff";
            this.SoudOff.Size = new System.Drawing.Size(60, 57);
            this.SoudOff.TabIndex = 12;
            this.SoudOff.UseVisualStyleBackColor = true;
            this.SoudOff.Click += new System.EventHandler(this.SoudOff_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.Location = new System.Drawing.Point(308, 80);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(39, 132);
            this.Back.TabIndex = 11;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Quit
            // 
            this.Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quit.BackgroundImage")));
            this.Quit.Location = new System.Drawing.Point(309, 262);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(38, 120);
            this.Quit.TabIndex = 1;
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Start
            // 
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.Location = new System.Drawing.Point(296, -7);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(60, 57);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // May
            // 
            this.May.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("May.BackgroundImage")));
            this.May.Location = new System.Drawing.Point(573, 207);
            this.May.Name = "May";
            this.May.Size = new System.Drawing.Size(83, 66);
            this.May.TabIndex = 11;
            this.May.TabStop = false;
            // 
            // NguoiChoi
            // 
            this.NguoiChoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NguoiChoi.BackgroundImage")));
            this.NguoiChoi.Location = new System.Drawing.Point(-6, 207);
            this.NguoiChoi.Name = "NguoiChoi";
            this.NguoiChoi.Size = new System.Drawing.Size(83, 66);
            this.NguoiChoi.TabIndex = 12;
            this.NguoiChoi.TabStop = false;
            // 
            // diemm
            // 
            this.diemm.AutoSize = true;
            this.diemm.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.diemm.Location = new System.Drawing.Point(582, 11);
            this.diemm.Name = "diemm";
            this.diemm.Size = new System.Drawing.Size(0, 22);
            this.diemm.TabIndex = 13;
            // 
            // diemc
            // 
            this.diemc.AutoSize = true;
            this.diemc.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.diemc.Location = new System.Drawing.Point(34, 10);
            this.diemc.Name = "diemc";
            this.diemc.Size = new System.Drawing.Size(0, 22);
            this.diemc.TabIndex = 14;
            // 
            // fGameCouple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(646, 475);
            this.Controls.Add(this.diemc);
            this.Controls.Add(this.diemm);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SoudOff);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.NguoiChoi);
            this.Controls.Add(this.May);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.progressBar1);
            this.Name = "fGameCouple";
            this.Text = "fGameCouple";
            this.Load += new System.EventHandler(this.NGUOICHOI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.meMove);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.May)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiChoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox May;
        private System.Windows.Forms.PictureBox NguoiChoi;
        private System.Windows.Forms.Button SoudOff;
        private System.Windows.Forms.Label diemm;
        private System.Windows.Forms.Label diemc;
    }
}