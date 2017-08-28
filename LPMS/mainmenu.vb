Public Class mainmenu
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading0.Close()
    End Sub

    Private Sub btn_newleague_Click(sender As Object, e As EventArgs) Handles btn_newleague.Click
        leaguecreation.Show()
    End Sub
End Class
