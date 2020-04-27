using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Windows.Forms;

namespace CustomGameLauncher
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
    public partial class ExecList : Form
    {
        public static Dictionary<string, string> data = new Dictionary<string, string>();

        //To write in the Local AppData Folder
        //public string FilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DavLauncher\\applications.txt";
        public static string FilePath = Application.StartupPath + "\\applications.txt";
        public ExecList()
        {
            InitializeComponent();

            //First File Read
            StreamReader reader = new StreamReader(FilePath);

            string nextLine = reader.ReadLine();

            while (nextLine != null)
            {
                string[] pair = nextLine.Split('|');

                string name = pair[0].TrimEnd();
                string path = pair[1].TrimStart();

                data.Add(name, path);
                listNames.Items.Add(name);
                listPaths.Items.Add(path);

                nextLine = reader.ReadLine();
            }

            reader.Close();
            reader.Dispose();
        }

        private void SymbolBox1_Click(object sender, EventArgs e)
        {
            if (panelTools.Visible)
            {
                panelTools.Hide();
                Width = 455;
            }
            else
            {
                panelTools.Show();
                Width = 702;
            }
        }

        private void ListGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPaths.SelectedIndex = listNames.SelectedIndex;
        }

        private void listPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            listNames.SelectedIndex = listPaths.SelectedIndex;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Executable Files|*.exe|All Files|*.*";
            openFileDialog1.Title = "Select the file you want to run";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txbPath.Text = openFileDialog1.FileName;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string path = txbPath.Text;

            if (name == "" || path == "")
                MessageBox.Show("Invalid Software Name / Executable Path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                listNames.Items.Add(name);
                listPaths.Items.Add(path);

                data.Add(name, path);

                AddToFile(name, path);
            }
        }

        public void WriteDictionaryToFile()
        {
            StreamWriter writer = new StreamWriter(FilePath, false);

            foreach (KeyValuePair<string, string> pair in data)
            {
                writer.WriteLine(pair.Key + " | " + pair.Value);
            }

            writer.Close();
            writer.Dispose();
        }

        private static void AddToFile(string name, string path)
        {
            StreamWriter writer = new StreamWriter(FilePath, true);
            writer.WriteLine(name + " | " + path);
            writer.Close();
            writer.Dispose();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure you want to delete the selected entry?", "Dav Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            int index = listNames.SelectedIndex;

            data.Remove((string) listNames.SelectedItem);

            //TODO : Fix ListView Desynchronization
            listNames.Items.RemoveAt(index);
            listPaths.Items.RemoveAt(index);

            WriteDictionaryToFile();
        }
    }
}
