
'En la siguiente clase se puede observar el funcionamiento del menú alternativo mediante botones.

Public Class Menu2

    'En el siguiente metodo se inicializa el timer para el funcionamiento del reloj 

    Private Sub Menu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    'Se inicizaliza el calendario con el timer para el correcto funcionamiento de ambos

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    TextBox1.Text = TimeOfDay
    'End Sub

    'El siguiente metodo describe el funcionamiento del boton actualizar agenda el cual abre el formulario agendar 

    Private Sub Agenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agenda.Click
        Buscar_paciente.ShowDialog()
    End Sub

    'El siguiente metodo drecribe y muestra el funcionamiento del boton actualizar pacientes el cual abre el formulario actualizar datos del paciente

    Private Sub Pacien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pacien.Click
        Paciente.ShowDialog()
    End Sub

    'El siguiente metodo explica el funcionamiento del boton salir el cual sale del sistema por completo

    Private Sub sali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sali.Click
        End
    End Sub
End Class