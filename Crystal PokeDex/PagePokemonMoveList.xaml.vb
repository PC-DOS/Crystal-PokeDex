Partial Public Class PagePokemonMoveList
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub lstPokemonMoves_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstPokemonMoves.DoubleTap
        If lstPokemonMoves.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstPokemonMoves.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        MoveSelectionNumber = CLng(strSel) - 1
        NavigationService.Navigate(New Uri("/PageMoveDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub lstPokemonMoves_Tap(sender As Object, e As GestureEventArgs) Handles lstPokemonMoves.Tap
        If lstPokemonMoves.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstPokemonMoves.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        MoveSelectionNumber = CLng(strSel) - 1
    End Sub

    Private Sub PagePokemonMoveList_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        GeneratePokemonMovesNameListFormID()
        lstPokemonMoves.ItemsSource = PokemonMovesCanLearnName
        lblName.Text = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.DexIDNumber) - 1)
    End Sub
End Class
