
namespace Questoes
{
    partial class Questao2
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
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorEmDolaresConvercao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorEmDolaresConvertido = new System.Windows.Forms.TextBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotação do dólar:";
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.Location = new System.Drawing.Point(165, 28);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(100, 23);
            this.txtCotacaoDolar.TabIndex = 1;
            this.txtCotacaoDolar.TextChanged += new System.EventHandler(this.txtCotacaoDolar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor em dólares para conversão:";
            // 
            // txtValorEmDolaresConvercao
            // 
            this.txtValorEmDolaresConvercao.Location = new System.Drawing.Point(257, 71);
            this.txtValorEmDolaresConvercao.Name = "txtValorEmDolaresConvercao";
            this.txtValorEmDolaresConvercao.Size = new System.Drawing.Size(100, 23);
            this.txtValorEmDolaresConvercao.TabIndex = 3;
            this.txtValorEmDolaresConvercao.TextChanged += new System.EventHandler(this.txtValorEmDolaresConvercao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor em dólares:";
            // 
            // txtValorEmDolaresConvertido
            // 
            this.txtValorEmDolaresConvertido.Location = new System.Drawing.Point(160, 116);
            this.txtValorEmDolaresConvertido.Name = "txtValorEmDolaresConvertido";
            this.txtValorEmDolaresConvertido.Size = new System.Drawing.Size(100, 23);
            this.txtValorEmDolaresConvertido.TabIndex = 5;
            this.txtValorEmDolaresConvertido.TextChanged += new System.EventHandler(this.txtValorEmDolaresConvertido_TextChanged);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltarMenu.Location = new System.Drawing.Point(286, 300);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(129, 23);
            this.btnVoltarMenu.TabIndex = 8;
            this.btnVoltarMenu.Text = "Voltar para o menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // Questao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(427, 335);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.txtValorEmDolaresConvertido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorEmDolaresConvercao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(40, 71);
            this.Name = "Questao2";
            this.Text = "Questao2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCotacaoDolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmDolares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorDolares;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.TextBox txtValorEmDolaresConvercao;
        private System.Windows.Forms.TextBox txtValorEmDolaresConvertido;
    }
}