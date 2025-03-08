using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();


            funcionario.NomeFuncionario = textBox1.Text;
            funcionario.HorasTrabalhadas = textBox2.Text;
            funcionario.ValorHorasTrabalhadas = textBox3.Text;

            FuncionarioBLL.validaDados(funcionario);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {

                MessageBox.Show(funcionario.Bruto().ToString());

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
