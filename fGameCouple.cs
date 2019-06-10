using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace PingPongGame
{
    public partial class fGameCouple : Form

    {
       
        public fGameCouple()
        {
            InitializeComponent();
            timer1.Enabled = true;
            KeyPreview = true;


        }

        SoundPlayer player = new SoundPlayer(@"D:\sg2.wav ");

        bool Up;
        bool Down;
        int Speed = 5;
        int BallX = 5;
        int BallY = -6;
        int ScorePlayer = 0;
        int ScoreComputer = 0;
            
        public void mePlay()
        {
            // Show score player on label1.
            diemc.Text = "" + ScorePlayer; 
            
            // Show score computer on label2.
            diemm.Text = "" + ScoreComputer; 

            Ball.Top -= BallY;
            Ball.Left -= BallX;

            May.Top += Speed;
            
             if (ScoreComputer < 5)
             {
                 if (May.Top < 0 || May.Top > 420)
                 {
                     Speed = -Speed;
                 }
             }
             else
             {
                 May.Top = Ball.Top + 10;
             }



            if (Ball.Left < 0)
            {
                Ball.Left = 400;
                BallX = -BallX;
                BallX -= 2;
                ScoreComputer++;
            }

            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Left = 400 ;
                BallX = -BallX;
                BallX += 2;
                ScorePlayer++;
            }
            if (Ball.Top < 0 || Ball.Top + Ball.Height > ClientSize.Height)
            {
                BallY = -BallY;

            }

            if (Ball.Bounds.IntersectsWith(NguoiChoi.Bounds) || Ball.Bounds.IntersectsWith(May.Bounds))
            {
                BallX = -BallX;

            }

            if (Up == true && NguoiChoi.Top > 0)
            {
                NguoiChoi.Top -= 10;
            }

            if (Down == true && NguoiChoi.Top < 420)
            {
                NguoiChoi.Top += 10;
            }



            if (ScorePlayer > 10)
            {
                timer1.Stop();
                MessageBox.Show("You win");

                fInfoPlayer f0 = new fInfoPlayer();
                this.Hide();
                f0.Show();

            }

            if (ScoreComputer > 10)
            {
                timer1.Stop();
                MessageBox.Show("The computer win ");
            }
        }
           
            private void timer1_Tick(object sender, EventArgs e)
            {
            mePlay();
            }
    

            private void NGUOICHOI_Load(object sender, EventArgs e)
        {
        }
       

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            fOption f2 = new fOption();
            this.Hide();
            f2.Show();
        }

       
        private void Score_Enter(object sender, EventArgs e)
        {
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            player.Play();
        }

        private void SoudOff_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

       

        private void meMove(object sender, KeyEventArgs e)
        {
            int x = NguoiChoi.Location.X;
            int y = NguoiChoi.Location.Y;

            if (e.KeyCode == Keys.E) x += 5;
            else if (e.KeyCode == Keys.A) x -= 5;
            else if (e.KeyCode == Keys.W) y -= 5;
            else if (e.KeyCode == Keys.S) y += 5;

            NguoiChoi.Location = new Point(x, y);
        }
    }
}
