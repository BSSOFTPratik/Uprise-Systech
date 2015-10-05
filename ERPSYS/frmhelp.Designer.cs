namespace ERPSYS
{
    partial class frmhelp
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
            //this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            //this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleShape1
            // 
            //this.rectangleShape1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            //this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            //this.rectangleShape1.Location = new System.Drawing.Point(42, 15);
            //this.rectangleShape1.Name = "rectangleShape1";
            //this.rectangleShape1.Size = new System.Drawing.Size(686, 31);
            //// 
            //// shapeContainer1
            //// 
            //this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            //this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            //this.shapeContainer1.Name = "shapeContainer1";
            //this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            //this.rectangleShape1});
            //this.shapeContainer1.Size = new System.Drawing.Size(767, 327);
            //this.shapeContainer1.TabIndex = 0;
            //this.shapeContainer1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(384, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.GridView1);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbsearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 238);
            this.panel1.TabIndex = 18;
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
            this.GridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView1_RowHeaderMouseClick);
            this.GridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            this.GridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridView1_KeyPress);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(419, 9);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(258, 29);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search Name";
            // 
            // cmbsearch
            // 
            this.cmbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Location = new System.Drawing.Point(126, 7);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(160, 33);
            this.cmbsearch.TabIndex = 0;
            this.cmbsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbsearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Field";
            // 
            // frmhelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(767, 327);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            //this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmhelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView1;
    }
}