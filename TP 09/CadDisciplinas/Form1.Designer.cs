namespace CadDisciplinas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codigoLabel = new System.Windows.Forms.Label();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.horasLabel = new System.Windows.Forms.Label();
            this.criarBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.inputDescricao = new System.Windows.Forms.TextBox();
            this.inputHoras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.Location = new System.Drawing.Point(37, 54);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(128, 37);
            this.codigoLabel.TabIndex = 0;
            this.codigoLabel.Text = "Código:";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoLabel.Location = new System.Drawing.Point(37, 145);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(168, 37);
            this.descricaoLabel.TabIndex = 1;
            this.descricaoLabel.Text = "Descrição:";
            // 
            // horasLabel
            // 
            this.horasLabel.AutoSize = true;
            this.horasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horasLabel.Location = new System.Drawing.Point(37, 224);
            this.horasLabel.Name = "horasLabel";
            this.horasLabel.Size = new System.Drawing.Size(112, 37);
            this.horasLabel.TabIndex = 2;
            this.horasLabel.Text = "Horas:";
            // 
            // criarBtn
            // 
            this.criarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarBtn.Location = new System.Drawing.Point(44, 343);
            this.criarBtn.Name = "criarBtn";
            this.criarBtn.Size = new System.Drawing.Size(161, 48);
            this.criarBtn.TabIndex = 3;
            this.criarBtn.Text = "Criar";
            this.criarBtn.UseVisualStyleBackColor = true;
            this.criarBtn.Click += new System.EventHandler(this.criarBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(44, 425);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(161, 48);
            this.readBtn.TabIndex = 4;
            this.readBtn.Text = "Ler";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(239, 343);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(161, 48);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Atualizar";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(239, 425);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(161, 48);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Excluir";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cleanBtn
            // 
            this.cleanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanBtn.Location = new System.Drawing.Point(520, 343);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(161, 48);
            this.cleanBtn.TabIndex = 7;
            this.cleanBtn.Text = "Limpar";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // inputCodigo
            // 
            this.inputCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCodigo.Location = new System.Drawing.Point(219, 47);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(462, 44);
            this.inputCodigo.TabIndex = 8;
            // 
            // inputDescricao
            // 
            this.inputDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDescricao.Location = new System.Drawing.Point(219, 145);
            this.inputDescricao.Name = "inputDescricao";
            this.inputDescricao.Size = new System.Drawing.Size(462, 44);
            this.inputDescricao.TabIndex = 9;
            // 
            // inputHoras
            // 
            this.inputHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputHoras.Location = new System.Drawing.Point(219, 224);
            this.inputHoras.Name = "inputHoras";
            this.inputHoras.Size = new System.Drawing.Size(462, 44);
            this.inputHoras.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 513);
            this.Controls.Add(this.inputHoras);
            this.Controls.Add(this.inputDescricao);
            this.Controls.Add(this.inputCodigo);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.criarBtn);
            this.Controls.Add(this.horasLabel);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.Label horasLabel;
        private System.Windows.Forms.Button criarBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.TextBox inputDescricao;
        private System.Windows.Forms.TextBox inputHoras;
    }
}

