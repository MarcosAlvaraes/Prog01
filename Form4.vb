Public Class Form4

    Dim resultado As Double
    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click

        resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) + Convert.ToDouble(txtBoxSegundoNumero.Text)
        txtResultadoOperacao.Text = resultado

    End Sub

    Private Sub btnSubtracao_Click(sender As Object, e As EventArgs) Handles btnSubtracao.Click
        resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) - Convert.ToDouble(txtBoxSegundoNumero.Text)
        txtResultadoOperacao.Text = resultado
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) * Convert.ToDouble(txtBoxSegundoNumero.Text)
        txtResultadoOperacao.Text = resultado
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) / Convert.ToDouble(txtBoxSegundoNumero.Text)
        txtResultadoOperacao.Text = resultado
    End Sub
End Class