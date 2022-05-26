using System;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class Number : UserControl
    {
        public Number(int num)
        {
            InitializeComponent();
            label1.Text = num.ToString();
            label1.Left = (ClientSize.Width - label1.Size.Width) / 2;
        }

        private void Number_SizeChanged(object sender, EventArgs e)
        {
            label1.Left = (ClientSize.Width - label1.Size.Width) / 2;
        }
    }
}
