Imports System.Data.OleDb

Public Class Cerinta4
    Private Sub FeedbackBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FeedbackBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.Feedback' table. You can move, or remove it, as needed.
        Me.FeedbackTableAdapter.Fill(Me.SIADDataSet.Feedback)
        'TODO: This line of code loads data into the 'SIADDataSet.Feedback' table. You can move, or remove it, as needed.
        Me.FeedbackTableAdapter.Fill(Me.SIADDataSet.Feedback)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Chart1.Series("Feedback").Points.Clear()

        Dim conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        Dim dataFile = "D:\FEAA\Master - SIA\An 1\Sem 1\SIAD\Proiect - Hotel\SIAD.accdb"
        conn.ConnectionString = provider & dataFile
        conn.Open()

        'Chart1.Series.Clear()
        'Chart1.Series.Add("Feedback")

        Dim q = "SELECT Feedback.[Cauza], COUNT(Feedback.idFeedback) AS Clienti FROM Feedback GROUP BY Feedback.[Cauza]"
        Dim cmd As OleDbCommand = New OleDbCommand(q, conn)
        Dim da As New OleDbDataAdapter(q, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            Chart1.Series("Feedback").Points.AddXY(dr("Cauza").ToString, dr("Clienti").ToString)



        End While
        dr.Close()
        cmd.Dispose()
        Dim ds = New DataSet
        da.Fill(ds, "Feedback")
        DataGridView1.DataMember = "Feedback"
        DataGridView1.DataSource = ds
    End Sub

    Private Sub FeedbackBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles FeedbackBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FeedbackBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class