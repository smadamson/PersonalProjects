import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.Point;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.function.Function;
import javax.swing.text.BadLocationException;
import javax.swing.text.DefaultStyledDocument;
import javax.swing.text.Style;
import javax.swing.text.StyleConstants;
import javax.swing.text.StyleContext;
import javax.swing.*;

public class HackerDisplay
{
    static Dimension screenSize = java.awt.Toolkit.getDefaultToolkit().getScreenSize();
    final static int SCREEN_WIDTH = screenSize.width;
    final static int SCREEN_HEIGHT = screenSize.height;

    /***************** Shared fields *************************************/

    final static Font TEXT_FONT = new Font("Serif", Font.PLAIN, 24);
    final static Font TITLE_TEXT_FONT = new Font("Serif", Font.PLAIN, 60);
    final static Color BACKGROUND_COLOR = Color.BLACK;
    final static Point TOGGLE_PROGRAM_BUTTON_LOCATION = new Point(10, 10);
    final static Point TITLE_LABEL_LOCATION_START_POINT = new Point(SCREEN_WIDTH / 2, 10);

    /***************** Decryption fields ****************************/
    final static Point PASSWORD_LABEL_LOCATION = new Point((SCREEN_WIDTH / 2) - (SCREEN_WIDTH / 4),
            7 * (SCREEN_HEIGHT / 13));
    final static Point DECRYPT_BUTTON_LOCATION = new Point(7 * (SCREEN_WIDTH / 11), 7 * (SCREEN_HEIGHT / 13));
    final static Point textAreaLocation = new Point(3 * (SCREEN_WIDTH / 8), 7 * (SCREEN_HEIGHT / 13));
    final static Point decryptTextAreaLocation = new Point(3 * (SCREEN_WIDTH / 8), 7 * (SCREEN_HEIGHT / 13) + 30);

    /***************** Hacker fields *************************************/
    final static Point KK_PASSWORD_LABEL_LOCATION = new Point((SCREEN_WIDTH / 2) - (SCREEN_WIDTH / 4),
            14 * (SCREEN_HEIGHT / 17));
    final static Point HACK_BUTTON_LOCATION = new Point(7 * (SCREEN_WIDTH / 11), 14 * (SCREEN_HEIGHT / 17) - 2);
    final static Point kktextAreaLocation = new Point(3 * (SCREEN_WIDTH / 8), 14 * (SCREEN_HEIGHT / 17) + 3);
    final static String TEXT_DISPLAYED_IN_PASSWORD_BOX = "Please enter your password";

    final static Point FIREWALL_IMAGE_LOCATION_1 = new Point(1 * (SCREEN_WIDTH / 4), (SCREEN_HEIGHT / 3));
    final static Point FIREWALL_LINE_POINT_1 = new Point(FIREWALL_IMAGE_LOCATION_1.x + 55,
            FIREWALL_IMAGE_LOCATION_1.y + 10);
    final static Point FIREWALL_LINE_POINT_1_THEM = new Point(FIREWALL_IMAGE_LOCATION_1.x + 55,
            FIREWALL_IMAGE_LOCATION_1.y + 150);

    final static Point FIREWALL_IMAGE_LOCATION_2 = new Point(1 * (SCREEN_WIDTH / 2) - 35, (SCREEN_HEIGHT / 3));
    final static Point FIREWALL_LINE_POINT_2 = new Point(FIREWALL_IMAGE_LOCATION_2.x + 35,
            FIREWALL_IMAGE_LOCATION_2.y + 100);
    final static Point FIREWALL_LINE_POINT_2_THEM = new Point(FIREWALL_IMAGE_LOCATION_2.x + 35,
            FIREWALL_IMAGE_LOCATION_2.y + 100);

    final static Point FIREWALL_IMAGE_LOCATION_3 = new Point(3 * (SCREEN_WIDTH / 4) - 40, (SCREEN_HEIGHT / 3));
    final static Point FIREWALL_LINE_POINT_3 = new Point(FIREWALL_IMAGE_LOCATION_3.x + 20,
            FIREWALL_IMAGE_LOCATION_3.y + 10);
    final static Point FIREWALL_LINE_POINT_3_THEM = new Point(FIREWALL_IMAGE_LOCATION_3.x + 20,
            FIREWALL_IMAGE_LOCATION_3.y + 150);

    final static Point OUR_SYSTEM_IMAGE_LOCATION = new Point((SCREEN_WIDTH / 2), 100);
    final static Point THIER_SYSTEM_IMAGE_LOCATION = new Point((SCREEN_WIDTH / 2), kktextAreaLocation.y - 50);

