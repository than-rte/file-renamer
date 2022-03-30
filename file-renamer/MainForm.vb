Imports System.IO

Public Class MainForm
    Private files() As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnGetFiles_Click(sender As Object, e As EventArgs) Handles btnGetFiles.Click
        loadFilenames()

    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        Select Case True
            Case rbtnRemoveWord.Checked
                removeWord()
            Case rbtnBeginning.Checked
                beginning()
            Case rbtnEnd.Checked
                endRename()
            Case rbtnExtension.Checked
                changeExtension()
        End Select
    End Sub

    Private Sub removeWord()
        For Each fileURL In files
            If fileURL.Contains(tbRename.Text) Then
                Dim newFileURL As String = fileURL.Replace(tbRename.Text, "").Trim
                Dim newFilename As String = newFileURL.Replace(tbUrl.Text + "\", "").Trim
                My.Computer.FileSystem.RenameFile(fileURL, newFileName)
            End If
        Next

        loadFilenames()
    End Sub

    Private Sub beginning()
        For Each fileURL In files
            Dim filename As String = fileURL.Replace(tbUrl.Text + "\", "").Trim
            Dim sb As New System.Text.StringBuilder()
            Dim newFilename As String = sb.Append(tbRename.Text).Append(filename).ToString()
            My.Computer.FileSystem.RenameFile(fileURL, newFilename)
        Next

        loadFilenames()
    End Sub

    Private Sub endRename()
        For Each fileURL In files
            Dim ext As String = Path.GetExtension(fileURL)
            Dim filenameOnly As String = Path.GetFileNameWithoutExtension(fileURL)
            Dim sb As New System.Text.StringBuilder()
            Dim newFilename As String = sb.Append(filenameOnly).Append(tbRename.Text).Append(ext).ToString()
            My.Computer.FileSystem.RenameFile(fileURL, newFilename)
        Next

        loadFilenames()
    End Sub

    Private Sub changeExtension()
        For Each fileURL In files
            Dim filenameOnly As String = Path.GetFileNameWithoutExtension(fileURL)
            Dim sb As New System.Text.StringBuilder()
            Dim newFilename As String = sb.Append(filenameOnly).Append("." + tbRename.Text).ToString()
            My.Computer.FileSystem.RenameFile(fileURL, newFilename)
        Next

        loadFilenames()
    End Sub

    Private Sub loadFilenames()
        lvFilenames.Items.Clear()
        files = IO.Directory.GetFiles(tbUrl.Text)

        For Each fileURL In files
            Dim fi As New FileInfo(fileURL)
            Console.WriteLine(fi.Attributes())
            lvFilenames.Items.Add(fileURL.Replace(tbUrl.Text + "\", "").Trim)
        Next
    End Sub

  
End Class
