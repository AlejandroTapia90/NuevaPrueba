
'En la clase paciente se realiza el almacenado de datos de los pacientes, se agregan, se eliminan, buscan datos de 
'los pacientes.
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Paciente
    Dim datos As String
    Dim conn As MySqlConnection
    Dim lector As MySqlDataReader
    Dim cargar As String
    Dim dataset As New DataSet
    Dim otra As String

    'En el metodo load del la clase paciente se realiza la conexion con la base de datos y se invoca el metodo
    'llenado.

    Private Sub Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buscar_paciente.Hide()
        Menú_paciente.Hide()

        Dim sr As StreamReader = New StreamReader("C:\xampp\pasword.txt")
        Dim usuario As String
        Dim pasword As String

        usuario = sr.ReadToEnd
        pasword = sr.ReadToEnd

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=" + usuario + "; password=" + pasword + " ;database=consultoria"
        conn.Open()



        'conn = New MySqlConnection
        'conn.ConnectionString = "server=localhost;user id=root; password= ; database=consultoria"
        'conn.Open()
        llenado()
        box1.Text = ""

    End Sub

    'El siguiente metodo muestra el funcionamiento dela tabla dgbconsulta en el cual el ciclo for sirve para selecionar una 
    'columna el valor de la columna selecionado se guardaen la variable otra la cual utilizamos en metodos posteriores.

    'Private Sub dgbconsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbpaciente.CellContentClick

    '    For x = 0 To dgbpaciente.Rows.Count - 2
    '        If dgbpaciente.Item(1, x).Selected = True Then

    '            otra = dgbpaciente.Item(0, x).Value

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'El metodo siguiente corresponde al boton nuevo el cual limpia los campos para que se puede llenar un nuevo registro

    Private Sub boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton.Click

        idpaciente.Text = ""
        nombrep.Text = ""
        tel.Text = ""
        box1.Text = ""
        edad.Text = ""
        calles.Text = ""
        num.Text = ""
        col.Text = ""
        cd.Text = ""
        box1.Text = ""

    End Sub

    'El metodo del boton aceptar funciona de la siguiente manera para empesar se validan que todos los campos esten llenos.
    'en el if se valida que los campos esten llenos si no lo es asi manda msg de error    
    'Se isertan los registros en la tabla pacientes
    'ademas de la tabla pacientes tambien se insertan registros en las tablas, analisis, primera consulta,consulta subsecuente
    'ya que estas tablas estan relacionadas de manera directa con el registro del paciente, para la generacion correcta del historial
    'clinico.

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        If cd.Text = "" Or col.Text = "" Or num.Text = "" Or calles.Text = "" Or edad.Text = "" Or tel.Text = "" Or nombrep.Text = "" Then

            MsgBox("Falta ingresar datos en algunos de los campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
            MsgBox("Es nesesario ingresar datos en todos los campos para poder guardar informacion", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")

        Else

            Dim Comando As New MySqlCommand("insert into pacientes values('" + idpaciente.Text + "','" + nombrep.Text + "','" + edad.Text + " ','" + box1.Text + "','" + calles.Text + "','" + num.Text + "','" + col.Text + "','" + cd.Text + "','" + tel.Text + "')", conn)
            MsgBox("Datos guardados correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notificación del sistema")
            Comando.ExecuteNonQuery()

            idpaciente.Text = ""
            nombrep.Text = ""
            edad.Text = ""
            box1.Text = ""
            calles.Text = ""
            num.Text = ""
            col.Text = ""
            cd.Text = ""
            tel.Text = ""

            Dim Comando2 As New MySqlCommand("insert into primera_consul(Id_Paciente) values('" + idpaciente.Text + "')", conn)
            Comando2.ExecuteNonQuery()

            Dim Comando3 As New MySqlCommand("insert into consulta_subsecuente(Id_Paciente) values('" + idpaciente.Text + "')", conn)
            Comando3.ExecuteNonQuery()

            Dim Comando4 As New MySqlCommand("insert into analisis(Id_Paciente) values('" + idpaciente.Text + "')", conn)
            Comando4.ExecuteNonQuery()

        End If

        'se inicializan las variables a utilizar en las validaciones de los campos

        nom = 0
        nume = 0
        em = 0
        cp = 0
        tele = 0

        'se invoca al metodo llenado para la actualizacion de los campos agregados 
        llenado()
        repor.Refresh()
        Menú_paciente.Refresh()

    End Sub

    'El funcionamiento del boton ir a agenda abre la ventana de registro de paciente 

    Private Sub Agendar_citas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agendar_citas.Click
        Buscar_paciente.Show()

    End Sub

    'El funcionamiento del boton salir cierra el sistema por completo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    'El boton eliminar funciona con el valor tomado por la variable otra recibe el valor del metodo anterior dgbpaciente y
    'elimina el registro con el nombre e id en todos los campos que fue insertado, por ultimo se llama al metodo llenado 
    'el cual actualiza la tabla.

    Private Sub elimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elimi.Click
        Eliminando.ShowDialog()
    End Sub

    'El metodo del boton ir al menú anterior cierra la ventana actual y regresa al menú de actualizar pacientes

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Menú_paciente.Show()

    End Sub

    'El boton buscar paciente abre la ventana de busqueda donde se buscan los datos de un paciente en especifico

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Buscar_paciente.ShowDialog()
    End Sub

    'El siguiente metodo keydown valida que el campo de texto nombre del pacente no permita ni copiar ni pegar texto

    Private Sub nombrep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nombrep.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            nombrep.ReadOnly = True
        Else
            nombrep.ReadOnly = False
        End If
    End Sub

    'El metodo keypress siguiente del campo de texto nombre valida que solo se puedan ingresar letras, que puedan aceptarse espacios
    'y un maximo de 40 caracteres.

    Private Sub nombrep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nombrep.KeyPress

        If Char.IsLetter(e.KeyChar) And em < 30 Then
            e.Handled = False
            em = em + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If em >= 0 Then
                em = em - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto ap del pacente no permita ni copiar ni pegar texto


    'El metodo keypress siguiente del campo de texto ap valida que solo se puedan ingresar letras, que puedan aceptarse espacios
    'y un maximo de 30 caracteres.

    Private Sub ap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) And em < 30 Then
            e.Handled = False
            em = em + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If em >= 0 Then
                em = em - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto am del pacente no permita ni copiar ni pegar texto

 

    'El metodo keypress siguiente del campo de texto am valida que solo se puedan ingresar letras, que puedan aceptarse espacios
    'y un maximo de 30 caracteres.

    Private Sub am_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) And em < 30 Then
            e.Handled = False
            em = em + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If em >= 0 Then
                em = em - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto calles del pacente no permita ni copiar ni pegar texto

    Private Sub tel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tel.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            tel.ReadOnly = True
        Else
            tel.ReadOnly = False
        End If
    End Sub

    'El metodo keypress siguiente del campo de texto tel valida que solo se puedan ingresar solo digitos,
    'y acepta un maximo de 12 caracteres.

    Private Sub tel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tel.KeyPress
        If Char.IsDigit(e.KeyChar) And nume < 12 Then
            e.Handled = False
            nume = nume + 1
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If nume >= 0 Then
                nume = nume - 1
            End If
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto calles del pacente no permita ni copiar ni pegar texto

    Private Sub edad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles edad.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            edad.ReadOnly = True
        Else
            edad.ReadOnly = False
        End If
    End Sub

    'El metodo keypress siguiente del campo de texto edad valida que solo se puedan ingresar solo digitos,
    'y acepta un maximo de 2 caracteres.

    Private Sub edad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles edad.KeyPress

        If Char.IsDigit(e.KeyChar) And cp < 2 Then
            e.Handled = False
            cp = cp + 1
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If cp >= 0 Then
                cp = cp - 1
            End If
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto calles del pacente no permita ni copiar ni pegar texto

    Private Sub calles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles calles.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            calles.ReadOnly = True
        Else
            calles.ReadOnly = False
        End If
    End Sub

    'El metodo keypress siguiente del campo de texto calles valida que solo se puedan ingresar letras, que puedan aceptarse espacios
    'y un maximo de 40 caracteres.

    Private Sub calles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles calles.KeyPress

        If Char.IsLetter(e.KeyChar) And nom < 40 Then
            e.Handled = False
            nom = nom + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If nom >= 0 Then
                nom = nom - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto num del pacente no permita ni copiar ni pegar texto

    Private Sub num_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles num.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            num.ReadOnly = True
        Else
            num.ReadOnly = False
        End If
    End Sub

    'El metodo keypress siguiente del campo de texto num valida que solo se puedan ingresar solo digitos,
    'y acepta un maximo de 5 caracteres.

    Private Sub num_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles num.KeyPress

        If Char.IsDigit(e.KeyChar) And tele < 5 Then
            e.Handled = False
            tele = tele + 1
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If tele >= 0 Then
                tele = tele - 1
            End If
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto col del pacente no permita ni copiar ni pegar texto

    Private Sub col_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles col.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            col.ReadOnly = True
        Else
            col.ReadOnly = False
        End If
    End Sub

    'El metodo keypress siguiente del campo de texto col valida que solo se puedan ingresar letras, que puedan aceptarse espacios
    'y un maximo de 40 caracteres.

    Private Sub col_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles col.KeyPress

        If Char.IsLetter(e.KeyChar) And nom < 40 Then
            e.Handled = False
            nom = nom + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If nom >= 0 Then
                nom = nom - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        Else
            e.Handled = True
        End If

    End Sub

    'El siguiente metodo keydown valida que el campo de texto cd del pacente no permita ni copiar ni pegar texto

    Private Sub cd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cd.KeyDown
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            cd.ReadOnly = True
        Else
            cd.ReadOnly = False
        End If
    End Sub

    'El metodo keypress siguiente del campo de texto cd valida que solo se puedan ingresar letras, que puedan aceptarse espacios
    'y un maximo de 40 caracteres.

    Private Sub cd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cd.KeyPress

        If Char.IsLetter(e.KeyChar) And nom < 40 Then
            e.Handled = False
            nom = nom + 1
            eb = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If nom >= 0 Then
                nom = nom - 1
            End If
            eb = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) And eb = False Then
            e.Handled = False
            eb = True
        Else
            e.Handled = True
        End If

    End Sub

    'El metodo keypress para el comboBox sirve para bloquear el comboBox para que no sea posible modificarlo

    Private Sub box1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles box1.KeyPress
        e.KeyChar = ""
    End Sub

    'El metodo llamado es el que carga los datos de la tabla dgbpaciente

    Sub llenado()
        datos = "SELECT * FROM pacientes"
        Dim adaptador As New MySqlDataAdapter(datos, conn)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dgbpaciente.DataSource = dataset.Tables(0)

    End Sub


    Private Sub nombrep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nombrep.TextChanged
        Dim I As Integer
        nombrep.Text = UCase(nombrep.Text)
        I = Len(nombrep.Text)
        nombrep.SelectionStart = I
    End Sub

    Private Sub calles_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calles.TextChanged
        Dim I As Integer
        calles.Text = UCase(calles.Text)
        I = Len(calles.Text)
        calles.SelectionStart = I
    End Sub

    Private Sub col_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles col.TextChanged
        Dim I As Integer
        col.Text = UCase(col.Text)
        I = Len(col.Text)
        col.SelectionStart = I
    End Sub

    Private Sub cd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd.TextChanged
        Dim I As Integer
        cd.Text = UCase(cd.Text)
        I = Len(cd.Text)
        cd.SelectionStart = I
    End Sub

    Private Sub box1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box1.SelectedIndexChanged

    End Sub
End Class



