using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace OAApack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "OAA-pack";
            toolTip1.SetToolTip(this.chkIncludeSubdirectories, "Executar l'operació de manera recursiva al directori seleccionat i els seus subdirectoris");
            toolTip1.SetToolTip(this.chkDeleteOriginal, "Eliminar els arxius originals després de realitzar les operacions..");
            toolTip1.SetToolTip(this.chkHcompress, "Hcompress produeix una compressió lleugerament millor que el mètode predeterminat Rice (aproximadament un 3% menor),\n però per a la majoria d'aplicacions, aquest petit guany no compensa els temps de CPU molt majors (aproximadament 3X)\nnecessaris per a comprimir i descomprimir les imatges amb Hcompress.");
            toolTip1.SetToolTip(this.chkIRAF, "Habilitar l'algoritme de compressió de llista de píxels d'IRAF.\nNomés es pot aplicar a imatges els valors de píxels dels quals estiguin en l'interval de 0 a 224 (16777216).");
            toolTip1.SetToolTip(this.numericUpDown1, "Especificar quant de temps esperar (en segons) abans d'abortar cada operació de compressió/descompressió.\nValors més baixos podrien conduir a comportaments no desitjats");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fpackPath = Path.Combine(appDirectory, "Tools", "fpack.exe");

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox1.AppendText("Processing compression operation...\r\n");
                    var args = new Tuple<string, string, SearchOption, bool>(
                        folderBrowser.SelectedPath,
                        fpackPath,
                        chkIncludeSubdirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly,
                        chkDeleteOriginal.Checked); // Include the state of the checkbox

                    backgroundWorker1.RunWorkerAsync(args);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string funpackPath = Path.Combine(appDirectory, "Tools", "funpack.exe");

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox1.AppendText("Processing decompression operation...\r\n");
                    var args = new Tuple<string, string, SearchOption, bool>(
                    folderBrowser.SelectedPath,
                    funpackPath,
                    chkIncludeSubdirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly,
                    chkDeleteOriginal.Checked); // Include the state of the checkbox
                    backgroundWorker1.RunWorkerAsync(args);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // NASA FPACK AND FUNPACK URL
            string url = "https://heasarc.gsfc.nasa.gov/fitsio/fpack/";

            // Open the URL in the default browser
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            rdoIncludeFiles.Enabled = false;
            rdoExcludeFiles.Enabled = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Link to Observatori Albanyà
            string url = "https://www.observatorialbanya.com";

            // Open the URL in the default browser
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            textBox1.AppendText($"{e.UserState.ToString()}: {e.ProgressPercentage}% completed.\r\n");


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                MessageBox.Show($"An error occurred: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                textBox1.AppendText("Operation cancelled.\r\n");
            }
            else
            {
                textBox1.AppendText("Operation completed successfully.\r\n");
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            // Enable/Disable the text box based on the checkbox state
            txtKeyword.Enabled = chkFilterByKeyword.Checked;

            // Enable the radio buttons if the checkbox is checked, otherwise disable them
            rdoIncludeFiles.Enabled = chkFilterByKeyword.Checked;
            rdoExcludeFiles.Enabled = chkFilterByKeyword.Checked;

            // Optionally, reset radio buttons when the checkbox is unchecked
            if (!chkFilterByKeyword.Checked)
            {
                rdoIncludeFiles.Checked = false;
                rdoExcludeFiles.Checked = false;
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var arguments = e.Argument as Tuple<string, string, SearchOption, bool>;
            string path = arguments.Item1;
            string executablePath = arguments.Item2;
            SearchOption searchOption = arguments.Item3;
            bool deleteOriginal = arguments.Item4;
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            int timeout = (int)numericUpDown1.Value * 1000; // Convert to milliseconds

            bool includeFiles = false;
            string keyword = "";
            bool useHcompress = false;
            bool useIRAF = false;
            bool filterByKeyword = false;
            bool isCompression = executablePath.Contains("fpack");

            this.Invoke((System.Windows.Forms.MethodInvoker)delegate
            {
                keyword = chkFilterByKeyword.Checked ? txtKeyword.Text : "";
                filterByKeyword = chkFilterByKeyword.Checked;
                includeFiles = rdoIncludeFiles.Checked;
                useHcompress = chkHcompress.Checked && isCompression;
                useIRAF = chkIRAF.Checked && isCompression;
            });

            string[] files;
            if (isCompression)
            {
                files = Directory.GetFiles(path, "*.*", searchOption)
                                 .Where(file => (Path.GetExtension(file).Equals(".FIT", StringComparison.OrdinalIgnoreCase) ||
                                                 Path.GetExtension(file).Equals(".FITS", StringComparison.OrdinalIgnoreCase)) &&
                                                (!filterByKeyword ||
                                                 (includeFiles && (string.IsNullOrEmpty(keyword) || file.Contains(keyword))) ||
                                                 (!includeFiles && (string.IsNullOrEmpty(keyword) || !file.Contains(keyword)))))
                                 .ToArray();
            }
            else
            {
                files = Directory.GetFiles(path, "*.fz", searchOption)
                                 .Where(file => (!filterByKeyword ||
                                                 (includeFiles && (string.IsNullOrEmpty(keyword) || file.Contains(keyword))) ||
                                                 (!includeFiles && (string.IsNullOrEmpty(keyword) || !file.Contains(keyword)))))
                                 .ToArray();
            }
            int fileCount = files.Length;

            for (int i = 0; i < fileCount; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                string file = files[i];
                string compressionOption = "";
                if (useHcompress)
                {
                    compressionOption = "-h ";
                }
                else if (useIRAF)
                {
                    compressionOption = "-p ";
                }
                string deleteOption = deleteOriginal ? "-D " : "";
                string commandArguments = $"{compressionOption}{deleteOption}\"{file}\"";

                bool success = TryProcessFileAsync(executablePath, commandArguments, timeout, appDirectory, isCompression, chkDeleteOriginal.Checked).GetAwaiter().GetResult();
                if (!success)
                {
                    this.Invoke((System.Windows.Forms.MethodInvoker)delegate {
                        textBox1.AppendText($"Skipping file due to timeout: {file}\r\n");
                    });
                    continue; // Skip to the next file
                }

                backgroundWorker1.ReportProgress(((i + 1) * 100) / fileCount, file);
            }
        }

        private async Task<bool> TryProcessFileAsync(string executablePath, string arguments, int timeoutMilliseconds, string appDirectory, bool isCompression, bool deleteOriginal)
        {
            string originalFilePath = GetFilePathFromArguments(arguments);
            string fzFilePath = originalFilePath + ".fz";
            string gzipFilePath = originalFilePath + ".gz";

            try
            {
                //textBox1.AppendText($"Processing: {originalFilePath}\r\n");
                bool processResult = await RunProcessWithTimeout(executablePath, arguments, timeoutMilliseconds);
                if (!processResult && isCompression)
                {
                    // Retry with gzip for compression only
                    textBox1.AppendText("Retrying compression operation with gzip....\r\n");
                    string gzipExecutablePath = Path.Combine(appDirectory, "Tools", "gzip.exe");
                    string gzipArguments = $"\"{originalFilePath}\"";
                    bool gzipResult = await RunProcessWithTimeout(gzipExecutablePath, gzipArguments, timeoutMilliseconds);

                    if (gzipResult && deleteOriginal)
                    {
                        // Delete the .fz file if gzip compression was successful
                        DeleteFileIfExists(fzFilePath);
                    }

                    return gzipResult;
                }

                if (deleteOriginal && !isCompression)
                {
                    // Delete the .fz file if decompression was successful
                    DeleteFileIfExists(fzFilePath);
                }

                return processResult;
            }
            catch (Exception ex)
            {
                this.Invoke((System.Windows.Forms.MethodInvoker)delegate {
                    textBox1.AppendText($"Error processing file {originalFilePath}: {ex.Message}\r\n");
                });
                return false;
            }
        }




        private async Task<bool> RunProcessWithTimeout(string executablePath, string arguments, int timeoutMilliseconds)
        {
            using (var proc = new Process())
            {
                proc.StartInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                proc.Start();
                var waitForExitTask = Task.Run(() => proc.WaitForExit());
                var delayTask = Task.Delay(timeoutMilliseconds);

                var completedTask = await Task.WhenAny(waitForExitTask, delayTask);
                if (completedTask == delayTask && !proc.HasExited)
                {
                    proc.Kill();
                    this.Invoke((System.Windows.Forms.MethodInvoker)delegate { textBox1.AppendText("Process killed due to timeout.\r\n"); });
                    return false;
                }

                return proc.ExitCode == 0;
            }
        }
        private void DeleteFileIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    this.Invoke((System.Windows.Forms.MethodInvoker)delegate { textBox1.AppendText($"{filePath} deleted.\r\n"); });
                }
                catch (Exception ex)
                {
                    this.Invoke((System.Windows.Forms.MethodInvoker)delegate { textBox1.AppendText($"Failed to delete {filePath}: {ex.Message}\r\n"); });
                }
            }
        }
        private string GetFilePathFromArguments(string arguments)
        {
            // Extracts the file path from the arguments, assuming the format is "-D "filePath"" or ""filePath""
            var match = System.Text.RegularExpressions.Regex.Match(arguments, "\"([^\"]+)\"");
            return match.Success ? match.Groups[1].Value : string.Empty;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chkIRAF_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIRAF.Checked)
            {
                chkHcompress.Checked = false;
            }
        }

        private void chkHcompress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHcompress.Checked)
            {
                chkIRAF.Checked = false;
            }
        }

        private void chkIncludeSubdirectories_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDeleteOriginal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}