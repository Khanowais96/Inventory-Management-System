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
using System.IO;

namespace Project
{
    public partial class Form2 : MaterialForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
         public static string conStr;
        

        public Form2()
        {
            conStr = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new SqlConnection(conStr);

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

 
        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("select * from Customer ", con);
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
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();


            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            if (id.Text == "" || name.Text == "" || fname.Text == "" || gen.Text.ToString() == "" || cnic.Text.ToString() == "" || contact.Text == "" || email.Text == "")
            {
                MessageBox.Show("Please Fill All Fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

   
            else
            {
                con.Open();
                string query = "insert into Customer values('" + this.id.Text + "','" + this.name.Text + "','" + this.fname.Text + "','"+this.gen.SelectedItem.ToString()+"','" + this.cnic.Text.ToString() + "','" + this.email.Text + "','" + this.contact.Text + "')";
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
            fname.Text = "";
            gen.Text = "";
            cnic.Text = "";
            contact.Text = "";
            email.Text = "";

        }

        void show()
        {
            SqlDataAdapter adap = new SqlDataAdapter("select * from Customer", con);
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
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
         

            }
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch!=8 )
            {
                e.Handled = true;
            }
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE  from Customer where Cust_ID='" + id.Text + "'";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            con.Close();
            clear();
            show();
            MessageBox.Show("Selected Record Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
          


            con.Open();

            string query = "update Customer set Cust_ID='" + id.Text + "', Name='" + name.Text.ToString() + "',FatherName ='" + fname.Text.ToString() + "', gender='" + gen.SelectedItem.ToString() + "'  ,Cnic='" + cnic.Text + "',Email='" + email.Text + "', Contact='" + contact.Text + "' where Cust_ID='" + id.Text + "'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();

            show();

        }

       

       

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            gen.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cnic.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            email.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            contact.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
          
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            gen.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cnic.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            email.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            contact.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
            
            
        }

        private void contact_Click(object sender, EventArgs e)
        {

        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Close();
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
