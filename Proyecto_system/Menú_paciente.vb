'En la siguiente clase menú del paciente se programo la accion de cada uno de los botones asi como la del calendario y
'el reloj.
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Menú_paciente
    Dim Ds As New DataSet
    Dim Con As New MySqlConnection
    Dim Cmd As New MySqlCommand
    Dim Da As New MySqlDataAdapter
    'En el load del programa se inicializa el timer como se ve a continuacion

    Private Sub Menú_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Menu_principal.Hide()

    End Sub

    ''Se inicia el Timer para que se muestre la hora.

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    TextBox1.Text = TimeOfDay
    'End Sub

    'El boton Actualizar paciente manda llamar el formulario paciente como se ve en el metodo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Paciente.Show()


    End Sub

    'El boton Ir al menú anterior cierra la ventana actual y regresa al menú principal

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Menu_principal.Show()

    End Sub


    'El boton Historial paciente Abre la ventana donde se puede visualizar el historial del paciente asi como
    'tambien se puede imprimir.

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Form2.Refresh()

    End Sub

    'Se Inicializa una variable para acceder a la aplicacion que genera el genograma apartir del boton Realizar genograma

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Tuto.Show()
    End Sub


End Class