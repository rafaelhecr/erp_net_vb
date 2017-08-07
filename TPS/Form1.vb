Imports System.Data.OleDb
Public Class Form1
    Inherits Form
    Public s As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect
        glass.TopBarSize = 100
        glass.LeftBarSize = 20
        glass.RightBarSize = 20
        glass.BottomBarSize = 60
        glass.ShowEffect(Me, Label1)
    End Sub


    Public Sub CommandLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink1.Click
        Dim con As Integer = 0
regreso:
        Dim oconn As New OleDbConnection 'conexion
        Dim ocomm As New OleDbCommand
        Dim odata As OleDbDataReader
        Dim ocomm1 As String = "SELECT * FROM ADMINISTRA where NOMBRE='" + TextBox1.Text + "' And CONTRA='" + TextBox2.Text + "'"
        Dim ocomm2 As String = "SELECT * FROM SYSADMON where NOMBRE='" + TextBox1.Text + "' And CONTRA='" + TextBox2.Text + "'"
        Dim ocomm3 As String = "SELECT * FROM USUARIOS where NOMBRE='" + TextBox1.Text + "' And CONTRA='" + TextBox2.Text + "'"
        On Error GoTo errcon
        oconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files\TPSFripapas\db\bdu.accdb;Persist Security Info=True;Jet OLEDB:Database Password=adminsys"
        oconn.Open()
        If con = 0 Then
            ocomm.CommandText = ocomm1
            ocomm.Connection = oconn
            odata = ocomm.ExecuteReader()
            If (odata.HasRows) Then
                Form10.Show()
                Me.Hide()
            Else
                con = con + 1
                GoTo regreso
            End If
        End If
        If con = 1 Then
            ocomm.CommandText = ocomm2
            ocomm.Connection = oconn
            odata = ocomm.ExecuteReader()
            If (odata.HasRows) Then
                Form11.Show()
                Me.Hide()
            Else
                con = con + 1
                GoTo regreso
            End If
        End If
        If con = 2 Then
            ocomm.CommandText = ocomm3
            ocomm.Connection = oconn
            odata = ocomm.ExecuteReader()
            If (odata.HasRows) Then
                Form2.Show()
                Me.Hide()
            Else
                con = con + 1
                GoTo regreso
            End If
        End If
        If con = 3 Then
            MessageBox.Show("Nombre de usuario y/o contraseña incorrecta", "Imposible inicias sesion", MessageBoxButtons.OK)
        End If
        oconn.Close()
        Exit Sub
errcon:
        MsgBox("Error:" + Err.Description)
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "No ha escrito un nombre de usuario")
        End If
    End Sub
End Class
