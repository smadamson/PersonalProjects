﻿using System.Windows.Forms;
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
            string textVal = "this value is set in Assignment.cs";

            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.generate_comment = new System.Windows.Forms.Button();
            this.commentTxtBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.SuspendLayout();

            // 
            // generate_comment
            // 
            this.generate_comment.Location = new System.Drawing.Point(12, 488);
            this.generate_comment.Name = "generate_comment";
            this.generate_comment.Size = new System.Drawing.Size(127, 23);
            this.generate_comment.TabIndex = 9;
            this.generate_comment.Text = "generate comment";
            this.generate_comment.UseVisualStyleBackColor = true;
            this.generate_comment.Click += new System.EventHandler(this.generate_comment_Click);
            // 
            // comment
            // 
            this.commentTxtBox.AccessibleName = "comment";
            this.commentTxtBox.Location = new System.Drawing.Point(259, 26);
            this.commentTxtBox.Name = "comment";
            this.commentTxtBox.Size = new System.Drawing.Size(228, 485);
            this.commentTxtBox.TabIndex = 10;
            this.commentTxtBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add other comments here:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(145, 488);
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
            this.checkBox1.Location = new System.Drawing.Point(22, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = textVal;
            this.checkBox1.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(160, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = textVal;
            this.checkBox2.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox2);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(22, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = textVal;
            this.checkBox3.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox3);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(22, 97);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(144, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = textVal;
            this.checkBox4.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox4);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(22, 120);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(198, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = textVal;
            this.checkBox5.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox5);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(22, 143);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(127, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = textVal;
            this.checkBox6.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox6);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(22, 166);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(157, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = textVal;
            this.checkBox7.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox7);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(22, 189);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(148, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = textVal;
            this.checkBox8.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox8);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(22, 212);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(114, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = textVal;
            this.checkBox9.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox9);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(22, 234);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(145, 17);
            this.checkBox10.TabIndex = 14;
            this.checkBox10.Text = textVal;
            this.checkBox10.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox10);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(22, 257);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(124, 17);
            this.checkBox11.TabIndex = 15;
            this.checkBox11.Text = textVal;
            this.checkBox11.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox11);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(22, 280);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(129, 17);
            this.checkBox12.TabIndex = 16;
            this.checkBox12.Text = textVal;
            this.checkBox12.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox12);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(22, 303);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(140, 17);
            this.checkBox13.TabIndex = 17;
            this.checkBox13.Text = textVal;
            this.checkBox13.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox13);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(22, 326);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(129, 17);
            this.checkBox14.TabIndex = 18;
            this.checkBox14.Text = textVal;
            this.checkBox14.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox14);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(22, 349);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(230, 17);
            this.checkBox15.TabIndex = 19;
            this.checkBox15.Text = textVal;
            this.checkBox15.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox15);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(22, 372);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(176, 17);
            this.checkBox16.TabIndex = 20;
            this.checkBox16.Text = textVal;
            this.checkBox16.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox16);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(22, 395);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(165, 17);
            this.checkBox17.TabIndex = 21;
            this.checkBox17.Text = textVal;
            this.checkBox17.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox17);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(22, 418);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(161, 17);
            this.checkBox18.TabIndex = 22;
            this.checkBox18.Text = textVal;
            this.checkBox18.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox18);
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(22, 441);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(174, 17);
            this.checkBox19.TabIndex = 23;
            this.checkBox19.Text = textVal;
            this.checkBox19.UseVisualStyleBackColor = true;
            checkboxes.Add(this.checkBox19);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 523);
            this.Controls.Add(this.checkBox19);
            this.Controls.Add(this.checkBox18);
            this.Controls.Add(this.checkBox17);
            this.Controls.Add(this.checkBox16);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox14);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentTxtBox);
            this.Controls.Add(this.generate_comment);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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


    }
}


