Partial Public Class PageAbilityDetails
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageAbilityDetails_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'InitializeAbilities()
        txtName.Text = CurrentAbility.Item(AbilitySelectionNumber - 1)
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
        pivData.Title = txtName.Text
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
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtDescription_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInput
        e.Handled = True
    End Sub

    Private Sub txtDescription_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHTInformal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTInformal.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTInformal_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTInformal.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtCHTInformal_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTInformal.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTInformal_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTInformal.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtJPN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJPN.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtJPN.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtJPN_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInput
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtENU_KeyDown(sender As Object, e As KeyEventArgs) Handles txtENU.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtENU_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtENU.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtENU_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInput
        e.Handled = True
    End Sub

    Private Sub txtENU_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInputStart
        e.Handled = True
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/PageAbilityOnlineSearchCfg.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub txtCHSOfficial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSOfficial.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSOfficial.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtCHSOfficial_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSOfficial.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSOfficial.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_TextInputUpdate(sender As Object, e As TextCompositionEventArgs) Handles txtCHSOfficial.TextInputUpdate
        e.Handled = True
    End Sub

    Private Sub txtCHTOfficial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTOfficial.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTOfficial_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTOfficial.TextChanged
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
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
        txtDescription.Text = AbilityDescriptions.Item(AbilitySelectionNumber - 1)
        txtCHTInformal.Text = AbilityNamesCHTInformal(AbilitySelectionNumber - 1)
        txtCHTOfficial.Text = AbilityNamesCHTOfficial(AbilitySelectionNumber - 1)
        txtCHSInformal.Text = AbilityNamesCHSInformal(AbilitySelectionNumber - 1)
        txtCHSOfficial.Text = AbilityNamesCHSOfficial(AbilitySelectionNumber - 1)
        txtENU.Text = AbilityNamesENG(AbilitySelectionNumber - 1)
        txtJPN.Text = AbilityNamesJPN(AbilitySelectionNumber - 1)
    End Sub

    Private Sub txtCHSInformal_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSInformal.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSInformal_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSInformal.TextInputStart
        e.Handled = True
    End Sub
End Class
