﻿namespace AplicacaoWindowsForm.Telas.Relatorio
{
	partial class FrmDefinirLayout
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbEditar = new System.Windows.Forms.PictureBox();
			this.lbEditar = new System.Windows.Forms.Label();
			this.lbTotal = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbCadastrar = new System.Windows.Forms.Label();
			this.pbCadastrar = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pbRemover = new System.Windows.Forms.PictureBox();
			this.lbRemover = new System.Windows.Forms.Label();
			this.lvwDados = new System.Windows.Forms.ListView();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Controls.Add(this.lbTotal);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.lvwDados);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(558, 404);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Corpo do relatório";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pbEditar);
			this.panel2.Controls.Add(this.lbEditar);
			this.panel2.Location = new System.Drawing.Point(425, 19);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(58, 58);
			this.panel2.TabIndex = 17;
			// 
			// pbEditar
			// 
			this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbEditar.Image = global::AplicacaoWindowsForm.Properties.Resources.Edit_32x32;
			this.pbEditar.Location = new System.Drawing.Point(13, 8);
			this.pbEditar.Name = "pbEditar";
			this.pbEditar.Size = new System.Drawing.Size(32, 32);
			this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbEditar.TabIndex = 3;
			this.pbEditar.TabStop = false;
			this.pbEditar.Click += new System.EventHandler(this.Editar_Click);
			// 
			// lbEditar
			// 
			this.lbEditar.AutoSize = true;
			this.lbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbEditar.Location = new System.Drawing.Point(12, 41);
			this.lbEditar.Name = "lbEditar";
			this.lbEditar.Size = new System.Drawing.Size(34, 13);
			this.lbEditar.TabIndex = 4;
			this.lbEditar.Text = "Editar";
			this.lbEditar.Click += new System.EventHandler(this.Editar_Click);
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.lbTotal.Location = new System.Drawing.Point(8, 39);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(196, 17);
			this.lbTotal.TabIndex = 11;
			this.lbTotal.Text = "TOTAL DE COLUNAS:  00";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbCadastrar);
			this.panel1.Controls.Add(this.pbCadastrar);
			this.panel1.Location = new System.Drawing.Point(361, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(58, 58);
			this.panel1.TabIndex = 3;
			// 
			// lbCadastrar
			// 
			this.lbCadastrar.AutoSize = true;
			this.lbCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbCadastrar.Location = new System.Drawing.Point(4, 41);
			this.lbCadastrar.Name = "lbCadastrar";
			this.lbCadastrar.Size = new System.Drawing.Size(51, 13);
			this.lbCadastrar.TabIndex = 4;
			this.lbCadastrar.Text = "Adicionar";
			this.lbCadastrar.Click += new System.EventHandler(this.Adicionar_Click);
			// 
			// pbCadastrar
			// 
			this.pbCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbCadastrar.Image = global::AplicacaoWindowsForm.Properties.Resources.AddItem_32x32;
			this.pbCadastrar.Location = new System.Drawing.Point(13, 5);
			this.pbCadastrar.Name = "pbCadastrar";
			this.pbCadastrar.Size = new System.Drawing.Size(32, 32);
			this.pbCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbCadastrar.TabIndex = 4;
			this.pbCadastrar.TabStop = false;
			this.pbCadastrar.Click += new System.EventHandler(this.Adicionar_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pbRemover);
			this.panel3.Controls.Add(this.lbRemover);
			this.panel3.Location = new System.Drawing.Point(489, 19);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(58, 58);
			this.panel3.TabIndex = 3;
			// 
			// pbRemover
			// 
			this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbRemover.Image = global::AplicacaoWindowsForm.Properties.Resources.Clear_32x32;
			this.pbRemover.Location = new System.Drawing.Point(13, 5);
			this.pbRemover.Name = "pbRemover";
			this.pbRemover.Size = new System.Drawing.Size(32, 32);
			this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbRemover.TabIndex = 2;
			this.pbRemover.TabStop = false;
			this.pbRemover.Click += new System.EventHandler(this.Remover_Click);
			// 
			// lbRemover
			// 
			this.lbRemover.AutoSize = true;
			this.lbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbRemover.Location = new System.Drawing.Point(4, 41);
			this.lbRemover.Name = "lbRemover";
			this.lbRemover.Size = new System.Drawing.Size(50, 13);
			this.lbRemover.TabIndex = 4;
			this.lbRemover.Text = "Remover";
			this.lbRemover.Click += new System.EventHandler(this.Remover_Click);
			// 
			// lvwDados
			// 
			this.lvwDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
			this.lvwDados.FullRowSelect = true;
			this.lvwDados.GridLines = true;
			this.lvwDados.Location = new System.Drawing.Point(11, 88);
			this.lvwDados.Name = "lvwDados";
			this.lvwDados.Size = new System.Drawing.Size(536, 295);
			this.lvwDados.TabIndex = 10;
			this.lvwDados.UseCompatibleStateImageBehavior = false;
			this.lvwDados.View = System.Windows.Forms.View.Details;
			this.lvwDados.DoubleClick += new System.EventHandler(this.lvwDados_DoubleClick);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Título";
			this.columnHeader2.Width = 400;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tamanho da Coluna";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader1.Width = 120;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(420, 422);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 7;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(501, 422);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmDefinirLayout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 457);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmDefinirLayout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Definir Layout";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrar)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvwDados;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbCadastrar;
		private System.Windows.Forms.PictureBox pbCadastrar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pbRemover;
		private System.Windows.Forms.Label lbRemover;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pbEditar;
		private System.Windows.Forms.Label lbEditar;
	}
}