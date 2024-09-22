Imports System.Data.OleDb

Public Class Form2

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable
    Dim objComm2 As OleDbCommand
    Dim objAdap2 As OleDbDataAdapter
    Dim objDt2 As DataTable
    Dim objRd As OleDbDataReader
    Dim list As New List(Of Object)
    Public administrator As String
    Public authorization As String
    Public masterKey As String
    Public grantType As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TabControl1.TabPages.Item(0).Text = "Registration Tab"
        Me.TabControl1.TabPages.Item(1).Text = "***"
        'Me.TabControl1.TabPages(1).Enabled = False

        Reset()

    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click

        'Try

        '    objComm = New OleDbCommand("INSERT INTO Employees VALUES ('" & CInt(txt_EmpID.Text) & "','" & txt_EmpName.Text & "','" & txt_ContactNum.Text & "','" & txt_Password.Text & "')", objConn)
        '    objAdap = New OleDbDataAdapter(objComm)
        '    objDt = New DataTable
        '    objAdap.Fill(objDt)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        RandomGenerator()

        Dim mergeMID As String
        Dim mergeCID As String
        Dim mergedFullName As String
        Dim mergeID As New System.Text.StringBuilder()
        Dim mergeID2 As New System.Text.StringBuilder()
        Dim mergeNames As New System.Text.StringBuilder()
        mergeMID = mergeID.Append("" + DateValue(Now).Year.ToString()).Append("" + txt_ID.Text).ToString
        mergeCID = mergeID2.Append("" + DateValue(Now).Day.ToString()).Append("" + txt_ID.Text).ToString
        mergedFullName = mergeNames.Append("" + txt_LastName.Text).Append(", ").Append("" + txt_FirstName.Text).Append(" " + txt_MiddleName.Text).ToString()

        Dim endDate As DateTime
        endDate = Convert.ToDateTime(DateTimePicker2.Value.Date.ToString("MM/dd/yyyy"))
        Try
            endDate = endDate.AddDays(CDbl(txt_Due.Text))
        Catch ex As Exception
        End Try

        'MessageBox.Show(endDate.ToString("MM/dd/yyyy"))

        Dim retryCount As Integer = 0
        Dim wasSuccessful As Boolean = False

        Dim SaveType As String = cmb_Type.SelectedItem.ToString

        Select Case SaveType
            Case "Management", "Collector"
                If (txt_Password.Text = txt_CheckPass.Text) Then

                    Do
                        Try
                            objComm = New OleDbCommand("INSERT INTO Employees VALUES ('" & CInt(mergeMID) & "','" & mergedFullName & "','" & txt_Address.Text & "','" & txt_ContactNum.Text & "','" & DateTimePicker1.Value.Date.ToString("MM/dd/yyyy") & "','" & txt_Email.Text & "','" & txt_Password.Text & "','" & cmb_Type.SelectedItem.ToString & "')", objConn)
                            objAdap = New OleDbDataAdapter(objComm)
                            objDt = New DataTable
                            objAdap.Fill(objDt)
                            'set wasSuccessful if everything was okay.'
                            wasSuccessful = True
                            MsgBox("Log into your account using the ID: " + mergeMID, MsgBoxStyle.Information, "Registration Successful")
                            Reset()

                        Catch
                            retryCount += 1
                        End Try
                    Loop Until wasSuccessful = True OrElse retryCount >= 5
                    'check if the statements were unsuccessful'
                    If Not wasSuccessful Then
                        MsgBox("Fill-up each field with the proper format and save. If the problem still occurs, please try again.", MsgBoxStyle.Exclamation, "Registration Failure")
                        txt_ID.Clear()
                    End If

                Else
                    MsgBox("Password does not match. Try again", MsgBoxStyle.Exclamation, "Registration Failure")
                    txt_Password.Clear()
                    txt_CheckPass.Clear()
                End If

            Case "Client"
                Do
                    Try
                        objComm = New OleDbCommand("INSERT INTO Clients VALUES ('" & CInt(mergeCID) & "','" & mergedFullName & "','" & txt_Address.Text & "','" & txt_ContactNum.Text & "','" & DateTimePicker1.Value.Date.ToString("MM/dd/yyyy") & "','" & txt_Email.Text & "','" & cmb_Type.SelectedItem.ToString & "','" & CInt(txt_Balance.Text) & "','" & DateTimePicker2.Value.Date.ToString("MM/dd/yyyy") & "','" & endDate & "','" & CInt(txt_Due.Text) & "','" & lst_Collector.SelectedItem.ToString & "')", objConn)
                        objAdap = New OleDbDataAdapter(objComm)
                        objDt = New DataTable
                        objAdap.Fill(objDt)
                        'set wasSuccessful if everything was okay.'
                        wasSuccessful = True
                        MsgBox("Client registered.", MsgBoxStyle.Information, "Registration Successful")
                        Reset()

                    Catch
                        retryCount += 1
                    End Try
                Loop Until wasSuccessful = True OrElse retryCount >= 5
                'check if the statements were unsuccessful'
                If Not wasSuccessful Then
                    MsgBox("Fill-up each field with the proper format and save. If the problem still occurs, please try again.", MsgBoxStyle.Exclamation, "Registration Failure")
                    txt_ID.Clear()
                End If

        End Select


    End Sub

    Private Sub lnk_Reset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Reset.LinkClicked

        Reset()

    End Sub

    Private Sub cmb_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Type.SelectedIndexChanged

        'objDt2 = New DataTable
        'objComm2 = New OleDbCommand("SELECT [Master_Key] FROM [Authorization] WHERE Admin_ID = 1", objConn)
        'objAdap2 = New OleDbDataAdapter(objComm2)

        'Try
        '    objConn.Open()
        '    objAdap2.Fill(objDt2)
        '    If objDt2.Rows.Count > 0 Then
        '        masterKey = Convert.ToString(objComm2.ExecuteScalar)
        '    Else
        '        MsgBox("No password restriction set.", MsgBoxStyle.OkOnly, "NOTE")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    If objConn.State = ConnectionState.Open Then
        '        objConn.Close()
        '    End If
        'End Try


        Try
            grantType = cmb_Type.SelectedItem.ToString()
            Select Case grantType
                Case "Management"
                    'authorization = InputBox("Access code: ", "Authorization", "")
                    'If (authorization.Equals(masterKey)) Then
                    txt_ID.Clear()
                    txt_LastName.Clear()
                    txt_FirstName.Clear()
                    txt_MiddleName.Clear()
                    txt_Address.Clear()
                    txt_ContactNum.Clear()
                    txt_Email.Clear()
                    txt_Password.Clear()
                    txt_CheckPass.Clear()
                    txt_Balance.Clear()
                    txt_Due.Clear()
                    lst_Collector.ClearSelected()

                    txt_ID.Enabled = False
                    txt_LastName.Enabled = True
                    txt_FirstName.Enabled = True
                    txt_MiddleName.Enabled = True
                    txt_Address.Enabled = True
                    txt_ContactNum.Enabled = True
                    DateTimePicker1.Enabled = True
                    DateTimePicker2.Enabled = False
                    txt_Email.Enabled = True
                    txt_Password.Enabled = True
                    txt_CheckPass.Enabled = True
                    txt_Balance.Enabled = False
                    txt_Due.Enabled = False
                    lst_Collector.Enabled = False
                    btn_Register.Enabled = True
                    'Else
                    'MsgBox("Password mismatch. Try again.", MsgBoxStyle.Critical, "Access denied")
                    'Reset()
                    'End If

                Case "Collector"
                    txt_ID.Clear()
                    txt_LastName.Clear()
                    txt_FirstName.Clear()
                    txt_MiddleName.Clear()
                    txt_Address.Clear()
                    txt_ContactNum.Clear()
                    txt_Email.Clear()
                    txt_Password.Clear()
                    txt_CheckPass.Clear()
                    txt_Balance.Clear()
                    txt_Due.Clear()
                    lst_Collector.ClearSelected()

                    txt_ID.Enabled = False
                    txt_LastName.Enabled = True
                    txt_FirstName.Enabled = True
                    txt_MiddleName.Enabled = True
                    txt_Address.Enabled = True
                    txt_ContactNum.Enabled = True
                    DateTimePicker1.Enabled = True
                    DateTimePicker2.Enabled = False
                    txt_Email.Enabled = True
                    txt_Password.Enabled = True
                    txt_CheckPass.Enabled = True
                    txt_Balance.Enabled = False
                    txt_Due.Enabled = False
                    lst_Collector.Enabled = False
                    btn_Register.Enabled = True

                Case "Client"
                    txt_ID.Clear()
                    txt_LastName.Clear()
                    txt_FirstName.Clear()
                    txt_MiddleName.Clear()
                    txt_Address.Clear()
                    txt_ContactNum.Clear()
                    txt_Email.Clear()
                    txt_Password.Clear()
                    txt_CheckPass.Clear()
                    txt_Balance.Clear()
                    txt_Due.Clear()
                    lst_Collector.ClearSelected()

                    txt_ID.Enabled = False
                    txt_LastName.Enabled = True
                    txt_FirstName.Enabled = True
                    txt_MiddleName.Enabled = True
                    txt_Address.Enabled = True
                    txt_ContactNum.Enabled = True
                    DateTimePicker1.Enabled = True
                    DateTimePicker2.Enabled = True
                    txt_Email.Enabled = True
                    txt_Password.Enabled = False
                    txt_CheckPass.Enabled = False
                    txt_Balance.Enabled = True
                    txt_Due.Enabled = True
                    lst_Collector.Enabled = True
                    btn_Register.Enabled = True

            End Select
            objConn.Close()
        Catch ex As Exception
            Reset()
        End Try

        'If (cmb_Type.SelectedIndex = 0) Then
        '    txt_ID.Clear()
        '    txt_LastName.Clear()
        '    txt_FirstName.Clear()
        '    txt_MiddleName.Clear()
        '    txt_Address.Clear()
        '    txt_ContactNum.Clear()
        '    txt_Email.Clear()
        '    txt_Password.Clear()
        '    txt_CheckPass.Clear()
        '    txt_Balance.Clear()
        '    txt_Due.Clear()
        '    lst_Collector.ClearSelected()

        '    txt_ID.Enabled = False
        '    txt_LastName.Enabled = True
        '    txt_FirstName.Enabled = True
        '    txt_MiddleName.Enabled = True
        '    txt_Address.Enabled = True
        '    txt_ContactNum.Enabled = True
        '    DateTimePicker1.Enabled = True
        '    DateTimePicker2.Enabled = False
        '    txt_Email.Enabled = True
        '    txt_Password.Enabled = True
        '    txt_CheckPass.Enabled = True
        '    txt_Balance.Enabled = False
        '    txt_Due.Enabled = False
        '    lst_Collector.Enabled = False
        '    btn_Register.Enabled = True

        'ElseIf (cmb_Type.SelectedIndex = 1) Then
        '    txt_ID.Clear()
        '    txt_LastName.Clear()
        '    txt_FirstName.Clear()
        '    txt_MiddleName.Clear()
        '    txt_Address.Clear()
        '    txt_ContactNum.Clear()
        '    txt_Email.Clear()
        '    txt_Password.Clear()
        '    txt_CheckPass.Clear()
        '    txt_Balance.Clear()
        '    txt_Due.Clear()
        '    lst_Collector.ClearSelected()

        '    txt_ID.Enabled = False
        '    txt_LastName.Enabled = True
        '    txt_FirstName.Enabled = True
        '    txt_MiddleName.Enabled = True
        '    txt_Address.Enabled = True
        '    txt_ContactNum.Enabled = True
        '    DateTimePicker1.Enabled = True
        '    DateTimePicker2.Enabled = False
        '    txt_Email.Enabled = True
        '    txt_Password.Enabled = True
        '    txt_CheckPass.Enabled = True
        '    txt_Balance.Enabled = False
        '    txt_Due.Enabled = False
        '    lst_Collector.Enabled = False
        '    btn_Register.Enabled = True

        'ElseIf (cmb_Type.SelectedIndex = 2) Then
        '    txt_ID.Clear()
        '    txt_LastName.Clear()
        '    txt_FirstName.Clear()
        '    txt_MiddleName.Clear()
        '    txt_Address.Clear()
        '    txt_ContactNum.Clear()
        '    txt_Email.Clear()
        '    txt_Password.Clear()
        '    txt_CheckPass.Clear()
        '    txt_Balance.Clear()
        '    txt_Due.Clear()
        '    lst_Collector.ClearSelected()

        '    txt_ID.Enabled = False
        '    txt_LastName.Enabled = True
        '    txt_FirstName.Enabled = True
        '    txt_MiddleName.Enabled = True
        '    txt_Address.Enabled = True
        '    txt_ContactNum.Enabled = True
        '    DateTimePicker1.Enabled = True
        '    DateTimePicker2.Enabled = True
        '    txt_Email.Enabled = True
        '    txt_Password.Enabled = False
        '    txt_CheckPass.Enabled = False
        '    txt_Balance.Enabled = True
        '    txt_Due.Enabled = True
        '    lst_Collector.Enabled = True
        '    btn_Register.Enabled = True
        'End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        Reset()

    End Sub
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click

        Me.Close()
        Form1.Show()

    End Sub
    Private Sub btn_TestDue_Click(sender As Object, e As EventArgs) Handles btn_TestDue.Click

        calcEndDate()

    End Sub
    Private Sub btn_testDb_Click(sender As Object, e As EventArgs) Handles btn_testDb.Click

        DBConnectionStatus()

    End Sub


    Public Sub RandomGenerator()

        Dim intNumber As Integer
        Dim arrNumber(0 To 3) As Integer
        Dim i, x, y As Integer

        For x = 0 To 3
