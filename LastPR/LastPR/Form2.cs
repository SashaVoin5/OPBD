using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace LastPR
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(LName.Text) || string.IsNullOrEmpty(FName.Text))
            {
                labelError.Text = "Заполните фамилию и имя";
                labelError.Visible = true;
            }
            else
            {
                if (dateTimePicker1.Value > DateTime.Now)
                {
                    labelError.Text = "Дата рождения должна быть реальной";
                    labelError.Visible = true;
                }
                else 
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
                    {
                        Con.Open();
                        string query = "INSERT INTO Client (FirstName, LastName, Patronymic, [Birthday], RegistrationDate, Email, Phone, GenderCode) VALUES " +
                              "('" + FName.Text + "', '" + LName.Text + "', '" + MName.Text + "', '" +
                              dateTimePicker1.Value + "','"+ dateTimePicker2.Value +"', '"+ txt_email.Text+"','" + textPhone.Text + "', " + comboBox1.SelectedValue + ")";
                        SqlCommand command = new SqlCommand(query, Con);
                        command.ExecuteNonQuery();

                        Con.Close();
                        this.Close();
                       // string query = "INSERT INTO [Client] ([FirstName],[LastName],[Patronymic],[Birthday],[RegistrationDate],[Email],[Phone],[GenderCode]) VALUES (" + txt_FName.Text + ",'" + txt_LName.Text + "','" + txt_MName.Text + "','" + dateTimePicker + "','" + dateTimePicker1 + "','" + txt_Email.Text + "','" + txt_Tel.Text + "'," + txt_Gender.Text + ")";
                    }
                }
            }

        }

       

    }

}
      


