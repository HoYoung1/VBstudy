Public Class Form9
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            PictureBox1.Image = New Bitmap("C:\Users\USER\Desktop\grand.jpg")

        ElseIf RadioButton2.Checked Then
            PictureBox1.Image = New Bitmap("C:\Users\USER\Desktop\lighthouse.gif")
        ElseIf RadioButton3.Checked Then
            PictureBox1.Image = New Bitmap("C:\Users\USER\Desktop\yosemity.jpg")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub
End Class