<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cerinta2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cerinta2))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.PrimavaraBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PrimavaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.PrimavaraBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnCereri = New System.Windows.Forms.Button()
        Me.GraficSezon = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SIADDataSet = New Hoteluri.SIADDataSet()
        Me.PrimavaraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimavaraTableAdapter = New Hoteluri.SIADDataSetTableAdapters.PrimavaraTableAdapter()
        Me.TableAdapterManager = New Hoteluri.SIADDataSetTableAdapters.TableAdapterManager()
        Me.ToamnaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToamnaTableAdapter = New Hoteluri.SIADDataSetTableAdapters.ToamnaTableAdapter()
        Me.VaraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VaraTableAdapter = New Hoteluri.SIADDataSetTableAdapters.VaraTableAdapter()
        Me.IarnaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IarnaTableAdapter = New Hoteluri.SIADDataSetTableAdapters.IarnaTableAdapter()
        Me.IarnaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToamnaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PrimavaraBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrimavaraBindingNavigator.SuspendLayout()
        CType(Me.PrimavaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraficSezon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimavaraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToamnaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VaraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IarnaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IarnaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToamnaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'PrimavaraBindingNavigator
        '
        Me.PrimavaraBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrimavaraBindingNavigator.BindingSource = Me.PrimavaraBindingSource
        Me.PrimavaraBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PrimavaraBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PrimavaraBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PrimavaraBindingNavigatorSaveItem})
        Me.PrimavaraBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PrimavaraBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PrimavaraBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PrimavaraBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PrimavaraBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PrimavaraBindingNavigator.Name = "PrimavaraBindingNavigator"
        Me.PrimavaraBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PrimavaraBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.PrimavaraBindingNavigator.TabIndex = 7
        Me.PrimavaraBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PrimavaraBindingSource
        '
        Me.PrimavaraBindingSource.DataMember = "Primavara"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'PrimavaraBindingNavigatorSaveItem
        '
        Me.PrimavaraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrimavaraBindingNavigatorSaveItem.Enabled = False
        Me.PrimavaraBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrimavaraBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrimavaraBindingNavigatorSaveItem.Name = "PrimavaraBindingNavigatorSaveItem"
        Me.PrimavaraBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PrimavaraBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnCereri
        '
        Me.btnCereri.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCereri.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCereri.Location = New System.Drawing.Point(604, 89)
        Me.btnCereri.Name = "btnCereri"
        Me.btnCereri.Size = New System.Drawing.Size(166, 35)
        Me.btnCereri.TabIndex = 6
        Me.btnCereri.Text = "Cereri pe sezoane"
        Me.btnCereri.UseVisualStyleBackColor = False
        '
        'GraficSezon
        '
        Me.GraficSezon.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.GraficSezon.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.GraficSezon.Legends.Add(Legend1)
        Me.GraficSezon.Location = New System.Drawing.Point(39, 169)
        Me.GraficSezon.Name = "GraficSezon"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "iarna"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "primavara"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "vara"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Legend = "Legend1"
        Series4.Name = "toamna"
        Me.GraficSezon.Series.Add(Series1)
        Me.GraficSezon.Series.Add(Series2)
        Me.GraficSezon.Series.Add(Series3)
        Me.GraficSezon.Series.Add(Series4)
        Me.GraficSezon.Size = New System.Drawing.Size(596, 323)
        Me.GraficSezon.TabIndex = 5
        Me.GraficSezon.Text = "GraficSezon"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(663, 135)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 35)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Inchide"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'SIADDataSet
        '
        Me.SIADDataSet.DataSetName = "SIADDataSet"
        Me.SIADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrimavaraBindingSource1
        '
        Me.PrimavaraBindingSource1.DataMember = "Primavara"
        Me.PrimavaraBindingSource1.DataSource = Me.SIADDataSet
        '
        'PrimavaraTableAdapter
        '
        Me.PrimavaraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CampaniiPublicitareTableAdapter = Nothing
        Me.TableAdapterManager.CircuiteTableAdapter = Nothing
        Me.TableAdapterManager.ClientiTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DetaliiCircuitTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.IstoricClientTableAdapter = Nothing
        Me.TableAdapterManager.LocatiiTableAdapter = Nothing
        Me.TableAdapterManager.ObiectiveTuristiceTableAdapter = Nothing
        Me.TableAdapterManager.PacheteTuristiceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hoteluri.SIADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ToamnaBindingSource1
        '
        Me.ToamnaBindingSource1.DataMember = "Toamna"
        Me.ToamnaBindingSource1.DataSource = Me.SIADDataSet
        '
        'ToamnaTableAdapter
        '
        Me.ToamnaTableAdapter.ClearBeforeFill = True
        '
        'VaraBindingSource1
        '
        Me.VaraBindingSource1.DataMember = "Vara"
        Me.VaraBindingSource1.DataSource = Me.SIADDataSet
        '
        'VaraTableAdapter
        '
        Me.VaraTableAdapter.ClearBeforeFill = True
        '
        'IarnaBindingSource1
        '
        Me.IarnaBindingSource1.DataMember = "Iarna"
        Me.IarnaBindingSource1.DataSource = Me.SIADDataSet
        '
        'IarnaTableAdapter
        '
        Me.IarnaTableAdapter.ClearBeforeFill = True
        '
        'IarnaBindingSource
        '
        Me.IarnaBindingSource.DataMember = "Iarna"
        '
        'VaraBindingSource
        '
        Me.VaraBindingSource.DataMember = "Vara"
        '
        'ToamnaBindingSource
        '
        Me.ToamnaBindingSource.DataMember = "Toamna"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Situatia cererilor pe anumite sezoane"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nr. persoane"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(512, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Intervale tarif"
        '
        'Cerinta2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hoteluri.My.Resources.Resources._11
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PrimavaraBindingNavigator)
        Me.Controls.Add(Me.btnCereri)
        Me.Controls.Add(Me.GraficSezon)
        Me.Name = "Cerinta2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Situatia cererilor pe anumite sezoane"
        CType(Me.PrimavaraBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrimavaraBindingNavigator.ResumeLayout(False)
        Me.PrimavaraBindingNavigator.PerformLayout()
        CType(Me.PrimavaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraficSezon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimavaraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToamnaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VaraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IarnaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IarnaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToamnaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents IarnaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VaraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToamnaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimavaraBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrimavaraBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents PrimavaraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCereri As System.Windows.Forms.Button
    Friend WithEvents GraficSezon As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SIADDataSet As Hoteluri.SIADDataSet
    Friend WithEvents PrimavaraBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PrimavaraTableAdapter As Hoteluri.SIADDataSetTableAdapters.PrimavaraTableAdapter
    Friend WithEvents TableAdapterManager As Hoteluri.SIADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToamnaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToamnaTableAdapter As Hoteluri.SIADDataSetTableAdapters.ToamnaTableAdapter
    Friend WithEvents VaraBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VaraTableAdapter As Hoteluri.SIADDataSetTableAdapters.VaraTableAdapter
    Friend WithEvents IarnaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IarnaTableAdapter As Hoteluri.SIADDataSetTableAdapters.IarnaTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
