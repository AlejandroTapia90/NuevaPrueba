<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu2
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
        Me.sali = New System.Windows.Forms.Button()
        Me.Agenda = New System.Windows.Forms.Button()
        Me.Pacien = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'sali
        '
        Me.sali.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cerrar1
        Me.sali.Location = New System.Drawing.Point(140, 45)
        Me.sali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sali.Name = "sali"
        Me.sali.Size = New System.Drawing.Size(60, 69)
        Me.sali.TabIndex = 51
        Me.sali.UseVisualStyleBackColor = True
        '
        'Agenda
        '
        Me.Agenda.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.agenda3
        Me.Agenda.Location = New System.Drawing.Point(37, 45)
        Me.Agenda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Agenda.Name = "Agenda"
        Me.Agenda.Size = New System.Drawing.Size(65, 69)
        Me.Agenda.TabIndex = 49
        Me.Agenda.UseVisualStyleBackColor = True
        '
        'Pacien
        '
        Me.Pacien.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.paciente3
        Me.Pacien.Location = New System.Drawing.Point(82, 160)
        Me.Pacien.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pacien.Name = "Pacien"
        Me.Pacien.Size = New System.Drawing.Size(67, 74)
        Me.Pacien.TabIndex = 50
        Me.Pacien.UseVisualStyleBackColor = True
        Me.Pacien.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Actualizar Agenda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(152, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Salir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(57, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 18)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Menú principal"
        '
        'Menu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul
        Me.ClientSize = New System.Drawing.Size(226, 126)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sali)
        Me.Controls.Add(Me.Agenda)
        Me.Controls.Add(Me.Pacien)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Menu2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sali As System.Windows.Forms.Button
    Friend WithEvents Agenda As System.Windows.Forms.Button
    Friend WithEvents Pacien As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
