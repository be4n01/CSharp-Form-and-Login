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

namespace WindowsFormsApp1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var pro = Filler.findOne(textBox1.Text);
            if (pro == null)
            {
                MessageBox.Show("Not Available!");
            }
            else
            {
                //Project.findOne(pro.Obj_name);
                MessageBox.Show("Available");
            }
        }
    }
}
