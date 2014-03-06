'En la clase consulta o menú de la elaboracion de la consulta se muestran la serie de opciones mediante botones 

Public Class Consulta

    'Se inicializa el time y el funcionamiento del calendario

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    TextBox1.Text = TimeOfDay
    'End Sub

    Private Sub Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        identificador.Hide()
        Timer1.Start()
    End Sub

    'El boton analisis va al boton realizar analisis y accede a la ventan analisis

    Private Sub anali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anali.Click
        analisis.ShowDialog()
    End Sub

    'El boton primera consulta accede al vaciado de datos abriendo la ventana de primera consulta

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Primera_consulta.ShowDialog()
    End Sub

    'El boton consulta subsecuente accede al vaciado de datos abriendo la venta consulta subsecuente

    Private Sub histo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles histo.Click
        Consulta_Subsecuente.ShowDialog()
    End Sub

    'El boton salir sale de la aplicacion 

    Private Sub sali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sali.Click
        End
    End Sub

    'El boton ir al menú anterior  cierra las ventanas menú de realizar consulta y la ventana identificador

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menu_principal.Show()

        Me.Close()

    End Sub

End Class