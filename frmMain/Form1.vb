Public Class Form1

    Function Promedio(ByVal notaMat As Integer, ByVal notaHis As Integer, ByVal notaPro As Integer) As Integer

        Return (notaMat + notaHis + notaPro) / 3

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emdPromedio.Click
        Dim Prom As Integer
        Prom = Promedio(CInt(txtHistoria.Text), CInt(txtMatematicas.Text), CInt(txtProgramacion.Text))
        If Prom <= 7 Then
            MsgBox("PROMEDIO: " & txtNombre.Text & " " & Prom, MsgBoxStyle.Critical)
        ElseIf Prom <= 9 Then
            MsgBox("PROMEDIO: " & txtNombre.Text & " " & Prom, MsgBoxStyle.Exclamation)
        ElseIf Prom <= 12 Then
            MsgBox("PROMEDIO: " & txtNombre.Text & " " & Prom, MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged



    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHistoria.TextChanged

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
