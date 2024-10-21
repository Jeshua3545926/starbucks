<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.Window
		Me.Panel2.Controls.Add(Me.Button4)
		Me.Panel2.Controls.Add(Me.Button3)
		Me.Panel2.Controls.Add(Me.PictureBox1)
		Me.Panel2.Controls.Add(Me.Label1)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(801, 795)
		Me.Panel2.TabIndex = 21
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._294657_starbucks_icon
		Me.PictureBox1.Location = New System.Drawing.Point(0, 99)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(939, 746)
		Me.PictureBox1.TabIndex = 21
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
		  Or System.Windows.Forms.AnchorStyles.Left) _
		  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Font = New System.Drawing.Font("MV Boli", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(135, 35)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(240, 61)
		Me.Label1.TabIndex = 20
		Me.Label1.Text = "STARBUCKS"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Button4
		'
		Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.SystemColors.MenuText
		Me.Button4.Location = New System.Drawing.Point(654, 3)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(57, 47)
		Me.Button4.TabIndex = 24
		Me.Button4.Text = "-"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.SystemColors.MenuText
		Me.Button3.Location = New System.Drawing.Point(714, 3)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 47)
		Me.Button3.TabIndex = 23
		Me.Button3.Text = "X"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Form6
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(801, 795)
		Me.Controls.Add(Me.Panel2)
		Me.Name = "Form6"
		Me.Text = "Form6"
		Me.Panel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
