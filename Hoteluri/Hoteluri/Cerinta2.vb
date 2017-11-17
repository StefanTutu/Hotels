Public Class Cerinta2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.Iarna' table. You can move, or remove it, as needed.
        Me.IarnaTableAdapter.Fill(Me.SIADDataSet.Iarna)
        'TODO: This line of code loads data into the 'SIADDataSet.Vara' table. You can move, or remove it, as needed.
        Me.VaraTableAdapter.Fill(Me.SIADDataSet.Vara)
        'TODO: This line of code loads data into the 'SIADDataSet.Toamna' table. You can move, or remove it, as needed.
        Me.ToamnaTableAdapter.Fill(Me.SIADDataSet.Toamna)
        'TODO: This line of code loads data into the 'SIADDataSet.Primavara' table. You can move, or remove it, as needed.
        Me.PrimavaraTableAdapter.Fill(Me.SIADDataSet.Primavara)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCereri.Click
        GraficSezon.Series("iarna").Points.Clear()
        GraficSezon.Series("primavara").Points.Clear()
        GraficSezon.Series("vara").Points.Clear()
        GraficSezon.Series("toamna").Points.Clear()

        'GraficSezon.ChartAreas.Clear()
        'GraficSezon.Series.Clear()
        'GraficSezon.Series.Add("iarna")
        'GraficSezon.Series.Add("primavara")
        'GraficSezon.Series.Add("vara")
        'GraficSezon.Series.Add("toamna")
        'GraficSezon.Series.ChartType(Spline)
        Dim n2 = Me.SIADDataSet.Iarna.Rows.Count - 1
        Dim c(n2)
        Dim d(n2)
        For i = 0 To n2
            c(i) = Me.SIADDataSet.Iarna.Rows.Item(i).ItemArray(1).ToString
            d(i) = Me.SIADDataSet.Iarna.Rows.Item(i).ItemArray(0).ToString
            GraficSezon.Series("iarna").Points.AddXY(d(i), c(i))
        Next
        Dim n3 = Me.SIADDataSet.Primavara.Rows.Count - 1
        Dim j(n3)
        Dim f(n3)
        For i = 0 To n3
            j(i) = Me.SIADDataSet.Primavara.Rows.Item(i).ItemArray(1).ToString
            f(i) = SIADDataSet.Primavara.Rows.Item(i).ItemArray(0).ToString
            GraficSezon.Series("primavara").Points.AddXY(f(i), j(i))
        Next
        Dim n4 = Me.SIADDataSet.Vara.Rows.Count - 1
        Dim g(n4)
        Dim h(n4)
        For i = 0 To n4
            g(i) = Me.SIADDataSet.Vara.Rows.Item(i).ItemArray(1).ToString
            h(i) = Me.SIADDataSet.Vara.Rows.Item(i).ItemArray(0).ToString
            GraficSezon.Series("vara").Points.AddXY(h(i), g(i))
        Next

        Dim n5 = Me.SIADDataSet.Toamna.Rows.Count - 1
        Dim m(n5)
        Dim k(n5)
        For i = 0 To n5
            m(i) = Me.SIADDataSet.Toamna.Rows.Item(i).ItemArray(1).ToString
            k(i) = Me.SIADDataSet.Toamna.Rows.Item(i).ItemArray(0).ToString
            GraficSezon.Series("toamna").Points.AddXY(h(i), g(i))
        Next
    End Sub

    Private Sub Cerinta2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.Iarna' table. You can move, or remove it, as needed.
        Me.IarnaTableAdapter.Fill(Me.SIADDataSet.Iarna)
        'TODO: This line of code loads data into the 'SIADDataSet.Vara' table. You can move, or remove it, as needed.
        Me.VaraTableAdapter.Fill(Me.SIADDataSet.Vara)
        'TODO: This line of code loads data into the 'SIADDataSet.Toamna' table. You can move, or remove it, as needed.
        Me.ToamnaTableAdapter.Fill(Me.SIADDataSet.Toamna)
        'TODO: This line of code loads data into the 'SIADDataSet.Primavara' table. You can move, or remove it, as needed.
        Me.PrimavaraTableAdapter.Fill(Me.SIADDataSet.Primavara)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class