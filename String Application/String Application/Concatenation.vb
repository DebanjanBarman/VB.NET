Public Class Concatenation
    Dim a, b As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = TextBox2.Text
        b = TextBox3.Text
        Label4.Text = a + " " + b
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Form1.Show()
        Me.Hide()
    End Sub
End Class