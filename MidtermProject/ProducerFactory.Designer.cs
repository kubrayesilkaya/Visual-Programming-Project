namespace MidtermProject
{
    partial class ProducerFactory
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
            this.lblWarehouses = new System.Windows.Forms.Label();
            this.btnToSeeWarehouses = new System.Windows.Forms.Button();
            this.lblChooseWarehouse = new System.Windows.Forms.Label();
            this.comboBoxWarehouses = new System.Windows.Forms.ComboBox();
            this.lblEnterProduct = new System.Windows.Forms.Label();
            this.txtEnterTheProduct = new System.Windows.Forms.TextBox();
            this.lblAmountOfProduct = new System.Windows.Forms.Label();
            this.txtAmountOfProduct = new System.Windows.Forms.TextBox();
            this.lblSubmitUpdate = new System.Windows.Forms.Button();
            this.grpProducerFactory = new System.Windows.Forms.GroupBox();
            this.lblStockUpdateHeader = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.ttpProducerFactory = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxProducer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxProducerFactory = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsAndTrickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpProducerFactory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducerFactory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarehouses
            // 
            this.lblWarehouses.AutoSize = true;
            this.lblWarehouses.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarehouses.Location = new System.Drawing.Point(18, 96);
            this.lblWarehouses.Name = "lblWarehouses";
            this.lblWarehouses.Size = new System.Drawing.Size(223, 23);
            this.lblWarehouses.TabIndex = 0;
            this.lblWarehouses.Text = "Click To See Warehouses :";
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
            // lblChooseWarehouse
            // 
            this.lblChooseWarehouse.AutoSize = true;
            this.lblChooseWarehouse.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChooseWarehouse.Location = new System.Drawing.Point(18, 214);
            this.lblChooseWarehouse.Name = "lblChooseWarehouse";
            this.lblChooseWarehouse.Size = new System.Drawing.Size(211, 23);
            this.lblChooseWarehouse.TabIndex = 2;
            this.lblChooseWarehouse.Text = "Choose The Warehouse :";
            // 
            // comboBoxWarehouses
            // 
            this.comboBoxWarehouses.BackColor = System.Drawing.Color.MistyRose;
            this.comboBoxWarehouses.FormattingEnabled = true;
            this.comboBoxWarehouses.Location = new System.Drawing.Point(316, 216);
            this.comboBoxWarehouses.Name = "comboBoxWarehouses";
            this.comboBoxWarehouses.Size = new System.Drawing.Size(222, 24);
            this.comboBoxWarehouses.TabIndex = 2;
            this.ttpProducerFactory.SetToolTip(this.comboBoxWarehouses, "Warehouse You Want To Add Products");
            // 
            // lblEnterProduct
            // 
            this.lblEnterProduct.AutoSize = true;
            this.lblEnterProduct.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnterProduct.Location = new System.Drawing.Point(19, 305);
            this.lblEnterProduct.Name = "lblEnterProduct";
            this.lblEnterProduct.Size = new System.Drawing.Size(163, 23);
            this.lblEnterProduct.TabIndex = 4;
            this.lblEnterProduct.Text = "Enter The Product :";
            // 
            // txtEnterTheProduct
            // 
            this.txtEnterTheProduct.BackColor = System.Drawing.Color.MistyRose;
            this.txtEnterTheProduct.Location = new System.Drawing.Point(316, 305);
            this.txtEnterTheProduct.Name = "txtEnterTheProduct";
            this.txtEnterTheProduct.Size = new System.Drawing.Size(222, 22);
            this.txtEnterTheProduct.TabIndex = 3;
            this.ttpProducerFactory.SetToolTip(this.txtEnterTheProduct, "Name Of The Product");
            // 
            // lblAmountOfProduct
            // 
            this.lblAmountOfProduct.AutoSize = true;
            this.lblAmountOfProduct.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmountOfProduct.Location = new System.Drawing.Point(18, 401);
            this.lblAmountOfProduct.Name = "lblAmountOfProduct";
            this.lblAmountOfProduct.Size = new System.Drawing.Size(258, 23);
            this.lblAmountOfProduct.TabIndex = 6;
            this.lblAmountOfProduct.Text = "Enter The Amount Of Product :";
            // 
            // txtAmountOfProduct
            // 
            this.txtAmountOfProduct.BackColor = System.Drawing.Color.MistyRose;
            this.txtAmountOfProduct.Location = new System.Drawing.Point(316, 402);
            this.txtAmountOfProduct.Name = "txtAmountOfProduct";
            this.txtAmountOfProduct.Size = new System.Drawing.Size(222, 22);
            this.txtAmountOfProduct.TabIndex = 4;
            this.ttpProducerFactory.SetToolTip(this.txtAmountOfProduct, "Quantity Of The Product");
            // 
            // lblSubmitUpdate
            // 
            this.lblSubmitUpdate.BackColor = System.Drawing.Color.MistyRose;
            this.lblSubmitUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubmitUpdate.Location = new System.Drawing.Point(23, 514);
            this.lblSubmitUpdate.Name = "lblSubmitUpdate";
            this.lblSubmitUpdate.Size = new System.Drawing.Size(515, 54);
            this.lblSubmitUpdate.TabIndex = 8;
            this.lblSubmitUpdate.Text = "&Submit Stock The Update";
            this.lblSubmitUpdate.UseVisualStyleBackColor = false;
            this.lblSubmitUpdate.Click += new System.EventHandler(this.lblSubmitUpdate_Click);
            // 
            // grpProducerFactory
            // 
            this.grpProducerFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpProducerFactory.Controls.Add(this.lblStockUpdateHeader);
            this.grpProducerFactory.Controls.Add(this.lblSubmitUpdate);
            this.grpProducerFactory.Controls.Add(this.txtAmountOfProduct);
            this.grpProducerFactory.Controls.Add(this.lblWarehouses);
            this.grpProducerFactory.Controls.Add(this.lblAmountOfProduct);
            this.grpProducerFactory.Controls.Add(this.btnToSeeWarehouses);
            this.grpProducerFactory.Controls.Add(this.txtEnterTheProduct);
            this.grpProducerFactory.Controls.Add(this.lblChooseWarehouse);
            this.grpProducerFactory.Controls.Add(this.lblEnterProduct);
            this.grpProducerFactory.Controls.Add(this.comboBoxWarehouses);
            this.grpProducerFactory.Location = new System.Drawing.Point(532, 23);
            this.grpProducerFactory.Name = "grpProducerFactory";
            this.grpProducerFactory.Size = new System.Drawing.Size(565, 590);
            this.grpProducerFactory.TabIndex = 1;
            this.grpProducerFactory.TabStop = false;
            // 
            // lblStockUpdateHeader
            // 
            this.lblStockUpdateHeader.AutoSize = true;
            this.lblStockUpdateHeader.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStockUpdateHeader.Location = new System.Drawing.Point(172, 35);
            this.lblStockUpdateHeader.Name = "lblStockUpdateHeader";
            this.lblStockUpdateHeader.Size = new System.Drawing.Size(196, 24);
            this.lblStockUpdateHeader.TabIndex = 0;
            this.lblStockUpdateHeader.Text = "Product Stock Update";
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.Snow;
            this.btnMessage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMessage.Location = new System.Drawing.Point(292, 93);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(140, 39);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "&Message";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(52, 222);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(88, 23);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "Welcome";
            // 
            // pictureBoxProducer2
            // 
            this.pictureBoxProducer2.Image = global::MidtermProject.Properties.Resources.flower;
            this.pictureBoxProducer2.Location = new System.Drawing.Point(27, 48);
            this.pictureBoxProducer2.Name = "pictureBoxProducer2";
            this.pictureBoxProducer2.Size = new System.Drawing.Size(234, 122);
            this.pictureBoxProducer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducer2.TabIndex = 13;
            this.pictureBoxProducer2.TabStop = false;
            // 
            // pictureBoxProducerFactory
            // 
            this.pictureBoxProducerFactory.Image = global::MidtermProject.Properties.Resources.birds1;
            this.pictureBoxProducerFactory.Location = new System.Drawing.Point(39, 351);
            this.pictureBoxProducerFactory.Name = "pictureBoxProducerFactory";
            this.pictureBoxProducerFactory.Size = new System.Drawing.Size(471, 219);
            this.pictureBoxProducerFactory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducerFactory.TabIndex = 11;
            this.pictureBoxProducerFactory.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStripProducerFactory";
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
            this.tipsAndTrickToolStripMenuItem});
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
            // tipsAndTrickToolStripMenuItem
            // 
            this.tipsAndTrickToolStripMenuItem.Name = "tipsAndTrickToolStripMenuItem";
            this.tipsAndTrickToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tipsAndTrickToolStripMenuItem.Text = "Tips And Trick";
            this.tipsAndTrickToolStripMenuItem.Click += new System.EventHandler(this.tipsAndTrickToolStripMenuItem_Click);
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
            // ProducerFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1126, 647);
            this.Controls.Add(this.pictureBoxProducer2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureBoxProducerFactory);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.grpProducerFactory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProducerFactory";
            this.Text = "Producer Factory";
            this.Load += new System.EventHandler(this.ProducerFactory_Load);
            this.grpProducerFactory.ResumeLayout(false);
            this.grpProducerFactory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducerFactory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarehouses;
        private System.Windows.Forms.Button btnToSeeWarehouses;
        private System.Windows.Forms.Label lblChooseWarehouse;
        private System.Windows.Forms.ComboBox comboBoxWarehouses;
        private System.Windows.Forms.Label lblEnterProduct;
        private System.Windows.Forms.TextBox txtEnterTheProduct;
        private System.Windows.Forms.Label lblAmountOfProduct;
        private System.Windows.Forms.TextBox txtAmountOfProduct;
        private System.Windows.Forms.Button lblSubmitUpdate;
        private System.Windows.Forms.GroupBox grpProducerFactory;
        private System.Windows.Forms.Label lblStockUpdateHeader;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.PictureBox pictureBoxProducerFactory;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBoxProducer2;
        private System.Windows.Forms.ToolTip ttpProducerFactory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsAndTrickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}