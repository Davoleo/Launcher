using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomGameLauncher
{
    public partial class GameList : Form
    {
        public GameList()
        {
            InitializeComponent();
        }

        private void GameList_Load(object sender, EventArgs e)
        {
            string[] names = new string[Properties.Settings.Default.Games.Count];
            string[] paths = new string[Properties.Settings.Default.Paths.Count];

            Properties.Settings.Default.Games.CopyTo(names, 0);
            Properties.Settings.Default.Paths.CopyTo(paths, 0);

            listNames.Items.AddRange(names);
            listPaths.Items.AddRange(paths);
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

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "" || txbPath.Text == "")
                MessageBox.Show("Invalid Game_Name/Game_Path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Properties.Settings.Default.Games.Add(txbName.Text);
                Properties.Settings.Default.Paths.Add(txbPath.Text);
                listNames.Items.Add(txbName.Text);
                listPaths.Items.Add(txbPath.Text);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //TODO : Fix List Desynchronization

            listNames.Items.Remove(listNames.SelectedItem);
            listPaths.Items.Remove(listPaths.SelectedItem);
        }
    }
}
