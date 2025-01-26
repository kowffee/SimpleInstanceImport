using System.IO.Compression;

namespace SII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        private static string zipFilePathToImport = string.Empty;
        private static string instancePath = string.Empty;
        #endregion

        #region Functions
        private static string SelectZipFile()
        {
            string selectedFilePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filters
                openFileDialog.Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*";
                openFileDialog.Title = "Select a ZIP File";
                openFileDialog.RestoreDirectory = true;

                // Show the dialog and check the result
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    selectedFilePath = openFileDialog.FileName;
            }

            return selectedFilePath;
        }

        private void Log(string text)
        {
            loggingBox.AppendText(text + Environment.NewLine);
        }
        #endregion


        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            string zipFilePath = SelectZipFile();
            if (string.IsNullOrEmpty(zipFilePath))
            {
                Log($"[Error] Zip path null or empty (got: {zipFilePath})");
                return;
            }

            zipFilePathToImport = zipFilePath;
            zipPathBox.Text = zipFilePath;
            Log($"[Success] Found {zipFilePath}");
        }

        private async void importBtn_Click(object sender, EventArgs e)
        {
            importBtn.Enabled = false;
            if (string.IsNullOrEmpty(zipFilePathToImport))
            {
                Log($"[Info] zipFilePathToImport is empty or null");
                MessageBox.Show("Please select a zip file first to import.");
                return;
            }
            if (string.IsNullOrEmpty(instancePath))
            {
                Log($"[Info] instancePath is empty or null");
                MessageBox.Show("Please select an instance path first to import.");
                return;
            }

            try
            {
                Log("[Info] Extracting, please wait.");
                await Task.Run(() =>
                {
                    ZipFile.ExtractToDirectory(zipFilePathToImport, instancePath, overwriteFiles: true);
                });
                Log($"[Success] Extracted {zipFilePathToImport} to {instancePath}");
            }
            catch (Exception ex)
            {
                importBtn.Enabled = true;
                Log($"[Error] {ex.Message}{Environment.NewLine}");
                MessageBox.Show($"Error during extraction: {ex.Message}");
            }
            importBtn.Enabled = true;
        }

        private void zipPathBox_TextChanged(object sender, EventArgs e)
        {
            zipFilePathToImport = zipPathBox.Text;
            Log($"[Info] zipFilePathToImport changed to {zipPathBox.Text}");
        }

        private void instPathBox_TextChanged(object sender, EventArgs e)
        {
            instancePath = instPathBox.Text;
            Log($"[Info] instancePath changed to {instPathBox.Text}");
        }
    }
}
