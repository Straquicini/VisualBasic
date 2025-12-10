Public Class Form3
    Private Sub EquipamentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EquipamentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BDDataSet.Tipos'. Você pode movê-la ou removê-la conforme necessário.
        Me.TiposTableAdapter.Fill(Me.BDDataSet.Tipos)
        'TODO: esta linha de código carrega dados na tabela 'BDDataSet.Equipamentos'. Você pode movê-la ou removê-la conforme necessário.
        Me.EquipamentosTableAdapter.Fill(Me.BDDataSet.Equipamentos)

    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        EquipamentosBindingSource.MovePrevious()
    End Sub

    Private Sub btn_seguinte_Click(sender As Object, e As EventArgs) Handles btn_seguinte.Click
        EquipamentosBindingSource.MoveNext()
    End Sub

    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        EquipamentosBindingSource.AddNew()
    End Sub

    Private Sub btn_remover_Click(sender As Object, e As EventArgs) Handles btn_remover.Click
        Try
            EquipamentosBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(BDDataSet)
            MsgBox("Registo atual foi apagado", vbOKOnly, "GMEI Software!")
        Catch ex As Exception
            MsgBox("Erro!", vbOKOnly, "GMEI Software!")
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            EquipamentosBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(BDDataSet)
            MsgBox("Gravação de dados com sucesso", vbOKOnly, "GMEI Software!")
        Catch ex As Exception
            MsgBox("Erro! Registo já existente!!!", vbOKOnly, "GMEI Software!")
        End Try
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

End Class