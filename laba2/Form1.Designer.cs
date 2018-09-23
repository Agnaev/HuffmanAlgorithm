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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.analiz = new System.Windows.Forms.Button();
      this.readFile = new System.Windows.Forms.Button();
      this.openFile = new System.Windows.Forms.Button();
      this.beginText = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.infoBox = new System.Windows.Forms.TextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.decodeTextBox = new System.Windows.Forms.TextBox();
      this.encodeTextBox = new System.Windows.Forms.TextBox();
      this.encode = new System.Windows.Forms.Button();
      this.decode = new System.Windows.Forms.Button();
      this.buldTree = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.groupBox4);
      this.groupBox1.Controls.Add(this.groupBox3);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(984, 705);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Дерево Хафмана";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.analiz);
      this.groupBox3.Controls.Add(this.readFile);
      this.groupBox3.Controls.Add(this.openFile);
      this.groupBox3.Controls.Add(this.beginText);
      this.groupBox3.Location = new System.Drawing.Point(12, 19);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(360, 585);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Входные данные";
      // 
      // analiz
      // 
      this.analiz.Location = new System.Drawing.Point(251, 19);
      this.analiz.Name = "analiz";
      this.analiz.Size = new System.Drawing.Size(103, 23);
      this.analiz.TabIndex = 5;
      this.analiz.Text = "Анализ";
      this.analiz.UseVisualStyleBackColor = true;
      this.analiz.Click += new System.EventHandler(this.analiz_Click);
      // 
      // readFile
      // 
      this.readFile.Location = new System.Drawing.Point(112, 19);
      this.readFile.Name = "readFile";
      this.readFile.Size = new System.Drawing.Size(133, 23);
      this.readFile.TabIndex = 4;
      this.readFile.Text = "Считать содержимое";
      this.readFile.UseVisualStyleBackColor = true;
      this.readFile.Click += new System.EventHandler(this.readFile_Click);
      // 
      // openFile
      // 
      this.openFile.Location = new System.Drawing.Point(6, 19);
      this.openFile.Name = "openFile";
      this.openFile.Size = new System.Drawing.Size(100, 23);
      this.openFile.TabIndex = 3;
      this.openFile.Text = "Открыть файл";
      this.openFile.UseVisualStyleBackColor = true;
      this.openFile.Click += new System.EventHandler(this.openFile_Click);
      // 
      // beginText
      // 
      this.beginText.Location = new System.Drawing.Point(6, 48);
      this.beginText.Multiline = true;
      this.beginText.Name = "beginText";
      this.beginText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.beginText.Size = new System.Drawing.Size(348, 531);
      this.beginText.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.infoBox);
      this.groupBox2.Location = new System.Drawing.Point(6, 610);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(972, 89);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Информация";
      // 
      // infoBox
      // 
      this.infoBox.Enabled = false;
      this.infoBox.Location = new System.Drawing.Point(6, 16);
      this.infoBox.Multiline = true;
      this.infoBox.Name = "infoBox";
      this.infoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.infoBox.Size = new System.Drawing.Size(960, 67);
      this.infoBox.TabIndex = 0;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.buldTree);
      this.groupBox4.Controls.Add(this.decode);
      this.groupBox4.Controls.Add(this.encode);
      this.groupBox4.Controls.Add(this.encodeTextBox);
      this.groupBox4.Controls.Add(this.decodeTextBox);
      this.groupBox4.Location = new System.Drawing.Point(527, 19);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(451, 585);
      this.groupBox4.TabIndex = 3;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Выходные данные";
      // 
      // decodeTextBox
      // 
      this.decodeTextBox.Enabled = false;
      this.decodeTextBox.Location = new System.Drawing.Point(6, 311);
      this.decodeTextBox.Multiline = true;
      this.decodeTextBox.Name = "decodeTextBox";
      this.decodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.decodeTextBox.Size = new System.Drawing.Size(439, 268);
      this.decodeTextBox.TabIndex = 0;
      // 
      // encodeTextBox
      // 
      this.encodeTextBox.Enabled = false;
      this.encodeTextBox.Location = new System.Drawing.Point(6, 48);
      this.encodeTextBox.Multiline = true;
      this.encodeTextBox.Name = "encodeTextBox";
      this.encodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.encodeTextBox.Size = new System.Drawing.Size(439, 218);
      this.encodeTextBox.TabIndex = 1;
      // 
      // encode
      // 
      this.encode.Enabled = false;
      this.encode.Location = new System.Drawing.Point(111, 19);
      this.encode.Name = "encode";
      this.encode.Size = new System.Drawing.Size(88, 23);
      this.encode.TabIndex = 2;
      this.encode.Text = "Закодировать";
      this.encode.UseVisualStyleBackColor = true;
      this.encode.Click += new System.EventHandler(this.encode_Click);
      // 
      // decode
      // 
      this.decode.Enabled = false;
      this.decode.Location = new System.Drawing.Point(6, 282);
      this.decode.Name = "decode";
      this.decode.Size = new System.Drawing.Size(88, 23);
      this.decode.TabIndex = 3;
      this.decode.Text = "Декодировать";
      this.decode.UseVisualStyleBackColor = true;
      this.decode.Click += new System.EventHandler(this.decode_Click);
      // 
      // buldTree
      // 
      this.buldTree.Location = new System.Drawing.Point(6, 19);
      this.buldTree.Name = "buldTree";
      this.buldTree.Size = new System.Drawing.Size(99, 23);
      this.buldTree.TabIndex = 4;
      this.buldTree.Text = "Строить дерево";
      this.buldTree.UseVisualStyleBackColor = true;
      this.buldTree.Click += new System.EventHandler(this.buldTree_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.groupBox1);
      this.MaximumSize = new System.Drawing.Size(1024, 768);
      this.MinimumSize = new System.Drawing.Size(1024, 768);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox infoBox;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button openFile;
    private System.Windows.Forms.TextBox beginText;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Button readFile;
    private System.Windows.Forms.Button analiz;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button decode;
    private System.Windows.Forms.Button encode;
    private System.Windows.Forms.TextBox encodeTextBox;
    private System.Windows.Forms.TextBox decodeTextBox;
    private System.Windows.Forms.Button buldTree;
  }
}

