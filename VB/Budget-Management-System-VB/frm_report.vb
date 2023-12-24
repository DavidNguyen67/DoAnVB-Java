Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_report
    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        DataGridView2.RowTemplate.Height = 30

        ExpanceLoad()
        Expance_load_monthYear()
        'Expance_overall_total()
        Income_load()
        Cbo_Income_monthYear_load()
        Income_overall_total()
    End Sub
    Public Sub ExpanceLoad()
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT `ydate`, `month`, `mothYear`, `category`, `amount`, `remarks` FROM `tbl_expance`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ydate"), dr.Item("month").ToString, dr.Item("mothYear").ToString, dr.Item("category").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Expance_overall_total()
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim selectedMonthYear As String = cbo_expanceFilterMonthAndYear.Text

            ' Nếu có lựa chọn tháng và năm
            If Not String.IsNullOrEmpty(selectedMonthYear) AndAlso selectedMonthYear <> "All" Then
                cmd = New MySqlCommand("SELECT `ydate`, `month`, `mothYear`, `category`, `amount`, `remarks` FROM `tbl_expance` WHERE `mothYear` = @selectedMonthYear AND category like '%" & txt_search.Text & "%' AND ydate BETWEEN '" & date1 & "'AND '" & date2 & "'", conn)
                cmd.Parameters.AddWithValue("@selectedMonthYear", selectedMonthYear)
            Else
                ' Nếu không có lựa chọn tháng và năm, hiển thị tất cả
                cmd = New MySqlCommand("SELECT `ydate`, `month`, `mothYear`, `category`, `amount`, `remarks` FROM `tbl_expance` WHERE category like '%" & txt_search.Text & "%' AND ydate BETWEEN '" & date1 & "'AND '" & date2 & "'", conn)
            End If
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ydate"), dr.Item("month").ToString, dr.Item("mothYear").ToString, dr.Item("category").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Expance_overall_total()
    End Sub
    Public Sub Expance_load_monthYear()
        cbo_expanceFilterMonthAndYear.Items.Clear()
        cbo_expanceFilterMonthAndYear.Items.Add("All")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'the video is cmd = New MySqlCommand("SELECT * FROM `tbl_expance` group by mothYear", conn)
            cmd = New MySqlCommand("SELECT * FROM `tbl_expance` group by `mothYear`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cbo_expanceFilterMonthAndYear.Items.Add(dr.Item("mothYear").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Expance_overall_total()
    End Sub
    Private Sub btn_expanceFilter_Click(sender As Object, e As EventArgs) Handles btn_expanceFilter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT `ydate`, `month`, `mothYear`, `category`, `amount`, `remarks` FROM `tbl_expance` WHERE ydate BETWEEN '" & date1 & "'AND '" & date2 & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ydate"), dr.Item("month").ToString, dr.Item("mothYear").ToString, dr.Item("category").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Expance_overall_total()
    End Sub
    Sub Expance_overall_total()
        Dim sum As Double = 0

        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step 1
            sum += DataGridView1.Rows(i).Cells(5).Value
        Next
        lbl_totalExpance.Text = Format(sum, "#,##0.00")
    End Sub
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        cbo_incomeMonthYear.Items.Clear()
        Me.Hide()
        frm_main.Show()
    End Sub
    Public Sub Income_load()
        DataGridView2.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT `month`, `mothYear`, `amount` FROM `tbl_income`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, dr.Item("month").ToString, dr.Item("mothYear").ToString, dr.Item("amount").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Income_overall_total()
    End Sub
    Public Sub Cbo_Income_monthYear_load()
        cbo_incomeMonthYear.Items.Clear()
        cbo_incomeMonthYear.Items.Add("All")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT `month`, `mothYear`, `amount` FROM `tbl_income` group by `mothYear`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cbo_incomeMonthYear.Items.Add(dr.Item("mothYear").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Income_overall_total()
    End Sub
    Private Sub cbo_incomeMonthYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_incomeMonthYear.SelectedIndexChanged
        DataGridView2.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim selectedMonthYear As String = cbo_incomeMonthYear.Text
            If Not String.IsNullOrEmpty(selectedMonthYear) AndAlso selectedMonthYear <> "All" Then
                cmd = New MySqlCommand("SELECT `month`, `mothYear`, `amount` FROM `tbl_income` WHERE `mothYear` = @selectedMonthYear COLLATE utf8mb4_unicode_ci;", conn)
                cmd.Parameters.AddWithValue("@selectedMonthYear", selectedMonthYear)
            Else
                cmd = New MySqlCommand("SELECT `month`, `mothYear`, `amount` FROM `tbl_income`", conn)
            End If
            dr = cmd.ExecuteReader

            While dr.Read()
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, dr.Item("month").ToString, dr.Item("mothYear").ToString, dr.Item("amount").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Income_overall_total()
    End Sub

    Sub Income_overall_total()
        Dim sum As Double = 0

        For i As Integer = 0 To DataGridView2.Rows.Count() - 1 Step 1
            sum += DataGridView2.Rows(i).Cells(3).Value
        Next
        lbl_incomeOverallTotal.Text = Format(sum, "#,##0.00")
    End Sub

    Private Sub cbo_expanceFilterMonthAndYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_expanceFilterMonthAndYear.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim selectedMonthYear As String = cbo_expanceFilterMonthAndYear.Text

            ' Nếu có lựa chọn tháng và năm
            If Not String.IsNullOrEmpty(selectedMonthYear) AndAlso selectedMonthYear <> "All" Then
                cmd = New MySqlCommand("SELECT `ydate`, `month`, `mothYear`, `category`, `amount`, `remarks` FROM `tbl_expance` WHERE `mothYear` = @selectedMonthYear", conn)
                cmd.Parameters.AddWithValue("@selectedMonthYear", selectedMonthYear)
            Else
                ' Nếu không có lựa chọn tháng và năm, hiển thị tất cả
                cmd = New MySqlCommand("SELECT `ydate`, `month`, `mothYear`, `category`, `amount`, `remarks` FROM `tbl_expance`", conn)
            End If

            dr = cmd.ExecuteReader

            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ydate"), dr.Item("month").ToString, dr.Item("mothYear").ToString, dr.Item("category").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Expance_overall_total()
    End Sub

End Class