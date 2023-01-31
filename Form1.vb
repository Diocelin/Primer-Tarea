Public Class Form1

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        X1.Text = ""
        X2.Text = ""
        Y1.Text = ""
        Y2.Text = ""
        Distancia.Text = ""
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim X1numero As Double
        Dim X2numero As Double
        Dim Y1numero As Double
        Dim Y2numero As Double

        X1numero = X1.Text
        X2numero = X2.Text
        Y1numero = Y1.Text
        Y2numero = Y2.Text

        Distancia.Text = Math.Round(Math.Sqrt(Math.Pow(X2numero - X1numero, 2) + Math.Pow(Y2numero - Y1numero, 2)), 4)
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

   
End Class

