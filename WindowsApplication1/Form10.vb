'ticket donde se muestra  la informacion del usuarioñ como nombre producto que escogio y etc
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class Form10
#Region "form"
Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load


TextBox1.Text = "Su nombre es: " & Module1.nombre & " " & Module1.apellidoPaterno & " " & Module1.apellidoMaterno & Environment.NewLine

		' Mostrar cantidad de productos
		TextBox1.Text &= "La cantidad de productos que escogió fue: " & Module1.cantidad.ToString() & Environment.NewLine

		' Calcular el total y mostrarlo


If Module1.ProductoLatte = "Si" Or ProductoLatte = "latte" Then

	Module1.operacion = Module1.cantidad * 200
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
End If
End If


If Module1.productoS = "Si" Or productoS = "for" Then

	Module1.operacion = Module1.cantidad * 300
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
		End If
	End If


 If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else



		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
	End If










If Module1.productoat = "Si" Or productoat = "latte" Then

	Module1.operacion = Module1.cantidad * 200
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
End If
End If


If Module1.productoSa = "Si" Or productoSa = "for" Then

	Module1.operacion = Module1.cantidad * 300
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
		End If
	End If


 If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else



		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
	End If






If Module1.productoSa = "Si" Or productoSa = "latte" Then

	Module1.operacion = Module1.cantidad * 200
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
End If
End If


If Module1.productoSt = "Si" Or productoSt = "for" Then

	Module1.operacion = Module1.cantidad * 300
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
		End If
	End If


 If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else



		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
	End If

























If Module1.productot = "Si" Or productot = "latte" Then

	Module1.operacion = Module1.cantidad * 200
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
End If
End If


If Module1.productoSo = "Si" Or productoSo = "for" Then

	Module1.operacion = Module1.cantidad * 300
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
		End If
	End If


 If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else



		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
	End If










If Module1.productoS9i = "Si" Or productoS9i = "latte" Then

	Module1.operacion = Module1.cantidad * 200
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
End If
End If


If Module1.productoS9 = "Si" Or productoS9 = "for" Then

	Module1.operacion = Module1.cantidad * 300
		TextBox1.Text &= "Su total es de: " & Module1.operacion.ToString("C2") & Environment.NewLine  ' El 

	   ' Agregar información condicional
	   If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else

		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
		End If
	End If


 If Module1.envio = " Starbucks  CENTRO " Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = "Starbucks  ALTAMA" Then

		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   ElseIf Module1.envio = " Starbucks ALTAMIRA" Then
		  TextBox1.Text &= "Sucursal domde recogera su pedido: " & Module1.envio & Environment.NewLine

	   Else
		  TextBox1.Text &= "Envío: " & Module1.direccion & Environment.NewLine &
						"Estado: " & Module1.estado & Environment.NewLine &
						"Ciudad: " & Module1.ciudad & Environment.NewLine &
						"Colonia: " & Module1.Colonia & Environment.NewLine &
						"Calle: " & Module1.Calle & Environment.NewLine
	   End If

	   If Module1.pago = "1000" Then
		' Calcular el cambio
			Dim cambio As Decimal = 1000 - Module1.operacion
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "200" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine


	   ElseIf Module1.pago = "300" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2500" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "2100" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

	   ElseIf Module1.pago = "3000" Then
		  TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine

		ElseIf Module1.pago = "5000" Then
		 TextBox1.Text &= " Metodo de Pago es efectivo" & Module1.efectivo & Environment.NewLine &
						" su cambio es de " & Module1.cambio & Environment.NewLine &
						" su suscursal de pago sera " & Module1.sucursalDePago & Environment.NewLine
	   Else



		  TextBox1.Text &= " Numero de tarjeta " & Module1.numeroTarjeta & Environment.NewLine & "Su dia de vencimiento es" & Module1.diaVencimiento &
						" sú mes de vencimiento " & Module1.mes & Environment.NewLine &
						" su año de vencimiento es " & Module1.añoVencimento & Environment.NewLine &
						" Su metodo de pago es  " & Module1.banco & Environment.NewLine
	End If
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  Application.Exit()

End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
  Me.WindowState = FormWindowState.Minimized
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

If Me.WindowState = FormWindowState.Maximized Then

Me.WindowState = FormWindowState.Normal

Else
Me.WindowState = FormWindowState.Maximized

End If

End Sub


#End Region
#Region "Drag Form"
<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
Private Shared Sub ReleaseCapture()
End Sub

<DllImport("user32.DLL", EntryPoint:="SendMessage")>
Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wPram As Integer, lParam As Integer)

End Sub
#End Region

Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
ReleaseCapture()
SendMessage(Me.Handle, &H112&, &HF012&, 0)



End Sub
End Class