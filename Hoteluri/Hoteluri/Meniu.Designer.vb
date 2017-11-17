<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meniu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GraficeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CeleMaiVizitateCircuiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriiDeClientiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpactulUneiCampaniiPublicitareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformatiiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnIerarhie = New System.Windows.Forms.Button()
        Me.TurismTree = New System.Windows.Forms.TreeView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SIADDataSet = New Hoteluri.SIADDataSet()
        Me.CircuiteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CircuiteTableAdapter = New Hoteluri.SIADDataSetTableAdapters.CircuiteTableAdapter()
        Me.TableAdapterManager = New Hoteluri.SIADDataSetTableAdapters.TableAdapterManager()
        Me.DetaliiCircuitTableAdapter = New Hoteluri.SIADDataSetTableAdapters.DetaliiCircuitTableAdapter()
        Me.PacheteTuristiceTableAdapter = New Hoteluri.SIADDataSetTableAdapters.PacheteTuristiceTableAdapter()
        Me.DetaliiCircuitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacheteTuristiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapPromovareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircuiteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetaliiCircuitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacheteTuristiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraficeToolStripMenuItem, Me.InformatiiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GraficeToolStripMenuItem
        '
        Me.GraficeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CeleMaiVizitateCircuiteToolStripMenuItem, Me.SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem, Me.PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem, Me.CategoriiDeClientiToolStripMenuItem, Me.ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem, Me.ImpactulUneiCampaniiPublicitareToolStripMenuItem, Me.PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem, Me.MapClientToolStripMenuItem, Me.MapPromovareToolStripMenuItem})
        Me.GraficeToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraficeToolStripMenuItem.Name = "GraficeToolStripMenuItem"
        Me.GraficeToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.GraficeToolStripMenuItem.Text = "Grafice"
        '
        'CeleMaiVizitateCircuiteToolStripMenuItem
        '
        Me.CeleMaiVizitateCircuiteToolStripMenuItem.Name = "CeleMaiVizitateCircuiteToolStripMenuItem"
        Me.CeleMaiVizitateCircuiteToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.CeleMaiVizitateCircuiteToolStripMenuItem.Text = "1.Export - Import Excel"
        '
        'SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem
        '
        Me.SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem.Name = "SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem"
        Me.SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem.Text = "2.Situatia cererilor pe anumite sezoane"
        '
        'PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem
        '
        Me.PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem.Name = "PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem"
        Me.PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem.Text = "3.Principalele cauze ale nemultumirilor clientilor"
        '
        'CategoriiDeClientiToolStripMenuItem
        '
        Me.CategoriiDeClientiToolStripMenuItem.Name = "CategoriiDeClientiToolStripMenuItem"
        Me.CategoriiDeClientiToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.CategoriiDeClientiToolStripMenuItem.Text = "4. Clienti pe categorii de varsta si studii"
        '
        'ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem
        '
        Me.ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem.Name = "ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem"
        Me.ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem.Text = "5.Previziuni asupra cheltuielilor pe campaniile publicitare"
        '
        'ImpactulUneiCampaniiPublicitareToolStripMenuItem
        '
        Me.ImpactulUneiCampaniiPublicitareToolStripMenuItem.Name = "ImpactulUneiCampaniiPublicitareToolStripMenuItem"
        Me.ImpactulUneiCampaniiPublicitareToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.ImpactulUneiCampaniiPublicitareToolStripMenuItem.Text = "6.Impactul unei campanii publicitare"
        '
        'InformatiiToolStripMenuItem
        '
        Me.InformatiiToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformatiiToolStripMenuItem.Name = "InformatiiToolStripMenuItem"
        Me.InformatiiToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.InformatiiToolStripMenuItem.Text = "Informatii"
        '
        'btnIerarhie
        '
        Me.btnIerarhie.BackColor = System.Drawing.Color.RosyBrown
        Me.btnIerarhie.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIerarhie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIerarhie.Location = New System.Drawing.Point(361, 486)
        Me.btnIerarhie.Name = "btnIerarhie"
        Me.btnIerarhie.Size = New System.Drawing.Size(304, 58)
        Me.btnIerarhie.TabIndex = 4
        Me.btnIerarhie.Text = "Afiseaza circuite si ore plecari"
        Me.btnIerarhie.UseVisualStyleBackColor = False
        '
        'TurismTree
        '
        Me.TurismTree.BackColor = System.Drawing.Color.RosyBrown
        Me.TurismTree.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurismTree.Location = New System.Drawing.Point(301, 245)
        Me.TurismTree.Name = "TurismTree"
        Me.TurismTree.Size = New System.Drawing.Size(364, 235)
        Me.TurismTree.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.RosyBrown
        Me.btnClose.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(671, 286)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 35)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Inchide"
        Me.btnClose.UseVisualStyleBackColor = False
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RosyBrown
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(671, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Write .xlsx"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem
        '
        Me.PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem.Name = "PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem"
        Me.PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem.Text = "7. Previziuni asupra veniturilor din campaniile publicitare"
        '
        'MapClientToolStripMenuItem
        '
        Me.MapClientToolStripMenuItem.Name = "MapClientToolStripMenuItem"
        Me.MapClientToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.MapClientToolStripMenuItem.Text = "8. Map client"
        '
        'MapPromovareToolStripMenuItem
        '
        Me.MapPromovareToolStripMenuItem.Name = "MapPromovareToolStripMenuItem"
        Me.MapPromovareToolStripMenuItem.Size = New System.Drawing.Size(516, 30)
        Me.MapPromovareToolStripMenuItem.Text = "9. Map promovare"
        '
        'Meniu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hoteluri.My.Resources.Resources._3
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TurismTree)
        Me.Controls.Add(Me.btnIerarhie)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Meniu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meniu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SIADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircuiteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetaliiCircuitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacheteTuristiceBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GraficeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformatiiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CeleMaiVizitateCircuiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SiatuatiaCererilorPeAnumitePerioadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrincipaleleCauzeAleNemltumirilorClientilorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriiDeClientiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpactulIntroduceriiUnorNoiCircuiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpactulUneiCampaniiPublicitareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SIADDataSet As Hoteluri.SIADDataSet
    Friend WithEvents CircuiteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CircuiteTableAdapter As Hoteluri.SIADDataSetTableAdapters.CircuiteTableAdapter
    Friend WithEvents TableAdapterManager As Hoteluri.SIADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetaliiCircuitTableAdapter As Hoteluri.SIADDataSetTableAdapters.DetaliiCircuitTableAdapter
    Friend WithEvents DetaliiCircuitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacheteTuristiceTableAdapter As Hoteluri.SIADDataSetTableAdapters.PacheteTuristiceTableAdapter
    Friend WithEvents PacheteTuristiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnIerarhie As System.Windows.Forms.Button
    Friend WithEvents TurismTree As System.Windows.Forms.TreeView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PreviziuniAsupraVeniturilorDinCampaniilePublicitareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapPromovareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
