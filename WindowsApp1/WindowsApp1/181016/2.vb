Public Class _2
    Dim i As Integer
    Dim nname(3) As String
    Dim score(3) As Integer
    Private Sub _2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        i = 0
        TextBox1.Text = i + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = i + 1
        TextBox2.Text = ""
        TextBox3.Text = ""
        If i > 2 Then
            MsgBox("입력이 불가능합니다")
        Else

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or i > 2 Then
            MsgBox("입력이 불가능합니다")
        Else
            nname(i) = TextBox2.Text
            score(i) = TextBox3.Text

            MsgBox("저장되었습니다")
            i = i + 1
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim temp As Integer = TextBox4.Text
        temp = temp - 1
        If temp >= i Then
            MsgBox("검색할수없습니다")
        Else
            TextBox2.Text = Name(temp)
            TextBox3.Text = score(temp)
        End If

    End Sub
End Class