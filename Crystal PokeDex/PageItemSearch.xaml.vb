Partial Public Class PageItemSearch
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageItemSearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstItems.ItemsSource = ItemList
        Else
            lstItems.ItemsSource = (From x In ItemList Where x.Contains(lpSearchRequest) Select x).ToArray()
        End If
        If lstItems.Items.Count = 0 Then
            gridNoResult.Visibility = System.Windows.Visibility.Visible
        Else
            gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub lstItems_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstItems.DoubleTap
        If lstItems.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstItems.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        lpSelectedItemNumber = strSel
        NavigationService.Navigate(New Uri("/PageItemDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub lstItems_Tap(sender As Object, e As GestureEventArgs) Handles lstItems.Tap
        If lstItems.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstItems.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        lpSelectedItemNumber = CLng(strSel) - 1
    End Sub

End Class
