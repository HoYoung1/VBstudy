﻿Public Class Form12
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox2
            .Items.Add("서울특별시")
            .Items.Add("인천광역시")
            .Items.Add("대전광역시")
            .Items.Add("대구광역시")
            .Items.Add("부산광역시")
            .Items.Add("광주광역시")
            .Items.Add("울산광역시")
            .Items.Add("경기도")
            .Items.Add("충청도")
            .Items.Add("강원도")
            .Items.Add("경상도")
            .Items.Add("전라도")
            .Items.Add("제주도")
            .Text = .Items(0)
        End With

        ComboBox1.Text = ComboBox1.Items(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(ComboBox1.Text + TextBox1.Text + "님은 " + ComboBox2.Text + "에 거주하십니다")

    End Sub
End Class