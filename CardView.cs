using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class CardView : UserControl
    {
        private bool isAccessible = true;
        private Form form;
        public CardView()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(33, 158, 188);   
        }

        public CardView(string name, Form form, bool visibility)
        {
            InitializeComponent();
            
            lblName.Text = name;
            this.form = form;
            this.isAccessible = visibility;

            if (!isAccessible)
            {
                BackColor = Color.FromArgb(142, 202, 230);
            }
            else
            {
                BackColor = Color.FromArgb(33, 158, 188);
            }
        }

        private void CardView_MouseClick(object sender, MouseEventArgs e)
        {
            if (isAccessible)
            {
                BackColor = Color.FromArgb(142, 202, 230);
                form.Show();
            }
        }


        private void CardView_MouseLeave(object sender, EventArgs e)
        {
            if (isAccessible)
            {
                BackColor = Color.FromArgb(33, 158, 188);
            }
        }

        private void CardView_MouseEnter(object sender, EventArgs e)
        {
            if (isAccessible)
            {
                BackColor = Color.FromArgb(142, 202, 230);
            }
        }

        private void lblName_MouseHover(object sender, EventArgs e)
        {
            if (isAccessible)
            {
                BackColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void lblName_SizeChanged(object sender, EventArgs e)
        {
            lblName.Left = (ClientSize.Width - lblName.Size.Width) / 2;  
        }
    }
}
