using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.DAL
{
    public class Conexao
    {
        private static string strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|BDAulas.mdb";

        public static OleDbConnection ObterConexao()
        {
            return new OleDbConnection(strConexao);
        }
    }
}
