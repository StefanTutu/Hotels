<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridExporta = New System.Windows.Forms.DataGridView()
        Me.LocatiiPreferateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridImporta = New System.Windows.Forms.DataGridView()
        Me.btnExportaDate = New System.Windows.Forms.Button()
        Me.btnIncarcaExcel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.gridExporta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocatiiPreferateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridImporta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridExporta
        '
        Me.gridExporta.AllowUserToAddRows = False
        Me.gridExporta.AllowUserToDeleteRows = False
        Me.gridExporta.AutoGenerateColumns = False
        Me.gridExporta.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.gridExporta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridExporta.DataSource = Me.LocatiiPreferateBindingSource
        Me.gridExporta.Location = New System.Drawing.Point(337, 63)
        Me.gridExporta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gridExporta.Name = "gridExporta"
        Me.gridExporta.ReadOnly = True
        Me.gridExporta.Size = New System.Drawing.Size(436, 113)
        Me.gridExporta.TabIndex = 7
        '
        'LocatiiPreferateBindingSource
        '
        Me.LocatiiPreferateBindingSource.DataMember = "LocatiiPreferate"
        '
        'gridImporta
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridImporta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridImporta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridImporta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridImporta.Location = New System.Drawing.Point(242, 351)
        Me.gridImporta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gridImporta.Name = "gridImporta"
        Me.gridImporta.Size = New System.Drawing.Size(530, 198)
        Me.gridImporta.TabIndex = 6
        '
        'btnExportaDate
        '
        Me.btnExportaDate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExportaDate.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportaDate.Location = New System.Drawing.Point(566, 183)
        Me.btnExportaDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExportaDate.Name = "btnExportaDate"
        Me.btnExportaDate.Size = New System.Drawing.Size(206, 44)
        Me.btnExportaDate.TabIndex = 5
        Me.btnExportaDate.Text = "Exporta date in Excel"
        Me.btnExportaDate.UseVisualStyleBackColor = False
        '
        'btnIncarcaExcel
        '
        Me.btnIncarcaExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIncarcaExcel.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncarcaExcel.Location = New System.Drawing.Point(566, 301)
        Me.btnIncarcaExcel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnIncarcaExcel.Name = "btnIncarcaExcel"
        Me.btnIncarcaExcel.Size = New System.Drawing.Size(206, 44)
        Me.btnIncarcaExcel.TabIndex = 4
        Me.btnIncarcaExcel.Text = "Importa date din Excel"
        Me.btnIncarcaExcel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 50)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Importul si exportul datelor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in/din Excel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnClose.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(13, 12)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 44)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Inchide"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hoteluri.My.Resources.Resources._13
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridExporta)
        Me.Controls.Add(Me.gridImporta)
        Me.Controls.Add(Me.btnExportaDate)
        Me.Controls.Add(Me.btnIncarcaExcel)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.gridExporta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocatiiPreferateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridImporta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridExporta As DataGridView
    Friend WithEvents LocatiiPreferateBindingSource As BindingSource
    Friend WithEvents gridImporta As DataGridView
    Friend WithEvents btnExportaDate As Button
    Friend WithEvents btnIncarcaExcel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
End Class
