<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.salesorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.storebillingsystemdbDataSet2 = New Store_Billing_System.storebillingsystemdbDataSet2()
        Me.employeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeeTableAdapter = New Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.employeeTableAdapter()
        Me.customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.customerTableAdapter = New Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.customerTableAdapter()
        Me.billBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.billTableAdapter = New Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.billTableAdapter()
        Me.salesorderTableAdapter = New Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.salesorderTableAdapter()
        CType(Me.salesorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.storebillingsystemdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackgroundImage = CType(resources.GetObject("ReportViewer1.BackgroundImage"), System.Drawing.Image)
        Me.ReportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Bill"
        ReportDataSource1.Value = Me.billBindingSource
        ReportDataSource2.Name = "SalesOrder"
        ReportDataSource2.Value = Me.salesorderBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Store_Billing_System.BillReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(707, 554)
        Me.ReportViewer1.TabIndex = 0
        '
        'salesorderBindingSource
        '
        Me.salesorderBindingSource.DataMember = "salesorder"
        Me.salesorderBindingSource.DataSource = Me.storebillingsystemdbDataSet2
        '
        'storebillingsystemdbDataSet2
        '
        Me.storebillingsystemdbDataSet2.DataSetName = "storebillingsystemdbDataSet2"
        Me.storebillingsystemdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'employeeBindingSource
        '
        Me.employeeBindingSource.DataMember = "employee"
        Me.employeeBindingSource.DataSource = Me.storebillingsystemdbDataSet2
        '
        'employeeTableAdapter
        '
        Me.employeeTableAdapter.ClearBeforeFill = True
        '
        'customerBindingSource
        '
        Me.customerBindingSource.DataMember = "customer"
        Me.customerBindingSource.DataSource = Me.storebillingsystemdbDataSet2
        '
        'customerTableAdapter
        '
        Me.customerTableAdapter.ClearBeforeFill = True
        '
        'billBindingSource
        '
        Me.billBindingSource.DataMember = "bill"
        Me.billBindingSource.DataSource = Me.storebillingsystemdbDataSet2
        '
        'billTableAdapter
        '
        Me.billTableAdapter.ClearBeforeFill = True
        '
        'salesorderTableAdapter
        '
        Me.salesorderTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReport"
        Me.ShowIcon = False
        Me.Text = "Report"
        CType(Me.salesorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.storebillingsystemdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents employeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents storebillingsystemdbDataSet2 As Store_Billing_System.storebillingsystemdbDataSet2
    Friend WithEvents customerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents billBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents employeeTableAdapter As Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.employeeTableAdapter
    Friend WithEvents customerTableAdapter As Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.customerTableAdapter
    Friend WithEvents billTableAdapter As Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.billTableAdapter
    Friend WithEvents salesorderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents salesorderTableAdapter As Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.salesorderTableAdapter
End Class
