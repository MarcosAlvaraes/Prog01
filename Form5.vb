Imports System.Runtime.CompilerServices

Public Class Form5
    Private Sub btnMostrarLegenda_Click(sender As Object, e As EventArgs) Handles btnMostrarLegenda.Click

        lblLegendaTestes.Show()

    End Sub

    Private Sub btnEsconder_Click(sender As Object, e As EventArgs) Handles btnEsconder.Click
        lblLegendaTestes.Hide()
    End Sub

    Private Sub btnMudarCorFundoLegenda_Click(sender As Object, e As EventArgs) Handles btnMudarCorFundoLegenda.Click

        lblLegendaTestes.BackColor = Color.FromArgb(Int((255 * Rnd()) + 0), Int((255 * Rnd()) + 0), Int((255 * Rnd()) + 0))

    End Sub

    Private Sub btnMudarCorFundoFormulario_Click(sender As Object, e As EventArgs) Handles btnMudarCorFundoFormulario.Click

        Me.BackColor = Color.FromArgb(Int((255 * Rnd()) + 0), Int((255 * Rnd()) + 0), Int((255 * Rnd()) + 0))

    End Sub

    Private Sub btnEscrevcerNumeroNaLegenda_Click(sender As Object, e As EventArgs) Handles btnEscrevcerNumeroNaLegenda.Click

        Dim MyValue As Integer
        MyValue = Int((100 * Rnd()) + 1)

        lblLegendaTestes.Text = Int((100 * Rnd()) + 1)
    End Sub
End Class