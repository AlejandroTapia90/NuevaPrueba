Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form4
    Dim datos As String
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim cargar As String
    Dim dataset As New DataSet
    Dim otra As String
    Dim Ds As New DataSet
    Dim Con As New MySqlConnection
    Dim Cmd As New MySqlCommand
    Dim Da As New MySqlDataAdapter

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Hide()

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menú_paciente.Show()

        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        Con = New MySqlConnection
        Con.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        Cmd.Connection = Con
        Con.Open()

        Cmd.CommandText = "select pacientes.Id_Paciente, pacientes.Nombre, pacientes.Edad, pacientes.Sexo, pacientes.Calle, pacientes.Numero, pacientes.Colonia, pacientes.Ciudad, pacientes.Telefono, analisis.Id_paciente, analisis.analisis, primera_consul.Id_paciente,primera_consul.Motivo_consulta, primera_consul.Subjetivo, primera_consul.Objetivo, primera_consul.Analisis, primera_consul.Plan_de_trabajo, consulta_subsecuente.Id_Paciente, consulta_subsecuente.Subjetivo, consulta_subsecuente.Objetivo, consulta_subsecuente.Analisis_pa, consulta_subsecuente.Plan FROM pacientes INNER JOIN analisis ON  pacientes.Id_Paciente = analisis.Id_paciente INNER JOIN primera_consul ON pacientes.Id_Paciente = primera_consul.Id_paciente INNER JOIN consulta_subsecuente ON pacientes.Id_Paciente = consulta_subsecuente.Id_paciente Where pacientes.Nombre  = '" & ComboBox1.Text & " ' "

        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        Ds.WriteXml("C:\XML\prueba2.xml", XmlWriteMode.WriteSchema)

        ComboBox1.Text = ""

        repor_indi.ShowDialog()

        Form5.ShowDialog()

    End Sub
End Class