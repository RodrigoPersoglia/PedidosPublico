﻿
namespace Login
{
	partial class ModificarPedido
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox NumeroTxt;
		private System.Windows.Forms.Button ModificarBtn;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox OCTxt;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPedido));
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumeroTxt = new System.Windows.Forms.TextBox();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OCTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnidadComboBox = new System.Windows.Forms.ComboBox();
            this.TerminacionComboBox = new System.Windows.Forms.ComboBox();
            this.PrioridadComboBox = new System.Windows.Forms.ComboBox();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.PerfilTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CantidadNumeric = new System.Windows.Forms.NumericUpDown();
            this.LargoNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgrgarBtn = new System.Windows.Forms.Button();
            this.QuitarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KgsEstimados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.ObservacionesTxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.AleacionComboBox = new System.Windows.Forms.ComboBox();
            this.TemplecomboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.BuscarPedBTN = new System.Windows.Forms.Button();
            this.IDPedido = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.matrizComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkImprimir = new System.Windows.Forms.CheckBox();
            this.BuscarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargoNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-29, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(-29, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "FECHA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.Location = new System.Drawing.Point(167, 100);
            this.NumeroTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NumeroTxt.MaxLength = 20;
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Size = new System.Drawing.Size(152, 19);
            this.NumeroTxt.TabIndex = 1;
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBtn.Location = new System.Drawing.Point(459, 560);
            this.ModificarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(120, 33);
            this.ModificarBtn.TabIndex = 17;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.CrearClick);
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(602, 560);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(120, 33);
            this.Cancelar.TabIndex = 18;
            this.Cancelar.Text = "Salir";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 408);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // OCTxt
            // 
            this.OCTxt.Location = new System.Drawing.Point(167, 313);
            this.OCTxt.Margin = new System.Windows.Forms.Padding(4);
            this.OCTxt.Name = "OCTxt";
            this.OCTxt.Size = new System.Drawing.Size(224, 19);
            this.OCTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "MODIFICAR PEDIDO";
            // 
            // UnidadComboBox
            // 
            this.UnidadComboBox.FormattingEnabled = true;
            this.UnidadComboBox.Location = new System.Drawing.Point(167, 217);
            this.UnidadComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnidadComboBox.Name = "UnidadComboBox";
            this.UnidadComboBox.Size = new System.Drawing.Size(224, 21);
            this.UnidadComboBox.TabIndex = 6;
            this.UnidadComboBox.SelectedValueChanged += new System.EventHandler(this.CambiaUnidad);
            // 
            // TerminacionComboBox
            // 
            this.TerminacionComboBox.FormattingEnabled = true;
            this.TerminacionComboBox.Location = new System.Drawing.Point(167, 249);
            this.TerminacionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TerminacionComboBox.Name = "TerminacionComboBox";
            this.TerminacionComboBox.Size = new System.Drawing.Size(224, 21);
            this.TerminacionComboBox.TabIndex = 7;
            // 
            // PrioridadComboBox
            // 
            this.PrioridadComboBox.FormattingEnabled = true;
            this.PrioridadComboBox.Location = new System.Drawing.Point(167, 281);
            this.PrioridadComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrioridadComboBox.Name = "PrioridadComboBox";
            this.PrioridadComboBox.Size = new System.Drawing.Size(224, 21);
            this.PrioridadComboBox.TabIndex = 8;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(167, 185);
            this.ClienteComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(224, 21);
            this.ClienteComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-29, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "UNIDAD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(-29, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 28);
            this.label9.TabIndex = 29;
            this.label9.Text = "TERMINACIÓN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(-29, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 28);
            this.label10.TabIndex = 30;
            this.label10.Text = "PRIORIDAD";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(-29, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 28);
            this.label11.TabIndex = 31;
            this.label11.Text = "CLIENTE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(398, 376);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 28);
            this.label12.TabIndex = 32;
            this.label12.Text = "Imagen:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fecha
            // 
            this.Fecha.CustomFormat = "dd/MM/yyyy";
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(167, 126);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(152, 19);
            this.Fecha.TabIndex = 2;
            this.Fecha.Value = new System.DateTime(2021, 1, 29, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(-39, 309);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 28);
            this.label13.TabIndex = 34;
            this.label13.Text = "O. DE COMPRA";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PerfilTxt
            // 
            this.PerfilTxt.Location = new System.Drawing.Point(167, 155);
            this.PerfilTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PerfilTxt.MaxLength = 20;
            this.PerfilTxt.Name = "PerfilTxt";
            this.PerfilTxt.Size = new System.Drawing.Size(152, 19);
            this.PerfilTxt.TabIndex = 3;
            this.PerfilTxt.TextChanged += new System.EventHandler(this.cambiaPerfil);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-29, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "PERFIL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(326, 155);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(65, 23);
            this.BuscarBtn.TabIndex = 4;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CantidadNumeric
            // 
            this.CantidadNumeric.Location = new System.Drawing.Point(12, 416);
            this.CantidadNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CantidadNumeric.Name = "CantidadNumeric";
            this.CantidadNumeric.Size = new System.Drawing.Size(95, 19);
            this.CantidadNumeric.TabIndex = 13;
            // 
            // LargoNumeric
            // 
            this.LargoNumeric.Location = new System.Drawing.Point(122, 416);
            this.LargoNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LargoNumeric.Name = "LargoNumeric";
            this.LargoNumeric.Size = new System.Drawing.Size(90, 19);
            this.LargoNumeric.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Cantidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(119, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 41;
            this.label6.Text = "Largo (mm)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AgrgarBtn
            // 
            this.AgrgarBtn.Location = new System.Drawing.Point(233, 409);
            this.AgrgarBtn.Name = "AgrgarBtn";
            this.AgrgarBtn.Size = new System.Drawing.Size(75, 30);
            this.AgrgarBtn.TabIndex = 15;
            this.AgrgarBtn.Text = "Agregar";
            this.AgrgarBtn.UseVisualStyleBackColor = true;
            this.AgrgarBtn.Click += new System.EventHandler(this.AgrgarBtn_Click);
            // 
            // QuitarBtn
            // 
            this.QuitarBtn.Location = new System.Drawing.Point(316, 408);
            this.QuitarBtn.Name = "QuitarBtn";
            this.QuitarBtn.Size = new System.Drawing.Size(75, 30);
            this.QuitarBtn.TabIndex = 16;
            this.QuitarBtn.Text = "Quitar";
            this.QuitarBtn.UseVisualStyleBackColor = true;
            this.QuitarBtn.Click += new System.EventHandler(this.QuitarBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Largo,
            this.KgsEstimados});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(379, 148);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecccioncelda);
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Largo
            // 
            this.Largo.Frozen = true;
            this.Largo.HeaderText = "Largo";
            this.Largo.MinimumWidth = 6;
            this.Largo.Name = "Largo";
            this.Largo.ReadOnly = true;
            this.Largo.Width = 125;
            // 
            // KgsEstimados
            // 
            this.KgsEstimados.Frozen = true;
            this.KgsEstimados.HeaderText = "Kgs Estimados";
            this.KgsEstimados.MinimumWidth = 6;
            this.KgsEstimados.Name = "KgsEstimados";
            this.KgsEstimados.ReadOnly = true;
            this.KgsEstimados.Width = 125;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-7, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 45;
            this.label7.Text = "OBSERVACIONES";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ObservacionesTxt
            // 
            this.ObservacionesTxt.Location = new System.Drawing.Point(167, 343);
            this.ObservacionesTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ObservacionesTxt.Name = "ObservacionesTxt";
            this.ObservacionesTxt.Size = new System.Drawing.Size(224, 19);
            this.ObservacionesTxt.TabIndex = 10;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(473, 63);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(209, 19);
            this.IDtxt.TabIndex = 47;
            this.IDtxt.Visible = false;
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(457, 155);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.ReadOnly = true;
            this.DescripcionTxt.Size = new System.Drawing.Size(209, 19);
            this.DescripcionTxt.TabIndex = 48;
            // 
            // AleacionComboBox
            // 
            this.AleacionComboBox.FormattingEnabled = true;
            this.AleacionComboBox.Location = new System.Drawing.Point(457, 210);
            this.AleacionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AleacionComboBox.Name = "AleacionComboBox";
            this.AleacionComboBox.Size = new System.Drawing.Size(224, 21);
            this.AleacionComboBox.TabIndex = 11;
            // 
            // TemplecomboBox
            // 
            this.TemplecomboBox.FormattingEnabled = true;
            this.TemplecomboBox.Location = new System.Drawing.Point(457, 267);
            this.TemplecomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TemplecomboBox.Name = "TemplecomboBox";
            this.TemplecomboBox.Size = new System.Drawing.Size(224, 21);
            this.TemplecomboBox.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(454, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 28);
            this.label14.TabIndex = 52;
            this.label14.Text = "Descripción:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(454, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 28);
            this.label15.TabIndex = 53;
            this.label15.Text = "Aleación:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(454, 235);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 28);
            this.label16.TabIndex = 54;
            this.label16.Text = "Temple:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(469, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 28);
            this.label17.TabIndex = 55;
            this.label17.Text = "ID base datos:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(455, 100);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(242, 28);
            this.label18.TabIndex = 56;
            this.label18.Text = "ARTÍCULO SELECCIONADO:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // BuscarPedBTN
            // 
            this.BuscarPedBTN.Location = new System.Drawing.Point(326, 100);
            this.BuscarPedBTN.Name = "BuscarPedBTN";
            this.BuscarPedBTN.Size = new System.Drawing.Size(65, 23);
            this.BuscarPedBTN.TabIndex = 58;
            this.BuscarPedBTN.Text = "Buscar";
            this.BuscarPedBTN.UseVisualStyleBackColor = true;
            this.BuscarPedBTN.Click += new System.EventHandler(this.BuscarPedBTN_Click);
            // 
            // IDPedido
            // 
            this.IDPedido.Location = new System.Drawing.Point(167, 72);
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.Size = new System.Drawing.Size(152, 19);
            this.IDPedido.TabIndex = 59;
            this.IDPedido.Visible = false;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(45, 66);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 28);
            this.label19.TabIndex = 60;
            this.label19.Text = "ID pedidos";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Visible = false;
            // 
            // matrizComboBox
            // 
            this.matrizComboBox.FormattingEnabled = true;
            this.matrizComboBox.Location = new System.Drawing.Point(459, 337);
            this.matrizComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.matrizComboBox.Name = "matrizComboBox";
            this.matrizComboBox.Size = new System.Drawing.Size(224, 21);
            this.matrizComboBox.TabIndex = 62;
            this.matrizComboBox.SelectionChangeCommitted += new System.EventHandler(this.matrizComboBox_SelectionChangeCommitted);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(456, 305);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 28);
            this.label20.TabIndex = 61;
            this.label20.Text = "Matrices disponibles";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkImprimir
            // 
            this.checkImprimir.AutoSize = true;
            this.checkImprimir.Checked = true;
            this.checkImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkImprimir.ForeColor = System.Drawing.Color.Black;
            this.checkImprimir.Location = new System.Drawing.Point(459, 534);
            this.checkImprimir.Name = "checkImprimir";
            this.checkImprimir.Size = new System.Drawing.Size(114, 19);
            this.checkImprimir.TabIndex = 63;
            this.checkImprimir.Text = "Imprimir Pedido";
            this.checkImprimir.UseVisualStyleBackColor = true;
            // 
            // BuscarImagen
            // 
            this.BuscarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarImagen.Location = new System.Drawing.Point(630, 381);
            this.BuscarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarImagen.Name = "BuscarImagen";
            this.BuscarImagen.Size = new System.Drawing.Size(56, 20);
            this.BuscarImagen.TabIndex = 64;
            this.BuscarImagen.Text = "Buscar";
            this.BuscarImagen.UseVisualStyleBackColor = true;
            this.BuscarImagen.Click += new System.EventHandler(this.BuscarImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image files (*.jpg, *.jpeg, *.bmp, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.bmp;" +
    " *.jfif; *.png; \"";
            // 
            // ModificarPedido
            // 
            this.AcceptButton = this.ModificarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(751, 610);
            this.ControlBox = false;
            this.Controls.Add(this.BuscarImagen);
            this.Controls.Add(this.checkImprimir);
            this.Controls.Add(this.matrizComboBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.IDPedido);
            this.Controls.Add(this.BuscarPedBTN);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TemplecomboBox);
            this.Controls.Add(this.AleacionComboBox);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.ObservacionesTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QuitarBtn);
            this.Controls.Add(this.AgrgarBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LargoNumeric);
            this.Controls.Add(this.CantidadNumeric);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PerfilTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.PrioridadComboBox);
            this.Controls.Add(this.TerminacionComboBox);
            this.Controls.Add(this.UnidadComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OCTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.NumeroTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Pedido";
            this.Load += new System.EventHandler(this.ModificarPedidoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargoNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.ComboBox UnidadComboBox;
        private System.Windows.Forms.ComboBox TerminacionComboBox;
        private System.Windows.Forms.ComboBox PrioridadComboBox;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PerfilTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.NumericUpDown CantidadNumeric;
        private System.Windows.Forms.NumericUpDown LargoNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgrgarBtn;
        private System.Windows.Forms.Button QuitarBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ObservacionesTxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.ComboBox AleacionComboBox;
        private System.Windows.Forms.ComboBox TemplecomboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KgsEstimados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button BuscarPedBTN;
        private System.Windows.Forms.TextBox IDPedido;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox matrizComboBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkImprimir;
        private System.Windows.Forms.Button BuscarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}