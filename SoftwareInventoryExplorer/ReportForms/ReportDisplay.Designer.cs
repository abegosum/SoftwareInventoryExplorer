namespace SoftwareInventoryExplorer.ReportForms
{
    partial class ReportDisplay
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
            this.reportResultsGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.reportNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportResultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportResultsGridView
            // 
            this.reportResultsGridView.AllowUserToAddRows = false;
            this.reportResultsGridView.AllowUserToDeleteRows = false;
            this.reportResultsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportResultsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportResultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportResultsGridView.Location = new System.Drawing.Point(12, 63);
            this.reportResultsGridView.Name = "reportResultsGridView";
            this.reportResultsGridView.ReadOnly = true;
            this.reportResultsGridView.Size = new System.Drawing.Size(776, 346);
            this.reportResultsGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(363, 415);
            this.closeButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.closeButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // reportNameLabel
            // 
            this.reportNameLabel.AutoSize = true;
            this.reportNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportNameLabel.Location = new System.Drawing.Point(17, 19);
            this.reportNameLabel.Name = "reportNameLabel";
            this.reportNameLabel.Size = new System.Drawing.Size(110, 24);
            this.reportNameLabel.TabIndex = 2;
            this.reportNameLabel.Text = "reportName";
            // 
            // ReportDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reportResultsGridView);
            this.Name = "ReportDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Display";
            this.Load += new System.EventHandler(this.ReportDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportResultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportResultsGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label reportNameLabel;
    }
}