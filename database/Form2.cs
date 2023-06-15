using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahas\OneDrive\Desktop\database\database\db.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display_data();
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from[Table]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Table] where registration_number='" + int.Parse(textBox1.Text) + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch
            {
                MessageBox.Show("Enter the Registration number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

         private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Confirm Delete Yes/No ","info",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dialogresult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Table] where registration_number='" + int.Parse(textBox1.Text) + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("data deleted", "delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

            }
            
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Table] set student_name='" + textBox4.Text + "',contact_number='" + textBox5.Text + "'where registration_number='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data updated", "update", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 info = new Form1();
            info.Visible = true;
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
