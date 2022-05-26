using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Alimentara
{
    public partial class FormAlimentara : MaterialSkin.Controls.MaterialForm
    {
        private OperatiiBDLogIN operatiiBDLogIN = new OperatiiBDLogIN();

        public FormAlimentara()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(255, 161, 195, 225);
            panel2.BackColor = Color.FromArgb(255, 202, 217, 231);
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "")
            {
                if (checkBoxAdmin.Checked)
                {
                    List<Admin> admins = operatiiBDLogIN.GetAdminByUsername(txtUsername.Text);
                    if (admins.Count > 0)
                    {
                        Admin admin = admins.First<Admin>();

                        Byte[] pass = SHA512(txtPass.Text);
                        string password = ByteToString(pass);
                        string passFromBD = ByteToString(admin.PassHash);

                        if (txtUsername.Text.Equals(admin.Username) &&
                                password.Equals(passFromBD))
                        {
                            ClearFields();
                            FormCompenents form = new FormCompenents("Admin: " + admin.FName, "ADMIN");
                            form.Show();
                            MessageBox.Show("Logged IN as Admin");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Credentials", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (checkBoxUser.Checked)
                {
                    List<User> users = operatiiBDLogIN.GetUserByUsername(txtUsername.Text);
                    if (users.Count > 0)
                    {
                        User user = users.First<User>();

                        Byte[] pass = SHA512(txtPass.Text);
                        string password = ByteToString(pass);
                        string passFromBD = ByteToString(user.PassHash);

                        if (txtUsername.Text.Equals(user.Username) &&
                                password.Equals(passFromBD))
                        {
                            ClearFields();
                            FormCompenents form = new FormCompenents("User: " + user.LName + " " + user.FName, "USER");
                            form.Show();
                            MessageBox.Show("Logged IN as User");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Credentials", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Inexistent!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Credentials", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
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
            for(int i = 0; i < vs.Length; i++)
            {
                str += vs[i].ToString();
            }
            return str;
        }
    
        private void ClearFields()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                txtUsername.Focus();
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                txtPass.Focus();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void btnLogInAsNewUser_Click(object sender, EventArgs e)
        {
            FormSingUpUser formSingUp = new FormSingUpUser();
            formSingUp.Show();
        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAdmin.Checked = !checkBoxUser.Checked;
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxUser.Checked = !checkBoxAdmin.Checked;
        }
    }
}
