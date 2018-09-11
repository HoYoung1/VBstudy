Public Class Form6
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Text 속성"
        TextBox2.Text = "보여요"
        TextBox2.Visible = True
        TextBox3.BackColor = Color.Green
        TextBox4.PasswordChar = "%"
    End Sub
End Class