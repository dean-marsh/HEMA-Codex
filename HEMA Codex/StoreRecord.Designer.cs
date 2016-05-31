namespace HEMA_Codex
{
    partial class StoreRecord
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
            this.gboxDisplay = new System.Windows.Forms.GroupBox();
            this.lviewRecord = new System.Windows.Forms.ListView();
            this.gboxInfo = new System.Windows.Forms.GroupBox();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.txtDiscipline = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.txtAddonInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gboxDisplay.SuspendLayout();
            this.gboxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDisplay
            // 
            this.gboxDisplay.Controls.Add(this.lviewRecord);
            this.gboxDisplay.Location = new System.Drawing.Point(12, 12);
            this.gboxDisplay.Name = "gboxDisplay";
            this.gboxDisplay.Size = new System.Drawing.Size(296, 361);
            this.gboxDisplay.TabIndex = 21;
            this.gboxDisplay.TabStop = false;
            this.gboxDisplay.Text = "Entries";
            // 
            // lviewRecord
            // 
            this.lviewRecord.Location = new System.Drawing.Point(6, 19);
            this.lviewRecord.Name = "lviewRecord";
            this.lviewRecord.Size = new System.Drawing.Size(278, 332);
            this.lviewRecord.TabIndex = 0;
            this.lviewRecord.UseCompatibleStateImageBehavior = false;
            this.lviewRecord.View = System.Windows.Forms.View.Details;
            this.lviewRecord.SelectedIndexChanged += new System.EventHandler(this.lviewRecord_SelectedIndexChanged);
            // 
            // gboxInfo
            // 
            this.gboxInfo.Controls.Add(this.lblDiscipline);
            this.gboxInfo.Controls.Add(this.txtDiscipline);
            this.gboxInfo.Controls.Add(this.txtDate);
            this.gboxInfo.Controls.Add(this.lblSchool);
            this.gboxInfo.Controls.Add(this.txtSchool);
            this.gboxInfo.Controls.Add(this.txtAddonInfo);
            this.gboxInfo.Controls.Add(this.lblInfo);
            this.gboxInfo.Controls.Add(this.lblName);
            this.gboxInfo.Controls.Add(this.lblCountry);
            this.gboxInfo.Controls.Add(this.txtSource);
            this.gboxInfo.Controls.Add(this.lblDate);
            this.gboxInfo.Controls.Add(this.lblSource);
            this.gboxInfo.Controls.Add(this.txtCountry);
            this.gboxInfo.Controls.Add(this.btnSave);
            this.gboxInfo.Controls.Add(this.btnAdd);
            this.gboxInfo.Controls.Add(this.txtName);
            this.gboxInfo.Controls.Add(this.btnDelete);
            this.gboxInfo.Location = new System.Drawing.Point(314, 12);
            this.gboxInfo.Name = "gboxInfo";
            this.gboxInfo.Size = new System.Drawing.Size(396, 361);
            this.gboxInfo.TabIndex = 20;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "Information";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(55, 138);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(66, 13);
            this.lblDiscipline.TabIndex = 22;
            this.lblDiscipline.Text = "Discipline(s):";
            // 
            // txtDiscipline
            // 
            this.txtDiscipline.Location = new System.Drawing.Point(127, 123);
            this.txtDiscipline.Multiline = true;
            this.txtDiscipline.Name = "txtDiscipline";
            this.txtDiscipline.Size = new System.Drawing.Size(235, 40);
            this.txtDiscipline.TabIndex = 21;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(127, 97);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(235, 20);
            this.txtDate.TabIndex = 5;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(78, 74);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(43, 13);
            this.lblSchool.TabIndex = 11;
            this.lblSchool.Text = "School:";
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(127, 71);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(235, 20);
            this.txtSchool.TabIndex = 4;
            // 
            // txtAddonInfo
            // 
            this.txtAddonInfo.Location = new System.Drawing.Point(6, 237);
            this.txtAddonInfo.Multiline = true;
            this.txtAddonInfo.Name = "txtAddonInfo";
            this.txtAddonInfo.Size = new System.Drawing.Size(383, 90);
            this.txtAddonInfo.TabIndex = 15;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(5, 218);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(111, 13);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "Additional Information:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(72, 48);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(49, 13);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country: ";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(127, 169);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(235, 47);
            this.txtSource.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(55, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date Active:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(20, 172);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(101, 13);
            this.lblSource.TabIndex = 13;
            this.lblSource.Text = "Source(s) Authored:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(127, 45);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(235, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(303, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StoreRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 381);
            this.Controls.Add(this.gboxDisplay);
            this.Controls.Add(this.gboxInfo);
            this.Name = "StoreRecord";
            this.Text = "HEMA Codex";
            this.gboxDisplay.ResumeLayout(false);
            this.gboxInfo.ResumeLayout(false);
            this.gboxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDisplay;
        private System.Windows.Forms.ListView lviewRecord;
        private System.Windows.Forms.GroupBox gboxInfo;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.TextBox txtDiscipline;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.TextBox txtAddonInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
    }
}

