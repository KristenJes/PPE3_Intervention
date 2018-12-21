Public Class CTA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        PF1_GrilleAppel.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        ConnexionSGBD.Show()
    End Sub

    Private Sub CTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Me.Hide()
        ConnexionSGBD.Show()
    End Sub
End Class