Partial Public Class PageTileLauncher
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageTileLauncher_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        IsLaunchedFromPinned = True
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
