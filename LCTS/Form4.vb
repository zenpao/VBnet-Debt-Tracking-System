Imports System.Data.OleDb

Public Class Form4

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable
    Dim objComm2 As OleDbCommand
    Dim objAdap2 As OleDbDataAdapter
    Dim objDt2 As DataTable
    Dim objRd As OleDbDataReader
    Dim list As New List(Of Object)
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Reset()

    End Sub

    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click

        Me.Close()
        Form6.Close()
        Form5.Close()

    End Sub

    Public Sub Reset()
        
        lst_MonitorAll.Items.Clear()

        objConn.Open()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT Client_Name, Payment_Time, Amount FROM Payments WHERE Collector = '" & Form1.NameHeader & "' AND Payment_Date = '" & DateTime.Now.ToString("MM/dd/yyyy") & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)


        Using reader As OleDbDataReader = objComm.ExecuteReader()
            While (reader.Read())
                Me.lst_MonitorAll.Items.Add(reader(0).ToString + " @" + reader(1).ToString + "      ₱ " + reader(2).ToString)
                list.Add(reader(0).ToString)
            End While
            objConn.Close()
        End Using

        objDt2 = New DataTable
        objComm2 = New OleDbCommand("SELECT SUM(Amount) FROM [Payments] WHERE [Collector] = '" & Form1.NameHeader & "' AND Payment_Date = '" & DateTime.Now.ToString("MM/dd/yyyy") & "'", objConn)
        objAdap2 = New OleDbDataAdapter(objComm2)
        Try
            objConn.Open()
            objAdap2.Fill(objDt2)
            If objDt2.Rows.Count > 0 Then
                lbl_Sum.Text = "₱ " + Convert.ToString(objComm2.ExecuteScalar)
            Else
                MsgBox("No Records Found.", MsgBoxStyle.OkOnly, "NOTE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
        End Try

    End Sub


End Class