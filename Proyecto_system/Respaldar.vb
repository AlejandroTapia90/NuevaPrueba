
'La clase respaldar es utilizada para respaldar la base de datos en una direccion del ordenador

Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Respaldo
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim datos As String
    Dim cargar As String
    Dim dataset As New DataSet

    'El siguiente metodo realiza un respaldo de la base de datos del sistema 

    'El boton cancelar cierra la ventana

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub





    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--user=root --password= --host=localhost --databases MySQL consultoria -r ""C:\xampp\BackUpDataBase.sql""")

    '    MsgBox("Respaldo realizado satisfactoriamente")
    'End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    respaldar.DefaultExt = "sql"
    '    Dim pathmysql As String
    '    Dim comando As String
    '    pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\MySQL\MySQL Connector Net 6.5.3", "Location", 0)
    '    If pathmysql = Nothing Then
    '        MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
    '        carpeta.ShowDialog()
    '        pathmysql = carpeta.SelectedPath
    '    End If
    '    respaldar.Filter = "File MYSQL (*.sql)|*.sql"
    '    If respaldar.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        'Try
    '        comando = pathmysql & "\bin\mysqldump --user=root --password= --databases consultoria -r """ & respaldar.FileName & """"
    '        MsgBox(comando)
    '        'Shell(comando)
    '        'Shell(comando, AppWinStyle.MaximizedFocus, True)
    '        'Catch ex As Exception
    '        '    MsgBox("Ocurrio un error al respaldar", MsgBoxStyle.Critical, "Informacion")
    '        'End Try

    '    End If
    'End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--user=root --password= --host=localhost --databases MySQL consultorio -r ""C:\xampp\mysql\bin\Respaldo_Bd_Consultoria.sql""")

        'Process.Start("C:\MySQL\MySQL Server 5.1\bin\mysqldump.exe", "-u username -p***** existing_database -r C:\backup.sql")

        Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--user=root --password= --host=localhost --databases MySQL consultoria -r ""C:\xampp\mysql\bin\consultoria.sql""")

        MsgBox("Respaldo realizado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
    End Sub
End Class