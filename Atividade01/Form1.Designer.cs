namespace Atividade01
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
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnVerificarLetra = new System.Windows.Forms.Button();
            this.btnContar10 = new System.Windows.Forms.Button();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnAprendendo = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(257, 65);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(294, 20);
            this.txtCampo.TabIndex = 0;
            this.txtCampo.TextChanged += new System.EventHandler(this.txtCampo_TextChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(254, 88);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "Resultado";
            this.lbResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVerificarLetra
            // 
            this.btnVerificarLetra.Location = new System.Drawing.Point(257, 146);
            this.btnVerificarLetra.Name = "btnVerificarLetra";
            this.btnVerificarLetra.Size = new System.Drawing.Size(148, 23);
            this.btnVerificarLetra.TabIndex = 3;
            this.btnVerificarLetra.Text = "Verificar Letra";
            this.btnVerificarLetra.UseVisualStyleBackColor = true;
            this.btnVerificarLetra.Click += new System.EventHandler(this.btnVerificarLetra_Click);
            // 
            // btnContar10
            // 
            this.btnContar10.Location = new System.Drawing.Point(257, 175);
            this.btnContar10.Name = "btnContar10";
            this.btnContar10.Size = new System.Drawing.Size(148, 23);
            this.btnContar10.TabIndex = 4;
            this.btnContar10.Text = "Contar até 10";
            this.btnContar10.UseVisualStyleBackColor = true;
            this.btnContar10.Click += new System.EventHandler(this.btnContar10_Click);
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(411, 117);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(140, 23);
            this.btnTabuada.TabIndex = 5;
            this.btnTabuada.Text = "Calcular Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnAprendendo
            // 
            this.btnAprendendo.Location = new System.Drawing.Point(411, 146);
            this.btnAprendendo.Name = "btnAprendendo";
            this.btnAprendendo.Size = new System.Drawing.Size(140, 23);
            this.btnAprendendo.TabIndex = 6;
            this.btnAprendendo.Text = "Estou Aprendendo";
            this.btnAprendendo.UseVisualStyleBackColor = true;
            this.btnAprendendo.Click += new System.EventHandler(this.btnAprendendo_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(411, 175);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(140, 23);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "Mini Jogo";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnIdade
            // 
            this.btnIdade.Location = new System.Drawing.Point(257, 117);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(148, 23);
            this.btnIdade.TabIndex = 8;
            this.btnIdade.Text = "Calcular Idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIdade);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnAprendendo);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnContar10);
            this.Controls.Add(this.btnVerificarLetra);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtCampo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnVerificarLetra;
        private System.Windows.Forms.Button btnContar10;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnAprendendo;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnIdade;
    }
}

