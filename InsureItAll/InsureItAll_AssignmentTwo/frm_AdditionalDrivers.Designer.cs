namespace InsureItAll_AssignmentTwo
{
    partial class frm_AdditionalDrivers
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
            this.coBoxAdditionalTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAddDOB = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAdditionalFname = new System.Windows.Forms.TextBox();
            this.txtBoxAdditionalSname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.coBoxAdditionalOccup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddAnotherDriver = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.coBoxRelation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxRelationOther = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.coBoxAdditonalEmp = new System.Windows.Forms.ComboBox();
            this.txtBoxAddClaimsAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dTPickerAddClaimsDate = new System.Windows.Forms.DateTimePicker();
            this.coBoxAddPastClaims = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AddDriversClaims = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coBoxAdditionalTitle
            // 
            this.coBoxAdditionalTitle.FormattingEnabled = true;
            this.coBoxAdditionalTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Dr",
            "Please Select"});
            this.coBoxAdditionalTitle.Location = new System.Drawing.Point(89, 72);
            this.coBoxAdditionalTitle.Name = "coBoxAdditionalTitle";
            this.coBoxAdditionalTitle.Size = new System.Drawing.Size(136, 21);
            this.coBoxAdditionalTitle.TabIndex = 28;
            this.coBoxAdditionalTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            this.coBoxAdditionalTitle.Leave += new System.EventHandler(this.coBoxAdditionalTitle_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Title";
            // 
            // dateTimePickerAddDOB
            // 
            this.dateTimePickerAddDOB.Location = new System.Drawing.Point(89, 207);
            this.dateTimePickerAddDOB.Name = "dateTimePickerAddDOB";
            this.dateTimePickerAddDOB.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerAddDOB.TabIndex = 38;
            this.dateTimePickerAddDOB.Leave += new System.EventHandler(this.DateTimePickerAddDOB_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(246, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Surname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(86, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "DOB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name:";
            // 
            // txtBoxAdditionalFname
            // 
            this.txtBoxAdditionalFname.Location = new System.Drawing.Point(89, 151);
            this.txtBoxAdditionalFname.Name = "txtBoxAdditionalFname";
            this.txtBoxAdditionalFname.Size = new System.Drawing.Size(136, 21);
            this.txtBoxAdditionalFname.TabIndex = 33;
            this.txtBoxAdditionalFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            this.txtBoxAdditionalFname.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxAdditionalFname_Validating);
            // 
            // txtBoxAdditionalSname
            // 
            this.txtBoxAdditionalSname.Location = new System.Drawing.Point(249, 151);
            this.txtBoxAdditionalSname.Name = "txtBoxAdditionalSname";
            this.txtBoxAdditionalSname.Size = new System.Drawing.Size(136, 21);
            this.txtBoxAdditionalSname.TabIndex = 32;
            this.txtBoxAdditionalSname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(443, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Empolyment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(443, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Occupation";
            // 
            // coBoxAdditionalOccup
            // 
            this.coBoxAdditionalOccup.FormattingEnabled = true;
            this.coBoxAdditionalOccup.Location = new System.Drawing.Point(520, 109);
            this.coBoxAdditionalOccup.Name = "coBoxAdditionalOccup";
            this.coBoxAdditionalOccup.Size = new System.Drawing.Size(168, 21);
            this.coBoxAdditionalOccup.TabIndex = 41;
            this.coBoxAdditionalOccup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            this.coBoxAdditionalOccup.Leave += new System.EventHandler(this.coBoxAdditionalOccup_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(446, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Relationship to Policy Holder";
            // 
            // btn_AddAnotherDriver
            // 
            this.btn_AddAnotherDriver.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AddAnotherDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAnotherDriver.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_AddAnotherDriver.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_AddAnotherDriver.Location = new System.Drawing.Point(89, 459);
            this.btn_AddAnotherDriver.Name = "btn_AddAnotherDriver";
            this.btn_AddAnotherDriver.Size = new System.Drawing.Size(128, 32);
            this.btn_AddAnotherDriver.TabIndex = 45;
            this.btn_AddAnotherDriver.Text = "Add Another Driver";
            this.btn_AddAnotherDriver.UseVisualStyleBackColor = true;
            this.btn_AddAnotherDriver.Click += new System.EventHandler(this.btn_AddAnotherDriver_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_Continue.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Continue.Location = new System.Drawing.Point(494, 459);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(99, 32);
            this.btn_Continue.TabIndex = 46;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // coBoxRelation
            // 
            this.coBoxRelation.FormattingEnabled = true;
            this.coBoxRelation.Items.AddRange(new object[] {
            "Husband",
            "Wife",
            "Son",
            "Daughter",
            "Please Select"});
            this.coBoxRelation.Location = new System.Drawing.Point(520, 181);
            this.coBoxRelation.Name = "coBoxRelation";
            this.coBoxRelation.Size = new System.Drawing.Size(168, 21);
            this.coBoxRelation.TabIndex = 47;
            this.coBoxRelation.SelectedIndexChanged += new System.EventHandler(this.CoBoxRelation_SelectedIndexChanged);
            this.coBoxRelation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            this.coBoxRelation.Leave += new System.EventHandler(this.coBoxRelation_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(443, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Other";
            // 
            // txtBoxRelationOther
            // 
            this.txtBoxRelationOther.Location = new System.Drawing.Point(520, 231);
            this.txtBoxRelationOther.Name = "txtBoxRelationOther";
            this.txtBoxRelationOther.Size = new System.Drawing.Size(168, 21);
            this.txtBoxRelationOther.TabIndex = 48;
            this.txtBoxRelationOther.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15.25F);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Additonal Drivers";
            // 
            // coBoxAdditonalEmp
            // 
            this.coBoxAdditonalEmp.FormattingEnabled = true;
            this.coBoxAdditonalEmp.Items.AddRange(new object[] {
            "Employment",
            "Self Employed",
            "Retired",
            "Unemployed",
            "Housewife / House Husband",
            "Full Time Student",
            "Please Select"});
            this.coBoxAdditonalEmp.Location = new System.Drawing.Point(520, 69);
            this.coBoxAdditonalEmp.Name = "coBoxAdditonalEmp";
            this.coBoxAdditonalEmp.Size = new System.Drawing.Size(168, 21);
            this.coBoxAdditonalEmp.TabIndex = 39;
            this.coBoxAdditonalEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            this.coBoxAdditonalEmp.Leave += new System.EventHandler(this.coBoxAdditonalEmp_Leave);
            // 
            // txtBoxAddClaimsAmount
            // 
            this.txtBoxAddClaimsAmount.Location = new System.Drawing.Point(89, 379);
            this.txtBoxAddClaimsAmount.Name = "txtBoxAddClaimsAmount";
            this.txtBoxAddClaimsAmount.Size = new System.Drawing.Size(218, 21);
            this.txtBoxAddClaimsAmount.TabIndex = 56;
            this.txtBoxAddClaimsAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxAddClaimsAmount_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(15, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 26);
            this.label10.TabIndex = 55;
            this.label10.Text = "Claim \r\nAmount";
            // 
            // dTPickerAddClaimsDate
            // 
            this.dTPickerAddClaimsDate.Location = new System.Drawing.Point(89, 321);
            this.dTPickerAddClaimsDate.Name = "dTPickerAddClaimsDate";
            this.dTPickerAddClaimsDate.Size = new System.Drawing.Size(218, 21);
            this.dTPickerAddClaimsDate.TabIndex = 54;
            // 
            // coBoxAddPastClaims
            // 
            this.coBoxAddPastClaims.FormattingEnabled = true;
            this.coBoxAddPastClaims.Items.AddRange(new object[] {
            "Please Select",
            "Yes",
            "No"});
            this.coBoxAddPastClaims.Location = new System.Drawing.Point(89, 264);
            this.coBoxAddPastClaims.Name = "coBoxAddPastClaims";
            this.coBoxAddPastClaims.Size = new System.Drawing.Size(218, 21);
            this.coBoxAddPastClaims.TabIndex = 53;
            this.coBoxAddPastClaims.SelectedIndexChanged += new System.EventHandler(this.CoBoxAddPastClaims_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(12, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Claim Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(12, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Past Claims";
            // 
            // btn_AddDriversClaims
            // 
            this.btn_AddDriversClaims.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AddDriversClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDriversClaims.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_AddDriversClaims.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_AddDriversClaims.Location = new System.Drawing.Point(281, 459);
            this.btn_AddDriversClaims.Name = "btn_AddDriversClaims";
            this.btn_AddDriversClaims.Size = new System.Drawing.Size(145, 32);
            this.btn_AddDriversClaims.TabIndex = 57;
            this.btn_AddDriversClaims.Text = "Add Additional Claim";
            this.btn_AddDriversClaims.UseVisualStyleBackColor = true;
            this.btn_AddDriversClaims.Click += new System.EventHandler(this.Btn_AddDriversClaims_Click);
            // 
            // frm_AdditionalDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 514);
            this.Controls.Add(this.btn_AddDriversClaims);
            this.Controls.Add(this.txtBoxAddClaimsAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dTPickerAddClaimsDate);
            this.Controls.Add(this.coBoxAddPastClaims);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxRelationOther);
            this.Controls.Add(this.coBoxRelation);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_AddAnotherDriver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.coBoxAdditionalOccup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coBoxAdditonalEmp);
            this.Controls.Add(this.dateTimePickerAddDOB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAdditionalFname);
            this.Controls.Add(this.txtBoxAdditionalSname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coBoxAdditionalTitle);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_AdditionalDrivers";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_AdditionalDrivers_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coBoxAdditionalTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddDOB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAdditionalFname;
        private System.Windows.Forms.TextBox txtBoxAdditionalSname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox coBoxAdditionalOccup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddAnotherDriver;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.ComboBox coBoxRelation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxRelationOther;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox coBoxAdditonalEmp;
        private System.Windows.Forms.TextBox txtBoxAddClaimsAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dTPickerAddClaimsDate;
        private System.Windows.Forms.ComboBox coBoxAddPastClaims;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_AddDriversClaims;
    }
}