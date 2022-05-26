using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class ProductItem : UserControl
    {
       public string Denumirea { get; set; }

        public ProductItem(string denumire, string descriere, string producator, string pret, int id)
        {
            InitializeComponent();
            lblDenumire.Text = denumire;
            lblDescriere.Text = descriere;
            lblPret.Text = pret;
            lblProducator.Text = producator;

            Denumirea = denumire;
            string name = "Image" + id.ToString();
            ImagePaths paths = new ImagePaths();
            Bitmap image;

            if (id <= 70)
            {
                image = new Bitmap(paths.pathImage[name]);
            }
            else
            {
                image = new Bitmap(paths.pathImage["Image0"]);
            }
            pictureBox1.Image = (Image)image;
        }

        private void ProductItem_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(Denumirea);
        }
    }
}
