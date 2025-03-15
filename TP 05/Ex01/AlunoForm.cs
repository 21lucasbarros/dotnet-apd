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
    public partial class AlunoForm : Form
    {
        private Aluno alunoSalvo;
        public AlunoForm()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.RA = txtRA.Text;
            aluno.Nome = txtNome.Text;
            aluno.Sexo = cmbSexo.SelectedItem?.ToString();
            aluno.DataNascimento = dtpDataNascimento.Value.ToString("dd/MM/yyyy");
            aluno.Telefone = txtTelefone.Text;

            if (AlunoBLL.ValidarAluno(aluno))
            {
                alunoSalvo = aluno;
                MessageBox.Show("Dados do aluno salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtRA.Clear();
            txtNome.Clear();
            cmbSexo.SelectedIndex = -1;
            dtpDataNascimento.Value = DateTime.Now;
            txtTelefone.Clear();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm produtoForm = new ProdutoForm();
            produtoForm.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (alunoSalvo != null)
            {
                txtRA.Text = alunoSalvo.RA;
                txtNome.Text = alunoSalvo.Nome;
                cmbSexo.SelectedItem = alunoSalvo.Sexo;
                dtpDataNascimento.Value = DateTime.ParseExact(alunoSalvo.DataNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None);
                txtTelefone.Text = alunoSalvo.Telefone;
            }
            else
            {
                MessageBox.Show("Nenhum aluno salvo para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AlunoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
