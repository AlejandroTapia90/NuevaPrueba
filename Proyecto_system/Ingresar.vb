'La siguiente clase Ingresar es usada para el control de acceso al sistema contiene validaciones conexion
'a la base de datos etc.
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Ingresar
    Dim conta As Integer
    Private Const iMinLength = 6


    'El metodo Keydown es utilizado para validar el campo donde  irá la contraseña lo que hace es que no permite que 
    'sea posible copiar y pegar mediante comandos del teclado u raton

    Private Sub texto2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles texto2.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            texto2.ReadOnly = True
        Else
            texto2.ReadOnly = False
        End If
    End Sub

    'El metodo Keypress es el metodo encargado de validar el campo contraseña, lo que hace este campo es que deja
    'entrar un maximo de 16 caracteres acepta tanto numeros como letras acepta solo un punto tambien valida los 
    'espacios. 

    Private Sub texto2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles texto2.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) And ca < 16 Then
            e.Handled = False
            ca = ca + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If ca >= 0 Then
                ca = ca - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        ElseIf Char.IsPunctuation(e.KeyChar) And pn = False Then
            e.Handled = False
            pn = True
        Else
            e.Handled = True
        End If
    End Sub

    'En el siguiente codigo se elaboro el codigo del boton aceptar primero se realiza la conexion con la base de datos
    'despues se realiza la validacion de usuarios se valida el tiepo de usuario que es y dependiendo del tipo de usuario
    'es el menú que despliega, tambien se valida en caso de que los datos introducidos sean erroreos mande mensajes de dialogo.

    Dim conn As MySqlConnection
    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptarr.Click

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        'MsgBox(usuario)
        'MsgBox(pasword)


        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()


        'conn = New MySqlConnection
        'conn.ConnectionString = "server=localhost;user id=root; password= ; database=consultorio"
        'conn.Open()


        Dim lector As MySqlDataReader
        Dim valida As String

        'Try
        valida = "select * from usuarios where usuarios = '" & texto1.Text & "' "

        Dim comando As New MySqlCommand(valida, conn)

        lector = comando.ExecuteReader


        lector.Read()

        If texto2.Text = lector("contrasena") And lector("Tipo_de_cuenta") = "A" Then

            Menu_principal.ShowDialog()
            texto1.Text = ""
            texto2.Text = ""
            lector.Close()


        ElseIf texto2.Text = lector("contrasena") And lector("Tipo_de_cuenta") = "U" Then
            Menu2.ShowDialog()

        Else
            texto2.Text = ""
            MsgBox("Error tecle la contraseña correcta", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        End If

        'Catch ex As Exception
        '    conta += 1
        '    ca = 0
        '    co = 0
        '    MsgBox("Error tecle el nombre de usuario y contraseña correcta", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        '    If conta = 3 Then
        '        MsgBox("Fin de intentos Ejecute de nuevo el programa", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        '        End
        '    End If
        '    texto1.Text = ""
        '    texto2.Text = ""


        'End Try




    End Sub

    'Aqui se origrama el boton cancelar el cual sale del sistema por completo

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        End
    End Sub

    'El metodo Keydown es utilizado para validar el campo donde  irá la cuenta de usuario  lo que hace es que no permite que 
    'sea posible copiar y pegar mediante comandos del teclado u raton

    Private Sub texto1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles texto1.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            texto1.ReadOnly = True
        Else
            texto1.ReadOnly = False
        End If
    End Sub

    'El metodo Keypress es el metodo encargado de validar el campo cuenta de usuario, lo que hace este campo es que deja
    'entrar un maximo de 16 caracteres acepta tanto numeros como letras acepta solo un punto tambien valida los 
    'espacios. 


    Private Sub texto1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles texto1.KeyPress

        If Char.IsLetterOrDigit(e.KeyChar) And co < 16 Then
            e.Handled = False
            co = co + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If co >= 0 Then
                co = co - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        ElseIf Char.IsPunctuation(e.KeyChar) And pn = False Then
            e.Handled = False
            pn = True
        Else
            e.Handled = True
        End If
    End Sub

    'En este metodo se inicializan las variables nesesarias en los metodos de validacion de campos

    Private Sub Ingresar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conta = 0
        ca = 0
        co = 0
    End Sub

    Private Sub DatosDelServidorDeBaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosDelServidorDeBaseDeDatosToolStripMenuItem.Click
        valida.ShowDialog()
    End Sub

    Private Sub CargarImagenDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarImagenDeUsuarioToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub


    Private Sub texto1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles texto1.LostFocus
        If Len(texto1.Text) < iMinLength Then
            texto1.Text = ""
            texto2.Text = ""
            MsgBox("La cuenta de usuario y contraseña deben tener como minimo de 6 Caracteres", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        End If


    End Sub

    'Private Sub texto1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles texto1.TextChanged
    '    Dim contador As New Integer

    '    contador = 0

    '    If Val(Me.texto1.Text) < 6 Or Val(Me.texto1.Text) > 16 Then

    '        MsgBox("debe tener mas de 6 caracteres", MsgBoxStyle.Critical)

    '    End If
    'End Sub

End Class
