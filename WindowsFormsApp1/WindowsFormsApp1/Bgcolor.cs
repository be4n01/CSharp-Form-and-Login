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
    public partial class Bgcolor : Form
    {
        public Bgcolor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            panel3.Location = new Point(43, 94);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BackColor= Color.Green;
            panel3.Location = new Point(35, 110);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.BackColor=Color.Blue;
            panel3.Location = new Point(35, 140);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Peru;
            panel3.Location = new Point(43, 219);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void productCardTemplate1_Load(object sender, EventArgs e)
        {

        }
    }
}
