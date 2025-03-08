using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    public class AlunoBLL
    {
        public static void validaDados(Aluno aluno)
        {
            Erro.setErro(false);
            if (aluno.P1.ToString().Length == 0)
            {
                Erro.setErro("O campo NOTA 1 é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(aluno.P1.ToString());
                }
                catch
                {
                    Erro.setErro("O campo Nota 1 deve ser numérico...");
                    return;
                }
                if (float.Parse(aluno.P1) <= 0)
                {
                    Erro.setErro("O campo P1 deve ser maior que zero.");
                    return;
                }
                if (float.Parse(aluno.P1) > 10)
                {
                    Erro.setErro("O campo P1 deve ser menor que 10");
                    return;
                }

                Erro.setErro(false);
                if (aluno.P2.ToString().Length == 0)
                {
                    Erro.setErro("O campo NOTA 2 é de preenchimento obrigatório...");
                    return;
                }
                else
                {
                    try
                    {
                        float.Parse(aluno.P2.ToString());
                    }
                    catch
                    {
                        Erro.setErro("O campo Nota 2 deve ser numérico...");
                        return;
                    }
                    if (float.Parse(aluno.P2) <= 0)
                    {
                        Erro.setErro("O campo P2 deve ser maior que zero.");
                        return;
                    }
                    if (float.Parse(aluno.P2) > 10)
                    {
                        Erro.setErro("O campo P2 deve ser menor que 10");
                        return;
                    }
                }

                Erro.setErro(false);
                if (aluno.P3.ToString().Length == 0)
                {
                    Erro.setErro("O campo NOTA 3 é de preenchimento obrigatório...");
                    return;
                }
                else
                {
                    try
                    {
                        float.Parse(aluno.P3.ToString());
                    }
                    catch
                    {
                        Erro.setErro("O campo Nota 3 deve ser numérico...");
                        return;
                    }
                    if (float.Parse(aluno.P3) <= 0)
                    {
                        Erro.setErro("O campo P3 deve ser maior que zero.");
                        return;
                    }
                    if (float.Parse(aluno.P3) > 10)
                    {
                        Erro.setErro("O campo P3 deve ser menor que 10");
                        return;
                    }
                }

                Erro.setErro(false);
                if (aluno.P4.ToString().Length == 0)
                {
                    Erro.setErro("O campo NOTA 4 é de preenchimento obrigatório...");
                    return;
                }
                else
                {
                    try
                    {
                        float.Parse(aluno.P4.ToString());
                    }
                    catch
                    {
                        Erro.setErro("O campo Nota 4 deve ser numérico...");
                        return;
                    }
                    if (float.Parse(aluno.P4) <= 0)
                    {
                        Erro.setErro("O campo P4 deve ser maior que zero.");
                        return;
                    }
                    if (float.Parse(aluno.P4) > 10)
                    {
                        Erro.setErro("O campo P4 deve ser menor que 10");
                        return;
                    }
                }
            }
        }
    }
}
