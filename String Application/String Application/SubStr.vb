Public Class SubStr
    Dim str As String
    Dim a, b As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        str = TextBox1.Text
        a = TextBox2.Text
        b = TextBox3.Text
        Label4.Text = str.Substring(a - 1, b)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class