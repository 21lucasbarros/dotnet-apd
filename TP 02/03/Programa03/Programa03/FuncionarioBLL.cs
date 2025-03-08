using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03
{
    public class FuncionarioBLL
    {
        public static void validaDados(Funcionario funcionario)
        {
            Erro.setErro(false);
            if (funcionario.NomeFuncionario.Length == 0)
            {
                Erro.setErro("O campo Nome é preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(funcionario.HorasTrabalhadas.ToString());
                }
                catch
                {
                    Erro.setErro("O campo Horas deve ser númerico...");
                    return;
                }
                if (float.Parse(funcionario.HorasTrabalhadas) < 0)
                {
                    Erro.setErro("O campo Horas deve ser maior que zero");
                    return;
                }

                try
                {
                    float.Parse(funcionario.ValorHorasTrabalhadas.ToString());
                }
                catch
                {
                    Erro.setErro("O campo Valor por hora deve ser númerico...");
                    return;
                }
                if (float.Parse(funcionario.ValorHorasTrabalhadas) < 0) ;
                {
                    Erro.setErro("O campo Valor por hora deve ser maior que zero");
                    return;
                }
            }
        }
    }
}
