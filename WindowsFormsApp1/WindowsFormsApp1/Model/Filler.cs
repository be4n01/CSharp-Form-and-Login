using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1.Model
{
    class Filler
    {
       static private List<Filler> fill = new List<Filler>();
       static private List<Filler> database = new List<Filler>();
        public int Id  {get; set;}
       public string Date { get; set; }
       public int Invent {get; set;}
       public string Object {get; set;}
       public int Count { get; set; }
       public float Price { get; set; } 
       public bool Check { get; set; }

       public void Saved()
        {
            fill.Add(this);

            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "insert into Product values('" + this.Id + "', '" + this.Date + "', " +
                    "'" + this.Invent + "', '" + this.Object +
                    "', '" + this.Count + "', '" + this.Price + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public List<Filler> GetAllProducts()
        {
            

            List<Filler> fills = new List<Filler>();
            try
            {

                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = db; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Select * from Product";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Filler p = new Filler();
                    p.Id = (int)sdr["Number"];
                    p.Date = (string)sdr["Date"];
                    p.Invent = (int)sdr["Inventory_Number"];
                    p.Object = (string)sdr["Object_Name"];
                    p.Count = (int)sdr["Count"];
                    p.Price = (float)sdr["Price"];
                    fills.Add(p);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return fills;
        }

        public static Filler findOne(string name)
        {
            return fill.Find(fill => fill.Object == name);
        }

    }
}
