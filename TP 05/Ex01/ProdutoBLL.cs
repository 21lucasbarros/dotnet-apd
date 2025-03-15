using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class ProdutoBLL
    {
        public static bool ValidarProduto(Produto produto)
        {
            if (string.IsNullOrEmpty(produto.Codigo) || string.IsNullOrEmpty(produto.Descricao) ||
            string.IsNullOrEmpty(produto.Fornecedor) || string.IsNullOrEmpty(produto.QtdEstoque) ||
            string.IsNullOrEmpty(produto.ValorUnitario))
            {
                Erro.ExibirMensagem("Todos os campos do produto são obrigatórios.");
                return false;
            }

            if (!int.TryParse(produto.Codigo, out int codigo) || codigo <= 0)
            {
                Erro.ExibirMensagem("O código do produto deve ser um número inteiro maior que zero.");
                return false;
            }

            if (!int.TryParse(produto.QtdEstoque, out int estoque) || estoque <= 0)
            {
                Erro.ExibirMensagem("A quantidade em estoque deve ser um número inteiro maior que zero.");
                return false;
            }

            if (!float.TryParse(produto.ValorUnitario, out float valor) || valor <= 0)
            {
                Erro.ExibirMensagem("O valor unitário deve ser um número maior que zero.");
                return false;
            }

            return true;
        }
    }
}
