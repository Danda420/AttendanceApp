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
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.btnManageAttendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageAcc.Location = new System.Drawing.Point(12, 251);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(513, 23);
            this.btnManageAcc.TabIndex = 9;
            this.btnManageAcc.Text = "Manage accounts";
            this.btnManageAcc.UseVisualStyleBackColor = true;
            this.btnManageAcc.Click += new System.EventHandler(this.btnManageAcc_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ADMIN";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(12, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(513, 23);
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
            // btnManageAttendance
            // 
            this.btnManageAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageAttendance.Location = new System.Drawing.Point(12, 222);
            this.btnManageAttendance.Name = "btnManageAttendance";
            this.btnManageAttendance.Size = new System.Drawing.Size(513, 23);
            this.btnManageAttendance.TabIndex = 14;
            this.btnManageAttendance.Text = "Manage attendance";
            this.btnManageAttendance.UseVisualStyleBackColor = true;
            this.btnManageAttendance.Click += new System.EventHandler(this.btnManageAttendance_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 315);
            this.Controls.Add(this.btnManageAttendance);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnManageAcc);
            this.MaximizeBox = false;
            this.Name = "AdminWindow";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button btnManageAttendance;
    }
}