using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinemark
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int largura = 40;
            int altura = 40;
            int espaco = 5;

            string[] linhas = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            for (int i = 0; i < linhas.Length; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Button cadeira = new Button();
                    cadeira.Width = largura;
                    cadeira.Height = altura;
                    cadeira.Left = j * (largura + espaco);
                    cadeira.Top = i * (altura + espaco);
                    cadeira.Text = linhas[i] + j;
                    cadeira.BackColor = Color.Green;
                    cadeira.ForeColor = Color.White;
                    cadeira.Cursor = Cursors.Hand;

                    cadeira.FlatStyle = FlatStyle.Flat;
                    cadeira.FlatAppearance.BorderSize = 1;
                    cadeira.Font = new Font("Arial", 9, FontStyle.Bold);

                    cadeira.Click += Cadeira_Click;

                    this.Controls.Add(cadeira);
                }
            }
    
        }
        private void Cadeira_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Green)
            {
                DialogResult resposta = MessageBox.Show(
                    "Deseja reservar a cadeira " + btn.Text + "?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resposta == DialogResult.Yes)
                {
                    btn.BackColor = Color.Red;
                }
            }
            else if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.Green;
            }
        }


        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            int ocupadas = 0;

            foreach (Control controle in this.Controls)
            {
                if (controle is Button)
                {
                    Button cadeira = controle as Button;

                    if (cadeira.BackColor == Color.Red && cadeira.Text != "Faturamento")
                    {
                        ocupadas++;
                    }
                }
            }

            int faturamento = ocupadas * 20;
            MessageBox.Show("Faturamento total: R$ " + faturamento, "Bilheteria");
        }

    }
}

