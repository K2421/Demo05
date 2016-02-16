using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Biisi
    {
        public string Songname { get; set; }
        public string Time { get; set; }
       

   
        public override string ToString()
        {
            return "   - " + Songname + " - " + Time;
        }
    }
}