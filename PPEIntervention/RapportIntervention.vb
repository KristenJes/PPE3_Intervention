Public Class RapportIntervention

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    'Dim nbComp As Integer
    'Dim etatInterv As String = "En Cours"

    Private Sub RapportIntervention_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSetSDIS.SINISTRE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SINISTRETableAdapter.Fill(Me.DataSetSDIS.SINISTRE)
        'TODO: cette ligne de code charge les données dans la table 'DataSetSDIS.ENGIN'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ENGINTableAdapter.Fill(Me.DataSetSDIS.ENGIN)
        'TODO: cette ligne de code charge les données dans la table 'DataSetSDIS.CASERNE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CASERNETableAdapter.Fill(Me.DataSetSDIS.CASERNE)
        'TODO: cette ligne de code charge les données dans la table 'DataSetSDIS.TYPE_ENGIN'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TYPE_ENGINTableAdapter.Fill(Me.DataSetSDIS.TYPE_ENGIN)
        'TODO: cette ligne de code charge les données dans la table 'DataSetSDIS.INTERVENTION'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.INTERVENTIONTableAdapter.Fill(Me.DataSetSDIS.INTERVENTION)

        connString = "DSN=CNX_ORAD22;Uid=SDIS29;Pwd=Iroise29;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        CBoxTypeEngin.DisplayMember = "TYPE_ENG_NOM"
        CBoxCentre.DisplayMember = "CIS_NOM"

        SelCenOrderedToolStripButton.PerformClick()
        SelCenOrderedToolStrip.Visible = False

    End Sub

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

        Dim qModifInterv As String = "UPDATE INTERVENTION SET INTERV_COMMENTAIRE = '" & txtCommInterv.Text & "', STATUT_INTERV = 'Terminée',  WHERE INTERV_ID = " & txtNumInterv.Text & ";"
        myCommand.Connection = myConnection
        myCommand.CommandText = qModifInterv
        myCommand.ExecuteNonQuery()
        MessageBox.Show("Modification effectuée")

    End Sub


    Private Sub CBoxTypeEngin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxTypeEngin.SelectedIndexChanged
        Dim qSelPlaces As String = "SELECT TYPE_ENG_PLACES FROM TYPE_ENGIN WHERE TYPE_ENG_ID = " & CBoxTypeEngin.SelectedIndex + 1 & ";"
        myAdapter = New Odbc.OdbcDataAdapter(qSelPlaces, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        Dim donneeEngPla As New DataTable
        Try
            myAdapter.Fill(donneeEngPla)
            Dim row As DataRow = donneeEngPla.Rows(0)
            'MessageBox.Show(row("TYPE_ENG_PLACES").ToString)
            Me.ajustIHM(row("TYPE_ENG_PLACES"))
            selectEngin()
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub SelCenOrderedToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelCenOrderedToolStripButton.Click
        Try
            Me.CASERNETableAdapter.SelCenOrdered(Me.DataSetSDIS.CASERNE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Ajuste l'IHM en fonction du nombre de places dans l'engin
    Function ajustIHM(ByVal unNbComp As Integer)

        Select Case unNbComp

            Case 5 To 6

                If unNbComp = 5 Then
                    lblComp6.Hide()
                    txtComp6.Hide()
                ElseIf unNbComp = 6 Then
                    lblComp6.Show()
                    txtComp6.Show()
                End If

                lblComp4.Show()
                txtComp4.Show()

                panDep.Height = 325
                panComp.Height = 121
                Me.Height = 542

                btnValider.Location = New Point(583, 468)
                btnValiderDep.Location = New Point(523, 293)

                lblDteDep.Location = New Point(19, 213)
                txtDteDep.Location = New Point(95, 210)
                lblDteRetour.Location = New Point(237, 213)
                txtDteRetour.Location = New Point(293, 210)
                lblNbKm.Location = New Point(441, 213)
                txtNbKm.Location = New Point(518, 210)

                lblCommDep.Location = New Point(19, 245)
                txtCommDep.Location = New Point(95, 242)

            Case 3 To 4

                If unNbComp = 3 Then
                    lblComp4.Hide()
                    txtComp4.Hide()
                ElseIf unNbComp = 4 Then
                    lblComp4.Show()
                    txtComp4.Show()
                End If

                panDep.Height = 291
                panComp.Height = 87
                Me.Height = 500

                btnValider.Location = New Point(583, 431)
                btnValiderDep.Location = New Point(523, 260)

                lblDteDep.Location = New Point(19, 179)
                txtDteDep.Location = New Point(95, 176)
                lblDteRetour.Location = New Point(237, 179)
                txtDteRetour.Location = New Point(293, 176)
                lblNbKm.Location = New Point(441, 179)
                txtNbKm.Location = New Point(518, 176)

                lblCommDep.Location = New Point(19, 211)
                txtCommDep.Location = New Point(95, 208)

            Case 2
                panDep.Height = 260
                panComp.Height = 56
                Me.Height = 469

                btnValider.Location = New Point(583, 400)
                btnValiderDep.Location = New Point(523, 229)

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

    Function selectEngin()
        Dim qSelEngin As String = "SELECT ENGIN_ID, ENGIN_NOM FROM ENGIN, TYPE_ENGIN, CASERNE WHERE ENGIN.TYPE_ENG_ID = TYPE_ENGIN.TYPE_ENG_ID AND ENGIN.CIS_ID = CASERNE.CIS_ID AND TYPE_ENG_NOM = " & CBoxTypeEngin.SelectedValue & " AND CIS_NOM = " & CBoxCentre.SelectedValue & ";"
        myAdapter = New Odbc.OdbcDataAdapter(qSelEngin, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        Dim donneeEngin As New DataTable
        Try
            myAdapter.Fill(donneeEngin)
            Dim row As DataRow = donneeEngin.Rows(0)
            MessageBox.Show(row("ENGIN_NOM").ToString)
            CBoxEngin.DisplayMember = row("ENGIN_NOM").ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return 0

    End Function

End Class
