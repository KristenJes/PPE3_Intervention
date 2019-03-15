<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Renfort
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
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.listViewVehicule = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEnvoi = New System.Windows.Forms.Button()
        Me.comboBoxVehicule = New System.Windows.Forms.ComboBox()
        Me.lblVehicule = New System.Windows.Forms.Label()
        Me.lblInterNom = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Centre de secours"
        Me.ColumnHeader1.Width = 157
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(313, 87)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(83, 21)
        Me.btnAjouter.TabIndex = 13
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'listViewVehicule
        '
        Me.listViewVehicule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listViewVehicule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.listViewVehicule.Location = New System.Drawing.Point(6, 5)
        Me.listViewVehicule.Name = "listViewVehicule"
        Me.listViewVehicule.Size = New System.Drawing.Size(322, 225)
        Me.listViewVehicule.TabIndex = 0
        Me.listViewVehicule.UseCompatibleStateImageBehavior = False
        Me.listViewVehicule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Véhicule"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 161
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.listViewVehicule)
        Me.Panel1.Location = New System.Drawing.Point(68, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 233)
        Me.Panel1.TabIndex = 12
        '
        'btnEnvoi
        '
        Me.btnEnvoi.Location = New System.Drawing.Point(297, 366)
        Me.btnEnvoi.Name = "btnEnvoi"
        Me.btnEnvoi.Size = New System.Drawing.Size(103, 26)
        Me.btnEnvoi.TabIndex = 11
        Me.btnEnvoi.Text = "Envoi"
        Me.btnEnvoi.UseVisualStyleBackColor = True
        '
        'comboBoxVehicule
        '
        Me.comboBoxVehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxVehicule.FormattingEnabled = True
        Me.comboBoxVehicule.Location = New System.Drawing.Point(188, 87)
        Me.comboBoxVehicule.Name = "comboBoxVehicule"
        Me.comboBoxVehicule.Size = New System.Drawing.Size(99, 21)
        Me.comboBoxVehicule.TabIndex = 10
        '
        'lblVehicule
        '
        Me.lblVehicule.AutoSize = True
        Me.lblVehicule.Location = New System.Drawing.Point(72, 90)
        Me.lblVehicule.Name = "lblVehicule"
        Me.lblVehicule.Size = New System.Drawing.Size(98, 13)
        Me.lblVehicule.TabIndex = 9
        Me.lblVehicule.Text = "Véhicule à ajouter :"
        '
        'lblInterNom
        '
        Me.lblInterNom.AutoSize = True
        Me.lblInterNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterNom.Location = New System.Drawing.Point(106, 35)
        Me.lblInterNom.Name = "lblInterNom"
        Me.lblInterNom.Size = New System.Drawing.Size(261, 16)
        Me.lblInterNom.TabIndex = 8
        Me.lblInterNom.Text = "48 - Malaise Léger  VP - Saint Renan"
        '
        'Renfort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 426)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEnvoi)
        Me.Controls.Add(Me.comboBoxVehicule)
        Me.Controls.Add(Me.lblVehicule)
        Me.Controls.Add(Me.lblInterNom)
        Me.Name = "Renfort"
        Me.Text = "Renfort"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents listViewVehicule As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEnvoi As System.Windows.Forms.Button
    Friend WithEvents comboBoxVehicule As System.Windows.Forms.ComboBox
    Friend WithEvents lblVehicule As System.Windows.Forms.Label
    Friend WithEvents lblInterNom As System.Windows.Forms.Label
End Class
