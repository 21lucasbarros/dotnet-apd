using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadDisciplinas
{
    public partial class Form1 : Form
    {
        Disciplina umaDisciplina = new Disciplina();
        public Form1()
        {
            InitializeComponent();
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            inputCodigo.Text = "";
            inputDescricao.Text = "";
            inputHoras.Text = "";
        }

        private void criarBtn_Click(object sender, EventArgs e)
        {
            umaDisciplina.setCodigo(inputCodigo.Text);
            umaDisciplina.setDescricao(inputDescricao.Text);
            umaDisciplina.setHoras(inputHoras.Text);

            DisciplinaBLL.validaDados(umaDisciplina, 'i');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            umaDisciplina.setCodigo(inputCodigo.Text);
            umaDisciplina.setDescricao(inputDescricao.Text);
            umaDisciplina.setHoras(inputHoras.Text);

            DisciplinaBLL.validaDados(umaDisciplina, 'a');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados alterados com sucesso!");
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            umaDisciplina.setCodigo(inputCodigo.Text);

            DisciplinaBLL.validaCodigo(umaDisciplina, 'c');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                inputCodigo.Text = umaDisciplina.getCodigo();
                inputDescricao.Text = umaDisciplina.getDescricao();
                inputHoras.Text = umaDisciplina.getHoras();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            umaDisciplina.setCodigo(inputCodigo.Text);

            DisciplinaBLL.validaCodigo(umaDisciplina, 'e');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Livro Excluído!");
        }
    }
}
