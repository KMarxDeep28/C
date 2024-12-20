namespace Contaduria_Proyecto
{
    partial class Form2
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
            this.btnBalanceInicial = new System.Windows.Forms.Button();
            this.btnComprobanteDiario = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnHojaDeTrabajo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalanceInicial
            // 
            this.btnBalanceInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBalanceInicial.Location = new System.Drawing.Point(106, 69);
            this.btnBalanceInicial.Name = "btnBalanceInicial";
            this.btnBalanceInicial.Size = new System.Drawing.Size(164, 83);
            this.btnBalanceInicial.TabIndex = 0;
            this.btnBalanceInicial.Text = "Balance Inicial";
            this.btnBalanceInicial.UseVisualStyleBackColor = true;
            this.btnBalanceInicial.Click += new System.EventHandler(this.btnBalanceInicial_Click);
            // 
            // btnComprobanteDiario
            // 
            this.btnComprobanteDiario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComprobanteDiario.Location = new System.Drawing.Point(106, 158);
            this.btnComprobanteDiario.Name = "btnComprobanteDiario";
            this.btnComprobanteDiario.Size = new System.Drawing.Size(164, 83);
            this.btnComprobanteDiario.TabIndex = 1;
            this.btnComprobanteDiario.Text = "Comprobantes Diarios";
            this.btnComprobanteDiario.UseVisualStyleBackColor = true;
            this.btnComprobanteDiario.Click += new System.EventHandler(this.btnComprobanteDiario_Click);
            // 
            // btnBC
            // 
            this.btnBC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBC.Location = new System.Drawing.Point(106, 336);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(164, 83);
            this.btnBC.TabIndex = 2;
            this.btnBC.Text = "Balance de Comprobacion";
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.AutoSize = true;
            this.btnSalir.Location = new System.Drawing.Point(270, 612);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.Location = new System.Drawing.Point(11, 612);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 40);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar Datos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnHojaDeTrabajo
            // 
            this.btnHojaDeTrabajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHojaDeTrabajo.Location = new System.Drawing.Point(106, 425);
            this.btnHojaDeTrabajo.Name = "btnHojaDeTrabajo";
            this.btnHojaDeTrabajo.Size = new System.Drawing.Size(164, 83);
            this.btnHojaDeTrabajo.TabIndex = 5;
            this.btnHojaDeTrabajo.Text = "Hoja de Trabajo";
            this.btnHojaDeTrabajo.UseVisualStyleBackColor = true;
            this.btnHojaDeTrabajo.Click += new System.EventHandler(this.btnHojaDeTrabajo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONTADURIA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "KEVIN ALEJANDRO BALDIVIESO ROJAS";
            // 
            // btnCuentas
            // 
            this.btnCuentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCuentas.AutoSize = true;
            this.btnCuentas.Location = new System.Drawing.Point(140, 612);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(124, 40);
            this.btnCuentas.TabIndex = 8;
            this.btnCuentas.Text = "Plan de Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(106, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 83);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mayores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(106, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 83);
            this.button2.TabIndex = 10;
            this.button2.Text = "Balance General";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 659);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHojaDeTrabajo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.btnComprobanteDiario);
            this.Controls.Add(this.btnBalanceInicial);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBalanceInicial;
        private System.Windows.Forms.Button btnComprobanteDiario;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnHojaDeTrabajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}