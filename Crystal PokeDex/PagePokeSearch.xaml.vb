﻿Partial Public Class PagePokeSearch
    Inherits PhoneApplicationPage
    Dim itemPokemons As New List(Of String)

    Public Sub New()
        itemPokemons.Clear()
        itemPokemons = CurrentTranslationForList
        InitializeComponent()
    End Sub

    Private Sub PagePokeSearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstPokemons.ItemsSource = itemPokemons
        Else
            lstPokemons.ItemsSource = (From x In itemPokemons Where x.Contains(lpSearchRequest) Select x).ToArray()
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
        imgSelPkMn.UriSource = New Uri("/PokemonsL/" & strSel & ".png", UriKind.RelativeOrAbsolute)
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
