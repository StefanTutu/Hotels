
Imports Microsoft.Office.Interop

Public Class Cerinta1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIerarhie.Click
        TurismTree.Nodes.Clear()
        Dim i As Integer
        Dim j As Integer
        '' Dim k As Integer

        Dim Circuite As String
        Dim PacheteTuristice As String
        '' Dim DetaliiCircuit As String

        For j = 0 To Me.SIADDataSet.Circuite.Rows.Count - 1
            Circuite = Me.SIADDataSet.Circuite.Rows.Item(j).ItemArray(1).ToString()
            Dim nod_Circuite As TreeNode = New TreeNode(Circuite)
            Me.PacheteTuristiceTableAdapter.FillBy(Me.SIADDataSet.PacheteTuristice, Int32.Parse(Me.SIADDataSet.Circuite.Rows.Item(j).ItemArray(0).ToString))
            For i = 0 To Me.SIADDataSet.PacheteTuristice.Rows.Count - 1
                PacheteTuristice = Me.SIADDataSet.PacheteTuristice.Rows.Item(i).ItemArray(1).ToString
                Dim nod_PacheteTuristice As TreeNode = New TreeNode(PacheteTuristice)
                nod_Circuite.Nodes.Add(nod_PacheteTuristice)
                nod_PacheteTuristice = Nothing
            Next
            Me.TurismTree.Nodes.Add(nod_Circuite)



            '' Me.DetaliiCircuitTableAdapter.FillBy(Me.SIADDataSet.DetaliiCircuit, Int32.Parse(Me.SIADDataSet.Circuite.Rows.Item(j).ItemArray(0).ToString))
            '' For k = 0 To Me.SIADDataSet.DetaliiCircuit.Rows.Count - 1
            ''DetaliiCircuit = Me.SIADDataSet.DetaliiCircuit.Rows.Item(k).ItemArray(2).ToString()
            ''  Dim nod_DetaliiCircuit As TreeNode = New TreeNode(DetaliiCircuit)
            '' nod_Circuite.Nodes.Add(nod_DetaliiCircuit)
            '' nod_DetaliiCircuit = Nothing
        Next
        '' nod_PacheteTuristice.Nodes.Add(nod_Circuite)
        '' nod_Circuite = Nothing
        ''Next
        '' Me.TurismTree.Nodes.Add(nod_PacheteTuristice)
        ''Next
    End Sub





    Private Sub CircuiteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CircuiteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.DetaliiCircuit' table. You can move, or remove it, as needed.
        Me.DetaliiCircuitTableAdapter.Fill(Me.SIADDataSet.DetaliiCircuit)
        'TODO: This line of code loads data into the 'SIADDataSet.PacheteTuristice' table. You can move, or remove it, as needed.
        Me.PacheteTuristiceTableAdapter.Fill(Me.SIADDataSet.PacheteTuristice)
        'TODO: This line of code loads data into the 'SIADDataSet.Circuite' table. You can move, or remove it, as needed.
        Me.CircuiteTableAdapter.Fill(Me.SIADDataSet.Circuite)
        'TODO: This line of code loads data into the 'SIADDataSet.PacheteTuristice' table. You can move, or remove it, as needed.
        Me.PacheteTuristiceTableAdapter.Fill(Me.SIADDataSet.PacheteTuristice)
        'TODO: This line of code loads data into the 'SIADDataSet.DetaliiCircuit' table. You can move, or remove it, as needed.
        Me.DetaliiCircuitTableAdapter.Fill(Me.SIADDataSet.DetaliiCircuit)
        'TODO: This line of code loads data into the 'SIADDataSet.Circuite' table. You can move, or remove it, as needed.
        Me.CircuiteTableAdapter.Fill(Me.SIADDataSet.Circuite)

    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel.
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add

        'Add data to cells of the first worksheet in the new workbook.
        oSheet = oBook.Worksheets(1)
        oSheet.Range("A1").Value = "Gen muzical"
        oSheet.Range("A1").Font.Bold = True
        oSheet.Range("A2").Value = "Clasica"
        oSheet.Range("A3").Value = "Disco"
        oSheet.Range("A4").Value = "Dubstep"
        oSheet.Range("A5").Value = "Folk"
        oSheet.Range("A6").Value = "Hip-Hop"
        oSheet.Range("A7").Value = "House"
        oSheet.Range("A8").Value = "Jazz"
        oSheet.Range("A9").Value = "Latino"
        oSheet.Range("A10").Value = "Pop"
        oSheet.Range("A11").Value = "Rap"
        oSheet.Range("A12").Value = "Rock"

        oBook.SaveAs("C:\Users\Stef\Desktop\test.xlsx")
        oSheet = Nothing
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing
        GC.Collect()


        Dim res As MsgBoxResult
        res = MsgBox("Export realizat cu succes. Doresti sa deschizi fisierul?", MsgBoxStyle.YesNo)
        If (res = MsgBoxResult.Yes) Then
            Process.Start("C:\Users\Stef\Desktop\test.xlsx")
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Shell("C:\Program Files\Microsoft Office\Office14\Excel C:\Users\Stef\Desktop\test.xlsx", vbNormalFocus)
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub CircuiteBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CircuiteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CircuiteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub
End Class