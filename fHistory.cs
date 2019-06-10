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
    public partial class fHistory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AP258QF\NGALT;Initial Catalog=PLAYER;Integrated Security=True");
        public fHistory()
        {
            InitializeComponent();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            fOption f1 = new fOption();
            this.Hide();
            f1.Show();
        }

        private void ConnectDatabase()
        {
            con.Open(); // mở kết nối
            string Sql = "select h.ID , h.Name, t.Time from Info as h join A1 as t on t.ID = h.ID";
            SqlCommand com = new SqlCommand(Sql, con); // bắt đầu truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); // vận chuyển dữ liệu về
            DataTable dt = new DataTable(); // tạo kho ảo để lưu trữ dữ liệu
            da.Fill(dt); // đổ dữ liệu vào kho 
            con.Close(); // đóng kết nối 

            txtHistory.DataSource = dt; // đổ dữ liệu vào datagidview
        }

        private void clHistory_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        private void DeleteHistory()
        {
            con.Open();
            string Sql = "UPDATE A1 SET Time = Null" ;
            SqlCommand com = new SqlCommand(Sql, con); // bắt đầu truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); // vận chuyển dữ liệu về
            DataTable dt = new DataTable(); // tạo kho ảo để lưu trữ dữ liệu
            da.Fill(dt); // đổ dữ liệu vào kho 
            con.Close(); // đóng kết nối 

            MessageBox.Show("Cleaned!");
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            DeleteHistory();
            ConnectDatabase();
        }
    }
}
