using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class fGameSingle : Form
    {

        SoundPlayer player = new SoundPlayer(@"D:\sg2.wav ");
        bool Up;
        bool Down;
        int Speed = 1;
        int BallX = 5;
        int BallY = -6;
        int ScorePlayer = 0;
        int fail = 0;
        public void mePlay()
        {
            score.Text = "" + ScorePlayer;
            
            Ball.Top -= BallY;
            Ball.Left -= BallX;
           

            if (Ball.Left < 0)
            {
                Ball.Left = 400;
                BallX = -BallX;
                BallX -= 2;
               
            }

            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Left = 400;
                BallX = -BallX;
                BallX += 2;
                fail++;
            }

            if (Ball.Top < 0 || Ball.Top + Ball.Height > ClientSize.Height)
            {
                BallY = -BallY;

            }

            if (Ball.Bounds.IntersectsWith(Player.Bounds) )
            {
                BallX = -BallX;
                ScorePlayer++;

            }

            if (Up == true && Player.Top > 0)
            {
                Player.Top -= 10;
            }

            if (Down == true && Player.Top < 400)
            {
                Player.Top += 10;
            }

            if( fail == 3)
            {
                timer1.Stop();
                MessageBox.Show("\tGAME OVER\t");

                fInfoPlayer f0 = new fInfoPlayer();
                this.Hide();
                f0.Show();


            }
        }

        public fGameSingle()
        {
            InitializeComponent();
            timer1.Enabled = true;
            KeyPreview = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            fOption f2 = new fOption();
            this.Hide();
            f2.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SoundOn_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void SoundOff_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mePlay();
        }

     

        private void meMove(object sender, KeyEventArgs e)
        {
            int x = Player.Location.X;
            int y = Player.Location.Y;

            if (e.KeyCode == Keys.E) x += 5;
            else if (e.KeyCode == Keys.A) x -= 5;
            else if (e.KeyCode == Keys.W) y -= 5;
            else if (e.KeyCode == Keys.S) y += 5;

            Player.Location = new Point(x, y);
        }
    }
}
