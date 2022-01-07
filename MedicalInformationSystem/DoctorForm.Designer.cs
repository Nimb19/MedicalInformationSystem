namespace MedicalInformationSystem
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.ColumnReqId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFlightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTicketsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOrderClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDateClose = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDateCreated = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAirplaneId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericOrderId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelOrdersCount = new System.Windows.Forms.Label();
            this.labelCompetedOrdersCount = new System.Windows.Forms.Label();
            this.labelOrdersOnWork = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.buttonSendDirectQuery = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.listBoxDirectQueryResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrderId)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Таблица заказов:";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnReqId,
            this.ColumnClinet,
            this.ColumnFlightId,
            this.ColumnTicketsCount,
            this.ColumnTotalPrice,
            this.ColumnDateOrderClosed,
            this.ColumnDateReq});
            this.dgvOrders.Location = new System.Drawing.Point(12, 36);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(774, 496);
            this.dgvOrders.TabIndex = 34;
            // 
            // ColumnReqId
            // 
            this.ColumnReqId.Frozen = true;
            this.ColumnReqId.HeaderText = "Id";
            this.ColumnReqId.Name = "ColumnReqId";
            this.ColumnReqId.ReadOnly = true;
            this.ColumnReqId.Width = 45;
            // 
            // ColumnClinet
            // 
            this.ColumnClinet.Frozen = true;
            this.ColumnClinet.HeaderText = "Имя/фамилия клиента";
            this.ColumnClinet.Name = "ColumnClinet";
            this.ColumnClinet.ReadOnly = true;
            this.ColumnClinet.Width = 150;
            // 
            // ColumnFlightId
            // 
            this.ColumnFlightId.Frozen = true;
            this.ColumnFlightId.HeaderText = "Название модели";
            this.ColumnFlightId.Name = "ColumnFlightId";
            this.ColumnFlightId.ReadOnly = true;
            this.ColumnFlightId.Width = 150;
            // 
            // ColumnTicketsCount
            // 
            this.ColumnTicketsCount.Frozen = true;
            this.ColumnTicketsCount.HeaderText = "Кол-во";
            this.ColumnTicketsCount.Name = "ColumnTicketsCount";
            this.ColumnTicketsCount.ReadOnly = true;
            this.ColumnTicketsCount.Width = 70;
            // 
            // ColumnTotalPrice
            // 
            this.ColumnTotalPrice.Frozen = true;
            this.ColumnTotalPrice.HeaderText = "Оплачено";
            this.ColumnTotalPrice.Name = "ColumnTotalPrice";
            this.ColumnTotalPrice.ReadOnly = true;
            // 
            // ColumnDateOrderClosed
            // 
            this.ColumnDateOrderClosed.Frozen = true;
            this.ColumnDateOrderClosed.HeaderText = "Дата выдачи";
            this.ColumnDateOrderClosed.Name = "ColumnDateOrderClosed";
            this.ColumnDateOrderClosed.ReadOnly = true;
            // 
            // ColumnDateReq
            // 
            this.ColumnDateReq.Frozen = true;
            this.ColumnDateReq.HeaderText = "Дата покупки";
            this.ColumnDateReq.Name = "ColumnDateReq";
            this.ColumnDateReq.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxDateClose);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxDateCreated);
            this.panel1.Controls.Add(this.textBoxTotalPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxAirplaneId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxUserId);
            this.panel1.Location = new System.Drawing.Point(12, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 94);
            this.panel1.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(369, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Время завершения заказа:";
            // 
            // textBoxDateClose
            // 
            this.textBoxDateClose.Location = new System.Drawing.Point(601, 52);
            this.textBoxDateClose.Name = "textBoxDateClose";
            this.textBoxDateClose.Size = new System.Drawing.Size(152, 27);
            this.textBoxDateClose.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Время создания заказа:";
            // 
            // textBoxDateCreated
            // 
            this.textBoxDateCreated.Location = new System.Drawing.Point(220, 52);
            this.textBoxDateCreated.Name = "textBoxDateCreated";
            this.textBoxDateCreated.Size = new System.Drawing.Size(133, 27);
            this.textBoxDateCreated.TabIndex = 48;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(599, 13);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(154, 27);
            this.textBoxTotalPrice.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(493, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Оплачено:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(440, 13);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(47, 27);
            this.textBoxCount.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(334, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Количество:";
            // 
            // textBoxAirplaneId
            // 
            this.textBoxAirplaneId.Location = new System.Drawing.Point(281, 13);
            this.textBoxAirplaneId.Name = "textBoxAirplaneId";
            this.textBoxAirplaneId.Size = new System.Drawing.Size(47, 27);
            this.textBoxAirplaneId.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(179, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Id модели:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Id клиента:";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(116, 13);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(47, 27);
            this.textBoxUserId.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Редактировать информацию о заказе с Id:";
            // 
            // numericOrderId
            // 
            this.numericOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericOrderId.Location = new System.Drawing.Point(371, 560);
            this.numericOrderId.Name = "numericOrderId";
            this.numericOrderId.Size = new System.Drawing.Size(72, 27);
            this.numericOrderId.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 592);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "(Что бы не менять значение, оставьте его пустым)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 49);
            this.button1.TabIndex = 45;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelHello
            // 
            this.labelHello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHello.Location = new System.Drawing.Point(803, 10);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(415, 60);
            this.labelHello.TabIndex = 46;
            this.labelHello.Text = "Приветствуем Вас, @@FULLNAME@@!";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(803, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 33);
            this.label10.TabIndex = 47;
            this.label10.Text = "Количество заказов:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(803, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 33);
            this.label11.TabIndex = 48;
            this.label11.Text = "Выдано заказов:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(803, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 33);
            this.label12.TabIndex = 49;
            this.label12.Text = "В работе:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.Location = new System.Drawing.Point(1045, 676);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(182, 33);
            this.labelDate.TabIndex = 51;
            this.labelDate.Text = "@@CURRENTDATE@@";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Location = new System.Drawing.Point(803, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 33);
            this.label14.TabIndex = 50;
            this.label14.Text = "Общая сумма";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrdersCount
            // 
            this.labelOrdersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrdersCount.Location = new System.Drawing.Point(1036, 81);
            this.labelOrdersCount.Name = "labelOrdersCount";
            this.labelOrdersCount.Size = new System.Drawing.Size(182, 33);
            this.labelOrdersCount.TabIndex = 52;
            this.labelOrdersCount.Text = "@@ORDERSCOUNT@@";
            this.labelOrdersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompetedOrdersCount
            // 
            this.labelCompetedOrdersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompetedOrdersCount.Location = new System.Drawing.Point(1036, 122);
            this.labelCompetedOrdersCount.Name = "labelCompetedOrdersCount";
            this.labelCompetedOrdersCount.Size = new System.Drawing.Size(182, 33);
            this.labelCompetedOrdersCount.TabIndex = 53;
            this.labelCompetedOrdersCount.Text = "@@ORDERSCOUNT@@";
            this.labelCompetedOrdersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrdersOnWork
            // 
            this.labelOrdersOnWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrdersOnWork.Location = new System.Drawing.Point(1036, 164);
            this.labelOrdersOnWork.Name = "labelOrdersOnWork";
            this.labelOrdersOnWork.Size = new System.Drawing.Size(182, 33);
            this.labelOrdersOnWork.TabIndex = 54;
            this.labelOrdersOnWork.Text = "@@ORDERSCOUNT@@";
            this.labelOrdersOnWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalTime.Location = new System.Drawing.Point(1036, 206);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(182, 33);
            this.labelTotalTime.TabIndex = 55;
            this.labelTotalTime.Text = "@@ORDERSCOUNT@@";
            this.labelTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSendDirectQuery
            // 
            this.buttonSendDirectQuery.Location = new System.Drawing.Point(7, 120);
            this.buttonSendDirectQuery.Name = "buttonSendDirectQuery";
            this.buttonSendDirectQuery.Size = new System.Drawing.Size(399, 31);
            this.buttonSendDirectQuery.TabIndex = 56;
            this.buttonSendDirectQuery.Text = "Отправить запрос";
            this.buttonSendDirectQuery.UseVisualStyleBackColor = true;
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(7, 35);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(399, 79);
            this.textBoxQuery.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(310, 21);
            this.label13.TabIndex = 57;
            this.label13.Text = "Направить прямой запрос T-SQL в БД:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.listBoxDirectQueryResult);
            this.panel2.Controls.Add(this.buttonSendDirectQuery);
            this.panel2.Controls.Add(this.textBoxQuery);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(807, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 421);
            this.panel2.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 21);
            this.label15.TabIndex = 59;
            this.label15.Text = "Результаты";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxDirectQueryResult
            // 
            this.listBoxDirectQueryResult.FormattingEnabled = true;
            this.listBoxDirectQueryResult.ItemHeight = 21;
            this.listBoxDirectQueryResult.Location = new System.Drawing.Point(7, 201);
            this.listBoxDirectQueryResult.Name = "listBoxDirectQueryResult";
            this.listBoxDirectQueryResult.Size = new System.Drawing.Size(399, 214);
            this.listBoxDirectQueryResult.TabIndex = 58;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 718);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelOrdersOnWork);
            this.Controls.Add(this.labelCompetedOrdersCount);
            this.Controls.Add(this.labelOrdersCount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericOrderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrderId)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReqId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTicketsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOrderClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateReq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.NumericUpDown numericOrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAirplaneId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDateClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDateCreated;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelOrdersCount;
        private System.Windows.Forms.Label labelCompetedOrdersCount;
        private System.Windows.Forms.Label labelOrdersOnWork;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Button buttonSendDirectQuery;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBoxDirectQueryResult;
    }
}