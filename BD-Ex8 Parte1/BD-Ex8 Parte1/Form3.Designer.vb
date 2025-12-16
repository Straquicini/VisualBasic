<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NrLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim Nr_TipoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.BDDataSet = New BD_Ex8_Parte1.BDDataSet()
        Me.EquipamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipamentosTableAdapter = New BD_Ex8_Parte1.BDDataSetTableAdapters.EquipamentosTableAdapter()
        Me.TableAdapterManager = New BD_Ex8_Parte1.BDDataSetTableAdapters.TableAdapterManager()
        Me.EquipamentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EquipamentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NrTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox()
        Me.Nr_TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.btn_seguinte = New System.Windows.Forms.Button()
        Me.btn_novo = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_remover = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposTableAdapter = New BD_Ex8_Parte1.BDDataSetTableAdapters.TiposTableAdapter()
        NrLabel = New System.Windows.Forms.Label()
        DescriçãoLabel = New System.Windows.Forms.Label()
        Nr_TipoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquipamentosBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NrLabel
        '
        NrLabel.AutoSize = True
        NrLabel.Location = New System.Drawing.Point(52, 50)
        NrLabel.Name = "NrLabel"
        NrLabel.Size = New System.Drawing.Size(21, 13)
        NrLabel.TabIndex = 1
        NrLabel.Text = "Nr:"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Location = New System.Drawing.Point(52, 76)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(58, 13)
        DescriçãoLabel.TabIndex = 3
        DescriçãoLabel.Text = "Descrição:"
        '
        'Nr_TipoLabel
        '
        Nr_TipoLabel.AutoSize = True
        Nr_TipoLabel.Location = New System.Drawing.Point(52, 102)
        Nr_TipoLabel.Name = "Nr_TipoLabel"
        Nr_TipoLabel.Size = New System.Drawing.Size(45, 13)
        Nr_TipoLabel.TabIndex = 5
        Nr_TipoLabel.Text = "Nr Tipo:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(52, 129)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 7
        DataLabel.Text = "Data:"
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipamentosBindingSource
        '
        Me.EquipamentosBindingSource.DataMember = "Equipamentos"
        Me.EquipamentosBindingSource.DataSource = Me.BDDataSet
        '
        'EquipamentosTableAdapter
        '
        Me.EquipamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipamentosTableAdapter = Me.EquipamentosTableAdapter
        Me.TableAdapterManager.TiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_Ex8_Parte1.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EquipamentosBindingNavigator
        '
        Me.EquipamentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EquipamentosBindingNavigator.BindingSource = Me.EquipamentosBindingSource
        Me.EquipamentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EquipamentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EquipamentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EquipamentosBindingNavigatorSaveItem})
        Me.EquipamentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EquipamentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EquipamentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EquipamentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EquipamentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EquipamentosBindingNavigator.Name = "EquipamentosBindingNavigator"
        Me.EquipamentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EquipamentosBindingNavigator.Size = New System.Drawing.Size(712, 25)
        Me.EquipamentosBindingNavigator.TabIndex = 0
        Me.EquipamentosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover seguinte"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EquipamentosBindingNavigatorSaveItem
        '
        Me.EquipamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EquipamentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EquipamentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EquipamentosBindingNavigatorSaveItem.Name = "EquipamentosBindingNavigatorSaveItem"
        Me.EquipamentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EquipamentosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'NrTextBox
        '
        Me.NrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Nr", True))
        Me.NrTextBox.Location = New System.Drawing.Point(116, 47)
        Me.NrTextBox.Name = "NrTextBox"
        Me.NrTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NrTextBox.TabIndex = 2
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Descrição", True))
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(116, 73)
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriçãoTextBox.TabIndex = 4
        '
        'Nr_TipoTextBox
        '
        Me.Nr_TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Nr Tipo", True))
        Me.Nr_TipoTextBox.Location = New System.Drawing.Point(116, 99)
        Me.Nr_TipoTextBox.Name = "Nr_TipoTextBox"
        Me.Nr_TipoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nr_TipoTextBox.TabIndex = 6
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquipamentosBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(116, 125)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Controls.Add(Me.NrTextBox)
        Me.GroupBox1.Controls.Add(NrLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(DescriçãoLabel)
        Me.GroupBox1.Controls.Add(Me.Nr_TipoTextBox)
        Me.GroupBox1.Controls.Add(Me.DescriçãoTextBox)
        Me.GroupBox1.Controls.Add(Nr_TipoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 190)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipamentos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Equipametos"
        '
        'btn_anterior
        '
        Me.btn_anterior.Location = New System.Drawing.Point(76, 305)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(80, 37)
        Me.btn_anterior.TabIndex = 11
        Me.btn_anterior.Text = "Anterior"
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'btn_seguinte
        '
        Me.btn_seguinte.Location = New System.Drawing.Point(162, 305)
        Me.btn_seguinte.Name = "btn_seguinte"
        Me.btn_seguinte.Size = New System.Drawing.Size(80, 37)
        Me.btn_seguinte.TabIndex = 12
        Me.btn_seguinte.Text = "Seguinte"
        Me.btn_seguinte.UseVisualStyleBackColor = True
        '
        'btn_novo
        '
        Me.btn_novo.Location = New System.Drawing.Point(248, 305)
        Me.btn_novo.Name = "btn_novo"
        Me.btn_novo.Size = New System.Drawing.Size(75, 37)
        Me.btn_novo.TabIndex = 13
        Me.btn_novo.Text = "Novo"
        Me.btn_novo.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(329, 305)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(79, 37)
        Me.btn_gravar.TabIndex = 14
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'btn_remover
        '
        Me.btn_remover.Location = New System.Drawing.Point(414, 305)
        Me.btn_remover.Name = "btn_remover"
        Me.btn_remover.Size = New System.Drawing.Size(74, 37)
        Me.btn_remover.TabIndex = 15
        Me.btn_remover.Text = "Remover"
        Me.btn_remover.UseVisualStyleBackColor = True
        '
        'btn_fechar
        '
        Me.btn_fechar.Location = New System.Drawing.Point(494, 305)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(74, 37)
        Me.btn_fechar.TabIndex = 16
        Me.btn_fechar.Text = "Fechar"
        Me.btn_fechar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(574, 305)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(74, 37)
        Me.btn_sair.TabIndex = 17
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EquipamentosBindingSource, "Nr Tipo", True))
        Me.ComboBox1.DataSource = Me.TiposBindingSource
        Me.ComboBox1.DisplayMember = "Nome Tipo"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(579, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "Nr Tipo"
        '
        'TiposBindingSource
        '
        Me.TiposBindingSource.DataMember = "Tipos"
        Me.TiposBindingSource.DataSource = Me.BDDataSet
        '
        'TiposTableAdapter
        '
        Me.TiposTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 365)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_remover)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.btn_novo)
        Me.Controls.Add(Me.btn_seguinte)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EquipamentosBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquipamentosBindingNavigator.ResumeLayout(False)
        Me.EquipamentosBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDDataSet As BDDataSet
    Friend WithEvents EquipamentosBindingSource As BindingSource
    Friend WithEvents EquipamentosTableAdapter As BDDataSetTableAdapters.EquipamentosTableAdapter
    Friend WithEvents TableAdapterManager As BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipamentosBindingNavigator As BindingNavigator
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
    Friend WithEvents EquipamentosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NrTextBox As TextBox
    Friend WithEvents DescriçãoTextBox As TextBox
    Friend WithEvents Nr_TipoTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_anterior As Button
    Friend WithEvents btn_seguinte As Button
    Friend WithEvents btn_novo As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_remover As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TiposBindingSource As BindingSource
    Friend WithEvents TiposTableAdapter As BDDataSetTableAdapters.TiposTableAdapter
End Class
