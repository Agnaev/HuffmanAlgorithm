namespace laba2 {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.beginText = new System.Windows.Forms.TextBox();
            this.decode = new System.Windows.Forms.Button();
            this.aboutEncoding = new System.Windows.Forms.RichTextBox();
            this.encode = new System.Windows.Forms.Button();
            this.encodeTextBox = new System.Windows.Forms.TextBox();
            this.decodeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(205, 23);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "Open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // beginText
            // 
            this.beginText.Location = new System.Drawing.Point(12, 62);
            this.beginText.Multiline = true;
            this.beginText.Name = "beginText";
            this.beginText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.beginText.Size = new System.Drawing.Size(671, 135);
            this.beginText.TabIndex = 0;
            // 
            // decode
            // 
            this.decode.Enabled = false;
            this.decode.Location = new System.Drawing.Point(470, 12);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(213, 23);
            this.decode.TabIndex = 3;
            this.decode.Text = "Decoding";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // aboutEncoding
            // 
            this.aboutEncoding.Location = new System.Drawing.Point(689, 62);
            this.aboutEncoding.Name = "aboutEncoding";
            this.aboutEncoding.Size = new System.Drawing.Size(307, 311);
            this.aboutEncoding.TabIndex = 1;
            this.aboutEncoding.Text = "";
            // 
            // encode
            // 
            this.encode.Enabled = false;
            this.encode.Location = new System.Drawing.Point(223, 12);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(241, 23);
            this.encode.TabIndex = 2;
            this.encode.Text = "Encoding";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // encodeTextBox
            // 
            this.encodeTextBox.Enabled = false;
            this.encodeTextBox.Location = new System.Drawing.Point(12, 230);
            this.encodeTextBox.Multiline = true;
            this.encodeTextBox.Name = "encodeTextBox";
            this.encodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encodeTextBox.Size = new System.Drawing.Size(671, 143);
            this.encodeTextBox.TabIndex = 1;
            // 
            // decodeTextBox
            // 
            this.decodeTextBox.Enabled = false;
            this.decodeTextBox.Location = new System.Drawing.Point(247, 400);
            this.decodeTextBox.Multiline = true;
            this.decodeTextBox.Name = "decodeTextBox";
            this.decodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decodeTextBox.Size = new System.Drawing.Size(749, 147);
            this.decodeTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Compression: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Encoding file size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Original file size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(689, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Huffman tree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Original file content: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encoding file content:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(247, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Decoding file content";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutEncoding);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.decodeTextBox);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.encodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.beginText);
            this.Controls.Add(this.openFile);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 2";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox beginText;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.TextBox encodeTextBox;
        private System.Windows.Forms.TextBox decodeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox aboutEncoding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

