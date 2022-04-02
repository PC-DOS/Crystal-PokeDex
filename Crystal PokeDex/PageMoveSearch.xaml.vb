Partial Public Class PageMoveSearch
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageMoveSearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstMoves.ItemsSource = CurrentMovesList
        Else
            lstMoves.ItemsSource = (From x In CurrentMovesList Where x.Contains(lpSearchRequest) Select x).ToArray()
        End If
        If lstMoves.Items.Count = 0 Then
            gridNoResult.Visibility = System.Windows.Visibility.Visible
        Else
            gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub lstMoves_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstMoves.DoubleTap
        If lstMoves.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstMoves.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        MoveSelectionNumber = CLng(strSel) - 1
        NavigationService.Navigate(New Uri("/PageMoveDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub lstMoves_Tap(sender As Object, e As GestureEventArgs) Handles lstMoves.Tap
        If lstMoves.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstMoves.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        MoveSelectionNumber = CLng(strSel) - 1
        'MoveSelectionNumber = Convert.ToInt64((lstMoves.SelectedItems.Item(0).ToString))
    End Sub
End Class
