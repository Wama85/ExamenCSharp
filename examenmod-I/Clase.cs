using examenmod_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figura
{
    public class figurageometrica

    {
        private double ladoa;
        private double ladob;
       
        public double Ladob { get;set; }
        public double Ladoa { get;set; }

        public double areas(double x, double y)
        { double totalarea = x * y;
          return totalarea;
        }
        
        public double areatriangulo(double x, double y)
        {
            double totalarea = (x * y)/2;
            return totalarea;
        }
       





    }
    
   
}
