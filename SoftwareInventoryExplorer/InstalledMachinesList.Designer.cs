namespace SoftwareInventoryExplorer
{
    partial class InstalledMachinesList
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
            this.installedMachinesDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.softwareNameLabel = new System.Windows.Forms.Label();
            this.softwareCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.installedMachinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // installedMachinesDataGridView
            // 
            this.installedMachinesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.installedMachinesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.installedMachinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.installedMachinesDataGridView.Location = new System.Drawing.Point(12, 75);
            this.installedMachinesDataGridView.Name = "installedMachinesDataGridView";
            this.installedMachinesDataGridView.Size = new System.Drawing.Size(527, 427);
            this.installedMachinesDataGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.Location = new System.Drawing.Point(13, 508);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // softwareNameLabel
            // 
            this.softwareNameLabel.AutoSize = true;
            this.softwareNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareNameLabel.Location = new System.Drawing.Point(8, 9);
            this.softwareNameLabel.Name = "softwareNameLabel";
            this.softwareNameLabel.Size = new System.Drawing.Size(119, 20);
            this.softwareNameLabel.TabIndex = 2;
            this.softwareNameLabel.Text = "Software Name";
            // 
            // softwareCodeLabel
            // 
            this.softwareCodeLabel.AutoSize = true;
            this.softwareCodeLabel.Location = new System.Drawing.Point(12, 44);
            this.softwareCodeLabel.Name = "softwareCodeLabel";
            this.softwareCodeLabel.Size = new System.Drawing.Size(77, 13);
            this.softwareCodeLabel.TabIndex = 3;
            this.softwareCodeLabel.Text = "Software Code";
            // 
            // InstalledMachinesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 543);
            this.Controls.Add(this.softwareCodeLabel);
            this.Controls.Add(this.softwareNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.installedMachinesDataGridView);
            this.MinimumSize = new System.Drawing.Size(382, 489);
            this.Name = "InstalledMachinesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Installed Machines";
            this.Load += new System.EventHandler(this.InstalledMachinesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.installedMachinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView installedMachinesDataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label softwareNameLabel;
        private System.Windows.Forms.Label softwareCodeLabel;
    }
}