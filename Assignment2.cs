using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string one_xywh_circle_comment = "When you implemented your Circle class, you created your own x, y, width, and height. These values are already provided by the inherited class. In most cases, you should not redefine values that are already provided, as keeping them \"in-sync\" is a trouble inducing problem.\n";
        string two_optimize_pushing_apart = "Your \"Pushing Apart\" algorithm loops over every circle and then every other circle. In reality, once the \"first\" circle has \"seen\" the \"second\" circle, you don't need to have the \"second\" circle \"recheck\" the \"first\". This can be achieved by using two for loops and having the second for loop start at the index of the first for loop.\n";
        string three_Jiggling_should_be_in_Own_THread = "While you were able to get the main functionality of the program working by calling the jiggle method in your main program, it really should be put in its own thread as discussed in lecture. This will allow your program to better utilize a \"multi-core\" computing environment... like your laptop.\n";
        string four_long_wall_code_in_jiggler = "All of your jiggling, pushing, and selection movement is in one long block of code in the run section of your Jiggler.  A Superior solution would be to make a separate method for each of these.\n";
        string five_cannot_toggle_off_spread_out_and_Jiggle = "There is no Boolean allowing customization so that your code will just spread out the circles, or just jiggle the circles. \n";
        string six_circles_not_fully_drawn = "Your circles are not fully drawn, there is a gap in the circles on the right side and the bottom. This is caused by drawing the ovals with a height and width of one too far in your paintComponent method. You should draw them to width-1 and height-1. \n";
        string seven_doing_set_color_int_paintComp = "You are setting the color of your circle inside paint component. This is not a good idea because paintComponent is going to be called very frequently and you only need to set the color once. The color should be set in the constructor.\n";
        string eight_mouse_dragged_not_global = "When dragging a circle a superior solution would get the global coordinates of the mouse and use an offset from the center of the circle to move the circles as the mouse moves. \n";
        string nine_calling_run_vs_start = "Instead of calling the start() method on your Jiggler, you directly called the run() method, which does not properly instantiate a new thread to run the Jiggler. In order to use the threading functionality, ensure you call the start() method. \n";
        string one_code_not_well_commented = "Your code should include Javadoc comments at the top of every method and there should be comments throughout the methods that describe the logic behind non-self-explanatory blocks of code. \n";
        string ten_good_analysis_with_labels = "Your analysis document looks good. There is a good explanation of the graph and you also include axis titles which is nice. You further demonstrate a good understanding of the complexity involved in the program. \n";
        string eleven_Circles_Spread_out_Is_Random = "When your circles spread out they don’t seem to actually move away from each other, It seems as though they just randomly move around until they are no longer overlapping. \n ";
        string twelve_improper_Constructors = "You have not implemented some of the constructors properly. In future assignments, it will be very important that you follow the specs exactly. \n";
        string thirteen_Good_Comments = "Your code is very nicely commented and you used Javadoc comments nicely. Good job.\n ";
        string fourteen_Good_Start_Work_Early = "You are off to a good start, get started on your projects early so that you have plenty of time to get your work done. \n";
        string fifteen_bad_analysis_good_graphs = "In an analysis document try to analyze the algorithms in the code and explain their big-O complexity. For example, you might say that the jiggler function is O(n) because it loops through every circle once and jiggles it. You might also say that spread out is O(n^2) because it loops through each circle n times and n*n is n^2. The graphs in your analysis document look wonderful good job on those. \n";
        string sixteen_public_instance_variables = "Some of the classes declare public instance variables which is generally not a good idea. Instead make those variables private and create getters and setters for them.\n";
        string seventeen_bad_analysis_bad_graphs = "In an analysis document try to analyze the algorithms in the code and explain their big-O complexity. For example, you might say that the jiggler function is O(n) because it loops through every circle once and jiggles it. You might also say that spread out is O(n^2) because it loops through each circle n times and n*n is n^2. Also, your analysis document should include a graph of FPS vs. Number of circles and that graph should have labeled axes.\n";
        string eighteen_selected_circle_moves_away = "When a circle is selected it should no longer try to get away from other circles.\n";
        string nineteen_jiggler_functions_in_circle = "Some functionality of spread-out/jiggler is implemented in the circle class which doesn't really make sense. Moving away from other circles is not really a property that all circles should have. While it might be an easy solution it's not the best solution. These functions should be implemented in the jiggler.\n";

        public Form1()
        {
            InitializeComponent();
            checkBox1.Text = "testing";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comment = "";
            if(this.checkBox2.Checked == true)
            {
                comment += two_optimize_pushing_apart;

            }
            if (this.checkBox3.Checked == true)
            {
                comment += three_Jiggling_should_be_in_Own_THread;

            }
            if (this.checkBox4.Checked == true)
            {
                comment += four_long_wall_code_in_jiggler;
            }
            if (this.checkBox5.Checked == true)
            {
                comment += five_cannot_toggle_off_spread_out_and_Jiggle;
            }
            if (this.checkBox6.Checked == true)
            {
                comment += six_circles_not_fully_drawn;
           
            }
            if (this.checkBox7.Checked == true)
            {
                comment += seven_doing_set_color_int_paintComp;
            }
            if (this.checkBox8.Checked == true)
            {
                comment += eight_mouse_dragged_not_global;
            }
            if (this.checkBox9.Checked == true)
            {
                comment += nine_calling_run_vs_start;
            }
            if(this.checkBox1.Checked == true)
            {
                comment += one_code_not_well_commented;
            }
            if(this.checkBox10.Checked == true)
            {
                comment += ten_good_analysis_with_labels;
            }
            if (this.checkBox11.Checked == true)
            {
                comment += eleven_Circles_Spread_out_Is_Random;
            }
            if (this.checkBox12.Checked == true)
            {
                comment += twelve_improper_Constructors;
            }
            if (this.checkBox13.Checked == true)
            {
                comment += thirteen_Good_Comments;
            }
            if (this.checkBox15.Checked == true)
            {
                comment += fifteen_bad_analysis_good_graphs;
            }
            if (this.checkBox16.Checked == true)
            {
                comment += sixteen_public_instance_variables;
            }
            if (this.checkBox17.Checked == true)
            {
                comment += seventeen_bad_analysis_bad_graphs;
            }
            if (this.checkBox18.Checked == true)
            {
                comment += eighteen_selected_circle_moves_away;
            }
            if (this.checkBox19.Checked == true)
            {
                comment += nineteen_jiggler_functions_in_circle;
            }
            comment += this.comment.Text + "\n";
            if (this.checkBox14.Checked == true)
            {
                comment += fourteen_Good_Start_Work_Early;
            }
            comment += "Please come see me in office hours if you have any questions about grading.\n";
            this.comment.Text = comment;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.comment.Text = "";
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
        }
    }
}
