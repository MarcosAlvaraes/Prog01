<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPrimeiroNumero = New System.Windows.Forms.Label()
        Me.lblSegundoNumero = New System.Windows.Forms.Label()
        Me.txtBoxPrimeiroNumero = New System.Windows.Forms.TextBox()
        Me.txtBoxSegundoNumero = New System.Windows.Forms.TextBox()
        Me.lblCalculo = New System.Windows.Forms.Label()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.btnSubtracao = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtResultadoOperacao = New System.Windows.Forms.TextBox()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrimeiroNumero
        '
        Me.lblPrimeiroNumero.AutoSize = True
        Me.lblPrimeiroNumero.Location = New System.Drawing.Point(33, 115)
        Me.lblPrimeiroNumero.Name = "lblPrimeiroNumero"
        Me.lblPrimeiroNumero.Size = New System.Drawing.Size(68, 15)
        Me.lblPrimeiroNumero.TabIndex = 0
        Me.lblPrimeiroNumero.Text = "1º Numero:"
        '
        'lblSegundoNumero
        '
        Me.lblSegundoNumero.AutoSize = True
        Me.lblSegundoNumero.Location = New System.Drawing.Point(33, 159)
        Me.lblSegundoNumero.Name = "lblSegundoNumero"
        Me.lblSegundoNumero.Size = New System.Drawing.Size(71, 15)
        Me.lblSegundoNumero.TabIndex = 1
        Me.lblSegundoNumero.Text = "2º Numero: "
        '
        'txtBoxPrimeiroNumero
        '
        Me.txtBoxPrimeiroNumero.Location = New System.Drawing.Point(107, 112)
        Me.txtBoxPrimeiroNumero.Name = "txtBoxPrimeiroNumero"
        Me.txtBoxPrimeiroNumero.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxPrimeiroNumero.TabIndex = 2
        '
        'txtBoxSegundoNumero
        '
        Me.txtBoxSegundoNumero.Location = New System.Drawing.Point(107, 156)
        Me.txtBoxSegundoNumero.Name = "txtBoxSegundoNumero"
        Me.txtBoxSegundoNumero.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxSegundoNumero.TabIndex = 3
        '
        'lblCalculo
        '
        Me.lblCalculo.AutoSize = True
        Me.lblCalculo.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCalculo.Location = New System.Drawing.Point(38, 28)
        Me.lblCalculo.Name = "lblCalculo"
        Me.lblCalculo.Size = New System.Drawing.Size(169, 54)
        Me.lblCalculo.TabIndex = 4
        Me.lblCalculo.Text = "Calculos"
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(33, 207)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(75, 23)
        Me.btnSoma.TabIndex = 5
        Me.btnSoma.Text = "Somar"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'btnSubtracao
        '
        Me.btnSubtracao.Location = New System.Drawing.Point(132, 207)
        Me.btnSubtracao.Name = "btnSubtracao"
        Me.btnSubtracao.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtracao.TabIndex = 6
        Me.btnSubtracao.Text = "Subtrair"
        Me.btnSubtracao.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(33, 256)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 7
        Me.btnMultiplicar.Text = "Multiplicar"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(132, 256)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 23)
        Me.btnDividir.TabIndex = 8
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(33, 308)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(62, 15)
        Me.lblResultado.TabIndex = 9
        Me.lblResultado.Text = "Resultado:"
        '
        'txtResultadoOperacao
        '
        Me.txtResultadoOperacao.Location = New System.Drawing.Point(101, 305)
        Me.txtResultadoOperacao.Name = "txtResultadoOperacao"
        Me.txtResultadoOperacao.ReadOnly = True
        Me.txtResultadoOperacao.Size = New System.Drawing.Size(100, 23)
        Me.txtResultadoOperacao.TabIndex = 10
        '
        'lblAviso
        '
        Me.lblAviso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAviso.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAviso.ForeColor = System.Drawing.Color.Red
        Me.lblAviso.Location = New System.Drawing.Point(22, 331)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(200, 24)
        Me.lblAviso.TabIndex = 11
        Me.lblAviso.Text = "ERRO"
        Me.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAviso.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 374)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.txtResultadoOperacao)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnSubtracao)
        Me.Controls.Add(Me.btnSoma)
        Me.Controls.Add(Me.lblCalculo)
        Me.Controls.Add(Me.txtBoxSegundoNumero)
        Me.Controls.Add(Me.txtBoxPrimeiroNumero)
        Me.Controls.Add(Me.lblSegundoNumero)
        Me.Controls.Add(Me.lblPrimeiroNumero)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrimeiroNumero As Label
    Friend WithEvents lblSegundoNumero As Label
    Friend WithEvents txtBoxPrimeiroNumero As TextBox
    Friend WithEvents txtBoxSegundoNumero As TextBox
    Friend WithEvents lblCalculo As Label
    Friend WithEvents btnSoma As Button
    Friend WithEvents btnSubtracao As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultadoOperacao As TextBox
    Friend WithEvents lblAviso As Label
End Class
