Public Class ConnexionSGBD

    Private Sub btnConnexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnexion.Click
        Try
            Dim Log = New Utilisateur(LoginTextbox.Text, mdpTextBox.Text)

            Select Case Log.profil
                Case "CTA"
                    Me.Hide()
                    CTA.Show()
                Case "CODIS"
                    Me.Hide()
                Case "SP"
                    Me.Hide()
            End Select
        Catch ex As Exception
            MessageBox.Show("Identifiant(s) incorrecte(s)")
        End Try
    End Sub

    Private Sub ConnexionSGBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        mdpTextBox.Text = ""
    End Sub
End Class