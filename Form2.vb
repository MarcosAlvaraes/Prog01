Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aux As String

        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            aux = TextBox1.Text
            TextBox1.Text = TextBox2.Text
            TextBox2.Text = aux
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            TextBox3.Text = TextBox1.Text + " " + TextBox2.Text
        End If
    End Sub

    Private Sub btnLimparNomes_Click(sender As Object, e As EventArgs) Handles btnLimparNomes.Click

        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty

    End Sub

End Class