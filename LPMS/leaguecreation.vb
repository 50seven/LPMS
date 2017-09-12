Imports System
Imports System.IO

Public Module GlobalVariables
    Public teamstable As Integer
End Module

Public Class leaguecreation
    Inherits System.Windows.Forms.Form
    Dim ranktext(20) As TextBox
    Dim count As Long
    Dim teams As String = "teams.txt"
    Dim countrank As Integer
    Dim notnum As Boolean



    Public Class GlobalVariables
        Public Shared noofteams As Integer
    End Class


    'for count = 0 to 'no of teams'
    Private Sub leaguecreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainmenu.Close()
        tbx_rankteam1 = ranktext(0)
        tbx_rankteam2 = ranktext(1)
        tbx_rankteam3 = ranktext(2)
        tbx_rankteam4 = ranktext(3)
        tbx_rankteam5 = ranktext(4)
        tbx_rankteam6 = ranktext(5)
        tbx_rankteam7 = ranktext(6)
        tbx_rankteam8 = ranktext(7)
        tbx_rankteam9 = ranktext(8)
        tbx_rankteam10 = ranktext(9)
        tbx_rankteam11 = ranktext(10)
        tbx_rankteam12 = ranktext(11)
        tbx_rankteam13 = ranktext(12)
        tbx_rankteam14 = ranktext(13)
        tbx_rankteam15 = ranktext(14)
        tbx_rankteam16 = ranktext(15)
        tbx_rankteam17 = ranktext(16)
        tbx_rankteam18 = ranktext(17)
        tbx_rankteam19 = ranktext(18)
        tbx_rankteam20 = ranktext(19)
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
        notnum = True
        For countrank = 0 To 19
            If Not IsNumeric((Val(ranktext(countrank).Text))) Then
                notnum = False
            End If
        Next
        If notnum = True Then
                leaguetable.Show()
                Me.Close()
            Else
                MsgBox("Please enter numbers as the rank")
            End If
    End Sub

    Private Sub scr_teamrank1_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank1.Scroll
        tbx_rankteam1.Text = scr_teamrank1.Value
    End Sub

    Private Sub scr_teamrank12_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank12.Scroll
        tbx_rankteam12.Text = scr_teamrank12.Value
    End Sub

    Private Sub scr_teamrank20_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank20.Scroll
        tbx_rankteam20.Text = scr_teamrank20.Value
    End Sub

    Private Sub scr_teamrank19_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank19.Scroll
        tbx_rankteam19.Text = scr_teamrank19.Value
    End Sub

    Private Sub scr_teamrank18_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank18.Scroll
        tbx_rankteam18.Text = scr_teamrank18.Value
    End Sub

    Private Sub scr_teamrank17_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank17.Scroll
        tbx_rankteam17.Text = scr_teamrank17.Value
    End Sub

    Private Sub scr_teamrank16_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank16.Scroll
        tbx_rankteam16.Text = scr_teamrank16.Value
    End Sub

    Private Sub scr_teamrank15_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank15.Scroll
        tbx_rankteam15.Text = scr_teamrank15.Value
    End Sub

    Private Sub scr_teamrank14_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank14.Scroll
        tbx_rankteam14.Text = scr_teamrank14.Value
    End Sub

    Private Sub scr_teamrank13_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank13.Scroll
        tbx_rankteam13.Text = scr_teamrank13.Value
    End Sub


    Private Sub scr_teamrank11_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank11.Scroll
        tbx_rankteam11.Text = scr_teamrank11.Value
    End Sub

    Private Sub scr_teamrank10_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank10.Scroll
        tbx_rankteam10.Text = scr_teamrank10.Value
    End Sub

    Private Sub scr_teamrank9_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank9.Scroll
        tbx_rankteam9.Text = scr_teamrank9.Value
    End Sub

    Private Sub scr_teamrank8_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank8.Scroll
        tbx_rankteam8.Text = scr_teamrank8.Value
    End Sub

    Private Sub scr_teamrank7_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank7.Scroll
        tbx_rankteam7.Text = scr_teamrank7.Value
    End Sub

    Private Sub scr_teamrank6_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank6.Scroll
        tbx_rankteam6.Text = scr_teamrank6.Value
    End Sub

    Private Sub scr_teamrank5_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank5.Scroll
        tbx_rankteam5.Text = scr_teamrank5.Value
    End Sub

    Private Sub scr_teamrank4_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank4.Scroll
        tbx_rankteam4.Text = scr_teamrank4.Value
    End Sub

    Private Sub scr_teamrank3_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank3.Scroll
        tbx_rankteam3.Text = scr_teamrank3.Value
    End Sub

    Private Sub scr_teamrank2_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank2.Scroll
        tbx_rankteam2.Text = scr_teamrank2.Value
    End Sub

    Private Sub btn_back0_Click(sender As Object, e As EventArgs) Handles btn_back0.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub tbx_rankteam1_TextChanged(sender As Object, e As EventArgs) Handles tbx_rankteam1.TextChanged
        scr_teamrank1.Value = tbx_rankteam1.Text
    End Sub
End Class