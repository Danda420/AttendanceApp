namespace Attendance
{
    partial class MemberWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.btnAbsen = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.rbHadir = new System.Windows.Forms.RadioButton();
            this.rbIzin = new System.Windows.Forms.RadioButton();
            this.rbAlfa = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendace History";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(12, 8);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 16);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // btnAbsen
            // 
            this.btnAbsen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsen.Location = new System.Drawing.Point(632, 8);
            this.btnAbsen.Name = "btnAbsen";
            this.btnAbsen.Size = new System.Drawing.Size(75, 23);
            this.btnAbsen.TabIndex = 3;
            this.btnAbsen.Text = "Absen";
            this.btnAbsen.UseVisualStyleBackColor = true;
            this.btnAbsen.Click += new System.EventHandler(this.btnAbsen_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(713, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 35);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(48, 16);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "Nama";
            // 
            // rbHadir
            // 
            this.rbHadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbHadir.AutoSize = true;
            this.rbHadir.Location = new System.Drawing.Point(632, 37);
            this.rbHadir.Name = "rbHadir";
            this.rbHadir.Size = new System.Drawing.Size(50, 17);
            this.rbHadir.TabIndex = 6;
            this.rbHadir.TabStop = true;
            this.rbHadir.Text = "Hadir";
            this.rbHadir.UseVisualStyleBackColor = true;
            // 
            // rbIzin
            // 
            this.rbIzin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbIzin.AutoSize = true;
            this.rbIzin.Location = new System.Drawing.Point(688, 37);
            this.rbIzin.Name = "rbIzin";
            this.rbIzin.Size = new System.Drawing.Size(41, 17);
            this.rbIzin.TabIndex = 7;
            this.rbIzin.TabStop = true;
            this.rbIzin.Text = "Izin";
            this.rbIzin.UseVisualStyleBackColor = true;
            // 
            // rbAlfa
            // 
            this.rbAlfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAlfa.AutoSize = true;
            this.rbAlfa.Location = new System.Drawing.Point(735, 37);
            this.rbAlfa.Name = "rbAlfa";
            this.rbAlfa.Size = new System.Drawing.Size(62, 17);
            this.rbAlfa.TabIndex = 8;
            this.rbAlfa.TabStop = true;
            this.rbAlfa.Text = "No inpo";
            this.rbAlfa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // MemberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbAlfa);
            this.Controls.Add(this.rbIzin);
            this.Controls.Add(this.rbHadir);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAbsen);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MemberWindow";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button btnAbsen;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.RadioButton rbHadir;
        private System.Windows.Forms.RadioButton rbIzin;
        private System.Windows.Forms.RadioButton rbAlfa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}