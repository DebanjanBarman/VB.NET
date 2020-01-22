Public Class Replace
    Dim str1, str2, str3 As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        str1 = TextBox1.Text
        str2 = TextBox2.Text
        str3 = TextBox3.Text
        Label4.Text = str1.Replace(str2, str3)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class