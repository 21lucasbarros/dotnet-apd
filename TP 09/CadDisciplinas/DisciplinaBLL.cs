using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadDisciplinas
{
    internal class DisciplinaBLL
    {
        public static void conecta()
        {
            DisciplinaDAL.conecta();
        }

        public static void desconecta()
        {
            DisciplinaDAL.desconecta();
        }

        public static void validaCodigo(Disciplina umaDisciplina, char op)
        {
            Erro.setErro(false);
            if (umaDisciplina.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (op == 'c') DisciplinaDAL.consultaUmaDisciplina(umaDisciplina);
            else DisciplinaDAL.excluiUmaDisciplina(umaDisciplina);
        }

        public static void validaDados(Disciplina umaDisciplina, char op)
        {
            Erro.setErro(false);
            if (umaDisciplina.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (umaDisciplina.getDescricao().Equals(""))
            {
                Erro.setMsg("O autor é de preenchimento obrigatório!");
                return;
            }
            if (umaDisciplina.getHoras().Equals(""))
            {
                Erro.setMsg("A Editora é de preenchimento obrigatório!");
                return;
            }


            try
            {
                int.Parse(umaDisciplina.getCodigo());
            }
            catch (Exception)
            {
                Erro.setMsg("O valor do código deve ser numérico!");
                return;
            }


            if (int.Parse(umaDisciplina.getCodigo()) <= 0)
            {
                Erro.setMsg("O valor do Código deve ser numérico e positivo!");
                return;
            }
            if (op == 'i')
                DisciplinaDAL.inseriUmaDisciplina(umaDisciplina);
            else if (op == 'a')
                DisciplinaDAL.atualizaUmaDisciplina(umaDisciplina);

        }
    }
}
