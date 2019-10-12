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

namespace laba2
{
    public partial class Form1 : Form
    {
        private string encodedText = null;
        private byte[] byteArray = null;
        private readonly HuffmanTree htree = new HuffmanTree();
        private BitArray encoded;


        public Form1()
        {
            InitializeComponent();
        }


        private void openFile_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                encode.Enabled = true;
                using (FileStream fstream = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    byteArray = new byte[fstream.Length];
                    fstream.Read(byteArray, 0, byteArray.Length);
                    ReadFileCustomEncoding(byteArray);
                }
            }
        }

        private void ReadFileCustomEncoding(byte[] arr)
        {
            string result = Encoding.Default.GetString(arr).ToLower();
            beginText.Text = result;
            encodedText = result;
        }


        private void encode_Click(object sender, System.EventArgs e)
        {
            aboutEncoding.Text = encodeTextBox.Text = string.Empty;


            htree.Build(encodedText);
            decode.Enabled = true;
            encoded = htree.Encode(encodedText);
            foreach (bool bit in encoded)
            {
                encodeTextBox.Text += bit ? 1 : 0;
            }

            FileInfo fi1 = new FileInfo(openFileDialog1.FileName);
            label5.Text = $"Исходный файл { fi1.Length } байт";

            //foreach (var item in htree.Frequencies)
            //{
            //    aboutEncoding.Text += $"Символ: { item.Key } Количество: { item.Value } Код { htree.codec1[item.Key] }\n";
            //}

            foreach (KeyValuePair<char, int> item in htree.Frequencies)
            {
                aboutEncoding.Text += ("Символ: " + item.Key + "   Количество: " + item.Value.ToString() + "   Код " + htree.codec1[item.Key].ToString() + "\n");
                //i++;
            }

            int a = 0;
            if (encoded.Count % 8 != 0)
                a++;
            a += encoded.Count / 8;
            label6.Text = $"Закодированный файл: { a } байт";
            label7.Text = $"Сжатие {Convert.ToDouble(fi1.Length) / a} раз";
        }

        private void decode_Click(object sender, System.EventArgs e)
        {
            decodeTextBox.Text = htree.Decode(encoded);
        }
    }
}
