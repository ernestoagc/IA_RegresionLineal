namespace WFRegresionLineal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnExaminar = new System.Windows.Forms.Button();
			this.gvDatos = new System.Windows.Forms.DataGridView();
			this.openfd = new System.Windows.Forms.OpenFileDialog();
			this.txtExaminar = new System.Windows.Forms.TextBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.cmbMoneda = new System.Windows.Forms.ComboBox();
			this.cmbGarantia = new System.Windows.Forms.ComboBox();
			this.cmbSegmento = new System.Windows.Forms.ComboBox();
			this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbBanca = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PowderBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-3, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1204, 50);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(411, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(301, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prediccion Calculo de Tasa";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seleccionar fuente historica";
			// 
			// btnExaminar
			// 
			this.btnExaminar.Location = new System.Drawing.Point(211, 79);
			this.btnExaminar.Name = "btnExaminar";
			this.btnExaminar.Size = new System.Drawing.Size(75, 23);
			this.btnExaminar.TabIndex = 2;
			this.btnExaminar.Text = "examinar";
			this.btnExaminar.UseVisualStyleBackColor = true;
			this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
			// 
			// gvDatos
			// 
			this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvDatos.Location = new System.Drawing.Point(29, 307);
			this.gvDatos.Name = "gvDatos";
			this.gvDatos.Size = new System.Drawing.Size(1134, 227);
			this.gvDatos.TabIndex = 3;
			this.gvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatos_CellContentClick);
			// 
			// openfd
			// 
			this.openfd.FileName = "opdArchivo";
			// 
			// txtExaminar
			// 
			this.txtExaminar.Location = new System.Drawing.Point(29, 80);
			this.txtExaminar.Name = "txtExaminar";
			this.txtExaminar.Size = new System.Drawing.Size(176, 20);
			this.txtExaminar.TabIndex = 4;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "PRODUCTO",
            "MONEDA",
            "IMPORTE",
            "TIPO_PLAZO",
            "PLAZO",
            "GARANTIA",
            "SEGMENTO",
            "TIPO_DOCUMENTO",
            "NRO_FAMILIA",
            "BANCA"});
			this.checkedListBox1.Location = new System.Drawing.Point(7, 27);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(186, 154);
			this.checkedListBox1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "PRODUCTO";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.comboBox3);
			this.panel2.Controls.Add(this.btnAgregar);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.cmbBanca);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.cmbTipoDocumento);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.cmbSegmento);
			this.panel2.Controls.Add(this.cmbGarantia);
			this.panel2.Controls.Add(this.cmbMoneda);
			this.panel2.Controls.Add(this.cmbProducto);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.textBox5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(29, 106);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(739, 185);
			this.panel2.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(165, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "MONEDA";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(308, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "IMPORTE";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(311, 71);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(124, 20);
			this.textBox3.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(448, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "TIPO_PLAZO";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(594, 55);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "PLAZO";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(597, 71);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(124, 20);
			this.textBox5.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(22, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(270, 20);
			this.label8.TabIndex = 17;
			this.label8.Text = "VARIABLES INDEPENDIENTES";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(23, 119);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "GARANTIA";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(165, 119);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "SEGMENTO";
			// 
			// cmbProducto
			// 
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Items.AddRange(new object[] {
            "Construyo",
            "Conticasa",
            "Contipuente",
            "Descuentos",
            "FIA Exportación",
            "FIA Importación",
            "PLD",
            "Préstamo Comercial (CP)",
            "Tarjeta Capital de Trabajo"});
			this.cmbProducto.Location = new System.Drawing.Point(24, 71);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(121, 21);
			this.cmbProducto.TabIndex = 22;
			// 
			// cmbMoneda
			// 
			this.cmbMoneda.FormattingEnabled = true;
			this.cmbMoneda.Items.AddRange(new object[] {
            "PEN",
            "USD"});
			this.cmbMoneda.Location = new System.Drawing.Point(168, 71);
			this.cmbMoneda.Name = "cmbMoneda";
			this.cmbMoneda.Size = new System.Drawing.Size(121, 21);
			this.cmbMoneda.TabIndex = 23;
			// 
			// cmbGarantia
			// 
			this.cmbGarantia.FormattingEnabled = true;
			this.cmbGarantia.Items.AddRange(new object[] {
            "SIN GARANTIA",
            "DINERARIA",
            "NO DINERARIA"});
			this.cmbGarantia.Location = new System.Drawing.Point(24, 135);
			this.cmbGarantia.Name = "cmbGarantia";
			this.cmbGarantia.Size = new System.Drawing.Size(121, 21);
			this.cmbGarantia.TabIndex = 24;
			// 
			// cmbSegmento
			// 
			this.cmbSegmento.FormattingEnabled = true;
			this.cmbSegmento.Items.AddRange(new object[] {
            "Construyo",
            "Conticasa",
            "Contipuente",
            "Descuentos",
            "FIA Exportación",
            "FIA Importación",
            "PLD",
            "Préstamo Comercial (CP)",
            "Tarjeta Capital de Trabajo"});
			this.cmbSegmento.Location = new System.Drawing.Point(168, 135);
			this.cmbSegmento.Name = "cmbSegmento";
			this.cmbSegmento.Size = new System.Drawing.Size(121, 21);
			this.cmbSegmento.TabIndex = 25;
			// 
			// cmbTipoDocumento
			// 
			this.cmbTipoDocumento.FormattingEnabled = true;
			this.cmbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
			this.cmbTipoDocumento.Location = new System.Drawing.Point(311, 135);
			this.cmbTipoDocumento.Name = "cmbTipoDocumento";
			this.cmbTipoDocumento.Size = new System.Drawing.Size(121, 21);
			this.cmbTipoDocumento.TabIndex = 27;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(308, 119);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(108, 13);
			this.label11.TabIndex = 26;
			this.label11.Text = "TIPO_DOCUMENTO";
			// 
			// cmbBanca
			// 
			this.cmbBanca.FormattingEnabled = true;
			this.cmbBanca.Items.AddRange(new object[] {
            "MIN",
            "BEC"});
			this.cmbBanca.Location = new System.Drawing.Point(600, 135);
			this.cmbBanca.Name = "cmbBanca";
			this.cmbBanca.Size = new System.Drawing.Size(121, 21);
			this.cmbBanca.TabIndex = 29;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(597, 119);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(43, 13);
			this.label12.TabIndex = 28;
			this.label12.Text = "BANCA";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(448, 119);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(78, 13);
			this.label13.TabIndex = 31;
			this.label13.Text = "NRO_FAMILIA";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(451, 135);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(124, 20);
			this.textBox1.TabIndex = 30;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(517, 10);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(204, 23);
			this.btnAgregar.TabIndex = 32;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel3.Controls.Add(this.btnProcesar);
			this.panel3.Controls.Add(this.label14);
			this.panel3.Controls.Add(this.checkedListBox1);
			this.panel3.Location = new System.Drawing.Point(818, 106);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(345, 185);
			this.panel3.TabIndex = 10;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(3, 7);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(154, 20);
			this.label14.TabIndex = 33;
			this.label14.Text = "CALCULAR TASA";
			// 
			// btnProcesar
			// 
			this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcesar.Location = new System.Drawing.Point(211, 27);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(115, 53);
			this.btnProcesar.TabIndex = 33;
			this.btnProcesar.Text = "Ejecutar Proceso";
			this.btnProcesar.UseVisualStyleBackColor = true;
			this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "DIA",
            "MES"});
			this.comboBox3.Location = new System.Drawing.Point(451, 70);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 33;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1200, 700);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtExaminar);
			this.Controls.Add(this.gvDatos);
			this.Controls.Add(this.btnExaminar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.DataGridView gvDatos;
		private System.Windows.Forms.OpenFileDialog openfd;
		private System.Windows.Forms.TextBox txtExaminar;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cmbMoneda;
		private System.Windows.Forms.ComboBox cmbProducto;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox cmbBanca;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbTipoDocumento;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbSegmento;
		private System.Windows.Forms.ComboBox cmbGarantia;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnProcesar;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox comboBox3;
	}
}

