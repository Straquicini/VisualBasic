<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Nr_TipoLabel As System.Windows.Forms.Label
        Dim Nome_TipoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BDDataSet = New BD_Ex8_Parte1.BDDataSet()
        Me.TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposTableAdapter = New BD_Ex8_Parte1.BDDataSetTableAdapters.TiposTableAdapter()
        Me.TableAdapterManager = New BD_Ex8_Parte1.BDDataSetTableAdapters.TableAdapterManager()
        Me.TiposBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TiposBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Nr_TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.btn_seguinte = New System.Windows.Forms.Button()
        Me.btn_novo = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_remover = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Nr_TipoLabel = New System.Windows.Forms.Label()
        Nome_TipoLabel = New System.Windows.Forms.Label()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TiposBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nr_TipoLabel
        '
        Nr_TipoLabel.AutoSize = True
        Nr_TipoLabel.Location = New System.Drawing.Point(70, 56)
        Nr_TipoLabel.Name = "Nr_TipoLabel"
        Nr_TipoLabel.Size = New System.Drawing.Size(45, 13)
        Nr_TipoLabel.TabIndex = 1
        Nr_TipoLabel.Text = "Nr Tipo:"
        '
        'Nome_TipoLabel
        '
        Nome_TipoLabel.AutoSize = True
        Nome_TipoLabel.Location = New System.Drawing.Point(70, 82)
        Nome_TipoLabel.Name = "Nome_TipoLabel"
        Nome_TipoLabel.Size = New System.Drawing.Size(62, 13)
        Nome_TipoLabel.TabIndex = 3
        Nome_TipoLabel.Text = "Nome Tipo:"
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipamentosTableAdapter = Nothing
        Me.TableAdapterManager.TiposTableAdapter = Me.TiposTableAdapter
        Me.TableAdapterManager.UpdateOrder = BD_Ex8_Parte1.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TiposBindingNavigator
        '
        Me.TiposBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TiposBindingNavigator.BindingSource = Me.TiposBindingSource
        Me.TiposBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TiposBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TiposBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TiposBindingNavigatorSaveItem})
        Me.TiposBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TiposBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TiposBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TiposBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TiposBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TiposBindingNavigator.Name = "TiposBindingNavigator"
        Me.TiposBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TiposBindingNavigator.Size = New System.Drawing.Size(763, 25)
        Me.TiposBindingNavigator.TabIndex = 0
        Me.TiposBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'TiposBindingNavigatorSaveItem
        '
        Me.TiposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TiposBindingNavigatorSaveItem.Image = CType(resources.GetObject("TiposBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TiposBindingNavigatorSaveItem.Name = "TiposBindingNavigatorSaveItem"
        Me.TiposBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TiposBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Nr_TipoTextBox
        '
        Me.Nr_TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "Nr Tipo", True))
        Me.Nr_TipoTextBox.Location = New System.Drawing.Point(138, 53)
        Me.Nr_TipoTextBox.Name = "Nr_TipoTextBox"
        Me.Nr_TipoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nr_TipoTextBox.TabIndex = 2
        '
        'Nome_TipoTextBox
        '
        Me.Nome_TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "Nome Tipo", True))
        Me.Nome_TipoTextBox.Location = New System.Drawing.Point(138, 79)
        Me.Nome_TipoTextBox.Name = "Nome_TipoTextBox"
        Me.Nome_TipoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_TipoTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipos de Equipamentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Nr_TipoTextBox)
        Me.GroupBox1.Controls.Add(Me.Nome_TipoTextBox)
        Me.GroupBox1.Controls.Add(Nr_TipoLabel)
        Me.GroupBox1.Controls.Add(Nome_TipoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(211, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 159)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Equipamentos"
        '
        'btn_anterior
        '
        Me.btn_anterior.Location = New System.Drawing.Point(106, 309)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(70, 30)
        Me.btn_anterior.TabIndex = 7
        Me.btn_anterior.Text = "Anterior"
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'btn_seguinte
        '
        Me.btn_seguinte.Location = New System.Drawing.Point(182, 309)
        Me.btn_seguinte.Name = "btn_seguinte"
        Me.btn_seguinte.Size = New System.Drawing.Size(70, 30)
        Me.btn_seguinte.TabIndex = 8
        Me.btn_seguinte.Text = "Seguinte"
        Me.btn_seguinte.UseVisualStyleBackColor = True
        '
        'btn_novo
        '
        Me.btn_novo.Location = New System.Drawing.Point(258, 309)
        Me.btn_novo.Name = "btn_novo"
        Me.btn_novo.Size = New System.Drawing.Size(70, 30)
        Me.btn_novo.TabIndex = 9
        Me.btn_novo.Text = "Novo"
        Me.btn_novo.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(334, 309)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(70, 30)
        Me.btn_gravar.TabIndex = 10
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'btn_remover
        '
        Me.btn_remover.Location = New System.Drawing.Point(410, 309)
        Me.btn_remover.Name = "btn_remover"
        Me.btn_remover.Size = New System.Drawing.Size(70, 30)
        Me.btn_remover.TabIndex = 11
        Me.btn_remover.Text = "Remover"
        Me.btn_remover.UseVisualStyleBackColor = True
        '
        'btn_fechar
        '
        Me.btn_fechar.Location = New System.Drawing.Point(486, 309)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(70, 30)
        Me.btn_fechar.TabIndex = 12
        Me.btn_fechar.Text = "Fechar"
        Me.btn_fechar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(564, 309)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(70, 30)
        Me.btn_sair.TabIndex = 13
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 351)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_remover)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.btn_novo)
        Me.Controls.Add(Me.btn_seguinte)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TiposBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TiposBindingNavigator.ResumeLayout(False)
        Me.TiposBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDDataSet As BDDataSet
    Friend WithEvents TiposBindingSource As BindingSource
    Friend WithEvents TiposTableAdapter As BDDataSetTableAdapters.TiposTableAdapter
    Friend WithEvents TableAdapterManager As BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TiposBindingNavigator As BindingNavigator
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
    Friend WithEvents TiposBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Nr_TipoTextBox As TextBox
    Friend WithEvents Nome_TipoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_anterior As Button
    Friend WithEvents btn_seguinte As Button
    Friend WithEvents btn_novo As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_remover As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents btn_sair As Button
End Class
