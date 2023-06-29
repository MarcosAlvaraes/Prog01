Public Class Form3
    Private Sub btnCalcularVolume_Click(sender As Object, e As EventArgs) Handles btnCalcularVolume.Click
        Dim volume As Double
        Try

            volume = Convert.ToDouble(txtBoxAltura.Text) * Convert.ToDouble(txtBoxComprimento.Text) * Convert.ToDouble(txtBoxLargura.Text)

            txtBoxResultadoVolume.Text = volume

            lblAvisoVolume.Visible = False

        Catch ex As Exception

            lblAvisoVolume.Visible = True

            If txtBoxAltura.Text Like String.Empty Or txtBoxComprimento.Text Like String.Empty Or txtBoxLargura.Text Like String.Empty Then

                lblAvisoVolume.Text = "ERRO: Por favor preencha todos os campos!"

            Else

                lblAvisoVolume.Text = "ERRO: Utilize apenas numeros para os calculos!"

            End If

        End Try


    End Sub

    Private Sub btnLimparVolume_Click(sender As Object, e As EventArgs) Handles btnLimparVolume.Click

        lblAvisoVolume.Visible = False

        txtBoxAltura.Text = String.Empty
        txtBoxComprimento.Text = String.Empty
        txtBoxLargura.Text = String.Empty
        txtBoxResultadoVolume.Text = String.Empty

    End Sub

End Class