namespace PingPongGame
{
    partial class fOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOption));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Guide = new System.Windows.Forms.Button();
            this.HightScore = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.cTypeGame = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(484, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 460);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 82);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ping Pong";
            // 
            // Play
            // 
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.Location = new System.Drawing.Point(517, 179);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(117, 42);
            this.Play.TabIndex = 14;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.Location = new System.Drawing.Point(517, 423);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 34);
            this.Exit.TabIndex = 15;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Guide
            // 
            this.Guide.BackColor = System.Drawing.Color.White;
            this.Guide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guide.BackgroundImage")));
            this.Guide.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Guide.Location = new System.Drawing.Point(179, 96);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(42, 36);
            this.Guide.TabIndex = 16;
            this.Guide.UseVisualStyleBackColor = false;
            this.Guide.Click += new System.EventHandler(this.Guide_Click);
            // 
            // HightScore
            // 
            this.HightScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HightScore.BackgroundImage")));
            this.HightScore.Location = new System.Drawing.Point(140, 96);
            this.HightScore.Name = "HightScore";
            this.HightScore.Size = new System.Drawing.Size(44, 36);
            this.HightScore.TabIndex = 19;
            this.HightScore.UseVisualStyleBackColor = true;
            this.HightScore.Click += new System.EventHandler(this.HightScore_Click);
            // 
            // History
            // 
            this.History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("History.BackgroundImage")));
            this.History.Location = new System.Drawing.Point(76, 83);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(70, 63);
            this.History.TabIndex = 20;
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // cTypeGame
            // 
            this.cTypeGame.FormattingEnabled = true;
            this.cTypeGame.Items.AddRange(new object[] {
            "one player",
            "two player"});
            this.cTypeGame.Location = new System.Drawing.Point(227, 105);
            this.cTypeGame.Name = "cTypeGame";
            this.cTypeGame.Size = new System.Drawing.Size(179, 21);
            this.cTypeGame.TabIndex = 21;
            this.cTypeGame.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 459);
            this.Controls.Add(this.cTypeGame);
            this.Controls.Add(this.History);
            this.Controls.Add(this.HightScore);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fOption";
            this.Text = "fOption";
            this.Load += new System.EventHandler(this.clGiaoDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Guide;
        private System.Windows.Forms.Button HightScore;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.ComboBox cTypeGame;
    }
}

