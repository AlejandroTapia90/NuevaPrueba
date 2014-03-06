
'La clase restaurar es utilizada para restaurar la base de datos que se encuentra en una direccion del ordenador

Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Restaurar
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim datos As String
    Dim cargar As String
    Dim dataset As New DataSet

    'El boton cancelar cierra la ventana

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub




    Private Sub Restaurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'El siguiente metodo realiza la restauracion de la base de datos del sistema almacenada anteiormente

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        'Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--user=root --password= --host=localhost --databases MySQL scip< ""C:\xampp\Respaldo_Bd_Consultoria.sql")
        Process.Start("C:\xampp\mysql\bin\mysql.exe", "--user=root --password= --host=localhost --databases MySQL consultoria < ""C:\xampp\mysql\bin\consultoria.sql")
        MsgBox("Restauracion realizada satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        'Dim myProcess As New Process()
        'myProcess.StartInfo.FileName = "cmd.exe"
        'myProcess.StartInfo.UseShellExecute = False
        'myProcess.StartInfo.WorkingDirectory = "C:\xampp\MySQL\\bin\"
        'myProcess.StartInfo.RedirectStandardInput = True
        'myProcess.StartInfo.RedirectStandardOutput = True
        'myProcess.Start()
        'Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        'Dim mystreamreader As StreamReader = myProcess.StandardOutput
        ''myStreamWriter.WriteLine("mysql -u username -p***** databasename < C:\backup.sql ")
        'myStreamWriter.WriteLine("mysqlimport.exe --user=root --password= --host=localhost --databases MySQL consultoria < C:\xampp\mysql\bin\consultoria.sql")
        'myStreamWriter.Close()
        'myProcess.WaitForExit()
        'myProcess.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class