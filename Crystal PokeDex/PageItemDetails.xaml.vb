Partial Public Class PageItemDetails
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageItemDetails_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        InitializeItemInformation()
        txtName.Text = ItemNamesCHT.Item(lpSelectedItemNumber - 1)
        txtDescription.Text = ItemDescriptions.Item(lpSelectedItemNumber - 1)
        txtROC.Text = ItemNamesCHT(lpSelectedItemNumber - 1)
        txtENU.Text = ItemNamesENG(lpSelectedItemNumber - 1)
        txtJPN.Text = ItemNamesJPN(lpSelectedItemNumber - 1)
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
        txtDescription.Text = ItemDescriptions.Item(lpSelectedItemNumber - 1)
        txtROC.Text = ItemNamesCHT(lpSelectedItemNumber - 1)
        txtENU.Text = ItemNamesENG(lpSelectedItemNumber - 1)
        txtJPN.Text = ItemNamesJPN(lpSelectedItemNumber - 1)
    End Sub

    Private Sub txtDescription_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInput
        e.Handled = True
    End Sub

    Private Sub txtDescription_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtROC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtROC.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtROC_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtROC.TextChanged
        txtDescription.Text = ItemDescriptions.Item(lpSelectedItemNumber - 1)
        txtROC.Text = ItemNamesCHT(lpSelectedItemNumber - 1)
        txtENU.Text = ItemNamesENG(lpSelectedItemNumber - 1)
        txtJPN.Text = ItemNamesJPN(lpSelectedItemNumber - 1)
    End Sub

    Private Sub txtROC_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInput
        e.Handled = True
    End Sub

    Private Sub txtROC_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtJPN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJPN.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtJPN.TextChanged
        txtDescription.Text = ItemDescriptions.Item(lpSelectedItemNumber - 1)
        txtROC.Text = ItemNamesCHT(lpSelectedItemNumber - 1)
        txtENU.Text = ItemNamesENG(lpSelectedItemNumber - 1)
        txtJPN.Text = ItemNamesJPN(lpSelectedItemNumber - 1)
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
        txtDescription.Text = ItemDescriptions.Item(lpSelectedItemNumber - 1)
        txtROC.Text = ItemNamesCHT(lpSelectedItemNumber - 1)
        txtENU.Text = ItemNamesENG(lpSelectedItemNumber - 1)
        txtJPN.Text = ItemNamesJPN(lpSelectedItemNumber - 1)
    End Sub

    Private Sub txtENU_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInput
        e.Handled = True
    End Sub

    Private Sub txtENU_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtENU.TextInputStart
        e.Handled = True
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/PageItemOnlineSearchCfg.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
