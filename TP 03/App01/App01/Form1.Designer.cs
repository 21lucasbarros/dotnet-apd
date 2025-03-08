namespace App01
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
            this.titulo = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.editora = new System.Windows.Forms.Label();
            this.ano = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.limpar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.titulo.Location = new System.Drawing.Point(19, 53);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(66, 25);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Titulo:";
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.autor.Location = new System.Drawing.Point(19, 95);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(65, 25);
            this.autor.TabIndex = 1;
            this.autor.Text = "Autor:";
            // 
            // editora
            // 
            this.editora.AutoSize = true;
            this.editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editora.Location = new System.Drawing.Point(19, 142);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(79, 25);
            this.editora.TabIndex = 2;
            this.editora.Text = "Editora:";
            this.editora.Click += new System.EventHandler(this.label3_Click);
            // 
            // ano
            // 
            this.ano.AutoSize = true;
            this.ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ano.Location = new System.Drawing.Point(13, 189);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(117, 25);
            this.ano.TabIndex = 3;
            this.ano.Text = "Ano edição:";
            this.ano.Click += new System.EventHandler(this.ano_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(136, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 30);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(136, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 30);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox3.Location = new System.Drawing.Point(136, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 30);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox4.Location = new System.Drawing.Point(136, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 30);
            this.textBox4.TabIndex = 7;
            // 
            // local
            // 
            this.local.AutoSize = true;
            this.local.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.local.Location = new System.Drawing.Point(19, 231);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(65, 25);
            this.local.TabIndex = 8;
            this.local.Text = "Local:";
            this.local.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox5.Location = new System.Drawing.Point(136, 228);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 30);
            this.textBox5.TabIndex = 9;
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.limpar.Location = new System.Drawing.Point(43, 304);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(106, 33);
            this.limpar.TabIndex = 10;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // salvar
            // 
            this.salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.salvar.Location = new System.Drawing.Point(171, 304);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(97, 33);
            this.salvar.TabIndex = 11;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // mostrar
            // 
            this.mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mostrar.Location = new System.Drawing.Point(289, 304);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(98, 33);
            this.mostrar.TabIndex = 12;
            this.mostrar.Text = "Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 374);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.local);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.editora);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label editora;
        private System.Windows.Forms.Label ano;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label local;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button mostrar;
    }
}

