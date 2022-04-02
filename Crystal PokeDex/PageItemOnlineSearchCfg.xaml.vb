Partial Public Class PageItemOnlineSearchCfg
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageItemOnlineSearchCfg_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        SystemTray.IsVisible = False
    End Sub

    Private Sub rdCHT_Tap(sender As Object, e As GestureEventArgs) Handles rdCHT.Tap
        ItemSearchRequest = ItemSearchRequestLanguages.ItemNameCHT
    End Sub

    Private Sub rdENG_Tap(sender As Object, e As GestureEventArgs) Handles rdENG.Tap
        ItemSearchRequest = ItemSearchRequestLanguages.ItemNameENG
    End Sub

    Private Sub rdJPN_Tap(sender As Object, e As GestureEventArgs) Handles rdJPN.Tap
        ItemSearchRequest = ItemSearchRequestLanguages.ItemNameJPN
    End Sub

    Private Sub btnCancel_Tap(sender As Object, e As GestureEventArgs) Handles btnCancel.Tap
        NavigationService.GoBack()
    End Sub

    Private Sub btnSearch_Tap(sender As Object, e As GestureEventArgs) Handles btnSearch.Tap
        If rdCHT.IsChecked Then
            ItemSearchRequest = ItemSearchRequestLanguages.ItemNameCHT
        End If
        If rdENG.IsChecked Then
            ItemSearchRequest = ItemSearchRequestLanguages.ItemNameENG
        End If
        If rdJPN.IsChecked Then
            ItemSearchRequest = ItemSearchRequestLanguages.ItemNameJPN
        End If
        Dim ItemSearchRequestHandler As Microsoft.Phone.Tasks.SearchTask
        ItemSearchRequestHandler = New Microsoft.Phone.Tasks.SearchTask
        Select Case ItemSearchRequest
            Case ItemSearchRequestLanguages.ItemNameCHT
                With ItemSearchRequestHandler
                    .SearchQuery = ItemNamesCHT(lpSelectedItemNumber - 1)
                    .Show()
                End With
            Case ItemSearchRequestLanguages.ItemNameENG
                With ItemSearchRequestHandler
                    .SearchQuery = ItemNamesENG(lpSelectedItemNumber - 1)
                    .Show()
                End With
            Case ItemSearchRequestLanguages.ItemNameJPN
                With ItemSearchRequestHandler
                    .SearchQuery = ItemNamesJPN(lpSelectedItemNumber - 1)
                    .Show()
                End With
            Case Else
                With ItemSearchRequestHandler
                    .SearchQuery = ItemNamesCHT(lpSelectedItemNumber - 1)
                    .Show()
                End With
        End Select
        NavigationService.GoBack()
    End Sub
End Class
