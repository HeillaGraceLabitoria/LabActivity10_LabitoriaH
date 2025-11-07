Imports System.IO

Public Class Form1

    Dim filePath As String = "sample.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine(NumericUpDown1.Value)
            End Using
            ListBox1.Items.Add(NumericUpDown1.Value)
            MessageBox.Show("Data written successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Not File.Exists(filePath) Then
                File.Create(filePath).Close()
            End If
            Using reader As New StreamReader(filePath)
                Dim content As String = reader.ReadToEnd
                MessageBox.Show("File Content:" & vbCrLf & content)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Not File.Exists(filePath) Then
                File.Create(filePath).Close()
            End If
            ListBox1.Items.Clear()
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    ListBox1.Items.Add(reader.ReadLine())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class