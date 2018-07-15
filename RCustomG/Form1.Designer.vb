<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FioriButton = New System.Windows.Forms.Button()
        Me.RomboButton = New System.Windows.Forms.Button()
        Me.PiccheButton = New System.Windows.Forms.Button()
        Me.CuoriButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RomboButton5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SymbolBox1 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.CuoriButton8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.DadiButton = New System.Windows.Forms.Button()
        Me.LaunchButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FioriButton
        '
        Me.FioriButton.BackColor = System.Drawing.Color.Transparent
        Me.FioriButton.BackgroundImage = CType(resources.GetObject("FioriButton.BackgroundImage"), System.Drawing.Image)
        Me.FioriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FioriButton.Location = New System.Drawing.Point(589, 240)
        Me.FioriButton.Name = "FioriButton"
        Me.FioriButton.Size = New System.Drawing.Size(65, 81)
        Me.FioriButton.TabIndex = 0
        Me.FioriButton.UseVisualStyleBackColor = False
        '
        'RomboButton
        '
        Me.RomboButton.BackColor = System.Drawing.Color.Transparent
        Me.RomboButton.BackgroundImage = CType(resources.GetObject("RomboButton.BackgroundImage"), System.Drawing.Image)
        Me.RomboButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RomboButton.Location = New System.Drawing.Point(28, 240)
        Me.RomboButton.Name = "RomboButton"
        Me.RomboButton.Size = New System.Drawing.Size(65, 81)
        Me.RomboButton.TabIndex = 1
        Me.RomboButton.UseVisualStyleBackColor = False
        '
        'PiccheButton
        '
        Me.PiccheButton.BackColor = System.Drawing.Color.Transparent
        Me.PiccheButton.BackgroundImage = CType(resources.GetObject("PiccheButton.BackgroundImage"), System.Drawing.Image)
        Me.PiccheButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PiccheButton.Location = New System.Drawing.Point(194, 240)
        Me.PiccheButton.Name = "PiccheButton"
        Me.PiccheButton.Size = New System.Drawing.Size(65, 81)
        Me.PiccheButton.TabIndex = 2
        Me.PiccheButton.UseVisualStyleBackColor = False
        '
        'CuoriButton
        '
        Me.CuoriButton.BackColor = System.Drawing.Color.Transparent
        Me.CuoriButton.BackgroundImage = CType(resources.GetObject("CuoriButton.BackgroundImage"), System.Drawing.Image)
        Me.CuoriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CuoriButton.Location = New System.Drawing.Point(423, 240)
        Me.CuoriButton.Name = "CuoriButton"
        Me.CuoriButton.Size = New System.Drawing.Size(65, 81)
        Me.CuoriButton.TabIndex = 3
        Me.CuoriButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("CoffeeTin", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Game Randomizer"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'RomboButton5
        '
        Me.RomboButton5.BackColor = System.Drawing.Color.Transparent
        Me.RomboButton5.BackgroundImage = CType(resources.GetObject("RomboButton5.BackgroundImage"), System.Drawing.Image)
        Me.RomboButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RomboButton5.Enabled = False
        Me.RomboButton5.Location = New System.Drawing.Point(12, 240)
        Me.RomboButton5.Name = "RomboButton5"
        Me.RomboButton5.Size = New System.Drawing.Size(65, 81)
        Me.RomboButton5.TabIndex = 5
        Me.RomboButton5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("POKERFACE", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(27, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "COLORS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("POKERFACE", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(591, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ADD GAME"
        '
        'SymbolBox1
        '
        Me.SymbolBox1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.SymbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox1.Location = New System.Drawing.Point(641, 0)
        Me.SymbolBox1.Name = "SymbolBox1"
        Me.SymbolBox1.Size = New System.Drawing.Size(24, 24)
        Me.SymbolBox1.Symbol = ""
        Me.SymbolBox1.TabIndex = 8
        Me.SymbolBox1.Text = "SymbolBox1"
        '
        'CuoriButton8
        '
        Me.CuoriButton8.BackColor = System.Drawing.Color.Transparent
        Me.CuoriButton8.BackgroundImage = CType(resources.GetObject("CuoriButton8.BackgroundImage"), System.Drawing.Image)
        Me.CuoriButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CuoriButton8.Enabled = False
        Me.CuoriButton8.Location = New System.Drawing.Point(407, 240)
        Me.CuoriButton8.Name = "CuoriButton8"
        Me.CuoriButton8.Size = New System.Drawing.Size(65, 81)
        Me.CuoriButton8.TabIndex = 9
        Me.CuoriButton8.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("POKERFACE", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(430, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "MUSIC"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.FocusHighlightColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.ForestGreen
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 16
        Me.ComboBoxEx1.Location = New System.Drawing.Point(194, 105)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(294, 22)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.ComboBoxEx1.TabIndex = 11
        Me.ComboBoxEx1.WatermarkColor = System.Drawing.Color.Transparent
        '
        'DadiButton
        '
        Me.DadiButton.BackColor = System.Drawing.Color.Transparent
        Me.DadiButton.BackgroundImage = CType(resources.GetObject("DadiButton.BackgroundImage"), System.Drawing.Image)
        Me.DadiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DadiButton.FlatAppearance.BorderSize = 0
        Me.DadiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DadiButton.ForeColor = System.Drawing.Color.Black
        Me.DadiButton.Location = New System.Drawing.Point(53, 105)
        Me.DadiButton.Name = "DadiButton"
        Me.DadiButton.Size = New System.Drawing.Size(90, 87)
        Me.DadiButton.TabIndex = 12
        Me.DadiButton.UseVisualStyleBackColor = False
        '
        'LaunchButton
        '
        Me.LaunchButton.BackColor = System.Drawing.Color.Transparent
        Me.LaunchButton.BackgroundImage = CType(resources.GetObject("LaunchButton.BackgroundImage"), System.Drawing.Image)
        Me.LaunchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LaunchButton.FlatAppearance.BorderSize = 0
        Me.LaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaunchButton.Location = New System.Drawing.Point(528, 105)
        Me.LaunchButton.Name = "LaunchButton"
        Me.LaunchButton.Size = New System.Drawing.Size(103, 87)
        Me.LaunchButton.TabIndex = 13
        Me.LaunchButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(287, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 333)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LaunchButton)
        Me.Controls.Add(Me.DadiButton)
        Me.Controls.Add(Me.ComboBoxEx1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SymbolBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RomboButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CuoriButton)
        Me.Controls.Add(Me.PiccheButton)
        Me.Controls.Add(Me.FioriButton)
        Me.Controls.Add(Me.RomboButton5)
        Me.Controls.Add(Me.CuoriButton8)
        Me.Font = New System.Drawing.Font("CoffeeTin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RCG "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FioriButton As Button
    Friend WithEvents RomboButton As Button
    Friend WithEvents PiccheButton As Button
    Friend WithEvents CuoriButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RomboButton5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SymbolBox1 As DevComponents.DotNetBar.Controls.SymbolBox
    Friend WithEvents CuoriButton8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents DadiButton As Button
    Friend WithEvents LaunchButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
