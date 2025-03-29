using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
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

        public void Editar(Pessoa pessoa)
        {
            using (OleDbConnection conexao = Conexao.ObterConexao())
            {
                // SQL para atualizar os dados da pessoa no banco
                string sql = "UPDATE TabPessoa SET Nome = @Nome, Sexo = @Sexo, Idade = @Idade WHERE Codigo = @Codigo";

                using (OleDbCommand cmd = new OleDbCommand(sql, conexao))
                {
                    // Adiciona os parâmetros corretamente com valores da pessoa
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome); // Nome
                    cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo.ToString()); // Sexo (como string)
                    cmd.Parameters.AddWithValue("@Idade", pessoa.Idade); // Idade
                    cmd.Parameters.AddWithValue("@Codigo", pessoa.Codigo); // Código (chave primária)

                    // Abre a conexão e executa o comando
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Apagar(int codigo)
        {
            using (OleDbConnection conexao = Conexao.ObterConexao())
            {
                string sql = "DELETE FROM TabPessoa WHERE Codigo = @Codigo";

                using (OleDbCommand cmd = new OleDbCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
