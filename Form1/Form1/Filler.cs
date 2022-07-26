using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Model
{
    class Filler
    {
        static private List<Filler> Fill = new List<Filler>();
        public int Id { get; set; }
        public string Date { get; set; }
        public int InvNum { get; set; }
        public string ObjName { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }

        public void save()
        {
            Fill.Add(this);
        }

        static public List<Filler> GetAllProducts()
        {
            return Fill;
        }


    }
}
