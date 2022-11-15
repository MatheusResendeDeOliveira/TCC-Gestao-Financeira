﻿namespace GestaoFinanceira
{
    partial class GestaoFinanceira
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
            this.btnSalvarSalario = new System.Windows.Forms.Button();
            this.lblInsiraSalario = new System.Windows.Forms.Label();
            this.txtInsiraSalario = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSaldoGuardado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDespesasMensais = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.msktxtDataLancamento = new System.Windows.Forms.MaskedTextBox();
            this.cbbTipoDeMovimentacao = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarLancamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txAno = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarSalario
            // 
            this.btnSalvarSalario.Location = new System.Drawing.Point(217, 22);
            this.btnSalvarSalario.Name = "btnSalvarSalario";
            this.btnSalvarSalario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarSalario.TabIndex = 0;
            this.btnSalvarSalario.Text = "Salvar";
            this.btnSalvarSalario.UseVisualStyleBackColor = true;
            // 
            // lblInsiraSalario
            // 
            this.lblInsiraSalario.AutoSize = true;
            this.lblInsiraSalario.Location = new System.Drawing.Point(12, 9);
            this.lblInsiraSalario.Name = "lblInsiraSalario";
            this.lblInsiraSalario.Size = new System.Drawing.Size(72, 15);
            this.lblInsiraSalario.TabIndex = 1;
            this.lblInsiraSalario.Text = "Insira salario";
            // 
            // txtInsiraSalario
            // 
            this.txtInsiraSalario.Location = new System.Drawing.Point(12, 25);
            this.txtInsiraSalario.Name = "txtInsiraSalario";
            this.txtInsiraSalario.Size = new System.Drawing.Size(199, 23);
            this.txtInsiraSalario.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(333, 23);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(143, 23);
            this.txtSalario.TabIndex = 4;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(330, 4);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 15);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 470);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblSaldoGuardado
            // 
            this.lblSaldoGuardado.AutoSize = true;
            this.lblSaldoGuardado.Location = new System.Drawing.Point(701, 35);
            this.lblSaldoGuardado.Name = "lblSaldoGuardado";
            this.lblSaldoGuardado.Size = new System.Drawing.Size(47, 15);
            this.lblSaldoGuardado.TabIndex = 10;
            this.lblSaldoGuardado.Text = "R$ 2300";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saldo guardado";
            // 
            // lblDespesasMensais
            // 
            this.lblDespesasMensais.AutoSize = true;
            this.lblDespesasMensais.Location = new System.Drawing.Point(701, 9);
            this.lblDespesasMensais.Name = "lblDespesasMensais";
            this.lblDespesasMensais.Size = new System.Drawing.Size(47, 15);
            this.lblDespesasMensais.TabIndex = 12;
            this.lblDespesasMensais.Text = "R$ 1700";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Despesas mensais:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 23);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(406, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 23);
            this.textBox4.TabIndex = 17;
            // 
            // msktxtDataLancamento
            // 
            this.msktxtDataLancamento.Location = new System.Drawing.Point(0, 54);
            this.msktxtDataLancamento.Mask = "00/00/0000";
            this.msktxtDataLancamento.Name = "msktxtDataLancamento";
            this.msktxtDataLancamento.Size = new System.Drawing.Size(64, 23);
            this.msktxtDataLancamento.TabIndex = 18;
            this.msktxtDataLancamento.ValidatingType = typeof(System.DateTime);
            // 
            // cbbTipoDeMovimentacao
            // 
            this.cbbTipoDeMovimentacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDeMovimentacao.FormattingEnabled = true;
            this.cbbTipoDeMovimentacao.Location = new System.Drawing.Point(70, 54);
            this.cbbTipoDeMovimentacao.Name = "cbbTipoDeMovimentacao";
            this.cbbTipoDeMovimentacao.Size = new System.Drawing.Size(121, 23);
            this.cbbTipoDeMovimentacao.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionarLancamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.msktxtDataLancamento);
            this.groupBox1.Controls.Add(this.cbbTipoDeMovimentacao);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 567);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnAdicionarLancamento
            // 
            this.btnAdicionarLancamento.Location = new System.Drawing.Point(639, 50);
            this.btnAdicionarLancamento.Name = "btnAdicionarLancamento";
            this.btnAdicionarLancamento.Size = new System.Drawing.Size(102, 28);
            this.btnAdicionarLancamento.TabIndex = 25;
            this.btnAdicionarLancamento.Text = "Adicionar";
            this.btnAdicionarLancamento.UseVisualStyleBackColor = true;
            this.btnAdicionarLancamento.Click += new System.EventHandler(this.btnAdicionarLancamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo de movimentação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data";
            // 
            // cbbMes
            // 
            this.cbbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMes.FormattingEnabled = true;
            this.cbbMes.Location = new System.Drawing.Point(97, 81);
            this.cbbMes.Name = "cbbMes";
            this.cbbMes.Size = new System.Drawing.Size(114, 23);
            this.cbbMes.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mês";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ano";
            // 
            // txAno
            // 
            this.txAno.Location = new System.Drawing.Point(12, 81);
            this.txAno.Name = "txAno";
            this.txAno.Size = new System.Drawing.Size(72, 23);
            this.txAno.TabIndex = 26;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(217, 80);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 27;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // GestaoFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 693);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txAno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDespesasMensais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSaldoGuardado);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblInsiraSalario);
            this.Controls.Add(this.txtInsiraSalario);
            this.Controls.Add(this.btnSalvarSalario);
            this.Name = "GestaoFinanceira";
            this.Text = "GestaoFinanceira";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInsiraSalario;
        private System.Windows.Forms.TextBox txtInsiraSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSaldoGuardado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDespesasMensais;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnSalvarSalario;
        private TextBox textBox3;
        private TextBox textBox4;
        private MaskedTextBox msktxtDataLancamento;
        private ComboBox cbbTipoDeMovimentacao;
        private GroupBox groupBox1;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdicionarLancamento;
        private ComboBox cbbMes;
        private Label label6;
        private Label label8;
        private TextBox txAno;
        private Button btnFiltrar;
    }
}