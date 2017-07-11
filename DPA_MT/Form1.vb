Imports System.Data.OleDb
Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCreateDB_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateDB.Click
        If txtDBName.Text = "" Then Exit Sub
        Dim strDBName As String = txtDBName.Text
        Dim CAT As New ADOX.Catalog()
        Try
            CAT.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName)
            MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)
        Finally
            CAT = Nothing
        End Try
    End Sub
    Private Sub btnCreateTable_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateTable.Click
        If txtDBName.Text = "" Then Exit Sub
        If txtTableName.Text = "" Then Exit Sub
        If txtDDL.Text = "" Then Exit Sub
        Dim strDBName As String = txtDBName.Text
        Dim strTableName As String = txtDBName.Text
        Dim strDDL As String = txtDDL.Text
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName)
        CON.Open()
        RunCMD(strDDL, CON)
        CON.Close()
        CON.Dispose()
    End Sub
    Private Sub RunCMD(ByVal strDDL As String, ByRef CON As OleDbConnection)
        Dim CMD As New OleDbCommand(strDDL, CON)
        Try
        CMD.ExecuteNonQuery()
        MessageBox.Show("Succeeded")
        Catch ex As Exception
            MessageBox.Show("Failed:" & vbCrLf & ex.Message)

        Finally
            CMD.Dispose()
        End Try
    End Sub
    Private Sub btnPopulate_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulate.Click
        If txtDBName.Text = "" Then Exit Sub
        If txtTableName.Text = "" Then Exit Sub
        If txtData.Text = "" Then Exit Sub
        Dim strDBName As String = txtDBName.Text
        Dim strTableName As String = txtTableName.Text
        Dim strData As String = txtData.Text
        Dim strRecs(), strFields() As String
        Dim intNumRecs, intNumFields, i, j As Integer
        Dim CON As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strDBName)
        Dim DA As New OleDbDataAdapter("SELECT * FROM " & strTableName, CON)
        Dim DT As New DataTable
        DA.Fill(DT)
        strRecs = strData.Replace(vbCrLf, Chr(8)).Split(Chr(8))
        intNumRecs = strRecs.Length
        For i = 0 To intNumRecs - 1
            strFields = strRecs(i).Split(Chr(124))
            intNumFields = strFields.Length
            DT.Rows.Add()
            For j = 0 To intNumFields - 1
                DT(i)(j) = strFields(j)
            Next
        Next
        Dim CB As New OleDbCommandBuilder(DA)
        DA.Update(DT)
        DT.Dispose()
        DA.Dispose()
        CON.Dispose()
    End Sub
End Class
