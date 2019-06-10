using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PingPongGame
{
    public partial class fInfoPlayer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AP258QF\NGALT;Initial Catalog=PLAYER;Integrated Security=True");
       
        public fInfoPlayer()
        {
            InitializeComponent();
            timer1.Start();
        }

       

        // ghi thông tin người chơi vào database
        private void FillDatabase()
        {
            con.Open(); // mở kết nối
            string Value1 = tID.Text;
            string Value2 = tName.Text;
            string Value3 = tScore.Text;
            string Value4 = tGame.Text;
            string Value5 = label.Text;

            string qry0 = "insert into Info values('" + Value1 + "','" + Value2 + "','" + Value5 +" ')";
            string qry1 = "insert into A1 values('" + Value1 + "','" + Value3 + "','" + tTime.Text + "','" + Value4 + "')";



           SqlCommand cmd0 = new SqlCommand(qry0, con);
           SqlCommand cmd1 = new SqlCommand(qry1, con);
          

           cmd0.ExecuteNonQuery();
           cmd1.ExecuteNonQuery();
          

            con.Close(); // đóng kết nối 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FillDatabase();
            MessageBox.Show("Recored!");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            fOption f1 = new fOption();
            this.Hide();
            f1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtime = DateTime.Now;
            this.tTime.Text = dtime.ToString() ;

        }
    }
}
