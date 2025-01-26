namespace SII
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            instPathBox = new TextBox();
            instPathLabel = new Label();
            instPathExample = new Label();
            pathToZipExample = new Label();
            pathToZipLabel = new Label();
            zipPathBox = new TextBox();
            importBtn = new Button();
            loggingBox = new RichTextBox();
            logsLabel = new Label();
            selectFileBtn = new Button();
            SuspendLayout();
            // 
            // instPathBox
            // 
            instPathBox.BackColor = Color.FromArgb(40, 40, 40);
            instPathBox.BorderStyle = BorderStyle.None;
            instPathBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instPathBox.ForeColor = Color.Silver;
            instPathBox.Location = new Point(23, 61);
            instPathBox.Name = "instPathBox";
            instPathBox.Size = new Size(766, 22);
            instPathBox.TabIndex = 1;
            instPathBox.TextChanged += instPathBox_TextChanged;
            // 
            // instPathLabel
            // 
            instPathLabel.AutoSize = true;
            instPathLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instPathLabel.Location = new Point(23, 37);
            instPathLabel.Name = "instPathLabel";
            instPathLabel.Size = new Size(119, 21);
            instPathLabel.TabIndex = 2;
            instPathLabel.Text = "Path to Instance";
            // 
            // instPathExample
            // 
            instPathExample.AutoSize = true;
            instPathExample.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instPathExample.ForeColor = Color.Silver;
            instPathExample.Location = new Point(148, 41);
            instPathExample.Name = "instPathExample";
            instPathExample.Size = new Size(641, 17);
            instPathExample.TabIndex = 3;
            instPathExample.Text = "(Example: C:\\Users\\YOURUSER\\AppData\\Roaming\\gdlauncher_carbon\\data\\instances\\ModdedSurv\\instance)";
            // 
            // pathToZipExample
            // 
            pathToZipExample.AutoSize = true;
            pathToZipExample.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathToZipExample.ForeColor = Color.Silver;
            pathToZipExample.Location = new Point(148, 115);
            pathToZipExample.Name = "pathToZipExample";
            pathToZipExample.Size = new Size(373, 17);
            pathToZipExample.TabIndex = 6;
            pathToZipExample.Text = "(Example: C:\\Users\\YOURUSER\\Downloads\\InstanceBackup.zip)";
            // 
            // pathToZipLabel
            // 
            pathToZipLabel.AutoSize = true;
            pathToZipLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathToZipLabel.Location = new Point(23, 111);
            pathToZipLabel.Name = "pathToZipLabel";
            pathToZipLabel.Size = new Size(84, 21);
            pathToZipLabel.TabIndex = 5;
            pathToZipLabel.Text = "Path to Zip";
            // 
            // zipPathBox
            // 
            zipPathBox.BackColor = Color.FromArgb(40, 40, 40);
            zipPathBox.BorderStyle = BorderStyle.None;
            zipPathBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zipPathBox.ForeColor = Color.Silver;
            zipPathBox.Location = new Point(23, 135);
            zipPathBox.Name = "zipPathBox";
            zipPathBox.Size = new Size(669, 22);
            zipPathBox.TabIndex = 4;
            zipPathBox.TextChanged += zipPathBox_TextChanged;
            // 
            // importBtn
            // 
            importBtn.AutoSize = true;
            importBtn.FlatAppearance.BorderColor = Color.Silver;
            importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 40, 40, 40);
            importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 50, 50, 50);
            importBtn.FlatStyle = FlatStyle.Flat;
            importBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importBtn.Location = new Point(369, 221);
            importBtn.Name = "importBtn";
            importBtn.Size = new Size(75, 33);
            importBtn.TabIndex = 7;
            importBtn.Text = "Import";
            importBtn.UseVisualStyleBackColor = true;
            importBtn.Click += importBtn_Click;
            // 
            // loggingBox
            // 
            loggingBox.BackColor = Color.FromArgb(40, 40, 40);
            loggingBox.BorderStyle = BorderStyle.None;
            loggingBox.ForeColor = Color.WhiteSmoke;
            loggingBox.Location = new Point(23, 318);
            loggingBox.Name = "loggingBox";
            loggingBox.Size = new Size(766, 96);
            loggingBox.TabIndex = 8;
            loggingBox.Text = "";
            // 
            // logsLabel
            // 
            logsLabel.AutoSize = true;
            logsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logsLabel.Location = new Point(23, 294);
            logsLabel.Name = "logsLabel";
            logsLabel.Size = new Size(43, 21);
            logsLabel.TabIndex = 9;
            logsLabel.Text = "Logs";
            // 
            // selectFileBtn
            // 
            selectFileBtn.AutoSize = true;
            selectFileBtn.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            selectFileBtn.FlatAppearance.BorderSize = 2;
            selectFileBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 40, 40, 40);
            selectFileBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 50, 50, 50);
            selectFileBtn.FlatStyle = FlatStyle.Flat;
            selectFileBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectFileBtn.Location = new Point(698, 129);
            selectFileBtn.Name = "selectFileBtn";
            selectFileBtn.Size = new Size(93, 35);
            selectFileBtn.TabIndex = 10;
            selectFileBtn.Text = "Select File";
            selectFileBtn.UseVisualStyleBackColor = true;
            selectFileBtn.Click += selectFileBtn_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(812, 450);
            Controls.Add(selectFileBtn);
            Controls.Add(logsLabel);
            Controls.Add(loggingBox);
            Controls.Add(importBtn);
            Controls.Add(pathToZipExample);
            Controls.Add(pathToZipLabel);
            Controls.Add(zipPathBox);
            Controls.Add(instPathExample);
            Controls.Add(instPathLabel);
            Controls.Add(instPathBox);
            ForeColor = Color.WhiteSmoke;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SII";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox instPathBox;
        private Label instPathLabel;
        private Label instPathExample;
        private Label pathToZipExample;
        private Label pathToZipLabel;
        private TextBox zipPathBox;
        private Button importBtn;
        private RichTextBox loggingBox;
        private Label logsLabel;
        private Button selectFileBtn;
    }
}
