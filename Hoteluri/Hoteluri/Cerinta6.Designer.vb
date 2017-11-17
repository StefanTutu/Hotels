<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cerinta6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cerinta6))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.Interval1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Interval1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Interval1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnAfisGrafic = New System.Windows.Forms.Button()
        Me.GraficVarsta = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SIADDataSet = New Hoteluri.SIADDataSet()
        Me.Interval1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Interval1TableAdapter = New Hoteluri.SIADDataSetTableAdapters.Interval1TableAdapter()
        Me.TableAdapterManager = New Hoteluri.SIADDataSetTableAdapters.TableAdapterManager()
        Me.Interval2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Interval2TableAdapter = New Hoteluri.SIADDataSetTableAdapters.Interval2TableAdapter()
        Me.Interval3BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Interval3TableAdapter = New Hoteluri.SIADDataSetTableAdapters.Interval3TableAdapter()
        Me.Interval3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Interval2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Interval1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Interval1BindingNavigator.SuspendLayout()
        CType(Me.Interval1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraficVarsta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interval1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interval2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interval3BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interval3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interval2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'Interval1BindingNavigator
        '
        Me.Interval1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Interval1BindingNavigator.BindingSource = Me.Interval1BindingSource
        Me.Interval1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Interval1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Interval1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Interval1BindingNavigatorSaveItem})
        Me.Interval1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Interval1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Interval1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Interval1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Interval1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Interval1BindingNavigator.Name = "Interval1BindingNavigator"
        Me.Interval1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Interval1BindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.Interval1BindingNavigator.TabIndex = 7
        Me.Interval1BindingNavigator.Text = "BindingNavigator1"
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
        'Interval1BindingSource
        '
        Me.Interval1BindingSource.DataMember = "Interval1"
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
        'Interval1BindingNavigatorSaveItem
        '
        Me.Interval1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Interval1BindingNavigatorSaveItem.Enabled = False
        Me.Interval1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Interval1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Interval1BindingNavigatorSaveItem.Name = "Interval1BindingNavigatorSaveItem"
        Me.Interval1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Interval1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnAfisGrafic
        '
        Me.btnAfisGrafic.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAfisGrafic.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic)
        Me.btnAfisGrafic.Location = New System.Drawing.Point(505, 457)
        Me.btnAfisGrafic.Name = "btnAfisGrafic"
        Me.btnAfisGrafic.Size = New System.Drawing.Size(158, 34)
        Me.btnAfisGrafic.TabIndex = 6
        Me.btnAfisGrafic.Text = "Afiseaza Grafic"
        Me.btnAfisGrafic.UseVisualStyleBackColor = False
        '
        'GraficVarsta
        '
        ChartArea1.Name = "ChartArea1"
        Me.GraficVarsta.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.GraficVarsta.Legends.Add(Legend1)
        Me.GraficVarsta.Location = New System.Drawing.Point(75, 100)
        Me.GraficVarsta.Name = "GraficVarsta"
        Me.GraficVarsta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "liceale"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "post-liceale"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "universitare"
        Me.GraficVarsta.Series.Add(Series1)
        Me.GraficVarsta.Series.Add(Series2)
        Me.GraficVarsta.Series.Add(Series3)
        Me.GraficVarsta.Size = New System.Drawing.Size(588, 328)
        Me.GraficVarsta.TabIndex = 5
        Me.GraficVarsta.Text = "GraficVarste"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(505, 497)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(158, 35)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Inchide"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'SIADDataSet
        '
        Me.SIADDataSet.DataSetName = "SIADDataSet"
        Me.SIADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Interval1BindingSource1
        '
        Me.Interval1BindingSource1.DataMember = "Interval1"
        Me.Interval1BindingSource1.DataSource = Me.SIADDataSet
        '
        'Interval1TableAdapter
        '
        Me.Interval1TableAdapter.ClearBeforeFill = True
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
        'Interval2BindingSource1
        '
        Me.Interval2BindingSource1.DataMember = "Interval2"
        Me.Interval2BindingSource1.DataSource = Me.SIADDataSet
        '
        'Interval2TableAdapter
        '
        Me.Interval2TableAdapter.ClearBeforeFill = True
        '
        'Interval3BindingSource1
        '
        Me.Interval3BindingSource1.DataMember = "Interval3"
        Me.Interval3BindingSource1.DataSource = Me.SIADDataSet
        '
        'Interval3TableAdapter
        '
        Me.Interval3TableAdapter.ClearBeforeFill = True
        '
        'Interval3BindingSource
        '
        Me.Interval3BindingSource.DataMember = "Interval3"
        '
        'Interval2BindingSource
        '
        Me.Interval2BindingSource.DataMember = "Interval2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(241, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clienti pe categorii de varsta si studii"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label2.Location = New System.Drawing.Point(60, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nr. pers."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(-4, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 27)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Interval de varsta"
        '
        'Cerinta6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hoteluri.My.Resources.Resources._7
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Interval1BindingNavigator)
        Me.Controls.Add(Me.btnAfisGrafic)
        Me.Controls.Add(Me.GraficVarsta)
        Me.Name = "Cerinta6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clienti pe varsta de categorii si studii"
        CType(Me.Interval1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Interval1BindingNavigator.ResumeLayout(False)
        Me.Interval1BindingNavigator.PerformLayout()
        CType(Me.Interval1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraficVarsta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interval1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interval2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interval3BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interval3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interval2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Interval3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Interval2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Interval1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Interval1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Interval1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAfisGrafic As System.Windows.Forms.Button
    Friend WithEvents GraficVarsta As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SIADDataSet As Hoteluri.SIADDataSet
    Friend WithEvents Interval1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Interval1TableAdapter As Hoteluri.SIADDataSetTableAdapters.Interval1TableAdapter
    Friend WithEvents TableAdapterManager As Hoteluri.SIADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Interval2BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Interval2TableAdapter As Hoteluri.SIADDataSetTableAdapters.Interval2TableAdapter
    Friend WithEvents Interval3BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Interval3TableAdapter As Hoteluri.SIADDataSetTableAdapters.Interval3TableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
