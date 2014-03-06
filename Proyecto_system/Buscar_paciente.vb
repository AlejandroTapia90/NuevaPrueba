
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Buscar_paciente

    Dim datos As String
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim lector2 As MySqlDataReader
    Dim cargar As String
    Dim dataset As New DataSet
    Dim otra As String

    Private Sub Buscar_paciente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        conn.Close()
    End Sub
    Private Sub Buscar_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menú_agenda.Hide()
        AutoCompletar(Me.TextBox1)
    End Sub
    Public Function AutoCompletar(ByVal Control As TextBox) As AutoCompleteStringCollection
        Dim Coleccion As New AutoCompleteStringCollection

        Dim Comando As String

        Comando = "SELECT Nombre FROM pacientes ORDER By Nombre"

        'conn = New MySqlConnection
        'conn.ConnectionString = "server=localhost;user id=root; password= ; database=consultoria"
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


        With Control
            .AutoCompleteMode = AutoCompleteMode.Suggest

            .AutoCompleteSource = AutoCompleteSource.CustomSource

            .AutoCompleteCustomSource = Coleccion

        End With
        'Devolvemos los datos recuperados de la base de datos
        Return Coleccion


    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Paciente.boton.Enabled = False
        Paciente.elimi.Enabled = False
        Paciente.Agendar_citas.Enabled = False

        TextBox1.Text = " "

        Paciente.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menú_agenda.Show()
        TextBox1.Text = " "
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        If TextBox1.Text = "" Then
            Menú_agenda.Show()
            MsgBox("Debe haber un nombre en el campo de texto si no se ecncuentra agregue al paciente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        Else
            nombregene = TextBox1.Text
            datos = "SELECT Id_paciente FROM  pacientes where Nombre = '" & TextBox1.Text & "'"
            Dim comando2 As New MySqlCommand(datos, conn)
            lector2 = comando2.ExecuteReader

            lector2.Read()
            idegeneral = lector2("Id_paciente")
            lector2.Close()

            TextBox1.Text = " "
            registrar.ShowDialog()
        End If
      

        Me.Close()
      
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class