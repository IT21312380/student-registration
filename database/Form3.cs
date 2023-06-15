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
    public partial class Form3 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahas\OneDrive\Desktop\homepage\homedata.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "select * from [Table]where username='" + textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";


            SqlDataAdapter sda = new SqlDataAdapter(querry, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Form1 obj = new Form1();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("wrong username or password", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
