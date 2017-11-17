Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports Hoteluri


Public Class Informatii

    Dim x As String
    Dim z As Integer
    Dim c As Integer
    Dim user As String

    Public Sub New(incoming As Integer, cod As Integer)
        InitializeComponent()
        z = incoming
        c = cod
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.Dispose()
        Meniu.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SIADDataSet.CampaniiPublicitare' table. You can move, or remove it, as needed.
        Me.CampaniiPublicitareTableAdapter.Fill(Me.SIADDataSet.CampaniiPublicitare)
        'TODO: This line of code loads data into the 'SIADDataSet.PacheteTuristice' table. You can move, or remove it, as needed.
        Me.PacheteTuristiceTableAdapter.Fill(Me.SIADDataSet.PacheteTuristice)
        'TODO: This line of code loads data into the 'SIADDataSet.DetaliiCircuit' table. You can move, or remove it, as needed.
        Me.DetaliiCircuitTableAdapter.Fill(Me.SIADDataSet.DetaliiCircuit)
        'TODO: This line of code loads data into the 'SIADDataSet.Circuite' table. You can move, or remove it, as needed.
        Me.CircuiteTableAdapter.Fill(Me.SIADDataSet.Circuite)
        'TODO: This line of code loads data into the 'SIADDataSet.CampaniiPublicitare' table. You can move, or remove it, as needed.
        Me.CampaniiPublicitareTableAdapter.Fill(Me.SIADDataSet.CampaniiPublicitare)

        If (z = 2) Then

            'Restrictii_Contabil()
            user = c.ToString()
        End If
        If (z = 1) Then

            'Restrictii_Manager()
            user = c.ToString()
        End If
        If (c = 0) Then

            user = "admin"
        End If
    End Sub

    Private Sub Main_FormClosed_1(sender As Object, e As FormClosedEventArgs)
        If x = 1 Then
            Application.[Exit]()
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs)
        x = ShowDialog()
        If x = 2 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub CampaniiPublicitareBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CampaniiPublicitareBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub

    Private Sub CircuiteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CircuiteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SIADDataSet)

    End Sub
End Class