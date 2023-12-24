Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_expance
    Private Sub frm_expance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        cbo_CategoyLoad()
    End Sub

    Private Sub btn_category_Click(sender As Object, e As EventArgs) Handles btn_category.Click
        frm_addCategory.ShowDialog()
    End Sub

    Public Sub cbo_CategoyLoad()
        cbo_category.Items.Clear()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT * FROM `tbl_category`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cbo_category.Items.Add(dr.Item("category").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("INSERT INTO `tbl_expance`(`ydate`, `month`, `mothYear`, `category`, `amount`, `remarks`) VALUES (@ydate, @month, @mothYear, @category, @amount, @remarks)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ydate", CDate(dtp_expanceDate.Text))
            cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
            cmd.Parameters.AddWithValue("@mothYear", Date.Now.ToString("MMMM-yyyy"))
            cmd.Parameters.AddWithValue("@category", cbo_category.Text)
            cmd.Parameters.AddWithValue("@amount", CDec(txt_amount.Text))
            cmd.Parameters.AddWithValue("@remarks", txt_remarks.Text)
            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("New Expance Save Successfully !", vbInformation)
                Clear()
            Else
                MsgBox("Expance Save Failed !", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        With frm_main
            .totalInCome()
            .totalExpance()
            .toDayExpance()
            .Balance()
        End With
    End Sub
    Public Sub Clear()
        txt_amount.Clear()
        txt_remarks.Clear()
        dtp_expanceDate.Text = Now
        cbo_category.SelectedIndex = -1
    End Sub
End Class