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
    public partial class AddEmployeesForm : Form
    {
        public int idmax;
        
        public AddEmployeesForm()
        {
            InitializeComponent();
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
            {
                Con.Open();
                string query = "SELECT [ID] = Code, [Name] = Name  FROM Gender as G ";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Name";



                Con.Close();
            }
           
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_LName.Text))
            {
                MessageBox.Show("Заполните фамилию!");
            }
            else
            {
                if (string.IsNullOrEmpty(txt_FName.Text))
                {
                    MessageBox.Show("Заполните имя!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_Email.Text))
                    {
                        MessageBox.Show("Введите Email!");
                    }
                                            
                        else
                        {
                            if (string.IsNullOrEmpty(txt_Tel.Text))
                            {
                                MessageBox.Show("Заполните номер телефона!");
                            }
                            else
                            {
                                if (dateTimePicker.Value > DateTime.Now)
                                {
                                    MessageBox.Show("Введите реальную дату рождения!");
                                }
                                else
                                {
                                    using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
                                    {
                                    Con.Open();
                                    string query = "INSERT INTO Client (FirstName, LastName, Patronymic, [Birthday], RegistrationDate, Email, Phone, GenderCode) VALUES " +
                                          "('" + txt_FName.Text + "', '" + txt_LName.Text + "', '" + txt_MName.Text + "', '" +
                                          dateTimePicker.Value + "','" + dateTimePicker1.Value + "', '" + txt_Email.Text + "','" + txt_Tel.Text + "', " + comboBox1.SelectedValue + ")";
                                    SqlCommand command = new SqlCommand(query, Con);
                                    command.ExecuteNonQuery();
                                    
                                        Con.Close();
                                        this.Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

       
    }

