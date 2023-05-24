<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblCalcularVolume = New System.Windows.Forms.Label()
        Me.lblComprimento = New System.Windows.Forms.Label()
        Me.lblLargura = New System.Windows.Forms.Label()
        Me.lblAtura = New System.Windows.Forms.Label()
        Me.txtBoxComprimento = New System.Windows.Forms.TextBox()
        Me.txtBoxLargura = New System.Windows.Forms.TextBox()
        Me.txtBoxAltura = New System.Windows.Forms.TextBox()
        Me.btnCalcularVolume = New System.Windows.Forms.Button()
        Me.txtBoxResultadoVolume = New System.Windows.Forms.TextBox()
        Me.lblResultadoVolume = New System.Windows.Forms.Label()
        Me.lblAvisoVolume = New System.Windows.Forms.Label()
        Me.btnLimparVolume = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCalcularVolume
        '
        Me.lblCalcularVolume.AutoSize = True
        Me.lblCalcularVolume.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCalcularVolume.Location = New System.Drawing.Point(52, 35)
        Me.lblCalcularVolume.Name = "lblCalcularVolume"
        Me.lblCalcularVolume.Size = New System.Drawing.Size(279, 28)
        Me.lblCalcularVolume.TabIndex = 0
        Me.lblCalcularVolume.Text = "Calcular Volume de um Tanque"
        '
        'lblComprimento
        '
        Me.lblComprimento.AutoSize = True
        Me.lblComprimento.Location = New System.Drawing.Point(74, 101)
        Me.lblComprimento.Name = "lblComprimento"
        Me.lblComprimento.Size = New System.Drawing.Size(85, 15)
        Me.lblComprimento.TabIndex = 1
        Me.lblComprimento.Text = "Comprimento:"
        '
        'lblLargura
        '
        Me.lblLargura.AutoSize = True
        Me.lblLargura.Location = New System.Drawing.Point(74, 147)
        Me.lblLargura.Name = "lblLargura"
        Me.lblLargura.Size = New System.Drawing.Size(50, 15)
        Me.lblLargura.TabIndex = 2
        Me.lblLargura.Text = "Largura:"
        '
        'lblAtura
        '
        Me.lblAtura.AutoSize = True
        Me.lblAtura.Location = New System.Drawing.Point(74, 194)
        Me.lblAtura.Name = "lblAtura"
        Me.lblAtura.Size = New System.Drawing.Size(42, 15)
        Me.lblAtura.TabIndex = 3
        Me.lblAtura.Text = "Altura:"
        '
        'txtBoxComprimento
        '
        Me.txtBoxComprimento.Location = New System.Drawing.Point(192, 98)
        Me.txtBoxComprimento.Name = "txtBoxComprimento"
        Me.txtBoxComprimento.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxComprimento.TabIndex = 4
        '
        'txtBoxLargura
        '
        Me.txtBoxLargura.Location = New System.Drawing.Point(192, 144)
        Me.txtBoxLargura.Name = "txtBoxLargura"
        Me.txtBoxLargura.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxLargura.TabIndex = 5
        '
        'txtBoxAltura
        '
        Me.txtBoxAltura.Location = New System.Drawing.Point(192, 191)
        Me.txtBoxAltura.Name = "txtBoxAltura"
        Me.txtBoxAltura.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxAltura.TabIndex = 6
        '
        'btnCalcularVolume
        '
        Me.btnCalcularVolume.Location = New System.Drawing.Point(111, 246)
        Me.btnCalcularVolume.Name = "btnCalcularVolume"
        Me.btnCalcularVolume.Size = New System.Drawing.Size(130, 63)
        Me.btnCalcularVolume.TabIndex = 7
        Me.btnCalcularVolume.Text = "Calcular Volume"
        Me.btnCalcularVolume.UseVisualStyleBackColor = True
        '
        'txtBoxResultadoVolume
        '
        Me.txtBoxResultadoVolume.Location = New System.Drawing.Point(192, 370)
        Me.txtBoxResultadoVolume.Name = "txtBoxResultadoVolume"
        Me.txtBoxResultadoVolume.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxResultadoVolume.TabIndex = 8
        '
        'lblResultadoVolume
        '
        Me.lblResultadoVolume.AutoSize = True
        Me.lblResultadoVolume.Location = New System.Drawing.Point(92, 373)
        Me.lblResultadoVolume.Name = "lblResultadoVolume"
        Me.lblResultadoVolume.Size = New System.Drawing.Size(50, 15)
        Me.lblResultadoVolume.TabIndex = 9
        Me.lblResultadoVolume.Text = "Volume:"
        '
        'lblAvisoVolume
        '
        Me.lblAvisoVolume.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAvisoVolume.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoVolume.Location = New System.Drawing.Point(42, 396)
        Me.lblAvisoVolume.Name = "lblAvisoVolume"
        Me.lblAvisoVolume.Size = New System.Drawing.Size(279, 30)
        Me.lblAvisoVolume.TabIndex = 10
        Me.lblAvisoVolume.Text = "ERRO"
        Me.lblAvisoVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAvisoVolume.Visible = False
        '
        'btnLimparVolume
        '
        Me.btnLimparVolume.Location = New System.Drawing.Point(125, 325)
        Me.btnLimparVolume.Name = "btnLimparVolume"
        Me.btnLimparVolume.Size = New System.Drawing.Size(102, 23)
        Me.btnLimparVolume.TabIndex = 11
        Me.btnLimparVolume.Text = "Limpar"
        Me.btnLimparVolume.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 450)
        Me.Controls.Add(Me.btnLimparVolume)
        Me.Controls.Add(Me.lblAvisoVolume)
        Me.Controls.Add(Me.lblResultadoVolume)
        Me.Controls.Add(Me.txtBoxResultadoVolume)
        Me.Controls.Add(Me.btnCalcularVolume)
        Me.Controls.Add(Me.txtBoxAltura)
        Me.Controls.Add(Me.txtBoxLargura)
        Me.Controls.Add(Me.txtBoxComprimento)
        Me.Controls.Add(Me.lblAtura)
        Me.Controls.Add(Me.lblLargura)
        Me.Controls.Add(Me.lblComprimento)
        Me.Controls.Add(Me.lblCalcularVolume)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCalcularVolume As Label
    Friend WithEvents lblComprimento As Label
    Friend WithEvents lblLargura As Label
    Friend WithEvents lblAtura As Label
    Friend WithEvents txtBoxComprimento As TextBox
    Friend WithEvents txtBoxLargura As TextBox
    Friend WithEvents txtBoxAltura As TextBox
    Friend WithEvents btnCalcularVolume As Button
    Friend WithEvents txtBoxResultadoVolume As TextBox
    Friend WithEvents lblResultadoVolume As Label
    Friend WithEvents lblAvisoVolume As Label
    Friend WithEvents btnLimparVolume As Button
End Class
