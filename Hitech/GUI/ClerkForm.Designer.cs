namespace Hitech.GUI
{
    partial class ClerkForm
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
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.buttonGenerateOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.comboBoxIsbn = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonListOrder = new System.Windows.Forms.Button();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelLine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxOrderId = new System.Windows.Forms.ComboBox();
            this.labelOrderId2 = new System.Windows.Forms.Label();
            this.listViewOrderLine = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOrder
            // 
            this.listViewOrder.BackColor = System.Drawing.Color.Teal;
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.column7});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(46, 220);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(529, 130);
            this.listViewOrder.TabIndex = 6;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // column1
            // 
            this.column1.Text = "Order ID";
            this.column1.Width = 61;
            // 
            // column2
            // 
            this.column2.Text = "Customer ID";
            this.column2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column2.Width = 71;
            // 
            // column3
            // 
            this.column3.Text = "Employee ID";
            this.column3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column3.Width = 75;
            // 
            // column4
            // 
            this.column4.Text = "Order Date";
            this.column4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column4.Width = 69;
            // 
            // column5
            // 
            this.column5.Text = "Updated Date";
            this.column5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column5.Width = 80;
            // 
            // column6
            // 
            this.column6.Text = "Required Date";
            this.column6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column6.Width = 81;
            // 
            // column7
            // 
            this.column7.Text = "Shipping Date";
            this.column7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column7.Width = 81;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(229, 58);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 37);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete  Order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(229, 101);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(75, 37);
            this.buttonUpdateOrder.TabIndex = 6;
            this.buttonUpdateOrder.Text = "Update Order";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // buttonGenerateOrder
            // 
            this.buttonGenerateOrder.Location = new System.Drawing.Point(229, 13);
            this.buttonGenerateOrder.Name = "buttonGenerateOrder";
            this.buttonGenerateOrder.Size = new System.Drawing.Size(75, 37);
            this.buttonGenerateOrder.TabIndex = 4;
            this.buttonGenerateOrder.Text = "Generate Order";
            this.buttonGenerateOrder.UseVisualStyleBackColor = true;
            this.buttonGenerateOrder.Click += new System.EventHandler(this.buttonGenerateOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Required Date";
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(6, 93);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomerId.TabIndex = 2;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(6, 77);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(63, 13);
            this.labelCustomerId.TabIndex = 36;
            this.labelCustomerId.Text = "Customer Id";
            this.labelCustomerId.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxIsbn
            // 
            this.comboBoxIsbn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxIsbn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxIsbn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsbn.FormattingEnabled = true;
            this.comboBoxIsbn.Location = new System.Drawing.Point(15, 87);
            this.comboBoxIsbn.Name = "comboBoxIsbn";
            this.comboBoxIsbn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIsbn.TabIndex = 9;
            this.comboBoxIsbn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerRequiredDate
            // 
            this.dateTimePickerRequiredDate.Location = new System.Drawing.Point(6, 151);
            this.dateTimePickerRequiredDate.Name = "dateTimePickerRequiredDate";
            this.dateTimePickerRequiredDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRequiredDate.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonListOrder);
            this.groupBox1.Controls.Add(this.labelOrderId);
            this.groupBox1.Controls.Add(this.textBoxOrderId);
            this.groupBox1.Controls.Add(this.comboBoxCustomerId);
            this.groupBox1.Controls.Add(this.labelCustomerId);
            this.groupBox1.Controls.Add(this.buttonUpdateOrder);
            this.groupBox1.Controls.Add(this.dateTimePickerRequiredDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonGenerateOrder);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 200);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Info";
            // 
            // buttonListOrder
            // 
            this.buttonListOrder.Location = new System.Drawing.Point(229, 145);
            this.buttonListOrder.Name = "buttonListOrder";
            this.buttonListOrder.Size = new System.Drawing.Size(75, 37);
            this.buttonListOrder.TabIndex = 7;
            this.buttonListOrder.Text = "List\r\nOrder";
            this.buttonListOrder.UseVisualStyleBackColor = true;
            this.buttonListOrder.Click += new System.EventHandler(this.buttonListOrder_Click);
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Location = new System.Drawing.Point(6, 27);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(47, 13);
            this.labelOrderId.TabIndex = 40;
            this.labelOrderId.Text = "Order ID";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(6, 43);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderId.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDelLine);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonUpdateItem);
            this.groupBox2.Controls.Add(this.buttonAddItem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.comboBoxOrderId);
            this.groupBox2.Controls.Add(this.labelOrderId2);
            this.groupBox2.Controls.Add(this.comboBoxIsbn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 197);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Line Info";
            // 
            // buttonDelLine
            // 
            this.buttonDelLine.Location = new System.Drawing.Point(180, 58);
            this.buttonDelLine.Name = "buttonDelLine";
            this.buttonDelLine.Size = new System.Drawing.Size(75, 37);
            this.buttonDelLine.TabIndex = 12;
            this.buttonDelLine.Text = "Delete\r\nLine";
            this.buttonDelLine.UseVisualStyleBackColor = true;
            this.buttonDelLine.Click += new System.EventHandler(this.buttonDelLine_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show\r\nDetails";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Location = new System.Drawing.Point(180, 101);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(75, 37);
            this.buttonUpdateItem.TabIndex = 13;
            this.buttonUpdateItem.Text = "Update\r\nLine";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(180, 13);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 37);
            this.buttonAddItem.TabIndex = 11;
            this.buttonAddItem.Text = "Add To Order";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(18, 137);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // comboBoxOrderId
            // 
            this.comboBoxOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderId.FormattingEnabled = true;
            this.comboBoxOrderId.Location = new System.Drawing.Point(15, 41);
            this.comboBoxOrderId.Name = "comboBoxOrderId";
            this.comboBoxOrderId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrderId.TabIndex = 8;
            this.comboBoxOrderId.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderId_SelectedIndexChanged);
            // 
            // labelOrderId2
            // 
            this.labelOrderId2.AutoSize = true;
            this.labelOrderId2.Location = new System.Drawing.Point(15, 25);
            this.labelOrderId2.Name = "labelOrderId2";
            this.labelOrderId2.Size = new System.Drawing.Size(47, 13);
            this.labelOrderId2.TabIndex = 42;
            this.labelOrderId2.Text = "Order ID";
            // 
            // listViewOrderLine
            // 
            this.listViewOrderLine.BackColor = System.Drawing.Color.Teal;
            this.listViewOrderLine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOrderLine.FullRowSelect = true;
            this.listViewOrderLine.GridLines = true;
            this.listViewOrderLine.Location = new System.Drawing.Point(156, 364);
            this.listViewOrderLine.Name = "listViewOrderLine";
            this.listViewOrderLine.Size = new System.Drawing.Size(309, 130);
            this.listViewOrderLine.TabIndex = 41;
            this.listViewOrderLine.UseCompatibleStateImageBehavior = false;
            this.listViewOrderLine.View = System.Windows.Forms.View.Details;
            this.listViewOrderLine.SelectedIndexChanged += new System.EventHandler(this.listViewOrderLine_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Book Title";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // ClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 506);
            this.Controls.Add(this.listViewOrderLine);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ClerkForm";
            this.Text = "ClerkForm";
            this.Load += new System.EventHandler(this.ClerkForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.ColumnHeader column3;
        private System.Windows.Forms.ColumnHeader column4;
        private System.Windows.Forms.ColumnHeader column5;
        private System.Windows.Forms.ColumnHeader column6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Button buttonGenerateOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.ComboBox comboBoxIsbn;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequiredDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxOrderId;
        private System.Windows.Forms.Label labelOrderId2;
        private System.Windows.Forms.Button buttonListOrder;
        private System.Windows.Forms.ColumnHeader column7;
        private System.Windows.Forms.ListView listViewOrderLine;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDelLine;
    }
}