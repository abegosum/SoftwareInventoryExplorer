namespace SoftwareInventoryExplorer
{
    partial class BackgroundAndForegroundColorDialog
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
            this.colorDisplayExampleLabel = new System.Windows.Forms.Label();
            this.setForegroundColorButton = new System.Windows.Forms.Button();
            this.setBackgroundColorButton = new System.Windows.Forms.Button();
            this.colorSelectDialog = new System.Windows.Forms.ColorDialog();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorDisplayExampleLabel
            // 
            this.colorDisplayExampleLabel.AutoSize = true;
            this.colorDisplayExampleLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorDisplayExampleLabel.Location = new System.Drawing.Point(125, 9);
            this.colorDisplayExampleLabel.Name = "colorDisplayExampleLabel";
            this.colorDisplayExampleLabel.Size = new System.Drawing.Size(111, 13);
            this.colorDisplayExampleLabel.TabIndex = 7;
            this.colorDisplayExampleLabel.Text = "Color Display Example";
            // 
            // setForegroundColorButton
            // 
            this.setForegroundColorButton.Location = new System.Drawing.Point(8, 25);
            this.setForegroundColorButton.Name = "setForegroundColorButton";
            this.setForegroundColorButton.Size = new System.Drawing.Size(152, 23);
            this.setForegroundColorButton.TabIndex = 8;
            this.setForegroundColorButton.Text = "Set Foreground Color";
            this.setForegroundColorButton.UseVisualStyleBackColor = true;
            this.setForegroundColorButton.Click += new System.EventHandler(this.setForegroundColorButton_Click);
            // 
            // setBackgroundColorButton
            // 
            this.setBackgroundColorButton.Location = new System.Drawing.Point(201, 25);
            this.setBackgroundColorButton.Name = "setBackgroundColorButton";
            this.setBackgroundColorButton.Size = new System.Drawing.Size(152, 23);
            this.setBackgroundColorButton.TabIndex = 9;
            this.setBackgroundColorButton.Text = "Set Background Color";
            this.setBackgroundColorButton.UseVisualStyleBackColor = true;
            this.setBackgroundColorButton.Click += new System.EventHandler(this.setBackgroundColorButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(102, 71);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(183, 71);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BackgroundAndForegroundColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 106);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.setBackgroundColorButton);
            this.Controls.Add(this.setForegroundColorButton);
            this.Controls.Add(this.colorDisplayExampleLabel);
            this.Name = "BackgroundAndForegroundColorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            this.Load += new System.EventHandler(this.BackgroundAndForegroundColorDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorDisplayExampleLabel;
        private System.Windows.Forms.Button setForegroundColorButton;
        private System.Windows.Forms.Button setBackgroundColorButton;
        private System.Windows.Forms.ColorDialog colorSelectDialog;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}