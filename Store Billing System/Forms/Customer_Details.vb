Imports MySql.Data.MySqlClient
Public Class Customer_Details

    'creating connection
    Dim connect As String = My.Settings.storebillingsystemdbConnectionString

    'Creating Connection Object
    Dim objconnection As New MySqlConnection(connect)
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorebillingsystemdbDataSet2)

    End Sub

    Private Sub Customer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorebillingsystemdbDataSet2.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.customer)
        
        
    End Sub

    Private Sub generateID()
        Dim Num As Integer
        Dim Words As String

        Randomize()
        Num = CInt(Int((1000 * Rnd()) + 1))
        Num.ToString()
        Words = String.Concat("CUST", Num)
        CustomerIDTextBox.Clear()
        CustomerIDTextBox.Text = Words.ToString
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            Dim query As String = "insert into Customer(CustomerID, FirstName, LastName, Email, Gender, Phone) values(@CustomerID, @FirstName, @LastName, @Email, @Gender, @Phone)"

            Dim Command = New MySqlCommand(query, objconnection)
            Command.Parameters.AddWithValue("@CustomerID", CustomerIDTextBox.Text)
            Command.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text)
            Command.Parameters.AddWithValue("@LastName", LastNameTextBox.Text)
            Command.Parameters.AddWithValue("@Email", EmailTextBox.Text)
            Command.Parameters.AddWithValue("@Gender", GenderComboBox.Text)
            Command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text)


            If Command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Save Successful", _
                       "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.CustomerTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.customer)
            Dashboard.totalCustomersLabel()

            'CustomerDataGridView.DataSource = StorebillingsystemdbDataSet2.customer

            'CustomerTableAdapter.Fill(StorebillingsystemdbDataSet2.customer)
            ' CustomerBindingSource.DataSource = StorebillingsystemdbDataSet2
            ' CustomerDataGridView.DataSource = CustomerBindingSource
            'CustomerTableAdapter.Update(StorebillingsystemdbDataSet2.customer)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim n As String = MessageBox.Show("Are you sure you want to Delete " & CustomerIDTextBox.Text & "'s record?", _
   "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Dim reader As MySqlDataReader
            Dim cmd As MySqlCommand
            Try
                objconnection.Open()

                Dim query As String
                query = "delete from Customer where CustomerID = '" & CustomerIDTextBox.Text & "' "
                cmd = New MySqlCommand(query, objconnection)
                reader = cmd.ExecuteReader

                MessageBox.Show("Data deleted")
                objconnection.Close()
                clear()
                Me.CustomerTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.customer)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Dispose()
            End Try
        End If
    End Sub

    Private Sub clear()
        CustomerIDTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        EmailTextBox.Clear()
        GenderComboBox.Text = "--Select--"
        PhoneTextBox.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim n As String = MessageBox.Show("Are you sure you want to Overwrite " & CustomerIDTextBox.Text & "'s record?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Try

                objconnection.Open()
                Dim query As String = "update Customer set FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Email = @Email, Phone = @Phone where CustomerID = @CustomerID"
                Dim Command = New MySqlCommand(query, objconnection)
                Command.Parameters.AddWithValue("@CustomerID", CustomerIDTextBox.Text)
                Command.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text)
                Command.Parameters.AddWithValue("@LastName", LastNameTextBox.Text)
                Command.Parameters.AddWithValue("@Email", EmailTextBox.Text)
                Command.Parameters.AddWithValue("@Gender", GenderComboBox.Text)
                Command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text)

                Command.ExecuteNonQuery()
                MsgBox("Data Updated successfully")

                Me.CustomerTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.customer)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Close()
            End Try
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Try
            BindingNavigatorAddNewItem.PerformClick()
            generateID()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            CustomerDataGridView.ClearSelection()

            For Each myRow As DataGridViewRow In CustomerDataGridView.Rows
                For Each myCell As DataGridViewCell In myRow.Cells
                    If InStr(myCell.Value.ToString, txtSearch.Text) Then
                        myRow.Selected = True
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreviousItem_Click(sender As Object, e As EventArgs) Handles btnPreviousItem.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub btnNextItem_Click(sender As Object, e As EventArgs) Handles btnNextItem.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub btnFirstItem_Click(sender As Object, e As EventArgs) Handles btnFirstItem.Click
        BindingNavigatorMoveFirstItem.PerformClick()
    End Sub

    Private Sub btnLastItem_Click(sender As Object, e As EventArgs) Handles btnLastItem.Click
        BindingNavigatorMoveLastItem.PerformClick()
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        BindingNavigator1.BindingSource = CustomerBindingSource
    End Sub
End Class