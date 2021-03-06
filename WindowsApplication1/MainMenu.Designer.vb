﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.titlelbl = New System.Windows.Forms.Label()
        Me.playerSelectionlbl = New System.Windows.Forms.Label()
        Me.playerNewbtn = New System.Windows.Forms.Button()
        Me.playerSelectlstv = New System.Windows.Forms.ListView()
        Me.playerLevel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerDeletebtn = New System.Windows.Forms.Button()
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameDatabaseDataSet = New simplefantasygame.GameDatabaseDataSet()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayerPartiesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerPartiesTableAdapter()
        Me.PlayerStatesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter()
        Me.StaticArmorTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticAugmentsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter()
        Me.StaticCampsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticCampsTableAdapter()
        Me.StaticCampTiersTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticCampTiersTableAdapter()
        Me.StaticConsumablesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter()
        Me.StaticCreaturesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.StaticJewelryTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticJewelryTableAdapter()
        Me.StaticMobsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticMobsTableAdapter()
        Me.StaticQuestsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter()
        Me.StaticSkillsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter()
        Me.StaticWeaponsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.PlayerPartiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticQuestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCampsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCampTiersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticJewelryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticMobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.PlayerSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerSkillsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter()
        Me.PlayerArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerArmorTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter()
        Me.PlayerWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerWeaponsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter()
        Me.PlayerConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerConsumablesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter()
        Me.PlayerJewelryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerJewelryTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerJewelryTableAdapter()
        Me.PlayerAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerAugmentsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerAugmentsTableAdapter()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPartiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCampsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCampTiersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticJewelryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticMobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerSkillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerConsumablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerJewelryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titlelbl
        '
        Me.titlelbl.AutoSize = True
        Me.titlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlelbl.Location = New System.Drawing.Point(24, 18)
        Me.titlelbl.Name = "titlelbl"
        Me.titlelbl.Size = New System.Drawing.Size(186, 24)
        Me.titlelbl.TabIndex = 0
        Me.titlelbl.Text = "fantasy game by trent"
        '
        'playerSelectionlbl
        '
        Me.playerSelectionlbl.AutoSize = True
        Me.playerSelectionlbl.Location = New System.Drawing.Point(69, 53)
        Me.playerSelectionlbl.Name = "playerSelectionlbl"
        Me.playerSelectionlbl.Size = New System.Drawing.Size(96, 13)
        Me.playerSelectionlbl.TabIndex = 2
        Me.playerSelectionlbl.Text = "choose your player"
        '
        'playerNewbtn
        '
        Me.playerNewbtn.Location = New System.Drawing.Point(39, 172)
        Me.playerNewbtn.Name = "playerNewbtn"
        Me.playerNewbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerNewbtn.TabIndex = 3
        Me.playerNewbtn.Text = "new"
        Me.playerNewbtn.UseVisualStyleBackColor = True
        '
        'playerSelectlstv
        '
        Me.playerSelectlstv.AutoArrange = False
        Me.playerSelectlstv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.playerLevel, Me.playerName})
        Me.playerSelectlstv.FullRowSelect = True
        Me.playerSelectlstv.GridLines = True
        Me.playerSelectlstv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.playerSelectlstv.HideSelection = False
        Me.playerSelectlstv.Location = New System.Drawing.Point(56, 69)
        Me.playerSelectlstv.MultiSelect = False
        Me.playerSelectlstv.Name = "playerSelectlstv"
        Me.playerSelectlstv.Size = New System.Drawing.Size(125, 97)
        Me.playerSelectlstv.TabIndex = 4
        Me.playerSelectlstv.UseCompatibleStateImageBehavior = False
        Me.playerSelectlstv.View = System.Windows.Forms.View.Details
        '
        'playerLevel
        '
        Me.playerLevel.Text = "Level"
        Me.playerLevel.Width = 40
        '
        'playerName
        '
        Me.playerName.Text = "Name"
        Me.playerName.Width = 81
        '
        'playerDeletebtn
        '
        Me.playerDeletebtn.Location = New System.Drawing.Point(120, 172)
        Me.playerDeletebtn.Name = "playerDeletebtn"
        Me.playerDeletebtn.Size = New System.Drawing.Size(75, 23)
        Me.playerDeletebtn.TabIndex = 5
        Me.playerDeletebtn.Text = "delete"
        Me.playerDeletebtn.UseVisualStyleBackColor = True
        '
        'PlayerStatesBindingSource
        '
        Me.PlayerStatesBindingSource.DataMember = "PlayerStates"
        Me.PlayerStatesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArmorAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BattlesTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStatesTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStatesTableAdapter = Nothing
        Me.TableAdapterManager.EnemyPartiesTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerArmorTableAdapter = Nothing
        Me.TableAdapterManager.PlayerAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerJewelryTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Me.PlayerPartiesTableAdapter
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.PlayerStatesTableAdapter = Me.PlayerStatesTableAdapter
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.RoadStatesTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Me.StaticArmorTableAdapter
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Me.StaticAugmentsTableAdapter
        Me.TableAdapterManager.StaticCampsTableAdapter = Me.StaticCampsTableAdapter
        Me.TableAdapterManager.StaticCampTiersTableAdapter = Me.StaticCampTiersTableAdapter
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Me.StaticConsumablesTableAdapter
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Me.StaticCreaturesTableAdapter
        Me.TableAdapterManager.StaticJewelryTableAdapter = Me.StaticJewelryTableAdapter
        Me.TableAdapterManager.StaticMobsTableAdapter = Me.StaticMobsTableAdapter
        Me.TableAdapterManager.StaticQuestsTableAdapter = Me.StaticQuestsTableAdapter
        Me.TableAdapterManager.StaticSkillsTableAdapter = Me.StaticSkillsTableAdapter
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Me.StaticWeaponsTableAdapter
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
        '
        'PlayerPartiesTableAdapter
        '
        Me.PlayerPartiesTableAdapter.ClearBeforeFill = True
        '
        'PlayerStatesTableAdapter
        '
        Me.PlayerStatesTableAdapter.ClearBeforeFill = True
        '
        'StaticArmorTableAdapter
        '
        Me.StaticArmorTableAdapter.ClearBeforeFill = True
        '
        'StaticAugmentsTableAdapter
        '
        Me.StaticAugmentsTableAdapter.ClearBeforeFill = True
        '
        'StaticCampsTableAdapter
        '
        Me.StaticCampsTableAdapter.ClearBeforeFill = True
        '
        'StaticCampTiersTableAdapter
        '
        Me.StaticCampTiersTableAdapter.ClearBeforeFill = True
        '
        'StaticConsumablesTableAdapter
        '
        Me.StaticConsumablesTableAdapter.ClearBeforeFill = True
        '
        'StaticCreaturesTableAdapter
        '
        Me.StaticCreaturesTableAdapter.ClearBeforeFill = True
        '
        'StaticJewelryTableAdapter
        '
        Me.StaticJewelryTableAdapter.ClearBeforeFill = True
        '
        'StaticMobsTableAdapter
        '
        Me.StaticMobsTableAdapter.ClearBeforeFill = True
        '
        'StaticQuestsTableAdapter
        '
        Me.StaticQuestsTableAdapter.ClearBeforeFill = True
        '
        'StaticSkillsTableAdapter
        '
        Me.StaticSkillsTableAdapter.ClearBeforeFill = True
        '
        'StaticWeaponsTableAdapter
        '
        Me.StaticWeaponsTableAdapter.ClearBeforeFill = True
        '
        'PlayerPartiesBindingSource
        '
        Me.PlayerPartiesBindingSource.DataMember = "PlayerParties"
        Me.PlayerPartiesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticCreaturesBindingSource
        '
        Me.StaticCreaturesBindingSource.DataMember = "StaticCreatures"
        Me.StaticCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticQuestsBindingSource
        '
        Me.StaticQuestsBindingSource.DataMember = "StaticQuests"
        Me.StaticQuestsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticCampsBindingSource
        '
        Me.StaticCampsBindingSource.DataMember = "StaticCamps"
        Me.StaticCampsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticCampTiersBindingSource
        '
        Me.StaticCampTiersBindingSource.DataMember = "StaticCampTiers"
        Me.StaticCampTiersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticWeaponsBindingSource
        '
        Me.StaticWeaponsBindingSource.DataMember = "StaticWeapons"
        Me.StaticWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticArmorBindingSource
        '
        Me.StaticArmorBindingSource.DataMember = "StaticArmor"
        Me.StaticArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticConsumablesBindingSource
        '
        Me.StaticConsumablesBindingSource.DataMember = "StaticConsumables"
        Me.StaticConsumablesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticJewelryBindingSource
        '
        Me.StaticJewelryBindingSource.DataMember = "StaticJewelry"
        Me.StaticJewelryBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticSkillsBindingSource
        '
        Me.StaticSkillsBindingSource.DataMember = "StaticSkills"
        Me.StaticSkillsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticMobsBindingSource
        '
        Me.StaticMobsBindingSource.DataMember = "StaticMobs"
        Me.StaticMobsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticAugmentsBindingSource
        '
        Me.StaticAugmentsBindingSource.DataMember = "StaticAugments"
        Me.StaticAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerCreaturesBindingSource
        '
        Me.PlayerCreaturesBindingSource.DataMember = "PlayerCreatures"
        Me.PlayerCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerCreaturesTableAdapter
        '
        Me.PlayerCreaturesTableAdapter.ClearBeforeFill = True
        '
        'PlayerSkillsBindingSource
        '
        Me.PlayerSkillsBindingSource.DataMember = "PlayerSkills"
        Me.PlayerSkillsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerSkillsTableAdapter
        '
        Me.PlayerSkillsTableAdapter.ClearBeforeFill = True
        '
        'PlayerArmorBindingSource
        '
        Me.PlayerArmorBindingSource.DataMember = "PlayerArmor"
        Me.PlayerArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerArmorTableAdapter
        '
        Me.PlayerArmorTableAdapter.ClearBeforeFill = True
        '
        'PlayerWeaponsBindingSource
        '
        Me.PlayerWeaponsBindingSource.DataMember = "PlayerWeapons"
        Me.PlayerWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerWeaponsTableAdapter
        '
        Me.PlayerWeaponsTableAdapter.ClearBeforeFill = True
        '
        'PlayerConsumablesBindingSource
        '
        Me.PlayerConsumablesBindingSource.DataMember = "PlayerConsumables"
        Me.PlayerConsumablesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerConsumablesTableAdapter
        '
        Me.PlayerConsumablesTableAdapter.ClearBeforeFill = True
        '
        'PlayerJewelryBindingSource
        '
        Me.PlayerJewelryBindingSource.DataMember = "PlayerJewelry"
        Me.PlayerJewelryBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerJewelryTableAdapter
        '
        Me.PlayerJewelryTableAdapter.ClearBeforeFill = True
        '
        'PlayerAugmentsBindingSource
        '
        Me.PlayerAugmentsBindingSource.DataMember = "PlayerAugments"
        Me.PlayerAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerAugmentsTableAdapter
        '
        Me.PlayerAugmentsTableAdapter.ClearBeforeFill = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(231, 212)
        Me.Controls.Add(Me.playerDeletebtn)
        Me.Controls.Add(Me.playerSelectlstv)
        Me.Controls.Add(Me.playerNewbtn)
        Me.Controls.Add(Me.playerSelectionlbl)
        Me.Controls.Add(Me.titlelbl)
        Me.MinimumSize = New System.Drawing.Size(247, 251)
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.Text = "main menu"
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPartiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCampsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCampTiersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticJewelryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticMobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerSkillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerConsumablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerJewelryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents playerSelectionlbl As Label
    Friend WithEvents playerNewbtn As Button
    Friend WithEvents playerSelectlstv As ListView
    Friend WithEvents playerLevel As ColumnHeader
    Friend WithEvents playerName As ColumnHeader
    Friend WithEvents playerDeletebtn As Button
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayerStatesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayerPartiesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerPartiesTableAdapter
    Friend WithEvents PlayerPartiesBindingSource As BindingSource
    Friend WithEvents StaticCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter
    Friend WithEvents StaticCreaturesBindingSource As BindingSource
    Friend WithEvents StaticQuestsTableAdapter As GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter
    Friend WithEvents StaticQuestsBindingSource As BindingSource
    Friend WithEvents StaticCampsTableAdapter As GameDatabaseDataSetTableAdapters.StaticCampsTableAdapter
    Friend WithEvents StaticCampsBindingSource As BindingSource
    Friend WithEvents StaticCampTiersTableAdapter As GameDatabaseDataSetTableAdapters.StaticCampTiersTableAdapter
    Friend WithEvents StaticCampTiersBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticConsumablesTableAdapter As GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter
    Friend WithEvents StaticConsumablesBindingSource As BindingSource
    Friend WithEvents StaticJewelryTableAdapter As GameDatabaseDataSetTableAdapters.StaticJewelryTableAdapter
    Friend WithEvents StaticJewelryBindingSource As BindingSource
    Friend WithEvents StaticSkillsTableAdapter As GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter
    Friend WithEvents StaticSkillsBindingSource As BindingSource
    Friend WithEvents StaticMobsTableAdapter As GameDatabaseDataSetTableAdapters.StaticMobsTableAdapter
    Friend WithEvents StaticMobsBindingSource As BindingSource
    Friend WithEvents StaticAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter
    Friend WithEvents StaticAugmentsBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Friend WithEvents PlayerSkillsBindingSource As BindingSource
    Friend WithEvents PlayerSkillsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter
    Friend WithEvents PlayerArmorBindingSource As BindingSource
    Friend WithEvents PlayerArmorTableAdapter As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter
    Friend WithEvents PlayerWeaponsBindingSource As BindingSource
    Friend WithEvents PlayerWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter
    Friend WithEvents PlayerConsumablesBindingSource As BindingSource
    Friend WithEvents PlayerConsumablesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter
    Friend WithEvents PlayerJewelryBindingSource As BindingSource
    Friend WithEvents PlayerJewelryTableAdapter As GameDatabaseDataSetTableAdapters.PlayerJewelryTableAdapter
    Friend WithEvents PlayerAugmentsBindingSource As BindingSource
    Friend WithEvents PlayerAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerAugmentsTableAdapter
End Class
