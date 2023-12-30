namespace project
{
    partial class Librariyan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librariyan));
            this.txtwellcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.Librariyan_password = new System.Windows.Forms.TextBox();
            this.txtLibrariyan_username = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtwellcome
            // 
            this.txtwellcome.AutoSize = true;
            this.txtwellcome.BackColor = System.Drawing.Color.Magenta;
            this.txtwellcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtwellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwellcome.ForeColor = System.Drawing.Color.Snow;
            this.txtwellcome.Location = new System.Drawing.Point(50, 31);
            this.txtwellcome.Name = "txtwellcome";
            this.txtwellcome.Size = new System.Drawing.Size(639, 46);
            this.txtwellcome.TabIndex = 21;
            this.txtwellcome.Text = "Wellcome To LULZ Library System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 120);
            this.panel1.TabIndex = 22;
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(202, 306);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(85, 18);
            this.txtusername.TabIndex = 24;
            this.txtusername.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(202, 360);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(83, 18);
            this.txtpassword.TabIndex = 25;
            this.txtpassword.Text = "Password";
            // 
            // Librariyan_password
            // 
            this.Librariyan_password.Location = new System.Drawing.Point(321, 359);
            this.Librariyan_password.Multiline = true;
            this.Librariyan_password.Name = "Librariyan_password";
            this.Librariyan_password.Size = new System.Drawing.Size(184, 20);
            this.Librariyan_password.TabIndex = 27;
            // 
            // txtLibrariyan_username
            // 
            this.txtLibrariyan_username.Location = new System.Drawing.Point(321, 304);
            this.txtLibrariyan_username.Multiline = true;
            this.txtLibrariyan_username.Name = "txtLibrariyan_username";
            this.txtLibrariyan_username.Size = new System.Drawing.Size(184, 20);
            this.txtLibrariyan_username.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(337, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogin1
            // 
            this.btnLogin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin1.BackColor = System.Drawing.Color.Blue;
            this.btnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin1.Location = new System.Drawing.Point(492, 424);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(75, 23);
            this.btnLogin1.TabIndex = 28;
            this.btnLogin1.Text = "Login";
            this.btnLogin1.UseVisualStyleBackColor = false;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // Librariyan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.Librariyan_password);
            this.Controls.Add(this.txtLibrariyan_username);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.txtwellcome);
            this.Controls.Add(this.panel1);
            this.Name = "Librariyan";
            this.Text = "Librariyan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtwellcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtusername;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.TextBox Librariyan_password;
        private System.Windows.Forms.TextBox txtLibrariyan_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogin1;
    }
}