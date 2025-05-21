Public Class ctlHome
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.CtlScan1.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.CtlScan1.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.CtlScan1.BringToFront()
    End Sub

    Private Sub ctlHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AllFunctions.ApplyTheme(Me)
    End Sub
End Class
