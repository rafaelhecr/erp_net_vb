Public Class Form7

    Private Sub USUARIOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USUARIOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.USUARIOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BduDataSet)

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 50
        glass.BottomBarSize = 10
        glass.RightBarSize = 10
        glass.LeftBarSize = 10
        glass.ShowEffect(Me, Label1)
        'TODO: esta línea de código carga datos en la tabla 'BduDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
        Me.USUARIOSTableAdapter.Fill(Me.BduDataSet.USUARIOS)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form11.Show()
        Me.Hide()
    End Sub
End Class