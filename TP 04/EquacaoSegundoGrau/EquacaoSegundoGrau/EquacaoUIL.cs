using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquacaoSegundoGrau
{
    public partial class EquacaoUIL : Form
    {
        Equacao umaequacao = new Equacao();
        public EquacaoUIL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            umaequacao.setA(textBox1.Text);
            umaequacao.setB(textBox2.Text);
            umaequacao.setC(textBox3.Text);
            EquacaoBLL.validaDados(umaequacao);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Delta = " + umaequacao.calcDelta() +
                                "\nx1  = " + umaequacao.calcX1() +
                                "\nx2  = " + umaequacao.calcX2());
                for(int x = -500; x < 500; x++)
                {
                    float y = float.Parse(umaequacao.getA()) * (x*x) +
                              float.Parse(umaequacao.getB()) * x +
                              float.Parse(umaequacao.getC());
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
        }
    }
}
