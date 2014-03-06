
'En la siguiente clase menus se cren una serie de botones el calendatio y la hora del menú

Public Class Menus

    'En el metodo load se inicializa el timer

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()
        Menu_principal.Hide()
    End Sub

    'En el meodo tmer se activa el calendario y el timer

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    TextBox1.Text = TimeOfDay
    'End Sub

    'En el el boton crear cuaenta que accede a a ventana crear cuenta

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--user=root --password= --host=localhost --databases MySQL consultoria -r ""C:\xampp\mysql\bin\consultoria.sql""")

        MsgBox("Respaldo realizado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start("C:\xampp\mysql\bin\mysql.exe", "--user=root --password= --host=localhost --databases MySQL consultoria < ""C:\xampp\mysql\bin\consultoria.sql")
        MsgBox("Restauracion realizada satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Crear_cuenta.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Menu_principal.Show()
        Me.Close()


    End Sub
End Class
