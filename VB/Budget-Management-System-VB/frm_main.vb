Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_main
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        totalInCome()
        totalExpance()
        toDayExpance()
        Balance()
        Label3.Text = Date.Now.ToString("dddd")
        Label6.Text = Date.Now.ToString("MMMM-yyyy")
        Label12.Text = Date.Now.ToString("MMMM-yyyy")
        Label9.Text = Date.Now.ToString("MMMM-yyyy")
    End Sub
    Private Sub btn_income_Click(sender As Object, e As EventArgs) Handles btn_income.Click
        frm_income.ShowDialog()
    End Sub

    Private Sub btn_expance_Click(sender As Object, e As EventArgs) Handles btn_expance.Click
        frm_expance.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        frm_report.Show()
        Me.Close()
    End Sub
    Public Sub totalInCome()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT SUM(amount) FROM `tbl_income` WHERE `month` = @month", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
            lbl_totalIncome.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Public Sub totalExpance()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT SUM(amount) FROM `tbl_expance` WHERE `month` = @month", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
            lbl_totalExpance.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Public Sub toDayExpance()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT SUM(amount) FROM `tbl_expance` WHERE `ydate` = @ydate", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ydate", Date.Now.ToString("yyyy/MM/dd"))
            lbl_todayExpance.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Public Sub Balance()
        Try
            lbl_balance.Text = CDec(lbl_totalIncome.Text) - CDec(lbl_totalExpance.Text)
        Catch ex As Exception
            MsgBox("This month Income Amount Not Update !", vbExclamation)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Balance()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = Date.Now.ToString("hh:mm:ss tt")
        Label5.Text = Date.Now.ToString("dddd dd-MM-yyyy")
    End Sub
End Class