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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
            {
                Con.Open();
                string query = "DELETE  FROM Client WHERE ID='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();
                this.Close();

            }
        }
    }
}


    

