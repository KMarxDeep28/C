

namespace ReproductorVideoMusica2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pFondo = new System.Windows.Forms.Panel();
            this.pReproductor = new System.Windows.Forms.Panel();
            this.pInformacion = new System.Windows.Forms.Panel();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pBarraHerramientas = new System.Windows.Forms.Panel();
            this.lblVelocidadReproduccion = new System.Windows.Forms.Label();
            this.dtbIndicador = new UIDC.UI_TrackBarWindows();
            this.dtbVolumen = new UIDC.UI_TrackBarText();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblIndicador = new System.Windows.Forms.Label();
            this.pbModoReproduccion = new System.Windows.Forms.PictureBox();
            this.pcbPantallaCompleta = new System.Windows.Forms.PictureBox();
            this.pcbVolumen = new System.Windows.Forms.PictureBox();
            this.pcbSiguiente = new System.Windows.Forms.PictureBox();
            this.pcbReproducir = new System.Windows.Forms.PictureBox();
            this.pcbAnterior = new System.Windows.Forms.PictureBox();
            this.uicpVolumen = new UIDC.UI_CircleProgress();
            this.pbPortada = new UIDC.UI_CirclePictureBox();
            this.aWMPReproductorVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPantallaCompleta = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnMasVolumen = new System.Windows.Forms.Button();
            this.btnMenosVolumen = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnMenosVelocidad = new System.Windows.Forms.Button();
            this.btnRetrocesoRapido = new System.Windows.Forms.Button();
            this.btnAvanceRapido = new System.Windows.Forms.Button();
            this.btnMasVelocidad = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.uljJoystick = new UIDC.UI_JoyStick();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrIndicador = new System.Windows.Forms.Timer(this.components);
            this.tmrPresionado = new System.Windows.Forms.Timer(this.components);
            this.clLedEncendido = new Control_LED_Configurable.Control_LED_Ruben();
            this.clLedDuracion = new Control_LED_Configurable.Control_LED_Ruben();
            this.pFondo.SuspendLayout();
            this.pReproductor.SuspendLayout();
            this.pInformacion.SuspendLayout();
            this.pBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModoReproduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPantallaCompleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWMPReproductorVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // pFondo
            // 
            this.pFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFondo.BackgroundImage = global::ReproductorVideoMusica2.Properties.Resources.psp_psd_template_by_skullsntikis_d1ktouk_fullview;
            this.pFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pFondo.Controls.Add(this.clLedDuracion);
            this.pFondo.Controls.Add(this.clLedEncendido);
            this.pFondo.Controls.Add(this.pReproductor);
            this.pFondo.Controls.Add(this.btnSiguiente);
            this.pFondo.Controls.Add(this.btnAnterior);
            this.pFondo.Controls.Add(this.btnHome);
            this.pFondo.Controls.Add(this.btnPantallaCompleta);
            this.pFondo.Controls.Add(this.btnPlaylist);
            this.pFondo.Controls.Add(this.btnMasVolumen);
            this.pFondo.Controls.Add(this.btnMenosVolumen);
            this.pFondo.Controls.Add(this.btnSelect);
            this.pFondo.Controls.Add(this.btnStart);
            this.pFondo.Controls.Add(this.btnMenosVelocidad);
            this.pFondo.Controls.Add(this.btnRetrocesoRapido);
            this.pFondo.Controls.Add(this.btnAvanceRapido);
            this.pFondo.Controls.Add(this.btnMasVelocidad);
            this.pFondo.Controls.Add(this.btnX);
            this.pFondo.Controls.Add(this.btnCuadrado);
            this.pFondo.Controls.Add(this.btnCirculo);
            this.pFondo.Controls.Add(this.btnTriangulo);
            this.pFondo.Controls.Add(this.uljJoystick);
            this.pFondo.Controls.Add(this.dgvPlaylist);
            this.pFondo.Location = new System.Drawing.Point(0, 0);
            this.pFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pFondo.Name = "pFondo";
            this.pFondo.Size = new System.Drawing.Size(1733, 800);
            this.pFondo.TabIndex = 0;
            // 
            // pReproductor
            // 
            this.pReproductor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pReproductor.BackColor = System.Drawing.Color.Black;
            this.pReproductor.Controls.Add(this.pInformacion);
            this.pReproductor.Controls.Add(this.pBarraHerramientas);
            this.pReproductor.Controls.Add(this.uicpVolumen);
            this.pReproductor.Controls.Add(this.pbPortada);
            this.pReproductor.Controls.Add(this.aWMPReproductorVideo);
            this.pReproductor.Location = new System.Drawing.Point(396, 73);
            this.pReproductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pReproductor.Name = "pReproductor";
            this.pReproductor.Size = new System.Drawing.Size(949, 379);
            this.pReproductor.TabIndex = 0;
            // 
            // pInformacion
            // 
            this.pInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.pInformacion.Controls.Add(this.lblGenero);
            this.pInformacion.Controls.Add(this.lblAnio);
            this.pInformacion.Controls.Add(this.lblAlbum);
            this.pInformacion.Controls.Add(this.lblArtista);
            this.pInformacion.Controls.Add(this.lblTitulo);
            this.pInformacion.Location = new System.Drawing.Point(0, 0);
            this.pInformacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pInformacion.Name = "pInformacion";
            this.pInformacion.Size = new System.Drawing.Size(949, 82);
            this.pInformacion.TabIndex = 18;
            this.pInformacion.Visible = false;
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(441, 52);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(82, 23);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero:";
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(441, 30);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(51, 23);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(5, 52);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(70, 23);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Album:";
            // 
            // lblArtista
            // 
            this.lblArtista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.Location = new System.Drawing.Point(5, 30);
            this.lblArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(73, 23);
            this.lblArtista.TabIndex = 1;
            this.lblArtista.Text = "Artista:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // pBarraHerramientas
            // 
            this.pBarraHerramientas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarraHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.pBarraHerramientas.Controls.Add(this.lblVelocidadReproduccion);
            this.pBarraHerramientas.Controls.Add(this.dtbIndicador);
            this.pBarraHerramientas.Controls.Add(this.dtbVolumen);
            this.pBarraHerramientas.Controls.Add(this.lblDuracion);
            this.pBarraHerramientas.Controls.Add(this.lblIndicador);
            this.pBarraHerramientas.Controls.Add(this.pbModoReproduccion);
            this.pBarraHerramientas.Controls.Add(this.pcbPantallaCompleta);
            this.pBarraHerramientas.Controls.Add(this.pcbVolumen);
            this.pBarraHerramientas.Controls.Add(this.pcbSiguiente);
            this.pBarraHerramientas.Controls.Add(this.pcbReproducir);
            this.pBarraHerramientas.Controls.Add(this.pcbAnterior);
            this.pBarraHerramientas.Location = new System.Drawing.Point(0, 281);
            this.pBarraHerramientas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBarraHerramientas.Name = "pBarraHerramientas";
            this.pBarraHerramientas.Size = new System.Drawing.Size(949, 98);
            this.pBarraHerramientas.TabIndex = 19;
            this.pBarraHerramientas.Visible = false;
            // 
            // lblVelocidadReproduccion
            // 
            this.lblVelocidadReproduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVelocidadReproduccion.AutoSize = true;
            this.lblVelocidadReproduccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidadReproduccion.Location = new System.Drawing.Point(543, 66);
            this.lblVelocidadReproduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVelocidadReproduccion.Name = "lblVelocidadReproduccion";
            this.lblVelocidadReproduccion.Size = new System.Drawing.Size(248, 23);
            this.lblVelocidadReproduccion.TabIndex = 19;
            this.lblVelocidadReproduccion.Text = "Velocidad de reproducción:";
            // 
            // dtbIndicador
            // 
            this.dtbIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbIndicador.BackColor = System.Drawing.Color.Transparent;
            this.dtbIndicador.BarActiveColour = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.dtbIndicador.BarShowColour = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.dtbIndicador.ForeColor = System.Drawing.Color.Transparent;
            this.dtbIndicador.LineColour = System.Drawing.Color.White;
            this.dtbIndicador.LineShowColour = System.Drawing.Color.Transparent;
            this.dtbIndicador.Location = new System.Drawing.Point(4, 4);
            this.dtbIndicador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtbIndicador.Maximum = 100;
            this.dtbIndicador.Name = "dtbIndicador";
            this.dtbIndicador.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.dtbIndicador.Round = true;
            this.dtbIndicador.Size = new System.Drawing.Size(933, 25);
            this.dtbIndicador.TabIndex = 18;
            this.dtbIndicador.Text = "uI_TrackBarWindows1";
            this.dtbIndicador.Value = 0;
            this.dtbIndicador.ValueChanged += new UIDC.UI_TrackBarWindows.ValueChangedEventHandler(this.dtbIndicador_ValueChanged);
            // 
            // dtbVolumen
            // 
            this.dtbVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtbVolumen.BackColor = System.Drawing.Color.Transparent;
            this.dtbVolumen.BarBaseColour = System.Drawing.Color.White;
            this.dtbVolumen.BorderColour = System.Drawing.Color.White;
            this.dtbVolumen.Colour_Strip1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.dtbVolumen.Colour_Strip2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.dtbVolumen.Location = new System.Drawing.Point(169, 66);
            this.dtbVolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtbVolumen.Maximum = 100;
            this.dtbVolumen.Name = "dtbVolumen";
            this.dtbVolumen.Size = new System.Drawing.Size(136, 28);
            this.dtbVolumen.StripColour = System.Drawing.Color.White;
            this.dtbVolumen.TabIndex = 18;
            this.dtbVolumen.Text = "uI_TrackBarText1";
            this.dtbVolumen.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.dtbVolumen.Value = 50;
            this.dtbVolumen.Visible = false;
            this.dtbVolumen.ValueChanged += new UIDC.UI_TrackBarText.ValueChangedEventHandler(this.dtbVolumen_ValueChanged);
            this.dtbVolumen.MouseLeave += new System.EventHandler(this.dtbVolumen_MouseLeave);
            // 
            // lblDuracion
            // 
            this.lblDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(871, 38);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(60, 23);
            this.lblDuracion.TabIndex = 6;
            this.lblDuracion.Text = "00:00";
            // 
            // lblIndicador
            // 
            this.lblIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIndicador.AutoSize = true;
            this.lblIndicador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicador.Location = new System.Drawing.Point(5, 38);
            this.lblIndicador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicador.Name = "lblIndicador";
            this.lblIndicador.Size = new System.Drawing.Size(60, 23);
            this.lblIndicador.TabIndex = 5;
            this.lblIndicador.Text = "00:00";
            // 
            // pbModoReproduccion
            // 
            this.pbModoReproduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbModoReproduccion.BackColor = System.Drawing.Color.Transparent;
            this.pbModoReproduccion.Image = global::ReproductorVideoMusica2.Properties.Resources.repetir;
            this.pbModoReproduccion.Location = new System.Drawing.Point(863, 64);
            this.pbModoReproduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbModoReproduccion.Name = "pbModoReproduccion";
            this.pbModoReproduccion.Size = new System.Drawing.Size(33, 31);
            this.pbModoReproduccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModoReproduccion.TabIndex = 5;
            this.pbModoReproduccion.TabStop = false;
            this.pbModoReproduccion.Click += new System.EventHandler(this.pbModoReproduccion_Click);
            // 
            // pcbPantallaCompleta
            // 
            this.pcbPantallaCompleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbPantallaCompleta.BackColor = System.Drawing.Color.Transparent;
            this.pcbPantallaCompleta.Image = global::ReproductorVideoMusica2.Properties.Resources.maximizar;
            this.pcbPantallaCompleta.Location = new System.Drawing.Point(904, 64);
            this.pcbPantallaCompleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbPantallaCompleta.Name = "pcbPantallaCompleta";
            this.pcbPantallaCompleta.Size = new System.Drawing.Size(33, 31);
            this.pcbPantallaCompleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPantallaCompleta.TabIndex = 4;
            this.pcbPantallaCompleta.TabStop = false;
            this.pcbPantallaCompleta.Click += new System.EventHandler(this.pcbPantallaCompleta_Click);
            // 
            // pcbVolumen
            // 
            this.pcbVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbVolumen.BackColor = System.Drawing.Color.Transparent;
            this.pcbVolumen.Image = global::ReproductorVideoMusica2.Properties.Resources.alto_volumen;
            this.pcbVolumen.Location = new System.Drawing.Point(128, 64);
            this.pcbVolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbVolumen.Name = "pcbVolumen";
            this.pcbVolumen.Size = new System.Drawing.Size(33, 31);
            this.pcbVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVolumen.TabIndex = 3;
            this.pcbVolumen.TabStop = false;
            this.pcbVolumen.Click += new System.EventHandler(this.pcbVolumen_Click);
            this.pcbVolumen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbVolumen_MouseMove);
            // 
            // pcbSiguiente
            // 
            this.pcbSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.pcbSiguiente.Image = global::ReproductorVideoMusica2.Properties.Resources.proximo;
            this.pcbSiguiente.Location = new System.Drawing.Point(87, 64);
            this.pcbSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbSiguiente.Name = "pcbSiguiente";
            this.pcbSiguiente.Size = new System.Drawing.Size(33, 31);
            this.pcbSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSiguiente.TabIndex = 2;
            this.pcbSiguiente.TabStop = false;
            this.pcbSiguiente.Click += new System.EventHandler(this.pcbSiguiente_Click);
            // 
            // pcbReproducir
            // 
            this.pcbReproducir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbReproducir.BackColor = System.Drawing.Color.Transparent;
            this.pcbReproducir.Image = global::ReproductorVideoMusica2.Properties.Resources.jugar;
            this.pcbReproducir.Location = new System.Drawing.Point(45, 64);
            this.pcbReproducir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbReproducir.Name = "pcbReproducir";
            this.pcbReproducir.Size = new System.Drawing.Size(33, 31);
            this.pcbReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbReproducir.TabIndex = 1;
            this.pcbReproducir.TabStop = false;
            this.pcbReproducir.Click += new System.EventHandler(this.pcbReproducir_Click);
            // 
            // pcbAnterior
            // 
            this.pcbAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbAnterior.BackColor = System.Drawing.Color.Transparent;
            this.pcbAnterior.Image = global::ReproductorVideoMusica2.Properties.Resources.atras;
            this.pcbAnterior.Location = new System.Drawing.Point(4, 64);
            this.pcbAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbAnterior.Name = "pcbAnterior";
            this.pcbAnterior.Size = new System.Drawing.Size(33, 31);
            this.pcbAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnterior.TabIndex = 0;
            this.pcbAnterior.TabStop = false;
            this.pcbAnterior.Click += new System.EventHandler(this.pcbAnterior_Click);
            // 
            // uicpVolumen
            // 
            this.uicpVolumen.BackColor = System.Drawing.Color.Transparent;
            this.uicpVolumen.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uicpVolumen.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.uicpVolumen.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.uicpVolumen.ForeColor = System.Drawing.Color.DimGray;
            this.uicpVolumen.Location = new System.Drawing.Point(0, 150);
            this.uicpVolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uicpVolumen.Maximum = 100;
            this.uicpVolumen.Name = "uicpVolumen";
            this.uicpVolumen.ProgressColour = System.Drawing.Color.Lime;
            this.uicpVolumen.RotationAngle = 180;
            this.uicpVolumen.Size = new System.Drawing.Size(79, 79);
            this.uicpVolumen.StartingAngle = 270;
            this.uicpVolumen.TabIndex = 21;
            this.uicpVolumen.Text = "uI_CircleProgress1";
            this.uicpVolumen.Value = 50;
            this.uicpVolumen.Visible = false;
            // 
            // pbPortada
            // 
            this.pbPortada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPortada.BackColor = System.Drawing.Color.Transparent;
            this.pbPortada.Filter = false;
            this.pbPortada.FilterAlpha = 0;
            this.pbPortada.FilterAngleAlpha = 180;
            this.pbPortada.FilterGradiantLeft = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.pbPortada.FilterGradiantRight = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.pbPortada.Image = global::ReproductorVideoMusica2.Properties.Resources.pngwing_com;
            this.pbPortada.Location = new System.Drawing.Point(389, 90);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.PicBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.pbPortada.PicBackColorAlpha = 100;
            this.pbPortada.RadioAngleAlpha = 180;
            this.pbPortada.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.pbPortada.RadioFilter = false;
            this.pbPortada.RadioFilterAlpha = 80;
            this.pbPortada.RadioGradiantLeft = System.Drawing.Color.Transparent;
            this.pbPortada.RadioGradiantRight = System.Drawing.Color.Transparent;
            this.pbPortada.RadioSize = 3;
            this.pbPortada.Size = new System.Drawing.Size(185, 185);
            this.pbPortada.TabIndex = 20;
            this.pbPortada.Visible = false;
            // 
            // aWMPReproductorVideo
            // 
            this.aWMPReproductorVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aWMPReproductorVideo.Enabled = true;
            this.aWMPReproductorVideo.Location = new System.Drawing.Point(3, 3);
            this.aWMPReproductorVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aWMPReproductorVideo.Name = "aWMPReproductorVideo";
            this.aWMPReproductorVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("aWMPReproductorVideo.OcxState")));
            this.aWMPReproductorVideo.Size = new System.Drawing.Size(706, 302);
            this.aWMPReproductorVideo.TabIndex = 1;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(1387, 36);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(197, 54);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(153, 36);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(197, 54);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(371, 474);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 37);
            this.btnHome.TabIndex = 15;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPantallaCompleta
            // 
            this.btnPantallaCompleta.BackColor = System.Drawing.Color.Transparent;
            this.btnPantallaCompleta.FlatAppearance.BorderSize = 0;
            this.btnPantallaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantallaCompleta.Location = new System.Drawing.Point(1020, 474);
            this.btnPantallaCompleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPantallaCompleta.Name = "btnPantallaCompleta";
            this.btnPantallaCompleta.Size = new System.Drawing.Size(53, 37);
            this.btnPantallaCompleta.TabIndex = 14;
            this.btnPantallaCompleta.UseVisualStyleBackColor = false;
            this.btnPantallaCompleta.Click += new System.EventHandler(this.btnPantallaCompleta_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Location = new System.Drawing.Point(1096, 474);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(53, 37);
            this.btnPlaylist.TabIndex = 13;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnMasVolumen
            // 
            this.btnMasVolumen.BackColor = System.Drawing.Color.Transparent;
            this.btnMasVolumen.FlatAppearance.BorderSize = 0;
            this.btnMasVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasVolumen.Location = new System.Drawing.Point(619, 474);
            this.btnMasVolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasVolumen.Name = "btnMasVolumen";
            this.btnMasVolumen.Size = new System.Drawing.Size(53, 37);
            this.btnMasVolumen.TabIndex = 12;
            this.btnMasVolumen.UseVisualStyleBackColor = false;
            this.btnMasVolumen.Click += new System.EventHandler(this.btnMasVolumen_Click);
            this.btnMasVolumen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMasVolumen_MouseDown);
            this.btnMasVolumen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMasVolumen_MouseUp);
            // 
            // btnMenosVolumen
            // 
            this.btnMenosVolumen.BackColor = System.Drawing.Color.Transparent;
            this.btnMenosVolumen.FlatAppearance.BorderSize = 0;
            this.btnMenosVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosVolumen.Location = new System.Drawing.Point(511, 474);
            this.btnMenosVolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenosVolumen.Name = "btnMenosVolumen";
            this.btnMenosVolumen.Size = new System.Drawing.Size(53, 37);
            this.btnMenosVolumen.TabIndex = 11;
            this.btnMenosVolumen.UseVisualStyleBackColor = false;
            this.btnMenosVolumen.Click += new System.EventHandler(this.btnMenosVolumen_Click);
            this.btnMenosVolumen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMenosVolumen_MouseDown);
            this.btnMenosVolumen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMenosVolumen_MouseUp);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(1183, 474);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(93, 37);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(1284, 474);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 37);
            this.btnStart.TabIndex = 9;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMenosVelocidad
            // 
            this.btnMenosVelocidad.BackColor = System.Drawing.Color.Transparent;
            this.btnMenosVelocidad.FlatAppearance.BorderSize = 0;
            this.btnMenosVelocidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosVelocidad.Location = new System.Drawing.Point(203, 266);
            this.btnMenosVelocidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenosVelocidad.Name = "btnMenosVelocidad";
            this.btnMenosVelocidad.Size = new System.Drawing.Size(69, 68);
            this.btnMenosVelocidad.TabIndex = 8;
            this.btnMenosVelocidad.UseVisualStyleBackColor = false;
            this.btnMenosVelocidad.Click += new System.EventHandler(this.btnMenosVelocidad_Click);
            // 
            // btnRetrocesoRapido
            // 
            this.btnRetrocesoRapido.BackColor = System.Drawing.Color.Transparent;
            this.btnRetrocesoRapido.FlatAppearance.BorderSize = 0;
            this.btnRetrocesoRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrocesoRapido.Location = new System.Drawing.Point(121, 223);
            this.btnRetrocesoRapido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetrocesoRapido.Name = "btnRetrocesoRapido";
            this.btnRetrocesoRapido.Size = new System.Drawing.Size(73, 64);
            this.btnRetrocesoRapido.TabIndex = 7;
            this.btnRetrocesoRapido.UseVisualStyleBackColor = false;
            this.btnRetrocesoRapido.Click += new System.EventHandler(this.btnRetrocesoRapido_Click);
            // 
            // btnAvanceRapido
            // 
            this.btnAvanceRapido.BackColor = System.Drawing.Color.Transparent;
            this.btnAvanceRapido.FlatAppearance.BorderSize = 0;
            this.btnAvanceRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanceRapido.Location = new System.Drawing.Point(277, 223);
            this.btnAvanceRapido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvanceRapido.Name = "btnAvanceRapido";
            this.btnAvanceRapido.Size = new System.Drawing.Size(73, 64);
            this.btnAvanceRapido.TabIndex = 6;
            this.btnAvanceRapido.UseVisualStyleBackColor = false;
            this.btnAvanceRapido.Click += new System.EventHandler(this.btnAvanceRapido_Click);
            // 
            // btnMasVelocidad
            // 
            this.btnMasVelocidad.BackColor = System.Drawing.Color.Transparent;
            this.btnMasVelocidad.FlatAppearance.BorderSize = 0;
            this.btnMasVelocidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasVelocidad.Location = new System.Drawing.Point(205, 170);
            this.btnMasVelocidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasVelocidad.Name = "btnMasVelocidad";
            this.btnMasVelocidad.Size = new System.Drawing.Size(69, 68);
            this.btnMasVelocidad.TabIndex = 5;
            this.btnMasVelocidad.UseVisualStyleBackColor = false;
            this.btnMasVelocidad.Click += new System.EventHandler(this.btnMasVelocidad_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(1467, 286);
            this.btnX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(67, 62);
            this.btnX.TabIndex = 4;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.Transparent;
            this.btnCuadrado.FlatAppearance.BorderSize = 0;
            this.btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadrado.Location = new System.Drawing.Point(1373, 214);
            this.btnCuadrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(67, 62);
            this.btnCuadrado.TabIndex = 3;
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.Color.Transparent;
            this.btnCirculo.FlatAppearance.BorderSize = 0;
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.Location = new System.Drawing.Point(1559, 214);
            this.btnCirculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(67, 62);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackColor = System.Drawing.Color.Transparent;
            this.btnTriangulo.FlatAppearance.BorderSize = 0;
            this.btnTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangulo.Location = new System.Drawing.Point(1467, 158);
            this.btnTriangulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(67, 62);
            this.btnTriangulo.TabIndex = 1;
            this.btnTriangulo.UseVisualStyleBackColor = false;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // uljJoystick
            // 
            this.uljJoystick.BackColor = System.Drawing.Color.Black;
            this.uljJoystick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uljJoystick.BackgroundImage")));
            this.uljJoystick.JoyStickColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.uljJoystick.KeepOnScreen = true;
            this.uljJoystick.Location = new System.Drawing.Point(183, 357);
            this.uljJoystick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uljJoystick.MovableObject = null;
            this.uljJoystick.Name = "uljJoystick";
            this.uljJoystick.Sensitivity = 3;
            this.uljJoystick.Size = new System.Drawing.Size(123, 95);
            this.uljJoystick.TabIndex = 18;
            this.uljJoystick.Text = "uI_JoyStick1";
            this.uljJoystick.DirectionChanged += new System.EventHandler(this.uljJoystick_DirectionChanged);
            this.uljJoystick.Click += new System.EventHandler(this.uljJoystick_Click);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.AllowUserToAddRows = false;
            this.dgvPlaylist.AllowUserToDeleteRows = false;
            this.dgvPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.dgvPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlaylist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlaylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlaylist.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlaylist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.dgvPlaylist.Location = new System.Drawing.Point(532, 550);
            this.dgvPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.ReadOnly = true;
            this.dgvPlaylist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylist.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPlaylist.RowHeadersVisible = false;
            this.dgvPlaylist.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPlaylist.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPlaylist.RowTemplate.Height = 50;
            this.dgvPlaylist.Size = new System.Drawing.Size(672, 223);
            this.dgvPlaylist.TabIndex = 19;
            this.dgvPlaylist.Visible = false;
            this.dgvPlaylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylist_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Imagen";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Duracion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // tmrIndicador
            // 
            this.tmrIndicador.Enabled = true;
            this.tmrIndicador.Tick += new System.EventHandler(this.tmrIndicador_Tick);
            // 
            // tmrPresionado
            // 
            this.tmrPresionado.Tick += new System.EventHandler(this.tmrPresionado_Tick);
            // 
            // clLedEncendido
            // 
            this.clLedEncendido.BackColor = System.Drawing.Color.Transparent;
            this.clLedEncendido.Location = new System.Drawing.Point(1633, 360);
            this.clLedEncendido.Name = "clLedEncendido";
            this.clLedEncendido.Ruben_Color = null;
            this.clLedEncendido.Ruben_Parpadeo = false;
            this.clLedEncendido.Ruben_Tiempo_Parpadeo = 0;
            this.clLedEncendido.Size = new System.Drawing.Size(21, 23);
            this.clLedEncendido.TabIndex = 20;
            // 
            // clLedDuracion
            // 
            this.clLedDuracion.BackColor = System.Drawing.Color.Transparent;
            this.clLedDuracion.Location = new System.Drawing.Point(1595, 417);
            this.clLedDuracion.Name = "clLedDuracion";
            this.clLedDuracion.Ruben_Color = null;
            this.clLedDuracion.Ruben_Parpadeo = false;
            this.clLedDuracion.Ruben_Tiempo_Parpadeo = 0;
            this.clLedDuracion.Size = new System.Drawing.Size(22, 26);
            this.clLedDuracion.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.pFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pFondo.ResumeLayout(false);
            this.pReproductor.ResumeLayout(false);
            this.pInformacion.ResumeLayout(false);
            this.pInformacion.PerformLayout();
            this.pBarraHerramientas.ResumeLayout(false);
            this.pBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModoReproduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPantallaCompleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWMPReproductorVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pFondo;
        private System.Windows.Forms.Panel pReproductor;
        private AxWMPLib.AxWindowsMediaPlayer aWMPReproductorVideo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnMenosVelocidad;
        private System.Windows.Forms.Button btnRetrocesoRapido;
        private System.Windows.Forms.Button btnAvanceRapido;
        private System.Windows.Forms.Button btnMasVelocidad;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPantallaCompleta;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnMasVolumen;
        private System.Windows.Forms.Button btnMenosVolumen;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pBarraHerramientas;
        private System.Windows.Forms.Panel pInformacion;
        private System.Windows.Forms.PictureBox pcbAnterior;
        private System.Windows.Forms.PictureBox pbModoReproduccion;
        private System.Windows.Forms.PictureBox pcbPantallaCompleta;
        private System.Windows.Forms.PictureBox pcbVolumen;
        private System.Windows.Forms.PictureBox pcbSiguiente;
        private System.Windows.Forms.PictureBox pcbReproducir;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblIndicador;
        private UIDC.UI_TrackBarWindows dtbIndicador;
        private UIDC.UI_TrackBarText dtbVolumen;
        private System.Windows.Forms.Timer tmrIndicador;
        private UIDC.UI_JoyStick uljJoystick;
        private System.Windows.Forms.Label lblVelocidadReproduccion;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Timer tmrPresionado;
        private UIDC.UI_CircleProgress uicpVolumen;
        private UIDC.UI_CirclePictureBox pbPortada;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Control_LED_Configurable.Control_LED_Ruben clLedEncendido;
        private Control_LED_Configurable.Control_LED_Ruben clLedDuracion;
    }
}

