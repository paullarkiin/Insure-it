namespace InsureItAll_AssignmentTwo
{
    partial class frm_WelcomeScreen
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
            this.btn_Quote = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lblSecTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quote
            // 
            this.btn_Quote.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Quote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quote.Font = new System.Drawing.Font("Bahnschrift", 10.25F);
            this.btn_Quote.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Quote.Location = new System.Drawing.Point(326, 286);
            this.btn_Quote.Name = "btn_Quote";
            this.btn_Quote.Size = new System.Drawing.Size(131, 52);
            this.btn_Quote.TabIndex = 1;
            this.btn_Quote.Text = "Get A Quote";
            this.btn_Quote.UseVisualStyleBackColor = true;
            this.btn_Quote.Click += new System.EventHandler(this.Btn_Quote_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.CausesValidation = false;
            this.lbl_title.Font = new System.Drawing.Font("Bahnschrift", 22F);
            this.lbl_title.Location = new System.Drawing.Point(320, 204);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(151, 40);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Welcome!";
            // 
            // lblSecTitle
            // 
            this.lblSecTitle.AutoSize = true;
            this.lblSecTitle.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTitle.Location = new System.Drawing.Point(417, 107);
            this.lblSecTitle.Name = "lblSecTitle";
            this.lblSecTitle.Size = new System.Drawing.Size(152, 19);
            this.lblSecTitle.TabIndex = 5;
            this.lblSecTitle.Text = "Independent Broker";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(243, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 50);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Easy Car Insurance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InsureItAll_AssignmentTwo.Properties.Resources._160_F_134910797_hYnXCep8tDFTnFxmTanhuVTwl9pjJy8q;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 157);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Bahnschrift", 10.25F);
            this.btn_Admin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Admin.Location = new System.Drawing.Point(687, 12);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(101, 34);
            this.btn_Admin.TabIndex = 6;
            this.btn_Admin.Text = "Admin Panel";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click_1);
            // 
            // frm_WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.lblSecTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Quote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_WelcomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Quote;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lblSecTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Admin;
    }
}