namespace Schedule_Builder
{
    partial class ManageCourses
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
            this.addCourse = new System.Windows.Forms.Button();
            this.courses = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acceptGoBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCourse
            // 
            this.addCourse.Location = new System.Drawing.Point(170, 5);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(103, 23);
            this.addCourse.TabIndex = 0;
            this.addCourse.Text = "Add New Course";
            this.addCourse.UseVisualStyleBackColor = true;
            this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // courses
            // 
            this.courses.FormattingEnabled = true;
            this.courses.Location = new System.Drawing.Point(34, 64);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(120, 34);
            this.courses.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Checked courses have been taken.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unchecked courses are planned.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To mark a course as taken, check it. ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.acceptGoBack);
            this.panel1.Controls.Add(this.addCourse);
            this.panel1.Location = new System.Drawing.Point(-1, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 31);
            this.panel1.TabIndex = 5;
            // 
            // acceptGoBack
            // 
            this.acceptGoBack.Location = new System.Drawing.Point(13, 3);
            this.acceptGoBack.Name = "acceptGoBack";
            this.acceptGoBack.Size = new System.Drawing.Size(119, 23);
            this.acceptGoBack.TabIndex = 1;
            this.acceptGoBack.Text = "Accept and Go Back";
            this.acceptGoBack.UseVisualStyleBackColor = true;
            this.acceptGoBack.Click += new System.EventHandler(this.acceptGoBack_Click);
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courses);
            this.Name = "ManageCourses";
            this.Text = "Manage Courses";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.CheckedListBox courses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button acceptGoBack;
    }
}