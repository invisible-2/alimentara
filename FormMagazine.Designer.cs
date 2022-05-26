
namespace Alimentara
{
    partial class FormMagazine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagazine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cmbLocalitate = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdaugaMagazin = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.magazinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alimentaraBDMagazineDataSet = new Alimentara.AlimentaraBDMagazineDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLocalitMagazine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNrOrase = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.alimentaraBDDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinTableAdapter = new Alimentara.AlimentaraBDMagazineDataSetTableAdapters.MagazinTableAdapter();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentaraBDMagazineDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alimentaraBDDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(138)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.cmbLocalitate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdaugaMagazin);
            this.panel1.Controls.Add(this.txtAdresa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(616, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 377);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nume: ";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(193, 80);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(282, 29);
            this.txtNume.TabIndex = 16;
            // 
            // cmbLocalitate
            // 
            this.cmbLocalitate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalitate.FormattingEnabled = true;
            this.cmbLocalitate.Location = new System.Drawing.Point(193, 223);
            this.cmbLocalitate.Name = "cmbLocalitate";
            this.cmbLocalitate.Size = new System.Drawing.Size(282, 33);
            this.cmbLocalitate.TabIndex = 15;
            this.cmbLocalitate.SelectedIndexChanged += new System.EventHandler(this.cmbLocalitate_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Adauga un Magazin Nou";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresa: ";
            // 
            // btnAdaugaMagazin
            // 
            this.btnAdaugaMagazin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaMagazin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaMagazin.ForeColor = System.Drawing.Color.Black;
            this.btnAdaugaMagazin.Image = global::Alimentara.Properties.Resources.add_icon;
            this.btnAdaugaMagazin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdaugaMagazin.Location = new System.Drawing.Point(193, 284);
            this.btnAdaugaMagazin.Name = "btnAdaugaMagazin";
            this.btnAdaugaMagazin.Size = new System.Drawing.Size(282, 67);
            this.btnAdaugaMagazin.TabIndex = 6;
            this.btnAdaugaMagazin.Text = "Adauga Magazin";
            this.btnAdaugaMagazin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdaugaMagazin.UseVisualStyleBackColor = true;
            this.btnAdaugaMagazin.Click += new System.EventHandler(this.btnAdaugaMagazin_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.Location = new System.Drawing.Point(193, 126);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(282, 29);
            this.txtAdresa.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Localitatea: ";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(193, 176);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(282, 29);
            this.txtTelefon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Alimentara.Properties.Resources.market;
            this.pictureBox1.Location = new System.Drawing.Point(718, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataMember = "Produs";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(13, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 208);
            this.panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.localitateDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magazinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 199);
            this.dataGridView1.TabIndex = 9;
            // 
            // magazinBindingSource
            // 
            this.magazinBindingSource.DataMember = "Magazin";
            this.magazinBindingSource.DataSource = this.alimentaraBDMagazineDataSet;
            // 
            // alimentaraBDMagazineDataSet
            // 
            this.alimentaraBDMagazineDataSet.DataSetName = "AlimentaraBDMagazineDataSet";
            this.alimentaraBDMagazineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbLocalitMagazine);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblNrOrase);
            this.panel3.Location = new System.Drawing.Point(13, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 377);
            this.panel3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 18;
            // 
            // cmbLocalitMagazine
            // 
            this.cmbLocalitMagazine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalitMagazine.FormattingEnabled = true;
            this.cmbLocalitMagazine.Location = new System.Drawing.Point(174, 112);
            this.cmbLocalitMagazine.Name = "cmbLocalitMagazine";
            this.cmbLocalitMagazine.Size = new System.Drawing.Size(282, 33);
            this.cmbLocalitMagazine.TabIndex = 17;
            this.cmbLocalitMagazine.SelectedIndexChanged += new System.EventHandler(this.cmbLocalitMagazine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Localitatea: ";
            // 
            // lblNrOrase
            // 
            this.lblNrOrase.AutoSize = true;
            this.lblNrOrase.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOrase.Location = new System.Drawing.Point(52, 19);
            this.lblNrOrase.Name = "lblNrOrase";
            this.lblNrOrase.Size = new System.Drawing.Size(391, 29);
            this.lblNrOrase.TabIndex = 0;
            this.lblNrOrase.Text = "Avem magazine în 10 orașe ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(-43, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1169, 634);
            this.panel4.TabIndex = 11;
            // 
            // magazinTableAdapter
            // 
            this.magazinTableAdapter.ClearBeforeFill = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 125;
            // 
            // localitateDataGridViewTextBoxColumn
            // 
            this.localitateDataGridViewTextBoxColumn.DataPropertyName = "Localitate";
            this.localitateDataGridViewTextBoxColumn.HeaderText = "Localitate";
            this.localitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.localitateDataGridViewTextBoxColumn.Name = "localitateDataGridViewTextBoxColumn";
            this.localitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormMagazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1113, 696);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMagazine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMagazine_FormClosing);
            this.Load += new System.EventHandler(this.FormMagazine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentaraBDMagazineDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alimentaraBDDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnAdaugaMagazin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
      
        private System.Windows.Forms.BindingSource produsBindingSource;
      
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNrOrase;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource alimentaraBDDataSet2BindingSource;
      
        private AlimentaraBDMagazineDataSet alimentaraBDMagazineDataSet;
        private System.Windows.Forms.BindingSource magazinBindingSource;
        private AlimentaraBDMagazineDataSetTableAdapters.MagazinTableAdapter magazinTableAdapter;
        private System.Windows.Forms.ComboBox cmbLocalitate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox cmbLocalitMagazine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMagazinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}