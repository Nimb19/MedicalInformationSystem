namespace MedicalInformationSystem
{
    partial class MyApointmentsInDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyApointmentsInDetailsForm));
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.ColumnFlightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTicketsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFlightId,
            this.ColumnHospital,
            this.ColumnTicketsCount,
            this.ColumnDateReq,
            this.ColumnPrice,
            this.ColumnDescription});
            this.dgvAppointments.Location = new System.Drawing.Point(12, 12);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.Size = new System.Drawing.Size(1068, 789);
            this.dgvAppointments.TabIndex = 27;
            // 
            // ColumnFlightId
            // 
            this.ColumnFlightId.Frozen = true;
            this.ColumnFlightId.HeaderText = "Фамилия/имя доктора";
            this.ColumnFlightId.Name = "ColumnFlightId";
            this.ColumnFlightId.ReadOnly = true;
            this.ColumnFlightId.Width = 203;
            // 
            // ColumnHospital
            // 
            this.ColumnHospital.Frozen = true;
            this.ColumnHospital.HeaderText = "Больница";
            this.ColumnHospital.Name = "ColumnHospital";
            this.ColumnHospital.ReadOnly = true;
            this.ColumnHospital.Width = 220;
            // 
            // ColumnTicketsCount
            // 
            this.ColumnTicketsCount.Frozen = true;
            this.ColumnTicketsCount.HeaderText = "Кабинет";
            this.ColumnTicketsCount.Name = "ColumnTicketsCount";
            this.ColumnTicketsCount.ReadOnly = true;
            // 
            // ColumnDateReq
            // 
            this.ColumnDateReq.Frozen = true;
            this.ColumnDateReq.HeaderText = "Дата приёма";
            this.ColumnDateReq.Name = "ColumnDateReq";
            this.ColumnDateReq.ReadOnly = true;
            this.ColumnDateReq.Width = 160;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.Frozen = true;
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 120;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.Frozen = true;
            this.ColumnDescription.HeaderText = "Описание записи";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Width = 220;
            // 
            // MyApointmentsInDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 813);
            this.Controls.Add(this.dgvAppointments);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MyApointmentsInDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробности о незакрытых записях";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTicketsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
    }
}