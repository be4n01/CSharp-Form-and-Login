using Form1.Model
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();
            ep.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(Fid.Text))
            {
                ep.SetError(Fid, "Number is required");
            }

            else if (string.IsNullOrEmpty(Fdate.Text))
            {
                ep.SetError(Fdate, "Number is required");
            }

            else if (string.IsNullOrEmpty(Finvnum.Text))
            {
                ep.SetError(Finvnum, "Number is required");
            }

            else if (string.IsNullOrEmpty(Fobjname.Text))
            {
                ep.SetError(Fobjname, "Number is required");
            }

            else if (string.IsNullOrEmpty(Fcount.Text))
            {
                ep.SetError(Fcount, "Number is required");
            }

            else if (string.IsNullOrEmpty(Fprice.Text))
            {
                ep.SetError(Fprice, "Number is required");
            }

            else if (!r.IsMatch(Fobjname.Text))
            {
                ep.SetError(Fobjname, "Object can't be a number");
            }

            else
            {
                try
                {
                    Filler F = new Filler
                    {
                        Id = int.Parse(Fid.Text),
                        Date = Fdate.Text,
                        InvNum = int.Parse(Finvnum.Text),
                        ObjName = Fobjname.Text,
                        Count = int.Parse(Fcount.Text),
                        Price = int.Parse(Fprice.Text)

                    };
                    F.save();
                    Grid.DataSource = null;
                    Grid.DataSource = Filler.GetAllProducts();
                }
                    
                    
                catch(Exception)
                {
                    MessageBox.Show("Mismatch");
                };


            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
