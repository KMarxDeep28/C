namespace Contaduria_Proyecto
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
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cmbEspecificacion = new System.Windows.Forms.ComboBox();
            this.lblEspecificacion = new System.Windows.Forms.Label();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAC = new System.Windows.Forms.DataGridView();
            this.ACTIVO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.PASIVO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASIVO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPNC = new System.Windows.Forms.DataGridView();
            this.PASIVO_NO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASIVO_NO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvANC = new System.Windows.Forms.DataGridView();
            this.ACTIVO_NO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO_NO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.PATRIMONIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATRIMONIO_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtANC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPYP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasivo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbBalanceInicial = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvANC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            this.gbBalanceInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(76, 12);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(100, 20);
            this.lblTipoCuenta.TabIndex = 0;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            this.lblTipoCuenta.Click += new System.EventHandler(this.lblTipoCuenta_Click);
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Items.AddRange(new object[] {
            "ACTIVO",
            "PASIVO",
            "PATRIMONIO"});
            this.cmbTipoCuenta.Location = new System.Drawing.Point(439, 12);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(312, 28);
            this.cmbTipoCuenta.TabIndex = 1;
            this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // cmbEspecificacion
            // 
            this.cmbEspecificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEspecificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecificacion.Enabled = false;
            this.cmbEspecificacion.FormattingEnabled = true;
            this.cmbEspecificacion.Items.AddRange(new object[] {
            "CORRIENTE",
            "NO CORRIENTE"});
            this.cmbEspecificacion.Location = new System.Drawing.Point(439, 64);
            this.cmbEspecificacion.Name = "cmbEspecificacion";
            this.cmbEspecificacion.Size = new System.Drawing.Size(312, 28);
            this.cmbEspecificacion.TabIndex = 3;
            this.cmbEspecificacion.SelectedIndexChanged += new System.EventHandler(this.cmbEspecificacion_SelectedIndexChanged);
            // 
            // lblEspecificacion
            // 
            this.lblEspecificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEspecificacion.AutoSize = true;
            this.lblEspecificacion.Enabled = false;
            this.lblEspecificacion.Location = new System.Drawing.Point(76, 64);
            this.lblEspecificacion.Name = "lblEspecificacion";
            this.lblEspecificacion.Size = new System.Drawing.Size(96, 20);
            this.lblEspecificacion.TabIndex = 2;
            this.lblEspecificacion.Text = "Especificacion";
            this.lblEspecificacion.Click += new System.EventHandler(this.lblEspecificacion_Click);
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuenta.Enabled = false;
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(439, 120);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(312, 28);
            this.cmbCuenta.TabIndex = 5;
            this.cmbCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbCuenta_SelectedIndexChanged_1);
            // 
            // lblCuenta
            // 
            this.lblCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Enabled = false;
            this.lblCuenta.Location = new System.Drawing.Point(76, 120);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(50, 20);
            this.lblCuenta.TabIndex = 4;
            this.lblCuenta.Text = "Cuenta";
            this.lblCuenta.Click += new System.EventHandler(this.lblCuenta_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Enabled = false;
            this.lblCantidad.Location = new System.Drawing.Point(76, 175);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 20);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(439, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(312, 26);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(79, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 39);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAC
            // 
            this.dgvAC.AllowUserToAddRows = false;
            this.dgvAC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvAC.BackgroundColor = System.Drawing.Color.White;
            this.dgvAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTIVO_CORRIENTE,
            this.ACTIVO_CORRIENTE_SALDO});
            this.dgvAC.Location = new System.Drawing.Point(77, 33);
            this.dgvAC.Name = "dgvAC";
            this.dgvAC.ReadOnly = true;
            this.dgvAC.RowHeadersWidth = 51;
            this.dgvAC.Size = new System.Drawing.Size(327, 259);
            this.dgvAC.TabIndex = 10;
            this.dgvAC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAC_CellContentClick);
            // 
            // ACTIVO_CORRIENTE
            // 
            this.ACTIVO_CORRIENTE.HeaderText = "ACTIVO CORRIENTE";
            this.ACTIVO_CORRIENTE.MinimumWidth = 6;
            this.ACTIVO_CORRIENTE.Name = "ACTIVO_CORRIENTE";
            this.ACTIVO_CORRIENTE.ReadOnly = true;
            this.ACTIVO_CORRIENTE.Width = 225;
            // 
            // ACTIVO_CORRIENTE_SALDO
            // 
            this.ACTIVO_CORRIENTE_SALDO.HeaderText = "";
            this.ACTIVO_CORRIENTE_SALDO.MinimumWidth = 6;
            this.ACTIVO_CORRIENTE_SALDO.Name = "ACTIVO_CORRIENTE_SALDO";
            this.ACTIVO_CORRIENTE_SALDO.ReadOnly = true;
            this.ACTIVO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ACTIVO_CORRIENTE_SALDO.Width = 125;
            // 
            // dgvPC
            // 
            this.dgvPC.AllowUserToAddRows = false;
            this.dgvPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvPC.BackgroundColor = System.Drawing.Color.White;
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PASIVO_CORRIENTE,
            this.PASIVO_CORRIENTE_SALDO});
            this.dgvPC.Location = new System.Drawing.Point(410, 33);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.ReadOnly = true;
            this.dgvPC.RowHeadersWidth = 51;
            this.dgvPC.Size = new System.Drawing.Size(330, 225);
            this.dgvPC.TabIndex = 11;
            // 
            // PASIVO_CORRIENTE
            // 
            this.PASIVO_CORRIENTE.HeaderText = "PASIVO CORRIENTE";
            this.PASIVO_CORRIENTE.MinimumWidth = 6;
            this.PASIVO_CORRIENTE.Name = "PASIVO_CORRIENTE";
            this.PASIVO_CORRIENTE.ReadOnly = true;
            this.PASIVO_CORRIENTE.Width = 225;
            // 
            // PASIVO_CORRIENTE_SALDO
            // 
            this.PASIVO_CORRIENTE_SALDO.HeaderText = "";
            this.PASIVO_CORRIENTE_SALDO.MinimumWidth = 6;
            this.PASIVO_CORRIENTE_SALDO.Name = "PASIVO_CORRIENTE_SALDO";
            this.PASIVO_CORRIENTE_SALDO.ReadOnly = true;
            this.PASIVO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PASIVO_CORRIENTE_SALDO.Width = 125;
            // 
            // dgvPNC
            // 
            this.dgvPNC.AllowUserToAddRows = false;
            this.dgvPNC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvPNC.BackgroundColor = System.Drawing.Color.White;
            this.dgvPNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPNC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PASIVO_NO_CORRIENTE,
            this.PASIVO_NO_CORRIENTE_SALDO});
            this.dgvPNC.Location = new System.Drawing.Point(410, 298);
            this.dgvPNC.Name = "dgvPNC";
            this.dgvPNC.ReadOnly = true;
            this.dgvPNC.RowHeadersWidth = 51;
            this.dgvPNC.Size = new System.Drawing.Size(330, 124);
            this.dgvPNC.TabIndex = 13;
            // 
            // PASIVO_NO_CORRIENTE
            // 
            this.PASIVO_NO_CORRIENTE.HeaderText = "PASIVO NO CORRIENTE";
            this.PASIVO_NO_CORRIENTE.MinimumWidth = 6;
            this.PASIVO_NO_CORRIENTE.Name = "PASIVO_NO_CORRIENTE";
            this.PASIVO_NO_CORRIENTE.ReadOnly = true;
            this.PASIVO_NO_CORRIENTE.Width = 225;
            // 
            // PASIVO_NO_CORRIENTE_SALDO
            // 
            this.PASIVO_NO_CORRIENTE_SALDO.HeaderText = "";
            this.PASIVO_NO_CORRIENTE_SALDO.MinimumWidth = 6;
            this.PASIVO_NO_CORRIENTE_SALDO.Name = "PASIVO_NO_CORRIENTE_SALDO";
            this.PASIVO_NO_CORRIENTE_SALDO.ReadOnly = true;
            this.PASIVO_NO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PASIVO_NO_CORRIENTE_SALDO.Width = 125;
            // 
            // dgvANC
            // 
            this.dgvANC.AllowUserToAddRows = false;
            this.dgvANC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvANC.BackgroundColor = System.Drawing.Color.White;
            this.dgvANC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvANC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTIVO_NO_CORRIENTE,
            this.ACTIVO_NO_CORRIENTE_SALDO});
            this.dgvANC.Location = new System.Drawing.Point(77, 365);
            this.dgvANC.Name = "dgvANC";
            this.dgvANC.ReadOnly = true;
            this.dgvANC.RowHeadersWidth = 51;
            this.dgvANC.Size = new System.Drawing.Size(327, 247);
            this.dgvANC.TabIndex = 12;
            // 
            // ACTIVO_NO_CORRIENTE
            // 
            this.ACTIVO_NO_CORRIENTE.HeaderText = "ACTIVO NO CORRIENTE";
            this.ACTIVO_NO_CORRIENTE.MinimumWidth = 6;
            this.ACTIVO_NO_CORRIENTE.Name = "ACTIVO_NO_CORRIENTE";
            this.ACTIVO_NO_CORRIENTE.ReadOnly = true;
            this.ACTIVO_NO_CORRIENTE.Width = 225;
            // 
            // ACTIVO_NO_CORRIENTE_SALDO
            // 
            this.ACTIVO_NO_CORRIENTE_SALDO.HeaderText = "";
            this.ACTIVO_NO_CORRIENTE_SALDO.MinimumWidth = 6;
            this.ACTIVO_NO_CORRIENTE_SALDO.Name = "ACTIVO_NO_CORRIENTE_SALDO";
            this.ACTIVO_NO_CORRIENTE_SALDO.ReadOnly = true;
            this.ACTIVO_NO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ACTIVO_NO_CORRIENTE_SALDO.Width = 125;
            // 
            // dgvP
            // 
            this.dgvP.AllowUserToAddRows = false;
            this.dgvP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvP.BackgroundColor = System.Drawing.Color.White;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PATRIMONIO,
            this.PATRIMONIO_SALDO});
            this.dgvP.Location = new System.Drawing.Point(410, 492);
            this.dgvP.Name = "dgvP";
            this.dgvP.ReadOnly = true;
            this.dgvP.RowHeadersWidth = 51;
            this.dgvP.Size = new System.Drawing.Size(330, 121);
            this.dgvP.TabIndex = 14;
            // 
            // PATRIMONIO
            // 
            this.PATRIMONIO.HeaderText = "PATRIMONIO";
            this.PATRIMONIO.MinimumWidth = 6;
            this.PATRIMONIO.Name = "PATRIMONIO";
            this.PATRIMONIO.ReadOnly = true;
            this.PATRIMONIO.Width = 225;
            // 
            // PATRIMONIO_SALDO
            // 
            this.PATRIMONIO_SALDO.HeaderText = "";
            this.PATRIMONIO_SALDO.MinimumWidth = 6;
            this.PATRIMONIO_SALDO.Name = "PATRIMONIO_SALDO";
            this.PATRIMONIO_SALDO.ReadOnly = true;
            this.PATRIMONIO_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PATRIMONIO_SALDO.Width = 125;
            // 
            // txtAC
            // 
            this.txtAC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAC.Location = new System.Drawing.Point(316, 318);
            this.txtAC.Name = "txtAC";
            this.txtAC.ReadOnly = true;
            this.txtAC.Size = new System.Drawing.Size(89, 26);
            this.txtAC.TabIndex = 15;
            this.txtAC.Text = "0";
            // 
            // TOTAL
            // 
            this.TOTAL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(77, 317);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(178, 20);
            this.TOTAL.TabIndex = 16;
            this.TOTAL.Text = "TOTAL ACTIVO CORRIENTE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "TOTAL PASIVO CORRIENTE";
            // 
            // txtPC
            // 
            this.txtPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPC.Location = new System.Drawing.Point(648, 266);
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(89, 26);
            this.txtPC.TabIndex = 17;
            this.txtPC.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "TOTAL PASIVO NO CORRIENTE";
            // 
            // txtPNC
            // 
            this.txtPNC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPNC.Location = new System.Drawing.Point(648, 427);
            this.txtPNC.Name = "txtPNC";
            this.txtPNC.ReadOnly = true;
            this.txtPNC.Size = new System.Drawing.Size(89, 26);
            this.txtPNC.TabIndex = 19;
            this.txtPNC.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "TOTAL ACTIVO NO CORRIENTE";
            // 
            // txtANC
            // 
            this.txtANC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtANC.Location = new System.Drawing.Point(316, 618);
            this.txtANC.Name = "txtANC";
            this.txtANC.ReadOnly = true;
            this.txtANC.Size = new System.Drawing.Size(89, 26);
            this.txtANC.TabIndex = 21;
            this.txtANC.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "TOTAL PATRIMONIO";
            // 
            // txtP
            // 
            this.txtP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtP.Location = new System.Drawing.Point(648, 619);
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(89, 26);
            this.txtP.TabIndex = 23;
            this.txtP.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "TOTAL PASIVO Y PATRIMONIO";
            // 
            // txtPYP
            // 
            this.txtPYP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPYP.Location = new System.Drawing.Point(648, 668);
            this.txtPYP.Name = "txtPYP";
            this.txtPYP.ReadOnly = true;
            this.txtPYP.Size = new System.Drawing.Size(89, 26);
            this.txtPYP.TabIndex = 27;
            this.txtPYP.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 666);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "TOTAL ACTIVO";
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtA.Location = new System.Drawing.Point(316, 667);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(89, 26);
            this.txtA.TabIndex = 25;
            this.txtA.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "TOTAL PASIVO";
            // 
            // txtPasivo
            // 
            this.txtPasivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPasivo.Location = new System.Drawing.Point(648, 459);
            this.txtPasivo.Name = "txtPasivo";
            this.txtPasivo.ReadOnly = true;
            this.txtPasivo.Size = new System.Drawing.Size(89, 26);
            this.txtPasivo.TabIndex = 29;
            this.txtPasivo.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(361, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 39);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbBalanceInicial
            // 
            this.gbBalanceInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBalanceInicial.Controls.Add(this.label7);
            this.gbBalanceInicial.Controls.Add(this.txtPasivo);
            this.gbBalanceInicial.Controls.Add(this.label5);
            this.gbBalanceInicial.Controls.Add(this.txtPYP);
            this.gbBalanceInicial.Controls.Add(this.label6);
            this.gbBalanceInicial.Controls.Add(this.txtA);
            this.gbBalanceInicial.Controls.Add(this.label4);
            this.gbBalanceInicial.Controls.Add(this.txtP);
            this.gbBalanceInicial.Controls.Add(this.label3);
            this.gbBalanceInicial.Controls.Add(this.txtANC);
            this.gbBalanceInicial.Controls.Add(this.label2);
            this.gbBalanceInicial.Controls.Add(this.txtPNC);
            this.gbBalanceInicial.Controls.Add(this.label1);
            this.gbBalanceInicial.Controls.Add(this.txtPC);
            this.gbBalanceInicial.Controls.Add(this.TOTAL);
            this.gbBalanceInicial.Controls.Add(this.txtAC);
            this.gbBalanceInicial.Controls.Add(this.dgvP);
            this.gbBalanceInicial.Controls.Add(this.dgvPNC);
            this.gbBalanceInicial.Controls.Add(this.dgvANC);
            this.gbBalanceInicial.Controls.Add(this.dgvPC);
            this.gbBalanceInicial.Controls.Add(this.dgvAC);
            this.gbBalanceInicial.Location = new System.Drawing.Point(11, 254);
            this.gbBalanceInicial.Name = "gbBalanceInicial";
            this.gbBalanceInicial.Size = new System.Drawing.Size(831, 703);
            this.gbBalanceInicial.TabIndex = 34;
            this.gbBalanceInicial.TabStop = false;
            this.gbBalanceInicial.Text = "BALANCE INICIAL";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(185, 212);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 39);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar como Imagen";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 969);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbBalanceInicial);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.cmbEspecificacion);
            this.Controls.Add(this.lblEspecificacion);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Balance Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvANC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            this.gbBalanceInicial.ResumeLayout(false);
            this.gbBalanceInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.ComboBox cmbEspecificacion;
        private System.Windows.Forms.Label lblEspecificacion;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAC;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.DataGridView dgvPNC;
        private System.Windows.Forms.DataGridView dgvANC;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtANC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPYP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasivo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbBalanceInicial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_NO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_NO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_NO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_NO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATRIMONIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATRIMONIO_SALDO;
    }
}

