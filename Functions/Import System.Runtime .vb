Imports System.Runtime.InteropServices

Public Class AllFunctions

    ' Base color applied to panels and inactive buttons
    Public Shared basecolor As Color = Color.FromArgb(45, 45, 48)
    ' Accent color used for the selected navigation button
    Public Shared buttoncolor As Color = Color.FromArgb(0, 120, 215)
    ' Standard text colour used across the UI
    Public Shared textcolor As Color = Color.White

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    ' Apply theme colours to the supplied control and its children
    Public Shared Sub ApplyTheme(parent As Control)
        parent.BackColor = basecolor
        ApplyThemeRecursive(parent)
    End Sub

    Private Shared Sub ApplyThemeRecursive(ctrl As Control)
        For Each child As Control In ctrl.Controls
            If TypeOf child Is Button Then
                child.BackColor = basecolor
                child.ForeColor = textcolor
                CType(child, Button).FlatStyle = FlatStyle.Popup
            ElseIf TypeOf child Is Panel Then
                child.BackColor = basecolor
            ElseIf TypeOf child Is Label Then
                child.ForeColor = textcolor
            End If

            If child.HasChildren Then
                ApplyThemeRecursive(child)
            End If
        Next
    End Sub



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
