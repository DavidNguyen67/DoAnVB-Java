Imports System.IO
Imports System.Web.UI.Design.WebControls
Imports MySql.Data.MySqlClient

Public Class frm_login
    Dim name As String
    Dim userName As String
    Dim password As String
    Dim role As String

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you Sure Exit ?.", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT `name`, `userName`, `password`, `role` FROM `tbluser` WHERE userName = @userName and password = @password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@userName", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)

            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                found = True
                name = dr.Item("name").ToString
                userName = dr.Item("userName").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString
            Else
                found = False
                name = ""
                userName = ""
                password = ""
                role = ""
            End If
            dr.Close()
            conn.Close()

            If found = True Then
                If StrComp(txt_username.Text, userName, CompareMethod.Binary) Or StrComp(txt_password.Text, password, CompareMethod.Binary) Then
                    MsgBox("Wrong usernName or password", vbExclamation)
                Else
                    txt_password.Clear()
                    txt_username.Clear()
                    'If UCase(role) = "ADMIN" Then
                    Me.Hide()
                    frm_main.Show()
                    frm_main.lbl.Text = $"Login User: {name} {vbNewLine}Time: {Date.Now.ToString("hh:mm:ss tt")}"
                    'End If
                End If
            Else
                MsgBox("Wrong usernName or password", vbExclamation)
            End If
            txt_password.Clear()
            txt_username.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frm_signup.Show()
        Me.Hide()
    End Sub
End Class
