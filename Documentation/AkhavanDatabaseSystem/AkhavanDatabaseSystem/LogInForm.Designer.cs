namespace AkhavanDatabaseSystem
{
    partial class LogInForm
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
            this.logInUserControl1 = new AkhavanDatabaseSystem.LogInUserControl();
            this.SuspendLayout();
            // 
            // logInUserControl1
            // 
            this.logInUserControl1.BackColor = System.Drawing.Color.LightBlue;
            this.logInUserControl1.Location = new System.Drawing.Point(2, 1);
            this.logInUserControl1.Name = "logInUserControl1";
            this.logInUserControl1.Size = new System.Drawing.Size(880, 654);
            this.logInUserControl1.TabIndex = 0;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(884, 726);
            this.Controls.Add(this.logInUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LogInUserControl logInUserControl1;
    }
}