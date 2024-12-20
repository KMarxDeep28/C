namespace Contaduria_Proyecto
{
    partial class Form7
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
            this.dgvMayor = new System.Windows.Forms.DataGridView();
            this.dgvDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMayor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).BeginInit();
            this.gbNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMayor
            // 
            this.dgvMayor.AllowUserToAddRows = false;
            this.dgvMayor.AllowUserToDeleteRows = false;
            this.dgvMayor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMayor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMayor.BackgroundColor = System.Drawing.Color.White;
            this.dgvMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDebe,
            this.dgvHaber});
            this.dgvMayor.Location = new System.Drawing.Point(19, 37);
            this.dgvMayor.Name = "dgvMayor";
            this.dgvMayor.ReadOnly = true;
            this.dgvMayor.RowHeadersWidth = 51;
            this.dgvMayor.Size = new System.Drawing.Size(273, 341);
            this.dgvMayor.TabIndex = 1;
            this.dgvMayor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMayor_CellContentClick);
            // 
            // dgvDebe
            // 
            this.dgvDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvDebe.Frozen = true;
            this.dgvDebe.HeaderText = "DEBE";
            this.dgvDebe.MinimumWidth = 6;
            this.dgvDebe.Name = "dgvDebe";
            this.dgvDebe.ReadOnly = true;
            this.dgvDebe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDebe.Width = 51;
            // 
            // dgvHaber
            // 
            this.dgvHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvHaber.Frozen = true;
            this.dgvHaber.HeaderText = "HABER";
            this.dgvHaber.MinimumWidth = 6;
            this.dgvHaber.Name = "dgvHaber";
            this.dgvHaber.ReadOnly = true;
            this.dgvHaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvHaber.Width = 60;
            // 
            // cmbMayor
            // 
            this.cmbMayor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMayor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMayor.FormattingEnabled = true;
            this.cmbMayor.Location = new System.Drawing.Point(224, 13);
            this.cmbMayor.Name = "cmbMayor";
            this.cmbMayor.Size = new System.Drawing.Size(108, 28);
            this.cmbMayor.TabIndex = 2;
            this.cmbMayor.SelectedIndexChanged += new System.EventHandler(this.cmbMayor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mayor";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportar.Location = new System.Drawing.Point(12, 59);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(133, 50);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "EXPORTAR A EXCEL";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Location = new System.Drawing.Point(292, 59);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImagen.Location = new System.Drawing.Point(152, 59);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(133, 50);
            this.btnImagen.TabIndex = 7;
            this.btnImagen.Text = "GUARDAR COMO IMAGEN";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // gbNombre
            // 
            this.gbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNombre.Controls.Add(this.textBox1);
            this.gbNombre.Controls.Add(this.textBox2);
            this.gbNombre.Controls.Add(this.txtHaber);
            this.gbNombre.Controls.Add(this.txtDebe);
            this.gbNombre.Controls.Add(this.dgvMayor);
            this.gbNombre.Location = new System.Drawing.Point(40, 156);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(327, 481);
            this.gbNombre.TabIndex = 8;
            this.gbNombre.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(132, 420);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(72, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(56, 420);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(72, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            // 
            // txtHaber
            // 
            this.txtHaber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHaber.Location = new System.Drawing.Point(132, 384);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.ReadOnly = true;
            this.txtHaber.Size = new System.Drawing.Size(72, 26);
            this.txtHaber.TabIndex = 3;
            this.txtHaber.Text = "0";
            // 
            // txtDebe
            // 
            this.txtDebe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDebe.Location = new System.Drawing.Point(56, 384);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.ReadOnly = true;
            this.txtDebe.Size = new System.Drawing.Size(72, 26);
            this.txtDebe.TabIndex = 2;
            this.txtDebe.Text = "0";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 649);
            this.Controls.Add(this.gbNombre);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMayor);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7";
            this.Text = "Mayores";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).EndInit();
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMayor;
        private System.Windows.Forms.ComboBox cmbMayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.TextBox txtDebe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHaber;
    }
}