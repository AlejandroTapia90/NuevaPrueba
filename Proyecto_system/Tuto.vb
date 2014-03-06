Public Class Tuto

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim RetVal
        RetVal = Shell("C:\Program Files\GenoPro\GenoPro.exe", 1)
        Menú_paciente.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("C:\Program Files\GenoPro\Tutorial.pdf ")
        Menú_paciente.Show()
        Me.Close()
    End Sub

    Private Sub Tuto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menú_paciente.Hide()
    End Sub
End Class