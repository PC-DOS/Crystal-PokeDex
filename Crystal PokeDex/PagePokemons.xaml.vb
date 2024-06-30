Imports Coding4Fun.Toolkit
Imports Coding4Fun.Toolkit.Controls
Imports Coding4Fun.Toolkit.Controls.InputPrompt
Imports System.Windows.Input
Imports Coding4Fun.Toolkit.Controls.UserPrompt
Partial Public Class PagePokemons
    Inherits PhoneApplicationPage

    Dim itemPokemons As New List(Of String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PagePokemons_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        lstPokemons.ItemsSource = CurrentPokemonTranslationForList
    End Sub

    Private Sub lstPokemons_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstPokemons.DoubleTap
        If lstPokemons.SelectedIndex < 0 Or lstPokemons.SelectedIndex > lstPokemons.Items.Count - 1 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstPokemons.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        PokemonInformationShared = GetPokemonInformation(CInt(strSel))
        If PokemonInformationShared.IsMissingNo Then
            Exit Sub
        End If
        NavigationService.Navigate(New System.Uri("/PagePokemonDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub lstPokemons_Tap(sender As Object, e As GestureEventArgs) Handles lstPokemons.Tap
        If lstPokemons.SelectedIndex < 0 Then
            Exit Sub
        End If
        'MessageBox.Show(Me.lstPokemons.SelectedItems.Item(0))
        Dim imgSelPkMn As Media.Imaging.BitmapImage
        imgSelPkMn = New Imaging.BitmapImage
        Dim strSel As String
        strSel = lstPokemons.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        imgSelPkMn.UriSource = New Uri("/Pokemons/" & strSel & ".png", UriKind.RelativeOrAbsolute)
        imgPokemon.Source = imgSelPkMn

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
            If (1 <= lpNumInt) And (lpNumInt <= lstPokemons.Items.Count) Then
                lstPokemons.SelectedIndex = lpNumInt - 1
                lstPokemons.ScrollIntoView(lstPokemons.SelectedItem)
                'MessageBox.Show(Me.lstPokemons.SelectedItems.Item(0))
                Dim imgSelPkMn As Media.Imaging.BitmapImage
                imgSelPkMn = New Imaging.BitmapImage
                Dim strSel As String
                strSel = lstPokemons.SelectedItems.Item(0).ToString
                strSel = strSel.Split(" ")(0)
                imgSelPkMn.UriSource = New Uri("/Pokemons/" & strSel & ".png", UriKind.RelativeOrAbsolute)
                imgPokemon.Source = imgSelPkMn
            Else
                MessageBox.Show("輸入的編號超出允許的範圍。", "錯誤", MessageBoxButton.OK)
                Exit Sub
            End If
        Else
            Exit Sub
        End If
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
            .Message = "請輸入您需要的神奇寶貝的全國圖鑑編號。" & vbCrLf & "範圍: 001-" & lstPokemons.Items.Count
            .InputScope = InputScopeNumber
            .Show()
        End With
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
            .Message = "請輸入您需要的神奇寶貝的全國圖鑑編號或者名稱的全部或者部分內容。"
            .Show()
        End With
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
            NavigationService.Navigate(New Uri("/PagePokemonSearch.xaml", UriKind.RelativeOrAbsolute))
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ApplicationBarMenuItem_Click(sender As Object, e As EventArgs)
        HTMLFilePath = "/Mega/Mega.htm"
        NavigationService.Navigate(New Uri("/Browser.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub ApplicationBarMenuItem_Click_1(sender As Object, e As EventArgs)
        HTMLFilePath = "/Mega/Mega-CHT.htm"
        NavigationService.Navigate(New Uri("/Browser.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub ApplicationBarMenuItem_Click_2(sender As Object, e As EventArgs)
        HTMLFilePath = "/Mega/Mega_ENG.htm"
        NavigationService.Navigate(New Uri("/Browser.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub ApplicationBarIconButton_Click_2(sender As Object, e As EventArgs)
        lstPokemons.SelectedIndex = 0
        Dim imgSelPkMn As Media.Imaging.BitmapImage
        imgSelPkMn = New Imaging.BitmapImage
        Dim strSel As String
        strSel = lstPokemons.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        imgSelPkMn.UriSource = New Uri("/Pokemons/" & strSel & ".png", UriKind.RelativeOrAbsolute)
        imgPokemon.Source = imgSelPkMn
    End Sub

    Private Sub ApplicationBarIconButton_Click_3(sender As Object, e As EventArgs)
        lstPokemons.SelectedIndex = lstPokemons.Items.Count - 1
        Dim imgSelPkMn As Media.Imaging.BitmapImage
        imgSelPkMn = New Imaging.BitmapImage
        Dim strSel As String
        strSel = lstPokemons.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        imgSelPkMn.UriSource = New Uri("/Pokemons/" & strSel & ".png", UriKind.RelativeOrAbsolute)
        imgPokemon.Source = imgSelPkMn
    End Sub

    Private Sub imgPokemon_Tap(sender As Object, e As GestureEventArgs) Handles imgPokemon.Tap
        If lstPokemons.SelectedIndex < 0 Or lstPokemons.SelectedIndex > lstPokemons.Items.Count - 1 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstPokemons.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        PokemonInformationShared = GetPokemonInformation(CInt(strSel))
        If PokemonInformationShared.IsMissingNo Then
            Exit Sub
        End If
        NavigationService.Navigate(New System.Uri("/PagePokemonDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
