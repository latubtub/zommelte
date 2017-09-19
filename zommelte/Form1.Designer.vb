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
        CType(Me.BoxPhotoID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BValider
        '
        Me.BValider.BackColor = System.Drawing.Color.Blue
        Me.BValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BValider.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BValider.Location = New System.Drawing.Point(374, 266)
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
        Me.Tnom.Location = New System.Drawing.Point(235, 67)
        Me.Tnom.Name = "Tnom"
        Me.Tnom.Size = New System.Drawing.Size(100, 20)
        Me.Tnom.TabIndex = 3
        Me.Tnom.Text = "Nom"
        '
        'TPrenom
        '
        Me.TPrenom.Location = New System.Drawing.Point(235, 93)
        Me.TPrenom.Name = "TPrenom"
        Me.TPrenom.Size = New System.Drawing.Size(100, 20)
        Me.TPrenom.TabIndex = 4
        Me.TPrenom.Text = "Prenom"
        '
        'TadressePostale
        '
        Me.TadressePostale.Location = New System.Drawing.Point(235, 119)
        Me.TadressePostale.Name = "TadressePostale"
        Me.TadressePostale.Size = New System.Drawing.Size(240, 20)
        Me.TadressePostale.TabIndex = 5
        Me.TadressePostale.Text = "Adresse postale"
        '
        'Tville
        '
        Me.Tville.Location = New System.Drawing.Point(235, 145)
        Me.Tville.Name = "Tville"
        Me.Tville.Size = New System.Drawing.Size(240, 20)
        Me.Tville.TabIndex = 6
        Me.Tville.Text = "Ville"
        '
        'Icodepostal
        '
        Me.Icodepostal.Location = New System.Drawing.Point(235, 171)
        Me.Icodepostal.Name = "Icodepostal"
        Me.Icodepostal.Size = New System.Drawing.Size(240, 20)
        Me.Icodepostal.TabIndex = 7
        Me.Icodepostal.Text = "Code Postal"
        '
        'Temail
        '
        Me.Temail.Location = New System.Drawing.Point(235, 197)
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(240, 20)
        Me.Temail.TabIndex = 8
        Me.Temail.Text = "email"
        '
        'BtAjouterPhoto
        '
        Me.BtAjouterPhoto.Location = New System.Drawing.Point(54, 197)
        Me.BtAjouterPhoto.Name = "BtAjouterPhoto"
        Me.BtAjouterPhoto.Size = New System.Drawing.Size(127, 23)
        Me.BtAjouterPhoto.TabIndex = 9
        Me.BtAjouterPhoto.Text = "Ajouter une photo"
        Me.BtAjouterPhoto.UseVisualStyleBackColor = True
        '
        'BoxPhotoID
        '
        Me.BoxPhotoID.Location = New System.Drawing.Point(54, 63)
        Me.BoxPhotoID.Name = "BoxPhotoID"
        Me.BoxPhotoID.Size = New System.Drawing.Size(127, 102)
        Me.BoxPhotoID.TabIndex = 10
        Me.BoxPhotoID.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.ClientSize = New System.Drawing.Size(514, 323)
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
End Class
