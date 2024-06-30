Partial Public Class PageAbilitiySearch
    Inherits PhoneApplicationPage
    Dim ResultList As New List(Of String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageAbilitiySearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ResultList.Clear()
        gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstAbilities.ItemsSource = CurrentAbilityList
        Else
            'lstAbilities.ItemsSource = (From x In CurrentAbilityList Where x.Contains(lpSearchRequest) Select x).ToArray()
            Dim i As Integer
            'Search Chinese, English, Japanese
            For i = 0 To CurrentAbilityList.Count - 1
                If AbilityNamesCHTInformal(i).Contains(lpSearchRequest) Or _
                    AbilityNamesCHTOfficial(i).Contains(lpSearchRequest) Or _
                    AbilityNamesCHSInformal(i).Contains(lpSearchRequest) Or _
                    AbilityNamesCHSOfficial(i).Contains(lpSearchRequest) Or _
                    AbilityNamesENG(i).ToUpper().Contains(lpSearchRequest.ToUpper()) Or _
                    AbilityNamesJPN(i).Contains(lpSearchRequest) Or _
                    CurrentAbilityList(i).Contains(lpSearchRequest) Then
                    ResultList.Add(CurrentAbilityList(i))
                End If
            Next
            lstAbilities.ItemsSource = ResultList
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
