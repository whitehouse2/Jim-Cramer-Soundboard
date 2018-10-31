Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        My.Computer.Audio.Play(My.Resources.Bull_button, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Computer.Audio.Play(My.Resources.Bear_button, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Play(My.Resources.KaChing_button, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        My.Computer.Audio.Play(My.Resources.Bowling, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        My.Computer.Audio.Play(My.Resources.MachineGun, AudioPlayMode.Background)
    End Sub
End Class
