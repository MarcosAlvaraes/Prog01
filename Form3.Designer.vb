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
        Me.SuspendLayout()
        '
        'lblCalcularVolume
        '
        Me.lblCalcularVolume.AutoSize = True
        Me.lblCalcularVolume.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCalcularVolume.Location = New System.Drawing.Point(52, 58)
        Me.lblCalcularVolume.Name = "lblCalcularVolume"
        Me.lblCalcularVolume.Size = New System.Drawing.Size(279, 28)
        Me.lblCalcularVolume.TabIndex = 0
        Me.lblCalcularVolume.Text = "Calcular Volume de um Tanque"
        '
        'lblComprimento
        '
        Me.lblComprimento.AutoSize = True
        Me.lblComprimento.Location = New System.Drawing.Point(92, 149)
        Me.lblComprimento.Name = "lblComprimento"
        Me.lblComprimento.Size = New System.Drawing.Size(85, 15)
        Me.lblComprimento.TabIndex = 1
        Me.lblComprimento.Text = "Comprimento:"
        '
        'lblLargura
        '
        Me.lblLargura.AutoSize = True
        Me.lblLargura.Location = New System.Drawing.Point(92, 192)
        Me.lblLargura.Name = "lblLargura"
        Me.lblLargura.Size = New System.Drawing.Size(50, 15)
        Me.lblLargura.TabIndex = 2
        Me.lblLargura.Text = "Largura:"
        '
        'lblAtura
        '
        Me.lblAtura.AutoSize = True
        Me.lblAtura.Location = New System.Drawing.Point(92, 235)
        Me.lblAtura.Name = "lblAtura"
        Me.lblAtura.Size = New System.Drawing.Size(42, 15)
        Me.lblAtura.TabIndex = 3
        Me.lblAtura.Text = "Altura:"
        '
        'txtBoxComprimento
        '
        Me.txtBoxComprimento.Location = New System.Drawing.Point(192, 146)
        Me.txtBoxComprimento.Name = "txtBoxComprimento"
        Me.txtBoxComprimento.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxComprimento.TabIndex = 4
        '
        'txtBoxLargura
        '
        Me.txtBoxLargura.Location = New System.Drawing.Point(192, 189)
        Me.txtBoxLargura.Name = "txtBoxLargura"
        Me.txtBoxLargura.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxLargura.TabIndex = 5
        '
        'txtBoxAltura
        '
        Me.txtBoxAltura.Location = New System.Drawing.Point(192, 232)
        Me.txtBoxAltura.Name = "txtBoxAltura"
        Me.txtBoxAltura.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxAltura.TabIndex = 6
        '
        'btnCalcularVolume
        '
        Me.btnCalcularVolume.Location = New System.Drawing.Point(116, 284)
        Me.btnCalcularVolume.Name = "btnCalcularVolume"
        Me.btnCalcularVolume.Size = New System.Drawing.Size(130, 63)
        Me.btnCalcularVolume.TabIndex = 7
        Me.btnCalcularVolume.Text = "Calcular Volume"
        Me.btnCalcularVolume.UseVisualStyleBackColor = True
        '
        'txtBoxResultadoVolume
        '
        Me.txtBoxResultadoVolume.Location = New System.Drawing.Point(192, 386)
        Me.txtBoxResultadoVolume.Name = "txtBoxResultadoVolume"
        Me.txtBoxResultadoVolume.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxResultadoVolume.TabIndex = 8
        '
        'lblResultadoVolume
        '
        Me.lblResultadoVolume.AutoSize = True
        Me.lblResultadoVolume.Location = New System.Drawing.Point(92, 389)
        Me.lblResultadoVolume.Name = "lblResultadoVolume"
        Me.lblResultadoVolume.Size = New System.Drawing.Size(50, 15)
        Me.lblResultadoVolume.TabIndex = 9
        Me.lblResultadoVolume.Text = "Volume:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 450)
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
End Class
