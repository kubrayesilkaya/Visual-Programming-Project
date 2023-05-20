namespace MidtermProject
{
    partial class ConsumerFactory
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
            this.grpConsumerFactory = new System.Windows.Forms.GroupBox();
            this.btnToSubmitStockChanges = new System.Windows.Forms.Button();
            this.txtAmountOfPrdouct = new System.Windows.Forms.TextBox();
            this.lblAmountOfProduct = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.comboBoxToChooseWarehouse = new System.Windows.Forms.ComboBox();
            this.btnToChooseWarehouse = new System.Windows.Forms.Label();
            this.btnToSeeWarehouses = new System.Windows.Forms.Button();
            this.lblToSeeWarehouses = new System.Windows.Forms.Label();
            this.lblConsumerPageHeader = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblMessageConsumer = new System.Windows.Forms.Label();
            this.ttpConsumerFactory = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripConsumerFactory = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxConsumer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxConsumerFactory = new System.Windows.Forms.PictureBox();
            this.grpConsumerFactory.SuspendLayout();
            this.menuStripConsumerFactory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsumer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsumerFactory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsumerFactory
            // 
            this.grpConsumerFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpConsumerFactory.Controls.Add(this.btnToSubmitStockChanges);
            this.grpConsumerFactory.Controls.Add(this.txtAmountOfPrdouct);
            this.grpConsumerFactory.Controls.Add(this.lblAmountOfProduct);
            this.grpConsumerFactory.Controls.Add(this.txtProductName);
            this.grpConsumerFactory.Controls.Add(this.lblProductName);
            this.grpConsumerFactory.Controls.Add(this.comboBoxToChooseWarehouse);
            this.grpConsumerFactory.Controls.Add(this.btnToChooseWarehouse);
            this.grpConsumerFactory.Controls.Add(this.btnToSeeWarehouses);
            this.grpConsumerFactory.Controls.Add(this.lblToSeeWarehouses);
            this.grpConsumerFactory.Controls.Add(this.lblConsumerPageHeader);
            this.grpConsumerFactory.Location = new System.Drawing.Point(532, 23);
            this.grpConsumerFactory.Name = "grpConsumerFactory";
            this.grpConsumerFactory.Size = new System.Drawing.Size(565, 590);
            this.grpConsumerFactory.TabIndex = 0;
            this.grpConsumerFactory.TabStop = false;
            // 
            // btnToSubmitStockChanges
            // 
            this.btnToSubmitStockChanges.BackColor = System.Drawing.Color.MistyRose;
            this.btnToSubmitStockChanges.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnToSubmitStockChanges.Location = new System.Drawing.Point(23, 514);
            this.btnToSubmitStockChanges.Name = "btnToSubmitStockChanges";
            this.btnToSubmitStockChanges.Size = new System.Drawing.Size(515, 54);
            this.btnToSubmitStockChanges.TabIndex = 5;
            this.btnToSubmitStockChanges.Text = "&Submit Stock The Update";
            this.btnToSubmitStockChanges.UseVisualStyleBackColor = false;
            this.btnToSubmitStockChanges.Click += new System.EventHandler(this.btnToSubmitStockChanges_Click);
            // 
            // txtAmountOfPrdouct
            // 
            this.txtAmountOfPrdouct.BackColor = System.Drawing.Color.MistyRose;
            this.txtAmountOfPrdouct.Location = new System.Drawing.Point(316, 402);
            this.txtAmountOfPrdouct.Name = "txtAmountOfPrdouct";
            this.txtAmountOfPrdouct.Size = new System.Drawing.Size(222, 22);
            this.txtAmountOfPrdouct.TabIndex = 4;
            this.ttpConsumerFactory.SetToolTip(this.txtAmountOfPrdouct, "The Quantitty Of Product");
            // 
            // lblAmountOfProduct
            // 
            this.lblAmountOfProduct.AutoSize = true;
            this.lblAmountOfProduct.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmountOfProduct.Location = new System.Drawing.Point(18, 401);
            this.lblAmountOfProduct.Name = "lblAmountOfProduct";
            this.lblAmountOfProduct.Size = new System.Drawing.Size(258, 23);
            this.lblAmountOfProduct.TabIndex = 7;
            this.lblAmountOfProduct.Text = "Enter The Amount Of Product :";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.MistyRose;
            this.txtProductName.Location = new System.Drawing.Point(316, 305);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(222, 22);
            this.txtProductName.TabIndex = 3;
            this.ttpConsumerFactory.SetToolTip(this.txtProductName, "Name Of The Product That You Want To Buy");
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(19, 305);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(163, 23);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Enter The Product :";
            // 
            // comboBoxToChooseWarehouse
            // 
            this.comboBoxToChooseWarehouse.BackColor = System.Drawing.Color.MistyRose;
            this.comboBoxToChooseWarehouse.FormattingEnabled = true;
            this.comboBoxToChooseWarehouse.Location = new System.Drawing.Point(316, 216);
            this.comboBoxToChooseWarehouse.Name = "comboBoxToChooseWarehouse";
            this.comboBoxToChooseWarehouse.Size = new System.Drawing.Size(222, 24);
            this.comboBoxToChooseWarehouse.TabIndex = 2;
            this.ttpConsumerFactory.SetToolTip(this.comboBoxToChooseWarehouse, "Warehouse whose products you want to use");
            // 
            // btnToChooseWarehouse
            // 
            this.btnToChooseWarehouse.AutoSize = true;
            this.btnToChooseWarehouse.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToChooseWarehouse.Location = new System.Drawing.Point(18, 214);
            this.btnToChooseWarehouse.Name = "btnToChooseWarehouse";
            this.btnToChooseWarehouse.Size = new System.Drawing.Size(211, 23);
            this.btnToChooseWarehouse.TabIndex = 3;
            this.btnToChooseWarehouse.Text = "Choose The Warehouse :";
            // 
            // btnToSeeWarehouses
            // 
            this.btnToSeeWarehouses.BackColor = System.Drawing.Color.MistyRose;
            this.btnToSeeWarehouses.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToSeeWarehouses.Location = new System.Drawing.Point(316, 79);
            this.btnToSeeWarehouses.Name = "btnToSeeWarehouses";
            this.btnToSeeWarehouses.Size = new System.Drawing.Size(222, 58);
            this.btnToSeeWarehouses.TabIndex = 1;
            this.btnToSeeWarehouses.Text = "&Warehouses";
            this.btnToSeeWarehouses.UseVisualStyleBackColor = false;
            this.btnToSeeWarehouses.Click += new System.EventHandler(this.btnToSeeWarehouses_Click);
            // 
            // lblToSeeWarehouses
            // 
            this.lblToSeeWarehouses.AutoSize = true;
            this.lblToSeeWarehouses.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToSeeWarehouses.Location = new System.Drawing.Point(18, 96);
            this.lblToSeeWarehouses.Name = "lblToSeeWarehouses";
            this.lblToSeeWarehouses.Size = new System.Drawing.Size(223, 23);
            this.lblToSeeWarehouses.TabIndex = 1;
            this.lblToSeeWarehouses.Text = "Click To See Warehouses :";
            // 
            // lblConsumerPageHeader
            // 
            this.lblConsumerPageHeader.AutoSize = true;
            this.lblConsumerPageHeader.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConsumerPageHeader.Location = new System.Drawing.Point(172, 35);
            this.lblConsumerPageHeader.Name = "lblConsumerPageHeader";
            this.lblConsumerPageHeader.Size = new System.Drawing.Size(201, 24);
            this.lblConsumerPageHeader.TabIndex = 0;
            this.lblConsumerPageHeader.Text = "Product Usage Update";
            // 
            // btnMessage
            // 
            this.btnMessage.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnMessage.Location = new System.Drawing.Point(292, 93);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(140, 39);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "&Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblMessageConsumer
            // 
            this.lblMessageConsumer.AutoSize = true;
            this.lblMessageConsumer.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.lblMessageConsumer.Location = new System.Drawing.Point(52, 222);
            this.lblMessageConsumer.Name = "lblMessageConsumer";
            this.lblMessageConsumer.Size = new System.Drawing.Size(88, 23);
            this.lblMessageConsumer.TabIndex = 2;
            this.lblMessageConsumer.Text = "Welcome";
            // 
            // menuStripConsumerFactory
            // 
            this.menuStripConsumerFactory.BackColor = System.Drawing.Color.MistyRose;
            this.menuStripConsumerFactory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripConsumerFactory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.formToolStripMenuItem});
            this.menuStripConsumerFactory.Location = new System.Drawing.Point(0, 0);
            this.menuStripConsumerFactory.Name = "menuStripConsumerFactory";
            this.menuStripConsumerFactory.Size = new System.Drawing.Size(1126, 28);
            this.menuStripConsumerFactory.TabIndex = 5;
            this.menuStripConsumerFactory.Text = "menuStrip1";
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
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBoxConsumer2
            // 
            this.pictureBoxConsumer2.Image = global::MidtermProject.Properties.Resources.cherry_blossoms;
            this.pictureBoxConsumer2.Location = new System.Drawing.Point(56, 348);
            this.pictureBoxConsumer2.Name = "pictureBoxConsumer2";
            this.pictureBoxConsumer2.Size = new System.Drawing.Size(390, 219);
            this.pictureBoxConsumer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConsumer2.TabIndex = 4;
            this.pictureBoxConsumer2.TabStop = false;
            // 
            // pictureBoxConsumerFactory
            // 
            this.pictureBoxConsumerFactory.Image = global::MidtermProject.Properties.Resources.blue_flower;
            this.pictureBoxConsumerFactory.Location = new System.Drawing.Point(56, 40);
            this.pictureBoxConsumerFactory.Name = "pictureBoxConsumerFactory";
            this.pictureBoxConsumerFactory.Size = new System.Drawing.Size(207, 145);
            this.pictureBoxConsumerFactory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConsumerFactory.TabIndex = 3;
            this.pictureBoxConsumerFactory.TabStop = false;
            // 
            // ConsumerFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1126, 647);
            this.Controls.Add(this.pictureBoxConsumer2);
            this.Controls.Add(this.pictureBoxConsumerFactory);
            this.Controls.Add(this.lblMessageConsumer);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.grpConsumerFactory);
            this.Controls.Add(this.menuStripConsumerFactory);
            this.MainMenuStrip = this.menuStripConsumerFactory;
            this.Name = "ConsumerFactory";
            this.Text = "Consumer Factory";
            this.Load += new System.EventHandler(this.ConsumerFactory_Load);
            this.grpConsumerFactory.ResumeLayout(false);
            this.grpConsumerFactory.PerformLayout();
            this.menuStripConsumerFactory.ResumeLayout(false);
            this.menuStripConsumerFactory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsumer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsumerFactory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsumerFactory;
        private System.Windows.Forms.Label lblConsumerPageHeader;
        private System.Windows.Forms.Label lblToSeeWarehouses;
        private System.Windows.Forms.Button btnToSeeWarehouses;
        private System.Windows.Forms.Label btnToChooseWarehouse;
        private System.Windows.Forms.ComboBox comboBoxToChooseWarehouse;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblAmountOfProduct;
        private System.Windows.Forms.TextBox txtAmountOfPrdouct;
        private System.Windows.Forms.Button btnToSubmitStockChanges;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblMessageConsumer;
        private System.Windows.Forms.PictureBox pictureBoxConsumerFactory;
        private System.Windows.Forms.PictureBox pictureBoxConsumer2;
        private System.Windows.Forms.ToolTip ttpConsumerFactory;
        private System.Windows.Forms.MenuStrip menuStripConsumerFactory;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsAndTricksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}