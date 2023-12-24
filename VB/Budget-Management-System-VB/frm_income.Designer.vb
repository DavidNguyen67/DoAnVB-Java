<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_income
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
        Me.txt_incomeAmount = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_incomeAmount
        '
        Me.txt_incomeAmount.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_incomeAmount.Location = New System.Drawing.Point(12, 35)
        Me.txt_incomeAmount.Name = "txt_incomeAmount"
        Me.txt_incomeAmount.Size = New System.Drawing.Size(320, 43)
        Me.txt_incomeAmount.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(12, 95)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(320, 42)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Your Income Amount"
        '
        'frm_income
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(349, 169)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_incomeAmount)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_income"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_incomeAmount As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label1 As Label
End Class
