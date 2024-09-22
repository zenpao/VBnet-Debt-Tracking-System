Imports System.Data.OleDb

Public Class Form6

    Friend ClientID As Integer
    Friend ClientName As String
    Friend ClientAddress As String
    Friend CurrentBalance As Integer
    Friend Due As Integer
    Friend CollectorAssigned As String
    Friend deductedValue As Integer
    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable
    Dim objComm2 As OleDbCommand
    Dim objAdap2 As OleDbDataAdapter
    Dim objDt2 As DataTable
    Dim objRd As OleDbDataReader
    Dim list As New List(Of Object)
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TabControl1.TabPages.Item(0).Text = "Client Profile"
        Me.TabControl1.TabPages.Item(1).Text = "Collect"

        txt_Payment.Clear()

        lbl_Name.Text = ClientName
        lbl_Current.Text = "₱ " + CStr(CurrentBalance)
        lbl_Address.Text = ClientAddress
        lbl_DueNum.Text = Due
        lbl_Name2.Text = ClientName
        lbl_Current2.Text = "₱ " + CStr(CurrentBalance)

        Reset()

    End Sub

    Private Sub btn_NewBalance_Click(sender As Object, e As EventArgs) Handles btn_NewBalance.Click

        If (CInt(txt_Payment.Text) > CurrentBalance) Then
            MsgBox("Input a valid amount.", MsgBoxStyle.Exclamation, "NOTE")
            txt_Payment.Clear()

        ElseIf (CInt(txt_Payment.Text) <= CurrentBalance) Then
            deductedValue = CurrentBalance - CInt(txt_Payment.Text)
            lbl_Current.Text = "₱ " + CStr(deductedValue)
            lbl_Current2.Text = "₱ " + CStr(deductedValue)

            For Each r As DataGridViewRow In Form5.DataGridView1.Rows
                If (r.Cells.Item("Box").Value) = True Then
                    Try
                        objConn.Open()
                        objComm = New OleDbCommand("UPDATE Clients SET " & "Balance ='" & deductedValue & "' WHERE Client_ID =" & ClientID, objConn)
                        objComm.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Return
                    Finally
                        If objConn.State = ConnectionState.Open Then
                            objConn.Close()
                        End If
                    End Try
                End If
            Next

                    Try

                        objComm = New OleDbCommand("INSERT INTO Payments VALUES ('" & DateTime.Now.ToString("MM/dd/yyyy") & "','" & DateTime.Now.ToString("HH:mm tt") & "','" & ClientName & "','" & deductedValue & "','" & CInt(txt_Payment.Text) & "','" & Due & "','" & CollectorAssigned & "')", objConn)
                        'DateTime.Now.ToString("MM/dd/yyyy HH:mm tt")
                        objAdap = New OleDbDataAdapter(objComm)
                        objDt = New DataTable
                        objAdap.Fill(objDt)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If

                CurrentBalance = CurrentBalance - CInt(txt_Payment.Text)
                txt_Payment.Clear()
                Reset()
        UpdateDataGrid(True) 'TRIGGER TRUE/UNCOMMENT ONLY IF FORM5 HAS IMPORTANT CHANGED THAT NEEDS TO BE SEEN RIGHT AWAY AFTER CLOSING FORM6. ELSE THIS PRODUCES AN ERROR IN VALUE!!

    End Sub

    Public Sub Reset()

        lst_Monitor.Items.Clear()

        objConn.Open()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT Payment_Date, Payment_Time, Amount FROM Payments WHERE Client_Name = '" & ClientName & "' AND Payment_Date = '" & DateTime.Now.ToString("MM/dd/yyyy") & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)


        Using reader As OleDbDataReader = objComm.ExecuteReader()
            While (reader.Read())
                Me.lst_Monitor.Items.Add(reader(0).ToString + " @" + reader(1).ToString + "      ₱ " + reader(2).ToString)
                list.Add(reader(0).ToString)
            End While
            objConn.Close()
        End Using

        objDt2 = New DataTable
        objComm2 = New OleDbCommand("SELECT SUM(Amount) FROM Payments WHERE Client_Name = '" & ClientName & "' AND Payment_Date = '" & DateTime.Now.ToString("MM/dd/yyyy") & "'", objConn)
        objAdap2 = New OleDbDataAdapter(objComm2)
        Try
            objConn.Open()
            objAdap2.Fill(objDt2)
            If objDt2.Rows.Count > 0 Then
                lbl_Sum.Text = "₱ " + Convert.ToString(objComm2.ExecuteScalar)
            Else
                MsgBox("No Records Found.", MsgBoxStyle.OkOnly, "EMPTY")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
        End Try

    End Sub

    Sub UpdateDataGrid(ByVal DisplayDialog As Boolean)

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT * FROM Clients WHERE Balance > 0 AND Collector = '" & Form1.NameHeader & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)
        SetDataGrid(DisplayDialog)

    End Sub

    Sub SetDataGrid(ByVal DisplayDialog As Boolean)
        Try
            objAdap.Fill(objDt)
            If objDt.Rows.Count > 0 Then
                Form5.DataGridView1.DataSource = objDt
                Form5.DataGridView1.Columns(1).Visible = False
                Form5.DataGridView1.Columns(5).Visible = False
                Form5.DataGridView1.Columns(6).Visible = False
                Form5.DataGridView1.Columns(7).Visible = False
                Form5.DataGridView1.Columns(11).Visible = False
                Form5.DataGridView1.Columns(12).Visible = False
            ElseIf DisplayDialog Then
                'MsgBox("No clients to display.", MsgBoxStyle.OkOnly, "NOTE")
            Else
                Form5.DataGridView1.DataSource = vbNull
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
        End Try
    End Sub

    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click

        Me.Close()
        Form5.Close()
        Form4.Close()

    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click

        Me.Close()

    End Sub

End Class