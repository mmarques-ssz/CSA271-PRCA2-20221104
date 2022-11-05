using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classficarTriangulo(object sender, EventArgs e)
        {
            Triangulo triangulo;
            triangulo = new Triangulo(
                int.Parse(txtLado1.Text),
                int.Parse(txtLado2.Text),
                int.Parse(txtLado3.Text));
            triangulo.classificar();


            if (triangulo.getTipo() == 0)
            {
                lblClassificacao.Text = "NFT";
                picTriangulo.Image = projTriangulo.Properties.Resources.nft;
            }
            else
                if (triangulo.getTipo() == 1)
            {
                lblClassificacao.Text = "Equilátero";
                picTriangulo.Image = projTriangulo.Properties.Resources.equilatero;
            }
            else
                if (triangulo.getTipo() == 2)
            {
                lblClassificacao.Text = "Isósceles";
                picTriangulo.Image = projTriangulo.Properties.Resources.isosceles;
            }
            else
            {
                lblClassificacao.Text = "Escaleno";
                picTriangulo.Image = projTriangulo.Properties.Resources.escaleno;
            }

            
        }
    }
}
