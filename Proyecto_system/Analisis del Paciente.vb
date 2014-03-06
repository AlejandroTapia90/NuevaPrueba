
'En la siguiente clase es utilizada para almacenar las observaciones que se hacen durante la consulta.
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class analisis
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim datos As String
    Dim cargar As String
    Dim dataset As New DataSet

    'En el metodo del boton guardar se almacena en la tabla analisis el analisis que el usuario realiza durante la consulta lo que 
    'hace es por medio de un identificador almacenar los datos en la tabla, modifica los datos ya que la tabla se crea como nula cuando se
    'registra el paciente.

    'Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

    '    Dim insertando As New MySqlCommand("update analisis set analisis = ('" + anali.Text + "') Where Id_Paciente = " & clave, conn)
    '    insertando.ExecuteNonQuery()
    '    anali.Text = " "

    'End Sub

    'En el metodo load se crea la conexion a la base de datos despues se selsciona la tabla alalisis

    Private Sub analisis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta.Hide()
        'conn = New MySqlConnection
        'conn.ConnectionString = "server=localhost;user id=root; password= ; database=consultoria"
        'conn.Open()

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

        Dim datos As String
        datos = "SELECT * FROM analisis"
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)

    End Sub

    'El boton cancelar cierra el formulario actual.

    'Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

    '    Me.Close()

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim insertando As New MySqlCommand("update analisis set analisis = ('" + anali.Text + "') Where Id_Paciente = " & clave, conn)
        insertando.ExecuteNonQuery()
        anali.Text = " "
        MsgBox("Datos guardados correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        Consulta.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Consulta.Show()

        Me.Close()
    End Sub

    Private Sub anali_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anali.TextChanged
        Dim I As Integer
        anali.Text = UCase(anali.Text)
        I = Len(anali.Text)
        anali.SelectionStart = I
    End Sub
End Class
