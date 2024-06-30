Partial Public Class PageTileLauncher
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageTileLauncher_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        IsLaunchedFromPinned = True
        InitializeTileIndexServer()
        Dim PokemonID As Integer
        Dim PokemonIDString As String
        PokemonIDString = ""
        PokemonID = 0
        If NavigationContext.QueryString.Keys.Contains("PokemonID") Then
            NavigationContext.QueryString.TryGetValue("PokemonID", PokemonIDString)
        End If
        PokemonID = CInt(PokemonIDString)
        PokemonInformationShared = GetPokemonInformation(PokemonID)
        NavigationService.Navigate(New System.Uri("/PagePokemonDetails.xaml", UriKind.RelativeOrAbsolute))
        'MessageBox.Show(PokemonIDString)
    End Sub
End Class
