namespace Tools
{
	partial class fHome
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			btInputDados = new Button();
			btFeedback = new Button();
			cbxFerramenta = new ComboBox();
			cbxInputSelect = new ComboBox();
			btIniciar = new Button();
			panel1 = new Panel();
			tbpBarraSuperior = new TableLayoutPanel();
			btSair = new Button();
			pictureBox1 = new PictureBox();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tbpBarraSuperior.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.BackColor = SystemColors.MenuHighlight;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Controls.Add(tbpBarraSuperior, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(603, 344);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.BackColor = SystemColors.ButtonFace;
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
			tableLayoutPanel2.Controls.Add(panel1, 1, 0);
			tableLayoutPanel2.Location = new Point(3, 63);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(597, 275);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.BackColor = SystemColors.ControlDark;
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Controls.Add(btInputDados, 0, 3);
			tableLayoutPanel3.Controls.Add(btFeedback, 0, 5);
			tableLayoutPanel3.Controls.Add(cbxFerramenta, 0, 0);
			tableLayoutPanel3.Controls.Add(cbxInputSelect, 0, 2);
			tableLayoutPanel3.Controls.Add(btIniciar, 0, 1);
			tableLayoutPanel3.Location = new Point(3, 3);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 6;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.Size = new Size(113, 269);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// btInputDados
			// 
			btInputDados.Dock = DockStyle.Fill;
			btInputDados.Location = new Point(0, 100);
			btInputDados.Margin = new Padding(0);
			btInputDados.Name = "btInputDados";
			btInputDados.Size = new Size(113, 40);
			btInputDados.TabIndex = 1;
			btInputDados.Text = "BASE DE DADOS";
			btInputDados.UseVisualStyleBackColor = true;
			// 
			// btFeedback
			// 
			btFeedback.Dock = DockStyle.Fill;
			btFeedback.Location = new Point(0, 236);
			btFeedback.Margin = new Padding(0);
			btFeedback.Name = "btFeedback";
			btFeedback.Size = new Size(113, 33);
			btFeedback.TabIndex = 2;
			btFeedback.Text = "FEEDBACK";
			btFeedback.UseVisualStyleBackColor = true;
			// 
			// cbxFerramenta
			// 
			cbxFerramenta.Dock = DockStyle.Fill;
			cbxFerramenta.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxFerramenta.FormattingEnabled = true;
			cbxFerramenta.Location = new Point(3, 3);
			cbxFerramenta.Name = "cbxFerramenta";
			cbxFerramenta.Size = new Size(107, 23);
			cbxFerramenta.TabIndex = 3;
			cbxFerramenta.SelectedIndexChanged += cbxFerramenta_SelectedIndexChanged;
			// 
			// cbxInputSelect
			// 
			cbxInputSelect.Dock = DockStyle.Fill;
			cbxInputSelect.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxInputSelect.FormattingEnabled = true;
			cbxInputSelect.Location = new Point(3, 73);
			cbxInputSelect.Name = "cbxInputSelect";
			cbxInputSelect.Size = new Size(107, 23);
			cbxInputSelect.TabIndex = 4;
			// 
			// btIniciar
			// 
			btIniciar.Dock = DockStyle.Fill;
			btIniciar.Location = new Point(0, 30);
			btIniciar.Margin = new Padding(0);
			btIniciar.Name = "btIniciar";
			btIniciar.Size = new Size(113, 40);
			btIniciar.TabIndex = 0;
			btIniciar.Text = "INICIAR";
			btIniciar.UseVisualStyleBackColor = true;
			btIniciar.Click += btIniciar_Click;
			// 
			// panel1
			// 
			panel1.Location = new Point(122, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(472, 269);
			panel1.TabIndex = 1;
			// 
			// tbpBarraSuperior
			// 
			tbpBarraSuperior.BackColor = SystemColors.InactiveCaption;
			tbpBarraSuperior.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			tbpBarraSuperior.ColumnCount = 3;
			tbpBarraSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			tbpBarraSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tbpBarraSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
			tbpBarraSuperior.Controls.Add(btSair, 2, 0);
			tbpBarraSuperior.Controls.Add(pictureBox1, 0, 0);
			tbpBarraSuperior.Location = new Point(3, 3);
			tbpBarraSuperior.Name = "tbpBarraSuperior";
			tbpBarraSuperior.RowCount = 1;
			tbpBarraSuperior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tbpBarraSuperior.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tbpBarraSuperior.Size = new Size(597, 54);
			tbpBarraSuperior.TabIndex = 1;
			// 
			// btSair
			// 
			btSair.Location = new Point(539, 4);
			btSair.Name = "btSair";
			btSair.Size = new Size(54, 23);
			btSair.TabIndex = 0;
			btSair.Text = "Sair";
			btSair.UseVisualStyleBackColor = true;
			btSair.Click += btSair_Click_1;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(4, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(74, 46);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// fHome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(603, 344);
			Controls.Add(tableLayoutPanel1);
			Name = "fHome";
			Text = "Tools Prototype";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tbpBarraSuperior.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private Button btSair;
		private TableLayoutPanel tbpBarraSuperior;
		private PictureBox pictureBox1;
		private Button btInputDados;
		private Button btFeedback;
		private ComboBox cbxFerramenta;
		private ComboBox cbxInputSelect;
		private Button btIniciar;
		private Panel panel1;
	}
}