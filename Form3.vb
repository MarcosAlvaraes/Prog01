Public Class Form3
    Private Sub btnCalcularVolume_Click(sender As Object, e As EventArgs) Handles btnCalcularVolume.Click
        Dim volume As Double

        volume = Convert.ToDouble(txtBoxAltura.Text) * Convert.ToDouble(txtBoxComprimento.Text) * Convert.ToDouble(txtBoxLargura.Text)

        txtBoxResultadoVolume.Text = volume

    End Sub
End Class