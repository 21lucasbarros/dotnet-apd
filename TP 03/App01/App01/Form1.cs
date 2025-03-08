using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class Form1 : Form


    {

        Livro livro = new Livro();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ano_Click(object sender, EventArgs e)
        {

        }

        private void mostrar_Click(object sender, EventArgs e)
        {

            textBox1.Text = livro.gettitulo();
            textBox2.Text = livro.getautor();
            textBox3.Text = livro.geteditora();
            textBox4.Text = livro.getanoedicao();
            textBox5.Text = livro.getlocal();
        }

        public void salvar_Click(object sender, EventArgs e)
        {

            livro.settitulo(textBox1.Text);
            livro.setautor(textBox2.Text);
            livro.seteditora(textBox3.Text);
            livro.setanoedicao(textBox4.Text);
            livro.setlocal(textBox5.Text);

            LivroBLL.validaDados(livro);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

    }
}