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
namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahas\OneDrive\Desktop\database\database\db.mdf;Integrated Security=True;Connect Timeout=30");
        string gen;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == ""||textBox1.Text==""||radioButton1.Checked==false&&radioButton2.Checked==false)
                {
                    MessageBox.Show("Complete the Missing Data", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {
                if (radioButton1.Checked)
                {
                    gen = "m";
                }
                else
                {
                    gen = "f";
                }

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Table] values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + gen + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();


                if (int.Parse(textBox3.Text) < 18)
                {

                    MessageBox.Show("Cannot Enroll – Below 18 years", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


                MessageBox.Show("Student Inserted Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }         

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox3.Text) > 18)
                {
                    MessageBox.Show("age limit exceeded", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Cannot Enroll – Below 18 years", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        dateTimePicker1.Text = "";
                        textBox3.Text = "";
                    }

                }
            }
            catch 
            {
                MessageBox.Show("invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

            DateTime b_day = dateTimePicker1.Value;
            DateTime p_date = DateTime.Now;
            TimeSpan age = p_date - b_day;

            double days = age.TotalDays;
            textBox3.Text = (days / 365).ToString("0");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 next = new Form2();
            next.Visible = true;
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox4.Text = "";
            comboBox1.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("data cleared", "clear", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
                
                }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int coursefee = 0;
                int finalfee = 0;
                int dis = 0;
                coursefee = int.Parse(textBox6.Text);
                dis = int.Parse(textBox7.Text);

                finalfee = coursefee - (coursefee * dis / 100);

                textBox5.Text = (finalfee).ToString("0");

            }
            catch
            {
                MessageBox.Show("invalid input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
