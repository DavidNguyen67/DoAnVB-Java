<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_expance
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
        Me.dtp_expanceDate = New System.Windows.Forms.DateTimePicker()
        Me.cbo_category = New System.Windows.Forms.ComboBox()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_category = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtp_expanceDate
        '
        Me.dtp_expanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_expanceDate.Location = New System.Drawing.Point(59, 35)
        Me.dtp_expanceDate.Name = "dtp_expanceDate"
        Me.dtp_expanceDate.Size = New System.Drawing.Size(261, 30)
        Me.dtp_expanceDate.TabIndex = 0
        '
        'cbo_category
        '
        Me.cbo_category.FormattingEnabled = True
        Me.cbo_category.Location = New System.Drawing.Point(59, 103)
        Me.cbo_category.Name = "cbo_category"
        Me.cbo_category.Size = New System.Drawing.Size(219, 31)
        Me.cbo_category.TabIndex = 1
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(59, 173)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(261, 30)
        Me.txt_amount.TabIndex = 2
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(59, 243)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(261, 74)
        Me.txt_remarks.TabIndex = 3
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(59, 341)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(261, 55)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Remarks"
        '
        'btn_category
        '
        Me.btn_category.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_category.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_category.ForeColor = System.Drawing.Color.White
        Me.btn_category.Location = New System.Drawing.Point(284, 103)
        Me.btn_category.Name = "btn_category"
        Me.btn_category.Size = New System.Drawing.Size(36, 31)
        Me.btn_category.TabIndex = 9
        Me.btn_category.Text = "+"
        Me.btn_category.UseVisualStyleBackColor = False
        '
        'frm_expance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 437)
        Me.Controls.Add(Me.btn_category)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.cbo_category)
        Me.Controls.Add(Me.dtp_expanceDate)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_expance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp_expanceDate As DateTimePicker
    Friend WithEvents cbo_category As ComboBox
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents txt_remarks As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_category As Button
End Class
