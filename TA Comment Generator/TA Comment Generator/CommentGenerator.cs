using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Comment_Generator
{
    public partial class CommentGenerator : Form
    {

        /// <summary>
        /// Create a list of all comments to be iterated through later. It is VERY important that they get added in order. 
        /// </summary>
        List<String> comments = new List<String>();
        //String[] textFields;
        List<String> textFieldsArr = new List<String>();

        //A few special comments
        String startEarlyNextTime, wellDone;
        //TODO: Change me!
        String percent_Of_Grade_Analysis_Doc_Is_Worth = "60%";

        public CommentGenerator()
        {
            InitializeComponent();
            CreateContainers();
            Setup();
            UpdateDisplay();
        }

        /*
         * Updates the display so that the check boxes look like they should
         */
        private void UpdateDisplay()
        {
            String[] textFields = textFieldsArr.ToArray();

            //Update the GUI text displayed next to each check box. 
            int i = 0;
            foreach (CheckBox cbox in checkboxes)
            {
                if (i >= textFields.Length)
                {
                    break;
                }
                else
                {
                    cbox.Text = textFields[i];
                }
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
            checkboxes.Add(checkBox1);
            checkboxes.Add(checkBox2);
            checkboxes.Add(checkBox3);
            checkboxes.Add(checkBox4);
            checkboxes.Add(checkBox5);
            checkboxes.Add(checkBox6);
            checkboxes.Add(checkBox7);
            checkboxes.Add(checkBox8);
            checkboxes.Add(checkBox9);
            checkboxes.Add(checkBox10);
            checkboxes.Add(checkBox11);
            checkboxes.Add(checkBox12);
            checkboxes.Add(checkBox13);
            checkboxes.Add(checkBox14);
            checkboxes.Add(checkBox15);
            checkboxes.Add(checkBox16);
            checkboxes.Add(checkBox17);
            checkboxes.Add(checkBox18);
            checkboxes.Add(checkBox19);
            checkboxes.Add(checkBox20);
            checkboxes.Add(checkBox21);
            checkboxes.Add(checkBox22);
            checkboxes.Add(checkBox23);
            checkboxes.Add(checkBox24);
            checkboxes.Add(checkBox25);
            checkboxes.Add(checkBox26);
            checkboxes.Add(checkBox27);
            checkboxes.Add(checkBox28);
            checkboxes.Add(checkBox29);
            checkboxes.Add(checkBox30);
            checkboxes.Add(checkBox31);
            checkboxes.Add(checkBox32);
            checkboxes.Add(checkBox33);
            checkboxes.Add(checkBox34);
            checkboxes.Add(checkBox35);
            checkboxes.Add(checkBox36);
            checkboxes.Add(checkBox37);
            checkboxes.Add(checkBox38);
            checkboxes.Add(checkBox39);
            checkboxes.Add(checkBox40);
            checkboxes.Add(checkBox41);
            checkboxes.Add(checkBox42);
            // checkboxes.Add(checkBox43);
            //checkboxes.Add(checkBox44);
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

            //Overall code style
            textFieldsArr.Add("Good comments");
            comments.Add("Your code is very nicely commented and you used Javadoc comments nicely. Good job.");


            textFieldsArr.Add("Bad comments");
            comments.Add("Your code should include Javadoc comments at the top of every method and there should be comments throughout the methods that describe the logic behind non-self-explanatory blocks of code.");


            textFieldsArr.Add("Good use of helper methods");
            comments.Add("You showed a good use of private helper methods, throughout your code. This makes your code easier to read, employers, TA's, and professors really like this.");


            textFieldsArr.Add("Bad use of helper methods");
            comments.Add("To make your code more readable you might consider adding more private helper methods to your code. One general rule of thumb is if your functions are longer than about 25 lines, you should try to extract some of the logic to a helper function.");

            textFieldsArr.Add("Code did not compile");
            comments.Add("When I tried to run your program it wouldn't compile. You should make it a priority to turn in code that compiles.");

            textFieldsArr.Add("Improperly implemented constructors/methods (not following specs)");
            comments.Add("You have implemented some of the constructors or methods improperly. It is very important that you follow the specifications exactly on all assignments.");

            //Included at end.
            startEarlyNextTime = "You are off to a good start, get started on your projects early so that you have plenty of time to get your work done.";
            textFieldsArr.Add("Good start, start early next time");
            comments.Add(startEarlyNextTime);

            //Included at end.
            wellDone = "Overall your submission looks wonderful, keep up the good hard work.";
            textFieldsArr.Add("Well done keep up the good work");
            comments.Add(wellDone);

            textFieldsArr.Add("Bad use of PUBLIC instance variables");
            comments.Add("Some of the classes declare public instance variables which is generally not a good idea. Instead make those variables private and create getters and setters for them.");

            textFieldsArr.Add("Left in print statements used in debugging");
            comments.Add("Do your best to turn in professional looking and functioning code. In general this means removing commented out code and print statements from your submission.");

            //Assignment Structure   
            textFieldsArr.Add("Improper Filename");
            comments.Add("You have named your zip file improperly.The Properly file name structure is YourFirst_YourLast_PartnersFirst_PartnersLast_CS2420_Assignment#.zip. It is very important your file name is structured like that because we use a piece of software which groups your submission and your partners submission into folder together.");

            /* Analysis doc
               [] Good analysis
               [] analysis needs improvement
               [] no analysis or bad analysis
            */

            //Analysis doc
            textFieldsArr.Add("Good analysis");
            comments.Add("Your analysis document looks good. There is a good explanation of the graph and you also include axis titles which is nice. You further demonstrate a good understanding of the complexity involved in the program.");

            textFieldsArr.Add("Analysis needs improvement");
            comments.Add("In an analysis document try to analyze the algorithms in the code and explain their big-O complexity. For example, you might say that the jiggler function is O(n) (where n represents the number of circles) because it loops through every circle once and jiggles it. Also, your analysis document should include several graphs with descriptive titles and labeled axis.");

            textFieldsArr.Add("No analysis");
            comments.Add("You forgot to include your analysis document. Remember that the written portion of this assignment is worth " + percent_Of_Grade_Analysis_Doc_Is_Worth + " of your grade. It is very important that you demonstrate an understanding of your work.");

            //Assignment.properties file
            textFieldsArr.Add("Good assignment.properties file");
            comments.Add("Your assignment.properties file looks great.");

            textFieldsArr.Add("No assignment.properties file/ not properly formatted");
            comments.Add("You either didn't submit an assignment.properties file or you did not format it properly, be sure to follow the specs exactly (every space must be exactly correct). This file is used by a computer to give you credit so this is very important!");

            //Design document
            textFieldsArr.Add("Good design doc");
            comments.Add("Well done on your design doc, you answered all of the questions and it looks great");

            textFieldsArr.Add("Design doc needs improvement");
            comments.Add("Your design doc could use a little improvement, answer each question and organize your answers nicely");

            textFieldsArr.Add("No Design doc");
            comments.Add("You forgot to include a design doc in your submission.");

            //Partnerships 
            textFieldsArr.Add("Partner carried the team");
            comments.Add("It seems like your partner did a lot of the work on this assignment. Be sure that when you work the a partner you are practicing the techniques of pair programing. This means sitting at the same computer. It may seem frustrating now but it will help you improve your skills.");

            //Testing
            textFieldsArr.Add("No Tests");
            comments.Add("No tests were included on this assignment. As a developer testing is very important because it helps ensure your code is working as expected. Please be sure to include tests for your public methods and classes.");

            textFieldsArr.Add("Bad Tests");
            comments.Add("The tests for this assignment were insufficient. The testing requirement for assignments is meant to help you ensure your code is behaving as expected. Please test each public class and method thoroughly and include those tests when you turn in your assignment.");

            textFieldsArr.Add("Good Tests");
            comments.Add("Well done creating tests for your classes. I'm sure this saved you a lot of time debugging.");

            //AssignmentSpecifics
            //textFieldsArr.Add("");
            //comments.Add("");


        }

        /**
         * Generates the comment and displays it in the comment text box to the user. 
         */
        private void generate_comment_Click(object sender, EventArgs e)
        {
            //Create the comment to be generated. 

            string comment = "";
            int i = 0;
            foreach (string com in comments)
            {
                //Add all of the checked boxes comments to the generated comment. 
                if (checkboxes[i].Checked == true && (i != 6) && (i != 7)) //Due to the nature of comments 7 and 8 (indexes 6 and 7), if they are checked I want them to be included at the end. 
                {
                    comment += com + "\n";
                }
                i++;
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
            String[] comment = (commentTxtBox.Text).Split('\n');
            if (comment.Length < 2)
            {
                commentTxtBox.Text = "please include the comment generated on the next line.";
            }
            else
            {
                textFieldsArr.Add(comment[0]);
                comments.Add(comment[1]);
                UpdateDisplay();
            }
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
    }
}
