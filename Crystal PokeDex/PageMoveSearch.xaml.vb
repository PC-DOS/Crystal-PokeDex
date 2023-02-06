Partial Public Class PageMoveSearch
    Inherits PhoneApplicationPage
    Dim ResultList As New List(Of String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageMoveSearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ResultList.Clear()
        gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstMoves.ItemsSource = CurrentMovesList
        Else
            'lstMoves.ItemsSource = (From x In CurrentMovesList Where x.Contains(lpSearchRequest) Select x).ToArray()
            Dim i As Integer
            'Search Chinese, English, Japanese
            For i = 0 To CurrentAbilityList.Count - 1
                If MoveNamesInformalCHT(i).Contains(lpSearchRequest) Or _
                    MoveNamesOfficialCHT(i).Contains(lpSearchRequest) Or _
                    MoveNamesInformalCHS(i).Contains(lpSearchRequest) Or _
                    MoveNamesOfficialCHS(i).Contains(lpSearchRequest) Or _
                    MoveNamesENG(i).ToUpper().Contains(lpSearchRequest.ToUpper()) Or _
                    MoveNamesJPN(i).Contains(lpSearchRequest) Or _
                    CurrentMovesList(i).Contains(lpSearchRequest) Then
                    ResultList.Add(CurrentMovesList(i))
                End If
            Next
            lstMoves.ItemsSource = ResultList
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
