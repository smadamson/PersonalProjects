import javax.swing.JButton;
import javax.swing.JTextField;

public class HackerProgram extends Thread
{
    Decryption dc;
    JTextField txt;
    JButton decpt;
    //String text;
    JTextField textBox;
    public HackerProgram ()
    {
    
    }
    public HackerProgram (JTextField text, JButton decrypt, JTextField decryptionText)
    {
        dc = new Decryption();
        txt = decryptionText;
        decpt = decrypt;
        //text = dText;
    }

    public void run ()
    {
        String[] loading = { ".", ".", ".", "d", "e", "c", "r", "y", "p", "t", "i", "n", "g", ".", ".", ".", ".", "." };
        String value = dc.getDecryptedValue(txt.getText());
        // long startTime = System.currentTimeMillis();
        long timeBetween = 100_000_000; // wait one second
        int index = 0;
        String loadingStr = "";
        int count = 0;
        while (count < 5)
        {
            //System.out.println("waiting");
            long startTime = System.nanoTime();
            //long currentTime = System.currentTimeMillis();
            // wait some time.
            while (System.nanoTime() - startTime < timeBetween)
            { // empty block
            }

            if (index < loading.length)
            {
                //loadingStr += loading[index];
                System.out.print(loading[index]);
                txt.setText(txt.getText() + loading[index]);
            }
            else if(index == loading.length)
            {
                count++;
                System.out.println("");
                index = -1;
                txt.setText("");
                //break;
            }
            index++;
        }
        System.out.println("");
        System.out.println(value);
        txt.setText(value);
    }
}
