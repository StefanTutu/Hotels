<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informatii
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SIADDataSet = New Hoteluri.SIADDataSet()
        Me.CircuiteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CircuiteTableAdapter = New Hoteluri.SIADDataSetTableAdapters.CircuiteTableAdapter()
        Me.TableAdapterManager = New Hoteluri.SIADDataSetTableAdapters.TableAdapterManager()
        Me.CampaniiPublicitareTableAdapter = New Hoteluri.SIADDataSetTableAdapters.CampaniiPublicitareTableAdapter()
        Me.DetaliiCircuitTableAdapter = New Hoteluri.SIADDataSetTableAdapters.DetaliiCircuitTableAdapter()
        Me.PacheteTuristiceTableAdapter = New Hoteluri.SIADDataSetTableAdapters.PacheteTuristiceTableAdapter()
        Me.DetaliiCircuitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacheteTuristiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CampaniiPublicitareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircuiteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetaliiCircuitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacheteTuristiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampaniiPublicitareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.DarkRed
        Me.BtnStart.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(451, 390)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(117, 38)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.label1.Location = New System.Drawing.Point(90, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(201, 132)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Proiect realizat de :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ciridariu Anca-Mihaela " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jderiu Livia-Georgiana " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tutu S" &
    "tefan Valentin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
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
        Me.TableAdapterManager.CampaniiPublicitareTableAdapter = Me.CampaniiPublicitareTableAdapter
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
        'CampaniiPublicitareTableAdapter
        '
        Me.CampaniiPublicitareTableAdapter.ClearBeforeFill = True
        '
        'DetaliiCircuitTableAdapter
        '
        Me.DetaliiCircuitTableAdapter.ClearBeforeFill = True
        '
        'PacheteTuristiceTableAdapter
        '
        Me.PacheteTuristiceTableAdapter.ClearBeforeFill = True
        '
        'DetaliiCircuitBindingSource
        '
        Me.DetaliiCircuitBindingSource.DataMember = "DetaliiCircuit"
        Me.DetaliiCircuitBindingSource.DataSource = Me.SIADDataSet
        '
        'PacheteTuristiceBindingSource
        '
        Me.PacheteTuristiceBindingSource.DataMember = "PacheteTuristice"
        Me.PacheteTuristiceBindingSource.DataSource = Me.SIADDataSet
        '
        'CampaniiPublicitareBindingSource
        '
        Me.CampaniiPublicitareBindingSource.DataMember = "CampaniiPublicitare"
        Me.CampaniiPublicitareBindingSource.DataSource = Me.SIADDataSet
        '
        'Informatii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hoteluri.My.Resources.Resources._5
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.BtnStart)
        Me.Name = "Informatii"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informatii"
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircuiteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetaliiCircuitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacheteTuristiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampaniiPublicitareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents BtnStart As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents SIADDataSet As Hoteluri.SIADDataSet
    Friend WithEvents CircuiteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CircuiteTableAdapter As Hoteluri.SIADDataSetTableAdapters.CircuiteTableAdapter
    Friend WithEvents TableAdapterManager As Hoteluri.SIADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetaliiCircuitTableAdapter As Hoteluri.SIADDataSetTableAdapters.DetaliiCircuitTableAdapter
    Friend WithEvents DetaliiCircuitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacheteTuristiceTableAdapter As Hoteluri.SIADDataSetTableAdapters.PacheteTuristiceTableAdapter
    Friend WithEvents PacheteTuristiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CampaniiPublicitareTableAdapter As Hoteluri.SIADDataSetTableAdapters.CampaniiPublicitareTableAdapter
    Friend WithEvents CampaniiPublicitareBindingSource As System.Windows.Forms.BindingSource
End Class
