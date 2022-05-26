
namespace Alimentara
{
    partial class ColumnTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPret = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNr);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 93);
            this.panel1.TabIndex = 0;
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.Location = new System.Drawing.Point(15, 27);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(21, 20);
            this.lblNr.TabIndex = 0;
            this.lblNr.Text = "1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDenumire);
            this.panel2.Location = new System.Drawing.Point(53, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 97);
            this.panel2.TabIndex = 1;
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenumire.Location = new System.Drawing.Point(22, 25);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(101, 20);
            this.lblDenumire.TabIndex = 0;
            this.lblDenumire.Text = "Denumire";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCantitate);
            this.panel3.Location = new System.Drawing.Point(546, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 93);
            this.panel3.TabIndex = 2;
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(19, 24);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(96, 20);
            this.lblCantitate.TabIndex = 0;
            this.lblCantitate.Text = "Cantitate";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblPret);
            this.panel4.Location = new System.Drawing.Point(697, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 93);
            this.panel4.TabIndex = 3;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(22, 25);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(95, 20);
            this.lblPret.TabIndex = 0;
            this.lblPret.Text = "Pret MDL";
            // 
            // ColumnTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ColumnTable";
            this.Size = new System.Drawing.Size(849, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPret;
    }
}
