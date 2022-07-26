using WindowsFormsApp1.Model;
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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(Fid.Text))
            {
                ep.SetError(Fid, "Number is required");
            }
            else if (string.IsNullOrEmpty(Finvent.Text))
            {
                ep.SetError(Finvent, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(Fobj.Text))
            {
                ep.SetError(Fobj, "Object name is required");
            }
            else if (string.IsNullOrEmpty(Fcount.Text))
            {
                ep.SetError(Fcount, "Count is required");
            }
            else if (string.IsNullOrEmpty(Fprice.Text))
            {
                ep.SetError(Fprice, "Price is required");
            }
            else if (!r.IsMatch(Fobj.Text))
            {
                ep.SetError(Fobj, "String should not have numbers.");
            }
            else
            {
                try
                {
                    Filler F = new Filler
                    {
                        Id = int.Parse(Fid.Text),
                        Date = dateTimePicker1.Text,
                        Invent = int.Parse(Finvent.Text),
                        Object = dateTimePicker1.Text,
                        Count = int.Parse(Fcount.Text),
                        Price = float.Parse(Fprice.Text)
                    };
                    F.Saved();
                    Grid.DataSource = null;
                    Grid.DataSource = Filler.GetAllProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
            }
        }
    }
}
