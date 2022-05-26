using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Alimentara
{
    public partial class FormProdusCautatDupaCod : MaterialSkin.Controls.MaterialForm
    {
        
        public FormProdusCautatDupaCod(List<Produs> produse)
        {
            InitializeComponent();
            listBox1.DataSource = produse;
            listBox1.DisplayMember = "GetProdus";
            Produs produs = produse.First<Produs>();
            FillForm(produs);   
        }

        private void FillForm(Produs produse)
        {
            lblCod.Text = produse.Cod;
            lblDenumire.Text = produse.Denumire;
            lblCantitate.Text = produse.Cantitate.ToString();
            lblTipCantitate.Text = produse.Tip_Cantitate;
            lblPret.Text = produse.Pret.ToString() + " MDL";
            lblDataValabilitate.Text = produse.Data_Valabilitate;

            OperatiiBD operatii = new OperatiiBD();
            List<Departament> departaments = new List<Departament>();
            List<Producator> producators = new List<Producator>();

            departaments = operatii.CautaDepartamentDupaID(produse.ID_Departament);
            producators = operatii.CautaProducatorDupaID(produse.ID_Producator);

            Departament dept = departaments.First<Departament>();
            Producator prod = producators.First<Producator>();

            lblDepartament.Text = dept.Nume;
            lblProducator.Text = prod.Denumirea;

            string name = "Image" + produse.ID_Produs.ToString();
            ImagePaths paths = new ImagePaths();
            Bitmap image;

            if (produse.ID_Produs <= 70)
            {
                image = new Bitmap(paths.pathImage[name]);

            }
            else
            {
                image = new Bitmap(paths.pathImage["Image0"]);
            }
            pictureBox1.Image = (Image)image;
        }
        
    }
}
