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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            foreach (var item in Filler.GetAllProducts())
            {
                ProductCardTemplate p = new ProductCardTemplate();
                p.pId = item.Id;
                p.pDate = item.Date;
                p.pInv = item.Invent;
                p.pObj = item.Object;
                p.pPrice = item.Price;
                p.pCount = item.Count;
                flowLayoutPanel1.Controls.Add(p);
            }
        }
    }
}
