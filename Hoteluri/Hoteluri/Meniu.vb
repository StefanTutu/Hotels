Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports Micrososft.Office.Interop

Public Class Meniu

    Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\FEAA\Master - SIA\An 1\Sem 1\SIAD\Proiect - Hotel\SIAD.accdb"
    Dim patch As String = "D:\FEAA\Master - SIA\An 1\Sem 1\SIAD\Proiect - Hotel\SIAD.accdb"
    Dim l = "SELECT ID, info FROM"
    Dim lc = "SELECT PacheteTuristice(ID) FROM"
    Dim w = "WHERE parentId="
    Dim branch() As String 'for 1st found branch (more that 2 tables)
    Dim arrp() As String 'for parrents table
    Dim arrc() As String 'for child table

    'Private Sub TreeViewAdd(dtParrent As Array, ParentId As Integer, level As Integer, treeNode As TreeNode)
    'For i = 0 To dtParrent.Length / 2 - 1
    'Dim child As New TreeNode()
    ' If level = 0 Then
    ' HotelTree.Nodes.Add(child)
    '   Else
    '         treeNode.Nodes.Add(child)
    '       End If
    '     If level < branch.Length - 1 Then
    ' Dim common As String = branch(level + 1) & w & dtParrent(i, 0) & "'"
    'Dim dtChild As Array = Me.GetData(l & Common, lc & Common)
    '         TreeViewAdd(dtChild, Integer.Parse(dtParrent(i, 0)), level + 1, child)
    '   End If
    ' Next
    'End Sub

    'Private Sub BuildBranchWithParrents(tb1 As String, level As Integer)
    'Dim index As Integer
    ' index = Array.FindIndex(arrp, Function(p) p = tb1)
    '  If index >= 0 Then
    ' ReDim Preserve branch(level)
    ' branch(level) = tb1
    'BuildBranchWithParrents(arrc(index), level + 1)
    ' End If
    'End Sub

    'Private Function GetData(q As String, q_c As String) As Array
    'Dim arr(,) As String
    'Dim conn As StringConection = New StringConection

    'OleDbConnection = New OleDbConnection
    ' conn.connectionString = strconn
    'conn.Open()
    'Dim cmd As New OleDbCommand(q, conn)
    'Dim cmd_c As New OleDbCommand(q_c, conn)
    'Dim dr As OLeDbCommand()
    'End Function

    Private Sub GraficeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraficeToolStripMenuItem.Click

    End Sub

    Private Sub InformatiiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformatiiToolStripMenuItem.Click
        'Main.Show(-1, 0)
    End Sub

    Private Sub CeleMaiVizitateCircuiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CeleMaiVizitateCircuiteToolStripMenuItem.Click
        '1
        'Cerinta1.Show()
        Form1.Show()
    End Sub

    Private Sub SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem.Click
        '2
        Cerinta2.Show()
    End Sub

    Private Sub PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem.Click
        '3
        Cerinta4.Show()
    End Sub

    Private Sub CategoriiDeClientiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriiDeClientiToolStripMenuItem.Click
        '4
        Cerinta6.Show()
    End Sub

    Private Sub ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem.Click
        '5
        Cerinta5.Show()
    End Sub

    Private Sub ImpactulUneiCampaniiPublicitareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpactulUneiCampaniiPublicitareToolStripMenuItem.Click
        '6
        Cerinta3.Show()
    End Sub

    Private Sub CircuiteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CircuiteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub

    Private Sub Meniu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.PacheteTuristice' table. You can move, or remove it, as needed.
        Me.PacheteTuristiceTableAdapter.Fill(Me.SIADDataSet.PacheteTuristice)
        'TODO: This line of code loads data into the 'SIADDataSet.DetaliiCircuit' table. You can move, or remove it, as needed.
        Me.DetaliiCircuitTableAdapter.Fill(Me.SIADDataSet.DetaliiCircuit)
        'TODO: This line of code loads data into the 'SIADDataSet.Circuite' table. You can move, or remove it, as needed.
        Me.CircuiteTableAdapter.Fill(Me.SIADDataSet.Circuite)

    End Sub

    Private Sub btnIerarhie_Click(sender As Object, e As EventArgs) Handles btnIerarhie.Click

        'TurismTree.Nodes.Clear()
        'Dim i As Integer
        'Dim j As Integer
        ' '' Dim k As Integer

        'Dim aCircuite As String
        'Dim aPacheteTuristice As String
        ' '' Dim DetaliiCircuit As String

        'For j = 0 To Me.SIADDataSet.Circuite.Rows.Count - 1
        '    aCircuite = Me.SIADDataSet.Circuite.Rows.Item(j).ItemArray(1).ToString()
        '    Dim nod_Circuite As TreeNode = New TreeNode(aCircuite)
        '    Me.PacheteTuristiceTableAdapter.FillBy(Me.SIADDataSet.PacheteTuristice, Int32.Parse(Me.SIADDataSet.Circuite.Rows.Item(j).ItemArray(0).ToString))
        '    For i = 0 To Me.SIADDataSet.PacheteTuristice.Rows.Count - 1
        '        aPacheteTuristice = Me.SIADDataSet.PacheteTuristice.Rows.Item(i).ItemArray(1).ToString
        '        Dim nod_PacheteTuristice As TreeNode = New TreeNode(aPacheteTuristice)
        '        nod_Circuite.Nodes.Add(nod_PacheteTuristice)
        '        nod_PacheteTuristice = Nothing
        '    Next
        '    Me.TurismTree.Nodes.Add(nod_Circuite)



        '' Me.DetaliiCircuitTableAdapter.FillBy(Me.SIADDataSet.DetaliiCircuit, Int32.Parse(Me.SIADDataSet.Circuite.Rows.Item(j).ItemArray(0).ToString))
        '' For k = 0 To Me.SIADDataSet.DetaliiCircuit.Rows.Count - 1
        ''DetaliiCircuit = Me.SIADDataSet.DetaliiCircuit.Rows.Item(k).ItemArray(2).ToString()
        ''  Dim nod_DetaliiCircuit As TreeNode = New TreeNode(DetaliiCircuit)
        '' nod_Circuite.Nodes.Add(nod_DetaliiCircuit)
        '' nod_DetaliiCircuit = Nothing
        'Next
        '' nod_PacheteTuristice.Nodes.Add(nod_Circuite)
        '' nod_Circuite = Nothing
        ''Next
        '' Me.TurismTree.Nodes.Add(nod_PacheteTuristice)
        ''Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class