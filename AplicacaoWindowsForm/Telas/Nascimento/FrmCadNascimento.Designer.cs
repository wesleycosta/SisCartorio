namespace AplicacaoWindowsForm.Telas.Nascimento
{
	partial class FrmCadNascimento
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
			this.tbNomeLivro = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbNumeroRegistro = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPosicaoFolha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbNumeroFolha = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNumeroLivro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbDataNascimento = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbCidade = new System.Windows.Forms.TextBox();
			this.tbNomeDeclarante = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbNomeMae = new System.Windows.Forms.TextBox();
			this.tbCodigoDeclarante = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbIdadePai = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbUF = new System.Windows.Forms.TextBox();
			this.tbNomePai = new System.Windows.Forms.TextBox();
			this.tbNomeRegistrado = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbNomeLivro
			// 
			this.tbNomeLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNomeLivro.Location = new System.Drawing.Point(15, 40);
			this.tbNomeLivro.MaxLength = 255;
			this.tbNomeLivro.Name = "tbNomeLivro";
			this.tbNomeLivro.Size = new System.Drawing.Size(201, 20);
			this.tbNomeLivro.TabIndex = 0;
			this.tbNomeLivro.Tag = "Nome do Livro";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbNumeroRegistro);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbPosicaoFolha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbNumeroFolha);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbNumeroLivro);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbNomeLivro);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(542, 76);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Básicos";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(452, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Nº Registro:";
			// 
			// tbNumeroRegistro
			// 
			this.tbNumeroRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNumeroRegistro.Location = new System.Drawing.Point(452, 40);
			this.tbNumeroRegistro.MaxLength = 5;
			this.tbNumeroRegistro.Name = "tbNumeroRegistro";
			this.tbNumeroRegistro.Size = new System.Drawing.Size(76, 20);
			this.tbNumeroRegistro.TabIndex = 4;
			this.tbNumeroRegistro.Tag = "Nº Registro";
			this.tbNumeroRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(357, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Posição Folha:";
			// 
			// tbPosicaoFolha
			// 
			this.tbPosicaoFolha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbPosicaoFolha.Location = new System.Drawing.Point(360, 40);
			this.tbPosicaoFolha.MaxLength = 1;
			this.tbPosicaoFolha.Name = "tbPosicaoFolha";
			this.tbPosicaoFolha.Size = new System.Drawing.Size(86, 20);
			this.tbPosicaoFolha.TabIndex = 3;
			this.tbPosicaoFolha.Tag = "Posição Folha";
			this.tbPosicaoFolha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(288, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nº Folha:";
			// 
			// tbNumeroFolha
			// 
			this.tbNumeroFolha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNumeroFolha.Location = new System.Drawing.Point(291, 40);
			this.tbNumeroFolha.MaxLength = 5;
			this.tbNumeroFolha.Name = "tbNumeroFolha";
			this.tbNumeroFolha.Size = new System.Drawing.Size(63, 20);
			this.tbNumeroFolha.TabIndex = 2;
			this.tbNumeroFolha.Tag = "Nº Folha";
			this.tbNumeroFolha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(219, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nº Livro:";
			// 
			// tbNumeroLivro
			// 
			this.tbNumeroLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNumeroLivro.Location = new System.Drawing.Point(222, 40);
			this.tbNumeroLivro.MaxLength = 5;
			this.tbNumeroLivro.Name = "tbNumeroLivro";
			this.tbNumeroLivro.Size = new System.Drawing.Size(63, 20);
			this.tbNumeroLivro.TabIndex = 1;
			this.tbNumeroLivro.Tag = "Nº Livro";
			this.tbNumeroLivro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome do Livro:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(479, 361);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(398, 361);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 2;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbDataNascimento);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.tbCidade);
			this.groupBox2.Controls.Add(this.tbNomeDeclarante);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.tbNomeMae);
			this.groupBox2.Controls.Add(this.tbCodigoDeclarante);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.tbIdadePai);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.tbUF);
			this.groupBox2.Controls.Add(this.tbNomePai);
			this.groupBox2.Controls.Add(this.tbNomeRegistrado);
			this.groupBox2.Location = new System.Drawing.Point(12, 94);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(542, 261);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados Básicos";
			// 
			// tbDataNascimento
			// 
			this.tbDataNascimento.CustomFormat = "";
			this.tbDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tbDataNascimento.Location = new System.Drawing.Point(425, 40);
			this.tbDataNascimento.Name = "tbDataNascimento";
			this.tbDataNascimento.Size = new System.Drawing.Size(103, 20);
			this.tbDataNascimento.TabIndex = 1;
			this.tbDataNascimento.Tag = "Data Nascimento";
			this.tbDataNascimento.Value = new System.DateTime(2018, 6, 23, 0, 0, 0, 0);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(15, 214);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(43, 13);
			this.label13.TabIndex = 7;
			this.label13.Text = "Cidade:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(133, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Nome Declarante:";
			// 
			// tbCidade
			// 
			this.tbCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbCidade.Location = new System.Drawing.Point(15, 230);
			this.tbCidade.MaxLength = 255;
			this.tbCidade.Name = "tbCidade";
			this.tbCidade.Size = new System.Drawing.Size(428, 20);
			this.tbCidade.TabIndex = 7;
			this.tbCidade.Tag = "Cidade";
			// 
			// tbNomeDeclarante
			// 
			this.tbNomeDeclarante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNomeDeclarante.Location = new System.Drawing.Point(136, 89);
			this.tbNomeDeclarante.MaxLength = 255;
			this.tbNomeDeclarante.Name = "tbNomeDeclarante";
			this.tbNomeDeclarante.Size = new System.Drawing.Size(392, 20);
			this.tbNomeDeclarante.TabIndex = 3;
			this.tbNomeDeclarante.Tag = "Nome Declarante";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 167);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 13);
			this.label12.TabIndex = 5;
			this.label12.Text = "Nome da Mae:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Código Declarante:";
			// 
			// tbNomeMae
			// 
			this.tbNomeMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNomeMae.Location = new System.Drawing.Point(15, 183);
			this.tbNomeMae.MaxLength = 255;
			this.tbNomeMae.Name = "tbNomeMae";
			this.tbNomeMae.Size = new System.Drawing.Size(513, 20);
			this.tbNomeMae.TabIndex = 6;
			this.tbNomeMae.Tag = "Nome da Mae";
			// 
			// tbCodigoDeclarante
			// 
			this.tbCodigoDeclarante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbCodigoDeclarante.Location = new System.Drawing.Point(15, 89);
			this.tbCodigoDeclarante.MaxLength = 1;
			this.tbCodigoDeclarante.Name = "tbCodigoDeclarante";
			this.tbCodigoDeclarante.Size = new System.Drawing.Size(112, 20);
			this.tbCodigoDeclarante.TabIndex = 2;
			this.tbCodigoDeclarante.Tag = "Código Declarante";
			this.tbCodigoDeclarante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(452, 121);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(70, 13);
			this.label11.TabIndex = 1;
			this.label11.Text = "Idade do Pai:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(422, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(92, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Data Nascimento:";
			// 
			// tbIdadePai
			// 
			this.tbIdadePai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbIdadePai.Location = new System.Drawing.Point(452, 137);
			this.tbIdadePai.MaxLength = 3;
			this.tbIdadePai.Name = "tbIdadePai";
			this.tbIdadePai.Size = new System.Drawing.Size(76, 20);
			this.tbIdadePai.TabIndex = 5;
			this.tbIdadePai.Tag = "Idade do Pai";
			this.tbIdadePai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(452, 214);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(24, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "UF:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(15, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Nome do Pai:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(15, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(92, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Nome Registrado:";
			// 
			// tbUF
			// 
			this.tbUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbUF.Location = new System.Drawing.Point(452, 230);
			this.tbUF.MaxLength = 2;
			this.tbUF.Name = "tbUF";
			this.tbUF.Size = new System.Drawing.Size(76, 20);
			this.tbUF.TabIndex = 8;
			this.tbUF.Tag = "UF";
			this.tbUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbNomePai
			// 
			this.tbNomePai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNomePai.Location = new System.Drawing.Point(15, 137);
			this.tbNomePai.MaxLength = 255;
			this.tbNomePai.Name = "tbNomePai";
			this.tbNomePai.Size = new System.Drawing.Size(431, 20);
			this.tbNomePai.TabIndex = 4;
			this.tbNomePai.Tag = "Nome do Pai";
			// 
			// tbNomeRegistrado
			// 
			this.tbNomeRegistrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNomeRegistrado.Location = new System.Drawing.Point(15, 40);
			this.tbNomeRegistrado.MaxLength = 255;
			this.tbNomeRegistrado.Name = "tbNomeRegistrado";
			this.tbNomeRegistrado.Size = new System.Drawing.Size(404, 20);
			this.tbNomeRegistrado.TabIndex = 0;
			this.tbNomeRegistrado.Tag = "Nome Registrado";
			// 
			// FrmCadNascimento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 390);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCadNascimento";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro de Nascimento";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tbNomeLivro;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNumeroLivro;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbNumeroFolha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPosicaoFolha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbNumeroRegistro;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbNomeDeclarante;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbCodigoDeclarante;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbNomeRegistrado;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbCidade;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbNomeMae;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbIdadePai;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbNomePai;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tbUF;
		private System.Windows.Forms.DateTimePicker tbDataNascimento;
	}
}