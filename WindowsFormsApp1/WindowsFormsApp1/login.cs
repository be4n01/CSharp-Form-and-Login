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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {

            Start l = new Start
            {
                user = tbuser.Text,
                password = tbpass.Text
            };
            


                

                if((l.user == "Admin" && l.password == "Admin") || (l.user == "User" && l.password == "User"))
            {
                
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                
            }
            l.user = l.user;
                
            
           
            
        }
    }
}
