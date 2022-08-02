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
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
            Search S = new Search();
            S.MdiParent = this;
            S.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Hide();
            Form1 dis = new Form1("");           
            dis.MdiParent = this;           
            dis.Show();
        }
    }
}
