Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Employee

    'creating connection
    Dim connect As String = My.Settings.storebillingsystemdbConnectionString

    Dim index As Integer = 0
    'Creating Connection Object
    'Dim objconnection As New MySqlConnection(connect)
    Dim MysqlConn As New MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png|all files|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PicturePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            PicturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        PicturePictureBox.Image = Nothing
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) = 45)) Then
                e.Handled = True
                MsgBox("Only Letters allowed")
            End If
        End If
    End Sub

    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) = 45)) Then
                e.Handled = True
                MsgBox("Only Letters allowed")
            End If
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) = 45)) Then
                e.Handled = True
                MsgBox("Only Letters allowed")
            End If
        End If
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorebillingsystemdbDataSet2.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.employee)
        DateOfBirthDateTimePicker.MaxDate = DateAdd(DateInterval.Year, -18, DateTime.Today)
        DateOfBirthDateTimePicker.MinDate = DateAdd(DateInterval.Year, -60, DateTime.Today)
        PicturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs)
        Dim emailRegex As New  _
            Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If Not (emailRegex.IsMatch(EmailTextBox.Text)) Then
            MsgBox("Emal incorrect")
            EmailTextBox.Focus()
            EmailTextBox.SelectAll()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



        Dim ms As New MemoryStream
        PicturePictureBox.Image.Save(ms, PicturePictureBox.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer
        Dim p As New MySqlParameter("@Picture", MySqlDbType.Blob)
        p.Value = data

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;user id=root;database=storebillingsystemdb"



        Try

            MysqlConn.Open()
            query = "insert into Employee(Username, Password, Role, Firstname, Middlename, Lastname, DateOfBirth, Gender, Email, DateOfEmployment, Position, Picture, Phone, Salary) values(@Username, @Password, @Role, @Firstname, @Middlename, @Lastname, @DateOfBirth, @Gender, @Email, @DateOfEmployment, @Position, @Picture, @Phone, @Salary)"
            command = New MySqlCommand(query, MysqlConn)
            command.Parameters.AddWithValue("@Username", UsernameTextBox.Text)
            command.Parameters.AddWithValue("@Password", PasswordTextBox.Text)
            command.Parameters.AddWithValue("@Role", RoleComboBox.Text)
            command.Parameters.AddWithValue("@Firstname", FirstNameTextBox.Text)
            command.Parameters.AddWithValue("@Middlename", MiddleNameTextBox.Text)
            command.Parameters.AddWithValue("@Lastname", LastNameTextBox.Text)
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirthDateTimePicker.Value)
            command.Parameters.AddWithValue("@Gender", GenderComboBox.Text)
            command.Parameters.AddWithValue("@Email", EmailTextBox.Text)
            command.Parameters.AddWithValue("@DateOfEmployment", DateOfEmploymentDateTimePicker.Value)
            command.Parameters.AddWithValue("@Position", PositionComboBox.Text)
            command.Parameters.Add(p)
            command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text)
            command.Parameters.AddWithValue("@Salary", CDec(SalaryTextBox.Text))

            command.ExecuteNonQuery()
            MsgBox("Data saved successfully")

            Me.EmployeeTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try



        'Try

        '    If objconnection.State = ConnectionState.Closed Then
        '        objconnection.Open()
        '    End If

        '    Dim query As String = "insert into Employee(Username, Password, Role, Firstname, Middlename, Lastname, DateOfBirth, Gender, Email, DateOfEmployment, Position, Picture) values('" & _
        '        txtUsername.Text & "','" & txtPassword.Text & "','" & cmbLoginRole.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & dtDOB.Value & "','" & _
        '        cmbGender.Text & "','" & txtEmail.Text & "','" & dtDOE.Value & "','" & cmbPosition.Text & "')"

        '    Dim cmd = New MySqlCommand(query, objconnection)


        '    If cmd.ExecuteNonQuery() > 0 Then
        '        MessageBox.Show("Save Successful", _
        '               "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If

        '    Me.Validate()
        '    Me.EmployeeBindingSource.EndEdit()
        '    Me.TableAdapterManager.UpdateAll(Me.StorebillingsystemdbDataSet2)


        '    'Me.EmployeeTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.employee)

        '    'EmployeeDataGridView.Refresh()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    objconnection.Dispose()
        'End Try

    End Sub

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorebillingsystemdbDataSet2)

    End Sub

    Private Sub clear()
        FirstNameTextBox.Clear()
        MiddleNameTextBox.Clear()
        LastNameTextBox.Clear()
        EmailTextBox.Clear()
        GenderComboBox.Text = ""
        PositionComboBox.Text = ""
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        RoleComboBox.Text = ""
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        BindingNavigatorAddNewItem.PerformClick()
        clear()
        generateUsername()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim n As String = MessageBox.Show("Are you sure you want to Delete " & UsernameTextBox.Text & "'s record ?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Try
                MysqlConn.Open()

                Dim query As String
                query = "delete from storebillingsystemdb.Employee where Username = '" & UsernameTextBox.Text & "' "
                command = New MySqlCommand(query, MysqlConn)
                reader = command.ExecuteReader

                MessageBox.Show("Data deleted")
                MysqlConn.Close()
                Me.Refresh()
                clear()
                Me.EmployeeTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.employee)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
        
    End Sub

    Private Sub generateUsername()
        ' Dim letters As String = GetChar(FirstNameTextBox.Text, 1) & LastNameTextBox.Text
        Randomize()
        Dim gen As Integer = CInt(Int((1000 * Rnd()) + 1))
        gen.ToString()
        Dim final As String = "EMP" & gen
        '"-" & letters
        UsernameTextBox.Clear()
        UsernameTextBox.Text = final
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim n As String = MessageBox.Show("Are you sure you want to Overwrite " & UsernameTextBox.Text & "'s record?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Dim ms As New MemoryStream
            PicturePictureBox.Image.Save(ms, PicturePictureBox.Image.RawFormat)
            Dim data As Byte() = ms.GetBuffer
            Dim p As New MySqlParameter("@Picture", MySqlDbType.Blob)
            p.Value = data

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;user id=root;database=storebillingsystemdb"

            Try

                MysqlConn.Open()
                query = "UPDATE Employee SET Password = @Password, Role = @Role, Firstname = @Firstname," & _
                    "Middlename = @Middlename, Lastname = @Lastname, DateOfBirth = @DateOfBirth, Gender = @Gender, Email = @Email," & _
                    "Phone = @Phone, DateOfEmployment = @DateOfEmployment, Position = @Position, Picture = @Picture where Username = @Username"
                command = New MySqlCommand(query, MysqlConn)
                command.Parameters.AddWithValue("@Username", UsernameTextBox.Text)
                command.Parameters.AddWithValue("@Password", PasswordTextBox.Text)
                command.Parameters.AddWithValue("@Role", RoleComboBox.Text)
                command.Parameters.AddWithValue("@Firstname", FirstNameTextBox.Text)
                command.Parameters.AddWithValue("@Middlename", MiddleNameTextBox.Text)
                command.Parameters.AddWithValue("@Lastname", LastNameTextBox.Text)
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirthDateTimePicker.Value)
                command.Parameters.AddWithValue("@Gender", GenderComboBox.Text)
                command.Parameters.AddWithValue("@Email", EmailTextBox.Text)
                command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text)
                command.Parameters.AddWithValue("@DateOfEmployment", DateOfEmploymentDateTimePicker.Value)
                command.Parameters.AddWithValue("@Position", PositionComboBox.Text)
                command.Parameters.Add(p)

                command.ExecuteNonQuery()
                MsgBox("Data Updated successfully")

                Me.EmployeeTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.employee)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Close()
            End Try
        End If
    End Sub

    Private Sub btnGenerateUsername_Click(sender As Object, e As EventArgs) Handles btnGenerateUsername.Click
        generateUsername()
    End Sub

    Private Sub btnFirstItem_Click(sender As Object, e As EventArgs) Handles btnFirstItem.Click
        BindingNavigatorMoveFirstItem.PerformClick()
    End Sub

    Private Sub btnPreviousItem_Click(sender As Object, e As EventArgs) Handles btnPreviousItem.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub btnNextItem_Click(sender As Object, e As EventArgs) Handles btnNextItem.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub btnLastItem_Click(sender As Object, e As EventArgs) Handles btnLastItem.Click
        BindingNavigatorMoveLastItem.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
        EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        EmployeeDataGridView.ClearSelection()
        Dim myRow As New DataGridViewRow
        Dim myCell As DataGridViewCell

        For Each myRow In EmployeeDataGridView.Rows
            For Each myCell In myRow.Cells
                If InStr(myCell.Value.ToString, txtSearchUsername.Text) Then
                    myRow.Selected = True
                End If
            Next
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class