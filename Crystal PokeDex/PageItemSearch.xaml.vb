Partial Public Class PageItemSearch
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PageItemSearch_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim ItemItems As New List(Of String)
        With ItemItems
            .Clear()
            .Add("001     除蟲噴霧器")
            .Add("002     白銀噴霧器")
            .Add("003     黃金噴霧器")
            .Add("004     脫離洞穴的繩子")
            .Add("005     黑色哨子")
            .Add("006     白色哨子")
            .Add("007     淺灘海鹽")
            .Add("008     淺灘貝殼")
            .Add("009     紅色碎片")
            .Add("010     藍色碎片")
            .Add("011     黃色碎片")
            .Add("012     綠色碎片")
            .Add("013     學習裝置")
            .Add("014     木箱")
            .Add("015     桐木箱")
            .Add("016     美味尾巴")
            .Add("017     甜蜜")
            .Add("018     穩穩肥")
            .Add("019     溼溼肥")
            .Add("020     長長肥")
            .Add("021     黏黏肥")
            .Add("022     楔石")
            .Add("023     釋出之玉")
            .Add("024     荒誕肥")
            .Add("025     勁勁肥")
            .Add("026     碩果肥")
            .Add("027     驚訝肥")
            .Add("028     特價券")
            .Add("029     神奇擺設")
            .Add("030     貝之化石")
            .Add("031     龜殼化石")
            .Add("032     秘密琥珀")
            .Add("033     樹根化石")
            .Add("034     尖爪化石")
            .Add("035     盾牌化石")
            .Add("036     頭蓋化石")
            .Add("037     蓋狀化石")
            .Add("038     羽之化石")
            .Add("039     顎之化石")
            .Add("040     鰭之化石")
            .Add("041     太陽之石")
            .Add("042     月之石")
            .Add("043     火之石")
            .Add("044     雷之石")
            .Add("045     水之石")
            .Add("046     葉之石")
            .Add("047     光之石")
            .Add("048     闇之石")
            .Add("049     覺醒之石")
            .Add("050     小蘑菇")
            .Add("051     大蘑菇")
            .Add("052     珍珠")
            .Add("053     大珍珠")
            .Add("054     星星的沙子")
            .Add("055     星星的碎片")
            .Add("056     金葉")
            .Add("057     銀葉")
            .Add("058     磚瓦碎片")
            .Add("059     金色珠")
            .Add("060     心之鱗片")
            .Add("061     貴重骨頭")
            .Add("062     美麗羽毛")
            .Add("063     芳香蘑菇")
            .Add("064     大金色珠")
            .Add("065     珍珠團子")
            .Add("066     彗星碎片")
            .Add("067     古代銅幣")
            .Add("068     古代銀幣")
            .Add("069     古代金幣")
            .Add("070     古代之壺")
            .Add("071     古代手鐲")
            .Add("072     古代石像")
            .Add("073     古代王冠")
        End With
        txtTitle.Text = lpSearchRequest & " 的搜尋結果"
        If lpSearchRequest = "" Then
            lstItems.ItemsSource = ItemItems
        Else
            lstItems.ItemsSource = (From x In ItemItems Where x.Contains(lpSearchRequest) Select x).ToArray()
        End If
        If lstItems.Items.Count = 0 Then
            gridNoResult.Visibility = System.Windows.Visibility.Visible
        Else
            gridNoResult.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub lstItems_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstItems.DoubleTap
        If lstItems.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstItems.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        lpSelectedItemNumber = strSel
        NavigationService.Navigate(New Uri("/PageItemDetails.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub lstItems_Tap(sender As Object, e As GestureEventArgs) Handles lstItems.Tap
        If lstItems.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim strSel As String
        strSel = lstItems.SelectedItems.Item(0).ToString
        strSel = strSel.Split(" ")(0)
        lpSelectedItemNumber = CLng(strSel) - 1
    End Sub

End Class
