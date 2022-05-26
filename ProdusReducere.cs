using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class ProdusReducere : UserControl
    {
       
        public ProdusReducere(int id, string denumire, float pret)
        {
            InitializeComponent();
            this.lblDenumire.Text = denumire;
            this.lblPretVechi.Text = pret.ToString() + " MDL";
            float pretNou = CalculeazaReducerea(pret, 20);
            this.lblPretNou.Text = "Pret Nou: " + (Math.Round((pretNou), 2)).ToString() + " MDL";
            
            string name = "Image" + id.ToString();
            ImagePaths paths = new ImagePaths();
            Bitmap image = new Bitmap(paths.pathImage[name]);
            pictureBox1.Image = (Image)image;
            lblDenumire.Left = (ClientSize.Width - lblDenumire.Size.Width) / 2;
        }

        private void lblDenumire_SizeChanged(object sender, EventArgs e)
        {
            lblDenumire.Left = (ClientSize.Width - lblDenumire.Size.Width) / 2;
        }

        private float CalculeazaReducerea(float pret, int procente)
        {
            return pret - (pret * procente / 100);
        }
    }
}
