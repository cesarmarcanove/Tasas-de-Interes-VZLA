Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Ap, i1, i2, z1, m, m1, d, n As Double
        Dim x1 As Double
        Dim c1 As Double
        Dim cien As Single

        'Numero 100
        cien = 100

        'Ingresos de datos
        Ap = Val(TxtAP.Text)   'Capital
        i1 = Val(TxtINT.Text)  'Tasa de Interes
        n = Val(TxtTMP.Text)   'Tiempo

        'Divisor entre 12 (Tasa de interés MEnsual)
        i2 = i1 / 12

        'Divisor entre 100
        'd = i1 / cien         'Tasa de interés anual
        d = i2 / cien          'Tasa de interés mensual

        'Multiplicar por 100
        z1 = d * 100

        'Calculo multiplo interes mas tiempo
        m = d * n

        'Calculo suma 1 mas resultado m = d * n
        m1 = 1 + m

        'Calculo capital mas resultado m = 1 + m
        c1 = Ap * m1

        'Monto del interés
        x1 = (c1 - Ap)

        'Salida de Datos
        'TxtMENSUAL.Text = c1
        TxtMINT.Text = Math.Round(Convert.ToDouble(x1), 2) & " $"
        TxtACUM.Text = Math.Round(Convert.ToDouble(c1), 2) & " $"
        TxtMENS.Text = Math.Round(Convert.ToDouble(z1), 2) & " %"
        TxtANUAL.Text = Math.Round(Convert.ToDouble(i1), 2) & " %"


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Limpiar en los ingresos de datos
        TxtAP.Text = " "
        TxtINT.Text = " "
        TxtTMP.Text = " "

        'Limpiar Pantalla en los resultados
        TxtACUM.Text = " "
        TxtMINT.Text = " "
        TxtMENS.Text = " "
        TxtANUAL.Text = " "
        TxtAP.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
