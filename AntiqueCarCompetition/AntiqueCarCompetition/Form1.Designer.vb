﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAntiqueCarCompetition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAntiqueCarCompetition))
        Dim Contestant_IDLabel As System.Windows.Forms.Label
        Dim Car_YearLabel As System.Windows.Forms.Label
        Dim Car_ModelLabel As System.Windows.Forms.Label
        Dim Owner_NameLabel As System.Windows.Forms.Label
        Dim HometownLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CarDataSet = New AntiqueCarCompetition.CarDataSet()
        Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarsTableAdapter = New AntiqueCarCompetition.CarDataSetTableAdapters.CarsTableAdapter()
        Me.TableAdapterManager = New AntiqueCarCompetition.CarDataSetTableAdapters.TableAdapterManager()
        Me.CarsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CarsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Contestant_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Car_YearTextBox = New System.Windows.Forms.TextBox()
        Me.Car_ModelTextBox = New System.Windows.Forms.TextBox()
        Me.Owner_NameTextBox = New System.Windows.Forms.TextBox()
        Me.HometownTextBox = New System.Windows.Forms.TextBox()
        Contestant_IDLabel = New System.Windows.Forms.Label()
        Car_YearLabel = New System.Windows.Forms.Label()
        Car_ModelLabel = New System.Windows.Forms.Label()
        Owner_NameLabel = New System.Windows.Forms.Label()
        HometownLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Pink
        Me.Label1.Location = New System.Drawing.Point(11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antique Car Top Ten Finalists"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AntiqueCarCompetition.My.Resources.Resources.car
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(493, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 385)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'CarDataSet
        '
        Me.CarDataSet.DataSetName = "CarDataSet"
        Me.CarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarsBindingSource
        '
        Me.CarsBindingSource.DataMember = "Cars"
        Me.CarsBindingSource.DataSource = Me.CarDataSet
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarsTableAdapter = Me.CarsTableAdapter
        Me.TableAdapterManager.UpdateOrder = AntiqueCarCompetition.CarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarsBindingNavigator
        '
        Me.CarsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CarsBindingNavigator.BindingSource = Me.CarsBindingSource
        Me.CarsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CarsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CarsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CarsBindingNavigatorSaveItem})
        Me.CarsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CarsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CarsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CarsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CarsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CarsBindingNavigator.Name = "CarsBindingNavigator"
        Me.CarsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CarsBindingNavigator.Size = New System.Drawing.Size(782, 25)
        Me.CarsBindingNavigator.TabIndex = 2
        Me.CarsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CarsBindingNavigatorSaveItem
        '
        Me.CarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CarsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CarsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CarsBindingNavigatorSaveItem.Name = "CarsBindingNavigatorSaveItem"
        Me.CarsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CarsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Contestant_IDLabel
        '
        Contestant_IDLabel.AutoSize = True
        Contestant_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contestant_IDLabel.Location = New System.Drawing.Point(48, 117)
        Contestant_IDLabel.Name = "Contestant_IDLabel"
        Contestant_IDLabel.Size = New System.Drawing.Size(127, 20)
        Contestant_IDLabel.TabIndex = 3
        Contestant_IDLabel.Text = "Contestant ID:"
        '
        'Contestant_IDTextBox
        '
        Me.Contestant_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Contestant ID", True))
        Me.Contestant_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contestant_IDTextBox.Location = New System.Drawing.Point(181, 114)
        Me.Contestant_IDTextBox.Name = "Contestant_IDTextBox"
        Me.Contestant_IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Contestant_IDTextBox.TabIndex = 4
        '
        'Car_YearLabel
        '
        Car_YearLabel.AutoSize = True
        Car_YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_YearLabel.Location = New System.Drawing.Point(48, 165)
        Car_YearLabel.Name = "Car_YearLabel"
        Car_YearLabel.Size = New System.Drawing.Size(85, 20)
        Car_YearLabel.TabIndex = 5
        Car_YearLabel.Text = "Car Year:"
        '
        'Car_YearTextBox
        '
        Me.Car_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Car Year", True))
        Me.Car_YearTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_YearTextBox.Location = New System.Drawing.Point(181, 162)
        Me.Car_YearTextBox.Name = "Car_YearTextBox"
        Me.Car_YearTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Car_YearTextBox.TabIndex = 6
        '
        'Car_ModelLabel
        '
        Car_ModelLabel.AutoSize = True
        Car_ModelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_ModelLabel.Location = New System.Drawing.Point(48, 214)
        Car_ModelLabel.Name = "Car_ModelLabel"
        Car_ModelLabel.Size = New System.Drawing.Size(95, 20)
        Car_ModelLabel.TabIndex = 7
        Car_ModelLabel.Text = "Car Model:"
        '
        'Car_ModelTextBox
        '
        Me.Car_ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Car Model", True))
        Me.Car_ModelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_ModelTextBox.Location = New System.Drawing.Point(181, 211)
        Me.Car_ModelTextBox.Name = "Car_ModelTextBox"
        Me.Car_ModelTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Car_ModelTextBox.TabIndex = 8
        '
        'Owner_NameLabel
        '
        Owner_NameLabel.AutoSize = True
        Owner_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Owner_NameLabel.Location = New System.Drawing.Point(48, 263)
        Owner_NameLabel.Name = "Owner_NameLabel"
        Owner_NameLabel.Size = New System.Drawing.Size(116, 20)
        Owner_NameLabel.TabIndex = 9
        Owner_NameLabel.Text = "Owner Name:"
        '
        'Owner_NameTextBox
        '
        Me.Owner_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Owner Name", True))
        Me.Owner_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owner_NameTextBox.Location = New System.Drawing.Point(181, 260)
        Me.Owner_NameTextBox.Name = "Owner_NameTextBox"
        Me.Owner_NameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Owner_NameTextBox.TabIndex = 10
        '
        'HometownLabel
        '
        HometownLabel.AutoSize = True
        HometownLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HometownLabel.Location = New System.Drawing.Point(48, 314)
        HometownLabel.Name = "HometownLabel"
        HometownLabel.Size = New System.Drawing.Size(99, 20)
        HometownLabel.TabIndex = 11
        HometownLabel.Text = "Hometown:"
        '
        'HometownTextBox
        '
        Me.HometownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Hometown", True))
        Me.HometownTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HometownTextBox.Location = New System.Drawing.Point(181, 311)
        Me.HometownTextBox.Name = "HometownTextBox"
        Me.HometownTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HometownTextBox.TabIndex = 12
        '
        'frmAntiqueCarCompetition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 414)
        Me.Controls.Add(HometownLabel)
        Me.Controls.Add(Me.HometownTextBox)
        Me.Controls.Add(Owner_NameLabel)
        Me.Controls.Add(Me.Owner_NameTextBox)
        Me.Controls.Add(Car_ModelLabel)
        Me.Controls.Add(Me.Car_ModelTextBox)
        Me.Controls.Add(Car_YearLabel)
        Me.Controls.Add(Me.Car_YearTextBox)
        Me.Controls.Add(Contestant_IDLabel)
        Me.Controls.Add(Me.Contestant_IDTextBox)
        Me.Controls.Add(Me.CarsBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAntiqueCarCompetition"
        Me.Text = "Antique Car Competition"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarsBindingNavigator.ResumeLayout(False)
        Me.CarsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CarDataSet As CarDataSet
    Friend WithEvents CarsBindingSource As BindingSource
    Friend WithEvents CarsTableAdapter As CarDataSetTableAdapters.CarsTableAdapter
    Friend WithEvents TableAdapterManager As CarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarsBindingNavigator As BindingNavigator
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
    Friend WithEvents CarsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Contestant_IDTextBox As TextBox
    Friend WithEvents Car_YearTextBox As TextBox
    Friend WithEvents Car_ModelTextBox As TextBox
    Friend WithEvents Owner_NameTextBox As TextBox
    Friend WithEvents HometownTextBox As TextBox
End Class
