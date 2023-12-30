namespace project
{
    partial class Home
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
            this.txtwellcome = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabReservaion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAddBookName = new System.Windows.Forms.TextBox();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvBookView = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddBookAuther = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudCoppys = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoanNic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addLoanBook = new System.Windows.Forms.ComboBox();
            this.btnViewLoans = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gvLoanView = new System.Windows.Forms.DataGridView();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtloadAuth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage312 = new System.Windows.Forms.TabPage();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBook_Name = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.tabPage385 = new System.Windows.Forms.TabPage();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBook_name1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabReservaion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoppys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoanView)).BeginInit();
            this.tabPage312.SuspendLayout();
            this.tabPage385.SuspendLayout();
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
            this.txtwellcome.Location = new System.Drawing.Point(13, 19);
            this.txtwellcome.Name = "txtwellcome";
            this.txtwellcome.Size = new System.Drawing.Size(639, 46);
            this.txtwellcome.TabIndex = 19;
            this.txtwellcome.Text = "Wellcome To LULZ Library System";
            // 
            // btnexit
            // 
            this.btnexit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexit.Location = new System.Drawing.Point(32, 407);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 31);
            this.btnexit.TabIndex = 22;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Location = new System.Drawing.Point(-34, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 120);
            this.panel1.TabIndex = 20;
            // 
            // tabReservaion
            // 
            this.tabReservaion.Controls.Add(this.tabPage1);
            this.tabReservaion.Controls.Add(this.tabPage2);
            this.tabReservaion.Controls.Add(this.tabPage312);
            this.tabReservaion.Controls.Add(this.tabPage385);
            this.tabReservaion.Location = new System.Drawing.Point(12, 116);
            this.tabReservaion.Name = "tabReservaion";
            this.tabReservaion.SelectedIndex = 0;
            this.tabReservaion.Size = new System.Drawing.Size(776, 269);
            this.tabReservaion.TabIndex = 30;
            this.tabReservaion.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAddBookName);
            this.tabPage1.Controls.Add(this.btnViewBooks);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gvBookView);
            this.tabPage1.Controls.Add(this.btnAddBook);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtAddBookAuther);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAddBookName
            // 
            this.txtAddBookName.Location = new System.Drawing.Point(118, 64);
            this.txtAddBookName.Name = "txtAddBookName";
            this.txtAddBookName.Size = new System.Drawing.Size(121, 20);
            this.txtAddBookName.TabIndex = 14;
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.Location = new System.Drawing.Point(330, 214);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.Size = new System.Drawing.Size(75, 23);
            this.btnViewBooks.TabIndex = 10;
            this.btnViewBooks.Text = "View Books";
            this.btnViewBooks.UseVisualStyleBackColor = true;
            this.btnViewBooks.Click += new System.EventHandler(this.btnViewBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "View Books";
            // 
            // gvBookView
            // 
            this.gvBookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookView.Location = new System.Drawing.Point(330, 37);
            this.gvBookView.Name = "gvBookView";
            this.gvBookView.Size = new System.Drawing.Size(430, 173);
            this.gvBookView.TabIndex = 8;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(143, 187);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add Books";
            // 
            // txtAddBookAuther
            // 
            this.txtAddBookAuther.Location = new System.Drawing.Point(118, 139);
            this.txtAddBookAuther.Name = "txtAddBookAuther";
            this.txtAddBookAuther.Size = new System.Drawing.Size(121, 20);
            this.txtAddBookAuther.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Auther :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLoanAmount);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.nudCoppys);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtLoanNic);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.addLoanBook);
            this.tabPage2.Controls.Add(this.btnViewLoans);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.gvLoanView);
            this.tabPage2.Controls.Add(this.btnAddLoan);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtloadAuth);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(112, 176);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(121, 20);
            this.txtLoanAmount.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Loan Amount :";
            // 
            // nudCoppys
            // 
            this.nudCoppys.Location = new System.Drawing.Point(113, 119);
            this.nudCoppys.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCoppys.Name = "nudCoppys";
            this.nudCoppys.Size = new System.Drawing.Size(120, 20);
            this.nudCoppys.TabIndex = 26;
            this.nudCoppys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCoppys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Number of coppys :";
            // 
            // txtLoanNic
            // 
            this.txtLoanNic.Location = new System.Drawing.Point(113, 147);
            this.txtLoanNic.Name = "txtLoanNic";
            this.txtLoanNic.Size = new System.Drawing.Size(121, 20);
            this.txtLoanNic.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "NIC :";
            // 
            // addLoanBook
            // 
            this.addLoanBook.FormattingEnabled = true;
            this.addLoanBook.Location = new System.Drawing.Point(113, 52);
            this.addLoanBook.Name = "addLoanBook";
            this.addLoanBook.Size = new System.Drawing.Size(121, 21);
            this.addLoanBook.TabIndex = 22;
            this.addLoanBook.SelectedIndexChanged += new System.EventHandler(this.addLoanBook_SelectedIndexChanged);
            // 
            // btnViewLoans
            // 
            this.btnViewLoans.Location = new System.Drawing.Point(325, 207);
            this.btnViewLoans.Name = "btnViewLoans";
            this.btnViewLoans.Size = new System.Drawing.Size(75, 23);
            this.btnViewLoans.TabIndex = 19;
            this.btnViewLoans.Text = "View Loans";
            this.btnViewLoans.UseVisualStyleBackColor = true;
            this.btnViewLoans.Click += new System.EventHandler(this.btnViewLoans_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "View Books";
            // 
            // gvLoanView
            // 
            this.gvLoanView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLoanView.Location = new System.Drawing.Point(325, 30);
            this.gvLoanView.Name = "gvLoanView";
            this.gvLoanView.Size = new System.Drawing.Size(430, 173);
            this.gvLoanView.TabIndex = 17;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(158, 207);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(75, 23);
            this.btnAddLoan.TabIndex = 16;
            this.btnAddLoan.Text = "Add Loan";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Add Loan";
            // 
            // txtloadAuth
            // 
            this.txtloadAuth.Enabled = false;
            this.txtloadAuth.Location = new System.Drawing.Point(114, 85);
            this.txtloadAuth.Name = "txtloadAuth";
            this.txtloadAuth.Size = new System.Drawing.Size(121, 20);
            this.txtloadAuth.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Auther :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Book Name :";
            // 
            // tabPage312
            // 
            this.tabPage312.Controls.Add(this.btnReturn);
            this.tabPage312.Controls.Add(this.label12);
            this.tabPage312.Controls.Add(this.label13);
            this.tabPage312.Controls.Add(this.txtBook_Name);
            this.tabPage312.Controls.Add(this.txtNIC);
            this.tabPage312.Location = new System.Drawing.Point(4, 22);
            this.tabPage312.Name = "tabPage312";
            this.tabPage312.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage312.Size = new System.Drawing.Size(768, 243);
            this.tabPage312.TabIndex = 2;
            this.tabPage312.Text = "Return";
            this.tabPage312.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Location = new System.Drawing.Point(644, 121);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 29);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(421, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Book_Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(421, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "NIC";
            // 
            // txtBook_Name
            // 
            this.txtBook_Name.BackColor = System.Drawing.Color.White;
            this.txtBook_Name.Location = new System.Drawing.Point(545, 77);
            this.txtBook_Name.Name = "txtBook_Name";
            this.txtBook_Name.Size = new System.Drawing.Size(163, 20);
            this.txtBook_Name.TabIndex = 8;
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.White;
            this.txtNIC.Location = new System.Drawing.Point(545, 25);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(163, 20);
            this.txtNIC.TabIndex = 6;
            // 
            // tabPage385
            // 
            this.tabPage385.Controls.Add(this.txtName);
            this.tabPage385.Controls.Add(this.btnReserve);
            this.tabPage385.Controls.Add(this.label15);
            this.tabPage385.Controls.Add(this.label14);
            this.tabPage385.Controls.Add(this.txtBook_name1);
            this.tabPage385.Controls.Add(this.pictureBox2);
            this.tabPage385.Location = new System.Drawing.Point(4, 22);
            this.tabPage385.Name = "tabPage385";
            this.tabPage385.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage385.Size = new System.Drawing.Size(768, 243);
            this.tabPage385.TabIndex = 3;
            this.tabPage385.Text = "Reservation";
            this.tabPage385.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReserve.Location = new System.Drawing.Point(546, 203);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 31;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(197, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(197, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Book_Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-16, -105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(801, 452);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // txtBook_name1
            // 
            this.txtBook_name1.BackColor = System.Drawing.Color.White;
            this.txtBook_name1.Location = new System.Drawing.Point(321, 88);
            this.txtBook_name1.Name = "txtBook_name1";
            this.txtBook_name1.Size = new System.Drawing.Size(217, 20);
            this.txtBook_name1.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(321, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 20);
            this.txtName.TabIndex = 32;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabReservaion);
            this.Controls.Add(this.txtwellcome);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabReservaion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoppys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoanView)).EndInit();
            this.tabPage312.ResumeLayout(false);
            this.tabPage312.PerformLayout();
            this.tabPage385.ResumeLayout(false);
            this.tabPage385.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtwellcome;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabReservaion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvBookView;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddBookAuther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewBooks;
        private System.Windows.Forms.Button btnViewLoans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvLoanView;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtloadAuth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddBookName;
        private System.Windows.Forms.TextBox txtLoanNic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox addLoanBook;
        private System.Windows.Forms.NumericUpDown nudCoppys;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage312;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBook_Name;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TabPage tabPage385;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBook_name1;
    }
}