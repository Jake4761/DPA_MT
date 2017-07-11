Public Class Menu
    Private Sub btnSetUpDB_Click(sender As System.Object, e As System.EventArgs) Handles btnSetUpDB.Click
        Form1.Show()
    End Sub
    Private Sub btnSuppliers_Click(sender As System.Object, e As System.EventArgs) Handles btnSuppliers.Click
        Form2.Show()
    End Sub
    Private Sub btnItems_Click(sender As System.Object, e As System.EventArgs) Handles btnItems.Click
        Form3.Show()
    End Sub
    Private Sub btnReorder_Click(sender As System.Object, e As System.EventArgs) Handles btnReorder.Click
        Form4.Show()
    End Sub
End Class