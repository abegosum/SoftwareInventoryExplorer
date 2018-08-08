namespace SoftwareInventoryExplorer.ReportForms
{
    partial class FilterEditorAddPrompt
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
            this.filterTypeLabel = new System.Windows.Forms.Label();
            this.filterTypeDropDown = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterTypeLabel
            // 
            this.filterTypeLabel.AutoSize = true;
            this.filterTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.filterTypeLabel.Name = "filterTypeLabel";
            this.filterTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.filterTypeLabel.TabIndex = 0;
            this.filterTypeLabel.Text = "Filter Type:";
            // 
            // filterTypeDropDown
            // 
            this.filterTypeDropDown.FormattingEnabled = true;
            this.filterTypeDropDown.Location = new System.Drawing.Point(15, 26);
            this.filterTypeDropDown.Name = "filterTypeDropDown";
            this.filterTypeDropDown.Size = new System.Drawing.Size(306, 21);
            this.filterTypeDropDown.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(88, 53);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(169, 53);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FilterEditorAddPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 87);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.filterTypeDropDown);
            this.Controls.Add(this.filterTypeLabel);
            this.MaximumSize = new System.Drawing.Size(349, 126);
            this.MinimumSize = new System.Drawing.Size(349, 126);
            this.Name = "FilterEditorAddPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Filter";
            this.Load += new System.EventHandler(this.FilterEditorAddPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filterTypeLabel;
        private System.Windows.Forms.ComboBox filterTypeDropDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}