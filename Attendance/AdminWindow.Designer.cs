namespace Attendance
{
    partial class AdminWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.rbAlfa = new System.Windows.Forms.RadioButton();
            this.rbIzin = new System.Windows.Forms.RadioButton();
            this.rbHadir = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDBoxDel = new System.Windows.Forms.TextBox();
            this.btnDelAttendance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(15, 180);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(294, 20);
            this.IDBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attendance";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(15, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Export Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManageAcc.Location = new System.Drawing.Point(15, 489);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(145, 23);
            this.btnManageAcc.TabIndex = 9;
            this.btnManageAcc.Text = "Manage accounts";
            this.btnManageAcc.UseVisualStyleBackColor = true;
            this.btnManageAcc.Click += new System.EventHandler(this.btnManageAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ADMIN";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Location = new System.Drawing.Point(164, 489);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 97);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(48, 16);
            this.lblNama.TabIndex = 13;
            this.lblNama.Text = "Nama";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(12, 68);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 16);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email";
            // 
            // rbAlfa
            // 
            this.rbAlfa.AutoSize = true;
            this.rbAlfa.Location = new System.Drawing.Point(120, 234);
            this.rbAlfa.Name = "rbAlfa";
            this.rbAlfa.Size = new System.Drawing.Size(62, 17);
            this.rbAlfa.TabIndex = 16;
            this.rbAlfa.TabStop = true;
            this.rbAlfa.Text = "No inpo";
            this.rbAlfa.UseVisualStyleBackColor = true;
            // 
            // rbIzin
            // 
            this.rbIzin.AutoSize = true;
            this.rbIzin.Location = new System.Drawing.Point(73, 234);
            this.rbIzin.Name = "rbIzin";
            this.rbIzin.Size = new System.Drawing.Size(41, 17);
            this.rbIzin.TabIndex = 15;
            this.rbIzin.TabStop = true;
            this.rbIzin.Text = "Izin";
            this.rbIzin.UseVisualStyleBackColor = true;
            // 
            // rbHadir
            // 
            this.rbHadir.AutoSize = true;
            this.rbHadir.Location = new System.Drawing.Point(18, 234);
            this.rbHadir.Name = "rbHadir";
            this.rbHadir.Size = new System.Drawing.Size(50, 17);
            this.rbHadir.TabIndex = 14;
            this.rbHadir.TabStop = true;
            this.rbHadir.Text = "Hadir";
            this.rbHadir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "EDIT ATTENDANCE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "DELETE ATTENDANCE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID";
            // 
            // IDBoxDel
            // 
            this.IDBoxDel.Location = new System.Drawing.Point(15, 366);
            this.IDBoxDel.Name = "IDBoxDel";
            this.IDBoxDel.Size = new System.Drawing.Size(294, 20);
            this.IDBoxDel.TabIndex = 19;
            // 
            // btnDelAttendance
            // 
            this.btnDelAttendance.Location = new System.Drawing.Point(15, 392);
            this.btnDelAttendance.Name = "btnDelAttendance";
            this.btnDelAttendance.Size = new System.Drawing.Size(294, 23);
            this.btnDelAttendance.TabIndex = 18;
            this.btnDelAttendance.Text = "DELETE";
            this.btnDelAttendance.UseVisualStyleBackColor = true;
            this.btnDelAttendance.Click += new System.EventHandler(this.btnDelAttendance_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDBoxDel);
            this.Controls.Add(this.btnDelAttendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbAlfa);
            this.Controls.Add(this.rbIzin);
            this.Controls.Add(this.rbHadir);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnManageAcc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminWindow";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.RadioButton rbAlfa;
        private System.Windows.Forms.RadioButton rbIzin;
        private System.Windows.Forms.RadioButton rbHadir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDBoxDel;
        private System.Windows.Forms.Button btnDelAttendance;
    }
}