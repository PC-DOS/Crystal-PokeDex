Partial Public Class PageAbilityOnlineSearchCfg
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rdCHTInformal_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTInformal.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHTInformal
    End Sub

    Private Sub rdCHTOfficial_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTOfficial.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHTOfficial
    End Sub

    Private Sub rdCHSInformal_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSInformal.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHSInformal
    End Sub

    Private Sub rdCHSOfficial_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSOfficial.Tap
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHSOfficial
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
        If rdCHTInformal.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHTInformal
        End If
        If rdCHTOfficial.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHTOfficial
        End If
        If rdCHSInformal.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHSInformal
        End If
        If rdCHSOfficial.IsChecked Then
            AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHSOfficial
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
            Case AbilitySearchRequestLanguages.AbilityNameCHTInformal
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case AbilitySearchRequestLanguages.AbilityNameCHSInformal
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
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
            Case AbilitySearchRequestLanguages.AbilityNameCHSOfficial
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case AbilitySearchRequestLanguages.AbilityNameCHTOfficial
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
                    .Show()
                End With
            Case Else
                With AbilitySearchRequestHandler
                    .SearchQuery = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
                    .Show()
                End With
        End Select
        NavigationService.GoBack()
    End Sub

    Private Sub PageAbilityOnlineSearchCfg_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        SystemTray.IsVisible = False
        rdCHTInformal.IsChecked = False
        rdCHTOfficial.IsChecked = False
        rdCHSInformal.IsChecked = False
        rdCHSOfficial.IsChecked = False
        rdENG.IsChecked = False
        rdJPN.IsChecked = False
        rdCHTInformal.IsChecked = True
        AbilitySearchRequest = AbilitySearchRequestLanguages.AbilityNameCHTInformal
    End Sub
End Class
