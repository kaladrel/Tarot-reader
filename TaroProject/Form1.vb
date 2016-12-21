Imports System.Collections.Generic
Imports System.Text
Imports Tarot.Logic
Imports Tarot.Logic.Model

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tarotcards As New List(Of TarotCard)
        Dim tarotLogic As New TarotLogic

        For i As Integer = 1 To 3
            Dim tarotcard As New TarotCard
            tarotcard = tarotLogic.GenerateTarotCard(tarotcards.Select(Function(x) x.CardId).ToList())
            tarotcards.Add(tarotcard)
        Next

        PictureBox1.BackgroundImage = My.Resources.ResourceManager.GetObject(tarotcards(0).ImageName)
        PictureBox2.BackgroundImage = My.Resources.ResourceManager.GetObject(tarotcards(1).ImageName)
        PictureBox3.BackgroundImage = My.Resources.ResourceManager.GetObject(tarotcards(2).ImageName)
        TextBox1.Text = tarotcards(0).Description
        TextBox3.Text = tarotcards(1).Description
        TextBox4.Text = tarotcards(2).Description

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.BackgroundImage = My.Resources.xiii_tarot_by_nekro_back1
        PictureBox2.BackgroundImage = My.Resources.xiii_tarot_by_nekro_back1
        PictureBox3.BackgroundImage = My.Resources.xiii_tarot_by_nekro_back1
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub




    'drag form without borders

    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Magic_Celtic_Music___The_Hooded_Man___Tarot,
          AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources.Magic_Celtic_Music___The_Hooded_Man___Tarot,
          AudioPlayMode.BackgroundLoop)
    End Sub
End Class
