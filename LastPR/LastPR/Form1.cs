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

namespace LastPR
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            
            InitializeComponent();
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
            {
                Con.Open();
                string query = $"SELECT " +
                                "C.ID, " +
                                "[Фамилия] = C.[LastName], " +
                                "[Имя] = C.[FirstName], " +
                                "[Отчество] = [Patronymic], " +
                                "[Пол] = G.[Name], " +
                                "[Телефона] = C.[Phone], " +
                                "[Email] = C.[Email], " +
                                "[Дата рождения] = C.[Birthday], " +
                                "[Дата регестрации] = CS.[StartTime] " +
                                "FROM [Gender] AS G " +
                                "JOIN [Client] AS C ON C.GenderCode = G.Code " +
                                "JOIN [ClientService] AS CS ON CS.ClientID = C.ID " +
                                "JOIN [Service] AS S ON CS.ServiceID = S.ID  " +
                                $" " +
                                $"";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                
                dt.Load(reader);
                Con.Close();

                if (dt.Rows.Count != 0)
                {
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Update();
                   
                }
                else
                {
                    dataGridView1.Visible = false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }

        
    
}
