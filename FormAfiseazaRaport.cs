using System;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class FormAfiseazaRaport : MaterialSkin.Controls.MaterialForm
    {
        public FormAfiseazaRaport()
        {
            InitializeComponent();
        }

        private void FormAfiseazaRaport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            this.reportViewer1.RefreshReport();
        }

        private void FormAfiseazaRaport_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
