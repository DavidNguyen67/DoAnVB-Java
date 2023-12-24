<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addCategory
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
        Me.txt_categoryName = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_categoryName
        '
        Me.txt_categoryName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_categoryName.Location = New System.Drawing.Point(12, 41)
        Me.txt_categoryName.Name = "txt_categoryName"
        Me.txt_categoryName.Size = New System.Drawing.Size(296, 34)
        Me.txt_categoryName.TabIndex = 4
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(12, 91)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(296, 35)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter Category Name"
        '
        'frm_addCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(326, 148)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_categoryName)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_addCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_categoryName As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label1 As Label
End Class
