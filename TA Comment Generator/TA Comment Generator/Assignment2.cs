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
    public partial class Assignment2 : Form
    {

        /// <summary>
        /// Create a list of all comments to be iterated through later. It is VERY important that they get added in order. 
        /// </summary>
        List<String> comments = new List<String>();
        String[] textFields;

        //Overall code style
        string oneText, one, twoText, two, threeText, three, fourText, four, fiveText, five, sixText, six, sevenText, seven, eightText, eight, nineText, nine, tenText, ten, elevenText, eleven;

        //Analysis doc
        string twelveText, twelve, thirteenText, thirteen, fourteenText, fourteen;

        //Other docs
        string fifteenText, fifteen, sixteenText, sixteen, seventeenText, seventeen, eighteenText, eighteen, nineteenText, ninteen;

        /****************    Assignment particular categories   *************************/
        //Assignment 2 NBody problem


        public Assignment2()
        {
            InitializeComponent();
            Setup();

            //Update the GUI text displayed next to each checkbox. 
            int i = 0;
            foreach (CheckBox cbox in checkboxes)
            {
                cbox.Text = textFields[i];
                i++;
            }
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
            textFields = new String[checkboxes.Count];

            /*Overall code style
         [] Good comments
         [] Bad comments
         [] Good use of helper methods
         [] Bad use of helper methods
         [] Code did not compile or has errors
         [] Improperly imlemented constructors/methods (not following directions)
         [] good start, start early
         [] Well done, keep up the good work.
         [] Bad use of public instance variables
         [] Left in println statements used for debugging
         [] Left in commented out code
      */

            //Overall code style
            oneText = "Good comments";
            one = "Your code is very nicely commented and you used Javadoc comments nicely. Good job.";
            textFields[0] = oneText;
            comments.Add(one);

            twoText = "Bad comments";
            two = "Your code should include Javadoc comments at the top of every method and there should be comments throughout the methods that describe the logic behind non-self-explanatory blocks of code.";
            textFields[1] = twoText;
            comments.Add(two);

            threeText = "Good use of helper methods";
            three = "You showed a good use of private helper methods, throughout your code. This makes your code easier to read, employers, TA's, and professors really like this.";
            textFields[2] = threeText;
            comments.Add(three);

            fourText = "Bad use of helper methods";
            four = "To make your code more readable you might consider adding more private helper methods to your code. One general rule of thumb is if your functions are longer than about 25 lines, you should try to extract some of the logic to a helper function.";
            textFields[3] = fourText;
            comments.Add(four);

            fiveText = "Code did not compile";
            five = "When I tried to run your program it wouldn't compile. You should make it a priority to turn in code that compiles.";
            textFields[4] = fiveText;
            comments.Add(five);

            sixText = "Improperly imlemented constructors/methods (not following specs)";
            six = "You have implemented some of the constructors or methods improperly. It is very important that you follow the specifications exactly on all assignments.";
            textFields[5] = sixText;
            comments.Add(six);

            sevenText = "Good start, start early next time";
            seven = "You are off to a good start, get started on your projects early so that you have plenty of time to get your work done.";
            textFields[6] = sevenText;
            comments.Add(seven);

            eightText = "Well done keep up the good work";
            eight = "Overall your submission looks wonderful, keep up the good hard work.";
            textFields[7] = eightText;
            comments.Add(eight);

            nineText = "Bad use of PUBLIC instance variables";
            nine = "Some of the classes declare public instance variables which is generally not a good idea. Instead make those variables private and create getters and setters for them.";
            textFields[8] = nineText;
            comments.Add(nine);

            tenText = "Left in Println statements used in dubgging";
            ten = "Do your best to turn in professional looking and functioning code. In general this means removing commented out code and println statements from your submission.";
            textFields[9] = tenText;
            comments.Add(ten);

            elevenText = "Extra- does nothing";
            eleven = "";
            textFields[10] = elevenText;
            comments.Add(one);

            /* Analysis doc
               [] Good analysis
               [] analysis needs improvement
               [] no analysis or bad analysis
            */

            //Analysis doc
            twelveText = "Good analysis";
            twelve = "Your analysis document looks good. There is a good explanation of the graph and you also include axis titles which is nice. You further demonstrate a good understanding of the complexity involved in the program.";
            textFields[11] = twelveText;
            comments.Add(twelve);

            thirteenText = "Analysis needs improvement";
            thirteen = "In an analysis document try to analyze the algorithms in the code and explain their big-O complexity. For example, you might say that the jiggler function is O(n) because it loops through every circle once and jiggles it. You might also say that spread out is O(n^2) because it loops through each circle n times and n*n is n^2. Also, your analysis document should include a graph of FPS vs. Number of circles and that graph should have labeled axes.";
            textFields[12] = thirteenText;
            comments.Add(thirteen);

            fourteenText = "No analysis";
            fourteen = "You forgot to include your analysis document. Remember that the written portion of this assignment is worth 30% of your grade. It is very important that you demonstrate an understanding of your work.";
            textFields[13] = fourteenText;
            comments.Add(fourteen);

            //Assignment.properties file
            fifteenText = "Good assignment.properties file";
            fifteen = "Your assignment.properties file looks great.";
            textFields[14] = fifteenText;
            comments.Add(fifteen);

            sixteenText = "No assignment.properties file/ not propery formatted";
            sixteen = "You either didn't submit an assignment.properties file or you did not format it properly, be sure to follow the specs exactly (every space must be exactly correct). This file is used by a computer to give you credit so this is very important!";
            textFields[15] = sixteenText;
            comments.Add(sixteen);

            //Design document
            seventeenText = "Good design doc";
            seventeen = "Well done on your desgn doc, you answered all of the questions and it looks great";
            textFields[16] = seventeenText;
            comments.Add(seventeen);

            eighteenText = "Design doc needs improvement";
            eighteen = "Your design doc could use a little improvement, answer each question and organize your answers nicely";
            textFields[17] = eighteenText;
            comments.Add(eighteen);

            nineteenText = "No Design doc";
            ninteen = "You forgot to include a design doc in your submission.";
            textFields[18] = nineteenText;
            comments.Add(ninteen);
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
                if (checkboxes[i].Checked == true && (i != 6 || i != 7)) //Due to the nature of comments 7 and 8 (indexes 6 and 7), if they are checked I want them to be included at the end. 
                {
                    comment += com + "\n";
                }
                i++;
            }

            //Add what is in the comment text box to the generated comment
            comment += this.commentTxtBox.Text + "\n";

            //Due to the nature of comments 7 and 8, if they are checked I want them to be included at the end. 
            if (checkBox7.Checked == true)
                comment += seven + "\n";
            if (checkBox8.Checked == true)
                comment += eight + "\n";

            comment += "Please come see me in office hours if you have any questions about grading.";
            this.commentTxtBox.Text = comment;
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
