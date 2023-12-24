<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Location = New System.Drawing.Point(46, 99)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(192, 23)
        Me.txt_username.TabIndex = 0
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Location = New System.Drawing.Point(46, 162)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(192, 23)
        Me.txt_password.TabIndex = 1
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Location = New System.Drawing.Point(46, 208)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(192, 36)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.Location = New System.Drawing.Point(46, 250)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(192, 36)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Register Here !"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(290, 330)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 21
        Me.LineShape3.X2 = 164
        Me.LineShape3.Y1 = 58
        Me.LineShape3.Y2 = 58
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 48
        Me.LineShape2.X2 = 240
        Me.LineShape2.Y1 = 188
        Me.LineShape2.Y2 = 188
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 45
        Me.LineShape1.X2 = 237
        Me.LineShape1.Y1 = 124
        Me.LineShape1.Y2 = 124
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 330)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
End Class
