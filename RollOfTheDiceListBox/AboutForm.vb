Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set label about the program
        AboutLabel.Text = "Roll Of The Dice - List Box" & vbNewLine _
                    & "Acme Computer Products LLC." & vbNewLine _
                    & "Aftanom Anfilofieff" & vbNewLine _
                    & "Copyright 2021" & vbNewLine

    End Sub

    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'show main form
        RollOfTheDiceListBoxForm.Show()

    End Sub
End Class