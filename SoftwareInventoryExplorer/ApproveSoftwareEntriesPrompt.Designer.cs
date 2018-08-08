namespace SoftwareInventoryExplorer
{
    partial class ApproveSoftwareEntriesPrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.listsDropDown = new System.Windows.Forms.ComboBox();
            this.approveForLabel = new System.Windows.Forms.Label();
            this.approvalTypeDropDown = new System.Windows.Forms.ComboBox();
            this.approvingEntriesLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Approved Software List:";
            // 
            // listsDropDown
            // 
            this.listsDropDown.FormattingEnabled = true;
            this.listsDropDown.Location = new System.Drawing.Point(140, 46);
            this.listsDropDown.Name = "listsDropDown";
            this.listsDropDown.Size = new System.Drawing.Size(351, 21);
            this.listsDropDown.TabIndex = 1;
            // 
            // approveForLabel
            // 
            this.approveForLabel.AutoSize = true;
            this.approveForLabel.Location = new System.Drawing.Point(12, 76);
            this.approveForLabel.Name = "approveForLabel";
            this.approveForLabel.Size = new System.Drawing.Size(65, 13);
            this.approveForLabel.TabIndex = 2;
            this.approveForLabel.Text = "Approve for:";
            this.approveForLabel.UseMnemonic = false;
            // 
            // approvalTypeDropDown
            // 
            this.approvalTypeDropDown.FormattingEnabled = true;
            this.approvalTypeDropDown.Location = new System.Drawing.Point(140, 73);
            this.approvalTypeDropDown.Name = "approvalTypeDropDown";
            this.approvalTypeDropDown.Size = new System.Drawing.Size(351, 21);
            this.approvalTypeDropDown.TabIndex = 3;
            // 
            // approvingEntriesLabel
            // 
            this.approvingEntriesLabel.AutoSize = true;
            this.approvingEntriesLabel.Location = new System.Drawing.Point(13, 8);
            this.approvingEntriesLabel.Name = "approvingEntriesLabel";
            this.approvingEntriesLabel.Size = new System.Drawing.Size(144, 13);
            this.approvingEntriesLabel.TabIndex = 4;
            this.approvingEntriesLabel.Text = "Approving 0 Software Entries";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(140, 101);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(221, 100);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ApproveSoftwareEntriesPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 128);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.approvingEntriesLabel);
            this.Controls.Add(this.approvalTypeDropDown);
            this.Controls.Add(this.approveForLabel);
            this.Controls.Add(this.listsDropDown);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(519, 167);
            this.MinimumSize = new System.Drawing.Size(519, 167);
            this.Name = "ApproveSoftwareEntriesPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Software to Approval List";
            this.Load += new System.EventHandler(this.ApproveSoftwareEntriesPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listsDropDown;
        private System.Windows.Forms.Label approveForLabel;
        private System.Windows.Forms.ComboBox approvalTypeDropDown;
        private System.Windows.Forms.Label approvingEntriesLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}