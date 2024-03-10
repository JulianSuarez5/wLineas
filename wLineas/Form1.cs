using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wLineas
{
    public partial class Form1 : Form
    {
        public const int ancho = 20;
        public const int largo = 20;
        Graphics grafico;
        public Form1()
        {
            InitializeComponent();
            grafico = pictureBox1.CreateGraphics();
        }

        #region
        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(txtX1.Text);
                double y1 = double.Parse(txtY1.Text);
                double x2 = double.Parse(txtX2.Text);
                double y2 = double.Parse(txtY2.Text);

                grafico.Clear(Color.White);
                clsRectangulo rec = new clsRectangulo();
                rec.DrawLine(grafico, x1, y1, x2, y2, Color.Black);
                txtCantidad.Text = Convert.ToString(clsRectangulo.obtenCuenta());

            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores de tipo numerico");
            }
        }
        #endregion
    }
}
