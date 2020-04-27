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
            this.listNames = new System.Windows.Forms.ListBox();
            this.listPaths = new System.Windows.Forms.ListBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.Location = new System.Drawing.Point(7, 6);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(192, 277);
            this.listNames.TabIndex = 1;
            this.listNames.SelectedIndexChanged += new System.EventHandler(this.ListGames_SelectedIndexChanged);
            // 
            // listPaths
            // 
            this.listPaths.FormattingEnabled = true;
            this.listPaths.Location = new System.Drawing.Point(205, 6);
            this.listPaths.Name = "listPaths";
            this.listPaths.Size = new System.Drawing.Size(214, 277);
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
            this.panelTools.Location = new System.Drawing.Point(465, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(248, 287);
            this.panelTools.TabIndex = 3;
            this.panelTools.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 247);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(227, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Selected Executable";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add New Executable";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 158);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(227, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
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
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Executable Path:";
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
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::CustomGameLauncher.Properties.Resources.settings;
            this.buttonRefresh.Location = new System.Drawing.Point(425, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(40, 40);
            this.buttonRefresh.TabIndex = 21;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.SymbolBox1_Click);
            // 
            // ExecList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 287);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.listPaths);
            this.Controls.Add(this.listNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExecList";
            this.Text = "ExecList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExecList_FormClosing);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button buttonRefresh;
    }
}