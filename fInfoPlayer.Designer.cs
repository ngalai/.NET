namespace PingPongGame
{
    partial class fInfoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInfoPlayer));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tScore = new System.Windows.Forms.TextBox();
            this.tGame = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.time_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tTime = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tSex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // tID
            // 
            this.tID.Location = new System.Drawing.Point(47, 96);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(189, 20);
            this.tID.TabIndex = 5;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(62, 134);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(174, 20);
            this.tName.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(242, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score";
            // 
            // tScore
            // 
            this.tScore.Location = new System.Drawing.Point(72, 200);
            this.tScore.Name = "tScore";
            this.tScore.Size = new System.Drawing.Size(164, 20);
            this.tScore.TabIndex = 10;
            // 
            // tGame
            // 
            this.tGame.Location = new System.Drawing.Point(72, 226);
            this.tGame.Name = "tGame";
            this.tGame.Size = new System.Drawing.Size(164, 20);
            this.tGame.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Game";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Crimson;
            this.Save.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(126, 282);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 35);
            this.Save.TabIndex = 13;
            this.Save.Text = "SAVE    ";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Record Score";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Green;
            this.Back.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(-4, 282);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 35);
            this.Back.TabIndex = 15;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.time_lb.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lb.ForeColor = System.Drawing.Color.White;
            this.time_lb.Location = new System.Drawing.Point(21, 59);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(43, 17);
            this.time_lb.TabIndex = 16;
            this.time_lb.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(62, 58);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(174, 20);
            this.tTime.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(24, 169);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 17);
            this.label.TabIndex = 18;
            this.label.Text = "Sex";
            // 
            // tSex
            // 
            this.tSex.Location = new System.Drawing.Point(62, 166);
            this.tSex.Name = "tSex";
            this.tSex.Size = new System.Drawing.Size(174, 20);
            this.tSex.TabIndex = 19;
            // 
            // fInfoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(267, 316);
            this.Controls.Add(this.tSex);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tTime);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tGame);
            this.Controls.Add(this.tScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "fInfoPlayer";
            this.Text = "fInfoPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tScore;
        private System.Windows.Forms.TextBox tGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tTime;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tSex;
    }
}