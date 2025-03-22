using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using CadastroPessoas.Models;

namespace CadastroPessoas.DAL
{
    public class PessoaDAL
    {
        public void Cadastrar(Pessoa pessoa)
        {
            using (OleDbConnection conexao = Conexao.ObterConexao())
            {
                string sql = "INSERT INTO TabPessoa (Codigo, Nome, Sexo, Idade) VALUES (@Codigo, @Nome, @Sexo, @Idade)";

                using (OleDbCommand cmd = new OleDbCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Codigo", pessoa.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo.ToString());
                    cmd.Parameters.AddWithValue("@Idade", pessoa.Idade);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Pessoa Consultar(int codigo)
        {
            using (OleDbConnection conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM TabPessoa WHERE Codigo = @Codigo";

                using (OleDbCommand cmd = new OleDbCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conexao.Open();

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Pessoa
                            {
                                Codigo = Convert.ToInt32(reader["Codigo"]),
                                Nome = reader["Nome"].ToString(),
                                Sexo = Convert.ToChar(reader["Sexo"]),
                                Idade = Convert.ToInt32(reader["Idade"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
