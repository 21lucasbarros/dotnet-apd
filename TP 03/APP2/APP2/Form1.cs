using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP2
{
    
    public partial class Form1 : Form
    {
        EqSegundoGrau eqsegundograu = new EqSegundoGrau();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eqsegundograu.seta(textBox1.Text);
            eqsegundograu.setb(textBox2.Text);
            eqsegundograu.setc(textBox3.Text);

            EqSegundoGrauBLL.validaDados(eqsegundograu);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            } else
            {
                MessageBox.Show($"Delta: {eqsegundograu.calcdelta()} \nX1:{eqsegundograu.calcx1()} \nX2: {eqsegundograu.calcx2()}");
            }
           
        }
    }
}
