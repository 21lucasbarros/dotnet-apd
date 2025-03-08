using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class LivroBLL
    {
        public static void validaDados(Livro livro)
        {
            Erro.setErro(false);
            if (livro.gettitulo().Length == 0)
            {
                Erro.setErro("O campo Titulo é preenchimento obrigatório...");
                return;

            }
            if (livro.getautor().Length == 0)
            {
                Erro.setErro("O campo Autor é preenchimento obrigatório...");
                return;
            }
            if (livro.geteditora().Length == 0)
            {
                Erro.setErro("O campo Editora é preenchimento obrigatório...");
                return;
            }
            if (livro.getanoedicao().Length == 0)
            {
                Erro.setErro("O campo Ano Edição é preenchimento obrigatório...");
                return;
            }
            if (livro.getlocal().Length == 0)
            {
                Erro.setErro("O campo Local é preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(livro.getanoedicao());
                }
                catch
                {
                    Erro.setErro("O campo Ano edição deve ser numérico...");
                    return;
                }
                if (int.Parse(livro.getanoedicao()) < 0)
                {
                    Erro.setErro("O ano de edição deve ser maior que positivo.");
                }
            }
        }
    }
}

                
