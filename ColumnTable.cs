using System.Windows.Forms;

namespace Alimentara
{
    public partial class ColumnTable : UserControl
    {
        public ColumnTable(int nr, Produs produs)
        {
            InitializeComponent();
            lblNr.Text = nr.ToString();
            lblDenumire.Text = produs.Denumire;
            lblCantitate.Text = produs.Cantitate.ToString() + " " + produs.Tip_Cantitate;
            lblPret.Text = produs.Pret.ToString() + " MDL";
        }

        public ColumnTable(int nr, string str)
        {
            InitializeComponent();
            lblNr.Text = nr.ToString();
            lblDenumire.Text = "Nu exista produs cu denumirea: " + str;
            lblCantitate.Text = "-";
            lblPret.Text = "-";
        }
    }
}
