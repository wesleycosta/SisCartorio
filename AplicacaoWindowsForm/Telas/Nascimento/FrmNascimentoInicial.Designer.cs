namespace AplicacaoWindowsForm.Telas.Nascimento
{
	partial class FrmNascimentoInicial
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbCadastrar = new System.Windows.Forms.Label();
			this.pbCadastrar = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pbRemover = new System.Windows.Forms.PictureBox();
			this.lbRemover = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbEditar = new System.Windows.Forms.PictureBox();
			this.lbEditar = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbPesquisa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvwDados = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Location = new System.Drawing.Point(505, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(225, 91);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ações";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbCadastrar);
			this.panel1.Controls.Add(this.pbCadastrar);
			this.panel1.Location = new System.Drawing.Point(8, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(64, 64);
			this.panel1.TabIndex = 3;
			// 
			// lbCadastrar
			// 
			this.lbCadastrar.AutoSize = true;
			this.lbCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbCadastrar.Location = new System.Drawing.Point(6, 44);
			this.lbCadastrar.Name = "lbCadastrar";
			this.lbCadastrar.Size = new System.Drawing.Size(52, 13);
			this.lbCadastrar.TabIndex = 4;
			this.lbCadastrar.Text = "Cadastrar";
			this.lbCadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
			// 
			// pbCadastrar
			// 
			this.pbCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbCadastrar.Image = global::AplicacaoWindowsForm.Properties.Resources.AddItem_32x32;
			this.pbCadastrar.Location = new System.Drawing.Point(16, 8);
			this.pbCadastrar.Name = "pbCadastrar";
			this.pbCadastrar.Size = new System.Drawing.Size(32, 32);
			this.pbCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbCadastrar.TabIndex = 4;
			this.pbCadastrar.TabStop = false;
			this.pbCadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pbRemover);
			this.panel3.Controls.Add(this.lbRemover);
			this.panel3.Location = new System.Drawing.Point(148, 19);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(64, 64);
			this.panel3.TabIndex = 3;
			// 
			// pbRemover
			// 
			this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbRemover.Image = global::AplicacaoWindowsForm.Properties.Resources.Clear_32x32;
			this.pbRemover.Location = new System.Drawing.Point(16, 8);
			this.pbRemover.Name = "pbRemover";
			this.pbRemover.Size = new System.Drawing.Size(32, 32);
			this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbRemover.TabIndex = 2;
			this.pbRemover.TabStop = false;
			this.pbRemover.Click += new System.EventHandler(this.pbRemover_Click);
			// 
			// lbRemover
			// 
			this.lbRemover.AutoSize = true;
			this.lbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbRemover.Location = new System.Drawing.Point(7, 44);
			this.lbRemover.Name = "lbRemover";
			this.lbRemover.Size = new System.Drawing.Size(50, 13);
			this.lbRemover.TabIndex = 4;
			this.lbRemover.Text = "Remover";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pbEditar);
			this.panel2.Controls.Add(this.lbEditar);
			this.panel2.Location = new System.Drawing.Point(78, 19);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(64, 64);
			this.panel2.TabIndex = 3;
			// 
			// pbEditar
			// 
			this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbEditar.Image = global::AplicacaoWindowsForm.Properties.Resources.Edit_32x32;
			this.pbEditar.Location = new System.Drawing.Point(16, 8);
			this.pbEditar.Name = "pbEditar";
			this.pbEditar.Size = new System.Drawing.Size(32, 32);
			this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbEditar.TabIndex = 3;
			this.pbEditar.TabStop = false;
			this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
			// 
			// lbEditar
			// 
			this.lbEditar.AutoSize = true;
			this.lbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbEditar.Location = new System.Drawing.Point(15, 44);
			this.lbEditar.Name = "lbEditar";
			this.lbEditar.Size = new System.Drawing.Size(34, 13);
			this.lbEditar.TabIndex = 4;
			this.lbEditar.Text = "Editar";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbPesquisa);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(487, 91);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pesquisar";
			// 
			// tbPesquisa
			// 
			this.tbPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbPesquisa.Location = new System.Drawing.Point(23, 48);
			this.tbPesquisa.Name = "tbPesquisa";
			this.tbPesquisa.Size = new System.Drawing.Size(444, 20);
			this.tbPesquisa.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pesquisar pelo nome registrado:";
			// 
			// lvwDados
			// 
			this.lvwDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader3});
			this.lvwDados.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvwDados.FullRowSelect = true;
			this.lvwDados.GridLines = true;
			this.lvwDados.Location = new System.Drawing.Point(12, 109);
			this.lvwDados.Name = "lvwDados";
			this.lvwDados.Size = new System.Drawing.Size(718, 364);
			this.lvwDados.TabIndex = 3;
			this.lvwDados.UseCompatibleStateImageBehavior = false;
			this.lvwDados.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nome Registrado";
			this.columnHeader1.Width = 210;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Dt Nasc.";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 80;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Nome Declarante";
			this.columnHeader8.Width = 210;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Nome do Pai";
			this.columnHeader3.Width = 190;
			// 
			// FrmNascimentoInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 485);
			this.Controls.Add(this.lvwDados);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmNascimentoInicial";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registros de Casamentos";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbCadastrar;
		private System.Windows.Forms.PictureBox pbCadastrar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pbRemover;
		private System.Windows.Forms.Label lbRemover;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pbEditar;
		private System.Windows.Forms.Label lbEditar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tbPesquisa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvwDados;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}