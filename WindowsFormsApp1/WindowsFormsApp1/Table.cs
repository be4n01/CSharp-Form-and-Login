using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Table : Form
    {

        public Table(int id, string date, int inv, string obj, int c,float p)
        {
            InitializeComponent();
            label2.Text = id.ToString();
            label4.Text = date;  
            label6.Text = inv.ToString();
            label8.Text = obj;   
            label10.Text = c.ToString();
            label12.Text = p.ToString();
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }
    }
}
