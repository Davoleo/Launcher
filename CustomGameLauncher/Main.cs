using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomGameLauncher
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
    public partial class Main : Form
    {
        private int x = 2;
        private System.Media.SoundPlayer player;
        private ExecList listForm;

        private List<Bitmap> icons = new List<Bitmap>();

        public Main()
        {
            InitializeComponent();

            listForm = new ExecList();

            player = new System.Media.SoundPlayer(Properties.Resources.chiptune_1);

            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            ClearAndFillIcons();
        }

        private void timerTitle_Tick(object sender, EventArgs e)
        {
            x++;
            switch(x)
            {
                case 1:
                    lblTitle.ForeColor = Color.Red;
                    break;
                case 2:
                    lblTitle.ForeColor = Color.Black;
                    break;
                case 3:
                    lblTitle.ForeColor = Color.Blue;
                    break;
                case 4:
                    lblTitle.ForeColor = Color.White;
                    x = 0;
                    break;
            }
        }

        private void symbolHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was coded by Davoleo AKA D36L" + Environment.NewLine + "Copyright - (c) - Davoleo - 2018-2020" + Environment.NewLine + Environment.NewLine + "Music Credits: Razor1911" + Environment.NewLine + Environment.NewLine + "Code and gfx: D36L", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureIcon.Image = icons[comboBoxGame.SelectedIndex];
        }

        private void btnQuadri1_Click(object sender, EventArgs e)
        {
            timerTitle.Stop();
            btnQuadri1.Enabled = false;
            btnQuadri1.SendToBack();
            btnQuadri5.Enabled = true;
        }

        private void btnQuadri5_Click(object sender, EventArgs e)
        {
            timerTitle.Start();
            btnQuadri5.Enabled = false;
            btnQuadri5.SendToBack();
            btnQuadri1.Enabled = true;
        }

        private void btnFiori_Click(object sender, EventArgs e)
        {
            listForm.Show();
        }

        private void btnCuori_Click(object sender, EventArgs e)
        {
            player.Stop();
            btnCuori.Enabled = false;
            btnCuori.SendToBack();
            btnCuori8.Enabled = true;
        }

        private void btnCuori8_Click(object sender, EventArgs e)
        {
            player.Play();
            btnCuori8.Enabled = false;
            btnCuori8.SendToBack();
            btnCuori.Enabled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            player.Play();

            foreach (var pair in ExecList.data)
            {
                comboBoxGame.Items.Add(pair.Key);
            }

            if (!File.Exists(ExecList.FilePath))
            {
                File.Create(ExecList.FilePath);
            }
        }

        private void symbolRefresh_Click(object sender, EventArgs e)
        {
            comboBoxGame.Items.Clear();

            foreach (var pair in ExecList.data)
            {
                comboBoxGame.Items.Add(pair.Key);
            }

            ClearAndFillIcons();
        }

        /// <summary>
        /// Clear and Fill Icon List
        /// </summary>
        private void ClearAndFillIcons()
        {
            icons.Clear();
            foreach (KeyValuePair<string, string> namePathPair in ExecList.data)
            {
                string filename = namePathPair.Value;

                if (filename == "") 
                    continue;

                Icon icon = Icon.ExtractAssociatedIcon(filename);
                Bitmap bitmapIcon = icon.ToBitmap();
                icons.Add(bitmapIcon);
            }
        }

        private void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
        }
    }
}
