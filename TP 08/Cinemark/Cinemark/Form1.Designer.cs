namespace Cinemark
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFaturamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaturamento
            // 
            this.btnFaturamento.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFaturamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFaturamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturamento.ForeColor = System.Drawing.Color.White;
            this.btnFaturamento.Location = new System.Drawing.Point(48, 463);
            this.btnFaturamento.Name = "btnFaturamento";
            this.btnFaturamento.Size = new System.Drawing.Size(157, 62);
            this.btnFaturamento.TabIndex = 0;
            this.btnFaturamento.Text = "Faturamento total";
            this.btnFaturamento.UseVisualStyleBackColor = false;
            this.btnFaturamento.Click += new System.EventHandler(this.btnFaturamento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnFaturamento);
            this.Name = "Form1";
            this.Text = "Cinemark do Asenjo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaturamento;
    }
}

