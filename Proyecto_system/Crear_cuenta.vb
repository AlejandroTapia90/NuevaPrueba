'En la clase crear cuenta se validan los campos para ingresar los valores los cuales son utilizados para ingresar al sistem.
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Crear_cuenta

    'En el metodo siguiente se valida que no pueda copiar ni pegar en el campo cuenta de usuario

    Private Sub cuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cuenta.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            cuenta.ReadOnly = True
        Else
            cuenta.ReadOnly = False
        End If
    End Sub

    'En el metodo siguient valida que el campo cuenta de usuario solo acepte un maximo de 16 caracteres 
    'pueda aceptar letras numeros y un punto.

    Private Sub cuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cuenta.KeyPress
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

    'En el metodo siguiente se valida que no pueda copiar ni pegar en el campo contraseña

    Private Sub contraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles contraseña.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            contraseña.ReadOnly = True
        Else
            contraseña.ReadOnly = False
        End If
    End Sub

    'En el metodo siguient valida que el campo cuenta de usuario solo acepte un maximo de 16 caracteres 
    'pueda aceptar letras numeros y un punto.

    Private Sub contraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles contraseña.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) And co < 30 Then
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

    'En el metodo del boton aceptar se crea la conexion ala base de datos se valida que todos los campos esten llenmos
    'antes de precionar enter y se almacena en la tabla usuarios

    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click


        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()
       
        If cuenta.Text = "" Or contraseña.Text = "" Or ComboBox1.Text = "" Then

            MsgBox("Falta ingresar datos en algunos de los campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
            MsgBox("Es nesesario ingresar datos en todos los campos para poder guardar informacion", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        Else

            Dim insertando As New MySqlCommand("insert into usuarios values('" + cuenta.Text + "','" + contraseña.Text + "','" + ComboBox1.Text + "')", conn)
            insertando.ExecuteNonQuery()

            cuenta.Text = ""
            contraseña.Text = ""
            ComboBox1.Text = ""
            MsgBox("Usuario generado exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        End If
    End Sub

    'En el metodo del boton cancelar el cual cierra la ventana

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Menus.Show()
        Me.Close()
    End Sub

    'El boton consultar usuarios que manda a la ventana que muestra los usuarios creados

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Datos_usuario.ShowDialog()
    End Sub

    'En el metodo siguiente se valida que no pueda copiar ni pegar en el camppo tipo de usuario

    Private Sub tipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tipo.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            tipo.ReadOnly = True
        Else
            tipo.ReadOnly = False
        End If
    End Sub

    'En el metodo siguient valida que el campo cuenta de usuario solo acepte un maximo de 1 caracter 
    'solo una A o una U.

    Private Sub tipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tipo.KeyPress
        If Char.IsLetter(e.KeyChar) And apm < 1 Then
            e.Handled = False
            apm = apm + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If apm >= 0 Then
                apm = apm - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Crear_cuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Menus.Hide()

        apm = 0
        ca = 0
        co = 0

    End Sub

    Private Sub tipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tipo.TextChanged
        Dim I As Integer
        tipo.Text = UCase(tipo.Text)
        I = Len(tipo.Text)
        tipo.SelectionStart = I
    End Sub
End Class