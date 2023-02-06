Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Dim SUICUNE As Integer
    ' 建構函式
    Public Sub New()
        InitializeComponent()
        If IsoSettingsLib.Keys.Count = 0 Then
            IsoSettingsLib.Add("IsCHS", False)
            IsoSettingsLib.Add("IsOfficial", True)
        End If
        If IsoSettingsLib.Keys.Count = 1 Then
            IsoSettingsLib.Add("IsOfficial", True)
        End If
        IsSimplifiedChineseEnabled = IsoSettingsLib.Item("IsCHS")
        IsOfficialTranslationEnabled = IsoSettingsLib.Item("IsOfficial")
        GetChineseDisplayConfig(IsSimplifiedChineseEnabled, IsOfficialTranslationEnabled)
        SetCurrentDisplay()
        InitAbilitySettings()
        SetCurrentAbilityDisplay()
        InitMovesSettings()
        SetCurrentMovesDisplay()
        DataContext = App.ViewModel
    End Sub

    ' 載入 ViewModel 項目的資料
    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        If Not App.ViewModel.IsDataLoaded Then
            App.ViewModel.LoadData()
        End If
    End Sub

    Private Sub imgTypes_Tap(sender As Object, e As GestureEventArgs) Handles imgTypes.Tap
        NavigationService.Navigate(New Uri("/PageTypes.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectTypes_Tap(sender As Object, e As GestureEventArgs) Handles rectTypes.Tap
        NavigationService.Navigate(New Uri("/PageTypes.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtTypes_Tap(sender As Object, e As GestureEventArgs) Handles txtTypes.Tap
        NavigationService.Navigate(New Uri("/PageTypes.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgNatures_Tap(sender As Object, e As GestureEventArgs) Handles imgNatures.Tap
        NavigationService.Navigate(New Uri("/PageNatures.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtNatures_Tap(sender As Object, e As GestureEventArgs) Handles txtNatures.Tap
        NavigationService.Navigate(New Uri("/PageNatures.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectNatures_Tap(sender As Object, e As GestureEventArgs) Handles rectNatures.Tap
        NavigationService.Navigate(New Uri("/PageNatures.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgPokemons_Tap(sender As Object, e As GestureEventArgs) Handles imgPokemons.Tap
        NavigationService.Navigate(New Uri("/PagePokemons.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectPkemons_Tap(sender As Object, e As GestureEventArgs) Handles rectPokemons.Tap
        NavigationService.Navigate(New Uri("/PagePokemons.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtPokemos_Tap(sender As Object, e As GestureEventArgs) Handles txtPokemos.Tap
        NavigationService.Navigate(New Uri("/PagePokemons.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'IsoSettingsLib = IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings
        'Do
        'MessageBox.Show(IsoSettingsLib.Keys.Count)
        'Loop Until 1 = 2
        'Thread.Sleep(TimeSpan.FromSeconds(5))
        'If IsoSettingsLib.Keys.Count = 0 Then
        '   NavigationService.Navigate(New Uri("/PageBlank.xaml", UriKind.RelativeOrAbsolute))
        'End If
        'NavigationService.GoBack()
        'NavigationService.RemoveBackEntry()

        'If IsoSettingsLib.Keys.Count = 2 Then
        '    InitFirstLaunch()
        '    With IsoSettingsLib
        '        .Add("ColorHP", ValueHP)
        '        .Add("ColorATK", ValueAttack)
        '        .Add("ColorDEF", ValueDefence)
        '        .Add("ColorSATK", ValueSpecialAttack)
        '        .Add("ColorSDEF", ValueSpecialDefence)
        '        .Add("ColorSPD", ValueSpeed)
        '        .Add("ColorTotal", ValueTotal)
        '    End With
        'End If
        'InitColors()
        InitColorStorage()

        'IsChineseNames = IsoSettingsLib.Item("IsCHS")
        'If IsChineseNames Then
        '    chkUseCHS.IsChecked = True
        'Else
        '    chkUseCHS.IsChecked = False
        'End If
        InitializeTileIndexServer()
    End Sub
    Private Sub imgMoves_Tap(sender As Object, e As GestureEventArgs) Handles imgMoves.Tap
        NavigationService.Navigate(New Uri("/PageMoves.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectMoves_Tap(sender As Object, e As GestureEventArgs) Handles rectMoves.Tap
        NavigationService.Navigate(New Uri("/PageMoves.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtMoves_Tap(sender As Object, e As GestureEventArgs) Handles txtMoves.Tap
        NavigationService.Navigate(New Uri("/PageMoves.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgItems_Tap(sender As Object, e As GestureEventArgs) Handles imgItems.Tap
        NavigationService.Navigate(New Uri("/PageItems.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtItems_Tap(sender As Object, e As GestureEventArgs) Handles txtItems.Tap
        NavigationService.Navigate(New Uri("/PageItems.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectItems_Tap(sender As Object, e As GestureEventArgs) Handles rectItems.Tap
        NavigationService.Navigate(New Uri("/PageItems.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub pitAbout_Tap(sender As Object, e As GestureEventArgs) Handles pitAbout.Tap
        SUICUNE = SUICUNE + 1
        If SUICUNE = -245 Then
            NavigationService.Navigate(New Uri("/PageAbout.xaml", UriKind.RelativeOrAbsolute))
            SUICUNE = 0
        End If
    End Sub

    Private Sub imgAbilities_Tap(sender As Object, e As GestureEventArgs) Handles imgAbilities.Tap
        NavigationService.Navigate(New Uri("/PageAbilities.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectAbilities_Tap(sender As Object, e As GestureEventArgs) Handles rectAbilities.Tap
        NavigationService.Navigate(New Uri("/PageAbilities.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtAbilities_Tap(sender As Object, e As GestureEventArgs) Handles txtAbilities.Tap
        NavigationService.Navigate(New Uri("/PageAbilities.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub Test_Tap(sender As Object, e As GestureEventArgs) Handles Test.Tap
        NavigationService.Navigate(New Uri("/PageCalculator.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectCalcBW_Tap(sender As Object, e As GestureEventArgs) Handles rectCalcBW.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorBW.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgCalcBW_Tap(sender As Object, e As GestureEventArgs) Handles imgCalcBW.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorBW.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtCalcBW_Tap(sender As Object, e As GestureEventArgs) Handles txtCalcBW.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorBW.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgCalcXY_Tap(sender As Object, e As GestureEventArgs) Handles imgCalcXY.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorXY.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectCalcXY_Tap(sender As Object, e As GestureEventArgs) Handles rectCalcXY.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorXY.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtCalcXY_Tap(sender As Object, e As GestureEventArgs) Handles txtCalcXY.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorXY.xaml", UriKind.RelativeOrAbsolute))
    End Sub
    Private Sub imgCalcSM_Tap(sender As Object, e As GestureEventArgs) Handles imgCalcSM.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorSM.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectCalcSM_Tap(sender As Object, e As GestureEventArgs) Handles rectCalcSM.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorSM.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtCalcSM_Tap(sender As Object, e As GestureEventArgs) Handles txtCalcSM.Tap
        NavigationService.Navigate(New Uri("/PageCalculatorSM.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgSettings_Tap(sender As Object, e As GestureEventArgs) Handles imgSettings.Tap
        NavigationService.Navigate(New Uri("/PivotPageSettings.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub rectSettings_Tap(sender As Object, e As GestureEventArgs) Handles rectSettings.Tap
        NavigationService.Navigate(New Uri("/PivotPageSettings.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtSettings_Tap(sender As Object, e As GestureEventArgs) Handles txtSettings.Tap
        NavigationService.Navigate(New Uri("/PivotPageSettings.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnMore_Tap(sender As Object, e As GestureEventArgs) Handles btnMore.Tap
        NavigationService.Navigate(New Uri("/PageAbout.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class