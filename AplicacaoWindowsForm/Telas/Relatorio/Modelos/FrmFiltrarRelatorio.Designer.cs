namespace AplicacaoWindowsForm.Telas.Relatorio.Modelos
{
	partial class FrmFiltrarRelatorio
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.tbDataInicial = new System.Windows.Forms.DateTimePicker();
			this.tbDataFinal = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbDataFinal);
			this.groupBox1.Controls.Add(this.tbDataInicial);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 78);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Período";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(241, 96);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 12;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(160, 96);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
			this.btnConfirmar.TabIndex = 11;
			this.btnConfirmar.Text = "Confimar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// tbDataInicial
			// 
			this.tbDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tbDataInicial.Location = new System.Drawing.Point(9, 44);
			this.tbDataInicial.Name = "tbDataInicial";
			this.tbDataInicial.Size = new System.Drawing.Size(139, 20);
			this.tbDataInicial.TabIndex = 13;
			// 
			// tbDataFinal
			// 
			this.tbDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tbDataFinal.Location = new System.Drawing.Point(154, 44);
			this.tbDataFinal.Name = "tbDataFinal";
			this.tbDataFinal.Size = new System.Drawing.Size(139, 20);
			this.tbDataFinal.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Data Inícial:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(151, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Data Final:";
			// 
			// FrmFiltrarRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 129);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfirmar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmFiltrarRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Filtrar";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker tbDataFinal;
		private System.Windows.Forms.DateTimePicker tbDataInicial;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnConfirmar;
	}
}