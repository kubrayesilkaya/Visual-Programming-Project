namespace MidtermProject
{
    partial class FactoriesList
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
            this.groupBoxFactoryType = new System.Windows.Forms.GroupBox();
            this.btnFactoriesList = new System.Windows.Forms.Button();
            this.checkBoxConsumerFactories = new System.Windows.Forms.CheckBox();
            this.checkBoxProducerFactories = new System.Windows.Forms.CheckBox();
            this.dataGridView_FactoriesList = new System.Windows.Forms.DataGridView();
            this.btnToPassPreviousPage = new System.Windows.Forms.Button();
            this.pictureBoxFactoriesListPage = new System.Windows.Forms.PictureBox();
            this.menuStripFactoriesList = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFactoryType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FactoriesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactoriesListPage)).BeginInit();
            this.menuStripFactoriesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFactoryType
            // 
            this.groupBoxFactoryType.Controls.Add(this.btnFactoriesList);
            this.groupBoxFactoryType.Controls.Add(this.checkBoxConsumerFactories);
            this.groupBoxFactoryType.Controls.Add(this.checkBoxProducerFactories);
            this.groupBoxFactoryType.Location = new System.Drawing.Point(110, 36);
            this.groupBoxFactoryType.Name = "groupBoxFactoryType";
            this.groupBoxFactoryType.Size = new System.Drawing.Size(686, 122);
            this.groupBoxFactoryType.TabIndex = 0;
            this.groupBoxFactoryType.TabStop = false;
            // 
            // btnFactoriesList
            // 
            this.btnFactoriesList.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFactoriesList.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFactoriesList.Location = new System.Drawing.Point(462, 39);
            this.btnFactoriesList.Name = "btnFactoriesList";
            this.btnFactoriesList.Size = new System.Drawing.Size(189, 41);
            this.btnFactoriesList.TabIndex = 2;
            this.btnFactoriesList.Text = "&View";
            this.btnFactoriesList.UseVisualStyleBackColor = false;
            this.btnFactoriesList.Click += new System.EventHandler(this.btnFactoriesList_Click);
            // 
            // checkBoxConsumerFactories
            // 
            this.checkBoxConsumerFactories.AutoSize = true;
            this.checkBoxConsumerFactories.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxConsumerFactories.Location = new System.Drawing.Point(241, 49);
            this.checkBoxConsumerFactories.Name = "checkBoxConsumerFactories";
            this.checkBoxConsumerFactories.Size = new System.Drawing.Size(175, 24);
            this.checkBoxConsumerFactories.TabIndex = 1;
            this.checkBoxConsumerFactories.Text = "Consumer Factories";
            this.checkBoxConsumerFactories.UseVisualStyleBackColor = true;
            // 
            // checkBoxProducerFactories
            // 
            this.checkBoxProducerFactories.AutoSize = true;
            this.checkBoxProducerFactories.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxProducerFactories.Location = new System.Drawing.Point(42, 49);
            this.checkBoxProducerFactories.Name = "checkBoxProducerFactories";
            this.checkBoxProducerFactories.Size = new System.Drawing.Size(168, 24);
            this.checkBoxProducerFactories.TabIndex = 0;
            this.checkBoxProducerFactories.Text = "Producer Factories";
            this.checkBoxProducerFactories.UseVisualStyleBackColor = true;
            // 
            // dataGridView_FactoriesList
            // 
            this.dataGridView_FactoriesList.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView_FactoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FactoriesList.Location = new System.Drawing.Point(110, 187);
            this.dataGridView_FactoriesList.Name = "dataGridView_FactoriesList";
            this.dataGridView_FactoriesList.RowHeadersWidth = 51;
            this.dataGridView_FactoriesList.RowTemplate.Height = 24;
            this.dataGridView_FactoriesList.Size = new System.Drawing.Size(686, 317);
            this.dataGridView_FactoriesList.TabIndex = 1;
            // 
            // btnToPassPreviousPage
            // 
            this.btnToPassPreviousPage.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnToPassPreviousPage.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnToPassPreviousPage.ForeColor = System.Drawing.Color.Olive;
            this.btnToPassPreviousPage.Location = new System.Drawing.Point(110, 539);
            this.btnToPassPreviousPage.Name = "btnToPassPreviousPage";
            this.btnToPassPreviousPage.Size = new System.Drawing.Size(75, 35);
            this.btnToPassPreviousPage.TabIndex = 3;
            this.btnToPassPreviousPage.Text = "<----";
            this.btnToPassPreviousPage.UseVisualStyleBackColor = false;
            this.btnToPassPreviousPage.Click += new System.EventHandler(this.btnToPassPreviousPage_Click);
            // 
            // pictureBoxFactoriesListPage
            // 
            this.pictureBoxFactoriesListPage.Image = global::MidtermProject.Properties.Resources.plant;
            this.pictureBoxFactoriesListPage.Location = new System.Drawing.Point(802, 235);
            this.pictureBoxFactoriesListPage.Name = "pictureBoxFactoriesListPage";
            this.pictureBoxFactoriesListPage.Size = new System.Drawing.Size(318, 247);
            this.pictureBoxFactoriesListPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFactoriesListPage.TabIndex = 2;
            this.pictureBoxFactoriesListPage.TabStop = false;
            // 
            // menuStripFactoriesList
            // 
            this.menuStripFactoriesList.BackColor = System.Drawing.Color.LightBlue;
            this.menuStripFactoriesList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFactoriesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.formToolStripMenuItem});
            this.menuStripFactoriesList.Location = new System.Drawing.Point(0, 0);
            this.menuStripFactoriesList.Name = "menuStripFactoriesList";
            this.menuStripFactoriesList.Size = new System.Drawing.Size(1126, 28);
            this.menuStripFactoriesList.TabIndex = 4;
            this.menuStripFactoriesList.Text = "menuStrip1";
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
            // FactoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 647);
            this.Controls.Add(this.btnToPassPreviousPage);
            this.Controls.Add(this.pictureBoxFactoriesListPage);
            this.Controls.Add(this.dataGridView_FactoriesList);
            this.Controls.Add(this.groupBoxFactoryType);
            this.Controls.Add(this.menuStripFactoriesList);
            this.MainMenuStrip = this.menuStripFactoriesList;
            this.Name = "FactoriesList";
            this.Text = "Factories List";
            this.groupBoxFactoryType.ResumeLayout(false);
            this.groupBoxFactoryType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FactoriesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactoriesListPage)).EndInit();
            this.menuStripFactoriesList.ResumeLayout(false);
            this.menuStripFactoriesList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFactoryType;
        private System.Windows.Forms.CheckBox checkBoxProducerFactories;
        private System.Windows.Forms.CheckBox checkBoxConsumerFactories;
        private System.Windows.Forms.Button btnFactoriesList;
        private System.Windows.Forms.DataGridView dataGridView_FactoriesList;
        private System.Windows.Forms.PictureBox pictureBoxFactoriesListPage;
        private System.Windows.Forms.Button btnToPassPreviousPage;
        private System.Windows.Forms.MenuStrip menuStripFactoriesList;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsAndTricksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}