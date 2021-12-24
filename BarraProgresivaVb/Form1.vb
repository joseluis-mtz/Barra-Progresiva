Public Class Form1

    '' Se declara un contador para llenar la barra de progreso
    Public contador As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    '' Evento click de la barra de progreso
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        '' Se establecen los valores minimo y maximo de la barra
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 100
        '' Se indica el intervalo de tiempo del temporizador
        Timer1.Interval = 40
        '' Se activa el temporizador
        Timer1.Enabled = True
    End Sub

    '' Evento Tick o paso del temporizador
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '' Condición que evalua que el contador sea menor que el valor máximo de la barra
        If contador < 100 Then
            '' Se le asigna el valor del contador al valor de la barra de progreso
            ProgressBar1.Value = contador
            '' Se agrega el valor de 1 al valor que ya tiene el contador 
            contador += 1
        Else
            '' Cuando la condición deje de cumplirse se desactiva el temporizador
            Timer1.Enabled = False
            '' Se oculta la ventana que estaba activa
            Me.Hide()
            '' Se finaliza la aplicación
            Application.Exit()
        End If
    End Sub
End Class
