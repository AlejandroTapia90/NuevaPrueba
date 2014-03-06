'En la siguiente clase datos de usuario esta diseñada para consultar los usuarios registrados para utilizar el sistema
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Datos_usuario
    Dim conn As MySqlConnection
    Dim datos As String
    Dim lector As MySqlDataReader
    Dim cargar As String
    Dim dataset As New DataSet
    Dim otra As String

    'En el metodo load se crea una conexion a la base de datos y se carga en la tabla usuarios en la tabla datos

    Private Sub Datos_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Crear_cuenta.Hide()

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()


        datos = "SELECT * FROM usuarios"
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        datosss.DataSource = dataset.Tables(0)

    End Sub

    'En el metodo del boton salir se sale de la ventana y regresa al aanterior

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Menus.Show()

        Me.Close()

    End Sub

    Private Sub datosss_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datosss.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menus.Show()
        Me.Close()

    End Sub
End Class