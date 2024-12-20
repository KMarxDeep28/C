namespace Contaduria_Proyecto
{
    partial class Form4
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
            this.dgvComprobacion = new System.Windows.Forms.DataGridView();
            this.dgvcCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDEBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHABER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDEUDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcACREEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCaptura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprobacion
            // 
            this.dgvComprobacion.AllowUserToAddRows = false;
            this.dgvComprobacion.AllowUserToDeleteRows = false;
            this.dgvComprobacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComprobacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvComprobacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvComprobacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCUENTA,
            this.dgvcDEBE,
            this.dgvcHABER,
            this.dgvcDEUDOR,
            this.dgvcACREEDOR});
            this.dgvComprobacion.Location = new System.Drawing.Point(18, 93);
            this.dgvComprobacion.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComprobacion.Name = "dgvComprobacion";
            this.dgvComprobacion.ReadOnly = true;
            this.dgvComprobacion.RowHeadersWidth = 51;
            this.dgvComprobacion.Size = new System.Drawing.Size(1102, 591);
            this.dgvComprobacion.TabIndex = 0;
            // 
            // dgvcCUENTA
            // 
            this.dgvcCUENTA.Frozen = true;
            this.dgvcCUENTA.HeaderText = "CUENTA";
            this.dgvcCUENTA.MinimumWidth = 6;
            this.dgvcCUENTA.Name = "dgvcCUENTA";
            this.dgvcCUENTA.ReadOnly = true;
            this.dgvcCUENTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcCUENTA.Width = 67;
            // 
            // dgvcDEBE
            // 
            this.dgvcDEBE.Frozen = true;
            this.dgvcDEBE.HeaderText = "DEBE";
            this.dgvcDEBE.MinimumWidth = 6;
            this.dgvcDEBE.Name = "dgvcDEBE";
            this.dgvcDEBE.ReadOnly = true;
            this.dgvcDEBE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcDEBE.Width = 51;
            // 
            // dgvcHABER
            // 
            this.dgvcHABER.Frozen = true;
            this.dgvcHABER.HeaderText = "HABER";
            this.dgvcHABER.MinimumWidth = 6;
            this.dgvcHABER.Name = "dgvcHABER";
            this.dgvcHABER.ReadOnly = true;
            this.dgvcHABER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcHABER.Width = 60;
            // 
            // dgvcDEUDOR
            // 
            this.dgvcDEUDOR.Frozen = true;
            this.dgvcDEUDOR.HeaderText = "DEUDOR";
            this.dgvcDEUDOR.MinimumWidth = 6;
            this.dgvcDEUDOR.Name = "dgvcDEUDOR";
            this.dgvcDEUDOR.ReadOnly = true;
            this.dgvcDEUDOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcDEUDOR.Width = 70;
            // 
            // dgvcACREEDOR
            // 
            this.dgvcACREEDOR.Frozen = true;
            this.dgvcACREEDOR.HeaderText = "ACREEDOR";
            this.dgvcACREEDOR.MinimumWidth = 6;
            this.dgvcACREEDOR.Name = "dgvcACREEDOR";
            this.dgvcACREEDOR.ReadOnly = true;
            this.dgvcACREEDOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcACREEDOR.Width = 88;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(480, 20);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(224, 64);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportar.Location = new System.Drawing.Point(18, 20);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(224, 64);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "EXPORTAR A EXCEL";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCaptura
            // 
            this.btnCaptura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCaptura.Location = new System.Drawing.Point(249, 20);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(224, 64);
            this.btnCaptura.TabIndex = 3;
            this.btnCaptura.Text = "GUARDAR COMO IMAGEN";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 703);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvComprobacion);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Balance de Comprobacion";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprobacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDEBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHABER;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDEUDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcACREEDOR;
    }
}