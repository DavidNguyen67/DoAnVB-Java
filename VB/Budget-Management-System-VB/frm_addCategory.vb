Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_addCategory
    Private Sub frm_addCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("INSERT INTO `tbl_category`(`category`) VALUES (@category)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@category", txt_categoryName.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Category Save Successfully", vbInformation)
            Else
                MsgBox("New Category Save Failed", vbInformation)
            End If
            txt_categoryName.Clear()
            txt_categoryName.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        frm_expance.cbo_CategoyLoad()
    End Sub
End Class