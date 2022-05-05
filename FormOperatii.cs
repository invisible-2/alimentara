using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class FormOperatii : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public FormOperatii()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red600, Primary.Red700,
                Primary.Green700, Accent.LightBlue100,
                TextShade.WHITE
              );
        }

        private void FormOperatii_FormClosed(object sender, FormClosedEventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String year = dateTimePicker1.Value.Year.ToString();
            String month = dateTimePicker1.Value.Month.ToString();
            String day = dateTimePicker1.Value.Day.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String year = dateTimePicker1.Value.Year.ToString();
            String month = dateTimePicker1.Value.Month.ToString();
            String day = dateTimePicker1.Value.Day.ToString();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}
