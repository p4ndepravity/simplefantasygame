﻿Module FormControl
    Public currentState As New PlayerState
    Public currentController As DatasetController

    Public Sub OpenMainMenu()
        currentState.mainmenu = New MainMenu
        currentState.mainmenu.Show()
        currentState.combatwindow.Close()
        currentState.innwindow.Close()
        currentState.marketwindow.Close()
        currentState.necrowindow.Close()
        currentState.playerwindow.Close()
        currentState.roadwindow.Close()
        currentState.tavernwindow.Close()
        currentState.townwindow.Close()
        currentState.creaturewindow.Close()
        currentState.deletewindow.Close()
        currentState.blacksmithwindow.Close()
    End Sub
End Module