namespace ERPSYS
{
    partial class frmGroupMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelhelp = new System.Windows.Forms.Panel();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cmbgrouptype = new System.Windows.Forms.ComboBox();
            this.txtnatureofgroup = new System.Windows.Forms.TextBox();
            this.txtundergroup = new System.Windows.Forms.TextBox();
            this.txtgroupname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelhelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelhelp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.cmbgrouptype);
            this.panel1.Controls.Add(this.txtnatureofgroup);
            this.panel1.Controls.Add(this.txtundergroup);
            this.panel1.Controls.Add(this.txtgroupname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 514);
            this.panel1.TabIndex = 0;
            // 
            // panelhelp
            // 
            this.panelhelp.AutoScroll = true;
            this.panelhelp.Controls.Add(this.GridView1);
            this.panelhelp.Controls.Add(this.txtsearch);
            this.panelhelp.Controls.Add(this.label6);
            this.panelhelp.Controls.Add(this.cmbsearch);
            this.panelhelp.Controls.Add(this.label7);
            this.panelhelp.Location = new System.Drawing.Point(175, 264);
            this.panelhelp.Name = "panelhelp";
            this.panelhelp.Size = new System.Drawing.Size(687, 238);
            this.panelhelp.TabIndex = 33;
            // 
            // GridView1
            // 
            this.GridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridView1.Location = new System.Drawing.Point(7, 47);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(680, 150);
            this.GridView1.TabIndex = 22;
            this.GridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellDoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(419, 9);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(258, 29);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Search Name";
            // 
            // cmbsearch
            // 
            this.cmbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Location = new System.Drawing.Point(126, 7);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(160, 33);
            this.cmbsearch.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Search Field";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "GROUP MASTER";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(619, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(167, 29);
            this.txtID.TabIndex = 32;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(671, 219);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(97, 39);
            this.btnexit.TabIndex = 31;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(364, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 39);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(261, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 39);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(568, 219);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(97, 39);
            this.btnclear.TabIndex = 28;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(465, 219);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(97, 39);
            this.btnsearch.TabIndex = 27;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cmbgrouptype
            // 
            this.cmbgrouptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrouptype.FormattingEnabled = true;
            this.cmbgrouptype.Items.AddRange(new object[] {
            "PRIMARY",
            "SECONDRY"});
            this.cmbgrouptype.Location = new System.Drawing.Point(415, 89);
            this.cmbgrouptype.Name = "cmbgrouptype";
            this.cmbgrouptype.Size = new System.Drawing.Size(198, 28);
            this.cmbgrouptype.TabIndex = 10;
            this.cmbgrouptype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbgrouptype_KeyPress);
            // 
            // txtnatureofgroup
            // 
            this.txtnatureofgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnatureofgroup.Location = new System.Drawing.Point(415, 154);
            this.txtnatureofgroup.Name = "txtnatureofgroup";
            this.txtnatureofgroup.Size = new System.Drawing.Size(198, 29);
            this.txtnatureofgroup.TabIndex = 9;
            this.txtnatureofgroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnatureofgroup_KeyPress);
            // 
            // txtundergroup
            // 
            this.txtundergroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtundergroup.Location = new System.Drawing.Point(415, 122);
            this.txtundergroup.Name = "txtundergroup";
            this.txtundergroup.Size = new System.Drawing.Size(198, 29);
            this.txtundergroup.TabIndex = 8;
            this.txtundergroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtundergroup_KeyPress);
            // 
            // txtgroupname
            // 
            this.txtgroupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgroupname.Location = new System.Drawing.Point(416, 57);
            this.txtgroupname.Name = "txtgroupname";
            this.txtgroupname.Size = new System.Drawing.Size(198, 29);
            this.txtgroupname.TabIndex = 7;
            this.txtgroupname.TextChanged += new System.EventHandler(this.txtgroupname_TextChanged_1);
            this.txtgroupname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgroupname_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Under Group : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nature  Of Group : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group Name :";
            // 
            // frmGroupMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "frmGroupMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmGroupMaster";
            this.Load += new System.EventHandler(this.frmGroupMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelhelp.ResumeLayout(false);
            this.panelhelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgrouptype;
        private System.Windows.Forms.TextBox txtnatureofgroup;
        private System.Windows.Forms.TextBox txtundergroup;
        private System.Windows.Forms.TextBox txtgroupname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panelhelp;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label7;
    }
}