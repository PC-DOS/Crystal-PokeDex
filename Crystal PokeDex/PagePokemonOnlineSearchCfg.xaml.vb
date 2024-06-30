Partial Public Class PagePokemonOnlineSearchCfg
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rdCHTInformal_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTInformal.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHTInformal
    End Sub

    Private Sub rdCHTOfficial_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTOfficial.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHTOfficial
    End Sub

    Private Sub rdCHSInformal_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSInformal.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHSInformal
    End Sub

    Private Sub rdCHSOfficial_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSOfficial.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHSOfficial
    End Sub

    Private Sub rdENG_Tap(sender As Object, e As GestureEventArgs) Handles rdENG.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameENG
    End Sub

    Private Sub rdKOR_Tap(sender As Object, e As GestureEventArgs) Handles rdKOR.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameKOR
    End Sub
    Private Sub rdJPN_Tap(sender As Object, e As GestureEventArgs) Handles rdJPN.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameJPN
    End Sub

    Private Sub btnCancel_Tap(sender As Object, e As GestureEventArgs) Handles btnCancel.Tap
        NavigationService.GoBack()
    End Sub

    Private Sub btnSearch_Tap(sender As Object, e As GestureEventArgs) Handles btnSearch.Tap
        If rdCHTInformal.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHTInformal
        End If
        If rdCHTOfficial.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHTOfficial
        End If
        If rdCHSInformal.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHSInformal
        End If
        If rdCHSOfficial.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHSOfficial
        End If
        If rdENG.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameENG
        End If
        If rdJPN.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameJPN
        End If
        If rdKOR.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameKOR
        End If
        Dim PokemonSearchRequestHandler As Microsoft.Phone.Tasks.SearchTask
        PokemonSearchRequestHandler = New Microsoft.Phone.Tasks.SearchTask
        Select Case PokemonSearchRequest
            Case PokemonSearchRequestLanguages.PokemonNameCHSInformal
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameCHSInformal
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameCHTInformal
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameCHTInformal
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameENG
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameENG
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameKOR
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameKOR
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameJPN
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameJPN
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameCHSOfficial
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameCHSOfficial
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameCHTOfficial
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameCHTOfficial
                    .Show()
                End With
                NavigationService.GoBack()
            Case Else
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.NameCHTInformal
                    .Show()
                End With
                NavigationService.GoBack()
        End Select
    End Sub

    Private Sub PageSearchReq_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        SystemTray.IsVisible = False
    End Sub

End Class
