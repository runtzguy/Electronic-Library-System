Imports System.Data.SQLite
Public Class frmMemberPage
    'Public variables are declared here
    Public sqlconn As New SQLiteConnection("Data source = Elibrary.db")
    Public fmtStr As String = "{0,-30}{1,-30}{2,-30}{3,-30}"

    Private Sub btnSearchAndCheckout_Click(sender As Object, e As EventArgs) Handles btnSearchAndCheckout.Click
        'Displays the Search and Checkout Form
        Me.Hide()
        frmSearchAndCheckout.Show()
    End Sub

    Private Sub btnAccountInfo_Click(sender As Object, e As EventArgs) Handles btnAccountInfo.Click
        'Display and shows the listview in frmAccountInfo

        'Declaring variables
        Dim holderMemberID As String = frmLogin.memberID
        Dim holderMemberName As String
        Dim holderLastName As String
        Dim holderStreetAddress As String
        Dim holderCity As String
        Dim holderState As String
        Dim holderZipCode As String
        Dim holderEmail As String
        Dim holderPW As String
        Dim i As ListViewItem

        frmAccountInfo.lstviewResult.Items.Clear()
        Dim sqlcmd1 As New SQLiteCommand("SELECT * FROM Member WHERE MemberID = '" & holderMemberID & "'", sqlconn)
        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()
        sqlcmd1.Dispose()

        If sqlreader.HasRows Then
            'Reads and displays the results on frmAccountInfo's listview
            Do While sqlreader.Read()
                holderMemberName = sqlreader("FirstName").ToString()
                holderLastName = sqlreader("LastName").ToString()
                holderStreetAddress = sqlreader("StreetAddress").ToString()
                holderCity = sqlreader("City").ToString()
                holderState = sqlreader("State").ToString()
                holderZipCode = sqlreader("ZipCode").ToString()
                holderEmail = sqlreader("Email").ToString()
                holderPW = sqlreader("Password").ToString()


                i = frmAccountInfo.lstviewResult.Items.Add(holderMemberName)
                i.SubItems.Add(holderLastName)
                i.SubItems.Add(holderStreetAddress)
                i.SubItems.Add(holderCity)
                i.SubItems.Add(holderState)
                i.SubItems.Add(holderZipCode)
                i.SubItems.Add(holderEmail)
            Loop

        End If
        sqlconn.Close()
        sqlreader.Dispose()
        Me.Hide()
        frmAccountInfo.Show()
    End Sub

    Private Sub btnReturnBooks_Click(sender As Object, e As EventArgs) Handles btnReturnBooks.Click
        'Returns the books that the user selected

        'Declaring variables
        Dim returnBook As DateTime = DateTime.Today
        Dim holderResourceID As String = ""
        Dim holderMemberID As String = frmLogin.memberID

        'Checks if the user has selected an item on the listview and acts accordingly
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox(" Please select a book to return ")
        ElseIf ListView1.FocusedItem.SubItems(5).Text = "" Then

            holderResourceID = ListView1.FocusedItem.SubItems(1).Text
            Dim sqlcmd As New SQLiteCommand("UPDATE Checkout SET  ReturnDate='" & returnBook & "' WHERE ResourceID='" & holderResourceID & "' AND MemberID='" & holderMemberID & "'", sqlconn)

            sqlconn.Open()
            sqlcmd.ExecuteReader()
            sqlcmd.Dispose()
            sqlconn.Close()
            MsgBox("Book Return Successful")
        Else
            MsgBox("Book has already been returned")
        End If



        frmLogin.memberPageListBox()

    End Sub
    Private Sub btnRenewBooks_Click(sender As Object, e As EventArgs) Handles btnRenewBooks.Click
        'Renews the books that user selects

        'Declaring variables
        Dim newCheckoutDate As DateTime = DateTime.Today
        Dim holderResourceID As String = ""
        Dim holderMemberID As String = frmLogin.memberID

        'Determines whether or not the user selects an item on the listview and acts accordingly
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox(" Please select a book for renewal ")
        ElseIf ListView1.FocusedItem.SubItems(5).Text = "" Then

            holderResourceID = ListView1.FocusedItem.SubItems(1).Text
            Dim sqlcmd As New SQLiteCommand("UPDATE Checkout SET  CheckOutDate='" & newCheckoutDate & "' WHERE ResourceID='" & holderResourceID & "' AND MemberID='" & holderMemberID & "'", sqlconn)

            sqlconn.Open()
            sqlcmd.ExecuteReader()

            sqlcmd.Dispose()
            sqlconn.Close()
            MsgBox("Book Renewal Successful")
        Else
            MsgBox("Cannot renew book. Please go through Search and Checkout to borrow book again")
        End If
        frmLogin.memberPageListBox()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clears the public variables and the text boxes in frmLogin
        frmLogin.memberID = ""
        frmLogin.memberName = ""
        frmLogin.txtEmail.Clear()
        frmLogin.txtPassword.Clear()
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class