using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03
{
    public class Funcionario
    {
        private string Nome;
        private string Horas;
        private string ValorHora;
        public string NomeFuncionario
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string HorasTrabalhadas
        {
            get { return Horas; }
            set { Horas = value; }
        }
        public string ValorHorasTrabalhadas
        {
            get { return ValorHora;}
            set { ValorHora = value; }
        }

        public float Bruto ()
        {
            return (float.Parse(Horas) * float.Parse(ValorHora));
        }

    }
}
