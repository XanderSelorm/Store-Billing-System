<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.tbcntrlDashboard = New System.Windows.Forms.TabControl()
        Me.tbpgSummary = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTotalBills = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.DashboardPictureBox = New System.Windows.Forms.PictureBox()
        Me.tbpgSearch = New System.Windows.Forms.TabPage()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.cmbSearchOn = New System.Windows.Forms.ComboBox()
        Me.cmbSearchFor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbcntrlDashboard.SuspendLayout()
        Me.tbpgSummary.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DashboardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpgSearch.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcntrlDashboard
        '
        Me.tbcntrlDashboard.Controls.Add(Me.tbpgSummary)
        Me.tbcntrlDashboard.Controls.Add(Me.tbpgSearch)
        Me.tbcntrlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcntrlDashboard.Location = New System.Drawing.Point(0, 0)
        Me.tbcntrlDashboard.Name = "tbcntrlDashboard"
        Me.tbcntrlDashboard.SelectedIndex = 0
        Me.tbcntrlDashboard.Size = New System.Drawing.Size(796, 415)
        Me.tbcntrlDashboard.TabIndex = 0
        '
        'tbpgSummary
        '
        Me.tbpgSummary.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbpgSummary.BackgroundImage = CType(resources.GetObject("tbpgSummary.BackgroundImage"), System.Drawing.Image)
        Me.tbpgSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbpgSummary.Controls.Add(Me.Panel4)
        Me.tbpgSummary.Controls.Add(Me.Panel3)
        Me.tbpgSummary.Controls.Add(Me.Panel1)
        Me.tbpgSummary.Location = New System.Drawing.Point(4, 22)
        Me.tbpgSummary.Name = "tbpgSummary"
        Me.tbpgSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgSummary.Size = New System.Drawing.Size(788, 389)
        Me.tbpgSummary.TabIndex = 0
        Me.tbpgSummary.Text = "Summary"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Controls.Add(Me.lblTotalBills)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(310, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(189, 135)
        Me.Panel4.TabIndex = 3
        '
        'lblTotalBills
        '
        Me.lblTotalBills.AutoSize = True
        Me.lblTotalBills.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBills.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalBills.Location = New System.Drawing.Point(80, 80)
        Me.lblTotalBills.Name = "lblTotalBills"
        Me.lblTotalBills.Size = New System.Drawing.Size(23, 25)
        Me.lblTotalBills.TabIndex = 1
        Me.lblTotalBills.Text = "0"
        Me.lblTotalBills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(43, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 50)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Bills " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Processed"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Controls.Add(Me.lblTotalCustomers)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(563, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(189, 135)
        Me.Panel3.TabIndex = 3
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCustomers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalCustomers.Location = New System.Drawing.Point(81, 79)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(23, 25)
        Me.lblTotalCustomers.TabIndex = 1
        Me.lblTotalCustomers.Text = "0"
        Me.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(20, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total Customers"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.DashboardPictureBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 383)
        Me.Panel1.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.FlatAppearance.BorderSize = 3
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(48, 275)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(167, 64)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(5, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Current Date and Time"
        '
        'lblRole
        '
        Me.lblRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRole.Location = New System.Drawing.Point(78, 234)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(51, 25)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = "Role"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(85, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Welcome"
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Location = New System.Drawing.Point(78, 209)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'DashboardPictureBox
        '
        Me.DashboardPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashboardPictureBox.BackColor = System.Drawing.Color.AliceBlue
        Me.DashboardPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DashboardPictureBox.Location = New System.Drawing.Point(65, 55)
        Me.DashboardPictureBox.Name = "DashboardPictureBox"
        Me.DashboardPictureBox.Size = New System.Drawing.Size(138, 151)
        Me.DashboardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DashboardPictureBox.TabIndex = 0
        Me.DashboardPictureBox.TabStop = False
        '
        'tbpgSearch
        '
        Me.tbpgSearch.BackColor = System.Drawing.Color.RoyalBlue
        Me.tbpgSearch.BackgroundImage = CType(resources.GetObject("tbpgSearch.BackgroundImage"), System.Drawing.Image)
        Me.tbpgSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbpgSearch.Controls.Add(Me.dgvResults)
        Me.tbpgSearch.Controls.Add(Me.cmbSearchOn)
        Me.tbpgSearch.Controls.Add(Me.cmbSearchFor)
        Me.tbpgSearch.Controls.Add(Me.Label3)
        Me.tbpgSearch.Controls.Add(Me.Label2)
        Me.tbpgSearch.Controls.Add(Me.Label1)
        Me.tbpgSearch.Controls.Add(Me.txtSearch)
        Me.tbpgSearch.Controls.Add(Me.btnDisplay)
        Me.tbpgSearch.Location = New System.Drawing.Point(4, 22)
        Me.tbpgSearch.Name = "tbpgSearch"
        Me.tbpgSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgSearch.Size = New System.Drawing.Size(788, 389)
        Me.tbpgSearch.TabIndex = 1
        Me.tbpgSearch.Text = "Search"
        '
        'dgvResults
        '
        Me.dgvResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(21, 84)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(747, 299)
        Me.dgvResults.TabIndex = 12
        '
        'cmbSearchOn
        '
        Me.cmbSearchOn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSearchOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchOn.FormattingEnabled = True
        Me.cmbSearchOn.Location = New System.Drawing.Point(353, 25)
        Me.cmbSearchOn.Name = "cmbSearchOn"
        Me.cmbSearchOn.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchOn.TabIndex = 10
        '
        'cmbSearchFor
        '
        Me.cmbSearchFor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSearchFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchFor.FormattingEnabled = True
        Me.cmbSearchFor.Items.AddRange(New Object() {"Employee", "Product", "Customer"})
        Me.cmbSearchFor.Location = New System.Drawing.Point(119, 26)
        Me.cmbSearchFor.Name = "cmbSearchFor"
        Me.cmbSearchFor.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchFor.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(488, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Search"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(281, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Filter By"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Search for"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.Location = New System.Drawing.Point(550, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(670, 23)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 24)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 415)
        Me.Controls.Add(Me.tbcntrlDashboard)
        Me.DoubleBuffered = True
        Me.Name = "Dashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbcntrlDashboard.ResumeLayout(False)
        Me.tbpgSummary.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DashboardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpgSearch.ResumeLayout(False)
        Me.tbpgSearch.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcntrlDashboard As System.Windows.Forms.TabControl
    Friend WithEvents tbpgSummary As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents DashboardPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents tbpgSearch As System.Windows.Forms.TabPage
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSearchOn As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearchFor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalBills As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalCustomers As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
