using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP2
{
    class EqSegundoGrauBLL
    {
        public static void validaDados(EqSegundoGrau eqSegundoGrau)
        {
            Erro.setErro(false);
            if (eqSegundoGrau.geta().Length == 0)
            {
                Erro.setErro("O campo 1 é preenchimento obrigatório...");
                return;

            }
            if (eqSegundoGrau.getb().Length == 0)
            {
                Erro.setErro("O campo 2 é preenchimento obrigatório...");
                return;
            }
            if (eqSegundoGrau.getc().Length == 0)
            {
                Erro.setErro("O campo 3 é preenchimento obrigatório...");
                return;
            }
            try
            {
                float.Parse(eqSegundoGrau.geta());
            }
            catch
            {
                Erro.setErro("O campo 1 deve ser numérico...");
                return;
            }
            try
            {
                float.Parse(eqSegundoGrau.getb());
            }
            catch
            {
                Erro.setErro("O campo 2  deve ser numérico...");
                return;
            }
            try
            {
                float.Parse(eqSegundoGrau.getc());
            }
            catch
            {
                Erro.setErro("O campo 3 deve ser numérico...");
                return;
            }
            if (float.Parse(eqSegundoGrau.calcdelta()) < 0)
            {
                Erro.setErro("Não Haverá Raizes");
            }

        }
    }
}
