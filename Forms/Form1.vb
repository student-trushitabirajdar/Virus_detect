Public Class Form1
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown
        ' Use the System.Windows.Forms enumeration for the mouse button check
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            AllFunctions.ReleaseCapture()
            AllFunctions.SendMessage(Handle, AllFunctions.WM_NCLBUTTONDOWN, AllFunctions.HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        AllFunctions.HomeBotton()
    End Sub

    Private Sub btnProtection_Click(sender As Object, e As EventArgs) Handles btnProtection.Click
        AllFunctions.ProtectionBotton()
    End Sub

    Private Sub btnPrivacy_Click(sender As Object, e As EventArgs) Handles btnPrivacy.Click
        AllFunctions.PrivacyBotton()
    End Sub

    Private Sub btnManager_Click(sender As Object, e As EventArgs) Handles btnManager.Click
        AllFunctions.ManagerBotton()
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        AllFunctions.ResultsBotton()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmColse.ShowDialog()
    End Sub
End Class

