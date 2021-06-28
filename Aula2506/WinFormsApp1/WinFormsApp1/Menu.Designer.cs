
namespace Questoes
{
    partial class Menu
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
            this.btnQuestao1 = new System.Windows.Forms.Button();
            this.btnQuestão2 = new System.Windows.Forms.Button();
            this.btnQuestao3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Questões";
            // 
            // btnQuestao1
            // 
            this.btnQuestao1.Location = new System.Drawing.Point(12, 97);
            this.btnQuestao1.Name = "btnQuestao1";
            this.btnQuestao1.Size = new System.Drawing.Size(75, 23);
            this.btnQuestao1.TabIndex = 1;
            this.btnQuestao1.Text = "1";
            this.btnQuestao1.UseVisualStyleBackColor = true;
            this.btnQuestao1.Click += new System.EventHandler(this.btnQuestao1_Click);
            // 
            // btnQuestão2
            // 
            this.btnQuestão2.Location = new System.Drawing.Point(12, 142);
            this.btnQuestão2.Name = "btnQuestão2";
            this.btnQuestão2.Size = new System.Drawing.Size(75, 23);
            this.btnQuestão2.TabIndex = 2;
            this.btnQuestão2.Text = "2";
            this.btnQuestão2.UseVisualStyleBackColor = true;
            this.btnQuestão2.Click += new System.EventHandler(this.btnQuestão2_Click);
            // 
            // btnQuestao3
            // 
            this.btnQuestao3.Location = new System.Drawing.Point(12, 186);
            this.btnQuestao3.Name = "btnQuestao3";
            this.btnQuestao3.Size = new System.Drawing.Size(75, 23);
            this.btnQuestao3.TabIndex = 3;
            this.btnQuestao3.Text = "3";
            this.btnQuestao3.UseVisualStyleBackColor = true;
            this.btnQuestao3.Click += new System.EventHandler(this.btnQuestao3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(427, 335);
            this.Controls.Add(this.btnQuestao3);
            this.Controls.Add(this.btnQuestão2);
            this.Controls.Add(this.btnQuestao1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuestao1;
        private System.Windows.Forms.Button btnQuestão2;
        private System.Windows.Forms.Button btnQuestao3;
    }
}