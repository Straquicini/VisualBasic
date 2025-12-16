Public Class Form2
    Private Sub TiposBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TiposBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TiposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BDDataSet.Tipos'. Você pode movê-la ou removê-la conforme necessário.
        Me.TiposTableAdapter.Fill(Me.BDDataSet.Tipos)

    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        TiposBindingSource.MovePrevious()
    End Sub

    Private Sub btn_seguinte_Click(sender As Object, e As EventArgs) Handles btn_seguinte.Click
        TiposBindingSource.MoveNext()
    End Sub

    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        TiposBindingSource.AddNew()
    End Sub

    Private Sub btn_remover_Click(sender As Object, e As EventArgs) Handles btn_remover.Click
        Try
            TiposBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(BDDataSet)
            MsgBox("Registo atual foi apagado", vbOKOnly, "GMEI Software!")
        Catch ex As Exception
            MsgBox("Erro!", vbOKOnly, "GMEI Software!")
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            TiposBindingSource.EndEdit()
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