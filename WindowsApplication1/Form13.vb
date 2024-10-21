' un registro de usuario donde se conecta a una base de datos para guardar la informacion del cliente

Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class Form13
    Private connectionString As String = "Server=ASUS;Database=MyCompany;Integrated Security=True;"


    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	   ' Crea un gráfico con esquinas redondeadas para el formulario
	   Dim radius As Integer = 75
	   Dim path As New GraphicsPath()
	   path.AddArc(0, 0, radius, radius, 180, 90)
	   path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
	   path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
	   path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
	   path.CloseFigure()

	   ' Aplica el gráfico como la región del formulario
	   Me.Region = New Region(path)
    End Sub




Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
 ' Código para registrar un nuevo usuario

    Using connection As New SqlConnection(connectionString)
	   Try
		  connection.Open()

		  ' Consulta para insertar un nuevo usuario
		  Dim query As String = "INSERT INTO validacionDeCliente (LoginName, Password, Email) VALUES (@LoginName, @Password, @Email)"
		  Dim command As New SqlCommand(query, connection)
		  command.Parameters.AddWithValue("@LoginName", TextBox1.Text) ' Nombre de usuario
		  command.Parameters.AddWithValue("@Password", TextBox3.Text) ' Contraseña
		  command.Parameters.AddWithValue("@Email", TextBox2.Text) ' Correo electrónico

		  ' Ejecuta la consulta de inserción
		  Dim result As Integer = command.ExecuteNonQuery()

		  ' Verifica si se insertó una fila (es decir, si el registro fue exitoso)
		  If result > 0 Then
			 MessageBox.Show("Usuario registrado exitosamente.")
Form4.Show()
Me.Hide()

		  Else
			 MessageBox.Show("Error al registrar el usuario.")
		  End If

	   Catch ex As Exception
		  MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
	   End Try
    End Using
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
  Application.Exit()
End Sub


   Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
	   ReleaseCapture()
	   SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wPram As Integer, lParam As Integer)
    End Sub



Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  Module1.nombre = TextBox1.Text
End Sub
End Class