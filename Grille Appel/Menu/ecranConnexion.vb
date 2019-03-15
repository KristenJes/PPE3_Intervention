''' ###############################################################################################################
''' #                                               INFORMATIONS                                                  #
''' ###############################################################################################################
''' #                                                                                                             #
''' # Nom du fichier         :  Connexion.vb                                                                      #                                                             
''' # Rôle du fichier        :  Interface de connexion                                                            #
''' # Langage                :  Visual Basic                                                                      #
''' # Auteur                 :  Kilian Magniez                                                                    #
''' # Dernière modification  :  14/12/2018                                                                        #
''' # Description            :  envois des information du pompier dans un autre form                              #
''' #                                                                                                             #
''' ###############################################################################################################
''' #                                                 VARIABLES                                                   #
''' ###############################################################################################################
''' #                                                                                                             #
''' # FGD           : Objet                                                                                       #
''' # Result        : Objet                                                                                       #                                                                                                                                                   #
''' # Nom_Pompier   : String                                                                                      #
''' # PrenomPompier : String                                                                                      #
''' # BIP_Pompier   : String                                                                                      #
''' #                                                                                                             #
''' ###############################################################################################################


Public Class ecranConnexion
    ' adamal
    ' a4141283d0b9ffd88e69cdc7983f8763
    Public listeUtilisateur As New ArrayList
    Dim Result As DataRow
    Dim requeteConnexion As String
    Dim requeteInfoPompier As String

    Public Shared instance As Connexion

    Private Sub Connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Affichage du nom de la machine local avec la fonction GetHostname
        TB_Statut.Text = "Nom du PC : " & GetHostname()

        'Affichage de l'adresse IP de la machine local avec la fonction GetIP()
        TB_Statut.Text = TB_Statut.Text & vbCrLf & "IP du PC : " & GetIP()


        TB_Statut.Text = TB_Statut.Text & vbCrLf & ""
        TB_Statut.Text = TB_Statut.Text & vbCrLf & "Connexion à la base SDIS29..."
        instance = New Connexion("SDIS29", "SDIS29", "Iroise29")

        'Masquage des caractères écrit dans la TextBox TB_Motdepasse. Les caractère sont remplacés par des étoiles ("*")
        TB_Motdepasse.PasswordChar = "*"




    End Sub


    Private Sub BT_Connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Connexion.Click
        requeteConnexion = "SELECT LOG_LOGIN, LOG_MDP FROM LOGIN WHERE LOG_LOGIN='" & TB_Identifiant.Text & "' AND LOG_MDP='" & TB_Motdepasse.Text & "';"
        Dim query As DataTable = Connexion.ORA.Table("SELECT LOG_NOM,LOG_PRENOM, LOG_PROFIL FROM LOGIN WHERE LOG_LOGIN='" & TB_Identifiant.Text & "';")

        Try
            Connexion.ORA.Execute(requeteConnexion)
            Dim profil As String = query.Rows(0)("LOG_PROFIL")
            Select Case profil
                Case "CTA"
                    Me.Hide()
                    CTA.Show()
            End Select



        Catch ex As Exception
            LB_message.Text = "/!\ Problème de Connexion /!\"


        End Try



    End Sub
End Class
