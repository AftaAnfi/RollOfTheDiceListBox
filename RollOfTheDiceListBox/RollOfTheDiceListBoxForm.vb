Option Strict On
Option Explicit On
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Roll Of The Dice - List Box
'https://github.com/AftaAnfi/RollOfTheDiceListBox.git
Public Class RollOfTheDiceListBoxForm
    Dim randomNumberCounterArray(10) As Integer

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        'close the form
        Me.Close()
    End Sub

    Sub RollRandomDice()
        'initialize randomizer
        Randomize(DateTime.Now.Millisecond)

        'roll 1000 times
        For j = 1 To 1000
            randomNumberCounterArray(CInt(Math.Floor(Rnd() * 6)) + CInt(Math.Floor(Rnd() * 6))) += 1
        Next

    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click, RollToolStripMenuItem.Click
        Dim rollRow As String = ""
        Dim rolledRow As String = ""

        'clear and roll the dice
        RollRandomDice()
        RolledDiceListBox.Items.Clear()

        'format rows to be added to list
        For l = 0 To randomNumberCounterArray.GetUpperBound(0)
            rollRow &= (l + 2).ToString.PadLeft(3) & "|"
            rolledRow &= randomNumberCounterArray(l).ToString.PadLeft(3) & "|"

        Next


        'add the title
        RolledDiceListBox.Items.Add(("Roll of the Dice").PadLeft(30))

        'add some spacers
        RolledDiceListBox.Items.Add("--------------------------------------------")

        'add the dice roll row
        RolledDiceListBox.Items.Add(rollRow)

        'add some spacers
        RolledDiceListBox.Items.Add("--------------------------------------------")

        'add the rolled row
        RolledDiceListBox.Items.Add(rolledRow)

        'add some spacers
        RolledDiceListBox.Items.Add("--------------------------------------------")

        'reset roll count in array
        For l = 0 To randomNumberCounterArray.GetUpperBound(0)
            randomNumberCounterArray(l) = 0
        Next

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click

        'reset rolls of array
        For l = 0 To randomNumberCounterArray.GetUpperBound(0)
            randomNumberCounterArray(l) = 0
        Next

        'clear the list box 
        RolledDiceListBox.Items.Clear()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'show about form and hide this form
        AboutForm.Show()
        Me.Hide()
    End Sub

End Class
