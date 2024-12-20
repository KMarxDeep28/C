using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReproductorVideoMusica2
{
    public partial class Form1 : Form
    {
        Boolean reproduccion = false;
        int modo = 0, pantallaCompleta = 0;
        int valorX = 0, valorY = 0, anchura = 0, altura = 0;
        int mousePresionado = 0;

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            pInformacion.Visible = !pInformacion.Visible;
            if (pInformacion.Visible)
            {
                aWMPReproductorVideo.Top += pInformacion.Height;
                aWMPReproductorVideo.Height -= pInformacion.Height;
            }
            else
            {
                aWMPReproductorVideo.Top -= pInformacion.Height;
                aWMPReproductorVideo.Height += pInformacion.Height;
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            pBarraHerramientas.Visible = !pBarraHerramientas.Visible;
            if (pBarraHerramientas.Visible)
            {
                aWMPReproductorVideo.Height -= pBarraHerramientas.Height;
            }
            else
            {
                aWMPReproductorVideo.Height += pBarraHerramientas.Height;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            aWMPReproductorVideo.Ctlcontrols.next();
            reproduccion = false;
            btnX_Click(sender, e);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            aWMPReproductorVideo.Ctlcontrols.previous();
            reproduccion = false;
            btnX_Click(sender, e);
        }

        private void btnMasVelocidad_Click(object sender, EventArgs e)
        {
            if (aWMPReproductorVideo.settings.rate > 2)
            {
                aWMPReproductorVideo.settings.rate = 2;
            }
            else
            {
                aWMPReproductorVideo.settings.rate += 0.25;
            }
        }

        private void btnRetrocesoRapido_Click(object sender, EventArgs e)
        {
            aWMPReproductorVideo.Ctlcontrols.fastReverse();
            reproduccion = false;
        }

        private void btnAvanceRapido_Click(object sender, EventArgs e)
        {
            aWMPReproductorVideo.Ctlcontrols.fastForward();
            reproduccion = false;
        }

        private void btnMenosVelocidad_Click(object sender, EventArgs e)
        {
            if (aWMPReproductorVideo.settings.rate <= 0.25)
            {
                aWMPReproductorVideo.settings.rate = 0.25;
            }
            else
            {
                aWMPReproductorVideo.settings.rate -= 0.25;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnX_Click(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog cuadroDialogoArchivo = new OpenFileDialog();
            cuadroDialogoArchivo.Multiselect = true;
            cuadroDialogoArchivo.Filter = "Archivos multimedia|*.mp3;*.mp4;*.avi;*.wav;*.wmv*";
            if (cuadroDialogoArchivo.ShowDialog() == DialogResult.OK)
            {
                foreach (string archivo in cuadroDialogoArchivo.FileNames)
                {
                    aWMPReproductorVideo.currentPlaylist.appendItem(aWMPReproductorVideo.newMedia(archivo));
                    dgvPlaylist.Rows.Add(
                    ActualizarPortada(archivo, Properties.Resources.silueta_retrato_clasico_hombre),
                    aWMPReproductorVideo.newMedia(archivo).name,
                    aWMPReproductorVideo.newMedia(archivo).durationString);
                }

                reproduccion = false;
                btnX_Click(sender, e);
            }
        }

        private void btnMasVolumen_Click(object sender, EventArgs e)
        {
            aWMPReproductorVideo.settings.volume += 1;
            if (!tmrPresionado.Enabled)
            {
                uicpVolumen.Visible = true;
                mousePresionado = 3;
                tmrPresionado.Interval = 3000;
                tmrPresionado.Start();
            }
        }

        private void btnMenosVolumen_Click(object sender, EventArgs e)
        {
            aWMPReproductorVideo.settings.volume -= 1;
            if (!tmrPresionado.Enabled)
            {
                uicpVolumen.Visible = true;
                mousePresionado = 3;
                tmrPresionado.Interval = 3000;
                tmrPresionado.Start();
            }
        }

        private void pcbAnterior_Click(object sender, EventArgs e)
        {
            btnAnterior_Click(sender, e);
        }

        private void pcbReproducir_Click(object sender, EventArgs e)
        {
            btnX_Click(sender, e);
        }

        private void pcbSiguiente_Click(object sender, EventArgs e)
        {
            btnSiguiente_Click(sender, e);
        }

        private void pcbPantallaCompleta_Click(object sender, EventArgs e)
        {
            pantallaCompleta = (pantallaCompleta + 1) % 2;
            switch (pantallaCompleta)
            {
                case 0:
                    {
                        this.WindowState = FormWindowState.Maximized;
                        pReproductor.Left = 0;
                        pReproductor.Top = 0;
                        pReproductor.Width = this.Width;
                        pReproductor.Height = this.Height;
                        pcbPantallaCompleta.Image = Properties.Resources.minimizar;
                    }
                    break;
                case 1:
                    {
                        this.WindowState = FormWindowState.Normal;
                        pReproductor.Left = valorX;
                        pReproductor.Top = valorY;
                        pReproductor.Width = anchura;
                        pReproductor.Height = altura;
                        pcbPantallaCompleta.Image = Properties.Resources.maximizar;
                    }
                    break;
            }
        }

        private void pcbVolumen_Click(object sender, EventArgs e)
        {
            if (dtbVolumen.Value != 0)
            {
                pcbVolumen.Image = Properties.Resources.silenciar_volumen;
                dtbVolumen.Value = 0;
            }
            else
            {
                pcbVolumen.Image = Properties.Resources.alto_volumen;
                dtbVolumen.Value = 50;
            }
            aWMPReproductorVideo.settings.volume = dtbVolumen.Value;
        }

        private void dtbVolumen_ValueChanged()
        {
            aWMPReproductorVideo.settings.volume = dtbVolumen.Value;
            if (dtbVolumen.Value != 0)
            {
                pcbVolumen.Image = Properties.Resources.alto_volumen;
            }
            else
            {
                pcbVolumen.Image = Properties.Resources.silenciar_volumen;
            }
        }

        private void dtbVolumen_MouseLeave(object sender, EventArgs e)
        {
            dtbVolumen.Visible = false;
        }

        private void pcbVolumen_MouseMove(object sender, MouseEventArgs e)
        {
            dtbVolumen.Visible = true;
        }

        private void tmrIndicador_Tick(object sender, EventArgs e)
        {
            dtbIndicador.Value = (int)aWMPReproductorVideo.Ctlcontrols.currentPosition;
            dtbVolumen.Value = aWMPReproductorVideo.settings.volume;
            uicpVolumen.Value = aWMPReproductorVideo.settings.volume;
            lblIndicador.Text = aWMPReproductorVideo.Ctlcontrols.currentPositionString;
            lblVelocidadReproduccion.Text = "Velocidad de reproducción: " + aWMPReproductorVideo.settings.rate.ToString();
            obtenerInformacionMultimedia();
            string posicion = uljJoystick.JoystickDirection.ToString();
            switch (posicion)
            {
                case "MiddleRight":
                    btnAvanceRapido_Click(sender, e);
                    break;
                case "MiddleLeft":
                    btnRetrocesoRapido_Click(sender, e);
                    break;
                case "UpperCenter":
                    btnMasVelocidad_Click(sender, e);
                    break;
                case "LowerCenter":
                    btnMenosVelocidad_Click(sender, e);
                    break;
            }
            //clLedDuracion.Ruben_Color = dtbIndicador.Value != 0 ? "Yellow" : "Gray" ;
        }

        private void obtenerInformacionMultimedia()
        {
            if (aWMPReproductorVideo.currentPlaylist.count > 0)
            {
                lblDuracion.Text = aWMPReproductorVideo.currentMedia.durationString;
                lblTitulo.Text = "Titulo: " + aWMPReproductorVideo.currentMedia.getItemInfo("Title");
                lblArtista.Text = "Artista: " + aWMPReproductorVideo.currentMedia.getItemInfo("Author");
                lblAlbum.Text = "Album: " + aWMPReproductorVideo.currentMedia.getItemInfo("Album");
                lblAnio.Text = "Año: " + aWMPReproductorVideo.currentMedia.getItemInfo("Year");
                lblGenero.Text = "Género: " + aWMPReproductorVideo.currentMedia.getItemInfo("Genre");
                string mediaType = aWMPReproductorVideo.currentMedia.getItemInfo("MediaType");
                if (mediaType == "audio")
                {
                    aWMPReproductorVideo.Visible = false;
                    pbPortada.Visible = true;
                    pbPortada.Image = ActualizarPortada(aWMPReproductorVideo.currentMedia.sourceURL, Properties.Resources.pngwing_com);
                }
                else
                {
                    aWMPReproductorVideo.Visible = true;
                    pbPortada.Visible = false;
                }
            }
        }

        private Image ActualizarPortada(string direccionArchivo, Image imagenNoEncontrada)
        {
            try
            {
                var archivo = TagLib.File.Create(direccionArchivo);
                TagLib.IPicture portada = archivo.Tag.Pictures.Length > 0 ? archivo.Tag.Pictures[0] : null;

                if (portada != null)
                {
                    using (MemoryStream stream = new MemoryStream(portada.Data.Data))
                    {
                        return Image.FromStream(stream);

                    }
                }
                else
                {
                    return imagenNoEncontrada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen de portada: " + ex.Message);
                return null;
            }
        }

        private void dtbIndicador_ValueChanged()
        {
            dtbIndicador.Maximum = (int)aWMPReproductorVideo.currentMedia.duration;
            if (dtbIndicador.Value != (int)aWMPReproductorVideo.Ctlcontrols.currentPosition)
            {
                aWMPReproductorVideo.Ctlcontrols.currentPosition = dtbIndicador.Value;
            }
        }

        private void pbModoReproduccion_Click(object sender, EventArgs e)
        {
            modo = (modo + 1) % 3;
            switch (modo)
            {
                case 0:
                    {
                        aWMPReproductorVideo.settings.setMode("loop", false);
                        aWMPReproductorVideo.settings.setMode("shuffle", false);
                        pbModoReproduccion.Image = Properties.Resources.repetir;
                        pbModoReproduccion.BackColor = Color.Transparent;
                    }
                    break;
                case 1:
                    {
                        aWMPReproductorVideo.settings.setMode("loop", true);
                        aWMPReproductorVideo.settings.setMode("shuffle", false);
                        pbModoReproduccion.Image = Properties.Resources.repetir;
                        pbModoReproduccion.BackColor = Color.FromArgb(30, 60, 80);
                    }
                    break;
                case 2:
                    {
                        aWMPReproductorVideo.settings.setMode("loop", false);
                        aWMPReproductorVideo.settings.setMode("shuffle", true);
                        pbModoReproduccion.Image = Properties.Resources.barajar;
                        pbModoReproduccion.BackColor = Color.Transparent;
                    }
                    break;
            }
        }

        private void uljJoystick_Click(object sender, EventArgs e)
        {
        }

        private void uljJoystick_DirectionChanged(object sender, EventArgs e)
        {
        }

        private void btnPantallaCompleta_Click(object sender, EventArgs e)
        {
            pcbPantallaCompleta_Click(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            clLedEncendido.Ruben_Color = "Gray";
            Close();
        }

        private void dgvPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            if (indiceFila != -1)
            {
                aWMPReproductorVideo.Ctlcontrols.playItem(aWMPReproductorVideo.currentPlaylist.Item[indiceFila]);
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            dgvPlaylist.Visible = !dgvPlaylist.Visible;
        }

        private void textBox1_Move(object sender, EventArgs e)
        {
        }

        private void btnMasVolumen_MouseUp(object sender, MouseEventArgs e)
        {
            tmrPresionado.Stop();
            uicpVolumen.Visible = false;
        }

        private void tmrPresionado_Tick(object sender, EventArgs e)
        {
            uicpVolumen.Visible = true;
            switch (mousePresionado)
            {
                case 0:
                    {
                        btnMasVolumen_Click(sender, e);
                    }
                    break;
                case 1:
                    {
                        btnMenosVolumen_Click(sender, e);
                    }
                    break;
                default:
                    {
                        uicpVolumen.Visible = false;
                        tmrPresionado.Interval = 100;
                        tmrPresionado.Stop();

                    }
                    break;
            }
        }

        private void btnMasVolumen_MouseDown(object sender, MouseEventArgs e)
        {
            mousePresionado = 0;
            tmrPresionado.Start();

        }

        private void btnMenosVolumen_MouseUp(object sender, MouseEventArgs e)
        {
            tmrPresionado.Stop();
            uicpVolumen.Visible = false;
        }

        private void btnMenosVolumen_MouseDown(object sender, MouseEventArgs e)
        {
            mousePresionado = 1;
            tmrPresionado.Start();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    btnMasVelocidad_Click(sender, e);
                    break;
                case Keys.Down:
                    btnMenosVelocidad_Click(sender, e);
                    break;
                case Keys.Right:
                    btnAvanceRapido_Click(sender, e);
                    break;
                case Keys.Left:
                    btnRetrocesoRapido_Click(sender, e);
                    break;
                case Keys.Z:
                    btnX_Click(sender, e);
                    break;
                case Keys.X:
                    btnCirculo_Click(sender, e);
                    break;
                case Keys.A:
                    btnCuadrado_Click(sender, e);
                    break;
                case Keys.S:
                    btnTriangulo_Click(sender, e);
                    break;
                case Keys.E:
                    btnSiguiente_Click(sender, e);
                    break;
                case Keys.Q:
                    btnAnterior_Click(sender, e);
                    break;
                case Keys.Enter:
                    btnStart_Click(sender, e);
                    break;
                case Keys.Tab:
                    btnSelect_Click(sender, e);
                    break;
                case Keys.M:
                    btnMasVolumen_Click(sender, e);
                    break;
                case Keys.L:
                    btnMenosVolumen_Click(sender, e);
                    break;
                case Keys.F:
                    pcbPantallaCompleta_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnHome_Click(sender, e);
                    break;
                case Keys.P:
                    btnPlaylist_Click(sender, e);
                    break;
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            aWMPReproductorVideo.Ctlcontrols.stop();
            reproduccion = true;
            btnX_Click(sender, e);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (!reproduccion)
            {
                pcbReproducir.Image = Properties.Resources.pausa;
                aWMPReproductorVideo.Ctlcontrols.play();
            }
            else
            {
                pcbReproducir.Image = Properties.Resources.jugar;
                aWMPReproductorVideo.Ctlcontrols.pause();
            }
            reproduccion = !reproduccion;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aWMPReproductorVideo.settings.autoStart = reproduccion;
            aWMPReproductorVideo.uiMode = "none";
            valorX = pReproductor.Location.X;
            valorY = pReproductor.Location.Y;
            anchura = pReproductor.Width;
            altura = pReproductor.Height;
            this.KeyPreview = true;
            clLedEncendido.Ruben_Color = "Green";
        }
    }
}
