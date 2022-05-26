using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class FormOperatiiDeAfisareProduse : MaterialSkin.Controls.MaterialForm
    {
        private OperatiiBD operatiiBD = new OperatiiBD();
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        private Conectare conectare = new Conectare();
        private int magazinID;
        public FormOperatiiDeAfisareProduse()
        {
            InitializeComponent();
            txtCauta.Focus();
            AfisareMagazine();
            btnValoareTotala.Enabled = false;
            cmbMagazine.Text = "Magazine";
        }

        public void AfisareMagazine()
        {
            dataAdapter = new SqlDataAdapter("select * from Magazin", conectare.Open());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbMagazine.DataSource = dt;
            cmbMagazine.DisplayMember = "Nume";
            cmbMagazine.ValueMember = "ID_Magazin";

        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            label2.Text = "Produse în ordine crescătoare a prețutilor: " + txtCauta.Text + "...";
            btnValoareTotala.Enabled = false;

            if (txtCauta.Text != "")
            {
                List<Produs> produse = operatiiBD.CautaProduse(txtCauta.Text);
                List<Produs> sortedProduse = produse.OrderBy(item => item.Pret).ToList();

                if (produse.Count > 0)
                {
                    int nr = 1;
                    sortedProduse.ForEach(item =>
                   {
                       flowLayoutPanel1.Controls.Add(new ColumnTable(nr, item));
                       nr++;
                   });
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(new ColumnTable(1, txtCauta.Text));
                }
            }
        }

        private void txtCauta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCauta.Text.Equals(""))
            {
                flowLayoutPanel1.Controls.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back || char.IsLetter(e.KeyChar))
            {
                btnCauta_Click(sender, e);
            }
        }

        private void cmbMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbMagazine.SelectedValue.ToString(), out magazinID);
            AfisareCelMaiScumpProdus();
            btnValoareTotala.Enabled = true;
        }

        private void AfisareCelMaiScumpProdus()
        {
            txtCauta.Text = "";
            List<Produs> produse = operatiiBD.GetProduseDinMagazin(magazinID);
            List<Magazin> magazins = operatiiBD.CautaMagazinDupaID(magazinID);

            if (magazins.Count > 0)
            {
                Magazin magazin = magazins.First<Magazin>();

                if (produse.Count > 0)
                {
                    List<Produs> sortedProduse = produse.OrderBy(item => item.Pret).ToList();
                    Produs produs = sortedProduse.Last<Produs>();

                    flowLayoutPanel1.Controls.Clear();
                    label2.Text = "Cel mai scump produs din magazinul: " + magazin.Nume;
                    flowLayoutPanel1.Controls.Add(new ColumnTable(1, produs));
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    label2.Text = "";
                    MessageBox.Show("Magazinul " + magazin.Nume + " temporar este închis, nu are produse!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
            
        }

        private void btnValoareTotala_Click(object sender, EventArgs e)
        {
            txtCauta.Text = "";
            float sumaPret = 0;
            List<Produs> produse = operatiiBD.GetProduseDinMagazin(magazinID);
            List<Magazin> magazins = operatiiBD.CautaMagazinDupaID(magazinID);

            if (magazins.Count > 0)
            {
                Magazin magazin = magazins.First<Magazin>();

                if (produse.Count > 0)
                {
                    produse.ForEach(item => {
                        sumaPret += item.Pret;
                    });
                    flowLayoutPanel1.Controls.Clear();
                    label2.Text = "În Magazinul "  +magazin.Nume + " valoarea totală a mărfurilor este: " + sumaPret.ToString();
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    label2.Text = "";
                    MessageBox.Show("Magazinul " + magazin.Nume + " temporar este închis, nu are produse!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void infoPictureBox_Click(object sender, EventArgs e)
        {
            string str = "* Butonul Valoarea Totatala a Mărfurilor, se activeaza după selectarea unui Magazin din ComboBox \n"
                + "* În TextBox-ul Denumirea se introduce numele unui produs și se afișează dacă sunt în Magazine";
            MessageBox.Show(str, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormOperatiiDeAfisareProduse_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

      
    }
}
