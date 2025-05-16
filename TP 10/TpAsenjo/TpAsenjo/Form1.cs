using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpAsenjo
{
    public partial class Form1 : Form
    {
        DataTable TabLivro = new DataTable();

        public Form1()
        {
            InitializeComponent();

            TabLivro.Columns.Add("Código");
            TabLivro.Columns.Add("Título");
            TabLivro.Columns.Add("Autor");
            TabLivro.Columns.Add("Ano");

            TabLivro.Rows.Add("001", "Dom Casmurro", "Machado de Assis", "1899");
            TabLivro.Rows.Add("002", "O Cortiço", "Aluísio Azevedo", "1890");
            TabLivro.Rows.Add("003", "Memórias Póstumas", "Machado de Assis", "1881");
        }

        private void btnListarListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (DataRow linha in TabLivro.Rows)
            {
                listBox1.Items.Add($"{linha["Código"]} - {linha["Título"]} - {linha["Autor"]}");
            }
        }

        private void btnListarWord_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();

            foreach (DataRow linha in TabLivro.Rows)
            {
                doc.Content.Text += $"{linha["Código"]} - {linha["Título"]} - {linha["Autor"]} - {linha["Ano"]}\n";
            }

            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\listagem.doc";
            doc.SaveAs2(caminho);
            doc.Close();
            wordApp.Quit();

            MessageBox.Show("Arquivo Word gerado com sucesso em Meus Documentos!");
        }

        private void btnListarExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel._Worksheet ws = (Microsoft.Office.Interop.Excel._Worksheet)excel.ActiveSheet;

            for (int i = 0; i < TabLivro.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = TabLivro.Columns[i].ColumnName;
                for (int j = 0; j < TabLivro.Rows.Count; j++)
                {
                    ws.Cells[j + 2, i + 1] = TabLivro.Rows[j][i];
                }
            }

            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\listagem.xlsx";
            ws.SaveAs(caminho);
            excel.Quit();

            MessageBox.Show("Arquivo Excel gerado com sucesso em Meus Documentos!");
        }
    }
}
