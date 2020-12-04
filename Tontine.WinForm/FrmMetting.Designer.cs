namespace Tontine.WinForm
{
    partial class FrmMetting
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
            this.txtNbreMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtMinimumContribution = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMetting = new System.Windows.Forms.TextBox();
            this.lblNomReunion = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mutualiterDataSet3 = new Tontine.WinForm.MutualiterDataSet3();
            this.reunionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reunionTableAdapter = new Tontine.WinForm.MutualiterDataSet3TableAdapters.ReunionTableAdapter();
            this.reunionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reunionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reunionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.reunionBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.reunionBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNbreMember
            // 
            this.txtNbreMember.BackColor = System.Drawing.Color.White;
            this.txtNbreMember.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reunionBindingSource, "nbre_mem", true));
            this.txtNbreMember.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbreMember.Location = new System.Drawing.Point(29, 248);
            this.txtNbreMember.Margin = new System.Windows.Forms.Padding(2);
            this.txtNbreMember.Name = "txtNbreMember";
            this.txtNbreMember.Size = new System.Drawing.Size(331, 20);
            this.txtNbreMember.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number of member";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(23, 368);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 19);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // txtMinimumContribution
            // 
            this.txtMinimumContribution.BackColor = System.Drawing.Color.White;
            this.txtMinimumContribution.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reunionBindingSource, "taux_col", true));
            this.txtMinimumContribution.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimumContribution.Location = new System.Drawing.Point(29, 186);
            this.txtMinimumContribution.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinimumContribution.Name = "txtMinimumContribution";
            this.txtMinimumContribution.Size = new System.Drawing.Size(331, 20);
            this.txtMinimumContribution.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCreate.Location = new System.Drawing.Point(26, 568);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 34);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minimum contribution";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(264, 568);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMetting
            // 
            this.txtMetting.BackColor = System.Drawing.Color.White;
            this.txtMetting.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reunionBindingSource, "nom_reun", true));
            this.txtMetting.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetting.Location = new System.Drawing.Point(27, 125);
            this.txtMetting.Margin = new System.Windows.Forms.Padding(2);
            this.txtMetting.Name = "txtMetting";
            this.txtMetting.Size = new System.Drawing.Size(333, 20);
            this.txtMetting.TabIndex = 1;
            // 
            // lblNomReunion
            // 
            this.lblNomReunion.AutoSize = true;
            this.lblNomReunion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomReunion.Location = new System.Drawing.Point(26, 97);
            this.lblNomReunion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomReunion.Name = "lblNomReunion";
            this.lblNomReunion.Size = new System.Drawing.Size(111, 19);
            this.lblNomReunion.TabIndex = 8;
            this.lblNomReunion.Text = "Metting name";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reunionBindingSource, "description", true));
            this.richTextBoxDescription.Location = new System.Drawing.Point(24, 400);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(333, 142);
            this.richTextBoxDescription.TabIndex = 5;
            this.richTextBoxDescription.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tontine.WinForm.Properties.Resources.logo_tontine_fond_noir;
            this.pictureBox1.Location = new System.Drawing.Point(422, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.BackColor = System.Drawing.Color.White;
            this.txtIdentifier.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reunionBindingSource, "id_reun", true));
            this.txtIdentifier.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifier.Location = new System.Drawing.Point(27, 68);
            this.txtIdentifier.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(333, 20);
            this.txtIdentifier.TabIndex = 0;
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifier.Location = new System.Drawing.Point(26, 40);
            this.lblIdentifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(75, 19);
            this.lblIdentifier.TabIndex = 21;
            this.lblIdentifier.Text = "Identifier";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(22, 287);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 19);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reunionBindingSource, "date_reun", true));
            this.txtDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(30, 325);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(331, 20);
            this.txtDate.TabIndex = 4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mutualiterDataSet3;
            this.bindingSource1.Position = 0;
            // 
            // mutualiterDataSet3
            // 
            this.mutualiterDataSet3.DataSetName = "MutualiterDataSet3";
            this.mutualiterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reunionBindingSource
            // 
            this.reunionBindingSource.DataMember = "Reunion";
            this.reunionBindingSource.DataSource = this.mutualiterDataSet3;
            // 
            // reunionTableAdapter
            // 
            this.reunionTableAdapter.ClearBeforeFill = true;
            // 
            // reunionBindingSource1
            // 
            this.reunionBindingSource1.DataMember = "Reunion";
            this.reunionBindingSource1.DataSource = this.mutualiterDataSet3;
            // 
            // reunionBindingSource2
            // 
            this.reunionBindingSource2.DataMember = "Reunion";
            this.reunionBindingSource2.DataSource = this.mutualiterDataSet3;
            // 
            // reunionBindingSource3
            // 
            this.reunionBindingSource3.DataMember = "Reunion";
            this.reunionBindingSource3.DataSource = this.mutualiterDataSet3;
            // 
            // reunionBindingSource4
            // 
            this.reunionBindingSource4.DataMember = "Reunion";
            this.reunionBindingSource4.DataSource = this.mutualiterDataSet3;
            // 
            // reunionBindingSource5
            // 
            this.reunionBindingSource5.DataMember = "Reunion";
            this.reunionBindingSource5.DataSource = this.mutualiterDataSet3;
            // 
            // FrmMetting
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.lblIdentifier);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.txtNbreMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtMinimumContribution);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMetting);
            this.Controls.Add(this.lblNomReunion);
            this.Name = "FrmMetting";
            this.Text = "FrmMetting";
            this.Load += new System.EventHandler(this.FrmMetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNbreMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtMinimumContribution;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMetting;
        private System.Windows.Forms.Label lblNomReunion;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private MutualiterDataSet3 mutualiterDataSet3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource reunionBindingSource;
        private MutualiterDataSet3TableAdapters.ReunionTableAdapter reunionTableAdapter;
        private System.Windows.Forms.BindingSource reunionBindingSource3;
        private System.Windows.Forms.BindingSource reunionBindingSource2;
        private System.Windows.Forms.BindingSource reunionBindingSource1;
        private System.Windows.Forms.BindingSource reunionBindingSource5;
        private System.Windows.Forms.BindingSource reunionBindingSource4;
    }
}