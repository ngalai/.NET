namespace PingPongGame
{
    partial class fGameSingle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGameSingle));
            this.Player = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Back = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SoundOn = new System.Windows.Forms.Button();
            this.SoundOff = new System.Windows.Forms.Button();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.Location = new System.Drawing.Point(542, 82);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(79, 72);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(379, -5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(18, 456);
            this.progressBar1.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.Location = new System.Drawing.Point(159, 189);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(165, 46);
            this.Back.TabIndex = 2;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Quit
            // 
            this.Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quit.BackgroundImage")));
            this.Quit.Location = new System.Drawing.Point(-6, 158);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(108, 108);
            this.Quit.TabIndex = 3;
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // SoundOn
            // 
            this.SoundOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoundOn.BackgroundImage")));
            this.SoundOn.Location = new System.Drawing.Point(362, -5);
            this.SoundOn.Name = "SoundOn";
            this.SoundOn.Size = new System.Drawing.Size(56, 57);
            this.SoundOn.TabIndex = 5;
            this.SoundOn.UseVisualStyleBackColor = true;
            this.SoundOn.Click += new System.EventHandler(this.SoundOn_Click);
            // 
            // SoundOff
            // 
            this.SoundOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoundOff.BackgroundImage")));
            this.SoundOff.Location = new System.Drawing.Point(362, 399);
            this.SoundOff.Name = "SoundOff";
            this.SoundOff.Size = new System.Drawing.Size(52, 52);
            this.SoundOff.TabIndex = 6;
            this.SoundOff.UseVisualStyleBackColor = true;
            this.SoundOff.Click += new System.EventHandler(this.SoundOff_Click);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Yellow;
            this.Ball.Location = new System.Drawing.Point(481, 91);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(22, 22);
            this.Ball.TabIndex = 7;
            this.Ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(503, 419);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 22);
            this.score.TabIndex = 8;
            // 
            // fGameSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.SoundOff);
            this.Controls.Add(this.SoundOn);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Player);
            this.Name = "fGameSingle";
            this.Text = "fGameSingle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.meMove);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button SoundOn;
        private System.Windows.Forms.Button SoundOff;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
    }
}