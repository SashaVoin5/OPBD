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
    public partial class DeleteEmployeesForm : Form
    {
        public DeleteEmployeesForm()
        {
            InitializeComponent();

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VEED6NM\SQLEXPRESS;Initial Catalog=Language-115;Integrated Security=True"))
            {
                Con.Open();
                string query = "DELETE  FROM Client WHERE ID='" + txt_Delete.Text + "'";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();
                this.Close();

            }
        }

            
      

       
    }
}
