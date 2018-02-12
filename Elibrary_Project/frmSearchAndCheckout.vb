Imports System.Data.SQLite
Public Class frmSearchAndCheckout
    'Declares the public variables
    Public conn As New SQLiteConnection("Data source = Elibrary.db")
    Public memberID As String
    Public fmtStr As String = "{0,-30}{1,-30}{2,-30}{3,-30}"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Declares the variables
        Dim resourceID As String
        Dim firstName As String
        Dim lastName As String
        Dim bookTitle As String
        Dim publicationDate As String
        Dim series As String

        ListView1.Items.Clear()

        'Checks that the user only inputs in only one of the textboxes and act accordingly
        If txtFullName.Text <> "" And txtLastName.Text = "" And txtBookTitle.Text = "" And txtPubDate.Text = "" And txtSeries.Text = "" Then
            Dim FindQuery As String = "SELECT * FROM Resources WHERE AuthorFirst LIKE'%" & txtFullName.Text & "%'"
            'open the connection to database 
            conn.Open()
            'declare new sqlite command with the current query and connection
            Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
            SQLcmd.Dispose()

            Dim i As ListViewItem

            If SQLreader.HasRows Then
                'looping sqlreader through all matching records
                Do While SQLreader.Read()
                    'convert whatever the reader finds from search into string
                    resourceID = SQLreader("ResourceID").ToString()
                    bookTitle = SQLreader("Title").ToString()
                    lastName = SQLreader("AuthorLast").ToString()
                    firstName = SQLreader("AuthorFirst").ToString()
                    publicationDate = SQLreader("PublicationDate").ToString()
                    series = SQLreader("Series").ToString

                    'display data from converted strings on listview 
                    i = ListView1.Items.Add(resourceID)
                    i.SubItems.Add(bookTitle)
                    i.SubItems.Add(firstName)
                    i.SubItems.Add(lastName)
                    i.SubItems.Add(publicationDate)
                    i.SubItems.Add(series)
                    i.SubItems.Add(isNULLorNot(resourceID))
                Loop
            Else
                MsgBox("There is no matching First Name for: " & txtFullName.Text)
                txtBookTitle.Clear()
                txtFullName.Clear()
                txtLastName.Clear()
                txtPubDate.Clear()
                txtSeries.Clear()
            End If

            SQLreader.Close()
            conn.Close()
            'Checks if the lastName textbox is empty or not and executes accordingly
        ElseIf txtFullName.Text = "" And txtLastName.Text <> "" And txtBookTitle.Text = "" And txtPubDate.Text = "" And txtSeries.Text = "" Then
            Dim FindQuery As String = "SELECT * FROM Resources WHERE AuthorLast LIKE'%" & txtLastName.Text & "%'"
            'open the connection to database 
            conn.Open()
            'declare new sqlite command with the current query and connection
            Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
            SQLcmd.Dispose()

            Dim i As ListViewItem
            'looping sqlreader through all matching records
            If SQLreader.HasRows Then
                Do While SQLreader.Read()
                    'convert whatever the reader finds from search into string
                    resourceID = SQLreader("ResourceID").ToString()
                    bookTitle = SQLreader("Title").ToString()
                    lastName = SQLreader("AuthorLast").ToString()
                    firstName = SQLreader("AuthorFirst").ToString()
                    publicationDate = SQLreader("PublicationDate").ToString()
                    series = SQLreader("Series").ToString

                    'display data from converted strings on listview 
                    i = ListView1.Items.Add(resourceID)
                    i.SubItems.Add(bookTitle)
                    i.SubItems.Add(firstName)
                    i.SubItems.Add(lastName)
                    i.SubItems.Add(publicationDate)
                    i.SubItems.Add(series)
                    i.SubItems.Add(isNULLorNot(resourceID))
                Loop
            Else
                MsgBox("There is no matching Last Name for: " & txtLastName.Text)
                txtBookTitle.Clear()
                txtFullName.Clear()
                txtLastName.Clear()
                txtPubDate.Clear()
                txtSeries.Clear()
            End If

            SQLreader.Close()
            conn.Close()
            'Checks if the Book Title textbox is empty or not and executes accordingly
        ElseIf txtFullName.Text = "" And txtLastName.Text = "" And txtBookTitle.Text <> "" And txtPubDate.Text = "" And txtSeries.Text = "" Then
            Dim FindQuery As String = "SELECT * FROM Resources WHERE Title LIKE'%" & txtBookTitle.Text & "%'"
            'open the connection to database 
            conn.Open()
            'declare new sqlite command with the current query and connection
            Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
            SQLcmd.Dispose()

            Dim i As ListViewItem
            'looping sqlreader through all matching records
            If SQLreader.HasRows Then
                Do While SQLreader.Read()
                    'convert whatever the reader finds from search into string
                    resourceID = SQLreader("ResourceID").ToString()
                    bookTitle = SQLreader("Title").ToString()
                    lastName = SQLreader("AuthorLast").ToString()
                    firstName = SQLreader("AuthorFirst").ToString()
                    publicationDate = SQLreader("PublicationDate").ToString()
                    series = SQLreader("Series").ToString

                    'display data from converted strings on listview 
                    i = ListView1.Items.Add(resourceID)
                    i.SubItems.Add(bookTitle)
                    i.SubItems.Add(firstName)
                    i.SubItems.Add(lastName)
                    i.SubItems.Add(publicationDate)
                    i.SubItems.Add(series)
                    i.SubItems.Add(isNULLorNot(resourceID))
                Loop
            Else
                MsgBox("There is no matching Book Title for: " & txtBookTitle.Text)
                txtBookTitle.Clear()
                txtFullName.Clear()
                txtLastName.Clear()
                txtPubDate.Clear()
                txtSeries.Clear()
            End If

            SQLreader.Close()
            conn.Close()
            'Checks if the PubDate textbox is empty or not and executes accordingly
        ElseIf txtFullName.Text = "" And txtLastName.Text = "" And txtBookTitle.Text = "" And txtPubDate.Text <> "" And txtSeries.Text = "" Then
            Dim FindQuery As String = "SELECT * FROM Resources WHERE PublicationDate LIKE'%" & txtPubDate.Text & "%'"
            'open the connection to database 
            conn.Open()
            'declare new sqlite command with the current query and connection
            Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
            SQLcmd.Dispose()

            Dim i As ListViewItem
            'looping sqlreader through all matching records
            If SQLreader.HasRows Then
                Do While SQLreader.Read()
                    'convert whatever the reader finds from search into string
                    resourceID = SQLreader("ResourceID").ToString()
                    bookTitle = SQLreader("Title").ToString()
                    lastName = SQLreader("AuthorLast").ToString()
                    firstName = SQLreader("AuthorFirst").ToString()
                    publicationDate = SQLreader("PublicationDate").ToString()
                    series = SQLreader("Series").ToString

                    'display data from converted strings on listview 
                    i = ListView1.Items.Add(resourceID)
                    i.SubItems.Add(bookTitle)
                    i.SubItems.Add(firstName)
                    i.SubItems.Add(lastName)
                    i.SubItems.Add(publicationDate)
                    i.SubItems.Add(series)
                    i.SubItems.Add(isNULLorNot(resourceID))
                Loop
            Else
                MsgBox("There is no matching Publication Date for: " & txtPubDate.Text)
                txtBookTitle.Clear()
                txtFullName.Clear()
                txtLastName.Clear()
                txtPubDate.Clear()
                txtSeries.Clear()
            End If

            SQLreader.Close()
            conn.Close()
            'Checks if the Series textbox is empty or not and executes accordingly
        ElseIf txtFullName.Text = "" And txtLastName.Text = "" And txtBookTitle.Text = "" And txtPubDate.Text = "" And txtSeries.Text <> "" Then
            Dim FindQuery As String = "SELECT * FROM Resources WHERE Series LIKE'%" & txtSeries.Text & "%'"
            'open the connection to database 
            conn.Open()
            'declare new sqlite command with the current query and connection
            Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
            SQLcmd.Dispose()

            Dim i As ListViewItem
            'looping sqlreader through all matching records
            If SQLreader.HasRows Then
                Do While SQLreader.Read()
                    'convert whatever the reader finds from search into string
                    resourceID = SQLreader("ResourceID").ToString()
                    bookTitle = SQLreader("Title").ToString()
                    lastName = SQLreader("AuthorLast").ToString()
                    firstName = SQLreader("AuthorFirst").ToString()
                    publicationDate = SQLreader("PublicationDate").ToString()
                    series = SQLreader("Series").ToString

                    'display data from converted strings on listview 
                    i = ListView1.Items.Add(resourceID)
                    i.SubItems.Add(bookTitle)
                    i.SubItems.Add(firstName)
                    i.SubItems.Add(lastName)
                    i.SubItems.Add(publicationDate)
                    i.SubItems.Add(series)
                    i.SubItems.Add(isNULLorNot(resourceID))
                Loop
            Else
                MsgBox("There is no matching Series for: " & txtSeries.Text)
                txtBookTitle.Clear()
                txtFullName.Clear()
                txtLastName.Clear()
                txtPubDate.Clear()
                txtSeries.Clear()
            End If

            SQLreader.Close()
            conn.Close()
        Else
            MsgBox("Please provide one input per search box")
            txtBookTitle.Clear()
            txtFullName.Clear()
            txtLastName.Clear()
            txtPubDate.Clear()
            txtSeries.Clear()
        End If
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        'Clears the Search list and the text boxes
        ListView1.Items.Clear()
        txtBookTitle.Clear()
        txtFullName.Clear()
        txtLastName.Clear()
        txtPubDate.Clear()
        txtSeries.Clear()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Dim i As ListViewItem

        'Checks if the listview is empty or not and whether the user selects an item on the listview
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select a book to add to book cart")
        ElseIf (ListView1.FocusedItem.SubItems(6).Text = "Yes") Then
            i = ListView2.Items.Add(ListView1.FocusedItem.Text)
            i.SubItems.Add(ListView1.FocusedItem.SubItems(1).Text)
            i.SubItems.Add(ListView1.FocusedItem.SubItems(2).Text)
            i.SubItems.Add(ListView1.FocusedItem.SubItems(3).Text)
            i.SubItems.Add(ListView1.FocusedItem.SubItems(4).Text)
            i.SubItems.Add(ListView1.FocusedItem.SubItems(5).Text)
            i.SubItems.Add(ListView1.FocusedItem.SubItems(6).Text)
            ListView1.FocusedItem.Remove()
        Else
            MsgBox("Book is unavailable")
        End If


    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        'Checks if the bookcart is empty or not and executes accordingly
        If ListView2.Items.Count > 0 Then
            readBookCart()
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            txtBookTitle.Clear()
            txtFullName.Clear()
            txtLastName.Clear()
            txtPubDate.Clear()
            txtSeries.Clear()
        Else
            MsgBox("There are no books in the Book Cart to checkout")
        End If

    End Sub

    Sub checkOutBooks(holderResourceId As String)
        'Checks out Books

        'Declares the variables
        Dim checkoutdate As String = CStr(Today.Date.ToString("d"))
        Dim holderMemberId As String
        Dim holderMemberName As String
        Dim checkoutId As String = ""

        holderMemberId = frmLogin.memberID
        holderMemberName = frmLogin.memberName

        'Generates a unique and new checkoutID
        Do While checkCheckOutID(checkoutId) = False
        Loop
        conn.Open()

        Dim sqlcmd As New SQLiteCommand("INSERT INTO Checkout (CheckoutID, ResourceID, MemberID, CheckOutDate, ReturnDate) VALUES('" & checkoutId & "','" & holderResourceId & "','" & holderMemberId & "','" & checkoutdate & "',NULL)", conn)

        sqlcmd.ExecuteNonQuery()
        sqlcmd.Dispose()
        conn.Close()

    End Sub
    Function checkCheckOutID(ByRef randomDigits As String) As Boolean
        'Checks if the checkoutID is used or not 

        Dim matchOrNot As Boolean
        Dim holderDigitsString As String

        holderDigitsString = getNewDigits()
        Dim FindQuery As String = "SELECT * FROM Checkout WHERE CheckoutID='" & holderDigitsString & "'"

        conn.Open()

        Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
        Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)

        'Checks if the sqlreader has value in it or not and executes accordingly
        If SQLreader.HasRows Then
            matchOrNot = False
        Else
            matchOrNot = True
            randomDigits = holderDigitsString
        End If
        SQLreader.Close()
        SQLcmd.Dispose()
        conn.Close()
        Return matchOrNot
    End Function
    Function getNewDigits() As String
        'Generates random numbers

        Dim rng As New Random
        Dim number As Integer = rng.Next(1, 99999)
        Dim digits As String = number.ToString("00000")

        Return digits
    End Function
    Sub readBookCart()
        'Reads the Book Cart
        Dim i As Integer
        Dim resourceId As String = ""

        'Reads each line of the book cart
        For i = 0 To ListView2.Items.Count - 1
            resourceId = CStr(ListView2.Items(i).Text)
            checkOutBooks(resourceId)

        Next
        MessageBox.Show("Your Books have been officially Checkout ")
    End Sub
    Private Sub btnRemoveBook_Click(sender As Object, e As EventArgs) Handles btnRemoveBook.Click
        'Checks if the user selected an item on the book cart and executes the removal of book 
        If ListView2.SelectedItems.Count = 0 And ListView2.Items.Count = 0 Then
            MsgBox(" There are no items in the Book Cart to remove ")
        ElseIf ListView2.SelectedItems.Count = 0 And ListView2.Items.Count > 0 Then
            MsgBox(" Please select an item to remove from Book Cart ")
        Else
            ListView2.FocusedItem.Remove()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Clears the Book Cart
        ListView2.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clears the textboxes and search list and book cart and leaves the frmSearchAndCheckout and goes to frmMemberPage
        txtBookTitle.Clear()
        txtFullName.Clear()
        txtLastName.Clear()
        txtPubDate.Clear()
        txtSeries.Clear()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        Me.Hide()
        frmMemberPage.ListView1.Items.Clear()
        frmMemberPage.lstOutput.Items.Clear()
        frmLogin.memberPageListBox()
    End Sub
    Function isNULLorNot(ByVal holderResourceID As String) As String
        'Determines the output of availability for the books in Search Listview

        Dim nullOrNot As String = ""
        Dim holderString As String = ""

        holderString = findAvailability(holderResourceID)

        'Determines what to return depending on whether the book searched is available or not
        If holderString = "Rented" Then
            nullOrNot = "No"

        ElseIf holderString = "NeverRented" Then
            nullOrNot = "Yes"
        Else
            nullOrNot = "ERROR"
        End If
        Return nullOrNot
    End Function

    Function findAvailability(ByVal holderResourceID As String) As String
        'Finds the availability of the book and returns whether or not it has been rented or not
        Dim availability As String = ""

        Dim sqlcmd1 As New SQLiteCommand("SELECT * FROM Checkout WHERE (ResourceID = '" & holderResourceID & "') And (ReturnDate IS NULL)", conn)
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()

        sqlcmd1.Dispose()
        If sqlreader.Read() = True Then
            availability = "Rented"
        Else
            availability = "NeverRented"
        End If
        sqlreader.Close()
        Return availability
    End Function

    Private Sub eraseAlltextBoxesExceptFullName(sender As Object, e As EventArgs) Handles txtFullName.GotFocus
        'Clears the text boxes book title, last name, pub date and series when the text box full name has focus
        txtBookTitle.Clear()
        txtLastName.Clear()
        txtPubDate.Clear()
        txtSeries.Clear()
    End Sub
    Private Sub eraseAlltextBoxesExceptLastName(sender As Object, e As EventArgs) Handles txtLastName.GotFocus
        'Clears the text boxes book title, first name, pub date and series when the text box last name has focus
        txtBookTitle.Clear()
        txtFullName.Clear()
        txtPubDate.Clear()
        txtSeries.Clear()
    End Sub
    Private Sub eraseAlltextBoxesExceptBookTitle(sender As Object, e As EventArgs) Handles txtBookTitle.GotFocus
        'Clears the text boxes full name, last name, pub date and series when the text box book title has focus
        txtFullName.Clear()
        txtLastName.Clear()
        txtPubDate.Clear()
        txtSeries.Clear()
    End Sub
    Private Sub eraseAlltextBoxesExceptPubDate(sender As Object, e As EventArgs) Handles txtPubDate.GotFocus
        'Clears the text boxes book title, last name, first name and series when the text box pub date has focus
        txtBookTitle.Clear()
        txtLastName.Clear()
        txtFullName.Clear()
        txtSeries.Clear()
    End Sub
    Private Sub eraseAlltextBoxesExceptSeries(sender As Object, e As EventArgs) Handles txtSeries.GotFocus
        'Clears the text boxes book title, last name, pub date and first name when the text box series has focus
        txtFullName.Clear()
        txtBookTitle.Clear()
        txtLastName.Clear()
        txtPubDate.Clear()

    End Sub

End Class