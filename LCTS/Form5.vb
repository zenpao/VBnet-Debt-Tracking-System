Imports System.Data.OleDb

Public Class Form5

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable
    Dim objRd As OleDbDataReader
    Dim list As New List(Of Object)
    Friend zero As Integer
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim columnwidth1 As DataGridViewColumn = DataGridView1.Columns(0)
        columnwidth1.Width = 20

        objConn.Open()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT * FROM Clients WHERE Balance > 0 AND Collector = '" & Form1.NameHeader & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)

        Try
            objAdap.Fill(objDt)

            If objDt.Rows.Count > 0 Then
                DataGridView1.DataSource = objDt
                DataGridView1.Columns(1).Visible = False
                DataGridView1.Columns(5).Visible = False
                DataGridView1.Columns(6).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(11).Visible = False
                DataGridView1.Columns(12).Visible = False

            Else
                MsgBox("No Records found.", MsgBoxStyle.OkOnly, "Client List")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
        End Try

    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click

        objConn.Open()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT * WHERE Client_Name LIKE '" & txt_Search.Text & "%'", objConn)
        objAdap = New OleDbDataAdapter(objComm)

        Try
            objAdap.Fill(objDt)

            If objDt.Rows.Count > 0 Then
                DataGridView1.DataSource = objDt
                DataGridView1.Columns(1).Visible = False
                DataGridView1.Columns(5).Visible = False
                DataGridView1.Columns(6).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(11).Visible = False
                DataGridView1.Columns(12).Visible = False
            Else
                MsgBox("No Records found. Search Criteria: SURNAME.", MsgBoxStyle.OkOnly, "Client List")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
        End Try

    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click

        Try
            For Each r As DataGridViewRow In DataGridView1.Rows
                If (r.Cells.Item("Box").Value) = True Then
                    Form6.ClientID = r.Cells.Item("Client_ID").Value
                    Form6.ClientName = r.Cells.Item("Client_Name").Value.ToString
                    Form6.ClientAddress = r.Cells.Item("Client_Address").Value.ToString
                    Form6.CurrentBalance = r.Cells.Item("Balance").Value
                    Form6.Due = r.Cells.Item("Due").Value
                    Form6.CollectorAssigned = r.Cells.Item("Collector").Value.ToString
                    Form6.ShowDialog()
                    'UpdateDataGrid(False) 'TRIGGER TRUE/UNCOMMENT ONLY IF FORM5 HAS IMPORTANT CHANGED THAT NEEDS TO BE SEEN RIGHT AWAY AFTER CLOSING FORM6. ELSE THIS PRODUCES AN ERROR IN VALUE!!
                    Return
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Select one client at a time.")
        End Try

    End Sub

    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click

        Me.Close()
        Form6.Close()
        Form4.Close()

    End Sub

    Sub UpdateDataGrid(ByVal DisplayDialog As Boolean)

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT Client_ID, Client_Name, Client_Address, Contact_Number, Balance, Start_Date, End_Date, Due, Collector FROM Clients WHERE Balance > 0 AND Collector = '" & Form1.NameHeader & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)
        SetDataGrid(DisplayDialog)

    End Sub

    Sub SetDataGrid(ByVal DisplayDialog As Boolean)
        Try
            objAdap.Fill(objDt)
            If objDt.Rows.Count > 0 Then
                DataGridView1.DataSource = objDt
                DataGridView1.Columns(1).Visible = False
                DataGridView1.Columns(5).Visible = False
                DataGridView1.Columns(8).Visible = False
                DataGridView1.Columns(9).Visible = False
            ElseIf DisplayDialog Then
                MsgBox("No Record Found.", MsgBoxStyle.OkOnly, "Try Again.")
            Else
                DataGridView1.DataSource = vbNull
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