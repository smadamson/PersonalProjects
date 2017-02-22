import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JComponent;
import javax.swing.JPanel;

class ImagePanel extends JComponent
{

    private Image img;

    public ImagePanel (String img)
    {
        this(new ImageIcon(img).getImage());
    }

    public ImagePanel (Image img)
    {
        this.img = img;
        Dimension size = new Dimension(img.getWidth(null), img.getHeight(null));
        setPreferredSize(size);
        setMinimumSize(size);
        setMaximumSize(size);
        setSize(size);
        setLayout(null);
    }

    public void paintComponent (Graphics g)
    {
        g.drawImage(img, 0, 0, null);
    }

}

/*
 * public class ImageComponent extends JComponent {
 * 
 * private BufferedImage image;
 * 
 * public ImageComponent (String filename) { try { image = ImageIO.read(new File(filename)); } catch (IOException ex) {
 * // handle exception... } }
 * 
 * @Override protected void paintComponent (Graphics g) { System.out.println("drawing image"); super.paintComponent(g);
 * g.drawImage(image, 0, 0, this); // see javadoc for more info on the parameters }
 * 
 * }
 */