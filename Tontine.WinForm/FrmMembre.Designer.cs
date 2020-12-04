namespace Tontine.WinForm
{
    partial class FrmMembre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMembre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mutualiterDataSet5 = new Tontine.WinForm.MutualiterDataSet5();
            this.k = new System.Windows.Forms.PictureBox();
            this.membresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membresTableAdapter = new Tontine.WinForm.MutualiterDataSet5TableAdapters.MembresTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.txtFonction);
            this.panel1.Controls.Add(this.lblFonction);
            this.panel1.Controls.Add(this.txtSex);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtIdentifier);
            this.panel1.Controls.Add(this.lblIdentifier);
            this.panel1.Controls.Add(this.txtTelephone);
            this.panel1.Controls.Add(this.lblTelephone);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Location = new System.Drawing.Point(351, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 465);
            this.panel1.TabIndex = 40;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.White;
            this.txtSex.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.membresBindingSource, "sexe", true));
            this.txtSex.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(16, 299);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(331, 20);
            this.txtSex.TabIndex = 5;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(12, 270);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(38, 19);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Sex";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(226, 405);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.Location = new System.Drawing.Point(20, 405);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 39);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.BackColor = System.Drawing.Color.White;
            this.txtIdentifier.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.membresBindingSource, "id_mem", true));
            this.txtIdentifier.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifier.Location = new System.Drawing.Point(15, 49);
            this.txtIdentifier.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(333, 20);
            this.txtIdentifier.TabIndex = 1;
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifier.Location = new System.Drawing.Point(15, 21);
            this.lblIdentifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(75, 19);
            this.lblIdentifier.TabIndex = 0;
            this.lblIdentifier.Text = "Identifier";
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.White;
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.membresBindingSource, "telephone", true));
            this.txtTelephone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(15, 229);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(331, 20);
            this.txtTelephone.TabIndex = 4;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(8, 203);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(89, 19);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.membresBindingSource, "prenom_mem", true));
            this.txtLastName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(15, 167);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(331, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(9, 141);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 19);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.membresBindingSource, "nom_mem", true));
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(15, 106);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(333, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(15, 78);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First name";
            // 
            // txtFonction
            // 
            this.txtFonction.BackColor = System.Drawing.Color.White;
            this.txtFonction.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.membresBindingSource, "fonction", true));
            this.txtFonction.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFonction.Location = new System.Drawing.Point(16, 360);
            this.txtFonction.Margin = new System.Windows.Forms.Padding(2);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(331, 20);
            this.txtFonction.TabIndex = 8;
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFonction.Location = new System.Drawing.Point(12, 331);
            this.lblFonction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(77, 19);
            this.lblFonction.TabIndex = 9;
            this.lblFonction.Text = "Fonction";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mutualiterDataSet5;
            this.bindingSource1.Position = 0;
            // 
            // mutualiterDataSet5
            // 
            this.mutualiterDataSet5.DataSetName = "MutualiterDataSetMembre";
            this.mutualiterDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // k
            // 
            this.k.Image = ((System.Drawing.Image)(resources.GetObject("k.Image")));
            this.k.Location = new System.Drawing.Point(2, 23);
            this.k.Margin = new System.Windows.Forms.Padding(2);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(345, 388);
            this.k.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.k.TabIndex = 41;
            this.k.TabStop = false;
            // 
            // membresBindingSource
            // 
            this.membresBindingSource.DataMember = "Membres";
            this.membresBindingSource.DataSource = this.mutualiterDataSet5;
            // 
            // membresTableAdapter
            // 
            this.membresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 468);
            this.Controls.Add(this.k);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMembre";
            this.Text = "FrmMembre";
            this.Load += new System.EventHandler(this.FrmMembre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox k;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MutualiterDataSet5 mutualiterDataSet5;
        private System.Windows.Forms.BindingSource membresBindingSource;
        private MutualiterDataSet5TableAdapters.MembresTableAdapter membresTableAdapter;
    }
}