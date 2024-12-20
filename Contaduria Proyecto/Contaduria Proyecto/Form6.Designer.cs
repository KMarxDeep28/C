namespace Contaduria_Proyecto
{
    partial class Form6
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
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.cmbEspecificacion = new System.Windows.Forms.ComboBox();
            this.lblEspecificacion = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lstCuenta = new System.Windows.Forms.ListBox();
            this.lblNuevaCuenta = new System.Windows.Forms.Label();
            this.txtNuevaCuenta = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuenta.Enabled = false;
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(374, 117);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(312, 28);
            this.cmbCuenta.TabIndex = 11;
            this.cmbCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbCuenta_SelectedIndexChanged);
            // 
            // lblCuenta
            // 
            this.lblCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Enabled = false;
            this.lblCuenta.Location = new System.Drawing.Point(11, 117);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(50, 20);
            this.lblCuenta.TabIndex = 10;
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
            this.cmbEspecificacion.Location = new System.Drawing.Point(374, 61);
            this.cmbEspecificacion.Name = "cmbEspecificacion";
            this.cmbEspecificacion.Size = new System.Drawing.Size(312, 28);
            this.cmbEspecificacion.TabIndex = 9;
            this.cmbEspecificacion.SelectedIndexChanged += new System.EventHandler(this.cmbEspecificacion_SelectedIndexChanged);
            // 
            // lblEspecificacion
            // 
            this.lblEspecificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEspecificacion.AutoSize = true;
            this.lblEspecificacion.Enabled = false;
            this.lblEspecificacion.Location = new System.Drawing.Point(11, 61);
            this.lblEspecificacion.Name = "lblEspecificacion";
            this.lblEspecificacion.Size = new System.Drawing.Size(96, 20);
            this.lblEspecificacion.TabIndex = 8;
            this.lblEspecificacion.Text = "Especificacion";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Items.AddRange(new object[] {
            "ACTIVO",
            "PASIVO",
            "PATRIMONIO",
            "INGRESO",
            "COSTO",
            "GASTO"});
            this.cmbTipoCuenta.Location = new System.Drawing.Point(374, 9);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(312, 28);
            this.cmbTipoCuenta.TabIndex = 7;
            this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(11, 9);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(100, 20);
            this.lblTipoCuenta.TabIndex = 6;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // lstCuenta
            // 
            this.lstCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCuenta.FormattingEnabled = true;
            this.lstCuenta.ItemHeight = 20;
            this.lstCuenta.Location = new System.Drawing.Point(14, 263);
            this.lstCuenta.Name = "lstCuenta";
            this.lstCuenta.Size = new System.Drawing.Size(687, 284);
            this.lstCuenta.TabIndex = 12;
            this.lstCuenta.SelectedIndexChanged += new System.EventHandler(this.lstCuenta_SelectedIndexChanged);
            // 
            // lblNuevaCuenta
            // 
            this.lblNuevaCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNuevaCuenta.AutoSize = true;
            this.lblNuevaCuenta.Enabled = false;
            this.lblNuevaCuenta.Location = new System.Drawing.Point(11, 168);
            this.lblNuevaCuenta.Name = "lblNuevaCuenta";
            this.lblNuevaCuenta.Size = new System.Drawing.Size(92, 20);
            this.lblNuevaCuenta.TabIndex = 14;
            this.lblNuevaCuenta.Text = "Nueva Cuenta";
            // 
            // txtNuevaCuenta
            // 
            this.txtNuevaCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNuevaCuenta.Enabled = false;
            this.txtNuevaCuenta.Location = new System.Drawing.Point(374, 165);
            this.txtNuevaCuenta.Name = "txtNuevaCuenta";
            this.txtNuevaCuenta.Size = new System.Drawing.Size(312, 26);
            this.txtNuevaCuenta.TabIndex = 13;
            this.txtNuevaCuenta.TextChanged += new System.EventHandler(this.txtNuevaCuenta_TextChanged);
            this.txtNuevaCuenta.Enter += new System.EventHandler(this.txtNuevaCuenta_Enter);
            this.txtNuevaCuenta.Leave += new System.EventHandler(this.txtNuevaCuenta_Leave);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(224, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 39);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(14, 207);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 39);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(118, 207);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 39);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 558);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNuevaCuenta);
            this.Controls.Add(this.txtNuevaCuenta);
            this.Controls.Add(this.lstCuenta);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.cmbEspecificacion);
            this.Controls.Add(this.lblEspecificacion);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form6";
            this.Text = "Plan de Cuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.ComboBox cmbEspecificacion;
        private System.Windows.Forms.Label lblEspecificacion;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ListBox lstCuenta;
        private System.Windows.Forms.Label lblNuevaCuenta;
        private System.Windows.Forms.TextBox txtNuevaCuenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}