Public Class Splash_Screen_Video
    Private Sub Splash_Screen_Video_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.uiMode = "none"
        AxWindowsMediaPlayer1.stretchToFit = True

        AxWindowsMediaPlayer1.settings.volume = 100

        Dim programPath As String = Application.StartupPath

        Dim videoFilename As String = "KN.avi"
        Dim videoPath As String = System.IO.Path.Combine(programPath, videoFilename)

        AxWindowsMediaPlayer1.URL = videoPath

        AxWindowsMediaPlayer1.settings.autoStart = True

        AddHandler AxWindowsMediaPlayer1.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
    End Sub
    Private Sub MediaPlayer_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsMediaEnded Then
            Splash_Screen.Show()
            Me.Close()
        End If
    End Sub
End Class