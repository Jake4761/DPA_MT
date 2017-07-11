<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblQuantityInStock = New System.Windows.Forms.Label()
        Me.lblReorderLevel = New System.Windows.Forms.Label()
        Me.lblReorderQuantity = New System.Windows.Forms.Label()
        Me.lblSuppliersOfSelectedItem = New System.Windows.Forms.Label()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.txtReorderQuantity = New System.Windows.Forms.TextBox()
        Me.cboSuppItem = New System.Windows.Forms.ComboBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblAllSuppliers = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.cboSuppAll = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(167, 602)
        Me.ListBox1.TabIndex = 0
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.Location = New System.Drawing.Point(179, 9)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantityInStock.TabIndex = 1
        Me.lblQuantityInStock.Text = "Quantity In Stock"
        '
        'lblReorderLevel
        '
        Me.lblReorderLevel.AutoSize = True
        Me.lblReorderLevel.Location = New System.Drawing.Point(286, 9)
        Me.lblReorderLevel.Name = "lblReorderLevel"
        Me.lblReorderLevel.Size = New System.Drawing.Size(74, 13)
        Me.lblReorderLevel.TabIndex = 2
        Me.lblReorderLevel.Text = "Reorder Level"
        '
        'lblReorderQuantity
        '
        Me.lblReorderQuantity.AutoSize = True
        Me.lblReorderQuantity.Location = New System.Drawing.Point(386, 9)
        Me.lblReorderQuantity.Name = "lblReorderQuantity"
        Me.lblReorderQuantity.Size = New System.Drawing.Size(87, 13)
        Me.lblReorderQuantity.TabIndex = 3
        Me.lblReorderQuantity.Text = "Reorder Quantity"
        '
        'lblSuppliersOfSelectedItem
        '
        Me.lblSuppliersOfSelectedItem.AutoSize = True
        Me.lblSuppliersOfSelectedItem.Location = New System.Drawing.Point(516, 9)
        Me.lblSuppliersOfSelectedItem.Name = "lblSuppliersOfSelectedItem"
        Me.lblSuppliersOfSelectedItem.Size = New System.Drawing.Size(132, 13)
        Me.lblSuppliersOfSelectedItem.TabIndex = 4
        Me.lblSuppliersOfSelectedItem.Text = "Suppliers Of Selected Item"
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(182, 25)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(86, 20)
        Me.txtQuantityInStock.TabIndex = 5
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.Location = New System.Drawing.Point(289, 25)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(71, 20)
        Me.txtReorderLevel.TabIndex = 6
        '
        'txtReorderQuantity
        '
        Me.txtReorderQuantity.Location = New System.Drawing.Point(389, 25)
        Me.txtReorderQuantity.Name = "txtReorderQuantity"
        Me.txtReorderQuantity.Size = New System.Drawing.Size(84, 20)
        Me.txtReorderQuantity.TabIndex = 7
        '
        'cboSuppItem
        '
        Me.cboSuppItem.FormattingEnabled = True
        Me.cboSuppItem.Location = New System.Drawing.Point(493, 24)
        Me.cboSuppItem.Name = "cboSuppItem"
        Me.cboSuppItem.Size = New System.Drawing.Size(216, 21)
        Me.cboSuppItem.TabIndex = 8
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(182, 86)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(490, 105)
        Me.DGV1.TabIndex = 9
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(179, 59)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(76, 13)
        Me.lbltitle.TabIndex = 10
        Me.lbltitle.Text = "Unfilled Orders"
        '
        'lblAllSuppliers
        '
        Me.lblAllSuppliers.AutoSize = True
        Me.lblAllSuppliers.Location = New System.Drawing.Point(179, 216)
        Me.lblAllSuppliers.Name = "lblAllSuppliers"
        Me.lblAllSuppliers.Size = New System.Drawing.Size(64, 13)
        Me.lblAllSuppliers.TabIndex = 11
        Me.lblAllSuppliers.Text = "All Suppliers"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(386, 216)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Date"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(516, 216)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(47, 13)
        Me.lblOrderID.TabIndex = 13
        Me.lblOrderID.Text = "Order ID"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(583, 211)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(89, 52)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New Order"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(583, 314)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 52)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(583, 476)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 52)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(191, 314)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(89, 52)
        Me.btnAddItem.TabIndex = 17
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(191, 476)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(89, 52)
        Me.btnRemoveItem.TabIndex = 18
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'cboSuppAll
        '
        Me.cboSuppAll.FormattingEnabled = True
        Me.cboSuppAll.Location = New System.Drawing.Point(182, 242)
        Me.cboSuppAll.Name = "cboSuppAll"
        Me.cboSuppAll.Size = New System.Drawing.Size(178, 21)
        Me.cboSuppAll.TabIndex = 19
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(389, 242)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 20
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(519, 243)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(58, 20)
        Me.txtOrderID.TabIndex = 21
        '
        'DGV2
        '
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(290, 314)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(286, 213)
        Me.DGV2.TabIndex = 22
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 597)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cboSuppAll)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAllSuppliers)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cboSuppItem)
        Me.Controls.Add(Me.txtReorderQuantity)
        Me.Controls.Add(Me.txtReorderLevel)
        Me.Controls.Add(Me.txtQuantityInStock)
        Me.Controls.Add(Me.lblSuppliersOfSelectedItem)
        Me.Controls.Add(Me.lblReorderQuantity)
        Me.Controls.Add(Me.lblReorderLevel)
        Me.Controls.Add(Me.lblQuantityInStock)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblQuantityInStock As System.Windows.Forms.Label
    Friend WithEvents lblReorderLevel As System.Windows.Forms.Label
    Friend WithEvents lblReorderQuantity As System.Windows.Forms.Label
    Friend WithEvents lblSuppliersOfSelectedItem As System.Windows.Forms.Label
    Friend WithEvents txtQuantityInStock As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cboSuppItem As System.Windows.Forms.ComboBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblAllSuppliers As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents cboSuppAll As System.Windows.Forms.ComboBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
End Class
