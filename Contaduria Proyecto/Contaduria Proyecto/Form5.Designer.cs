namespace Contaduria_Proyecto
{
    partial class Form5
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
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvTrabajo = new System.Windows.Forms.DataGridView();
            this.dgvcCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDEUDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcACREEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPERDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGANANCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPASPAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCaptura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportar.Location = new System.Drawing.Point(16, 18);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(224, 65);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "EXPORTAR A EXCEL";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(478, 18);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(224, 65);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvTrabajo
            // 
            this.dgvTrabajo.AllowUserToAddRows = false;
            this.dgvTrabajo.AllowUserToDeleteRows = false;
            this.dgvTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTrabajo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCUENTA,
            this.dgvcDEUDOR,
            this.dgvcACREEDOR,
            this.dgvcPERDIDA,
            this.dgvcGANANCIA,
            this.dgvcACTIVO,
            this.dgvcPASPAT});
            this.dgvTrabajo.Location = new System.Drawing.Point(16, 92);
            this.dgvTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTrabajo.Name = "dgvTrabajo";
            this.dgvTrabajo.ReadOnly = true;
            this.dgvTrabajo.RowHeadersWidth = 51;
            this.dgvTrabajo.Size = new System.Drawing.Size(1005, 558);
            this.dgvTrabajo.TabIndex = 5;
            this.dgvTrabajo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajo_CellContentClick);
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
            // dgvcPERDIDA
            // 
            this.dgvcPERDIDA.Frozen = true;
            this.dgvcPERDIDA.HeaderText = "EGRESOS";
            this.dgvcPERDIDA.MinimumWidth = 6;
            this.dgvcPERDIDA.Name = "dgvcPERDIDA";
            this.dgvcPERDIDA.ReadOnly = true;
            this.dgvcPERDIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcPERDIDA.Width = 80;
            // 
            // dgvcGANANCIA
            // 
            this.dgvcGANANCIA.Frozen = true;
            this.dgvcGANANCIA.HeaderText = "INGRESOS";
            this.dgvcGANANCIA.MinimumWidth = 6;
            this.dgvcGANANCIA.Name = "dgvcGANANCIA";
            this.dgvcGANANCIA.ReadOnly = true;
            this.dgvcGANANCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcGANANCIA.Width = 83;
            // 
            // dgvcACTIVO
            // 
            this.dgvcACTIVO.Frozen = true;
            this.dgvcACTIVO.HeaderText = "ACTIVO";
            this.dgvcACTIVO.MinimumWidth = 6;
            this.dgvcACTIVO.Name = "dgvcACTIVO";
            this.dgvcACTIVO.ReadOnly = true;
            this.dgvcACTIVO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcACTIVO.Width = 62;
            // 
            // dgvcPASPAT
            // 
            this.dgvcPASPAT.Frozen = true;
            this.dgvcPASPAT.HeaderText = "PASIVO Y PATRIMONIO";
            this.dgvcPASPAT.MinimumWidth = 6;
            this.dgvcPASPAT.Name = "dgvcPASPAT";
            this.dgvcPASPAT.ReadOnly = true;
            this.dgvcPASPAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcPASPAT.Width = 145;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCaptura.Location = new System.Drawing.Point(247, 18);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(224, 65);
            this.btnCaptura.TabIndex = 6;
            this.btnCaptura.Text = "GUARDAR COMO IMAGEN";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 669);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.dgvTrabajo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Hoja de Trabajo";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvTrabajo;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDEUDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcACREEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPERDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGANANCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcACTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPASPAT;
    }
}