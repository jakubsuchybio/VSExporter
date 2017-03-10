using System;
using System.Windows.Forms;

namespace VSExporter
{
    public partial class VSExporterDialog : Form
    {
        public VSExporterDialog() =>
            InitializeComponent();

        private void Button_DirPath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                var result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                    textBox_DirPath.Text = folderDialog.SelectedPath;
            }
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {

        }
    }
}
