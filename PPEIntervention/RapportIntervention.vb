Public Class RapportIntervention

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Dim nbComp As Integer

    Private Sub RapportIntervention_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=CNX_ORAD22;Uid=SDIS29;Pwd=Iroise29;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

refaire:
        Try
            nbComp = InputBox("Entrez le nombre de pompiers pour le départ")
        Catch ex As Exception
            MessageBox.Show("Entrez un nombre")
            GoTo refaire
        End Try

        If nbComp < 2 Or nbComp > 6 Then
            MessageBox.Show("Aucun véhicule n'est disponible pour " & nbComp & " pompier(s)")
            GoTo refaire
        End If


        Select Case nbComp

            Case 5
                lblComp6.Hide()
                txtComp6.Hide()

            Case 3
                lblComp4.Hide()
                txtComp4.Hide()

        End Select

        Me.ajustIHM(nbComp)

    End Sub

    Function ajustIHM(ByVal unNbComp As Integer)

        Select Case unNbComp

            Case 3 To 4
                panDep.Height = 267
                panComp.Height = 87
                Me.Height = 478

                btnValider.Location = New Point(583, 407)

                lblDteDep.Location = New Point(19, 179)
                txtDteDep.Location = New Point(95, 176)
                lblDteRetour.Location = New Point(237, 179)
                txtDteRetour.Location = New Point(293, 176)
                lblNbKm.Location = New Point(441, 179)
                txtNbKm.Location = New Point(518, 176)

                lblCommDep.Location = New Point(19, 211)
                txtCommDep.Location = New Point(95, 208)

            Case 2
                panDep.Height = 236
                panComp.Height = 56
                Me.Height = 447

                btnValider.Location = New Point(583, 376)

                lblDteDep.Location = New Point(19, 148)
                txtDteDep.Location = New Point(95, 145)
                lblDteRetour.Location = New Point(237, 148)
                txtDteRetour.Location = New Point(293, 145)
                lblNbKm.Location = New Point(441, 148)
                txtNbKm.Location = New Point(518, 145)

                lblCommDep.Location = New Point(19, 180)
                txtCommDep.Location = New Point(95, 177)

        End Select

        Return 0

    End Function

End Class
