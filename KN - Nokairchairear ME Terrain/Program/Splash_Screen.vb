Imports System.IO

Public Class Splash_Screen

    Dim D1Size_Max As Integer
    Dim NA As Integer = 0

    Public Shared Program_System_File_Path As String = Application.ExecutablePath

    Public Shared HR_Log As String = Path.Combine(Program_System_File_Path, "/Log/")
    Public Shared HR_Setting As String = Path.Combine(Program_System_File_Path, "/Setting/")
    Public Shared HR_Cache_Memory As String = Path.Combine(Program_System_File_Path, "/Cache/")

    Public Shared HR_SQL_SETTING As String = Path.Combine(Program_System_File_Path, "/SQL_PERF/")
    Public Shared HR_SQL_UNICODE As String = Path.Combine(Program_System_File_Path, "/SQL_DATA/")

    Public Shared HR_MS_SQL As String = Path.Combine(Program_System_File_Path, "/MSSQL/")
    Public Shared HR_MY_SQL As String = Path.Combine(Program_System_File_Path, "/MYSQL/")
    'Public Shared HR_LI_SQL As String = Path.Combine(Program_System_File_Path, "/LISQL/")

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        D1Size_Max = Panel1.Width
        If Panel2.Location.X > D1Size_Max Then
            Panel2.Location = New Point((0 - Panel2.Width), 0)
            NA = 0 - (Panel2.Width)
        End If
        NA += 15
        Panel2.Location = New Point(NA, 0)
    End Sub

    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()

        AxWindowsMediaPlayer1.uiMode = "none"
        AxWindowsMediaPlayer1.stretchToFit = True

        AxWindowsMediaPlayer1.settings.volume = 100
        Dim programPath As String = Application.StartupPath
        Dim videoFilename As String = "DMC.avi"
        Dim videoPath As String = System.IO.Path.Combine(programPath, videoFilename)
        AxWindowsMediaPlayer1.URL = videoPath
        AxWindowsMediaPlayer1.settings.autoStart = True
        AddHandler AxWindowsMediaPlayer1.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
    End Sub

    Private Sub MediaPlayer_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsMediaEnded Then
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Timer2.Interval = 3000 Then
            Kernal.Show() ' DDS - Start Form
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Dim Process_Percentage_Start As Double

    Sub Load_Program()
        Process_Percentage_Start = 0.00
    End Sub

    Sub CREATE_SQL_CACHE()
        Create_Folder(Path.Combine(Program_System_File_Path, HR_SQL_UNICODE))
        Create_Folder(Path.Combine(Program_System_File_Path, HR_SQL_SETTING))
        Dim HR_SQL_UNICODE_MSE As String = Path.Combine(Program_System_File_Path, HR_SQL_UNICODE)
        Create_Folder(Path.Combine(HR_SQL_UNICODE_MSE, HR_MS_SQL))
        Create_Folder(Path.Combine(HR_SQL_UNICODE_MSE, HR_MY_SQL))


    End Sub

    Sub Create_Folder(Path_And_Name_Folder As String)
        ' Specify the path for the new folder
        Dim folderPath As String = Path_And_Name_Folder

        ' Check if the folder doesn't exist, then create it
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)

        Else

        End If
    End Sub


End Class