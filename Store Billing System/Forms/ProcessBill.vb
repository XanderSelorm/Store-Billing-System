Imports MySql.Data.MySqlClient
Public Class ProcessBill

    'creating connection
    Dim connect As String = My.Settings.storebillingsystemdbConnectionString

    'Creating Connection Object
    Dim objconnection As New MySqlConnection(connect)

    Private Sub ProcessBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'With dgvSalesOrder
        '    .Columns.Add("ProductID", "ProductID")
        '    .Columns.Add("ProductName", "Product Name")
        '    .Columns.Add("SellPrice", "Sell Price")
        '    .Columns.Add("Quantity", "Quantity")
        '    .Columns.Add("Total", "Total")
        'End With



        Dim reader As MySqlDataReader

        Try
            objconnection.Open()
            'FILL PRODUCTS COMBOBOX'''
            Dim query1 As String
            query1 = "select * from  storebillingsystemdb.product  "
            Dim cmd = New MySqlCommand(query1, objconnection)
            reader = cmd.ExecuteReader

            While reader.Read
                Dim sid = reader.GetString("Productname")
                cmbProduct.Items.Add(sid)

            End While
            

            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try

        Try
            objconnection.Open()
            'FILL CustomerID COMBOBOX'''
            Dim query2 As String
            query2 = "select * from  storebillingsystemdb.customer  "
            Dim cmd = New MySqlCommand(query2, objconnection)
            reader = cmd.ExecuteReader

            While reader.Read
                Dim sid = reader.GetString("CustomerID")
                cmbCustomerID.Items.Add(sid)

            End While


            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
        txtBillID.Clear()
        cmbCustomerID.Text = "Select"
        txtcustomerName.clear()
        txtQuantity.Clear()
        txtAmountPaid.Clear()
        'dgvSalesOrder.Rows.Clear() SalesorderDataGridView.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub


    ''NOT FINISHED WITH THIS CODE. AM KINDDA CONFUSED
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            Dim query As String = "insert into SalesOrder(SalesOrderID, ProductName, SellPrice, Quantity) values('" & txtSalesOrderID.Text & "','" & cmbProduct.Text & "','" & txtPrice.Text & "','" & txtQuantity.Text & "')"

            Dim cmd = New MySqlCommand(query, objconnection)

            

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Product Added", _
                       "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim query1 As String = "update salesorder set total=quantity*sellprice"
            Dim cmd1 = New MySqlCommand(query1, objconnection)
            cmd1.ExecuteScalar()

            Me.SalesorderTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.salesorder)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub txtChange_TextChanged(sender As Object, e As EventArgs) Handles txtChange.TextChanged
        txtChange.Text = (Convert.ToInt64(txtAmountPaid.Text) - Convert.ToInt64(txtGrandTotal.Text))
    End Sub


    Private Sub SalesorderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesorderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorebillingsystemdbDataSet2)

    End Sub

    Private Sub btnGenerateBillID_Click(sender As Object, e As EventArgs) Handles btnGenerateBillID.Click

        Randomize()
        Dim gen As Integer = CInt(Int((1000 * Rnd()) + 1))
        gen.ToString()
        Dim final As String = "BILL" & gen
        txtBillID.Clear()
        txtBillID.Text = final
    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        BindingNavigatorDeleteItem.PerformClick()

        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim n As String = MessageBox.Show("Are you sure you want to the selected product?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Try
                objconnection.Open()

                Dim query As String
                query = "delete from SalesOrder where ProductName = '" & cmbProduct.Text & "' "
                cmd = New MySqlCommand(query, objconnection)
                reader = cmd.ExecuteReader

                MessageBox.Show("Data deleted")
                objconnection.Close()
                Me.Refresh()
                Me.SalesorderTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.salesorder)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                objconnection.Dispose()
            End Try
        End If
    End Sub

    Private Sub cmbCustomerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomerID.SelectedIndexChanged
        Dim reader As MySqlDataReader
        Try
            objconnection.Open()

            Dim query As String
            query = "select * from customer where CustomerID ='" & cmbCustomerID.Text & "'  "
            Dim cmd = New MySqlCommand(query, objconnection)
            reader = cmd.ExecuteReader

            Dim firstname, lastname As String
            While reader.Read
                firstname = reader.GetString("Firstname")
                lastname = reader.GetString("Lastname")
                txtCustomerName.Text = "" & firstname & " " & lastname & ""
            End While



            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        Dim reader As MySqlDataReader
        Try
            objconnection.Open()

            Dim query As String
            query = "select * from product where ProductName ='" & cmbProduct.Text & "'  "
            Dim cmd = New MySqlCommand(query, objconnection)
            reader = cmd.ExecuteReader

            Dim price As Decimal
            While reader.Read
                price = reader.GetDecimal("SellPrice")
            End While

            txtPrice.Text = price.ToString

            objconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        BindingNavigator1.BindingSource = SalesorderBindingSource
    End Sub

    Private Sub btnGenerateSalesID_Click(sender As Object, e As EventArgs) Handles btnGenerateSalesID.Click
        Randomize()
        Dim gen As Integer = CInt(Int((1000 * Rnd()) + 1))
        gen.ToString()
        Dim final As String = "SALES" & gen
        txtSalesOrderID.Clear()
        txtSalesOrderID.Text = final
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            objconnection.Open()
            Dim query As String = "select sum(Total) from SalesOrder"
            Dim Command = New MySqlCommand(query, objconnection)
            Dim total = Command.ExecuteScalar()

            txtGrandTotal.Text = total.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objconnection.Close()
        End Try
    End Sub

    Private Sub btnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenerateReceipt.Click
        Try

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            Dim query As String = "insert into Bill(BillID, CustomerID, CustomerName, CurrentDate, SalesOrderID, GrandTotal ) values('" & txtBillID.Text & "','" & cmbCustomerID.Text & "','" & txtCustomerName.Text & "','" & DateTimePicker1.Value & "','" & txtSalesOrderID.Text & "','" & txtGrandTotal.Text & "')"

            Dim cmd = New MySqlCommand(query, objconnection)


            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Save Successful", _
                       "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Me.BillTableAdapter.Fill(Me.StorebillingsystemdbDataSet2.bill)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objconnection.Dispose()
        End Try

        frmReport.Show()
    End Sub
End Class