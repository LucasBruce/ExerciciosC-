namespace Banco
{
    partial class FormAdicionarConta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grupConta = new System.Windows.Forms.GroupBox();
            this.campoNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoTitular = new System.Windows.Forms.TextBox();
            this.campoSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grupConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.comboContas);
            this.groupBox1.Controls.Add(this.textTitular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de Conta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolher a Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Busca por titular";
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(180, 66);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(100, 20);
            this.textTitular.TabIndex = 3;
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(180, 32);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 4;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(302, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grupConta
            // 
            this.grupConta.Controls.Add(this.button1);
            this.grupConta.Controls.Add(this.campoValor);
            this.grupConta.Controls.Add(this.label6);
            this.grupConta.Controls.Add(this.campoSaldo);
            this.grupConta.Controls.Add(this.label5);
            this.grupConta.Controls.Add(this.campoTitular);
            this.grupConta.Controls.Add(this.campoNumero);
            this.grupConta.Controls.Add(this.label3);
            this.grupConta.Controls.Add(this.label4);
            this.grupConta.Location = new System.Drawing.Point(12, 152);
            this.grupConta.Name = "grupConta";
            this.grupConta.Size = new System.Drawing.Size(434, 233);
            this.grupConta.TabIndex = 6;
            this.grupConta.TabStop = false;
            this.grupConta.Text = "Conta";
            this.grupConta.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // campoNumero
            // 
            this.campoNumero.Location = new System.Drawing.Point(180, 57);
            this.campoNumero.Name = "campoNumero";
            this.campoNumero.Size = new System.Drawing.Size(100, 20);
            this.campoNumero.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Titular";
            // 
            // campoTitular
            // 
            this.campoTitular.Location = new System.Drawing.Point(180, 32);
            this.campoTitular.Name = "campoTitular";
            this.campoTitular.Size = new System.Drawing.Size(100, 20);
            this.campoTitular.TabIndex = 6;
            // 
            // campoSaldo
            // 
            this.campoSaldo.Location = new System.Drawing.Point(180, 83);
            this.campoSaldo.Name = "campoSaldo";
            this.campoSaldo.Size = new System.Drawing.Size(100, 20);
            this.campoSaldo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saldo";
            // 
            // campoValor
            // 
            this.campoValor.Location = new System.Drawing.Point(180, 109);
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(100, 20);
            this.campoValor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.grupConta);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdicionarConta";
            this.Text = "FormAdicionarConta";
            this.Load += new System.EventHandler(this.FormAdicionarConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupConta.ResumeLayout(false);
            this.grupConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupConta;
        private System.Windows.Forms.TextBox campoNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoTitular;
        private System.Windows.Forms.Button button1;
    }
}