namespace MidtermProject
{
    partial class LoginPage
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnClearLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnConsumer = new System.Windows.Forms.RadioButton();
            this.radioBtnProducer = new System.Windows.Forms.RadioButton();
            this.btnToPassSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFactoryEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ttpLoginTextBoxes = new System.Windows.Forms.ToolTip(this.components);
            this.ttpButtonsOnLoginPage = new System.Windows.Forms.ToolTip(this.components);
            this.lblToPassWarehousesLogin = new System.Windows.Forms.Label();
            this.btnToPassWarehousesLogin = new System.Windows.Forms.Button();
            this.menuStripLoginPage = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItemForm = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            this.menuStripLoginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpLogin.Controls.Add(this.btnClearLogin);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.radioBtnConsumer);
            this.grpLogin.Controls.Add(this.radioBtnProducer);
            this.grpLogin.Controls.Add(this.btnToPassSignUp);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtFactoryEmail);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblEmail);
            this.grpLogin.Controls.Add(this.lblWelcome);
            this.grpLogin.Location = new System.Drawing.Point(572, 64);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(499, 507);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            // 
            // btnClearLogin
            // 
            this.btnClearLogin.BackColor = System.Drawing.Color.Thistle;
            this.btnClearLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearLogin.Location = new System.Drawing.Point(44, 433);
            this.btnClearLogin.Name = "btnClearLogin";
            this.btnClearLogin.Size = new System.Drawing.Size(147, 36);
            this.btnClearLogin.TabIndex = 10;
            this.btnClearLogin.Text = "&Clear";
            this.btnClearLogin.UseVisualStyleBackColor = false;
            this.btnClearLogin.Click += new System.EventHandler(this.btnClearLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Factory Type : ";
            // 
            // radioBtnConsumer
            // 
            this.radioBtnConsumer.AutoSize = true;
            this.radioBtnConsumer.Location = new System.Drawing.Point(352, 318);
            this.radioBtnConsumer.Name = "radioBtnConsumer";
            this.radioBtnConsumer.Size = new System.Drawing.Size(89, 20);
            this.radioBtnConsumer.TabIndex = 3;
            this.radioBtnConsumer.TabStop = true;
            this.radioBtnConsumer.Text = "Consumer";
            this.ttpLoginTextBoxes.SetToolTip(this.radioBtnConsumer, "Type Of The Factory");
            this.radioBtnConsumer.UseVisualStyleBackColor = true;
            // 
            // radioBtnProducer
            // 
            this.radioBtnProducer.AutoSize = true;
            this.radioBtnProducer.Location = new System.Drawing.Point(237, 318);
            this.radioBtnProducer.Name = "radioBtnProducer";
            this.radioBtnProducer.Size = new System.Drawing.Size(83, 20);
            this.radioBtnProducer.TabIndex = 2;
            this.radioBtnProducer.TabStop = true;
            this.radioBtnProducer.Text = "Producer";
            this.ttpLoginTextBoxes.SetToolTip(this.radioBtnProducer, "Type Of The Factory");
            this.radioBtnProducer.UseVisualStyleBackColor = true;
            // 
            // btnToPassSignUp
            // 
            this.btnToPassSignUp.BackColor = System.Drawing.Color.Thistle;
            this.btnToPassSignUp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToPassSignUp.Location = new System.Drawing.Point(203, 433);
            this.btnToPassSignUp.Name = "btnToPassSignUp";
            this.btnToPassSignUp.Size = new System.Drawing.Size(251, 36);
            this.btnToPassSignUp.TabIndex = 5;
            this.btnToPassSignUp.Text = "&Click To Sign Up Page";
            this.btnToPassSignUp.UseVisualStyleBackColor = false;
            this.btnToPassSignUp.Click += new System.EventHandler(this.btnToPassSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Thistle;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(42, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(412, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Login";
            this.ttpButtonsOnLoginPage.SetToolTip(this.btnLogin, "Click To Login");
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 22);
            this.txtPassword.TabIndex = 1;
            this.ttpLoginTextBoxes.SetToolTip(this.txtPassword, "The Password Of The Factory");
            // 
            // txtFactoryEmail
            // 
            this.txtFactoryEmail.Location = new System.Drawing.Point(216, 164);
            this.txtFactoryEmail.Name = "txtFactoryEmail";
            this.txtFactoryEmail.Size = new System.Drawing.Size(238, 22);
            this.txtFactoryEmail.TabIndex = 0;
            this.ttpLoginTextBoxes.SetToolTip(this.txtFactoryEmail, "E-mail Of The Factory");
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(37, 239);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 27);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(37, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 27);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Factory E-mail :";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Purple;
            this.lblWelcome.Location = new System.Drawing.Point(155, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! ";
            // 
            // lblToPassWarehousesLogin
            // 
            this.lblToPassWarehousesLogin.AutoSize = true;
            this.lblToPassWarehousesLogin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToPassWarehousesLogin.Location = new System.Drawing.Point(89, 506);
            this.lblToPassWarehousesLogin.Name = "lblToPassWarehousesLogin";
            this.lblToPassWarehousesLogin.Size = new System.Drawing.Size(195, 23);
            this.lblToPassWarehousesLogin.TabIndex = 2;
            this.lblToPassWarehousesLogin.Text = "If You Are Warehouse :";
            // 
            // btnToPassWarehousesLogin
            // 
            this.btnToPassWarehousesLogin.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnToPassWarehousesLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToPassWarehousesLogin.Location = new System.Drawing.Point(307, 497);
            this.btnToPassWarehousesLogin.Name = "btnToPassWarehousesLogin";
            this.btnToPassWarehousesLogin.Size = new System.Drawing.Size(192, 42);
            this.btnToPassWarehousesLogin.TabIndex = 3;
            this.btnToPassWarehousesLogin.Text = "&Warehouses Section";
            this.btnToPassWarehousesLogin.UseVisualStyleBackColor = false;
            this.btnToPassWarehousesLogin.Click += new System.EventHandler(this.btnToPassWarehousesLogin_Click);
            // 
            // menuStripLoginPage
            // 
            this.menuStripLoginPage.BackColor = System.Drawing.Color.Thistle;
            this.menuStripLoginPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripLoginPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.formToolStripMenuItemForm});
            this.menuStripLoginPage.Location = new System.Drawing.Point(0, 0);
            this.menuStripLoginPage.Name = "menuStripLoginPage";
            this.menuStripLoginPage.Size = new System.Drawing.Size(1126, 28);
            this.menuStripLoginPage.TabIndex = 4;
            this.menuStripLoginPage.Text = "menuStripLoginPage";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.tipsAndTricksToolStripMenuItem});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // tipsAndTricksToolStripMenuItem
            // 
            this.tipsAndTricksToolStripMenuItem.Name = "tipsAndTricksToolStripMenuItem";
            this.tipsAndTricksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tipsAndTricksToolStripMenuItem.Text = "Tips And Tricks";
            this.tipsAndTricksToolStripMenuItem.Click += new System.EventHandler(this.tipsAndTricksToolStripMenuItem_Click);
            // 
            // formToolStripMenuItemForm
            // 
            this.formToolStripMenuItemForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.formToolStripMenuItemForm.Name = "formToolStripMenuItemForm";
            this.formToolStripMenuItemForm.Size = new System.Drawing.Size(57, 24);
            this.formToolStripMenuItemForm.Text = "Form";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MidtermProject.Properties.Resources.cherry_blossom;
            this.pictureBox1.Location = new System.Drawing.Point(83, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1126, 647);
            this.Controls.Add(this.btnToPassWarehousesLogin);
            this.Controls.Add(this.lblToPassWarehousesLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.menuStripLoginPage);
            this.MainMenuStrip = this.menuStripLoginPage;
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.menuStripLoginPage.ResumeLayout(false);
            this.menuStripLoginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnToPassSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFactoryEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnConsumer;
        private System.Windows.Forms.RadioButton radioBtnProducer;
        private System.Windows.Forms.ToolTip ttpLoginTextBoxes;
        private System.Windows.Forms.ToolTip ttpButtonsOnLoginPage;
        private System.Windows.Forms.Button btnClearLogin;
        private System.Windows.Forms.Label lblToPassWarehousesLogin;
        private System.Windows.Forms.Button btnToPassWarehousesLogin;
        private System.Windows.Forms.MenuStrip menuStripLoginPage;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsAndTricksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItemForm;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

