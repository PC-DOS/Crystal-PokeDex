Partial Public Class PageAbilityOnlineSearchCfg
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rdCHT_Tap(sender As Object, e As GestureEventArgs) Handles rdCHT.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHT
    End Sub

    Private Sub rdENG_Tap(sender As Object, e As GestureEventArgs) Handles rdENG.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameENG
    End Sub

    Private Sub rdJPN_Tap(sender As Object, e As GestureEventArgs) Handles rdJPN.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameJPN
    End Sub

    Private Sub btnCancel_Tap(sender As Object, e As GestureEventArgs) Handles btnCancel.Tap
        NavigationService.GoBack()
    End Sub

    Private Sub btnSearch_Tap(sender As Object, e As GestureEventArgs) Handles btnSearch.Tap
        If rdCHT.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHT
        End If
        If rdCHTO.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHTO
        End If
        If rdCHS.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHS
        End If
        If rdCHSO.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHSO
        End If
        If rdENG.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameENG
        End If
        If rdJPN.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameJPN
        End If
        Dim AbilitySearchRequestHandler As Microsoft.Phone.Tasks.SearchTask
        AbilitySearchRequestHandler = New Microsoft.Phone.Tasks.SearchTask
        Select Case AbilitySearchRequest
            Case AbilitySearchRequestLanguages.AbilityNameCHT
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesInformalCHT(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case AbilitySearchRequestLanguages.AbilityNameCHS
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesInformalCHS(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case AbilitySearchRequestLanguages.AbilityNameENG
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesENG(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case AbilitySearchRequestLanguages.AbilityNameJPN
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesJPN(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case AbilitySearchRequestLanguages.AbilityNameCHSO
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesOfficialCHS(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case AbilitySearchRequestLanguages.AbilityNameCHTO
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesOfficialCHT(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case Else
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesInformalCHT(AbilitySelectionNumber - 1)
                    .Show()
                End With
        End Select
        NavigationService.GoBack()
    End Sub

    Private Sub rdCHS_Tap(sender As Object, e As GestureEventArgs) Handles rdCHS.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHS
    End Sub

    Private Sub rdCHSO_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSO.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHSO
    End Sub

    Private Sub rdCHTO_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTO.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHTO
    End Sub

    Private Sub PageAbilityOnlineSearchCfg_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        SystemTray.IsVisible = False
        rdCHS.IsChecked = False
        rdCHSO.IsChecked = False
        rdCHT.IsChecked = False
        rdCHTO.IsChecked = False
        rdENG.IsChecked = False
        rdJPN.IsChecked = False
        rdCHT.IsChecked = True
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHT
    End Sub
End Class
