<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnSetUpDB = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnReorder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetUpDB
        '
        Me.btnSetUpDB.Location = New System.Drawing.Point(12, 24)
        Me.btnSetUpDB.Name = "btnSetUpDB"
        Me.btnSetUpDB.Size = New System.Drawing.Size(210, 54)
        Me.btnSetUpDB.TabIndex = 0
        Me.btnSetUpDB.Text = "Set Up DataBase"
        Me.btnSetUpDB.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Location = New System.Drawing.Point(12, 84)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(210, 58)
        Me.btnSuppliers.TabIndex = 1
        Me.btnSuppliers.Text = "Suppliers Form"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.Location = New System.Drawing.Point(12, 148)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(210, 54)
        Me.btnItems.TabIndex = 2
        Me.btnItems.Text = "The Main Items Form"
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'btnReorder
        '
        Me.btnReorder.Location = New System.Drawing.Point(12, 208)
        Me.btnReorder.Name = "btnReorder"
        Me.btnReorder.Size = New System.Drawing.Size(210, 54)
        Me.btnReorder.TabIndex = 3
        Me.btnReorder.Text = "Reordering Form"
        Me.btnReorder.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 467)
        Me.Controls.Add(Me.btnReorder)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnSuppliers)
        Me.Controls.Add(Me.btnSetUpDB)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSetUpDB As System.Windows.Forms.Button
    Friend WithEvents btnSuppliers As System.Windows.Forms.Button
    Friend WithEvents btnItems As System.Windows.Forms.Button
    Friend WithEvents btnReorder As System.Windows.Forms.Button
End Class