    static boolean buttonIsPressed = false;

    public static void main (String[] args)
    {

        System.out.println(SCREEN_WIDTH);
        System.out.println(SCREEN_HEIGHT);

        // JFrame BlackFrame = new JFrame();
        // BlackFrame.setSize(BlackFrame.getPreferredSize());
        // BlackFrame.setBackground(BACKGROUND_COLOR);
        // BlackFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        // BlackFrame.pack();
        // BlackFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);
        // BlackFrame.setVisible(true);
        // JPanel BlackPanel = new JPanel();
        // BlackPanel.setSize(BlackPanel.getPreferredSize());
        // BlackPanel.setBackground(BACKGROUND_COLOR);
        // BlackFrame.setContentPane(BlackPanel);

        setUpKodeKrack();
    }

    private static void setUpDecryptor ()
    {
        JPanel centerPanel = new JPanel();
        centerPanel.setBackground(BACKGROUND_COLOR);
        centerPanel.setLayout(null);

        JLabel passcodeLabel = new JLabel("Passcode:");
        passcodeLabel.setName("passcodeLabel");
        passcodeLabel.setFont(TEXT_FONT);
        passcodeLabel.setForeground(Color.RED);
        passcodeLabel.setSize(passcodeLabel.getPreferredSize());
        passcodeLabel.setLocation(PASSWORD_LABEL_LOCATION);
        centerPanel.add(passcodeLabel);

        JLabel hacker = new JLabel("Decryption");
        hacker.setFont(TITLE_TEXT_FONT);
        hacker.setForeground(Color.RED);
        hacker.setSize(hacker.getPreferredSize());
        hacker.setLocation(TITLE_LABEL_LOCATION_START_POINT.x - (hacker.getWidth() / 2),
                TITLE_LABEL_LOCATION_START_POINT.y);
        centerPanel.add(hacker);

        JButton decryptButton = new JButton("Decrypt");
        decryptButton.setFont(TEXT_FONT);
        decryptButton.setForeground(Color.RED);
        decryptButton.setBackground(BACKGROUND_COLOR);
        decryptButton.setLocation(DECRYPT_BUTTON_LOCATION);
        decryptButton.setSize(decryptButton.getPreferredSize());
        decryptButton.setBorderPainted(false);
        centerPanel.add(decryptButton);

        JTextField text = new JTextField("enter me");
        text.setForeground(Color.GREEN);
        text.setBackground(BACKGROUND_COLOR);
        text.setLocation(textAreaLocation);
        text.setSize(300, 30);
        text.setBorder(BorderFactory.createLineBorder(BACKGROUND_COLOR));
        centerPanel.add(text);

        JTextField decryptionText = new JTextField();
        decryptionText.setForeground(Color.GREEN);
        decryptionText.setBackground(BACKGROUND_COLOR);
        decryptionText.setLocation(decryptTextAreaLocation);
        decryptionText.setSize(300, 50);
        decryptionText.setBorder(BorderFactory.createLineBorder(BACKGROUND_COLOR));
        centerPanel.add(decryptionText);

        JFrame topLevelFrame = new JFrame();
        topLevelFrame.setSize(topLevelFrame.getPreferredSize());
        topLevelFrame.setContentPane(centerPanel);

        topLevelFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        topLevelFrame.pack();
        topLevelFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);

        JButton goToKodeKrackButton = new JButton("KodeKrack");
        goToKodeKrackButton.setFont(TEXT_FONT);
        goToKodeKrackButton.setForeground(Color.RED);
        goToKodeKrackButton.setBackground(BACKGROUND_COLOR);
        goToKodeKrackButton.setLocation(TOGGLE_PROGRAM_BUTTON_LOCATION);
        goToKodeKrackButton.setSize(goToKodeKrackButton.getPreferredSize());
        goToKodeKrackButton.setBorderPainted(false);
        centerPanel.add(goToKodeKrackButton);

        goToKodeKrackButton.addActionListener(new ActionListener()
        {
            public void actionPerformed (ActionEvent e)
            {
                setUpKodeKrack();
                topLevelFrame.setVisible(false);
            }
        });

        decryptButton.addActionListener(new ActionListener()
        {
            public void actionPerformed (ActionEvent e)
            {

                (new HackerProgram(text, decryptButton, decryptionText)).start();
            }
        });

