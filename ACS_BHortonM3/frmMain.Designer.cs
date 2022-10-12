namespace ACS_BHortonM3
{
    partial class frmMain
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
            this.tbxEmpID = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxExtension = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEmpID
            // 
            this.tbxEmpID.Location = new System.Drawing.Point(165, 37);
            this.tbxEmpID.Multiline = true;
            this.tbxEmpID.Name = "tbxEmpID";
            this.tbxEmpID.Size = new System.Drawing.Size(200, 28);
            this.tbxEmpID.TabIndex = 0;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(165, 93);
            this.tbxFirstName.Multiline = true;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(200, 28);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(165, 149);
            this.tbxLastName.Multiline = true;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(200, 28);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxExtension
            // 
            this.tbxExtension.Location = new System.Drawing.Point(165, 200);
            this.tbxExtension.Multiline = true;
            this.tbxExtension.Name = "tbxExtension";
            this.tbxExtension.Size = new System.Drawing.Size(200, 28);
            this.tbxExtension.TabIndex = 3;
            // 
            // lblEmpID
            // 
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(24, 42);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(120, 23);
            this.lblEmpID.TabIndex = 4;
            this.lblEmpID.Text = "EmployeeID";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(24, 98);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 23);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(24, 154);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(120, 23);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblExtension
            // 
            this.lblExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(24, 205);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(120, 23);
            this.lblExtension.TabIndex = 7;
            this.lblExtension.Text = "Extension";
            this.lblExtension.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 543);
            this.ControlBox = false;
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.tbxExtension);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxEmpID);
            this.Name = "frmMain";
            this.Text = "Employees Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmpID;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxExtension;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblExtension;
    }
}

