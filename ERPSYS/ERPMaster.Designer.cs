namespace ERPSYS
{
    partial class ERPMaster
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taxInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupMasterToolStripMenuItem,
            this.itemMasterToolStripMenuItem,
            this.ledgerMasterToolStripMenuItem,
            this.stockGroupToolStripMenuItem,
            this.unitMasterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "&Master";
            // 
            // groupMasterToolStripMenuItem
            // 
            this.groupMasterToolStripMenuItem.Name = "groupMasterToolStripMenuItem";
            this.groupMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.groupMasterToolStripMenuItem.Text = "&Group Master";
            this.groupMasterToolStripMenuItem.Click += new System.EventHandler(this.groupMasterToolStripMenuItem_Click);
            // 
            // itemMasterToolStripMenuItem
            // 
            this.itemMasterToolStripMenuItem.Name = "itemMasterToolStripMenuItem";
            this.itemMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemMasterToolStripMenuItem.Text = "&Item Master";
            this.itemMasterToolStripMenuItem.Click += new System.EventHandler(this.itemMasterToolStripMenuItem_Click);
            // 
            // ledgerMasterToolStripMenuItem
            // 
            this.ledgerMasterToolStripMenuItem.Name = "ledgerMasterToolStripMenuItem";
            this.ledgerMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ledgerMasterToolStripMenuItem.Text = "&Ledger Master";
            // 
            // stockGroupToolStripMenuItem
            // 
            this.stockGroupToolStripMenuItem.Name = "stockGroupToolStripMenuItem";
            this.stockGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockGroupToolStripMenuItem.Text = "&Stock Group";
            this.stockGroupToolStripMenuItem.Click += new System.EventHandler(this.stockGroupToolStripMenuItem_Click);
            // 
            // unitMasterToolStripMenuItem
            // 
            this.unitMasterToolStripMenuItem.Name = "unitMasterToolStripMenuItem";
            this.unitMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unitMasterToolStripMenuItem.Text = "&Unit Master";
            this.unitMasterToolStripMenuItem.Click += new System.EventHandler(this.unitMasterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesInvoiceToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "&Transaction";
            // 
            // salesInvoiceToolStripMenuItem
            // 
            this.salesInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesInvoiceToolStripMenuItem1,
            this.taxInvoiceToolStripMenuItem});
            this.salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            this.salesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salesInvoiceToolStripMenuItem.Text = "&Sales Invoice";
            // 
            // salesInvoiceToolStripMenuItem1
            // 
            this.salesInvoiceToolStripMenuItem1.Name = "salesInvoiceToolStripMenuItem1";
            this.salesInvoiceToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.salesInvoiceToolStripMenuItem1.Text = "&Retail Invoice";
            // 
            // taxInvoiceToolStripMenuItem
            // 
            this.taxInvoiceToolStripMenuItem.Name = "taxInvoiceToolStripMenuItem";
            this.taxInvoiceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.taxInvoiceToolStripMenuItem.Text = "&Tax Invoice";
            // 
            // ERPMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ERPMaster";
            this.Text = "ERPMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taxInvoiceToolStripMenuItem;
    }
}



