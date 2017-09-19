<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BValider = New System.Windows.Forms.Button()
        Me.LabelInscription = New System.Windows.Forms.Label()
        Me.Tnom = New System.Windows.Forms.TextBox()
        Me.TPrenom = New System.Windows.Forms.TextBox()
        Me.TadressePostale = New System.Windows.Forms.TextBox()
        Me.Tville = New System.Windows.Forms.TextBox()
        Me.Icodepostal = New System.Windows.Forms.TextBox()
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.BtAjouterPhoto = New System.Windows.Forms.Button()
        Me.BoxPhotoID = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TPseudo = New System.Windows.Forms.TextBox()
        Me.SMdP = New System.Windows.Forms.TextBox()
        Me.TMdPConfirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.BoxPhotoID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BValider
        '
        Me.BValider.BackColor = System.Drawing.Color.Blue
        Me.BValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BValider.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BValider.Location = New System.Drawing.Point(374, 298)
        Me.BValider.Name = "BValider"
        Me.BValider.Size = New System.Drawing.Size(101, 34)
        Me.BValider.TabIndex = 1
        Me.BValider.Text = "Valider"
        Me.BValider.UseVisualStyleBackColor = False
        '
        'LabelInscription
        '
        Me.LabelInscription.AutoSize = True
        Me.LabelInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInscription.Location = New System.Drawing.Point(230, 9)
        Me.LabelInscription.Name = "LabelInscription"
        Me.LabelInscription.Size = New System.Drawing.Size(121, 25)
        Me.LabelInscription.TabIndex = 2
        Me.LabelInscription.Text = "Inscription"
        '
        'Tnom
        '
        Me.Tnom.Location = New System.Drawing.Point(235, 37)
        Me.Tnom.Name = "Tnom"
        Me.Tnom.Size = New System.Drawing.Size(100, 20)
        Me.Tnom.TabIndex = 3
        Me.Tnom.Text = "Nom"
        '
        'TPrenom
        '
        Me.TPrenom.Location = New System.Drawing.Point(235, 63)
        Me.TPrenom.Name = "TPrenom"
        Me.TPrenom.Size = New System.Drawing.Size(100, 20)
        Me.TPrenom.TabIndex = 4
        Me.TPrenom.Text = "Prenom"
        '
        'TadressePostale
        '
        Me.TadressePostale.Location = New System.Drawing.Point(235, 180)
        Me.TadressePostale.Name = "TadressePostale"
        Me.TadressePostale.Size = New System.Drawing.Size(240, 20)
        Me.TadressePostale.TabIndex = 5
        Me.TadressePostale.Text = "Adresse postale"
        '
        'Tville
        '
        Me.Tville.Location = New System.Drawing.Point(235, 206)
        Me.Tville.Name = "Tville"
        Me.Tville.Size = New System.Drawing.Size(240, 20)
        Me.Tville.TabIndex = 6
        Me.Tville.Text = "Ville"
        '
        'Icodepostal
        '
        Me.Icodepostal.Location = New System.Drawing.Point(235, 232)
        Me.Icodepostal.Name = "Icodepostal"
        Me.Icodepostal.Size = New System.Drawing.Size(240, 20)
        Me.Icodepostal.TabIndex = 7
        Me.Icodepostal.Text = "Code Postal"
        '
        'Temail
        '
        Me.Temail.Location = New System.Drawing.Point(235, 258)
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(240, 20)
        Me.Temail.TabIndex = 8
        Me.Temail.Text = "email"
        '
        'BtAjouterPhoto
        '
        Me.BtAjouterPhoto.Location = New System.Drawing.Point(54, 236)
        Me.BtAjouterPhoto.Name = "BtAjouterPhoto"
        Me.BtAjouterPhoto.Size = New System.Drawing.Size(127, 23)
        Me.BtAjouterPhoto.TabIndex = 9
        Me.BtAjouterPhoto.Text = "Ajouter une photo"
        Me.BtAjouterPhoto.UseVisualStyleBackColor = True
        '
        'BoxPhotoID
        '
        Me.BoxPhotoID.Location = New System.Drawing.Point(54, 37)
        Me.BoxPhotoID.Name = "BoxPhotoID"
        Me.BoxPhotoID.Size = New System.Drawing.Size(127, 144)
        Me.BoxPhotoID.TabIndex = 10
        Me.BoxPhotoID.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TPseudo
        '
        Me.TPseudo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPseudo.Location = New System.Drawing.Point(235, 89)
        Me.TPseudo.Name = "TPseudo"
        Me.TPseudo.Size = New System.Drawing.Size(100, 20)
        Me.TPseudo.TabIndex = 11
        Me.TPseudo.Text = "Pseudo"
        '
        'SMdP
        '
        Me.SMdP.Location = New System.Drawing.Point(235, 115)
        Me.SMdP.Name = "SMdP"
        Me.SMdP.Size = New System.Drawing.Size(127, 20)
        Me.SMdP.TabIndex = 12
        Me.SMdP.Text = "Mot de Passe"
        '
        'TMdPConfirm
        '
        Me.TMdPConfirm.Location = New System.Drawing.Point(235, 141)
        Me.TMdPConfirm.Name = "TMdPConfirm"
        Me.TMdPConfirm.Size = New System.Drawing.Size(127, 20)
        Me.TMdPConfirm.TabIndex = 13
        Me.TMdPConfirm.Text = "Confirmer Mot de Passe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(235, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "mention obligatoire"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(205, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 31)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(205, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 31)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(205, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 31)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(205, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 31)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(205, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 31)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.ClientSize = New System.Drawing.Size(512, 344)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TMdPConfirm)
        Me.Controls.Add(Me.SMdP)
        Me.Controls.Add(Me.TPseudo)
        Me.Controls.Add(Me.BoxPhotoID)
        Me.Controls.Add(Me.BtAjouterPhoto)
        Me.Controls.Add(Me.Temail)
        Me.Controls.Add(Me.Icodepostal)
        Me.Controls.Add(Me.Tville)
        Me.Controls.Add(Me.TadressePostale)
        Me.Controls.Add(Me.TPrenom)
        Me.Controls.Add(Me.Tnom)
        Me.Controls.Add(Me.LabelInscription)
        Me.Controls.Add(Me.BValider)
        Me.Name = "Form1"
        Me.Text = "Inscription"
        CType(Me.BoxPhotoID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BValider As Button
    Friend WithEvents LabelInscription As Label
    Friend WithEvents Tnom As TextBox
    Friend WithEvents TPrenom As TextBox
    Friend WithEvents TadressePostale As TextBox
    Friend WithEvents Tville As TextBox
    Friend WithEvents Icodepostal As TextBox
    Friend WithEvents Temail As TextBox
    Friend WithEvents BtAjouterPhoto As Button
    Friend WithEvents BoxPhotoID As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TPseudo As TextBox
    Friend WithEvents SMdP As TextBox
    Friend WithEvents TMdPConfirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
