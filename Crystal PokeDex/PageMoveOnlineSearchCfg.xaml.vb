Partial Public Class PageMoveOnlineSaerchCfg
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rdCHT_Tap(sender As Object, e As GestureEventArgs) Handles rdCHT.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHT
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
        If rdCHT.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHT
        End If
        If rdENG.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameENG
        End If
        If rdJPN.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameJPN
        End If
        If rdCHSO.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHSO
        End If
        If rdCHS.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHS
        End If
        If rdCHTO.IsChecked Then
            MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHTO
        End If
        Dim MoveSearchHandler As Microsoft.Phone.Tasks.SearchTask
        MoveSearchHandler = New Microsoft.Phone.Tasks.SearchTask
        Select Case MoveSearchRequest
            Case MoveSearchRequestLanguages.MoveNameCHT
                With MoveSearchHandler
                    .SearchQuery = MoveNamesInformalCHT.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case MoveSearchRequestLanguages.MoveNameCHS
                With MoveSearchHandler
                    .SearchQuery = MoveNamesInformalCHS.Item(MoveSelectionNumber)
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
            Case MoveSearchRequestLanguages.MoveNameCHSO
                With MoveSearchHandler
                    .SearchQuery = MoveNamesOfficialCHS.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case MoveSearchRequestLanguages.MoveNameCHTO
                With MoveSearchHandler
                    .SearchQuery = MoveNamesOfficialCHT.Item(MoveSelectionNumber)
                    .Show()
                End With
            Case Else
                With MoveSearchHandler
                    .SearchQuery = MoveNamesInformalCHT.Item(MoveSelectionNumber)
                    .Show()
                End With
        End Select
        NavigationService.GoBack()
    End Sub

    Private Sub PageMoveOnlineSaerchCfg_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        SystemTray.IsVisible = False
        rdCHS.IsChecked = False
        rdCHSO.IsChecked = False
        rdCHT.IsChecked = False
        rdCHTO.IsChecked = False
        rdENG.IsChecked = False
        rdJPN.IsChecked = False
        rdCHT.IsChecked = True
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHT
    End Sub

    Private Sub rdCHS_Tap(sender As Object, e As GestureEventArgs) Handles rdCHS.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHS
    End Sub

    Private Sub rdCHSO_Tap(sender As Object, e As GestureEventArgs) Handles rdCHSO.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHSO
    End Sub

    Private Sub rdCHTO_Tap(sender As Object, e As GestureEventArgs) Handles rdCHTO.Tap
        MoveSearchRequest = MoveSearchRequestLanguages.MoveNameCHTO
    End Sub
End Class
