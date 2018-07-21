namespace AplicacaoWindowsForm
{
	partial class FrmInicial
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
			this.lbNascimento = new System.Windows.Forms.Label();
			this.pbNascimento = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pbObito = new System.Windows.Forms.PictureBox();
			this.lbObito = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbCasamento = new System.Windows.Forms.PictureBox();
			this.lbCasamento = new System.Windows.Forms.Label();
			this.pbRelatorio = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbRelatorio = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbNascimento)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbObito)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCasamento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRelatorio)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(242, 91);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registros";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbNascimento);
			this.panel1.Controls.Add(this.pbNascimento);
			this.panel1.Location = new System.Drawing.Point(10, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(70, 64);
			this.panel1.TabIndex = 3;
			// 
			// lbNascimento
			// 
			this.lbNascimento.AutoSize = true;
			this.lbNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbNascimento.Location = new System.Drawing.Point(4, 44);
			this.lbNascimento.Name = "lbNascimento";
			this.lbNascimento.Size = new System.Drawing.Size(63, 13);
			this.lbNascimento.TabIndex = 4;
			this.lbNascimento.Text = "Nascimento";
			this.lbNascimento.Click += new System.EventHandler(this.Nascimento_Click);
			// 
			// pbNascimento
			// 
			this.pbNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbNascimento.Image = global::AplicacaoWindowsForm.Properties.Resources.Today_32x32;
			this.pbNascimento.Location = new System.Drawing.Point(19, 8);
			this.pbNascimento.Name = "pbNascimento";
			this.pbNascimento.Size = new System.Drawing.Size(32, 32);
			this.pbNascimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbNascimento.TabIndex = 4;
			this.pbNascimento.TabStop = false;
			this.pbNascimento.Click += new System.EventHandler(this.Nascimento_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pbObito);
			this.panel3.Controls.Add(this.lbObito);
			this.panel3.Location = new System.Drawing.Point(162, 19);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(70, 64);
			this.panel3.TabIndex = 3;
			// 
			// pbObito
			// 
			this.pbObito.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbObito.Image = global::AplicacaoWindowsForm.Properties.Resources.AlignHorizontalTop_32x32;
			this.pbObito.Location = new System.Drawing.Point(19, 8);
			this.pbObito.Name = "pbObito";
			this.pbObito.Size = new System.Drawing.Size(32, 32);
			this.pbObito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbObito.TabIndex = 2;
			this.pbObito.TabStop = false;
			this.pbObito.Click += new System.EventHandler(this.Obito_Click);
			// 
			// lbObito
			// 
			this.lbObito.AutoSize = true;
			this.lbObito.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbObito.Location = new System.Drawing.Point(19, 44);
			this.lbObito.Name = "lbObito";
			this.lbObito.Size = new System.Drawing.Size(32, 13);
			this.lbObito.TabIndex = 4;
			this.lbObito.Text = "Óbito";
			this.lbObito.Click += new System.EventHandler(this.Obito_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pbCasamento);
			this.panel2.Controls.Add(this.lbCasamento);
			this.panel2.Location = new System.Drawing.Point(86, 19);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(70, 64);
			this.panel2.TabIndex = 3;
			// 
			// pbCasamento
			// 
			this.pbCasamento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbCasamento.Image = global::AplicacaoWindowsForm.Properties.Resources.ContentArrangeInRows_32x32;
			this.pbCasamento.Location = new System.Drawing.Point(20, 8);
			this.pbCasamento.Name = "pbCasamento";
			this.pbCasamento.Size = new System.Drawing.Size(32, 32);
			this.pbCasamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbCasamento.TabIndex = 3;
			this.pbCasamento.TabStop = false;
			this.pbCasamento.Click += new System.EventHandler(this.Casamento_Click);
			// 
			// lbCasamento
			// 
			this.lbCasamento.AutoSize = true;
			this.lbCasamento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbCasamento.Location = new System.Drawing.Point(5, 44);
			this.lbCasamento.Name = "lbCasamento";
			this.lbCasamento.Size = new System.Drawing.Size(60, 13);
			this.lbCasamento.TabIndex = 4;
			this.lbCasamento.Text = "Casamento";
			this.lbCasamento.Click += new System.EventHandler(this.Casamento_Click);
			// 
			// pbRelatorio
			// 
			this.pbRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbRelatorio.Image = global::AplicacaoWindowsForm.Properties.Resources.AddHeader_32x32;
			this.pbRelatorio.Location = new System.Drawing.Point(19, 8);
			this.pbRelatorio.Name = "pbRelatorio";
			this.pbRelatorio.Size = new System.Drawing.Size(32, 32);
			this.pbRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbRelatorio.TabIndex = 1;
			this.pbRelatorio.TabStop = false;
			this.pbRelatorio.Click += new System.EventHandler(this.CriarRelatorio_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel5);
			this.groupBox2.Controls.Add(this.panel4);
			this.groupBox2.Location = new System.Drawing.Point(260, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(171, 91);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Relatórios";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Location = new System.Drawing.Point(11, 19);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(71, 64);
			this.panel5.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Location = new System.Drawing.Point(8, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Relatórios";
			this.label1.Click += new System.EventHandler(this.Relatorio_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::AplicacaoWindowsForm.Properties.Resources.Report_32x32;
			this.pictureBox1.Location = new System.Drawing.Point(19, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.Relatorio_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lbRelatorio);
			this.panel4.Controls.Add(this.pbRelatorio);
			this.panel4.Location = new System.Drawing.Point(88, 19);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(71, 64);
			this.panel4.TabIndex = 3;
			// 
			// lbRelatorio
			// 
			this.lbRelatorio.AutoSize = true;
			this.lbRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbRelatorio.Location = new System.Drawing.Point(-1, 44);
			this.lbRelatorio.Name = "lbRelatorio";
			this.lbRelatorio.Size = new System.Drawing.Size(73, 13);
			this.lbRelatorio.TabIndex = 4;
			this.lbRelatorio.Text = "Criar Relatório";
			this.lbRelatorio.Click += new System.EventHandler(this.CriarRelatorio_Click);
			// 
			// FrmInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 560);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmInicial";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Teste prático de desenvolvimento em C# - Windows Forms";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbNascimento)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbObito)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCasamento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRelatorio)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbObito;
		private System.Windows.Forms.PictureBox pbObito;
		private System.Windows.Forms.Label lbCasamento;
		private System.Windows.Forms.PictureBox pbCasamento;
		private System.Windows.Forms.Label lbNascimento;
		private System.Windows.Forms.PictureBox pbNascimento;
		private System.Windows.Forms.PictureBox pbRelatorio;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbRelatorio;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}