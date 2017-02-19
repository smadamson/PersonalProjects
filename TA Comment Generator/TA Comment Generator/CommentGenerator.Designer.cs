﻿using System.Windows.Forms;
using System.Collections.Generic;

namespace TA_Comment_Generator
{
    partial class CommentGenerator
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.CheckBoxPanel = new System.Windows.Forms.Panel();
            this.CommentBoxPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.checkBox38 = new System.Windows.Forms.CheckBox();
            this.checkBox37 = new System.Windows.Forms.CheckBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox36 = new System.Windows.Forms.CheckBox();
            this.checkBox35 = new System.Windows.Forms.CheckBox();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.checkBox34 = new System.Windows.Forms.CheckBox();
            this.CheckBoxPanel.SuspendLayout();
            this.CommentBoxPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generate_comment
            // 
            this.generate_comment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generate_comment.Location = new System.Drawing.Point(386, 454);
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
            this.commentTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commentTxtBox.Location = new System.Drawing.Point(0, 20);
            this.commentTxtBox.Name = "commentTxtBox";
            this.commentTxtBox.Size = new System.Drawing.Size(264, 472);
            this.commentTxtBox.TabIndex = 10;
            this.commentTxtBox.Text = "";
            this.commentTxtBox.TextChanged += new System.EventHandler(this.commentTxtBox_TextChanged);
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
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear.Location = new System.Drawing.Point(529, 454);
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
            this.CheckBoxPanel.Size = new System.Drawing.Size(301, 437);
            this.CheckBoxPanel.TabIndex = 24;
            // 
            // CommentBoxPanel
            // 
            this.CommentBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentBoxPanel.Controls.Add(this.commentTxtBox);
            this.CommentBoxPanel.Controls.Add(this.label1);
            this.CommentBoxPanel.Location = new System.Drawing.Point(610, 15);
            this.CommentBoxPanel.Name = "CommentBoxPanel";
            this.CommentBoxPanel.Size = new System.Drawing.Size(267, 462);
            this.CommentBoxPanel.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox20);
            this.panel1.Controls.Add(this.checkBox21);
            this.panel1.Controls.Add(this.checkBox22);
            this.panel1.Controls.Add(this.checkBox23);
            this.panel1.Controls.Add(this.checkBox24);
            this.panel1.Controls.Add(this.checkBox25);
            this.panel1.Controls.Add(this.checkBox26);
            this.panel1.Controls.Add(this.checkBox27);
            this.panel1.Controls.Add(this.checkBox28);
            this.panel1.Controls.Add(this.checkBox29);
            this.panel1.Controls.Add(this.checkBox30);
            this.panel1.Controls.Add(this.checkBox31);
            this.panel1.Controls.Add(this.checkBox38);
            this.panel1.Controls.Add(this.checkBox37);
            this.panel1.Controls.Add(this.checkBox32);
            this.panel1.Controls.Add(this.checkBox36);
            this.panel1.Controls.Add(this.checkBox35);
            this.panel1.Controls.Add(this.checkBox33);
            this.panel1.Controls.Add(this.checkBox34);
            this.panel1.Location = new System.Drawing.Point(319, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 434);
            this.panel1.TabIndex = 25;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(3, 3);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(180, 17);
            this.checkBox20.TabIndex = 13;
            this.checkBox20.Text = "this value is set in Assignment.cs";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(3, 210);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(15, 14);
            this.checkBox21.TabIndex = 23;
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(3, 26);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(180, 17);
            this.checkBox22.TabIndex = 1;
            this.checkBox22.Text = "this value is set in Assignment.cs";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(3, 187);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(15, 14);
            this.checkBox23.TabIndex = 22;
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(3, 49);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(180, 17);
            this.checkBox24.TabIndex = 2;
            this.checkBox24.Text = "this value is set in Assignment.cs";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(3, 164);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(15, 14);
            this.checkBox25.TabIndex = 21;
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(3, 72);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(15, 14);
            this.checkBox26.TabIndex = 3;
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(3, 141);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(15, 14);
            this.checkBox27.TabIndex = 20;
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(3, 95);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(15, 14);
            this.checkBox28.TabIndex = 4;
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(3, 118);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(15, 14);
            this.checkBox29.TabIndex = 19;
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(3, 230);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(15, 14);
            this.checkBox30.TabIndex = 5;
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(3, 413);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(15, 14);
            this.checkBox31.TabIndex = 18;
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox38
            // 
            this.checkBox38.AutoSize = true;
            this.checkBox38.Location = new System.Drawing.Point(3, 321);
            this.checkBox38.Name = "checkBox38";
            this.checkBox38.Size = new System.Drawing.Size(15, 14);
            this.checkBox38.TabIndex = 14;
            this.checkBox38.UseVisualStyleBackColor = true;
            // 
            // checkBox37
            // 
            this.checkBox37.AutoSize = true;
            this.checkBox37.Location = new System.Drawing.Point(3, 344);
            this.checkBox37.Name = "checkBox37";
            this.checkBox37.Size = new System.Drawing.Size(15, 14);
            this.checkBox37.TabIndex = 15;
            this.checkBox37.UseVisualStyleBackColor = true;
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(3, 253);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(15, 14);
            this.checkBox32.TabIndex = 6;
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox36
            // 
            this.checkBox36.AutoSize = true;
            this.checkBox36.Location = new System.Drawing.Point(3, 299);
            this.checkBox36.Name = "checkBox36";
            this.checkBox36.Size = new System.Drawing.Size(15, 14);
            this.checkBox36.TabIndex = 8;
            this.checkBox36.UseVisualStyleBackColor = true;
            // 
            // checkBox35
            // 
            this.checkBox35.AutoSize = true;
            this.checkBox35.Location = new System.Drawing.Point(3, 367);
            this.checkBox35.Name = "checkBox35";
            this.checkBox35.Size = new System.Drawing.Size(15, 14);
            this.checkBox35.TabIndex = 16;
            this.checkBox35.UseVisualStyleBackColor = true;
            // 
            // checkBox33
            // 
            this.checkBox33.AutoSize = true;
            this.checkBox33.Location = new System.Drawing.Point(3, 390);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(15, 14);
            this.checkBox33.TabIndex = 17;
            this.checkBox33.UseVisualStyleBackColor = true;
            // 
            // checkBox34
            // 
            this.checkBox34.AutoSize = true;
            this.checkBox34.Location = new System.Drawing.Point(3, 276);
            this.checkBox34.Name = "checkBox34";
            this.checkBox34.Size = new System.Drawing.Size(15, 14);
            this.checkBox34.TabIndex = 7;
            this.checkBox34.UseVisualStyleBackColor = true;
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 489);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Panel panel1;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox24;
        private CheckBox checkBox25;
        private CheckBox checkBox26;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private CheckBox checkBox29;
        private CheckBox checkBox30;
        private CheckBox checkBox31;
        private CheckBox checkBox32;
        private CheckBox checkBox33;
        private CheckBox checkBox34;
        private CheckBox checkBox35;
        private CheckBox checkBox36;
        private CheckBox checkBox37;
        private CheckBox checkBox38;
    }
}


