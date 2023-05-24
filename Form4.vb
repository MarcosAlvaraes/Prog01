Public Class Form4

    Dim resultado As Double

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click

        Try

            resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) + Convert.ToDouble(txtBoxSegundoNumero.Text)
            txtResultadoOperacao.Text = resultado

            lblAviso.Visible = False

        Catch ex As Exception

            lblAviso.Visible = True

            If txtBoxPrimeiroNumero.Text Like String.Empty Or txtBoxSegundoNumero.Text Like String.Empty Then

                lblAviso.Text = "ERRO: Por favor introduza ambos os numeros!"

            Else

                lblAviso.Text = "ERRO: Utilize apenas numeros para os calculos!"

            End If

        End Try


    End Sub

    Private Sub btnSubtracao_Click(sender As Object, e As EventArgs) Handles btnSubtracao.Click

        Try

            resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) - Convert.ToDouble(txtBoxSegundoNumero.Text)
            txtResultadoOperacao.Text = resultado
            lblAviso.Visible = False

        Catch ex As Exception

            lblAviso.Visible = True

            If txtBoxPrimeiroNumero.Text Like String.Empty Or txtBoxSegundoNumero.Text Like String.Empty Then

                lblAviso.Text = "ERRO: Por favor introduza ambos os numeros!"

            Else

                lblAviso.Text = "ERRO: Utilize apenas numeros para os calculos!"

            End If

        End Try
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click

        Try

            resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) * Convert.ToDouble(txtBoxSegundoNumero.Text)
            txtResultadoOperacao.Text = resultado
            lblAviso.Visible = False

        Catch ex As Exception

            lblAviso.Visible = True

            If txtBoxPrimeiroNumero.Text Like String.Empty Or txtBoxSegundoNumero.Text Like String.Empty Then

                lblAviso.Text = "ERRO: Por favor introduza ambos os numeros!"

            Else

                lblAviso.Text = "ERRO: Utilize apenas numeros para os calculos!"

            End If

        End Try

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click

        Try

            resultado = Convert.ToDouble(txtBoxPrimeiroNumero.Text) / Convert.ToDouble(txtBoxSegundoNumero.Text)
            txtResultadoOperacao.Text = resultado
            lblAviso.Visible = False

        Catch ex As Exception

            lblAviso.Visible = True

            If txtBoxPrimeiroNumero.Text Like String.Empty Or txtBoxSegundoNumero.Text Like String.Empty Then

                lblAviso.Text = "ERRO: Por favor introduza ambos os numeros!"

            Else

                lblAviso.Text = "ERRO: Utilize apenas numeros para os calculos!"

            End If

        End Try

    End Sub
End Class