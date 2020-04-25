namespace AkhavanDatabaseSystem
{
    partial class LogInUserControl
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
            this.userPictureBoz = new System.Windows.Forms.PictureBox();
            this.memberLoginLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forgotLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userPictureBoz
            // 
            this.userPictureBoz.Image = global::AkhavanDatabaseSystem.Properties.Resources.personLoginImg;
            this.userPictureBoz.Location = new System.Drawing.Point(86, 307);
            this.userPictureBoz.Name = "userPictureBoz";
            this.userPictureBoz.Size = new System.Drawing.Size(300, 300);
            this.userPictureBoz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBoz.TabIndex = 0;
            this.userPictureBoz.TabStop = false;
            // 
            // memberLoginLabel
            // 
            this.memberLoginLabel.AutoSize = true;
            this.memberLoginLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLoginLabel.Location = new System.Drawing.Point(478, 307);
            this.memberLoginLabel.Name = "memberLoginLabel";
            this.memberLoginLabel.Size = new System.Drawing.Size(297, 46);
            this.memberLoginLabel.TabIndex = 1;
            this.memberLoginLabel.Text = "Member Login";
            this.memberLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.usernameTextBox.Location = new System.Drawing.Point(486, 411);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(289, 40);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Text = "Employee Id";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(486, 466);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(289, 40);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(486, 542);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(289, 53);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Red;
            this.exitAppBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.Location = new System.Drawing.Point(726, 3);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(151, 52);
            this.exitAppBtn.TabIndex = 5;
            this.exitAppBtn.Text = "Exit App";
            this.exitAppBtn.UseVisualStyleBackColor = false;
            this.exitAppBtn.Click += new System.EventHandler(this.exitAppBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AkhavanDatabaseSystem.Properties.Resources.akhavanLogo;
            this.pictureBox1.Location = new System.Drawing.Point(274, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // forgotLinkLabel
            // 
            this.forgotLinkLabel.AutoSize = true;
            this.forgotLinkLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotLinkLabel.Location = new System.Drawing.Point(482, 615);
            this.forgotLinkLabel.Name = "forgotLinkLabel";
            this.forgotLinkLabel.Size = new System.Drawing.Size(295, 23);
            this.forgotLinkLabel.TabIndex = 7;
            this.forgotLinkLabel.TabStop = true;
            this.forgotLinkLabel.Text = "Forgot Username/Password?";
            // 
            // LogInUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.forgotLinkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.memberLoginLabel);
            this.Controls.Add(this.userPictureBoz);
            this.Name = "LogInUserControl";
            this.Size = new System.Drawing.Size(880, 678);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPictureBoz;
        private System.Windows.Forms.Label memberLoginLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel forgotLinkLabel;
    }
}
