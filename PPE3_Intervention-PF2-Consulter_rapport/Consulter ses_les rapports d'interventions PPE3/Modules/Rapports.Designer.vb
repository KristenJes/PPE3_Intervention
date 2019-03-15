<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rapports
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
        Me.BT_FERMER = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BT_FERMER
        '
        Me.BT_FERMER.Location = New System.Drawing.Point(87, 101)
        Me.BT_FERMER.Name = "BT_FERMER"
        Me.BT_FERMER.Size = New System.Drawing.Size(132, 65)
        Me.BT_FERMER.TabIndex = 0
        Me.BT_FERMER.Text = "Fermer"
        Me.BT_FERMER.UseVisualStyleBackColor = True
        '
        'Rapports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BT_FERMER)
        Me.Name = "Rapports"
        Me.Text = "Rapports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BT_FERMER As System.Windows.Forms.Button
End Class
