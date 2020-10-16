namespace InsureItAll_AssignmentTwo
{
    partial class frm_Vehicle
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
            this.txtBoxMMOther = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMiles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coBoxMM = new System.Windows.Forms.ComboBox();
            this.coBoxVehkept = new System.Windows.Forms.ComboBox();
            this.coBoxVehUsage = new System.Windows.Forms.ComboBox();
            this.btn_Quote = new System.Windows.Forms.Button();
            this.btn_NamedDrivers = new System.Windows.Forms.Button();
            this.DTPicker_PStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ProcessPolicys = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AddClaims = new System.Windows.Forms.Button();
            this.dTPickerClaimsDate = new System.Windows.Forms.DateTimePicker();
            this.coBoxPastClaims = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxClaimsAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxMMOther
            // 
            this.txtBoxMMOther.Location = new System.Drawing.Point(421, 121);
            this.txtBoxMMOther.Name = "txtBoxMMOther";
            this.txtBoxMMOther.Size = new System.Drawing.Size(175, 21);
            this.txtBoxMMOther.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(17, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make and Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(381, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Other";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(17, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehicle Kept";
            // 
            // txtBoxMiles
            // 
            this.txtBoxMiles.Location = new System.Drawing.Point(421, 177);
            this.txtBoxMiles.Name = "txtBoxMiles";
            this.txtBoxMiles.Size = new System.Drawing.Size(175, 21);
            this.txtBoxMiles.TabIndex = 9;
            this.txtBoxMiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxClaimsAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(381, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Miles";
            // 
            // coBoxMM
            // 
            this.coBoxMM.FormattingEnabled = true;
            this.coBoxMM.Location = new System.Drawing.Point(136, 121);
            this.coBoxMM.Name = "coBoxMM";
            this.coBoxMM.Size = new System.Drawing.Size(218, 21);
            this.coBoxMM.TabIndex = 12;
            this.coBoxMM.SelectedIndexChanged += new System.EventHandler(this.coBoxMM_SelectedIndexChanged);
            // 
            // coBoxVehkept
            // 
            this.coBoxVehkept.FormattingEnabled = true;
            this.coBoxVehkept.Items.AddRange(new object[] {
            "Public Road",
            "Private Drive",
            "Garage",
            "Please Select"});
            this.coBoxVehkept.Location = new System.Drawing.Point(136, 233);
            this.coBoxVehkept.Name = "coBoxVehkept";
            this.coBoxVehkept.Size = new System.Drawing.Size(218, 21);
            this.coBoxVehkept.TabIndex = 13;
            this.coBoxVehkept.Leave += new System.EventHandler(this.coBoxVehkept_Leave);
            // 
            // coBoxVehUsage
            // 
            this.coBoxVehUsage.FormattingEnabled = true;
            this.coBoxVehUsage.Items.AddRange(new object[] {
            "Social domestic pleasure",
            "Social and Commuting",
            "Business",
            "Please Select"});
            this.coBoxVehUsage.Location = new System.Drawing.Point(136, 177);
            this.coBoxVehUsage.Name = "coBoxVehUsage";
            this.coBoxVehUsage.Size = new System.Drawing.Size(218, 21);
            this.coBoxVehUsage.TabIndex = 14;
            this.coBoxVehUsage.SelectedIndexChanged += new System.EventHandler(this.coBoxVehUsage_SelectedIndexChanged);
            this.coBoxVehUsage.Leave += new System.EventHandler(this.coBoxVehUsage_Leave);
            // 
            // btn_Quote
            // 
            this.btn_Quote.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Quote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quote.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_Quote.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Quote.Location = new System.Drawing.Point(399, 476);
            this.btn_Quote.Name = "btn_Quote";
            this.btn_Quote.Size = new System.Drawing.Size(154, 40);
            this.btn_Quote.TabIndex = 15;
            this.btn_Quote.Text = "Get Quote";
            this.btn_Quote.UseVisualStyleBackColor = true;
            this.btn_Quote.Click += new System.EventHandler(this.btn_Quote_Click);
            // 
            // btn_NamedDrivers
            // 
            this.btn_NamedDrivers.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_NamedDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NamedDrivers.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_NamedDrivers.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_NamedDrivers.Location = new System.Drawing.Point(21, 476);
            this.btn_NamedDrivers.Name = "btn_NamedDrivers";
            this.btn_NamedDrivers.Size = new System.Drawing.Size(158, 40);
            this.btn_NamedDrivers.TabIndex = 16;
            this.btn_NamedDrivers.Text = "Add Additional Drivers";
            this.btn_NamedDrivers.UseVisualStyleBackColor = true;
            this.btn_NamedDrivers.Click += new System.EventHandler(this.btn_NamedDrivers_Click);
            // 
            // DTPicker_PStartDate
            // 
            this.DTPicker_PStartDate.Location = new System.Drawing.Point(136, 73);
            this.DTPicker_PStartDate.MinDate = new System.DateTime(2019, 12, 16, 0, 0, 0, 0);
            this.DTPicker_PStartDate.Name = "DTPicker_PStartDate";
            this.DTPicker_PStartDate.Size = new System.Drawing.Size(218, 21);
            this.DTPicker_PStartDate.TabIndex = 18;
            this.DTPicker_PStartDate.Leave += new System.EventHandler(this.DTPicker_PStartDate_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(15, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Policy Start Date";
            // 
            // btn_ProcessPolicys
            // 
            this.btn_ProcessPolicys.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ProcessPolicys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProcessPolicys.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.btn_ProcessPolicys.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_ProcessPolicys.Location = new System.Drawing.Point(502, 12);
            this.btn_ProcessPolicys.Name = "btn_ProcessPolicys";
            this.btn_ProcessPolicys.Size = new System.Drawing.Size(100, 28);
            this.btn_ProcessPolicys.TabIndex = 20;
            this.btn_ProcessPolicys.Text = "Process Policies";
            this.btn_ProcessPolicys.UseVisualStyleBackColor = true;
            this.btn_ProcessPolicys.Click += new System.EventHandler(this.Btn_ProcessPolicys_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 33);
            this.label9.TabIndex = 21;
            this.label9.Text = "Your Car";
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.btn_Exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Exit.Location = new System.Drawing.Point(502, 46);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 28);
            this.btn_Exit.TabIndex = 22;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(18, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Past Claims";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(18, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Claim Date";
            // 
            // btn_AddClaims
            // 
            this.btn_AddClaims.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AddClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddClaims.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_AddClaims.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_AddClaims.Location = new System.Drawing.Point(211, 476);
            this.btn_AddClaims.Name = "btn_AddClaims";
            this.btn_AddClaims.Size = new System.Drawing.Size(158, 40);
            this.btn_AddClaims.TabIndex = 26;
            this.btn_AddClaims.Text = "Add Additional Claim";
            this.btn_AddClaims.UseVisualStyleBackColor = true;
            this.btn_AddClaims.Click += new System.EventHandler(this.Btn_AddClaims_Click);
            // 
            // dTPickerClaimsDate
            // 
            this.dTPickerClaimsDate.Location = new System.Drawing.Point(136, 345);
            this.dTPickerClaimsDate.Name = "dTPickerClaimsDate";
            this.dTPickerClaimsDate.Size = new System.Drawing.Size(218, 21);
            this.dTPickerClaimsDate.TabIndex = 27;
            // 
            // coBoxPastClaims
            // 
            this.coBoxPastClaims.FormattingEnabled = true;
            this.coBoxPastClaims.Items.AddRange(new object[] {
            "Please Select",
            "Yes",
            "No"});
            this.coBoxPastClaims.Location = new System.Drawing.Point(136, 288);
            this.coBoxPastClaims.Name = "coBoxPastClaims";
            this.coBoxPastClaims.Size = new System.Drawing.Size(218, 21);
            this.coBoxPastClaims.TabIndex = 25;
            this.coBoxPastClaims.SelectedIndexChanged += new System.EventHandler(this.CoBoxPastClaims_SelectedIndexChanged);
            this.coBoxPastClaims.Leave += new System.EventHandler(this.coBoxPastClaims_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(18, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Claim Amount";
            // 
            // txtBoxClaimsAmount
            // 
            this.txtBoxClaimsAmount.Location = new System.Drawing.Point(136, 400);
            this.txtBoxClaimsAmount.Name = "txtBoxClaimsAmount";
            this.txtBoxClaimsAmount.Size = new System.Drawing.Size(218, 21);
            this.txtBoxClaimsAmount.TabIndex = 29;
            this.txtBoxClaimsAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxClaimsAmount_KeyPress);
            // 
            // frm_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 555);
            this.Controls.Add(this.txtBoxClaimsAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dTPickerClaimsDate);
            this.Controls.Add(this.btn_AddClaims);
            this.Controls.Add(this.coBoxPastClaims);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_ProcessPolicys);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTPicker_PStartDate);
            this.Controls.Add(this.btn_NamedDrivers);
            this.Controls.Add(this.btn_Quote);
            this.Controls.Add(this.coBoxVehUsage);
            this.Controls.Add(this.coBoxVehkept);
            this.Controls.Add(this.coBoxMM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxMiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMMOther);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxMMOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox coBoxMM;
        private System.Windows.Forms.ComboBox coBoxVehkept;
        private System.Windows.Forms.ComboBox coBoxVehUsage;
        private System.Windows.Forms.Button btn_Quote;
        private System.Windows.Forms.Button btn_NamedDrivers;
        private System.Windows.Forms.DateTimePicker DTPicker_PStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ProcessPolicys;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AddClaims;
        private System.Windows.Forms.DateTimePicker dTPickerClaimsDate;
        private System.Windows.Forms.ComboBox coBoxPastClaims;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxClaimsAmount;
    }
}