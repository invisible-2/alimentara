using System;
using System.Collections.Generic;
using System.Linq;

namespace Alimentara
{
    public partial class FormCeleMaiVanduteProduse : MaterialSkin.Controls.MaterialForm
    {
        private OperatiiBD operatiiBD = new OperatiiBD();
        public FormCeleMaiVanduteProduse()
        {
            InitializeComponent();
            AfiseazaProduse();
        }

        private void AfiseazaProduse()
        {
            List<ProductItem> produsReducere = new List<ProductItem>();
            Random random = new Random();
            List<int> nums = new List<int>();
            nums = GetRandomNums();
            int buc = 140;

            for (int i = 0; i < 10; i++)
            {
                int id = nums[i];
                List<Produs> produse = operatiiBD.CautaProdusDupaID(id);

                if (produse.Count > 0)
                {
                    Produs produs = produse.First<Produs>();
                    int x = random.Next(buc, buc + 21);
                    string descriere = "S-au vândut până acum: " + x + " bucăți.";

                    List<Producator> producators = new List<Producator>();
                    producators = operatiiBD.CautaProducatorDupaID(produs.ID_Producator);
                    Producator producator = producators.First<Producator>();

                    produsReducere.Add(new ProductItem(produs.Denumire, descriere , producator.Denumirea, produs.Pret.ToString(), produs.ID_Produs));
                }
                Number number = new Number(i + 1);
                flowLayoutPanel1.Controls.Add(number);
                flowLayoutPanel1.Controls.Add(produsReducere[i]);
                buc -= 10;
            }
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
