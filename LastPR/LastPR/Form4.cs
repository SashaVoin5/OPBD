using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LastPR
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
            {
                if (textBox3.Text == "")
                {
                    Con.Open();
                    string sql = string.Format("Update Client Set LastName = '{0}' Where ID = '{1}'",
                textBox2.Text, textBox1.Text);
                    using (SqlCommand command = new SqlCommand(sql, Con))
                    {
                        command.ExecuteNonQuery();
                        Con.Close();
                        this.Close();
                    }
                }
                if (textBox2.Text == "")
                {
                    Con.Open();
                    string sql = string.Format("Update Client Set FirstName = '{0}' Where ID = '{1}'",
                textBox3.Text, textBox1.Text);
                    using (SqlCommand command = new SqlCommand(sql, Con))
                    {
                        command.ExecuteNonQuery();
                        Con.Close();
                        this.Close();
                    }
                }

                Con.Open();
                    string sql1 = string.Format("Update Client Set LastName = '{0}',FirstName = '{1}' Where ID = '{2}'",
                textBox2.Text, textBox3.Text,textBox1.Text);
                    using (SqlCommand command = new SqlCommand(sql1, Con))
                    {
                        command.ExecuteNonQuery();
                        Con.Close();
                        this.Close();
                    }
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
