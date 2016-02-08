﻿Public Class PlayerWindow
    Private Sub PlayerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerInfoPanellbl.Text = currentPlayer.ToString
        playerLeveltxt.Text = currentPlayer.level
        playerGoldtxt.Text = currentPlayer.gold
        playerExperiencebar.Minimum = currentPlayer.level ^ 5
        playerExperiencebar.Maximum = (currentPlayer.level + 1) ^ 5
        playerExperiencebar.Value = currentPlayer.exp

        PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        PlayerCreaturesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerCreatures, currentPlayer.id)

        For Each row As DataRow In PlayerCreaturesTableAdapter.GetDataByPlayerid(currentPlayer.id)
            creaturelst.Items.Add(New creature(StaticCreaturesTableAdapter.GetCreatureByid(row("id"))(0)).ToString)
        Next
    End Sub

    Private Sub creaturelst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles creaturelst.SelectedIndexChanged
        If Not creaturelst.SelectedIndices(0) = -1 Then
            currentCreatureWindow = New CreatureWindow
            currentCreatureWindow.Show()
        End If
    End Sub

    Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameToolStripMenuItem.Click
        Dim nameString As String = InputBox("enter a name.",, currentPlayer.name)
        If String.IsNullOrWhiteSpace(nameString) Then
            MsgBox("Name cannot be blank.")
            Exit Sub
        End If

        'Called from Names.vb
        'Converts any string into a proper-cased trimmed string
        nameString = ProperCase(nameString)
        currentPlayer.ReName(nameString)

        GameDatabaseDataSet.Players(currentPlayer.id - 1).name = currentPlayer.name

        Try
            Validate()
            GameDatabaseDataSet.Players(currentPlayer.id - 1).gold = currentPlayer.gold
            PlayersBindingSource.EndEdit()
            PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
            playerInfoPanellbl.Text = currentPlayer.ToString
        Catch ex As Exception
            MsgBox("Failed to add creature to database.")
        End Try
    End Sub
End Class