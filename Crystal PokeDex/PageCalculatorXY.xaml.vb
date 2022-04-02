Partial Public Class PageCalcXY
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageCalculator_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = True
            .Text = "正在載入網頁..."
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
        webCalc.Navigate(New Uri("/CalculatorXY/CalculatorXY.htm", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub webCalc_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles webCalc.LoadCompleted
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = False
            .Text = "正在載入網頁..."
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
    End Sub

    Private Sub webCalc_NavigationFailed(sender As Object, e As NavigationFailedEventArgs) Handles webCalc.NavigationFailed
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = False
            .Text = "正在載入網頁..."
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim trayProgress As ProgressIndicator
        trayProgress = New ProgressIndicator
        With trayProgress
            .IsIndeterminate = True
            .IsVisible = True
            .Text = "正在載入網頁..."
        End With
        SystemTray.SetProgressIndicator(Me, trayProgress)
        webCalc.Navigate(New Uri("/CalculatorXY/CalculatorXY.htm", UriKind.RelativeOrAbsolute))
    End Sub
End Class
