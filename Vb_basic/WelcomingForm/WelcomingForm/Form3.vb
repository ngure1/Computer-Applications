Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3

    Private Sub Garamond_CheckedChanged(sender As Object, e As EventArgs) Handles Garamond.CheckedChanged
        TextBox.Font = New Font("Garamond", TextBox.Font.Size, TextBox.Font.Style)
    End Sub

    Private Sub Magento_CheckedChanged(sender As Object, e As EventArgs) Handles Magento.CheckedChanged
        TextBox.Font = New Font("Magento", TextBox.Font.Size, TextBox.Font.Style)
    End Sub

    Private Sub Tahoma_CheckedChanged(sender As Object, e As EventArgs) Handles Tahoma.CheckedChanged
        TextBox.Font = New Font("Tahoma", TextBox.Font.Size, TextBox.Font.Style)
    End Sub

    Private Sub ItalicBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicBox.CheckedChanged
        TextBox.Font = New Font(TextBox.Font.FontFamily, TextBox.Font.Size, FontStyle.Italic)
    End Sub

    Private Sub BoldBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldBox.CheckedChanged
        TextBox.Font = New Font(TextBox.Font.FontFamily, TextBox.Font.Size, FontStyle.Bold)
    End Sub

    Private Sub BoldItalicBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicBox.CheckedChanged
        TextBox.Font = New Font(TextBox.Font.FontFamily, TextBox.Font.Size, FontStyle.Bold Or FontStyle.Italic)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog.Title = "Select an Image File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

        Dim form1 As New Form1()

        form1.Show()

    End Sub

    Private Sub TextRed_CheckedChanged(sender As Object, e As EventArgs) Handles TextRed.CheckedChanged
        TextBox.ForeColor = Color.Red
    End Sub

    Private Sub TextBlue_CheckedChanged(sender As Object, e As EventArgs) Handles TextBlue.CheckedChanged
        TextBox.ForeColor = Color.Blue
    End Sub

    Private Sub TextGreen_CheckedChanged(sender As Object, e As EventArgs) Handles TextGreen.CheckedChanged
        TextBox.ForeColor = Color.Green
    End Sub
End Class