'En la siguiente clase consultar citas se muestran los pacientes registrados asi como la hora y fecha de la cita.
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Consultar_Citas
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim otra As String

    'En el metodo load se inicializa el reloj y se crea la conexion a la base de datos y se invoca el metodo llenado.

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        registrar.Hide()
        Menú_agenda.Hide()

        Timer1.Start()

        'conn = New MySqlConnection
        'conn.ConnectionString = "server=localhost;user id=root; password= ; database=consultoria"
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

    'En la siguiente la variable cargar toma el valor y seleciona todo de los datos del id que selecione.

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cargar As String

        cargar = "selet * from "

    End Sub

    'En el siguiente metodo dgbconsulta se realiza un ciclo for nesesario para que al selecionar el id del paciente sea
    'posible acceder a los datos de ese paciente.

    Private Sub dgbconsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbconsulta.CellContentClick

        For x = 0 To dgbconsulta.Rows.Count - 2

            If dgbconsulta.Item(1, x).Selected = True Then

                selecion = dgbconsulta.Item(1, x).Value
                otra = dgbconsulta.Item(1, x).Value
                Historial.ShowDialog()
                Exit For
            End If
        Next

    End Sub

    'En el metodo se inicializa el timer y el calendario.

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = TimeOfDay
    End Sub

    'El boton cancelar cierra la ventana actual y regresa al menú registrar citas.

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Menú_agenda.Show()
        Me.Close()

    End Sub

    'En el siguiente metodo para eliminar una cita ya registrada se seleciona nuevaente el id del paciente en la tabla
    'se toma el valor en la variable otra lo cual al hacer la consulta para eliminar se elimina el paciente con el id 
    'almacenado en la variable otra.

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        MsgBox("Esta seguro de que desea eliminar este paciente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        conn.Open()
        Dim eliminar As String
        eliminar = "DELETE From agendar_consulta WHERE Id_paciente = " & otra
        Dim comando As New MySqlCommand(eliminar, conn)
        comando.ExecuteNonQuery()
        conn.Close()
        llenado()
        Menú_agenda.Show()
        Me.Close()

    End Sub

    'El metodo llenado es utilizado para refrescar los registros de la tabla dgbconsulta

    Sub llenado()
        Dim datos As String
        datos = "SELECT * FROM agendar_consulta"
       
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dgbconsulta.DataSource = dataset.Tables(0)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        nuevo.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class