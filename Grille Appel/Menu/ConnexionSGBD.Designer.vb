<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnexionSGBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConnexionSGBD))
        Me.LoginTextbox = New System.Windows.Forms.TextBox()
        Me.mdpTextBox = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblBienvenue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConnexion = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginTextbox
        '
        Me.LoginTextbox.Location = New System.Drawing.Point(204, 116)
        Me.LoginTextbox.Name = "LoginTextbox"
        Me.LoginTextbox.Size = New System.Drawing.Size(298, 20)
        Me.LoginTextbox.TabIndex = 0
        '
        'mdpTextBox
        '
        Me.mdpTextBox.Location = New System.Drawing.Point(204, 160)
        Me.mdpTextBox.Name = "mdpTextBox"
        Me.mdpTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.mdpTextBox.Size = New System.Drawing.Size(298, 20)
        Me.mdpTextBox.TabIndex = 1
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(101, 116)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(39, 13)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(101, 163)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Mot de Passe :"
        '
        'lblBienvenue
        '
        Me.lblBienvenue.AutoSize = True
        Me.lblBienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenue.ForeColor = System.Drawing.Color.Red
        Me.lblBienvenue.Location = New System.Drawing.Point(301, 28)
        Me.lblBienvenue.Name = "lblBienvenue"
        Me.lblBienvenue.Size = New System.Drawing.Size(123, 25)
        Me.lblBienvenue.TabIndex = 4
        Me.lblBienvenue.Text = "Bienvenue"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(104, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnConnexion
        '
        Me.btnConnexion.Location = New System.Drawing.Point(427, 217)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(75, 23)
        Me.btnConnexion.TabIndex = 6
        Me.btnConnexion.Text = "Connexion"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'ConnexionSGBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 261)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBienvenue)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.mdpTextBox)
        Me.Controls.Add(Me.LoginTextbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConnexionSGBD"
        Me.Text = "Gestion des Interventions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginTextbox As System.Windows.Forms.TextBox
    Friend WithEvents mdpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblBienvenue As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConnexion As System.Windows.Forms.Button
End Class
