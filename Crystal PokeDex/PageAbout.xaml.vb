Partial Public Class PageAbout
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub lnkPrivacy_Tap(sender As Object, e As GestureEventArgs) Handles lnkPrivacy.Tap
        Dim BrowserInstance As Microsoft.Phone.Tasks.WebBrowserTask
        BrowserInstance = New Microsoft.Phone.Tasks.WebBrowserTask
        With BrowserInstance
            .Uri = New System.Uri("https://github.com/PC-DOS/privacy/wiki/")
            .Show()
        End With
    End Sub
End Class
