namespace BrowseDesktopDotNet7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // This page lists the special folders that can be used with Environment.SpecialFolder: https://learn.microsoft.com/en-us/dotnet/api/system.environment.specialfolder?view=net-7.0
            folderBrowserDesktop.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDesktopPathDocuments.RootFolder = Environment.SpecialFolder.Desktop;

            // These lines allow you to set the selected path when you click the Documents buttons
            // Currently sets the selected path to My Documents
            //folderBrowserDesktopPathDocuments.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //folderBrowserDesktopPathDocuments.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //folderBrowserMyComputerPathDocuments.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);;
        }

        private void buttonDesktop_Click(object sender, EventArgs e)
        {
            if (folderBrowserDesktop.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDesktop.SelectedPath, "Selected Folder");
            }
        }

        private void buttonDesktopDocuments_Click(object sender, EventArgs e)
        {
            if (folderBrowserDesktopPathDocuments.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDesktopPathDocuments.SelectedPath, "Selected Folder");
            }
        }

        private void buttonMyComputer_Click(object sender, EventArgs e)
        {
            if (folderBrowserMyComputer.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserMyComputer.SelectedPath, "Selected Folder");
            }
        }

        private void buttonMyComputerDocuments_Click(object sender, EventArgs e)
        {
            if (folderBrowserMyComputerPathDocuments.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserMyComputerPathDocuments.SelectedPath, "Selected Folder");
            }
        }
    }
}