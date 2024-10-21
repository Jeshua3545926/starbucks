'sistema de pago ya sea de tarjeta o efectivo donde el cliente escoge su metodo de pago

Imports System.Drawing.Drawing2D

Public Class Form9

Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Define el radio de las esquinas redondeadas, ajustado para el tamaño del botón
    Dim radius As Integer = 30 ' Ajusta este valor según sea necesario

    ' Crea un gráfico con esquinas redondeadas para el botón
    Dim path As New GraphicsPath()
    path.StartFigure()
    path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
    path.AddArc(New Rectangle(Button1.Width - radius, 0, radius, radius), 270, 90)
    path.AddArc(New Rectangle(Button1.Width - radius, Button1.Height - radius, radius, radius), 0, 90)
    path.AddArc(New Rectangle(0, Button1.Height - radius, radius, radius), 90, 90)
    path.CloseFigure()

    ' Asigna la región personalizada al botón
    Button1.Region = New Region(path)
    Button2.Region = New Region(path)

End Sub


Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
Module1.pago = Convert.ToInt32(ComboBox6.SelectedItem.ToString)
Module1.sucursalDePago = ComboBox1.SelectedItem.ToString()
Module1.efectivo = ComboBox6.SelectedItem.ToString()
Form10.Show()
Me.Hide()
Form4.Show()
Me.Close()


End Sub


Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
Module1.numeroTarjeta = Convert.ToInt32(TextBox1.Text)
Module1.pin = Convert.ToInt32(TextBox3.Text)
Module1.Cvv = Convert.ToInt32(TextBox2.Text)
Module1.mes = Convert.ToInt32(ComboBox5.SelectedItem.ToString())
Module1.banco = ComboBox4.SelectedItem.ToString()
Module1.diaVencimiento = Convert.ToInt32(ComboBox2.SelectedItem.ToString())
Module1.añoVencimento = Convert.ToInt32(ComboBox3.SelectedItem.ToString())
Module1.Titular = Convert.ToInt32(TextBox1.Text)
Form10.Show()
Me.Hide()

Form4.Show()
Me.Close()


End Sub

End Class