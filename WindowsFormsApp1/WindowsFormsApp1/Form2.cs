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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void DataUpd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "update Product set date='" + DataDate.Text + "',inventory='" + Datainvent.Text
                    + "',object='" + Dataobj.Text + "',count='" + Datacount.Text
                    + "',price='" + Dataprice.Text + "' where id = '" + Dataid.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show("Update successful");                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataDel_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "delete from Product where id = '" + Dataid.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show("Deletion successful");                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "insert into Product values(" + Dataid.Text + "," + DataDate.Text + "," + Datainvent.Text + "," + Dataobj.Text + "," + Datacount.Text + "," + Dataprice.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion successful");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
