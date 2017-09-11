Imports System
Imports System.IO

Public Module GlobalVariables
    Public teamstable As Integer
End Module

Public Class leaguecreation
    Inherits System.Windows.Forms.Form
    Dim count As Long
    Dim teams As String = "C:\Users\ker0017\Documents\School\Year 12\Software Development\Unit 3\LPMS\LPMS\bin\Debug\teams.txt"


    Public Class GlobalVariables
        Public Shared noofteams As Integer
    End Class


    'for count = 0 to 'no of teams'
    Private Sub leaguecreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainmenu.Close()
    End Sub

    Private Sub ExitToWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToWindowsToolStripMenuItem.Click
        End
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub tbx_leaguename_TextChanged(sender As Object, e As EventArgs) Handles tbx_leaguename.TextChanged
        lbl_displayedleaguename.Text = tbx_leaguename.Text
    End Sub

    Private Sub btn_next0_Click(sender As Object, e As EventArgs) Handles btn_next0.Click
        If File.Exists("teams.txt") = True Then
            Dim outputfile As StreamWriter
            outputfile = File.CreateText("teams.txt")
            outputfile.WriteLine(tbx_team1.Text)
            outputfile.WriteLine(tbx_team2.Text)
            outputfile.WriteLine(tbx_team3.Text)
            outputfile.WriteLine(tbx_team4.Text)
            outputfile.WriteLine(tbx_team5.Text)
            outputfile.WriteLine(tbx_team6.Text)
            outputfile.WriteLine(tbx_team7.Text)
            outputfile.WriteLine(tbx_team8.Text)
            outputfile.WriteLine(tbx_team9.Text)
            outputfile.WriteLine(tbx_team10.Text)
            outputfile.WriteLine(tbx_team11.Text)
            outputfile.WriteLine(tbx_team12.Text)
            outputfile.WriteLine(tbx_team13.Text)
            outputfile.WriteLine(tbx_team14.Text)
            outputfile.WriteLine(tbx_team15.Text)
            outputfile.WriteLine(tbx_team16.Text)
            outputfile.WriteLine(tbx_team17.Text)
            outputfile.WriteLine(tbx_team18.Text)
            outputfile.WriteLine(tbx_team19.Text)
            outputfile.WriteLine(tbx_team20.Text)
            outputfile.Close()
        Else
            Dim outputfile As StreamWriter
            outputfile = File.CreateText("teams.txt")
            outputfile = My.Computer.FileSystem.OpenTextFileWriter("teams.txt", True)
            outputfile.WriteLine(tbx_team1.Text)
            outputfile.WriteLine(tbx_team2.Text)
            outputfile.WriteLine(tbx_team3.Text)
            outputfile.WriteLine(tbx_team4.Text)
            outputfile.WriteLine(tbx_team5.Text)
            outputfile.WriteLine(tbx_team6.Text)
            outputfile.WriteLine(tbx_team7.Text)
            outputfile.WriteLine(tbx_team8.Text)
            outputfile.WriteLine(tbx_team9.Text)
            outputfile.WriteLine(tbx_team10.Text)
            outputfile.WriteLine(tbx_team11.Text)
            outputfile.WriteLine(tbx_team12.Text)
            outputfile.WriteLine(tbx_team13.Text)
            outputfile.WriteLine(tbx_team14.Text)
            outputfile.WriteLine(tbx_team15.Text)
            outputfile.WriteLine(tbx_team16.Text)
            outputfile.WriteLine(tbx_team17.Text)
            outputfile.WriteLine(tbx_team18.Text)
            outputfile.WriteLine(tbx_team19.Text)
            outputfile.WriteLine(tbx_team20.Text)
            outputfile.Close()
        End If

        If File.Exists("rank.txt") = True Then
            Dim outputfile As StreamWriter
            outputfile = File.CreateText("rank.txt")
            outputfile.WriteLine(scr_teamrank1)
            outputfile.WriteLine(scr_teamrank2)
            outputfile.WriteLine(scr_teamrank3)
            outputfile.WriteLine(scr_teamrank4)
            outputfile.WriteLine(scr_teamrank5)
            outputfile.WriteLine(scr_teamrank6)
            outputfile.WriteLine(scr_teamrank7)
            outputfile.WriteLine(scr_teamrank8)
            outputfile.WriteLine(scr_teamrank9)
            outputfile.WriteLine(scr_teamrank10)
            outputfile.WriteLine(scr_teamrank11)
            outputfile.WriteLine(scr_teamrank12)
            outputfile.WriteLine(scr_teamrank13)
            outputfile.WriteLine(scr_teamrank14)
            outputfile.WriteLine(scr_teamrank15)
            outputfile.WriteLine(scr_teamrank16)
            outputfile.WriteLine(scr_teamrank17)
            outputfile.WriteLine(scr_teamrank18)
            outputfile.WriteLine(scr_teamrank19)
            outputfile.WriteLine(scr_teamrank20)
            outputfile.Close()
        Else
            Dim outputfile As StreamWriter
            outputfile = File.CreateText("rank.txt")
            outputfile = My.Computer.FileSystem.OpenTextFileWriter("rank.txt", True)
            outputfile.WriteLine(scr_teamrank1.Value)
            outputfile.WriteLine(scr_teamrank2.Value)
            outputfile.WriteLine(scr_teamrank3.Value)
            outputfile.WriteLine(scr_teamrank4.Value)
            outputfile.WriteLine(scr_teamrank5.Value)
            outputfile.WriteLine(scr_teamrank6.Value)
            outputfile.WriteLine(scr_teamrank7.Value)
            outputfile.WriteLine(scr_teamrank8.Value)
            outputfile.WriteLine(scr_teamrank9.Value)
            outputfile.WriteLine(scr_teamrank10.Value)
            outputfile.WriteLine(scr_teamrank11.Value)
            outputfile.WriteLine(scr_teamrank12.Value)
            outputfile.WriteLine(scr_teamrank13.Value)
            outputfile.WriteLine(scr_teamrank14.Value)
            outputfile.WriteLine(scr_teamrank15.Value)
            outputfile.WriteLine(scr_teamrank16.Value)
            outputfile.WriteLine(scr_teamrank17.Value)
            outputfile.WriteLine(scr_teamrank18.Value)
            outputfile.WriteLine(scr_teamrank19.Value)
            outputfile.WriteLine(scr_teamrank20.Value)
            outputfile.Close()
        End If
        ' MsgBox("Exiting League Creation")
        leaguetable.Show()
        Me.Close()
        ' MsgBox("Exiting League Creation")
    End Sub

    Private Sub scr_teamrank1_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank1.Scroll
        lbl_rankteam1.Text = scr_teamrank1.Value
    End Sub

    Private Sub scr_teamrank12_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank12.Scroll
        lbl_rankteam12.Text = scr_teamrank12.Value
    End Sub

    Private Sub scr_teamrank20_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank20.Scroll
        lbl_rankteam20.Text = scr_teamrank20.Value
    End Sub

    Private Sub scr_teamrank19_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank19.Scroll
        lbl_rankteam19.Text = scr_teamrank19.Value
    End Sub

    Private Sub scr_teamrank18_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank18.Scroll
        lbl_rankteam18.Text = scr_teamrank18.Value
    End Sub

    Private Sub scr_teamrank17_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank17.Scroll
        lbl_rankteam17.Text = scr_teamrank17.Value
    End Sub

    Private Sub scr_teamrank16_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank16.Scroll
        lbl_rankteam16.Text = scr_teamrank16.Value
    End Sub

    Private Sub scr_teamrank15_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank15.Scroll
        lbl_rankteam15.Text = scr_teamrank15.Value
    End Sub

    Private Sub scr_teamrank14_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank14.Scroll
        lbl_rankteam14.Text = scr_teamrank14.Value
    End Sub

    Private Sub scr_teamrank13_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank13.Scroll
        lbl_rankteam13.Text = scr_teamrank13.Value
    End Sub


    Private Sub scr_teamrank11_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank11.Scroll
        lbl_rankteam11.Text = scr_teamrank11.Value
    End Sub

    Private Sub scr_teamrank10_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank10.Scroll
        lbl_rankteam10.Text = scr_teamrank10.Value
    End Sub

    Private Sub scr_teamrank9_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank9.Scroll
        lbl_rankteam9.Text = scr_teamrank9.Value
    End Sub

    Private Sub scr_teamrank8_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank8.Scroll
        lbl_rankteam8.Text = scr_teamrank8.Value
    End Sub

    Private Sub scr_teamrank7_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank7.Scroll
        lbl_rankteam7.Text = scr_teamrank7.Value
    End Sub

    Private Sub scr_teamrank6_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank6.Scroll
        lbl_rankteam6.Text = scr_teamrank6.Value
    End Sub

    Private Sub scr_teamrank5_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank5.Scroll
        lbl_rankteam5.Text = scr_teamrank5.Value
    End Sub

    Private Sub scr_teamrank4_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank4.Scroll
        lbl_rankteam4.Text = scr_teamrank4.Value
    End Sub

    Private Sub scr_teamrank3_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank3.Scroll
        lbl_rankteam3.Text = scr_teamrank3.Value
    End Sub

    Private Sub scr_teamrank2_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank2.Scroll
        lbl_rankteam2.Text = scr_teamrank2.Value
    End Sub

    Private Sub tbx_team1_TextChanged(sender As Object, e As EventArgs) Handles tbx_team1.TextChanged

    End Sub

    Private Sub btn_back0_Click(sender As Object, e As EventArgs) Handles btn_back0.Click
        mainmenu.Show()
        Me.Close()
    End Sub
End Class