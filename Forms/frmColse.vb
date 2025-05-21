Public Class frmColse
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Exit Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub frmColse_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown
        ' Use the System.Windows.Forms enumeration for the mouse button check
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            AllFunctions.ReleaseCapture()
            AllFunctions.SendMessage(Handle, AllFunctions.WM_NCLBUTTONDOWN, AllFunctions.HT_CAPTION, 0)
        End If
    End Sub
End Class