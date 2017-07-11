Imports System.Data.OleDb
Public Class Form2
    Private CN As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Stock2.mdb;")
    Private DA As OleDbDataAdapter
    Private DT As New DataTable

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitDGV()
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
    Private Sub ReadDB()
        DA = New OleDbDataAdapter("SELECT * FROM tblSupplier", CN)
        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub
    Private Sub DGV_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.RowEnter
        txtSupplierID.Text = DGV.Item("SupplierID", e.RowIndex).Value.ToString
        txtName.Text = DGV.Item("Name", e.RowIndex).Value.ToString
        txtTelephone.Text = DGV.Item("Telephone", e.RowIndex).Value.ToString
        txtEmail.Text = DGV.Item("Email", e.RowIndex).Value.ToString
    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim DR As DataRow = DT.NewRow
        DR("SupplierID") = txtSupplierID.Text
        DR("Name") = txtName.Text
        DR("Telephone") = txtTelephone.Text
        DR("Email") = txtEmail.Text
        DT.Rows.Add(DR)
        DGV.CurrentCell = DGV.Item(0, DGV.RowCount - 1)
    End Sub
    Private Sub btnAmend_Click(sender As System.Object, e As System.EventArgs) Handles btnAmend.Click
        DGV.Item("SupplierID", DGV.CurrentRow.Index).Value = txtSupplierID.Text
        DGV.Item("Name", DGV.CurrentRow.Index).Value = txtName.Text
        DGV.Item("Telephone", DGV.CurrentRow.Index).Value = txtTelephone.Text
        DGV.Item("Email", DGV.CurrentRow.Index).Value = txtEmail.Text
        DGV.BindingContext(DT).EndCurrentEdit()
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim CB As OleDbCommandBuilder = New OleDbCommandBuilder(DA)
        DA.Update(DT)
    End Sub
End Class