Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BValider.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelInscription.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Tnom.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TPrenom.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles TadressePostale.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_3(sender As Object, e As EventArgs) Handles Tville.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_4(sender As Object, e As EventArgs) Handles Temail.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtAjouterPhoto_Click(sender As Object, e As EventArgs) Handles BtAjouterPhoto.Click

        Dim IDphoto As String
        OpenFileDialog1.Filter = "fichier image|*.jpg"
        OpenFileDialog1.InitialDirectory = "C:\Users\AIFOR\Desktop\photosID"
        OpenFileDialog1.ShowDialog()
        IDphoto = OpenFileDialog1.FileName
        BoxPhotoID.ImageLocation = IDphoto

    End Sub
End Class
