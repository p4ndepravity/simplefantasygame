﻿Public Class Creature
    Private creatureid As Integer
    Private creatureName As String
    Private creatureSpecies As String
    Private creatureClass As String
    Private creatureLevel As Integer
    Private creatureExperience As Integer
    Private creatureMaxHealth As Integer
    Private creatureHealth As Integer
    Private creatureStrength As Integer
    Private creatureArmor As Integer
    Private creatureInitiative As Integer
    Private creatureIntelligence As Integer
    Private creatureWisdom As Integer
    Private creatureDexterity As Integer
    Private creatureOwner As Player

    Public Sub New()
        creatureid = -1
        creatureName = getCreatureName()
        creatureSpecies = getSpecies()
        creatureClass = "class"
        creatureLevel = 1
        creatureExperience = 1
        creatureArmor = 0
        creatureMaxHealth = 70 + Roll(50)
        creatureHealth = creatureMaxHealth
        creatureStrength = 70 + Roll(50)
        creatureInitiative = 70 + Roll(50)
        creatureIntelligence = 70 + Roll(50)
        creatureWisdom = 70 + Roll(50)
        creatureDexterity = 70 + Roll(50)
        creatureOwner = currentPlayer
    End Sub

    Public Sub New(name As String)
        creatureid = -1
        creatureName = name
        creatureSpecies = "species"
        creatureHealth = 1
        creatureStrength = 1
        creatureArmor = 1
        creatureLevel = 1
        creatureExperience = 1
        creatureInitiative = 1
        creatureIntelligence = 1
        creatureWisdom = 1
        creatureDexterity = 1
        creatureOwner = currentPlayer
    End Sub

    Public Sub New(id As Integer,
                   name As String,
                   species As String,
                   health As Integer,
                   strength As Integer,
                   armor As Integer,
                   level As Integer,
                   exp As Integer,
                   ini As Integer,
                   int As Integer,
                   wis As Integer,
                   dex As Integer,
                   owner As Player)
        creatureid = id
        creatureName = name
        creatureSpecies = species
        creatureHealth = health
        creatureStrength = strength
        creatureArmor = armor
        creatureLevel = level
        creatureExperience = exp
        creatureInitiative = ini
        creatureIntelligence = int
        creatureWisdom = wis
        creatureDexterity = dex
        creatureOwner = owner
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticCreaturesRow)
        creatureid = row("id")
        creatureSpecies = row("species")
        creatureHealth = row("health")
        creatureStrength = row("strength")
        creatureArmor = row("armor")
        creatureLevel = row("level")
        creatureExperience = row("experience")
        creatureInitiative = row("initiative")
        creatureIntelligence = row("intelligence")
        creatureWisdom = row("wisdom")
        creatureDexterity = row("dexterity")
        creatureName = row("name")
        creatureOwner = currentPlayer
    End Sub

    Public ReadOnly Property id() As Integer
        Get
            Return creatureid
        End Get
    End Property

    Public Property name() As String
        Get
            Return creatureName
        End Get
        Set(value As String)
            creatureName = value
        End Set
    End Property

    Public ReadOnly Property species() As String
        Get
            Return creatureSpecies
        End Get
    End Property

    Public Property job As String
        Get
            Return creatureClass
        End Get
        Set(value As String)
            creatureClass = value
        End Set
    End Property

    Public ReadOnly Property maxHP As Integer
        Get
            Return creatureMaxHealth
        End Get
    End Property

    Public ReadOnly Property health() As Integer
        Get
            Return creatureHealth
        End Get
    End Property

    Public ReadOnly Property str() As Integer
        Get
            Return creatureStrength
        End Get
    End Property

    Public ReadOnly Property armor() As Integer
        Get
            Return creatureArmor
        End Get
    End Property

    Public ReadOnly Property level() As Integer
        Get
            Return creatureLevel
        End Get
    End Property

    Public ReadOnly Property exp() As Integer
        Get
            Return creatureExperience
        End Get
    End Property

    Public ReadOnly Property ini() As Integer
        Get
            Return creatureInitiative
        End Get
    End Property

    Public ReadOnly Property int() As Integer
        Get
            Return creatureIntelligence
        End Get
    End Property

    Public ReadOnly Property wis() As Integer
        Get
            Return creatureWisdom
        End Get
    End Property

    Public ReadOnly Property dex() As Integer
        Get
            Return creatureDexterity
        End Get
    End Property

    Public ReadOnly Property owner() As Player
        Get
            Return creatureOwner
        End Get
    End Property

    Public Overloads Overrides Function Equals(creature) As Boolean
        If creatureid = creature.id Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub TakeDamage(damage)
        LogCreatureDamageTaken(Me, damage)
        If damage < creatureHealth Then
            creatureHealth = creatureHealth - damage
        Else
            creatureHealth = 0
            MsgBox(Me.ToString & " has died.")
            LogCreatureDeath(Me)
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return Me.name & " the level " & Me.creatureLevel & Space(1) & Me.species
    End Function

    Public Sub GainExp(amount)
        creatureExperience += amount
        If creatureExperience >= (creatureLevel + 1) ^ 5 Then
            creatureLevel += 1
        End If
    End Sub

    Public Sub Equip(equipment)
        'add code that reflects this simplification:
        'creatureAttribute += equipment.attribute
    End Sub

    Public Sub Buff(skill)
        'add code that applies positive spell effects to creature
    End Sub

    Public Sub Save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter)
        Dim newRow As DataRow = ds.Tables("StaticCreatures").NewRow()
        newRow("species") = creatureSpecies
        newRow("class") = creatureClass
        newRow("level") = creatureLevel
        newRow("experience") = creatureExperience
        newRow("maxHealth") = creatureMaxHealth
        newRow("health") = creatureHealth
        newRow("strength") = creatureStrength
        newRow("armor") = creatureArmor
        newRow("initiative") = creatureInitiative
        newRow("intelligence") = creatureIntelligence
        newRow("wisdom") = creatureWisdom
        newRow("dexterity") = creatureDexterity
        newRow("name") = creatureName
        ds.Tables("StaticCreatures").Rows.Add(newRow)
        Try
            bs.EndEdit()
            ta.Update(ds.StaticCreatures)
        Catch ex As Exception
            MsgBox("failed to add static creature to database.")
        End Try
    End Sub
End Class
