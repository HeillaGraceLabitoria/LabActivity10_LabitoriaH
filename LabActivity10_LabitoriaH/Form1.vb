Imports System.IO

Public Class Form1
    Dim filePath As String = "sample.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            Using writer As New StreamWriter(filePath, True) 'true append
                ListBox1.Items.Add(NumericUpDown1.Text)

            End Using
            MessageBox.Show("Data written successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Using reader As New StreamReader(filePath)
            Dim content As String = reader.ReadToEnd
            MessageBox.Show("File Content: " + content + ListBox1.Items.Add(NumericUpDown1.Text))

        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Using reader As New StreamReader(filePath)
            Dim line As String
            line = reader.ReadLine()
            While (line IsNot Nothing)
                ListBox1.Items.Add(line)
                line = reader.ReadLine()
            End While
        End Using
    End Sub
End Class
