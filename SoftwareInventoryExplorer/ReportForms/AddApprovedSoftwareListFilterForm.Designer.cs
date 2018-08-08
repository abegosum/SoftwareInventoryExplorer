namespace SoftwareInventoryExplorer.ReportForms
{
    partial class AddApprovedSoftwareListFilterForm
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
            this.preambleLabel = new System.Windows.Forms.Label();
            this.negationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.approvedSoftwareListDropDown = new System.Windows.Forms.ComboBox();
            this.addEditButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preambleLabel
            // 
            this.preambleLabel.AutoSize = true;
            this.preambleLabel.Location = new System.Drawing.Point(126, 9);
            this.preambleLabel.Name = "preambleLabel";
            this.preambleLabel.Size = new System.Drawing.Size(161, 13);
            this.preambleLabel.TabIndex = 0;
            this.preambleLabel.Text = "Exclude software entries that are";
            // 
            // negationComboBox
            // 
            this.negationComboBox.FormattingEnabled = true;
            this.negationComboBox.Items.AddRange(new object[] {
            "IS IN",
            "IS NOT IN"});
            this.negationComboBox.Location = new System.Drawing.Point(143, 25);
            this.negationComboBox.Name = "negationComboBox";
            this.negationComboBox.Size = new System.Drawing.Size(121, 21);
            this.negationComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "this software list";
            // 
            // approvedSoftwareListDropDown
            // 
            this.approvedSoftwareListDropDown.FormattingEnabled = true;
            this.approvedSoftwareListDropDown.Location = new System.Drawing.Point(61, 65);
            this.approvedSoftwareListDropDown.Name = "approvedSoftwareListDropDown";
            this.approvedSoftwareListDropDown.Size = new System.Drawing.Size(291, 21);
            this.approvedSoftwareListDropDown.TabIndex = 3;
            // 
            // addEditButton
            // 
            this.addEditButton.Location = new System.Drawing.Point(129, 93);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(75, 23);
            this.addEditButton.TabIndex = 4;
            this.addEditButton.Text = "Add Filter";
            this.addEditButton.UseVisualStyleBackColor = true;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(211, 92);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddApprovedSoftwareListFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 131);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.approvedSoftwareListDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.negationComboBox);
            this.Controls.Add(this.preambleLabel);
            this.MaximumSize = new System.Drawing.Size(429, 170);
            this.MinimumSize = new System.Drawing.Size(429, 170);
            this.Name = "AddApprovedSoftwareListFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Approved Software List Filter";
            this.Load += new System.EventHandler(this.AddApprovedSoftwareListFilterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preambleLabel;
        private System.Windows.Forms.ComboBox negationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox approvedSoftwareListDropDown;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Button cancelButton;
    }
}