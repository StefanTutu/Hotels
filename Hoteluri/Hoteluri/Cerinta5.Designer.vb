<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cerinta5
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cerinta5))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CampaniiPublicitareBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CampaniiPublicitareBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CampaniiPublicitareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIADDataSet = New Hoteluri.SIADDataSet()
        Me.TableAdapterManager = New Hoteluri.SIADDataSetTableAdapters.TableAdapterManager()
        Me.CampaniiPublicitareTableAdapter = New Hoteluri.SIADDataSetTableAdapters.CampaniiPublicitareTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.metroLabel2 = New System.Windows.Forms.Label()
        Me.metroLabel1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampaniiPublicitareBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CampaniiPublicitareBindingNavigator.SuspendLayout()
        CType(Me.CampaniiPublicitareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(465, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Previziune privind cheltuielile campaniilor publicitare pe luni"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClose.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(628, 487)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 35)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "Inchide"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(620, 373)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Button2.Location = New System.Drawing.Point(617, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 57)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Previziune Ani"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(72, 304)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Estimare (ani)"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(514, 270)
        Me.Chart2.TabIndex = 32
        Me.Chart2.Text = "Chart2"
        '
        'CampaniiPublicitareBindingNavigatorSaveItem
        '
        Me.CampaniiPublicitareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CampaniiPublicitareBindingNavigatorSaveItem.Image = CType(resources.GetObject("CampaniiPublicitareBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CampaniiPublicitareBindingNavigatorSaveItem.Name = "CampaniiPublicitareBindingNavigatorSaveItem"
        Me.CampaniiPublicitareBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CampaniiPublicitareBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
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
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'CampaniiPublicitareBindingNavigator
        '
        Me.CampaniiPublicitareBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CampaniiPublicitareBindingNavigator.BindingSource = Me.CampaniiPublicitareBindingSource
        Me.CampaniiPublicitareBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CampaniiPublicitareBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CampaniiPublicitareBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CampaniiPublicitareBindingNavigatorSaveItem})
        Me.CampaniiPublicitareBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CampaniiPublicitareBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CampaniiPublicitareBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CampaniiPublicitareBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CampaniiPublicitareBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CampaniiPublicitareBindingNavigator.Name = "CampaniiPublicitareBindingNavigator"
        Me.CampaniiPublicitareBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CampaniiPublicitareBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.CampaniiPublicitareBindingNavigator.TabIndex = 31
        Me.CampaniiPublicitareBindingNavigator.Text = "BindingNavigator1"
        '
        'CampaniiPublicitareBindingSource
        '
        Me.CampaniiPublicitareBindingSource.DataMember = "CampaniiPublicitare"
        Me.CampaniiPublicitareBindingSource.DataSource = Me.SIADDataSet
        '
        'SIADDataSet
        '
        Me.SIADDataSet.DataSetName = "SIADDataSet"
        Me.SIADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CampaniiPublicitareTableAdapter = Me.CampaniiPublicitareTableAdapter
        Me.TableAdapterManager.CircuiteTableAdapter = Nothing
        Me.TableAdapterManager.ClientiTableAdapter = Nothing
        Me.TableAdapterManager.DetaliiCircuitTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.IstoricClientTableAdapter = Nothing
        Me.TableAdapterManager.LocatiiTableAdapter = Nothing
        Me.TableAdapterManager.ObiectiveTuristiceTableAdapter = Nothing
        Me.TableAdapterManager.PacheteTuristiceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hoteluri.SIADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CampaniiPublicitareTableAdapter
        '
        Me.CampaniiPublicitareTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Previziune privind cheltuielile campaniilor publicitare pe ani"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(625, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 30
        '
        'metroLabel2
        '
        Me.metroLabel2.AutoSize = True
        Me.metroLabel2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metroLabel2.Location = New System.Drawing.Point(625, 69)
        Me.metroLabel2.Name = "metroLabel2"
        Me.metroLabel2.Size = New System.Drawing.Size(100, 18)
        Me.metroLabel2.TabIndex = 29
        Me.metroLabel2.Text = "Introduceti luni"
        '
        'metroLabel1
        '
        Me.metroLabel1.AutoSize = True
        Me.metroLabel1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metroLabel1.Location = New System.Drawing.Point(621, 341)
        Me.metroLabel1.Name = "metroLabel1"
        Me.metroLabel1.Size = New System.Drawing.Size(94, 18)
        Me.metroLabel1.TabIndex = 28
        Me.metroLabel1.Text = "Introduceti ani"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(72, 54)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "Estimare (luni)"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(514, 192)
        Me.Chart1.TabIndex = 27
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Button1.Location = New System.Drawing.Point(620, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 62)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Previziune luni"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cerinta5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.CampaniiPublicitareBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.metroLabel2)
        Me.Controls.Add(Me.metroLabel1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Cerinta5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Previsiuni cheltuieli campanii publicitare"
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampaniiPublicitareBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CampaniiPublicitareBindingNavigator.ResumeLayout(False)
        Me.CampaniiPublicitareBindingNavigator.PerformLayout()
        CType(Me.CampaniiPublicitareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CampaniiPublicitareBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CampaniiPublicitareBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CampaniiPublicitareBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SIADDataSet As Hoteluri.SIADDataSet
    Friend WithEvents TableAdapterManager As Hoteluri.SIADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CampaniiPublicitareTableAdapter As Hoteluri.SIADDataSetTableAdapters.CampaniiPublicitareTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents metroLabel2 As System.Windows.Forms.Label
    Friend WithEvents metroLabel1 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
