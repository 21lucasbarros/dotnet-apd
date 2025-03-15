using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex01
{
    public class AlunoBLL
    {
        public static bool ValidarAluno(Aluno aluno)
        {
            if (string.IsNullOrEmpty(aluno.RA) || string.IsNullOrEmpty(aluno.Nome) ||
            string.IsNullOrEmpty(aluno.Sexo) || string.IsNullOrEmpty(aluno.DataNascimento) ||
            string.IsNullOrEmpty(aluno.Telefone))
            {
                Erro.ExibirMensagem("Todos os campos do aluno são obrigatórios.");
                return false;
            }

            string sexo = aluno.Sexo.Trim();
            if (!sexo.Equals("Masculino", StringComparison.OrdinalIgnoreCase) &&
                !sexo.Equals("Feminino", StringComparison.OrdinalIgnoreCase))
            {
                Erro.ExibirMensagem("O sexo do aluno deve ser 'Masculino' ou 'Feminino'.");
                return false;
            }

            if (!DateTime.TryParseExact(aluno.DataNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                Erro.ExibirMensagem("A data de nascimento deve estar no formato DD/MM/YYYY.");
                return false;
            }

            if (!Regex.IsMatch(aluno.Telefone, @"^\(\d{2}\) \d{5}-\d{4}$"))
            {
                Erro.ExibirMensagem("O telefone deve estar no formato (XX) XXXXX-XXXX.");
                return false;
            }

            return true;

        }
    }
}
