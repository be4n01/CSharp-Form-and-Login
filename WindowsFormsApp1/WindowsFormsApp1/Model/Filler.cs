using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model
{
    class Filler
    {
       static private List<Filler> fill = new List<Filler>();
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
        }

        static public List<Filler> GetAllProducts()
        {
            return fill;
        }

        public static Filler findOne(string name)
        {
            return fill.Find(fill => fill.Object == name);
        }

    }
}
