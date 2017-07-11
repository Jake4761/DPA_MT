Imports System.Data.OleDb
Imports System.IO

Public Class Form4
    Private CN As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Stock2.mdb;")
    Private DAItems As OleDbDataAdapter
    Private DTItems, DTNewOrder As DataTable
    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitDGV1()
        InitDGV2()
        GetAllSuppliers()
        GetLowStock()
        txtDate.Text = Now.Date.ToShortDateString
    End Sub
    Private Sub InitDGV1()
        With DGV1
            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
        End With
    End Sub
    Private Sub InitDGV2()
        With DGV2
            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = False
        End With
    End Sub
    Private Sub GetAllSuppliers()
        Dim strSQL As String = "SELECT SupplierID, Name FROM tblSupplier ORDER BY SupplierID"
        CN.Open()
        Dim CM As New OleDbCommand(strSQL, CN)
        Dim DR As OleDbDataReader = CM.ExecuteReader
        Do While DR.Read
            cboSuppAll.Items.Add(DR.Item("SupplierID").ToString & " " & DR.Item("Name").ToString)
        Loop
        CN.Close()
        cboSuppAll.SelectedIndex = 0
    End Sub
    Private Sub GetLowStock()
        Dim strSQL As String = "SELECT * FROM tblItem " & "WHERE QuantityInStock < ReorderLevel"
        DAItems = New OleDbDataAdapter(strSQL, CN)
        DTItems = New DataTable
        DAItems.Fill(DTItems)
        FillList(0)
    End Sub
    Private Sub FillList(ByVal intSelectRow As Integer)
        ListBox1.Items.Clear()
        For Each DR As DataRow In DTItems.Rows
            ListBox1.Items.Add(DR.Item("StockID").ToString & " " & DR.Item("Description").ToString)
        Next
        ListBox1.SelectedIndex = intSelectRow
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim strSuppID As String = cboSuppAll.Text.Substring(0, cboSuppAll.Text.IndexOf(" "))
        Dim strSQL As String = "SELECT tblItem.StockID,Description,ReorderQuantity AS Qty " & "FROM tblItem, tblSupplierItem " & "WHERE tblItem.StockID = tblSupplierItem.StockID " & "AND tblSupplierItem.SupplierID = '" & strSuppID & "'" & "AND QuantityInStock < ReorderLevel "
        DTNewOrder = New DataTable
        Dim DANewOrder As New OleDbDataAdapter(strSQL, CN)
        DANewOrder.Fill(DTNewOrder)
        DGV2.DataSource = DTNewOrder
        DGV2.CurrentCell = Nothing
    End Sub

    Private Sub btnAddItem_Click(sender As System.Object, e As System.EventArgs) Handles btnAddItem.Click
        Dim DRNew As DataRow = DTNewOrder.NewRow
        Dim DR As DataRow = DTItems(ListBox1.SelectedIndex)
        DRNew("StockID") = DR.Item("StockID")
        DRNew("Description") = DR.Item("Description")
        DRNew("Qty") = DR.Item("ReorderQuantity")
        DTNewOrder.Rows.Add(DRNew)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SaveOrder()
        SaveOrderItems()
    End Sub
    Private Sub SaveOrder()
        Dim strOrderID As String = txtOrderID.Text
        If strOrderID = "" Then Exit Sub
        Dim strSuppID As String = cboSuppAll.Text.Substring(0, cboSuppAll.Text.IndexOf(" "))
        Dim strdate As String = Format(CDate(txtDate.Text), "MM/dd/yyyy")
        Dim strSQL As String = "INSERT INTO tblOrder " & "VALUES('" & strOrderID & "','" & strSuppID & "',#" & strdate & "#,NULL)"
        CN.Open()
        Dim CM As New OleDbCommand(strSQL, CN)
        CM.ExecuteNonQuery()
        CN.Close()
    End Sub
    Private Sub btnRemoveItem_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveItem.Click
        With DGV2
            If .RowCount = 0 Then Exit Sub
            Dim intSelRow = .CurrentRow.Index
            .Rows.RemoveAt(intSelRow)
            If .RowCount <> 0 Then
                If intSelRow = .RowCount Then
                    intSelRow -= 1
                End If
                .CurrentCell = .Item(0, intSelRow)
                .CurrentCell.Selected = True
            End If
        End With
    End Sub
    Private Sub SaveOrderItems()
        Dim strOrderID As String = txtOrderID.Text
        If strOrderID = "" Then Exit Sub
        Dim strStockID, strSQL As String
        Dim intQty As Integer
        Dim CM As New OleDbCommand
        CN.Open()
        CM.Connection = CN
        For Each Row As DataGridViewRow In DGV2.Rows
            strStockID = Row.Cells("StockID").Value.ToString
            intQty = CInt(Row.Cells("Qty").Value)
            strSQL = "INSERT INTO tblOrderItem " & "VALUES('" & strOrderID & "','" & strStockID & "'," & intQty & ")"
            CM.CommandText = strSQL
            CM.ExecuteNonQuery()
        Next
        CN.Close()
        CM.Dispose()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim strOrderID As String = txtOrderID.Text
        If strOrderID = "" Then Exit Sub
        Dim strSupplier As String = cboSuppAll.Text
        Dim strDate As String = txtDate.Text
        Dim strLine As String = ""
        Dim strFileName As String = "Order" & strOrderID & ".txt"
        Dim SW As New StreamWriter(strFileName)
        strLine = "ORDER No.: " & strOrderID.ToString & vbCrLf & "SUPPLIER : " & strSupplier.ToString & vbCrLf & "DATE     : " & strDate.ToString & vbCrLf
        SW.WriteLine(strLine)
        strLine = "StockID   Description     Qty"
        SW.WriteLine(strLine)
        For Each Row As DataGridViewRow In DGV2.Rows
            strLine = Row.Cells("StockID").Value.ToString.PadRight(10) & Row.Cells("Description").Value.ToString.PadRight(20) & Row.Cells("Qty").Value.ToString
            SW.WriteLine(strLine)
        Next
        SW.Close()
        System.Diagnostics.Process.Start(strFileName)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim DR As DataRow = DTItems(ListBox1.SelectedIndex)
        txtQuantityInStock.Text = DR.Item("QuantityInStock").ToString
        txtReorderLevel.Text = DR.Item("ReorderLevel").ToString
        txtReorderQuantity.Text = DR.Item("ReorderQuantity").ToString
        GetItemSuppliers(DR("StockID").ToString)
        GetUnfilledOrders(DR("StockID").ToString)
    End Sub
    Private Sub GetItemSuppliers(ByVal strID As String)
        Dim strSQL As String = "SELECT tblSupplier.SupplierID, Name " & "FROM tblSupplier, tblSupplierItem " & "WHERE tblSupplier.SupplierID = " & "tblSupplierItem.SupplierID " & "AND StockID = '" & strID & "'"
        CN.Open()
        Dim CM As New OleDbCommand(strSQL, CN)
        Dim DR As OleDbDataReader = CM.ExecuteReader
        cboSuppItem.Items.Clear()
        cboSuppItem.Text = ""
        Do While DR.Read
            cboSuppItem.Items.Add(DR.Item("SupplierID").ToString & " " & DR.Item("Name").ToString)
        Loop
        CN.Close()
        If cboSuppItem.Items.Count > 0 Then
            cboSuppItem.SelectedIndex = 0
        End If
    End Sub
    Private Sub GetUnfilledOrders(ByVal strID As String)
        Dim strSQL As String = "SELECT tblOrder.OrderID, SupplierID, " & "DateSent, DateReceived, Qty " & "FROM tblOrder, tblOrderItem " & "WHERE tblOrder.OrderID = " & "tblOrderItem.OrderID " & "AND StockID = '" & strID & "' " & "AND DateReceived IS NULL"
        Dim DTUnfilled As New DataTable
        Dim DAUnfilled As New OleDbDataAdapter(strSQL, CN)
        DAUnfilled.Fill(DTUnfilled)
        DGV1.DataSource = DTUnfilled
        DGV1.CurrentCell = Nothing
    End Sub
End Class