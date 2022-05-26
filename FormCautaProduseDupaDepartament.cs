using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Alimentara
{
    public partial class FormCautaProduseDupaDepartament : MaterialSkin.Controls.MaterialForm
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        private Conectare conectare = new Conectare();
        private OperatiiBD operatiiBD = new OperatiiBD();
        private int deptID;
        public FormCautaProduseDupaDepartament()
        {
            InitializeComponent();
            AfiseazaDepartamentele();
        }

        private void AfiseazaDepartamentele()
        {
              dataAdapter = new SqlDataAdapter("select * from Departament", conectare.Open());
              dt = new DataTable();
              dataAdapter.Fill(dt);
              cmbDepartament.DataSource = dt;
              cmbDepartament.DisplayMember = "Nume";
              cmbDepartament.ValueMember = "ID_Departament";

              
               ProductItem productItem = new ProductItem("Selectati un departament!" , "", "", "00,00", 0);
               flowLayoutPanel1.Controls.Add(productItem);

        }

        private void AfiseazaProdusele()
        {
            List<ProductItem> productItems = new List<ProductItem>();
            List<Produs> produse = new List<Produs>();
            List<Departament> departaments = new List<Departament>();

            departaments = operatiiBD.CautaDepartamentDupaID(deptID);
            
             if (departaments.Count > 0)
             {
                 Departament dept = departaments.First<Departament>();
                 produse = operatiiBD.GetProduse(dept.Nume);

                if (produse.Count > 0)
                 {
                     for (int i = 0; i < produse.Count; i++)
                     {
                        Produs prod = produse[i];
                        string descrierea = prod.Cantitate.ToString() + " " + prod.Tip_Cantitate + ", Valabil pana pe: " + prod.Data_Valabilitate;
                        string pret = prod.Pret.ToString();

                        List<Producator> producators = new List<Producator>();
                        producators = operatiiBD.CautaProducatorDupaID(prod.ID_Producator);
                        Producator producator = producators.First<Producator>();

                         productItems.Add(new ProductItem(prod.Denumire, descrierea, producator.Denumirea, pret,  prod.ID_Produs));
                         flowLayoutPanel1.Controls.Add(productItems[i]);
                     }
                 } else
                 {
                     ProductItem productItem = new ProductItem("Nu exista produse in " + dept.Nume, "--", "--", "--", 0);
                     flowLayoutPanel1.Controls.Add(productItem);
                 }
             }  
        }

        private void cmbDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int.TryParse(cmbDepartament.SelectedValue.ToString(), out deptID);
            AfiseazaProdusele();  
        }

        private void FormCautaProduseDupaDepartament_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
