Imports System
Imports System.IO

Public Class leaguecreation
    Inherits System.Windows.Forms.Form
    Dim tempfile As String
    Dim teamsText(24) As TextBox
    Dim teamsScroll(24) As ScrollBar
    Dim teamsLabel(24) As Label
    Dim count As Long
    Dim teams As String = "C:\Users\ker0017\Documents\School\Year 12\Software Development\Unit 3\LPMS\LPMS\bin\Debug\teams.txt"

    Public Class GlobalVariables
        Public Shared noofteams As Integer
    End Class


    'for count = 0 to 'no of teams'
    Private Sub leaguecreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainmenu.Close()
        teamsText(0) = tbx_team1
        teamsText(1) = tbx_team2
        teamsText(2) = tbx_team3
        teamsText(3) = tbx_team4
        teamsText(4) = tbx_team5
        teamsText(5) = tbx_team6
        teamsText(6) = tbx_team7
        teamsText(7) = tbx_team8
        teamsText(8) = tbx_team9
        teamsText(9) = tbx_team10
        teamsText(10) = tbx_team11
        teamsText(11) = tbx_team12
        teamsText(12) = tbx_team13
        teamsText(13) = tbx_team14
        teamsText(14) = tbx_team15
        teamsText(15) = tbx_team16
        teamsText(16) = tbx_team17
        teamsText(17) = tbx_team18
        teamsText(18) = tbx_team19
        teamsText(19) = tbx_team20
        teamsText(20) = tbx_team21
        teamsText(21) = tbx_team22
        teamsText(22) = tbx_team23
        teamsText(23) = tbx_team24
        teamsScroll(0) = scr_teamrank1
        teamsScroll(1) = scr_teamrank2
        teamsScroll(2) = scr_teamrank3
        teamsScroll(3) = scr_teamrank4
        teamsScroll(4) = scr_teamrank5
        teamsScroll(5) = scr_teamrank6
        teamsScroll(6) = scr_teamrank7
        teamsScroll(7) = scr_teamrank8
        teamsScroll(8) = scr_teamrank9
        teamsScroll(9) = scr_teamrank10
        teamsScroll(10) = scr_teamrank11
        teamsScroll(11) = scr_teamrank12
        teamsScroll(12) = scr_teamrank13
        teamsScroll(13) = scr_teamrank14
        teamsScroll(14) = scr_teamrank15
        teamsScroll(15) = scr_teamrank16
        teamsScroll(16) = scr_teamrank17
        teamsScroll(17) = scr_teamrank18
        teamsScroll(18) = scr_teamrank19
        teamsScroll(19) = scr_teamrank20
        teamsScroll(20) = scr_teamrank21
        teamsScroll(21) = scr_teamrank22
        teamsScroll(22) = scr_teamrank23
        teamsScroll(23) = scr_teamrank24
        teamsLabel(0) = lbl_rankteam1
        teamsLabel(1) = lbl_rankteam2
        teamsLabel(2) = lbl_rankteam3
        teamsLabel(3) = lbl_rankteam4
        teamsLabel(4) = lbl_rankteam5
        teamsLabel(5) = lbl_rankteam6
        teamsLabel(6) = lbl_rankteam7
        teamsLabel(7) = lbl_rankteam8
        teamsLabel(8) = lbl_rankteam9
        teamsLabel(9) = lbl_rankteam10
        teamsLabel(10) = lbl_rankteam11
        teamsLabel(11) = lbl_rankteam12
        teamsLabel(12) = lbl_rankteam13
        teamsLabel(13) = lbl_rankteam14
        teamsLabel(14) = lbl_rankteam15
        teamsLabel(15) = lbl_rankteam16
        teamsLabel(16) = lbl_rankteam17
        teamsLabel(17) = lbl_rankteam18
        teamsLabel(18) = lbl_rankteam19
        teamsLabel(19) = lbl_rankteam20
        teamsLabel(20) = lbl_rankteam21
        teamsLabel(21) = lbl_rankteam22
        teamsLabel(22) = lbl_rankteam23
        teamsLabel(23) = lbl_rankteam24

        tbx_team1.Visible = 0
        tbx_team2.Visible = 0
        tbx_team3.Visible = 0
        tbx_team4.Visible = 0
        tbx_team5.Visible = 0
        tbx_team6.Visible = 0
        tbx_team7.Visible = 0
        tbx_team8.Visible = 0
        tbx_team9.Visible = 0
        tbx_team10.Visible = 0
        tbx_team11.Visible = 0
        tbx_team12.Visible = 0
        tbx_team13.Visible = 0
        tbx_team14.Visible = 0
        tbx_team15.Visible = 0
        tbx_team16.Visible = 0
        tbx_team17.Visible = 0
        tbx_team18.Visible = 0
        tbx_team19.Visible = 0
        tbx_team20.Visible = 0
        tbx_team21.Visible = 0
        tbx_team22.Visible = 0
        tbx_team23.Visible = 0
        tbx_team24.Visible = 0
        scr_teamrank1.Visible = 0
        scr_teamrank2.Visible = 0
        scr_teamrank3.Visible = 0
        scr_teamrank4.Visible = 0
        scr_teamrank5.Visible = 0
        scr_teamrank6.Visible = 0
        scr_teamrank7.Visible = 0
        scr_teamrank8.Visible = 0
        scr_teamrank9.Visible = 0
        scr_teamrank10.Visible = 0
        scr_teamrank11.Visible = 0
        scr_teamrank12.Visible = 0
        scr_teamrank13.Visible = 0
        scr_teamrank14.Visible = 0
        scr_teamrank15.Visible = 0
        scr_teamrank16.Visible = 0
        scr_teamrank17.Visible = 0
        scr_teamrank18.Visible = 0
        scr_teamrank19.Visible = 0
        scr_teamrank20.Visible = 0
        scr_teamrank21.Visible = 0
        scr_teamrank22.Visible = 0
        scr_teamrank23.Visible = 0
        scr_teamrank24.Visible = 0
        lbl_rankteam1.Visible = 0
        lbl_rankteam2.Visible = 0
        lbl_rankteam3.Visible = 0
        lbl_rankteam4.Visible = 0
        lbl_rankteam5.Visible = 0
        lbl_rankteam6.Visible = 0
        lbl_rankteam7.Visible = 0
        lbl_rankteam8.Visible = 0
        lbl_rankteam9.Visible = 0
        lbl_rankteam10.Visible = 0
        lbl_rankteam11.Visible = 0
        lbl_rankteam12.Visible = 0
        lbl_rankteam13.Visible = 0
        lbl_rankteam14.Visible = 0
        lbl_rankteam15.Visible = 0
        lbl_rankteam16.Visible = 0
        lbl_rankteam17.Visible = 0
        lbl_rankteam18.Visible = 0
        lbl_rankteam19.Visible = 0
        lbl_rankteam20.Visible = 0
        lbl_rankteam21.Visible = 0
        lbl_rankteam22.Visible = 0
        lbl_rankteam23.Visible = 0
        lbl_rankteam24.Visible = 0
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
            outputfile.WriteLine(tbx_team21.Text)
            outputfile.WriteLine(tbx_team22.Text)
            outputfile.WriteLine(tbx_team23.Text)
            outputfile.WriteLine(tbx_team24.Text)
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
            outputfile.WriteLine(tbx_team21.Text)
            outputfile.WriteLine(tbx_team22.Text)
            outputfile.WriteLine(tbx_team23.Text)
            outputfile.WriteLine(tbx_team24.Text)
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
            outputfile.WriteLine(scr_teamrank21)
            outputfile.WriteLine(scr_teamrank22)
            outputfile.WriteLine(scr_teamrank23)
            outputfile.WriteLine(scr_teamrank24)
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
            outputfile.WriteLine(scr_teamrank21.Value)
            outputfile.WriteLine(scr_teamrank22.Value)
            outputfile.WriteLine(scr_teamrank23.Value)
            outputfile.WriteLine(scr_teamrank24.Value)
            outputfile.Close()
        End If
        ' MsgBox("Exiting League Creation")
        leaguetable.Show()
        Me.Close()
        ' MsgBox("Exiting League Creation")



    End Sub

    Private Sub cmb_noofteams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_noofteams.SelectedIndexChanged
        If cmb_noofteams.Text = 6 Then
            For count = 0 To 5 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 8 Then
            For count = 0 To 7 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 10 Then
            For count = 0 To 9 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 12 Then
            For count = 0 To 11 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 14 Then
            For count = 0 To 13 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 16 Then
            For count = 0 To 15 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 18 Then
            For count = 0 To 17 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 20 Then
            For count = 0 To 19 'counts to the number of objects to be displayed + 1 
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 22 Then
            For count = 0 To 21 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        ElseIf cmb_noofteams.Text = 24 Then
            For count = 0 To 23 'counts to the number of objects to be displayed + 1
                teamsText(count).Visible = True
                teamsScroll(count).Visible = True
                teamsLabel(count).Visible = True
            Next

        End If
    End Sub

    Private Sub scr_teamrank1_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank1.Scroll
        lbl_rankteam1.Text = scr_teamrank1.Value
    End Sub

    Private Sub scr_teamrank12_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank12.Scroll
        lbl_rankteam12.Text = scr_teamrank12.Value
    End Sub

    Private Sub scr_teamrank24_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank24.Scroll
        lbl_rankteam24.Text = scr_teamrank24.Value
    End Sub

    Private Sub scr_teamrank23_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank23.Scroll
        lbl_rankteam23.Text = scr_teamrank23.Value
    End Sub

    Private Sub scr_teamrank22_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank22.Scroll
        lbl_rankteam22.Text = scr_teamrank22.Value
    End Sub

    Private Sub scr_teamrank21_Scroll(sender As Object, e As ScrollEventArgs) Handles scr_teamrank21.Scroll
        lbl_rankteam21.Text = scr_teamrank21.Value
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