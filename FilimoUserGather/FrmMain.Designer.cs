namespace FilimoUserGather
{
    partial class FrmMain
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
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_users = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_clearUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_count)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre Link";
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(13, 48);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(227, 20);
            this.txt_link.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(246, 48);
            this.txt_count.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.txt_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(98, 20);
            this.txt_count.TabIndex = 5;
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_count);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_link);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_users);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 265);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // txt_users
            // 
            this.txt_users.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_users.Location = new System.Drawing.Point(13, 19);
            this.txt_users.Multiline = true;
            this.txt_users.Name = "txt_users";
            this.txt_users.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_users.Size = new System.Drawing.Size(338, 230);
            this.txt_users.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(356, 9);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(25, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "█";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_clearUsers
            // 
            this.btn_clearUsers.Location = new System.Drawing.Point(312, 9);
            this.btn_clearUsers.Name = "btn_clearUsers";
            this.btn_clearUsers.Size = new System.Drawing.Size(38, 23);
            this.btn_clearUsers.TabIndex = 6;
            this.btn_clearUsers.Text = "cls";
            this.btn_clearUsers.UseVisualStyleBackColor = true;
            this.btn_clearUsers.Click += new System.EventHandler(this.btn_clearUsers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gathred Users will save to \'users.txt\' in application path";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clearUsers);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filimo User Gather { MHNCR0Software }";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_count)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_users;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_clearUsers;
        private System.Windows.Forms.Label label2;
    }
}

