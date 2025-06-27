namespace Farm_School
{
    partial class Farmerdashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmerdashbord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnevent = new System.Windows.Forms.Button();
            this.btnmatarials = new System.Windows.Forms.Button();
            this.btnschedule = new System.Windows.Forms.Button();
            this.btncourseList = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnprofile = new System.Windows.Forms.Button();
            this.btnnotification = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profileControl1 = new Farm_School.profileControl();
            this.eventControl1 = new Farm_School.eventControl();
            this.matarialsControl1 = new Farm_School.matarialsControl();
            this.scheduleControl1 = new Farm_School.scheduleControl();
            this.courseControl1 = new Farm_School.CourseControl();
            this.welcome1 = new Farm_School.welcome();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnevent);
            this.panel1.Controls.Add(this.btnmatarials);
            this.panel1.Controls.Add(this.btnschedule);
            this.panel1.Controls.Add(this.btncourseList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 455);
            this.panel1.TabIndex = 0;
            // 
            // btnevent
            // 
            this.btnevent.FlatAppearance.BorderSize = 0;
            this.btnevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnevent.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnevent.Image = ((System.Drawing.Image)(resources.GetObject("btnevent.Image")));
            this.btnevent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnevent.Location = new System.Drawing.Point(0, 306);
            this.btnevent.Name = "btnevent";
            this.btnevent.Size = new System.Drawing.Size(111, 103);
            this.btnevent.TabIndex = 3;
            this.btnevent.Text = "Event";
            this.btnevent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnevent.UseVisualStyleBackColor = true;
            this.btnevent.Click += new System.EventHandler(this.btnevent_Click);
            // 
            // btnmatarials
            // 
            this.btnmatarials.FlatAppearance.BorderSize = 0;
            this.btnmatarials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmatarials.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatarials.Image = ((System.Drawing.Image)(resources.GetObject("btnmatarials.Image")));
            this.btnmatarials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmatarials.Location = new System.Drawing.Point(0, 207);
            this.btnmatarials.Name = "btnmatarials";
            this.btnmatarials.Size = new System.Drawing.Size(138, 103);
            this.btnmatarials.TabIndex = 3;
            this.btnmatarials.Text = "Matarials";
            this.btnmatarials.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmatarials.UseVisualStyleBackColor = true;
            this.btnmatarials.Click += new System.EventHandler(this.btnmatarials_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.FlatAppearance.BorderSize = 0;
            this.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnschedule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.Image = ((System.Drawing.Image)(resources.GetObject("btnschedule.Image")));
            this.btnschedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.Location = new System.Drawing.Point(0, 108);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(141, 103);
            this.btnschedule.TabIndex = 3;
            this.btnschedule.Text = "Schedule";
            this.btnschedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnschedule.UseVisualStyleBackColor = true;
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // btncourseList
            // 
            this.btncourseList.FlatAppearance.BorderSize = 0;
            this.btncourseList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncourseList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncourseList.Image = ((System.Drawing.Image)(resources.GetObject("btncourseList.Image")));
            this.btncourseList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncourseList.Location = new System.Drawing.Point(3, 22);
            this.btncourseList.Name = "btncourseList";
            this.btncourseList.Size = new System.Drawing.Size(141, 103);
            this.btncourseList.TabIndex = 2;
            this.btncourseList.Text = "Course ";
            this.btncourseList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncourseList.UseVisualStyleBackColor = true;
            this.btncourseList.Click += new System.EventHandler(this.btncourseList_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btnprofile);
            this.flowLayoutPanel1.Controls.Add(this.btnnotification);
            this.flowLayoutPanel1.Controls.Add(this.btnlogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(144, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(680, 49);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnprofile
            // 
            this.btnprofile.FlatAppearance.BorderSize = 0;
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
            this.btnprofile.Location = new System.Drawing.Point(3, 3);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(38, 35);
            this.btnprofile.TabIndex = 3;
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnnotification
            // 
            this.btnnotification.FlatAppearance.BorderSize = 0;
            this.btnnotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotification.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotification.Image = ((System.Drawing.Image)(resources.GetObject("btnnotification.Image")));
            this.btnnotification.Location = new System.Drawing.Point(47, 3);
            this.btnnotification.Name = "btnnotification";
            this.btnnotification.Size = new System.Drawing.Size(38, 35);
            this.btnnotification.TabIndex = 4;
            this.btnnotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnotification.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.Location = new System.Drawing.Point(91, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(38, 35);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "FARM SCHOOL";
            // 
            // profileControl1
            // 
            this.profileControl1.Location = new System.Drawing.Point(147, 108);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(680, 347);
            this.profileControl1.TabIndex = 7;
            // 
            // eventControl1
            // 
            this.eventControl1.Location = new System.Drawing.Point(144, 108);
            this.eventControl1.Name = "eventControl1";
            this.eventControl1.Size = new System.Drawing.Size(680, 347);
            this.eventControl1.TabIndex = 6;
            this.eventControl1.Load += new System.EventHandler(this.eventControl1_Load);
            // 
            // matarialsControl1
            // 
            this.matarialsControl1.Location = new System.Drawing.Point(147, 96);
            this.matarialsControl1.Name = "matarialsControl1";
            this.matarialsControl1.Size = new System.Drawing.Size(680, 347);
            this.matarialsControl1.TabIndex = 5;
            this.matarialsControl1.Load += new System.EventHandler(this.matarialsControl1_Load);
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Location = new System.Drawing.Point(144, 108);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.Size = new System.Drawing.Size(680, 347);
            this.scheduleControl1.TabIndex = 4;
            // 
            // courseControl1
            // 
            this.courseControl1.Location = new System.Drawing.Point(147, 108);
            this.courseControl1.Name = "courseControl1";
            this.courseControl1.Size = new System.Drawing.Size(680, 347);
            this.courseControl1.TabIndex = 3;
            // 
            // welcome1
            // 
            this.welcome1.Location = new System.Drawing.Point(144, 108);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(680, 347);
            this.welcome1.TabIndex = 8;
            // 
            // Farmerdashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.Controls.Add(this.welcome1);
            this.Controls.Add(this.profileControl1);
            this.Controls.Add(this.eventControl1);
            this.Controls.Add(this.matarialsControl1);
            this.Controls.Add(this.scheduleControl1);
            this.Controls.Add(this.courseControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Farmerdashbord";
            this.Text = "Farmerdashbord";
            this.Load += new System.EventHandler(this.Farmerdashbord_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btncourseList;
        private System.Windows.Forms.Button btnschedule;
        private System.Windows.Forms.Button btnevent;
        private System.Windows.Forms.Button btnmatarials;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Button btnnotification;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label1;
        private CourseControl courseControl1;
        private scheduleControl scheduleControl1;
        private matarialsControl matarialsControl1;
        private eventControl eventControl1;
        private profileControl profileControl1;
        private welcome welcome1;
    }
}