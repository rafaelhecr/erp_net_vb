Public Class Form12

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 50
        glass.BottomBarSize = 20
        glass.RightBarSize = 20
        glass.LeftBarSize = 20
        glass.ShowEffect(Me, Label2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class