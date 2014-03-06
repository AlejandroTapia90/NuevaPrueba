<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar
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
        Me.aceptarr = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.Label()
        Me.texto1 = New System.Windows.Forms.TextBox()
        Me.texto2 = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDelServidorDeBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarImagenDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'aceptarr
        '
        Me.aceptarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarr.ForeColor = System.Drawing.Color.Black
        Me.aceptarr.Location = New System.Drawing.Point(0, 230)
        Me.aceptarr.Name = "aceptarr"
        Me.aceptarr.Size = New System.Drawing.Size(81, 23)
        Me.aceptarr.TabIndex = 0
        Me.aceptarr.Text = "Aceptar"
        Me.aceptarr.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.ForeColor = System.Drawing.Color.Black
        Me.cancelar.Location = New System.Drawing.Point(195, 230)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(84, 23)
        Me.cancelar.TabIndex = 1
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.BackColor = System.Drawing.Color.Transparent
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.ForeColor = System.Drawing.Color.White
        Me.usuario.Location = New System.Drawing.Point(68, 136)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(126, 15)
        Me.usuario.TabIndex = 2
        Me.usuario.Text = "Cuenta de Usuario"
        '
        'texto1
        '
        Me.texto1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.texto1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.texto1.Location = New System.Drawing.Point(40, 157)
        Me.texto1.Name = "texto1"
        Me.texto1.Size = New System.Drawing.Size(192, 20)
        Me.texto1.TabIndex = 3
        '
        'texto2
        '
        Me.texto2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.texto2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.texto2.Location = New System.Drawing.Point(40, 204)
        Me.texto2.Name = "texto2"
        Me.texto2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.texto2.Size = New System.Drawing.Size(192, 20)
        Me.texto2.TabIndex = 4
        '
        'contraseña
        '
        Me.contraseña.AutoSize = True
        Me.contraseña.BackColor = System.Drawing.Color.Transparent
        Me.contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contraseña.ForeColor = System.Drawing.Color.White
        Me.contraseña.Location = New System.Drawing.Point(92, 184)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(80, 15)
        Me.contraseña.TabIndex = 5
        Me.contraseña.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ingreso al sistema"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.usuario
        Me.PictureBox1.Location = New System.Drawing.Point(91, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(279, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosDelServidorDeBaseDeDatosToolStripMenuItem, Me.CargarImagenDeUsuarioToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'DatosDelServidorDeBaseDeDatosToolStripMenuItem
        '
        Me.DatosDelServidorDeBaseDeDatosToolStripMenuItem.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul
        Me.DatosDelServidorDeBaseDeDatosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DatosDelServidorDeBaseDeDatosToolStripMenuItem.Name = "DatosDelServidorDeBaseDeDatosToolStripMenuItem"
        Me.DatosDelServidorDeBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DatosDelServidorDeBaseDeDatosToolStripMenuItem.Text = "Datos del servidor "
        '
        'CargarImagenDeUsuarioToolStripMenuItem
        '
        Me.CargarImagenDeUsuarioToolStripMenuItem.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul
        Me.CargarImagenDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CargarImagenDeUsuarioToolStripMenuItem.Name = "CargarImagenDeUsuarioToolStripMenuItem"
        Me.CargarImagenDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CargarImagenDeUsuarioToolStripMenuItem.Text = "Cargar imagen de usuario"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Ingresar
        '
        Me.AcceptButton = Me.aceptarr
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo_azul
        Me.ClientSize = New System.Drawing.Size(279, 253)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.texto2)
        Me.Controls.Add(Me.texto1)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptarr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Ingresar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aceptarr As System.Windows.Forms.Button
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents usuario As System.Windows.Forms.Label
    Friend WithEvents texto1 As System.Windows.Forms.TextBox
    Friend WithEvents texto2 As System.Windows.Forms.TextBox
    Friend WithEvents contraseña As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosDelServidorDeBaseDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarImagenDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
