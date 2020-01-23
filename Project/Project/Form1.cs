using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Configuration;
using System.Data.SqlClient;

namespace Project
{

  

    public partial class Form1 : MaterialForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;

        public static string conStr;

        public Form1()
        {
            conStr = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new SqlConnection(conStr);

            InitializeComponent();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //SELECT COUNT(*) FROM login WHERE username = '"+ textBox1.Text +"' AND password = '"+ textBox2.Text +"'
            con.Open();
            string query = "select COUNT(*) from adminlogin where Username='"+txtuser.Text+"'AND Password='"+txtpass.Text+"'";
            adap = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form3 obj = new Form3();
                obj.Show();
            }
            else
                MessageBox.Show("Invalid username or password");

            con.Close();

        }
    }
}
