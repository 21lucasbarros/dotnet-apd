using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Models;
using CadastroPessoas.DAL;

namespace CadastroPessoas.BLL
{
    public class PessoaBLL
    {
        private PessoaDAL pessoaDAL = new PessoaDAL();

        public void Cadastrar(Pessoa pessoa)
        {
            if (pessoa.Codigo <= 0)
                throw new Exception("Código inválido!");

            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new Exception("Nome é obrigatório!");

            if (pessoa.Sexo != 'F' && pessoa.Sexo != 'M' && pessoa.Sexo != 'f' && pessoa.Sexo != 'm')
                throw new Exception("Sexo deve ser 'F' ou 'M'.");

            if (pessoa.Idade <= 0)
                throw new Exception("Idade deve ser maior que zero!");

            pessoaDAL.Cadastrar(pessoa);
        }

        public Pessoa Consultar(int codigo)
        {
            if (codigo <= 0)
                throw new Exception("Código inválido!");

            Pessoa pessoa = pessoaDAL.Consultar(codigo);

            if (pessoa == null)
                throw new Exception("Pessoa não encontrada!");

            return pessoa;
        }
    }
}
