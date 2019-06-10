using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class fOption : Form
    {
        public fOption()
        {
            InitializeComponent();
        }
      
        private void Play_Click(object sender, EventArgs e)
        {
            if (cTypeGame.Text == "one player")
            {
                fGameSingle f1 = new fGameSingle();
                this.Hide();
                f1.Show();
            }

            else if (cTypeGame.Text == "two player")
            {
                fGameCouple f2 = new fGameCouple();
                this.Hide();
                f2.Show();
            }
          
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clGiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void Guide_Click(object sender, EventArgs e)
        {
            const string message =
        "Hướng Dẫn Người Chơi : \n\n"+
        "Sử dụng các phím A, E, S, W lần lượt để di chuyển người chơi \n" +
        "lên trên , xuống dưới , sang trái , sang phải.\n" +
        "Hãy cố gắng di chuyển để bóng không đi đến cuối sân bóng phía bạn.";

            MessageBox.Show(message);
        }

        private void HightScore_Click(object sender, EventArgs e)
        {
            fResult f3 = new fResult();
            this.Hide();
            f3.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            fHistory f4 = new fHistory();
            this.Hide();
            f4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
