
Imports System.IO

Public Class valida

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim valor As Object
        Dim archivo As Object

        valor = CreateObject("Scripting.FileSystemObject")
        'archivo = valor.CreateTextFile("C:\Users\ALEJANDRO\Desktop\pasword.txt", True)

        archivo = valor.CreateTextFile("C:\xampp\pasword.txt", True)

        archivo.WriteLine(texto1.Text)
        archivo.WriteLine(texto2.Text)
        archivo.close()

        texto1.Text = " "
        texto2.Text = " "


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub valida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class