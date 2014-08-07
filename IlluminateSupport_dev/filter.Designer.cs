namespace IlluminateSupport_dev
{
    partial class filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filter));
            this.updateFilterButton = new System.Windows.Forms.Button();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.stateGroupBox = new System.Windows.Forms.GroupBox();
            this.priorityGroupBox = new System.Windows.Forms.GroupBox();
            this.closeFilterButton = new System.Windows.Forms.Button();
            this.bugCheckBox = new System.Windows.Forms.CheckBox();
            this.newCheckBox = new System.Windows.Forms.CheckBox();
            this.pendingDeploymentCheckBox = new System.Windows.Forms.CheckBox();
            this.openCheckBox = new System.Windows.Forms.CheckBox();
            this.pendingEngineeringCheckBox = new System.Windows.Forms.CheckBox();
            this.questionCheckBox = new System.Windows.Forms.CheckBox();
            this.informationCheckBox = new System.Windows.Forms.CheckBox();
            this.installationCheckBox = new System.Windows.Forms.CheckBox();
            this.environmentCheckBox = new System.Windows.Forms.CheckBox();
            this.usabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.enhancementCheckBox = new System.Windows.Forms.CheckBox();
            this.closedCheckBox = new System.Windows.Forms.CheckBox();
            this.urgentCheckBox = new System.Windows.Forms.CheckBox();
            this.highCheckBox = new System.Windows.Forms.CheckBox();
            this.mediumCheckBox = new System.Windows.Forms.CheckBox();
            this.lowCheckBox = new System.Windows.Forms.CheckBox();
            this.typeGroupBox.SuspendLayout();
            this.stateGroupBox.SuspendLayout();
            this.priorityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateFilterButton
            // 
            this.updateFilterButton.Location = new System.Drawing.Point(11, 261);
            this.updateFilterButton.Name = "updateFilterButton";
            this.updateFilterButton.Size = new System.Drawing.Size(137, 23);
            this.updateFilterButton.TabIndex = 18;
            this.updateFilterButton.Text = "Update Filter";
            this.updateFilterButton.UseVisualStyleBackColor = true;
            this.updateFilterButton.Click += new System.EventHandler(this.updateFilterButton_Click);
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.bugCheckBox);
            this.typeGroupBox.Controls.Add(this.enhancementCheckBox);
            this.typeGroupBox.Controls.Add(this.usabilityCheckBox);
            this.typeGroupBox.Controls.Add(this.environmentCheckBox);
            this.typeGroupBox.Controls.Add(this.installationCheckBox);
            this.typeGroupBox.Controls.Add(this.informationCheckBox);
            this.typeGroupBox.Controls.Add(this.questionCheckBox);
            this.typeGroupBox.Location = new System.Drawing.Point(11, 12);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(281, 90);
            this.typeGroupBox.TabIndex = 0;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type";
            // 
            // stateGroupBox
            // 
            this.stateGroupBox.Controls.Add(this.newCheckBox);
            this.stateGroupBox.Controls.Add(this.pendingDeploymentCheckBox);
            this.stateGroupBox.Controls.Add(this.openCheckBox);
            this.stateGroupBox.Controls.Add(this.pendingEngineeringCheckBox);
            this.stateGroupBox.Controls.Add(this.closedCheckBox);
            this.stateGroupBox.Location = new System.Drawing.Point(11, 108);
            this.stateGroupBox.Name = "stateGroupBox";
            this.stateGroupBox.Size = new System.Drawing.Size(281, 91);
            this.stateGroupBox.TabIndex = 0;
            this.stateGroupBox.TabStop = false;
            this.stateGroupBox.Text = "State";
            // 
            // priorityGroupBox
            // 
            this.priorityGroupBox.Controls.Add(this.mediumCheckBox);
            this.priorityGroupBox.Controls.Add(this.lowCheckBox);
            this.priorityGroupBox.Controls.Add(this.urgentCheckBox);
            this.priorityGroupBox.Controls.Add(this.highCheckBox);
            this.priorityGroupBox.Location = new System.Drawing.Point(11, 205);
            this.priorityGroupBox.Name = "priorityGroupBox";
            this.priorityGroupBox.Size = new System.Drawing.Size(281, 50);
            this.priorityGroupBox.TabIndex = 0;
            this.priorityGroupBox.TabStop = false;
            this.priorityGroupBox.Text = "Priority";
            // 
            // closeFilterButton
            // 
            this.closeFilterButton.Location = new System.Drawing.Point(154, 261);
            this.closeFilterButton.Name = "closeFilterButton";
            this.closeFilterButton.Size = new System.Drawing.Size(138, 23);
            this.closeFilterButton.TabIndex = 21;
            this.closeFilterButton.Text = "Cancel";
            this.closeFilterButton.UseVisualStyleBackColor = true;
            this.closeFilterButton.Click += new System.EventHandler(this.closeFilterButton_Click);
            // 
            // bugCheckBox
            // 
            this.bugCheckBox.AutoSize = true;
            this.bugCheckBox.Checked = true;
            this.bugCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bugCheckBox.Location = new System.Drawing.Point(13, 18);
            this.bugCheckBox.Name = "bugCheckBox";
            this.bugCheckBox.Size = new System.Drawing.Size(45, 17);
            this.bugCheckBox.TabIndex = 22;
            this.bugCheckBox.Text = "Bug";
            this.bugCheckBox.UseVisualStyleBackColor = true;
            // 
            // newCheckBox
            // 
            this.newCheckBox.AutoSize = true;
            this.newCheckBox.Checked = true;
            this.newCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newCheckBox.Location = new System.Drawing.Point(13, 19);
            this.newCheckBox.Name = "newCheckBox";
            this.newCheckBox.Size = new System.Drawing.Size(48, 17);
            this.newCheckBox.TabIndex = 23;
            this.newCheckBox.Text = "New";
            this.newCheckBox.UseVisualStyleBackColor = true;
            // 
            // pendingDeploymentCheckBox
            // 
            this.pendingDeploymentCheckBox.AutoSize = true;
            this.pendingDeploymentCheckBox.Checked = true;
            this.pendingDeploymentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pendingDeploymentCheckBox.Location = new System.Drawing.Point(104, 19);
            this.pendingDeploymentCheckBox.Name = "pendingDeploymentCheckBox";
            this.pendingDeploymentCheckBox.Size = new System.Drawing.Size(124, 17);
            this.pendingDeploymentCheckBox.TabIndex = 24;
            this.pendingDeploymentCheckBox.Text = "Pending Deployment";
            this.pendingDeploymentCheckBox.UseVisualStyleBackColor = true;
            // 
            // openCheckBox
            // 
            this.openCheckBox.AutoSize = true;
            this.openCheckBox.Checked = true;
            this.openCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openCheckBox.Location = new System.Drawing.Point(13, 43);
            this.openCheckBox.Name = "openCheckBox";
            this.openCheckBox.Size = new System.Drawing.Size(52, 17);
            this.openCheckBox.TabIndex = 25;
            this.openCheckBox.Text = "Open";
            this.openCheckBox.UseVisualStyleBackColor = true;
            // 
            // pendingEngineeringCheckBox
            // 
            this.pendingEngineeringCheckBox.AutoSize = true;
            this.pendingEngineeringCheckBox.Checked = true;
            this.pendingEngineeringCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pendingEngineeringCheckBox.Location = new System.Drawing.Point(104, 43);
            this.pendingEngineeringCheckBox.Name = "pendingEngineeringCheckBox";
            this.pendingEngineeringCheckBox.Size = new System.Drawing.Size(124, 17);
            this.pendingEngineeringCheckBox.TabIndex = 26;
            this.pendingEngineeringCheckBox.Text = "Pending Engineering";
            this.pendingEngineeringCheckBox.UseVisualStyleBackColor = true;
            // 
            // questionCheckBox
            // 
            this.questionCheckBox.AutoSize = true;
            this.questionCheckBox.Checked = true;
            this.questionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.questionCheckBox.Location = new System.Drawing.Point(104, 65);
            this.questionCheckBox.Name = "questionCheckBox";
            this.questionCheckBox.Size = new System.Drawing.Size(68, 17);
            this.questionCheckBox.TabIndex = 27;
            this.questionCheckBox.Text = "Question";
            this.questionCheckBox.UseVisualStyleBackColor = true;
            // 
            // informationCheckBox
            // 
            this.informationCheckBox.AutoSize = true;
            this.informationCheckBox.Checked = true;
            this.informationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.informationCheckBox.Location = new System.Drawing.Point(13, 65);
            this.informationCheckBox.Name = "informationCheckBox";
            this.informationCheckBox.Size = new System.Drawing.Size(78, 17);
            this.informationCheckBox.TabIndex = 28;
            this.informationCheckBox.Text = "Information";
            this.informationCheckBox.UseVisualStyleBackColor = true;
            // 
            // installationCheckBox
            // 
            this.installationCheckBox.AutoSize = true;
            this.installationCheckBox.Checked = true;
            this.installationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.installationCheckBox.Location = new System.Drawing.Point(104, 42);
            this.installationCheckBox.Name = "installationCheckBox";
            this.installationCheckBox.Size = new System.Drawing.Size(76, 17);
            this.installationCheckBox.TabIndex = 29;
            this.installationCheckBox.Text = "Installation";
            this.installationCheckBox.UseVisualStyleBackColor = true;
            // 
            // environmentCheckBox
            // 
            this.environmentCheckBox.AutoSize = true;
            this.environmentCheckBox.Checked = true;
            this.environmentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.environmentCheckBox.Location = new System.Drawing.Point(13, 42);
            this.environmentCheckBox.Name = "environmentCheckBox";
            this.environmentCheckBox.Size = new System.Drawing.Size(85, 17);
            this.environmentCheckBox.TabIndex = 30;
            this.environmentCheckBox.Text = "Environment";
            this.environmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // usabilityCheckBox
            // 
            this.usabilityCheckBox.AutoSize = true;
            this.usabilityCheckBox.Checked = true;
            this.usabilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usabilityCheckBox.Location = new System.Drawing.Point(211, 18);
            this.usabilityCheckBox.Name = "usabilityCheckBox";
            this.usabilityCheckBox.Size = new System.Drawing.Size(65, 17);
            this.usabilityCheckBox.TabIndex = 31;
            this.usabilityCheckBox.Text = "Usability";
            this.usabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // enhancementCheckBox
            // 
            this.enhancementCheckBox.AutoSize = true;
            this.enhancementCheckBox.Checked = true;
            this.enhancementCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enhancementCheckBox.Location = new System.Drawing.Point(104, 18);
            this.enhancementCheckBox.Name = "enhancementCheckBox";
            this.enhancementCheckBox.Size = new System.Drawing.Size(92, 17);
            this.enhancementCheckBox.TabIndex = 32;
            this.enhancementCheckBox.Text = "Enhancement";
            this.enhancementCheckBox.UseVisualStyleBackColor = true;
            // 
            // closedCheckBox
            // 
            this.closedCheckBox.AutoSize = true;
            this.closedCheckBox.Checked = true;
            this.closedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closedCheckBox.Location = new System.Drawing.Point(13, 66);
            this.closedCheckBox.Name = "closedCheckBox";
            this.closedCheckBox.Size = new System.Drawing.Size(58, 17);
            this.closedCheckBox.TabIndex = 33;
            this.closedCheckBox.Text = "Closed";
            this.closedCheckBox.UseVisualStyleBackColor = true;
            // 
            // urgentCheckBox
            // 
            this.urgentCheckBox.AutoSize = true;
            this.urgentCheckBox.Checked = true;
            this.urgentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.urgentCheckBox.Location = new System.Drawing.Point(211, 18);
            this.urgentCheckBox.Name = "urgentCheckBox";
            this.urgentCheckBox.Size = new System.Drawing.Size(58, 17);
            this.urgentCheckBox.TabIndex = 34;
            this.urgentCheckBox.Text = "Urgent";
            this.urgentCheckBox.UseVisualStyleBackColor = true;
            // 
            // highCheckBox
            // 
            this.highCheckBox.AutoSize = true;
            this.highCheckBox.Checked = true;
            this.highCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highCheckBox.Location = new System.Drawing.Point(146, 18);
            this.highCheckBox.Name = "highCheckBox";
            this.highCheckBox.Size = new System.Drawing.Size(48, 17);
            this.highCheckBox.TabIndex = 35;
            this.highCheckBox.Text = "High";
            this.highCheckBox.UseVisualStyleBackColor = true;
            // 
            // mediumCheckBox
            // 
            this.mediumCheckBox.AutoSize = true;
            this.mediumCheckBox.Checked = true;
            this.mediumCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mediumCheckBox.Location = new System.Drawing.Point(77, 18);
            this.mediumCheckBox.Name = "mediumCheckBox";
            this.mediumCheckBox.Size = new System.Drawing.Size(63, 17);
            this.mediumCheckBox.TabIndex = 36;
            this.mediumCheckBox.Text = "Medium";
            this.mediumCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowCheckBox
            // 
            this.lowCheckBox.AutoSize = true;
            this.lowCheckBox.Checked = true;
            this.lowCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowCheckBox.Location = new System.Drawing.Point(13, 18);
            this.lowCheckBox.Name = "lowCheckBox";
            this.lowCheckBox.Size = new System.Drawing.Size(46, 17);
            this.lowCheckBox.TabIndex = 37;
            this.lowCheckBox.Text = "Low";
            this.lowCheckBox.UseVisualStyleBackColor = true;
            // 
            // filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 293);
            this.Controls.Add(this.closeFilterButton);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.stateGroupBox);
            this.Controls.Add(this.priorityGroupBox);
            this.Controls.Add(this.updateFilterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "filter";
            this.Text = "Filter Points";
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.stateGroupBox.ResumeLayout(false);
            this.stateGroupBox.PerformLayout();
            this.priorityGroupBox.ResumeLayout(false);
            this.priorityGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateFilterButton;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.GroupBox stateGroupBox;
        private System.Windows.Forms.GroupBox priorityGroupBox;
        private System.Windows.Forms.Button closeFilterButton;
        private System.Windows.Forms.CheckBox bugCheckBox;
        private System.Windows.Forms.CheckBox enhancementCheckBox;
        private System.Windows.Forms.CheckBox usabilityCheckBox;
        private System.Windows.Forms.CheckBox environmentCheckBox;
        private System.Windows.Forms.CheckBox installationCheckBox;
        private System.Windows.Forms.CheckBox informationCheckBox;
        private System.Windows.Forms.CheckBox questionCheckBox;
        private System.Windows.Forms.CheckBox newCheckBox;
        private System.Windows.Forms.CheckBox pendingDeploymentCheckBox;
        private System.Windows.Forms.CheckBox openCheckBox;
        private System.Windows.Forms.CheckBox pendingEngineeringCheckBox;
        private System.Windows.Forms.CheckBox closedCheckBox;
        private System.Windows.Forms.CheckBox mediumCheckBox;
        private System.Windows.Forms.CheckBox lowCheckBox;
        private System.Windows.Forms.CheckBox urgentCheckBox;
        private System.Windows.Forms.CheckBox highCheckBox;
    }
}