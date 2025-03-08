using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.P1 = textBox1.Text;
            aluno.P2 = textBox2.Text;
            aluno.P3 = textBox3.Text;
            aluno.P4 = textBox4.Text;
            AlunoBLL.validaDados(aluno);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {

                MessageBox.Show(aluno.MediaAritmetica());

            }

           
        }

    }
}
