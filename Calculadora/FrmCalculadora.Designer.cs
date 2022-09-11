namespace Calculadora
{
    partial class FrmCalculadora
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
            this.tbNumero1 = new System.Windows.Forms.TextBox();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtnDividir = new System.Windows.Forms.RadioButton();
            this.rbtnSubtrair = new System.Windows.Forms.RadioButton();
            this.rbtnSomar = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumero1
            // 
            this.tbNumero1.Location = new System.Drawing.Point(58, 23);
            this.tbNumero1.Name = "tbNumero1";
            this.tbNumero1.Size = new System.Drawing.Size(135, 20);
            this.tbNumero1.TabIndex = 0;
            // 
            // tbNumero2
            // 
            this.tbNumero2.Location = new System.Drawing.Point(58, 175);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(135, 20);
            this.tbNumero2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMultiplicar);
            this.groupBox1.Controls.Add(this.rbtnDividir);
            this.groupBox1.Controls.Add(this.rbtnSubtrair);
            this.groupBox1.Controls.Add(this.rbtnSomar);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opreação";
            // 
            // rbtnMultiplicar
            // 
            this.rbtnMultiplicar.AutoSize = true;
            this.rbtnMultiplicar.Location = new System.Drawing.Point(104, 54);
            this.rbtnMultiplicar.Name = "rbtnMultiplicar";
            this.rbtnMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbtnMultiplicar.TabIndex = 3;
            this.rbtnMultiplicar.TabStop = true;
            this.rbtnMultiplicar.Text = "Multiplicar";
            this.rbtnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtnDividir
            // 
            this.rbtnDividir.AutoSize = true;
            this.rbtnDividir.Location = new System.Drawing.Point(32, 54);
            this.rbtnDividir.Name = "rbtnDividir";
            this.rbtnDividir.Size = new System.Drawing.Size(54, 17);
            this.rbtnDividir.TabIndex = 2;
            this.rbtnDividir.TabStop = true;
            this.rbtnDividir.Text = "Dividir";
            this.rbtnDividir.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtrair
            // 
            this.rbtnSubtrair.AutoSize = true;
            this.rbtnSubtrair.Location = new System.Drawing.Point(104, 31);
            this.rbtnSubtrair.Name = "rbtnSubtrair";
            this.rbtnSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rbtnSubtrair.TabIndex = 1;
            this.rbtnSubtrair.TabStop = true;
            this.rbtnSubtrair.Text = "Subtrair";
            this.rbtnSubtrair.UseVisualStyleBackColor = true;
            // 
            // rbtnSomar
            // 
            this.rbtnSomar.AutoSize = true;
            this.rbtnSomar.Location = new System.Drawing.Point(32, 31);
            this.rbtnSomar.Name = "rbtnSomar";
            this.rbtnSomar.Size = new System.Drawing.Size(55, 17);
            this.rbtnSomar.TabIndex = 0;
            this.rbtnSomar.TabStop = true;
            this.rbtnSomar.Text = "Somar";
            this.rbtnSomar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(78, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Enabled = false;
            this.tbResultado.Location = new System.Drawing.Point(12, 269);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(212, 20);
            this.tbResultado.TabIndex = 4;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 321);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNumero2);
            this.Controls.Add(this.tbNumero1);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumero1;
        private System.Windows.Forms.TextBox tbNumero2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMultiplicar;
        private System.Windows.Forms.RadioButton rbtnDividir;
        private System.Windows.Forms.RadioButton rbtnSubtrair;
        private System.Windows.Forms.RadioButton rbtnSomar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

