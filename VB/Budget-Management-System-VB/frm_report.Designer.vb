<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_incomeOverallTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_incomeMonthYear = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_totalExpance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_expanceFilter = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbo_expanceFilterMonthAndYear = New System.Windows.Forms.ComboBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btn_Exit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 100)
        Me.Panel1.TabIndex = 0
        '
        'btn_Exit
        '
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.ForeColor = System.Drawing.Color.White
        Me.btn_Exit.Location = New System.Drawing.Point(762, 0)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(160, 100)
        Me.btn_Exit.TabIndex = 1
        Me.btn_Exit.Text = "EXIT"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REPORT"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 50)
        Me.TabControl1.Location = New System.Drawing.Point(0, 100)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(15, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(922, 547)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(914, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INCOME"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 84)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(908, 402)
        Me.DataGridView2.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 53
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Month"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 104
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Month & Year"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_incomeOverallTotal)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbo_incomeMonthYear)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(908, 81)
        Me.Panel3.TabIndex = 0
        '
        'lbl_incomeOverallTotal
        '
        Me.lbl_incomeOverallTotal.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_incomeOverallTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_incomeOverallTotal.Location = New System.Drawing.Point(626, 20)
        Me.lbl_incomeOverallTotal.Name = "lbl_incomeOverallTotal"
        Me.lbl_incomeOverallTotal.Size = New System.Drawing.Size(277, 35)
        Me.lbl_incomeOverallTotal.TabIndex = 14
        Me.lbl_incomeOverallTotal.Text = "0.00"
        Me.lbl_incomeOverallTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Filter by Month & Year"
        '
        'cbo_incomeMonthYear
        '
        Me.cbo_incomeMonthYear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_incomeMonthYear.FormattingEnabled = True
        Me.cbo_incomeMonthYear.Location = New System.Drawing.Point(193, 20)
        Me.cbo_incomeMonthYear.Name = "cbo_incomeMonthYear"
        Me.cbo_incomeMonthYear.Size = New System.Drawing.Size(227, 36)
        Me.cbo_incomeMonthYear.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 54)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(914, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EXPANCE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Month, Me.Column3, Me.Column4, Me.Amount, Me.Column5})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(908, 399)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 53
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "Date"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 86
        '
        'Month
        '
        Me.Month.HeaderText = "Month"
        Me.Month.MinimumWidth = 6
        Me.Month.Name = "Month"
        Me.Month.ReadOnly = True
        Me.Month.Width = 125
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Month & Year"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 173
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Category"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.MinimumWidth = 6
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 125
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Remarks"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 122
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_totalExpance)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_expanceFilter)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.cbo_expanceFilterMonthAndYear)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(908, 84)
        Me.Panel2.TabIndex = 0
        '
        'lbl_totalExpance
        '
        Me.lbl_totalExpance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalExpance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_totalExpance.Location = New System.Drawing.Point(620, 42)
        Me.lbl_totalExpance.Name = "lbl_totalExpance"
        Me.lbl_totalExpance.Size = New System.Drawing.Size(277, 35)
        Me.lbl_totalExpance.TabIndex = 11
        Me.lbl_totalExpance.Text = "0.00"
        Me.lbl_totalExpance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(606, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "TO"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(644, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(149, 27)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Filter by Month & Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search by Category"
        '
        'btn_expanceFilter
        '
        Me.btn_expanceFilter.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_expanceFilter.FlatAppearance.BorderSize = 0
        Me.btn_expanceFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_expanceFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_expanceFilter.ForeColor = System.Drawing.Color.White
        Me.btn_expanceFilter.Location = New System.Drawing.Point(813, 6)
        Me.btn_expanceFilter.Name = "btn_expanceFilter"
        Me.btn_expanceFilter.Size = New System.Drawing.Size(84, 27)
        Me.btn_expanceFilter.TabIndex = 6
        Me.btn_expanceFilter.Text = "FILTER"
        Me.btn_expanceFilter.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(451, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 27)
        Me.DateTimePicker1.TabIndex = 4
        '
        'cbo_expanceFilterMonthAndYear
        '
        Me.cbo_expanceFilterMonthAndYear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_expanceFilterMonthAndYear.FormattingEnabled = True
        Me.cbo_expanceFilterMonthAndYear.Location = New System.Drawing.Point(190, 42)
        Me.cbo_expanceFilterMonthAndYear.Name = "cbo_expanceFilterMonthAndYear"
        Me.cbo_expanceFilterMonthAndYear.Size = New System.Drawing.Size(227, 31)
        Me.cbo_expanceFilterMonthAndYear.TabIndex = 3
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(190, 3)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(227, 30)
        Me.txt_search.TabIndex = 2
        '
        'frm_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(922, 647)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbo_expanceFilterMonthAndYear As ComboBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_expanceFilter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbl_totalExpance As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Month As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_incomeOverallTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_incomeMonthYear As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
