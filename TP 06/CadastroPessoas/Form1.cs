using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using CadastroPessoas.Models;
using CadastroPessoas.BLL;

namespace CadastroPessoas
{
    public partial class Form1 : Form
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    Nome = txtNome.Text,
                    Sexo = cmbSexo.SelectedItem.ToString()[0],
                    Idade = int.Parse(mtbIdade.Text)
                };

                PessoaBLL pessoaBLL = new PessoaBLL();
                pessoaBLL.Cadastrar(pessoa);

                MessageBox.Show("Pessoa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigo.Clear();
                txtNome.Clear();
                cmbSexo.SelectedIndex = -1;
                mtbIdade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Digite um código antes de consultar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int codigo = int.Parse(txtCodigo.Text);
                PessoaBLL pessoaBLL = new PessoaBLL();
                Pessoa pessoa = pessoaBLL.Consultar(codigo);

                if (pessoa == null)
                {
                    MessageBox.Show("Pessoa não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Limpa e exibe os dados no ListBox
                lstResultado.Items.Clear();
                lstResultado.Items.Add($"Código: {pessoa.Codigo}");
                lstResultado.Items.Add($"Nome: {pessoa.Nome}");
                lstResultado.Items.Add($"Sexo: {pessoa.Sexo}");
                lstResultado.Items.Add($"Idade: {pessoa.Idade}");
            }
            catch (FormatException)
            {
                MessageBox.Show("O código deve ser um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}