Public Class Form9

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BduDataSet.SYSADMON' Puede moverla o quitarla según sea necesario.
        Me.SYSADMONTableAdapter.Fill(Me.BduDataSet.SYSADMON)
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 50
        glass.LeftBarSize = 10
        glass.RightBarSize = 10
        glass.BottomBarSize = 10
        glass.ShowEffect(Me, Label1)
    End Sub

    Private Sub SYSADMONBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYSADMONBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SYSADMONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BduDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form11.Show()
        Me.Hide()
    End Sub
End Class