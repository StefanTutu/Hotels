<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logare
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
        Me.Utilizator = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtParola = New System.Windows.Forms.TextBox()
        Me.btnLogare = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Utilizator
        '
        Me.Utilizator.AutoSize = True
        Me.Utilizator.BackColor = System.Drawing.Color.Transparent
        Me.Utilizator.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Utilizator.ForeColor = System.Drawing.Color.DarkRed
        Me.Utilizator.Location = New System.Drawing.Point(29, 46)
        Me.Utilizator.Name = "Utilizator"
        Me.Utilizator.Size = New System.Drawing.Size(72, 18)
        Me.Utilizator.TabIndex = 0
        Me.Utilizator.Text = "Utilizator"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtUsername.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(32, 67)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(176, 25)
        Me.txtUsername.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.DarkRed
        Me.label2.Location = New System.Drawing.Point(29, 104)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 18)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Parolă:"
        '
        'txtParola
        '
        Me.txtParola.AcceptsReturn = True
        Me.txtParola.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtParola.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtParola.Location = New System.Drawing.Point(32, 125)
        Me.txtParola.Name = "txtParola"
        Me.txtParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtParola.Size = New System.Drawing.Size(176, 25)
        Me.txtParola.TabIndex = 6
        '
        'btnLogare
        '
        Me.btnLogare.BackColor = System.Drawing.Color.Salmon
        Me.btnLogare.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnLogare.Location = New System.Drawing.Point(32, 172)
        Me.btnLogare.Name = "btnLogare"
        Me.btnLogare.Size = New System.Drawing.Size(176, 42)
        Me.btnLogare.TabIndex = 7
        Me.btnLogare.Text = "Logare"
        Me.btnLogare.UseVisualStyleBackColor = False
        '
        'Logare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hoteluri.My.Resources.Resources._4
        Me.ClientSize = New System.Drawing.Size(244, 261)
        Me.Controls.Add(Me.btnLogare)
        Me.Controls.Add(Me.txtParola)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Utilizator)
        Me.Name = "Logare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Utilizator As System.Windows.Forms.Label
    Private WithEvents txtUsername As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtParola As System.Windows.Forms.TextBox
    Private WithEvents btnLogare As System.Windows.Forms.Button
End Class
