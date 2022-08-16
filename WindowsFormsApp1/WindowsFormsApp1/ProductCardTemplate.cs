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
    public partial class ProductCardTemplate : UserControl
    {
        private int _pId;

        public int pId { 
            get { return _pId; }
            set { _pId = value; CardId.Text = value.ToString(); }
        }
        
        private string _pDate;

        public string pDate
        {
            get { return _pDate; }
            set { _pDate = value; CardDate.Text = value.ToString(); }
        }

        private int _pInv;

        public int pInv
        {
            get { return _pInv; }
            set { _pInv = value; CardInv.Text = value.ToString(); }
        }

        private string _pObj;

        public string pObj
        {
            get { return _pObj; }
            set { _pObj = value; CardObj.Text = value.ToString(); }
        }

        private int _pCount;

        public int pCount
        {
            get { return _pCount; }
            set { _pCount = value; CardCount.Text = value.ToString(); }
        }
        
        private float _pPrice;
        public float pPrice
        {
            get { return _pPrice; }
            set { _pPrice = value; CardPrice.Text = value.ToString(); }
        }



        public ProductCardTemplate()
        {
            InitializeComponent();
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void prodName_Click(object sender, EventArgs e)
        {

        }

        private void ProductCardTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
