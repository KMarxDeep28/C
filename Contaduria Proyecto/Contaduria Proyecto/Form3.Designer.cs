namespace Contaduria_Proyecto
{
    partial class Form3
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.cmbEspecificacion = new System.Windows.Forms.ComboBox();
            this.lblEspecificacion = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.dgvDiario = new System.Windows.Forms.DataGridView();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA_DEBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA_HABER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.Label();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.gbDiario = new System.Windows.Forms.GroupBox();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtTrece = new System.Windows.Forms.TextBox();
            this.txtTres = new System.Windows.Forms.TextBox();
            this.cmbDiario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).BeginInit();
            this.gbDiario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(684, 209);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 39);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(169, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 39);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(63, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 39);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Enabled = false;
            this.lblCantidad.Location = new System.Drawing.Point(63, 172);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 20);
            this.lblCantidad.TabIndex = 41;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(427, 172);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(312, 26);
            this.txtCantidad.TabIndex = 40;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuenta.Enabled = false;
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(427, 117);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(312, 28);
            this.cmbCuenta.TabIndex = 39;
            this.cmbCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbCuenta_SelectedIndexChanged);
            // 
            // lblCuenta
            // 
            this.lblCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Enabled = false;
            this.lblCuenta.Location = new System.Drawing.Point(63, 117);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(50, 20);
            this.lblCuenta.TabIndex = 38;
            this.lblCuenta.Text = "Cuenta";
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
            this.cmbEspecificacion.Location = new System.Drawing.Point(427, 61);
            this.cmbEspecificacion.Name = "cmbEspecificacion";
            this.cmbEspecificacion.Size = new System.Drawing.Size(312, 28);
            this.cmbEspecificacion.TabIndex = 37;
            this.cmbEspecificacion.SelectedIndexChanged += new System.EventHandler(this.cmbEspecificacion_SelectedIndexChanged);
            // 
            // lblEspecificacion
            // 
            this.lblEspecificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEspecificacion.AutoSize = true;
            this.lblEspecificacion.Enabled = false;
            this.lblEspecificacion.Location = new System.Drawing.Point(63, 61);
            this.lblEspecificacion.Name = "lblEspecificacion";
            this.lblEspecificacion.Size = new System.Drawing.Size(96, 20);
            this.lblEspecificacion.TabIndex = 36;
            this.lblEspecificacion.Text = "Especificacion";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipoCuenta.Items.AddRange(new object[] {
            "ACTIVO",
            "PASIVO",
            "PATRIMONIO",
            "INGRESO",
            "COSTO",
            "GASTO"});
            this.cmbTipoCuenta.Location = new System.Drawing.Point(427, 9);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(312, 28);
            this.cmbTipoCuenta.TabIndex = 35;
            this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(63, 9);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(100, 20);
            this.lblTipoCuenta.TabIndex = 34;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // dgvDiario
            // 
            this.dgvDiario.AllowUserToAddRows = false;
            this.dgvDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDiario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDiario.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUENTA,
            this.CUENTA_DEBE,
            this.CUENTA_HABER});
            this.dgvDiario.Location = new System.Drawing.Point(94, 27);
            this.dgvDiario.Name = "dgvDiario";
            this.dgvDiario.ReadOnly = true;
            this.dgvDiario.RowHeadersWidth = 51;
            this.dgvDiario.Size = new System.Drawing.Size(469, 353);
            this.dgvDiario.TabIndex = 46;
            // 
            // CUENTA
            // 
            this.CUENTA.Frozen = true;
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.MinimumWidth = 6;
            this.CUENTA.Name = "CUENTA";
            this.CUENTA.ReadOnly = true;
            this.CUENTA.Width = 225;
            // 
            // CUENTA_DEBE
            // 
            this.CUENTA_DEBE.Frozen = true;
            this.CUENTA_DEBE.HeaderText = "DEBE";
            this.CUENTA_DEBE.MinimumWidth = 6;
            this.CUENTA_DEBE.Name = "CUENTA_DEBE";
            this.CUENTA_DEBE.ReadOnly = true;
            this.CUENTA_DEBE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CUENTA_DEBE.Width = 125;
            // 
            // CUENTA_HABER
            // 
            this.CUENTA_HABER.Frozen = true;
            this.CUENTA_HABER.HeaderText = "HABER";
            this.CUENTA_HABER.MinimumWidth = 6;
            this.CUENTA_HABER.Name = "CUENTA_HABER";
            this.CUENTA_HABER.ReadOnly = true;
            this.CUENTA_HABER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CUENTA_HABER.Width = 125;
            // 
            // txtHaber
            // 
            this.txtHaber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtHaber.Location = new System.Drawing.Point(420, 397);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.ReadOnly = true;
            this.txtHaber.Size = new System.Drawing.Size(91, 26);
            this.txtHaber.TabIndex = 50;
            this.txtHaber.Text = "0";
            // 
            // TOTAL
            // 
            this.TOTAL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(98, 403);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(49, 20);
            this.TOTAL.TabIndex = 49;
            this.TOTAL.Text = "TOTAL";
            // 
            // txtDebe
            // 
            this.txtDebe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDebe.Location = new System.Drawing.Point(332, 397);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.ReadOnly = true;
            this.txtDebe.Size = new System.Drawing.Size(91, 26);
            this.txtDebe.TabIndex = 51;
            this.txtDebe.Text = "0";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(275, 209);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(136, 39);
            this.btnExportar.TabIndex = 52;
            this.btnExportar.Text = "Exportar en excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImagen.Enabled = false;
            this.btnImagen.Location = new System.Drawing.Point(416, 209);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(157, 39);
            this.btnImagen.TabIndex = 53;
            this.btnImagen.Text = "Guardar como Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbDiario
            // 
            this.gbDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDiario.Controls.Add(this.txtDebe);
            this.gbDiario.Controls.Add(this.txtHaber);
            this.gbDiario.Controls.Add(this.TOTAL);
            this.gbDiario.Controls.Add(this.dgvDiario);
            this.gbDiario.Location = new System.Drawing.Point(326, 256);
            this.gbDiario.Name = "gbDiario";
            this.gbDiario.Size = new System.Drawing.Size(620, 433);
            this.gbDiario.TabIndex = 54;
            this.gbDiario.TabStop = false;
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(11, 292);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(35, 20);
            this.lblNeto.TabIndex = 55;
            this.lblNeto.Text = "87%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "13%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "3%";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitulo.Location = new System.Drawing.Point(835, 14);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(152, 80);
            this.txtTitulo.TabIndex = 62;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Titulo";
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(83, 289);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(109, 26);
            this.txtNeto.TabIndex = 52;
            this.txtNeto.Text = "0";
            // 
            // txtTrece
            // 
            this.txtTrece.Location = new System.Drawing.Point(83, 325);
            this.txtTrece.Name = "txtTrece";
            this.txtTrece.ReadOnly = true;
            this.txtTrece.Size = new System.Drawing.Size(109, 26);
            this.txtTrece.TabIndex = 66;
            this.txtTrece.Text = "0";
            // 
            // txtTres
            // 
            this.txtTres.Location = new System.Drawing.Point(83, 364);
            this.txtTres.Name = "txtTres";
            this.txtTres.ReadOnly = true;
            this.txtTres.Size = new System.Drawing.Size(109, 26);
            this.txtTres.TabIndex = 67;
            this.txtTres.Text = "0";
            // 
            // cmbDiario
            // 
            this.cmbDiario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiario.FormattingEnabled = true;
            this.cmbDiario.Location = new System.Drawing.Point(883, 125);
            this.cmbDiario.Name = "cmbDiario";
            this.cmbDiario.Size = new System.Drawing.Size(176, 28);
            this.cmbDiario.TabIndex = 69;
            this.cmbDiario.SelectedIndexChanged += new System.EventHandler(this.cmbDiario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Comprobante Diario";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(579, 209);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 39);
            this.btnLimpiar.TabIndex = 71;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(958, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 39);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 701);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbDiario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTres);
            this.Controls.Add(this.txtTrece);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.gbDiario);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
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
            this.Name = "Form3";
            this.Text = "Comprobante Diario";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).EndInit();
            this.gbDiario.ResumeLayout(false);
            this.gbDiario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.ComboBox cmbEspecificacion;
        private System.Windows.Forms.Label lblEspecificacion;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.DataGridView dgvDiario;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.TextBox txtDebe;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.GroupBox gbDiario;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.TextBox txtTrece;
        private System.Windows.Forms.TextBox txtTres;
        private System.Windows.Forms.ComboBox cmbDiario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA_DEBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA_HABER;
        private System.Windows.Forms.Button btnEliminar;
    }
}