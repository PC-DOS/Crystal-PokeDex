Partial Public Class PageMoveOnlineSaerchCfg
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rdCHTInformal_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTInformal.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHTInformal
    End Sub

    Private Sub rdCHTOfficial_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTOfficial.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHTOfficial
    End Sub

    Private Sub rdCHSInformal_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSInformal.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHSInformal
    End Sub

    Private Sub rdCHSOfficial_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSOfficial.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHSOfficial
    End Sub

    Private Sub rdENG_Tap(sender As Object, e As GestureEventArgs) Handles rdENG.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameENG
    End Sub

    Private Sub rdJPN_Tap(sender As Object, e As GestureEventArgs) Handles rdJPN.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameJPN
    End Sub

    Private Sub btnCancel_Tap(sender As Object, e As GestureEventArgs) Handles btnCancel.Tap
        NavigationService.GoBack()
    End Sub

    Private Sub btnSearch_Tap(sender As Object, e As GestureEventArgs) Handles btnSearch.Tap
        If rdCHTInformal.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHTInformal
        End If
        If rdCHTOfficial.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHTOfficial
        End If
        If rdCHSInformal.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHSInformal
        End If
        If rdCHSOfficial.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHSOfficial
        End If
        If rdENG.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameENG
        End If
        If rdJPN.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameJPN
        End If
        Dim MoveSearchHandler As Microsoft.Phone.Tasks.SearchTask
        MoveSearchHandler = New Microsoft.Phone.Tasks.SearchTask
        Select Case MoveSearchRequest
            Case MoveSearchRequestLanguages.MoveNameCHTInformal
                With MoveSearchHandler
                    .SearchQuery = MoveNamesCHTInformal.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case MoveSearchRequestLanguages.MoveNameCHSInformal
                With MoveSearchHandler
                    .SearchQuery = MoveNamesCHSInformal.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case MoveSearchRequestLanguages.MoveNameENG
                With MoveSearchHandler
                    .SearchQuery = MoveNamesENG.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case MoveSearchRequestLanguages.MoveNameJPN
                With MoveSearchHandler
                    .SearchQuery = MoveNamesJPN.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case MoveSearchRequestLanguages.MoveNameCHSOfficial
                With MoveSearchHandler
                    .SearchQuery = MoveNamesCHSOfficial.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case MoveSearchRequestLanguages.MoveNameCHTOfficial
                With MoveSearchHandler
                    .SearchQuery = MoveNamesCHTOfficial.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case Else
                With MoveSearchHandler
                    .SearchQuery = MoveNamesCHTInformal.Item(MoveSelectionNumber)
                    .Show()
                End With
        End Select
        NavigationService.GoBack()
    End Sub

    Private Sub PageMoveOnlineSaerchCfg_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        SystemTray.IsVisible = False
        rdCHTInformal.IsChecked = False
        rdCHTOfficial.IsChecked = False
        rdCHSInformal.IsChecked = False
        rdCHSOfficial.IsChecked = False
        rdENG.IsChecked = False
        rdJPN.IsChecked = False
        rdCHTInformal.IsChecked = True
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHTInformal
    End Sub
End Class
