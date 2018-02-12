Imports System.Data.SQLite
Public Class frmLogin
    '******************************************************************************
    ' Name   : Electronic Library:                 New and existing members can login, 
    '                                              checkout, renew, return and search for books in the database.
    ' Author : Victor (Kam Ho) Liu
    ' Date   : November 22, 2016
    '******************************************************************************

    'Declaring public variable and array to be used throughout functions
    Public sqlconn As New SQLiteConnection("Data source = Elibrary.db")
    Public memberID As String = ""
    Public memberName As String = ""
    Public fmtStr As String = "{0,-30}{1,-30}{2,-30}{3,-30}"

    Public Function Hasconnection() As Boolean
        'Checking whether there is a connection to the database
        Try
            sqlconn.Open()
            sqlconn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows whether the connection to database is successful or not to user
        If Hasconnection() = True Then
            MessageBox.Show("Successful connection")

        Else
            MessageBox.Show("Unsuccessful")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Where the user logins into the Main Menu and checks whether his credentials are correct or not

        'Declaring variables
        Dim MemberPassword As String
        Dim sqlcmd1 As New SQLiteCommand("SELECT Email, Password, MemberID, FirstName FROM Member WHERE (Email = '" & txtEmail.Text & "')", sqlconn)
        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()
        sqlcmd1.Dispose()

        'Determing whether the email is found or not
        If sqlreader.Read() = True Then
            memberID = sqlreader("MemberID").ToString()
            memberName = sqlreader("FirstName").ToString()
            MemberPassword = sqlreader("Password").ToString()
            If MemberPassword = txtPassword.Text Then
                MessageBox.Show("login successful")

                Me.Hide()
                sqlreader.Dispose()
                sqlconn.Close()

                memberPageListBox()

            Else
                MessageBox.Show("login unsuccessful - email or password incorrect")
            End If

        Else
            MessageBox.Show("login unsuccessful - email or password incorrect")
        End If
        sqlreader.Close()
        sqlconn.Close()

    End Sub

    Sub memberPageListBox()
        'Shows the list box output containing the date and time of today 
        frmMemberPage.lstOutput.Items.Clear()
        frmMemberPage.ListView1.Items.Clear()
        frmMemberPage.lstOutput.Items.Add(String.Format(fmtStr, "Date/Time of Report       :    ", System.DateTime.Now, " ", " "))
        memberPageListView()
        sqlconn.Close()
        frmMemberPage.Show()

    End Sub
    Sub memberPageListView()
        'Displays the member's book rental history on listview in frmMemberPage

        'Declaring variables
        Dim holderCheckoutDate As String
        Dim holderReturnDate As String
        Dim holderCheckoutID As String
        Dim holderResourceID As String
        Dim holderBookTitle As String
        Dim holderDueDate As DateTime
        Dim holderMemberID As String = memberID
        Dim i As ListViewItem
        Dim thisDay As DateTime = DateTime.Today

        Dim sqlcmd1 As New SQLiteCommand("SELECT * FROM Checkout WHERE MemberID = '" & holderMemberID & "'", sqlconn)
        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()
        sqlcmd1.Dispose()

        'Executes if the sqlreader finds a row in the database
        If sqlreader.HasRows Then
            'Executes as long as sqlreader is readable
            Do While sqlreader.Read()

                holderCheckoutID = sqlreader("CheckoutID").ToString()
                holderResourceID = sqlreader("ResourceID").ToString()
                holderCheckoutDate = sqlreader("CheckOutDate").ToString()
                holderReturnDate = sqlreader("ReturnDate").ToString()
                holderDueDate = calcDueDate(holderResourceID, holderCheckoutDate)
                holderBookTitle = findBookTitle(holderResourceID)

                i = frmMemberPage.ListView1.Items.Add(holderCheckoutID)
                i.SubItems.Add(holderResourceID)

                i.SubItems.Add(holderBookTitle)

                i.SubItems.Add(holderCheckoutDate)
                i.SubItems.Add(holderDueDate)
                i.SubItems.Add(holderReturnDate)


            Loop
        End If
        sqlreader.Dispose()

    End Sub
    Function calcDueDate(ByVal holderResourceID As String, ByVal holderCheckoutDate As DateTime) As String
        'Calculates the Due Date and returns due date
        'Declaring variables
        Dim holderDueDate As String = ""
        Dim holderCheckOutPeriod As String = ""

        'Executes the functions/subs needed
        holderCheckOutPeriod = findCheckoutPeriod(holderResourceID)
        holderDueDate = holderCheckoutDate.AddDays(holderCheckOutPeriod)

        Return holderDueDate
    End Function
    Function findCheckoutPeriod(ByVal holderResourceID As String) As String
        'Finds the checkout period from the database
        'Declaring variables
        Dim holderCheckOutPeriod As String = ""
        Dim sqlcmd2 As New SQLiteCommand("SELECT * FROM Resources WHERE (ResourceID = '" & holderResourceID & "')", sqlconn)
        Dim sqlreader2 As SQLiteDataReader = sqlcmd2.ExecuteReader()
        sqlcmd2.Dispose()

        'Executes sqlreader2 until there is nothing to read anymore
        Do While sqlreader2.Read()
            holderCheckOutPeriod = sqlreader2("CheckOutPeriod").ToString()
        Loop
        sqlreader2.Close()
        Return holderCheckOutPeriod
    End Function
    Function findBookTitle(holderresourceID As String) As String
        'Finds the book title from the Database
        'Declaring variables
        Dim holderBookTitle As String = ""
        Dim sqlcmd2 As New SQLiteCommand("SELECT * FROM Resources WHERE (ResourceID = '" & holderresourceID & "')", sqlconn)
        Dim sqlreader2 As SQLiteDataReader = sqlcmd2.ExecuteReader()
        sqlcmd2.Dispose()

        'Executes sqlreader2 until there is nothing to read anymore
        Do While sqlreader2.Read()
            holderBookTitle = sqlreader2("Title").ToString()
        Loop
        sqlreader2.Close()
        Return holderBookTitle
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Closes the program
        frmMemberPage.Close()
        frmAccountInfo.Close()
        frmSearchAndCheckout.Close()
        Me.Close()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'Shows the form to sign up new members
        frmNewMember.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmFAQ.Show()
        Me.Hide()
    End Sub
End Class
