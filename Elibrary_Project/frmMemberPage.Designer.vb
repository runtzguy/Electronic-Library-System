<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberPage))
        Me.btnAccountInfo = New System.Windows.Forms.Button()
        Me.btnSearchAndCheckout = New System.Windows.Forms.Button()
        Me.btnReturnBooks = New System.Windows.Forms.Button()
        Me.btnRenewBooks = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAccountInfo
        '
        Me.btnAccountInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountInfo.Location = New System.Drawing.Point(203, 39)
        Me.btnAccountInfo.Name = "btnAccountInfo"
        Me.btnAccountInfo.Size = New System.Drawing.Size(195, 44)
        Me.btnAccountInfo.TabIndex = 0
        Me.btnAccountInfo.Text = "Account Information"
        Me.btnAccountInfo.UseVisualStyleBackColor = True
        '
        'btnSearchAndCheckout
        '
        Me.btnSearchAndCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAndCheckout.Location = New System.Drawing.Point(404, 39)
        Me.btnSearchAndCheckout.Name = "btnSearchAndCheckout"
        Me.btnSearchAndCheckout.Size = New System.Drawing.Size(195, 44)
        Me.btnSearchAndCheckout.TabIndex = 1
        Me.btnSearchAndCheckout.Text = "Search and Checkout Books"
        Me.btnSearchAndCheckout.UseVisualStyleBackColor = True
        '
        'btnReturnBooks
        '
        Me.btnReturnBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBooks.Location = New System.Drawing.Point(744, 218)
        Me.btnReturnBooks.Name = "btnReturnBooks"
        Me.btnReturnBooks.Size = New System.Drawing.Size(128, 44)
        Me.btnReturnBooks.TabIndex = 2
        Me.btnReturnBooks.Text = "Return Books"
        Me.btnReturnBooks.UseVisualStyleBackColor = True
        '
        'btnRenewBooks
        '
        Me.btnRenewBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenewBooks.Location = New System.Drawing.Point(744, 268)
        Me.btnRenewBooks.Name = "btnRenewBooks"
        Me.btnRenewBooks.Size = New System.Drawing.Size(128, 44)
        Me.btnRenewBooks.TabIndex = 3
        Me.btnRenewBooks.Text = "Renew Books"
        Me.btnRenewBooks.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(32, 122)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstOutput.Size = New System.Drawing.Size(673, 43)
        Me.lstOutput.TabIndex = 4
        Me.lstOutput.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(32, 200)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(673, 295)
        Me.ListView1.TabIndex = 8
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Checkout ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Resource ID"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Title"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Checkout Date"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Due Date"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Return Date"
        Me.ColumnHeader6.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Welcome !"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(744, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGreen
        Me.Label2.Location = New System.Drawing.Point(409, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Member Account History"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGreen
        Me.Label3.Location = New System.Drawing.Point(521, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date and Time"
        '
        'frmMemberPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(884, 507)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnRenewBooks)
        Me.Controls.Add(Me.btnReturnBooks)
        Me.Controls.Add(Me.btnSearchAndCheckout)
        Me.Controls.Add(Me.btnAccountInfo)
        Me.Name = "frmMemberPage"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccountInfo As Button
    Friend WithEvents btnSearchAndCheckout As Button
    Friend WithEvents btnReturnBooks As Button
    Friend WithEvents btnRenewBooks As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
