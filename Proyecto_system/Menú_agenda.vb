
'En la clase menu agenda se acceden a los distintas ventanas al precionar los botones se inicializa el calendario 
'y el reloj.

Public Class Menú_agenda
    Dim fecha As Date

    'En el metodo del boton registrar un paciente al seleccionar abre la ventana de registrar pacientes

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Buscar_paciente.Show()

    End Sub

    'En el metodo del boton consultar sitas accede a la ventana consultar citas

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Consultar_Citas.Show()

    End Sub

    'En el metodo del boton Ir al menú anterior cieera el menú actual y regresa al menú principal

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Menu_principal.Show()
        Me.Close()


    End Sub

    'En el metodo load se inicializa el timer

    Private Sub Menú_agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        fecha = Now
        Menu_principal.Hide()
    End Sub

    'En el metodo timer se inicializa el timer y el calendario

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    TextBox1.Text = TimeOfDay
    'End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class