Public Class Cerinta5


    Public Shared trendline As Integer
    Public Shared trendlineRo As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Chart1.Series("Estimare (luni)").Points.Clear()
        Dim n = Me.SIADDataSet.CampaniiPublicitare.Rows.Count
        Dim x(n) As Double
        Dim y(n) As Double
        Dim sum_of_xy As Double = 0
        Dim sum_of_xx As Double = 0
        Dim sum_of_x = 0
        Dim sum_of_y = 0
        For i = 0 To n - 1
            x(i) = i + 1
            y(i) = Me.SIADDataSet.CampaniiPublicitare.Rows(i).Item("Cheltuieli")
            sum_of_xy = sum_of_xy + (x(i) * y(i))
            sum_of_xx = sum_of_xx + (x(i) * x(i))
            sum_of_x = sum_of_x + x(i)
            sum_of_y = sum_of_y + y(i)
        Next
        Dim alpha As Double
        alpha = ((n * sum_of_xy) - (sum_of_x * sum_of_y)) / ((n * sum_of_xx) - (sum_of_x * sum_of_x))
        Dim beta As Double
        beta = (sum_of_y - (alpha * sum_of_x)) / n
        Dim months = Me.SIADDataSet.CampaniiPublicitare.Rows(0).Item("Data inceput")
        Dim month As Double
        month = DateAndTime.Month(months)
        Dim result As Double
        result = Convert.ToDouble(TextBox1.Text.ToString)
        Dim input_x = (result - month + 1)
        Dim pred_y As Double
        pred_y = (alpha * input_x) + beta
        For i = 0 To n - 1
            Chart1.Series("Estimare (luni)").Points.AddXY((month + i), y(i))
        Next
        Chart1.Series("Estimare (luni)").Points.AddXY((input_x + month - 1), pred_y)
        TextBox1.Text = pred_y.ToString

    End Sub

    Private Sub CampaniiPublicitareBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CampaniiPublicitareBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CampaniiPublicitareBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub

    Private Sub Cerinta5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.CampaniiPublicitare' table. You can move, or remove it, as needed.
        Me.CampaniiPublicitareTableAdapter.Fill(Me.SIADDataSet.CampaniiPublicitare)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Chart2.Series("Estimare (ani)").Points.Clear()

        Dim n = Me.SIADDataSet.CampaniiPublicitare.Rows.Count
        Dim x(n) As Double
        Dim y(n) As Double
        Dim sum_of_xy As Double = 0
        Dim sum_of_xx As Double = 0
        Dim sum_of_x = 0
        Dim sum_of_y = 0
        For i = 0 To n - 1
            x(i) = i + 1
            y(i) = Me.SIADDataSet.CampaniiPublicitare.Rows(i).Item("Cheltuieli")
            sum_of_xy = sum_of_xy + (x(i) * y(i))
            sum_of_xx = sum_of_xx + (x(i) * x(i))
            sum_of_x = sum_of_x + x(i)
            sum_of_y = sum_of_y + y(i)
        Next
        Dim alpha As Double
        alpha = ((n * sum_of_xy) - (sum_of_x * sum_of_y)) / ((n * sum_of_xx) - (sum_of_x * sum_of_x))
        Dim beta As Double
        beta = (sum_of_y - (alpha * sum_of_x)) / n
        Dim years = Me.SIADDataSet.CampaniiPublicitare.Rows(0).Item("Data inceput")
        Dim year As Double
        year = DateAndTime.Year(years)
        Dim result As Double
        result = Convert.ToDouble(TextBox2.Text.ToString)
        Dim input_x = (result - year + 1)
        Dim pred_y As Double
        pred_y = (alpha * input_x) + beta
        For i = 0 To n - 1
            Chart2.Series("Estimare (ani)").Points.AddXY((year + i), y(i))
        Next
        Chart2.Series("Estimare (ani)").Points.AddXY((input_x + year - 1), pred_y)
        TextBox2.Text = pred_y.ToString
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class