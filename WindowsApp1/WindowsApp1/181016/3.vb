Public Class _3
    Private Sub _3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim doremi(7) As String
        Dim i As Integer

        doremi(0) = "도"
        doremi(1) = "레"
        doremi(2) = "미"
        doremi(3) = "파"
        doremi(4) = "솔"
        doremi(5) = "라"
        doremi(6) = "시"

        For i = 0 To 6
            Label1.Text = Label1.Text + doremi(i)
        Next
    End Sub
End Class