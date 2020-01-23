namespace Hitech.GUI
{
    partial class FormLogin
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
            this.checkBoxShowHide = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelHiteck = new System.Windows.Forms.Label();
            this.linkLabelChPass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // checkBoxShowHide
            // 
            this.checkBoxShowHide.AutoSize = true;
            this.checkBoxShowHide.Location = new System.Drawing.Point(253, 131);
            this.checkBoxShowHide.Name = "checkBoxShowHide";
            this.checkBoxShowHide.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowHide.TabIndex = 3;
            this.checkBoxShowHide.Text = "Show Password";
            this.checkBoxShowHide.UseVisualStyleBackColor = true;
            this.checkBoxShowHide.CheckedChanged += new System.EventHandler(this.checkBoxShowHide_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(136, 127);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(237, 205);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(139, 58);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(76, 23);
            this.labelWelcome.TabIndex = 21;
            this.labelWelcome.Text = "Welcome";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(139, 206);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(133, 112);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 20;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Location = new System.Drawing.Point(7, 112);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(67, 13);
            this.labelEmpID.TabIndex = 19;
            this.labelEmpID.Text = "Employee ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(10, 128);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(43, 205);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHiteck
            // 
            this.labelHiteck.AutoSize = true;
            this.labelHiteck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHiteck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHiteck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHiteck.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHiteck.Location = new System.Drawing.Point(67, 14);
            this.labelHiteck.Name = "labelHiteck";
            this.labelHiteck.Size = new System.Drawing.Size(220, 31);
            this.labelHiteck.TabIndex = 15;
            this.labelHiteck.Text = "Hi-Teck Distribution Inc.";
            // 
            // linkLabelChPass
            // 
            this.linkLabelChPass.AutoSize = true;
            this.linkLabelChPass.Location = new System.Drawing.Point(143, 161);
            this.linkLabelChPass.Name = "linkLabelChPass";
            this.linkLabelChPass.Size = new System.Drawing.Size(93, 13);
            this.linkLabelChPass.TabIndex = 22;
            this.linkLabelChPass.TabStop = true;
            this.linkLabelChPass.Text = "Change Password";
            this.linkLabelChPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChPass_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 246);
            this.Controls.Add(this.linkLabelChPass);
            this.Controls.Add(this.checkBoxShowHide);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmpID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelHiteck);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowHide;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelHiteck;
        private System.Windows.Forms.LinkLabel linkLabelChPass;
    }
}