Public Class loading0
    Private Sub tmr_load_Tick(sender As Object, e As EventArgs) Handles tmr_load.Tick
        pgb_programload.Increment(37)
        If pgb_programload.Value = pgb_programload.Maximum Then
            mainmenu.Show()
        End If
    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr_load.Start()
    End Sub
End Class