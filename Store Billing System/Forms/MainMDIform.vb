Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class MainMDIform

    Dim con As New MySqlConnection(My.Settings.storebillingsystemdbConnectionString)
    Dim cmd As New MySqlCommand


    '''CREATING NEW TABS'''
    Dim emp, db, stk, cust, prd, pb As New TabPage

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Try
            If MainMDIFormTC.TabPages.Contains(emp) Then
                MainMDIFormTC.SelectedTab = emp
            Else
                MainMDIFormTC.TabPages.Add(emp)
                emp.Text = "Employees"
                Employee.TopLevel = False
                Employee.Visible = True
                Employee.FormBorderStyle = FormBorderStyle.None
                Employee.Dock = DockStyle.Fill

                emp.Controls.Add(Employee)
                Employee.Show()
                MainMDIFormTC.SelectedTab = emp
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub MainMDIform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Show()
    End Sub

    Private Sub mainMDIform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MainMDIFormTC.TabPages.Insert(0, db)
            db.Text = "Dashboard"
            Dashboard.TopLevel = False
            Dashboard.Visible = True
            Dashboard.FormBorderStyle = FormBorderStyle.None
            Dashboard.Dock = DockStyle.Fill
            db.Controls.Add(Dashboard)
            Dashboard.Show()
            MainMDIFormTC.SelectedTab = db
            MainMDIFormTC.Update()

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim n As String = MessageBox.Show("Do you really want to Logout?", _
    "Confirmation Dialog Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If n = vbYes Then
            Me.Close() 'Current Form Closed
            Login.Show() 'Form Name.show()
        End If
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Try
            If MainMDIFormTC.TabPages.Contains(cust) Then
                MainMDIFormTC.SelectedTab = cust
            Else
                MainMDIFormTC.TabPages.Add(cust)
                cust.Text = "Customers"
                Customer_Details.TopLevel = False
                Customer_Details.Visible = True
                Customer_Details.FormBorderStyle = FormBorderStyle.None
                Customer_Details.Dock = DockStyle.Fill

                cust.Controls.Add(Customer_Details)
                Customer_Details.Show()
                MainMDIFormTC.SelectedTab = cust
                cust.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Try
            If MainMDIFormTC.TabPages.Contains(prd) Then
                MainMDIFormTC.SelectedTab = prd
            Else
                MainMDIFormTC.TabPages.Add(prd)
                prd.Text = "Products"
                Products.TopLevel = False
                Products.Visible = True
                Products.FormBorderStyle = FormBorderStyle.None
                Products.Dock = DockStyle.Fill

                prd.Controls.Add(Products)
                Products.Show()
                MainMDIFormTC.SelectedTab = prd
                prd.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnProcessBill_Click(sender As Object, e As EventArgs) Handles btnProcessBill.Click
        Try
            If MainMDIFormTC.TabPages.Contains(pb) Then
                MainMDIFormTC.SelectedTab = pb
            Else
                MainMDIFormTC.TabPages.Add(pb)
                pb.Text = "Process Bill"
                ProcessBill.TopLevel = False
                ProcessBill.Visible = True
                ProcessBill.FormBorderStyle = FormBorderStyle.None
                ProcessBill.Dock = DockStyle.Fill

                pb.Controls.Add(ProcessBill)
                ProcessBill.Show()
                MainMDIFormTC.SelectedTab = pb
                pb.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConfigureTax_Click(sender As Object, e As EventArgs) Handles btnConfigureTax.Click
        'ConfigureTax.ShowDialog()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Calculator.Show()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        Try
            If MainMDIFormTC.TabPages.Contains(stk) Then
                MainMDIFormTC.SelectedTab = stk
            Else
                Stock.TopLevel = False
                Stock.Visible = True
                Stock.FormBorderStyle = FormBorderStyle.None
                Stock.Dock = DockStyle.Fill
                MainMDIFormTC.TabPages.Add(stk)
                stk.Text = "Stock"
                stk.Controls.Add(Stock)
                Stock.Show()
                MainMDIFormTC.SelectedTab = stk
                stk.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try


    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Try
            If MainMDIFormTC.TabPages.Contains(db) Then
                MainMDIFormTC.SelectedTab = db
            Else
                MainMDIFormTC.TabPages.Add(db)
                db.Text = "Dashboard"
                Dashboard.TopLevel = False
                Dashboard.Visible = True
                Dashboard.FormBorderStyle = FormBorderStyle.None
                Dashboard.Dock = DockStyle.Fill

                db.Controls.Add(Dashboard)
                Dashboard.Show()
                MainMDIFormTC.SelectedTab = db
                db.Refresh()
            End If

            ''''''''fill total customers label''''''''
            
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        AddCategory.ShowDialog()
    End Sub

    Private Sub btnViewBills_Click(sender As Object, e As EventArgs) Handles btnViewBills.Click
        frmReport.Show()
    End Sub
End Class
