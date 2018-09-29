

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

namespace haffman {

  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
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



    public HuffmanTree htree = new HuffmanTree();
    public BitArray encoded;
    public BitArray symbols;

    private void button1_Click(object sender, EventArgs e) {
      int i = 0;
      richTextBox1.Text = "";
      string alphabet = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

      htree.Build(textBox1.Text);
      encoded = htree.Encode(textBox1.Text);
      MessageBox.Show("Закодировано");

      FileInfo fi1 = new FileInfo(openFileDialog1.FileName);
      label5.Text = "Исходный файл " + fi1.Length.ToString() + " байт";
      byte[] array = new byte[68];

      byte[] chislo = new byte[2];
      int n = 0;
      bool zapisal = false;

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
        richTextBox3.Text += ("Символ: " + item.Key + "\tКоличество: " + item.Value.ToString() + "\tКод " + htree.codec1[item.Key].ToString() + "\n");
        i++;
      }
      foreach (bool bit in encoded) {
        richTextBox1.Text += ((bit ? 1 : 0).ToString() + " ");
      }

      int a = 0;
      if (encoded.Count % 8 != 0)
        a++;
      a += encoded.Count / 8;
      label6.Text = "Закодированный файл: " + a.ToString() + " байт";
      label7.Text = "Сжатие " + (Convert.ToDouble(fi1.Length) / Convert.ToDouble(a)).ToString() + " раз";
      ;
      byte[] my_ar = ToByteArray(encoded);
      byte[] b3 = array.Concat(my_ar).ToArray();
      File.WriteAllBytes("my_text.haff", b3);
    }

    Dictionary<char, int> kolichestvo_simvolov = new Dictionary<char, int>();
    public Node Root { get; set; }
    public int vsego_simvolov = 0;

    private void button2_Click(object sender, EventArgs e) {
      kolichestvo_simvolov.Clear();
      richTextBox2.Text = "";
      byte[] my_array = File.ReadAllBytes("my_text.haff");
      byte[] chislo = new byte[2];
      string alphabet = " абвгдеёжзийклмнопрстуфхцчщшъыьэюя";
      int n = 0;
      for (int j = 0; j < 34; j++) {
        char symbol = alphabet[j];
        chislo[0] = my_array[n++];
        chislo[1] = my_array[n++];
        Int16 a = BitConverter.ToInt16(chislo, 0);
        if (a > 0)
          kolichestvo_simvolov.Add(alphabet[j], Convert.ToInt32(a));
      }
      //далее нужно построить дерево по получившимся значениям частот, пользуясь алгоритмом выше build
      //посчитать сколько символов всего и, пока не набралось достаточное количество символов декодировать код начиная с 34 байта, переведя его в биты
      Build_for_decode(kolichestvo_simvolov);

      foreach (KeyValuePair<char, int> symbol in kolichestvo_simvolov) {
        vsego_simvolov += symbol.Value;
      }

      byte[] zakodirovannij_tekst = new byte[my_array.Count() - 68];

      Array.Copy(my_array, 68, zakodirovannij_tekst, 0, my_array.Count() - 68);

      BitArray decode = new BitArray(zakodirovannij_tekst);
      n = 0;
      for (int i = 0; i < zakodirovannij_tekst.Count(); i++) {
        byte[] one = new byte[1];
        one[0] = zakodirovannij_tekst[i];
        BitArray one_to_bit = new BitArray(one);
        string str = "";

        for (int j = 0; j < 8; j++)
          if (one_to_bit[j])
            str += "1";
          else
            str += "0";
        BitArray one_naoborot = new BitArray(8);
        int k = 0;
        for (int j = 7; j >= 0; j--)
          if (str[j] == '0')
            one_naoborot[k++] = false;
          else
            one_naoborot[k++] = true;
        for (int j = 0; j < 8; j++) {
          decode[n] = one_naoborot[j];
          n++;
        }
      }
      richTextBox2.Text += Decode(decode);
    }


    public List<Node> nodes = new List<Node>();


    public void Build_for_decode(Dictionary<char, int> Frequencies) {
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

        Root = nodes.FirstOrDefault();

      }

    }

    public string Decode(BitArray bits) {
      Node current = Root;
      string decoded = "";
      foreach (bool bit in bits) {
        if (bit) {
          if (current.Right != null && vsego_simvolov != 0) {
            current = current.Right;
          }
        } else {
          if (current.Left != null && vsego_simvolov != 0) {
            current = current.Left;
          }
        }
        if (IsLeaf(current) && vsego_simvolov != 0) {
          decoded += current.Symbol;
          current = Root;
          vsego_simvolov--;
        }
      }
      return decoded;
    }

    public bool IsLeaf(Node node) {
      return (node.Left == null && node.Right == null);
    }

    byte[] array;


    private void button3_Click(object sender, EventArgs e) {
      openFileDialog1.Filter = "dat files (*.dat)|*.dat";
      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        using (BinaryReader reader = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open))) {
          // пока не достигнут конец файла
          // считываем каждое значение из файла
          string my_text = "";
          while (reader.PeekChar() > -1) {
            byte chislo = reader.ReadByte();
            switch (chislo) {
              case 0: {
                my_text += " ";
              }
              break;
              case 1: {
                my_text += "а";
              }
              break;
              case 2: {
                my_text += "б";
              }

              break;

              case 3: {

                my_text += "в";

              }

              break;

              case 33: {

                my_text += "я";

              }

              break;
            }
          }
          textBox1.Text = my_text;
          reader.Close();
        }

        using (BinaryReader reader = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open))) {
          array = new byte[textBox1.Text.Length];
          int n = 0;
          while (reader.PeekChar() > -1) {
            byte chislo = reader.ReadByte();
            array[n] = chislo;
            n++;
          }
          reader.Close();
        }
      }
    }
  }
}