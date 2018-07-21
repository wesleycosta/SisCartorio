namespace AplicacaoWindowsForm.Telas.Relatorio
{
	partial class FrmCadModeloRelatorio
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
			this.btnConfimar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.tbTitulo = new System.Windows.Forms.TextBox();
			this.cbTipoDeRegistro = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCampoData = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gbCondicao = new System.Windows.Forms.GroupBox();
			this.tbValorCondicional01 = new System.Windows.Forms.TextBox();
			this.cbOperadorCondicional01 = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbOperadorLogico = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbCampoCondicional01 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbValorCondicional02 = new System.Windows.Forms.TextBox();
			this.cbOperadorCondicional02 = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbCampoCondicional02 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbAplicarCondicao = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbImprimirCabecalho = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbImprimirSumario = new System.Windows.Forms.ComboBox();
			this.cbImprimirRodape = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pnCondicao02 = new System.Windows.Forms.Panel();
			this.gbCondicao.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.pnCondicao02.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConfimar
			// 
			this.btnConfimar.Location = new System.Drawing.Point(344, 415);
			this.btnConfimar.Name = "btnConfimar";
			this.btnConfimar.Size = new System.Drawing.Size(75, 23);
			this.btnConfimar.TabIndex = 4;
			this.btnConfimar.Text = "Confirmar";
			this.btnConfimar.UseVisualStyleBackColor = true;
			this.btnConfimar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(425, 415);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// tbTitulo
			// 
			this.tbTitulo.Location = new System.Drawing.Point(15, 27);
			this.tbTitulo.Name = "tbTitulo";
			this.tbTitulo.Size = new System.Drawing.Size(485, 20);
			this.tbTitulo.TabIndex = 0;
			this.tbTitulo.Tag = "Título";
			// 
			// cbTipoDeRegistro
			// 
			this.cbTipoDeRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoDeRegistro.FormattingEnabled = true;
			this.cbTipoDeRegistro.Items.AddRange(new object[] {
            "Nascimento",
            "Casamento",
            "Óbito"});
			this.cbTipoDeRegistro.Location = new System.Drawing.Point(13, 40);
			this.cbTipoDeRegistro.Name = "cbTipoDeRegistro";
			this.cbTipoDeRegistro.Size = new System.Drawing.Size(128, 21);
			this.cbTipoDeRegistro.TabIndex = 2;
			this.cbTipoDeRegistro.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeRegistro_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Título:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tipo do registro:";
			// 
			// cbCampoData
			// 
			this.cbCampoData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCampoData.FormattingEnabled = true;
			this.cbCampoData.Location = new System.Drawing.Point(147, 40);
			this.cbCampoData.Name = "cbCampoData";
			this.cbCampoData.Size = new System.Drawing.Size(210, 21);
			this.cbCampoData.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(147, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Campo de data:";
			// 
			// gbCondicao
			// 
			this.gbCondicao.Controls.Add(this.pnCondicao02);
			this.gbCondicao.Controls.Add(this.tbValorCondicional01);
			this.gbCondicao.Controls.Add(this.cbOperadorCondicional01);
			this.gbCondicao.Controls.Add(this.label13);
			this.gbCondicao.Controls.Add(this.label8);
			this.gbCondicao.Controls.Add(this.cbOperadorLogico);
			this.gbCondicao.Controls.Add(this.label7);
			this.gbCondicao.Controls.Add(this.cbCampoCondicional01);
			this.gbCondicao.Controls.Add(this.label5);
			this.gbCondicao.Location = new System.Drawing.Point(12, 133);
			this.gbCondicao.Name = "gbCondicao";
			this.gbCondicao.Size = new System.Drawing.Size(488, 187);
			this.gbCondicao.TabIndex = 2;
			this.gbCondicao.TabStop = false;
			this.gbCondicao.Text = "Condição";
			// 
			// tbValorCondicional01
			// 
			this.tbValorCondicional01.Location = new System.Drawing.Point(365, 48);
			this.tbValorCondicional01.Name = "tbValorCondicional01";
			this.tbValorCondicional01.Size = new System.Drawing.Size(109, 20);
			this.tbValorCondicional01.TabIndex = 4;
			this.tbValorCondicional01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbOperadorCondicional01
			// 
			this.cbOperadorCondicional01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOperadorCondicional01.FormattingEnabled = true;
			this.cbOperadorCondicional01.Items.AddRange(new object[] {
            "Igual a",
            "Diferente de ",
            "Maior que",
            "Maior ou igual a",
            "Menor que",
            "Menor ou igual a"});
			this.cbOperadorCondicional01.Location = new System.Drawing.Point(229, 48);
			this.cbOperadorCondicional01.Name = "cbOperadorCondicional01";
			this.cbOperadorCondicional01.Size = new System.Drawing.Size(130, 21);
			this.cbOperadorCondicional01.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(362, 32);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(34, 13);
			this.label13.TabIndex = 3;
			this.label13.Text = "Valor:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(226, 28);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Operador condicional 01:";
			// 
			// cbOperadorLogico
			// 
			this.cbOperadorLogico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOperadorLogico.FormattingEnabled = true;
			this.cbOperadorLogico.Items.AddRange(new object[] {
            "Selecione...",
            "E",
            "OU"});
			this.cbOperadorLogico.Location = new System.Drawing.Point(13, 100);
			this.cbOperadorLogico.Name = "cbOperadorLogico";
			this.cbOperadorLogico.Size = new System.Drawing.Size(208, 21);
			this.cbOperadorLogico.TabIndex = 2;
			this.cbOperadorLogico.SelectedIndexChanged += new System.EventHandler(this.cbOperadorLogico_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Operador lógico:";
			// 
			// cbCampoCondicional01
			// 
			this.cbCampoCondicional01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCampoCondicional01.FormattingEnabled = true;
			this.cbCampoCondicional01.Location = new System.Drawing.Point(13, 48);
			this.cbCampoCondicional01.Name = "cbCampoCondicional01";
			this.cbCampoCondicional01.Size = new System.Drawing.Size(210, 21);
			this.cbCampoCondicional01.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Campo 01:";
			// 
			// tbValorCondicional02
			// 
			this.tbValorCondicional02.Location = new System.Drawing.Point(355, 20);
			this.tbValorCondicional02.Name = "tbValorCondicional02";
			this.tbValorCondicional02.Size = new System.Drawing.Size(111, 20);
			this.tbValorCondicional02.TabIndex = 4;
			this.tbValorCondicional02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbOperadorCondicional02
			// 
			this.cbOperadorCondicional02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOperadorCondicional02.FormattingEnabled = true;
			this.cbOperadorCondicional02.Items.AddRange(new object[] {
            "Igual a",
            "Diferente de ",
            "Maior que",
            "Maior ou igual a",
            "Menor que",
            "Menor ou igual a"});
			this.cbOperadorCondicional02.Location = new System.Drawing.Point(222, 19);
			this.cbOperadorCondicional02.Name = "cbOperadorCondicional02";
			this.cbOperadorCondicional02.Size = new System.Drawing.Size(127, 21);
			this.cbOperadorCondicional02.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(354, 3);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Valor:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(219, 3);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(126, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Operador condicional 02:";
			// 
			// cbCampoCondicional02
			// 
			this.cbCampoCondicional02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCampoCondicional02.FormattingEnabled = true;
			this.cbCampoCondicional02.Location = new System.Drawing.Point(5, 19);
			this.cbCampoCondicional02.Name = "cbCampoCondicional02";
			this.cbCampoCondicional02.Size = new System.Drawing.Size(208, 21);
			this.cbCampoCondicional02.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(2, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Campo 02:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbAplicarCondicao);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.cbTipoDeRegistro);
			this.groupBox2.Controls.Add(this.cbCampoData);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(12, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(488, 74);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filtro";
			// 
			// cbAplicarCondicao
			// 
			this.cbAplicarCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAplicarCondicao.FormattingEnabled = true;
			this.cbAplicarCondicao.Items.AddRange(new object[] {
            "Sim",
            "Não"});
			this.cbAplicarCondicao.Location = new System.Drawing.Point(363, 40);
			this.cbAplicarCondicao.Name = "cbAplicarCondicao";
			this.cbAplicarCondicao.Size = new System.Drawing.Size(111, 21);
			this.cbAplicarCondicao.TabIndex = 7;
			this.cbAplicarCondicao.SelectedIndexChanged += new System.EventHandler(this.cbAplicarCondicao_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(362, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Aplicar Condição:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(154, 13);
			this.label11.TabIndex = 8;
			this.label11.Text = "Imprimir área de cabeçalho em:";
			// 
			// cbImprimirCabecalho
			// 
			this.cbImprimirCabecalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImprimirCabecalho.FormattingEnabled = true;
			this.cbImprimirCabecalho.Items.AddRange(new object[] {
            "Todas as páginas",
            "Apenas na primeira página"});
			this.cbImprimirCabecalho.Location = new System.Drawing.Point(13, 43);
			this.cbImprimirCabecalho.Name = "cbImprimirCabecalho";
			this.cbImprimirCabecalho.Size = new System.Drawing.Size(160, 21);
			this.cbImprimirCabecalho.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbImprimirSumario);
			this.groupBox3.Controls.Add(this.cbImprimirRodape);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.cbImprimirCabecalho);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Location = new System.Drawing.Point(12, 326);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(488, 83);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Outras informações";
			// 
			// cbImprimirSumario
			// 
			this.cbImprimirSumario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImprimirSumario.FormattingEnabled = true;
			this.cbImprimirSumario.Items.AddRange(new object[] {
            "Sim",
            "Não"});
			this.cbImprimirSumario.Location = new System.Drawing.Point(344, 43);
			this.cbImprimirSumario.Name = "cbImprimirSumario";
			this.cbImprimirSumario.Size = new System.Drawing.Size(130, 21);
			this.cbImprimirSumario.TabIndex = 7;
			// 
			// cbImprimirRodape
			// 
			this.cbImprimirRodape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImprimirRodape.FormattingEnabled = true;
			this.cbImprimirRodape.Items.AddRange(new object[] {
            "Todas as páginas",
            "Apenas na primeira página"});
			this.cbImprimirRodape.Location = new System.Drawing.Point(179, 43);
			this.cbImprimirRodape.Name = "cbImprimirRodape";
			this.cbImprimirRodape.Size = new System.Drawing.Size(159, 21);
			this.cbImprimirRodape.TabIndex = 7;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(341, 27);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(123, 13);
			this.label15.TabIndex = 8;
			this.label15.Text = "Imprimir área de sumário:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(176, 27);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(120, 13);
			this.label14.TabIndex = 8;
			this.label14.Text = "Imprimir área de rodapé:";
			// 
			// pnCondicao02
			// 
			this.pnCondicao02.Controls.Add(this.tbValorCondicional02);
			this.pnCondicao02.Controls.Add(this.cbCampoCondicional02);
			this.pnCondicao02.Controls.Add(this.label9);
			this.pnCondicao02.Controls.Add(this.cbOperadorCondicional02);
			this.pnCondicao02.Controls.Add(this.label10);
			this.pnCondicao02.Controls.Add(this.label12);
			this.pnCondicao02.Location = new System.Drawing.Point(8, 128);
			this.pnCondicao02.Name = "pnCondicao02";
			this.pnCondicao02.Size = new System.Drawing.Size(476, 48);
			this.pnCondicao02.TabIndex = 6;
			// 
			// FrmCadModeloRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 445);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbCondicao);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbTitulo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfimar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCadModeloRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerar Relatório";
			this.gbCondicao.ResumeLayout(false);
			this.gbCondicao.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.pnCondicao02.ResumeLayout(false);
			this.pnCondicao02.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfimar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox tbTitulo;
		private System.Windows.Forms.ComboBox cbTipoDeRegistro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCampoData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox gbCondicao;
		private System.Windows.Forms.ComboBox cbOperadorCondicional02;
		private System.Windows.Forms.ComboBox cbOperadorCondicional01;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbOperadorLogico;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbCampoCondicional02;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbCampoCondicional01;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbImprimirCabecalho;
		private System.Windows.Forms.TextBox tbValorCondicional02;
		private System.Windows.Forms.TextBox tbValorCondicional01;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cbImprimirRodape;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbImprimirSumario;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cbAplicarCondicao;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel pnCondicao02;
	}
}