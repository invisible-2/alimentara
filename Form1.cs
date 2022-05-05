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
    public partial class FormAlimentara : MaterialSkin.Controls.MaterialForm
    {
        public FormAlimentara()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red600, Primary.Red700,
                Primary.Green700, Accent.LightBlue100,
                TextShade.WHITE
              );

            textBox1.Focus();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOperatii formOperatii = new FormOperatii();
            formOperatii.ShowDialog();

            this.Show();
            DialogResult dialog = MessageBox.Show("Doriti sa inchideti fereastra?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) 
                this.Close();
            
            
        }
    }
}
