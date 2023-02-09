Partial Public Class PivotPageSettings
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ValidateColor()
        If Not IsNumberBool(txtRed.Text) Then
            txtRed.Text = "0"
        End If
        If Not IsNumberBool(txtGreen.Text) Then
            txtGreen.Text = "0"
        End If
        If Not IsNumberBool(txtBlue.Text) Then
            txtBlue.Text = "0"
        End If
        If CInt(txtRed.Text.ToString) > 255 Then
            txtRed.Text = "255"
        End If
        If CInt(txtRed.Text.ToString) < 0 Then
            txtRed.Text = "0"
        End If
        If CInt(txtGreen.Text.ToString) > 255 Then
            txtGreen.Text = "255"
        End If
        If CInt(txtRed.Text.ToString) < 0 Then
            txtGreen.Text = "0"
        End If
        If CInt(txtBlue.Text.ToString) > 255 Then
            txtBlue.Text = "255"
        End If
        If CInt(txtBlue.Text.ToString) < 0 Then
            txtBlue.Text = "0"
        End If
    End Sub
    Private Sub UpdateColorPreview()
        ValidateColor()
        clrPicker.Color = Color.FromArgb(255, CInt(txtRed.Text), CInt(txtGreen.Text), CInt(txtBlue.Text))
        rctColorPreview.Fill = New SolidColorBrush(Color.FromArgb(255, CInt(txtRed.Text), CInt(txtGreen.Text), CInt(txtBlue.Text)))
    End Sub
    Private Sub chkUseCHS_Tap(sender As Object, e As GestureEventArgs) Handles chkUseCHS.Tap
        If chkUseCHS.IsChecked = True Then
            IsSimplifiedChineseEnabled = True
            IsoSettingsLib.Item("IsCHS") = True
            GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
            SetCurrentDisplay()
        Else
            IsChineseNames = False
            IsSimplifiedChineseEnabled = False
            IsoSettingsLib.Item("IsCHS") = False
            GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
            SetCurrentDisplay()
        End If
    End Sub

    Private Sub PivotPageSettings_BackKeyPress(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.BackKeyPress
        If GridColor.Visibility = System.Windows.Visibility.Visible Then
            GridColor.Visibility = System.Windows.Visibility.Collapsed
            e.Cancel = True
        End If
    End Sub

    Private Sub PageSettings_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
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
        If IsAbilitySimplifiedChineseEnabled Then
            chkUseCHS_Ability.IsChecked = True
        Else
            chkUseCHS_Ability.IsChecked = False
        End If
        If IsAbilityOfficialTranslationEnabled Then
            chkUseOfficial_Ability.IsChecked = True
        Else
            chkUseOfficial_Ability.IsChecked = False
        End If
        If IsMovesSimplifiedChineseEnabled Then
            chkUseCHS_Moves.IsChecked = True
        Else
            chkUseCHS_Moves.IsChecked = False
        End If
        If IsMovesOfficialTranslationEnabled Then
            chkUseOfficial_Moves.IsChecked = True
        Else
            chkUseOfficial_Moves.IsChecked = False
        End If
        If chkRGBInput.IsChecked Then
            grdRGBPicker.Visibility = System.Windows.Visibility.Visible
            clrPicker.Visibility = System.Windows.Visibility.Collapsed
        Else
            grdRGBPicker.Visibility = System.Windows.Visibility.Collapsed
            clrPicker.Visibility = System.Windows.Visibility.Visible
        End If
        GridColor.Visibility = System.Windows.Visibility.Collapsed
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
        With ValueHP
            If .IsSystemAccent Then
                prgSVHP.Foreground = prgExp.Foreground
            Else
                prgSVHP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueAttack
            If .IsSystemAccent Then
                prgSVATK.Foreground = prgExp.Foreground
            Else
                prgSVATK.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueDefence
            If .IsSystemAccent Then
                prgSVDEF.Foreground = prgExp.Foreground
            Else
                prgSVDEF.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpecialAttack
            If .IsSystemAccent Then
                prgSVSA.Foreground = prgExp.Foreground
            Else
                prgSVSA.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpecialDefence
            If .IsSystemAccent Then
                prgSVSD.Foreground = prgExp.Foreground
            Else
                prgSVSD.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpeed
            If .IsSystemAccent Then
                prgSVSP.Foreground = prgExp.Foreground
            Else
                prgSVSP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueTotal
            If .IsSystemAccent Then
                prgSVT.Foreground = prgExp.Foreground
            Else
                prgSVT.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
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

    Private Sub chkUseDefault_DoubleTap(sender As Object, e As GestureEventArgs) Handles chkUseDefault.DoubleTap
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
    End Sub
    Private Sub chkUseDefault_Tab(sender As Object, e As GestureEventArgs) Handles chkUseDefault.Tap
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
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

    Private Sub prgSVDEF_Tap(sender As Object, e As GestureEventArgs) Handles prgSVDEF.Tap
        EditingTarget = EditingTargets.DEF
        With ValueDefence
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub prgSVHP_Tap(sender As Object, e As GestureEventArgs) Handles prgSVHP.Tap
        'MessageBox.Show("")
        EditingTarget = EditingTargets.HP
        With ValueHP
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub prgSVATK_Tap(sender As Object, e As GestureEventArgs) Handles prgSVATK.Tap
        EditingTarget = EditingTargets.ATK
        With ValueAttack
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub prgSVSA_Tap(sender As Object, e As GestureEventArgs) Handles prgSVSA.Tap
        EditingTarget = EditingTargets.SATK
        With ValueSpecialAttack
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub prgSVSD_Tap(sender As Object, e As GestureEventArgs) Handles prgSVSD.Tap
        EditingTarget = EditingTargets.SDEF
        With ValueSpecialDefence
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub prgSVSP_Tap(sender As Object, e As GestureEventArgs) Handles prgSVSP.Tap
        EditingTarget = EditingTargets.SPD
        With ValueSpeed
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub prgSVT_Tap(sender As Object, e As GestureEventArgs) Handles prgSVT.Tap
        EditingTarget = EditingTargets.TOTAL
        With ValueTotal
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtSVHP_Tap(sender As Object, e As GestureEventArgs) Handles txtSVHP.Tap
        EditingTarget = EditingTargets.HP
        With ValueHP
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtSVDEF_Tap(sender As Object, e As GestureEventArgs) Handles txtSVDEF.Tap
        EditingTarget = EditingTargets.DEF
        With ValueDefence
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtSVATK_Tap(sender As Object, e As GestureEventArgs) Handles txtSVATK.Tap
        EditingTarget = EditingTargets.ATK
        With ValueAttack
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtSVSA_Tap(sender As Object, e As GestureEventArgs) Handles txtSVSA.Tap
        EditingTarget = EditingTargets.SATK
        With ValueSpecialAttack
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtSVSD_Tap(sender As Object, e As GestureEventArgs) Handles txtSVSD.Tap
        EditingTarget = EditingTargets.SDEF
        With ValueSpecialDefence
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtSVSP_Tap(sender As Object, e As GestureEventArgs) Handles txtSVSP.Tap
        EditingTarget = EditingTargets.SPD
        With ValueSpeed
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtSVT_Tap(sender As Object, e As GestureEventArgs) Handles txtSVT.Tap
        EditingTarget = EditingTargets.TOTAL
        With ValueTotal
            chkUseDefault.IsChecked = .IsSystemAccent
            txtRed.Text = .ColorSettingsRGB.Red
            txtGreen.Text = .ColorSettingsRGB.Green
            txtBlue.Text = .ColorSettingsRGB.Blue
        End With
        If chkUseDefault.IsChecked Then
            txtRed.IsEnabled = False
            txtGreen.IsEnabled = False
            txtBlue.IsEnabled = False
            clrPicker.IsEnabled = False
        Else
            txtRed.IsEnabled = True
            txtGreen.IsEnabled = True
            txtBlue.IsEnabled = True
            clrPicker.IsEnabled = True
        End If
        UpdateColorPreview()
        GridColor.Visibility = System.Windows.Visibility.Visible
    End Sub

    Private Sub txtBlue_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtBlue.GotFocus
        txtBlue.SelectAll()
    End Sub

    Private Sub txtGreen_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtGreen.GotFocus
        txtGreen.SelectAll()
    End Sub

    Private Sub txtRed_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtRed.GotFocus
        txtRed.SelectAll()
    End Sub

    Private Sub txtRed_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtRed.LostFocus
        UpdateColorPreview()
    End Sub

    Private Sub txtGreen_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtGreen.LostFocus
        UpdateColorPreview()
    End Sub

    Private Sub txtBlue_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtBlue.LostFocus
        UpdateColorPreview()
    End Sub

    Private Sub chkUseCHS_Ability_Tap(sender As Object, e As GestureEventArgs) Handles chkUseCHS_Ability.Tap
        If chkUseCHS_Ability.IsChecked Then
            IsAbilitySimplifiedChineseEnabled = True
            GetAbilityDisplayConfig(IsAbilitySimplifiedChineseEnabled, IsAbilityOfficialTranslationEnabled)
            SetCurrentAbilityDisplay()
        Else
            IsAbilitySimplifiedChineseEnabled = False
            GetAbilityDisplayConfig(IsAbilitySimplifiedChineseEnabled, IsAbilityOfficialTranslationEnabled)
            SetCurrentAbilityDisplay()
        End If
    End Sub

    Private Sub chkUseOfficial_Ability_Tap(sender As Object, e As GestureEventArgs) Handles chkUseOfficial_Ability.Tap
        If chkUseOfficial_Ability.IsChecked Then
            IsAbilityOfficialTranslationEnabled = True
            GetAbilityDisplayConfig(IsAbilitySimplifiedChineseEnabled, IsAbilityOfficialTranslationEnabled)
            SetCurrentAbilityDisplay()
        Else
            IsAbilityOfficialTranslationEnabled = False
            GetAbilityDisplayConfig(IsAbilitySimplifiedChineseEnabled, IsAbilityOfficialTranslationEnabled)
            SetCurrentAbilityDisplay()
        End If
    End Sub

    Private Sub chkUseCHS_Moves_Tap(sender As Object, e As GestureEventArgs) Handles chkUseCHS_Moves.Tap
        If chkUseCHS_Moves.IsChecked Then
            IsMovesSimplifiedChineseEnabled = True
            GetMovesDisplayConfig(IsMovesSimplifiedChineseEnabled, IsMovesOfficialTranslationEnabled)
            SetCurrentMovesDisplay()
        Else
            IsMovesSimplifiedChineseEnabled = False
            GetMovesDisplayConfig(IsMovesSimplifiedChineseEnabled, IsMovesOfficialTranslationEnabled)
            SetCurrentMovesDisplay()
        End If
    End Sub

    Private Sub chkUseOfficial_Moves_Tap(sender As Object, e As GestureEventArgs) Handles chkUseOfficial_Moves.Tap
        If chkUseOfficial_Moves.IsChecked Then
            IsMovesOfficialTranslationEnabled = True
            GetMovesDisplayConfig(IsMovesSimplifiedChineseEnabled, IsMovesOfficialTranslationEnabled)
            SetCurrentMovesDisplay()
        Else
            IsMovesOfficialTranslationEnabled = False
            GetMovesDisplayConfig(IsMovesSimplifiedChineseEnabled, IsMovesOfficialTranslationEnabled)
            SetCurrentMovesDisplay()
        End If
    End Sub

    Private Sub chkRGBInput_Click(sender As Object, e As RoutedEventArgs) Handles chkRGBInput.Click
        If chkRGBInput.IsChecked Then
            clrPicker.Visibility = System.Windows.Visibility.Collapsed
            grdRGBPicker.Visibility = System.Windows.Visibility.Visible
            txtRed.Text = clrPicker.Color.R
            txtGreen.Text = clrPicker.Color.G
            txtBlue.Text = clrPicker.Color.B
            rctColorPreview.Fill = New SolidColorBrush(clrPicker.Color)
        Else
            clrPicker.Visibility = System.Windows.Visibility.Visible
            grdRGBPicker.Visibility = System.Windows.Visibility.Collapsed
            UpdateColorPreview()
        End If
    End Sub
    Private Sub clrPicker_ColorChanged(sender As Object, color As Color) Handles clrPicker.ColorChanged
        txtRed.Text = clrPicker.Color.R.ToString
        txtGreen.Text = clrPicker.Color.G.ToString
        txtBlue.Text = clrPicker.Color.B.ToString
        rctColorPreview.Fill = New SolidColorBrush(clrPicker.Color)
    End Sub

    Private Sub btnCancel_Tap(sender As Object, e As GestureEventArgs) Handles btnCancel.Tap
        GridColor.Visibility = System.Windows.Visibility.Collapsed
    End Sub

    Private Sub btnOK_Tap(sender As Object, e As GestureEventArgs) Handles btnOK.Tap
        If txtRed.Text.Length = 0 Then
            txtRed.Text = "0"
        End If
        If txtBlue.Text.Length = 0 Then
            txtBlue.Text = "0"
        End If
        If txtGreen.Text.Length = 0 Then
            txtGreen.Text = "0"
        End If
        If IsNumber(txtRed.Text) = 0 Then
            MessageBox.Show("請輸入有效的數值。", "錯誤", MessageBoxButton.OK)
            Exit Sub
        End If
        If IsNumber(txtGreen.Text) = 0 Then
            MessageBox.Show("請輸入有效的數值。", "錯誤", MessageBoxButton.OK)
            Exit Sub
        End If
        If IsNumber(txtBlue.Text) = 0 Then
            MessageBox.Show("請輸入有效的數值。", "錯誤", MessageBoxButton.OK)
            Exit Sub
        End If
        txtRed.Text = CInt(txtRed.Text.ToString)
        txtGreen.Text = CInt(txtGreen.Text.ToString)
        txtBlue.Text = CInt(txtBlue.Text.ToString)
        If CInt(txtRed.Text.ToString) > 255 Then
            txtRed.Text = "255"
        End If
        If CInt(txtRed.Text.ToString) < 0 Then
            txtRed.Text = "0"
        End If
        If CInt(txtGreen.Text.ToString) > 255 Then
            txtGreen.Text = "255"
        End If
        If CInt(txtRed.Text.ToString) < 0 Then
            txtGreen.Text = "0"
        End If
        If CInt(txtBlue.Text.ToString) > 255 Then
            txtBlue.Text = "255"
        End If
        If CInt(txtBlue.Text.ToString) < 0 Then
            txtBlue.Text = "0"
        End If
        Select Case EditingTarget
            Case EditingTargets.HP
                With ValueHP
                    .IsSystemAccent = chkUseDefault.IsChecked
                    With .ColorSettingsRGB
                        .Red = txtRed.Text
                        .Green = txtGreen.Text
                        .Blue = txtBlue.Text
                    End With
                    If .IsSystemAccent Then
                        prgSVHP.Foreground = prgExp.Foreground
                    Else
                        prgSVHP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                    End If
                End With
                'IsoSettingsLib("ColorHP") = ValueHP
            Case EditingTargets.ATK
                With ValueAttack
                    .IsSystemAccent = chkUseDefault.IsChecked
                    With .ColorSettingsRGB
                        .Red = txtRed.Text
                        .Green = txtGreen.Text
                        .Blue = txtBlue.Text
                    End With
                    If .IsSystemAccent Then
                        prgSVATK.Foreground = prgExp.Foreground
                    Else
                        prgSVATK.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                    End If
                End With
                'IsoSettingsLib("ColorATK") = ValueAttack
            Case EditingTargets.DEF
                With ValueDefence
                    .IsSystemAccent = chkUseDefault.IsChecked
                    With .ColorSettingsRGB
                        .Red = txtRed.Text
                        .Green = txtGreen.Text
                        .Blue = txtBlue.Text
                    End With
                    If .IsSystemAccent Then
                        prgSVDEF.Foreground = prgExp.Foreground
                    Else
                        prgSVDEF.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                    End If
                End With
                'IsoSettingsLib("ColorDEF") = ValueDefence
            Case EditingTargets.SATK
                With ValueSpecialAttack
                    .IsSystemAccent = chkUseDefault.IsChecked
                    With .ColorSettingsRGB
                        .Red = txtRed.Text
                        .Green = txtGreen.Text
                        .Blue = txtBlue.Text
                    End With
                    If .IsSystemAccent Then
                        prgSVSA.Foreground = prgExp.Foreground
                    Else
                        prgSVSA.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                    End If
                End With
                'IsoSettingsLib("ColorSATK") = ValueSpecialAttack
            Case EditingTargets.SDEF
                With ValueSpecialDefence
                    .IsSystemAccent = chkUseDefault.IsChecked
                    With .ColorSettingsRGB
                        .Red = txtRed.Text
                        .Green = txtGreen.Text
                        .Blue = txtBlue.Text
                    End With
                    If .IsSystemAccent Then
                        prgSVSD.Foreground = prgExp.Foreground
                    Else
                        prgSVSD.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                    End If
                End With
                'IsoSettingsLib("ColorSDEF") = ValueSpecialDefence
            Case EditingTargets.SPD
                With ValueSpeed
                    .IsSystemAccent = chkUseDefault.IsChecked
                    With .ColorSettingsRGB
                        .Red = txtRed.Text
                        .Green = txtGreen.Text
                        .Blue = txtBlue.Text
                    End With
                    If .IsSystemAccent Then
                        prgSVSP.Foreground = prgExp.Foreground
                    Else
                        prgSVSP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                    End If
                End With
                'IsoSettingsLib("ColorSPD") = ValueSpeed
            Case EditingTargets.TOTAL
                With ValueTotal
                    .IsSystemAccent = chkUseDefault.IsChecked
                    With .ColorSettingsRGB
                        .Red = txtRed.Text
                        .Green = txtGreen.Text
                        .Blue = txtBlue.Text
                    End With
                    If .IsSystemAccent Then
                        prgSVT.Foreground = prgExp.Foreground
                    Else
                        prgSVT.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                    End If
                End With
                'IsoSettingsLib("ColorTotal") = ValueTotal
        End Select
        SaveColor(EditingTarget)
        GridColor.Visibility = System.Windows.Visibility.Collapsed
    End Sub
End Class
