Partial Public Class PageSettings
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub chkUseCHS_Tap(sender As Object, e As GestureEventArgs) Handles chkUseCHS.Tap
        If chkUseCHS.IsChecked = True Then
            IsSimplifiedChineseEnabled = True
            IsoSettingsLib.Item("IsCHS") = True
            GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
            'InitalizeList()
            'InitalizeMainList()
            SetCurrentDisplay()
        Else
            IsChineseNames = False
            IsSimplifiedChineseEnabled = False
            IsoSettingsLib.Item("IsCHS") = False
            GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
            'InitalizeList()
            'InitalizeMainList()
            SetCurrentDisplay()
        End If
    End Sub

    Private Sub PageSettings_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        IsoSettingsLib = IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings
        If IsoSettingsLib.Keys.Count = 0 Then
            IsoSettingsLib.Add("IsCHS", False)
            IsoSettingsLib.Add("IsOfficial", False)
        End If
        If IsoSettingsLib.Keys.Count = 1 Then
            IsoSettingsLib.Add("IsOfficial", False)
        End If
        IsSimplifiedChineseEnabled = IsoSettingsLib.Item("IsCHS")
        IsOfficialTranslationEnabled = IsoSettingsLib.Item("IsOfficial")
        If IsSimplifiedChineseEnabled Then
            chkUseCHS.IsChecked = True
        Else
            chkUseCHS.IsChecked = False
        End If
        If IsOfficialTranslationEnabled Then
            chkUseOfficial.IsChecked = True
        Else
            chkUseOfficial.IsChecked = False
        End If
        IsChineseNames = IsoSettingsLib.Item("IsCHS")
        If IsChineseNames Then
            chkUseCHS.IsChecked = True
        Else
            chkUseCHS.IsChecked = False
        End If
        Dim OSVersionWPEPO As Version = New Version(8, 10, 0)
        Dim OSVersionGDR3 As Version = New Version(8, 0, 10492)
        If Environment.OSVersion.Version < OSVersionGDR3 Then
            gridSR.Visibility = System.Windows.Visibility.Collapsed
            gridPS.Visibility = System.Windows.Visibility.Collapsed
            gridNotifications.Visibility = System.Windows.Visibility.Collapsed
            gridOffice.Visibility = System.Windows.Visibility.Collapsed
            gridNFC.Visibility = System.Windows.Visibility.Collapsed
        ElseIf (OSVersionGDR3 <= Environment.OSVersion.Version) And (Environment.OSVersion.Version < OSVersionWPEPO) Then
            gridSR.Visibility = System.Windows.Visibility.Visible
            gridPS.Visibility = System.Windows.Visibility.Visible
            gridNotifications.Visibility = System.Windows.Visibility.Collapsed
            gridOffice.Visibility = System.Windows.Visibility.Collapsed
            gridNFC.Visibility = System.Windows.Visibility.Collapsed
        Else
            gridSR.Visibility = System.Windows.Visibility.Visible
            gridPS.Visibility = System.Windows.Visibility.Visible
            gridNotifications.Visibility = System.Windows.Visibility.Visible
            gridOffice.Visibility = System.Windows.Visibility.Visible
            gridNFC.Visibility = System.Windows.Visibility.Visible
        End If
    End Sub
    Private Sub gridAirPlaneMode_Tap(sender As Object, e As GestureEventArgs) Handles gridAirPlaneMode.Tap
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.AirplaneMode
        CST.Show()
    End Sub

    Private Sub gridBluetooth_Tap(sender As Object, e As GestureEventArgs) Handles gridBluetooth.Tap
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.Bluetooth
        CST.Show()
    End Sub

    Private Sub gridCellular_Tap(sender As Object, e As GestureEventArgs) Handles gridCellular.Tap
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.Cellular
        CST.Show()
    End Sub

    Private Async Sub gridGPS_Tap(sender As Object, e As GestureEventArgs) Handles gridGPS.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-location:"))
    End Sub

    Private Sub gridWLAN_Tap(sender As Object, e As GestureEventArgs) Handles gridWLAN.Tap
        Dim CST As Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST = New Microsoft.Phone.Tasks.ConnectionSettingsTask
        CST.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.WiFi
        CST.Show()
    End Sub

    Private Async Sub gridLock_Tap(sender As Object, e As GestureEventArgs) Handles gridLock.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-lock:"))
    End Sub

    Private Async Sub gridMail_Tap(sender As Object, e As GestureEventArgs) Handles gridMail.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-emailandaccounts:"))
    End Sub

    Private Async Sub gridNFC_Tap(sender As Object, e As GestureEventArgs) Handles gridNFC.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-proximity:"))
    End Sub

    Private Async Sub gridNotifications_Tap(sender As Object, e As GestureEventArgs) Handles gridNotifications.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-notifications:"))
    End Sub

    Private Async Sub gridOffice_Tap(sender As Object, e As GestureEventArgs) Handles gridOffice.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-workplace:"))
    End Sub

    Private Async Sub gridPS_Tap(sender As Object, e As GestureEventArgs) Handles gridPS.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-power:"))
    End Sub

    Private Async Sub gridSR_Tap(sender As Object, e As GestureEventArgs) Handles gridSR.Tap
        Await Windows.System.Launcher.LaunchUriAsync(New Uri("ms-settings-screenrotation:"))
    End Sub

    Private Sub chkUseOfficial_Tap(sender As Object, e As GestureEventArgs) Handles chkUseOfficial.Tap
        If chkUseOfficial.IsChecked Then
            IsOfficialTranslationEnabled = True
            IsoSettingsLib.Item("IsOfficial") = True
            GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
            'InitalizeList()
            'InitalizeMainList()
            SetCurrentDisplay()
        Else
            IsOfficialTranslationEnabled = False
            IsoSettingsLib.Item("IsOfficial") = False
            GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
            'InitalizeList()
            'InitalizeMainList()
            SetCurrentDisplay()
        End If
    End Sub
End Class
