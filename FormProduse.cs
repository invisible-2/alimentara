using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class FormProduse : MaterialSkin.Controls.MaterialForm
    {
        List<Produs> produse = new List<Produs>();
        OperatiiBD operatiiBD = new OperatiiBD();
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        private Conectare conectare = new Conectare();
        private int departamentID;
        private int producatorID;
        private int magazinID;
        private string tipCantitate = "KG";
        private Produs produs;
        public FormProduse()
        {
            InitializeComponent();
            txtCod.Focus();
            AfisareDepartamente();
            AfisareProducatori();
            AfisareMagazine();

            cmbTipCantitate.Items.Add("KG");
            cmbTipCantitate.Items.Add("g");
            cmbTipCantitate.Items.Add("L");
            cmbTipCantitate.Items.Add("ML");
            cmbTipCantitate.Items.Add("buc.");
            cmbTipCantitate.Items.Add("pac.");

            btnActualizeaza.Enabled = false;
            btnSterge.Enabled = false;
        }
        public void AfisareDepartamente()
        {
            dataAdapter = new SqlDataAdapter("select * from Departament", conectare.Open());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbDepartament.DataSource = dt;
            cmbDepartament.DisplayMember = "Nume";
            cmbDepartament.ValueMember = "ID_Departament";

        }
        public void AfisareProducatori()
        {
            dataAdapter = new SqlDataAdapter("select * from Producator", conectare.Open());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbProducator.DataSource = dt;
            cmbProducator.DisplayMember = "Denumirea";
            cmbProducator.ValueMember = "ID_Producator";
        }
        public void AfisareMagazine()
        {
            dataAdapter = new SqlDataAdapter("select * from Magazin", conectare.Open());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbMagazin.DataSource = dt;
            cmbMagazin.DisplayMember = "Nume";
            cmbMagazin.ValueMember = "ID_Magazin";
        }
        private void btnCautaCodBD_Click(object sender, EventArgs e)
        {
            OperatiiBD operatii = new OperatiiBD();
            if (txtCod.Text != "")
            {
                int cod = int.Parse(txtCod.Text);
                produse = operatii.CautaProdusDupaCod(cod);

                if (produse.Count > 0)
                {
                    FormProdusCautatDupaCod formProdus = new FormProdusCautatDupaCod(produse);
                    formProdus.ShowDialog();
                    txtCod.Text = "";
                    txtCod.Focus();

                }
                else
                {
                    MessageBox.Show("Codul " + txtCod.Text + " este inexistent!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCod.Text = "";
                    txtCod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Introduce-ți Codul", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCod.Text = "";
                txtCod.Focus();
            }



        }
        private void FormProduse_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            produs = new Produs();

            if (txtCod.Text != "")
            {
                int cod = int.Parse(txtCod.Text);
                produse = operatiiBD.CautaProdusDupaCod(cod);

                if (produse.Count > 0)
                {
                    produs = produse.First<Produs>();
                    FillFields(produs);

                    btnActualizeaza.Enabled = true;
                    btnSterge.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Codul " + txtCod.Text + " este inexistent!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFiels();
                    txtCod.Text = "";
                    txtCod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Introduce-ți Codul", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCod.Text = "";
                txtCod.Focus();
            }
        }
        private void FillFields(Produs produs)
        {
            txtDenumire.Text = produs.Denumire;
            txtCantitate.Text = produs.Cantitate.ToString();
            cmbTipCantitate.Text = produs.Tip_Cantitate;
            txtPret.Text = produs.Pret.ToString();

            int date = int.Parse(produs.Data_Valabilitate.Substring(0, 2));
            int month = int.Parse(produs.Data_Valabilitate.Substring(3, 2));
            int year = int.Parse(produs.Data_Valabilitate.Substring(6, 4));

            dateTimePicker1.Value = new DateTime(year, month, date);

            List<Departament> departaments = new List<Departament>();
            departaments = operatiiBD.CautaDepartamentDupaID(produs.ID_Departament);
            Departament departament = departaments.First<Departament>();
            cmbDepartament.Text = departament.Nume;

            List<Producator> producators = new List<Producator>();
            producators = operatiiBD.CautaProducatorDupaID(produs.ID_Producator);
            Producator producator = producators.First<Producator>();
            cmbProducator.Text = producator.Denumirea;

            List<Magazin> magazins = new List<Magazin>();
            magazins = operatiiBD.CautaMagazinDupaID(produs.ID_Magazin);
            Magazin magazin = magazins.First<Magazin>();
            cmbMagazin.Text = magazin.Nume;
            cmbTipCantitate.Text = produs.Tip_Cantitate;
        }
        private void ClearFiels()
        {
            txtCod.Clear();
            txtDenumire.Clear();
            txtCantitate.Clear();
            cmbTipCantitate.Text = "";
            txtPret.Clear();
            cmbDepartament.Text = "";
            cmbProducator.Text = "";
            cmbMagazin.Text = "";
        }
        private String CorrectDate(string day)
        {
            return (day.Length == 1) ? "0" + day : day;
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.Year.ToString();
            string month = CorrectDate(dateTimePicker1.Value.Month.ToString());
            string day = CorrectDate(dateTimePicker1.Value.Day.ToString());
            string dateValid = day + "-" + month + "-" + year;

            if (txtCod.Text != "" && txtCantitate.Text != "" && txtDenumire.Text != "" && txtPret.Text != "")
            {
                if (departamentID != 0 && producatorID != 0 && magazinID != 0)
                {
                    DialogResult dialog = MessageBox.Show("Doriți să adăugați un nou Produs?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        float cantitate = float.Parse(txtCantitate.Text);
                        float pret = float.Parse(txtPret.Text);

                        operatiiBD.AdaugaProdus(txtCod.Text, txtDenumire.Text, cantitate , cmbTipCantitate.SelectedItem.ToString(),
                        pret, dateValid, departamentID, producatorID, magazinID);
                        ClearFiels();
                    }
                }
                else
                {
                    MessageBox.Show("Selectați Deparatmentul, Producatorul si Magazinul!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduce-ți toate câmpurile!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntActualizeaza_Click(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.Year.ToString();
            string month = CorrectDate(dateTimePicker1.Value.Month.ToString());
            string day = CorrectDate(dateTimePicker1.Value.Day.ToString());
            string dateValid = day + "-" + month + "-" + year;

            float cantitate = float.Parse(txtCantitate.Text);
            float pret = float.Parse(txtPret.Text);

            operatiiBD.ActualizeazaProdus(produs.ID_Produs, txtCod.Text, txtDenumire.Text, cantitate, cmbTipCantitate.SelectedItem.ToString(),
                    pret, dateValid);

            MessageBox.Show("Actualizat cu succes", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFiels();
            btnActualizeaza.Enabled = false;
            btnSterge.Enabled = false;
        }
        private void btnSterge_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Doriți să ștergeți produsul cu codul: " + produs.Cod + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                operatiiBD.StergeProdus(produs.ID_Produs);
                ClearFiels();
                MessageBox.Show("Ștergere cu succes", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizeaza.Enabled = false;
                btnSterge.Enabled = false;
            }  
        }
        private void cmbDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbDepartament.SelectedValue.ToString(), out departamentID);
        }
        private void cmbProducator_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbProducator.SelectedValue.ToString(), out producatorID);
        }
        private void cmbMagazin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int.TryParse(cmbMagazin.SelectedValue.ToString(), out magazinID);
        }
        private void cmbTipCantitate_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipCantitate = cmbTipCantitate.SelectedItem.ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFiels();
            btnSterge.Enabled = false;
            btnActualizeaza.Enabled = false;
        }
        private void FormProduse_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }
        private void txtPret_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPret.Text, @"\."))
            {
                MessageBox.Show("Folosește virgula pentru numere cu zecimale!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPret.Text = txtPret.Text.Remove(txtPret.Text.Length - 1);
            }
            else if (Regex.IsMatch(txtPret.Text, "[^0-9,]"))
            {
                MessageBox.Show("Introduce-ți doar numere!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPret.Text = txtPret.Text.Remove(txtPret.Text.Length - 1);
            }
        }
        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtCantitate.Text, @"\."))
            {
                MessageBox.Show("Folosește virgula pentru numere cu zecimale!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantitate.Text = txtCantitate.Text.Remove(txtCantitate.Text.Length - 1);
            }
            else if (Regex.IsMatch(txtCantitate.Text, "[^0-9,]"))
            {
                MessageBox.Show("Introduce-ți doar numere!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantitate.Text = txtCantitate.Text.Remove(txtCantitate.Text.Length - 1);
            }
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCautaCodBD_Click(sender, e);
            }
        }
    }     
}
