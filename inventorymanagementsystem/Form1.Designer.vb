<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginPage))
        Me.tabControls = New System.Windows.Forms.TabControl()
        Me.tabProductDetails = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BATTERIESDataSet = New InventoryManagementSystem.BATTERIESDataSet()
        Me.exitButton0 = New System.Windows.Forms.Button()
        Me.deleteButton0 = New System.Windows.Forms.Button()
        Me.nextButton0 = New System.Windows.Forms.Button()
        Me.previousButton0 = New System.Windows.Forms.Button()
        Me.newButton0 = New System.Windows.Forms.Button()
        Me.storeButton0 = New System.Windows.Forms.Button()
        Me.priceLabel0 = New System.Windows.Forms.Label()
        Me.prodTypeLabel0 = New System.Windows.Forms.Label()
        Me.itemLabel0 = New System.Windows.Forms.Label()
        Me.productIdLabel0 = New System.Windows.Forms.Label()
        Me.prodNameLabel0 = New System.Windows.Forms.Label()
        Me.priceTextBox0 = New System.Windows.Forms.TextBox()
        Me.productTypeTextBox0 = New System.Windows.Forms.TextBox()
        Me.productIdTextBox0 = New System.Windows.Forms.TextBox()
        Me.itemTextBox0 = New System.Windows.Forms.TextBox()
        Me.productNameTextBox0 = New System.Windows.Forms.TextBox()
        Me.tabInventory = New System.Windows.Forms.TabPage()
        Me.newButton1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InboundDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutboundDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartureDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.departureDateLabel0 = New System.Windows.Forms.Label()
        Me.departureDateTextBox0 = New System.Windows.Forms.TextBox()
        Me.inBoundLabel0 = New System.Windows.Forms.Label()
        Me.inStockLabel0 = New System.Windows.Forms.Label()
        Me.inBoundTextBox0 = New System.Windows.Forms.TextBox()
        Me.inStockTextBox0 = New System.Windows.Forms.TextBox()
        Me.outBoundLabel = New System.Windows.Forms.Label()
        Me.arrivalDateLabel = New System.Windows.Forms.Label()
        Me.outBoundTextBox = New System.Windows.Forms.TextBox()
        Me.arrivalDateTextBox = New System.Windows.Forms.TextBox()
        Me.exitButton1 = New System.Windows.Forms.Button()
        Me.deleteButton1 = New System.Windows.Forms.Button()
        Me.nextButton1 = New System.Windows.Forms.Button()
        Me.previousButton1 = New System.Windows.Forms.Button()
        Me.storeButton1 = New System.Windows.Forms.Button()
        Me.productIdLabel1 = New System.Windows.Forms.Label()
        Me.productIdTextBox1 = New System.Windows.Forms.TextBox()
        Me.tabRestock = New System.Windows.Forms.TabPage()
        Me.newButton2 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.exitButton2 = New System.Windows.Forms.Button()
        Me.deleteButton2 = New System.Windows.Forms.Button()
        Me.nextButton2 = New System.Windows.Forms.Button()
        Me.previousButton2 = New System.Windows.Forms.Button()
        Me.storeButton2 = New System.Windows.Forms.Button()
        Me.unitPriceLabel = New System.Windows.Forms.Label()
        Me.orderIdLabel = New System.Windows.Forms.Label()
        Me.quantityLabel0 = New System.Windows.Forms.Label()
        Me.productIdLabel2 = New System.Windows.Forms.Label()
        Me.unitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.orderIdTextBox = New System.Windows.Forms.TextBox()
        Me.quantityTextBox0 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tabCustomerOrder = New System.Windows.Forms.TabPage()
        Me.newButton3 = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.exitButton3 = New System.Windows.Forms.Button()
        Me.deleteButton3 = New System.Windows.Forms.Button()
        Me.nextButton3 = New System.Windows.Forms.Button()
        Me.previousButton3 = New System.Windows.Forms.Button()
        Me.storeButton3 = New System.Windows.Forms.Button()
        Me.customerIdLabel2 = New System.Windows.Forms.Label()
        Me.orderIdLabel2 = New System.Windows.Forms.Label()
        Me.quantityLabel1 = New System.Windows.Forms.Label()
        Me.customerNameLabel0 = New System.Windows.Forms.Label()
        Me.customerIdTextBox0 = New System.Windows.Forms.TextBox()
        Me.orderId1TextBox = New System.Windows.Forms.TextBox()
        Me.quantityTextBox1 = New System.Windows.Forms.TextBox()
        Me.customerNameTextBox0 = New System.Windows.Forms.TextBox()
        Me.tabCustomerInformation = New System.Windows.Forms.TabPage()
        Me.newButton4 = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.exitButton4 = New System.Windows.Forms.Button()
        Me.deleteButton4 = New System.Windows.Forms.Button()
        Me.nextButton4 = New System.Windows.Forms.Button()
        Me.previousButton4 = New System.Windows.Forms.Button()
        Me.storeButton4 = New System.Windows.Forms.Button()
        Me.stateLabel0 = New System.Windows.Forms.Label()
        Me.cityLabel0 = New System.Windows.Forms.Label()
        Me.addressLabel0 = New System.Windows.Forms.Label()
        Me.customerContactLabel0 = New System.Windows.Forms.Label()
        Me.phoneLabel0 = New System.Windows.Forms.Label()
        Me.customerNameLabel1 = New System.Windows.Forms.Label()
        Me.stateTextBox0 = New System.Windows.Forms.TextBox()
        Me.cityTextBox0 = New System.Windows.Forms.TextBox()
        Me.addressTextBox0 = New System.Windows.Forms.TextBox()
        Me.customerContactTextBox0 = New System.Windows.Forms.TextBox()
        Me.phoneTextBox0 = New System.Windows.Forms.TextBox()
        Me.customerNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Product_DetailsTableAdapter = New InventoryManagementSystem.BATTERIESDataSetTableAdapters.Product_DetailsTableAdapter()
        Me.InventoryTableAdapter = New InventoryManagementSystem.BATTERIESDataSetTableAdapters.InventoryTableAdapter()
        Me.RestockTableAdapter = New InventoryManagementSystem.BATTERIESDataSetTableAdapters.RestockTableAdapter()
        Me.Customer_OrderTableAdapter = New InventoryManagementSystem.BATTERIESDataSetTableAdapters.Customer_OrderTableAdapter()
        Me.Customer_InformationTableAdapter = New InventoryManagementSystem.BATTERIESDataSetTableAdapters.Customer_InformationTableAdapter()
        Me.loginGroupBox = New System.Windows.Forms.GroupBox()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.cnclButton = New System.Windows.Forms.Button()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.tabControls.SuspendLayout
        Me.tabProductDetails.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductDetailsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BATTERIESDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabInventory.SuspendLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.InventoryBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabRestock.SuspendLayout
        CType(Me.DataGridView3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RestockBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabCustomerOrder.SuspendLayout
        CType(Me.DataGridView4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CustomerOrderBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabCustomerInformation.SuspendLayout
        CType(Me.DataGridView5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CustomerInformationBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.loginGroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'tabControls
        '
        Me.tabControls.Controls.Add(Me.tabProductDetails)
        Me.tabControls.Controls.Add(Me.tabInventory)
        Me.tabControls.Controls.Add(Me.tabRestock)
        Me.tabControls.Controls.Add(Me.tabCustomerOrder)
        Me.tabControls.Controls.Add(Me.tabCustomerInformation)
        Me.tabControls.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tabControls.Location = New System.Drawing.Point(46, 48)
        Me.tabControls.Name = "tabControls"
        Me.tabControls.SelectedIndex = 0
        Me.tabControls.Size = New System.Drawing.Size(1253, 433)
        Me.tabControls.TabIndex = 0
        Me.tabControls.Visible = false
        '
        'tabProductDetails
        '
        Me.tabProductDetails.Controls.Add(Me.DataGridView1)
        Me.tabProductDetails.Controls.Add(Me.exitButton0)
        Me.tabProductDetails.Controls.Add(Me.deleteButton0)
        Me.tabProductDetails.Controls.Add(Me.nextButton0)
        Me.tabProductDetails.Controls.Add(Me.previousButton0)
        Me.tabProductDetails.Controls.Add(Me.newButton0)
        Me.tabProductDetails.Controls.Add(Me.storeButton0)
        Me.tabProductDetails.Controls.Add(Me.priceLabel0)
        Me.tabProductDetails.Controls.Add(Me.prodTypeLabel0)
        Me.tabProductDetails.Controls.Add(Me.itemLabel0)
        Me.tabProductDetails.Controls.Add(Me.productIdLabel0)
        Me.tabProductDetails.Controls.Add(Me.prodNameLabel0)
        Me.tabProductDetails.Controls.Add(Me.priceTextBox0)
        Me.tabProductDetails.Controls.Add(Me.productTypeTextBox0)
        Me.tabProductDetails.Controls.Add(Me.productIdTextBox0)
        Me.tabProductDetails.Controls.Add(Me.itemTextBox0)
        Me.tabProductDetails.Controls.Add(Me.productNameTextBox0)
        Me.tabProductDetails.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tabProductDetails.Location = New System.Drawing.Point(4, 33)
        Me.tabProductDetails.Name = "tabProductDetails"
        Me.tabProductDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProductDetails.Size = New System.Drawing.Size(1245, 396)
        Me.tabProductDetails.TabIndex = 1
        Me.tabProductDetails.Text = "Product Details"
        Me.tabProductDetails.UseVisualStyleBackColor = true
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductTypeDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(458, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(781, 284)
        Me.DataGridView1.TabIndex = 4
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'ProductTypeDataGridViewTextBoxColumn
        '
        Me.ProductTypeDataGridViewTextBoxColumn.DataPropertyName = "Product Type"
        Me.ProductTypeDataGridViewTextBoxColumn.HeaderText = "Product Type"
        Me.ProductTypeDataGridViewTextBoxColumn.Name = "ProductTypeDataGridViewTextBoxColumn"
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'ProductDetailsBindingSource
        '
        Me.ProductDetailsBindingSource.DataMember = "Product Details"
        Me.ProductDetailsBindingSource.DataSource = Me.BATTERIESDataSet
        '
        'BATTERIESDataSet
        '
        Me.BATTERIESDataSet.DataSetName = "BATTERIESDataSet"
        Me.BATTERIESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'exitButton0
        '
        Me.exitButton0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.exitButton0.Location = New System.Drawing.Point(303, 296)
        Me.exitButton0.Name = "exitButton0"
        Me.exitButton0.Size = New System.Drawing.Size(149, 52)
        Me.exitButton0.TabIndex = 10
        Me.exitButton0.Text = "Exit"
        Me.exitButton0.UseVisualStyleBackColor = true
        '
        'deleteButton0
        '
        Me.deleteButton0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.deleteButton0.Location = New System.Drawing.Point(303, 238)
        Me.deleteButton0.Name = "deleteButton0"
        Me.deleteButton0.Size = New System.Drawing.Size(149, 52)
        Me.deleteButton0.TabIndex = 9
        Me.deleteButton0.Text = "Delete"
        Me.deleteButton0.UseVisualStyleBackColor = true
        '
        'nextButton0
        '
        Me.nextButton0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.nextButton0.Location = New System.Drawing.Point(303, 122)
        Me.nextButton0.Name = "nextButton0"
        Me.nextButton0.Size = New System.Drawing.Size(149, 52)
        Me.nextButton0.TabIndex = 7
        Me.nextButton0.Text = "Next query"
        Me.nextButton0.UseVisualStyleBackColor = true
        '
        'previousButton0
        '
        Me.previousButton0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.previousButton0.Location = New System.Drawing.Point(303, 180)
        Me.previousButton0.Name = "previousButton0"
        Me.previousButton0.Size = New System.Drawing.Size(149, 52)
        Me.previousButton0.TabIndex = 8
        Me.previousButton0.Text = "Previous query"
        Me.previousButton0.UseVisualStyleBackColor = true
        '
        'newButton0
        '
        Me.newButton0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.newButton0.Location = New System.Drawing.Point(303, 6)
        Me.newButton0.Name = "newButton0"
        Me.newButton0.Size = New System.Drawing.Size(149, 52)
        Me.newButton0.TabIndex = 6
        Me.newButton0.Text = "New"
        Me.newButton0.UseVisualStyleBackColor = true
        '
        'storeButton0
        '
        Me.storeButton0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.storeButton0.Location = New System.Drawing.Point(303, 64)
        Me.storeButton0.Name = "storeButton0"
        Me.storeButton0.Size = New System.Drawing.Size(149, 52)
        Me.storeButton0.TabIndex = 6
        Me.storeButton0.Text = "Store"
        Me.storeButton0.UseVisualStyleBackColor = true
        '
        'priceLabel0
        '
        Me.priceLabel0.AutoSize = true
        Me.priceLabel0.Location = New System.Drawing.Point(37, 273)
        Me.priceLabel0.Name = "priceLabel0"
        Me.priceLabel0.Size = New System.Drawing.Size(83, 17)
        Me.priceLabel0.TabIndex = 3
        Me.priceLabel0.Text = "Retail Price"
        '
        'prodTypeLabel0
        '
        Me.prodTypeLabel0.AutoSize = true
        Me.prodTypeLabel0.Location = New System.Drawing.Point(6, 157)
        Me.prodTypeLabel0.Name = "prodTypeLabel0"
        Me.prodTypeLabel0.Size = New System.Drawing.Size(94, 17)
        Me.prodTypeLabel0.TabIndex = 3
        Me.prodTypeLabel0.Text = "Product Type"
        '
        'itemLabel0
        '
        Me.itemLabel0.AutoSize = true
        Me.itemLabel0.Location = New System.Drawing.Point(6, 215)
        Me.itemLabel0.Name = "itemLabel0"
        Me.itemLabel0.Size = New System.Drawing.Size(114, 17)
        Me.itemLabel0.TabIndex = 3
        Me.itemLabel0.Text = "Item Description"
        '
        'productIdLabel0
        '
        Me.productIdLabel0.AutoSize = true
        Me.productIdLabel0.Location = New System.Drawing.Point(6, 41)
        Me.productIdLabel0.Name = "productIdLabel0"
        Me.productIdLabel0.Size = New System.Drawing.Size(77, 17)
        Me.productIdLabel0.TabIndex = 3
        Me.productIdLabel0.Text = "Product ID"
        '
        'prodNameLabel0
        '
        Me.prodNameLabel0.AutoSize = true
        Me.prodNameLabel0.Location = New System.Drawing.Point(6, 99)
        Me.prodNameLabel0.Name = "prodNameLabel0"
        Me.prodNameLabel0.Size = New System.Drawing.Size(102, 17)
        Me.prodNameLabel0.TabIndex = 3
        Me.prodNameLabel0.Text = "Product Name"
        '
        'priceTextBox0
        '
        Me.priceTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductDetailsBindingSource, "Price", true))
        Me.priceTextBox0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.priceTextBox0.Location = New System.Drawing.Point(173, 273)
        Me.priceTextBox0.Name = "priceTextBox0"
        Me.priceTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.priceTextBox0.TabIndex = 5
        '
        'productTypeTextBox0
        '
        Me.productTypeTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductDetailsBindingSource, "Product Type", true))
        Me.productTypeTextBox0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.productTypeTextBox0.Location = New System.Drawing.Point(173, 157)
        Me.productTypeTextBox0.Name = "productTypeTextBox0"
        Me.productTypeTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.productTypeTextBox0.TabIndex = 2
        '
        'productIdTextBox0
        '
        Me.productIdTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductDetailsBindingSource, "Product ID", true))
        Me.productIdTextBox0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.productIdTextBox0.Location = New System.Drawing.Point(173, 41)
        Me.productIdTextBox0.Name = "productIdTextBox0"
        Me.productIdTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.productIdTextBox0.TabIndex = 1
        '
        'itemTextBox0
        '
        Me.itemTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductDetailsBindingSource, "Item Description", true))
        Me.itemTextBox0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.itemTextBox0.Location = New System.Drawing.Point(173, 215)
        Me.itemTextBox0.Name = "itemTextBox0"
        Me.itemTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.itemTextBox0.TabIndex = 3
        '
        'productNameTextBox0
        '
        Me.productNameTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductDetailsBindingSource, "Product Name", true))
        Me.productNameTextBox0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.productNameTextBox0.Location = New System.Drawing.Point(173, 99)
        Me.productNameTextBox0.Name = "productNameTextBox0"
        Me.productNameTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.productNameTextBox0.TabIndex = 1
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.newButton1)
        Me.tabInventory.Controls.Add(Me.DataGridView2)
        Me.tabInventory.Controls.Add(Me.departureDateLabel0)
        Me.tabInventory.Controls.Add(Me.departureDateTextBox0)
        Me.tabInventory.Controls.Add(Me.inBoundLabel0)
        Me.tabInventory.Controls.Add(Me.inStockLabel0)
        Me.tabInventory.Controls.Add(Me.inBoundTextBox0)
        Me.tabInventory.Controls.Add(Me.inStockTextBox0)
        Me.tabInventory.Controls.Add(Me.outBoundLabel)
        Me.tabInventory.Controls.Add(Me.arrivalDateLabel)
        Me.tabInventory.Controls.Add(Me.outBoundTextBox)
        Me.tabInventory.Controls.Add(Me.arrivalDateTextBox)
        Me.tabInventory.Controls.Add(Me.exitButton1)
        Me.tabInventory.Controls.Add(Me.deleteButton1)
        Me.tabInventory.Controls.Add(Me.nextButton1)
        Me.tabInventory.Controls.Add(Me.previousButton1)
        Me.tabInventory.Controls.Add(Me.storeButton1)
        Me.tabInventory.Controls.Add(Me.productIdLabel1)
        Me.tabInventory.Controls.Add(Me.productIdTextBox1)
        Me.tabInventory.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tabInventory.Location = New System.Drawing.Point(4, 33)
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInventory.Size = New System.Drawing.Size(1245, 396)
        Me.tabInventory.TabIndex = 0
        Me.tabInventory.Text = "Inventory"
        Me.tabInventory.UseVisualStyleBackColor = true
        '
        'newButton1
        '
        Me.newButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.newButton1.Location = New System.Drawing.Point(303, 8)
        Me.newButton1.Name = "newButton1"
        Me.newButton1.Size = New System.Drawing.Size(149, 52)
        Me.newButton1.TabIndex = 30
        Me.newButton1.Text = "New"
        Me.newButton1.UseVisualStyleBackColor = true
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = false
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn1, Me.StockDataGridViewTextBoxColumn, Me.InboundDataGridViewTextBoxColumn, Me.ArrivalDateDataGridViewTextBoxColumn, Me.OutboundDataGridViewTextBoxColumn, Me.DepartureDateDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.InventoryBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(458, 11)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(781, 284)
        Me.DataGridView2.TabIndex = 29
        '
        'ProductIDDataGridViewTextBoxColumn1
        '
        Me.ProductIDDataGridViewTextBoxColumn1.DataPropertyName = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn1.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn1.Name = "ProductIDDataGridViewTextBoxColumn1"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'InboundDataGridViewTextBoxColumn
        '
        Me.InboundDataGridViewTextBoxColumn.DataPropertyName = "In-bound"
        Me.InboundDataGridViewTextBoxColumn.HeaderText = "In-bound"
        Me.InboundDataGridViewTextBoxColumn.Name = "InboundDataGridViewTextBoxColumn"
        '
        'ArrivalDateDataGridViewTextBoxColumn
        '
        Me.ArrivalDateDataGridViewTextBoxColumn.DataPropertyName = "Arrival date"
        Me.ArrivalDateDataGridViewTextBoxColumn.HeaderText = "Arrival date"
        Me.ArrivalDateDataGridViewTextBoxColumn.Name = "ArrivalDateDataGridViewTextBoxColumn"
        '
        'OutboundDataGridViewTextBoxColumn
        '
        Me.OutboundDataGridViewTextBoxColumn.DataPropertyName = "Out-bound"
        Me.OutboundDataGridViewTextBoxColumn.HeaderText = "Out-bound"
        Me.OutboundDataGridViewTextBoxColumn.Name = "OutboundDataGridViewTextBoxColumn"
        '
        'DepartureDateDataGridViewTextBoxColumn
        '
        Me.DepartureDateDataGridViewTextBoxColumn.DataPropertyName = "Departure date"
        Me.DepartureDateDataGridViewTextBoxColumn.HeaderText = "Departure date"
        Me.DepartureDateDataGridViewTextBoxColumn.Name = "DepartureDateDataGridViewTextBoxColumn"
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.BATTERIESDataSet
        '
        'departureDateLabel0
        '
        Me.departureDateLabel0.AutoSize = true
        Me.departureDateLabel0.Location = New System.Drawing.Point(9, 333)
        Me.departureDateLabel0.Name = "departureDateLabel0"
        Me.departureDateLabel0.Size = New System.Drawing.Size(108, 17)
        Me.departureDateLabel0.TabIndex = 28
        Me.departureDateLabel0.Text = "Departure Date"
        '
        'departureDateTextBox0
        '
        Me.departureDateTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Departure date", true))
        Me.departureDateTextBox0.Location = New System.Drawing.Point(173, 333)
        Me.departureDateTextBox0.Name = "departureDateTextBox0"
        Me.departureDateTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.departureDateTextBox0.TabIndex = 6
        '
        'inBoundLabel0
        '
        Me.inBoundLabel0.AutoSize = true
        Me.inBoundLabel0.Location = New System.Drawing.Point(9, 154)
        Me.inBoundLabel0.Name = "inBoundLabel0"
        Me.inBoundLabel0.Size = New System.Drawing.Size(66, 17)
        Me.inBoundLabel0.TabIndex = 25
        Me.inBoundLabel0.Text = "In-Bound"
        '
        'inStockLabel0
        '
        Me.inStockLabel0.AutoSize = true
        Me.inStockLabel0.Location = New System.Drawing.Point(9, 96)
        Me.inStockLabel0.Name = "inStockLabel0"
        Me.inStockLabel0.Size = New System.Drawing.Size(45, 17)
        Me.inStockLabel0.TabIndex = 26
        Me.inStockLabel0.Text = "Stock"
        '
        'inBoundTextBox0
        '
        Me.inBoundTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "In-bound", true))
        Me.inBoundTextBox0.Location = New System.Drawing.Point(173, 154)
        Me.inBoundTextBox0.Name = "inBoundTextBox0"
        Me.inBoundTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.inBoundTextBox0.TabIndex = 3
        '
        'inStockTextBox0
        '
        Me.inStockTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Stock", true))
        Me.inStockTextBox0.Location = New System.Drawing.Point(173, 96)
        Me.inStockTextBox0.Name = "inStockTextBox0"
        Me.inStockTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.inStockTextBox0.TabIndex = 2
        '
        'outBoundLabel
        '
        Me.outBoundLabel.AutoSize = true
        Me.outBoundLabel.Location = New System.Drawing.Point(9, 270)
        Me.outBoundLabel.Name = "outBoundLabel"
        Me.outBoundLabel.Size = New System.Drawing.Size(79, 17)
        Me.outBoundLabel.TabIndex = 21
        Me.outBoundLabel.Text = "Out-Bound"
        '
        'arrivalDateLabel
        '
        Me.arrivalDateLabel.AutoSize = true
        Me.arrivalDateLabel.Location = New System.Drawing.Point(9, 212)
        Me.arrivalDateLabel.Name = "arrivalDateLabel"
        Me.arrivalDateLabel.Size = New System.Drawing.Size(83, 17)
        Me.arrivalDateLabel.TabIndex = 22
        Me.arrivalDateLabel.Text = "Arrival Date"
        '
        'outBoundTextBox
        '
        Me.outBoundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Out-bound", true))
        Me.outBoundTextBox.Location = New System.Drawing.Point(173, 270)
        Me.outBoundTextBox.Name = "outBoundTextBox"
        Me.outBoundTextBox.Size = New System.Drawing.Size(124, 25)
        Me.outBoundTextBox.TabIndex = 5
        '
        'arrivalDateTextBox
        '
        Me.arrivalDateTextBox.Location = New System.Drawing.Point(173, 212)
        Me.arrivalDateTextBox.Name = "arrivalDateTextBox"
        Me.arrivalDateTextBox.Size = New System.Drawing.Size(124, 25)
        Me.arrivalDateTextBox.TabIndex = 4
        '
        'exitButton1
        '
        Me.exitButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.exitButton1.Location = New System.Drawing.Point(303, 298)
        Me.exitButton1.Name = "exitButton1"
        Me.exitButton1.Size = New System.Drawing.Size(149, 52)
        Me.exitButton1.TabIndex = 12
        Me.exitButton1.Text = "Exit"
        Me.exitButton1.UseVisualStyleBackColor = true
        '
        'deleteButton1
        '
        Me.deleteButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.deleteButton1.Location = New System.Drawing.Point(303, 240)
        Me.deleteButton1.Name = "deleteButton1"
        Me.deleteButton1.Size = New System.Drawing.Size(149, 52)
        Me.deleteButton1.TabIndex = 11
        Me.deleteButton1.Text = "Delete"
        Me.deleteButton1.UseVisualStyleBackColor = true
        '
        'nextButton1
        '
        Me.nextButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.nextButton1.Location = New System.Drawing.Point(303, 124)
        Me.nextButton1.Name = "nextButton1"
        Me.nextButton1.Size = New System.Drawing.Size(149, 52)
        Me.nextButton1.TabIndex = 9
        Me.nextButton1.Text = "Next query"
        Me.nextButton1.UseVisualStyleBackColor = true
        '
        'previousButton1
        '
        Me.previousButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.previousButton1.Location = New System.Drawing.Point(303, 182)
        Me.previousButton1.Name = "previousButton1"
        Me.previousButton1.Size = New System.Drawing.Size(149, 52)
        Me.previousButton1.TabIndex = 10
        Me.previousButton1.Text = "Previous query"
        Me.previousButton1.UseVisualStyleBackColor = true
        '
        'storeButton1
        '
        Me.storeButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.storeButton1.Location = New System.Drawing.Point(303, 66)
        Me.storeButton1.Name = "storeButton1"
        Me.storeButton1.Size = New System.Drawing.Size(149, 52)
        Me.storeButton1.TabIndex = 8
        Me.storeButton1.Text = "Store"
        Me.storeButton1.UseVisualStyleBackColor = true
        '
        'productIdLabel1
        '
        Me.productIdLabel1.AutoSize = true
        Me.productIdLabel1.Location = New System.Drawing.Point(9, 38)
        Me.productIdLabel1.Name = "productIdLabel1"
        Me.productIdLabel1.Size = New System.Drawing.Size(77, 17)
        Me.productIdLabel1.TabIndex = 10
        Me.productIdLabel1.Text = "Product ID"
        '
        'productIdTextBox1
        '
        Me.productIdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Product ID", true))
        Me.productIdTextBox1.Location = New System.Drawing.Point(173, 38)
        Me.productIdTextBox1.Name = "productIdTextBox1"
        Me.productIdTextBox1.Size = New System.Drawing.Size(124, 25)
        Me.productIdTextBox1.TabIndex = 1
        '
        'tabRestock
        '
        Me.tabRestock.Controls.Add(Me.newButton2)
        Me.tabRestock.Controls.Add(Me.DataGridView3)
        Me.tabRestock.Controls.Add(Me.exitButton2)
        Me.tabRestock.Controls.Add(Me.deleteButton2)
        Me.tabRestock.Controls.Add(Me.nextButton2)
        Me.tabRestock.Controls.Add(Me.previousButton2)
        Me.tabRestock.Controls.Add(Me.storeButton2)
        Me.tabRestock.Controls.Add(Me.unitPriceLabel)
        Me.tabRestock.Controls.Add(Me.orderIdLabel)
        Me.tabRestock.Controls.Add(Me.quantityLabel0)
        Me.tabRestock.Controls.Add(Me.productIdLabel2)
        Me.tabRestock.Controls.Add(Me.unitPriceTextBox)
        Me.tabRestock.Controls.Add(Me.orderIdTextBox)
        Me.tabRestock.Controls.Add(Me.quantityTextBox0)
        Me.tabRestock.Controls.Add(Me.TextBox1)
        Me.tabRestock.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tabRestock.Location = New System.Drawing.Point(4, 33)
        Me.tabRestock.Name = "tabRestock"
        Me.tabRestock.Size = New System.Drawing.Size(1245, 396)
        Me.tabRestock.TabIndex = 2
        Me.tabRestock.Text = "Restock"
        Me.tabRestock.UseVisualStyleBackColor = true
        '
        'newButton2
        '
        Me.newButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.newButton2.Location = New System.Drawing.Point(299, 12)
        Me.newButton2.Name = "newButton2"
        Me.newButton2.Size = New System.Drawing.Size(149, 52)
        Me.newButton2.TabIndex = 31
        Me.newButton2.Text = "New"
        Me.newButton2.UseVisualStyleBackColor = true
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = false
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn2, Me.ArrivalDateDataGridViewTextBoxColumn1, Me.QuantityDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.OrderDateDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.RestockBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(454, 12)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(788, 284)
        Me.DataGridView3.TabIndex = 13
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn2
        '
        Me.ProductIDDataGridViewTextBoxColumn2.DataPropertyName = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn2.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn2.Name = "ProductIDDataGridViewTextBoxColumn2"
        '
        'ArrivalDateDataGridViewTextBoxColumn1
        '
        Me.ArrivalDateDataGridViewTextBoxColumn1.DataPropertyName = "Arrival Date"
        Me.ArrivalDateDataGridViewTextBoxColumn1.HeaderText = "Arrival Date"
        Me.ArrivalDateDataGridViewTextBoxColumn1.Name = "ArrivalDateDataGridViewTextBoxColumn1"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "Order Date"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "Order Date"
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        '
        'RestockBindingSource
        '
        Me.RestockBindingSource.DataMember = "Restock"
        Me.RestockBindingSource.DataSource = Me.BATTERIESDataSet
        '
        'exitButton2
        '
        Me.exitButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.exitButton2.Location = New System.Drawing.Point(299, 302)
        Me.exitButton2.Name = "exitButton2"
        Me.exitButton2.Size = New System.Drawing.Size(149, 52)
        Me.exitButton2.TabIndex = 10
        Me.exitButton2.Text = "Exit"
        Me.exitButton2.UseVisualStyleBackColor = true
        '
        'deleteButton2
        '
        Me.deleteButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.deleteButton2.Location = New System.Drawing.Point(299, 244)
        Me.deleteButton2.Name = "deleteButton2"
        Me.deleteButton2.Size = New System.Drawing.Size(149, 52)
        Me.deleteButton2.TabIndex = 9
        Me.deleteButton2.Text = "Delete"
        Me.deleteButton2.UseVisualStyleBackColor = true
        '
        'nextButton2
        '
        Me.nextButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.nextButton2.Location = New System.Drawing.Point(299, 128)
        Me.nextButton2.Name = "nextButton2"
        Me.nextButton2.Size = New System.Drawing.Size(149, 52)
        Me.nextButton2.TabIndex = 7
        Me.nextButton2.Text = "Next query"
        Me.nextButton2.UseVisualStyleBackColor = true
        '
        'previousButton2
        '
        Me.previousButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.previousButton2.Location = New System.Drawing.Point(299, 186)
        Me.previousButton2.Name = "previousButton2"
        Me.previousButton2.Size = New System.Drawing.Size(149, 52)
        Me.previousButton2.TabIndex = 8
        Me.previousButton2.Text = "Previous query"
        Me.previousButton2.UseVisualStyleBackColor = true
        '
        'storeButton2
        '
        Me.storeButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.storeButton2.Location = New System.Drawing.Point(299, 70)
        Me.storeButton2.Name = "storeButton2"
        Me.storeButton2.Size = New System.Drawing.Size(149, 52)
        Me.storeButton2.TabIndex = 6
        Me.storeButton2.Text = "Store"
        Me.storeButton2.UseVisualStyleBackColor = true
        '
        'unitPriceLabel
        '
        Me.unitPriceLabel.AutoSize = true
        Me.unitPriceLabel.Location = New System.Drawing.Point(3, 213)
        Me.unitPriceLabel.Name = "unitPriceLabel"
        Me.unitPriceLabel.Size = New System.Drawing.Size(71, 17)
        Me.unitPriceLabel.TabIndex = 9
        Me.unitPriceLabel.Text = "Unit Price"
        '
        'orderIdLabel
        '
        Me.orderIdLabel.AutoSize = true
        Me.orderIdLabel.Location = New System.Drawing.Point(3, 39)
        Me.orderIdLabel.Name = "orderIdLabel"
        Me.orderIdLabel.Size = New System.Drawing.Size(64, 17)
        Me.orderIdLabel.TabIndex = 10
        Me.orderIdLabel.Text = "Order ID"
        '
        'quantityLabel0
        '
        Me.quantityLabel0.AutoSize = true
        Me.quantityLabel0.Location = New System.Drawing.Point(3, 155)
        Me.quantityLabel0.Name = "quantityLabel0"
        Me.quantityLabel0.Size = New System.Drawing.Size(104, 17)
        Me.quantityLabel0.TabIndex = 11
        Me.quantityLabel0.Text = "Order Quantity"
        '
        'productIdLabel2
        '
        Me.productIdLabel2.AutoSize = true
        Me.productIdLabel2.Location = New System.Drawing.Point(3, 97)
        Me.productIdLabel2.Name = "productIdLabel2"
        Me.productIdLabel2.Size = New System.Drawing.Size(77, 17)
        Me.productIdLabel2.TabIndex = 12
        Me.productIdLabel2.Text = "Product ID"
        '
        'unitPriceTextBox
        '
        Me.unitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestockBindingSource, "Unit Price", true))
        Me.unitPriceTextBox.Location = New System.Drawing.Point(155, 213)
        Me.unitPriceTextBox.Name = "unitPriceTextBox"
        Me.unitPriceTextBox.Size = New System.Drawing.Size(124, 25)
        Me.unitPriceTextBox.TabIndex = 4
        '
        'orderIdTextBox
        '
        Me.orderIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestockBindingSource, "Order ID", true))
        Me.orderIdTextBox.Location = New System.Drawing.Point(155, 39)
        Me.orderIdTextBox.Name = "orderIdTextBox"
        Me.orderIdTextBox.Size = New System.Drawing.Size(124, 25)
        Me.orderIdTextBox.TabIndex = 1
        '
        'quantityTextBox0
        '
        Me.quantityTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestockBindingSource, "Quantity", true))
        Me.quantityTextBox0.Location = New System.Drawing.Point(155, 155)
        Me.quantityTextBox0.Name = "quantityTextBox0"
        Me.quantityTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.quantityTextBox0.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestockBindingSource, "Product ID", true))
        Me.TextBox1.Location = New System.Drawing.Point(155, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 25)
        Me.TextBox1.TabIndex = 0
        '
        'tabCustomerOrder
        '
        Me.tabCustomerOrder.Controls.Add(Me.newButton3)
        Me.tabCustomerOrder.Controls.Add(Me.DataGridView4)
        Me.tabCustomerOrder.Controls.Add(Me.exitButton3)
        Me.tabCustomerOrder.Controls.Add(Me.deleteButton3)
        Me.tabCustomerOrder.Controls.Add(Me.nextButton3)
        Me.tabCustomerOrder.Controls.Add(Me.previousButton3)
        Me.tabCustomerOrder.Controls.Add(Me.storeButton3)
        Me.tabCustomerOrder.Controls.Add(Me.customerIdLabel2)
        Me.tabCustomerOrder.Controls.Add(Me.orderIdLabel2)
        Me.tabCustomerOrder.Controls.Add(Me.quantityLabel1)
        Me.tabCustomerOrder.Controls.Add(Me.customerNameLabel0)
        Me.tabCustomerOrder.Controls.Add(Me.customerIdTextBox0)
        Me.tabCustomerOrder.Controls.Add(Me.orderId1TextBox)
        Me.tabCustomerOrder.Controls.Add(Me.quantityTextBox1)
        Me.tabCustomerOrder.Controls.Add(Me.customerNameTextBox0)
        Me.tabCustomerOrder.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tabCustomerOrder.Location = New System.Drawing.Point(4, 33)
        Me.tabCustomerOrder.Name = "tabCustomerOrder"
        Me.tabCustomerOrder.Size = New System.Drawing.Size(1245, 396)
        Me.tabCustomerOrder.TabIndex = 4
        Me.tabCustomerOrder.Text = "Customer Order"
        Me.tabCustomerOrder.UseVisualStyleBackColor = true
        '
        'newButton3
        '
        Me.newButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.newButton3.Location = New System.Drawing.Point(318, 38)
        Me.newButton3.Name = "newButton3"
        Me.newButton3.Size = New System.Drawing.Size(149, 52)
        Me.newButton3.TabIndex = 32
        Me.newButton3.Text = "New"
        Me.newButton3.UseVisualStyleBackColor = true
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = false
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn1, Me.ProductIDDataGridViewTextBoxColumn3, Me.CustomerNameDataGridViewTextBoxColumn, Me.OrderQuantityDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.CustomerOrderBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(472, 11)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(770, 284)
        Me.DataGridView4.TabIndex = 13
        '
        'OrderIDDataGridViewTextBoxColumn1
        '
        Me.OrderIDDataGridViewTextBoxColumn1.DataPropertyName = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn1.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn1.Name = "OrderIDDataGridViewTextBoxColumn1"
        '
        'ProductIDDataGridViewTextBoxColumn3
        '
        Me.ProductIDDataGridViewTextBoxColumn3.DataPropertyName = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn3.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn3.Name = "ProductIDDataGridViewTextBoxColumn3"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'OrderQuantityDataGridViewTextBoxColumn
        '
        Me.OrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "Order Quantity"
        Me.OrderQuantityDataGridViewTextBoxColumn.HeaderText = "Order Quantity"
        Me.OrderQuantityDataGridViewTextBoxColumn.Name = "OrderQuantityDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CustomerOrderBindingSource
        '
        Me.CustomerOrderBindingSource.DataMember = "Customer Order"
        Me.CustomerOrderBindingSource.DataSource = Me.BATTERIESDataSet
        '
        'exitButton3
        '
        Me.exitButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.exitButton3.Location = New System.Drawing.Point(318, 325)
        Me.exitButton3.Name = "exitButton3"
        Me.exitButton3.Size = New System.Drawing.Size(149, 52)
        Me.exitButton3.TabIndex = 9
        Me.exitButton3.Text = "Exit"
        Me.exitButton3.UseVisualStyleBackColor = true
        '
        'deleteButton3
        '
        Me.deleteButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.deleteButton3.Location = New System.Drawing.Point(318, 267)
        Me.deleteButton3.Name = "deleteButton3"
        Me.deleteButton3.Size = New System.Drawing.Size(149, 52)
        Me.deleteButton3.TabIndex = 8
        Me.deleteButton3.Text = "Delete"
        Me.deleteButton3.UseVisualStyleBackColor = true
        '
        'nextButton3
        '
        Me.nextButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.nextButton3.Location = New System.Drawing.Point(318, 151)
        Me.nextButton3.Name = "nextButton3"
        Me.nextButton3.Size = New System.Drawing.Size(149, 52)
        Me.nextButton3.TabIndex = 6
        Me.nextButton3.Text = "Next query"
        Me.nextButton3.UseVisualStyleBackColor = true
        '
        'previousButton3
        '
        Me.previousButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.previousButton3.Location = New System.Drawing.Point(318, 209)
        Me.previousButton3.Name = "previousButton3"
        Me.previousButton3.Size = New System.Drawing.Size(149, 52)
        Me.previousButton3.TabIndex = 7
        Me.previousButton3.Text = "Previous query"
        Me.previousButton3.UseVisualStyleBackColor = true
        '
        'storeButton3
        '
        Me.storeButton3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.storeButton3.Location = New System.Drawing.Point(318, 93)
        Me.storeButton3.Name = "storeButton3"
        Me.storeButton3.Size = New System.Drawing.Size(149, 52)
        Me.storeButton3.TabIndex = 5
        Me.storeButton3.Text = "Store"
        Me.storeButton3.UseVisualStyleBackColor = true
        '
        'customerIdLabel2
        '
        Me.customerIdLabel2.AutoSize = true
        Me.customerIdLabel2.Location = New System.Drawing.Point(3, 96)
        Me.customerIdLabel2.Name = "customerIdLabel2"
        Me.customerIdLabel2.Size = New System.Drawing.Size(91, 17)
        Me.customerIdLabel2.TabIndex = 9
        Me.customerIdLabel2.Text = "Customer ID"
        '
        'orderIdLabel2
        '
        Me.orderIdLabel2.AutoSize = true
        Me.orderIdLabel2.Location = New System.Drawing.Point(3, 38)
        Me.orderIdLabel2.Name = "orderIdLabel2"
        Me.orderIdLabel2.Size = New System.Drawing.Size(64, 17)
        Me.orderIdLabel2.TabIndex = 10
        Me.orderIdLabel2.Text = "Order ID"
        '
        'quantityLabel1
        '
        Me.quantityLabel1.AutoSize = true
        Me.quantityLabel1.Location = New System.Drawing.Point(3, 155)
        Me.quantityLabel1.Name = "quantityLabel1"
        Me.quantityLabel1.Size = New System.Drawing.Size(104, 17)
        Me.quantityLabel1.TabIndex = 11
        Me.quantityLabel1.Text = "Order Quantity"
        '
        'customerNameLabel0
        '
        Me.customerNameLabel0.AutoSize = true
        Me.customerNameLabel0.Location = New System.Drawing.Point(3, 212)
        Me.customerNameLabel0.Name = "customerNameLabel0"
        Me.customerNameLabel0.Size = New System.Drawing.Size(116, 17)
        Me.customerNameLabel0.TabIndex = 12
        Me.customerNameLabel0.Text = "Customer Name"
        '
        'customerIdTextBox0
        '
        Me.customerIdTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Customer ID", true))
        Me.customerIdTextBox0.Location = New System.Drawing.Point(187, 96)
        Me.customerIdTextBox0.Name = "customerIdTextBox0"
        Me.customerIdTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.customerIdTextBox0.TabIndex = 3
        '
        'orderId1TextBox
        '
        Me.orderId1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Order ID", true))
        Me.orderId1TextBox.Location = New System.Drawing.Point(187, 38)
        Me.orderId1TextBox.Name = "orderId1TextBox"
        Me.orderId1TextBox.Size = New System.Drawing.Size(124, 25)
        Me.orderId1TextBox.TabIndex = 1
        '
        'quantityTextBox1
        '
        Me.quantityTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Order Quantity", true))
        Me.quantityTextBox1.Location = New System.Drawing.Point(187, 155)
        Me.quantityTextBox1.Name = "quantityTextBox1"
        Me.quantityTextBox1.Size = New System.Drawing.Size(124, 25)
        Me.quantityTextBox1.TabIndex = 2
        '
        'customerNameTextBox0
        '
        Me.customerNameTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Customer Name", true))
        Me.customerNameTextBox0.Location = New System.Drawing.Point(187, 212)
        Me.customerNameTextBox0.Name = "customerNameTextBox0"
        Me.customerNameTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.customerNameTextBox0.TabIndex = 0
        '
        'tabCustomerInformation
        '
        Me.tabCustomerInformation.Controls.Add(Me.newButton4)
        Me.tabCustomerInformation.Controls.Add(Me.DataGridView5)
        Me.tabCustomerInformation.Controls.Add(Me.exitButton4)
        Me.tabCustomerInformation.Controls.Add(Me.deleteButton4)
        Me.tabCustomerInformation.Controls.Add(Me.nextButton4)
        Me.tabCustomerInformation.Controls.Add(Me.previousButton4)
        Me.tabCustomerInformation.Controls.Add(Me.storeButton4)
        Me.tabCustomerInformation.Controls.Add(Me.stateLabel0)
        Me.tabCustomerInformation.Controls.Add(Me.cityLabel0)
        Me.tabCustomerInformation.Controls.Add(Me.addressLabel0)
        Me.tabCustomerInformation.Controls.Add(Me.customerContactLabel0)
        Me.tabCustomerInformation.Controls.Add(Me.phoneLabel0)
        Me.tabCustomerInformation.Controls.Add(Me.customerNameLabel1)
        Me.tabCustomerInformation.Controls.Add(Me.stateTextBox0)
        Me.tabCustomerInformation.Controls.Add(Me.cityTextBox0)
        Me.tabCustomerInformation.Controls.Add(Me.addressTextBox0)
        Me.tabCustomerInformation.Controls.Add(Me.customerContactTextBox0)
        Me.tabCustomerInformation.Controls.Add(Me.phoneTextBox0)
        Me.tabCustomerInformation.Controls.Add(Me.customerNameTextBox1)
        Me.tabCustomerInformation.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tabCustomerInformation.Location = New System.Drawing.Point(4, 33)
        Me.tabCustomerInformation.Name = "tabCustomerInformation"
        Me.tabCustomerInformation.Size = New System.Drawing.Size(1245, 396)
        Me.tabCustomerInformation.TabIndex = 5
        Me.tabCustomerInformation.Text = "Customer Information"
        Me.tabCustomerInformation.UseVisualStyleBackColor = true
        '
        'newButton4
        '
        Me.newButton4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.newButton4.Location = New System.Drawing.Point(341, 5)
        Me.newButton4.Name = "newButton4"
        Me.newButton4.Size = New System.Drawing.Size(149, 52)
        Me.newButton4.TabIndex = 32
        Me.newButton4.Text = "New"
        Me.newButton4.UseVisualStyleBackColor = true
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = false
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn1, Me.CustomerNameDataGridViewTextBoxColumn1, Me.CompanyContactDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.CustomerInformationBindingSource
        Me.DataGridView5.Location = New System.Drawing.Point(492, 13)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(750, 284)
        Me.DataGridView5.TabIndex = 30
        '
        'CustomerIDDataGridViewTextBoxColumn1
        '
        Me.CustomerIDDataGridViewTextBoxColumn1.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.Name = "CustomerIDDataGridViewTextBoxColumn1"
        '
        'CustomerNameDataGridViewTextBoxColumn1
        '
        Me.CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn1.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1"
        '
        'CompanyContactDataGridViewTextBoxColumn
        '
        Me.CompanyContactDataGridViewTextBoxColumn.DataPropertyName = "Company Contact"
        Me.CompanyContactDataGridViewTextBoxColumn.HeaderText = "Company Contact"
        Me.CompanyContactDataGridViewTextBoxColumn.Name = "CompanyContactDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'CustomerInformationBindingSource
        '
        Me.CustomerInformationBindingSource.DataMember = "Customer Information"
        Me.CustomerInformationBindingSource.DataSource = Me.BATTERIESDataSet
        '
        'exitButton4
        '
        Me.exitButton4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.exitButton4.Location = New System.Drawing.Point(341, 295)
        Me.exitButton4.Name = "exitButton4"
        Me.exitButton4.Size = New System.Drawing.Size(149, 52)
        Me.exitButton4.TabIndex = 25
        Me.exitButton4.Text = "Exit"
        Me.exitButton4.UseVisualStyleBackColor = true
        '
        'deleteButton4
        '
        Me.deleteButton4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.deleteButton4.Location = New System.Drawing.Point(341, 237)
        Me.deleteButton4.Name = "deleteButton4"
        Me.deleteButton4.Size = New System.Drawing.Size(149, 52)
        Me.deleteButton4.TabIndex = 26
        Me.deleteButton4.Text = "Delete"
        Me.deleteButton4.UseVisualStyleBackColor = true
        '
        'nextButton4
        '
        Me.nextButton4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.nextButton4.Location = New System.Drawing.Point(341, 121)
        Me.nextButton4.Name = "nextButton4"
        Me.nextButton4.Size = New System.Drawing.Size(149, 52)
        Me.nextButton4.TabIndex = 27
        Me.nextButton4.Text = "Next query"
        Me.nextButton4.UseVisualStyleBackColor = true
        '
        'previousButton4
        '
        Me.previousButton4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.previousButton4.Location = New System.Drawing.Point(341, 179)
        Me.previousButton4.Name = "previousButton4"
        Me.previousButton4.Size = New System.Drawing.Size(149, 52)
        Me.previousButton4.TabIndex = 28
        Me.previousButton4.Text = "Previous query"
        Me.previousButton4.UseVisualStyleBackColor = true
        '
        'storeButton4
        '
        Me.storeButton4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.storeButton4.Location = New System.Drawing.Point(341, 63)
        Me.storeButton4.Name = "storeButton4"
        Me.storeButton4.Size = New System.Drawing.Size(149, 52)
        Me.storeButton4.TabIndex = 29
        Me.storeButton4.Text = "Store"
        Me.storeButton4.UseVisualStyleBackColor = true
        '
        'stateLabel0
        '
        Me.stateLabel0.AutoSize = true
        Me.stateLabel0.Location = New System.Drawing.Point(47, 330)
        Me.stateLabel0.Name = "stateLabel0"
        Me.stateLabel0.Size = New System.Drawing.Size(42, 17)
        Me.stateLabel0.TabIndex = 9
        Me.stateLabel0.Text = "State"
        '
        'cityLabel0
        '
        Me.cityLabel0.AutoSize = true
        Me.cityLabel0.Location = New System.Drawing.Point(47, 272)
        Me.cityLabel0.Name = "cityLabel0"
        Me.cityLabel0.Size = New System.Drawing.Size(33, 17)
        Me.cityLabel0.TabIndex = 9
        Me.cityLabel0.Text = "City"
        '
        'addressLabel0
        '
        Me.addressLabel0.AutoSize = true
        Me.addressLabel0.Location = New System.Drawing.Point(47, 214)
        Me.addressLabel0.Name = "addressLabel0"
        Me.addressLabel0.Size = New System.Drawing.Size(62, 17)
        Me.addressLabel0.TabIndex = 9
        Me.addressLabel0.Text = "Address"
        '
        'customerContactLabel0
        '
        Me.customerContactLabel0.AutoSize = true
        Me.customerContactLabel0.Location = New System.Drawing.Point(3, 98)
        Me.customerContactLabel0.Name = "customerContactLabel0"
        Me.customerContactLabel0.Size = New System.Drawing.Size(126, 17)
        Me.customerContactLabel0.TabIndex = 10
        Me.customerContactLabel0.Text = "Company Contact"
        '
        'phoneLabel0
        '
        Me.phoneLabel0.AutoSize = true
        Me.phoneLabel0.Location = New System.Drawing.Point(3, 156)
        Me.phoneLabel0.Name = "phoneLabel0"
        Me.phoneLabel0.Size = New System.Drawing.Size(106, 17)
        Me.phoneLabel0.TabIndex = 11
        Me.phoneLabel0.Text = "Phone Number"
        '
        'customerNameLabel1
        '
        Me.customerNameLabel1.AutoSize = true
        Me.customerNameLabel1.Location = New System.Drawing.Point(3, 40)
        Me.customerNameLabel1.Name = "customerNameLabel1"
        Me.customerNameLabel1.Size = New System.Drawing.Size(116, 17)
        Me.customerNameLabel1.TabIndex = 12
        Me.customerNameLabel1.Text = "Customer Name"
        '
        'stateTextBox0
        '
        Me.stateTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInformationBindingSource, "State", true))
        Me.stateTextBox0.Location = New System.Drawing.Point(211, 330)
        Me.stateTextBox0.Name = "stateTextBox0"
        Me.stateTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.stateTextBox0.TabIndex = 5
        '
        'cityTextBox0
        '
        Me.cityTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInformationBindingSource, "City", true))
        Me.cityTextBox0.Location = New System.Drawing.Point(209, 272)
        Me.cityTextBox0.Name = "cityTextBox0"
        Me.cityTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.cityTextBox0.TabIndex = 5
        '
        'addressTextBox0
        '
        Me.addressTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInformationBindingSource, "Address", true))
        Me.addressTextBox0.Location = New System.Drawing.Point(209, 214)
        Me.addressTextBox0.Name = "addressTextBox0"
        Me.addressTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.addressTextBox0.TabIndex = 5
        '
        'customerContactTextBox0
        '
        Me.customerContactTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInformationBindingSource, "Company Contact", true))
        Me.customerContactTextBox0.Location = New System.Drawing.Point(209, 98)
        Me.customerContactTextBox0.Name = "customerContactTextBox0"
        Me.customerContactTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.customerContactTextBox0.TabIndex = 6
        '
        'phoneTextBox0
        '
        Me.phoneTextBox0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInformationBindingSource, "Phone Number", true))
        Me.phoneTextBox0.Location = New System.Drawing.Point(209, 156)
        Me.phoneTextBox0.Name = "phoneTextBox0"
        Me.phoneTextBox0.Size = New System.Drawing.Size(124, 25)
        Me.phoneTextBox0.TabIndex = 7
        '
        'customerNameTextBox1
        '
        Me.customerNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInformationBindingSource, "Customer Name", true))
        Me.customerNameTextBox1.Location = New System.Drawing.Point(208, 40)
        Me.customerNameTextBox1.Name = "customerNameTextBox1"
        Me.customerNameTextBox1.Size = New System.Drawing.Size(124, 25)
        Me.customerNameTextBox1.TabIndex = 8
        '
        'Product_DetailsTableAdapter
        '
        Me.Product_DetailsTableAdapter.ClearBeforeFill = true
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = true
        '
        'RestockTableAdapter
        '
        Me.RestockTableAdapter.ClearBeforeFill = true
        '
        'Customer_OrderTableAdapter
        '
        Me.Customer_OrderTableAdapter.ClearBeforeFill = true
        '
        'Customer_InformationTableAdapter
        '
        Me.Customer_InformationTableAdapter.ClearBeforeFill = true
        '
        'loginGroupBox
        '
        Me.loginGroupBox.BackgroundImage = Global.InventoryManagementSystem.My.Resources.Resources.thumbnail_Track_Inventory_WhiteRack_0
        Me.loginGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.loginGroupBox.Controls.Add(Me.usernameTextBox)
        Me.loginGroupBox.Controls.Add(Me.passwordTextBox)
        Me.loginGroupBox.Controls.Add(Me.clearButton)
        Me.loginGroupBox.Controls.Add(Me.cnclButton)
        Me.loginGroupBox.Controls.Add(Me.loginButton)
        Me.loginGroupBox.Controls.Add(Me.passwordLabel)
        Me.loginGroupBox.Controls.Add(Me.usernameLabel)
        Me.loginGroupBox.Controls.Add(Me.titleLabel)
        Me.loginGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loginGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.loginGroupBox.Name = "loginGroupBox"
        Me.loginGroupBox.Size = New System.Drawing.Size(1365, 753)
        Me.loginGroupBox.TabIndex = 3
        Me.loginGroupBox.TabStop = false
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(131, 254)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(165, 20)
        Me.usernameTextBox.TabIndex = 3
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(131, 320)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(165, 20)
        Me.passwordTextBox.TabIndex = 3
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.clearButton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.clearButton.ForeColor = System.Drawing.SystemColors.Control
        Me.clearButton.Location = New System.Drawing.Point(221, 436)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = false
        '
        'cnclButton
        '
        Me.cnclButton.BackColor = System.Drawing.Color.Firebrick
        Me.cnclButton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cnclButton.ForeColor = System.Drawing.SystemColors.Control
        Me.cnclButton.Location = New System.Drawing.Point(131, 494)
        Me.cnclButton.Name = "cnclButton"
        Me.cnclButton.Size = New System.Drawing.Size(75, 23)
        Me.cnclButton.TabIndex = 2
        Me.cnclButton.Text = "Exit"
        Me.cnclButton.UseVisualStyleBackColor = false
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.loginButton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.loginButton.ForeColor = System.Drawing.SystemColors.Control
        Me.loginButton.Location = New System.Drawing.Point(33, 436)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 23)
        Me.loginButton.TabIndex = 1
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = false
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = true
        Me.passwordLabel.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.passwordLabel.Location = New System.Drawing.Point(30, 320)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(56, 14)
        Me.passwordLabel.TabIndex = 0
        Me.passwordLabel.Text = "Password"
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = true
        Me.usernameLabel.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.usernameLabel.Location = New System.Drawing.Point(30, 257)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(57, 14)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "Username"
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = true
        Me.titleLabel.Font = New System.Drawing.Font("Xirod", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.titleLabel.Location = New System.Drawing.Point(473, 16)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(327, 45)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "INVENTOR"
        '
        'loginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.ClientSize = New System.Drawing.Size(1362, 561)
        Me.Controls.Add(Me.loginGroupBox)
        Me.Controls.Add(Me.tabControls)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "loginPage"
        Me.Text = "Inventor"
        Me.tabControls.ResumeLayout(false)
        Me.tabProductDetails.ResumeLayout(false)
        Me.tabProductDetails.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProductDetailsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BATTERIESDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabInventory.ResumeLayout(false)
        Me.tabInventory.PerformLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.InventoryBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabRestock.ResumeLayout(false)
        Me.tabRestock.PerformLayout
        CType(Me.DataGridView3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RestockBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabCustomerOrder.ResumeLayout(false)
        Me.tabCustomerOrder.PerformLayout
        CType(Me.DataGridView4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CustomerOrderBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabCustomerInformation.ResumeLayout(false)
        Me.tabCustomerInformation.PerformLayout
        CType(Me.DataGridView5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CustomerInformationBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.loginGroupBox.ResumeLayout(false)
        Me.loginGroupBox.PerformLayout
        Me.ResumeLayout(false)

End Sub
   Friend WithEvents tabControls As System.Windows.Forms.TabControl
   Friend WithEvents tabProductDetails As System.Windows.Forms.TabPage
   Friend WithEvents tabInventory As System.Windows.Forms.TabPage
   Friend WithEvents tabRestock As System.Windows.Forms.TabPage
   Friend WithEvents tabCustomerOrder As System.Windows.Forms.TabPage
   Friend WithEvents tabCustomerInformation As System.Windows.Forms.TabPage
   Friend WithEvents priceLabel0 As System.Windows.Forms.Label
   Friend WithEvents prodTypeLabel0 As System.Windows.Forms.Label
   Friend WithEvents itemLabel0 As System.Windows.Forms.Label
   Friend WithEvents prodNameLabel0 As System.Windows.Forms.Label
   Friend WithEvents priceTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents productTypeTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents itemTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents productNameTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents exitButton0 As System.Windows.Forms.Button
   Friend WithEvents deleteButton0 As System.Windows.Forms.Button
   Friend WithEvents nextButton0 As System.Windows.Forms.Button
   Friend WithEvents previousButton0 As System.Windows.Forms.Button
   Friend WithEvents storeButton0 As System.Windows.Forms.Button
   Friend WithEvents exitButton2 As System.Windows.Forms.Button
   Friend WithEvents deleteButton2 As System.Windows.Forms.Button
   Friend WithEvents nextButton2 As System.Windows.Forms.Button
   Friend WithEvents previousButton2 As System.Windows.Forms.Button
   Friend WithEvents storeButton2 As System.Windows.Forms.Button
   Friend WithEvents unitPriceLabel As System.Windows.Forms.Label
   Friend WithEvents orderIdLabel As System.Windows.Forms.Label
   Friend WithEvents quantityLabel0 As System.Windows.Forms.Label
   Friend WithEvents unitPriceTextBox As System.Windows.Forms.TextBox
   Friend WithEvents orderIdTextBox As System.Windows.Forms.TextBox
   Friend WithEvents quantityTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents customerIdLabel2 As System.Windows.Forms.Label
   Friend WithEvents orderIdLabel2 As System.Windows.Forms.Label
   Friend WithEvents quantityLabel1 As System.Windows.Forms.Label
   Friend WithEvents customerNameLabel0 As System.Windows.Forms.Label
   Friend WithEvents customerIdTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents orderId1TextBox As System.Windows.Forms.TextBox
   Friend WithEvents quantityTextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents customerNameTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents stateLabel0 As System.Windows.Forms.Label
   Friend WithEvents cityLabel0 As System.Windows.Forms.Label
   Friend WithEvents addressLabel0 As System.Windows.Forms.Label
   Friend WithEvents customerContactLabel0 As System.Windows.Forms.Label
   Friend WithEvents phoneLabel0 As System.Windows.Forms.Label
   Friend WithEvents customerNameLabel1 As System.Windows.Forms.Label
   Friend WithEvents stateTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents cityTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents addressTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents customerContactTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents phoneTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents customerNameTextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents loginGroupBox As System.Windows.Forms.GroupBox
   Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
   Friend WithEvents clearButton As System.Windows.Forms.Button
   Friend WithEvents cnclButton As System.Windows.Forms.Button
   Friend WithEvents loginButton As System.Windows.Forms.Button
   Friend WithEvents passwordLabel As System.Windows.Forms.Label
   Friend WithEvents usernameLabel As System.Windows.Forms.Label
   Friend WithEvents titleLabel As System.Windows.Forms.Label
   Friend WithEvents inBoundLabel0 As System.Windows.Forms.Label
   Friend WithEvents inStockLabel0 As System.Windows.Forms.Label
   Friend WithEvents inBoundTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents inStockTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents outBoundLabel As System.Windows.Forms.Label
   Friend WithEvents arrivalDateLabel As System.Windows.Forms.Label
   Friend WithEvents outBoundTextBox As System.Windows.Forms.TextBox
   Friend WithEvents arrivalDateTextBox As System.Windows.Forms.TextBox
   Friend WithEvents exitButton1 As System.Windows.Forms.Button
   Friend WithEvents deleteButton1 As System.Windows.Forms.Button
   Friend WithEvents nextButton1 As System.Windows.Forms.Button
   Friend WithEvents previousButton1 As System.Windows.Forms.Button
   Friend WithEvents storeButton1 As System.Windows.Forms.Button
   Friend WithEvents productIdLabel1 As System.Windows.Forms.Label
   Friend WithEvents productIdTextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents departureDateLabel0 As System.Windows.Forms.Label
   Friend WithEvents departureDateTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents exitButton3 As System.Windows.Forms.Button
   Friend WithEvents deleteButton3 As System.Windows.Forms.Button
   Friend WithEvents nextButton3 As System.Windows.Forms.Button
   Friend WithEvents previousButton3 As System.Windows.Forms.Button
   Friend WithEvents storeButton3 As System.Windows.Forms.Button
   Friend WithEvents exitButton4 As System.Windows.Forms.Button
   Friend WithEvents deleteButton4 As System.Windows.Forms.Button
   Friend WithEvents nextButton4 As System.Windows.Forms.Button
   Friend WithEvents previousButton4 As System.Windows.Forms.Button
   Friend WithEvents storeButton4 As System.Windows.Forms.Button
   Friend WithEvents productIdLabel0 As System.Windows.Forms.Label
   Friend WithEvents productIdTextBox0 As System.Windows.Forms.TextBox
   Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
   Friend WithEvents BATTERIESDataSet As InventoryManagementSystem.BATTERIESDataSet
   Friend WithEvents ProductDetailsBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents Product_DetailsTableAdapter As InventoryManagementSystem.BATTERIESDataSetTableAdapters.Product_DetailsTableAdapter
   Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
   Friend WithEvents InventoryBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents InventoryTableAdapter As InventoryManagementSystem.BATTERIESDataSetTableAdapters.InventoryTableAdapter
   Friend WithEvents productIdLabel2 As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
   Friend WithEvents RestockBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents RestockTableAdapter As InventoryManagementSystem.BATTERIESDataSetTableAdapters.RestockTableAdapter
   Friend WithEvents OrderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ArrivalDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents OrderDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
   Friend WithEvents CustomerOrderBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents Customer_OrderTableAdapter As InventoryManagementSystem.BATTERIESDataSetTableAdapters.Customer_OrderTableAdapter
   Friend WithEvents OrderIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductIDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents OrderQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
   Friend WithEvents CustomerInformationBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents Customer_InformationTableAdapter As InventoryManagementSystem.BATTERIESDataSetTableAdapters.Customer_InformationTableAdapter
   Friend WithEvents CustomerIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CustomerNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CompanyContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents newButton0 As System.Windows.Forms.Button
   Friend WithEvents newButton1 As System.Windows.Forms.Button
   Friend WithEvents newButton2 As System.Windows.Forms.Button
   Friend WithEvents newButton3 As System.Windows.Forms.Button
   Friend WithEvents newButton4 As System.Windows.Forms.Button
   Friend WithEvents ProductIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents InboundDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ArrivalDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents OutboundDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DepartureDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn


End Class
