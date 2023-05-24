<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lblLegendaTestes = New System.Windows.Forms.Label()
        Me.btnEsconder = New System.Windows.Forms.Button()
        Me.btnMostrarLegenda = New System.Windows.Forms.Button()
        Me.btnMudarCorFundoLegenda = New System.Windows.Forms.Button()
        Me.btnMudarCorFundoFormulario = New System.Windows.Forms.Button()
        Me.btnEscrevcerNumeroNaLegenda = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLegendaTestes
        '
        Me.lblLegendaTestes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLegendaTestes.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblLegendaTestes.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLegendaTestes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLegendaTestes.Location = New System.Drawing.Point(28, 32)
        Me.lblLegendaTestes.Name = "lblLegendaTestes"
        Me.lblLegendaTestes.Size = New System.Drawing.Size(251, 37)
        Me.lblLegendaTestes.TabIndex = 0
        Me.lblLegendaTestes.Text = "Isto é uma legenda!"
        Me.lblLegendaTestes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEsconder
        '
        Me.btnEsconder.Location = New System.Drawing.Point(70, 100)
        Me.btnEsconder.Name = "btnEsconder"
        Me.btnEsconder.Size = New System.Drawing.Size(164, 23)
        Me.btnEsconder.TabIndex = 1
        Me.btnEsconder.Text = "Esconder Legenda"
        Me.btnEsconder.UseVisualStyleBackColor = True
        '
        'btnMostrarLegenda
        '
        Me.btnMostrarLegenda.Location = New System.Drawing.Point(70, 150)
        Me.btnMostrarLegenda.Name = "btnMostrarLegenda"
        Me.btnMostrarLegenda.Size = New System.Drawing.Size(164, 23)
        Me.btnMostrarLegenda.TabIndex = 2
        Me.btnMostrarLegenda.Text = "Mostrar Legenda"
        Me.btnMostrarLegenda.UseVisualStyleBackColor = True
        '
        'btnMudarCorFundoLegenda
        '
        Me.btnMudarCorFundoLegenda.Location = New System.Drawing.Point(70, 200)
        Me.btnMudarCorFundoLegenda.Name = "btnMudarCorFundoLegenda"
        Me.btnMudarCorFundoLegenda.Size = New System.Drawing.Size(164, 23)
        Me.btnMudarCorFundoLegenda.TabIndex = 3
        Me.btnMudarCorFundoLegenda.Text = "Mudar cor da legenda"
        Me.btnMudarCorFundoLegenda.UseVisualStyleBackColor = True
        '
        'btnMudarCorFundoFormulario
        '
        Me.btnMudarCorFundoFormulario.Location = New System.Drawing.Point(70, 250)
        Me.btnMudarCorFundoFormulario.Name = "btnMudarCorFundoFormulario"
        Me.btnMudarCorFundoFormulario.Size = New System.Drawing.Size(164, 23)
        Me.btnMudarCorFundoFormulario.TabIndex = 4
        Me.btnMudarCorFundoFormulario.Text = "Mudar cor do formulario"
        Me.btnMudarCorFundoFormulario.UseVisualStyleBackColor = True
        '
        'btnEscrevcerNumeroNaLegenda
        '
        Me.btnEscrevcerNumeroNaLegenda.Location = New System.Drawing.Point(70, 300)
        Me.btnEscrevcerNumeroNaLegenda.Name = "btnEscrevcerNumeroNaLegenda"
        Me.btnEscrevcerNumeroNaLegenda.Size = New System.Drawing.Size(164, 23)
        Me.btnEscrevcerNumeroNaLegenda.TabIndex = 5
        Me.btnEscrevcerNumeroNaLegenda.Text = "Escrever um numero"
        Me.btnEscrevcerNumeroNaLegenda.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(228, 347)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 382)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEscrevcerNumeroNaLegenda)
        Me.Controls.Add(Me.btnMudarCorFundoFormulario)
        Me.Controls.Add(Me.btnMudarCorFundoLegenda)
        Me.Controls.Add(Me.btnMostrarLegenda)
        Me.Controls.Add(Me.btnEsconder)
        Me.Controls.Add(Me.lblLegendaTestes)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLegendaTestes As Label
    Friend WithEvents btnEsconder As Button
    Friend WithEvents btnMostrarLegenda As Button
    Friend WithEvents btnMudarCorFundoLegenda As Button
    Friend WithEvents btnMudarCorFundoFormulario As Button
    Friend WithEvents btnEscrevcerNumeroNaLegenda As Button
    Friend WithEvents btnReset As Button
End Class
