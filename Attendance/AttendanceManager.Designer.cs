﻿namespace Attendance
{
    partial class AttendanceManager
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDBoxDel = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAbsentEdit = new System.Windows.Forms.RadioButton();
            this.rbIzinEdit = new System.Windows.Forms.RadioButton();
            this.rbHadirEdit = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBoxEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addAttBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAbsentAdd = new System.Windows.Forms.RadioButton();
            this.rbIzinAdd = new System.Windows.Forms.RadioButton();
            this.rbHadirAdd = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxDisplay = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbAddAtt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbTelatEdit = new System.Windows.Forms.RadioButton();
            this.rbTelatAdd = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "DELETE ATTENDANCE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID";
            // 
            // IDBoxDel
            // 
            this.IDBoxDel.Location = new System.Drawing.Point(14, 507);
            this.IDBoxDel.Name = "IDBoxDel";
            this.IDBoxDel.Size = new System.Drawing.Size(320, 20);
            this.IDBoxDel.TabIndex = 35;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(14, 533);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(320, 23);
            this.btnDel.TabIndex = 34;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "EDIT ATTENDANCE";
            // 
            // rbAbsentEdit
            // 
            this.rbAbsentEdit.AutoSize = true;
            this.rbAbsentEdit.Location = new System.Drawing.Point(119, 346);
            this.rbAbsentEdit.Name = "rbAbsentEdit";
            this.rbAbsentEdit.Size = new System.Drawing.Size(58, 17);
            this.rbAbsentEdit.TabIndex = 32;
            this.rbAbsentEdit.TabStop = true;
            this.rbAbsentEdit.Text = "Absent";
            this.rbAbsentEdit.UseVisualStyleBackColor = true;
            // 
            // rbIzinEdit
            // 
            this.rbIzinEdit.AutoSize = true;
            this.rbIzinEdit.Location = new System.Drawing.Point(72, 346);
            this.rbIzinEdit.Name = "rbIzinEdit";
            this.rbIzinEdit.Size = new System.Drawing.Size(41, 17);
            this.rbIzinEdit.TabIndex = 31;
            this.rbIzinEdit.TabStop = true;
            this.rbIzinEdit.Text = "Izin";
            this.rbIzinEdit.UseVisualStyleBackColor = true;
            // 
            // rbHadirEdit
            // 
            this.rbHadirEdit.AutoSize = true;
            this.rbHadirEdit.Location = new System.Drawing.Point(17, 346);
            this.rbHadirEdit.Name = "rbHadirEdit";
            this.rbHadirEdit.Size = new System.Drawing.Size(50, 17);
            this.rbHadirEdit.TabIndex = 30;
            this.rbHadirEdit.TabStop = true;
            this.rbHadirEdit.Text = "Hadir";
            this.rbHadirEdit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Attendance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // IDBoxEdit
            // 
            this.IDBoxEdit.Location = new System.Drawing.Point(14, 292);
            this.IDBoxEdit.Name = "IDBoxEdit";
            this.IDBoxEdit.Size = new System.Drawing.Size(320, 20);
            this.IDBoxEdit.TabIndex = 27;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(14, 373);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(320, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Submit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "ADD ATTENDANCE";
            // 
            // addAttBox
            // 
            this.addAttBox.Location = new System.Drawing.Point(14, 58);
            this.addAttBox.Name = "addAttBox";
            this.addAttBox.Size = new System.Drawing.Size(320, 20);
            this.addAttBox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Name";
            // 
            // rbAbsentAdd
            // 
            this.rbAbsentAdd.AutoSize = true;
            this.rbAbsentAdd.Location = new System.Drawing.Point(122, 158);
            this.rbAbsentAdd.Name = "rbAbsentAdd";
            this.rbAbsentAdd.Size = new System.Drawing.Size(58, 17);
            this.rbAbsentAdd.TabIndex = 45;
            this.rbAbsentAdd.TabStop = true;
            this.rbAbsentAdd.Text = "Absent";
            this.rbAbsentAdd.UseVisualStyleBackColor = true;
            // 
            // rbIzinAdd
            // 
            this.rbIzinAdd.AutoSize = true;
            this.rbIzinAdd.Location = new System.Drawing.Point(75, 158);
            this.rbIzinAdd.Name = "rbIzinAdd";
            this.rbIzinAdd.Size = new System.Drawing.Size(41, 17);
            this.rbIzinAdd.TabIndex = 44;
            this.rbIzinAdd.TabStop = true;
            this.rbIzinAdd.Text = "Izin";
            this.rbIzinAdd.UseVisualStyleBackColor = true;
            // 
            // rbHadirAdd
            // 
            this.rbHadirAdd.AutoSize = true;
            this.rbHadirAdd.Location = new System.Drawing.Point(20, 158);
            this.rbHadirAdd.Name = "rbHadirAdd";
            this.rbHadirAdd.Size = new System.Drawing.Size(50, 17);
            this.rbHadirAdd.TabIndex = 43;
            this.rbHadirAdd.TabStop = true;
            this.rbHadirAdd.Text = "Hadir";
            this.rbHadirAdd.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Attendance";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 23);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(362, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Event";
            // 
            // cBoxDisplay
            // 
            this.cBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxDisplay.FormattingEnabled = true;
            this.cBoxDisplay.Location = new System.Drawing.Point(408, 11);
            this.cBoxDisplay.Name = "cBoxDisplay";
            this.cBoxDisplay.Size = new System.Drawing.Size(463, 21);
            this.cBoxDisplay.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 485);
            this.dataGridView1.TabIndex = 53;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(877, 9);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 23);
            this.btnShow.TabIndex = 54;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(365, 534);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(614, 23);
            this.btnExport.TabIndex = 55;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbAddAtt
            // 
            this.cbAddAtt.FormattingEnabled = true;
            this.cbAddAtt.Location = new System.Drawing.Point(14, 105);
            this.cbAddAtt.Name = "cbAddAtt";
            this.cbAddAtt.Size = new System.Drawing.Size(320, 21);
            this.cbAddAtt.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Event";
            // 
            // rbTelatEdit
            // 
            this.rbTelatEdit.AutoSize = true;
            this.rbTelatEdit.Location = new System.Drawing.Point(183, 346);
            this.rbTelatEdit.Name = "rbTelatEdit";
            this.rbTelatEdit.Size = new System.Drawing.Size(49, 17);
            this.rbTelatEdit.TabIndex = 58;
            this.rbTelatEdit.TabStop = true;
            this.rbTelatEdit.Text = "Telat";
            this.rbTelatEdit.UseVisualStyleBackColor = true;
            // 
            // rbTelatAdd
            // 
            this.rbTelatAdd.AutoSize = true;
            this.rbTelatAdd.Location = new System.Drawing.Point(186, 158);
            this.rbTelatAdd.Name = "rbTelatAdd";
            this.rbTelatAdd.Size = new System.Drawing.Size(49, 17);
            this.rbTelatAdd.TabIndex = 59;
            this.rbTelatAdd.TabStop = true;
            this.rbTelatAdd.Text = "Telat";
            this.rbTelatAdd.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 23);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AttendanceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 562);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbTelatAdd);
            this.Controls.Add(this.rbTelatEdit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbAddAtt);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBoxDisplay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rbAbsentAdd);
            this.Controls.Add(this.rbIzinAdd);
            this.Controls.Add(this.rbHadirAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addAttBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDBoxDel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbAbsentEdit);
            this.Controls.Add(this.rbIzinEdit);
            this.Controls.Add(this.rbHadirEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBoxEdit);
            this.Controls.Add(this.btnEdit);
            this.Name = "AttendanceManager";
            this.Text = "Attendance Manager";
            this.Load += new System.EventHandler(this.AttendanceManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDBoxDel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAbsentEdit;
        private System.Windows.Forms.RadioButton rbIzinEdit;
        private System.Windows.Forms.RadioButton rbHadirEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBoxEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addAttBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAbsentAdd;
        private System.Windows.Forms.RadioButton rbIzinAdd;
        private System.Windows.Forms.RadioButton rbHadirAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBoxDisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbAddAtt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbTelatEdit;
        private System.Windows.Forms.RadioButton rbTelatAdd;
        private System.Windows.Forms.Button btnBack;
    }
}