<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paciente
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
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Nombres = New System.Windows.Forms.Label()
        Me.nombrep = New System.Windows.Forms.TextBox()
        Me.cd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Calle = New System.Windows.Forms.Label()
        Me.Sexo = New System.Windows.Forms.Label()
        Me.col = New System.Windows.Forms.TextBox()
        Me.edad = New System.Windows.Forms.TextBox()
        Me.calles = New System.Windows.Forms.TextBox()
        Me.num = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ciudad = New System.Windows.Forms.Label()
        Me.Colonia = New System.Windows.Forms.Label()
        Me.Numero = New System.Windows.Forms.Label()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.dgbpaciente = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.boton = New System.Windows.Forms.Button()
        Me.elimi = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Agendar_citas = New System.Windows.Forms.Button()
        Me.box1 = New System.Windows.Forms.ComboBox()
        Me.idpaciente = New System.Windows.Forms.TextBox()
        CType(Me.dgbpaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(40, 718)
        Me.Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(120, 26)
        Me.Guardar.TabIndex = 0
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(466, 718)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(130, 26)
        Me.Eliminar.TabIndex = 1
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(184, 718)
        Me.Cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(112, 26)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Nombres
        '
        Me.Nombres.AutoSize = True
        Me.Nombres.BackColor = System.Drawing.Color.Transparent
        Me.Nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombres.ForeColor = System.Drawing.Color.White
        Me.Nombres.Location = New System.Drawing.Point(11, 70)
        Me.Nombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Size = New System.Drawing.Size(121, 15)
        Me.Nombres.TabIndex = 4
        Me.Nombres.Text = "Nombre completo"
        '
        'nombrep
        '
        Me.nombrep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.nombrep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.nombrep.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nombrep.Location = New System.Drawing.Point(7, 45)
        Me.nombrep.Margin = New System.Windows.Forms.Padding(4)
        Me.nombrep.Name = "nombrep"
        Me.nombrep.Size = New System.Drawing.Size(477, 21)
        Me.nombrep.TabIndex = 9
        '
        'cd
        '
        Me.cd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cd.Location = New System.Drawing.Point(527, 165)
        Me.cd.Margin = New System.Windows.Forms.Padding(4)
        Me.cd.Name = "cd"
        Me.cd.Size = New System.Drawing.Size(149, 21)
        Me.cd.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(126, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Edad"
        '
        'Calle
        '
        Me.Calle.AutoSize = True
        Me.Calle.BackColor = System.Drawing.Color.Transparent
        Me.Calle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calle.ForeColor = System.Drawing.Color.White
        Me.Calle.Location = New System.Drawing.Point(7, 189)
        Me.Calle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Calle.Name = "Calle"
        Me.Calle.Size = New System.Drawing.Size(40, 15)
        Me.Calle.TabIndex = 17
        Me.Calle.Text = "Calle"
        '
        'Sexo
        '
        Me.Sexo.AutoSize = True
        Me.Sexo.BackColor = System.Drawing.Color.Transparent
        Me.Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sexo.ForeColor = System.Drawing.Color.White
        Me.Sexo.Location = New System.Drawing.Point(11, 130)
        Me.Sexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(39, 15)
        Me.Sexo.TabIndex = 18
        Me.Sexo.Text = "Sexo"
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col.Location = New System.Drawing.Point(334, 166)
        Me.col.Margin = New System.Windows.Forms.Padding(4)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(184, 21)
        Me.col.TabIndex = 19
        '
        'edad
        '
        Me.edad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.edad.Location = New System.Drawing.Point(127, 107)
        Me.edad.Margin = New System.Windows.Forms.Padding(4)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(63, 21)
        Me.edad.TabIndex = 20
        '
        'calles
        '
        Me.calles.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.calles.Location = New System.Drawing.Point(5, 166)
        Me.calles.Margin = New System.Windows.Forms.Padding(4)
        Me.calles.Name = "calles"
        Me.calles.Size = New System.Drawing.Size(252, 21)
        Me.calles.TabIndex = 21
        '
        'num
        '
        Me.num.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.num.Location = New System.Drawing.Point(265, 166)
        Me.num.Margin = New System.Windows.Forms.Padding(4)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(61, 21)
        Me.num.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(245, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Domicilio del paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(168, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nombre del paciente"
        '
        'Ciudad
        '
        Me.Ciudad.AutoSize = True
        Me.Ciudad.BackColor = System.Drawing.Color.Transparent
        Me.Ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciudad.ForeColor = System.Drawing.Color.White
        Me.Ciudad.Location = New System.Drawing.Point(527, 188)
        Me.Ciudad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(52, 15)
        Me.Ciudad.TabIndex = 27
        Me.Ciudad.Text = "Ciudad"
        '
        'Colonia
        '
        Me.Colonia.AutoSize = True
        Me.Colonia.BackColor = System.Drawing.Color.Transparent
        Me.Colonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colonia.ForeColor = System.Drawing.Color.White
        Me.Colonia.Location = New System.Drawing.Point(338, 187)
        Me.Colonia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Colonia.Name = "Colonia"
        Me.Colonia.Size = New System.Drawing.Size(56, 15)
        Me.Colonia.TabIndex = 28
        Me.Colonia.Text = "Colonia"
        '
        'Numero
        '
        Me.Numero.AutoSize = True
        Me.Numero.BackColor = System.Drawing.Color.Transparent
        Me.Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.ForeColor = System.Drawing.Color.White
        Me.Numero.Location = New System.Drawing.Point(267, 188)
        Me.Numero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(58, 15)
        Me.Numero.TabIndex = 29
        Me.Numero.Text = "Número"
        '
        'nuevo
        '
        Me.nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.Location = New System.Drawing.Point(323, 718)
        Me.nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(115, 26)
        Me.nuevo.TabIndex = 31
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(199, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Teléfono"
        '
        'tel
        '
        Me.tel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tel.Location = New System.Drawing.Point(198, 107)
        Me.tel.Margin = New System.Windows.Forms.Padding(4)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(150, 21)
        Me.tel.TabIndex = 22
        '
        'dgbpaciente
        '
        Me.dgbpaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbpaciente.Location = New System.Drawing.Point(13, 357)
        Me.dgbpaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.dgbpaciente.Name = "dgbpaciente"
        Me.dgbpaciente.Size = New System.Drawing.Size(795, 75)
        Me.dgbpaciente.TabIndex = 35
        Me.dgbpaciente.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(105, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Datos del paciente"
        '
        'Salir
        '
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(646, 718)
        Me.Salir.Margin = New System.Windows.Forms.Padding(4)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(243, 26)
        Me.Salir.TabIndex = 39
        Me.Salir.Text = "AgendarCita"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'aceptar
        '
        Me.aceptar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.guardar3
        Me.aceptar.ForeColor = System.Drawing.Color.Green
        Me.aceptar.Location = New System.Drawing.Point(108, 230)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(67, 65)
        Me.aceptar.TabIndex = 40
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'boton
        '
        Me.boton.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.aliminar1
        Me.boton.ForeColor = System.Drawing.Color.Green
        Me.boton.Location = New System.Drawing.Point(187, 230)
        Me.boton.Name = "boton"
        Me.boton.Size = New System.Drawing.Size(66, 65)
        Me.boton.TabIndex = 41
        Me.boton.UseVisualStyleBackColor = True
        '
        'elimi
        '
        Me.elimi.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.eliminarrr1
        Me.elimi.ForeColor = System.Drawing.Color.Green
        Me.elimi.Location = New System.Drawing.Point(264, 231)
        Me.elimi.Name = "elimi"
        Me.elimi.Size = New System.Drawing.Size(66, 64)
        Me.elimi.TabIndex = 42
        Me.elimi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cerrar2
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(425, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 66)
        Me.Button1.TabIndex = 44
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.regresar4
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(506, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 66)
        Me.Button2.TabIndex = 45
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(261, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 18)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Actualizar Datos  Pacientes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(114, 212)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Guardar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(197, 212)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Nuevo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(269, 212)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Eliminar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(438, 211)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Salir"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(338, 212)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 15)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Ir a Agenda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(485, 212)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 15)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Regresar al Menu "
        '
        'Agendar_citas
        '
        Me.Agendar_citas.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.agenda4
        Me.Agendar_citas.ForeColor = System.Drawing.Color.Green
        Me.Agendar_citas.Location = New System.Drawing.Point(343, 229)
        Me.Agendar_citas.Name = "Agendar_citas"
        Me.Agendar_citas.Size = New System.Drawing.Size(63, 67)
        Me.Agendar_citas.TabIndex = 43
        Me.Agendar_citas.UseVisualStyleBackColor = True
        '
        'box1
        '
        Me.box1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.box1.FormattingEnabled = True
        Me.box1.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.box1.Location = New System.Drawing.Point(10, 107)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(110, 23)
        Me.box1.TabIndex = 56
        '
        'idpaciente
        '
        Me.idpaciente.Location = New System.Drawing.Point(29, 0)
        Me.idpaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.idpaciente.Name = "idpaciente"
        Me.idpaciente.Size = New System.Drawing.Size(132, 21)
        Me.idpaciente.TabIndex = 8
        Me.idpaciente.Visible = False
        '
        'Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul5
        Me.ClientSize = New System.Drawing.Size(682, 297)
        Me.Controls.Add(Me.box1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Agendar_citas)
        Me.Controls.Add(Me.elimi)
        Me.Controls.Add(Me.boton)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgbpaciente)
        Me.Controls.Add(Me.tel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.Numero)
        Me.Controls.Add(Me.Colonia)
        Me.Controls.Add(Me.Ciudad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.calles)
        Me.Controls.Add(Me.edad)
        Me.Controls.Add(Me.col)
        Me.Controls.Add(Me.Sexo)
        Me.Controls.Add(Me.Calle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cd)
        Me.Controls.Add(Me.nombrep)
        Me.Controls.Add(Me.idpaciente)
        Me.Controls.Add(Me.Nombres)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Guardar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Paciente"
        CType(Me.dgbpaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Nombres As System.Windows.Forms.Label
    Friend WithEvents nombrep As System.Windows.Forms.TextBox
    Friend WithEvents cd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Calle As System.Windows.Forms.Label
    Friend WithEvents Sexo As System.Windows.Forms.Label
    Friend WithEvents col As System.Windows.Forms.TextBox
    Friend WithEvents edad As System.Windows.Forms.TextBox
    Friend WithEvents calles As System.Windows.Forms.TextBox
    Friend WithEvents num As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ciudad As System.Windows.Forms.Label
    Friend WithEvents Colonia As System.Windows.Forms.Label
    Friend WithEvents Numero As System.Windows.Forms.Label
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tel As System.Windows.Forms.TextBox
    Friend WithEvents dgbpaciente As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents boton As System.Windows.Forms.Button
    Friend WithEvents elimi As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Agendar_citas As System.Windows.Forms.Button
    Friend WithEvents box1 As System.Windows.Forms.ComboBox
    Friend WithEvents idpaciente As System.Windows.Forms.TextBox
End Class
