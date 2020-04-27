namespace CustomGameLauncher
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.symbolHelp = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.btnQuadri1 = new System.Windows.Forms.Button();
            this.btnQuadri5 = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnPicche = new System.Windows.Forms.Button();
            this.btnCuori8 = new System.Windows.Forms.Button();
            this.btnCuori = new System.Windows.Forms.Button();
            this.btnFiori = new System.Windows.Forms.Button();
            this.lblAddGame = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.timerTitle = new System.Windows.Forms.Timer(this.components);
            this.symbolRefresh = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Share Tech Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(175, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DAV LAUNCHER";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Transparent;
            this.btnRandom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRandom.BackgroundImage")));
            this.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.ForeColor = System.Drawing.Color.Black;
            this.btnRandom.Location = new System.Drawing.Point(46, 125);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(90, 90);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // symbolHelp
            // 
            this.symbolHelp.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.symbolHelp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolHelp.Location = new System.Drawing.Point(647, 0);
            this.symbolHelp.Name = "symbolHelp";
            this.symbolHelp.Size = new System.Drawing.Size(27, 23);
            this.symbolHelp.Symbol = "";
            this.symbolHelp.TabIndex = 4;
            this.symbolHelp.Text = "symbolBox1";
            this.symbolHelp.Click += new System.EventHandler(this.SymbolHelp_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLaunch.BackgroundImage")));
            this.btnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaunch.FlatAppearance.BorderSize = 0;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.ForeColor = System.Drawing.Color.Black;
            this.btnLaunch.Location = new System.Drawing.Point(544, 125);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(90, 90);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            // 
            // pictureIcon
            // 
            this.pictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureIcon.Location = new System.Drawing.Point(314, 165);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(50, 50);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIcon.TabIndex = 7;
            this.pictureIcon.TabStop = false;
            // 
            // btnQuadri1
            // 
            this.btnQuadri1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuadri1.BackgroundImage")));
            this.btnQuadri1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuadri1.Location = new System.Drawing.Point(34, 272);
            this.btnQuadri1.Name = "btnQuadri1";
            this.btnQuadri1.Size = new System.Drawing.Size(65, 81);
            this.btnQuadri1.TabIndex = 8;
            this.btnQuadri1.UseVisualStyleBackColor = true;
            this.btnQuadri1.Click += new System.EventHandler(this.BtnQuadri1_Click);
            // 
            // btnQuadri5
            // 
            this.btnQuadri5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuadri5.BackgroundImage")));
            this.btnQuadri5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuadri5.Enabled = false;
            this.btnQuadri5.Location = new System.Drawing.Point(12, 272);
            this.btnQuadri5.Name = "btnQuadri5";
            this.btnQuadri5.Size = new System.Drawing.Size(65, 81);
            this.btnQuadri5.TabIndex = 9;
            this.btnQuadri5.UseVisualStyleBackColor = true;
            this.btnQuadri5.Click += new System.EventHandler(this.BtnQuadri5_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.Red;
            this.lblColor.Location = new System.Drawing.Point(32, 252);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(57, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "COLORS";
            // 
            // btnPicche
            // 
            this.btnPicche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPicche.BackgroundImage")));
            this.btnPicche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicche.Location = new System.Drawing.Point(194, 271);
            this.btnPicche.Name = "btnPicche";
            this.btnPicche.Size = new System.Drawing.Size(65, 81);
            this.btnPicche.TabIndex = 11;
            this.btnPicche.UseVisualStyleBackColor = true;
            // 
            // btnCuori8
            // 
            this.btnCuori8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuori8.BackgroundImage")));
            this.btnCuori8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuori8.Location = new System.Drawing.Point(399, 272);
            this.btnCuori8.Name = "btnCuori8";
            this.btnCuori8.Size = new System.Drawing.Size(65, 81);
            this.btnCuori8.TabIndex = 12;
            this.btnCuori8.UseVisualStyleBackColor = true;
            this.btnCuori8.Click += new System.EventHandler(this.BtnCuori8_Click);
            // 
            // btnCuori
            // 
            this.btnCuori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuori.BackgroundImage")));
            this.btnCuori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuori.Enabled = false;
            this.btnCuori.Location = new System.Drawing.Point(418, 272);
            this.btnCuori.Name = "btnCuori";
            this.btnCuori.Size = new System.Drawing.Size(65, 81);
            this.btnCuori.TabIndex = 13;
            this.btnCuori.UseVisualStyleBackColor = true;
            this.btnCuori.Click += new System.EventHandler(this.BtnCuori_Click);
            // 
            // btnFiori
            // 
            this.btnFiori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiori.BackgroundImage")));
            this.btnFiori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiori.Location = new System.Drawing.Point(597, 271);
            this.btnFiori.Name = "btnFiori";
            this.btnFiori.Size = new System.Drawing.Size(65, 81);
            this.btnFiori.TabIndex = 15;
            this.btnFiori.UseVisualStyleBackColor = true;
            this.btnFiori.Click += new System.EventHandler(this.BtnFiori_Click);
            // 
            // lblAddGame
            // 
            this.lblAddGame.AutoSize = true;
            this.lblAddGame.BackColor = System.Drawing.Color.Transparent;
            this.lblAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddGame.Location = new System.Drawing.Point(593, 255);
            this.lblAddGame.Name = "lblAddGame";
            this.lblAddGame.Size = new System.Drawing.Size(72, 13);
            this.lblAddGame.TabIndex = 16;
            this.lblAddGame.Text = "EDIT EXES";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.BackColor = System.Drawing.Color.Transparent;
            this.lblMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.Color.Red;
            this.lblMusic.Location = new System.Drawing.Point(420, 257);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(46, 13);
            this.lblMusic.TabIndex = 17;
            this.lblMusic.Text = "MUSIC";
            // 
            // timerTitle
            // 
            this.timerTitle.Enabled = true;
            this.timerTitle.Interval = 500;
            this.timerTitle.Tick += new System.EventHandler(this.TimerTitle_Tick);
            // 
            // symbolRefresh
            // 
            this.symbolRefresh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.symbolRefresh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolRefresh.Location = new System.Drawing.Point(0, 0);
            this.symbolRefresh.Name = "symbolRefresh";
            this.symbolRefresh.Size = new System.Drawing.Size(26, 23);
            this.symbolRefresh.Symbol = "";
            this.symbolRefresh.TabIndex = 18;
            this.symbolRefresh.Text = "symbolBox1";
            this.symbolRefresh.Click += new System.EventHandler(this.SymbolRefresh_Click);
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Location = new System.Drawing.Point(194, 95);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(289, 21);
            this.comboBoxGame.TabIndex = 19;
            this.comboBoxGame.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGame_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 365);
            this.Controls.Add(this.btnCuori8);
            this.Controls.Add(this.comboBoxGame);
            this.Controls.Add(this.symbolRefresh);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblAddGame);
            this.Controls.Add(this.btnFiori);
            this.Controls.Add(this.btnCuori);
            this.Controls.Add(this.btnPicche);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnQuadri1);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.symbolHelp);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuadri5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Dav Launcher";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRandom;
        private DevComponents.DotNetBar.Controls.SymbolBox symbolHelp;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Button btnQuadri1;
        private System.Windows.Forms.Button btnQuadri5;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnPicche;
        private System.Windows.Forms.Button btnCuori8;
        private System.Windows.Forms.Button btnCuori;
        private System.Windows.Forms.Button btnFiori;
        private System.Windows.Forms.Label lblAddGame;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Timer timerTitle;
        private DevComponents.DotNetBar.Controls.SymbolBox symbolRefresh;
        private System.Windows.Forms.ComboBox comboBoxGame;
    }
}

