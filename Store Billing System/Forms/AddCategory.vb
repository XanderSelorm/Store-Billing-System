Imports MySql.Data.MySqlClient
Public Class AddCategory

    'creating connection
    Dim connect As String = My.Settings.storebillingsystemdbConnectionString

    'Creating Connection Object
    Dim objconnection As New MySqlConnection(connect)
    Private Sub CategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorebillingsystemdbDataSet)

    End Sub

    Private Sub AddCategory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Products.CategoryComboBox.Update()
    End Sub

    Private Sub AddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorebillingsystemdbDataSet.category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.StorebillingsystemdbDataSet.category)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            Dim query As String = "insert into Category(CategoryName, Description) values(@CategoryName, @Description)"
            Dim command = New MySqlCommand(query, objconnection)

            command.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text)
            command.Parameters.AddWithValue("@Description", DescriptionTextBox.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Save Successful", _
                       "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.CategoryTableAdapter.Fill(Me.StorebillingsystemdbDataSet.category)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim n As String = MessageBox.Show("Are you sure you want to Delete " & CategoryNameTextBox.Text & "'s record?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Dim reader As MySqlDataReader
            Try

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                Dim query As String = "delete from Category where CategoryName = @CategoryName "
                Dim command = New MySqlCommand(query, objconnection)
                command.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text)
                command.Parameters.AddWithValue("@Description", DescriptionTextBox.Text)

                reader = command.ExecuteReader()

                MessageBox.Show("Data Deleted", _
                           "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                Me.CategoryTableAdapter.Fill(Me.StorebillingsystemdbDataSet.category)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Dispose()
            End Try
        End If
    End Sub
    Sub clear()
        CategoryNameTextBox.Clear()
        DescriptionTextBox.Clear()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs)
        clear()
        CategoryNameTextBox.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim n As String = MessageBox.Show("Are you sure you want to Overwrite " & CategoryNameTextBox.Text & "'s record?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Try

                objconnection.Open()
                Dim query As String = "update category set CategoryName = @CategoryName, Description = @Description where CategoryName = @CategoryName )"
                Dim Command = New MySqlCommand(query, objconnection)
                Command.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text)
                Command.Parameters.AddWithValue("@Description", DescriptionTextBox.Text)

                Command.ExecuteNonQuery()
                MsgBox("Data Updated successfully")

                Me.CategoryTableAdapter.Fill(Me.StorebillingsystemdbDataSet.category)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Close()
            End Try
        End If
    End Sub
End Class