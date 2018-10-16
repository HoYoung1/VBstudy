Public Class Form11
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim temp As String
        temp = TextBox1.Text
        ListBox1.Items.Add(temp)
        TextBox1.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Add(ListBox1.Text)
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox1.Items.Add(ListBox2.Text)
        ListBox2.Items.Remove(ListBox2.Text)
    End Sub
End Class