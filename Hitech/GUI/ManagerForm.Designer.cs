namespace Hitech.GUI
{
    partial class ManagerForm
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
            this.listViewCustomers = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonListCustomerDB = new System.Windows.Forms.Button();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelCustumerId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.buttonListCustomerDS = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCustomers
            // 
            this.listViewCustomers.BackColor = System.Drawing.Color.Teal;
            this.listViewCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.column7,
            this.column8});
            this.listViewCustomers.FullRowSelect = true;
            this.listViewCustomers.GridLines = true;
            this.listViewCustomers.Location = new System.Drawing.Point(0, 252);
            this.listViewCustomers.Name = "listViewCustomers";
            this.listViewCustomers.Size = new System.Drawing.Size(720, 130);
            this.listViewCustomers.TabIndex = 4;
            this.listViewCustomers.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers.View = System.Windows.Forms.View.Details;
            this.listViewCustomers.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            // 
            // column1
            // 
            this.column1.Text = "Customer ID";
            this.column1.Width = 75;
            // 
            // column2
            // 
            this.column2.Text = "Name";
            this.column2.Width = 116;
            // 
            // column3
            // 
            this.column3.Text = "Street";
            this.column3.Width = 150;
            // 
            // column4
            // 
            this.column4.Text = "City";
            this.column4.Width = 79;
            // 
            // column5
            // 
            this.column5.Text = "Postal Code";
            this.column5.Width = 71;
            // 
            // column6
            // 
            this.column6.Text = "Phone Number";
            this.column6.Width = 85;
            // 
            // column7
            // 
            this.column7.Text = "Fax Number";
            this.column7.Width = 72;
            // 
            // column8
            // 
            this.column8.Text = "Credit Limit";
            this.column8.Width = 67;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(626, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(626, 120);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(626, 84);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(626, 51);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonListCustomerDB
            // 
            this.buttonListCustomerDB.Location = new System.Drawing.Point(413, 26);
            this.buttonListCustomerDB.Name = "buttonListCustomerDB";
            this.buttonListCustomerDB.Size = new System.Drawing.Size(107, 48);
            this.buttonListCustomerDB.TabIndex = 9;
            this.buttonListCustomerDB.Text = "List Customers DB";
            this.buttonListCustomerDB.UseVisualStyleBackColor = true;
            this.buttonListCustomerDB.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.maskedTextBoxPostalCode);
            this.groupBoxCustomer.Controls.Add(this.maskedTextBoxFaxNumber);
            this.groupBoxCustomer.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.groupBoxCustomer.Controls.Add(this.labelPhoneNumber);
            this.groupBoxCustomer.Controls.Add(this.labelCustumerId);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerId);
            this.groupBoxCustomer.Controls.Add(this.labelCreditLimit);
            this.groupBoxCustomer.Controls.Add(this.labelPostalCode);
            this.groupBoxCustomer.Controls.Add(this.labelCity);
            this.groupBoxCustomer.Controls.Add(this.labelStreet);
            this.groupBoxCustomer.Controls.Add(this.labelPhone);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Controls.Add(this.textBoxCreditLimit);
            this.groupBoxCustomer.Controls.Add(this.textBoxCity);
            this.groupBoxCustomer.Controls.Add(this.textBoxStreet);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(395, 202);
            this.groupBoxCustomer.TabIndex = 24;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer Info";
            // 
            // maskedTextBoxPostalCode
            // 
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(239, 33);
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPostalCode.TabIndex = 5;
            // 
            // maskedTextBoxFaxNumber
            // 
            this.maskedTextBoxFaxNumber.Location = new System.Drawing.Point(239, 124);
            this.maskedTextBoxFaxNumber.Name = "maskedTextBoxFaxNumber";
            this.maskedTextBoxFaxNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFaxNumber.TabIndex = 7;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(239, 78);
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 6;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(239, 62);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 39;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelCustumerId
            // 
            this.labelCustumerId.AutoSize = true;
            this.labelCustumerId.Location = new System.Drawing.Point(9, 17);
            this.labelCustumerId.Name = "labelCustumerId";
            this.labelCustumerId.Size = new System.Drawing.Size(65, 13);
            this.labelCustumerId.TabIndex = 37;
            this.labelCustumerId.Text = "Custumer ID";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(9, 33);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(138, 20);
            this.textBoxCustomerId.TabIndex = 1;
            this.textBoxCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.AutoSize = true;
            this.labelCreditLimit.Location = new System.Drawing.Point(239, 150);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.Size = new System.Drawing.Size(58, 13);
            this.labelCreditLimit.TabIndex = 35;
            this.labelCreditLimit.Text = "Credit Limit";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(239, 17);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(64, 13);
            this.labelPostalCode.TabIndex = 34;
            this.labelPostalCode.Text = "Postal Code";
            this.labelPostalCode.Click += new System.EventHandler(this.labelPostalCode_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 153);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 33;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(9, 109);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 32;
            this.labelStreet.Text = "Street";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(239, 108);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(64, 13);
            this.labelPhone.TabIndex = 31;
            this.labelPhone.Text = "Fax Number";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(9, 62);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerName.TabIndex = 30;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(239, 166);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreditLimit.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(12, 166);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(9, 124);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(177, 20);
            this.textBoxStreet.TabIndex = 3;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(9, 78);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(138, 20);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // buttonListCustomerDS
            // 
            this.buttonListCustomerDS.Location = new System.Drawing.Point(413, 120);
            this.buttonListCustomerDS.Name = "buttonListCustomerDS";
            this.buttonListCustomerDS.Size = new System.Drawing.Size(107, 48);
            this.buttonListCustomerDS.TabIndex = 10;
            this.buttonListCustomerDS.Text = "List Customers DS";
            this.buttonListCustomerDS.UseVisualStyleBackColor = true;
            this.buttonListCustomerDS.Click += new System.EventHandler(this.buttonListCustomerDS_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(626, 155);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 383);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonListCustomerDS);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.buttonListCustomerDB);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.Text = "Customer Info";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewCustomers;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.ColumnHeader column3;
        private System.Windows.Forms.ColumnHeader column4;
        private System.Windows.Forms.ColumnHeader column5;
        private System.Windows.Forms.ColumnHeader column6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonListCustomerDB;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label labelCustumerId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label labelCreditLimit;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFaxNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.Button buttonListCustomerDS;
        private System.Windows.Forms.ColumnHeader column7;
        private System.Windows.Forms.ColumnHeader column8;
        private System.Windows.Forms.Button buttonExit;
    }
}