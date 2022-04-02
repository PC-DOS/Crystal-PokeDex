Partial Public Class Browser
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Browser_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = True
            .Text = "正在載入網頁"
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
        webBrowser1.Navigate(New Uri(lpHTMFilePath, UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub webBrowser1_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles webBrowser1.LoadCompleted
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = False
            .Text = "正在載入網頁"
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
    End Sub

    Private Sub webBrowser1_NavigationFailed(sender As Object, e As NavigationFailedEventArgs) Handles webBrowser1.NavigationFailed
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = False
            .Text = "正在載入網頁"
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = True
            .Text = "正在載入網頁"
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
        webBrowser1.Navigate(New Uri(lpHTMFilePath, UriKind.RelativeOrAbsolute))
    End Sub
End Class
