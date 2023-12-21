namespace Attendance
{
    partial class ManageAccounts
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
            this.warning = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PangkatBox = new System.Windows.Forms.TextBox();
            this.NamaBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.IDBoxDel = new System.Windows.Forms.TextBox();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // warning
            // 
            this.warning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Black;
            this.warning.Location = new System.Drawing.Point(12, 328);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 16);
            this.warning.TabIndex = 11;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 32);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(250, 20);
            this.EmailBox.TabIndex = 9;
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(12, 301);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(250, 24);
            this.btnAddAcc.TabIndex = 8;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pangkat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 264);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(250, 20);
            this.PasswordBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // PangkatBox
            // 
            this.PangkatBox.Location = new System.Drawing.Point(12, 146);
            this.PangkatBox.Name = "PangkatBox";
            this.PangkatBox.Size = new System.Drawing.Size(250, 20);
            this.PangkatBox.TabIndex = 10;
            // 
            // NamaBox
            // 
            this.NamaBox.Location = new System.Drawing.Point(12, 87);
            this.NamaBox.Name = "NamaBox";
            this.NamaBox.Size = new System.Drawing.Size(250, 20);
            this.NamaBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 480);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(13, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(249, 32);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back to Main Admin Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID";
            // 
            // IDBoxDel
            // 
            this.IDBoxDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IDBoxDel.Location = new System.Drawing.Point(12, 390);
            this.IDBoxDel.Name = "IDBoxDel";
            this.IDBoxDel.Size = new System.Drawing.Size(250, 20);
            this.IDBoxDel.TabIndex = 27;
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelAcc.Location = new System.Drawing.Point(12, 416);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(250, 23);
            this.btnDelAcc.TabIndex = 26;
            this.btnDelAcc.Text = "DELETE";
            this.btnDelAcc.UseVisualStyleBackColor = true;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Assign Event (Operator only)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 505);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDBoxDel);
            this.Controls.Add(this.btnDelAcc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NamaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.PangkatBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManageAccounts";
            this.Text = "Manage Accounts";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PangkatBox;
        private System.Windows.Forms.TextBox NamaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDBoxDel;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}