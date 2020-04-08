Imports MySql.Data.MySqlClient
Public Class Dashboard

    Dim con As New MySqlConnection(My.Settings.storebillingsystemdbConnectionString)
    Dim cmd As New MySqlCommand
    Dim query As String = ""
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Creating Columns in the DatGridView
        dgvResults.Columns.Clear()
        If cmbSearchFor.Text = "Employee" Then
            With dgvResults
                .Columns.Add("Username", "User Name")
                .Columns.Add("FirstName", "First Name")
                .Columns.Add("LastName", "Last Name")
                .Columns.Add("Email", "Email")
                .Columns.Add("Position", "Position")
            End With
        ElseIf cmbSearchFor.Text = "Product" Then
            With dgvResults
                .Columns.Add("ProductID", "Product ID")
                .Columns.Add("ProductName", "Product Name")
                .Columns.Add("SellPrice", "Sell Price")
            End With
        ElseIf cmbSearchFor.Text = "Customer" Then
            With dgvResults
                .Columns.Add("CustomerID", "Product ID")
                .Columns.Add("FirstName", "First Name")
                .Columns.Add("LastName", "Last Name")
                .Columns.Add("Email", "Email")
                .Columns.Add("Phone", "Phone")
            End With
        End If
        'Query to look for items in the database and display them in the DataGrid View
        query = "select * from  Product   where '" & cmbSearchOn.Text & "' like '%" & txtSearch.Text & "%'"
        cmd = New MySqlCommand(query, con)
        If (con.State = ConnectionState.Closed) Then
            con.Open()
        End If
        'Read data from database, create rows in the DataGridView and display the items in them
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read Then
            While dr.Read()
                Select Case cmbSearchFor.Text
                    Case "Employee"
                        dgvResults.Rows.Add(dr.GetString("Username"), dr.GetString("FirstName"),
                                            dr.GetString("LastName"), dr.GetString("Email"), dr.GetString("Position"))
                    Case "Product"
                        dgvResults.Rows.Add(dr.GetString("ProductID"), dr.GetString("ProductName"),
                                            dr.GetString("SellPrice"))
                    Case "Customer"
                        dgvResults.Rows.Add(dr.GetString("CustomerID"), dr.GetString("FirstName"),
                                            dr.GetString("LastName"), dr.GetString("Email"), dr.GetString("Phone"))
                End Select

            End While
        Else
            MsgBox("Error")
        End If
        con.Close()
    End Sub

    Private Sub cmbSearchFor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchFor.SelectedIndexChanged
        cmbSearchOn.Items.Clear()
        Select Case cmbSearchFor.SelectedIndex
            Case 0
                With cmbSearchOn
                    .Items.Add("Username")
                    .Items.Add("FirstName")
                    .Items.Add("LastName")
                    .Items.Add("Email")
                    .Items.Add("Position")
                End With
            Case 1
                With cmbSearchOn
                    .Items.Add("ProductID")
                    .Items.Add("ProductName")
                    .Items.Add("SellPrice")
                End With
            Case 2
                With cmbSearchOn
                    .Items.Add("CustomeerID")
                    .Items.Add("FirstName")
                    .Items.Add("LastName")
                    .Items.Add("Email")
                    .Items.Add("Phone")
                End With
        End Select
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim n As String = MessageBox.Show("Do you really want to Logout?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Me.Close() 'Current Form Closed
            MainMDIform.Close()
            Login.Show() 'Form Name.show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")
    End Sub

    Sub totalCustomersLabel()
        '''''''''''TOTAL CUSTOMERS LABEL'''''''''''
        Try
            query = "select count(*) from Customer"
            cmd = New MySqlCommand(query, con)
            Dim ap = New MySqlDataAdapter(cmd.CommandText, con)
            Dim ds = New DataSet()


            con.Open()
            ap.Fill(ds)
            lblTotalCustomers.Text = cmd.ExecuteScalar
            'ds.Tables(0).Rows.Count.ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub totalBillsLabel()
        ''''''''''''''TOTAL BILLS PROCESSED LABEL'''''''''
        Try
            query = "select count(*) from Bill"
            cmd = New MySqlCommand(query, con)
            Dim ap = New MySqlDataAdapter(cmd.CommandText, con)
            Dim ds = New DataSet()


            con.Open()
            ap.Fill(ds)
            lblTotalBills.Text = cmd.ExecuteScalar
            'ds.Tables(0).Rows.Count.ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown, Me.GotFocus

        Timer1.Interval = 250
        Timer1.Start()

        totalCustomersLabel()
        totalBillsLabel()

    End Sub
End Class