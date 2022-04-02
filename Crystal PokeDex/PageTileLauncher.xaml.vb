Partial Public Class PageTileLauncher
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
        InitializeList()
        InitializeMainList()
        IsSimplifiedChineseEnabled = IsoSettingsLib.Item("IsCHS")
        IsOfficialTranslationEnabled = IsoSettingsLib.Item("IsOfficial")
        GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
        SetCurrentDisplay()
        InitAbilitySettings()
        SetCurrentAbilityDisplay()
        InitMovesSettings()
        SetCurrentMovesDisplay()
    End Sub

    Private Sub PageTileLauncher_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        IsLaunchedFromPinned = True
        If IsoSettingsLib.Keys.Count = 0 Then
            IsoSettingsLib.Add("IsCHS", False)
            IsoSettingsLib.Add("IsOfficial", False)
        End If
        If IsoSettingsLib.Keys.Count = 1 Then
            IsoSettingsLib.Add("IsOfficial", False)
        End If
        InitColorStorage()
        InitializeTileIndexServer()
        Dim comm As Integer
        Dim nums As String
        nums = ""
        comm = 0
        If NavigationContext.QueryString.Keys.Contains("Num") Then
            NavigationContext.QueryString.TryGetValue("Num", nums)
        End If
        comm = CInt(nums)
        PokemonInformationShared = GetPokemonInformation(CInt(nums))
        NavigationService.Navigate(New System.Uri("/PagePokemonDetails.xaml", UriKind.RelativeOrAbsolute))
        'MessageBox.Show(nums)
    End Sub
End Class
