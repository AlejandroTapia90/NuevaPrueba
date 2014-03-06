<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Primera_consulta
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id_pacient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Observaciones = New System.Windows.Forms.Label()
        Me.subjeti = New System.Windows.Forms.TextBox()
        Me.objeti = New System.Windows.Forms.TextBox()
        Me.analisis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.plan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.plann = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgbpaciente = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgbpaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Objetivo"
        '
        'id_pacient
        '
        Me.id_pacient.Location = New System.Drawing.Point(3, 1)
        Me.id_pacient.Margin = New System.Windows.Forms.Padding(4)
        Me.id_pacient.Name = "id_pacient"
        Me.id_pacient.Size = New System.Drawing.Size(132, 21)
        Me.id_pacient.TabIndex = 54
        Me.id_pacient.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Motivo de la consulta"
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.BackColor = System.Drawing.Color.Transparent
        Me.Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.ForeColor = System.Drawing.Color.White
        Me.Hora.Location = New System.Drawing.Point(161, 105)
        Me.Hora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(108, 16)
        Me.Hora.TabIndex = 51
        Me.Hora.Text = "Análisis SOAP"
        '
        'Observaciones
        '
        Me.Observaciones.AutoSize = True
        Me.Observaciones.BackColor = System.Drawing.Color.Transparent
        Me.Observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observaciones.ForeColor = System.Drawing.Color.White
        Me.Observaciones.Location = New System.Drawing.Point(37, 125)
        Me.Observaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Size = New System.Drawing.Size(73, 16)
        Me.Observaciones.TabIndex = 49
        Me.Observaciones.Text = "Subjetivo"
        '
        'subjeti
        '
        Me.subjeti.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.subjeti.Location = New System.Drawing.Point(14, 145)
        Me.subjeti.Margin = New System.Windows.Forms.Padding(4)
        Me.subjeti.Multiline = True
        Me.subjeti.Name = "subjeti"
        Me.subjeti.Size = New System.Drawing.Size(407, 53)
        Me.subjeti.TabIndex = 58
        '
        'objeti
        '
        Me.objeti.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.objeti.Location = New System.Drawing.Point(18, 222)
        Me.objeti.Margin = New System.Windows.Forms.Padding(4)
        Me.objeti.Multiline = True
        Me.objeti.Name = "objeti"
        Me.objeti.Size = New System.Drawing.Size(403, 57)
        Me.objeti.TabIndex = 60
        '
        'analisis
        '
        Me.analisis.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.analisis.Location = New System.Drawing.Point(18, 304)
        Me.analisis.Margin = New System.Windows.Forms.Padding(4)
        Me.analisis.Multiline = True
        Me.analisis.Name = "analisis"
        Me.analisis.Size = New System.Drawing.Size(400, 49)
        Me.analisis.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 283)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Análisis"
        '
        'plan
        '
        Me.plan.Location = New System.Drawing.Point(60, 679)
        Me.plan.Margin = New System.Windows.Forms.Padding(4)
        Me.plan.Multiline = True
        Me.plan.Name = "plan"
        Me.plan.Size = New System.Drawing.Size(1034, 89)
        Me.plan.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 656)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Plan de trabajo"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.guardar4
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(7, 448)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 65)
        Me.Button1.TabIndex = 66
        Me.Button1.UseVisualStyleBackColor = True
        '
        'plann
        '
        Me.plann.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.plann.Location = New System.Drawing.Point(14, 377)
        Me.plann.Margin = New System.Windows.Forms.Padding(4)
        Me.plann.Multiline = True
        Me.plann.Name = "plann"
        Me.plann.Size = New System.Drawing.Size(407, 52)
        Me.plann.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(34, 356)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Plan de Trabajo"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.regresar5
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Green
        Me.Button3.Location = New System.Drawing.Point(354, 444)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 69)
        Me.Button3.TabIndex = 70
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(503, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(102, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(234, 18)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Captura de datos del Paciente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(13, 431)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Guardar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(364, 429)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Salir"
        '
        'dgbpaciente
        '
        Me.dgbpaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbpaciente.Location = New System.Drawing.Point(609, 354)
        Me.dgbpaciente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgbpaciente.Name = "dgbpaciente"
        Me.dgbpaciente.Size = New System.Drawing.Size(126, 53)
        Me.dgbpaciente.TabIndex = 91
        Me.dgbpaciente.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightGray
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Transtornos_depresivos", "Crisis_de_ansiedad", "Baja_autoestima", "Estres", "Deficit_de_atención", "Problemas_de_pareja", "Desorientacio_ Existencial"})
        Me.ComboBox1.Location = New System.Drawing.Point(18, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 23)
        Me.ComboBox1.TabIndex = 92
        '
        'Primera_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul5
        Me.ClientSize = New System.Drawing.Size(437, 512)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dgbpaciente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.plann)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.plan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.analisis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.objeti)
        Me.Controls.Add(Me.subjeti)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.id_pacient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.Observaciones)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Primera_consulta"
        CType(Me.dgbpaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents id_pacient As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Hora As System.Windows.Forms.Label
    Friend WithEvents Observaciones As System.Windows.Forms.Label
    Friend WithEvents subjeti As System.Windows.Forms.TextBox
    Friend WithEvents objeti As System.Windows.Forms.TextBox
    Friend WithEvents analisis As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents plan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents plann As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgbpaciente As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
