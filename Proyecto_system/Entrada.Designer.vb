<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iniciando
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
        Me.components = New System.ComponentModel.Container()
        Me.inicio = New System.Windows.Forms.Label()
        Me.texto = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'inicio
        '
        Me.inicio.AutoSize = True
        Me.inicio.BackColor = System.Drawing.Color.Transparent
        Me.inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicio.ForeColor = System.Drawing.Color.White
        Me.inicio.Location = New System.Drawing.Point(109, 59)
        Me.inicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(57, 18)
        Me.inicio.TabIndex = 0
        Me.inicio.Text = "Label1"
        '
        'texto
        '
        Me.texto.AutoSize = True
        Me.texto.BackColor = System.Drawing.Color.Transparent
        Me.texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto.ForeColor = System.Drawing.Color.White
        Me.texto.Location = New System.Drawing.Point(4, 76)
        Me.texto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(45, 13)
        Me.texto.TabIndex = 1
        Me.texto.Text = "Label2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(32, 39)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(219, 13)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consultorio Clínico Ramos"
        '
        'Iniciando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul
        Me.ClientSize = New System.Drawing.Size(281, 94)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.inicio)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Iniciando"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inicio As System.Windows.Forms.Label
    Friend WithEvents texto As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
