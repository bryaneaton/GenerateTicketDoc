﻿namespace GenerateTicketDoc
{
    partial class TicketForm
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
            this.getDocs = new System.Windows.Forms.Button();
            this.txtDescription = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtAnalystName = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtApplicationName = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtRollBack1 = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtRollBack2 = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtSystemAffected1 = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtTestingDescription = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtSystemAffected2 = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtDepartment = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtLastName = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtFirstName = new GenerateTicketDoc.WaterMarkTextBox();
            this.txtTicketNumber = new GenerateTicketDoc.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // getDocs
            // 
            this.getDocs.Location = new System.Drawing.Point(174, 169);
            this.getDocs.Name = "getDocs";
            this.getDocs.Size = new System.Drawing.Size(104, 23);
            this.getDocs.TabIndex = 99;
            this.getDocs.Text = "Create Docs!";
            this.getDocs.UseVisualStyleBackColor = true;
            this.getDocs.Click += new System.EventHandler(this.getDocs_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescription.Location = new System.Drawing.Point(173, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 22;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtDescription.WaterMarkText = "Ticket Description";
            // 
            // txtAnalystName
            // 
            this.txtAnalystName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAnalystName.Location = new System.Drawing.Point(173, 117);
            this.txtAnalystName.Name = "txtAnalystName";
            this.txtAnalystName.Size = new System.Drawing.Size(100, 20);
            this.txtAnalystName.TabIndex = 26;
            this.txtAnalystName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtAnalystName.WaterMarkText = "Analyst Name";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtApplicationName.Location = new System.Drawing.Point(173, 91);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(100, 20);
            this.txtApplicationName.TabIndex = 25;
            this.txtApplicationName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtApplicationName.WaterMarkText = "Application Name";
            // 
            // txtRollBack1
            // 
            this.txtRollBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRollBack1.Location = new System.Drawing.Point(174, 65);
            this.txtRollBack1.Name = "txtRollBack1";
            this.txtRollBack1.Size = new System.Drawing.Size(100, 20);
            this.txtRollBack1.TabIndex = 24;
            this.txtRollBack1.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtRollBack1.WaterMarkText = "RollBack 1 SVN#";
            // 
            // txtRollBack2
            // 
            this.txtRollBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRollBack2.Location = new System.Drawing.Point(174, 39);
            this.txtRollBack2.Name = "txtRollBack2";
            this.txtRollBack2.Size = new System.Drawing.Size(100, 20);
            this.txtRollBack2.TabIndex = 23;
            this.txtRollBack2.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtRollBack2.WaterMarkText = "RollBack 2 SVN#";
            // 
            // txtSystemAffected1
            // 
            this.txtSystemAffected1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSystemAffected1.Location = new System.Drawing.Point(13, 117);
            this.txtSystemAffected1.Name = "txtSystemAffected1";
            this.txtSystemAffected1.Size = new System.Drawing.Size(100, 20);
            this.txtSystemAffected1.TabIndex = 20;
            this.txtSystemAffected1.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSystemAffected1.WaterMarkText = "System Affected 1";
            // 
            // txtTestingDescription
            // 
            this.txtTestingDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTestingDescription.Location = new System.Drawing.Point(173, 143);
            this.txtTestingDescription.Name = "txtTestingDescription";
            this.txtTestingDescription.Size = new System.Drawing.Size(100, 20);
            this.txtTestingDescription.TabIndex = 27;
            this.txtTestingDescription.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtTestingDescription.WaterMarkText = "Testing Description";
            // 
            // txtSystemAffected2
            // 
            this.txtSystemAffected2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSystemAffected2.Location = new System.Drawing.Point(12, 143);
            this.txtSystemAffected2.Name = "txtSystemAffected2";
            this.txtSystemAffected2.Size = new System.Drawing.Size(100, 20);
            this.txtSystemAffected2.TabIndex = 21;
            this.txtSystemAffected2.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSystemAffected2.WaterMarkText = "System Affected 2";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDepartment.Location = new System.Drawing.Point(14, 91);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 19;
            this.txtDepartment.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtDepartment.WaterMarkText = "Enter Department";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLastName.Location = new System.Drawing.Point(12, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLastName.WaterMarkText = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFirstName.Location = new System.Drawing.Point(13, 39);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 17;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtFirstName.WaterMarkText = "First Name";
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTicketNumber.Location = new System.Drawing.Point(13, 13);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTicketNumber.TabIndex = 16;
            this.txtTicketNumber.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtTicketNumber.WaterMarkText = "Enter Ticket#";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAnalystName);
            this.Controls.Add(this.txtApplicationName);
            this.Controls.Add(this.txtRollBack1);
            this.Controls.Add(this.txtRollBack2);
            this.Controls.Add(this.txtSystemAffected1);
            this.Controls.Add(this.txtTestingDescription);
            this.Controls.Add(this.txtSystemAffected2);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.getDocs);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getDocs;
        private WaterMarkTextBox txtTicketNumber;
        private WaterMarkTextBox txtFirstName;
        private WaterMarkTextBox txtLastName;
        //private WaterMarkTextBox txtPhoneNumber;
        private WaterMarkTextBox txtDepartment;
        private WaterMarkTextBox txtSystemAffected1;
        private WaterMarkTextBox txtSystemAffected2;
        private WaterMarkTextBox txtDescription;
        private WaterMarkTextBox txtRollBack1;
        private WaterMarkTextBox txtRollBack2;
        private WaterMarkTextBox txtApplicationName;
        private WaterMarkTextBox txtAnalystName;
        private WaterMarkTextBox txtTestingDescription;
    }
}