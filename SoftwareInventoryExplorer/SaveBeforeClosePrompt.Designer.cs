namespace SoftwareInventoryExplorer
{
    partial class SaveBeforeClosePrompt
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dontSaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(80, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(175, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Your project has unsaved changes.";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(49, 29);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dontSaveButton
            // 
            this.dontSaveButton.Location = new System.Drawing.Point(130, 29);
            this.dontSaveButton.Name = "dontSaveButton";
            this.dontSaveButton.Size = new System.Drawing.Size(75, 23);
            this.dontSaveButton.TabIndex = 2;
            this.dontSaveButton.Text = "Don\'t Save";
            this.dontSaveButton.UseVisualStyleBackColor = true;
            this.dontSaveButton.Click += new System.EventHandler(this.dontSaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(211, 29);
            this.cancelButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.cancelButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SaveBeforeClosePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 61);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dontSaveButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.messageLabel);
            this.Name = "SaveBeforeClosePrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button dontSaveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}