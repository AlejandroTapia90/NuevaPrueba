Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class prueba
    Dim Ds As New DataSet
    Dim Con As New MySqlConnection
    Dim Cmd As New MySqlCommand
    Dim Da As New MySqlDataAdapter


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Con = New MySqlConnection
        Con.ConnectionString = "server=localhost;user id=root; password= ;database=consultoria"
        Cmd.Connection = Con
        Con.Open()

        Cmd.CommandText = "select * from pacientes,analisis,primera_consul,consulta_subsecuente"
        Da.SelectCommand = Cmd
        Da.Fill(Ds)


        'SELECT tabla.campo, tabla.campo, tabla.campo FROM tabla1 INNER JOIN tabla2 ON  tabla1.id = tabla2.id INNER JOIN tabla3 ON tabla1.id ó tabla2.id (segun la relacion de las tablas) = tabla3.id WHERE tabla1.id (ó egun el campo a  comparar de que tabla ya sea 2 ó 3) = valor

        Cmd.CommandText = "SELECT pacientes.Id_Paciente, pacientes.Nombre, pacientes.Edad, pacientes.Sexo, pacientes.Calle, pacientes.Numero, pacientes.Colonia, pacientes.Ciudad, pacientes.Telefono, analisis.Id_paciente, analisis.analisis, primera_consul.Id_paciente,primera_consul.Motivo_consulta, primera_consul.Subjetivo, primera_consul.Objetivo, primera_consul.Analisis, primera_consul.Plan_de_trabajo, consulta_subsecuente.Id_Paciente, consulta_subsecuente.Subjetivo, consulta_subsecuente.Objetivo, consulta_subsecuente.Analisis_pa, consulta_subsecuente.Plan  FROM pacientes INNER JOIN analisis ON  pacientes.Id_Paciente = analisis.Id_paciente INNER JOIN primera_consul ON pacientes.Id_Paciente = primera_consul.Id_paciente INNER JOIN consulta_subsecuente ON pacientes.Id_Paciente = consulta_subsecuente.Id_paciente where pacientes.Id_Paciente = analisis.Id_paciente and pacientes.Id_Paciente = primera_consul.Id_paciente and pacientes.Id_Paciente = consulta_subsecuente.Id_Paciente"
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        Ds.WriteXml("C:\XML\prueba.xml", XmlWriteMode.WriteSchema)


        repor.Show()

    End Sub

    Private Sub prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class