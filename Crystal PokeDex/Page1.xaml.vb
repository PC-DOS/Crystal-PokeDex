Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell
Imports Microsoft.Phone.Info.DeviceExtendedProperties
Imports Microsoft.Phone.Info.DeviceStatus
Imports Windows.Phone.Devices.Power
Imports Windows.Phone.System.Memory
Imports Microsoft.Phone.Tasks
Imports Microsoft.Phone.Media
Imports Windows.Phone.Media.Capture
Imports Microsoft.Xna.Framework.Media
Partial Public Class Page1
    Inherits PhoneApplicationPage
    Dim pnc As Microsoft.Phone.Tasks.PhoneNumberChooserTask
    Dim flflag As Boolean
    Dim phoneNumberChooserTask As PhoneNumberChooserTask
    Dim batt As Battery
    Dim IsFlashOn As Boolean = False
    Dim avDevice As AudioVideoCaptureDevice

    Public Sub New()
        InitializeComponent()
        phoneNumberChooserTask = New PhoneNumberChooserTask()
        AddHandler phoneNumberChooserTask.Completed, AddressOf phoneNumberChooserTask_Completed
        batt = Windows.Phone.Devices.Power.Battery.GetDefault
    End Sub
    Private Sub phoneNumberChooserTask_Completed(sender As Object, e As PhoneNumberResult)

        If e.TaskResult = TaskResult.OK Then

            MessageBox.Show("The phone number for " + e.DisplayName + " is " + e.PhoneNumber)

            'Code to start a new call using the retrieved phone number.
            Dim phoneCallTask As PhoneCallTask
            phoneCallTask = New PhoneCallTask()
            phoneCallTask.DisplayName = e.DisplayName
            phoneCallTask.PhoneNumber = e.PhoneNumber
            'MessageBox.Show(phoneCallTask.PhoneNumber)
            phoneCallTask.Show()
        End If
    End Sub
    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim mec As MediaElement
        mec = New MediaElement
        mec.Stop()
        Dim a As Microsoft.Phone.BackgroundAudio.UserAction
        a = New Microsoft.Phone.BackgroundAudio.UserAction
        Dim b
        b = Microsoft.Phone.BackgroundAudio.UserAction.Stop
        Microsoft.Phone.BackgroundAudio.BackgroundAudioPlayer.Instance.Close()
        MediaPlayer.Stop()
        Dim song As Song = song.FromUri("MySong", New Uri("00.mp3", UriKind.Relative))
        MessageBox.Show("Stopped Music Successfuly", "Stop Music", MessageBoxButton.OK)
        MediaPlayer.Play(song)
        MediaPlayer.Play(song)
        MessageBox.Show("Stopped Music Successfuly", "Stop Music", MessageBoxButton.OK)
    End Sub
    Private Sub ApplicationBarIconButton_Click_2(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        phoneNumberChooserTask.Show()
    End Sub
    Private Sub ApplicationBarMenuItem_Click(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim mec As MediaElement
        mec = New MediaElement
        mec.Stop()
        Dim a As Microsoft.Phone.BackgroundAudio.UserAction
        a = New Microsoft.Phone.BackgroundAudio.UserAction
        Dim b
        b = Microsoft.Phone.BackgroundAudio.UserAction.Stop
        Microsoft.Phone.BackgroundAudio.BackgroundAudioPlayer.Instance.Close()
        MediaPlayer.Stop()
        Dim song As Song = song.FromUri("MySong", New Uri("00.mp3", UriKind.Relative))
        MessageBox.Show("Stopped Music Successfuly", "Stop Music", MessageBoxButton.OK)
        MediaPlayer.Play(song)
        MediaPlayer.Play(song)
        MessageBox.Show("Stopped Music Successfuly", "Stop Music", MessageBoxButton.OK)
    End Sub
    Private Sub ApplicationBarMenuItem_Click_2(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.AirplaneMode
        CST.Show()
    End Sub
    Private Sub ApplicationBarMenuItem_Click_3(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.Bluetooth
        CST.Show()
    End Sub
    Private Sub ApplicationBarMenuItem_Click_4(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.WiFi
        CST.Show()
    End Sub
    Private Sub ApplicationBarMenuItem_Click_5(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.Cellular
        CST.Show()
    End Sub
    Private Sub ApplicationBarMenuItem_Click_7(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim mht As Microsoft.Phone.Tasks.MarketplaceHubTask
        mht = New Microsoft.Phone.Tasks.MarketplaceHubTask
        mht.ContentType = Microsoft.Phone.Tasks.MarketplaceContentType.Applications
        mht.Show()
    End Sub
    Sub Toolbox(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        NavigationService.Navigate(New Uri("/PivotPage1.xaml", UriKind.Relative))
    End Sub
    Private Sub ApplicationBarMenuItem_Click_8(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim mht As Microsoft.Phone.Tasks.MarketplaceHubTask
        mht = New Microsoft.Phone.Tasks.MarketplaceHubTask
        mht.ContentType = Microsoft.Phone.Tasks.MarketplaceContentType.Music
        mht.Show()
    End Sub
    Private Sub ApplicationBarMenuItem_Click_9(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        phoneNumberChooserTask.Show()
    End Sub

    Private Sub Page1_DoubleTap(sender As Object, e As GestureEventArgs) Handles Me.DoubleTap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub Page1_Hold(sender As Object, e As GestureEventArgs) Handles Me.Hold
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub Page1_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        AddHandler batt.RemainingChargePercentChanged, AddressOf Battery_PercentChanged
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim tmr As System.Windows.Threading.DispatcherTimer
        tmr = New System.Windows.Threading.DispatcherTimer
        tmr.Interval = TimeSpan.FromSeconds(1)
        AddHandler tmr.Tick, AddressOf tmr_Timer
        tmr.Start()
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub
    Sub BattTmr_Timer()
        Dim lpBL As Integer
        Dim Batt As Battery
        Batt = Battery.GetDefault
        lpBL = batt.RemainingChargePercent
        'Dim BatteryInfo As Battery
        ''BatteryInfo = New Windows.Phone.Devices.Power.Battery
        'lpBL = BatteryInfo.RemainingChargePercent
        TextBlock2_Copy2.Text = Batt.RemainingChargePercent.ToString & "%"
        lpBL = lpBL
        'If lpBL >= 75 Then
        '    TimeBoxS_Copy2.Fill = New SolidColorBrush(Colors.Cyan)
        '    TimeBoxS_Copy2.Stroke = New SolidColorBrush(Colors.Cyan)
        '    TimeBoxS_Copy1.Fill = New SolidColorBrush(Colors.Cyan)
        '    TimeBoxS_Copy1.Stroke = New SolidColorBrush(Colors.Cyan)
        'ElseIf 50 <= lpBL < 75 Then
        '    TimeBoxS_Copy2.Fill = New SolidColorBrush(Colors.Yellow)
        '    TimeBoxS_Copy2.Stroke = New SolidColorBrush(Colors.Yellow)
        '    TimeBoxS_Copy1.Fill = New SolidColorBrush(Colors.Yellow)
        '    TimeBoxS_Copy1.Stroke = New SolidColorBrush(Colors.Yellow)
        'ElseIf 25 <= lpBL < 50 Then
        '    TimeBoxS_Copy2.Fill = New SolidColorBrush(Colors.Orange)
        '    TimeBoxS_Copy2.Stroke = New SolidColorBrush(Colors.Orange)
        '    TimeBoxS_Copy1.Fill = New SolidColorBrush(Colors.Orange)
        '    TimeBoxS_Copy1.Stroke = New SolidColorBrush(Colors.Orange)
        'ElseIf lpBL < 25 Then
        '    TimeBoxS_Copy2.Fill = New SolidColorBrush(Colors.Red)
        '    TimeBoxS_Copy2.Stroke = New SolidColorBrush(Colors.Red)
        '    TimeBoxS_Copy1.Fill = New SolidColorBrush(Colors.Red)
        '    TimeBoxS_Copy1.Stroke = New SolidColorBrush(Colors.Red)
        'ElseIf lpBL = 100 Then
        '    TimeBoxS_Copy2.Fill = New SolidColorBrush(Colors.Green)
        '    TimeBoxS_Copy2.Stroke = New SolidColorBrush(Colors.Green)
        '    TimeBoxS_Copy1.Fill = New SolidColorBrush(Colors.Green)
        '    TimeBoxS_Copy1.Stroke = New SolidColorBrush(Colors.Green)
        'End If
    End Sub
    Sub tmr_Timer()
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub Page1_Tap(sender As Object, e As GestureEventArgs) Handles Me.Tap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub ContentPanel_DoubleTap(sender As Object, e As GestureEventArgs) Handles ContentPanel.DoubleTap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub ContentPanel_GotFocus(sender As Object, e As RoutedEventArgs) Handles ContentPanel.GotFocus
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub ContentPanel_Hold(sender As Object, e As GestureEventArgs) Handles ContentPanel.Hold
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub ContentPanel_Tap(sender As Object, e As GestureEventArgs) Handles ContentPanel.Tap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub LayoutRoot_DoubleTap(sender As Object, e As GestureEventArgs) Handles LayoutRoot.DoubleTap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub LayoutRoot_GotFocus(sender As Object, e As RoutedEventArgs) Handles LayoutRoot.GotFocus
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub LayoutRoot_Hold(sender As Object, e As GestureEventArgs) Handles LayoutRoot.Hold
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub LayoutRoot_Tap(sender As Object, e As GestureEventArgs) Handles LayoutRoot.Tap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock1__Copy2_DoubleTap(sender As Object, e As GestureEventArgs) Handles TextBlock1__Copy2.DoubleTap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock1__Copy2_GotFocus(sender As Object, e As RoutedEventArgs) Handles TextBlock1__Copy2.GotFocus
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock1__Copy2_Hold(sender As Object, e As GestureEventArgs) Handles TextBlock1__Copy2.Hold
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock1__Copy2_Tap(sender As Object, e As GestureEventArgs) Handles TextBlock1__Copy2.Tap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TimeBox_DoubleTap(sender As Object, e As GestureEventArgs) Handles TimeBox.DoubleTap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TimeBox_GotFocus(sender As Object, e As RoutedEventArgs) Handles TimeBox.GotFocus
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TimeBox_Hold(sender As Object, e As GestureEventArgs) Handles TimeBox.Hold
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TimeBox_Tap(sender As Object, e As GestureEventArgs) Handles TimeBox.Tap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock2_Copy2_DoubleTap(sender As Object, e As GestureEventArgs) Handles TextBlock2_Copy2.DoubleTap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock2_Copy2_GotFocus(sender As Object, e As RoutedEventArgs) Handles TextBlock2_Copy2.GotFocus
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock2_Copy2_Hold(sender As Object, e As GestureEventArgs) Handles TextBlock2_Copy2.Hold
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub

    Private Sub TextBlock2_Copy2_Tap(sender As Object, e As GestureEventArgs) Handles TextBlock2_Copy2.Tap
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub
    Private Async Sub ApplicationBarMenuItem_Click_11(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Dim OSVersionGDR3 As Version = New Version(8, 0, 10492)
        If Environment.OSVersion.Version >= OSVersionGDR3 Then
            Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-screenrotation:"))
        Else
            MessageBox.Show("屏幕旋轉要求至少Windows Phone 8 GDR3操作系統")
            Exit Sub
        End If
    End Sub
    Private Async Sub ApplicationBarMenuItem_Click_12(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        'Dim OSVersionGDR3 As Version = New Version(8, 0, 10492)
        ''If Environment.OSVersion.Version >= OSVersionGDR3 Then
        'Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-power:"))
        ''Else
        ''MessageBox.Show("屏幕旋轉要求至少Windows Phone 8 GDR3操作系統")
        ''Exit Sub
        ''End If
        Dim OSVersionGDR3 As Version = New Version(8, 0, 10492)
        If Environment.OSVersion.Version >= OSVersionGDR3 Then
            Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-power:"))
        Else
            MessageBox.Show("省電模式要求至少Windows Phone 8 GDR3操作系統")
            Exit Sub
        End If
    End Sub
    Private Async Sub ApplicationBarMenuItem_Click_13(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-lock:"))
    End Sub
    Private Async Sub ApplicationBarMenuItem_Click_14(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-location:"))
    End Sub
    Sub Refresh(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub
    Private Sub ApplicationBarIconButton_Click_1(sender As Object, e As EventArgs)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub
    Sub Battery_PercentChanged(lpSender As Object, e As Object)
        Dim BattTmr As System.Windows.Threading.DispatcherTimer
        BattTmr = New System.Windows.Threading.DispatcherTimer
        BattTmr.Interval = TimeSpan.FromSeconds(25)
        AddHandler BattTmr.Tick, AddressOf BattTmr_Timer
        BattTmr.Start()
        Dim lpBL As Integer
        lpBL = batt.RemainingChargePercent
        TextBlock2_Copy2.Text = batt.RemainingChargePercent.ToString & "%"
        Dim TmrHour As Integer
        Dim TmrMinute As Integer
        Dim TmrSecond As Integer
        TmrHour = DateTime.Now.Hour
        TmrMinute = DateTime.Now.Minute
        TmrSecond = DateTime.Now.Second
        TimeBox.Text = "當前系統時間:" & String.Format("{0:D2}", TmrHour) & "時" & String.Format("{0:D2}", TmrMinute) & "分" & String.Format("{0:D2}", TmrSecond) & "秒"
    End Sub
End Class
