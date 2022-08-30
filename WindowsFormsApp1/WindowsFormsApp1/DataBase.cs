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

namespace WindowsFormsApp1
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void DataBase_Load(object sender, EventArgs e)
        {

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
                SqlConnection c = new SqlConnection(connectionstring);
                c.Open();
                MessageBox.Show("Connected");
           }
            catch
            {
                MessageBox.Show("Not Connected");
            };
    }

        private void InsBtn_Click(object sender, EventArgs e)
        {
           
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
                SqlConnection c = new SqlConnection(connectionstring);
                c.Open();

            
            string Query = "insert into Product values(1,'2018-11-1',1,'Shoe',1,59.00)";
                SqlCommand com = new SqlCommand(Query, c);

                var res = com.ExecuteNonQuery();

                
                
                
            
            
            
        }

        private void DisBtn_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
            SqlConnection c = new SqlConnection(connectionstring);
            c.Open();

            string Query = "select * from product";            
            SqlCommand com = new SqlCommand(Query, c);

            

            var res = com.ExecuteReader();
            while (res.Read())
            {
                MessageBox.Show(res["object"].ToString());
            }
        }
    }
}
