'sistema de direccion donde  piede al cliente su metodo de direccion yasea sucursal o direccion de su casa conectada a una base de datos para guardar numero de celular
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient

Public Class Form8
    Private connectionString As String = "Server=192.168.0.6;Database=MyCompany;Integrated Security=True;"

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	   ' Aplica esquinas redondeadas a los botones de 519 x 67
	   ApplyRoundedCorners(Button1, 30)
	   ApplyRoundedCorners(Button2, 30)

	   ' Aplica esquinas redondeadas al botón de 74 x 74
	   ApplyRoundedCorners(Button3, 20)
    End Sub

    Private Sub ApplyRoundedCorners(button As Button, radius As Integer)
	   Dim path As New GraphicsPath()
	   path.StartFigure()
	   path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
	   path.AddArc(New Rectangle(button.Width - radius, 0, radius, radius), 270, 90)
	   path.AddArc(New Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90)
	   path.AddArc(New Rectangle(0, button.Height - radius, radius, radius), 90, 90)
	   path.CloseFigure()
	   button.Region = New Region(path)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
	   Module1.envio = ComboBox1.SelectedItem.ToString()
	   openChildForm(New Form1())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
	   ' Asignación de valores a las variables del módulo
	   Module1.Colonia = TextBox5.Text
	   Module1.Calle = TextBox6.Text
	   Module1.direccion = ComboBox2.SelectedItem.ToString()
	   Module1.apellidoPaterno = TextBox2.Text
	   Module1.apellidoMaterno = TextBox1.Text
	   Module1.estado = ComboBox3.SelectedItem.ToString()
	   Module1.ciudad = ComboBox4.SelectedItem.ToString()
	   Module1.numeroDeCelular = TextBox3.Text
	   openChildForm(New Form1())

    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
	   If currentForm IsNot Nothing Then currentForm.Close()
	   currentForm = childForm
	   childForm.TopLevel = False
	   childForm.FormBorderStyle = FormBorderStyle.None
	   childForm.Dock = DockStyle.Fill
	   Panel2.Controls.Add(childForm)
	   Panel2.Tag = childForm
	   Panel2.BringToFront()
	   childForm.Show()
	   Panel1.Visible = False
	   Label1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
	   Application.Exit()
    End Sub
End Class
'Imports System.Drawing.Drawing2D
'Imports System.Data.SqlClient

'Public Class Form8
' Private connectionString As String = "Server=Asus;Database=MyCompany;Integrated "
'    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    ' Aplica esquinas redondeadas a los botones de 519 x 67
'    ApplyRoundedCorners(Button1, 30) ' Primer botón de 519 x 67 con radio de 30
'    ApplyRoundedCorners(Button2, 30) ' Segundo botón de 519 x 67 con radio de 30

'    ' Aplica esquinas redondeadas al botón de 74 x 74
'    ApplyRoundedCorners(Button3, 20) ' Botón de 74 x 74 con radio de 20
'	   ' Crea un gráfico con esquinas redondeadas

'    End Sub
'Private Sub ApplyRoundedCorners(button As Button, radius As Integer)
'    Dim path As New GraphicsPath()
'    path.StartFigure()
'    path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
'    path.AddArc(New Rectangle(button.Width - radius, 0, radius, radius), 270, 90)
'    path.AddArc(New Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90)
'    path.AddArc(New Rectangle(0, button.Height - radius, radius, radius), 90, 90)
'    path.CloseFigure()


'    button.Region = New Region(path)
'End Sub

'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'Module1.envio = ComboBox1.SelectedItem.ToString()

'openChildForm(New Form1())
'End Sub


'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'Module1.direccion = ComboBox2.SelectedItem.ToString()
'  Module1.apellidoPaterno = TextBox2.Text
'  Module1.apellidoMaterno = TextBox1.Text
'  TextBox1.Text = Module1.CodigoPostal
'  TextBox1.Text = Module1.Colonia
'  TextBox1.Text = Module1.Calle
'  TextBox1.Text = Module1.numeroDeCelular

'  openChildForm(New Form1())
'MsgBox(Module1.apellidoMaterno & Module1.apellidoPaterno)
'Module1.estado = ComboBox3.SelectedItem.ToString()
'Module1.ciudad = ComboBox4.SelectedItem.ToString()


'Using connection As New SqlConnection(connectionString)
'    Try
'	   connection.Open()

'	   ' Consulta para insertar un nuevo usuario
'	   Dim query As String = "INSERT INTO NumeroDeClientess (numeroDeCliente) VALUES (@numeroDeCliente)"
'	   Dim command As New SqlCommand(query, connection)
'	   command.Parameters.AddWithValue("@numeroDeCliente", TextBox3.Text)	' Número de cliente

'	   ' Ejecuta la consulta de inserción
'	   Dim result As Integer = command.ExecuteNonQuery()

'	   ' Verifica si se insertó una fila (es decir, si el registro fue exitoso)
'	   If result > 0 Then
'		  MessageBox.Show("Usuario registrado exitosamente.")
'		  Form4.Show()
'		  Me.Hide()
'	   Else
'		  MessageBox.Show("Error al registrar el usuario.")
'	   End If

'    Catch ex As Exception
'	   MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
'    End Try
'End Using

'End Sub

'Private currentForm As Form = Nothing
'Private Sub openChildForm(childForm As Form)
'If currentForm IsNot Nothing Then currentForm.Close()
'currentForm = childForm
'childForm.TopLevel = False
'childForm.FormBorderStyle = FormBorderStyle.None
'childForm.Dock = DockStyle.Fill
'Panel2.Controls.Add(childForm)
'Panel2.Tag = childForm
'Panel2.BringToFront()
'childForm.Show()
'Panel1.Visible = False
'Label1.Visible = False

'End Sub

'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'Application.Exit()

'End Sub

'End Class