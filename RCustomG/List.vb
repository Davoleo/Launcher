Public Class List
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Panel1.Visible = True Then
            Panel1.Hide()
            Me.Width = "455"
        Else
            Panel1.Show()
            Me.Width = "702"
        End If
    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        For Each Path In My.Settings.Paths
            PathList.Items.Add(Path)
        Next
        For Each Game In My.Settings.Games
            GameList.Items.Add(Game)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openfile As New OpenFileDialog
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxX1.Text = openfile.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBoxX1.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Invalid Game_Name/Game_Path!", MsgBoxStyle.Exclamation)
        Else
            My.Settings.Games.Add(TextBox1.Text)
            My.Settings.Paths.Add(TextBoxX1.Text)
            GameList.Items.Add(TextBox1.Text)
            PathList.Items.Add(TextBoxX1.Text)
        End If
    End Sub
End Class