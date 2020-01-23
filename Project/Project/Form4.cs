using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : MaterialForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        public static string conStr;
        public Form4()
        {
            conStr = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new SqlConnection(conStr);

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("select * from Product ", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();



            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || qty.Text == "" ||  pprice.Text == "" || sprice.Text == "")
            {
                MessageBox.Show("Please Fill All Fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                con.Open();
                string query = "insert into Product values('" + this.id.Text + "','" + this.name.Text + "','" + this.qty.Text + "','" + this.pprice.Text + "','" + this.sprice.Text + "','"+this.ctg.Text+"')";
                cmd = new SqlCommand(query, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                show();
                MessageBox.Show("New Record Inserted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        void clear()
        {

            id.Text = "";
            name.Text = "";
            qty.Text = "";
            pprice.Text = "";
            sprice.Text = "";
            ctg.Text = "";
        

        }

        void show()
        {
            SqlDataAdapter adap = new SqlDataAdapter("select * from Product", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();



            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE  from Product where ProdID='" + id.Text + "'";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();
            clear();
            show();
            MessageBox.Show("Selected Record Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update Product set ProdID='" + id.Text + "',Name='" + name.Text + "',Quantity ='" + qty.Text + "' ,Price='" + pprice.Text.ToString() + "', SalePrice='" + sprice.Text + "',Category='"+ctg.Text+"' where ProdID='" + id.Text + "'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();

            show();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            qty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pprice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            sprice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ctg.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            qty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pprice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            sprice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ctg.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Close();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
