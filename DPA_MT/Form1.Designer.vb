<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCreateDB = New System.Windows.Forms.Button()
        Me.btnPopulate = New System.Windows.Forms.Button()
        Me.btnCreateTable = New System.Windows.Forms.Button()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtTableName = New System.Windows.Forms.TextBox()
        Me.txtDDL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreateDB
        '
        Me.btnCreateDB.Location = New System.Drawing.Point(260, 15)
        Me.btnCreateDB.Name = "btnCreateDB"
        Me.btnCreateDB.Size = New System.Drawing.Size(174, 23)
        Me.btnCreateDB.TabIndex = 0
        Me.btnCreateDB.Text = "Create Blank DataBase"
        Me.btnCreateDB.UseVisualStyleBackColor = True
        '
        'btnPopulate
        '
        Me.btnPopulate.Location = New System.Drawing.Point(260, 241)
        Me.btnPopulate.Name = "btnPopulate"
        Me.btnPopulate.Size = New System.Drawing.Size(174, 23)
        Me.btnPopulate.TabIndex = 1
        Me.btnPopulate.Text = "Populate Table Using Data"
        Me.btnPopulate.UseVisualStyleBackColor = True
        '
        'btnCreateTable
        '
        Me.btnCreateTable.Location = New System.Drawing.Point(260, 59)
        Me.btnCreateTable.Name = "btnCreateTable"
        Me.btnCreateTable.Size = New System.Drawing.Size(174, 23)
        Me.btnCreateTable.TabIndex = 2
        Me.btnCreateTable.Text = "Create Table - Using DDL"
        Me.btnCreateTable.UseVisualStyleBackColor = True
        '
        'txtDBName
        '
        Me.txtDBName.Location = New System.Drawing.Point(12, 15)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(217, 20)
        Me.txtDBName.TabIndex = 3
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(12, 270)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(422, 190)
        Me.txtData.TabIndex = 4
        '
        'txtTableName
        '
        Me.txtTableName.Location = New System.Drawing.Point(12, 59)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(217, 20)
        Me.txtTableName.TabIndex = 5
        '
        'txtDDL
        '
        Me.txtDDL.Location = New System.Drawing.Point(12, 107)
        Me.txtDDL.Multiline = True
        Me.txtDDL.Name = "txtDDL"
        Me.txtDDL.Size = New System.Drawing.Size(242, 157)
        Me.txtDDL.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 472)
        Me.Controls.Add(Me.txtDDL)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtDBName)
        Me.Controls.Add(Me.btnCreateTable)
        Me.Controls.Add(Me.btnPopulate)
        Me.Controls.Add(Me.btnCreateDB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateDB As System.Windows.Forms.Button
    Friend WithEvents btnPopulate As System.Windows.Forms.Button
    Friend WithEvents btnCreateTable As System.Windows.Forms.Button
    Friend WithEvents txtDBName As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents txtTableName As System.Windows.Forms.TextBox
    Friend WithEvents txtDDL As System.Windows.Forms.TextBox

End Class
