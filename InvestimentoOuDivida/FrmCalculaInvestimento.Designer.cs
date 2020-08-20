namespace InvestimentoOuDivida
{
    partial class FrmCalculaInvestimento
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbInvestimento = new System.Windows.Forms.RadioButton();
            this.rdbDivida = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(170, 48);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 31);
            this.txtValor.TabIndex = 1;
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(476, 51);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(100, 31);
            this.txtPercentual.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            // 
            // rdbInvestimento
            // 
            this.rdbInvestimento.AutoSize = true;
            this.rdbInvestimento.Checked = true;
            this.rdbInvestimento.Location = new System.Drawing.Point(170, 112);
            this.rdbInvestimento.Name = "rdbInvestimento";
            this.rdbInvestimento.Size = new System.Drawing.Size(164, 29);
            this.rdbInvestimento.TabIndex = 4;
            this.rdbInvestimento.TabStop = true;
            this.rdbInvestimento.Text = "Investimento";
            this.rdbInvestimento.UseVisualStyleBackColor = true;
            this.rdbInvestimento.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbDivida
            // 
            this.rdbDivida.AutoSize = true;
            this.rdbDivida.Location = new System.Drawing.Point(372, 112);
            this.rdbDivida.Name = "rdbDivida";
            this.rdbDivida.Size = new System.Drawing.Size(103, 29);
            this.rdbDivida.TabIndex = 5;
            this.rdbDivida.Text = "Divida";
            this.rdbDivida.UseVisualStyleBackColor = true;
            this.rdbDivida.CheckedChanged += new System.EventHandler(this.rdbDivida_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Yellow;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(385, 257);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(146, 31);
            this.txtResultado.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblResultado.Location = new System.Drawing.Point(225, 260);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(154, 25);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Lucro Obtido:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(123, 180);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(452, 49);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCalculaInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rdbDivida);
            this.Controls.Add(this.rdbInvestimento);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCalculaInvestimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculaInvestimento";
            this.Load += new System.EventHandler(this.FrmCalculaInvestimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbInvestimento;
        private System.Windows.Forms.RadioButton rdbDivida;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}