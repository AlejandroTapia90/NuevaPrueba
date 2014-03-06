Imports MySql.Data
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Ds As New DataSet
    Dim Conn As New MySqlConnection
    Dim Cmd As New MySqlCommand
    Dim Da As New MySqlDataAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        Conn = New MySqlConnection
        Conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        Cmd.Connection = Conn
        Conn.Open()

        Cmd.CommandText = "SELECT pacientes.Id_Paciente, pacientes.Nombre, pacientes.Edad, pacientes.Sexo, pacientes.Calle, pacientes.Numero, pacientes.Colonia, pacientes.Ciudad, pacientes.Telefono, analisis.Id_paciente, analisis.analisis, primera_consul.Id_paciente,primera_consul.Motivo_consulta, primera_consul.Subjetivo, primera_consul.Objetivo, primera_consul.Analisis, primera_consul.Plan_de_trabajo, consulta_subsecuente.Id_Paciente, consulta_subsecuente.Subjetivo, consulta_subsecuente.Objetivo, consulta_subsecuente.Analisis_pa, consulta_subsecuente.Plan  FROM pacientes INNER JOIN analisis ON  pacientes.Id_Paciente = analisis.Id_paciente INNER JOIN primera_consul ON pacientes.Id_Paciente = primera_consul.Id_paciente INNER JOIN consulta_subsecuente ON pacientes.Id_Paciente = consulta_subsecuente.Id_paciente where pacientes.Id_Paciente = analisis.Id_paciente and pacientes.Id_Paciente = primera_consul.Id_paciente and pacientes.Id_Paciente = consulta_subsecuente.Id_Paciente"
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        Ds.WriteXml("C:\XML\prueba.xml", XmlWriteMode.WriteSchema)

        repor.Show()
        Form1.Show()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form6.ShowDialog()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menú_paciente.Hide()
    End Sub
End Class