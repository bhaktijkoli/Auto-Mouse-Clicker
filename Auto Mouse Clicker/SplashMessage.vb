Public Class SplashMessage

    WithEvents ShowTimer As New Timer With {.Interval = 1000}

    Public Sub Start()
        ShowTimer.Enabled = True
        ShowTimer.Start()
        Me.Show()
    End Sub

    Public Sub FStop() Handles ShowTimer.Tick
        ShowTimer.Enabled = False
        ShowTimer.Stop()
        Me.Hide()
    End Sub

    Public Sub Message(Message As String)
        LblMessage.Text = Message
    End Sub

    Private Sub SplashMessage_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
        Top = 10
    End Sub
End Class
