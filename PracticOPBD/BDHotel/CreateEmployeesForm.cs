using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDHotel
{
    public partial class CreateEmployeesForm : Form
    {
        public CreateEmployeesForm()
        {
            InitializeComponent();
           
        }

        private void CreateEmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = (Form1)Application.OpenForms[0];
            form.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
            {
                if (txt_FName.Text == "")
                {
                    Con.Open();
                    string sql = string.Format("Update Client Set LastName = '{0}' Where ID = '{1}'",
                txt_LName.Text, txt_ID.Text);
                    using (SqlCommand command = new SqlCommand(sql, Con))
                    {
                        command.ExecuteNonQuery();
                        Con.Close();
                        this.Close();
                    }
                }
                if (txt_LName.Text == "")
                {
                    Con.Open();
                    string sql = string.Format("Update Client Set FirstName = '{0}' Where ID = '{1}'",
                txt_FName.Text, txt_ID.Text);
                    using (SqlCommand command = new SqlCommand(sql, Con))
                    {
                        command.ExecuteNonQuery();
                        Con.Close();
                        this.Close();
                    }
                }
                
                

                Con.Open();
                string sql1 = string.Format("Update Client Set LastName = '{0}',FirstName = '{1}' Where ID = '{2}'",
            txt_LName.Text, txt_FName.Text, txt_ID.Text);
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
    }
}
