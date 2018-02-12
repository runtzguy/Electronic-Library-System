<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchAndCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchAndCheckout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtPubDate = New System.Windows.Forms.TextBox()
        Me.txtSeries = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colResourceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPubDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSeries = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAvailability = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnRemoveBook = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Result(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label2.Location = New System.Drawing.Point(13, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Book Cart"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label4.Location = New System.Drawing.Point(16, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Author Full Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label5.Location = New System.Drawing.Point(146, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Author Last Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label6.Location = New System.Drawing.Point(290, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Book Title:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label8.Location = New System.Drawing.Point(400, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Publication Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label9.Location = New System.Drawing.Point(542, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Series:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(921, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(872, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 38)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Return to Main Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(19, 62)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(100, 20)
        Me.txtFullName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(149, 62)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(281, 62)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtBookTitle.TabIndex = 2
        '
        'txtPubDate
        '
        Me.txtPubDate.Location = New System.Drawing.Point(403, 62)
        Me.txtPubDate.Name = "txtPubDate"
        Me.txtPubDate.Size = New System.Drawing.Size(100, 20)
        Me.txtPubDate.TabIndex = 3
        '
        'txtSeries
        '
        Me.txtSeries.Location = New System.Drawing.Point(519, 62)
        Me.txtSeries.Name = "txtSeries"
        Me.txtSeries.Size = New System.Drawing.Size(100, 20)
        Me.txtSeries.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colResourceID, Me.colTitle, Me.colFirstName, Me.colLastName, Me.colPubDate, Me.colSeries, Me.colAvailability})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 132)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(830, 276)
        Me.ListView1.TabIndex = 20
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colResourceID
        '
        Me.colResourceID.Text = "Resource ID"
        Me.colResourceID.Width = 100
        '
        'colTitle
        '
        Me.colTitle.Text = "Title"
        Me.colTitle.Width = 200
        '
        'colFirstName
        '
        Me.colFirstName.Text = "Author First Name"
        Me.colFirstName.Width = 100
        '
        'colLastName
        '
        Me.colLastName.Text = "Author Last Name"
        Me.colLastName.Width = 100
        '
        'colPubDate
        '
        Me.colPubDate.Text = "Publication Date"
        Me.colPubDate.Width = 100
        '
        'colSeries
        '
        Me.colSeries.Text = "Series"
        Me.colSeries.Width = 100
        '
        'colAvailability
        '
        Me.colAvailability.Text = "Available?"
        Me.colAvailability.Width = 100
        '
        'btnClearSearch
        '
        Me.btnClearSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.Location = New System.Drawing.Point(921, 239)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(123, 38)
        Me.btnClearSearch.TabIndex = 6
        Me.btnClearSearch.Text = "Clear Search "
        Me.btnClearSearch.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(15, 450)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(827, 263)
        Me.ListView2.TabIndex = 22
        Me.ListView2.TabStop = False
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Resource ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Title"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Author First Name"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Author Last Name"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Publication Date"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Series"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Available?"
        Me.ColumnHeader7.Width = 100
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(921, 283)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(123, 38)
        Me.btnAddBook.TabIndex = 7
        Me.btnAddBook.Text = "Add to Book Cart"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(921, 521)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(123, 38)
        Me.btnCheckout.TabIndex = 8
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(921, 609)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 38)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Clear Checkout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnRemoveBook
        '
        Me.btnRemoveBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveBook.Location = New System.Drawing.Point(921, 565)
        Me.btnRemoveBook.Name = "btnRemoveBook"
        Me.btnRemoveBook.Size = New System.Drawing.Size(123, 38)
        Me.btnRemoveBook.TabIndex = 9
        Me.btnRemoveBook.Text = "Remove Book"
        Me.btnRemoveBook.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label3.Location = New System.Drawing.Point(16, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Search and CheckOut Books Here!"
        '
        'frmSearchAndCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1069, 731)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemoveBook)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtSeries)
        Me.Controls.Add(Me.txtPubDate)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSearchAndCheckout"
        Me.Text = "Search and Checkout "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents txtPubDate As TextBox
    Friend WithEvents txtSeries As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colResourceID As ColumnHeader
    Friend WithEvents colTitle As ColumnHeader
    Friend WithEvents colFirstName As ColumnHeader
    Friend WithEvents colLastName As ColumnHeader
    Friend WithEvents colPubDate As ColumnHeader
    Friend WithEvents colSeries As ColumnHeader
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnRemoveBook As Button
    Friend WithEvents colAvailability As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label3 As Label
End Class
