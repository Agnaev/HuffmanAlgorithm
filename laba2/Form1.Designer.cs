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
      this.readFile = new System.Windows.Forms.Button();
      this.openFile = new System.Windows.Forms.Button();
      this.beginText = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.infoBox = new System.Windows.Forms.TextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
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
      // readFile
      // 
      this.readFile.Location = new System.Drawing.Point(163, 19);
      this.readFile.Name = "readFile";
      this.readFile.Size = new System.Drawing.Size(133, 23);
      this.readFile.TabIndex = 4;
      this.readFile.Text = "Считать содержимое";
      this.readFile.UseVisualStyleBackColor = true;
      this.readFile.Click += new System.EventHandler(this.readFile_Click);
      // 
      // openFile
      // 
      this.openFile.Location = new System.Drawing.Point(57, 19);
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
  }
}

