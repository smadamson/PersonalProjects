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
        string oneText = "Good comments";
        string one = "Your code is very nicely commented and you used Javadoc comments nicely. Good job.";
        string twoText = "Bad comments";
        string two = "Your code should include Javadoc comments at the top of every method and there should be comments throughout the methods that describe the logic behind non-self-explanatory blocks of code.";
        string threeText = "Good use of helper methods";
        string three = "";
        string fourText = "Bad use of helper methods";
        string four = "";
        string fiveText = "Code did not compile or has errors";
        string five = "";
        string sixText = "Improperly imlemented constructors/methods (not following specs)";
        string six = "You have implemented some of the constructors or methods improperly. It is very important that you follow the specifications exactly on all assignments.";
        string sevenText = "Good start, start early next time";
        string seven = "You are off to a good start, get started on your projects early so that you have plenty of time to get your work done.";
        string eightText = "Well done keep up the good work";
        string eight = "";
        string nineText = "Bad use of PUBLIC instance variables";
        string nine = "Some of the classes declare public instance variables which is generally not a good idea. Instead make those variables private and create getters and setters for them.";
        string tenText = "Left in Println statements used in dubgging";
        string ten = "";
        string elevenText = "Left in commented out code";
        string eleven = "";
        string twelveText = "Good analysis";
        string twelve = "Your analysis document looks good. There is a good explanation of the graph and you also include axis titles which is nice. You further demonstrate a good understanding of the complexity involved in the program.";
        string thirteenText = "Analysis needs improvement";
        string thirteen = "In an analysis document try to analyze the algorithms in the code and explain their big-O complexity. For example, you might say that the jiggler function is O(n) because it loops through every circle once and jiggles it. You might also say that spread out is O(n^2) because it loops through each circle n times and n*n is n^2. Also, your analysis document should include a graph of FPS vs. Number of circles and that graph should have labeled axes.";
        string fourteenText = "No analysis";
        string fourteen = "You forgot to include your analysis document. Remember that the written portion of this assignment is worth 30% of your grade. It is very important that you demonstrate an understanding of your work.";
        string fifteenText = "Good assignment.properties file";
        string fifteen = "Your assignment.properties file looks great.";
        string sixteenText = "No assignment.properties file/ not propery formatted";
        string sixteen = "You either didn't submit an assignment.properties file or you did not format it properly, be sure to follow the specs exactly (every space must be exactly correct). This file is used by a computer to give you credit so this is very important!";
        string seventeenText = "Good design doc";
        string seventeen = "Well done on your desgn doc, you answered all of the questions and it looks great";
        string eighteenText = "Design doc needs improvement";
        string eighteen = "Your design doc could use a little improvement, answer each question and organize your answers nicely";
        string nineteenText = "No Design doc";
        string ninteen = "You forgot to include a design doc in your submission.";

        /****************    Assignment particular categories   *************************/
        //Assignment 2 NBody problem


        public Assignment2()
        {
            Setup();
            InitializeComponent();

            //Populate the GUI text of the checkBoxes. 
            textFields = new String[checkboxes.Count];
            int i = 0;
            foreach(CheckBox cbox in checkboxes)
            {
                cbox.Text = textFields[i];
                i++;
            }
        }

        private void Setup()
        {
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

            twoText = "Bad comments";
            two = "Your code should include Javadoc comments at the top of every method and there should be comments throughout the methods that describe the logic behind non-self-explanatory blocks of code.";

            threeText = "Good use of helper methods";
            three = "";

            fourText = "Bad use of helper methods";
            four = "";

            fiveText = "Code did not compile or has errors";
            five = "";

            sixText = "Improperly imlemented constructors/methods (not following specs)";
            six = "You have implemented some of the constructors or methods improperly. It is very important that you follow the specifications exactly on all assignments.";

            sevenText = "Good start, start early next time";
            seven = "You are off to a good start, get started on your projects early so that you have plenty of time to get your work done.";

            eightText = "Well done keep up the good work";
            eight = "";

            nineText = "Bad use of PUBLIC instance variables";
            nine = "Some of the classes declare public instance variables which is generally not a good idea. Instead make those variables private and create getters and setters for them.";

            tenText = "Left in Println statements used in dubgging";
            ten = "";

            elevenText = "Left in commented out code";
            eleven = "";

            /* Analysis doc
               [] Good analysis
               [] analysis needs improvement
               [] no analysis or bad analysis
            */

            //Analysis doc
            twelveText = "Good analysis";
            twelve = "Your analysis document looks good. There is a good explanation of the graph and you also include axis titles which is nice. You further demonstrate a good understanding of the complexity involved in the program.";
            thirteenText = "Analysis needs improvement";
            thirteen = "In an analysis document try to analyze the algorithms in the code and explain their big-O complexity. For example, you might say that the jiggler function is O(n) because it loops through every circle once and jiggles it. You might also say that spread out is O(n^2) because it loops through each circle n times and n*n is n^2. Also, your analysis document should include a graph of FPS vs. Number of circles and that graph should have labeled axes.";
            fourteenText = "No analysis";
            fourteen = "You forgot to include your analysis document. Remember that the written portion of this assignment is worth 30% of your grade. It is very important that you demonstrate an understanding of your work.";

            //Assignment.properties file
            fifteenText = "Good assignment.properties file";
            fifteen = "Your assignment.properties file looks great.";
            sixteenText = "No assignment.properties file/ not propery formatted";
            sixteen = "You either didn't submit an assignment.properties file or you did not format it properly, be sure to follow the specs exactly (every space must be exactly correct). This file is used by a computer to give you credit so this is very important!";

            //Design document
            seventeenText = "Good design doc";
            seventeen = "Well done on your desgn doc, you answered all of the questions and it looks great";
            eighteenText = "Design doc needs improvement";
            eighteen = "Your design doc could use a little improvement, answer each question and organize your answers nicely";
            nineteenText = "No Design doc";
            ninteen = "You forgot to include a design doc in your submission.";
        }

        private void generate_comment_Click(object sender, EventArgs e)
        {
            //Create the comment to be generated. 

            string comment = "";
            int i = 0;
            foreach(string com in comments)
            {
                //Add all of the checked boxes comments to the generated comment. 
                if (checkboxes[i].Checked == true)
                {
                    comment += comments + "\n";
                }
                i++;
            }

            //Add what is in the comment text box to the generated comment
            comment += this.commentTxtBox.Text + "\n";
            comment += "Please come see me in office hours if you have any questions about grading.";
            this.commentTxtBox.Text = comment;

            /*
            if (this.checkBox1.Checked == true)
            {
                comment += one;
            }
            if (this.checkBox2.Checked == true)
            {
                comment += two;

            }
            if (this.checkBox3.Checked == true)
            {
                comment += three;

            }
            if (this.checkBox4.Checked == true)
            {
                comment += four;
            }
            if (this.checkBox5.Checked == true)
            {
                comment += five;
            }
            if (this.checkBox6.Checked == true)
            {
                comment += six;

            }
            if (this.checkBox7.Checked == true)
            {
                comment += seven;
            }
            if (this.checkBox8.Checked == true)
            {
                comment += eight;
            }
            if (this.checkBox9.Checked == true)
            {
                comment += nine;
            }
            if (this.checkBox10.Checked == true)
            {
                comment += ten;
            }
            if (this.checkBox11.Checked == true)
            {
                comment += eleven;
            }
            if (this.checkBox12.Checked == true)
            {
                comment += twelve;
            }
            if (this.checkBox13.Checked == true)
            {
                comment += thirteen;
            }
            if (this.checkBox15.Checked == true)
            {
                comment += fifteen;
            }
            if (this.checkBox16.Checked == true)
            {
                comment += sixteen;
            }
            if (this.checkBox17.Checked == true)
            {
                comment += seventeen;
            }
            if (this.checkBox18.Checked == true)
            {
                comment += eighteen;
            }
            if (this.checkBox19.Checked == true)
            {
                comment += ninteen;
            }
            
            if (this.checkBox14.Checked == true)
            {
                comment += fourteen;
            }
            */


        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.commentTxtBox.Text = "";
            foreach (CheckBox cbox in checkboxes)
            {
                cbox.Checked = false;
            }
            /*
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
            this.checkBox1.Checked = false;
            this.checkBox10.Checked = false;
            this.checkBox11.Checked = false;
            this.checkBox12.Checked = false;
            this.checkBox13.Checked = false;
            this.checkBox14.Checked = false;
            this.checkBox15.Checked = false;
            this.checkBox16.Checked = false;
            this.checkBox17.Checked = false;
            this.checkBox18.Checked = false;
            this.checkBox19.Checked = false;
            */
        }
    }
}
