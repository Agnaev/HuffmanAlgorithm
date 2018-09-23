using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace laba2 {
  public partial class Form1 : Form {
    byte numberOfAction  = 0;
    string encodedText   = null;
    byte[] byteArray     = null;
    char[] myEncode      = {' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                            'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У',
                            'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'};

    Dictionary<string, int> statistic = new Dictionary<string, int>();
    
    
    public Form1() {
      InitializeComponent();
    }

    private void openFile_Click(object sender, System.EventArgs e) {
      if (openFileDialog1.ShowDialog() == DialogResult.OK) {
        numberOfAction++;
        infoBox.Text += "["+ numberOfAction +"] " +openFileDialog1.FileName + " ";
      }
    }

    private void readFile_Click(object sender, System.EventArgs e) {
      using (FileStream fstream = new FileStream(openFileDialog1.FileName, FileMode.Open)) {
        byteArray = new byte[fstream.Length];
        fstream.Read(byteArray, 0, byteArray.Length);
        numberOfAction++;
        infoBox.Text += "\n [" + numberOfAction + "] " + "Файл прочитан. ";
        readFileInMyEncoding(byteArray);
      }
    }

    // Чтение файла в собственной кодировке
    private void readFileInMyEncoding(byte[] arr) {
      string result = "";
      foreach (byte el in arr) {
        for (int i = 0; i < myEncode.Length; i++) {
          if (el == i) {
            result += myEncode[i];
            break;
          }
        }
      }
      beginText.Text = result;
      encodedText = result;
    }

    private void getStatictic(byte[] arr) {
      
    }
  }
}
