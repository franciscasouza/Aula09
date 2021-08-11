
namespace Aula09_Dados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDado1 = new System.Windows.Forms.TextBox();
            this.txtDado2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJogado1 = new System.Windows.Forms.TextBox();
            this.txtComputador = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(227, 28);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(78, 30);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogador 1";
            // 
            // txtDado1
            // 
            this.txtDado1.Enabled = false;
            this.txtDado1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDado1.Location = new System.Drawing.Point(151, 100);
            this.txtDado1.Multiline = true;
            this.txtDado1.Name = "txtDado1";
            this.txtDado1.Size = new System.Drawing.Size(66, 86);
            this.txtDado1.TabIndex = 3;
            // 
            // txtDado2
            // 
            this.txtDado2.Enabled = false;
            this.txtDado2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDado2.Location = new System.Drawing.Point(298, 100);
            this.txtDado2.Multiline = true;
            this.txtDado2.Name = "txtDado2";
            this.txtDado2.Size = new System.Drawing.Size(66, 86);
            this.txtDado2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Computador";
            // 
            // txtJogado1
            // 
            this.txtJogado1.BackColor = System.Drawing.SystemColors.Control;
            this.txtJogado1.Location = new System.Drawing.Point(174, 297);
            this.txtJogado1.Name = "txtJogado1";
            this.txtJogado1.Size = new System.Drawing.Size(43, 23);
            this.txtJogado1.TabIndex = 6;
            // 
            // txtComputador
            // 
            this.txtComputador.BackColor = System.Drawing.SystemColors.Control;
            this.txtComputador.Location = new System.Drawing.Point(174, 350);
            this.txtComputador.Name = "txtComputador";
            this.txtComputador.Size = new System.Drawing.Size(43, 23);
            this.txtComputador.TabIndex = 7;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnJogar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJogar.ForeColor = System.Drawing.Color.Snow;
            this.btnJogar.Location = new System.Drawing.Point(371, 322);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(97, 33);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.Text = "Jogar Dados";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.button1_Click);
            this.btnJogar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Jogada);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 409);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtComputador);
            this.Controls.Add(this.txtJogado1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDado2);
            this.Controls.Add(this.txtDado1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDado1;
        private System.Windows.Forms.TextBox txtDado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJogado1;
        private System.Windows.Forms.TextBox txtComputador;
        private System.Windows.Forms.Button btnJogar;
    }
}

