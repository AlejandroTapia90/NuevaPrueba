Imports System.IO
Imports MySql.Data.MySqlClient
Public Class nuevo
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim otra As String
    Private Sub nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim datos As String
        datos = "SELECT agendar_consulta.Fecha_de_consulta, agendar_consulta.Horario_de_consulta, horario.Id_h, horario.Horarios FROM agendar_consulta INNER JOIN horario ON agendar_consulta.Horario_de_consulta = horario.Id_h"
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dgbconsulta.DataSource = dataset.Tables(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class