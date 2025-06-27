namespace Farm_School
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.titlelbl = new System.Windows.Forms.Label();
            this.rolecmb = new System.Windows.Forms.ComboBox();
            this.rolelbl = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.MaskedTextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.phnlbl = new System.Windows.Forms.Label();
            this.fnametxt = new System.Windows.Forms.MaskedTextBox();
            this.locationtxt = new System.Windows.Forms.MaskedTextBox();
            this.passtxt = new System.Windows.Forms.MaskedTextBox();
            this.phntxt = new System.Windows.Forms.MaskedTextBox();
            this.locationlbl = new System.Windows.Forms.Label();
            this.expertiselbl = new System.Windows.Forms.Label();
            this.expertisecmb = new System.Windows.Forms.ComboBox();
            this.btloginbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(61, 44);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(341, 42);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Create a new account,";
            // 
            // rolecmb
            // 
            this.rolecmb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolecmb.FormattingEnabled = true;
            this.rolecmb.Items.AddRange(new object[] {
            "Farmer",
            "Instructor"});
            this.rolecmb.Location = new System.Drawing.Point(337, 119);
            this.rolecmb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rolecmb.Name = "rolecmb";
            this.rolecmb.Size = new System.Drawing.Size(196, 27);
            this.rolecmb.TabIndex = 17;
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rolelbl.Location = new System.Drawing.Point(125, 122);
            this.rolelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(57, 27);
            this.rolelbl.TabIndex = 16;
            this.rolelbl.Text = "Role";
            this.rolelbl.Click += new System.EventHandler(this.Rolelbl_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.DarkGray;
            this.registerbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(220, 478);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(176, 34);
            this.registerbtn.TabIndex = 15;
            this.registerbtn.Text = "Create Account";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.fnamelbl.Location = new System.Drawing.Point(125, 206);
            this.fnamelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(69, 27);
            this.fnamelbl.TabIndex = 13;
            this.fnamelbl.Text = "Name";
            this.fnamelbl.Click += new System.EventHandler(this.Fnamelbl_Click);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.emaillbl.Location = new System.Drawing.Point(125, 161);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(76, 27);
            this.emaillbl.TabIndex = 12;
            this.emaillbl.Text = "E-mail";
            this.emaillbl.Click += new System.EventHandler(this.Emaillbl_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(337, 160);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(196, 26);
            this.emailtxt.TabIndex = 11;
            this.emailtxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Emailtxt_MaskInputRejected);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.passlbl.Location = new System.Drawing.Point(125, 254);
            this.passlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(104, 27);
            this.passlbl.TabIndex = 20;
            this.passlbl.Text = "Password";
            this.passlbl.Click += new System.EventHandler(this.Passlbl_Click);
            // 
            // phnlbl
            // 
            this.phnlbl.AutoSize = true;
            this.phnlbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.phnlbl.Location = new System.Drawing.Point(125, 305);
            this.phnlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.phnlbl.Name = "phnlbl";
            this.phnlbl.Size = new System.Drawing.Size(73, 27);
            this.phnlbl.TabIndex = 21;
            this.phnlbl.Text = "Phone";
            this.phnlbl.Click += new System.EventHandler(this.Confirmpasslbl_Click);
            // 
            // fnametxt
            // 
            this.fnametxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(337, 204);
            this.fnametxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(196, 26);
            this.fnametxt.TabIndex = 23;
            this.fnametxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Fnametxt_MaskInputRejected);
            // 
            // locationtxt
            // 
            this.locationtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtxt.Location = new System.Drawing.Point(337, 357);
            this.locationtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(196, 26);
            this.locationtxt.TabIndex = 24;
            this.locationtxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Locationtxt_MaskInputRejected);
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(337, 254);
            this.passtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(196, 26);
            this.passtxt.TabIndex = 26;
            this.passtxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Passtxt_MaskInputRejected);
            // 
            // phntxt
            // 
            this.phntxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phntxt.Location = new System.Drawing.Point(337, 304);
            this.phntxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.phntxt.Name = "phntxt";
            this.phntxt.PasswordChar = '*';
            this.phntxt.Size = new System.Drawing.Size(196, 26);
            this.phntxt.TabIndex = 27;
            this.phntxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Confirmpasstxt_MaskInputRejected);
            // 
            // locationlbl
            // 
            this.locationlbl.AutoSize = true;
            this.locationlbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.locationlbl.Location = new System.Drawing.Point(125, 358);
            this.locationlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.locationlbl.Name = "locationlbl";
            this.locationlbl.Size = new System.Drawing.Size(98, 27);
            this.locationlbl.TabIndex = 28;
            this.locationlbl.Text = "Location";
            this.locationlbl.Click += new System.EventHandler(this.Locationlbl_Click);
            // 
            // expertiselbl
            // 
            this.expertiselbl.AutoSize = true;
            this.expertiselbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.expertiselbl.Location = new System.Drawing.Point(125, 412);
            this.expertiselbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.expertiselbl.Name = "expertiselbl";
            this.expertiselbl.Size = new System.Drawing.Size(103, 27);
            this.expertiselbl.TabIndex = 29;
            this.expertiselbl.Text = "Expertise";
            // 
            // expertisecmb
            // 
            this.expertisecmb.FormattingEnabled = true;
            this.expertisecmb.Items.AddRange(new object[] {
            "Soil Science",
            "Crop Cultivation",
            "Pest Management",
            "Agribusiness",
            "Organic Farming",
            "Farm Technology"});
            this.expertisecmb.Location = new System.Drawing.Point(337, 412);
            this.expertisecmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expertisecmb.Name = "expertisecmb";
            this.expertisecmb.Size = new System.Drawing.Size(196, 24);
            this.expertisecmb.TabIndex = 31;
            this.expertisecmb.SelectedIndexChanged += new System.EventHandler(this.Expertisecmb_SelectedIndexChanged);
            // 
            // btloginbtn
            // 
            this.btloginbtn.BackColor = System.Drawing.Color.DarkGray;
            this.btloginbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btloginbtn.Location = new System.Drawing.Point(953, 512);
            this.btloginbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btloginbtn.Name = "btloginbtn";
            this.btloginbtn.Size = new System.Drawing.Size(117, 38);
            this.btloginbtn.TabIndex = 32;
            this.btloginbtn.Text = "Back to login";
            this.btloginbtn.UseVisualStyleBackColor = false;
            this.btloginbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1104, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btloginbtn);
            this.Controls.Add(this.expertisecmb);
            this.Controls.Add(this.expertiselbl);
            this.Controls.Add(this.locationlbl);
            this.Controls.Add(this.phntxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.phnlbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.rolecmb);
            this.Controls.Add(this.rolelbl);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.titlelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignupForm";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.ComboBox rolecmb;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.MaskedTextBox emailtxt;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label phnlbl;
        private System.Windows.Forms.MaskedTextBox fnametxt;
        private System.Windows.Forms.MaskedTextBox locationtxt;
        private System.Windows.Forms.MaskedTextBox passtxt;
        private System.Windows.Forms.MaskedTextBox phntxt;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.Label expertiselbl;
        private System.Windows.Forms.ComboBox expertisecmb;
        private System.Windows.Forms.Button btloginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}