namespace Farm_School
{
    partial class welcome
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
            this.lblwlc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblwlc
            // 
            this.lblwlc.AutoSize = true;
            this.lblwlc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwlc.Location = new System.Drawing.Point(153, 117);
            this.lblwlc.Name = "lblwlc";
            this.lblwlc.Size = new System.Drawing.Size(334, 23);
            this.lblwlc.TabIndex = 3;
            this.lblwlc.Text = "Hello,Welcome To FARM SCHOOL";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblwlc);
            this.Name = "welcome";
            this.Size = new System.Drawing.Size(680, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwlc;
    }
}
