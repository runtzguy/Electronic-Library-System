Imports System.Data.SQLite
Public Class frmAccountInfo
    'Declare the public variables
    Public sqlconn As New SQLiteConnection("Data source = Elibrary.db")
    Public fmtStr As String = "{0,-30}{1,-30}{2,-30}{3,-30}"
    Public memberID As String = frmLogin.memberID
    Public accountInfoMemberName As String

    Private Sub btnUpdateInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateInfo.Click
        'Updates the information in the database when the information is changed

        'Delcare the variables
        Dim holderFirstName As String = ""
        Dim holderLastName As String = ""
        Dim holderStreetAddress As String = ""
        Dim holderCity As String = ""
        Dim holderState As String = ""
        Dim holderZipCode As String = ""
        Dim holderEmail As String = ""
        Dim holderPW As String = ""
        Dim emailChangedOrNot As Boolean = False
        Dim passwordChangedOrNot As Boolean = False

        'Tells user to provide an input for one of the text boxes and executes accordingly
        If txtFirstName.Text = "" And txtLastName.Text = "" And txtAddress.Text = "" And txtCity.Text = "" And txtState.Text = "" And txtZipCode.Text = "" And txtEmail.Text = "" And txtNewPw.Text = "" And txtConfirmPw.Text = "" Then
            MsgBox("Please provide an input into one or more of the input boxes")
        Else
            If txtFirstName.Text = String.Empty And txtFirstName.TextLength = 0 Then
                holderFirstName = lstviewResult.Items(0).SubItems(0).Text
                accountInfoMemberName = CStr(holderFirstName)
            Else
                holderFirstName = CStr(txtFirstName.Text)
                accountInfoMemberName = CStr(holderFirstName)

            End If
            If txtLastName.Text = String.Empty And txtLastName.TextLength = 0 Then
                holderLastName = lstviewResult.Items(0).SubItems(1).Text
            Else
                holderLastName = CStr(txtLastName.Text)
            End If
            If txtAddress.Text = String.Empty And txtAddress.TextLength = 0 Then
                holderStreetAddress = lstviewResult.Items(0).SubItems(2).Text
            Else
                holderStreetAddress = CStr(txtAddress.Text)
            End If
            If txtState.Text = String.Empty And txtState.TextLength = 0 Then
                holderState = lstviewResult.Items(0).SubItems(4).Text
            Else
                holderState = CStr(txtState.Text)
            End If
            If txtCity.Text = String.Empty And txtCity.TextLength = 0 Then
                holderCity = lstviewResult.Items(0).SubItems(3).Text
            Else
                holderCity = CStr(txtCity.Text)
            End If
            If txtZipCode.Text = String.Empty And txtZipCode.TextLength = 0 Then
                holderZipCode = lstviewResult.Items(0).SubItems(5).Text
            Else
                holderZipCode = CStr(txtZipCode.Text)
            End If
            If txtEmail.Text = String.Empty And txtEmail.TextLength = 0 Then
                holderEmail = lstviewResult.Items(0).SubItems(6).Text
            ElseIf checkEmail() Then
                holderEmail = CStr(txtEmail.Text)
                emailChangedOrNot = True
            Else
                MsgBox("Email already in use. Please use another")
                holderEmail = lstviewResult.Items(0).SubItems(6).Text
            End If
            If txtNewPw.Text = String.Empty And txtConfirmPw.Text <> String.Empty Or txtNewPw.Text <> String.Empty And txtConfirmPw.Text = String.Empty Then
                MsgBox("Please confirm the New password by entering in both boxes")
                txtNewPw.Clear()
                txtConfirmPw.Clear()
            Else
                If txtNewPw.Text = String.Empty And txtConfirmPw.Text = String.Empty Then
                    holderPW = grabPW()
                    txtNewPw.Clear()
                    txtConfirmPw.Clear()
                ElseIf txtNewPw.Text = txtConfirmPw.Text Then
                    holderPW = CStr(txtNewPw.Text)
                    passwordChangedOrNot = True
                    txtNewPw.Clear()
                    txtConfirmPw.Clear()
                ElseIf txtNewPw.Text <> txtConfirmPw.Text Then
                    MsgBox("The Passwords are not identical")
                    txtNewPw.Clear()
                    txtConfirmPw.Clear()

                End If
            End If
            updateMemberInfo(holderFirstName, holderLastName, holderStreetAddress, holderCity, holderState, holderZipCode, holderEmail, holderPW, emailChangedOrNot, passwordChangedOrNot)

        End If

    End Sub
    Sub updateMemberInfo(ByVal hFirstName As String, ByVal hLastName As String, ByVal hStreetAddress As String, ByVal hCity As String, ByVal hState As String, ByVal hZipcode As String, ByVal hEmail As String, ByVal hPW As String, ByVal emailChangeOrNot As Boolean, ByVal passwordChangedorNot As Boolean)
        'Updates Member Information in database

        Dim sqlcmd As New SQLiteCommand("UPDATE Member SET FirstName ='" & hFirstName & "', LastName ='" & hLastName & "', StreetAddress ='" & hStreetAddress & "', City ='" & hCity & "', State ='" & hState & "', ZipCode ='" & hZipcode & "', Email ='" & hEmail & "', Password ='" & hPW & "' WHERE MemberID='" & memberID & "';", sqlconn)
        sqlconn.Open()
        sqlcmd.ExecuteReader()
        sqlcmd.Dispose()

        'Display messagebox depending on what the user changed
        If passwordChangedorNot = True Then
            MessageBox.Show(" Password has been changed ")
        End If
        If emailChangeOrNot = True And hEmail = lstviewResult.Items(0).SubItems(6).Text Then
            MsgBox(" Account Information Changed/Updated ")
        ElseIf emailChangeOrNot = True Then
            MessageBox.Show(" Email Address has been changed ")
        ElseIf hFirstName <> lstviewResult.Items(0).SubItems(0).Text Or hLastName <> lstviewResult.Items(0).SubItems(1).Text Or hStreetAddress <> lstviewResult.Items(0).SubItems(2).Text Or hCity <> lstviewResult.Items(0).SubItems(3).Text Or hState <> lstviewResult.Items(0).SubItems(4).Text Or hZipcode <> lstviewResult.Items(0).SubItems(5).Text Then
            MsgBox(" Account Information Changed/Updated ")
        End If

        sqlconn.Close()
        clearEverything()
        showList()

    End Sub

    Sub showList()
        'Shows the listview and the items inside it in frmAccountInfo
        Dim holderMemberName As String
        Dim holderLastName As String
        Dim holderStreetAddress As String
        Dim holderCity As String
        Dim holderState As String
        Dim holderZipCode As String
        Dim holderEmail As String
        Dim holderPW As String
        Dim i As ListViewItem



        Dim sqlcmd1 As New SQLiteCommand("SELECT * FROM Member WHERE MemberID = '" & memberID & "'", sqlconn)
        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()
        sqlcmd1.Dispose()

        If sqlreader.HasRows Then

            Do While sqlreader.Read()
                holderMemberName = sqlreader("FirstName").ToString()
                holderLastName = sqlreader("LastName").ToString()
                holderStreetAddress = sqlreader("StreetAddress").ToString()
                holderCity = sqlreader("City").ToString()
                holderState = sqlreader("State").ToString()
                holderZipCode = sqlreader("ZipCode").ToString()
                holderEmail = sqlreader("Email").ToString()
                holderPW = sqlreader("Password").ToString()


                i = lstviewResult.Items.Add(holderMemberName)
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
    End Sub
    Sub clearEverything()
        'Clears everything in frmAccountInfo
        lstviewResult.Items.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZipCode.Clear()
        txtEmail.Clear()
        txtConfirmPw.Clear()
        txtNewPw.Clear()
    End Sub
    Function grabPW() As String
        'Grabs the password from the database and returns it
        Dim holderPW As String = ""

        Dim sqlcmd1 As New SQLiteCommand("SELECT Password FROM Member WHERE (MemberID = '" & memberID & "')", sqlconn)


        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()
        sqlcmd1.Dispose()

        If sqlreader.Read() = True Then
            holderPW = sqlreader("Password").ToString
        End If
        sqlreader.Close()
        sqlconn.Close()

        Return holderPW
    End Function

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Returns user to the MemberPage
        frmLogin.memberPageListBox()
        Me.Hide()

    End Sub

    Function checkEmail() As Boolean
        'Checks the email and see if the email is used in the database or not
        Dim takenEmail As Boolean
        Dim lastFiveDigits As String = ""

        Dim FindQuery As String = "SELECT * FROM Member WHERE Email='" & txtEmail.Text & "'"

        sqlconn.Open()

        Dim SQLcmd As New SQLiteCommand(FindQuery, sqlconn)
        Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
        If SQLreader.HasRows Then
            takenEmail = False
        Else
            takenEmail = True
        End If
        SQLreader.Close()
        SQLcmd.Dispose()
        sqlconn.Close()
        Return takenEmail
    End Function

    Private Sub frmAccountInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class