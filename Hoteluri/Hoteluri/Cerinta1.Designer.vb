<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cerinta1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cerinta1))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.TurismTree = New System.Windows.Forms.TreeView()
        Me.btnIerarhie = New System.Windows.Forms.Button()
        Me.SIADDataSet = New Hoteluri.SIADDataSet()
        Me.CircuiteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CircuiteTableAdapter = New Hoteluri.SIADDataSetTableAdapters.CircuiteTableAdapter()
        Me.TableAdapterManager = New Hoteluri.SIADDataSetTableAdapters.TableAdapterManager()
        Me.DetaliiCircuitTableAdapter = New Hoteluri.SIADDataSetTableAdapters.DetaliiCircuitTableAdapter()
        Me.PacheteTuristiceTableAdapter = New Hoteluri.SIADDataSetTableAdapters.PacheteTuristiceTableAdapter()
        Me.CircuiteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CircuiteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PacheteTuristiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetaliiCircuitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircuiteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircuiteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CircuiteBindingNavigator.SuspendLayout()
        CType(Me.PacheteTuristiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetaliiCircuitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.YellowGreen
        Me.btnClose.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(13, 265)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 35)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Inchide"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpen.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(13, 213)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(114, 46)
        Me.btnOpen.TabIndex = 26
        Me.btnOpen.Text = "Open.xlsx"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnWrite
        '
        Me.btnWrite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnWrite.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrite.Location = New System.Drawing.Point(12, 161)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(115, 46)
        Me.btnWrite.TabIndex = 25
        Me.btnWrite.Text = "Write.xlsx"
        Me.btnWrite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWrite.UseVisualStyleBackColor = False
        '
        'TurismTree
        '
        Me.TurismTree.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TurismTree.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurismTree.Location = New System.Drawing.Point(437, 55)
        Me.TurismTree.Name = "TurismTree"
        Me.TurismTree.Size = New System.Drawing.Size(317, 204)
        Me.TurismTree.TabIndex = 24
        '
        'btnIerarhie
        '
        Me.btnIerarhie.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIerarhie.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIerarhie.Location = New System.Drawing.Point(13, 104)
        Me.btnIerarhie.Name = "btnIerarhie"
        Me.btnIerarhie.Size = New System.Drawing.Size(173, 51)
        Me.btnIerarhie.TabIndex = 23
        Me.btnIerarhie.Text = "Afiseaza circuite si ora plecarii"
        Me.btnIerarhie.UseVisualStyleBackColor = False
        '
        'SIADDataSet
        '
        Me.SIADDataSet.DataSetName = "SIADDataSet"
        Me.SIADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CircuiteBindingSource
        '
        Me.CircuiteBindingSource.DataMember = "Circuite"
        Me.CircuiteBindingSource.DataSource = Me.SIADDataSet
        '
        'CircuiteTableAdapter
        '
        Me.CircuiteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CampaniiPublicitareTableAdapter = Nothing
        Me.TableAdapterManager.CircuiteTableAdapter = Me.CircuiteTableAdapter
        Me.TableAdapterManager.ClientiTableAdapter = Nothing
        Me.TableAdapterManager.DetaliiCircuitTableAdapter = Me.DetaliiCircuitTableAdapter
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.IstoricClientTableAdapter = Nothing
        Me.TableAdapterManager.LocatiiTableAdapter = Nothing
        Me.TableAdapterManager.ObiectiveTuristiceTableAdapter = Nothing
        Me.TableAdapterManager.PacheteTuristiceTableAdapter = Me.PacheteTuristiceTableAdapter
        Me.TableAdapterManager.UpdateOrder = Hoteluri.SIADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetaliiCircuitTableAdapter
        '
        Me.DetaliiCircuitTableAdapter.ClearBeforeFill = True
        '
        'PacheteTuristiceTableAdapter
        '
        Me.PacheteTuristiceTableAdapter.ClearBeforeFill = True
        '
        'CircuiteBindingNavigator
        '
        Me.CircuiteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CircuiteBindingNavigator.BindingSource = Me.CircuiteBindingSource
        Me.CircuiteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CircuiteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CircuiteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CircuiteBindingNavigatorSaveItem})
        Me.CircuiteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CircuiteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CircuiteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CircuiteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CircuiteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CircuiteBindingNavigator.Name = "CircuiteBindingNavigator"
        Me.CircuiteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CircuiteBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.CircuiteBindingNavigator.TabIndex = 27
        Me.CircuiteBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CircuiteBindingNavigatorSaveItem
        '
        Me.CircuiteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CircuiteBindingNavigatorSaveItem.Image = CType(resources.GetObject("CircuiteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CircuiteBindingNavigatorSaveItem.Name = "CircuiteBindingNavigatorSaveItem"
        Me.CircuiteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CircuiteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PacheteTuristiceBindingSource
        '
        Me.PacheteTuristiceBindingSource.DataMember = "PacheteTuristice"
        Me.PacheteTuristiceBindingSource.DataSource = Me.SIADDataSet
        '
        'DetaliiCircuitBindingSource
        '
        Me.DetaliiCircuitBindingSource.DataMember = "DetaliiCircuit"
        Me.DetaliiCircuitBindingSource.DataSource = Me.SIADDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 28)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Circuite"
        '
        'Cerinta1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hoteluri.My.Resources.Resources._12
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CircuiteBindingNavigator)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.TurismTree)
        Me.Controls.Add(Me.btnIerarhie)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Cerinta1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cerinta1"
        CType(Me.SIADDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CircuiteBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CircuiteBindingNavigator,System.ComponentModel.ISupportInitialize).EndInit
        Me.CircuiteBindingNavigator.ResumeLayout(false)
        Me.CircuiteBindingNavigator.PerformLayout
        CType(Me.PacheteTuristiceBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DetaliiCircuitBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents TurismTree As System.Windows.Forms.TreeView
    Friend WithEvents btnIerarhie As System.Windows.Forms.Button
    Friend WithEvents SIADDataSet As Hoteluri.SIADDataSet
    Friend WithEvents CircuiteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CircuiteTableAdapter As Hoteluri.SIADDataSetTableAdapters.CircuiteTableAdapter
    Friend WithEvents TableAdapterManager As Hoteluri.SIADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CircuiteBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CircuiteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PacheteTuristiceTableAdapter As Hoteluri.SIADDataSetTableAdapters.PacheteTuristiceTableAdapter
    Friend WithEvents PacheteTuristiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetaliiCircuitTableAdapter As Hoteluri.SIADDataSetTableAdapters.DetaliiCircuitTableAdapter
    Friend WithEvents DetaliiCircuitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As Label
End Class