Start:
            Randomize()
            intNumber = Int((9 * Rnd()) + 1) ' Random number 1 to 9
            For y = 0 To 3
                ' Check arrNumber (y)
                'If intnumber has already been selected,
                'Then go and select another one.
                If intNumber = arrNumber(y) Then
                    GoTo Start
                End If
            Next y

            'Place the next non-repeated number in the arrNumber(x).
            arrNumber(x) = intNumber

        Next x
        '----------------------------------------------------

        For i = 0 To 3
            txt_ID.Text = CInt(txt_ID.Text & (arrNumber(i)))
        Next

    End Sub

    Public Sub Reset()

        Form1.txt_UserID.Clear()
        Form1.txt_Password.Clear()

        cmb_Type.SelectedIndex() = -1
        txt_ID.Clear()
        txt_LastName.Clear()
        txt_FirstName.Clear()
        txt_MiddleName.Clear()
        txt_Address.Clear()
        txt_ContactNum.Clear()
        txt_Email.Clear()
        txt_Password.Clear()
        txt_CheckPass.Clear()
        txt_Balance.Clear()
        txt_Due.Clear()
        lst_Collector.Items.Clear()
        lst_Collector.ClearSelected()

        txt_ID.Enabled = False
        txt_LastName.Enabled = False
        txt_FirstName.Enabled = False
        txt_MiddleName.Enabled = False
        txt_Address.Enabled = False
        txt_ContactNum.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        txt_Email.Enabled = False
        txt_Password.Enabled = False
        txt_CheckPass.Enabled = False
        txt_Balance.Enabled = False
        txt_Due.Enabled = False
        lst_Collector.Enabled = False
        btn_Register.Enabled = False

        objConn.Open()

        lst_Collector.Items.Clear()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT Employee_Name FROM Employees WHERE Type = '" & "Collector" & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)


        Using reader As OleDbDataReader = objComm.ExecuteReader()
            While (reader.Read())
                Me.lst_Collector.Items.Add(reader(0).ToString)
                list.Add(reader(0).ToString)
            End While
            objConn.Close()
        End Using

        objConn.Close()

    End Sub

    Private Function DBConnectionStatus() As Boolean
        Try
            Using mdbConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
                mdbConn.Open()
                Return MsgBox("Status: " & (mdbConn.State = ConnectionState.Open) & ". Database is connected.", MsgBoxStyle.Information, "ACTIVE")
            End Using
        Catch e1 As OleDbException
            Return MsgBox("Status: " & False & ". Database disconnected. Contact administrator.", MsgBoxStyle.Critical, "INACTIVE")
        Catch e2 As Exception
            Return MsgBox("Status: " & False & ". Database disconnected. Contact administrator.", MsgBoxStyle.Critical, "INACTIVE")
        End Try
    End Function

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()

    End Sub

    Private Sub calcEndDate()

        Dim sampleDate As String
        Dim sampleDue As String
        Dim endDate As DateTime

        Try
            'endDate = Convert.ToDateTime(DateTimePicker2.Value.Date.ToString("MM/dd/yyyy"))
            'endDate = endDate.AddDays(CDbl(txt_Due.Text))

            sampleDate = InputBox("Enter Date: ", "Test Due date", "MM/dd/yyyy")
            sampleDue = InputBox("Enter Due: ", "Test Due date", "")
            endDate = Convert.ToDateTime(sampleDate)
            endDate = endDate.AddDays(CDbl(sampleDue))
            MessageBox.Show("Due on: " + endDate.ToString("MM/dd/yyyy"))

        Catch ex As Exception
            MsgBox("Invalid value/format: " + ex.Message)
        End Try

    End Sub

End Class