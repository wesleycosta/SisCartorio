namespace AplicacaoWindowsForm.Telas.Relatorio
{
	partial class FrmCadAtributo
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnConfimar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbTamanho = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbTitulo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbAlinhamento = new System.Windows.Forms.ComboBox();
			this.cbCampo = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbTamanho)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(301, 150);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnConfimar
			// 
			this.btnConfimar.Location = new System.Drawing.Point(220, 150);
			this.btnConfimar.Name = "btnConfimar";
			this.btnConfimar.Size = new System.Drawing.Size(75, 23);
			this.btnConfimar.TabIndex = 1;
			this.btnConfimar.Text = "Confirmar";
			this.btnConfimar.UseVisualStyleBackColor = true;
			this.btnConfimar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbTamanho);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbTitulo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbAlinhamento);
			this.groupBox1.Controls.Add(this.cbCampo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 132);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Layout da Coluna";
			// 
			// tbTamanho
			// 
			this.tbTamanho.Location = new System.Drawing.Point(21, 96);
			this.tbTamanho.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
			this.tbTamanho.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.tbTamanho.Name = "tbTamanho";
			this.tbTamanho.Size = new System.Drawing.Size(149, 20);
			this.tbTamanho.TabIndex = 2;
			this.tbTamanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbTamanho.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(18, 78);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(142, 13);
			this.label13.TabIndex = 16;
			this.label13.Text = "Tamanho da coluna (em px):";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(173, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Título da coluna:";
			// 
			// tbTitulo
			// 
			this.tbTitulo.Location = new System.Drawing.Point(176, 43);
			this.tbTitulo.Name = "tbTitulo";
			this.tbTitulo.Size = new System.Drawing.Size(170, 20);
			this.tbTitulo.TabIndex = 1;
			this.tbTitulo.Tag = "Título da coluna";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(173, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Alinhamento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Campo:";
			// 
			// cbAlinhamento
			// 
			this.cbAlinhamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAlinhamento.FormattingEnabled = true;
			this.cbAlinhamento.Items.AddRange(new object[] {
            "Centralizado",
            "Direita",
            "Esquerda"});
			this.cbAlinhamento.Location = new System.Drawing.Point(176, 95);
			this.cbAlinhamento.Name = "cbAlinhamento";
			this.cbAlinhamento.Size = new System.Drawing.Size(170, 21);
			this.cbAlinhamento.TabIndex = 3;
			// 
			// cbCampo
			// 
			this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCampo.FormattingEnabled = true;
			this.cbCampo.Location = new System.Drawing.Point(21, 43);
			this.cbCampo.Name = "cbCampo";
			this.cbCampo.Size = new System.Drawing.Size(149, 21);
			this.cbCampo.TabIndex = 0;
			// 
			// FrmCadAtributo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 181);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfimar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCadAtributo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Coluna";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbTamanho)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnConfimar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbTitulo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbAlinhamento;
		private System.Windows.Forms.ComboBox cbCampo;
		private System.Windows.Forms.NumericUpDown tbTamanho;
	}
}