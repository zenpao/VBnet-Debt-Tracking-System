Imports System.Data.OleDb

Public Class Form1

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable
    Public empID As Integer
    Public NameHeader As String
    Public empType As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_UserID.Clear()
        txt_Password.Clear()

    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT * FROM Employees where Employee_ID=" & CInt(txt_UserID.Text) & "AND Password ='" & txt_Password.Text & "' ", objConn)
        objAdap = New OleDbDataAdapter(objComm)
        objConn.Open()

        Dim oledbreader As OleDbDataReader = objComm.ExecuteReader()
        If (oledbreader.Read() = True) Then
            empType = oledbreader(7)
            NameHeader = oledbreader(1)
            empID = oledbreader(0)
            MessageBox.Show("Welcome " + NameHeader + " !", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Select Case empType
                Case "Management"
                    txt_UserID.Clear()
                    txt_Password.Clear()
                    Me.Hide()
                    Form10.ShowDialog()
                Case "Collector"
                    txt_UserID.Clear()
                    txt_Password.Clear()
                    Me.Hide()
                    Form3.ShowDialog()
            End Select
        Else
            MessageBox.Show("Invalid username or password! Try again.")
        End If
        objConn.Close()

    End Sub

    Private Sub lnk_Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Register.LinkClicked

        Me.Hide()
        Form2.ShowDialog()

    End Sub

End Class
