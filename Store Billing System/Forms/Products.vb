Imports MySql.Data.MySqlClient
Public Class Products

    'creating connection
    Dim connect As String = My.Settings.storebillingsystemdbConnectionString

    'Creating Connection Object
    Dim objconnection, con As New MySqlConnection(connect)

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorebillingsystemdbDataSet2)

    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.GotFocus
        'TODO: This line of code loads data into the 'StorebillingsystemdbDataSet2.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.product)
        Dim reader As MySqlDataReader

        Try
            objconnection.Open()

            Dim query As String
            query = "select * from  storebillingsystemdb.category  "
            Dim cmd = New MySqlCommand(query, objconnection)
            reader = cmd.ExecuteReader

            While reader.Read
                Dim sid = reader.GetString("categoryname")
                CategoryComboBox.Items.Add(sid)

            End While
            reader.Close()
            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query2 As String = "insert into Product(ProductID, CategoryName, ProductName, ProfitMargin, Description, SellPrice, CostPrice)" & _
                    "values(@ProductID, @CategoryName, @ProductName, @ProfitMargin, @Description, @SellPrice, @CostPrice)"
            Dim command2 As New MySqlCommand(query2, con)
            command2.Parameters.AddWithValue("@ProductID", ProductIDTextBox.Text)
            command2.Parameters.AddWithValue("@CategoryName", CategoryComboBox.Text)
            command2.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text)
            command2.Parameters.AddWithValue("@ProfitMargin", ProfitMarginTextBox.Text)
            command2.Parameters.AddWithValue("@Description", DescriptionTextBox.Text)
            command2.Parameters.AddWithValue("@SellPrice", SellPriceTextBox.Text)
            command2.Parameters.AddWithValue("@CostPrice", CostPriceTextBox.Text)

            If command2.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Save Successful", _
                       "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.ProductTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.product)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim n As String = MessageBox.Show("Are you sure you want to Delete " & ProductNameTextBox.Text & "'s record ?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Try
                objconnection.Open()

                Dim query As String
                query = "delete from Product where ProductID = '" & ProductIDTextBox.Text & "' "
                cmd = New MySqlCommand(query, objconnection)
                reader = cmd.ExecuteReader

                MessageBox.Show("Data deleted")
                objconnection.Close()
                Me.Refresh()
                clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Dispose()
            End Try
        End If
    End Sub

    Private Sub clear()
        ProductIDTextBox.Clear()
        CategoryComboBox.Text = ""
        ProductNameTextBox.Clear()
        ProfitMarginTextBox.Clear()
        DescriptionTextBox.Clear()
        SellPriceTextBox.Text = ""
        CostPriceTextBox.Clear()
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
        'Dim reader As MySqlDataReader
        'Dim cmd As MySqlCommand
        Try
            ProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ProductDataGridView.ClearSelection()

            For Each myRow As DataGridViewRow In ProductDataGridView.Rows
                For Each myCell As DataGridViewCell In myRow.Cells
                    If InStr(myCell.Value.ToString, txtSearch.Text) Then
                        myRow.Selected = True
                    End If
                Next
            Next
        Catch ex As Exception
      
        End Try
    End Sub

    Sub generateID()
        Dim Num As Integer
        Dim Words As String

        Randomize()
        Num = CInt(Int((1000 * Rnd()) + 1))
        Num.ToString()
        Words = String.Concat("PRO", Num)
        ProductIDTextBox.Text = Words
    End Sub

    Private Sub ProductIDTextBox_GotFocus(sender As Object, e As EventArgs) Handles ProductIDTextBox.MouseClick
        generateID()
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        AddCategory.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim n As String = MessageBox.Show("Are you sure you want to Overwrite " & ProductNameTextBox.Text & "'s record?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            Try
                Dim query1 As String = "UPDATE product SET CategoryName = @CategoryName, ProductName = @ProductName," & _
                        "ProfitMargin = @ProfitMargin, Description = @Description, SellPrice = @SellPrice, CostPrice = @CostPrice WHERE ProductID = @ProductID"
                Dim command1 As New MySqlCommand(query1, objconnection)

                command1.Parameters.AddWithValue("@ProductID", ProductIDTextBox.Text)
                command1.Parameters.AddWithValue("@CategoryName", CategoryComboBox.Text)
                command1.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text)
                command1.Parameters.AddWithValue("@ProfitMargin", ProfitMarginTextBox.Text)
                command1.Parameters.AddWithValue("@Description", DescriptionTextBox.Text)
                command1.Parameters.AddWithValue("@SellPrice", SellPriceTextBox.Text)
                command1.Parameters.AddWithValue("@CostPrice", CostPriceTextBox.Text)
                command1.ExecuteNonQuery()
                If command1.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Overwrite Successful", _
                           "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Me.ProductTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.product)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Close()
            End Try
        End If
    End Sub

    Private Sub ProfitMarginTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfitMarginTextBox.Click
        Dim sell, cost, profit As Decimal
        sell = SellPriceTextBox.Text
        cost = CostPriceTextBox.Text
        profit = (((sell - cost) / cost)) * 100
        ProfitMarginTextBox.Text = profit
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        BindingNavigator1.BindingSource = ProductBindingSource
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

    Private Sub txtSearch_KeyPress(sender As Object, e As EventArgs) Handles txtSearch.KeyPress, btnSearch.Click
        Try
            ProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ProductDataGridView.ClearSelection()
            Dim myRow As New DataGridViewRow
            Dim myCell As DataGridViewCell

            For Each myRow In ProductDataGridView.Rows
                For Each myCell In myRow.Cells
                    If InStr(myCell.Value.ToString, txtSearch.Text) Then
                        myRow.Selected = True
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class