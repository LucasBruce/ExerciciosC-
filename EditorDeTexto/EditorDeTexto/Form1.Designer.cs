namespace EditorDeTexto
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
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.botaoFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textoFind = new System.Windows.Forms.TextBox();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botaoReplace = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoMaiuscula = new System.Windows.Forms.Button();
            this.botaoMenuscula = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(12, 24);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(426, 204);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGravar
            // 
            this.botaoGravar.Location = new System.Drawing.Point(360, 244);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 23);
            this.botaoGravar.TabIndex = 1;
            this.botaoGravar.Text = "Gravar";
            this.botaoGravar.UseVisualStyleBackColor = true;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // botaoFind
            // 
            this.botaoFind.Location = new System.Drawing.Point(273, 28);
            this.botaoFind.Name = "botaoFind";
            this.botaoFind.Size = new System.Drawing.Size(75, 23);
            this.botaoFind.TabIndex = 2;
            this.botaoFind.Text = "Find";
            this.botaoFind.UseVisualStyleBackColor = true;
            this.botaoFind.Click += new System.EventHandler(this.botaoFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Find";
            // 
            // textoFind
            // 
            this.textoFind.Location = new System.Drawing.Point(102, 30);
            this.textoFind.Name = "textoFind";
            this.textoFind.Size = new System.Drawing.Size(150, 20);
            this.textoFind.TabIndex = 5;
            // 
            // textoReplace
            // 
            this.textoReplace.Location = new System.Drawing.Point(102, 67);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(150, 20);
            this.textoReplace.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Replace";
            // 
            // botaoReplace
            // 
            this.botaoReplace.Location = new System.Drawing.Point(273, 65);
            this.botaoReplace.Name = "botaoReplace";
            this.botaoReplace.Size = new System.Drawing.Size(75, 23);
            this.botaoReplace.TabIndex = 8;
            this.botaoReplace.Text = "Replace";
            this.botaoReplace.UseVisualStyleBackColor = true;
            this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoReplace);
            this.groupBox1.Controls.Add(this.botaoFind);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoReplace);
            this.groupBox1.Controls.Add(this.textoFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 109);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // botaoMaiuscula
            // 
            this.botaoMaiuscula.Location = new System.Drawing.Point(12, 244);
            this.botaoMaiuscula.Name = "botaoMaiuscula";
            this.botaoMaiuscula.Size = new System.Drawing.Size(75, 23);
            this.botaoMaiuscula.TabIndex = 10;
            this.botaoMaiuscula.Text = "Maiúsculas";
            this.botaoMaiuscula.UseVisualStyleBackColor = true;
            this.botaoMaiuscula.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoMenuscula
            // 
            this.botaoMenuscula.Location = new System.Drawing.Point(104, 244);
            this.botaoMenuscula.Name = "botaoMenuscula";
            this.botaoMenuscula.Size = new System.Drawing.Size(75, 23);
            this.botaoMenuscula.TabIndex = 11;
            this.botaoMenuscula.Text = "Menusculas";
            this.botaoMenuscula.UseVisualStyleBackColor = true;
            this.botaoMenuscula.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 406);
            this.Controls.Add(this.botaoMenuscula);
            this.Controls.Add(this.botaoMaiuscula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoGravar);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.Button botaoFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoFind;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botaoReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoMaiuscula;
        private System.Windows.Forms.Button botaoMenuscula;
    }
}

