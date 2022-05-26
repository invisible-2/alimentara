
namespace Alimentara
{
    partial class FormOperatiiDeAfisareProduse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperatiiDeAfisareProduse));
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMagazine = new System.Windows.Forms.ComboBox();
            this.btnValoareTotala = new System.Windows.Forms.Button();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCauta
            // 
            this.txtCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauta.Location = new System.Drawing.Point(151, 124);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(302, 32);
            this.txtCauta.TabIndex = 0;
            this.txtCauta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCauta_KeyPress);
            // 
            // btnCauta
            // 
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauta.Location = new System.Drawing.Point(459, 123);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(119, 33);
            this.btnCauta.TabIndex = 1;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Denumirea:";
            // 
            // cmbMagazine
            // 
            this.cmbMagazine.BackColor = System.Drawing.Color.White;
            this.cmbMagazine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMagazine.FormattingEnabled = true;
            this.cmbMagazine.Location = new System.Drawing.Point(601, 127);
            this.cmbMagazine.Name = "cmbMagazine";
            this.cmbMagazine.Size = new System.Drawing.Size(302, 33);
            this.cmbMagazine.TabIndex = 5;
            this.cmbMagazine.SelectedIndexChanged += new System.EventHandler(this.cmbMagazine_SelectedIndexChanged);
            // 
            // btnValoareTotala
            // 
            this.btnValoareTotala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValoareTotala.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValoareTotala.Location = new System.Drawing.Point(601, 79);
            this.btnValoareTotala.Name = "btnValoareTotala";
            this.btnValoareTotala.Size = new System.Drawing.Size(302, 42);
            this.btnValoareTotala.TabIndex = 6;
            this.btnValoareTotala.Text = "Valoare Totală a Mărfurilor";
            this.btnValoareTotala.UseVisualStyleBackColor = true;
            this.btnValoareTotala.Click += new System.EventHandler(this.btnValoareTotala_Click);
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.infoPictureBox.Image = global::Alimentara.Properties.Resources.info_icon;
            this.infoPictureBox.Location = new System.Drawing.Point(12, 78);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(45, 43);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPictureBox.TabIndex = 7;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 244);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 456);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 187);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(891, 51);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produse:";
            // 
            // FormOperatiiDeAfisareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 706);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.btnValoareTotala);
            this.Controls.Add(this.cmbMagazine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtCauta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOperatiiDeAfisareProduse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare Produse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOperatiiDeAfisareProduse_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMagazine;
        private System.Windows.Forms.Button btnValoareTotala;
        private System.Windows.Forms.PictureBox infoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
    }
}