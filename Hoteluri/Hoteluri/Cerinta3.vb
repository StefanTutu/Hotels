Imports System.Data.OleDb

Public Class Cerinta3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'GraficSezon.Series("iarna").Points.Clear()
        Chart1.Series.Clear()
        Chart1.Series.Add("CampaniiPublicitare")

        Dim no_of_rec = Me.SIADDataSet.CampaniiPublicitare.Rows.Count - 1
        Dim q(no_of_rec)
        Dim n(no_of_rec)
        For i = 0 To no_of_rec
            q(i) = Me.SIADDataSet.CampaniiPublicitare.Rows.Item(i).ItemArray(5).ToString
            n(i) = Me.SIADDataSet.CampaniiPublicitare.Rows.Item(i).ItemArray(1).ToString
            Chart1.Series("CampaniiPublicitare").Points.AddXY(n(i), q(i))
        Next


        'Dim exp_int(5, 1) As Integer
        'exp_int(0, 0) = 20
        '' exp_int(1, 0) = 30
        ''exp_int(2, 0) = 40
        ''exp_int(3, 0) = 50
        '' exp_int(4, 0) = 60
        '' exp_int(5, 0) = 70
        '' exp_int(0, 1) = 70
        '' exp_int(1, 1) = 100
        '' exp_int(2, 1) = 120
        '' exp_int(3, 1) = 130
        '' exp_int(4, 1) = 140
        '' exp_int(5, 1) = 10


        ''  For i = 1 To 6
        ''Me.Chart1.Series("Varsta").Points.AddXY("Varsta de" & i.ToString, exp_int(i - 1, 0))
        '' Me.Chart1.Series("Studii").Points.AddXY("Studii de " & i.ToString, exp_int(i - 1, 1))

        ''  Next i
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.CampaniiPublicitare' table. You can move, or remove it, as needed.
        Me.CampaniiPublicitareTableAdapter.Fill(Me.SIADDataSet.CampaniiPublicitare)
        'TODO: This line of code loads data into the 'SIADDataSet.CampaniiPublicitare' table. You can move, or remove it, as needed.
        Me.CampaniiPublicitareTableAdapter.Fill(Me.SIADDataSet.CampaniiPublicitare)
        'TODO: This line of code loads data into the 'SIAD1DataSet.Campanii_Publicitare' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        Dim dataFile = "D:\FEAA\Master - SIA\An 1\Sem 1\SIAD\Proiect - Hotel\SIAD.accdb"
        conn.ConnectionString = provider & dataFile
        conn.Open()
        Chart2.Series("CampaniiPublicitare").Points.Clear()
        'Chart2.Series.Clear()
        'Chart2.Series.Add("CampaniiPublicitare")

        Dim q = "SELECT CampaniiPublicitare.[Nume], Sum(CampaniiPublicitare.Cheltuieli) AS Cheltuieli FROM CampaniiPublicitare GROUP BY CampaniiPublicitare.[Nume]"
        Dim cmd As OleDbCommand = New OleDbCommand(q, conn)
        Dim da As New OleDbDataAdapter(q, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            Chart2.Series("CampaniiPublicitare").Points.AddXY(dr("Nume").ToString, dr("Cheltuieli").ToString)



        End While
        dr.Close()
        cmd.Dispose()
        Dim ds = New DataSet
        da.Fill(ds, "CampaniiPublicitare")
        DataGridView1.DataMember = "CampaniiPublicitare"
        DataGridView1.DataSource = ds
    End Sub

    Private Sub CampaniiPublicitareBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CampaniiPublicitareBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CampaniiPublicitareBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class