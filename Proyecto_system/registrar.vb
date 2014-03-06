
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Web.UI.WebControls

Public Class registrar
    Dim datos, fecha, datos2 As String
    Dim conn As MySqlConnection
    Dim lector2 As MySqlDataReader
    Dim lector5 As MySqlDataReader
    Dim lector As MySqlDataReader
    Dim idh As String


    Private Sub registrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Menú_agenda.Hide()

        TextBox1.Text = nombregene

        Timer1.Start()

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Buscar_paciente.Hide()

        TextBox1.Text = " "
        Consultar_Citas.ShowDialog()

    End Sub

    Private Sub box2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box2.SelectedIndexChanged
        datos = "SELECT Id_h FROM  horario where Horarios = '" & box2.Text & "'"
        Dim comando2 As New MySqlCommand(datos, conn)
        lector2 = comando2.ExecuteReader
        lector2.Read()
        idh = lector2("Id_h")
        lector2.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Buscar_paciente.Hide()

        fecha = calendario.SelectionRange.Start.Date

        datos = "SELECT Id_paciente, Horario_de_consulta FROM  agendar_consulta where Fecha_de_consulta = '" & fecha & "'"
        Dim comando3 As New MySqlCommand(datos, conn)
        Dim comando6 As New MySqlCommand(datos, conn)
        lector = comando3.ExecuteReader
        'lector5 = comando6.ExecuteReader

        Dim Numero() As Integer = New Integer(8) {}
        Dim contador As Integer
        Dim ban As Integer = 0

        contador = 0
        While lector.Read

            If lector("Id_paciente") <> idegeneral Then
                Numero(contador) = lector("Horario_de_consulta")

                contador += 1
            Else
                MsgBox("el paciente no puede ser registrados 2 veces el mismo dia", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
                lector.Close()

                Exit Sub
            End If



        End While

        lector.Close()

        box2.Items.Clear()
        For I = 1 To 8

            ban = 0

            For H = 1 To 8

                If I = Numero(H) Then
                    ban = 1
                    Exit For

                End If
            Next

            If ban = 0 Then

                    datos = "SELECT Horarios FROM  horario where Id_h = " & I

                    Dim comando2 As New MySqlCommand(datos, conn)
                    lector2 = comando2.ExecuteReader
                    lector2.Read()
                    box2.Items.Add(lector2("Horarios"))
                    lector2.Close()

                End If
            'If lector5("Id_h") = I Then
            '    lector5.Read()
            '    MsgBox("Ya existe una cita registrada a esta hora favor de seleccionar otra", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
            '    lector5.Close()
            'End If

        Next



    End Sub

    Private Sub citas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles citas.Click

        Buscar_paciente.Hide()

        Try
            If TextBox1.Text = "" Or box2.Text = "" Then

            End If

            Dim Comando As New MySqlCommand("insert into agendar_consulta values('" & TextBox2.Text & "','" & idegeneral & "', '" & fecha & "', '" & idh & "')", conn)
            Comando.ExecuteNonQuery()

            box2.Items.Clear()
            box2.Text = ""


            MsgBox("Datos Guardados Correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        Catch ex As Exception

            MsgBox("Falta ingresar datos en algunos de los campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        End Try

        TextBox1.Text = " "
        Menú_agenda.Show()

        Me.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Buscar_paciente.Hide()
        'TextBox1.Text = " "
        Menú_agenda.Show()
        Me.Close()

    End Sub

    Private Sub calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calendario.DateChanged
        fecha = calendario.SelectionRange.Start.Date
       
        Dim domingo As String
        Dim sabado As String
        Dim habiles, habiles2, habiles3, habiles4, habiles5 As String
        habiles = calendario.SelectionStart.Date.AddDays(1 - (calendario.SelectionStart.Date.DayOfWeek))
        habiles2 = calendario.SelectionStart.Date.AddDays(2 - (calendario.SelectionStart.Date.DayOfWeek))
        habiles3 = calendario.SelectionStart.Date.AddDays(3 - (calendario.SelectionStart.Date.DayOfWeek))
        habiles4 = calendario.SelectionStart.Date.AddDays(4 - (calendario.SelectionStart.Date.DayOfWeek))
        habiles5 = calendario.SelectionStart.Date.AddDays(5 - (calendario.SelectionStart.Date.DayOfWeek))

        sabado = calendario.SelectionStart.Date.AddDays(6 - (calendario.SelectionStart.Date.DayOfWeek))
        domingo = calendario.SelectionStart.Date.AddDays(7 - (calendario.SelectionStart.Date.DayOfWeek))

        If fecha < Today Then
            MsgBox("Este dia no puede ser registrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

            MsgBox("Es nesesario que seleccione un dia posterior o igual  a " & Today.Day, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        End If




        'Try
        '    If sabado = calendario.SelectionStart.Date.AddDays(6 - (calendario.SelectionStart.Date.DayOfWeek)) Then

        '        MsgBox("Este dia no puede ser registrado debido a que es Sabado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        '        MsgBox("Favor de ingresar solo dias habiles que son: de lunes a viernes", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        '    ElseIf habiles = calendario.SelectionStart.Date.AddDays(1 - (calendario.SelectionStart.Date.DayOfWeek)) Or habiles2 = calendario.SelectionStart.Date.AddDays(2 - (calendario.SelectionStart.Date.DayOfWeek)) Or habiles3 = calendario.SelectionStart.Date.AddDays(3 - (calendario.SelectionStart.Date.DayOfWeek)) Or habiles4 = calendario.SelectionStart.Date.AddDays(4 - (calendario.SelectionStart.Date.DayOfWeek)) Or habiles5 = calendario.SelectionStart.Date.AddDays(5 - (calendario.SelectionStart.Date.DayOfWeek)) Then
        '        If fecha < Today Then
        '            MsgBox("Este dia no puede ser registrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        '            MsgBox("Es nesesario que seleccione un dia posterior o igual  a " & Today.Day, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        '        End If

        '    ElseIf domingo = calendario.SelectionStart.Date.AddDays(7 - (calendario.SelectionStart.Date.DayOfWeek)) Then
        '        MsgBox("Este dia no puede ser registrado debido a que es domingo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        '        MsgBox("favor de ingresar solo dias habiles de lunes a viernes", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        '        Else
        '            MsgBox("Error ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
        '        End If
        'Catch ex As Exception
        '    MsgBox("Error", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        'End Try


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub calendario_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calendario.DateSelected
    

    End Sub
End Class