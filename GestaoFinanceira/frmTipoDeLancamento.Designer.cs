namespace GestaoFinanceira
{
    partial class frmTipoDeLancamento
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
            this.txtCadastroTipoDeLancamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroDeTipoDeLancamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCadastroTipoDeLancamento
            // 
            this.txtCadastroTipoDeLancamento.Location = new System.Drawing.Point(12, 31);
            this.txtCadastroTipoDeLancamento.Name = "txtCadastroTipoDeLancamento";
            this.txtCadastroTipoDeLancamento.Size = new System.Drawing.Size(158, 23);
            this.txtCadastroTipoDeLancamento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de lançamento";
            // 
            // btnCadastroDeTipoDeLancamento
            // 
            this.btnCadastroDeTipoDeLancamento.Location = new System.Drawing.Point(176, 12);
            this.btnCadastroDeTipoDeLancamento.Name = "btnCadastroDeTipoDeLancamento";
            this.btnCadastroDeTipoDeLancamento.Size = new System.Drawing.Size(111, 26);
            this.btnCadastroDeTipoDeLancamento.TabIndex = 2;
            this.btnCadastroDeTipoDeLancamento.Text = "Cadastrar";
            this.btnCadastroDeTipoDeLancamento.UseVisualStyleBackColor = true;
            // 
            // frmTipoDeLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 70);
            this.Controls.Add(this.btnCadastroDeTipoDeLancamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadastroTipoDeLancamento);
            this.Name = "frmTipoDeLancamento";
            this.Text = "Cadastro de tipo de lancamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCadastroTipoDeLancamento;
        private Label label1;
        private Button btnCadastroDeTipoDeLancamento;
    }
}