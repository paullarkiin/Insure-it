namespace InsureItAll_AssignmentTwo
{
    partial class frm_AdminPanel
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
            this.dateTimePickerPolicy = new System.Windows.Forms.DateTimePicker();
            this.btn_ShowPolicies = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDispPolicies = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerPolicy
            // 
            this.dateTimePickerPolicy.Location = new System.Drawing.Point(671, 43);
            this.dateTimePickerPolicy.Name = "dateTimePickerPolicy";
            this.dateTimePickerPolicy.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerPolicy.TabIndex = 1;
            // 
            // btn_ShowPolicies
            // 
            this.btn_ShowPolicies.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ShowPolicies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPolicies.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_ShowPolicies.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_ShowPolicies.Location = new System.Drawing.Point(168, 379);
            this.btn_ShowPolicies.Name = "btn_ShowPolicies";
            this.btn_ShowPolicies.Size = new System.Drawing.Size(100, 40);
            this.btn_ShowPolicies.TabIndex = 2;
            this.btn_ShowPolicies.Text = "Show Policies";
            this.btn_ShowPolicies.UseVisualStyleBackColor = true;
            this.btn_ShowPolicies.Click += new System.EventHandler(this.Btn_ShowPolicies_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_Exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Exit.Location = new System.Drawing.Point(486, 379);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 40);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Panel - Policy Checker";
            // 
            // txtDispPolicies
            // 
            this.txtDispPolicies.Location = new System.Drawing.Point(12, 69);
            this.txtDispPolicies.Multiline = true;
            this.txtDispPolicies.Name = "txtDispPolicies";
            this.txtDispPolicies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDispPolicies.Size = new System.Drawing.Size(790, 273);
            this.txtDispPolicies.TabIndex = 5;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.btn_Back.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Back.Location = new System.Drawing.Point(324, 379);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 40);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frm_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txtDispPolicies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ShowPolicies);
            this.Controls.Add(this.dateTimePickerPolicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPolicy;
        private System.Windows.Forms.Button btn_ShowPolicies;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDispPolicies;
        private System.Windows.Forms.Button btn_Back;
    }
}