Partial Public Class PagePokemonDetails
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Function CalculateCatchRatePercentage(OriginalCatchRate As String) As String
        Dim ReturnValue As String = "0.00%"
        Dim CatchRateValue As Integer
        Dim CatchRatePercent As Double
        Try
            CatchRateValue = Math.Abs(CInt(OriginalCatchRate))
        Catch ex As Exception
            CatchRateValue = 0
        End Try
        CatchRatePercent = Math.Round((CatchRateValue / 765) * 10000) / 1000
        If CatchRatePercent > 100 Then
            CatchRatePercent = 100
        End If
        ReturnValue = CatchRatePercent.ToString("F2") & "%"
        Return ReturnValue
    End Function

    Private Sub PagePokemonDetails_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'InitializeAbilities()
        If IsLaunchedFromPinned Then
            NavigationService.RemoveBackEntry()
        End If
        GenerateSpecificStateInfo(CLng(PokemonInformationShared.lpNumber))
        GenerateEvolutionData(CInt(PokemonInformationShared.lpNumber))
        gridNoEvolution.Visibility = System.Windows.Visibility.Visible
        imgArrow.Visibility = System.Windows.Visibility.Collapsed
        rectImgEvo_Dest.Visibility = System.Windows.Visibility.Collapsed
        imgEvoDest.Visibility = System.Windows.Visibility.Collapsed
        txtName_EVODest.Visibility = System.Windows.Visibility.Collapsed
        txtNum_EVODest.Visibility = System.Windows.Visibility.Collapsed
        lblEvolution.Visibility = System.Windows.Visibility.Collapsed
        Dim imgPokemonMale As Media.Imaging.BitmapImage
        imgPokemonMale = New Imaging.BitmapImage
        Dim imgPokemonFemale As Media.Imaging.BitmapImage
        imgPokemonFemale = New Imaging.BitmapImage
        Dim imgPokemonEvolutionBasic As Media.Imaging.BitmapImage
        imgPokemonEvolutionBasic = New Imaging.BitmapImage
        imgPokemonFemale.UriSource = New Uri(PokemonInformationShared.lpImageFemaleUri, UriKind.RelativeOrAbsolute)
        imgPokemonMale.UriSource = New Uri(PokemonInformationShared.lpImageMaleUri, UriKind.RelativeOrAbsolute)
        imgPokemonEvolutionBasic.UriSource = New Uri("/PokemonsL/" & PokemonInformationShared.lpNumber & ".png", UriKind.RelativeOrAbsolute)
        imgFemale.Source = imgPokemonFemale
        imgMale.Source = imgPokemonMale
        imgEvoBasic.Source = imgPokemonEvolutionBasic
        With ValueHP
            If .IsSystemAccent Then
                prgSVHP.Foreground = prgEXP.Foreground
            Else
                prgSVHP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueAttack
            If .IsSystemAccent Then
                prgSVATK.Foreground = prgEXP.Foreground
            Else
                prgSVATK.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueDefence
            If .IsSystemAccent Then
                prgSVDEF.Foreground = prgEXP.Foreground
            Else
                prgSVDEF.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpecialAttack
            If .IsSystemAccent Then
                prgSVSA.Foreground = prgEXP.Foreground
            Else
                prgSVSA.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpecialDefence
            If .IsSystemAccent Then
                prgSVSD.Foreground = prgEXP.Foreground
            Else
                prgSVSD.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueSpeed
            If .IsSystemAccent Then
                prgSVSP.Foreground = prgEXP.Foreground
            Else
                prgSVSP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ValueTotal
            If .IsSystemAccent Then
                prgSVT.Foreground = prgEXP.Foreground
            Else
                prgSVT.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        If PokemonInformationShared.IsNoSex Then
            imgFemale.Visibility = System.Windows.Visibility.Collapsed
            rectImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgMale.Text = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1) & " 的外貌"
        Else
            imgFemale.Visibility = System.Windows.Visibility.Visible
            rectImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgMale.Text = "雄性的外貌"
        End If
        pivotBack.Title = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1)
        GenerateMultiStateList(PokemonInformationShared.lpNumber)
        If States.Count = 0 Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            lstStates.ItemsSource = States
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
        End If
        With PokemonInformationShared
            txtBasicFV.Text = .lpStandardFriendlyRate
            Try
                txtCatchRate.Text = .lpCatchRate & " (" & CalculateCatchRatePercentage(.lpCatchRate) & ")"
            Catch ex As Exception
                txtCatchRate.Text = .lpCatchRate
            End Try
            txtType.Text = .lpType
            Dim PMType As TypeData = ParseTypeString(.lpType)
            If PMType.IsType2Available Then
                gridType2.Visibility = System.Windows.Visibility.Visible
                txtType1.Text = PMType.TypeString1
                gridType1.Background = New SolidColorBrush(Color.FromArgb(255, PMType.TypeColor1.Red, PMType.TypeColor1.Green, PMType.TypeColor1.Blue))
                txtType2.Text = PMType.TypeString2
                gridType2.Background = New SolidColorBrush(Color.FromArgb(255, PMType.TypeColor2.Red, PMType.TypeColor2.Green, PMType.TypeColor2.Blue))
            Else
                gridType2.Visibility = System.Windows.Visibility.Collapsed
                txtType1.Text = PMType.TypeString1
                gridType1.Background = New SolidColorBrush(Color.FromArgb(255, PMType.TypeColor1.Red, PMType.TypeColor1.Green, PMType.TypeColor1.Blue))
            End If
            txtDescription.Text = .lpDescription
            txtEgg1.Text = .lpEggGroup1
            txtEgg2.Text = .lpEggGroup2
            txtExpBasic.Text = .lpBasicExpPoint
            txtExpFullLV.Text = .lpFullLevelExpPoint
            txtHatch.Text = .lpBornStepsCount
            txtHeight.Text = .lpHeight
            txtName.Text = CurrentTranslationForCommonUse(CInt(.lpNumber) - 1)
            txtName_EVOBasic.Text = CurrentTranslationForCommonUse(CInt(.lpNumber) - 1)
            txtNum_EVOBasic.Text = "全國圖鑑登錄號 " & .lpNumber
            txtNum.Text = "全國圖鑑登錄號 " & .lpNumber
            txtShelter.Text = .lpSheleter
            txtSexRatio.Text = .lpSexRatio
            txtSVATK.Text = .lpBaseValues.ATTACK.ToString
            txtSVDEF.Text = .lpBaseValues.DEFEND.ToString
            txtSVHP.Text = .lpBaseValues.HP.ToString
            txtSVSA.Text = .lpBaseValues.SPATTACK.ToString
            txtSVSD.Text = .lpBaseValues.SPDEFEND.ToString
            txtSVSP.Text = .lpBaseValues.SPEED
            txtSVT.Text = .lpBaseValues.TOTAL.ToString
            txtClass.Text = .lpClass
            txtWeight.Text = .lpWeight
            If .lpAbility1 <> "---" And .lpAbility1 <> "ERROR" Then
                txtAbility1.Text = CurrentAbility(CInt(.lpAbility1) - 1)
            Else
                txtAbility1.Text = .lpAbility1
            End If
            If .lpAbility2 <> "---" And .lpAbility2 <> "ERROR" Then
                txtAbility2.Text = CurrentAbility(CInt(.lpAbility2) - 1)
            Else
                txtAbility2.Text = .lpAbility2
            End If
            If .lpAbilityHidden <> "---" And .lpAbilityHidden <> "ERROR" Then
                txtAbility3.Text = CurrentAbility(CInt(.lpAbilityHidden) - 1)
            Else
                txtAbility3.Text = .lpAbilityHidden
            End If
            txtROC.Text = .lpNameCHT
            txtPRC.Text = .lpNameCHS
            txtENU.Text = .lpNameENG
            txtJPN.Text = .lpNameJPN
            txtKOR.Text = .lpNameKOR
            txtFRA.Text = .lpNameFRA
            txtGER.Text = .lpNameGER
            txtCHTO.Text = .lpNameCHTO
            txtCHSO.Text = .lpNameCHSO
            Select Case CLng(.lpNumber)
                Case Is <= 151
                    btnRGBY.IsEnabled = True
                    btnGSC.IsEnabled = True
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    Exit Select
                Case Is <= 251
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = True
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    Exit Select
                Case Is <= 386
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    Exit Select
                Case Is <= 493
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    Exit Select
                Case Is <= 649
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    Exit Select
                Case Is <= 721
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    Exit Select
                Case Is <= 809
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    Exit Select
                Case Is <= 898
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = False
                    btnSS.IsEnabled = True
                Case Else
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = False
                    btnSS.IsEnabled = False
                    Exit Select
            End Select
            If .IsMissingNo Then
                btnRGBY.IsEnabled = False
                btnGSC.IsEnabled = False
                btnRSE.IsEnabled = False
                btnDPT.IsEnabled = False
                btnBW.IsEnabled = False
                btnXY.IsEnabled = False
                btnSM.IsEnabled = False
                btnSS.IsEnabled = False
            End If
        End With
        With PokemonInformationShared.lpBaseValues
            prgSVATK.Value = .ATTACK
            prgSVDEF.Value = .DEFEND
            prgSVHP.Value = .HP
            prgSVSA.Value = .SPATTACK
            prgSVSD.Value = .SPDEFEND
            prgSVSP.Value = .SPEED
            prgSVT.Value = .TOTAL
        End With
        If PokemonInformationShared.IsNoSex Then
            imgFemale.Visibility = System.Windows.Visibility.Collapsed
            rectImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgMale.Text = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1) & " 的外貌"
        Else
            imgFemale.Visibility = System.Windows.Visibility.Visible
            rectImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgMale.Text = "雄性的外貌"
        End If
        pivotBack.Title = PokemonInformationShared.lpTitle
        txtName.Text = PokemonInformationShared.lpTitle
        If IsEvolutionsAvailable Then
            gridNoEvolution.Visibility = System.Windows.Visibility.Collapsed
            lstEvoRot.ItemsSource = EvolutionRoutins
        Else
            gridNoEvolution.Visibility = System.Windows.Visibility.Visible
        End If
        If PokemonInformationShared.lpMultiStatesURI = "" Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            'webMS.Navigate(New Uri(PokemonInformationShared.lpMultiStatesURI, UriKind.RelativeOrAbsolute))
        End If
        If States.Count = 0 Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            lstStates.ItemsSource = States
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub txtDescription_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.GotFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.Black)
    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtDescription_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtDescription.LostFocus
        txtDescription.Foreground = New SolidColorBrush(Colors.white)
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtDescription.TextChanged
        txtDescription.Text = PokemonInformationShared.lpDescription
    End Sub

    Private Sub txtDescription_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInput
        e.Handled = True
    End Sub

    Private Sub txtDescription_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtENU_KeyDown(sender As Object, e As KeyEventArgs) Handles txtENU.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtENU_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtENU.TextChanged
        txtENU.Text = PokemonInformationShared.lpNameENG
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
        txtJPN.Text = PokemonInformationShared.lpNameJPN
    End Sub

    Private Sub txtJPN_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInput
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtPRC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPRC.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtPRC_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtPRC.TextChanged
        txtPRC.Text = PokemonInformationShared.lpNameCHS
    End Sub

    Private Sub txtPRC_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtPRC.TextInput
        e.Handled = True
    End Sub

    Private Sub txtPRC_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtPRC.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtROC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtROC.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtROC_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtROC.TextChanged
        txtROC.Text = PokemonInformationShared.lpNameCHT
    End Sub

    Private Sub txtROC_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInput
        e.Handled = True
    End Sub

    Private Sub txtROC_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtROC.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtKOR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKOR.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtKOR_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtKOR.TextChanged
        txtKOR.Text = PokemonInformationShared.lpNameKOR
    End Sub

    Private Sub txtKOR_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtKOR.TextInput
        e.Handled = True
    End Sub

    Private Sub txtKOR_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtKOR.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtFRA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFRA.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtFRA_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtFRA.TextChanged
        txtFRA.Text = PokemonInformationShared.lpNameFRA
    End Sub

    Private Sub txtFRA_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtFRA.TextInput
        e.Handled = True
    End Sub

    Private Sub txtFRA_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtFRA.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtGER_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGER.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtGER_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtGER.TextChanged
        txtGER.Text = PokemonInformationShared.lpNameGER
    End Sub

    Private Sub txtGER_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtGER.TextInput
        e.Handled = True
    End Sub

    Private Sub txtGER_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtGER.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtAbility1_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility1.Tap
        If txtAbility1.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpAbility1 - 1), txtAbility1.Text, MessageBoxButton.OK)
        Exit Sub
    End Sub

    Private Sub txtAbility3_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3.Tap
        If txtAbility3.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpAbilityHidden - 1), txtAbility3.Text, MessageBoxButton.OK)
        Exit Sub
    End Sub

    Private Sub lstEvoRot_Tap(sender As Object, e As GestureEventArgs) Handles lstEvoRot.Tap
        If lstEvoRot.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim i As Integer
        i = lstEvoRot.SelectedIndex
        If i >= 0 Then
            imgArrow.Visibility = System.Windows.Visibility.Visible
            rectImgEvo_Dest.Visibility = System.Windows.Visibility.Visible
            imgEvoDest.Visibility = System.Windows.Visibility.Visible
            txtName_EVODest.Visibility = System.Windows.Visibility.Visible
            txtNum_EVODest.Visibility = System.Windows.Visibility.Visible
            lblEvolution.Visibility = System.Windows.Visibility.Visible
            lblEvolution.Text = lstEvoRot.SelectedItem
            Dim lpEvoDestNum As Integer
            lpEvoDestNum = CInt(EvoluteToNumers(i))
            Dim imgPokemonEvoDest As Imaging.BitmapImage
            txtName_EVODest.Text = CurrentTranslationForCommonUse(lpEvoDestNum - 1)
            imgPokemonEvoDest = New Imaging.BitmapImage
            imgPokemonEvoDest.UriSource = New Uri("/PokemonsL/" & EvoluteToNumers(i) & ".png", UriKind.RelativeOrAbsolute)
            imgEvoDest.Source = imgPokemonEvoDest
            txtNum_EVODest.Text = "全國圖鑑登錄號 " & EvoluteToNumers(i)
        End If
    End Sub

    Private Sub ApplicationBarMenuItem_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/PageSearchReq.xaml", UriKind.RelativeOrAbsolute))
        Exit Sub
    End Sub

    Private Sub ApplicationBarMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim tile As FlipTileData
        tile = New FlipTileData
        Dim PkMnNum As String
        PkMnNum = PokemonInformationShared.lpNumber
        With tile
            .BackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .SmallBackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .WideBackgroundImage = New Uri("/PokemonsTL/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .Title = CurrentTranslationForCommonUse(CInt(PokemonInformationShared.lpNumber) - 1)
        End With
        ShellTile.Create(New Uri("/PageTileLauncher.xaml?Index=" & currentTileIndex.ToString & "&Num=" & PkMnNum, UriKind.RelativeOrAbsolute), tile, True)
        currentTileIndex = currentTileIndex + 1
        indexManage("Index") = currentTileIndex
    End Sub

    Private Sub ApplicationBarMenuItem_Click_2(sender As Object, e As EventArgs)
        Dim tile As FlipTileData
        tile = New FlipTileData
        Dim PkMnNum As String
        PkMnNum = PokemonInformationShared.lpNumber
        With tile
            .BackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .SmallBackgroundImage = New Uri("/PokemonsT/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .WideBackgroundImage = New Uri("/PokemonsTL/" & PkMnNum & ".png", UriKind.RelativeOrAbsolute)
            .Title = ""
        End With
        ShellTile.Create(New Uri("/PageTileLauncher.xaml?Index=" & currentTileIndex.ToString & "&Num=" & PkMnNum, UriKind.RelativeOrAbsolute), tile, True)
        currentTileIndex = currentTileIndex + 1
        indexManage("Index") = currentTileIndex
    End Sub

    Private Sub txtAbility2_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2.Tap
        If txtAbility2.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.lpAbility2 - 1), txtAbility2.Text, MessageBoxButton.OK)
        Exit Sub
    End Sub

    Private Sub lstStates_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstStates.DoubleTap
        If lstStates.SelectedIndex >= 0 Then
            SharedStateInformation = StateInformation(lstStates.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedStateInformation.lpImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
            SharedStateInformation.lpStateName = States.Item(lstStates.SelectedIndex)
            NavigationService.Navigate(New Uri("/PageStateInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub lstStates_Tap(sender As Object, e As GestureEventArgs) Handles lstStates.Tap
        If lstStates.SelectedIndex >= 0 Then
            SharedStateInformation = StateInformation(lstStates.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedStateInformation.lpImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
        Else
            Exit Sub
            'NavigationService.Navigate(New Uri("/PageStateInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub btnRGBY_Tap(sender As Object, e As GestureEventArgs) Handles btnRGBY.Tap
        GeneratePokemonMovesIDListByPMID_RGBY(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnGSC_Tap(sender As Object, e As GestureEventArgs) Handles btnGSC.Tap
        GeneratePokemonMovesIDListByPMID_GSC(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnRSE_Tap(sender As Object, e As GestureEventArgs) Handles btnRSE.Tap
        GeneratePokemonMovesIDListByPMID_RSE(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnDPT_Tap(sender As Object, e As GestureEventArgs) Handles btnDPT.Tap
        GeneratePokemonMovesIDListByPMID_DPT(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnBW_Tap(sender As Object, e As GestureEventArgs) Handles btnBW.Tap
        GeneratePokemonMovesIDListByPMID_BW(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnXY_Tap(sender As Object, e As GestureEventArgs) Handles btnXY.Tap
        GeneratePokemonMovesIDListByPMID_XY(PokemonInformationShared.lpNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnSM_Tap(sender As Object, e As GestureEventArgs) Handles btnSM.Tap
        If PokemonInformationShared.lpNumber >= 722 And PokemonInformationShared.lpNumber <= 809 Then
            GeneratePokemonMovesIDListByPMID_SM_7(PokemonInformationShared.lpNumber)
        Else
            GeneratePokemonMovesIDListByPMID_SM(PokemonInformationShared.lpNumber)
        End If
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub imgPokemon_Tap(sender As Object, e As GestureEventArgs) Handles imgPokemon.Tap
        If lstStates.SelectedIndex >= 0 Then
            SharedStateInformation = StateInformation(lstStates.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedStateInformation.lpImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
            SharedStateInformation.lpStateName = States.Item(lstStates.SelectedIndex)
            NavigationService.Navigate(New Uri("/PageStateInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub txtCHTO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTO.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTO_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTO.TextChanged
        txtCHTO.Text = PokemonInformationShared.lpNameCHTO
    End Sub

    Private Sub txtCHTO_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTO.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTO_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTO.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSO.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSO_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSO.TextChanged
        txtCHSO.Text = PokemonInformationShared.lpNameCHSO
    End Sub

    Private Sub txtCHSO_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSO.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSO_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSO.TextInputStart
        e.Handled = True
    End Sub
End Class
