Public Class Form8

    Private Sub ADMINISTRABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADMINISTRABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ADMINISTRABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BduDataSet)

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim glas As New rtaGlassEffectsLib.rtaGlassEffect
        glas.TopBarSize = 50
        glas.BottomBarSize = 10
        glas.RightBarSize = 10
        glas.LeftBarSize = 10
        glas.ShowEffect(Me, Label1)
        'TODO: esta línea de código carga datos en la tabla 'BduDataSet.ADMINISTRA' Puede moverla o quitarla según sea necesario.
        Me.ADMINISTRATableAdapter.Fill(Me.BduDataSet.ADMINISTRA)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form11.Show()
        Me.Hide()
    End Sub
End Class