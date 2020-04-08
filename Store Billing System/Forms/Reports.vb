Public Class frmReport

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'storebillingsystemdbDataSet2.salesorder' table. You can move, or remove it, as needed.
        Me.salesorderTableAdapter.Fill(Me.storebillingsystemdbDataSet2.salesorder)
        'TODO: This line of code loads data into the 'storebillingsystemdbDataSet2.employee' table. You can move, or remove it, as needed.
        Me.employeeTableAdapter.Fill(Me.storebillingsystemdbDataSet2.employee)
        'TODO: This line of code loads data into the 'storebillingsystemdbDataSet2.customer' table. You can move, or remove it, as needed.
        Me.customerTableAdapter.Fill(Me.storebillingsystemdbDataSet2.customer)
        'TODO: This line of code loads data into the 'storebillingsystemdbDataSet2.bill' table. You can move, or remove it, as needed.
        Me.billTableAdapter.Fill(Me.storebillingsystemdbDataSet2.bill)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class