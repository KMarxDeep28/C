using Paint.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graficos;
        Point puntoInicial = new Point(10, 10);
        Point puntoFinal = new Point(100, 100);
        Pen lapiz = new Pen(Color.Black, 1);
        PictureBox[] botonColores = new PictureBox[30];
        PictureBox[] botonFiguras = new PictureBox[8];
        PictureBox[] botonHerramientas = new PictureBox[3];
        int estado = 0, auxiliarColor = 20, figuraSeleccionada = 0;
        Bitmap lienzo;
        Boolean esGoma = false;
        public Form1()
        {
            InitializeComponent();
            lienzo = new Bitmap(pbPlanoDibujo.Width, pbPlanoDibujo.Height);
            graficos = Graphics.FromImage(lienzo);
            pbPlanoDibujo.Image = lienzo;
            graficos.Clear(pbPlanoDibujo.BackColor);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //graficos = pbPlanoDibujo.CreateGraphics();
            lblAncho.Text = "Ancho: " + pbPlanoDibujo.Width;
            lblAlto.Text = "Alto: " + pbPlanoDibujo.Height;
            pbColor1.BackColor = color1.BackColor;
            for (int i = 0; i < botonColores.Length; i++)
            {
                botonColores[i] = new PictureBox();
                botonColores[i] = Controls.Find("color" + (i + 1), true).FirstOrDefault() as PictureBox;
            }
            for (int i = 0; i < botonFiguras.Length; i++)
            {
                botonFiguras[i] = new PictureBox();
                botonFiguras[i] = Controls.Find("pbFigura" + (i + 1), true).FirstOrDefault() as PictureBox;
            }
            for (int i = 0; i < botonHerramientas.Length; i++)
            {
                botonHerramientas[i] = new PictureBox();
                botonHerramientas[i] = Controls.Find("pbHerramienta" + (i + 1), true).FirstOrDefault() as PictureBox;
            }
        }

        private void pbPlanoDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            lblX.Text = "X: " + x;
            lblY.Text = "Y: " + y;
            if ((e.Button == MouseButtons.Left || e.Button == MouseButtons.Right) && figuraSeleccionada == 0)
            {
                puntoFinal = e.Location;
                graficos.DrawLine(lapiz, puntoInicial, puntoFinal);
                puntoInicial = puntoFinal;
                pbPlanoDibujo.Invalidate();
            }
        }

        private void pbPlanoDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            pbPlanoDibujo.Cursor = Cursors.Cross;
            lblX1.Text = "X1: " + e.X;
            lblY1.Text = "Y1:" + e.Y;
            puntoInicial = e.Location;
            if (!esGoma)
            {
                lapiz.Color = e.Button != MouseButtons.Right ? pbColor1.BackColor : pbColor2.BackColor;
            }
            else
            {
                lapiz.Color = pbPlanoDibujo.BackColor;
            }
        }

        private void pbPaletaColores_Click(object sender, EventArgs e)
        {
            ColorDialog cuadroColor = new ColorDialog();
            cuadroColor.ShowDialog();
            pbPaletaColores.BackColor = cuadroColor.Color;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = cuadroColor.Color;

            if (auxiliarColor < botonColores.Length)
            {
                botonColores[auxiliarColor].BackColor = cuadroColor.Color;
                auxiliarColor++;
            }
            else
            {
                auxiliarColor = 20;
                botonColores[auxiliarColor].BackColor = cuadroColor.Color;
            }
        }

        private void color1_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color1.BackColor;
            color1.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color1.BackColor;
        }

        private void color2_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color2.BackColor;
            color2.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color2.BackColor;
        }

        private void color3_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color3.BackColor;
            color3.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color3.BackColor;
        }

        private void pbColor1_Click(object sender, EventArgs e)
        {
            pbColor1.BorderStyle = BorderStyle.Fixed3D;
            pbColor2.BorderStyle = BorderStyle.None;
            estado = 0;
        }

        private void pbColor2_Click(object sender, EventArgs e)
        {
            pbColor1.BorderStyle = BorderStyle.None;
            pbColor2.BorderStyle = BorderStyle.Fixed3D;
            estado = 1;
        }

        private void color4_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color4.BackColor;
            color4.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color4.BackColor;
        }

        private void color5_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color5.BackColor;
            color5.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color5.BackColor;
        }

        private void color6_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color6.BackColor;
            color6.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color6.BackColor;
        }

        private void color7_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color7.BackColor;
            color7.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color7.BackColor;
        }

        private void color8_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color8.BackColor;
            color8.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color8.BackColor;
        }

        private void color9_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color9.BackColor;
            color9.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color9.BackColor;
        }

        private void color10_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color10.BackColor;
            color10.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color10.BackColor;
        }

        private void color11_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color11.BackColor;
            color11.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color11.BackColor;
        }

        private void color12_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color12.BackColor;
            color12.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color12.BackColor;
        }

        private void color13_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color13.BackColor;
            color13.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color13.BackColor;
        }

        private void color14_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color14.BackColor;
            color14.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color14.BackColor;
        }

        private void color15_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color15.BackColor;
            color15.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color15.BackColor;
        }

        private void color16_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color16.BackColor;
            color16.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color16.BackColor;
        }

        private void color17_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color17.BackColor;
            color17.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color17.BackColor;
        }

        private void color18_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color18.BackColor;
            color18.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color18.BackColor;
        }

        private void color19_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color19.BackColor;
            color19.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color19.BackColor;
        }

        private void color20_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color20.BackColor;
            color20.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color20.BackColor;
        }

        private void color21_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color21.BackColor;
            color21.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color21.BackColor;
        }

        private void color22_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color22.BackColor;
            color22.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color22.BackColor;
        }

        private void color23_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color23.BackColor;
            color23.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color23.BackColor;
        }

        private void color24_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color24.BackColor;
            color24.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color24.BackColor;
        }

        private void color25_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color25.BackColor;
            color25.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color25.BackColor;
        }

        private void color26_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color26.BackColor;
            color26.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color26.BackColor;
        }

        private void color27_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color27.BackColor;
            color27.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color27.BackColor;
        }

        private void color28_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color28.BackColor;
            color28.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color28.BackColor;
        }

        private void color29_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color29.BackColor;
            color29.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color29.BackColor;
        }

        private void color30_Click(object sender, EventArgs e)
        {
            DeseleccionColor();
            lapiz.Color = color30.BackColor;
            color30.BorderStyle = BorderStyle.Fixed3D;
            (estado != 1 ? pbColor1 : pbColor2).BackColor = color30.BackColor;
        }

        private void DeseleccionColor()
        {
            for (int i = 0; i < botonColores.Length; i++)
            {
                botonColores[i].BorderStyle = BorderStyle.None;
            }
        }

        private void tbGrosor_Scroll(object sender, EventArgs e)
        {
            lapiz.Width = tbGrosor.Value;
            gbGrosor.Text = "Grosor: " + tbGrosor.Value;
        }

        private void DibujarFiguras()
        {
            switch (figuraSeleccionada)
            {
                case 1:
                    graficos.DrawLine(lapiz, puntoInicial, puntoFinal);
                    break;
                case 2:
                    graficos.DrawBezier(lapiz, puntoInicial, new Point((puntoInicial.X + puntoFinal.X) / 2, puntoInicial.Y - 50),
                        new Point((puntoInicial.X + puntoFinal.X) / 2, puntoFinal.Y + 50), puntoFinal);
                    break;
                case 3:
                    graficos.DrawEllipse(lapiz, new Rectangle(
                        Math.Min(puntoInicial.X, puntoFinal.X),
                        Math.Min(puntoInicial.Y, puntoFinal.Y),
                        Math.Abs(puntoInicial.X - puntoFinal.X),
                        Math.Abs(puntoInicial.Y - puntoFinal.Y)
                    ));
                    break;
                case 4:
                    graficos.DrawRectangle(lapiz, new Rectangle(
                        Math.Min(puntoInicial.X, puntoFinal.X),
                        Math.Min(puntoInicial.Y, puntoFinal.Y),
                        Math.Abs(puntoInicial.X - puntoFinal.X),
                        Math.Abs(puntoInicial.Y - puntoFinal.Y)
                    ));
                    break;
                case 5:
                    int radio = 20;
                    GraphicsPath path = new GraphicsPath();
                    path.AddArc(puntoInicial.X, puntoInicial.Y, radio, radio, 180, 90);
                    path.AddArc(puntoFinal.X - radio, puntoInicial.Y, radio, radio, 270, 90);
                    path.AddArc(puntoFinal.X - radio, puntoFinal.Y - radio, radio, radio, 0, 90);
                    path.AddArc(puntoInicial.X, puntoFinal.Y - radio, radio, radio, 90, 90);
                    path.CloseFigure();
                    graficos.DrawPath(lapiz, path);
                    break;
                case 6:
                    Point puntoMedio = new Point((puntoInicial.X + puntoFinal.X) / 2, puntoInicial.Y);
                    Point[] puntosTriangulo = new Point[]
                    {
                puntoMedio,
                new Point(puntoInicial.X, puntoFinal.Y),
                new Point(puntoFinal.X, puntoFinal.Y)
                    };
                    graficos.DrawPolygon(lapiz, puntosTriangulo);
                    break;
                case 7:
                    Point[] puntosRombo = new Point[]
                    {
                new Point((puntoInicial.X + puntoFinal.X) / 2, puntoInicial.Y),
                new Point(puntoFinal.X, (puntoInicial.Y + puntoFinal.Y) / 2),
                new Point((puntoInicial.X + puntoFinal.X) / 2, puntoFinal.Y),
                new Point(puntoInicial.X, (puntoInicial.Y + puntoFinal.Y) / 2)
                    };
                    graficos.DrawPolygon(lapiz, puntosRombo);
                    break;
                case 8:
                    Point[] puntosPentagono = new Point[]
                    {
                new Point((puntoInicial.X + puntoFinal.X) / 2, puntoInicial.Y),
                new Point(puntoFinal.X, puntoInicial.Y + (puntoFinal.Y - puntoInicial.Y) / 3),
                new Point(puntoFinal.X - (puntoFinal.X - puntoInicial.X) / 4, puntoFinal.Y),
                new Point(puntoInicial.X + (puntoFinal.X - puntoInicial.X) / 4, puntoFinal.Y),
                new Point(puntoInicial.X, puntoInicial.Y + (puntoFinal.Y - puntoInicial.Y) / 3)
                    };
                    graficos.DrawPolygon(lapiz, puntosPentagono);
                    break;
            }
        }

        private void pbPlanoDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            puntoFinal = e.Location;
            if (figuraSeleccionada != 0)
            {
                DibujarFiguras();
                pbPlanoDibujo.Invalidate();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graficos.Clear(pbPlanoDibujo.BackColor);
            pbPlanoDibujo.Invalidate();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog archivoGuardado = new SaveFileDialog();
            archivoGuardado.Filter = "Archivo de dibujo (*.drw)|*.drw";
            archivoGuardado.Title = "Guardar dibujo";

            if (archivoGuardado.ShowDialog() == DialogResult.OK)
            {
                lienzo.Save(archivoGuardado.FileName, ImageFormat.Jpeg);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeseleccionFigura()
        {
            for (int i = 0; i < botonFiguras.Length; i++)
            {
                botonFiguras[i].BorderStyle = BorderStyle.None;
            }
        }

        private void pbLinea_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura1.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 1;
            esGoma = false;
        }

        private void pbFigura2_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura2.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 2;
            esGoma = false;
        }

        private void pbFigura3_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura3.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 3;
            esGoma = false;
        }

        private void pbFigura4_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura4.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 4;
            esGoma = false;
        }

        private void pbFigura5_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura5.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 5;
            esGoma = false;
        }

        private void pbFigura6_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura6.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 6;
            esGoma = false;
        }

        private void pbFigura7_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura7.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 7;
            esGoma = false;
        }

        private void pbFigura8_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbFigura8.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 8;
            esGoma = false;
        }

        private void DeseleccionHerramientas()
        {
            for (int i = 0; i < botonHerramientas.Length; i++)
            {
                botonHerramientas[i].BorderStyle = BorderStyle.None;
            }
        }

        private void pbHerramienta1_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbHerramienta1.BorderStyle = BorderStyle.Fixed3D;
            esGoma = false;
            figuraSeleccionada = 0;
        }

        private void pbHerramienta2_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbHerramienta2.BorderStyle = BorderStyle.Fixed3D;
            esGoma = true;
            figuraSeleccionada = 0;
        }

        private void pbHerramienta3_Click(object sender, EventArgs e)
        {
            DeseleccionFigura();
            DeseleccionHerramientas();
            pbHerramienta3.BorderStyle = BorderStyle.Fixed3D;
            figuraSeleccionada = 0;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog archivoGuardado = new SaveFileDialog();
            archivoGuardado.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            archivoGuardado.Title = "Guardar imagen";

            if (archivoGuardado.ShowDialog() == DialogResult.OK)
            {
                lienzo.Save(archivoGuardado.FileName, ImageFormat.Jpeg);
            }
        }

        private void colorDeFondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cuadroColor = new ColorDialog();
            cuadroColor.ShowDialog();
            graficos.Clear(cuadroColor.Color);
            pbPlanoDibujo.BackColor = cuadroColor.Color;
            pbPlanoDibujo.Invalidate();
        }

        private void pbPlanoDibujo_Resize(object sender, EventArgs e)
        {
            lblAncho.Text = "Ancho: " + pbPlanoDibujo.Width;
            lblAlto.Text = "Alto: " + pbPlanoDibujo.Height;
        }
    }
}
