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
        ranktext(0) = tbx_teamrank1
        ranktext(1) = tbx_teamrank2
        ranktext(2) = tbx_teamrank3
        ranktext(3) = tbx_teamrank4
        ranktext(4) = tbx_teamrank5
        ranktext(5) = tbx_teamrank6
        ranktext(6) = tbx_teamrank7
        ranktext(7) = tbx_teamrank8
        ranktext(8) = tbx_teamrank9
        ranktext(9) = tbx_teamrank10
        ranktext(10) = tbx_teamrank11
        ranktext(11) = tbx_teamrank12
        ranktext(12) = tbx_teamrank13
        ranktext(13) = tbx_teamrank14
        ranktext(14) = tbx_teamrank15
        ranktext(15) = tbx_teamrank16
        ranktext(16) = tbx_teamrank17
        ranktext(17) = tbx_teamrank18
        ranktext(18) = tbx_teamrank19
        ranktext(19) = tbx_teamrank20
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
            outputfile.WriteLine(tbx_teamrank1.Text)
            outputfile.WriteLine(tbx_teamrank2.Text)
            outputfile.WriteLine(tbx_teamrank3.Text)
            outputfile.WriteLine(tbx_teamrank4.Text)
            outputfile.WriteLine(tbx_teamrank5.Text)
            outputfile.WriteLine(tbx_teamrank6.Text)
            outputfile.WriteLine(tbx_teamrank7.Text)
            outputfile.WriteLine(tbx_teamrank8.Text)
            outputfile.WriteLine(tbx_teamrank9.Text)
            outputfile.WriteLine(tbx_teamrank10.Text)
            outputfile.WriteLine(tbx_teamrank11.Text)
            outputfile.WriteLine(tbx_teamrank12.Text)
            outputfile.WriteLine(tbx_teamrank13.Text)
            outputfile.WriteLine(tbx_teamrank14.Text)
            outputfile.WriteLine(tbx_teamrank15.Text)
            outputfile.WriteLine(tbx_teamrank16.Text)
            outputfile.WriteLine(tbx_teamrank17.Text)
            outputfile.WriteLine(tbx_teamrank18.Text)
            outputfile.WriteLine(tbx_teamrank19.Text)
            outputfile.WriteLine(tbx_teamrank20.Text)
            outputfile.Close()
        Else
            Dim outputfile As StreamWriter
            outputfile = File.CreateText("rank.txt")
            outputfile = My.Computer.FileSystem.OpenTextFileWriter("rank.txt", True)
            outputfile.WriteLine(tbx_teamrank1.Text)
            outputfile.WriteLine(tbx_teamrank2.Text)
            outputfile.WriteLine(tbx_teamrank3.Text)
            outputfile.WriteLine(tbx_teamrank4.Text)
            outputfile.WriteLine(tbx_teamrank5.Text)
            outputfile.WriteLine(tbx_teamrank6.Text)
            outputfile.WriteLine(tbx_teamrank7.Text)
            outputfile.WriteLine(tbx_teamrank8.Text)
            outputfile.WriteLine(tbx_teamrank9.Text)
            outputfile.WriteLine(tbx_teamrank10.Text)
            outputfile.WriteLine(tbx_teamrank11.Text)
            outputfile.WriteLine(tbx_teamrank12.Text)
            outputfile.WriteLine(tbx_teamrank13.Text)
            outputfile.WriteLine(tbx_teamrank14.Text)
            outputfile.WriteLine(tbx_teamrank15.Text)
            outputfile.WriteLine(tbx_teamrank16.Text)
            outputfile.WriteLine(tbx_teamrank17.Text)
            outputfile.WriteLine(tbx_teamrank18.Text)
            outputfile.WriteLine(tbx_teamrank19.Text)
            outputfile.WriteLine(tbx_teamrank20.Text)
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

    Private Sub btn_back0_Click(sender As Object, e As EventArgs) Handles btn_back0.Click
        mainmenu.Show()
        Me.Close()
    End Sub


End Class