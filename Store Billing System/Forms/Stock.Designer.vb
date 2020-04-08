<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim StockIDLabel As System.Windows.Forms.Label
        Dim DateAddedLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim CostPriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim ManDateLabel As System.Windows.Forms.Label
        Dim ExpDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StorebillingsystemdbDataSet2 = New Store_Billing_System.storebillingsystemdbDataSet2()
        Me.StockIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateAddedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CostPriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ManDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExpDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StockTableAdapter = New Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.stockTableAdapter()
        Me.TableAdapterManager = New Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnNextItem = New System.Windows.Forms.Button()
        Me.btnPreviousItem = New System.Windows.Forms.Button()
        Me.btnLastItem = New System.Windows.Forms.Button()
        Me.btnFirstItem = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        StockIDLabel = New System.Windows.Forms.Label()
        DateAddedLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        CostPriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        ManDateLabel = New System.Windows.Forms.Label()
        ExpDateLabel = New System.Windows.Forms.Label()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorebillingsystemdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StockIDLabel
        '
        StockIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        StockIDLabel.AutoSize = True
        StockIDLabel.Location = New System.Drawing.Point(60, 10)
        StockIDLabel.Name = "StockIDLabel"
        StockIDLabel.Size = New System.Drawing.Size(55, 15)
        StockIDLabel.TabIndex = 1
        StockIDLabel.Text = "Stock ID:"
        '
        'DateAddedLabel
        '
        DateAddedLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        DateAddedLabel.AutoSize = True
        DateAddedLabel.Location = New System.Drawing.Point(60, 41)
        DateAddedLabel.Name = "DateAddedLabel"
        DateAddedLabel.Size = New System.Drawing.Size(74, 15)
        DateAddedLabel.TabIndex = 3
        DateAddedLabel.Text = "Date Added:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(60, 70)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(67, 15)
        ProductIDLabel.TabIndex = 5
        ProductIDLabel.Text = "Product ID:"
        '
        'CostPriceLabel
        '
        CostPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        CostPriceLabel.AutoSize = True
        CostPriceLabel.Location = New System.Drawing.Point(60, 101)
        CostPriceLabel.Name = "CostPriceLabel"
        CostPriceLabel.Size = New System.Drawing.Size(65, 15)
        CostPriceLabel.TabIndex = 7
        CostPriceLabel.Text = "Cost Price:"
        '
        'QuantityLabel
        '
        QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(399, 13)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(54, 15)
        QuantityLabel.TabIndex = 9
        QuantityLabel.Text = "Quantity:"
        '
        'ManDateLabel
        '
        ManDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        ManDateLabel.AutoSize = True
        ManDateLabel.Location = New System.Drawing.Point(399, 44)
        ManDateLabel.Name = "ManDateLabel"
        ManDateLabel.Size = New System.Drawing.Size(64, 15)
        ManDateLabel.TabIndex = 11
        ManDateLabel.Text = "Man Date:"
        '
        'ExpDateLabel
        '
        ExpDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        ExpDateLabel.AutoSize = True
        ExpDateLabel.Location = New System.Drawing.Point(399, 74)
        ExpDateLabel.Name = "ExpDateLabel"
        ExpDateLabel.Size = New System.Drawing.Size(60, 15)
        ExpDateLabel.TabIndex = 13
        ExpDateLabel.Text = "Exp Date:"
        '
        'StockDataGridView
        '
        Me.StockDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(12, 131)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(1063, 283)
        Me.StockDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StockID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StockID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DateAdded"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DateAdded"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CostPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CostPrice"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ManDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ManDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ExpDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ExpDate"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.StorebillingsystemdbDataSet2
        '
        'StorebillingsystemdbDataSet2
        '
        Me.StorebillingsystemdbDataSet2.DataSetName = "storebillingsystemdbDataSet2"
        Me.StorebillingsystemdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockIDTextBox
        '
        Me.StockIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StockIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "StockID", True))
        Me.StockIDTextBox.Location = New System.Drawing.Point(145, 7)
        Me.StockIDTextBox.Name = "StockIDTextBox"
        Me.StockIDTextBox.Size = New System.Drawing.Size(233, 21)
        Me.StockIDTextBox.TabIndex = 2
        '
        'DateAddedDateTimePicker
        '
        Me.DateAddedDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateAddedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StockBindingSource, "DateAdded", True))
        Me.DateAddedDateTimePicker.Location = New System.Drawing.Point(145, 37)
        Me.DateAddedDateTimePicker.Name = "DateAddedDateTimePicker"
        Me.DateAddedDateTimePicker.Size = New System.Drawing.Size(233, 21)
        Me.DateAddedDateTimePicker.TabIndex = 4
        '
        'ProductIDComboBox
        '
        Me.ProductIDComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProductIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "ProductID", True))
        Me.ProductIDComboBox.FormattingEnabled = True
        Me.ProductIDComboBox.Location = New System.Drawing.Point(145, 67)
        Me.ProductIDComboBox.Name = "ProductIDComboBox"
        Me.ProductIDComboBox.Size = New System.Drawing.Size(233, 23)
        Me.ProductIDComboBox.TabIndex = 6
        '
        'CostPriceTextBox
        '
        Me.CostPriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CostPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "CostPrice", True))
        Me.CostPriceTextBox.Location = New System.Drawing.Point(145, 98)
        Me.CostPriceTextBox.Name = "CostPriceTextBox"
        Me.CostPriceTextBox.Size = New System.Drawing.Size(233, 21)
        Me.CostPriceTextBox.TabIndex = 8
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(484, 9)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(233, 21)
        Me.QuantityTextBox.TabIndex = 10
        '
        'ManDateDateTimePicker
        '
        Me.ManDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ManDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StockBindingSource, "ManDate", True))
        Me.ManDateDateTimePicker.Location = New System.Drawing.Point(484, 39)
        Me.ManDateDateTimePicker.Name = "ManDateDateTimePicker"
        Me.ManDateDateTimePicker.Size = New System.Drawing.Size(233, 21)
        Me.ManDateDateTimePicker.TabIndex = 12
        '
        'ExpDateDateTimePicker
        '
        Me.ExpDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ExpDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StockBindingSource, "ExpDate", True))
        Me.ExpDateDateTimePicker.Location = New System.Drawing.Point(484, 69)
        Me.ExpDateDateTimePicker.Name = "ExpDateDateTimePicker"
        Me.ExpDateDateTimePicker.Size = New System.Drawing.Size(233, 21)
        Me.ExpDateDateTimePicker.TabIndex = 14
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.billTableAdapter = Nothing
        Me.TableAdapterManager.categoryTableAdapter = Nothing
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.salesorderTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        'Me.TableAdapterManager.taxTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnNextItem
        '
        Me.btnNextItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNextItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextItem.Image = CType(resources.GetObject("btnNextItem.Image"), System.Drawing.Image)
        Me.btnNextItem.Location = New System.Drawing.Point(891, 17)
        Me.btnNextItem.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNextItem.Name = "btnNextItem"
        Me.btnNextItem.Size = New System.Drawing.Size(52, 32)
        Me.btnNextItem.TabIndex = 24
        Me.btnNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnNextItem, "Next Item")
        Me.btnNextItem.UseVisualStyleBackColor = True
        '
        'btnPreviousItem
        '
        Me.btnPreviousItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPreviousItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousItem.Image = CType(resources.GetObject("btnPreviousItem.Image"), System.Drawing.Image)
        Me.btnPreviousItem.Location = New System.Drawing.Point(829, 17)
        Me.btnPreviousItem.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPreviousItem.Name = "btnPreviousItem"
        Me.btnPreviousItem.Size = New System.Drawing.Size(52, 32)
        Me.btnPreviousItem.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btnPreviousItem, "Previous Item")
        Me.btnPreviousItem.UseVisualStyleBackColor = True
        '
        'btnLastItem
        '
        Me.btnLastItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLastItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLastItem.Image = CType(resources.GetObject("btnLastItem.Image"), System.Drawing.Image)
        Me.btnLastItem.Location = New System.Drawing.Point(953, 17)
        Me.btnLastItem.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLastItem.Name = "btnLastItem"
        Me.btnLastItem.Size = New System.Drawing.Size(54, 32)
        Me.btnLastItem.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnLastItem, "Last Item")
        Me.btnLastItem.UseVisualStyleBackColor = True
        '
        'btnFirstItem
        '
        Me.btnFirstItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFirstItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstItem.Image = CType(resources.GetObject("btnFirstItem.Image"), System.Drawing.Image)
        Me.btnFirstItem.Location = New System.Drawing.Point(772, 17)
        Me.btnFirstItem.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFirstItem.Name = "btnFirstItem"
        Me.btnFirstItem.Size = New System.Drawing.Size(48, 32)
        Me.btnFirstItem.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.btnFirstItem, "First Item")
        Me.btnFirstItem.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(907, 58)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(81, 32)
        Me.btnUpdate.TabIndex = 45
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(998, 58)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 32)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
        Me.btnAddNew.Location = New System.Drawing.Point(814, 58)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(81, 32)
        Me.btnAddNew.TabIndex = 47
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(725, 58)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 32)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1087, 25)
        Me.BindingNavigator1.TabIndex = 49
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 427)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNextItem)
        Me.Controls.Add(Me.btnPreviousItem)
        Me.Controls.Add(Me.btnLastItem)
        Me.Controls.Add(Me.btnFirstItem)
        Me.Controls.Add(StockIDLabel)
        Me.Controls.Add(Me.StockIDTextBox)
        Me.Controls.Add(DateAddedLabel)
        Me.Controls.Add(Me.DateAddedDateTimePicker)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDComboBox)
        Me.Controls.Add(CostPriceLabel)
        Me.Controls.Add(Me.CostPriceTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(ManDateLabel)
        Me.Controls.Add(Me.ManDateDateTimePicker)
        Me.Controls.Add(ExpDateLabel)
        Me.Controls.Add(Me.ExpDateDateTimePicker)
        Me.Controls.Add(Me.StockDataGridView)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Stock"
        Me.ShowIcon = False
        Me.Text = "Stock"
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorebillingsystemdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StorebillingsystemdbDataSet2 As Store_Billing_System.storebillingsystemdbDataSet2
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.stockTableAdapter
    Friend WithEvents TableAdapterManager As Store_Billing_System.storebillingsystemdbDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateAddedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProductIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CostPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExpDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNextItem As System.Windows.Forms.Button
    Friend WithEvents btnPreviousItem As System.Windows.Forms.Button
    Friend WithEvents btnLastItem As System.Windows.Forms.Button
    Friend WithEvents btnFirstItem As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
