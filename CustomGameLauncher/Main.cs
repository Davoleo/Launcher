using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomGameLauncher
{
    public partial class Main : Form
    {
        private int x = 2;
        private System.Media.SoundPlayer player;
        private ExecList listForm;

        public Main()
        {
            InitializeComponent();

            listForm = new ExecList();

            //MemoryStream stream = new MemoryStream();
            //StreamWriter writer = new StreamWriter(stream);
            //writer.Write(Properties.Resources.chiptune_1);
            //writer.Write(Properties.Resources.chiptune_3);
            //writer.Flush();
            //stream.Position = 0;
            player = new System.Media.SoundPlayer(Properties.Resources.chiptune_1);

            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
        }

        private void timerTitle_Tick(object sender, EventArgs e)
        {
            x += 1;
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
            string filename = Properties.Settings.Default.Paths[comboBoxGame.SelectedIndex];
            if (filename == "") return;
            Icon icon = Icon.ExtractAssociatedIcon(filename);
            Bitmap bitmapIcon = icon.ToBitmap();
            pictureIcon.Image = bitmapIcon;
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
            listForm.ShowDialog();
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

            foreach (string name in Properties.Settings.Default.Games)
                comboBoxGame.Items.Add(name);
        }

        private void symbolRefresh_Click(object sender, EventArgs e)
        {
            comboBoxGame.Items.Clear();
            foreach (string name in Properties.Settings.Default.Games)
                comboBoxGame.Items.Add(name);
        }

        private void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
        }
    }
}
