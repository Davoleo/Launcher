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

        //public string FilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\applications.txt";
        public static string FilePath = "..\\..\\Resources\\applications.txt";

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

        private void GameList_Load(object sender, EventArgs e)
        {
        }

        private void symbolBox1_Click(object sender, EventArgs e)
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

        private void listGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPaths.SelectedIndex = listNames.SelectedIndex;
        }

        private void listPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            listNames.SelectedIndex = listPaths.SelectedIndex;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Executable Files|*.exe|All Files|*.*";
            openFileDialog1.Title = "Select the file you want to run";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txbPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string path = txbPath.Text;

            if (name == "" || path == "")
                MessageBox.Show("Invalid Game_Name/Game_Path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                listNames.Items.Add(name);
                listPaths.Items.Add(path);

                data.Add(name, path);

                addToFile(name, path);
            }
        }

        public void writeDictionaryToFile()
        {
            StreamWriter writer = new StreamWriter(FilePath, false);

            foreach (KeyValuePair<string, string> pair in data)
            {
                writer.WriteLine(pair.Key + " | " + pair.Value);
            }

            writer.Close();
            writer.Dispose();
        }

        private void addToFile(string name, string path)
        {
            StreamWriter writer = new StreamWriter(FilePath, true);
            writer.WriteLine(name + " | " + path);
            writer.Close();
            writer.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            data.Remove((string) listNames.SelectedItem);

            //TODO : Fix ListView Desynchronization
            listNames.Items.Remove(listNames.SelectedItem);
            listPaths.Items.Remove(listPaths.SelectedItem);
        }
    }
}
