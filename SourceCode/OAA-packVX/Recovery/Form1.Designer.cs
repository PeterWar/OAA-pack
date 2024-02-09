namespace FpackCompressor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkIncludeSubdirectories = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkDeleteOriginal = new System.Windows.Forms.CheckBox();
            this.chkFilterByKeyword = new System.Windows.Forms.CheckBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.rdoIncludeFiles = new System.Windows.Forms.RadioButton();
            this.rdoExcludeFiles = new System.Windows.Forms.RadioButton();
            this.chkHcompress = new System.Windows.Forms.CheckBox();
            this.chkIRAF = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select folder to compress";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(746, 132);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OAA-pack provides a GUI to advanced methods of compression and decompression of F" +
    "IT files.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select folder to decompress";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 194);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NASA fpack and funpack website:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 315);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(511, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "Disclaimer: This software is provided \'as-is\', without any express or implied war" +
    "ranty. In no event will the authors be held liable for any data loss or damages " +
    "arising from the use of this software.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(511, 56);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(546, 445);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(217, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " https://heasarc.gsfc.nasa.gov/fitsio/fpack/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkIncludeSubdirectories
            // 
            this.chkIncludeSubdirectories.AutoSize = true;
            this.chkIncludeSubdirectories.Location = new System.Drawing.Point(12, 40);
            this.chkIncludeSubdirectories.Name = "chkIncludeSubdirectories";
            this.chkIncludeSubdirectories.Size = new System.Drawing.Size(129, 17);
            this.chkIncludeSubdirectories.TabIndex = 8;
            this.chkIncludeSubdirectories.Text = "Include subdirectories";
            this.chkIncludeSubdirectories.UseVisualStyleBackColor = true;
            this.chkIncludeSubdirectories.CheckedChanged += new System.EventHandler(this.chkIncludeSubdirectories_CheckedChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(25, 445);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(182, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://www.observatorialbanya.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // chkDeleteOriginal
            // 
            this.chkDeleteOriginal.AutoSize = true;
            this.chkDeleteOriginal.Checked = true;
            this.chkDeleteOriginal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeleteOriginal.Location = new System.Drawing.Point(147, 40);
            this.chkDeleteOriginal.Name = "chkDeleteOriginal";
            this.chkDeleteOriginal.Size = new System.Drawing.Size(98, 17);
            this.chkDeleteOriginal.TabIndex = 10;
            this.chkDeleteOriginal.Text = "Delete originals";
            this.chkDeleteOriginal.UseVisualStyleBackColor = true;
            this.chkDeleteOriginal.CheckedChanged += new System.EventHandler(this.chkDeleteOriginal_CheckedChanged);
            // 
            // chkFilterByKeyword
            // 
            this.chkFilterByKeyword.AutoSize = true;
            this.chkFilterByKeyword.Location = new System.Drawing.Point(251, 40);
            this.chkFilterByKeyword.Name = "chkFilterByKeyword";
            this.chkFilterByKeyword.Size = new System.Drawing.Size(143, 17);
            this.chkFilterByKeyword.TabIndex = 11;
            this.chkFilterByKeyword.Text = "For filenames containing:";
            this.chkFilterByKeyword.UseVisualStyleBackColor = true;
            this.chkFilterByKeyword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Enabled = false;
            this.txtKeyword.Location = new System.Drawing.Point(395, 38);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(251, 20);
            this.txtKeyword.TabIndex = 12;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(641, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rdoIncludeFiles
            // 
            this.rdoIncludeFiles.AutoSize = true;
            this.rdoIncludeFiles.Enabled = false;
            this.rdoIncludeFiles.Location = new System.Drawing.Point(395, 64);
            this.rdoIncludeFiles.Name = "rdoIncludeFiles";
            this.rdoIncludeFiles.Size = new System.Drawing.Size(132, 17);
            this.rdoIncludeFiles.TabIndex = 16;
            this.rdoIncludeFiles.TabStop = true;
            this.rdoIncludeFiles.Text = "Run only for these files";
            this.rdoIncludeFiles.UseVisualStyleBackColor = true;
            this.rdoIncludeFiles.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoExcludeFiles
            // 
            this.rdoExcludeFiles.AutoSize = true;
            this.rdoExcludeFiles.Enabled = false;
            this.rdoExcludeFiles.Location = new System.Drawing.Point(533, 64);
            this.rdoExcludeFiles.Name = "rdoExcludeFiles";
            this.rdoExcludeFiles.Size = new System.Drawing.Size(113, 17);
            this.rdoExcludeFiles.TabIndex = 17;
            this.rdoExcludeFiles.TabStop = true;
            this.rdoExcludeFiles.Text = "Exclude these files";
            this.rdoExcludeFiles.UseVisualStyleBackColor = true;
            this.rdoExcludeFiles.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkHcompress
            // 
            this.chkHcompress.AutoSize = true;
            this.chkHcompress.Location = new System.Drawing.Point(251, 261);
            this.chkHcompress.Name = "chkHcompress";
            this.chkHcompress.Size = new System.Drawing.Size(80, 17);
            this.chkHcompress.TabIndex = 18;
            this.chkHcompress.Text = "HCompress";
            this.chkHcompress.UseVisualStyleBackColor = true;
            this.chkHcompress.CheckedChanged += new System.EventHandler(this.chkHcompress_CheckedChanged);
            // 
            // chkIRAF
            // 
            this.chkIRAF.AutoSize = true;
            this.chkIRAF.Location = new System.Drawing.Point(337, 261);
            this.chkIRAF.Name = "chkIRAF";
            this.chkIRAF.Size = new System.Drawing.Size(113, 17);
            this.chkIRAF.TabIndex = 19;
            this.chkIRAF.Text = "IRAF Compression";
            this.chkIRAF.UseVisualStyleBackColor = true;
            this.chkIRAF.CheckedChanged += new System.EventHandler(this.chkIRAF_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Advanced methods of compression:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(685, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Timeout for each operation";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 467);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkIRAF);
            this.Controls.Add(this.chkHcompress);
            this.Controls.Add(this.rdoExcludeFiles);
            this.Controls.Add(this.rdoIncludeFiles);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.chkFilterByKeyword);
            this.Controls.Add(this.chkDeleteOriginal);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.chkIncludeSubdirectories);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OAA-pack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label4;
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
