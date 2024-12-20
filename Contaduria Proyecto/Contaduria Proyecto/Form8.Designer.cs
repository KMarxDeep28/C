namespace Contaduria_Proyecto
{
    partial class Form8
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
            this.gbBalanceGral = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPYP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtANC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPNC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.PATRIMONIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATRIMONIO_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPNC = new System.Windows.Forms.DataGridView();
            this.PASIVO_NO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASIVO_NO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvANC = new System.Windows.Forms.DataGridView();
            this.ACTIVO_NO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO_NO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.PASIVO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASIVO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAC = new System.Windows.Forms.DataGridView();
            this.ACTIVO_CORRIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO_CORRIENTE_SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbBalanceGral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvANC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBalanceGral
            // 
            this.gbBalanceGral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBalanceGral.AutoSize = true;
            this.gbBalanceGral.Controls.Add(this.label7);
            this.gbBalanceGral.Controls.Add(this.txtPasivo);
            this.gbBalanceGral.Controls.Add(this.label5);
            this.gbBalanceGral.Controls.Add(this.txtPYP);
            this.gbBalanceGral.Controls.Add(this.label6);
            this.gbBalanceGral.Controls.Add(this.txtA);
            this.gbBalanceGral.Controls.Add(this.label4);
            this.gbBalanceGral.Controls.Add(this.txtP);
            this.gbBalanceGral.Controls.Add(this.label3);
            this.gbBalanceGral.Controls.Add(this.txtANC);
            this.gbBalanceGral.Controls.Add(this.label2);
            this.gbBalanceGral.Controls.Add(this.txtPNC);
            this.gbBalanceGral.Controls.Add(this.label1);
            this.gbBalanceGral.Controls.Add(this.txtPC);
            this.gbBalanceGral.Controls.Add(this.TOTAL);
            this.gbBalanceGral.Controls.Add(this.txtAC);
            this.gbBalanceGral.Controls.Add(this.dgvP);
            this.gbBalanceGral.Controls.Add(this.dgvPNC);
            this.gbBalanceGral.Controls.Add(this.dgvANC);
            this.gbBalanceGral.Controls.Add(this.dgvPC);
            this.gbBalanceGral.Controls.Add(this.dgvAC);
            this.gbBalanceGral.Location = new System.Drawing.Point(28, 100);
            this.gbBalanceGral.Name = "gbBalanceGral";
            this.gbBalanceGral.Size = new System.Drawing.Size(759, 727);
            this.gbBalanceGral.TabIndex = 35;
            this.gbBalanceGral.TabStop = false;
            this.gbBalanceGral.Text = "BALANCE GENERAL";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "TOTAL PASIVO";
            // 
            // txtPasivo
            // 
            this.txtPasivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasivo.Location = new System.Drawing.Point(612, 465);
            this.txtPasivo.Name = "txtPasivo";
            this.txtPasivo.ReadOnly = true;
            this.txtPasivo.Size = new System.Drawing.Size(89, 26);
            this.txtPasivo.TabIndex = 29;
            this.txtPasivo.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 673);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "TOTAL PASIVO Y PATRIMONIO";
            // 
            // txtPYP
            // 
            this.txtPYP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPYP.Location = new System.Drawing.Point(612, 674);
            this.txtPYP.Name = "txtPYP";
            this.txtPYP.ReadOnly = true;
            this.txtPYP.Size = new System.Drawing.Size(89, 26);
            this.txtPYP.TabIndex = 27;
            this.txtPYP.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 672);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "TOTAL ACTIVO";
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA.Location = new System.Drawing.Point(280, 673);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(89, 26);
            this.txtA.TabIndex = 25;
            this.txtA.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "TOTAL PATRIMONIO";
            // 
            // txtP
            // 
            this.txtP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP.Location = new System.Drawing.Point(612, 625);
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(89, 26);
            this.txtP.TabIndex = 23;
            this.txtP.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "TOTAL ACTIVO NO CORRIENTE";
            // 
            // txtANC
            // 
            this.txtANC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtANC.Location = new System.Drawing.Point(280, 624);
            this.txtANC.Name = "txtANC";
            this.txtANC.ReadOnly = true;
            this.txtANC.Size = new System.Drawing.Size(89, 26);
            this.txtANC.TabIndex = 21;
            this.txtANC.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "TOTAL PASIVO NO CORRIENTE";
            // 
            // txtPNC
            // 
            this.txtPNC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPNC.Location = new System.Drawing.Point(612, 433);
            this.txtPNC.Name = "txtPNC";
            this.txtPNC.ReadOnly = true;
            this.txtPNC.Size = new System.Drawing.Size(89, 26);
            this.txtPNC.TabIndex = 19;
            this.txtPNC.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "TOTAL PASIVO CORRIENTE";
            // 
            // txtPC
            // 
            this.txtPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPC.Location = new System.Drawing.Point(612, 272);
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(89, 26);
            this.txtPC.TabIndex = 17;
            this.txtPC.Text = "0";
            // 
            // TOTAL
            // 
            this.TOTAL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(42, 323);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(178, 20);
            this.TOTAL.TabIndex = 16;
            this.TOTAL.Text = "TOTAL ACTIVO CORRIENTE";
            // 
            // txtAC
            // 
            this.txtAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAC.Location = new System.Drawing.Point(280, 324);
            this.txtAC.Name = "txtAC";
            this.txtAC.ReadOnly = true;
            this.txtAC.Size = new System.Drawing.Size(89, 26);
            this.txtAC.TabIndex = 15;
            this.txtAC.Text = "0";
            // 
            // dgvP
            // 
            this.dgvP.AllowUserToAddRows = false;
            this.dgvP.AllowUserToDeleteRows = false;
            this.dgvP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvP.BackgroundColor = System.Drawing.Color.White;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PATRIMONIO,
            this.PATRIMONIO_SALDO});
            this.dgvP.Location = new System.Drawing.Point(374, 501);
            this.dgvP.Name = "dgvP";
            this.dgvP.ReadOnly = true;
            this.dgvP.Size = new System.Drawing.Size(330, 118);
            this.dgvP.TabIndex = 14;
            // 
            // PATRIMONIO
            // 
            this.PATRIMONIO.HeaderText = "PATRIMONIO";
            this.PATRIMONIO.Name = "PATRIMONIO";
            this.PATRIMONIO.ReadOnly = true;
            this.PATRIMONIO.Width = 225;
            // 
            // PATRIMONIO_SALDO
            // 
            this.PATRIMONIO_SALDO.HeaderText = "";
            this.PATRIMONIO_SALDO.Name = "PATRIMONIO_SALDO";
            this.PATRIMONIO_SALDO.ReadOnly = true;
            // 
            // dgvPNC
            // 
            this.dgvPNC.AllowUserToAddRows = false;
            this.dgvPNC.AllowUserToDeleteRows = false;
            this.dgvPNC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPNC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPNC.BackgroundColor = System.Drawing.Color.White;
            this.dgvPNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPNC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PASIVO_NO_CORRIENTE,
            this.PASIVO_NO_CORRIENTE_SALDO});
            this.dgvPNC.Location = new System.Drawing.Point(374, 307);
            this.dgvPNC.Name = "dgvPNC";
            this.dgvPNC.ReadOnly = true;
            this.dgvPNC.Size = new System.Drawing.Size(330, 121);
            this.dgvPNC.TabIndex = 13;
            // 
            // PASIVO_NO_CORRIENTE
            // 
            this.PASIVO_NO_CORRIENTE.HeaderText = "PASIVO NO CORRIENTE";
            this.PASIVO_NO_CORRIENTE.Name = "PASIVO_NO_CORRIENTE";
            this.PASIVO_NO_CORRIENTE.ReadOnly = true;
            this.PASIVO_NO_CORRIENTE.Width = 225;
            // 
            // PASIVO_NO_CORRIENTE_SALDO
            // 
            this.PASIVO_NO_CORRIENTE_SALDO.HeaderText = "";
            this.PASIVO_NO_CORRIENTE_SALDO.Name = "PASIVO_NO_CORRIENTE_SALDO";
            this.PASIVO_NO_CORRIENTE_SALDO.ReadOnly = true;
            this.PASIVO_NO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvANC
            // 
            this.dgvANC.AllowUserToAddRows = false;
            this.dgvANC.AllowUserToDeleteRows = false;
            this.dgvANC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvANC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvANC.BackgroundColor = System.Drawing.Color.White;
            this.dgvANC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvANC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTIVO_NO_CORRIENTE,
            this.ACTIVO_NO_CORRIENTE_SALDO});
            this.dgvANC.Location = new System.Drawing.Point(42, 374);
            this.dgvANC.Name = "dgvANC";
            this.dgvANC.ReadOnly = true;
            this.dgvANC.Size = new System.Drawing.Size(327, 244);
            this.dgvANC.TabIndex = 12;
            // 
            // ACTIVO_NO_CORRIENTE
            // 
            this.ACTIVO_NO_CORRIENTE.HeaderText = "ACTIVO NO CORRIENTE";
            this.ACTIVO_NO_CORRIENTE.Name = "ACTIVO_NO_CORRIENTE";
            this.ACTIVO_NO_CORRIENTE.ReadOnly = true;
            this.ACTIVO_NO_CORRIENTE.Width = 225;
            // 
            // ACTIVO_NO_CORRIENTE_SALDO
            // 
            this.ACTIVO_NO_CORRIENTE_SALDO.HeaderText = "";
            this.ACTIVO_NO_CORRIENTE_SALDO.Name = "ACTIVO_NO_CORRIENTE_SALDO";
            this.ACTIVO_NO_CORRIENTE_SALDO.ReadOnly = true;
            this.ACTIVO_NO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvPC
            // 
            this.dgvPC.AllowUserToAddRows = false;
            this.dgvPC.AllowUserToDeleteRows = false;
            this.dgvPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPC.BackgroundColor = System.Drawing.Color.White;
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PASIVO_CORRIENTE,
            this.PASIVO_CORRIENTE_SALDO});
            this.dgvPC.Location = new System.Drawing.Point(374, 42);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.ReadOnly = true;
            this.dgvPC.Size = new System.Drawing.Size(330, 222);
            this.dgvPC.TabIndex = 11;
            // 
            // PASIVO_CORRIENTE
            // 
            this.PASIVO_CORRIENTE.HeaderText = "PASIVO CORRIENTE";
            this.PASIVO_CORRIENTE.Name = "PASIVO_CORRIENTE";
            this.PASIVO_CORRIENTE.ReadOnly = true;
            this.PASIVO_CORRIENTE.Width = 225;
            // 
            // PASIVO_CORRIENTE_SALDO
            // 
            this.PASIVO_CORRIENTE_SALDO.HeaderText = "";
            this.PASIVO_CORRIENTE_SALDO.Name = "PASIVO_CORRIENTE_SALDO";
            this.PASIVO_CORRIENTE_SALDO.ReadOnly = true;
            this.PASIVO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvAC
            // 
            this.dgvAC.AllowUserToAddRows = false;
            this.dgvAC.AllowUserToDeleteRows = false;
            this.dgvAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAC.BackgroundColor = System.Drawing.Color.White;
            this.dgvAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTIVO_CORRIENTE,
            this.ACTIVO_CORRIENTE_SALDO});
            this.dgvAC.Location = new System.Drawing.Point(42, 42);
            this.dgvAC.Name = "dgvAC";
            this.dgvAC.ReadOnly = true;
            this.dgvAC.Size = new System.Drawing.Size(327, 256);
            this.dgvAC.TabIndex = 10;
            // 
            // ACTIVO_CORRIENTE
            // 
            this.ACTIVO_CORRIENTE.HeaderText = "ACTIVO CORRIENTE";
            this.ACTIVO_CORRIENTE.Name = "ACTIVO_CORRIENTE";
            this.ACTIVO_CORRIENTE.ReadOnly = true;
            this.ACTIVO_CORRIENTE.Width = 225;
            // 
            // ACTIVO_CORRIENTE_SALDO
            // 
            this.ACTIVO_CORRIENTE_SALDO.HeaderText = "";
            this.ACTIVO_CORRIENTE_SALDO.Name = "ACTIVO_CORRIENTE_SALDO";
            this.ACTIVO_CORRIENTE_SALDO.ReadOnly = true;
            this.ACTIVO_CORRIENTE_SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Location = new System.Drawing.Point(26, 13);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(224, 65);
            this.btnCaptura.TabIndex = 38;
            this.btnCaptura.Text = "GUARDAR COMO IMAGEN";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(264, 14);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(224, 65);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 841);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbBalanceGral);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.Text = "Balance General";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.gbBalanceGral.ResumeLayout(false);
            this.gbBalanceGral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvANC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBalanceGral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPYP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtANC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.DataGridView dgvPNC;
        private System.Windows.Forms.DataGridView dgvANC;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.DataGridView dgvAC;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_NO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_NO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_NO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_NO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASIVO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_CORRIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO_CORRIENTE_SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATRIMONIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATRIMONIO_SALDO;
    }
}