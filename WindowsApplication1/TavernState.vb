﻿Public Class TavernState
    Private tavernStateid As Integer
    Private tavernStatePlayerState As PlayerState
    Private tavernStateHires(4) As Creature
    Private tavernStateQuests(3) As Quest
    Private tavernStateDateVisited As Date

    Public Sub New()
        tavernStateid = -1
        tavernStatePlayerState = New PlayerState
        For ctr = 0 To 3
            Select Case ctr
                Case 0
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 1
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 2
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 3
                    tavernStateHires(ctr) = New Creature
            End Select
        Next
        tavernStateDateVisited = currentState.dateInGame
    End Sub

    Public Sub New(id As Integer)
        tavernStateid = id
        tavernStatePlayerState = New PlayerState
        For ctr = 0 To 3
            Select Case ctr
                Case 0
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 1
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 2
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 3
                    tavernStateHires(ctr) = New Creature
            End Select
        Next
        tavernStateDateVisited = currentState.dateInGame
    End Sub

    Public Sub New(state As PlayerState)
        tavernStateid = -1
        tavernStatePlayerState = state
        For ctr = 0 To 3
            Select Case ctr
                Case 0
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 1
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 2
                    tavernStateHires(ctr) = New Creature
                    tavernStateQuests(ctr) = New Quest
                Case 3
                    tavernStateHires(ctr) = New Creature
            End Select
        Next
        tavernStateDateVisited = state.dateInGame
    End Sub

    Public Sub New(row As GameDatabaseDataSet.TavernStatesRow)
        tavernStateid = row("id")
        tavernStatePlayerState = currentState
        For ctr = 0 To 3
            Select Case ctr
                Case 0
                    tavernStateHires(ctr) = New Creature(CInt(row("hireSlot1id")))
                    tavernStateQuests(ctr) = New Quest(CInt(row("questSlot1id")))
                Case 1
                    tavernStateHires(ctr) = New Creature(CInt(row("hireSlot2id")))
                    tavernStateQuests(ctr) = New Quest(CInt(row("questSlot2id")))
                Case 2
                    tavernStateHires(ctr) = New Creature(CInt(row("hireSlot3id")))
                    tavernStateQuests(ctr) = New Quest(CInt(row("questSlot3id")))
                Case 3
                    tavernStateHires(ctr) = New Creature(CInt(row("hireSlot4id")))
            End Select
        Next
        tavernStateDateVisited = row("dateVisited")
    End Sub

    Public ReadOnly Property id As Integer
        Get
            Return tavernStateid
        End Get
    End Property

    Public Property playerState As PlayerState
        Get
            Return tavernStatePlayerState
        End Get
        Set(value As PlayerState)
            tavernStatePlayerState = value
        End Set
    End Property

    Public Property hires As Creature()
        Get
            Return tavernStateHires
        End Get
        Set(value As Creature())
            tavernStateHires = value
        End Set
    End Property

    Public Property quests As Quest()
        Get
            Return tavernStateQuests
        End Get
        Set(value As Quest())
            tavernStateQuests = value
        End Set
    End Property

    Public ReadOnly Property dateVisited() As DateTime
        Get
            Return tavernStateDateVisited
        End Get
    End Property

    Public Sub FillHires(creaturesTable As GameDatabaseDataSet.StaticCreaturesDataTable)
        Dim row As DataRow
        For ctr = 0 To 3
            row = creaturesTable(ctr)
            tavernStateHires(ctr) = New Creature(row)
        Next
    End Sub

    Public Sub FillQuests(questsTable As GameDatabaseDataSet.StaticQuestsDataTable)
        Dim row As DataRow
        For ctr = 0 To 2
            row = questsTable(ctr)
            tavernStateQuests(ctr) = New Quest(row)
        Next
    End Sub

    Public Sub changeDate(amount As TimeSpan)
        If amount < TimeSpan.Zero Then
            tavernStateDateVisited = tavernStateDateVisited.Subtract(amount)
        Else
            tavernStateDateVisited = tavernStateDateVisited.Add(amount)
        End If
    End Sub
End Class
