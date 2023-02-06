Imports Coding4Fun.Toolkit.Controls

Partial Public Class PageItems
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ApplicationBarIconButton_Click_1(sender As Object, e As EventArgs)
        Dim InputBoxEx As InputPrompt
        InputBoxEx = New InputPrompt
        If 245 = 25 Then
            Dim InputScopeNumber As InputScope
            InputScopeNumber = New InputScope
            Dim InputScopeNumberName As InputScopeName
            InputScopeNumberName = New InputScopeName
            With InputScopeNumberName
                .NameValue = InputScopeNameValue.Search
            End With
            With InputScopeNumber
                .Names.Add(InputScopeNumberName)
            End With
        End If
        Dim InputScopeSearch As InputScope
        InputScopeSearch = New InputScope
        Dim InputScopeSearchName As InputScopeName
        InputScopeSearchName = New InputScopeName
        With InputScopeSearchName
            .NameValue = InputScopeNameValue.Search
        End With
        With InputScopeSearch
            .Names.Add(InputScopeSearchName)
        End With
        With InputBoxEx
            AddHandler .Completed, AddressOf SearchRequest_Completed
            .Title = "搜尋"
            .InputScope = InputScopeSearch
            .Message = "請輸入您需要的道具名稱的全部或者部分內容。"
            .Show()
        End With
    End Sub
    Sub InputPrompt_Completed(lpSender As Object, e As PopUpEventArgs(Of String, PopUpResult))
        If e.PopUpResult = PopUpResult.Ok Then
            Dim lpNum As String
            Dim lpNumInt As Long
            lpNum = e.Result
            lpNumInt = CLng(lpNum)
            If (1 <= lpNumInt) And (lpNumInt <= lstItems.SelectedIndex > lstItems.Items.Count) Then
                lstItems.SelectedIndex = lpNumInt - 1
                lstItems.ScrollIntoView(lstItems.SelectedItem)
            Else
                MessageBox.Show("輸入的編號超出允許的範圍。", "錯誤", MessageBoxButton.OK)
                Exit Sub
            End If
            'MessageBox.Show(Me.lstPokemons.SelectedItems.Item(0))
        Else
            Exit Sub
        End If
    End Sub
    Sub SearchRequest_Completed(lpSender As Object, e As PopUpEventArgs(Of String, PopUpResult))
        If e.PopUpResult = PopUpResult.Ok Then
            Dim lpIPBSearchRequest As String
            lpIPBSearchRequest = e.Result.Trim
            If lpIPBSearchRequest = "" Then
                MessageBox.Show("請不要嘗試搜尋空白內容或者純空白字符。", "錯誤", MessageBoxButton.OK)
                Exit Sub
            End If
            lpSearchRequest = lpIPBSearchRequest
            'NavigationService
            NavigationService.Navigate(New Uri("/PageItemSearch.xaml", UriKind.RelativeOrAbsolute))
        Else
            Exit Sub
        End If
    End Sub
    Private Sub PageItems_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        InitializeItemInformation()
        lstItems.ItemsSource = ItemList
    End Sub

    Private Sub lstItems_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstItems.DoubleTap
        If lstItems.SelectedIndex < 0 Or lstItems.SelectedIndex > lstItems.Items.Count - 1 Then
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
    End Sub
    Private Sub ApplicationBarIconButton_Click_2(sender As Object, e As EventArgs)
        lstItems.SelectedIndex = 0
    End Sub

    Private Sub ApplicationBarIconButton_Click_3(sender As Object, e As EventArgs)
        lstItems.SelectedIndex = lstItems.Items.Count - 1
    End Sub
End Class
