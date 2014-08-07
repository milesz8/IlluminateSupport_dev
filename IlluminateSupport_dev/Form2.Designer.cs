namespace IlluminateSupport_dev
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.solutionLabel = new System.Windows.Forms.Label();
            this.solutionGroupBox = new System.Windows.Forms.GroupBox();
            this.priorityGroupBox = new System.Windows.Forms.GroupBox();
            this.lowPriorityLabel = new System.Windows.Forms.Label();
            this.urgentPriorityLabel = new System.Windows.Forms.Label();
            this.mediumPriorityLabel = new System.Windows.Forms.Label();
            this.highPriorityLabel = new System.Windows.Forms.Label();
            this.pointGroupBox = new System.Windows.Forms.GroupBox();
            this.stateTitleLabel = new System.Windows.Forms.Label();
            this.lastUpdateTitleLabel = new System.Windows.Forms.Label();
            this.createdOnTitleLabel = new System.Windows.Forms.Label();
            this.typeTitleLabel = new System.Windows.Forms.Label();
            this.numberTitleLabel = new System.Windows.Forms.Label();
            this.notesGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.closePointViewButton = new System.Windows.Forms.Button();
            this.solutionGroupBox.SuspendLayout();
            this.priorityGroupBox.SuspendLayout();
            this.pointGroupBox.SuspendLayout();
            this.notesGroupBox.SuspendLayout();
            this.descriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // solutionLabel
            // 
            this.solutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionLabel.Location = new System.Drawing.Point(6, 17);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(235, 336);
            this.solutionLabel.TabIndex = 1;
            // 
            // solutionGroupBox
            // 
            this.solutionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionGroupBox.Controls.Add(this.solutionLabel);
            this.solutionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionGroupBox.Location = new System.Drawing.Point(8, 326);
            this.solutionGroupBox.Name = "solutionGroupBox";
            this.solutionGroupBox.Size = new System.Drawing.Size(247, 356);
            this.solutionGroupBox.TabIndex = 16;
            this.solutionGroupBox.TabStop = false;
            this.solutionGroupBox.Text = "Solution";
            // 
            // priorityGroupBox
            // 
            this.priorityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityGroupBox.Controls.Add(this.lowPriorityLabel);
            this.priorityGroupBox.Controls.Add(this.urgentPriorityLabel);
            this.priorityGroupBox.Controls.Add(this.mediumPriorityLabel);
            this.priorityGroupBox.Controls.Add(this.highPriorityLabel);
            this.priorityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityGroupBox.Location = new System.Drawing.Point(8, 263);
            this.priorityGroupBox.Name = "priorityGroupBox";
            this.priorityGroupBox.Size = new System.Drawing.Size(247, 52);
            this.priorityGroupBox.TabIndex = 17;
            this.priorityGroupBox.TabStop = false;
            this.priorityGroupBox.Text = "Priority";
            // 
            // lowPriorityLabel
            // 
            this.lowPriorityLabel.AutoSize = true;
            this.lowPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowPriorityLabel.Location = new System.Drawing.Point(17, 25);
            this.lowPriorityLabel.Name = "lowPriorityLabel";
            this.lowPriorityLabel.Size = new System.Drawing.Size(27, 13);
            this.lowPriorityLabel.TabIndex = 10;
            this.lowPriorityLabel.Text = "Low";
            // 
            // urgentPriorityLabel
            // 
            this.urgentPriorityLabel.AutoSize = true;
            this.urgentPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urgentPriorityLabel.Location = new System.Drawing.Point(190, 25);
            this.urgentPriorityLabel.Name = "urgentPriorityLabel";
            this.urgentPriorityLabel.Size = new System.Drawing.Size(39, 13);
            this.urgentPriorityLabel.TabIndex = 13;
            this.urgentPriorityLabel.Text = "Urgent";
            // 
            // mediumPriorityLabel
            // 
            this.mediumPriorityLabel.AutoSize = true;
            this.mediumPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumPriorityLabel.Location = new System.Drawing.Point(69, 25);
            this.mediumPriorityLabel.Name = "mediumPriorityLabel";
            this.mediumPriorityLabel.Size = new System.Drawing.Size(44, 13);
            this.mediumPriorityLabel.TabIndex = 11;
            this.mediumPriorityLabel.Text = "Medium";
            // 
            // highPriorityLabel
            // 
            this.highPriorityLabel.AutoSize = true;
            this.highPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highPriorityLabel.Location = new System.Drawing.Point(144, 25);
            this.highPriorityLabel.Name = "highPriorityLabel";
            this.highPriorityLabel.Size = new System.Drawing.Size(29, 13);
            this.highPriorityLabel.TabIndex = 12;
            this.highPriorityLabel.Text = "High";
            // 
            // pointGroupBox
            // 
            this.pointGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pointGroupBox.Controls.Add(this.stateTitleLabel);
            this.pointGroupBox.Controls.Add(this.solutionGroupBox);
            this.pointGroupBox.Controls.Add(this.priorityGroupBox);
            this.pointGroupBox.Controls.Add(this.lastUpdateTitleLabel);
            this.pointGroupBox.Controls.Add(this.createdOnTitleLabel);
            this.pointGroupBox.Controls.Add(this.typeTitleLabel);
            this.pointGroupBox.Controls.Add(this.numberTitleLabel);
            this.pointGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointGroupBox.Location = new System.Drawing.Point(883, 12);
            this.pointGroupBox.Name = "pointGroupBox";
            this.pointGroupBox.Size = new System.Drawing.Size(261, 688);
            this.pointGroupBox.TabIndex = 18;
            this.pointGroupBox.TabStop = false;
            this.pointGroupBox.Text = "Point Info";
            // 
            // stateTitleLabel
            // 
            this.stateTitleLabel.AutoSize = true;
            this.stateTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTitleLabel.Location = new System.Drawing.Point(87, 223);
            this.stateTitleLabel.Name = "stateTitleLabel";
            this.stateTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.stateTitleLabel.TabIndex = 8;
            this.stateTitleLabel.Text = "State:";
            // 
            // lastUpdateTitleLabel
            // 
            this.lastUpdateTitleLabel.AutoSize = true;
            this.lastUpdateTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdateTitleLabel.Location = new System.Drawing.Point(50, 175);
            this.lastUpdateTitleLabel.Name = "lastUpdateTitleLabel";
            this.lastUpdateTitleLabel.Size = new System.Drawing.Size(72, 13);
            this.lastUpdateTitleLabel.TabIndex = 6;
            this.lastUpdateTitleLabel.Text = "Last updated:";
            // 
            // createdOnTitleLabel
            // 
            this.createdOnTitleLabel.AutoSize = true;
            this.createdOnTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdOnTitleLabel.Location = new System.Drawing.Point(60, 127);
            this.createdOnTitleLabel.Name = "createdOnTitleLabel";
            this.createdOnTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.createdOnTitleLabel.TabIndex = 4;
            this.createdOnTitleLabel.Text = "Created on:";
            // 
            // typeTitleLabel
            // 
            this.typeTitleLabel.AutoSize = true;
            this.typeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTitleLabel.Location = new System.Drawing.Point(88, 78);
            this.typeTitleLabel.Name = "typeTitleLabel";
            this.typeTitleLabel.Size = new System.Drawing.Size(34, 13);
            this.typeTitleLabel.TabIndex = 2;
            this.typeTitleLabel.Text = "Type:";
            // 
            // numberTitleLabel
            // 
            this.numberTitleLabel.AutoSize = true;
            this.numberTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTitleLabel.Location = new System.Drawing.Point(75, 34);
            this.numberTitleLabel.Name = "numberTitleLabel";
            this.numberTitleLabel.Size = new System.Drawing.Size(47, 13);
            this.numberTitleLabel.TabIndex = 0;
            this.numberTitleLabel.Text = "Number:";
            // 
            // notesGroupBox
            // 
            this.notesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesGroupBox.Controls.Add(this.notesTextBox);
            this.notesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesGroupBox.Location = new System.Drawing.Point(12, 125);
            this.notesGroupBox.Name = "notesGroupBox";
            this.notesGroupBox.Size = new System.Drawing.Size(865, 604);
            this.notesGroupBox.TabIndex = 19;
            this.notesGroupBox.TabStop = false;
            this.notesGroupBox.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.notesTextBox.Location = new System.Drawing.Point(6, 20);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(853, 584);
            this.notesTextBox.TabIndex = 0;
            this.notesTextBox.TabStop = false;
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionGroupBox.Controls.Add(this.descriptionLabel);
            this.descriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(865, 107);
            this.descriptionGroupBox.TabIndex = 20;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Description";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(6, 16);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(853, 88);
            this.descriptionLabel.TabIndex = 2;
            // 
            // closePointViewButton
            // 
            this.closePointViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closePointViewButton.Location = new System.Drawing.Point(883, 706);
            this.closePointViewButton.Name = "closePointViewButton";
            this.closePointViewButton.Size = new System.Drawing.Size(261, 23);
            this.closePointViewButton.TabIndex = 21;
            this.closePointViewButton.Text = "Close";
            this.closePointViewButton.UseVisualStyleBackColor = true;
            this.closePointViewButton.Click += new System.EventHandler(this.closePointViewButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 741);
            this.Controls.Add(this.closePointViewButton);
            this.Controls.Add(this.descriptionGroupBox);
            this.Controls.Add(this.notesGroupBox);
            this.Controls.Add(this.pointGroupBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Point View";
            this.solutionGroupBox.ResumeLayout(false);
            this.priorityGroupBox.ResumeLayout(false);
            this.priorityGroupBox.PerformLayout();
            this.pointGroupBox.ResumeLayout(false);
            this.pointGroupBox.PerformLayout();
            this.notesGroupBox.ResumeLayout(false);
            this.notesGroupBox.PerformLayout();
            this.descriptionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label solutionLabel;
        private System.Windows.Forms.GroupBox solutionGroupBox;
        private System.Windows.Forms.GroupBox priorityGroupBox;
        private System.Windows.Forms.Label lowPriorityLabel;
        private System.Windows.Forms.Label urgentPriorityLabel;
        private System.Windows.Forms.Label mediumPriorityLabel;
        private System.Windows.Forms.Label highPriorityLabel;
        private System.Windows.Forms.GroupBox pointGroupBox;
        private System.Windows.Forms.Label stateTitleLabel;
        private System.Windows.Forms.Label lastUpdateTitleLabel;
        private System.Windows.Forms.Label createdOnTitleLabel;
        private System.Windows.Forms.Label typeTitleLabel;
        private System.Windows.Forms.Label numberTitleLabel;
        private System.Windows.Forms.GroupBox notesGroupBox;
        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button closePointViewButton;
        private System.Windows.Forms.TextBox notesTextBox;

    }
}