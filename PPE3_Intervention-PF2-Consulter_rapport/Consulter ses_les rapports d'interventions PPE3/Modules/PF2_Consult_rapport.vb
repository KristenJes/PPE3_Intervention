
Imports System.Data.SqlClient

Public Class PF2_Consult_rapport

    Dim Interv As New CurdIntervention

    Dim connString As String
    Dim donnee As DataTable



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Interv.afficheIHMInterv(Me, ListView1)


        'Dim resultSelect As DataTable = Connexion.ORA.Table("SELECT interv_id || ' - ' || interv_lieu ||' - ' || interv_dte || ' - ' || SIN_ID || ' - ' || SIN_NATURE from intervention inner join sinistre on intervention.interv_sin_id=sinistre.sin_id ")

        'For Each nom As DataRow In resultSelect.Rows
        '    interv_id = nom("interv_id").ToString
        '    interv_lieu = nom("interv_lieu").ToString
        '    'CIS_NOM = nom("CIS_NOM").ToString
        '    interv_dte = nom("interv_dte").ToString
        '    SIN_ID = nom("SIN_ID").ToString
        '    SIN_NATURE = nom("SIN_NATURE").ToString
        'Next


    End Sub











    Private Sub btnselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselect.Click
        Rapports.ShowDialog()


    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub
End Class
