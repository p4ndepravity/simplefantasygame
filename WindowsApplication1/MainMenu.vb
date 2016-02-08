﻿Imports System
Imports System.IO
Imports System.Text

Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)
        Me.PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)

        StartLog()  'From log.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            playerSelectlstv.Items.Add(New player(row("id"), row("name"), row("level"), row("experience"), row("gold")).level)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(row("name").ToString)
        Next
    End Sub

    Private Sub playerNewbtn_Click(sender As Object, e As EventArgs) Handles playerNewbtn.Click
        Dim nameString As String = InputBox("Enter a name.",, "name")
        If String.IsNullOrWhiteSpace(nameString) Then
            MsgBox("Name cannot be blank.")
            Exit Sub
        End If

        'Called from Names.vb
        'Converts any string into a proper-cased trimmed string
        nameString = ProperCase(nameString)

        Dim player As player = NewPlayer(nameString, 1, 1, 0)
        Try
            playerSelectlstv.Items.Add(player.level)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(player.name)
        Catch ex As Exception
            MsgBox("Unable to create new player.")
        End Try
    End Sub

    Private Sub playerSelectlstv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerSelectlstv.SelectedIndexChanged
        Dim row As DataRow = GameDatabaseDataSet.Players(playerSelectlstv.SelectedIndices(0))
        If Not playerSelectlstv.SelectedIndices(0) = -1 Then
            currentPlayer = New player(row("id"), row("name"), row("level"), row("experience"), row("gold"))
            currentTownWindow = New TownWindow
            currentTownWindow.Show()
            Me.Close()
        End If
    End Sub

    Private Function NewPlayer(name, level, experience, gold)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Players").NewRow()

        newRow("name") = name
        newRow("level") = level
        newRow("experience") = experience
        newRow("gold") = gold

        GameDatabaseDataSet.Tables("Players").Rows.Add(newRow)

        'Attempts to update the database with the new row from the dataset.
        'If successful, a new Player instance is created with the attributes
        'from the new database record.
        Try
            Validate()
            PlayersBindingSource.EndEdit()
            PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
            newRow = PlayersTableAdapter.GetLastRow().Select().First
            LogNewPlayer(newRow, True)  'from log.vb
            Return New player(newRow("id"), name, level, experience, gold)
        Catch ex As Exception
            LogNewPlayer(newRow, False)  'from log.vb
            MsgBox("Failed to add player to database.")
            Exit Function
        End Try
    End Function

    Private Sub playerDeletebtn_Click(sender As Object, e As EventArgs) Handles playerDeletebtn.Click
        currentDeletePlayersWindow = New DeletePlayersWindow
        currentDeletePlayersWindow.Show()
        Me.Close()
    End Sub

    Private Sub PlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub

    Private Sub PlayersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub

    Private Sub PlayersBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub
End Class