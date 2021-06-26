
namespace Questoes
{
    partial class Questao1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeMinima = new System.Windows.Forms.TextBox();
            this.txtQuantidadeMaxima = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtEstoqueMedio = new System.Windows.Forms.TextBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade Mínima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade Máxima:";
            // 
            // txtQuantidadeMinima
            // 
            this.txtQuantidadeMinima.Location = new System.Drawing.Point(177, 24);
            this.txtQuantidadeMinima.Name = "txtQuantidadeMinima";
            this.txtQuantidadeMinima.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeMinima.TabIndex = 3;
            this.txtQuantidadeMinima.TextChanged += new System.EventHandler(this.txtQuantidadeMinima_TextChanged);
            // 
            // txtQuantidadeMaxima
            // 
            this.txtQuantidadeMaxima.Location = new System.Drawing.Point(177, 71);
            this.txtQuantidadeMaxima.Name = "txtQuantidadeMaxima";
            this.txtQuantidadeMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeMaxima.TabIndex = 4;
            this.txtQuantidadeMaxima.TextChanged += new System.EventHandler(this.txtQuantidadeMaxima_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb.Location = new System.Drawing.Point(40, 116);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(101, 19);
            this.lb.TabIndex = 5;
            this.lb.Text = "EstoqueMedio:";
            // 
            // txtEstoqueMedio
            // 
            this.txtEstoqueMedio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEstoqueMedio.Location = new System.Drawing.Point(147, 116);
            this.txtEstoqueMedio.Name = "txtEstoqueMedio";
            this.txtEstoqueMedio.ReadOnly = true;
            this.txtEstoqueMedio.Size = new System.Drawing.Size(100, 23);
            this.txtEstoqueMedio.TabIndex = 6;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltarMenu.Location = new System.Drawing.Point(286, 300);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(129, 23);
            this.btnVoltarMenu.TabIndex = 7;
            this.btnVoltarMenu.Text = "Voltar para o menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // Questao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 335);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.txtEstoqueMedio);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtQuantidadeMaxima);
            this.Controls.Add(this.txtQuantidadeMinima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Questao1";
            this.Text = "Questao 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeMinima;
        private System.Windows.Forms.TextBox txtQuantidadeMaxima;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtEstoqueMedio;
        private System.Windows.Forms.Button btnVoltarMenu;
    }
}