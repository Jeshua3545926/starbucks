'inicio de sesion conectada auna base de datos para validar  al cliente si existe o no y dependiendo si existe lo deja pasar y si no no  lo dejara pasar 

Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class Form7

    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=ASUS;Database=MyCompany;Integrated Security=True;"


    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	   ' Crea un gráfico con esquinas redondeadas para el formulario
	   Dim radius As Integer = 100
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
    ' Ejemplo de conexión y consulta a la base de datos

  Using connection As New SqlConnection(connectionString)
	   Try
		  connection.Open()

		  ' Consulta para validar LoginName, Email y Password
		  Dim query As String = "SELECT * FROM validacionDeCliente WHERE LoginName = @LoginName AND Email = @Email AND Password = @Password"
		  Dim command As New SqlCommand(query, connection)
		  command.Parameters.AddWithValue("@LoginName", TextBox1.Text) ' Nombre de usuario
		  command.Parameters.AddWithValue("@Email", TextBox2.Text) ' Correo electrónico
		  command.Parameters.AddWithValue("@Password", TextBox3.Text) ' Contraseña

		  Dim reader As SqlDataReader = command.ExecuteReader()
		  If reader.HasRows Then
			 While reader.Read()
				' Si se encuentra un registro, puedes asignar valores a los controles si es necesario
				TextBox3.Clear() ' Limpia el TextBox de contraseña
			 End While
			 ' Oculta el formulario actual y muestra el Form4
			 Form4.Show()
			 Me.Hide()
		  Else
			 MessageBox.Show("Nombre de usuario, correo electrónico o contraseña incorrectos.")
		  End If

		  reader.Close()

	   Catch ex As Exception
		  MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
	   End Try
    End Using

End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
	   Module1.nombre = TextBox1.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
	   Application.Exit()
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
	   ' Ajusta el valor de "radius" para cambiar el grado de redondez de las esquinas del botón
	   Dim radius As Integer = 20

	   ' Crea un gráfico con esquinas redondeadas para el botón
	   Dim path As New GraphicsPath()
	   path.AddArc(0, 0, radius, radius, 180, 90)
	   path.AddArc(Button1.Width - radius, 0, radius, radius, 270, 90)
	   path.AddArc(Button1.Width - radius, Button1.Height - radius, radius, radius, 0, 90)
	   path.AddArc(0, Button1.Height - radius, radius, radius, 90, 90)
	   path.CloseFigure()

	   ' Aplica el gráfico como la región del botón
	   Button1.Region = New Region(path)
	   Button3.Region = New Region(path)
	   Button2.Region = New Region(path)
    End Sub

    Private Sub Form7_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
	   Select Case e.KeyCode
		  Case Keys.D1, Keys.Enter
			 Button1.PerformClick()
	   End Select
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

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
	   '' Este método se dejó vacío, pero está listo si necesitas personalizar la apariencia de Panel1.
    'End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  Form13.Show()
Me.Hide()

End Sub


End Class
