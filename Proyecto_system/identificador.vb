
'En la clase identificador fue elaborada para enlazar a cada paciente con su consulta esto para hacer posible 
'la realizacion del historial clinico.
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class identificador
    Dim datos As String
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim cargar As String
    Dim dataset As New DataSet
    Dim otra As String

    'En el metodo load se crea la conexion con la base de datos, se muestran los datos de la tabla pacientes en
    'el comboBox, se limpiar el comboBox t por ultimo se cargan los nombres de los paciente en el comboBox

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menu_principal.Hide()
        AutoCompletar(Me.TextBox1)

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()

        datos = "select Nombre from pacientes "
        Dim comando1 As New MySqlCommand(datos, conn)
        lector = comando1.ExecuteReader

        ComboBox1.Items.Clear()

        While lector.Read
            ComboBox1.Items.Add(lector("Nombre"))
        End While
        lector.Close()
    End Sub

    ''En el metodo del boton aceptar se genera la consulta del nombre del paciente al quien se le realizara la 
    'terapia una vez rescatado este valor se almacena en la variable clave la cual sirve de referencia una vez 
    'estando en el menu de realizar consulta todos los campos tiene el id con el valor de clave, esto quiere
    'decir el mismo id el mismo paciente mientras la ventana siga abierta

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        datos = "select Id_Paciente from pacientes Where Nombre = '" & TextBox1.Text & " ' "
        Dim comando1 As New MySqlCommand(datos, conn)
        lector = comando1.ExecuteReader
        lector.Read()

        clave = CStr(lector("Id_Paciente"))
        lector.Close()
        TextBox1.Text = " "
        Consulta.ShowDialog()

    End Sub

    'En el boton cancelar cierra la ventana y regresa al menú principal

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TextBox1.Text = " "
        Me.Close()
        Menu_principal.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Public Function AutoCompletar(ByVal Control As TextBox) As AutoCompleteStringCollection
        Dim Coleccion As New AutoCompleteStringCollection

        Dim Comando As String

        Comando = "SELECT Nombre FROM pacientes ORDER By Nombre"

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        Dim lector As New MySqlCommand(Comando, conn)

        conn.Open()
        Dim lector2 As MySqlDataReader = lector.ExecuteReader()

        While lector2.Read()
            Coleccion.AddRange(New String() {lector2(0)})

        End While

        lector2.Close()

        'Cerramos la coneccion
        conn.Close()

        With Control
            .AutoCompleteMode = AutoCompleteMode.Suggest

            .AutoCompleteSource = AutoCompleteSource.CustomSource

            .AutoCompleteCustomSource = Coleccion

        End With
        'Devolvemos los datos recuperados de la base de datos
        Return Coleccion


    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class