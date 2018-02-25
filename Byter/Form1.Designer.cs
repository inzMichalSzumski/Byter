namespace Byter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathLabel1 = new System.Windows.Forms.Label();
            this.fileExtensionLabel1 = new System.Windows.Forms.Label();
            this.bytesString1 = new System.Windows.Forms.Label();
            this.bytesStringrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fileExtensionTextBox1 = new System.Windows.Forms.TextBox();
            this.pathTextBox1 = new System.Windows.Forms.TextBox();
            this.bytesString2 = new System.Windows.Forms.Label();
            this.bytesStringrichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.startButton1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathLabel1
            // 
            this.pathLabel1.AutoSize = true;
            this.pathLabel1.Location = new System.Drawing.Point(112, 66);
            this.pathLabel1.Name = "pathLabel1";
            this.pathLabel1.Size = new System.Drawing.Size(107, 13);
            this.pathLabel1.TabIndex = 0;
            this.pathLabel1.Text = "Ścieżka do katalogu:";
            // 
            // fileExtensionLabel1
            // 
            this.fileExtensionLabel1.AutoSize = true;
            this.fileExtensionLabel1.Location = new System.Drawing.Point(121, 96);
            this.fileExtensionLabel1.Name = "fileExtensionLabel1";
            this.fileExtensionLabel1.Size = new System.Drawing.Size(98, 13);
            this.fileExtensionLabel1.TabIndex = 1;
            this.fileExtensionLabel1.Text = "Rozszerzenie pliku:";
            // 
            // bytesString1
            // 
            this.bytesString1.AutoSize = true;
            this.bytesString1.Location = new System.Drawing.Point(31, 127);
            this.bytesString1.Name = "bytesString1";
            this.bytesString1.Size = new System.Drawing.Size(188, 13);
            this.bytesString1.TabIndex = 2;
            this.bytesString1.Text = "Wyszukiwany ciąg bajtów do zamiany:";
            // 
            // bytesStringrichTextBox1
            // 
            this.bytesStringrichTextBox1.Location = new System.Drawing.Point(295, 127);
            this.bytesStringrichTextBox1.Name = "bytesStringrichTextBox1";
            this.bytesStringrichTextBox1.Size = new System.Drawing.Size(444, 179);
            this.bytesStringrichTextBox1.TabIndex = 3;
            this.bytesStringrichTextBox1.Text = "";
            // 
            // fileExtensionTextBox1
            // 
            this.fileExtensionTextBox1.Location = new System.Drawing.Point(295, 96);
            this.fileExtensionTextBox1.Name = "fileExtensionTextBox1";
            this.fileExtensionTextBox1.Size = new System.Drawing.Size(444, 20);
            this.fileExtensionTextBox1.TabIndex = 4;
            // 
            // pathTextBox1
            // 
            this.pathTextBox1.Location = new System.Drawing.Point(295, 63);
            this.pathTextBox1.Name = "pathTextBox1";
            this.pathTextBox1.Size = new System.Drawing.Size(444, 20);
            this.pathTextBox1.TabIndex = 5;
            this.pathTextBox1.Text = "C:\\Drivers";
            this.pathTextBox1.DoubleClick += new System.EventHandler(this.pathTextBox1_DoubleClick);
            // 
            // bytesString2
            // 
            this.bytesString2.AutoSize = true;
            this.bytesString2.Location = new System.Drawing.Point(35, 350);
            this.bytesString2.Name = "bytesString2";
            this.bytesString2.Size = new System.Drawing.Size(187, 13);
            this.bytesString2.TabIndex = 6;
            this.bytesString2.Text = "Ciąg bajtów, na które należy zamienić:";
            // 
            // bytesStringrichTextBox2
            // 
            this.bytesStringrichTextBox2.Location = new System.Drawing.Point(295, 347);
            this.bytesStringrichTextBox2.Name = "bytesStringrichTextBox2";
            this.bytesStringrichTextBox2.Size = new System.Drawing.Size(444, 179);
            this.bytesStringrichTextBox2.TabIndex = 7;
            this.bytesStringrichTextBox2.Text = "";
            // 
            // startButton1
            // 
            this.startButton1.Location = new System.Drawing.Point(520, 617);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(219, 23);
            this.startButton1.TabIndex = 8;
            this.startButton1.Text = "Start";
            this.startButton1.UseVisualStyleBackColor = true;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(295, 565);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // progressLabel1
            // 
            this.progressLabel1.AutoSize = true;
            this.progressLabel1.Location = new System.Drawing.Point(176, 565);
            this.progressLabel1.Name = "progressLabel1";
            this.progressLabel1.Size = new System.Drawing.Size(43, 13);
            this.progressLabel1.TabIndex = 10;
            this.progressLabel1.Text = "Postęp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 652);
            this.Controls.Add(this.progressLabel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.bytesStringrichTextBox2);
            this.Controls.Add(this.bytesString2);
            this.Controls.Add(this.pathTextBox1);
            this.Controls.Add(this.fileExtensionTextBox1);
            this.Controls.Add(this.bytesStringrichTextBox1);
            this.Controls.Add(this.bytesString1);
            this.Controls.Add(this.fileExtensionLabel1);
            this.Controls.Add(this.pathLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel1;
        private System.Windows.Forms.Label fileExtensionLabel1;
        private System.Windows.Forms.Label bytesString1;
        private System.Windows.Forms.RichTextBox bytesStringrichTextBox1;
        private System.Windows.Forms.TextBox fileExtensionTextBox1;
        private System.Windows.Forms.TextBox pathTextBox1;
        private System.Windows.Forms.Label bytesString2;
        private System.Windows.Forms.RichTextBox bytesStringrichTextBox2;
        private System.Windows.Forms.Button startButton1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressLabel1;
    }
}

