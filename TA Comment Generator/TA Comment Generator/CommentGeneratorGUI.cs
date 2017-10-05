using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comment_Generator_Model;

namespace TA_Comment_Generator
{
    public partial class CommentGeneratorGUI : Form
    {
        String special_order_comments;
        String percent_Of_Grade_Analysis_Doc_Is_Worth = "30%";
        CommentGenerator cg;

        CheckBox[] checkBoxes;


        //file extension for a spreadsheet
        private string CG_EXT = ".cg";

        //filter for opening and saving spreadsheet files. 
        private string DEFAULT_FILTER = "CommentGenerator Files (*.cg)|*.cg|All Files|*.*";


        public CommentGeneratorGUI()
        {
            cg = new CommentGenerator();
            //InitializeComponent();
            //CreateContainers();
            //Setup();
            //UpdateDisplay();
        }

        /// <summary>
        /// Creates a checkbox for every comment in cg. 
        /// </summary>
        private void UpdateDisplay()
        {
            checkBoxes = new CheckBox[cg.Count];

            int height = 1;
            int padding = 10;

            int i = 0;
            foreach(KeyValuePair<string, string> comment in CommentGenerator.getAllComments())
            {
                checkBoxes[i] = new CheckBox();
                checkBoxes[i].Name = i.ToString();
                checkBoxes[i].Text = comment.Key;
                checkBoxes[i].TabIndex = i;
                checkBoxes[i].AutoCheck = true;
                checkBoxes[i].Bounds = new Rectangle(10, 20 + padding + height, 40, 22);
                checkBoxPanel.Controls.Add(checkBoxes[i]);
                height += 22;
                i++;
            }
        }

        /*
         * This is really dumb, there's got to be a collection of these from the frame. 
         * How Can I do this better? 
         */
        private void CreateContainers()
        {
            /*
            foreach (Control component in CheckBoxPanel.Controls)
            {
                if (component is CheckBox)
                {
                    checkboxes.Add((CheckBox)component);
                }
            }
            foreach (Control component in panel1.Controls)
            {
                if(component is CheckBox)
                {
                    checkboxes.Add((CheckBox)component);
                }
            }
            */
        }

        /**
         * Sets up all of the comments to be generated and text for the checkBoxes. 
         * 
         * At some point, this should read lines from a text file... The first line will be the text shown next to the box. 
         * The second line will be the comment generated when that box is checked.
         */
        private void Setup()
        {
            //Populate the GUI text of the checkBoxes. 
            //Add labels to sections of comments?
            //Create new comment?
            //Open existing comments?
        }

        /**
         * Generates the comment and displays it in the comment text box to the user. 
         */
        private void generate_comment_Click(object sender, EventArgs e)
        {
            //Create the comment to be generated. 
            string comment = "";// disclaimer + "\n\n";

            int i = 0;
            foreach (CheckBox box in checkBoxes)
            {
                //Add all of the checked boxes comments to the generated comment. 
                if (box.Checked == true) 
                {
                    comment += cg.GetComment(box.Text) + "\n";
                }
            }

            //Add what is in the comment text box to the generated comment
            comment += this.commentTxtBox.Text + "\n";

            //Due to the nature of comments 7 and 8, if they are checked I want them to be included at the end. 
            if (checkBox7.Checked == true)
                comment += startEarlyNextTime + "\n";
            if (checkBox8.Checked == true)
                comment += wellDone + "\n";


            comment += "Please come see me in office hours if you have any questions about grading."; //An ending message. 
            this.commentTxtBox.Text = comment;
        }

        /**
         * Creates and labels a new comment check box. The input for this must be very specifically formatted.
         * The first line is the text that gets added to the check box and the second line is the  comment generated when the 
         * check box is checked. 
         */
        private void NewComment_Click(object sender, EventArgs e)
        {
            //String[] comment = (commentTxtBox.Text).Split('\n');
            //if (comment.Length < 2)
            //{
            //    commentTxtBox.Text = "please include the comment generated on the next line.";
            //}
            //else
            //{
            //    textFieldsArr.Add(comment[0]);
            //    comments.Add(comment[1]);
            //    UpdateDisplay();
            //}
        }

        /**
         * Explains how to add a new comment. 
         */
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To use the comment creation tool simply type the comment you'd like to generate in the text box.\nThe format is this:\n\n"
                + "Text displayed next to check box\nComment generated when check box is clicked.\n\nBe sure to only include the text you'd like generated in the comment box.");
        }

        /**
         * Clear all of the check boxes and the comment text box. 
         */
        private void clear_Click(object sender, EventArgs e)
        {
            this.commentTxtBox.Text = "";
            foreach (CheckBox cbox in checkboxes)
            {
                cbox.Checked = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open File dialog box
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = CG_EXT; //default file extension
            dlg.Filter = DEFAULT_FILTER; //display only .cg files or All Files. 

            //Open the given file. 
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //Get the file path of the file selected. 
                String filePath = dlg.FileName;

                //Ask the user to handle any unsaved changes, open the new file. 
                //if (saveChanges == true)
                //{
                //    OpenFile(filePath);
                //}
                cg = cg.ReadXml(filePath);
                UpdateDisplay();
            }
        }
    }
}
