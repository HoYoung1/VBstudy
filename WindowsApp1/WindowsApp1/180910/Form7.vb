Public Class Form7
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chk주황.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selected_list As String
        If chk빨강.Checked = True Then selected_list = chk빨강.Text & Chr(13)
        If chk주황.Checked = True Then selected_list = selected_list + chk주황.Text & Chr(13)
        If chk노랑.Checked = True Then selected_list = selected_list + chk노랑.Text & Chr(13)
        If chk초록.Checked = True Then selected_list = selected_list + chk초록.Text & Chr(13)
        If chk파랑.Checked = True Then selected_list = selected_list + chk파랑.Text & Chr(13)
        If chk보라.Checked = True Then selected_list = selected_list + chk보라.Text & Chr(13)

        lab선택목록.Text = selected_list
    End Sub
End Class