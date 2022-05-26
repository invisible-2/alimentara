using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class FormSingUpUser : MaterialSkin.Controls.MaterialForm
    {
        private OperatiiBDLogIN operatiiBD = new OperatiiBDLogIN();
        public FormSingUpUser()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(255, 161, 195, 225);
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            if(txtFName.Text != "" && txtLName.Text != "" && txtUsername.Text != "" && 
                txtPass.Text != "" && txtRepeatPass.Text != "")
            {
                List<String> users = operatiiBD.CheckIfExistUser(txtUsername.Text);
                String user = users.First<String>();
                if (user.Equals("EXISTS"))
                {
                    MessageBox.Show("Username ocupat, alege altul!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.BackColor = Color.Red;
                }
                else
                {
                    if (txtPass.Text.Equals(txtRepeatPass.Text))
                    {
                       operatiiBD.AddUser(txtUsername.Text, txtFName.Text, txtLName.Text, txtPass.Text);
                       DialogResult dialog =  MessageBox.Show("User înregistrat cu succes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dialog == DialogResult.OK)
                        {
                            FormAlimentara form = new FormAlimentara();
                            form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola nu coincide!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRepeatPass.BackColor = Color.Red;
                    }
                }

            }
            else
            {
                MessageBox.Show("Enter Credentials!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void txtRepeatPass_TextChanged(object sender, EventArgs e)
        {
            txtRepeatPass.BackColor = Color.White;
        }

        private static Byte[] SHA512(string plaintext)
        {
            ASCIIEncoding AE = new ASCIIEncoding();
            byte[] passBuff = AE.GetBytes(plaintext);

            SHA512Managed hashVal = new SHA512Managed();
            byte[] passHash = hashVal.ComputeHash(passBuff);

            return passHash;
        }

        private string ByteToString(Byte[] vs)
        {
            string str = "";
            for (int i = 0; i < vs.Length; i++)
            {
                str += vs[i].ToString();
            }
            return str;
        }
       
    }
}
