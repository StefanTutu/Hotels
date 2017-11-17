Public Class Cerinta6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAfisGrafic.Click

        GraficVarsta.Series.Clear()
        GraficVarsta.Series.Add("liceale")
        GraficVarsta.Series.Add("post-liceale")
        GraficVarsta.Series.Add("universitare")

        Dim n2 = Me.SIADDataSet.Interval1.Rows.Count - 1
        Dim c(n2)
        Dim d(n2)
        For i = 0 To n2
            c(i) = Me.SIADDataSet.Interval1.Rows.Item(i).ItemArray(1).ToString
            d(i) = Me.SIADDataSet.Interval1.Rows.Item(i).ItemArray(0).ToString
            GraficVarsta.Series("liceale").Points.AddXY(d(i), c(i))
        Next
        Dim n3 = Me.SIADDataSet.Interval2.Rows.Count - 1
        Dim j(n3)
        Dim f(n3)
        For i = 0 To n3
            j(i) = Me.SIADDataSet.Interval2.Rows.Item(i).ItemArray(1).ToString
            f(i) = SIADDataSet.Interval2.Rows.Item(i).ItemArray(0).ToString
            GraficVarsta.Series("post-liceale").Points.AddXY(f(i), j(i))
        Next
        Dim n4 = Me.SIADDataSet.Interval3.Rows.Count - 1
        Dim g(n4)
        Dim h(n4)
        For i = 0 To n4
            g(i) = Me.SIADDataSet.Interval3.Rows.Item(i).ItemArray(1).ToString
            h(i) = Me.SIADDataSet.Interval3.Rows.Item(i).ItemArray(0).ToString
            GraficVarsta.Series("universitare").Points.AddXY(h(i), g(i))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.Interval3' table. You can move, or remove it, as needed.
        Me.Interval3TableAdapter.Fill(Me.SIADDataSet.Interval3)
        'TODO: This line of code loads data into the 'SIADDataSet.Interval2' table. You can move, or remove it, as needed.
        Me.Interval2TableAdapter.Fill(Me.SIADDataSet.Interval2)
        'TODO: This line of code loads data into the 'SIADDataSet.Interval1' table. You can move, or remove it, as needed.
        Me.Interval1TableAdapter.Fill(Me.SIADDataSet.Interval1)
        'TODO: This line of code loads data into the 'SIADDataSet.Interval3' table. You can move, or remove it, as needed.
        Me.Interval3TableAdapter.Fill(Me.SIADDataSet.Interval3)
        'TODO: This line of code loads data into the 'SIADDataSet.Interval2' table. You can move, or remove it, as needed.
        Me.Interval2TableAdapter.Fill(Me.SIADDataSet.Interval2)
        'TODO: This line of code loads data into the 'SIADDataSet.Interval1' table. You can move, or remove it, as needed.
        Me.Interval1TableAdapter.Fill(Me.SIADDataSet.Interval1)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub GraficVarsta_Click(sender As Object, e As EventArgs) Handles GraficVarsta.Click

    End Sub
End Class