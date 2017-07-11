Imports System.Data.OleDb
Public Class Form3
    Private CN As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Stock2.mdb;")
    Private DA As OleDbDataAdapter
    Private DT As New DataTable

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitDGV()
        GetAllSuppliers()
        ReadDB()
    End Sub
    Private Sub InitDGV()
        With DGV
            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
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
    Private Sub ReadDB()
        Dim strSQL As String = "SELECT * FROM tblItem ORDER BY StockID"
        DA = New OleDbDataAdapter(strSQL, CN)
        DA.Fill(DT)
        FillList(0)
    End Sub
    Private Sub FillList(ByVal intSelectRow As Integer)
        ListBox1.Items.Clear()
        For Each DR As DataRow In DT.Rows
            ListBox1.Items.Add(DR.Item("StockID").ToString & " " & DR.Item("Description").ToString)
        Next
        ListBox1.SelectedIndex = intSelectRow
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim DR As DataRow = DT(ListBox1.SelectedIndex)
        txtStockID.Text = DR.Item("StockID").ToString
        txtDescription.Text = DR.Item("Description").ToString
        txtPrice.Text = DR.Item("Price").ToString
        txtQuantityInStock.Text = DR.Item("QuantityInStock").ToString
        txtReorderLevel.Text = DR.Item("ReorderLevel").ToString
        txtReorderQuantity.Text = DR.Item("ReorderQuantity").ToString
        GetItemSuppliers(txtStockID.Text)
        GetItemOrders(txtStockID.Text)
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
    Private Sub GetItemOrders(ByVal strID As String)
        Dim strSQL As String = "SELECT tblOrder.OrderID, SupplierID, " & "DateSent, DateReceived, Qty " & "FROM tblOrder, tblOrderItem " & "WHERE tblOrder.OrderID = " & "tblOrderItem.OrderID " & "AND StockID = '" & strID & "'"
        Dim DT2 As New DataTable
        Dim DA2 As New OleDbDataAdapter(strSQL, CN)
        DA2.Fill(DT2)
        DGV.DataSource = DT2
        DGV.CurrentCell = Nothing
    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim DR As DataRow = DT.NewRow
        DR("StockID") = txtStockID.Text
        DR("Description") = txtDescription.Text
        DR("Price") = CSng(txtPrice.Text)
        DR("QuantityInStock") = CInt("0" & txtQuantityInStock.Text)
        DR("ReorderLevel") = CInt("0" & txtReorderLevel.Text)
        DR("ReorderQuantity") = CInt("0" & txtReorderQuantity.Text)
        DT.Rows.Add(DR)
        FillList(ListBox1.Items.Count - 1)
    End Sub
    Private Sub btnAmend_Click(sender As System.Object, e As System.EventArgs) Handles btnAmend.Click
        Dim intR As Integer = ListBox1.SelectedIndex
        DT(intR)("StockID") = txtStockID.Text
        DT(intR)("Description") = txtDescription.Text
        DT(intR)("Price") = CSng(txtPrice.Text)
        DT(intR)("QuantityInStock") = CInt("0" & txtQuantityInStock.Text)
        DT(intR)("ReorderLevel") = CInt("0" & txtReorderLevel.Text)
        DT(intR)("ReorderQuantity") = CInt("0" & txtReorderQuantity.Text)
        FillList(intR)
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim CB As OleDbCommandBuilder = New OleDbCommandBuilder(DA)
        DA.Update(DT)
    End Sub
    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        Dim strStockID As String = txtStockID.Text
        If strStockID = "" Then Exit Sub
        Dim strSupplierID As String = cboSuppItem.Text.Substring(0, cboSuppItem.Text.IndexOf(Chr(32)))
        If strSupplierID = "" Then Exit Sub
        Dim sngCost As Single = CSng("0" & txtPrice.Text)
        Dim strSQL As String = "INSERT INTO tblSupplierItem VALUES('" & strSupplierID & "','" & strStockID & "'," & sngCost & ")"
        CN.Open()
        Dim CM As New OleDbCommand(strSQL, CN)
        Try
            CM.ExecuteNonQuery()
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        GetItemSuppliers(strStockID)
    End Sub
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim strStockID As String = txtStockID.Text
        If strStockID = "" Then Exit Sub
        Dim strSupplierID As String = cboSuppItem.Text.Substring(0, 2)
        If strSupplierID = "" Then Exit Sub
        Dim strSQL As String = "DELETE FROM tblSupplierItem " & "WHERE StockID = '" & strStockID & "' " & "AND SupplierID = '" & strSupplierID & "'"
        CN.Open()
        Dim CM As New OleDbCommand(strSQL, CN)
        Try
            CM.ExecuteNonQuery()
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        GetItemSuppliers(strStockID)
    End Sub
End Class