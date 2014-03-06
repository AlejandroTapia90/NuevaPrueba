
'En la clase menú principal se crearon accesos por medio de botones a cada uno de los modulos.

Public Class Menu_principal
    Dim fecha As Date
    'En en el load se inicializa el timer

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        fecha = Now
        TextBox2.Text = TextBox2.Text + fecha
        Ingresar.Hide()


    End Sub

    'En se da los valores al timer y al calendario

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'TextBox1.Text = TimeOfDay
    End Sub

    'En el metodo del boton menú del paciente este boton abre la ventana de menú del paciente

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Menú_paciente.Show()


    End Sub

    'En el metodo del boton menú para actualizar este boton abre la ventana de menú actualizar agenda

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menú_agenda.Show()
    End Sub


    'En el siguiente metodo al precionar el boton aparece la ventan que permite la selecion del paciente al que se le
    'aplicara la consulta.

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        identificador.Show()


    End Sub

    'El metodo del boton ir al menú herramientas al precionarlo abrela ventanade menú herramientas

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Menus.Show()


    End Sub

    'El metodo del boton salir al precionarlo sale por completo del sistema

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        End

    End Sub
End Class