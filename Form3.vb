Public Class Form3
    Private Sub btnCalcularVolume_Click(sender As Object, e As EventArgs) Handles btnCalcularVolume.Click
        Dim volume As Double

        volume = Convert.ToInt32(txtBoxAltura.Text) * Convert.ToInt32(txtBoxComprimento.Text) * Convert.ToInt32(txtBoxLargura.Text)

        txtBoxResultadoVolume.Text = volume

    End Sub
End Class