using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquacaoSegundoGrau
{
    class EquacaoBLL
    {
        public static void validaDados(Equacao _umaequacao)
        {
            Erro.setErro(false);
            if (_umaequacao.getA().Length == 0)
            {
                Erro.setErro("O valor de A é obrigatório.");
                return;
            }
            else
            {
                try 
                {
                    float.Parse(_umaequacao.getA());
                }
                catch
                {
                    Erro.setErro("O valor de A deve ser numérico!");
                    return;
                }
            }

            if (_umaequacao.getB().Length == 0)
            {
                Erro.setErro("O valor de B é obrigatório.");
                return;
            }
            else
            {
                try
                {
                    float.Parse(_umaequacao.getB());
                }
                catch
                {
                    Erro.setErro("O valor de B deve ser numérico!");
                    return;
                }
            }

            if (_umaequacao.getC().Length == 0)
            {
                Erro.setErro("O valor de C é obrigatório.");
                return;
            }
            else
            {
                try
                {
                    float.Parse(_umaequacao.getC());
                }
                catch
                {
                    Erro.setErro("O valor de C deve ser numérico!");
                    return;
                }
            }

            if (float.Parse(_umaequacao.calcDelta()) < 0)
            {
                Erro.setErro("Delta Negativo! Não existem raízes reias.");
                return;
            }

        }
    }
}
