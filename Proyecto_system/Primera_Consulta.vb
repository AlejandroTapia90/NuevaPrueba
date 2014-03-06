
'En la clase primera consulta se modifican en la tabla para generar el historial clinico
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Primera_consulta
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim datos As String
    Dim cargar As String
    Dim dataset As New DataSet

    'En el metodo load se crea la conexion a la base de datos y se muestra la tabla pacientes por medio de un datasourse

    Private Sub Primera_consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta.Hide()

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()

        Dim datos As String

        datos = "SELECT * FROM analisis"
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dgbpaciente.DataSource = dataset.Tables(0)
    End Sub

    'En el metodo guardar son modificados los registros que anteriormente, antes de precionar este boton son nulos,
    'se modifican todos los campos y al presionar aceptar se almacenan y se limpian los campos
    'se valida que los campos tengan datos antes de guardarlos de lo contrario mandan mensaje de error

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Or subjeti.Text = "" Or objeti.Text = "" Or analisis.Text = "" Or plann.Text = "" Then
            MsgBox("Falta ingresar datos en algunos de los campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
            MsgBox("Es nesesario ingresar datos en todos los campos para poder guardar informacion", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        Else

            Dim insertando As New MySqlCommand("update primera_consul set Motivo_consulta = '" & ComboBox1.Text & "', Subjetivo = '" & subjeti.Text & "', Objetivo = '" & objeti.Text & "', Analisis = '" & analisis.Text & "', Plan_de_trabajo = '" & plann.Text & "'  Where Id_Paciente = " & clave, conn)
            insertando.ExecuteNonQuery()

            id_pacient.Text = "  "
            ComboBox1.Text = ""
            subjeti.Text = ""
            objeti.Text = ""
            analisis.Text = ""
            plann.Text = ""

            MsgBox("Datos Guardados correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        End If

        Consulta.Show()
        Me.Close()


    End Sub

    'en el siguiente metodo el boton salir cierra la ventana y regresa al menú realizar consulta

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Consulta.Show()

        Me.Close()
    End Sub

    'Private Sub motivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim I As Integer
    '    motivo.Text = UCase(motivo.Text)
    '    I = Len(motivo.Text)
    '    motivo.SelectionStart = I
    'End Sub

    Private Sub subjeti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjeti.TextChanged
        Dim I As Integer
        subjeti.Text = UCase(subjeti.Text)
        I = Len(subjeti.Text)
        subjeti.SelectionStart = I
    End Sub

    Private Sub objeti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objeti.TextChanged
        Dim I As Integer
        objeti.Text = UCase(objeti.Text)
        I = Len(objeti.Text)
        objeti.SelectionStart = I
    End Sub

    Private Sub analisis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles analisis.TextChanged
        Dim I As Integer
        analisis.Text = UCase(analisis.Text)
        I = Len(analisis.Text)
        analisis.SelectionStart = I
    End Sub

    Private Sub plann_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plann.TextChanged
        Dim I As Integer
        plann.Text = UCase(plann.Text)
        I = Len(plann.Text)
        plann.SelectionStart = I
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class