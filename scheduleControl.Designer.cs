namespace Farm_School
{
    partial class scheduleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scheduleControl));
            this.panelScheule = new System.Windows.Forms.Panel();
            this.labSchulemonth1 = new System.Windows.Forms.Label();
            this.labSchedule = new System.Windows.Forms.Label();
            this.panelScheule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelScheule
            // 
            this.panelScheule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelScheule.Controls.Add(this.labSchedule);
            this.panelScheule.Controls.Add(this.labSchulemonth1);
            this.panelScheule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScheule.Location = new System.Drawing.Point(0, 0);
            this.panelScheule.Name = "panelScheule";
            this.panelScheule.Size = new System.Drawing.Size(680, 347);
            this.panelScheule.TabIndex = 0;
            this.panelScheule.Paint += new System.Windows.Forms.PaintEventHandler(this.panelScheule_Paint);
            // 
            // labSchulemonth1
            // 
            this.labSchulemonth1.AutoSize = true;
            this.labSchulemonth1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSchulemonth1.Location = new System.Drawing.Point(3, 64);
            this.labSchulemonth1.Name = "labSchulemonth1";
            this.labSchulemonth1.Size = new System.Drawing.Size(627, 378);
            this.labSchulemonth1.TabIndex = 8;
            this.labSchulemonth1.Text = resources.GetString("labSchulemonth1.Text");
            // 
            // labSchedule
            // 
            this.labSchedule.AutoSize = true;
            this.labSchedule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSchedule.Location = new System.Drawing.Point(239, 14);
            this.labSchedule.Name = "labSchedule";
            this.labSchedule.Size = new System.Drawing.Size(99, 21);
            this.labSchedule.TabIndex = 9;
            this.labSchedule.Text = "SCHEDULE";
            // 
            // scheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelScheule);
            this.Name = "scheduleControl";
            this.Size = new System.Drawing.Size(680, 347);
            this.panelScheule.ResumeLayout(false);
            this.panelScheule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScheule;
        private System.Windows.Forms.Label labSchulemonth1;
        private System.Windows.Forms.Label labSchedule;
    }
}
