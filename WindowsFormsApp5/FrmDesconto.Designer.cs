namespace WindowsFormsApp5
{
    partial class FrmDesconto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQtdComprada = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblTotalSemDesconto = new System.Windows.Forms.Label();
            this.lblTotalComDesconto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQtdComprada = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtTotalComDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalSemDesconto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(128, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(401, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculador de Desconto";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(83, 151);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(69, 20);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // lblQtdComprada
            // 
            this.lblQtdComprada.AutoSize = true;
            this.lblQtdComprada.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdComprada.Location = new System.Drawing.Point(83, 267);
            this.lblQtdComprada.Name = "lblQtdComprada";
            this.lblQtdComprada.Size = new System.Drawing.Size(174, 20);
            this.lblQtdComprada.TabIndex = 2;
            this.lblQtdComprada.Text = "Quantidade Comprada";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnitario.Location = new System.Drawing.Point(83, 382);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(113, 20);
            this.lblPrecoUnitario.TabIndex = 3;
            this.lblPrecoUnitario.Text = "Preço Unitário";
            // 
            // lblTotalSemDesconto
            // 
            this.lblTotalSemDesconto.AutoSize = true;
            this.lblTotalSemDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemDesconto.Location = new System.Drawing.Point(405, 269);
            this.lblTotalSemDesconto.Name = "lblTotalSemDesconto";
            this.lblTotalSemDesconto.Size = new System.Drawing.Size(156, 20);
            this.lblTotalSemDesconto.TabIndex = 4;
            this.lblTotalSemDesconto.Text = "Total Sem Desconto";
            // 
            // lblTotalComDesconto
            // 
            this.lblTotalComDesconto.AutoSize = true;
            this.lblTotalComDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComDesconto.Location = new System.Drawing.Point(405, 383);
            this.lblTotalComDesconto.Name = "lblTotalComDesconto";
            this.lblTotalComDesconto.Size = new System.Drawing.Size(158, 20);
            this.lblTotalComDesconto.TabIndex = 5;
            this.lblTotalComDesconto.Text = "Total Com Desconto";
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(81, 176);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(233, 38);
            this.txtProduto.TabIndex = 6;
            // 
            // txtQtdComprada
            // 
            this.txtQtdComprada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtQtdComprada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdComprada.Location = new System.Drawing.Point(87, 292);
            this.txtQtdComprada.Name = "txtQtdComprada";
            this.txtQtdComprada.Size = new System.Drawing.Size(227, 38);
            this.txtQtdComprada.TabIndex = 7;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(81, 407);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(233, 38);
            this.txtPrecoUnitario.TabIndex = 8;
            // 
            // txtTotalComDesconto
            // 
            this.txtTotalComDesconto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalComDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalComDesconto.Location = new System.Drawing.Point(408, 407);
            this.txtTotalComDesconto.Name = "txtTotalComDesconto";
            this.txtTotalComDesconto.Size = new System.Drawing.Size(180, 38);
            this.txtTotalComDesconto.TabIndex = 9;
            // 
            // txtTotalSemDesconto
            // 
            this.txtTotalSemDesconto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotalSemDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSemDesconto.Location = new System.Drawing.Point(407, 292);
            this.txtTotalSemDesconto.Name = "txtTotalSemDesconto";
            this.txtTotalSemDesconto.Size = new System.Drawing.Size(180, 38);
            this.txtTotalSemDesconto.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(407, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 56);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(506, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 56);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 512);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotalSemDesconto);
            this.Controls.Add(this.txtTotalComDesconto);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtQtdComprada);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblTotalComDesconto);
            this.Controls.Add(this.lblTotalSemDesconto);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.lblQtdComprada);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmDesconto";
            this.Text = "FrmDesconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQtdComprada;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblTotalSemDesconto;
        private System.Windows.Forms.Label lblTotalComDesconto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQtdComprada;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.TextBox txtTotalComDesconto;
        private System.Windows.Forms.TextBox txtTotalSemDesconto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}