import java.awt.BorderLayout;
import java.awt.Color;
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
    final static int PANEL_WIDTH = 1500;
    final static int PANEL_HEIGHT = 600;
    final static Font TEXT_FONT = new Font("Serif", Font.PLAIN, 24);
    final static Point passLabelLocation = new Point(1000 / 2 - 80, 600 / 2);
    final static Point hackerLocation = new Point(500, 10);
    final static Point textAreaLocation = new Point(1000 / 2 + 60, 600 / 2 + 130);
    final static Point decryptTextAreaLocation = new Point(1000 / 2 + 60, 600 / 2 + 130 + 30);
    final static Point BUTTON_LOCATION = new Point(1000 / 2 + 375, 600 / 2 + 130);
    final static String TEXT = "Please enter your password";
    final static Color BACKGROUND_COLOR = Color.BLACK;
    final static Font TITLE_TEXT_FONT = new Font("Serif", Font.PLAIN, 60);
    final static Point KK_BUTTON_LOCATION = new Point(10, 10);

    static boolean buttonIsPressed = false;

    public static void main (String[] args)
    {   
        
        JFrame BlackFrame = new JFrame();
        BlackFrame.setSize(1000, 1000);
        BlackFrame.setBackground(BACKGROUND_COLOR);
        BlackFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        BlackFrame.pack();
        BlackFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);
        BlackFrame.setVisible(true);
        
        setUpDecryptor();
    }

    private static void setUpDecryptor ()
    {
        JPanel centerPanel = new JPanel();
        centerPanel.setBackground(BACKGROUND_COLOR);
        centerPanel.setLayout(null);

        JLabel passcodeLabel = new JLabel("Passcode:");
        passcodeLabel.setBounds(passLabelLocation.x, passLabelLocation.y, PANEL_WIDTH - passLabelLocation.x,
                PANEL_HEIGHT - passLabelLocation.y);
        passcodeLabel.setName("passcodeLabel");
        passcodeLabel.setFont(TEXT_FONT);
        passcodeLabel.setForeground(Color.RED);
        centerPanel.add(passcodeLabel);

        JLabel hacker = new JLabel("Decryption");
        hacker.setFont(TITLE_TEXT_FONT);
        hacker.setForeground(Color.RED);
        hacker.setLocation(hackerLocation);
        hacker.setSize(1000, 100);
        centerPanel.add(hacker);

        JButton decryptButton = new JButton("Decrypt");
        decryptButton.setFont(TEXT_FONT);
        decryptButton.setForeground(Color.RED);
        decryptButton.setBackground(BACKGROUND_COLOR);
        decryptButton.setLocation(BUTTON_LOCATION);
        decryptButton.setSize(200, 50);
        decryptButton.setBorderPainted(false);
        centerPanel.add(decryptButton);

        JTextField text = new JTextField("enter me");
        text.setForeground(Color.GREEN);
        text.setBackground(BACKGROUND_COLOR);
        text.setLocation(textAreaLocation);
        text.setSize(300, 30);
        centerPanel.add(text);

        JTextField decryptionText = new JTextField();
        decryptionText.setForeground(Color.GREEN);
        decryptionText.setBackground(BACKGROUND_COLOR);
        decryptionText.setLocation(decryptTextAreaLocation);
        decryptionText.setSize(300, 50);
        centerPanel.add(decryptionText);

        JFrame topLevelFrame = new JFrame();
        topLevelFrame.setSize(1000, 1000);
        topLevelFrame.setContentPane(centerPanel);

        topLevelFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        topLevelFrame.pack();
        topLevelFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);

        JButton goToKodeKrackButton = new JButton("KodeKrack");
        goToKodeKrackButton.setFont(TEXT_FONT);
        goToKodeKrackButton.setForeground(Color.RED);
        goToKodeKrackButton.setBackground(BACKGROUND_COLOR);
        goToKodeKrackButton.setLocation(KK_BUTTON_LOCATION);
        goToKodeKrackButton.setSize(150, 100);
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
        
        HackerProgram hp = new HackerProgram(text, decryptButton, decryptionText);

        decryptButton.addActionListener(new ActionListener()
        {
            public void actionPerformed (ActionEvent e)
            {
                hp.start();
            }
        });

        topLevelFrame.setVisible(true);
    }

    private static void setUpKodeKrack ()
    {
        JPanel kKCenterPanel = new JPanel();
        kKCenterPanel.setBackground(BACKGROUND_COLOR);
        kKCenterPanel.setLayout(null);
        JLabel kk = new JLabel("KodeKrack");
        kk.setFont(TITLE_TEXT_FONT);
        kk.setForeground(Color.RED);
        kk.setLocation(hackerLocation);
        kk.setSize(1000, 100);
        kKCenterPanel.add(kk);

        JLabel passcodeLabel = new JLabel("Passcode:");
        passcodeLabel.setBounds(passLabelLocation.x, passLabelLocation.y, PANEL_WIDTH - passLabelLocation.x,
                PANEL_HEIGHT - passLabelLocation.y);
        passcodeLabel.setName("passcodeLabel");
        passcodeLabel.setFont(TEXT_FONT);
        passcodeLabel.setForeground(Color.RED);
        kKCenterPanel.add(passcodeLabel);

        JButton crackButton = new JButton("Hack");
        crackButton.setFont(TEXT_FONT);
        crackButton.setForeground(Color.RED);
        crackButton.setBackground(BACKGROUND_COLOR);
        crackButton.setLocation(BUTTON_LOCATION);
        crackButton.setSize(200, 50);
        crackButton.setBorderPainted(false);
        kKCenterPanel.add(crackButton);

        JTextField kkText = new JTextField("enter me");
        kkText.setForeground(Color.GREEN);
        kkText.setBackground(BACKGROUND_COLOR);
        kkText.setLocation(textAreaLocation);
        kkText.setSize(300, 30);
        kKCenterPanel.add(kkText);

        JFrame kKTopLevelFrame = new JFrame();
        kKTopLevelFrame.setSize(1000, 1000);
        kKTopLevelFrame.setContentPane(kKCenterPanel);
        kKTopLevelFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        kKTopLevelFrame.pack();
        kKTopLevelFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);
        
        JButton goToDecryptorButton = new JButton("Decryptor");
        goToDecryptorButton.setFont(TEXT_FONT);
        goToDecryptorButton.setForeground(Color.RED);
        goToDecryptorButton.setBackground(BACKGROUND_COLOR);
        goToDecryptorButton.setLocation(KK_BUTTON_LOCATION);
        goToDecryptorButton.setSize(150, 100);
        goToDecryptorButton.setBorderPainted(false);
        kKCenterPanel.add(goToDecryptorButton);

        goToDecryptorButton.addActionListener(new ActionListener()
        {
            public void actionPerformed (ActionEvent e)
            {
                setUpDecryptor();
                kKTopLevelFrame.setVisible(false);
            }
        });
        
        KodeKrackProgram kpp = new KodeKrackProgram();
        
        crackButton.addActionListener(new ActionListener()
        {
            public void actionPerformed (ActionEvent e)
            {
                kpp.start();
            }
        });

        kKTopLevelFrame.setVisible(true);
    }
}
