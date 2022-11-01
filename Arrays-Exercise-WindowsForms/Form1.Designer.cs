namespace Arrays_Exercise_WindowsForms
{
    partial class FrmStudentMarks
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
            this.BtnGrades = new System.Windows.Forms.Button();
            this.LstInfo = new System.Windows.Forms.ListBox();
            this.BtnPassFail = new System.Windows.Forms.Button();
            this.BtnHighestMark = new System.Windows.Forms.Button();
            this.BtnFrequency = new System.Windows.Forms.Button();
            this.BtnShowSorted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGrades
            // 
            this.BtnGrades.Location = new System.Drawing.Point(67, 12);
            this.BtnGrades.Name = "BtnGrades";
            this.BtnGrades.Size = new System.Drawing.Size(199, 62);
            this.BtnGrades.TabIndex = 0;
            this.BtnGrades.Text = "Grades";
            this.BtnGrades.UseVisualStyleBackColor = true;
            this.BtnGrades.Click += new System.EventHandler(this.BtnGrades_Click);
            // 
            // LstInfo
            // 
            this.LstInfo.FormattingEnabled = true;
            this.LstInfo.ItemHeight = 16;
            this.LstInfo.Location = new System.Drawing.Point(407, 104);
            this.LstInfo.Name = "LstInfo";
            this.LstInfo.Size = new System.Drawing.Size(340, 260);
            this.LstInfo.TabIndex = 1;
            // 
            // BtnPassFail
            // 
            this.BtnPassFail.Location = new System.Drawing.Point(67, 93);
            this.BtnPassFail.Name = "BtnPassFail";
            this.BtnPassFail.Size = new System.Drawing.Size(198, 66);
            this.BtnPassFail.TabIndex = 2;
            this.BtnPassFail.Text = "Show Pass / Fail";
            this.BtnPassFail.UseVisualStyleBackColor = true;
            this.BtnPassFail.Click += new System.EventHandler(this.BtnPassFail_Click);
            // 
            // BtnHighestMark
            // 
            this.BtnHighestMark.Location = new System.Drawing.Point(71, 185);
            this.BtnHighestMark.Name = "BtnHighestMark";
            this.BtnHighestMark.Size = new System.Drawing.Size(194, 63);
            this.BtnHighestMark.TabIndex = 3;
            this.BtnHighestMark.Text = "Highest Marks";
            this.BtnHighestMark.UseVisualStyleBackColor = true;
            this.BtnHighestMark.Click += new System.EventHandler(this.BtnHighestMark_Click);
            // 
            // BtnFrequency
            // 
            this.BtnFrequency.Location = new System.Drawing.Point(77, 272);
            this.BtnFrequency.Name = "BtnFrequency";
            this.BtnFrequency.Size = new System.Drawing.Size(188, 67);
            this.BtnFrequency.TabIndex = 4;
            this.BtnFrequency.Text = "Show Frequency";
            this.BtnFrequency.UseVisualStyleBackColor = true;
            this.BtnFrequency.Click += new System.EventHandler(this.BtnFrequency_Click);
            // 
            // BtnShowSorted
            // 
            this.BtnShowSorted.Location = new System.Drawing.Point(79, 359);
            this.BtnShowSorted.Name = "BtnShowSorted";
            this.BtnShowSorted.Size = new System.Drawing.Size(186, 65);
            this.BtnShowSorted.TabIndex = 5;
            this.BtnShowSorted.Text = "Show Sorted";
            this.BtnShowSorted.UseVisualStyleBackColor = true;
            this.BtnShowSorted.Click += new System.EventHandler(this.BtnShowSorted_Click);
            // 
            // FrmStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShowSorted);
            this.Controls.Add(this.BtnFrequency);
            this.Controls.Add(this.BtnHighestMark);
            this.Controls.Add(this.BtnPassFail);
            this.Controls.Add(this.LstInfo);
            this.Controls.Add(this.BtnGrades);
            this.Name = "FrmStudentMarks";
            this.Text = "Student Marks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGrades;
        private System.Windows.Forms.ListBox LstInfo;
        private System.Windows.Forms.Button BtnPassFail;
        private System.Windows.Forms.Button BtnHighestMark;
        private System.Windows.Forms.Button BtnFrequency;
        private System.Windows.Forms.Button BtnShowSorted;
    }
}

