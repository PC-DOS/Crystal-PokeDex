Partial Public Class PagePokemonSearch
    Inherits PhoneApplicationPage
    Dim ResultList As New List(Of String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PagePokeSearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ResultList.Clear()
        gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstPokemons.ItemsSource = CurrentPokemonTranslationForList
        Else
            'lstPokemons.ItemsSource = (From x In ResultList Where x.Contains(lpSearchRequest) Select x).ToArray()
            Dim i As Integer
            'Search Chinese, English, Japanese or Korean
            InitPokemonNameList()
            For i = 0 To CurrentPokemonTranslationForList.Count - 1
                If PokemonNamesCHT(i).Contains(lpSearchRequest) Or _
                    PokemonNamesCHTO(i).Contains(lpSearchRequest) Or _
                    PokemonNamesCHS(i).Contains(lpSearchRequest) Or _
                    PokemonNamesCHSO(i).Contains(lpSearchRequest) Or _
                    PokemonNamesENG(i).ToUpper().Contains(lpSearchRequest.ToUpper()) Or _
                    PokemonNamesFRA(i).ToUpper().Contains(lpSearchRequest.ToUpper()) Or _
                    PokemonNamesGER(i).ToUpper().Contains(lpSearchRequest.ToUpper()) Or _
                    PokemonNamesJPN(i).Contains(lpSearchRequest) Or _
                    PokemonNamesKOR(i).Contains(lpSearchRequest) Or _
                    CurrentPokemonTranslationForList(i).Contains(lpSearchRequest) Then
                    ResultList.Add(CurrentPokemonTranslationForList(i))
                End If
            Next
            lstPokemons.ItemsSource = ResultList
        End If
        If lstPokemons.Items.Count = 0 Then
            gridNoResult.Visibility = System.Windows.Visibility.Visible
        Else
            gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub lstPokemons_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstPokemons.DoubleTap
        If lstPokemons.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstPokemons.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        PokemonInformationShared = GetPokemonInformation(CInt(strSel))
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

    Private Sub imgPokemon_Tap(sender As Object, e As GestureEventArgs) Handles imgPokemon.Tap
        If lstPokemons.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstPokemons.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        PokemonInformationShared = GetPokemonInformation(CInt(strSel))
        NavigationService.Navigate(New System.Uri("/PagePokemonDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
