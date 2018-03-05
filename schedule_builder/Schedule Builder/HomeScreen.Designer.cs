namespace Schedule_Builder
{
    partial class HomeScreen
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
            this.Name = new System.Windows.Forms.Label();
            this.Major = new System.Windows.Forms.Label();
            this.majorsList = new System.Windows.Forms.RichTextBox();
            this.editMajors = new System.Windows.Forms.Button();
            this.manageCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courses = new System.Windows.Forms.RichTextBox();
            this.viewMyPlan = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(20, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(71, 26);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Major
            // 
            this.Major.AutoSize = true;
            this.Major.Location = new System.Drawing.Point(22, 53);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(41, 13);
            this.Major.TabIndex = 1;
            this.Major.Text = "Majors:";
            // 
            // majorsList
            // 
            this.majorsList.Location = new System.Drawing.Point(69, 53);
            this.majorsList.Name = "majorsList";
            this.majorsList.Size = new System.Drawing.Size(100, 39);
            this.majorsList.TabIndex = 2;
            this.majorsList.Text = "Computer Science";
            // 
            // editMajors
            // 
            this.editMajors.Location = new System.Drawing.Point(25, 111);
            this.editMajors.Name = "editMajors";
            this.editMajors.Size = new System.Drawing.Size(75, 23);
            this.editMajors.TabIndex = 3;
            this.editMajors.Text = "Edit Majors";
            this.editMajors.UseVisualStyleBackColor = true;
            this.editMajors.Click += new System.EventHandler(this.editMajors_Click);
            // 
            // manageCourses
            // 
            this.manageCourses.Location = new System.Drawing.Point(31, 219);
            this.manageCourses.Name = "manageCourses";
            this.manageCourses.Size = new System.Drawing.Size(130, 23);
            this.manageCourses.TabIndex = 4;
            this.manageCourses.Text = "Manage Courses";
            this.manageCourses.UseVisualStyleBackColor = true;
            this.manageCourses.Click += new System.EventHandler(this.manageCourses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Courses:";
            // 
            // courses
            // 
            this.courses.Location = new System.Drawing.Point(116, 150);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(99, 63);
            this.courses.TabIndex = 6;
            this.courses.Text = "CS 1410 (Taken), CS 3500 (Planned)";
            // 
            // viewMyPlan
            // 
            this.viewMyPlan.Location = new System.Drawing.Point(158, 264);
            this.viewMyPlan.Name = "viewMyPlan";
            this.viewMyPlan.Size = new System.Drawing.Size(85, 23);
            this.viewMyPlan.TabIndex = 7;
            this.viewMyPlan.Text = "View My Plan";
            this.viewMyPlan.UseVisualStyleBackColor = true;
            this.viewMyPlan.Click += new System.EventHandler(this.viewMyPlan_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(16, 264);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 8;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 299);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.viewMyPlan);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manageCourses);
            this.Controls.Add(this.editMajors);
            this.Controls.Add(this.majorsList);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.Name);
            //this.Name = "HomeScreen";
            this.RightToLeftLayout = true;
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Major;
        private System.Windows.Forms.RichTextBox majorsList;
        private System.Windows.Forms.Button editMajors;
        private System.Windows.Forms.Button manageCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox courses;
        private System.Windows.Forms.Button viewMyPlan;
        private System.Windows.Forms.Button logout;
    }
}