<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMDIform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMDIform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabHomePage = New System.Windows.Forms.TabPage()
        Me.HomeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnDashboard = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProcessBill = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCalculator = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabRecordsPage = New System.Windows.Forms.TabPage()
        Me.RecordsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnViewBills = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEmployees = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCustomers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProducts = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnStock = New System.Windows.Forms.ToolStripButton()
        Me.tabSettingsPage = New System.Windows.Forms.TabPage()
        Me.SettingsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCategory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnConfigureTax = New System.Windows.Forms.ToolStripButton()
        Me.MainMDIFormTC = New Store_Billing_System.TabControlEx()
        Me.Panel1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.tabHomePage.SuspendLayout()
        Me.HomeToolStrip.SuspendLayout()
        Me.tabRecordsPage.SuspendLayout()
        Me.RecordsToolStrip.SuspendLayout()
        Me.tabSettingsPage.SuspendLayout()
        Me.SettingsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.TabControl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 81)
        Me.Panel1.TabIndex = 5
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(645, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(84, 25)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabHomePage)
        Me.TabControl.Controls.Add(Me.tabRecordsPage)
        Me.TabControl.Controls.Add(Me.tabSettingsPage)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(729, 81)
        Me.TabControl.TabIndex = 4
        '
        'tabHomePage
        '
        Me.tabHomePage.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tabHomePage.Controls.Add(Me.HomeToolStrip)
        Me.tabHomePage.Location = New System.Drawing.Point(4, 25)
        Me.tabHomePage.Name = "tabHomePage"
        Me.tabHomePage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHomePage.Size = New System.Drawing.Size(721, 52)
        Me.tabHomePage.TabIndex = 0
        Me.tabHomePage.Text = "Home"
        '
        'HomeToolStrip
        '
        Me.HomeToolStrip.BackColor = System.Drawing.SystemColors.HotTrack
        Me.HomeToolStrip.BackgroundImage = CType(resources.GetObject("HomeToolStrip.BackgroundImage"), System.Drawing.Image)
        Me.HomeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HomeToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.HomeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDashboard, Me.ToolStripSeparator1, Me.btnProcessBill, Me.ToolStripSeparator2, Me.btnCalculator, Me.ToolStripSeparator3})
        Me.HomeToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.HomeToolStrip.Name = "HomeToolStrip"
        Me.HomeToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HomeToolStrip.Size = New System.Drawing.Size(715, 50)
        Me.HomeToolStrip.TabIndex = 2
        Me.HomeToolStrip.Text = "Tools"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.SystemColors.Control
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDashboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDashboard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(80, 47)
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'btnProcessBill
        '
        Me.btnProcessBill.BackColor = System.Drawing.SystemColors.Control
        Me.btnProcessBill.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnProcessBill.Image = CType(resources.GetObject("btnProcessBill.Image"), System.Drawing.Image)
        Me.btnProcessBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcessBill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnProcessBill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcessBill.Name = "btnProcessBill"
        Me.btnProcessBill.Size = New System.Drawing.Size(80, 47)
        Me.btnProcessBill.Text = "Process Bill"
        Me.btnProcessBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProcessBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'btnCalculator
        '
        Me.btnCalculator.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculator.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCalculator.Image = CType(resources.GetObject("btnCalculator.Image"), System.Drawing.Image)
        Me.btnCalculator.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalculator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCalculator.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(74, 47)
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 50)
        '
        'tabRecordsPage
        '
        Me.tabRecordsPage.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tabRecordsPage.Controls.Add(Me.RecordsToolStrip)
        Me.tabRecordsPage.Location = New System.Drawing.Point(4, 25)
        Me.tabRecordsPage.Name = "tabRecordsPage"
        Me.tabRecordsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRecordsPage.Size = New System.Drawing.Size(721, 52)
        Me.tabRecordsPage.TabIndex = 1
        Me.tabRecordsPage.Text = "Records"
        '
        'RecordsToolStrip
        '
        Me.RecordsToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.RecordsToolStrip.BackgroundImage = CType(resources.GetObject("RecordsToolStrip.BackgroundImage"), System.Drawing.Image)
        Me.RecordsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RecordsToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RecordsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnViewBills, Me.ToolStripSeparator4, Me.btnEmployees, Me.ToolStripSeparator5, Me.btnCustomers, Me.ToolStripSeparator6, Me.btnProducts, Me.ToolStripSeparator7, Me.btnStock})
        Me.RecordsToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.RecordsToolStrip.Name = "RecordsToolStrip"
        Me.RecordsToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.RecordsToolStrip.Size = New System.Drawing.Size(715, 50)
        Me.RecordsToolStrip.TabIndex = 3
        Me.RecordsToolStrip.Text = "Tools"
        '
        'btnViewBills
        '
        Me.btnViewBills.BackColor = System.Drawing.SystemColors.Control
        Me.btnViewBills.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnViewBills.Image = CType(resources.GetObject("btnViewBills.Image"), System.Drawing.Image)
        Me.btnViewBills.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewBills.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnViewBills.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewBills.Name = "btnViewBills"
        Me.btnViewBills.Size = New System.Drawing.Size(69, 47)
        Me.btnViewBills.Text = "View Bills"
        Me.btnViewBills.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 50)
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.SystemColors.Control
        Me.btnEmployees.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnEmployees.Image = CType(resources.GetObject("btnEmployees.Image"), System.Drawing.Image)
        Me.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEmployees.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(78, 47)
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 50)
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.SystemColors.Control
        Me.btnCustomers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCustomers.Image = CType(resources.GetObject("btnCustomers.Image"), System.Drawing.Image)
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(79, 47)
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 50)
        '
        'btnProducts
        '
        Me.btnProducts.BackColor = System.Drawing.SystemColors.Control
        Me.btnProducts.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(67, 47)
        Me.btnProducts.Text = "Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 50)
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.SystemColors.Control
        Me.btnStock.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnStock.Image = CType(resources.GetObject("btnStock.Image"), System.Drawing.Image)
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnStock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(66, 47)
        Me.btnStock.Text = "   Stock  "
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tabSettingsPage
        '
        Me.tabSettingsPage.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tabSettingsPage.Controls.Add(Me.SettingsToolStrip)
        Me.tabSettingsPage.Location = New System.Drawing.Point(4, 25)
        Me.tabSettingsPage.Name = "tabSettingsPage"
        Me.tabSettingsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettingsPage.Size = New System.Drawing.Size(721, 52)
        Me.tabSettingsPage.TabIndex = 2
        Me.tabSettingsPage.Text = "Settings"
        '
        'SettingsToolStrip
        '
        Me.SettingsToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.SettingsToolStrip.BackgroundImage = CType(resources.GetObject("SettingsToolStrip.BackgroundImage"), System.Drawing.Image)
        Me.SettingsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SettingsToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SettingsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.btnCategory, Me.ToolStripSeparator10, Me.btnConfigureTax})
        Me.SettingsToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.SettingsToolStrip.Name = "SettingsToolStrip"
        Me.SettingsToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SettingsToolStrip.Size = New System.Drawing.Size(715, 50)
        Me.SettingsToolStrip.TabIndex = 3
        Me.SettingsToolStrip.Text = "Tools"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 50)
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.SystemColors.Control
        Me.btnCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCategory.Image = CType(resources.GetObject("btnCategory.Image"), System.Drawing.Image)
        Me.btnCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(130, 47)
        Me.btnCategory.Text = "Product Categories"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 50)
        '
        'btnConfigureTax
        '
        Me.btnConfigureTax.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfigureTax.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnConfigureTax.Image = CType(resources.GetObject("btnConfigureTax.Image"), System.Drawing.Image)
        Me.btnConfigureTax.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfigureTax.Name = "btnConfigureTax"
        Me.btnConfigureTax.Size = New System.Drawing.Size(97, 47)
        Me.btnConfigureTax.Text = "Configure Tax"
        Me.btnConfigureTax.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfigureTax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnConfigureTax.Visible = False
        '
        'MainMDIFormTC
        '
        Me.MainMDIFormTC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMDIFormTC.Location = New System.Drawing.Point(0, 81)
        Me.MainMDIFormTC.Name = "MainMDIFormTC"
        Me.MainMDIFormTC.SelectedIndex = 0
        Me.MainMDIFormTC.Size = New System.Drawing.Size(729, 438)
        Me.MainMDIFormTC.TabIndex = 7
        '
        'MainMDIform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 519)
        Me.Controls.Add(Me.MainMDIFormTC)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMDIform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Billing System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.tabHomePage.ResumeLayout(False)
        Me.tabHomePage.PerformLayout()
        Me.HomeToolStrip.ResumeLayout(False)
        Me.HomeToolStrip.PerformLayout()
        Me.tabRecordsPage.ResumeLayout(False)
        Me.tabRecordsPage.PerformLayout()
        Me.RecordsToolStrip.ResumeLayout(False)
        Me.RecordsToolStrip.PerformLayout()
        Me.tabSettingsPage.ResumeLayout(False)
        Me.tabSettingsPage.PerformLayout()
        Me.SettingsToolStrip.ResumeLayout(False)
        Me.SettingsToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabHomePage As System.Windows.Forms.TabPage
    Friend WithEvents HomeToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDashboard As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProcessBill As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCalculator As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tabRecordsPage As System.Windows.Forms.TabPage
    Friend WithEvents RecordsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnViewBills As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEmployees As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCustomers As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProducts As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnStock As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabSettingsPage As System.Windows.Forms.TabPage
    Friend WithEvents SettingsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCategory As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMDIFormTC As Store_Billing_System.TabControlEx
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnConfigureTax As System.Windows.Forms.ToolStripButton

End Class
