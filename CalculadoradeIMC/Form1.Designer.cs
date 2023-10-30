namespace CalculadoradeIMC
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.NumericUpDown();
            this.txtPeso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(12, 184);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(83, 213);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(84, 20);
            this.txtIMC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calculadora IMC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "IMC";
            // 
            // txtTabela
            // 
            this.txtTabela.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTabela.ForeColor = System.Drawing.Color.Lime;
            this.txtTabela.Location = new System.Drawing.Point(28, 239);
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.Size = new System.Drawing.Size(144, 13);
            this.txtTabela.TabIndex = 8;
            // 
            // txtAltura
            // 
            this.txtAltura.DecimalPlaces = 2;
            this.txtAltura.Location = new System.Drawing.Point(83, 132);
            this.txtAltura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(85, 20);
            this.txtAltura.TabIndex = 9;
            this.txtAltura.ValueChanged += new System.EventHandler(this.txtAltura_ValueChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.DecimalPlaces = 2;
            this.txtPeso.Location = new System.Drawing.Point(83, 158);
            this.txtPeso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(85, 20);
            this.txtPeso.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(180, 276);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtTabela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTabela;
        private System.Windows.Forms.NumericUpDown txtAltura;
        private System.Windows.Forms.NumericUpDown txtPeso;
    }
}

