Imports System
Imports System.IO

Public Class leaguetable
    Inherits System.Windows.Forms.Form
    Dim inputfile As IO.StreamReader

    Private Sub leaguetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("League Table")
        If File.Exists("teams.txt") Then
            inputfile = IO.File.OpenText("teams.txt")
            lbl_team1.Text = inputfile.ReadLine
            lbl_team2.Text = inputfile.ReadLine
            lbl_team3.Text = inputfile.ReadLine
            lbl_team4.Text = inputfile.ReadLine
            lbl_team5.Text = inputfile.ReadLine
            lbl_team6.Text = inputfile.ReadLine
            lbl_team7.Text = inputfile.ReadLine
            lbl_team8.Text = inputfile.ReadLine
            lbl_team9.Text = inputfile.ReadLine
            lbl_team10.Text = inputfile.ReadLine
            lbl_team11.Text = inputfile.ReadLine
            lbl_team12.Text = inputfile.ReadLine
            lbl_team13.Text = inputfile.ReadLine
            lbl_team14.Text = inputfile.ReadLine
            lbl_team15.Text = inputfile.ReadLine
            lbl_team16.Text = inputfile.ReadLine
            lbl_team17.Text = inputfile.ReadLine
            lbl_team18.Text = inputfile.ReadLine
            lbl_team19.Text = inputfile.ReadLine
            lbl_team20.Text = inputfile.ReadLine
            lbl_team21.Text = inputfile.ReadLine
            lbl_team22.Text = inputfile.ReadLine
            lbl_team23.Text = inputfile.ReadLine
            lbl_team24.Text = inputfile.ReadLine
            inputfile.Close()
        End If
        ' MsgBox("Exiting League Table")
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        mainmenu.Visible = 1
        Me.Close()
    End Sub

End Class