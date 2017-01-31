using System.Windows.Forms;
using System.Collections.Generic;

namespace TA_Comment_Generator
{
    partial class Assignment2
    {
        /// <summary>
        /// Create a list of checkboxes so that I can iterate through them later. It is important that they get added in order. 
        /// </summary>
        List<CheckBox> checkboxes = new List<CheckBox> ();


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

            this.generate_comment = new System.Windows.Forms.Button();
            this.commentTxtBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();

            this.checkBox1 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox1);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox2);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox3);
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox4);
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox5);
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox6);
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox7);
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox8);
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox9);
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox10);
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox11);
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox12);
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox13);
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox14);
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox15);
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox16);
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox17);
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox18);
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            checkboxes.Add(checkBox19);

            this.CheckBoxPanel = new System.Windows.Forms.Panel();
            this.CommentBoxPanel = new System.Windows.Forms.Panel();
            this.CheckBoxPanel.SuspendLayout();
            this.CommentBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(180, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "this value is set in Assignment.cs";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(180, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "this value is set in Assignment.cs";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 72);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(180, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "this value is set in Assignment.cs";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 95);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(180, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "this value is set in Assignment.cs";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(3, 118);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(180, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "this value is set in Assignment.cs";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 141);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(180, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "this value is set in Assignment.cs";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(3, 164);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(180, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "this value is set in Assignment.cs";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(3, 187);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(180, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "this value is set in Assignment.cs";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // generate_comment
            // 
            this.generate_comment.Location = new System.Drawing.Point(26, 488);
            this.generate_comment.Name = "generate_comment";
            this.generate_comment.Size = new System.Drawing.Size(127, 23);
            this.generate_comment.TabIndex = 9;
            this.generate_comment.Text = "generate comment";
            this.generate_comment.UseVisualStyleBackColor = true;
            this.generate_comment.Click += new System.EventHandler(this.generate_comment_Click);
            // 
            // commentTxtBox
            // 
            this.commentTxtBox.AccessibleName = "comment";
            this.commentTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTxtBox.Location = new System.Drawing.Point(0, 20);
            this.commentTxtBox.Name = "commentTxtBox";
            this.commentTxtBox.Size = new System.Drawing.Size(264, 463);
            this.commentTxtBox.TabIndex = 10;
            this.commentTxtBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add other comments here:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(187, 488);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 12;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "this value is set in Assignment.cs";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(3, 209);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(180, 17);
            this.checkBox10.TabIndex = 14;
            this.checkBox10.Text = "this value is set in Assignment.cs";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(3, 232);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(180, 17);
            this.checkBox11.TabIndex = 15;
            this.checkBox11.Text = "this value is set in Assignment.cs";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(3, 255);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(180, 17);
            this.checkBox12.TabIndex = 16;
            this.checkBox12.Text = "this value is set in Assignment.cs";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(3, 278);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(180, 17);
            this.checkBox13.TabIndex = 17;
            this.checkBox13.Text = "this value is set in Assignment.cs";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(3, 301);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(180, 17);
            this.checkBox14.TabIndex = 18;
            this.checkBox14.Text = "this value is set in Assignment.cs";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(3, 324);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(180, 17);
            this.checkBox15.TabIndex = 19;
            this.checkBox15.Text = "this value is set in Assignment.cs";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(3, 347);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(180, 17);
            this.checkBox16.TabIndex = 20;
            this.checkBox16.Text = "this value is set in Assignment.cs";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(3, 370);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(180, 17);
            this.checkBox17.TabIndex = 21;
            this.checkBox17.Text = "this value is set in Assignment.cs";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(3, 393);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(180, 17);
            this.checkBox18.TabIndex = 22;
            this.checkBox18.Text = "this value is set in Assignment.cs";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(3, 416);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(180, 17);
            this.checkBox19.TabIndex = 23;
            this.checkBox19.Text = "this value is set in Assignment.cs";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPanel
            // 
            this.CheckBoxPanel.Controls.Add(this.checkBox1);
            this.CheckBoxPanel.Controls.Add(this.checkBox19);
            this.CheckBoxPanel.Controls.Add(this.checkBox2);
            this.CheckBoxPanel.Controls.Add(this.checkBox18);
            this.CheckBoxPanel.Controls.Add(this.checkBox3);
            this.CheckBoxPanel.Controls.Add(this.checkBox17);
            this.CheckBoxPanel.Controls.Add(this.checkBox4);
            this.CheckBoxPanel.Controls.Add(this.checkBox16);
            this.CheckBoxPanel.Controls.Add(this.checkBox5);
            this.CheckBoxPanel.Controls.Add(this.checkBox15);
            this.CheckBoxPanel.Controls.Add(this.checkBox6);
            this.CheckBoxPanel.Controls.Add(this.checkBox14);
            this.CheckBoxPanel.Controls.Add(this.checkBox7);
            this.CheckBoxPanel.Controls.Add(this.checkBox13);
            this.CheckBoxPanel.Controls.Add(this.checkBox8);
            this.CheckBoxPanel.Controls.Add(this.checkBox12);
            this.CheckBoxPanel.Controls.Add(this.checkBox9);
            this.CheckBoxPanel.Controls.Add(this.checkBox11);
            this.CheckBoxPanel.Controls.Add(this.checkBox10);
            this.CheckBoxPanel.Location = new System.Drawing.Point(12, 12);
            this.CheckBoxPanel.Name = "CheckBoxPanel";
            this.CheckBoxPanel.Size = new System.Drawing.Size(273, 470);
            this.CheckBoxPanel.TabIndex = 24;
            // 
            // CommentBoxPanel
            // 
            this.CommentBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentBoxPanel.Controls.Add(this.commentTxtBox);
            this.CommentBoxPanel.Controls.Add(this.label1);
            this.CommentBoxPanel.Location = new System.Drawing.Point(291, 15);
            this.CommentBoxPanel.Name = "CommentBoxPanel";
            this.CommentBoxPanel.Size = new System.Drawing.Size(267, 496);
            this.CommentBoxPanel.TabIndex = 25;
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 523);
            this.Controls.Add(this.CommentBoxPanel);
            this.Controls.Add(this.CheckBoxPanel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.generate_comment);
            this.Name = "Assignment2";
            this.Text = "Comment Generator";
            this.CheckBoxPanel.ResumeLayout(false);
            this.CheckBoxPanel.PerformLayout();
            this.CommentBoxPanel.ResumeLayout(false);
            this.CommentBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.Button generate_comment;
        private System.Windows.Forms.RichTextBox commentTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private Panel CheckBoxPanel;
        private Panel CommentBoxPanel;
    }
}


