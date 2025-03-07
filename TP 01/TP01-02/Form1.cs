using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double angulo = double.Parse(textBox1.Text);

            double radianos = angulo * (Math.PI / 180);

            // Calcula as funções trigonométricas
            double seno = Math.Sin(radianos);
            double coseno = Math.Cos(radianos);
            double tangente = Math.Tan(radianos);
            double secante = 1 / Math.Cos(radianos);

            // Exibe os resultados nos Labels
            label2.Text = $"Seno: {seno:F4}";
            label3.Text = $"Coseno: {coseno:F4}";
            label4.Text = $"Tangente: {tangente:F4}";
            label5.Text = $"Secante: {secante:F4}";
        }
    }
}
