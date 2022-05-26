
namespace Alimentara
{
    partial class ProdusReducere
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPretVechi = new System.Windows.Forms.Label();
            this.lblPretNou = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPretVechi
            // 
            this.lblPretVechi.AutoSize = true;
            this.lblPretVechi.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretVechi.Location = new System.Drawing.Point(148, 226);
            this.lblPretVechi.Name = "lblPretVechi";
            this.lblPretVechi.Size = new System.Drawing.Size(100, 20);
            this.lblPretVechi.TabIndex = 1;
            this.lblPretVechi.Text = "pretVechi";
            // 
            // lblPretNou
            // 
            this.lblPretNou.AutoSize = true;
            this.lblPretNou.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretNou.ForeColor = System.Drawing.Color.Red;
            this.lblPretNou.Location = new System.Drawing.Point(41, 266);
            this.lblPretNou.Name = "lblPretNou";
            this.lblPretNou.Size = new System.Drawing.Size(90, 20);
            this.lblPretNou.TabIndex = 2;
            this.lblPretNou.Text = "pret nou";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Alimentara.Properties.Resources.sale_img;
            this.pictureBox1.Location = new System.Drawing.Point(77, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenumire.Location = new System.Drawing.Point(96, 172);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(103, 20);
            this.lblDenumire.TabIndex = 3;
            this.lblDenumire.Text = "Denumirea";
            this.lblDenumire.SizeChanged += new System.EventHandler(this.lblDenumire_SizeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pret Vechi:";
            // 
            // ProdusReducere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.lblPretNou);
            this.Controls.Add(this.lblPretVechi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProdusReducere";
            this.Size = new System.Drawing.Size(320, 306);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPretVechi;
        private System.Windows.Forms.Label lblPretNou;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label label1;
    }
}
