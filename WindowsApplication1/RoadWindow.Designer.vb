﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoadWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoadWindow))
        Me.camp1lbl = New System.Windows.Forms.Label()
        Me.camp1btn = New System.Windows.Forms.Button()
        Me.camp2btn = New System.Windows.Forms.Button()
        Me.camp2lbl = New System.Windows.Forms.Label()
        Me.camp3btn = New System.Windows.Forms.Button()
        Me.camp3lbl = New System.Windows.Forms.Label()
        Me.camp4btn = New System.Windows.Forms.Button()
        Me.camp4lbl = New System.Windows.Forms.Label()
        Me.camp5btn = New System.Windows.Forms.Button()
        Me.camp5lbl = New System.Windows.Forms.Label()
        Me.campSelectionlbl = New System.Windows.Forms.Label()
        Me.campSelectionpnl = New System.Windows.Forms.Panel()
        Me.roadpnl = New System.Windows.Forms.Panel()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayerStatesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PlayerStatesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.campSelectionpnl.SuspendLayout()
        Me.roadpnl.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerStatesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'camp1lbl
        '
        Me.camp1lbl.AutoSize = True
        Me.camp1lbl.Location = New System.Drawing.Point(3, 23)
        Me.camp1lbl.Name = "camp1lbl"
        Me.camp1lbl.Size = New System.Drawing.Size(42, 13)
        Me.camp1lbl.TabIndex = 0
        Me.camp1lbl.Text = "camp 1"
        '
        'camp1btn
        '
        Me.camp1btn.Location = New System.Drawing.Point(51, 18)
        Me.camp1btn.Name = "camp1btn"
        Me.camp1btn.Size = New System.Drawing.Size(75, 23)
        Me.camp1btn.TabIndex = 1
        Me.camp1btn.Text = "travel"
        Me.camp1btn.UseVisualStyleBackColor = True
        '
        'camp2btn
        '
        Me.camp2btn.Location = New System.Drawing.Point(51, 47)
        Me.camp2btn.Name = "camp2btn"
        Me.camp2btn.Size = New System.Drawing.Size(75, 23)
        Me.camp2btn.TabIndex = 3
        Me.camp2btn.Text = "travel"
        Me.camp2btn.UseVisualStyleBackColor = True
        '
        'camp2lbl
        '
        Me.camp2lbl.AutoSize = True
        Me.camp2lbl.Location = New System.Drawing.Point(3, 52)
        Me.camp2lbl.Name = "camp2lbl"
        Me.camp2lbl.Size = New System.Drawing.Size(42, 13)
        Me.camp2lbl.TabIndex = 2
        Me.camp2lbl.Text = "camp 2"
        '
        'camp3btn
        '
        Me.camp3btn.Location = New System.Drawing.Point(51, 76)
        Me.camp3btn.Name = "camp3btn"
        Me.camp3btn.Size = New System.Drawing.Size(75, 23)
        Me.camp3btn.TabIndex = 5
        Me.camp3btn.Text = "travel"
        Me.camp3btn.UseVisualStyleBackColor = True
        '
        'camp3lbl
        '
        Me.camp3lbl.AutoSize = True
        Me.camp3lbl.Location = New System.Drawing.Point(3, 81)
        Me.camp3lbl.Name = "camp3lbl"
        Me.camp3lbl.Size = New System.Drawing.Size(42, 13)
        Me.camp3lbl.TabIndex = 4
        Me.camp3lbl.Text = "camp 3"
        '
        'camp4btn
        '
        Me.camp4btn.Location = New System.Drawing.Point(51, 105)
        Me.camp4btn.Name = "camp4btn"
        Me.camp4btn.Size = New System.Drawing.Size(75, 23)
        Me.camp4btn.TabIndex = 7
        Me.camp4btn.Text = "travel"
        Me.camp4btn.UseVisualStyleBackColor = True
        '
        'camp4lbl
        '
        Me.camp4lbl.AutoSize = True
        Me.camp4lbl.Location = New System.Drawing.Point(3, 110)
        Me.camp4lbl.Name = "camp4lbl"
        Me.camp4lbl.Size = New System.Drawing.Size(42, 13)
        Me.camp4lbl.TabIndex = 6
        Me.camp4lbl.Text = "camp 4"
        '
        'camp5btn
        '
        Me.camp5btn.Location = New System.Drawing.Point(51, 134)
        Me.camp5btn.Name = "camp5btn"
        Me.camp5btn.Size = New System.Drawing.Size(75, 23)
        Me.camp5btn.TabIndex = 9
        Me.camp5btn.Text = "travel"
        Me.camp5btn.UseVisualStyleBackColor = True
        '
        'camp5lbl
        '
        Me.camp5lbl.AutoSize = True
        Me.camp5lbl.Location = New System.Drawing.Point(3, 139)
        Me.camp5lbl.Name = "camp5lbl"
        Me.camp5lbl.Size = New System.Drawing.Size(42, 13)
        Me.camp5lbl.TabIndex = 8
        Me.camp5lbl.Text = "camp 5"
        '
        'campSelectionlbl
        '
        Me.campSelectionlbl.AutoSize = True
        Me.campSelectionlbl.Location = New System.Drawing.Point(24, 2)
        Me.campSelectionlbl.Name = "campSelectionlbl"
        Me.campSelectionlbl.Size = New System.Drawing.Size(83, 13)
        Me.campSelectionlbl.TabIndex = 10
        Me.campSelectionlbl.Text = "travel to a camp"
        '
        'campSelectionpnl
        '
        Me.campSelectionpnl.Controls.Add(Me.campSelectionlbl)
        Me.campSelectionpnl.Controls.Add(Me.camp1lbl)
        Me.campSelectionpnl.Controls.Add(Me.camp5btn)
        Me.campSelectionpnl.Controls.Add(Me.camp1btn)
        Me.campSelectionpnl.Controls.Add(Me.camp5lbl)
        Me.campSelectionpnl.Controls.Add(Me.camp2lbl)
        Me.campSelectionpnl.Controls.Add(Me.camp4btn)
        Me.campSelectionpnl.Controls.Add(Me.camp2btn)
        Me.campSelectionpnl.Controls.Add(Me.camp4lbl)
        Me.campSelectionpnl.Controls.Add(Me.camp3lbl)
        Me.campSelectionpnl.Controls.Add(Me.camp3btn)
        Me.campSelectionpnl.Location = New System.Drawing.Point(12, 12)
        Me.campSelectionpnl.Name = "campSelectionpnl"
        Me.campSelectionpnl.Size = New System.Drawing.Size(131, 161)
        Me.campSelectionpnl.TabIndex = 11
        '
        'roadpnl
        '
        Me.roadpnl.Controls.Add(Me.campSelectionpnl)
        Me.roadpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.roadpnl.Location = New System.Drawing.Point(0, 0)
        Me.roadpnl.Name = "roadpnl"
        Me.roadpnl.Size = New System.Drawing.Size(155, 187)
        Me.roadpnl.TabIndex = 17
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlayerStatesBindingSource
        '
        Me.PlayerStatesBindingSource.DataMember = "PlayerStates"
        Me.PlayerStatesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerStatesTableAdapter
        '
        Me.PlayerStatesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Nothing
        Me.TableAdapterManager.PlayerStatesTableAdapter = Me.PlayerStatesTableAdapter
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.RoadStatesTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Nothing
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTiersTableAdapter = Nothing
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Nothing
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
        '
        'PlayerStatesBindingNavigator
        '
        Me.PlayerStatesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlayerStatesBindingNavigator.BindingSource = Me.PlayerStatesBindingSource
        Me.PlayerStatesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlayerStatesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlayerStatesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlayerStatesBindingNavigatorSaveItem})
        Me.PlayerStatesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlayerStatesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlayerStatesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlayerStatesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlayerStatesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlayerStatesBindingNavigator.Name = "PlayerStatesBindingNavigator"
        Me.PlayerStatesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlayerStatesBindingNavigator.Size = New System.Drawing.Size(111, 25)
        Me.PlayerStatesBindingNavigator.TabIndex = 18
        Me.PlayerStatesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PlayerStatesBindingNavigatorSaveItem
        '
        Me.PlayerStatesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlayerStatesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlayerStatesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlayerStatesBindingNavigatorSaveItem.Name = "PlayerStatesBindingNavigatorSaveItem"
        Me.PlayerStatesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PlayerStatesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RoadWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(155, 187)
        Me.Controls.Add(Me.PlayerStatesBindingNavigator)
        Me.Controls.Add(Me.roadpnl)
        Me.Name = "RoadWindow"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "travel"
        Me.campSelectionpnl.ResumeLayout(False)
        Me.campSelectionpnl.PerformLayout()
        Me.roadpnl.ResumeLayout(False)
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayerStatesBindingNavigator.ResumeLayout(False)
        Me.PlayerStatesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents camp1lbl As Label
    Friend WithEvents camp1btn As Button
    Friend WithEvents camp2btn As Button
    Friend WithEvents camp2lbl As Label
    Friend WithEvents camp3btn As Button
    Friend WithEvents camp3lbl As Label
    Friend WithEvents camp4btn As Button
    Friend WithEvents camp4lbl As Label
    Friend WithEvents camp5btn As Button
    Friend WithEvents camp5lbl As Label
    Friend WithEvents campSelectionlbl As Label
    Friend WithEvents campSelectionpnl As Panel
    Friend WithEvents roadpnl As Panel
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayerStatesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayerStatesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PlayerStatesBindingNavigatorSaveItem As ToolStripButton
End Class
