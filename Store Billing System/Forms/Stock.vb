Imports MySql.Data.MySqlClient
Public Class Stock

    'creating connection
    Dim connect As String = My.Settings.storebillingsystemdbConnectionString

    'Creating Connection Object
    Dim objconnection As New MySqlConnection(connect)
    Private Sub StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorebillingsystemdbDataSet2)

    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorebillingsystemdbDataSet2.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.stock)

        Dim reader As MySqlDataReader

        Try
            objconnection.Open()

            Dim query As String
            query = "select * from  storebillingsystemdb.product  "
            Dim cmd = New MySqlCommand(query, objconnection)
            reader = cmd.ExecuteReader

            While reader.Read
                Dim sid = reader.GetString("productID")
                ProductIDComboBox.Items.Add(sid)

            End While

            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            Dim query As String = "insert into Stock(StockID, DateAdded, ProductID, CostPrice, Quantity, ManDate, ExpDate) values(@StockID, @DateAdded, @ProductID, @CostPrice, @Quantity, @ManDate, @ExpDate)"
            Dim cmd = New MySqlCommand(query, objconnection)
            cmd.Parameters.AddWithValue("@StockID", StockIDTextBox.Text)
            cmd.Parameters.AddWithValue("@DateAdded", DateAddedDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@ProductID", ProductIDComboBox.SelectedItem)
            cmd.Parameters.AddWithValue("@CostPrice", CostPriceTextBox.Text)
            cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
            cmd.Parameters.AddWithValue("@ManDate", ManDateDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@ExpDate", ExpDateDateTimePicker.Value)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Save Successful", _
                       "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.StockTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.stock)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim n As String = MessageBox.Show("Are you sure you want to Delete " & StockIDTextBox.Text & "'s record?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Dim reader As MySqlDataReader
            Dim cmd As MySqlCommand
            Try
                objconnection.Open()

                Dim query As String
                query = "delete from Stock where StockID = '" & StockIDTextBox.Text & "' "
                cmd = New MySqlCommand(query, objconnection)
                reader = cmd.ExecuteReader

                MessageBox.Show("Data deleted")
                objconnection.Close()
                Me.StockTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.stock)
                clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Dispose()
            End Try
        End If
    End Sub

    Private Sub clear()
        StockIDTextBox.Clear()
        ProductIDComboBox.Text = ""
        CostPriceTextBox.Clear()
        QuantityTextBox.Text = ""
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        BindingNavigatorAddNewItem.PerformClick()
        generateID()
    End Sub
    Private Sub generateID()
        Dim Num As Integer
        Dim Words As String

        Randomize()
        Num = (Rnd() * 1000000) + 1
        Num.ToString()
        Words = String.Concat("STK", Num)
        StockIDTextBox.Text = Words
    End Sub

    Private Sub ProductIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductIDComboBox.SelectedIndexChanged
        Dim reader As MySqlDataReader
        Try
            objconnection.Open()

            Dim query As String
            query = "select * from product where ProductName ='" & ProductIDComboBox.Text & "'  "
            Dim cmd = New MySqlCommand(query, objconnection)
            reader = cmd.ExecuteReader

            Dim price As Decimal
            While reader.Read
                price = reader.GetDecimal("CostPrice")
            End While

            CostPriceTextBox.Text = price.ToString

            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim n As String = MessageBox.Show("Are you sure you want to Overwrite " & StockIDTextBox.Text & "'s record?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Try

                objconnection.Open()
                Dim query As String = "update Stock set DateAdded = @DateAdded, ProductID = @ProductID, CostPrice = @CostPrice, Quantity = @Quantity, ManDate = @ManDate, ExpDate = @ExpDate where StockID = @StockID"
                Dim Command = New MySqlCommand(query, objconnection)
                Command.Parameters.AddWithValue("@StockID", StockIDTextBox.Text)
                Command.Parameters.AddWithValue("@DateAdded", DateAddedDateTimePicker.Value)
                Command.Parameters.AddWithValue("@ProductID", ProductIDComboBox.SelectedItem)
                Command.Parameters.AddWithValue("@CostPrice", CostPriceTextBox.Text)
                Command.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
                Command.Parameters.AddWithValue("@ManDate", ManDateDateTimePicker.Value)
                Command.Parameters.AddWithValue("@ExpDate", ExpDateDateTimePicker.Value)

                Command.ExecuteNonQuery()
                MsgBox("Data Updated successfully")

                Me.StockTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.stock)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Close()
            End Try
        End If
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
End Class