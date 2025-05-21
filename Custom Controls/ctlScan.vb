Imports System.IO
Imports System.Security.Cryptography
Imports System.Text



Public Class ctlScan

    Private md5Hashes As New HashSet(Of String)()
    Private Const Md5HashFilePath As String = "main.db"
    ' Collection of known malicious file hashes loaded from disk
    Private TargetMd5Hashes As List(Of String)
    Private FileHash As String

    Private Sub LoadTargetMd5Hashes()

        TargetMd5Hashes = New List(Of String)
        If File.Exists(Md5HashFilePath) Then
            TargetMd5Hashes.AddRange(File.ReadLines(Md5HashFilePath))
        Else
            MessageBox.Show("MD5 hash file does not exist!")
        End If

    End Sub
    Private Function CalculateMD5(filePath As String) As String
        Using md5 As MD5 = MD5.Create()
            Using stream As FileStream = File.OpenRead(filePath)
                Dim hashBytes As Byte() = md5.ComputeHash(stream)
                Dim hashStringBuilder As New StringBuilder()

                For Each hashByte As Byte In hashBytes
                    hashStringBuilder.Append(hashByte.ToString("x2"))
                Next
                Return hashStringBuilder.ToString()
            End Using

        End Using
    End Function

    Private Sub AddItemToListView(fileName As String, status As String, fileType As String, itemColor As Color)
        Dim item As New ListViewItem(fileName)
        item.SubItems.Add(fileType)
        item.SubItems.Add(status)
        item.ForeColor = itemColor
        ListView1.Items.Add(item)
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.CtlScan1.SendToBack()
    End Sub


    Private Sub btnDeepScan_Click(sender As Object, e As EventArgs) Handles btnDeepScan.Click
        ' Use the built-in DialogResult enumeration
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ListBox1.Items.Clear()
            ListView1.Items.Clear()
        Else
            Exit Sub
        End If
        On Error Resume Next

        For Each strFile As String In System.IO.Directory.GetFiles(FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.AllDirectories)
            ListBox1.Items.Add(strFile)
        Next
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadTargetMd5Hashes()
        ProgressBar1.Maximum = ListBox1.Items.Count

        If ProgressBar1.Value < ProgressBar1.Maximum Then
            Try
                ListBox1.SelectedIndex += 1
                lblLast.Text = ListBox1.SelectedItem.ToString()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            Try
                Dim currentFile As String = ListBox1.SelectedItem.ToString()
                Dim fileExtension As String = Path.GetExtension(currentFile).ToLower()
                FileHash = CalculateMD5(currentFile)
                If TargetMd5Hashes.Contains(FileHash) Then
                    AddItemToListView(ListBox1.SelectedItem.ToString(), "Threat", fileExtension, Color.Red)
                Else
                    AddItemToListView(ListBox1.SelectedItem.ToString(), "Clean", fileExtension, Color.Green)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ProgressBar1.Increment(1)
            ProgressBar2.Increment(1)
        Else
            ListView1.Enabled = True
            Timer1.Stop()
            ProgressBar1.Value = 0
            ProgressBar2.Value = 0
        End If
    End Sub
End Class
