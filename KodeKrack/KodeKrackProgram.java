import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.Rectangle;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.HashSet;
import java.util.Scanner;
import javax.swing.JComponent;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class KodeKrackProgram  extends Thread
{
    Point from_us, from_them, fireWall_1_us, fireWall_2_us, fireWall_3_us, fireWall_1_them, fireWall_2_them,
            fireWall_3_them;
    JPanel mainPanel;
    Line line1_us, line2_us, line3_us, line1_them, line2_them, line3_them;
    String password;

    HashSet<String> possiblePasswords;

    static int count = 0;

    public KodeKrackProgram (JTextField text, JPanel mainPanel, Point from_us, Point from_them, Point fireWall_1_us,
            Point fireWall_1_them, Point fireWall_2_us, Point fireWall_2_them, Point fireWall_3_us,
            Point fireWall_3_them)
    {
        this.from_us = from_us;
        this.from_them = from_them;
        this.fireWall_1_us = fireWall_1_us;
        this.fireWall_2_us = fireWall_2_us;
        this.fireWall_3_us = fireWall_3_us;
        this.fireWall_1_them = fireWall_1_them;
        this.fireWall_2_them = fireWall_2_them;
        this.fireWall_3_them = fireWall_3_them;
        // this.mainPanel = mainPanel;
        // password = text.getText().trim();
        // Create a list of the possible passwords.
        possiblePasswords = new HashSet<>();
        populatePasswords("C:/Users/Sara Adamson/workspaceTA2420/Hacker/Resources/passwords.txt");

        // create the lines.
        line1_us = new Line(from_us, fireWall_1_us);
         line2_us = new Line(from_us, fireWall_2_us);
         line3_us = new Line(from_us, fireWall_3_us);
         line1_them = new Line(from_them, fireWall_1_them);
         line2_them = new Line(from_them, fireWall_2_them);
         line3_them = new Line(from_them, fireWall_3_them);

    }

    public void run(){
        subRun(mainPanel, password);
    }
    public void subRun (JPanel mainPanel, String password)
    {

        // add the lines when the password is entered.
        if (possiblePasswords.contains(password))
        {
            if (count == 0)
            {
                count++;
                drawSlowly(from_us, fireWall_1_us, mainPanel);
//                long timeBetween = 10_000; // wait a bit
//                long startTime;
//                Line l;
//
//                int numerator = 1;
//                int denom = 2;
//                double fraction = numerator/denom;
//                
//                // change values in l, and add them to main, and repaint incrementally.
//                Point tempTo;
//                
//                //To find the points on the line I need to use point slope formula. 
//                Double slope = (fireWall_1_us.getY()-from_us.getY())/(fireWall_1_us.getX() - from_us.getX()); //The slope between these two lines. 
//                
//                //I will use incremental values of y (top down) and compute the values of x. 
//                Double tempY = from_us.getY(); //top y value. 
//                
//                //find the x value associated with this y value using point slope. 
//                Double tempX;
//                
//                while (true) // stop when we've added the entire line.
//                {
//                    tempX = (tempY - from_us.y + slope*from_us.x)/slope;
//                    
//                    tempTo = new Point((int)(1 * tempX), (int)(1 * tempY));
//                    
//                    l = new Line(from_us, tempTo);
//
//                    mainPanel.add(l);
//                    mainPanel.repaint();
//                    
//                    tempY++;
//                    if (tempTo.equals(fireWall_1_us))
//                    {
//                        break;
//                    }
//
//                    startTime = System.nanoTime();
//                    while (System.nanoTime() - startTime < timeBetween)
//                    { 
//                        // empty block
//                    }
//                }
                //mainPanel.add(line1_us);
                 //mainPanel.add(line1_them);
                mainPanel.repaint();

                // remove the password
                possiblePasswords.remove(password);
            }
            else if (count == 1)
            {
                // System.out.println("you got one!");
                mainPanel.add(line2_us);
                mainPanel.add(line2_them);
                count++;
                mainPanel.repaint();

                // remove the password
                possiblePasswords.remove(password);
            }
            else if (count == 2)
            {
                // System.out.println("you got them all!");
                mainPanel.add(line3_us);
                mainPanel.add(line3_them);
                count++;
                mainPanel.repaint();
                // remove the password
                possiblePasswords.remove(password);
            }

        }

        // draw a line from point "from" to point "to".
        // System.out.println("That was wrong" + count);
    }

    private void drawSlowly (Point from, Point to, JPanel main)
    {
        long timeBetween = 10_000; // wait a bit
        long startTime;
        Line l;

        int numerator = 1;
        int denom = 2;
        double fraction = numerator/denom;
        
        // change values in l, and add them to main, and repaint incrementally.
        Point tempTo;
        
        //To find the points on the line I need to use point slope formula. 
        Double slope = (to.getY()-from.getY())/(to.getX() - from.getX()); //The slope between these two lines. 
        
        //I will use incremental values of y (top down) and compute the values of x. 
        Double tempY = from.getY(); //top y value. 
        
        //find the x value associated with this y value using point slope. 
        Double tempX;
        
        while (true) // stop when we've added the entire line.
        {
            tempX = (tempY - from.y + slope*from.x)/slope;
            
            tempTo = new Point((int)(1 * tempX), (int)(1 * tempY));
            l = new Line(from, tempTo);

            main.add(l);
            main.repaint();
            
            tempY++;
            if (tempTo.equals(to))
            {
                break;
            }

            startTime = System.nanoTime();
            while (System.nanoTime() - startTime < timeBetween)
            { 
                // empty block
            }
        }
    }

    /**
     * Populates the passwords set using the given filename.
     */
    private void populatePasswords (String fileName)
    {
        Scanner s;
        try (BufferedReader reader = new BufferedReader(new FileReader(fileName)))
        {
            s = new Scanner(reader);

            while (s.hasNext())
            {
                // add each line to the possiblePasswords.
                possiblePasswords.add(s.nextLine().trim());
            }

        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
        }
    }
}

class Line extends JComponent
{
    Point from, to;

    public Line (Point from, Point to)
    {
        this.setSize(1000, 1000);
        this.setName("line");

        this.setForeground(Color.GREEN);

        this.from = from;
        //System.out.print("Correct: (" + from.x + ", " + from.y + ")");
        this.to = to;
        //System.out.println("(" + to.x + ", " + to.y + ")");
    }

    @Override
    public void paintComponent (Graphics g)
    {
        super.paintComponent(g);
        Graphics2D g2d = (Graphics2D) g.create();
        g2d.setStroke(new BasicStroke(5));
        g2d.drawLine(from.x, from.y, to.x, to.y);
        System.out.println("drawing");

        g2d.dispose();
    }
}