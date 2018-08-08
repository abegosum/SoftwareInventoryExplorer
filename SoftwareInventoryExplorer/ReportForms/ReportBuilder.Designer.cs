namespace SoftwareInventoryExplorer.ReportForms
{
    partial class ReportBuilder
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
            this.reportNameLabel = new System.Windows.Forms.Label();
            this.reportNameTextBox = new System.Windows.Forms.TextBox();
            this.saveOrCreateButton = new System.Windows.Forms.Button();
            this.reportSourceDropDown = new System.Windows.Forms.ComboBox();
            this.reportSourceLabel = new System.Windows.Forms.Label();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.filtersGridView = new System.Windows.Forms.DataGridView();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.editFilterButton = new System.Windows.Forms.Button();
            this.deleteFilterButton = new System.Windows.Forms.Button();
            this.modifiedByLabel = new System.Windows.Forms.Label();
            this.modifiedDateLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportNameLabel
            // 
            this.reportNameLabel.AutoSize = true;
            this.reportNameLabel.Location = new System.Drawing.Point(13, 13);
            this.reportNameLabel.Name = "reportNameLabel";
            this.reportNameLabel.Size = new System.Drawing.Size(73, 13);
            this.reportNameLabel.TabIndex = 0;
            this.reportNameLabel.Text = "Report Name:";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new System.Drawing.Point(92, 10);
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new System.Drawing.Size(290, 20);
            this.reportNameTextBox.TabIndex = 1;
            // 
            // saveOrCreateButton
            // 
            this.saveOrCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveOrCreateButton.Location = new System.Drawing.Point(713, 415);
            this.saveOrCreateButton.Name = "saveOrCreateButton";
            this.saveOrCreateButton.Size = new System.Drawing.Size(75, 23);
            this.saveOrCreateButton.TabIndex = 2;
            this.saveOrCreateButton.Text = "Save";
            this.saveOrCreateButton.UseVisualStyleBackColor = true;
            this.saveOrCreateButton.Click += new System.EventHandler(this.saveOrCreateButton_Click);
            // 
            // reportSourceDropDown
            // 
            this.reportSourceDropDown.FormattingEnabled = true;
            this.reportSourceDropDown.Location = new System.Drawing.Point(98, 36);
            this.reportSourceDropDown.Name = "reportSourceDropDown";
            this.reportSourceDropDown.Size = new System.Drawing.Size(284, 21);
            this.reportSourceDropDown.TabIndex = 3;
            // 
            // reportSourceLabel
            // 
            this.reportSourceLabel.AutoSize = true;
            this.reportSourceLabel.Location = new System.Drawing.Point(13, 40);
            this.reportSourceLabel.Name = "reportSourceLabel";
            this.reportSourceLabel.Size = new System.Drawing.Size(79, 13);
            this.reportSourceLabel.TabIndex = 4;
            this.reportSourceLabel.Text = "Report Source:";
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Location = new System.Drawing.Point(13, 69);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(155, 13);
            this.filtersLabel.TabIndex = 5;
            this.filtersLabel.Text = "Include software entries unless:";
            // 
            // filtersGridView
            // 
            this.filtersGridView.AllowUserToAddRows = false;
            this.filtersGridView.AllowUserToDeleteRows = false;
            this.filtersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.filtersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filtersGridView.Location = new System.Drawing.Point(16, 85);
            this.filtersGridView.MultiSelect = false;
            this.filtersGridView.Name = "filtersGridView";
            this.filtersGridView.ReadOnly = true;
            this.filtersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.filtersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filtersGridView.Size = new System.Drawing.Size(772, 323);
            this.filtersGridView.TabIndex = 6;
            this.filtersGridView.SelectionChanged += new System.EventHandler(this.filtersGridView_SelectionChanged);
            // 
            // addFilterButton
            // 
            this.addFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFilterButton.Location = new System.Drawing.Point(16, 414);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.Size = new System.Drawing.Size(75, 23);
            this.addFilterButton.TabIndex = 7;
            this.addFilterButton.Text = "Add Filter";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.addFilterButton_Click);
            // 
            // editFilterButton
            // 
            this.editFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editFilterButton.Enabled = false;
            this.editFilterButton.Location = new System.Drawing.Point(97, 415);
            this.editFilterButton.Name = "editFilterButton";
            this.editFilterButton.Size = new System.Drawing.Size(75, 23);
            this.editFilterButton.TabIndex = 8;
            this.editFilterButton.Text = "Edit Filter";
            this.editFilterButton.UseVisualStyleBackColor = true;
            this.editFilterButton.Click += new System.EventHandler(this.editFilterButton_Click);
            // 
            // deleteFilterButton
            // 
            this.deleteFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteFilterButton.Enabled = false;
            this.deleteFilterButton.Location = new System.Drawing.Point(178, 415);
            this.deleteFilterButton.Name = "deleteFilterButton";
            this.deleteFilterButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFilterButton.TabIndex = 9;
            this.deleteFilterButton.Text = "Delete Filter";
            this.deleteFilterButton.UseVisualStyleBackColor = true;
            this.deleteFilterButton.Click += new System.EventHandler(this.deleteFilterButton_Click);
            // 
            // modifiedByLabel
            // 
            this.modifiedByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedByLabel.Location = new System.Drawing.Point(602, 13);
            this.modifiedByLabel.Name = "modifiedByLabel";
            this.modifiedByLabel.Size = new System.Drawing.Size(186, 17);
            this.modifiedByLabel.TabIndex = 10;
            this.modifiedByLabel.Text = "modifiedBy";
            this.modifiedByLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // modifiedDateLabel
            // 
            this.modifiedDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedDateLabel.Location = new System.Drawing.Point(605, 40);
            this.modifiedDateLabel.Name = "modifiedDateLabel";
            this.modifiedDateLabel.Size = new System.Drawing.Size(183, 23);
            this.modifiedDateLabel.TabIndex = 11;
            this.modifiedDateLabel.Text = "modifiedDate";
            this.modifiedDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(632, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ReportBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.modifiedDateLabel);
            this.Controls.Add(this.modifiedByLabel);
            this.Controls.Add(this.deleteFilterButton);
            this.Controls.Add(this.editFilterButton);
            this.Controls.Add(this.addFilterButton);
            this.Controls.Add(this.filtersGridView);
            this.Controls.Add(this.filtersLabel);
            this.Controls.Add(this.reportSourceLabel);
            this.Controls.Add(this.reportSourceDropDown);
            this.Controls.Add(this.saveOrCreateButton);
            this.Controls.Add(this.reportNameTextBox);
            this.Controls.Add(this.reportNameLabel);
            this.Name = "ReportBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Builder";
            this.Load += new System.EventHandler(this.ReportBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filtersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportNameLabel;
        private System.Windows.Forms.TextBox reportNameTextBox;
        private System.Windows.Forms.Button saveOrCreateButton;
        private System.Windows.Forms.ComboBox reportSourceDropDown;
        private System.Windows.Forms.Label reportSourceLabel;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.DataGridView filtersGridView;
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.Button editFilterButton;
        private System.Windows.Forms.Button deleteFilterButton;
        private System.Windows.Forms.Label modifiedByLabel;
        private System.Windows.Forms.Label modifiedDateLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}