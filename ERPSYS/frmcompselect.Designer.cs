namespace ERPSYS
{
    partial class frmcompselect
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
            this.btnok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.selectcomp = new System.Windows.Forms.Panel();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtccode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Panel();
            this.btnverify = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.selectcomp.SuspendLayout();
            this.pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btncreate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(52, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 127);
            this.panel1.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(213, 10);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(89, 33);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(378, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Password";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::ERPSYS.Properties.Resources._151;
            this.btnSelect.Location = new System.Drawing.Point(43, 60);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(164, 53);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Company";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseCompatibleTextRendering = true;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Image = global::ERPSYS.Properties.Resources.Not_Always_on_Top;
            this.btncreate.Location = new System.Drawing.Point(213, 60);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(159, 56);
            this.btncreate.TabIndex = 1;
            this.btncreate.Text = "Create Company";
            this.btncreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(308, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // selectcomp
            // 
            this.selectcomp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectcomp.Controls.Add(this.txtcname);
            this.selectcomp.Controls.Add(this.txtccode);
            this.selectcomp.Controls.Add(this.label1);
            this.selectcomp.Location = new System.Drawing.Point(3, 16);
            this.selectcomp.Name = "selectcomp";
            this.selectcomp.Size = new System.Drawing.Size(707, 46);
            this.selectcomp.TabIndex = 0;
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(328, 9);
            this.txtcname.Multiline = true;
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(314, 30);
            this.txtcname.TabIndex = 1;
            this.txtcname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcname_KeyPress);
            // 
            // txtccode
            // 
            this.txtccode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtccode.Location = new System.Drawing.Point(217, 9);
            this.txtccode.Name = "txtccode";
            this.txtccode.Size = new System.Drawing.Size(100, 31);
            this.txtccode.TabIndex = 0;
            this.txtccode.TextChanged += new System.EventHandler(this.txtccode_TextChanged);
            this.txtccode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtccode_KeyDown);
            this.txtccode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtccode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Company";
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pass.Controls.Add(this.btnverify);
            this.pass.Controls.Add(this.txtpass);
            this.pass.Controls.Add(this.label2);
            this.pass.Location = new System.Drawing.Point(8, 12);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(719, 50);
            this.pass.TabIndex = 12;
            // 
            // btnverify
            // 
            this.btnverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.Location = new System.Drawing.Point(616, 9);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(89, 34);
            this.btnverify.TabIndex = 1;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(216, 9);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(381, 30);
            this.txtpass.TabIndex = 0;
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // frmcompselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(733, 305);
            this.Controls.Add(this.selectcomp);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcompselect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcomselect";
            this.Load += new System.EventHandler(this.frmcompselect_Load);
            this.panel1.ResumeLayout(false);
            this.selectcomp.ResumeLayout(false);
            this.selectcomp.PerformLayout();
            this.pass.ResumeLayout(false);
            this.pass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel selectcomp;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtccode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnverify;
    }
}