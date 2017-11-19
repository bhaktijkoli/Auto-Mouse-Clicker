Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public WithEvents HotKeyTimer As New Timer
    Public WithEvents StartTimer As New Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.ProductName
        Me.Icon = My.Resources.icon
        HotKeyTimer.Interval = 500
        HotKeyTimer.Enabled = True
        HotKeyTimer.Start()
        ListButton.SelectedIndex = 0
        NumInterval.Value = 1000
        StartTimer.Enabled = False
    End Sub

    Private Sub HotKeyTimer_Tick(sender As Object, e As EventArgs) Handles HotKeyTimer.Tick
        If GetAsyncKeyState(Keys.F11) Then
            HotKeyTimer.Enabled = False
            CmdStart_Click()
        End If
    End Sub

    Private Sub CmdStart_Click() Handles CmdStart.Click
        If StartTimer.Enabled = False Then
            CmdStart.Text = "Stop"
            StartTimer.Enabled = True
            StartTimer.Interval = NumInterval.Value
            StartTimer.Start()
            NumInterval.Enabled = False
            SplashMessage.Message("Press F10 to stop " + My.Application.Info.ProductName)
            SplashMessage.Start()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Else
            CmdStart.Text = "Start"
            StartTimer.Stop()
            StartTimer.Enabled = False
            SplashMessage.Message("Press F10 to start " + My.Application.Info.ProductName)
            SplashMessage.Start()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
        HotKeyTimer.Enabled = True
        NumInterval.Enabled = Not StartTimer.Enabled
    End Sub

    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        Select Case ListButton.SelectedIndex
            Case 0
                Mouse.RightClick()
            Case 1
                Mouse.LeftClick()
            Case 2
                Mouse.MiddleClick()
        End Select
    End Sub
End Class
