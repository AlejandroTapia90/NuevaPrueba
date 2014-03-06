Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Eliminando
    Dim datos As String
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim cargar As String
    Dim dataset As New DataSet
    Dim otra As String

    Private Sub Eliminando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoCompletar(Me.TextBox1)
        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()
       
        llenado()
    End Sub

    Sub llenado()
        datos = "SELECT * FROM pacientes"
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dgbpaciente.DataSource = dataset.Tables(0)

    End Sub

    Public Function AutoCompletar(ByVal Control As TextBox) As AutoCompleteStringCollection
        Dim Coleccion As New AutoCompleteStringCollection

        Dim Comando As String

      
        Comando = "SELECT Nombre FROM pacientes ORDER By Nombre"

        Dim sr As StreamReader = New StreamReader("C:\Users\ALEJANDRO\Desktop\pasword.txt")
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


        With Control
            .AutoCompleteMode = AutoCompleteMode.Suggest

            .AutoCompleteSource = AutoCompleteSource.CustomSource

            .AutoCompleteCustomSource = Coleccion

        End With
        'Devolvemos los datos recuperados de la base de datos
        Return Coleccion


    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        bandera = False

        confirma.ShowDialog()

        If bandera = True Then

            Dim eliminar As String

            eliminar = "DELETE From pacientes WHERE Id_Paciente = " & otra
            Dim comando As New MySqlCommand(eliminar, conn)
            comando.ExecuteNonQuery()

            eliminar = "DELETE From primera_consul WHERE Id_Paciente = " & otra
            Dim comando2 As New MySqlCommand(eliminar, conn)
            comando2.ExecuteNonQuery()

            eliminar = "DELETE From analisis WHERE Id_Paciente = " & otra
            Dim comando3 As New MySqlCommand(eliminar, conn)
            comando3.ExecuteNonQuery()

            eliminar = "DELETE From consulta_subsecuente WHERE Id_Paciente = " & otra
            Dim comando4 As New MySqlCommand(eliminar, conn)
            comando4.ExecuteNonQuery()

            MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        Else
            Me.Close()
        End If



    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub buscar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbpaciente.CellContentClick
        For x = 0 To dgbpaciente.Rows.Count - 2
            If dgbpaciente.Item(1, x).Selected = True Then

                otra = dgbpaciente.Item(0, x).Value

                Exit For
            End If
        Next
    End Sub
End Class