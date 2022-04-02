Imports Coding4Fun.Toolkit.Controls

Partial Public Class PageAblities
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ApplicationBarIconButton_Click_1(sender As Object, e As EventArgs)
        Dim InputBoxEx As InputPrompt
        InputBoxEx = New InputPrompt
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
            .Message = "請輸入您需要的特性名稱的全部或者部分內容。"
            .Show()
        End With
    End Sub
    Sub InputPrompt_Completed(lpSender As Object, e As PopUpEventArgs(Of String, PopUpResult))
        If e.PopUpResult = PopUpResult.Ok Then
            Dim lpNum As String
            Dim lpNumInt As Long
            lpNum = e.Result
            If IsNumber(lpNum) = 0 Then
                MessageBox.Show("請輸入有效的數值。", "錯誤", MessageBoxButton.OK)
                Exit Sub
            End If
            lpNumInt = CLng(lpNum)
            If (1 <= lpNumInt) And (lpNumInt <= lstAbilities.Items.Count) Then
                lstAbilities.SelectedIndex = lpNumInt - 1
                lstAbilities.ScrollIntoView(lstAbilities.SelectedItem)
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
            NavigationService.Navigate(New Uri("/PageAbilitySearch.xaml", UriKind.RelativeOrAbsolute))
        Else
            Exit Sub
        End If
    End Sub
    Private Sub PageAblities_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Select Case UIAbilityChineseDisplayConfig
            Case ChineseDisplayConfig.DefaultConfig
                lstAbilities.ItemsSource = ListAbilityOfficialCHT
            Case ChineseDisplayConfig.InformalChineseSimplified
                lstAbilities.ItemsSource = ListAbilityInformalCHS
            Case ChineseDisplayConfig.InformalChineseTraditional
                lstAbilities.ItemsSource = ListAbilityInformalCHT
            Case ChineseDisplayConfig.OfficialChineseSimplified
                lstAbilities.ItemsSource = ListAbilityOfficialCHS
            Case ChineseDisplayConfig.OfficialChineseTraditional
                lstAbilities.ItemsSource = ListAbilityOfficialCHT
        End Select
    End Sub
    Private Sub ApplicationBarIconButton_Click_2(sender As Object, e As EventArgs)
        lstAbilities.SelectedIndex = 0
    End Sub

    Private Sub ApplicationBarIconButton_Click_3(sender As Object, e As EventArgs)
        lstAbilities.SelectedIndex = lstAbilities.Items.Count - 1
    End Sub

    Private Sub lstAbilities_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstAbilities.DoubleTap
        If lstAbilities.SelectedIndex < 0 Then
            Exit Sub
        End If
        If lstAbilities.SelectedIndex < 0 Or lstAbilities.SelectedIndex > lstAbilities.Items.Count - 1 Then
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

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim InputBoxEx As InputPrompt
        InputBoxEx = New InputPrompt
        Dim InputScopeNumber As InputScope
        InputScopeNumber = New InputScope
        Dim InputScopeNumberName As InputScopeName
        InputScopeNumberName = New InputScopeName
        With InputScopeNumberName
            .NameValue = InputScopeNameValue.Number
        End With
        With InputScopeNumber
            .Names.Add(InputScopeNumberName)
        End With
        With InputBoxEx
            AddHandler .Completed, AddressOf InputPrompt_Completed
            .Title = "定位到編號"
            .Message = "請輸入您需要的特性的編號。" & vbCrLf & "範圍: 001-" & lstAbilities.Items.Count
            .InputScope = InputScopeNumber
            .Show()
        End With
    End Sub
End Class
