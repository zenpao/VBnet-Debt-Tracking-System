Imports System.Data.OleDb

Public Class Form3

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAccounts.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lbl_Welcome.Text = "Welcome, " + Form1.NameHeader + "!"

    End Sub

    Private Sub btn_List_Click(sender As Object, e As EventArgs) Handles btn_List.Click

        Form4.ShowDialog()

    End Sub

    Private Sub btn_Profile_Click(sender As Object, e As EventArgs) Handles btn_Profile.Click

        Form5.ShowDialog()

    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click

        Me.Close()
        Form1.Show()

    End Sub


    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()

    End Sub

End Class