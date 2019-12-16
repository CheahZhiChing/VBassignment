Public Class Form1

    Private Sub TbBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tb' table. You can move, or remove it, as needed.
        Me.TbTableAdapter.Fill(Me.Database1DataSet.tb)

    End Sub

    Private Sub TbDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TbDataGridView.CellContentClick

    End Sub
End Class
