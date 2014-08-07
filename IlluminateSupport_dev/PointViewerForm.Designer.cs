namespace IlluminateSupport_dev
{
    partial class PointViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointViewerForm));
            this.pointIDTitleLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.PointIDTB = new System.Windows.Forms.MaskedTextBox();
            this.IdListBox = new System.Windows.Forms.ListBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.resetFiltersButton = new System.Windows.Forms.Button();
            this.exsportButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pointIDTitleLabel
            // 
            this.pointIDTitleLabel.AutoSize = true;
            this.pointIDTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointIDTitleLabel.Location = new System.Drawing.Point(28, 10);
            this.pointIDTitleLabel.Name = "pointIDTitleLabel";
            this.pointIDTitleLabel.Size = new System.Drawing.Size(62, 15);
            this.pointIDTitleLabel.TabIndex = 3;
            this.pointIDTitleLabel.Text = "Point ID:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(165, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(141, 22);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Open Point Viewer";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PointIDTB
            // 
            this.PointIDTB.Location = new System.Drawing.Point(96, 9);
            this.PointIDTB.Mask = "000-000-00";
            this.PointIDTB.Name = "PointIDTB";
            this.PointIDTB.Size = new System.Drawing.Size(63, 20);
            this.PointIDTB.TabIndex = 10;
            // 
            // IdListBox
            // 
            this.IdListBox.FormattingEnabled = true;
            this.IdListBox.Location = new System.Drawing.Point(15, 35);
            this.IdListBox.Name = "IdListBox";
            this.IdListBox.Size = new System.Drawing.Size(729, 589);
            this.IdListBox.TabIndex = 11;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(312, 7);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(141, 22);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // resetFiltersButton
            // 
            this.resetFiltersButton.Location = new System.Drawing.Point(603, 7);
            this.resetFiltersButton.Name = "resetFiltersButton";
            this.resetFiltersButton.Size = new System.Drawing.Size(141, 22);
            this.resetFiltersButton.TabIndex = 14;
            this.resetFiltersButton.Text = "Reset Filters";
            this.resetFiltersButton.UseVisualStyleBackColor = true;
            this.resetFiltersButton.Visible = false;
            this.resetFiltersButton.Click += new System.EventHandler(this.resetFiltersButton_Click);
            // 
            // exsportButton
            // 
            this.exsportButton.Location = new System.Drawing.Point(459, 7);
            this.exsportButton.Name = "exsportButton";
            this.exsportButton.Size = new System.Drawing.Size(141, 22);
            this.exsportButton.TabIndex = 15;
            this.exsportButton.Text = "Export";
            this.exsportButton.UseVisualStyleBackColor = true;
            this.exsportButton.Click += new System.EventHandler(this.exsportButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // PointViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 645);
            this.Controls.Add(this.exsportButton);
            this.Controls.Add(this.resetFiltersButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.IdListBox);
            this.Controls.Add(this.PointIDTB);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pointIDTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PointViewerForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointIDTitleLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MaskedTextBox PointIDTB;
        private System.Windows.Forms.ListBox IdListBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button resetFiltersButton;
        private System.Windows.Forms.Button exsportButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

