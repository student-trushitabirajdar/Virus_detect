Imports System.Runtime.InteropServices
Imports System.Drawing

Public Class AllFunctions
    
    Public Shared basecolor As Color = Color.FromArgb(28, 114, 157)
    Public Shared buttoncolor As Color = Color.FromArgb(102, 50, 173)

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2




    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, lParam As Integer) As Integer

    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean

    End Function

    Public Shared Sub HomeBotton()
        With Form1
            .btnHome.BackColor = buttoncolor
            .btnManager.BackColor = basecolor
            .btnPrivacy.BackColor = basecolor
            .btnProtection.BackColor = basecolor
            .btnResults.BackColor = basecolor
            .CtlHome1.BringToFront()
        End With
    End Sub

    Public Shared Sub ManagerBotton()
        With Form1
            .btnHome.BackColor = basecolor
            .btnManager.BackColor = buttoncolor
            .btnPrivacy.BackColor = basecolor
            .btnProtection.BackColor = basecolor
            .btnResults.BackColor = basecolor
            .CtlHome1.BringToFront()
        End With
    End Sub

    Public Shared Sub PrivacyBotton()
        With Form1
            .btnHome.BackColor = basecolor
            .btnManager.BackColor = basecolor
            .btnPrivacy.BackColor = buttoncolor
            .btnProtection.BackColor = basecolor
            .btnResults.BackColor = basecolor
            .CtlHome1.BringToFront()
        End With
    End Sub

    Public Shared Sub ProtectionBotton()
        With Form1
            .btnHome.BackColor = basecolor
            .btnManager.BackColor = basecolor
            .btnPrivacy.BackColor = basecolor
            .btnProtection.BackColor = buttoncolor
            .btnResults.BackColor = basecolor
            .btnResults.BackColor = basecolor
            .CtlProtection1.BringToFront()
        End With
    End Sub

    Public Shared Sub ResultsBotton()
        With Form1
            .btnHome.BackColor = basecolor
            .btnManager.BackColor = basecolor
            .btnPrivacy.BackColor = basecolor
            .btnProtection.BackColor = basecolor
            .btnResults.BackColor = buttoncolor
            .CtlHome1.BringToFront()
        End With
    End Sub

End Class
