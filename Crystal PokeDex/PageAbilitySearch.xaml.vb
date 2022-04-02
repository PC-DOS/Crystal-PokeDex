Partial Public Class PageAbilitiySearch
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageAbilitiySearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstAbilities.ItemsSource = CurrentAbilityList
        Else
            lstAbilities.ItemsSource = (From x In CurrentAbilityList Where x.Contains(lpSearchRequest) Select x).ToArray()
        End If
        If lstAbilities.Items.Count = 0 Then
            gridNoResult.Visibility = System.Windows.Visibility.Visible
        Else
            gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub lstAbilities_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstAbilities.DoubleTap
        If lstAbilities.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstAbilities.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        AbilitySelectionNumber = strSel
        NavigationService.Navigate(New Uri("/PageAbilityDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub lstAbilities_Tap(sender As Object, e As GestureEventArgs) Handles lstAbilities.Tap
        If lstAbilities.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstAbilities.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
    End Sub
End Class
