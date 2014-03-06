
'En la siguiente clase se muestra el vaciado de datos de la consulta 
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Consulta_Subsecuente
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim datos As String
    Dim cargar As String
    Dim dataset As New DataSet

    'En el boton guardar se modifican los campos almacenados anteriormente ya que los registros se crean con valor nulo
    'al ingresar los datos del paciente esto para hacer posible la generacion del historial clinico. 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If subje.Text = "" Or objeti.Text = "" Or anali.Text = "" Or plan.Text = "" Then

            MsgBox("Falta ingresar datos en algunos de los campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
            MsgBox("Es nesesario ingresar datos en todos los campos para poder guardar informacion", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        Else

            Dim insertando As New MySqlCommand("update consulta_subsecuente set  Subjetivo = '" & subje.Text & "', Objetivo = '" & objeti.Text & "', Analisis_pa = '" & anali.Text & "', Plan = '" & plan.Text & "'  Where Id_Paciente = " & clave, conn)
            insertando.ExecuteNonQuery()

            id_pacient.Text = " "
            subje.Text = ""
            objeti.Text = ""
            plan.Text = ""
            anali.Text = ""
            MsgBox("Datos guardados correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        End If
        Consulta.Show()
        Me.Close()

    End Sub

    'En el metodo load se crea la conexion a la base de datos y se crea una consulta.

    Private Sub Consulta_Subsecuente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        datos = "SELECT * FROM consulta_subsecuente"
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)

    End Sub

    'El boton Ir al menú anterior sale de la ventana jeje

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Consulta.Show()

        Me.Close()
    End Sub

    Private Sub subje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subje.TextChanged
        Dim I As Integer
        subje.Text = UCase(subje.Text)
        I = Len(subje.Text)
        subje.SelectionStart = I
    End Sub

    Private Sub objeti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objeti.TextChanged
        Dim I As Integer
        objeti.Text = UCase(objeti.Text)
        I = Len(objeti.Text)
        objeti.SelectionStart = I
    End Sub

    Private Sub anali_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anali.TextChanged
        Dim I As Integer
        anali.Text = UCase(anali.Text)
        I = Len(anali.Text)
        anali.SelectionStart = I
    End Sub

    Private Sub plan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plan.TextChanged
        Dim I As Integer
        plan.Text = UCase(plan.Text)
        I = Len(plan.Text)
        plan.SelectionStart = I
    End Sub
End Class