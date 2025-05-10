using System;
using System.Data.OleDb;

namespace CadDisciplinas
{
    internal class DisciplinaDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void inseriUmaDisciplina(Disciplina umaDisciplina)
        {
            try
            {
                conn.Open();
                String query = "insert into TabDisciplinas(codigo,descricao,horas) values (@codigo,@descricao,@horas)";

                strSQL = new OleDbCommand(query, conn);

                strSQL.Parameters.Add("@codigo", OleDbType.Integer).Value = umaDisciplina.getCodigo();
                strSQL.Parameters.Add("@descricao", OleDbType.VarChar).Value = umaDisciplina.getDescricao();
                strSQL.Parameters.Add("@horas", OleDbType.Integer).Value = umaDisciplina.getHoras();


                try
                {
                    strSQL.ExecuteNonQuery();
                    Erro.setErro(false);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao inserir: " + ex.Message);
                    conn.Close();
                }
            }
            catch
            {
                conn.Close();
            }
        }

        public static void consultaUmaDisciplina(Disciplina umaDisciplina)
        {
            try
            {
                conn.Open();

                String query = "select * from TabDisciplinas where codigo = @codigo";
                strSQL = new OleDbCommand(query, conn);

                int codigo = int.Parse(umaDisciplina.getCodigo());

                strSQL.Parameters.Add("@codigo", OleDbType.Integer).Value = codigo;
                result = strSQL.ExecuteReader();

                Erro.setErro(false);

                if (result.Read())
                {
                    umaDisciplina.setDescricao(result["descricao"].ToString());
                    umaDisciplina.setHoras(result["horas"].ToString());
                }
                else
                {
                    Erro.setMsg("Disciplina não cadastrada.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Erro.setMsg("Ocorreu um erro ao consultar a disciplina: " + ex.Message);
                conn.Close();
            }
        }


        public static void excluiUmaDisciplina(Disciplina umaDisciplina)
        {
            try
            {
                conn.Open();
                String query = "delete from TabDisciplinas where codigo = @codigo";

                strSQL = new OleDbCommand(query, conn);
                strSQL.Parameters.Add("@codigo", OleDbType.Integer).Value = umaDisciplina.getCodigo();
                strSQL.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                Erro.setMsg("Ocorreu um erri ao excluir a disciplina" + ex.Message);
                conn.Close();
            }
        }

        public static void atualizaUmaDisciplina(Disciplina umaDisciplina)
        {
            try
            {
                conn.Open();
                String query = "update TabDisciplinas set descricao=@descricao, horas=@horas where codigo=@codigo";

                strSQL = new OleDbCommand(query, conn);
                
                strSQL.Parameters.Add("@descricao", OleDbType.VarChar).Value = umaDisciplina.getDescricao();
                strSQL.Parameters.Add("@horas", OleDbType.Integer).Value = umaDisciplina.getHoras();
                strSQL.Parameters.Add("@codigo", OleDbType.Integer).Value = umaDisciplina.getCodigo();
                strSQL.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Erro.setMsg("Ocorreu um erro ao tentar atualizar os dados" + ex.Message);
                conn.Close();
            }
        }
    }
}
