namespace PickingTeams
{
    partial class frmPickingTeams
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnMakeGroups = new System.Windows.Forms.Button();
            this.txtTeamSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Name";
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(111, 85);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 95);
            this.lstNames.TabIndex = 2;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(244, 38);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 3;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnMakeGroups
            // 
            this.btnMakeGroups.Location = new System.Drawing.Point(121, 247);
            this.btnMakeGroups.Name = "btnMakeGroups";
            this.btnMakeGroups.Size = new System.Drawing.Size(105, 23);
            this.btnMakeGroups.TabIndex = 4;
            this.btnMakeGroups.Text = "Make Groups";
            this.btnMakeGroups.UseVisualStyleBackColor = true;
            this.btnMakeGroups.Click += new System.EventHandler(this.btnMakeGroups_Click);
            // 
            // txtTeamSize
            // 
            this.txtTeamSize.Location = new System.Drawing.Point(126, 208);
            this.txtTeamSize.Name = "txtTeamSize";
            this.txtTeamSize.Size = new System.Drawing.Size(100, 20);
            this.txtTeamSize.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TeamSize";
            // 
            // frmPickingTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(331, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamSize);
            this.Controls.Add(this.btnMakeGroups);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmPickingTeams";
            this.Text = "Picking Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnMakeGroups;
        private System.Windows.Forms.TextBox txtTeamSize;
        private System.Windows.Forms.Label label2;
    }
}

