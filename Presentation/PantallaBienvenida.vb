
Public Class PantallaBienvenida

    Private Sub PantallaBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        FadeIn()
    End Sub

    Private Sub FadeIn()
        Dim fadeInTimer As New Timer() With {.Interval = 30}
        AddHandler fadeInTimer.Tick,
            Sub(sender As Object, e As EventArgs)
                Me.Opacity += 0.05
                If Me.Opacity >= 1 Then
                    fadeInTimer.Stop()
                End If
            End Sub
        fadeInTimer.Start()
    End Sub

    Private Sub FadeOutAndClose()
        Dim fadeOutTimer As New Timer() With {.Interval = 30}
        AddHandler fadeOutTimer.Tick,
            Sub(sender As Object, e As EventArgs)
                Me.Opacity -= 0.05
                If Me.Opacity <= 0 Then
                    fadeOutTimer.Stop()
                    Me.Close()
                End If
            End Sub
        fadeOutTimer.Start()
    End Sub

End Class