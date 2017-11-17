Public Class Logare

    Dim x As Integer
    Dim y As Integer
    Dim check1 As Boolean = False
    Dim check2 As Boolean = False
    Public Logare()
    Private Sub Executa()
        If txtUsername.Text = "" Then
            check1 = False
            MessageBox.Show("Trebuie sa introduceti un nume de utilizator!")
        Else
            check1 = True
        End If
        If txtParola.Text = "" Then
            check2 = False
            MessageBox.Show("Trebuie sa introduceti o parola!")
        Else
            check2 = True
        End If
        If check1 = True AndAlso check2 = True Then
            If txtUsername.Text = "admin" AndAlso txtParola.Text = "parola" Then
                x = -1
                Dim newform As New Informatii(x, 0)
                Hide()
                newform.Show()
            Else
                If txtUsername.Text = "contabil" AndAlso txtParola.Text = "contabil" Then
                    x = 2
                    y = 0
                    Dim newform As New Informatii(x, y)
                    Hide()
                    newform.Show()
                Else

                    If txtUsername.Text = "manager" AndAlso txtParola.Text = "manager" Then
                        x = 1
                        y = 0
                        Dim newform As New Informatii(x, y)
                        Hide()
                        newform.Show()
                    Else
                        MessageBox.Show("Nume de utilizator sau parola gresita!")
                    End If
                End If
            End If
        End If

        If x = 0 Then
            MessageBox.Show("Nume de utilizator sau parola gresita!")
        End If
    End Sub

    Private Sub btnLogare_Click(sender As Object, e As EventArgs) Handles btnLogare.Click

        Executa()
    
       
    End Sub

    Private Sub Parola_KeyDown(KeyCode As Integer, Shift As Integer)
        If KeyCode = 13 Then
            Executa()

        End If
    End Sub

    Private Sub txtParola_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParola.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            btnLogare.PerformClick()
        End If
    End Sub
End Class