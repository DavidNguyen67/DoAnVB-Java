<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_expance = New System.Windows.Forms.Button()
        Me.btn_income = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_todayExpance = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_totalExpance = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_totalIncome = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Budget Management System"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_report, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_expance, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_income, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(607, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(645, 100)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(486, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(156, 94)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.Transparent
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report.ForeColor = System.Drawing.Color.White
        Me.btn_report.Location = New System.Drawing.Point(325, 3)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(155, 94)
        Me.btn_report.TabIndex = 3
        Me.btn_report.Text = "Report"
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'btn_expance
        '
        Me.btn_expance.BackColor = System.Drawing.Color.Transparent
        Me.btn_expance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_expance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_expance.FlatAppearance.BorderSize = 0
        Me.btn_expance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btn_expance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_expance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_expance.ForeColor = System.Drawing.Color.White
        Me.btn_expance.Location = New System.Drawing.Point(164, 3)
        Me.btn_expance.Name = "btn_expance"
        Me.btn_expance.Size = New System.Drawing.Size(155, 94)
        Me.btn_expance.TabIndex = 2
        Me.btn_expance.Text = "Expance"
        Me.btn_expance.UseVisualStyleBackColor = False
        '
        'btn_income
        '
        Me.btn_income.BackColor = System.Drawing.Color.Transparent
        Me.btn_income.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_income.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_income.FlatAppearance.BorderSize = 0
        Me.btn_income.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_income.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_income.ForeColor = System.Drawing.Color.White
        Me.btn_income.Location = New System.Drawing.Point(3, 3)
        Me.btn_income.Name = "btn_income"
        Me.btn_income.Size = New System.Drawing.Size(155, 94)
        Me.btn_income.TabIndex = 1
        Me.btn_income.Text = "Income"
        Me.btn_income.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.lbl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 485)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1252, 78)
        Me.Panel2.TabIndex = 1
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Black
        Me.lbl.Location = New System.Drawing.Point(12, 26)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(277, 28)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "Budget Management System"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_balance)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.ShapeContainer3)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(981, 150)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(259, 163)
        Me.Panel5.TabIndex = 5
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_balance.Location = New System.Drawing.Point(5, 112)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(33, 38)
        Me.lbl_balance.TabIndex = 2
        Me.lbl_balance.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Income"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 28)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Blance Amount"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(259, 163)
        Me.ShapeContainer3.TabIndex = 3
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape2"
        Me.LineShape3.X1 = 6
        Me.LineShape3.X2 = 241
        Me.LineShape3.Y1 = 100
        Me.LineShape3.Y2 = 100
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel3.Controls.Add(Me.lbl_todayExpance)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.ShapeContainer1)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(658, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 163)
        Me.Panel3.TabIndex = 6
        '
        'lbl_todayExpance
        '
        Me.lbl_todayExpance.AutoSize = True
        Me.lbl_todayExpance.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_todayExpance.Location = New System.Drawing.Point(3, 112)
        Me.lbl_todayExpance.Name = "lbl_todayExpance"
        Me.lbl_todayExpance.Size = New System.Drawing.Size(33, 38)
        Me.lbl_todayExpance.TabIndex = 2
        Me.lbl_todayExpance.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Income"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Today expance"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(259, 163)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape2"
        Me.LineShape1.X1 = 6
        Me.LineShape1.X2 = 241
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbl_totalExpance)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.ShapeContainer2)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(327, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 163)
        Me.Panel4.TabIndex = 7
        '
        'lbl_totalExpance
        '
        Me.lbl_totalExpance.AutoSize = True
        Me.lbl_totalExpance.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalExpance.Location = New System.Drawing.Point(5, 112)
        Me.lbl_totalExpance.Name = "lbl_totalExpance"
        Me.lbl_totalExpance.Size = New System.Drawing.Size(33, 38)
        Me.lbl_totalExpance.TabIndex = 2
        Me.lbl_totalExpance.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Income"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Expance"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(259, 163)
        Me.ShapeContainer2.TabIndex = 3
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 6
        Me.LineShape2.X2 = 241
        Me.LineShape2.Y1 = 100
        Me.LineShape2.Y2 = 100
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lbl_totalIncome)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.ShapeContainer4)
        Me.Panel6.ForeColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(12, 150)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(259, 163)
        Me.Panel6.TabIndex = 6
        '
        'lbl_totalIncome
        '
        Me.lbl_totalIncome.AutoSize = True
        Me.lbl_totalIncome.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalIncome.Location = New System.Drawing.Point(5, 112)
        Me.lbl_totalIncome.Name = "lbl_totalIncome"
        Me.lbl_totalIncome.Size = New System.Drawing.Size(33, 38)
        Me.lbl_totalIncome.TabIndex = 2
        Me.lbl_totalIncome.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Income"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 28)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Total Income"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer4.Size = New System.Drawing.Size(259, 163)
        Me.ShapeContainer4.TabIndex = 3
        Me.ShapeContainer4.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape2"
        Me.LineShape4.X1 = 6
        Me.LineShape4.X2 = 241
        Me.LineShape4.Y1 = 100
        Me.LineShape4.Y2 = 100
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 54)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(15, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 50)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label5"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1252, 563)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_expance As Button
    Friend WithEvents btn_income As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_balance As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_todayExpance As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_totalExpance As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_totalIncome As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer2 As Timer
End Class
