namespace Tontine.WinForm
{
    partial class FrmEvent
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
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtContribution = new System.Windows.Forms.TextBox();
            this.lblContribution = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtTotalContribution = new System.Windows.Forms.TextBox();
            this.lblTotalContributions = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mutualiterDataSet4 = new Tontine.WinForm.MutualiterDataSet4();
            this.evenementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evenementTableAdapter = new Tontine.WinForm.MutualiterDataSet4TableAdapters.EvenementTableAdapter();
            this.txtDateEvenement = new System.Windows.Forms.TextBox();
            this.lblDateEvenement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.BackColor = System.Drawing.Color.White;
            this.txtIdentifier.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.evenementBindingSource, "id_eve", true));
            this.txtIdentifier.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifier.Location = new System.Drawing.Point(26, 73);
            this.txtIdentifier.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(184, 20);
            this.txtIdentifier.TabIndex = 0;
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifier.Location = new System.Drawing.Point(22, 45);
            this.lblIdentifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(75, 19);
            this.lblIdentifier.TabIndex = 29;
            this.lblIdentifier.Text = "Identifier";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.evenementBindingSource, "lieux", true));
            this.txtLocation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(25, 204);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(185, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(22, 178);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(76, 19);
            this.lblLocation.TabIndex = 27;
            this.lblLocation.Text = "Location";
            // 
            // txtContribution
            // 
            this.txtContribution.BackColor = System.Drawing.Color.White;
            this.txtContribution.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.evenementBindingSource, "taux", true));
            this.txtContribution.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContribution.Location = new System.Drawing.Point(252, 71);
            this.txtContribution.Margin = new System.Windows.Forms.Padding(2);
            this.txtContribution.Name = "txtContribution";
            this.txtContribution.Size = new System.Drawing.Size(185, 20);
            this.txtContribution.TabIndex = 2;
            // 
            // lblContribution
            // 
            this.lblContribution.AutoSize = true;
            this.lblContribution.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContribution.Location = new System.Drawing.Point(246, 45);
            this.lblContribution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContribution.Name = "lblContribution";
            this.lblContribution.Size = new System.Drawing.Size(179, 19);
            this.lblContribution.TabIndex = 25;
            this.lblContribution.Text = " Minimum contribution";
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.Color.White;
            this.txtEventName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEventName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.evenementBindingSource, "nom_eve", true));
            this.txtEventName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(26, 139);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(184, 20);
            this.txtEventName.TabIndex = 0;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(22, 111);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(99, 19);
            this.lblEventName.TabIndex = 23;
            this.lblEventName.Text = "Event name";
            // 
            // txtTotalContribution
            // 
            this.txtTotalContribution.BackColor = System.Drawing.Color.White;
            this.txtTotalContribution.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalContribution.Location = new System.Drawing.Point(250, 137);
            this.txtTotalContribution.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalContribution.Name = "txtTotalContribution";
            this.txtTotalContribution.Size = new System.Drawing.Size(185, 20);
            this.txtTotalContribution.TabIndex = 3;
            // 
            // lblTotalContributions
            // 
            this.lblTotalContributions.AutoSize = true;
            this.lblTotalContributions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContributions.Location = new System.Drawing.Point(247, 111);
            this.lblTotalContributions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalContributions.Name = "lblTotalContributions";
            this.lblTotalContributions.Size = new System.Drawing.Size(152, 19);
            this.lblTotalContributions.TabIndex = 31;
            this.lblTotalContributions.Text = "Total contributions";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCreate.Location = new System.Drawing.Point(26, 267);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(184, 34);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(250, 267);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mutualiterDataSet4;
            this.bindingSource1.Position = 0;
            // 
            // mutualiterDataSet4
            // 
            this.mutualiterDataSet4.DataSetName = "MutualiterDataSet4";
            this.mutualiterDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evenementBindingSource
            // 
            this.evenementBindingSource.DataMember = "Evenement";
            this.evenementBindingSource.DataSource = this.mutualiterDataSet4;
            // 
            // evenementTableAdapter
            // 
            this.evenementTableAdapter.ClearBeforeFill = true;
            // 
            // txtDateEvenement
            // 
            this.txtDateEvenement.BackColor = System.Drawing.Color.White;
            this.txtDateEvenement.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.evenementBindingSource, "date_eve", true));
            this.txtDateEvenement.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateEvenement.Location = new System.Drawing.Point(250, 204);
            this.txtDateEvenement.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateEvenement.Name = "txtDateEvenement";
            this.txtDateEvenement.Size = new System.Drawing.Size(185, 20);
            this.txtDateEvenement.TabIndex = 4;
            // 
            // lblDateEvenement
            // 
            this.lblDateEvenement.AutoSize = true;
            this.lblDateEvenement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEvenement.Location = new System.Drawing.Point(247, 178);
            this.lblDateEvenement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateEvenement.Name = "lblDateEvenement";
            this.lblDateEvenement.Size = new System.Drawing.Size(132, 19);
            this.lblDateEvenement.TabIndex = 35;
            this.lblDateEvenement.Text = "Date evenement";
            // 
            // FrmEvent
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(768, 325);
            this.Controls.Add(this.txtDateEvenement);
            this.Controls.Add(this.lblDateEvenement);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTotalContribution);
            this.Controls.Add(this.lblTotalContributions);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.lblIdentifier);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtContribution);
            this.Controls.Add(this.lblContribution);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.lblEventName);
            this.Name = "FrmEvent";
            this.Text = "FrmEvent";
            this.Load += new System.EventHandler(this.FrmEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtContribution;
        private System.Windows.Forms.Label lblContribution;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtTotalContribution;
        private System.Windows.Forms.Label lblTotalContributions;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MutualiterDataSet4 mutualiterDataSet4;
        private System.Windows.Forms.BindingSource evenementBindingSource;
        private MutualiterDataSet4TableAdapters.EvenementTableAdapter evenementTableAdapter;
        private System.Windows.Forms.TextBox txtDateEvenement;
        private System.Windows.Forms.Label lblDateEvenement;
    }
}