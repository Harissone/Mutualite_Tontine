namespace Tontine.WinForm
{
    partial class FrmInfoMeettings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMeetingList = new System.Windows.Forms.Label();
            this.mutualiterDataSet3 = new Tontine.WinForm.MutualiterDataSet3();
            this.reunionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reunionTableAdapter = new Tontine.WinForm.MutualiterDataSet3TableAdapters.ReunionTableAdapter();
            this.idreunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomreunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxcolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrememDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datereunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewMeeting = new System.Windows.Forms.Button();
            this.btnEditMeeting = new System.Windows.Forms.Button();
            this.btnDeleteMeeting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreunDataGridViewTextBoxColumn,
            this.nomreunDataGridViewTextBoxColumn,
            this.tauxcolDataGridViewTextBoxColumn,
            this.nbrememDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.datereunDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reunionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblMeetingList
            // 
            this.lblMeetingList.AutoSize = true;
            this.lblMeetingList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingList.ForeColor = System.Drawing.Color.White;
            this.lblMeetingList.Location = new System.Drawing.Point(32, 36);
            this.lblMeetingList.Name = "lblMeetingList";
            this.lblMeetingList.Size = new System.Drawing.Size(95, 19);
            this.lblMeetingList.TabIndex = 5;
            this.lblMeetingList.Text = "Meeting list";
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
            // idreunDataGridViewTextBoxColumn
            // 
            this.idreunDataGridViewTextBoxColumn.DataPropertyName = "id_reun";
            this.idreunDataGridViewTextBoxColumn.HeaderText = "id_reun";
            this.idreunDataGridViewTextBoxColumn.Name = "idreunDataGridViewTextBoxColumn";
            // 
            // nomreunDataGridViewTextBoxColumn
            // 
            this.nomreunDataGridViewTextBoxColumn.DataPropertyName = "nom_reun";
            this.nomreunDataGridViewTextBoxColumn.HeaderText = "nom_reun";
            this.nomreunDataGridViewTextBoxColumn.Name = "nomreunDataGridViewTextBoxColumn";
            // 
            // tauxcolDataGridViewTextBoxColumn
            // 
            this.tauxcolDataGridViewTextBoxColumn.DataPropertyName = "taux_col";
            this.tauxcolDataGridViewTextBoxColumn.HeaderText = "taux_col";
            this.tauxcolDataGridViewTextBoxColumn.Name = "tauxcolDataGridViewTextBoxColumn";
            // 
            // nbrememDataGridViewTextBoxColumn
            // 
            this.nbrememDataGridViewTextBoxColumn.DataPropertyName = "nbre_mem";
            this.nbrememDataGridViewTextBoxColumn.HeaderText = "nbre_mem";
            this.nbrememDataGridViewTextBoxColumn.Name = "nbrememDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // datereunDataGridViewTextBoxColumn
            // 
            this.datereunDataGridViewTextBoxColumn.DataPropertyName = "date_reun";
            this.datereunDataGridViewTextBoxColumn.HeaderText = "date_reun";
            this.datereunDataGridViewTextBoxColumn.Name = "datereunDataGridViewTextBoxColumn";
            // 
            // btnNewMeeting
            // 
            this.btnNewMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMeeting.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnNewMeeting.Location = new System.Drawing.Point(573, 67);
            this.btnNewMeeting.Name = "btnNewMeeting";
            this.btnNewMeeting.Size = new System.Drawing.Size(90, 36);
            this.btnNewMeeting.TabIndex = 6;
            this.btnNewMeeting.Text = "New meeting";
            this.btnNewMeeting.UseVisualStyleBackColor = true;
            this.btnNewMeeting.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnEditMeeting
            // 
            this.btnEditMeeting.BackColor = System.Drawing.Color.DimGray;
            this.btnEditMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMeeting.ForeColor = System.Drawing.Color.DeepPink;
            this.btnEditMeeting.Location = new System.Drawing.Point(573, 132);
            this.btnEditMeeting.Name = "btnEditMeeting";
            this.btnEditMeeting.Size = new System.Drawing.Size(90, 36);
            this.btnEditMeeting.TabIndex = 7;
            this.btnEditMeeting.Text = "Edit meeting";
            this.btnEditMeeting.UseVisualStyleBackColor = false;
            this.btnEditMeeting.Click += new System.EventHandler(this.btnEditMeeting_Click);
            // 
            // btnDeleteMeeting
            // 
            this.btnDeleteMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMeeting.ForeColor = System.Drawing.Color.Yellow;
            this.btnDeleteMeeting.Location = new System.Drawing.Point(573, 203);
            this.btnDeleteMeeting.Name = "btnDeleteMeeting";
            this.btnDeleteMeeting.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteMeeting.TabIndex = 8;
            this.btnDeleteMeeting.Text = "Delete meeting";
            this.btnDeleteMeeting.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(573, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmInfoMeettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(690, 393);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteMeeting);
            this.Controls.Add(this.btnEditMeeting);
            this.Controls.Add(this.btnNewMeeting);
            this.Controls.Add(this.lblMeetingList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInfoMeettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInfoMeettings";
            this.Load += new System.EventHandler(this.FrmInfoMeettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutualiterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reunionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMeetingList;
        private MutualiterDataSet3 mutualiterDataSet3;
        private System.Windows.Forms.BindingSource reunionBindingSource;
        private MutualiterDataSet3TableAdapters.ReunionTableAdapter reunionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomreunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxcolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrememDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereunDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNewMeeting;
        private System.Windows.Forms.Button btnEditMeeting;
        private System.Windows.Forms.Button btnDeleteMeeting;
        private System.Windows.Forms.Button btnExit;
    }
}