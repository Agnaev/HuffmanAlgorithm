using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace laba2 {
  public partial class Form1 : Form {
    byte numberOfAction  = 0;
    string encodedText   = null;
    byte[] byteArray     = null;
    char[] myEncoding = {' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                            'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У',
                            'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'};

    HuffmanTree htree = new HuffmanTree();
    public BitArray encoded;
    public BitArray symbols;


    public Form1() {
      InitializeComponent();
    }


    private void openFile_Click(object sender, System.EventArgs e) {
      if (openFileDialog1.ShowDialog() == DialogResult.OK) {
        numberOfAction++;
        infoBox.Text += "["+ numberOfAction +"] " +openFileDialog1.FileName + "    ";
      }
    }


    private void readFile_Click(object sender, System.EventArgs e) {
      using (FileStream fstream = new FileStream(openFileDialog1.FileName, FileMode.Open)) {
        byteArray = new byte[fstream.Length];
        fstream.Read(byteArray, 0, byteArray.Length);
        numberOfAction++;
        infoBox.Text += "\n [" + numberOfAction + "] " + "Файл прочитан.    ";
        readFileInMyEncoding(byteArray);
      }
    }


    // Чтение файла в собственной кодировке
    private void readFileInMyEncoding(byte[] arr) {
      string result = "";
      foreach (byte el in arr) {
        for (int i = 0; i < myEncoding.Length; i++) {
          if (el == i) {
            result += myEncoding[i];
            break;
          }
        }
      }
      beginText.Text = result;
      encodedText = result;
    }
    

    private void encode_Click(object sender, System.EventArgs e) {
      decode.Enabled = true;
      encoded = htree.Encode(encodedText);
      foreach (bool bit in encoded) {
        encodeTextBox.Text += (bit ? 1 : 0) + " ";
      }

      //
      int i = 0;
      string alphabet = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
      FileInfo fi1    = new FileInfo(openFileDialog1.FileName);
      label5.Text     = "Исходный файл " + fi1.Length.ToString() + " байт";
      byte[] array    = new byte[68];
      byte[] chislo   = new byte[2];
      int n           = 0;
      bool zapisal    = false;

      for (int j = 0; j < 34; j++) {
        zapisal = false;
        foreach (KeyValuePair<char, int> item in htree.Frequencies) {
          if (alphabet[j] == item.Key) {
            chislo = BitConverter.GetBytes(Convert.ToInt16(item.Value));
            chislo.CopyTo(array, n);
            n += 2;
            zapisal = true;
          }
        }
        if (!zapisal) {
          array[n] = Convert.ToByte(0);
          n++;
          array[n] = Convert.ToByte(0);
          n++;
        }
      }

      foreach (KeyValuePair<char, int> item in htree.Frequencies) {
        aboutEncoding.Text += ("Символ: " + item.Key + "   Количество: " + item.Value.ToString() + "   Код " + htree.codec1[item.Key].ToString() + "\n");
        i++;
      }

      int a = 0;
      if (encoded.Count % 8 != 0)
        a++;
      a += encoded.Count / 8;
      label6.Text = "Закодированный файл: " + a.ToString() + " байт";
      label7.Text = "Сжатие " + (Convert.ToDouble(fi1.Length) / Convert.ToDouble(a)).ToString() + " раз";
      //
      numberOfAction++;
      infoBox.Text += "[" + numberOfAction + "] " + "Text was encoded via Huffman algorithm.    ";
    }


    private void decode_Click(object sender, System.EventArgs e) {
      decodeTextBox.Text = htree.Decode(encoded);
      numberOfAction++;
      infoBox.Text += "[" + numberOfAction + "] " + "Text was decoded via Huffman algorithm.    ";
    }


    private void buldTree_Click(object sender, System.EventArgs e) {
      encode.Enabled = true;
      htree.Build(encodedText);
      numberOfAction++;
      infoBox.Text += "[" + numberOfAction + "] " + "Huffman tree was builded. ";
    }


    public static byte[] ToByteArray(BitArray bits) {
      int numBytes = bits.Count / 8;
      if (bits.Count % 8 != 0)
        numBytes++;

      byte[] bytes = new byte[numBytes];
      int byteIndex = 0, bitIndex = 0;

      for (int i = 0; i < bits.Count; i++) {
        if (bits[i])
          bytes[byteIndex] |= (byte)(1 << (7 - bitIndex));
        bitIndex++;
        if (bitIndex == 8) {
          bitIndex = 0;
          byteIndex++;
        }
      }
      return bytes;
    }


    public class Node {
      public char Symbol { get; set; }
      public int Frequency { get; set; }
      public Node Right { get; set; }
      public Node Left { get; set; }
      public List<bool> Traverse(char symbol, List<bool> data) {
        // Leaf
        if (Right == null && Left == null) {
          if (symbol.Equals(this.Symbol)) {
            return data;
          } else {
            return null;
          }
        } else {
          List<bool> left = null;
          List<bool> right = null;
          if (Left != null) {
            List<bool> leftPath = new List<bool>();
            leftPath.AddRange(data);
            leftPath.Add(false);
            left = Left.Traverse(symbol, leftPath);
          }
          if (Right != null) {
            List<bool> rightPath = new List<bool>();
            rightPath.AddRange(data);
            rightPath.Add(true);
            right = Right.Traverse(symbol, rightPath);
          }
          if (left != null) {
            return left;
          } else {
            return right;
          }
        }
      }
    }


    public class HuffmanTree {
      private List<Node> nodes = new List<Node>();
      public Node Root { get; set; }
      public Dictionary<char, int> Frequencies = new Dictionary<char, int>();

      public void Build(string source) {
        for (int i = 0; i < source.Length; i++) {
          if (!Frequencies.ContainsKey(source[i])) {
            Frequencies.Add(source[i], 0);
          }
          Frequencies[source[i]]++;
        }

        Dictionary<char, int> temp_dictionary = new Dictionary<char, int>();

        foreach (KeyValuePair<char, int> item in Frequencies.OrderBy(key => key.Key)) {
          temp_dictionary.Add(item.Key, item.Value);
        }

        Frequencies.Clear();

        foreach (KeyValuePair<char, int> item in temp_dictionary) {
          Frequencies.Add(item.Key, item.Value);
        }

        foreach (KeyValuePair<char, int> symbol in Frequencies) {
          nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
        }

        while (nodes.Count > 1) {
          List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList<Node>();

          if (orderedNodes.Count >= 2) {
            // Take first two items
            List<Node> taken = orderedNodes.Take(2).ToList<Node>();
            // Create a parent node by combining the frequencies
            Node parent = new Node() {
              Symbol = '*',
              Frequency = taken[0].Frequency + taken[1].Frequency,
              Left = taken[0],
              Right = taken[1]
            };

            nodes.Remove(taken[0]);

            nodes.Remove(taken[1]);

            nodes.Add(parent);
          }
          this.Root = nodes.FirstOrDefault();
        }
      }


      public List<string> code = new List<string>();

      public IEnumerable<string> codec;

      public Dictionary<char, string> codec1 = new Dictionary<char, string>();


      public BitArray Encode(string source) {
        List<bool> encodedSource = new List<bool>();
        for (int i = 0; i < source.Length; i++) {
          List<bool> encodedSymbol = this.Root.Traverse(source[i], new List<bool>());
          encodedSource.AddRange(encodedSymbol);
          this.code.Add("");
          foreach (bool a in encodedSymbol.ToArray()) {
            this.code[i] += Convert.ToInt32(a).ToString();
          }
          if (!codec1.ContainsKey(source[i]))
            codec1.Add(source[i], code[i]);
        }
        BitArray bits = new BitArray(encodedSource.ToArray());
        return bits;
      }


      public string Decode(BitArray bits) {
        Node current = this.Root;
        string decoded = "";

        foreach (bool bit in bits) {
          if (bit) {
            if (current.Right != null) {
              current = current.Right;
            }
          } else {
            if (current.Left != null) {
              current = current.Left;
            }
          }

          if (IsLeaf(current)) {
            decoded += current.Symbol;
            current = this.Root;
          }
        }
        return decoded;
      }

      public bool IsLeaf(Node node) {
        return (node.Left == null && node.Right == null);
      }
    }


  }

 


}
