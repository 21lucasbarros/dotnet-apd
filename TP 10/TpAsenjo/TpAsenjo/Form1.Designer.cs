namespace TpAsenjo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListarListBox = new System.Windows.Forms.Button();
            this.btnListarWord = new System.Windows.Forms.Button();
            this.btnListarExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(94, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(594, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnListarListBox
            // 
            this.btnListarListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarListBox.Location = new System.Drawing.Point(94, 284);
            this.btnListarListBox.Name = "btnListarListBox";
            this.btnListarListBox.Size = new System.Drawing.Size(120, 40);
            this.btnListarListBox.TabIndex = 1;
            this.btnListarListBox.Text = "Listar Box";
            this.btnListarListBox.UseVisualStyleBackColor = true;
            this.btnListarListBox.Click += new System.EventHandler(this.btnListarListBox_Click);
            // 
            // btnListarWord
            // 
            this.btnListarWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarWord.Location = new System.Drawing.Point(328, 284);
            this.btnListarWord.Name = "btnListarWord";
            this.btnListarWord.Size = new System.Drawing.Size(120, 40);
            this.btnListarWord.TabIndex = 2;
            this.btnListarWord.Text = "Listar Word";
            this.btnListarWord.UseVisualStyleBackColor = true;
            this.btnListarWord.Click += new System.EventHandler(this.btnListarWord_Click);
            // 
            // btnListarExcel
            // 
            this.btnListarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarExcel.Location = new System.Drawing.Point(568, 284);
            this.btnListarExcel.Name = "btnListarExcel";
            this.btnListarExcel.Size = new System.Drawing.Size(120, 40);
            this.btnListarExcel.TabIndex = 3;
            this.btnListarExcel.Text = "Listar Excel";
            this.btnListarExcel.UseVisualStyleBackColor = true;
            this.btnListarExcel.Click += new System.EventHandler(this.btnListarExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btnListarExcel);
            this.Controls.Add(this.btnListarWord);
            this.Controls.Add(this.btnListarListBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListarListBox;
        private System.Windows.Forms.Button btnListarWord;
        private System.Windows.Forms.Button btnListarExcel;
    }
}

