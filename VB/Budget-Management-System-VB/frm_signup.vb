Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_signup
    Private Sub frm_signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
        dbconn()
    End Sub
    Private Sub btn_signUp_Click(sender As Object, e As EventArgs) Handles btn_signUp.Click
        ' Kiểm tra xem đã nhập đầy đủ thông tin đăng ký chưa
        If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txt_username.Text) Or String.IsNullOrEmpty(txt_password.Text) Then
            MsgBox("Please enter all required information.", vbExclamation)
            Return
        End If

        PerformSignUp()
    End Sub

    ' Hàm kiểm tra đăng ký
    Private Sub PerformSignUp()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New MySqlCommand("SELECT * FROM `tbluser` WHERE userName = @userName", conn)
            cmd.Parameters.AddWithValue("@userName", txt_username.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                MsgBox("Username already exists. Please choose another one.", vbExclamation)
                dr.Close()
            Else
                dr.Close()
                cmd = New MySqlCommand("INSERT INTO `tbluser`(`name`, `userName`, `password`) VALUES (@name, @userName, @password)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@userName", txt_username.Text)
                cmd.Parameters.AddWithValue("@password", txt_password.Text)

                i = cmd.ExecuteNonQuery

                If i > 0 Then
                    ' Đăng ký thành công
                    MsgBox("New User is Added Successfully", vbInformation)
                    txtName.Clear()
                    txt_password.Clear()
                    txt_username.Clear()
                    txtName.Focus()
                Else
                    ' Đăng ký không thành công
                    MsgBox("New User Added Failed", vbExclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you Sure Exit ?.", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        frm_login.Show()
    End Sub
End Class
