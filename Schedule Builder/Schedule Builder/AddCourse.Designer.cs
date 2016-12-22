namespace Schedule_Builder
{
    partial class AddCourse
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
            this.CourseValue = new System.Windows.Forms.TextBox();
            this.CourseAbbr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.AddAnother = new System.Windows.Forms.Button();
            this.taken = new System.Windows.Forms.CheckBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseValue
            // 
            this.CourseValue.Location = new System.Drawing.Point(105, 45);
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.Size = new System.Drawing.Size(67, 20);
            this.CourseValue.TabIndex = 85;
            this.CourseValue.Text = "1410";
            // 
            // CourseAbbr
            // 
            this.CourseAbbr.Location = new System.Drawing.Point(12, 45);
            this.CourseAbbr.Name = "CourseAbbr";
            this.CourseAbbr.Size = new System.Drawing.Size(65, 20);
            this.CourseAbbr.TabIndex = 84;
            this.CourseAbbr.Text = "CS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Course Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Course Abbr.";
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(95, 84);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 86;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // AddAnother
            // 
            this.AddAnother.Location = new System.Drawing.Point(176, 84);
            this.AddAnother.Name = "AddAnother";
            this.AddAnother.Size = new System.Drawing.Size(75, 23);
            this.AddAnother.TabIndex = 87;
            this.AddAnother.Text = "AddAnother";
            this.AddAnother.UseVisualStyleBackColor = true;
            this.AddAnother.Click += new System.EventHandler(this.AddAnother_Click);
            // 
            // taken
            // 
            this.taken.AutoSize = true;
            this.taken.Location = new System.Drawing.Point(194, 45);
            this.taken.Name = "taken";
            this.taken.Size = new System.Drawing.Size(57, 17);
            this.taken.TabIndex = 88;
            this.taken.Text = "Taken";
            this.taken.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 84);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 90;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 118);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.taken);
            this.Controls.Add(this.AddAnother);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.CourseValue);
            this.Controls.Add(this.CourseAbbr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "AddCourse";
            this.Text = "Add A Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseValue;
        private System.Windows.Forms.TextBox CourseAbbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button AddAnother;
        private System.Windows.Forms.CheckBox taken;
        private System.Windows.Forms.Button cancel;
    }
}