Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Linq

Public Class Form1
    Private Sub btnIncarcaExcel_Click(sender As Object, e As EventArgs) Handles btnIncarcaExcel.Click
        'Dim conn As OleDbConnection
        'Dim dta As OleDbDataAdapter
        'Dim dts As DataSet
        'Dim excel As String
        'Dim openFileDialog As New OpenFileDialog


        'openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'openFileDialog.Filter = "All Files (*.*) |*.*| Excel files (*.xlsx)|*.xlsx| CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        'If (openFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

        '    Dim fi As New FileInfo(openFileDialog.FileName)
        '    Dim FileName As String = openFileDialog.FileName
        '    btnIncarcaExcel.Text = fi.ToString

        '    excel = fi.FullName
        '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
        '    dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
        '    dts = New DataSet

        '    dta.Fill(dts, "[Sheet1$]")
        '    gridImporta.DataSource = dts
        '    gridImporta.DataMember = "[Sheet1$]"

        '    conn.Close()
        'End If
    End Sub

    Private Sub btnExportaDate_Click(sender As Object, e As EventArgs) Handles btnExportaDate.Click
        'Dim xlApp As Microsoft.Office.Interop.Excel.Application
        'Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value
        'Dim i As Integer
        'Dim j As Integer

        'xlApp = New Microsoft.Office.Interop.Excel.Application
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")

        'For i = 0 To gridExporta.RowCount - 1
        '    For j = 0 To gridExporta.ColumnCount - 1
        '        For k As Integer = 1 To gridExporta.Columns.Count
        '            xlWorkSheet.Cells(1, k) = gridExporta.Columns(k - 1).HeaderText
        '            xlWorkSheet.Cells(i + 2, j + 1) = gridExporta(j, i).Value.ToString()
        '        Next
        '    Next
        'Next

        'xlWorkSheet.SaveAs("C:\Users\Stef\Desktop\exportExcel.xlsx")
        'xlWorkBook.Close()
        'xlApp.Quit()

        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)

        ''MsgBox("You can find the file")
        'Dim res As MsgBoxResult
        'res = MsgBox("Proces complet, doriti sa deschideti fisierul?", MsgBoxStyle.YesNo)
        'If (res = MsgBoxResult.Yes) Then
        '    Process.Start("C:\Users\Stef\Desktop\exportExcel.xlsx")
        'End If
    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        'Try
        '    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        '    obj = Nothing
        'Catch ex As Exception
        '    obj = Nothing
        'Finally
        '    GC.Collect()
        'End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class