        topLevelFrame.setVisible(true);
    }

    private static void setUpKodeKrack ()
    {
        JPanel KkCenterPanel = new JPanel();
        KkCenterPanel.setBackground(BACKGROUND_COLOR);
        KkCenterPanel.setLayout(null);
        JLabel kk = new JLabel("KodeKrack");
        kk.setFont(TITLE_TEXT_FONT);
        kk.setForeground(Color.RED);
        kk.setSize(kk.getPreferredSize());
        kk.setLocation(TITLE_LABEL_LOCATION_START_POINT.x - (kk.getWidth() / 2), TITLE_LABEL_LOCATION_START_POINT.y);
        KkCenterPanel.add(kk);

        JLabel passcodeLabel = new JLabel("Passcode:");
        passcodeLabel.setName("passcodeLabel");
        passcodeLabel.setFont(TEXT_FONT);
        passcodeLabel.setForeground(Color.RED);
        passcodeLabel.setSize(passcodeLabel.getPreferredSize());
        passcodeLabel.setLocation(KK_PASSWORD_LABEL_LOCATION);
        KkCenterPanel.add(passcodeLabel);

        JButton crackButton = new JButton("Hack");
        crackButton.setFont(TEXT_FONT);
        crackButton.setForeground(Color.RED);
        crackButton.setBackground(BACKGROUND_COLOR);
        crackButton.setLocation(HACK_BUTTON_LOCATION);
        crackButton.setSize(crackButton.getPreferredSize());
        crackButton.setBorderPainted(false);
        KkCenterPanel.add(crackButton);

        JTextField kkText = new JTextField("enter me");
        kkText.setForeground(Color.GREEN);
        kkText.setBackground(BACKGROUND_COLOR);
        kkText.setLocation(kktextAreaLocation);
        kkText.setSize(300, 30);
        kkText.setBorder(BorderFactory.createLineBorder(BACKGROUND_COLOR));
        KkCenterPanel.add(kkText);

        JFrame kKTopLevelFrame = new JFrame();
        kKTopLevelFrame.setSize(kKTopLevelFrame.getPreferredSize());
        kKTopLevelFrame.setContentPane(KkCenterPanel);
        kKTopLevelFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        kKTopLevelFrame.pack();
        kKTopLevelFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);

        JButton goToDecryptorButton = new JButton("Decryptor");
        goToDecryptorButton.setFont(TEXT_FONT);
        goToDecryptorButton.setForeground(Color.RED);
        goToDecryptorButton.setBackground(BACKGROUND_COLOR);
        goToDecryptorButton.setLocation(TOGGLE_PROGRAM_BUTTON_LOCATION);
        goToDecryptorButton.setSize(goToDecryptorButton.getPreferredSize());
        goToDecryptorButton.setBorderPainted(false);
        KkCenterPanel.add(goToDecryptorButton);

        ImagePanel firewall_1 = new ImagePanel("C:/Users/Sara Adamson/workspaceTA2420/Hacker/Resources/firewall.png");
        firewall_1.setLocation(FIREWALL_IMAGE_LOCATION_1);
        KkCenterPanel.add(firewall_1);

        ImagePanel firewall_2 = new ImagePanel("C:/Users/Sara Adamson/workspaceTA2420/Hacker/Resources/firewall.png");
        firewall_2.setLocation(FIREWALL_IMAGE_LOCATION_2);
        KkCenterPanel.add(firewall_2);

        ImagePanel firewall_3 = new ImagePanel("C:/Users/Sara Adamson/workspaceTA2420/Hacker/Resources/firewall.png");
        firewall_3.setLocation(FIREWALL_IMAGE_LOCATION_3);
        KkCenterPanel.add(firewall_3);
        KkCenterPanel.repaint();

        goToDecryptorButton.addActionListener(new ActionListener()
        {
            public void actionPerformed (ActionEvent e)
            {
                setUpDecryptor();
                kKTopLevelFrame.setVisible(false);
            }
        });

        KodeKrackProgram kkp = new KodeKrackProgram(KkCenterPanel, OUR_SYSTEM_IMAGE_LOCATION,
                THIER_SYSTEM_IMAGE_LOCATION, FIREWALL_LINE_POINT_1, FIREWALL_LINE_POINT_1_THEM, FIREWALL_LINE_POINT_2,
                FIREWALL_LINE_POINT_2_THEM, FIREWALL_LINE_POINT_3, FIREWALL_LINE_POINT_3_THEM);

        crackButton.addActionListener(new ActionListener()
        {
            public void actionPerformed (ActionEvent e)
            {
                (kkp).start();
            }
        });

        kKTopLevelFrame.setVisible(true);
    }
}
