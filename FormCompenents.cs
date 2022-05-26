namespace Alimentara
{
    public partial class FormCompenents : MaterialSkin.Controls.MaterialForm
    {
        public FormCompenents(string loggedFname, string accessibility)
        {
            InitializeComponent();
            label1.Text = loggedFname;
            FormAfiseazaRaport raport = new FormAfiseazaRaport();
            FormProduse formProduse = new FormProduse();
            FormCautaProduseDupaDepartament cautaProduseDupaDepartament = new FormCautaProduseDupaDepartament();
            FormMagazine formMagazine = new FormMagazine();
            FormOperatiiDeAfisareProduse operatiiDeAfisareProduse = new FormOperatiiDeAfisareProduse();
            FormProduseLaReducere produseLaReducere = new FormProduseLaReducere();

            CardView cardView1;
            CardView cardView2;
            CardView cardView3;
            CardView cardView4;
            CardView cardView5;
            CardView cardView6;

            if (accessibility.ToUpper().Equals("USER"))
            {
                cardView1 = new CardView("Magazine", formMagazine, false);
                cardView2 = new CardView("Produse", formProduse, false);
                cardView3 = new CardView("Produse în toate \n magazinele", cautaProduseDupaDepartament, true);
                cardView4 = new CardView("Raport", raport, true);
                cardView5 = new CardView("Operații de \n afișare", operatiiDeAfisareProduse, true);
                cardView6 = new CardView("Produse la \n Reducere!", produseLaReducere, true);
            }
            else
            {
                cardView1 = new CardView("Magazine", formMagazine, true);
                cardView2 = new CardView("Produse", formProduse, true);
                cardView3 = new CardView("Produse în toate \n magazinele", cautaProduseDupaDepartament, true);
                cardView4 = new CardView("Raport", raport, true);
                cardView5 = new CardView("Operații de \n afișare", operatiiDeAfisareProduse, true);
                cardView6 = new CardView("Produse la \n Reducere!", produseLaReducere, true);
            }

            flowLayoutPanel1.Controls.Add(cardView1);
            flowLayoutPanel1.Controls.Add(cardView2);
            flowLayoutPanel1.Controls.Add(cardView3);
            flowLayoutPanel1.Controls.Add(cardView4);
            flowLayoutPanel1.Controls.Add(cardView5);
            flowLayoutPanel1.Controls.Add(cardView6);

        }
    }
}
