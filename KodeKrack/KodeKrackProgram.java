import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import javax.swing.JComponent;
import javax.swing.JPanel;

public class KodeKrackProgram extends Thread
{
    Point from_us, from_them, fireWall_1_us, fireWall_2_us, fireWall_3_us, fireWall_1_them, fireWall_2_them, fireWall_3_them;
    JPanel mainPanel;
    Line line1_us, line2_us, line3_us, line1_them, line2_them, line3_them;

    public KodeKrackProgram (JPanel mainPanel, Point from_us, Point from_them, Point fireWall_1_us, Point fireWall_1_them,
            Point fireWall_2_us, Point fireWall_2_them, Point fireWall_3_us, Point fireWall_3_them)
    {
        this.from_us = from_us;
        this.from_them = from_them;
        this.fireWall_1_us = fireWall_1_us;
        this.fireWall_2_us = fireWall_2_us;
        this.fireWall_3_us = fireWall_3_us;
        this.fireWall_1_them = fireWall_1_them;
        this.fireWall_2_them = fireWall_2_them;
        this.fireWall_3_them = fireWall_3_them;
        this.mainPanel = mainPanel;
    }

    public void run ()
    {
        line1_us = new Line(from_us, fireWall_1_us);
        line2_us = new Line(from_us, fireWall_2_us);
        line3_us = new Line(from_us, fireWall_3_us);
        line1_them = new Line(from_them, fireWall_1_them);
        line2_them = new Line(from_them, fireWall_2_them);
        line3_them = new Line(from_them, fireWall_3_them);

        mainPanel.add(line1_us);
        mainPanel.add(line2_us);
        mainPanel.add(line3_us);
        mainPanel.add(line1_them);
        mainPanel.add(line2_them);
        mainPanel.add(line3_them);
        mainPanel.repaint();

        // draw a line from point "from" to point "to".
        System.out.println("running");
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
        this.to = to;
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