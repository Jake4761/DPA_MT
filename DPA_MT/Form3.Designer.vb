<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAmend = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.lblReorderLevel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblQuantityInStock = New System.Windows.Forms.Label()
        Me.lblReorderQuantity = New System.Windows.Forms.Label()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.txtReorderQuantity = New System.Windows.Forms.TextBox()
        Me.lblAllSuppliers = New System.Windows.Forms.Label()
        Me.lblSuppliersItem = New System.Windows.Forms.Label()
        Me.cboSuppAll = New System.Windows.Forms.ComboBox()
        Me.cboSuppItem = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 498)
        Me.ListBox1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(426, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAmend
        '
        Me.btnAmend.Location = New System.Drawing.Point(426, 41)
        Me.btnAmend.Name = "btnAmend"
        Me.btnAmend.Size = New System.Drawing.Size(111, 23)
        Me.btnAmend.TabIndex = 2
        Me.btnAmend.Text = "Amend"
        Me.btnAmend.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(426, 70)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(426, 113)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(111, 23)
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(426, 142)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblStockID
        '
        Me.lblStockID.AutoSize = True
        Me.lblStockID.Location = New System.Drawing.Point(174, 12)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(46, 13)
        Me.lblStockID.TabIndex = 6
        Me.lblStockID.Text = "StockID"
        '
        'lblReorderLevel
        '
        Me.lblReorderLevel.AutoSize = True
        Me.lblReorderLevel.Location = New System.Drawing.Point(321, 13)
        Me.lblReorderLevel.Name = "lblReorderLevel"
        Me.lblReorderLevel.Size = New System.Drawing.Size(74, 13)
        Me.lblReorderLevel.TabIndex = 7
        Me.lblReorderLevel.Text = "Reorder Level"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(174, 44)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price"
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(226, 10)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(59, 20)
        Me.txtStockID.TabIndex = 9
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(226, 41)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(55, 20)
        Me.txtPrice.TabIndex = 10
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.Location = New System.Drawing.Point(324, 37)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(86, 20)
        Me.txtReorderLevel.TabIndex = 11
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(174, 80)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 12
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(174, 96)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(236, 20)
        Me.txtDescription.TabIndex = 13
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.Location = New System.Drawing.Point(174, 132)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantityInStock.TabIndex = 14
        Me.lblQuantityInStock.Text = "Quantity In Stock"
        '
        'lblReorderQuantity
        '
        Me.lblReorderQuantity.AutoSize = True
        Me.lblReorderQuantity.Location = New System.Drawing.Point(314, 132)
        Me.lblReorderQuantity.Name = "lblReorderQuantity"
        Me.lblReorderQuantity.Size = New System.Drawing.Size(87, 13)
        Me.lblReorderQuantity.TabIndex = 15
        Me.lblReorderQuantity.Text = "Reorder Quantity"
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(174, 148)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityInStock.TabIndex = 16
        '
        'txtReorderQuantity
        '
        Me.txtReorderQuantity.Location = New System.Drawing.Point(310, 148)
        Me.txtReorderQuantity.Name = "txtReorderQuantity"
        Me.txtReorderQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderQuantity.TabIndex = 17
        '
        'lblAllSuppliers
        '
        Me.lblAllSuppliers.AutoSize = True
        Me.lblAllSuppliers.Location = New System.Drawing.Point(174, 236)
        Me.lblAllSuppliers.Name = "lblAllSuppliers"
        Me.lblAllSuppliers.Size = New System.Drawing.Size(64, 13)
        Me.lblAllSuppliers.TabIndex = 19
        Me.lblAllSuppliers.Text = "All Suppliers"
        '
        'lblSuppliersItem
        '
        Me.lblSuppliersItem.AutoSize = True
        Me.lblSuppliersItem.Location = New System.Drawing.Point(174, 189)
        Me.lblSuppliersItem.Name = "lblSuppliersItem"
        Me.lblSuppliersItem.Size = New System.Drawing.Size(70, 13)
        Me.lblSuppliersItem.TabIndex = 18
        Me.lblSuppliersItem.Text = "SuppliersItem"
        '
        'cboSuppAll
        '
        Me.cboSuppAll.FormattingEnabled = True
        Me.cboSuppAll.Location = New System.Drawing.Point(174, 252)
        Me.cboSuppAll.Name = "cboSuppAll"
        Me.cboSuppAll.Size = New System.Drawing.Size(363, 21)
        Me.cboSuppAll.TabIndex = 20
        '
        'cboSuppItem
        '
        Me.cboSuppItem.FormattingEnabled = True
        Me.cboSuppItem.Location = New System.Drawing.Point(174, 205)
        Me.cboSuppItem.Name = "cboSuppItem"
        Me.cboSuppItem.Size = New System.Drawing.Size(363, 21)
        Me.cboSuppItem.TabIndex = 21
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(174, 279)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(363, 210)
        Me.DGV.TabIndex = 22
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 501)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.cboSuppItem)
        Me.Controls.Add(Me.cboSuppAll)
        Me.Controls.Add(Me.lblAllSuppliers)
        Me.Controls.Add(Me.lblSuppliersItem)
        Me.Controls.Add(Me.txtReorderQuantity)
        Me.Controls.Add(Me.txtQuantityInStock)
        Me.Controls.Add(Me.lblReorderQuantity)
        Me.Controls.Add(Me.lblQuantityInStock)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtReorderLevel)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtStockID)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblReorderLevel)
        Me.Controls.Add(Me.lblStockID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAmend)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAmend As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblStockID As System.Windows.Forms.Label
    Friend WithEvents lblReorderLevel As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityInStock As System.Windows.Forms.Label
    Friend WithEvents lblReorderQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantityInStock As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblAllSuppliers As System.Windows.Forms.Label
    Friend WithEvents lblSuppliersItem As System.Windows.Forms.Label
    Friend WithEvents cboSuppAll As System.Windows.Forms.ComboBox
    Friend WithEvents cboSuppItem As System.Windows.Forms.ComboBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
