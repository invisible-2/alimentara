using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Alimentara
{
    public partial class FormMagazine : MaterialSkin.Controls.MaterialForm
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        private Conectare conectare = new Conectare();
        private int IDLocalitate;
        private Int32 CountOrase;
        private OperatiiBD operatiiBD = new OperatiiBD();
        public FormMagazine()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(100, 223, 223);
            panel2.BackColor = Color.FromArgb(100, 223, 223);
            panel3.BackColor = Color.FromArgb(100, 223, 223);
            panel4.BackColor = Color.FromArgb(128, 255, 219);

            AfisareLocalitati();
            txtNume.Focus();
            NrOrase();

            SqlCommand cmd = new SqlCommand("select count(ID_Localitate) from Magazin where ID_Localitate = 1", conectare.Open());
            Int32 nr = (Int32)cmd.ExecuteScalar();
            label6.Text = "La Chisinau sunt deschise " + nr + " magazine";


        }
        public void AfisareLocalitati()
        {
            dataAdapter = new SqlDataAdapter("select * from Localitate", conectare.Open());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbLocalitate.DataSource = dt;
            cmbLocalitate.DisplayMember = "Nume";
            cmbLocalitate.ValueMember = "ID_Localitate";

            cmbLocalitMagazine.DataSource = dt;
            cmbLocalitMagazine.DisplayMember = "Nume";
            cmbLocalitMagazine.ValueMember = "ID_Localitate";

        }

        private void NrOrase()
        {
            SqlCommand cmd = new SqlCommand("select count(distinct ID_Localitate) from Magazin", conectare.Open());
            CountOrase = (Int32)cmd.ExecuteScalar();
            lblNrOrase.Text = "Avem magazine în " + CountOrase + " orașe";
        }

        private void FormMagazine_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FormMagazine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alimentaraBDMagazineDataSet.Magazin' table. You can move, or remove it, as needed.
            this.magazinTableAdapter.Fill(this.alimentaraBDMagazineDataSet.Magazin);  
        }

        private void btnAdaugaMagazin_Click(object sender, EventArgs e)
        {
            if(txtNume.Text != "" && txtAdresa.Text != "" && txtTelefon.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Doriți să adăugați un nou Magazin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    operatiiBD.AdaugaMagazin(txtNume.Text, txtAdresa.Text, txtTelefon.Text, IDLocalitate);
                    NrOrase();
                    ClearFields();
                    this.magazinTableAdapter.Fill(this.alimentaraBDMagazineDataSet.Magazin);
                    MessageBox.Show("Magazin adaugat cu succes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbLocalitMagazine_SelectedIndexChanged(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Introduceți Numele, Adresa si Telefonul Magazinului!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLocalitate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbLocalitate.SelectedValue.ToString(), out IDLocalitate);
        }

        private void ClearFields()
        {
            txtNume.Clear();
            txtAdresa.Clear();
            txtTelefon.Clear();
          
        }

        private void cmbLocalitMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            List<Localitate> localitates = new List<Localitate>();
            int.TryParse(cmbLocalitMagazine.SelectedValue.ToString(), out id);
            localitates = operatiiBD.CautaLocalitateDupaID(id);

            if (localitates.Count > 0)
            {
                Localitate localitate = localitates.First<Localitate>();

                SqlCommand cmd = new SqlCommand("select count(ID_Localitate) from Magazin where ID_Localitate = " + id, conectare.Open());
                Int32 nr = (Int32)cmd.ExecuteScalar();

                if (nr > 1)
                {
                    label6.Text = "La " + localitate.Nume + " sunt deschise " + nr + " magazine";
                }else if( nr == 1)
                {
                    label6.Text = "La " + localitate.Nume + " este deschis " + nr + " magazin";
                }
                else
                {
                    label6.Text = "La " + localitate.Nume + " nu avem magazine deschise, \n Adauga acum unul!";
                }
            }
        }

    }
}
