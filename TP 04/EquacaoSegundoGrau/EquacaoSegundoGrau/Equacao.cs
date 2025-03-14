using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquacaoSegundoGrau
{
    class Equacao
    {
        private String a;
        private String b;
        private String c;

        public void setA(String _a) { a = _a; }
        public void setB(String _b) { b = _b; }
        public void setC(String _c) { c = _c; }
        public String getA() { return a; }
        public String getB() { return b; }
        public String getC() { return c; }

        public String calcDelta()
        {
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            float _c = float.Parse(c);

            return (_b * _b - 4 * _a * _c).ToString();
        }

        public String calcX1()
        {
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            float _d = float.Parse(calcDelta());

            return ((-_b + Math.Sqrt(_d))/(2*_a)).ToString();
        }

        public String calcX2()
        {
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            float _d = float.Parse(calcDelta());

            return ((-_b - Math.Sqrt(_d)) / (2 * _a)).ToString();
        }

    }
}
