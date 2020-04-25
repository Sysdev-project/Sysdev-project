namespace AkhavanDatabaseSystem
{
    partial class SystemForm
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.inventoryUserControl1 = new AkhavanDatabaseSystem.InventoryUserControl();
            this.reportsUserControl1 = new AkhavanDatabaseSystem.ReportsUserControl();
            this.homeUserControl2 = new AkhavanDatabaseSystem.HomeUserControl();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidePanel.Controls.Add(this.logoutBtn);
            this.sidePanel.Controls.Add(this.reportsBtn);
            this.sidePanel.Controls.Add(this.inventoryBtn);
            this.sidePanel.Controls.Add(this.homeBtn);
            this.sidePanel.Location = new System.Drawing.Point(0, 202);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(330, 480);
            this.sidePanel.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = global::AkhavanDatabaseSystem.Properties.Resources.rsz_logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(27, 356);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(278, 90);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Image = global::AkhavanDatabaseSystem.Properties.Resources.report;
            this.reportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsBtn.Location = new System.Drawing.Point(27, 243);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(278, 90);
            this.reportsBtn.TabIndex = 4;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.Image = global::AkhavanDatabaseSystem.Properties.Resources.Inventory;
            this.inventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBtn.Location = new System.Drawing.Point(27, 130);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(278, 90);
            this.inventoryBtn.TabIndex = 5;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Image = global::AkhavanDatabaseSystem.Properties.Resources.home;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(27, 17);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(278, 90);
            this.homeBtn.TabIndex = 6;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPictureBox.Image = global::AkhavanDatabaseSystem.Properties.Resources.akhavanLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(330, 194);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 680);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // inventoryUserControl1
            // 
            this.inventoryUserControl1.BackColor = System.Drawing.Color.LightBlue;
            this.inventoryUserControl1.Location = new System.Drawing.Point(329, 2);
            this.inventoryUserControl1.Name = "inventoryUserControl1";
            this.inventoryUserControl1.Size = new System.Drawing.Size(915, 680);
            this.inventoryUserControl1.TabIndex = 4;
            // 
            // reportsUserControl1
            // 
            this.reportsUserControl1.BackColor = System.Drawing.Color.LightBlue;
            this.reportsUserControl1.Location = new System.Drawing.Point(323, 2);
            this.reportsUserControl1.Name = "reportsUserControl1";
            this.reportsUserControl1.Size = new System.Drawing.Size(921, 680);
            this.reportsUserControl1.TabIndex = 5;
            // 
            // homeUserControl2
            // 
            this.homeUserControl2.BackColor = System.Drawing.Color.LightBlue;
            this.homeUserControl2.Location = new System.Drawing.Point(323, 2);
            this.homeUserControl2.Name = "homeUserControl2";
            this.homeUserControl2.Size = new System.Drawing.Size(921, 680);
            this.homeUserControl2.TabIndex = 7;
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1245, 681);
            this.Controls.Add(this.homeUserControl2);
            this.Controls.Add(this.reportsUserControl1);
            this.Controls.Add(this.inventoryUserControl1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemForm";
            this.Text = "Inventory Management";
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button logoutBtn;
        public System.Windows.Forms.Panel sidePanel;
        private InventoryUserControl inventoryUserControl1;
        private ReportsUserControl reportsUserControl1;
        private HomeUserControl homeUserControl2;
    }
}

