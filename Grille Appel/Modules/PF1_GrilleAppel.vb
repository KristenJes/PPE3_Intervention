Public Class PF1_GrilleAppel
    Private Sub PF1_GrilleAppel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim query As DataTable = Connexion.ORA.Table("SELECT CIS_NOM FROM CASERNE;")
        For Each NomCaserne In query.Rows
            localisationComboBox.Items.Add(NomCaserne("CIS_NOM"))
            DemComboBox.Items.Add(NomCaserne("CIS_NOM"))
        Next

        query = Connexion.ORA.Table("SELECT SIN_NATURE FROM SINISTRE;")
        For Each unSinistre In query.Rows
            sinistreComboBox.Items.Add(unSinistre("SIN_NATURE"))
        Next

        'TODO: cette ligne de code charge les données dans la table 'DataSet1.COMMUNE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.COMMUNETableAdapter.Fill(Me.DataSet1.COMMUNE)
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.SINISTRE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SINISTRETableAdapter.Fill(Me.DataSet1.SINISTRE)

    End Sub




    Private Sub sinistreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinistreComboBox.SelectedIndexChanged

        'On modifie le numero afficher en fonction du sinistre choisi
        Dim libelleSinistre As String = sinistreComboBox.Text
        Dim query As DataTable = Connexion.ORA.Table("SELECT SIN_ID FROM SINISTRE WHERE SIN_NATURE='" & libelleSinistre & "'")
        sinistreTextBox.Text = query.Rows(0)("SIN_ID").ToString()

        'On Crée un objet sinistre comprenant tous les champs
        Dim Sin As New Sinistre(sinistreTextBox.Text, sinistreComboBox.Text)
        DepartListBox.Items.Clear()
        query = Connexion.ORA.Table("SELECT TYPE_ENG_NOM FROM PREVU,TYPE_ENGIN WHERE(TYPE_ENGIN.TYPE_ENG_ID = PREVU.TYPE_ENG_ID) AND PREVU.SIN_ID=" & sinistreTextBox.Text & ";")
        For Each untypeengin In query.Rows
            DepartListBox.Items.Add(untypeengin("TYPE_ENG_NOM"))
        Next
    End Sub


    Private Sub localisationComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles localisationComboBox.SelectedIndexChanged
        Dim nomcaserne As String = localisationComboBox.Text
        Dim query As DataTable = Connexion.ORA.Table("SELECT CIS_ID FROM CASERNE WHERE CIS_NOM='" & nomcaserne & "'")
        LocaComTextBox.Text = query.Rows(0)("CIS_ID").ToString()
    End Sub


    Private Sub DemComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemComboBox.SelectedIndexChanged
        Dim nomcaserne As String = DemComboBox.Text
        Dim query As DataTable = Connexion.ORA.Table("SELECT CIS_ID FROM CASERNE WHERE CIS_NOM='" & nomcaserne & "'")
        DemComTextBox.Text = query.Rows(0)("CIS_ID").ToString()
    End Sub


    'Verifier si un demandeur existe deja
    Private Sub TelTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelTextBox.TextChanged
        Try
            Dim query As DataTable = Connexion.ORA.Table("SELECT * FROM DEMANDEUR WHERE DEMAND_TEL=" & TelTextBox.Text)
            NomTextBox.Text = query.Rows(0)("DEMAND_NOM")
            PrenomTextBox.Text = query.Rows(0)("DEMAND_PRENOM")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Envoyer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Envoyer.Click
        'CAS ERREURS



        Try
            'DEMANDEUR

            Dim query As DataTable = Connexion.ORA.Table("SELECT COUNT(*) FROM DEMANDEUR")
            Dim demand_id As Integer = query.Rows(0)("COUNT(*)") + 1

            'Verif si exterieur
            Dim DemandExt As Integer
            If DemCheckBox.Checked Then
                DemandExt = 1
            Else
                DemandExt = 0
            End If

            'Insertion des données
            Dim demande As New Demandeur(demand_id, NomTextBox.Text, PrenomTextBox.Text, TelTextBox.Text, DemLieuTextBox.Text, DemNoTextBox.Text, DemandExt, DemEtageTextBox.Text, DemPorteTextBox.Text, DemBatTextBox.Text, DemCodeTextBox.Text, DemComTextBox.Text, DemPreTextBox.Text)
            Connexion.ORA.Execute("INSERT INTO DEMANDEUR (DEMAND_ID,DEMAND_NOM,DEMAND_PRENOM,DEMAND_TEL,DEMAND_LIEU,DEMAND_NO,DEMAND_EXT,DEMAND_ETAGE,DEMAND_PORTE,DEMAND_BAT,DEMAND_CODE,DEMAND_COMMUNE,DEMAND_COMMENTAIRE) VALUES (" & demand_id & ",'" & demande.nom & "','" & demande.prenom & "','" & demande.tel & "','" & demande.lieu & "'," & demande.no & "," & demande.ext & "," & demande.etage & "," & demande.porte & "," & demande.bat & "," & demande.code & "," & demande.caserne & ",'" & demande.commentaire & "' );")



            'INTERVENTION
            query = Connexion.ORA.Table("SELECT MAX(INTERV_ID) FROM INTERVENTION")
            Dim interv_id As Integer = query.Rows(0)("MAX(INTERV_ID)") + 1

            'Verif si exterieur
            Dim IntervExt As Integer
            If LocalCheckBox.Checked Then
                IntervExt = 1
            Else
                IntervExt = 0
            End If

            'Insertion des données
            Dim uneIntervention As New Intervention(interv_id, LocaLieuTextBox.Text, LocaNoTextBox.Text, IntervExt, LocaEtageTextBox.Text, LocaAppTextBox.Text, LocaBatTextBox.Text, LocaCodeTextBox.Text, LocaPreTextBox.Text, sinistreTextBox.Text, LocaComTextBox.Text, sinistreTextBox2.Text, demand_id)
            Connexion.ORA.Execute("INSERT INTO INTERVENTION (INTERV_ID, INTERV_LIEU, INTERV_NO, INTERV_EXT, INTERV_ETAGE, INTERV_PORTE, INTERV_BAT, INTERV_CODE, INTERV_COMMENTAIRE, INTERV_SIN_ID, INTERV_COMMUNE,SIN_OBSERVATION, DEMAND_ID) VALUES (" & interv_id & ",'" & uneIntervention.lieu & "'," & uneIntervention.no & "," & uneIntervention.ext & "," & uneIntervention.etage & "," & uneIntervention.porte & ",'" & uneIntervention.bat & "'," & uneIntervention.code & ",'" & uneIntervention.commentaire & "'," & uneIntervention.sin & "," & uneIntervention.caserne & ",'" & uneIntervention.sinobserv & "'," & demand_id & ");")

            Me.Close()
            CTA.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub PF1_GrilleAppel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        CTA.Show()
    End Sub
End Class
