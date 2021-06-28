
namespace Questoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.btnEnviat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a sua idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(158, 35);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 23);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbClassificacao.Location = new System.Drawing.Point(158, 90);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(0, 23);
            this.lbClassificacao.TabIndex = 2;
            // 
            // btnEnviat
            // 
            this.btnEnviat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnviat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviat.Location = new System.Drawing.Point(172, 64);
            this.btnEnviat.Name = "btnEnviat";
            this.btnEnviat.Size = new System.Drawing.Size(75, 23);
            this.btnEnviat.TabIndex = 3;
            this.btnEnviat.Text = "Enviar";
            this.btnEnviat.UseVisualStyleBackColor = false;
            this.btnEnviat.Click += new System.EventHandler(this.btnEnviat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 335);
            this.Controls.Add(this.btnEnviat);
            this.Controls.Add(this.lbClassificacao);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Questão 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lbClassificacao;
        private System.Windows.Forms.Button btnEnviat;
    }
}