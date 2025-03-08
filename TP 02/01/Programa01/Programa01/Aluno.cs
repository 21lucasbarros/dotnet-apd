using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    public class Aluno
    {
        private String p1;
        private String p2;
        private String p3;
        private String p4;

        public String P1
        {
            get { return p1; }
            set { p1 = value; }
        }
        public String P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        public String P3
        {
            get { return p3; }
            set { p3 = value; }
        }
        public String P4
        {
            get { return p4; }
            set { p4 = value; }
        }

        public String MediaAritmetica()
        {
            return ((float.Parse(p1) + float.Parse(p2) + float.Parse(p3) + float.Parse(p4)) / 4).ToString();
        }
    }
}
