namespace OAApack
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            chkIncludeSubdirectories = new CheckBox();
            linkLabel2 = new LinkLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chkDeleteOriginal = new CheckBox();
            chkFilterByKeyword = new CheckBox();
            txtKeyword = new TextBox();
            btnStop = new Button();
            rdoIncludeFiles = new RadioButton();
            rdoExcludeFiles = new RadioButton();
            chkHcompress = new CheckBox();
            chkIRAF = new CheckBox();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 61);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(192, 27);
            button1.TabIndex = 0;
            button1.Text = "Seleccionar carpeta a comprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 93);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(758, 169);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(544, 15);
            label1.TabIndex = 1;
            label1.Text = "OAA-pack proporciona una GUI amb métodes avançats de compresió i descompresió d'arxius FIT.";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 61);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(203, 27);
            button2.TabIndex = 2;
            button2.Text = "Seleccionar carpeta a descomprimir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 265);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 197);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 461);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 4;
            label2.Text = "Web de NASA fpack i funpack:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(230, 351);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(550, 109);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(548, 461);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(232, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://heasarc.gsfc.nasa.gov/fitsio/fpack/";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // chkIncludeSubdirectories
            // 
            chkIncludeSubdirectories.AutoSize = true;
            chkIncludeSubdirectories.Location = new Point(14, 34);
            chkIncludeSubdirectories.Margin = new Padding(4, 3, 4, 3);
            chkIncludeSubdirectories.Name = "chkIncludeSubdirectories";
            chkIncludeSubdirectories.Size = new Size(140, 19);
            chkIncludeSubdirectories.TabIndex = 8;
            chkIncludeSubdirectories.Text = "Incloure subdirectoris";
            chkIncludeSubdirectories.UseVisualStyleBackColor = true;
            chkIncludeSubdirectories.CheckedChanged += chkIncludeSubdirectories_CheckedChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(18, 461);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(204, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://www.observatorialbanya.com";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // chkDeleteOriginal
            // 
            chkDeleteOriginal.AutoSize = true;
            chkDeleteOriginal.Checked = true;
            chkDeleteOriginal.CheckState = CheckState.Checked;
            chkDeleteOriginal.Location = new Point(159, 34);
            chkDeleteOriginal.Margin = new Padding(4, 3, 4, 3);
            chkDeleteOriginal.Name = "chkDeleteOriginal";
            chkDeleteOriginal.Size = new Size(117, 19);
            chkDeleteOriginal.TabIndex = 10;
            chkDeleteOriginal.Text = "Esborrar originals";
            chkDeleteOriginal.UseVisualStyleBackColor = true;
            chkDeleteOriginal.CheckedChanged += chkDeleteOriginal_CheckedChanged;
            // 
            // chkFilterByKeyword
            // 
            chkFilterByKeyword.AutoSize = true;
            chkFilterByKeyword.Location = new Point(289, 34);
            chkFilterByKeyword.Margin = new Padding(4, 3, 4, 3);
            chkFilterByKeyword.Name = "chkFilterByKeyword";
            chkFilterByKeyword.Size = new Size(176, 19);
            chkFilterByKeyword.TabIndex = 11;
            chkFilterByKeyword.Text = "Noms d'arxiu que contenen:";
            chkFilterByKeyword.UseVisualStyleBackColor = true;
            chkFilterByKeyword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtKeyword
            // 
            txtKeyword.Enabled = false;
            txtKeyword.Location = new Point(462, 33);
            txtKeyword.Margin = new Padding(4, 3, 4, 3);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(309, 23);
            txtKeyword.TabIndex = 12;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(665, 269);
            btnStop.Margin = new Padding(4, 3, 4, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(88, 27);
            btnStop.TabIndex = 13;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // rdoIncludeFiles
            // 
            rdoIncludeFiles.AutoSize = true;
            rdoIncludeFiles.Checked = true;
            rdoIncludeFiles.Enabled = false;
            rdoIncludeFiles.Location = new Point(430, 62);
            rdoIncludeFiles.Margin = new Padding(4, 3, 4, 3);
            rdoIncludeFiles.Name = "rdoIncludeFiles";
            rdoIncludeFiles.Size = new Size(206, 19);
            rdoIncludeFiles.TabIndex = 16;
            rdoIncludeFiles.TabStop = true;
            rdoIncludeFiles.Text = "Executar només per aquests arxius";
            rdoIncludeFiles.UseVisualStyleBackColor = true;
            rdoIncludeFiles.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdoExcludeFiles
            // 
            rdoExcludeFiles.AutoSize = true;
            rdoExcludeFiles.Enabled = false;
            rdoExcludeFiles.Location = new Point(634, 62);
            rdoExcludeFiles.Margin = new Padding(4, 3, 4, 3);
            rdoExcludeFiles.Name = "rdoExcludeFiles";
            rdoExcludeFiles.Size = new Size(147, 19);
            rdoExcludeFiles.TabIndex = 17;
            rdoExcludeFiles.Text = "Excloure aquests arxius";
            rdoExcludeFiles.UseVisualStyleBackColor = true;
            rdoExcludeFiles.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkHcompress
            // 
            chkHcompress.AutoSize = true;
            chkHcompress.Location = new Point(232, 290);
            chkHcompress.Margin = new Padding(4, 3, 4, 3);
            chkHcompress.Name = "chkHcompress";
            chkHcompress.Size = new Size(88, 19);
            chkHcompress.TabIndex = 18;
            chkHcompress.Text = "HCompress";
            chkHcompress.UseVisualStyleBackColor = true;
            chkHcompress.CheckedChanged += chkHcompress_CheckedChanged;
            // 
            // chkIRAF
            // 
            chkIRAF.AutoSize = true;
            chkIRAF.Location = new Point(332, 290);
            chkIRAF.Margin = new Padding(4, 3, 4, 3);
            chkIRAF.Name = "chkIRAF";
            chkIRAF.Size = new Size(50, 19);
            chkIRAF.TabIndex = 19;
            chkIRAF.Text = "IRAF";
            chkIRAF.UseVisualStyleBackColor = true;
            chkIRAF.CheckedChanged += chkIRAF_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(228, 270);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(185, 15);
            label5.TabIndex = 20;
            label5.Text = "Mètodes avançats de compresió";
            label5.Click += label5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(704, 314);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 23);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 317);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 15);
            label6.TabIndex = 22;
            label6.Text = "Timeout per cada operació:";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 481);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(chkIRAF);
            Controls.Add(chkHcompress);
            Controls.Add(rdoExcludeFiles);
            Controls.Add(rdoIncludeFiles);
            Controls.Add(btnStop);
            Controls.Add(txtKeyword);
            Controls.Add(chkFilterByKeyword);
            Controls.Add(chkDeleteOriginal);
            Controls.Add(linkLabel2);
            Controls.Add(chkIncludeSubdirectories);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "OAA-pack";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkIncludeSubdirectories;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkDeleteOriginal;
        private System.Windows.Forms.CheckBox chkFilterByKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rdoIncludeFiles;
        private System.Windows.Forms.RadioButton rdoExcludeFiles;
        private System.Windows.Forms.CheckBox chkHcompress;
        private System.Windows.Forms.CheckBox chkIRAF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}
