namespace BrowseDesktopDotNet7
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
            this.buttonDesktop = new System.Windows.Forms.Button();
            this.buttonMyComputer = new System.Windows.Forms.Button();
            this.folderBrowserDesktop = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserMyComputer = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonMyComputerDocuments = new System.Windows.Forms.Button();
            this.buttonDesktopDocuments = new System.Windows.Forms.Button();
            this.folderBrowserDesktopPathDocuments = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserMyComputerPathDocuments = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxDesktop = new System.Windows.Forms.GroupBox();
            this.groupBoxMyComputer = new System.Windows.Forms.GroupBox();
            this.groupBoxDesktop.SuspendLayout();
            this.groupBoxMyComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDesktop
            // 
            this.buttonDesktop.Location = new System.Drawing.Point(6, 22);
            this.buttonDesktop.Name = "buttonDesktop";
            this.buttonDesktop.Size = new System.Drawing.Size(155, 23);
            this.buttonDesktop.TabIndex = 0;
            this.buttonDesktop.Text = "SelectedPath Default";
            this.buttonDesktop.UseVisualStyleBackColor = true;
            this.buttonDesktop.Click += new System.EventHandler(this.buttonDesktop_Click);
            // 
            // buttonMyComputer
            // 
            this.buttonMyComputer.Location = new System.Drawing.Point(6, 22);
            this.buttonMyComputer.Name = "buttonMyComputer";
            this.buttonMyComputer.Size = new System.Drawing.Size(155, 23);
            this.buttonMyComputer.TabIndex = 2;
            this.buttonMyComputer.Text = "SelectedPath Default";
            this.buttonMyComputer.UseVisualStyleBackColor = true;
            this.buttonMyComputer.Click += new System.EventHandler(this.buttonMyComputer_Click);
            // 
            // folderBrowserMyComputer
            // 
            this.folderBrowserMyComputer.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // buttonMyComputerDocuments
            // 
            this.buttonMyComputerDocuments.Location = new System.Drawing.Point(167, 22);
            this.buttonMyComputerDocuments.Name = "buttonMyComputerDocuments";
            this.buttonMyComputerDocuments.Size = new System.Drawing.Size(155, 23);
            this.buttonMyComputerDocuments.TabIndex = 3;
            this.buttonMyComputerDocuments.Text = "SelectedPath Documents";
            this.buttonMyComputerDocuments.UseVisualStyleBackColor = true;
            this.buttonMyComputerDocuments.Click += new System.EventHandler(this.buttonMyComputerDocuments_Click);
            // 
            // buttonDesktopDocuments
            // 
            this.buttonDesktopDocuments.Location = new System.Drawing.Point(167, 22);
            this.buttonDesktopDocuments.Name = "buttonDesktopDocuments";
            this.buttonDesktopDocuments.Size = new System.Drawing.Size(155, 23);
            this.buttonDesktopDocuments.TabIndex = 1;
            this.buttonDesktopDocuments.Text = "SelectedPath Documents";
            this.buttonDesktopDocuments.UseVisualStyleBackColor = true;
            this.buttonDesktopDocuments.Click += new System.EventHandler(this.buttonDesktopDocuments_Click);
            // 
            // folderBrowserMyComputerPathDocuments
            // 
            this.folderBrowserMyComputerPathDocuments.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // groupBoxDesktop
            // 
            this.groupBoxDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDesktop.Controls.Add(this.buttonDesktop);
            this.groupBoxDesktop.Controls.Add(this.buttonDesktopDocuments);
            this.groupBoxDesktop.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDesktop.Name = "groupBoxDesktop";
            this.groupBoxDesktop.Size = new System.Drawing.Size(331, 59);
            this.groupBoxDesktop.TabIndex = 4;
            this.groupBoxDesktop.TabStop = false;
            this.groupBoxDesktop.Text = "Desktop";
            // 
            // groupBoxMyComputer
            // 
            this.groupBoxMyComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMyComputer.Controls.Add(this.buttonMyComputer);
            this.groupBoxMyComputer.Controls.Add(this.buttonMyComputerDocuments);
            this.groupBoxMyComputer.Location = new System.Drawing.Point(12, 77);
            this.groupBoxMyComputer.Name = "groupBoxMyComputer";
            this.groupBoxMyComputer.Size = new System.Drawing.Size(331, 58);
            this.groupBoxMyComputer.TabIndex = 5;
            this.groupBoxMyComputer.TabStop = false;
            this.groupBoxMyComputer.Text = "My Computer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 155);
            this.Controls.Add(this.groupBoxMyComputer);
            this.Controls.Add(this.groupBoxDesktop);
            this.MinimumSize = new System.Drawing.Size(371, 194);
            this.Name = "Form1";
            this.Text = "Browse Test App .NET 7";
            this.groupBoxDesktop.ResumeLayout(false);
            this.groupBoxMyComputer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDesktop;
        private Button buttonMyComputer;
        private FolderBrowserDialog folderBrowserDesktop;
        private FolderBrowserDialog folderBrowserMyComputer;
        private Button buttonMyComputerDocuments;
        private Button buttonDesktopDocuments;
        private FolderBrowserDialog folderBrowserDesktopPathDocuments;
        private FolderBrowserDialog folderBrowserMyComputerPathDocuments;
        private GroupBox groupBoxDesktop;
        private GroupBox groupBoxMyComputer;
    }
}