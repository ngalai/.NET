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
    public partial class fResult : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AP258QF\NGALT;Initial Catalog=PLAYER;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public fResult()
        {
            InitializeComponent();
            DisplayData();
            
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

        private void clResult_Load(object sender, EventArgs e)
        {
           
        }

        private void dHightScore_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Info.Name, A1.Score, A1.Type , Info.Sex FROM Info JOIN A1 ON A1.ID = Info.ID and A1.Score in (select distinct top 3 Score from A1 order by Score desc)", con);
            adapt.Fill(dt);
            dHightScore.DataSource = dt;
            con.Close();
        }

    }
}
        
