
'la calase iniciando se elabora para dar un presentacion al sistema la cual muestra una barra donde de muestra que
'el sistema esta cargando el sistema ademas que se mandan mensajes sobre el sistema
Public Class Iniciando
    Dim contador As Byte = 5

    Private Sub Entrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'el siguiente codigo lo que hace es cargar la barra progres bar se define el tiempo el cual tarda en cargar 
        'Una vez que termina de cargar se abre la ventana de ingresar 

        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.5
            If Me.Opacity = 0.0 Then
                Me.Hide()
                Ingresar.Show()

                'se activa y configura el timer el cual es la base de la progress bar

                Timer1.Enabled = False
            End If
        Else
            ProgressBar1.Value += 5
            If ProgressBar1.Value = contador Then

                inicio.Text = "Iniciando....."
            Else
                If ProgressBar1.Value = contador + 16 Then
                    inicio.Text = " "
                    contador += 20

                End If

                'mientras se carga la progres bar se configura un timer para que aparescan mansajes como iniciando 
                'ademas que aparesca la version del software 

                texto.Text = "Version 1.0"

            End If
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub texto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles texto.Click

    End Sub
End Class