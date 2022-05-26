using System;
using System.Collections.Generic;
using System.Linq;

namespace Alimentara
{
    public partial class FormProduseLaReducere : MaterialSkin.Controls.MaterialForm
    {
        private OperatiiBD operatiiBD = new OperatiiBD();
        public FormProduseLaReducere()
        {
            InitializeComponent();
            AfiseazaProdusele();
        }

        private void AfiseazaProdusele()
        {
            List<ProdusReducere> produsReducere = new List<ProdusReducere>();
            Random random = new Random();
            List<int> nums = new List<int>();
            nums = GetRandomNums();

            for (int i = 0; i < 10; i++)
            {
                int id = nums[i];
                List<Produs> produse = operatiiBD.CautaProdusDupaID(id);

                if (produse.Count > 0)
                {
                    Produs produs = produse.First<Produs>();
                    produsReducere.Add(new ProdusReducere(produs.ID_Produs, produs.Denumire, produs.Pret));  
                }
                flowLayoutPanel1.Controls.Add(produsReducere[i]);
            }

        }

        private void btnCeleMaiVanduteProduse_Click(object sender, EventArgs e)
        {
            FormCeleMaiVanduteProduse form = new FormCeleMaiVanduteProduse();
            form.Show();
        }

        private List<int> GetRandomNums()
        {
            List<int> listNumbers = new List<int>();
            Random random = new Random();
            int number;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = random.Next(1, 71);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }

            return listNumbers;
        }
    }
}
