<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportIntervention
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNumInterv = New System.Windows.Forms.TextBox()
        Me.txtDteInterv = New System.Windows.Forms.TextBox()
        Me.txtNumSinistre = New System.Windows.Forms.TextBox()
        Me.txtLibSinistre = New System.Windows.Forms.TextBox()
        Me.txtCommInterv = New System.Windows.Forms.TextBox()
        Me.lblNumInterv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSinistre = New System.Windows.Forms.Label()
        Me.lblCommInterv = New System.Windows.Forms.Label()
        Me.txtCommDep = New System.Windows.Forms.TextBox()
        Me.txtNbKm = New System.Windows.Forms.TextBox()
        Me.txtDteDep = New System.Windows.Forms.TextBox()
        Me.txtDteRetour = New System.Windows.Forms.TextBox()
        Me.lblCommDep = New System.Windows.Forms.Label()
        Me.lblNbKm = New System.Windows.Forms.Label()
        Me.lblDteRetour = New System.Windows.Forms.Label()
        Me.lblDteDep = New System.Windows.Forms.Label()
        Me.txtCentre = New System.Windows.Forms.TextBox()
        Me.txtTypeEngin = New System.Windows.Forms.TextBox()
        Me.txtEngin = New System.Windows.Forms.TextBox()
        Me.txtNumDep = New System.Windows.Forms.TextBox()
        Me.lblCentre = New System.Windows.Forms.Label()
        Me.lblTypeEngin = New System.Windows.Forms.Label()
        Me.lblEngin = New System.Windows.Forms.Label()
        Me.lblNumDep = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.panDep = New System.Windows.Forms.GroupBox()
        Me.lblComp1 = New System.Windows.Forms.Label()
        Me.lblComp3 = New System.Windows.Forms.Label()
        Me.lblComp5 = New System.Windows.Forms.Label()
        Me.lblComp2 = New System.Windows.Forms.Label()
        Me.lblComp4 = New System.Windows.Forms.Label()
        Me.lblComp6 = New System.Windows.Forms.Label()
        Me.txtComp1 = New System.Windows.Forms.TextBox()
        Me.txtComp3 = New System.Windows.Forms.TextBox()
        Me.txtComp5 = New System.Windows.Forms.TextBox()
        Me.txtComp2 = New System.Windows.Forms.TextBox()
        Me.txtComp4 = New System.Windows.Forms.TextBox()
        Me.txtComp6 = New System.Windows.Forms.TextBox()
        Me.panComp = New System.Windows.Forms.GroupBox()
        Me.panDep.SuspendLayout()
        Me.panComp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumInterv
        '
        Me.txtNumInterv.Location = New System.Drawing.Point(101, 12)
        Me.txtNumInterv.Name = "txtNumInterv"
        Me.txtNumInterv.Size = New System.Drawing.Size(48, 20)
        Me.txtNumInterv.TabIndex = 0
        '
        'txtDteInterv
        '
        Me.txtDteInterv.Location = New System.Drawing.Point(209, 12)
        Me.txtDteInterv.Name = "txtDteInterv"
        Me.txtDteInterv.Size = New System.Drawing.Size(132, 20)
        Me.txtDteInterv.TabIndex = 1
        '
        'txtNumSinistre
        '
        Me.txtNumSinistre.Location = New System.Drawing.Point(413, 12)
        Me.txtNumSinistre.Name = "txtNumSinistre"
        Me.txtNumSinistre.Size = New System.Drawing.Size(45, 20)
        Me.txtNumSinistre.TabIndex = 2
        '
        'txtLibSinistre
        '
        Me.txtLibSinistre.Location = New System.Drawing.Point(464, 12)
        Me.txtLibSinistre.Name = "txtLibSinistre"
        Me.txtLibSinistre.Size = New System.Drawing.Size(157, 20)
        Me.txtLibSinistre.TabIndex = 3
        '
        'txtCommInterv
        '
        Me.txtCommInterv.Location = New System.Drawing.Point(101, 65)
        Me.txtCommInterv.Multiline = True
        Me.txtCommInterv.Name = "txtCommInterv"
        Me.txtCommInterv.Size = New System.Drawing.Size(520, 46)
        Me.txtCommInterv.TabIndex = 4
        '
        'lblNumInterv
        '
        Me.lblNumInterv.AutoSize = True
        Me.lblNumInterv.Location = New System.Drawing.Point(3, 15)
        Me.lblNumInterv.Name = "lblNumInterv"
        Me.lblNumInterv.Size = New System.Drawing.Size(78, 13)
        Me.lblNumInterv.TabIndex = 5
        Me.lblNumInterv.Text = "Intervention N°"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Du"
        '
        'lblSinistre
        '
        Me.lblSinistre.AutoSize = True
        Me.lblSinistre.Location = New System.Drawing.Point(366, 15)
        Me.lblSinistre.Name = "lblSinistre"
        Me.lblSinistre.Size = New System.Drawing.Size(41, 13)
        Me.lblSinistre.TabIndex = 7
        Me.lblSinistre.Text = "Sinistre"
        '
        'lblCommInterv
        '
        Me.lblCommInterv.AutoSize = True
        Me.lblCommInterv.Location = New System.Drawing.Point(13, 65)
        Me.lblCommInterv.Name = "lblCommInterv"
        Me.lblCommInterv.Size = New System.Drawing.Size(68, 13)
        Me.lblCommInterv.TabIndex = 8
        Me.lblCommInterv.Text = "Commentaire"
        '
        'txtCommDep
        '
        Me.txtCommDep.Location = New System.Drawing.Point(95, 242)
        Me.txtCommDep.Multiline = True
        Me.txtCommDep.Name = "txtCommDep"
        Me.txtCommDep.Size = New System.Drawing.Size(520, 45)
        Me.txtCommDep.TabIndex = 15
        '
        'txtNbKm
        '
        Me.txtNbKm.Location = New System.Drawing.Point(518, 210)
        Me.txtNbKm.Name = "txtNbKm"
        Me.txtNbKm.Size = New System.Drawing.Size(100, 20)
        Me.txtNbKm.TabIndex = 14
        '
        'txtDteDep
        '
        Me.txtDteDep.Location = New System.Drawing.Point(95, 210)
        Me.txtDteDep.Name = "txtDteDep"
        Me.txtDteDep.Size = New System.Drawing.Size(123, 20)
        Me.txtDteDep.TabIndex = 13
        '
        'txtDteRetour
        '
        Me.txtDteRetour.Location = New System.Drawing.Point(293, 210)
        Me.txtDteRetour.Name = "txtDteRetour"
        Me.txtDteRetour.Size = New System.Drawing.Size(123, 20)
        Me.txtDteRetour.TabIndex = 12
        '
        'lblCommDep
        '
        Me.lblCommDep.AutoSize = True
        Me.lblCommDep.Location = New System.Drawing.Point(19, 245)
        Me.lblCommDep.Name = "lblCommDep"
        Me.lblCommDep.Size = New System.Drawing.Size(68, 13)
        Me.lblCommDep.TabIndex = 11
        Me.lblCommDep.Text = "Commentaire"
        '
        'lblNbKm
        '
        Me.lblNbKm.AutoSize = True
        Me.lblNbKm.Location = New System.Drawing.Point(441, 213)
        Me.lblNbKm.Name = "lblNbKm"
        Me.lblNbKm.Size = New System.Drawing.Size(71, 13)
        Me.lblNbKm.TabIndex = 10
        Me.lblNbKm.Text = "Nb kilometres"
        '
        'lblDteRetour
        '
        Me.lblDteRetour.AutoSize = True
        Me.lblDteRetour.Location = New System.Drawing.Point(237, 213)
        Me.lblDteRetour.Name = "lblDteRetour"
        Me.lblDteRetour.Size = New System.Drawing.Size(50, 13)
        Me.lblDteRetour.TabIndex = 9
        Me.lblDteRetour.Text = "Retour le"
        '
        'lblDteDep
        '
        Me.lblDteDep.AutoSize = True
        Me.lblDteDep.Location = New System.Drawing.Point(19, 213)
        Me.lblDteDep.Name = "lblDteDep"
        Me.lblDteDep.Size = New System.Drawing.Size(50, 13)
        Me.lblDteDep.TabIndex = 8
        Me.lblDteDep.Text = "Départ le"
        '
        'txtCentre
        '
        Me.txtCentre.Location = New System.Drawing.Point(524, 57)
        Me.txtCentre.Name = "txtCentre"
        Me.txtCentre.Size = New System.Drawing.Size(114, 20)
        Me.txtCentre.TabIndex = 7
        '
        'txtTypeEngin
        '
        Me.txtTypeEngin.Location = New System.Drawing.Point(332, 57)
        Me.txtTypeEngin.Name = "txtTypeEngin"
        Me.txtTypeEngin.Size = New System.Drawing.Size(122, 20)
        Me.txtTypeEngin.TabIndex = 6
        '
        'txtEngin
        '
        Me.txtEngin.Location = New System.Drawing.Point(95, 57)
        Me.txtEngin.Name = "txtEngin"
        Me.txtEngin.Size = New System.Drawing.Size(150, 20)
        Me.txtEngin.TabIndex = 5
        '
        'txtNumDep
        '
        Me.txtNumDep.Location = New System.Drawing.Point(95, 23)
        Me.txtNumDep.Name = "txtNumDep"
        Me.txtNumDep.Size = New System.Drawing.Size(150, 20)
        Me.txtNumDep.TabIndex = 4
        '
        'lblCentre
        '
        Me.lblCentre.AutoSize = True
        Me.lblCentre.Location = New System.Drawing.Point(480, 60)
        Me.lblCentre.Name = "lblCentre"
        Me.lblCentre.Size = New System.Drawing.Size(38, 13)
        Me.lblCentre.TabIndex = 3
        Me.lblCentre.Text = "Centre"
        '
        'lblTypeEngin
        '
        Me.lblTypeEngin.AutoSize = True
        Me.lblTypeEngin.Location = New System.Drawing.Point(265, 60)
        Me.lblTypeEngin.Name = "lblTypeEngin"
        Me.lblTypeEngin.Size = New System.Drawing.Size(61, 13)
        Me.lblTypeEngin.TabIndex = 2
        Me.lblTypeEngin.Text = "Type Engin"
        '
        'lblEngin
        '
        Me.lblEngin.AutoSize = True
        Me.lblEngin.Location = New System.Drawing.Point(19, 60)
        Me.lblEngin.Name = "lblEngin"
        Me.lblEngin.Size = New System.Drawing.Size(34, 13)
        Me.lblEngin.TabIndex = 1
        Me.lblEngin.Text = "Engin"
        '
        'lblNumDep
        '
        Me.lblNumDep.AutoSize = True
        Me.lblNumDep.Location = New System.Drawing.Point(19, 26)
        Me.lblNumDep.Name = "lblNumDep"
        Me.lblNumDep.Size = New System.Drawing.Size(54, 13)
        Me.lblNumDep.TabIndex = 0
        Me.lblNumDep.Text = "Départ N°"
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(583, 441)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 10
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'panDep
        '
        Me.panDep.Controls.Add(Me.panComp)
        Me.panDep.Controls.Add(Me.txtCommDep)
        Me.panDep.Controls.Add(Me.txtEngin)
        Me.panDep.Controls.Add(Me.lblCommDep)
        Me.panDep.Controls.Add(Me.txtNbKm)
        Me.panDep.Controls.Add(Me.lblNumDep)
        Me.panDep.Controls.Add(Me.txtDteRetour)
        Me.panDep.Controls.Add(Me.lblNbKm)
        Me.panDep.Controls.Add(Me.txtDteDep)
        Me.panDep.Controls.Add(Me.lblDteRetour)
        Me.panDep.Controls.Add(Me.txtNumDep)
        Me.panDep.Controls.Add(Me.lblEngin)
        Me.panDep.Controls.Add(Me.lblTypeEngin)
        Me.panDep.Controls.Add(Me.txtTypeEngin)
        Me.panDep.Controls.Add(Me.lblCentre)
        Me.panDep.Controls.Add(Me.lblDteDep)
        Me.panDep.Controls.Add(Me.txtCentre)
        Me.panDep.Location = New System.Drawing.Point(6, 134)
        Me.panDep.Name = "panDep"
        Me.panDep.Size = New System.Drawing.Size(652, 301)
        Me.panDep.TabIndex = 11
        Me.panDep.TabStop = False
        Me.panDep.Text = "Départ"
        '
        'lblComp1
        '
        Me.lblComp1.AutoSize = True
        Me.lblComp1.Location = New System.Drawing.Point(10, 27)
        Me.lblComp1.Name = "lblComp1"
        Me.lblComp1.Size = New System.Drawing.Size(54, 13)
        Me.lblComp1.TabIndex = 0
        Me.lblComp1.Text = "Membre 1"
        '
        'lblComp3
        '
        Me.lblComp3.AutoSize = True
        Me.lblComp3.Location = New System.Drawing.Point(10, 59)
        Me.lblComp3.Name = "lblComp3"
        Me.lblComp3.Size = New System.Drawing.Size(54, 13)
        Me.lblComp3.TabIndex = 1
        Me.lblComp3.Text = "Membre 3"
        '
        'lblComp5
        '
        Me.lblComp5.AutoSize = True
        Me.lblComp5.Location = New System.Drawing.Point(10, 91)
        Me.lblComp5.Name = "lblComp5"
        Me.lblComp5.Size = New System.Drawing.Size(54, 13)
        Me.lblComp5.TabIndex = 2
        Me.lblComp5.Text = "Membre 5"
        '
        'lblComp2
        '
        Me.lblComp2.AutoSize = True
        Me.lblComp2.Location = New System.Drawing.Point(196, 27)
        Me.lblComp2.Name = "lblComp2"
        Me.lblComp2.Size = New System.Drawing.Size(54, 13)
        Me.lblComp2.TabIndex = 4
        Me.lblComp2.Text = "Membre 2"
        '
        'lblComp4
        '
        Me.lblComp4.AutoSize = True
        Me.lblComp4.Location = New System.Drawing.Point(196, 59)
        Me.lblComp4.Name = "lblComp4"
        Me.lblComp4.Size = New System.Drawing.Size(54, 13)
        Me.lblComp4.TabIndex = 5
        Me.lblComp4.Text = "Membre 4"
        '
        'lblComp6
        '
        Me.lblComp6.AutoSize = True
        Me.lblComp6.Location = New System.Drawing.Point(196, 91)
        Me.lblComp6.Name = "lblComp6"
        Me.lblComp6.Size = New System.Drawing.Size(54, 13)
        Me.lblComp6.TabIndex = 6
        Me.lblComp6.Text = "Membre 6"
        '
        'txtComp1
        '
        Me.txtComp1.Location = New System.Drawing.Point(70, 24)
        Me.txtComp1.Name = "txtComp1"
        Me.txtComp1.Size = New System.Drawing.Size(100, 20)
        Me.txtComp1.TabIndex = 8
        '
        'txtComp3
        '
        Me.txtComp3.Location = New System.Drawing.Point(70, 56)
        Me.txtComp3.Name = "txtComp3"
        Me.txtComp3.Size = New System.Drawing.Size(100, 20)
        Me.txtComp3.TabIndex = 9
        '
        'txtComp5
        '
        Me.txtComp5.Location = New System.Drawing.Point(70, 88)
        Me.txtComp5.Name = "txtComp5"
        Me.txtComp5.Size = New System.Drawing.Size(100, 20)
        Me.txtComp5.TabIndex = 10
        '
        'txtComp2
        '
        Me.txtComp2.Location = New System.Drawing.Point(256, 24)
        Me.txtComp2.Name = "txtComp2"
        Me.txtComp2.Size = New System.Drawing.Size(100, 20)
        Me.txtComp2.TabIndex = 12
        '
        'txtComp4
        '
        Me.txtComp4.Location = New System.Drawing.Point(256, 56)
        Me.txtComp4.Name = "txtComp4"
        Me.txtComp4.Size = New System.Drawing.Size(100, 20)
        Me.txtComp4.TabIndex = 13
        '
        'txtComp6
        '
        Me.txtComp6.Location = New System.Drawing.Point(256, 88)
        Me.txtComp6.Name = "txtComp6"
        Me.txtComp6.Size = New System.Drawing.Size(100, 20)
        Me.txtComp6.TabIndex = 14
        '
        'panComp
        '
        Me.panComp.Controls.Add(Me.txtComp6)
        Me.panComp.Controls.Add(Me.txtComp4)
        Me.panComp.Controls.Add(Me.txtComp2)
        Me.panComp.Controls.Add(Me.txtComp5)
        Me.panComp.Controls.Add(Me.txtComp3)
        Me.panComp.Controls.Add(Me.txtComp1)
        Me.panComp.Controls.Add(Me.lblComp6)
        Me.panComp.Controls.Add(Me.lblComp4)
        Me.panComp.Controls.Add(Me.lblComp2)
        Me.panComp.Controls.Add(Me.lblComp5)
        Me.panComp.Controls.Add(Me.lblComp3)
        Me.panComp.Controls.Add(Me.lblComp1)
        Me.panComp.Location = New System.Drawing.Point(95, 83)
        Me.panComp.Name = "panComp"
        Me.panComp.Size = New System.Drawing.Size(384, 121)
        Me.panComp.TabIndex = 16
        Me.panComp.TabStop = False
        Me.panComp.Text = "Composition de l'engin"
        '
        'RapportIntervention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 473)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.panDep)
        Me.Controls.Add(Me.lblCommInterv)
        Me.Controls.Add(Me.lblSinistre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNumInterv)
        Me.Controls.Add(Me.txtCommInterv)
        Me.Controls.Add(Me.txtLibSinistre)
        Me.Controls.Add(Me.txtNumSinistre)
        Me.Controls.Add(Me.txtDteInterv)
        Me.Controls.Add(Me.txtNumInterv)
        Me.Name = "RapportIntervention"
        Me.Text = "INTERVENTION"
        Me.panDep.ResumeLayout(False)
        Me.panDep.PerformLayout()
        Me.panComp.ResumeLayout(False)
        Me.panComp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumInterv As System.Windows.Forms.TextBox
    Friend WithEvents txtDteInterv As System.Windows.Forms.TextBox
    Friend WithEvents txtNumSinistre As System.Windows.Forms.TextBox
    Friend WithEvents txtLibSinistre As System.Windows.Forms.TextBox
    Friend WithEvents txtCommInterv As System.Windows.Forms.TextBox
    Friend WithEvents lblNumInterv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSinistre As System.Windows.Forms.Label
    Friend WithEvents lblCommInterv As System.Windows.Forms.Label
    Friend WithEvents txtCommDep As System.Windows.Forms.TextBox
    Friend WithEvents txtNbKm As System.Windows.Forms.TextBox
    Friend WithEvents txtDteDep As System.Windows.Forms.TextBox
    Friend WithEvents txtDteRetour As System.Windows.Forms.TextBox
    Friend WithEvents lblCommDep As System.Windows.Forms.Label
    Friend WithEvents lblNbKm As System.Windows.Forms.Label
    Friend WithEvents lblDteRetour As System.Windows.Forms.Label
    Friend WithEvents lblDteDep As System.Windows.Forms.Label
    Friend WithEvents txtCentre As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeEngin As System.Windows.Forms.TextBox
    Friend WithEvents txtEngin As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDep As System.Windows.Forms.TextBox
    Friend WithEvents lblCentre As System.Windows.Forms.Label
    Friend WithEvents lblTypeEngin As System.Windows.Forms.Label
    Friend WithEvents lblEngin As System.Windows.Forms.Label
    Friend WithEvents lblNumDep As System.Windows.Forms.Label
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents panDep As System.Windows.Forms.GroupBox
    Friend WithEvents panComp As System.Windows.Forms.GroupBox
    Friend WithEvents txtComp6 As System.Windows.Forms.TextBox
    Friend WithEvents txtComp4 As System.Windows.Forms.TextBox
    Friend WithEvents txtComp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtComp5 As System.Windows.Forms.TextBox
    Friend WithEvents txtComp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtComp1 As System.Windows.Forms.TextBox
    Friend WithEvents lblComp6 As System.Windows.Forms.Label
    Friend WithEvents lblComp4 As System.Windows.Forms.Label
    Friend WithEvents lblComp2 As System.Windows.Forms.Label
    Friend WithEvents lblComp5 As System.Windows.Forms.Label
    Friend WithEvents lblComp3 As System.Windows.Forms.Label
    Friend WithEvents lblComp1 As System.Windows.Forms.Label

End Class
