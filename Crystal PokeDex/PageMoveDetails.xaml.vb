Partial Public Class MoveDetail
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MoveDetail_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        txtCHTInformal.Text = MoveNamesCHTInformal(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtClass.Text = MoveClasses.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
        txtHitrate.Text = MoveHitrate.Item(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtPower.Text = MovePower.Item(MoveSelectionNumber)
        txtPP.Text = MovePP.Item(MoveSelectionNumber)
        txtType.Text = MoveTypes.Item(MoveSelectionNumber)
        Dim MoveTypeData As SingleTypeRepresentativeColor = GetSingleTypeRepresentativeColor(MoveTypes.Item(MoveSelectionNumber))
        txtType1.Text = MoveTypes.Item(MoveSelectionNumber)
        gridType1.Background = New SolidColorBrush(Color.FromArgb(255, MoveTypeData.Red, MoveTypeData.Green, MoveTypeData.Blue))
        pivData.Title = CurrentMoves.Item(MoveSelectionNumber)
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/PageMoveOnlineSearchCfg.xaml", UriKind.RelativeOrAbsolute))
    End Sub
    Private Sub txtDescription_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.GotFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.Black)
    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtDescription_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.LostFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.White)
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtDescription.TextChanged
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
        txtCHTInformal.Text = MoveNamesCHTInformal.Item(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
    End Sub

    Private Sub txtDescription_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInput
        e.Handled = True
    End Sub

    Private Sub txtDescription_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSOfficial.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSOfficial.TextChanged
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
        txtCHTInformal.Text = MoveNamesCHTInformal.Item(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
    End Sub

    Private Sub txtCHSOfficial_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSOfficial.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSOfficial.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHTOfficial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTOfficial.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTOfficial_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTOfficial.TextChanged
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
        txtCHTInformal.Text = MoveNamesCHTInformal.Item(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
    End Sub

    Private Sub txtCHTOfficial_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTOfficial.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTOfficial_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTOfficial.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSInformal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSInformal.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSInformal_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSInformal.TextChanged
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
        txtCHTInformal.Text = MoveNamesCHTInformal.Item(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
    End Sub

    Private Sub txtCHSInformal_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSInformal.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSInformal_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSInformal.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHTInformal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTInformal.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTInformal_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTInformal.TextChanged
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
        txtCHTInformal.Text = MoveNamesCHTInformal.Item(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
    End Sub

    Private Sub txtCHTInformal_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTInformal.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTInformal_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTInformal.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtENU_KeyDown(sender As Object, e As KeyEventArgs) Handles txtENU.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtENU_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtENU.TextChanged
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
        txtCHTInformal.Text = MoveNamesCHTInformal.Item(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
    End Sub

    Private Sub txtENU_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInput
        e.Handled = True
    End Sub

    Private Sub txtENU_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtJPN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJPN.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtJPN.TextChanged
        txtDescription.Text = MoveDescription.Item(MoveSelectionNumber)
        txtCHTInformal.Text = MoveNamesCHTInformal.Item(MoveSelectionNumber)
        txtCHSInformal.Text = MoveNamesCHSInformal(MoveSelectionNumber)
        txtCHSOfficial.Text = MoveNamesCHSOfficial(MoveSelectionNumber)
        txtCHTOfficial.Text = MoveNamesCHTOfficial(MoveSelectionNumber)
        txtJPN.Text = MoveNamesJPN.Item(MoveSelectionNumber)
        txtENU.Text = MoveNamesENG.Item(MoveSelectionNumber)
    End Sub

    Private Sub txtJPN_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInput
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInputStart
        e.Handled = True
    End Sub
End Class
