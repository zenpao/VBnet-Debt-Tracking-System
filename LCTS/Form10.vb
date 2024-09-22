Imports System.Data.OleDb

Public Class Form10

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable
    Dim objComm2 As OleDbCommand
    Dim objAdap2 As OleDbDataAdapter
    Dim objDt2 As DataTable
    Dim objRd As OleDbDataReader
    Dim list As New List(Of Object)
    Dim list2 As New List(Of Object)

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TabControl1.TabPages.Item(0).Text = "Home"
        Me.TabControl1.TabPages.Item(1).Text = "Collectors"
        Me.TabControl1.TabPages.Item(2).Text = "***"

        lbl_Welcome.Text = "Welcome, " + Form1.NameHeader + "!"

        Reset()

    End Sub

    Private Sub btn_TestDue_Click(sender As Object, e As EventArgs) Handles btn_TestDue.Click

        calcEndDate()

    End Sub
    Private Sub btn_testDb_Click(sender As Object, e As EventArgs) Handles btn_testDb.Click

        DBConnectionStatus()

    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click

        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Form10_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()

    End Sub

    Private Sub lst_Collector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Collector.SelectedIndexChanged

        lst_Client.Items.Clear()

        objConn.Open()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT Client_Name, Payment_Time, Amount FROM Payments WHERE Collector = '" & lst_Collector.SelectedItem.ToString() & "' AND Payment_Date = '" & DateTime.Now.ToString("MM/dd/yyyy") & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)


        Using reader As OleDbDataReader = objComm.ExecuteReader()
            While (reader.Read())
                Me.lst_Client.Items.Add(reader(0).ToString + " @" + reader(1).ToString + "      ₱ " + reader(2).ToString)
                list.Add(reader(0).ToString)
            End While
            objConn.Close()
        End Using

        objDt2 = New DataTable
        objComm2 = New OleDbCommand("SELECT SUM(Amount) FROM [Payments] WHERE [Collector] = '" & lst_Collector.SelectedItem.ToString() & "' AND Payment_Date = '" & DateTime.Now.ToString("MM/dd/yyyy") & "'", objConn)
        objAdap2 = New OleDbDataAdapter(objComm2)
        Try
            objConn.Open()
            objAdap2.Fill(objDt2)
            If objDt2.Rows.Count > 0 Then
                lbl_Sum.Text = "₱ " + Convert.ToString(objComm2.ExecuteScalar)
            Else
                MsgBox("No Record Found.", MsgBoxStyle.OkOnly, "Try again later")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            Reset()
        Finally
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
        End Try

        objConn.Close()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        Reset()

    End Sub
    Public Sub Reset()

        objConn.Open()

        lst_Collector.ClearSelected()
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