using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAreaCuadrado_Click(object sender, EventArgs e)
        {
            Areas ac = new Areas();
            decimal resultado = ac.Cuadrado(numDato1.Value);
            lblAreaCuadrado.Text = resultado + "";
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            Areas ar = new Areas();
            decimal resultado = ar.Rectangulo(numDato2.Value, numDato3.Value);
            lblAreaRectangulo.Text = resultado + "";
        }

        private void btnAreaTriangulo_Click(object sender, EventArgs e)
        {
            Areas at = new Areas();
            decimal resultado = at.Triangulo(numDato4.Value, numDato5.Value);
            lblAreaTriangulo.Text = resultado + "";
        }

        private void btnAreaRombo_Click(object sender, EventArgs e)
        {
            Areas arb = new Areas();
            decimal resultado = arb.Rombo(numDato6.Value, numDato7.Value);
            lblAreaRombo.Text = resultado + "";
        }

        private void btnAreaRomboide_Click(object sender, EventArgs e)
        {
            Areas arbide = new Areas();
            decimal resultado = arbide.Romboide(numDato8.Value, numDato9.Value);
            lblAreaRomboide.Text = resultado + "";
        }

        private void btnAreaTrapecio_Click(object sender, EventArgs e)
        {
            Areas atr = new Areas();
            decimal resultado = atr.Trapecio(numDato10.Value, numDato11.Value, numDato12.Value);
            lblAreaTrapecio.Text = resultado + "";
        }

        private void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            Areas ac = new Areas();
            decimal resultado = ac.Circulo(numDato13.Value, numDato14.Value);
            lblAreaCirculo.Text = resultado + "";
        }

        private void btnAreaPoligonoRegular_Click(object sender, EventArgs e)
        {
            Areas apr = new Areas();
            decimal resultado = apr.PoligonoRegular(numDato15.Value, numDato16.Value);
            lblAreaPoligonoRegular.Text = resultado + "";
        }
    }
}
