namespace FabrikamSQL
{
    partial class Form1
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
            this.StudentIDPrompt = new System.Windows.Forms.Label();
            this.FNamePrompt = new System.Windows.Forms.Label();
            this.LNamePrompt = new System.Windows.Forms.Label();
            this.MajorPrompt = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.Major = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentIDPrompt
            // 
            this.StudentIDPrompt.AutoSize = true;
            this.StudentIDPrompt.Location = new System.Drawing.Point(13, 133);
            this.StudentIDPrompt.Name = "StudentIDPrompt";
            this.StudentIDPrompt.Size = new System.Drawing.Size(64, 13);
            this.StudentIDPrompt.TabIndex = 0;
            this.StudentIDPrompt.Text = "Student ID: ";
            this.StudentIDPrompt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FNamePrompt
            // 
            this.FNamePrompt.AutoSize = true;
            this.FNamePrompt.Location = new System.Drawing.Point(28, 31);
            this.FNamePrompt.Name = "FNamePrompt";
            this.FNamePrompt.Size = new System.Drawing.Size(63, 13);
            this.FNamePrompt.TabIndex = 1;
            this.FNamePrompt.Text = "First Name: ";
            this.FNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LNamePrompt
            // 
            this.LNamePrompt.AutoSize = true;
            this.LNamePrompt.Location = new System.Drawing.Point(28, 175);
            this.LNamePrompt.Name = "LNamePrompt";
            this.LNamePrompt.Size = new System.Drawing.Size(61, 13);
            this.LNamePrompt.TabIndex = 1;
            this.LNamePrompt.Text = "Last Name:";
            this.LNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MajorPrompt
            // 
            this.MajorPrompt.AutoSize = true;
            this.MajorPrompt.Location = new System.Drawing.Point(50, 220);
            this.MajorPrompt.Name = "MajorPrompt";
            this.MajorPrompt.Size = new System.Drawing.Size(39, 13);
            this.MajorPrompt.TabIndex = 1;
            this.MajorPrompt.Text = "Major: ";
            this.MajorPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(106, 130);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(153, 20);
            this.studentID.TabIndex = 2;
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(106, 30);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(153, 20);
            this.FName.TabIndex = 2;
            // 
            // Major
            // 
            this.Major.Location = new System.Drawing.Point(106, 217);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(153, 20);
            this.Major.TabIndex = 2;
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(106, 172);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(153, 20);
            this.LName.TabIndex = 2;
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(16, 74);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(89, 23);
            this.FindBtn.TabIndex = 3;
            this.FindBtn.Text = "FIND";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Location = new System.Drawing.Point(130, 74);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(89, 23);
            this.ClrBtn.TabIndex = 3;
            this.ClrBtn.Text = "CLEAR";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 278);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.MajorPrompt);
            this.Controls.Add(this.LNamePrompt);
            this.Controls.Add(this.FNamePrompt);
            this.Controls.Add(this.StudentIDPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentIDPrompt;
        private System.Windows.Forms.Label FNamePrompt;
        private System.Windows.Forms.Label LNamePrompt;
        private System.Windows.Forms.Label MajorPrompt;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox Major;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button ClrBtn;
    }
}

