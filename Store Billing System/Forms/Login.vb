Imports MySql.Data.MySqlClient
Imports System

Public Class Login


    'creating connection
    Dim connect As String = My.Settings.storebillingsystemdbConnectionString

    'Creating Connection Object
    Dim objconnection As New MySqlConnection(connect)

    'command
    Dim cmd As New MySqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim reader As MySqlDataReader
        Try
            objconnection.Open()

            Dim query As String
            query = "select * from  Employee where Username ='" & txtUsername.Text & "' and Password ='" & txtPassword.Text & "' "
            cmd = New MySqlCommand(query, objconnection)

            'Cheking if the connection was open or not
            If objconnection.State = ConnectionState.Closed Then objconnection.Open()

            'reading data from database table to check if the query is true or false
            reader = cmd.ExecuteReader


            'if the user exist

            If reader.Read = True Then
                'declaring variables to store data from the database
                Dim role As String = reader("Role")
                Dim username As String = reader("Username")
                Dim img() As Byte = reader("Picture")
                'img = reader("Picture")
                

                'if the user is a general employee then some of the buttons will be disabled
                If role = "Employee" Then
                    'disabling some buttons on the home form
                    MainMDIform.btnEmployees.Visible = False

                    MainMDIform.ToolStripSeparator4.Visible = False
                    MainMDIform.ToolStripSeparator5.Visible = False
                    MainMDIform.TabControl.TabPages.RemoveAt(2)
                    'MDIform.btnReports.Enabled = False
                    'MDIform.btnSystemManagement.Enabled = False
                    Me.Hide()
                    MainMDIform.Show()

                ElseIf role = "Administrator" Then
                    'disabling some buttons on the home form
                    MainMDIform.btnEmployees.Enabled = True
                    'MDIform.btnReports.Enabled = True
                    'MDIform.btnSystemManagement.Enabled = True
                    Me.Hide()
                    MainMDIform.Show()
                End If
                Dashboard.lblUsername.Text = username
                Dashboard.lblRole.Text = role

                Dim ms As New IO.MemoryStream(img)
                Dashboard.DashboardPictureBox.Image = Image.FromStream(ms)
                'Dashboard.DashboardPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MsgBox("Invalid Login Details", MsgBoxStyle.Information)
                txtUsername.Focus()
            End If

            reader.Close()
            cmd.Dispose()
            If objconnection.State = ConnectionState.Open Then objconnection.Close()


            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
        'clearing user data
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

End Class
