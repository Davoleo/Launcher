namespace CustomGameLauncher
{
    partial class ExecList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.symbolBox1 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.listNames = new System.Windows.Forms.ListBox();
            this.listPaths = new System.Windows.Forms.ListBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // symbolBox1
            // 
            // 
            // 
            // 
            this.symbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox1.Location = new System.Drawing.Point(413, 1);
            this.symbolBox1.Name = "symbolBox1";
            this.symbolBox1.Size = new System.Drawing.Size(25, 25);
            this.symbolBox1.Symbol = "";
            this.symbolBox1.TabIndex = 0;
            this.symbolBox1.Text = "symbolBox1";
            this.symbolBox1.Click += new System.EventHandler(this.symbolBox1_Click);
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.Location = new System.Drawing.Point(7, 6);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(192, 264);
            this.listNames.TabIndex = 1;
            this.listNames.SelectedIndexChanged += new System.EventHandler(this.listGames_SelectedIndexChanged);
            // 
            // listPaths
            // 
            this.listPaths.FormattingEnabled = true;
            this.listPaths.Location = new System.Drawing.Point(205, 6);
            this.listPaths.Name = "listPaths";
            this.listPaths.Size = new System.Drawing.Size(192, 264);
            this.listPaths.TabIndex = 2;
            this.listPaths.SelectedIndexChanged += new System.EventHandler(this.listPaths_SelectedIndexChanged);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTools.Controls.Add(this.btnRemove);
            this.panelTools.Controls.Add(this.btnAdd);
            this.panelTools.Controls.Add(this.btnBrowse);
            this.panelTools.Controls.Add(this.txbPath);
            this.panelTools.Controls.Add(this.label2);
            this.panelTools.Controls.Add(this.txbName);
            this.panelTools.Controls.Add(this.label1);
            this.panelTools.Location = new System.Drawing.Point(438, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(248, 287);
            this.panelTools.TabIndex = 3;
            this.panelTools.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Game";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 158);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(227, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(9, 72);
            this.txbPath.Multiline = true;
            this.txbPath.Name = "txbPath";
            this.txbPath.ReadOnly = true;
            this.txbPath.Size = new System.Drawing.Size(227, 80);
            this.txbPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Path:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(9, 23);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(227, 20);
            this.txbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 247);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(227, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Game";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ExecList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 287);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.listPaths);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.symbolBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExecList";
            this.Text = "ExecList";
            this.Load += new System.EventHandler(this.GameList_Load);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
        private System.Windows.Forms.ListBox listNames;
        private System.Windows.Forms.ListBox listPaths;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRemove;
    }
}