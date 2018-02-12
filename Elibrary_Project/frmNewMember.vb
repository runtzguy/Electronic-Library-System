Imports System.Data.SQLite
Public Class frmNewMember
    'Opens the database
    Public conn As New SQLiteConnection("Data source = Elibrary.db")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Assigns user input into variables and determines whether or not the user has entered into all of the textboxes and registers new member
        Dim holderFirstName As String = ""
        Dim holderLastName As String = ""
        Dim holderStreetAddress As String = ""
        Dim holderCity As String = ""
        Dim holderState As String = ""
        Dim holderZipCode As String = ""
        Dim holderEmail As String = ""
        Dim holderPW As String = ""

        'Checks to see if the user enters into all of the textboxes
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtStreetAddress.Text = "" Or txtCity.Text = "" Or txtState.Text = "" Or txtZipCode.Text = "" Or txtEmail.Text = "" Or txtPW.Text = "" Or txtConfirmPW.Text = "" Then
            MsgBox("Please fill in all boxes")
        Else
            holderFirstName = CStr(txtFirstName.Text)
            holderLastName = CStr(txtLastName.Text)
            holderStreetAddress = CStr(txtStreetAddress.Text)
            holderCity = CStr(txtCity.Text)
            holderState = CStr(txtState.Text)
            holderZipCode = CStr(txtZipCode.Text)
            'checks if the email is in use or not
            If checkEmail() Then
                holderEmail = CStr(txtEmail.Text)
                'checks the password and see if it is the same as the confirm password
                If txtPW.Text = String.Empty And txtConfirmPW.Text <> String.Empty Or txtPW.Text <> String.Empty And txtConfirmPW.Text = String.Empty Then
                    MsgBox("Please confirm the New password by entering in both boxes")
                    txtPW.Clear()
                    txtConfirmPW.Clear()
                Else
                    If txtPW.Text = txtConfirmPW.Text Then
                        holderPW = CStr(txtPW.Text)
                        registerNewMember(holderFirstName, holderLastName, holderStreetAddress, holderCity, holderState, holderZipCode, holderEmail, holderPW)
                        MsgBox("Congratulations " & holderFirstName & "!" & vbCrLf & "You have successfully registered as a member!")
                        frmLogin.Show()
                        Me.Close()

                    ElseIf txtPW.Text <> txtConfirmPW.Text Then
                        MsgBox("The Passwords are not identical")
                        txtPW.Clear()
                        txtConfirmPW.Clear()

                    End If
                End If
            Else
                txtEmail.Clear()
                MsgBox("Email " & txtEmail.Text & " is already in use" & vbCrLf & "Please choose another email")
            End If

        End If
    End Sub
    Function checkEmail() As Boolean
        'Checks if the email is used or not in the database
        Dim takenEmail As Boolean
        Dim lastFiveDigits As String = ""

        Dim FindQuery As String = "SELECT * FROM Member WHERE Email='" & txtEmail.Text & "'"

        conn.Open()

        Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
        Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
        If SQLreader.HasRows Then
            takenEmail = False
        Else
            takenEmail = True
        End If
        SQLreader.Close()
        SQLcmd.Dispose()
        conn.Close()
        Return takenEmail
    End Function
    Sub registerNewMember(ByVal holderFirstName As String, ByVal holderLastName As String, ByVal holderStreetAddress As String, ByVal holderCity As String, ByVal holderState As String, ByVal holderZipCode As String, ByVal holderEmail As String, ByVal holderPW As String)
        'Register the new member with the given information provided
        Dim newMemberID As String = ""

        newMemberID = getNewMemberID()

        Dim sqlcmd As New SQLiteCommand("INSERT INTO Member (MemberID, FirstName, LastName, StreetAddress, City, State, ZipCode, Email, Password) VALUES ('" & newMemberID & "','" & holderFirstName & "','" & holderLastName & "','" & holderStreetAddress & "','" & holderCity & "','" & holderState & "','" & holderZipCode & "','" & holderEmail & "','" & holderPW & "')", conn)
        conn.Open()
        sqlcmd.ExecuteNonQuery()
        sqlcmd.Dispose()
        conn.Close()

    End Sub
    Function getNewMemberID() As String
        'Get new and unique Member ID
        Dim newFiveDigits As String = ""
        Dim newMemberID As String = ""

        'Finds and returns the last 5 new digits of a new MemberID
        Do While findNewMemberID(newFiveDigits) = False
        Loop

        'Concatenate the new member into the proper format
        newMemberID = "PLIV" + newFiveDigits

        Return newMemberID
    End Function
    Function findNewMemberID(ByRef newFiveDigits As String) As Boolean
        'Finds 5 unique digits for the new member and returns it
        Dim matchOrNot As Boolean
        Dim lastFiveDigits As String = ""

        lastFiveDigits = getNewMemberLastFiveDigits()
        Dim FindQuery As String = "SELECT * FROM Member WHERE MemberID='PLIV" & lastFiveDigits & "'"

        conn.Open()

        Dim SQLcmd As New SQLiteCommand(FindQuery, conn)
        Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
        If SQLreader.HasRows Then
            matchOrNot = False
        Else
            matchOrNot = True
            newFiveDigits = lastFiveDigits
        End If
        SQLreader.Close()
        SQLcmd.Dispose()
        conn.Close()
        Return matchOrNot
    End Function
    Function getNewMemberLastFiveDigits() As String
        'Gets a random number containing 5 digits and returns it
        Dim rng As New Random
        Dim number As Integer = rng.Next(1, 99999)
        Dim digits As String = number.ToString("00000")

        Return digits
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Shows frmlogin and closes the frmNewMember
        frmLogin.Show()
        Me.Close()
    End Sub


End Class