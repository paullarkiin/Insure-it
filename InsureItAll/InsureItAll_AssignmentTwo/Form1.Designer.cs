namespace InsureItAll_AssignmentTwo
{
    partial class frm_Personal
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
            this.coBoxEmp = new System.Windows.Forms.ComboBox();
            this.coBoxMarital = new System.Windows.Forms.ComboBox();
            this.txtBoxSname = new System.Windows.Forms.TextBox();
            this.txtBoxFname = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxHouseNo = new System.Windows.Forms.TextBox();
            this.txtBoxPostcode = new System.Windows.Forms.TextBox();
            this.txtBoxAdStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_CreateDPolicy = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.coBoxOccup = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.coBoxTitle = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coBoxEmp
            // 
            this.coBoxEmp.FormattingEnabled = true;
            this.coBoxEmp.Items.AddRange(new object[] {
            "Please Select",
            "Employed",
            "Self Employed",
            "Retired",
            "Unemployed",
            "Housewife/House Husband",
            "Full Time Student"});
            this.coBoxEmp.Location = new System.Drawing.Point(108, 304);
            this.coBoxEmp.Name = "coBoxEmp";
            this.coBoxEmp.Size = new System.Drawing.Size(201, 21);
            this.coBoxEmp.TabIndex = 0;
            this.coBoxEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSname_KeyPress);
            this.coBoxEmp.Leave += new System.EventHandler(this.CoBoxEmp_Leave);
            this.coBoxEmp.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxFname_Validating);
            // 
            // coBoxMarital
            // 
            this.coBoxMarital.FormattingEnabled = true;
            this.coBoxMarital.Items.AddRange(new object[] {
            "Please Select",
            "Single",
            "Married",
            "Partner",
            "Separated",
            "Divorced",
            "Widowed"});
            this.coBoxMarital.Location = new System.Drawing.Point(615, 59);
            this.coBoxMarital.Name = "coBoxMarital";
            this.coBoxMarital.Size = new System.Drawing.Size(166, 21);
            this.coBoxMarital.TabIndex = 2;
            this.coBoxMarital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxAdStreet_KeyPress);
            this.coBoxMarital.Leave += new System.EventHandler(this.CoBoxMarital_Leave);
            // 
            // txtBoxSname
            // 
            this.txtBoxSname.Location = new System.Drawing.Point(272, 138);
            this.txtBoxSname.Name = "txtBoxSname";
            this.txtBoxSname.Size = new System.Drawing.Size(158, 21);
            this.txtBoxSname.TabIndex = 4;
            this.txtBoxSname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSname_KeyPress);
            this.txtBoxSname.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxFname_Validating);
            // 
            // txtBoxFname
            // 
            this.txtBoxFname.Location = new System.Drawing.Point(108, 138);
            this.txtBoxFname.Name = "txtBoxFname";
            this.txtBoxFname.Size = new System.Drawing.Size(145, 21);
            this.txtBoxFname.TabIndex = 5;
            this.txtBoxFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSname_KeyPress);
            this.txtBoxFname.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxFname_Validating);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(108, 253);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(200, 21);
            this.txtBoxPhone.TabIndex = 6;
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(30, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(30, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(30, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Empolyment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(494, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marital Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(494, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // txtBoxHouseNo
            // 
            this.txtBoxHouseNo.Location = new System.Drawing.Point(615, 190);
            this.txtBoxHouseNo.Name = "txtBoxHouseNo";
            this.txtBoxHouseNo.Size = new System.Drawing.Size(166, 21);
            this.txtBoxHouseNo.TabIndex = 14;
            this.txtBoxHouseNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxHouseNo_KeyPress);
            this.txtBoxHouseNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxFname_Validating);
            // 
            // txtBoxPostcode
            // 
            this.txtBoxPostcode.Location = new System.Drawing.Point(615, 289);
            this.txtBoxPostcode.Name = "txtBoxPostcode";
            this.txtBoxPostcode.Size = new System.Drawing.Size(166, 21);
            this.txtBoxPostcode.TabIndex = 15;
            // 
            // txtBoxAdStreet
            // 
            this.txtBoxAdStreet.Location = new System.Drawing.Point(615, 235);
            this.txtBoxAdStreet.Name = "txtBoxAdStreet";
            this.txtBoxAdStreet.Size = new System.Drawing.Size(166, 21);
            this.txtBoxAdStreet.TabIndex = 16;
            this.txtBoxAdStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxAdStreet_KeyPress);
            this.txtBoxAdStreet.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxFname_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(545, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "HouseNo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(545, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(545, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Postcode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(105, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Forename";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(269, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Surname";
            // 
            // btn_CreateDPolicy
            // 
            this.btn_CreateDPolicy.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_CreateDPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateDPolicy.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_CreateDPolicy.Location = new System.Drawing.Point(497, 366);
            this.btn_CreateDPolicy.Name = "btn_CreateDPolicy";
            this.btn_CreateDPolicy.Size = new System.Drawing.Size(104, 38);
            this.btn_CreateDPolicy.TabIndex = 22;
            this.btn_CreateDPolicy.Text = "Next";
            this.btn_CreateDPolicy.UseVisualStyleBackColor = true;
            this.btn_CreateDPolicy.Click += new System.EventHandler(this.btn_CreateDPolicy_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.CausesValidation = false;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_Exit.Location = new System.Drawing.Point(652, 366);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 38);
            this.btn_Exit.TabIndex = 23;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(108, 197);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerDOB.TabIndex = 24;
            this.dateTimePickerDOB.Leave += new System.EventHandler(this.DateTimePickerDOB_Leave);
            // 
            // coBoxOccup
            // 
            this.coBoxOccup.FormattingEnabled = true;
            this.coBoxOccup.Location = new System.Drawing.Point(108, 360);
            this.coBoxOccup.Name = "coBoxOccup";
            this.coBoxOccup.Size = new System.Drawing.Size(200, 21);
            this.coBoxOccup.TabIndex = 25;
            this.coBoxOccup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSname_KeyPress);
            this.coBoxOccup.Leave += new System.EventHandler(this.CoBoxOccup_Leave);
            this.coBoxOccup.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxFname_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(30, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Occupation";
            // 
            // coBoxTitle
            // 
            this.coBoxTitle.FormattingEnabled = true;
            this.coBoxTitle.Items.AddRange(new object[] {
            "Please Select",
            "Mr",
            "Mrs",
            "Ms",
            "Dr"});
            this.coBoxTitle.Location = new System.Drawing.Point(108, 59);
            this.coBoxTitle.Name = "coBoxTitle";
            this.coBoxTitle.Size = new System.Drawing.Size(121, 21);
            this.coBoxTitle.TabIndex = 27;
            this.coBoxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxSname_KeyPress);
            this.coBoxTitle.Leave += new System.EventHandler(this.CoBoxTitle_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 33);
            this.label14.TabIndex = 28;
            this.label14.Text = "Driver Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(494, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(615, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 21);
            this.textBox1.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(30, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Number";
            // 
            // frm_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.coBoxTitle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.coBoxOccup);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_CreateDPolicy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxAdStreet);
            this.Controls.Add(this.txtBoxPostcode);
            this.Controls.Add(this.txtBoxHouseNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxFname);
            this.Controls.Add(this.txtBoxSname);
            this.Controls.Add(this.coBoxMarital);
            this.Controls.Add(this.coBoxEmp);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coBoxEmp;
        private System.Windows.Forms.ComboBox coBoxMarital;
        private System.Windows.Forms.TextBox txtBoxSname;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxHouseNo;
        private System.Windows.Forms.TextBox txtBoxPostcode;
        private System.Windows.Forms.TextBox txtBoxAdStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_CreateDPolicy;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox coBoxOccup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxFname;
        private System.Windows.Forms.ComboBox coBoxTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
    }
}

