Partial Public Class PageBlank
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageBlank_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        NavigationService.GoBack()
    End Sub
End Class
