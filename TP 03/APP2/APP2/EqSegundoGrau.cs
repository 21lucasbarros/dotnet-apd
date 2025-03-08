using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP2
{
    internal class EqSegundoGrau
    {
        private string a;
        private string b;
        private string c;

        public void seta(string _a) { a = _a; }
        public String geta() { return a; }
        public void setb(string _b) { b = _b; }
        public String getb() { return b; }
        public void setc(string _c) { c= _c; }
        public String getc() { return c; }

        public string calcdelta()
        {
            double delta;
            delta = (float.Parse(b) * float.Parse(b)) - (4 * float.Parse(a) * float.Parse(c));
            return delta.ToString();
        }
     public string calcx1()
        {
            double delta = float.Parse(calcdelta());
           
            float aValue = float.Parse(a);
            float bValue = float.Parse(b);

            double x1 = (-bValue + Math.Sqrt(delta)) / (2 * aValue);
            return x1.ToString();
        }

        public string calcx2()
        {
            double delta = float.Parse(calcdelta());

         
            float aValue = float.Parse(a);
            float bValue = float.Parse(b);

           
            double x2 = (-bValue - Math.Sqrt(delta)) / (2 * aValue);
            return x2.ToString();
        }

    }
}
