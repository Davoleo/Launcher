﻿Public Class Form1
    Dim x As Integer = 0
    Dim r As New System.Random
    Private Property Shell1 As Object
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 1
        If x = 1 Then
            Label1.ForeColor = Color.Red
        ElseIf x = 2 Then
            Label1.ForeColor = Color.Black
        ElseIf x = 3 Then
            Label1.ForeColor = Color.Blue
        ElseIf x = 4 Then
            Label1.ForeColor = Color.White
            x = 0
        End If
    End Sub

    Private Sub RomboButton_Click(sender As Object, e As EventArgs) Handles RomboButton.Click
        Timer1.Stop()
        RomboButton.Enabled = False
        RomboButton.SendToBack()
        RomboButton5.Enabled = True
    End Sub

    Private Sub RomboButton5_Click(sender As Object, e As EventArgs) Handles RomboButton5.Click
        Timer1.Start()
        RomboButton5.Enabled = False
        RomboButton5.SendToBack()
        RomboButton.Enabled = True
    End Sub

    Private Sub FioriButton_Click(sender As Object, e As EventArgs) Handles FioriButton.Click
        List.Show()

    End Sub

    Private Sub SymbolBox1_Click(sender As Object, e As EventArgs) Handles SymbolBox1.Click
        MsgBox("This application was written in VB.NET by Davoleo AKA D36L" & Environment.NewLine & "Copyright - (c) - 2018 - D36L" & Environment.NewLine & Environment.NewLine & "Music: Babaman - Tentan di Fermarmi" & Environment.NewLine & Environment.NewLine & "Code and gfx: D36L", MsgBoxStyle.Information, "Credits")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Game In My.Settings.Games
            ComboBoxEx1.Items.Add(Game)
        Next
        'My.Computer.Audio.Play(My.Resources.Babaman___Tentan_Di_Fermarmi, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub CuoriButton_Click(sender As Object, e As EventArgs) Handles CuoriButton.Click
        My.Computer.Audio.Stop()
        CuoriButton.Enabled = False
        CuoriButton.SendToBack()
        CuoriButton8.Enabled = True
    End Sub

    Private Sub CuoriButton8_Click(sender As Object, e As EventArgs) Handles CuoriButton8.Click
        My.Computer.Audio.Play(My.Resources.Babaman___Tentan_Di_Fermarmi, AudioPlayMode.BackgroundLoop)
        CuoriButton8.Enabled = False
        CuoriButton8.SendToBack()
        CuoriButton.Enabled = True
    End Sub

    Private Sub DadiButton_Click(sender As Object, e As EventArgs) Handles DadiButton.Click
        ComboBoxEx1.SelectedIndex = Convert.ToInt32(r.Next(1, ComboBoxEx1.Items.Count.ToString))
    End Sub

    Private Sub LaunchButton_Click(sender As Object, e As EventArgs) Handles LaunchButton.Click
        Shell1 = CreateObject("shell.application", "runas")
        Shell1.open(My.Settings.Paths(ComboBoxEx1.SelectedIndex).ToString)
    End Sub


    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Try
            PictureBox1.Image = System.Drawing.Icon.ExtractAssociatedIcon(My.Settings.Paths(ComboBoxEx1.SelectedIndex).ToString).ToBitmap
        Catch
            MsgBox("Couldn't find the icon for the application selected in the ComboBox", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
