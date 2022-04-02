Partial Public Class PageSearchReq
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rdCHS_Tap(sender As Object, e As GestureEventArgs) Handles rdCHS.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHS
    End Sub

    Private Sub rdCHT_Tap(sender As Object, e As GestureEventArgs) Handles rdCHT.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHT
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
        If rdCHS.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHS
        End If
        If rdCHT.IsChecked Then
            PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHT
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
            Case PokemonSearchRequestLanguages.PokemonNameCHS
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameCHS
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameCHT
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameCHT
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameENG
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameENG
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameKOR
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameKOR
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameJPN
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameJPN
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameCHSO
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameCHSO
                    .Show()
                End With
                NavigationService.GoBack()
            Case PokemonSearchRequestLanguages.PokemonNameCHTO
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameCHTO
                    .Show()
                End With
                NavigationService.GoBack()
            Case Else
                With PokemonSearchRequestHandler
                    .SearchQuery = PokemonInformationShared.lpNameCHT
                    .Show()
                End With
                NavigationService.GoBack()
        End Select
    End Sub

    Private Sub PageSearchReq_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        SystemTray.IsVisible = False
    End Sub

    Private Sub rdCHSO_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSO.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHSO
    End Sub

    Private Sub rdCHTO_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTO.Tap
        PokemonSearchRequest = PokemonSearchRequestLanguages.PokemonNameCHTO
    End Sub
End Class
