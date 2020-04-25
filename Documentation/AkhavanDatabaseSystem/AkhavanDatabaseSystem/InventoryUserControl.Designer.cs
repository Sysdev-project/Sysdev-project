namespace AkhavanDatabaseSystem
{
    partial class InventoryUserControl
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
            this.radioBtnPanel = new System.Windows.Forms.Panel();
            this.searchByNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.searchByItemNumberBtn = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.radioBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnPanel
            // 
            this.radioBtnPanel.Controls.Add(this.searchByItemNumberBtn);
            this.radioBtnPanel.Controls.Add(this.searchByNameRadioBtn);
            this.radioBtnPanel.Location = new System.Drawing.Point(168, 102);
            this.radioBtnPanel.Name = "radioBtnPanel";
            this.radioBtnPanel.Size = new System.Drawing.Size(566, 78);
            this.radioBtnPanel.TabIndex = 0;
            // 
            // searchByNameRadioBtn
            // 
            this.searchByNameRadioBtn.AutoSize = true;
            this.searchByNameRadioBtn.Checked = true;
            this.searchByNameRadioBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameRadioBtn.Location = new System.Drawing.Point(3, 36);
            this.searchByNameRadioBtn.Name = "searchByNameRadioBtn";
            this.searchByNameRadioBtn.Size = new System.Drawing.Size(245, 27);
            this.searchByNameRadioBtn.TabIndex = 0;
            this.searchByNameRadioBtn.TabStop = true;
            this.searchByNameRadioBtn.Text = "Search By Item Name";
            this.searchByNameRadioBtn.UseVisualStyleBackColor = true;
            this.searchByNameRadioBtn.CheckedChanged += new System.EventHandler(this.searchByNameRadioBtn_CheckedChanged);
            // 
            // searchByItemNumberBtn
            // 
            this.searchByItemNumberBtn.AutoSize = true;
            this.searchByItemNumberBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByItemNumberBtn.Location = new System.Drawing.Point(291, 36);
            this.searchByItemNumberBtn.Name = "searchByItemNumberBtn";
            this.searchByItemNumberBtn.Size = new System.Drawing.Size(267, 27);
            this.searchByItemNumberBtn.TabIndex = 1;
            this.searchByItemNumberBtn.Text = "Search By Item Number";
            this.searchByItemNumberBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.searchTextBox.Location = new System.Drawing.Point(98, 186);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(566, 40);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Item Name";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(670, 185);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(147, 47);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search Item";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // InventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.radioBtnPanel);
            this.Name = "InventoryUserControl";
            this.Size = new System.Drawing.Size(880, 680);
            this.radioBtnPanel.ResumeLayout(false);
            this.radioBtnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel radioBtnPanel;
        private System.Windows.Forms.RadioButton searchByItemNumberBtn;
        private System.Windows.Forms.RadioButton searchByNameRadioBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
    }
}
