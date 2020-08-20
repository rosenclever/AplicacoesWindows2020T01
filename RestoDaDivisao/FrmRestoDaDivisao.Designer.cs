namespace RestoDaDivisao
{
    partial class FrmRestoDaDivisao
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
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnReaizarDivisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dividendo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(190, 34);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(200, 39);
            this.txtDividendo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Divisor:";
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(545, 37);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(200, 39);
            this.txtDivisor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resto:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(545, 130);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(200, 39);
            this.txtResultado.TabIndex = 3;
            // 
            // btnReaizarDivisao
            // 
            this.btnReaizarDivisao.Location = new System.Drawing.Point(69, 134);
            this.btnReaizarDivisao.Name = "btnReaizarDivisao";
            this.btnReaizarDivisao.Size = new System.Drawing.Size(321, 43);
            this.btnReaizarDivisao.TabIndex = 4;
            this.btnReaizarDivisao.Text = "Realizar Dvisao";
            this.btnReaizarDivisao.UseVisualStyleBackColor = true;
            this.btnReaizarDivisao.Click += new System.EventHandler(this.btnReaizarDivisao_Click);
            // 
            // FrmRestoDaDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 220);
            this.Controls.Add(this.btnReaizarDivisao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRestoDaDivisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resto da Divisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnReaizarDivisao;
    }
}