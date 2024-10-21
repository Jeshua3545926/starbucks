' inicio de aplicacion
Public Class Form4

Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.WindowState = FormWindowState.Maximized
End Sub


Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
openChildForm(New Form9())
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
  openChildForm(New Form8())

End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

 openChildForm(New Form1())



End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  openChildForm(New Form6())
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
PictureBox1.Visible = False
Label1.Visible = False
Button3.Visible = False
Button4.Visible = False


    End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Form7.Show()
Me.Hide()

End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  Application.Exit()

End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    Me.WindowState = FormWindowState.Minimized
End Sub
End Class