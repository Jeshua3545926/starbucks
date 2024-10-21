'menu de productos donde el cliente pueda comprar o agregar al carrito 

Public Class Form1
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
		Module1.ProductoLatte = InputBox("Me confirma que su producto sera latte?")

		If Module1.ProductoLatte = "no" Then
				MessageBox.Show("Ok siga comprando")
  End If
	End Sub






    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
	   Module1.productoSat = InputBox("Me confiraa que su producto sera for")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
		  Module1.productoat = InputBox("Me confiraa que su producto sera for")


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
	  Module1.productoS = InputBox("Me confiraa que su producto sera for")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
		  Module1.productot = InputBox("Me confiraa que su producto sera for")


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
	   Module1.productoSa = InputBox("Me confiraa que su producto sera for")

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
	   Module1.productoSt = InputBox("Me confiraa que su producto sera for")

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
	   Module1.productoSo = InputBox("Me confiraa que su producto sera for")


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
		Module1.productoS9i = InputBox("Me confiraa que su producto sera for")

    End Sub


Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
  Application.Exit()
End Sub

Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click


	   MsgBox("su nombre es " & Module1.nombre)
	   Module1.cantidad = InputBox("ingrese la cantidad que usted desea")
		Module1.productoS9 = InputBox("Me confiraa que su producto sera for")


End Sub


	Private currentForm As Form = Nothing
	Private Sub openChildForm(childForm As Form)
	   If currentForm IsNot Nothing Then currentForm.Close()
	   currentForm = childForm
	   childForm.TopLevel = False
	   childForm.FormBorderStyle = FormBorderStyle.None
	   childForm.Dock = DockStyle.Fill
	   Panel10.Controls.Add(childForm)

	   Panel10.Tag = childForm
	   Panel10.BringToFront()
	   childForm.Show()
	   Panel2.Visible = False

	   Panel4.Visible = False
	   Panel3.Visible = False
	   Panel5.Visible = False
	   Panel7.Visible = False
	   Panel6.Visible = False

	   Panel9.Visible = False
	   Panel11.Visible = False
	   cafe3.Visible = False
	   cafe2.Visible = False
	   cafe.Visible = False


	   Button11.Visible = False
	   Button10.Visible = False
	   Button2.Visible = False
	   Button3.Visible = False
	   Button4.Visible = False
	   Button5.Visible = False

	   Button5.Visible = False
	   Button14.Visible = False
	   Button15.Visible = False
	   Button13.Visible = False
	   Button12.Visible = False
	   Button16.Visible = False
	   Button5.Visible = False
	   Button21.Visible = False
	   Button20.Visible = False
	   Button19.Visible = False
	   Button18.Visible = False

	End Sub

End Class
