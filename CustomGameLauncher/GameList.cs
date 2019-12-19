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
            /*
            StreamReader nameReader = new StreamReader(Environment.CurrentDirectory + "../../../Resources/Names.txt");
            StreamReader pathReader = new StreamReader(Environment.CurrentDirectory + "../../../Resources/Paths.txt");

            string nameLine = nameReader.ReadLine();
            string pathLine = pathReader.ReadLine();

            while (nameLine != null)
                listNames.Items.Add(nameLine);

            while (pathLine != null)
                listPaths.Items.Add(pathLine);

            nameReader.Close();
            pathReader.Close();
            */
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
    }
}
