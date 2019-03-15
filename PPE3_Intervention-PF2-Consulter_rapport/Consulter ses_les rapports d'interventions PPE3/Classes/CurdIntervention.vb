Public Class CurdIntervention
    'Public Sub AfficheCaserne(ByVal uneListView As ListView)


    'Dim info(7) As String
    'Dim itm As ListViewItem


    'Dim resultSelect As DataTable = Connexion.ORA.Table("SELECT INTERV_ID, INTERV_LIEU FROM INTERVENTION;")
    'For Each nom As DataRow In resultSelect.Rows()
    '    info(0) = nom("INTERV_ID").ToString
    '    info(1) = nom("INTERV_LIEU").ToString


    '    itm = New ListViewItem(info)
    '    uneListView.Items.Add(itm)

    'Next


    ''Dim caserne = "BREST"
    ''Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND CIS_NOM='" & caserne & "';")
    ''For Each nom As DataRow In engin.Rows
    ''    info(0) = nom("CIS_NOM").ToString
    ''    info(1) = nom("ENGIN_NOM").ToString
    ''    info(2) = nom("ENGIN_IMMAT").ToString
    ''    info(3) = nom("ENGIN_ETAT").ToString

    ''    itm = New ListViewItem(info)
    ''    uneListView.Items.Add(itm)
    ''Next

    ''LIAISON AVEC IHM
    Public Sub afficheIHMinterv(ByVal uneFeuille As Form, ByVal uneListView As ListView)

        uneListView.Clear()
        uneListView.Columns.Add("N°", 30, HorizontalAlignment.Left)
        uneListView.Columns.Add("Lieu", 70, HorizontalAlignment.Left)
        uneListView.Columns.Add("Date", 90, HorizontalAlignment.Left)
        uneListView.Columns.Add("ID", 120, HorizontalAlignment.Left)
        uneListView.Columns.Add("Nature du sinistre", 90, HorizontalAlignment.Left)

        Dim info(5) As String
        Dim itm As ListViewItem

        Dim interv As DataTable = Connexion.ORA.Table(" SELECT interv_id ,interv_lieu, interv_dte , SIN_ID , SIN_NATURE from intervention inner join sinistre on intervention.interv_sin_id=sinistre.sin_id ;")
        For Each nom As DataRow In interv.Rows
            info(0) = nom("interv_id").ToString
            info(1) = nom("interv_lieu").ToString
            info(2) = nom("interv_dte").ToString
            info(3) = nom("SIN_ID").ToString
            info(4) = nom("SIN_NATURE").ToString

            itm = New ListViewItem(info)

            uneListView.Items.Add(itm)


        Next
        uneListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

End Class
