namespace STUDENTREG
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgv_stud = new System.Windows.Forms.DataGridView();
            this.btntop = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtboxlast = new System.Windows.Forms.TextBox();
            this.txtboxfirst = new System.Windows.Forms.TextBox();
            this.txtboxmid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncourse = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxcourse = new System.Windows.Forms.TextBox();
            this.txtboxpath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(10, 320);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(51, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(65, 320);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(51, 28);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(119, 320);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(51, 28);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(174, 320);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(61, 28);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dgv_stud
            // 
            this.dgv_stud.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_stud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stud.Location = new System.Drawing.Point(231, 6);
            this.dgv_stud.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_stud.Name = "dgv_stud";
            this.dgv_stud.RowTemplate.Height = 28;
            this.dgv_stud.Size = new System.Drawing.Size(313, 307);
            this.dgv_stud.TabIndex = 4;
            // 
            // btntop
            // 
            this.btntop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntop.BackgroundImage")));
            this.btntop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btntop.Location = new System.Drawing.Point(281, 320);
            this.btntop.Margin = new System.Windows.Forms.Padding(2);
            this.btntop.Name = "btntop";
            this.btntop.Size = new System.Drawing.Size(51, 28);
            this.btntop.TabIndex = 5;
            this.btntop.UseVisualStyleBackColor = true;
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprevious.BackgroundImage")));
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.Location = new System.Drawing.Point(336, 320);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(51, 28);
            this.btnprevious.TabIndex = 6;
            this.btnprevious.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnext.BackgroundImage")));
            this.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnext.Location = new System.Drawing.Point(391, 320);
            this.btnnext.Margin = new System.Windows.Forms.Padding(2);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(51, 28);
            this.btnnext.TabIndex = 7;
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlast.BackgroundImage")));
            this.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlast.Location = new System.Drawing.Point(445, 320);
            this.btnlast.Margin = new System.Windows.Forms.Padding(2);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(51, 28);
            this.btnlast.TabIndex = 8;
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(99, 162);
            this.txtboxID.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(123, 20);
            this.txtboxID.TabIndex = 9;
            // 
            // txtboxlast
            // 
            this.txtboxlast.Location = new System.Drawing.Point(99, 192);
            this.txtboxlast.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxlast.Name = "txtboxlast";
            this.txtboxlast.Size = new System.Drawing.Size(123, 20);
            this.txtboxlast.TabIndex = 10;
            // 
            // txtboxfirst
            // 
            this.txtboxfirst.Location = new System.Drawing.Point(99, 220);
            this.txtboxfirst.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxfirst.Name = "txtboxfirst";
            this.txtboxfirst.Size = new System.Drawing.Size(123, 20);
            this.txtboxfirst.TabIndex = 11;
            // 
            // txtboxmid
            // 
            this.txtboxmid.Location = new System.Drawing.Point(99, 248);
            this.txtboxmid.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxmid.Name = "txtboxmid";
            this.txtboxmid.Size = new System.Drawing.Size(123, 20);
            this.txtboxmid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "STUDENT ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "LAST NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "FIRST NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "MIDDLE NAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "COURSE:";
            // 
            // btncourse
            // 
            this.btncourse.Location = new System.Drawing.Point(99, 297);
            this.btncourse.Margin = new System.Windows.Forms.Padding(2);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(122, 19);
            this.btncourse.TabIndex = 18;
            this.btncourse.Text = "Select Course";
            this.btncourse.UseVisualStyleBackColor = true;
            this.btncourse.Click += new System.EventHandler(this.btncourse_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 78);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 28);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(76, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 120);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxcourse
            // 
            this.txtboxcourse.Location = new System.Drawing.Point(99, 272);
            this.txtboxcourse.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxcourse.Name = "txtboxcourse";
            this.txtboxcourse.Size = new System.Drawing.Size(123, 20);
            this.txtboxcourse.TabIndex = 21;
            // 
            // txtboxpath
            // 
            this.txtboxpath.Location = new System.Drawing.Point(7, 130);
            this.txtboxpath.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxpath.Name = "txtboxpath";
            this.txtboxpath.Size = new System.Drawing.Size(214, 20);
            this.txtboxpath.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "FILE PATH:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxpath);
            this.Controls.Add(this.txtboxcourse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btncourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxmid);
            this.Controls.Add(this.txtboxfirst);
            this.Controls.Add(this.txtboxlast);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btntop);
            this.Controls.Add(this.dgv_stud);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "STUDENT REGISTRATION";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgv_stud;
        private System.Windows.Forms.Button btntop;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtboxlast;
        private System.Windows.Forms.TextBox txtboxfirst;
        private System.Windows.Forms.TextBox txtboxmid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncourse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxcourse;
        private System.Windows.Forms.TextBox txtboxpath;
        private System.Windows.Forms.Label label6;
    }
}

