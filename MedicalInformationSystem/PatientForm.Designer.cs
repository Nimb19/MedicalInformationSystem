namespace MedicalInformationSystem
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.buttonAllWorkingMedics = new System.Windows.Forms.Button();
            this.buttonSelectMedics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxRank = new System.Windows.Forms.CheckBox();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAcademicDegree = new System.Windows.Forms.CheckBox();
            this.comboBoxAcademicDegree = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxMinimumExperiensYears = new System.Windows.Forms.CheckBox();
            this.checkBoxSuccessOperationsCount = new System.Windows.Forms.CheckBox();
            this.checkBoxMedicsProfile = new System.Windows.Forms.CheckBox();
            this.checkBoxMedicalInstitute = new System.Windows.Forms.CheckBox();
            this.checkBoxPlace = new System.Windows.Forms.CheckBox();
            this.numericUpDownMinimumExperiensYears = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownSuccessOperationsCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMedicalInstitions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.comboBoxMedicsProfile = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.общееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТекстовыеРедакторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиСФормыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзУчётнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиСПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияПоПриложениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumExperiensYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuccessOperationsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAllWorkingMedics
            // 
            this.buttonAllWorkingMedics.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllWorkingMedics.Location = new System.Drawing.Point(29, 36);
            this.buttonAllWorkingMedics.Name = "buttonAllWorkingMedics";
            this.buttonAllWorkingMedics.Size = new System.Drawing.Size(377, 69);
            this.buttonAllWorkingMedics.TabIndex = 28;
            this.buttonAllWorkingMedics.Text = "Получить полный список работающего мед. персонала корпорации";
            this.buttonAllWorkingMedics.UseVisualStyleBackColor = true;
            // 
            // buttonSelectMedics
            // 
            this.buttonSelectMedics.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectMedics.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectMedics.Name = "buttonSelectMedics";
            this.buttonSelectMedics.Size = new System.Drawing.Size(368, 64);
            this.buttonSelectMedics.TabIndex = 29;
            this.buttonSelectMedics.Text = "Получить мед. персонал по указанным параметрам";
            this.buttonSelectMedics.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxRank);
            this.panel1.Controls.Add(this.comboBoxRank);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkBoxAcademicDegree);
            this.panel1.Controls.Add(this.comboBoxAcademicDegree);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkBoxMinimumExperiensYears);
            this.panel1.Controls.Add(this.checkBoxSuccessOperationsCount);
            this.panel1.Controls.Add(this.checkBoxMedicsProfile);
            this.panel1.Controls.Add(this.checkBoxMedicalInstitute);
            this.panel1.Controls.Add(this.checkBoxPlace);
            this.panel1.Controls.Add(this.numericUpDownMinimumExperiensYears);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDownSuccessOperationsCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxMedicalInstitions);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxPlace);
            this.panel1.Controls.Add(this.comboBoxMedicsProfile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSelectMedics);
            this.panel1.Location = new System.Drawing.Point(29, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 549);
            this.panel1.TabIndex = 30;
            // 
            // checkBoxRank
            // 
            this.checkBoxRank.AutoSize = true;
            this.checkBoxRank.Location = new System.Drawing.Point(339, 482);
            this.checkBoxRank.Name = "checkBoxRank";
            this.checkBoxRank.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRank.TabIndex = 51;
            this.checkBoxRank.UseVisualStyleBackColor = true;
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Location = new System.Drawing.Point(37, 499);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(317, 28);
            this.comboBoxRank.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Звание мед. персонала:";
            // 
            // checkBoxAcademicDegree
            // 
            this.checkBoxAcademicDegree.AutoSize = true;
            this.checkBoxAcademicDegree.Location = new System.Drawing.Point(339, 416);
            this.checkBoxAcademicDegree.Name = "checkBoxAcademicDegree";
            this.checkBoxAcademicDegree.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAcademicDegree.TabIndex = 48;
            this.checkBoxAcademicDegree.UseVisualStyleBackColor = true;
            // 
            // comboBoxAcademicDegree
            // 
            this.comboBoxAcademicDegree.FormattingEnabled = true;
            this.comboBoxAcademicDegree.Location = new System.Drawing.Point(37, 433);
            this.comboBoxAcademicDegree.Name = "comboBoxAcademicDegree";
            this.comboBoxAcademicDegree.Size = new System.Drawing.Size(317, 28);
            this.comboBoxAcademicDegree.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Научная степень мед. персонала:";
            // 
            // checkBoxMinimumExperiensYears
            // 
            this.checkBoxMinimumExperiensYears.AutoSize = true;
            this.checkBoxMinimumExperiensYears.Location = new System.Drawing.Point(339, 350);
            this.checkBoxMinimumExperiensYears.Name = "checkBoxMinimumExperiensYears";
            this.checkBoxMinimumExperiensYears.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMinimumExperiensYears.TabIndex = 45;
            this.checkBoxMinimumExperiensYears.UseVisualStyleBackColor = true;
            // 
            // checkBoxSuccessOperationsCount
            // 
            this.checkBoxSuccessOperationsCount.AutoSize = true;
            this.checkBoxSuccessOperationsCount.Location = new System.Drawing.Point(339, 284);
            this.checkBoxSuccessOperationsCount.Name = "checkBoxSuccessOperationsCount";
            this.checkBoxSuccessOperationsCount.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSuccessOperationsCount.TabIndex = 44;
            this.checkBoxSuccessOperationsCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedicsProfile
            // 
            this.checkBoxMedicsProfile.AutoSize = true;
            this.checkBoxMedicsProfile.Location = new System.Drawing.Point(339, 221);
            this.checkBoxMedicsProfile.Name = "checkBoxMedicsProfile";
            this.checkBoxMedicsProfile.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMedicsProfile.TabIndex = 43;
            this.checkBoxMedicsProfile.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedicalInstitute
            // 
            this.checkBoxMedicalInstitute.AutoSize = true;
            this.checkBoxMedicalInstitute.Checked = true;
            this.checkBoxMedicalInstitute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMedicalInstitute.Location = new System.Drawing.Point(339, 153);
            this.checkBoxMedicalInstitute.Name = "checkBoxMedicalInstitute";
            this.checkBoxMedicalInstitute.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMedicalInstitute.TabIndex = 42;
            this.checkBoxMedicalInstitute.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlace
            // 
            this.checkBoxPlace.AutoSize = true;
            this.checkBoxPlace.Checked = true;
            this.checkBoxPlace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlace.Location = new System.Drawing.Point(174, 81);
            this.checkBoxPlace.Name = "checkBoxPlace";
            this.checkBoxPlace.Size = new System.Drawing.Size(190, 24);
            this.checkBoxPlace.TabIndex = 41;
            this.checkBoxPlace.Text = "(Учитывать в запросе)";
            this.checkBoxPlace.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMinimumExperiensYears
            // 
            this.numericUpDownMinimumExperiensYears.Location = new System.Drawing.Point(37, 369);
            this.numericUpDownMinimumExperiensYears.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMinimumExperiensYears.Name = "numericUpDownMinimumExperiensYears";
            this.numericUpDownMinimumExperiensYears.Size = new System.Drawing.Size(317, 26);
            this.numericUpDownMinimumExperiensYears.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Минимальный стаж работы (кол-во лет):";
            // 
            // numericUpDownSuccessOperationsCount
            // 
            this.numericUpDownSuccessOperationsCount.Location = new System.Drawing.Point(37, 303);
            this.numericUpDownSuccessOperationsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSuccessOperationsCount.Name = "numericUpDownSuccessOperationsCount";
            this.numericUpDownSuccessOperationsCount.Size = new System.Drawing.Size(317, 26);
            this.numericUpDownSuccessOperationsCount.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Количество успешных операций:";
            // 
            // comboBoxMedicalInstitions
            // 
            this.comboBoxMedicalInstitions.FormattingEnabled = true;
            this.comboBoxMedicalInstitions.Location = new System.Drawing.Point(37, 172);
            this.comboBoxMedicalInstitions.Name = "comboBoxMedicalInstitions";
            this.comboBoxMedicalInstitions.Size = new System.Drawing.Size(317, 28);
            this.comboBoxMedicalInstitions.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Медицинское учреждение:";
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Location = new System.Drawing.Point(37, 105);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(317, 28);
            this.comboBoxPlace.TabIndex = 34;
            this.comboBoxPlace.TextChanged += new System.EventHandler(this.ComboBoxPlace_TextChanged);
            // 
            // comboBoxMedicsProfile
            // 
            this.comboBoxMedicsProfile.FormattingEnabled = true;
            this.comboBoxMedicsProfile.Location = new System.Drawing.Point(37, 238);
            this.comboBoxMedicsProfile.Name = "comboBoxMedicsProfile";
            this.comboBoxMedicsProfile.Size = new System.Drawing.Size(317, 28);
            this.comboBoxMedicsProfile.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Профиль мед. персонала:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Город/посёлок:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(435, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(854, 640);
            this.dataGridView.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееToolStripMenuItem,
            this.информацияПоПриложениюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // общееToolStripMenuItem
            // 
            this.общееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьТекстовыеРедакторыToolStripMenuItem,
            this.выйтиСФормыToolStripMenuItem,
            this.выйтиИзУчётнойЗаписиToolStripMenuItem,
            this.выйтиСПриложенияToolStripMenuItem});
            this.общееToolStripMenuItem.Name = "общееToolStripMenuItem";
            this.общееToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.общееToolStripMenuItem.Text = "Общее";
            // 
            // обновитьТекстовыеРедакторыToolStripMenuItem
            // 
            this.обновитьТекстовыеРедакторыToolStripMenuItem.Name = "обновитьТекстовыеРедакторыToolStripMenuItem";
            this.обновитьТекстовыеРедакторыToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.обновитьТекстовыеРедакторыToolStripMenuItem.Text = "Обновить значения в текстовых редакторах";
            this.обновитьТекстовыеРедакторыToolStripMenuItem.Click += new System.EventHandler(this.ОбновитьТекстовыеРедакторыToolStripMenuItem_Click);
            // 
            // выйтиСФормыToolStripMenuItem
            // 
            this.выйтиСФормыToolStripMenuItem.Name = "выйтиСФормыToolStripMenuItem";
            this.выйтиСФормыToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.выйтиСФормыToolStripMenuItem.Text = "Выйти с формы";
            this.выйтиСФормыToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиСФормыToolStripMenuItem_Click);
            // 
            // выйтиИзУчётнойЗаписиToolStripMenuItem
            // 
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Name = "выйтиИзУчётнойЗаписиToolStripMenuItem";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Text = "Выйти из учётной записи";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиИзУчётнойЗаписиToolStripMenuItem_Click);
            // 
            // выйтиСПриложенияToolStripMenuItem
            // 
            this.выйтиСПриложенияToolStripMenuItem.Name = "выйтиСПриложенияToolStripMenuItem";
            this.выйтиСПриложенияToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.выйтиСПриложенияToolStripMenuItem.Text = "Выйти с приложения";
            this.выйтиСПриложенияToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиСПриложенияToolStripMenuItem_Click);
            // 
            // информацияПоПриложениюToolStripMenuItem
            // 
            this.информацияПоПриложениюToolStripMenuItem.Name = "информацияПоПриложениюToolStripMenuItem";
            this.информацияПоПриложениюToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.информацияПоПриложениюToolStripMenuItem.Text = "О приложении";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 688);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAllWorkingMedics);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о персонале";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumExperiensYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuccessOperationsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAllWorkingMedics;
        private System.Windows.Forms.Button buttonSelectMedics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMedicsProfile;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.ComboBox comboBoxMedicalInstitions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem общееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиСФормыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзУчётнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиСПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияПоПриложениюToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSuccessOperationsCount;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimumExperiensYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxPlace;
        private System.Windows.Forms.CheckBox checkBoxMedicalInstitute;
        private System.Windows.Forms.CheckBox checkBoxMedicsProfile;
        private System.Windows.Forms.CheckBox checkBoxMinimumExperiensYears;
        private System.Windows.Forms.CheckBox checkBoxSuccessOperationsCount;
        private System.Windows.Forms.CheckBox checkBoxRank;
        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxAcademicDegree;
        private System.Windows.Forms.ComboBox comboBoxAcademicDegree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem обновитьТекстовыеРедакторыToolStripMenuItem;
    }
}