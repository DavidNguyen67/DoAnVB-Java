Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_income
    Private Sub frm_income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txt_incomeAmount.Text = ""
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If String.IsNullOrWhiteSpace(txt_incomeAmount.Text) Then
            MsgBox("Fill Monthly Income Amount !", vbExclamation)
            txt_incomeAmount.Focus()
            Return
        End If

        Dim incomeAmount As Decimal
        If Not Decimal.TryParse(txt_incomeAmount.Text, incomeAmount) Then
            MsgBox("Invalid Income Amount! Please enter a valid number.", vbExclamation)
            txt_incomeAmount.Clear()
            txt_incomeAmount.Focus()
            Return
        End If

        cmd = New MySqlCommand("SELECT * FROM `tbl_income` WHERE `month` =@month", conn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
        da = New MySqlDataAdapter
        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim amount As Decimal = CDec(dt.Rows(0)("amount"))
            If MsgBox($"{Date.Now.ToString("MMMM-yyyy")} Monthly Income Amount: {amount} {vbNewLine}Are you Sure update new amount: {CDec(txt_incomeAmount.Text)}", vbExclamation + vbYesNo) = vbYes Then
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    cmd = New MySqlCommand("UPDATE `tbl_income` SET `amount` = @amount WHERE `mothYear` = @monthYear", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@amount", CDec(txt_incomeAmount.Text))
                    cmd.Parameters.AddWithValue("@monthYear", Date.Now.ToString("MMMM-yyyy"))
                    i = cmd.ExecuteNonQuery

                    If i > 0 Then
                        MsgBox($"Income Update Successfully ! {vbNewLine} Current Month: {Date.Now.ToString("MMMM-yyyy")}", vbInformation)
                    Else
                        MsgBox("Income Update Failed!", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
            'MsgBox($"Already {Date.Now.ToString("MMMM-yyyy")} Monthly Income Amount Update !", vbExclamation)
        Else
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                cmd = New MySqlCommand("INSERT INTO `tbl_income`(`month`, `mothYear`, `amount`) VALUES (@month, @mothYear, @amount)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
                cmd.Parameters.AddWithValue("@mothYear", Date.Now.ToString("MMMM-yyyy"))
                cmd.Parameters.AddWithValue("@amount", CDec(txt_incomeAmount.Text))
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox($"Income Save Successfully ! {vbNewLine} Current Month: {Date.Now.ToString("MMMM-yyyy")}", vbInformation)
                Else
                    MsgBox("Income Save Failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End If
        txt_incomeAmount.Clear()
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
End Class