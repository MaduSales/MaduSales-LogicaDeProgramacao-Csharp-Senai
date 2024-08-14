namespace WindowsFormsApp9
{
    partial class FrmRadioButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.rbtnJava = new System.Windows.Forms.RadioButton();
            this.rbtnCsharp = new System.Windows.Forms.RadioButton();
            this.rbtnPhyton = new System.Windows.Forms.RadioButton();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projeto Radio Button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(211, 138);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(298, 30);
            this.txtResposta.TabIndex = 2;
            this.txtResposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnJava
            // 
            this.rbtnJava.AutoSize = true;
            this.rbtnJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJava.Location = new System.Drawing.Point(85, 222);
            this.rbtnJava.Name = "rbtnJava";
            this.rbtnJava.Size = new System.Drawing.Size(60, 24);
            this.rbtnJava.TabIndex = 3;
            this.rbtnJava.TabStop = true;
            this.rbtnJava.Text = "Java";
            this.rbtnJava.UseVisualStyleBackColor = true;
            // 
            // rbtnCsharp
            // 
            this.rbtnCsharp.AutoSize = true;
            this.rbtnCsharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCsharp.Location = new System.Drawing.Point(262, 222);
            this.rbtnCsharp.Name = "rbtnCsharp";
            this.rbtnCsharp.Size = new System.Drawing.Size(47, 24);
            this.rbtnCsharp.TabIndex = 4;
            this.rbtnCsharp.TabStop = true;
            this.rbtnCsharp.Text = "C#";
            this.rbtnCsharp.UseVisualStyleBackColor = true;
            // 
            // rbtnPhyton
            // 
            this.rbtnPhyton.AutoSize = true;
            this.rbtnPhyton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPhyton.Location = new System.Drawing.Point(433, 222);
            this.rbtnPhyton.Name = "rbtnPhyton";
            this.rbtnPhyton.Size = new System.Drawing.Size(76, 24);
            this.rbtnPhyton.TabIndex = 5;
            this.rbtnPhyton.TabStop = true;
            this.rbtnPhyton.Text = "Phyton";
            this.rbtnPhyton.UseVisualStyleBackColor = true;
            // 
            // btnEscolher
            // 
            this.btnEscolher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolher.Location = new System.Drawing.Point(194, 283);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(176, 39);
            this.btnEscolher.TabIndex = 6;
            this.btnEscolher.Text = "Escolher";
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // FrmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 353);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.rbtnPhyton);
            this.Controls.Add(this.rbtnCsharp);
            this.Controls.Add(this.rbtnJava);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRadioButton";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.RadioButton rbtnJava;
        private System.Windows.Forms.RadioButton rbtnCsharp;
        private System.Windows.Forms.RadioButton rbtnPhyton;
        private System.Windows.Forms.Button btnEscolher;
    }
}

