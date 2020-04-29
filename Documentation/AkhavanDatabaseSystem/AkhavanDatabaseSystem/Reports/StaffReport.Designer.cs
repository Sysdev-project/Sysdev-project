namespace AkhavanDatabaseSystem.Reports
{
    partial class StaffReport
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
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.BackColor = System.Drawing.SystemColors.Window;
            this.welcomeUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUserLabel.Location = new System.Drawing.Point(132, 162);
            this.welcomeUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(174, 32);
            this.welcomeUserLabel.TabIndex = 8;
            this.welcomeUserLabel.Text = "Staff Report";
            // 
            // StaffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.welcomeUserLabel);
            this.Name = "StaffReport";
            this.Size = new System.Drawing.Size(437, 356);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeUserLabel;
    }
}
