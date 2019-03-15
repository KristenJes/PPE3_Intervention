﻿Public Class SelectionIntervention

    Dim OracleUtils As Connexion
    Dim sdisQuery As String
    Dim valeurComboBox As String
    Dim interventionID As String



    Private Sub SelectionIntervention_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Connexion à la DB
        OracleUtils = New Connexion("SDIS29_PPE3", "SDIS29", "Iroise29")

        'Requête Select
        Dim resultSelect As DataTable
        sdisQuery = "SELECT sin_nature || ' - ' || interv_lieu || ' / ID:' || interv_id FROM INTERVENTION, SINISTRE WHERE INTERVENTION.INTERV_SIN_ID=SINISTRE.SIN_ID AND STATUT_INTERV <> 'TERMINE' ORDER BY interv_id"
        resultSelect = OracleUtils.Table(sdisQuery)

        Dim resultInterv = ""

        Dim listeIntervention As List(Of String)
        listeIntervention = New List(Of String)

        For Each resultSelectFinal As DataRow In resultSelect.Rows
            resultInterv = resultSelectFinal.Item(0).ToString
            listeIntervention.Add(resultInterv)
        Next

        selectInterComboBox.DataSource = listeIntervention
    End Sub

    Private Sub selectIntervButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectIntervButton.Click

        valeurComboBox = selectInterComboBox.SelectedValue.ToString

        interventionID = Split(valeurComboBox, "ID:")(1)
        Dim Intervention As New INTERVENTION(interventionID, valeurComboBox)

        Intervention.labelInterName.Text = Split(valeurComboBox, "/")(0)
        Intervention.Show()
        Renfort.lblInterNom.Text = valeurComboBox
        Me.Hide()

    End Sub


    Public Function getInterventionID()
        Return Me.interventionID
    End Function

    Private Sub selectInterComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles selectInterComboBox.SelectedIndexChanged

    End Sub
End Class