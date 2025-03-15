using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01
{
    public partial class ProdutoForm : Form
    {
        private Produto produtoSalvo;
        public ProdutoForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Codigo = txtCodigo.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Fornecedor = txtFornecedor.Text;
            produto.QtdEstoque = txtQtdEstoque.Text;
            produto.ValorUnitario = txtValorUnitario.Text;

            if (ProdutoBLL.ValidarProduto(produto))
            {
                produtoSalvo = produto;
                MessageBox.Show("Dados do produto salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoForm alunoForm = new AlunoForm();
            alunoForm.Show();
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtFornecedor.Clear();
            txtQtdEstoque.Clear();
            txtValorUnitario.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (produtoSalvo != null)
            {
                txtCodigo.Text = produtoSalvo.Codigo;
                txtDescricao.Text = produtoSalvo.Descricao;
                txtFornecedor.Text = produtoSalvo.Fornecedor;
                txtQtdEstoque.Text = produtoSalvo.QtdEstoque;
                txtValorUnitario.Text = produtoSalvo.ValorUnitario;
            }
            else
            {
                MessageBox.Show("Nenhum produto salvo para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
