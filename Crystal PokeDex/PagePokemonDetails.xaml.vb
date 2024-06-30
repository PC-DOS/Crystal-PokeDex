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
        CatchRatePercent = Math.Round((CatchRateValue / 765) * 10000) / 100
        If CatchRatePercent > 100 Then
            CatchRatePercent = 100
        End If
        ReturnValue = CatchRatePercent.ToString("F2") & "%"
        Return ReturnValue
    End Function

    Private Sub PagePokemonDetails_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        If IsLaunchedFromPinned Then
            NavigationService.RemoveBackEntry()
        End If
        GenerateSpecificFormDifferenceInfo(CLng(PokemonInformationShared.DexIDNumber))
        GenerateEvolutionData(CInt(PokemonInformationShared.DexIDNumber))
        gridNoEvolution.Visibility = System.Windows.Visibility.Visible
        imgArrowDown.Visibility = System.Windows.Visibility.Collapsed
        imgArrowUp.Visibility = System.Windows.Visibility.Collapsed
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
        imgPokemonFemale.UriSource = New Uri(PokemonInformationShared.ImageFemaleURI, UriKind.RelativeOrAbsolute)
        imgPokemonMale.UriSource = New Uri(PokemonInformationShared.ImageMaleURI, UriKind.RelativeOrAbsolute)
        imgPokemonEvolutionBasic.UriSource = New Uri("/Pokemons/" & PokemonInformationShared.DexIDNumber & ".png", UriKind.RelativeOrAbsolute)
        imgFemale.Source = imgPokemonFemale
        imgMale.Source = imgPokemonMale
        imgEvoBasic.Source = imgPokemonEvolutionBasic
        With ColorHP
            If .IsSystemAccent Then
                prgSVHP.Foreground = prgEXP.Foreground
            Else
                prgSVHP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorAttack
            If .IsSystemAccent Then
                prgSVATK.Foreground = prgEXP.Foreground
            Else
                prgSVATK.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorDefence
            If .IsSystemAccent Then
                prgSVDEF.Foreground = prgEXP.Foreground
            Else
                prgSVDEF.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorSpecialAttack
            If .IsSystemAccent Then
                prgSVSA.Foreground = prgEXP.Foreground
            Else
                prgSVSA.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorSpecialDefence
            If .IsSystemAccent Then
                prgSVSD.Foreground = prgEXP.Foreground
            Else
                prgSVSD.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorSpeed
            If .IsSystemAccent Then
                prgSVSP.Foreground = prgEXP.Foreground
            Else
                prgSVSP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorTotal
            If .IsSystemAccent Then
                prgSVT.Foreground = prgEXP.Foreground
            Else
                prgSVT.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        If PokemonInformationShared.IsNoGenderOrSingleGender Then
            imgFemale.Visibility = System.Windows.Visibility.Collapsed
            rectImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgMale.Text = CurrentPokemonTranslationForCommonUse(CInt(PokemonInformationShared.DexIDNumber) - 1) & " 的外貌"
        Else
            imgFemale.Visibility = System.Windows.Visibility.Visible
            rectImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgMale.Text = "雄性的外貌"
        End If
        pivotBack.Title = CurrentPokemonTranslationForCommonUse(CInt(PokemonInformationShared.DexIDNumber) - 1)
        If FormDifferenceList.Count = 0 Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            lstFormDifferences.ItemsSource = FormDifferenceList
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
        End If
        With PokemonInformationShared
            txtBasicFV.Text = .InitialFriendshipValue
            Try
                txtCatchRate.Text = .CatchRate & " (" & CalculateCatchRatePercentage(.CatchRate) & ")"
            Catch ex As Exception
                txtCatchRate.Text = .CatchRate
            End Try
            txtType.Text = .Type
            Dim PMType As TypeData = ParseTypeString(.Type)
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
            txtDescription.Text = .Description
            txtEgg1.Text = .EggGroup1
            txtEgg2.Text = .EggGroup2
            txtExpBasic.Text = .BasicExpPoint
            txtExpFullLV.Text = .FullLevelExpPoint
            txtHatch.Text = .HatchEggCycles
            If .HatchEggCycles <> "---" And .HatchEggCycles <> "ERROR" Then
                txtHatch.Text = .HatchEggCycles & "週期 (約合" & CInt(.HatchEggCycles) * 257 & "步)"
            Else
                txtHatch.Text = .HatchEggCycles
            End If
            txtHeight.Text = .Height
            txtName.Text = CurrentPokemonTranslationForCommonUse(CInt(.DexIDNumber) - 1)
            txtName_EVOBasic.Text = CurrentPokemonTranslationForCommonUse(CInt(.DexIDNumber) - 1)
            txtNum_EVOBasic.Text = "全國圖鑑登錄號 " & .DexIDNumber
            txtNum.Text = "全國圖鑑登錄號 " & .DexIDNumber
            txtBodyColor.Text = .BodyColor
            txtShelter.Text = .Sheleter
            txtGenderRatio.Text = .GenderRatio
            txtSVATK.Text = .SpeciesStrengthValues.Attack.ToString
            txtSVDEF.Text = .SpeciesStrengthValues.Defence.ToString
            txtSVHP.Text = .SpeciesStrengthValues.HP.ToString
            txtSVSA.Text = .SpeciesStrengthValues.SpecialAttack.ToString
            txtSVSD.Text = .SpeciesStrengthValues.SpecialDefence.ToString
            txtSVSP.Text = .SpeciesStrengthValues.Speed
            txtSVT.Text = .SpeciesStrengthValues.Total.ToString
            txtCategory.Text = .Category
            txtWeight.Text = .Weight
            If .Ability1 <> "---" And .Ability1 <> "ERROR" Then
                txtAbility1.Text = CurrentAbility(CInt(.Ability1) - 1)
            Else
                txtAbility1.Text = .Ability1
            End If
            If .Ability2 <> "---" And .Ability2 <> "ERROR" Then
                txtAbility2.Text = CurrentAbility(CInt(.Ability2) - 1)
            Else
                txtAbility2.Text = .Ability2
            End If
            If .AbilityHidden <> "---" And .AbilityHidden <> "ERROR" Then
                txtAbility3.Text = CurrentAbility(CInt(.AbilityHidden) - 1)
            Else
                txtAbility3.Text = .AbilityHidden
            End If
            txtCHTInformal.Text = .NameCHTInformal
            txtCHTOfficial.Text = .NameCHTOfficial
            txtCHSInformal.Text = .NameCHSInformal
            txtCHSOfficial.Text = .NameCHSOfficial
            txtENU.Text = .NameENG
            txtJPN.Text = .NameJPN
            txtKOR.Text = .NameKOR
            txtFRA.Text = .NameFRA
            txtGER.Text = .NameGER
            Select Case CLng(.DexIDNumber)
                Case Is <= TotalPokemonCountPerVersion.RGBY
                    btnRGBY.IsEnabled = True
                    btnGSC.IsEnabled = True
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.GSC
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = True
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.RSE
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = True
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.DPT
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = True
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.BW
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = True
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.XY
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = True
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.SM
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = True
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.SS
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = False
                    btnSS.IsEnabled = True
                    btnSV.IsEnabled = True
                    Exit Select
                Case Is <= TotalPokemonCountPerVersion.SV
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = False
                    btnSS.IsEnabled = False
                    btnSV.IsEnabled = True
                    Exit Select
                Case Else
                    btnRGBY.IsEnabled = False
                    btnGSC.IsEnabled = False
                    btnRSE.IsEnabled = False
                    btnDPT.IsEnabled = False
                    btnBW.IsEnabled = False
                    btnXY.IsEnabled = False
                    btnSM.IsEnabled = False
                    btnSS.IsEnabled = False
                    btnSV.IsEnabled = False
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
        With PokemonInformationShared.SpeciesStrengthValues
            prgSVATK.Value = .Attack
            prgSVDEF.Value = .Defence
            prgSVHP.Value = .HP
            prgSVSA.Value = .SpecialAttack
            prgSVSD.Value = .SpecialDefence
            prgSVSP.Value = .Speed
            prgSVT.Value = .Total
        End With
        If PokemonInformationShared.IsNoGenderOrSingleGender Then
            imgFemale.Visibility = System.Windows.Visibility.Collapsed
            rectImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgFemale.Visibility = System.Windows.Visibility.Collapsed
            txtImgMale.Text = CurrentPokemonTranslationForCommonUse(CInt(PokemonInformationShared.DexIDNumber) - 1) & " 的外貌"
        Else
            imgFemale.Visibility = System.Windows.Visibility.Visible
            rectImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgFemale.Visibility = System.Windows.Visibility.Visible
            txtImgMale.Text = "雄性的外貌"
        End If
        pivotBack.Title = PokemonInformationShared.Title
        txtName.Text = PokemonInformationShared.Title
        If IsEvolutionsAvailable Then
            gridNoEvolution.Visibility = System.Windows.Visibility.Collapsed
            lstEvoRot.ItemsSource = EvolutionRoutins
        Else
            gridNoEvolution.Visibility = System.Windows.Visibility.Visible
        End If
        If FormDifferenceList.Count = 0 Then
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Visible
        Else
            GridNotAvailable_MS.Visibility = System.Windows.Visibility.Collapsed
            lstFormDifferences.ItemsSource = FormDifferenceList
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
        txtDescription.Text = PokemonInformationShared.Description
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
        txtENU.Text = PokemonInformationShared.NameENG
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
        txtJPN.Text = PokemonInformationShared.NameJPN
    End Sub

    Private Sub txtJPN_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInput
        e.Handled = True
    End Sub

    Private Sub txtJPN_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtJPN.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSInformal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSInformal.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSInformal_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSInformal.TextChanged
        txtCHSInformal.Text = PokemonInformationShared.NameCHSInformal
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
        txtCHTInformal.Text = PokemonInformationShared.NameCHTInformal
    End Sub

    Private Sub txtCHTInformal_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTInformal.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTInformal_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTInformal.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtKOR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKOR.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtKOR_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtKOR.TextChanged
        txtKOR.Text = PokemonInformationShared.NameKOR
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
        txtFRA.Text = PokemonInformationShared.NameFRA
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
        txtGER.Text = PokemonInformationShared.NameGER
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
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.Ability1 - 1), txtAbility1.Text, MessageBoxButton.OK)
        Exit Sub
    End Sub

    Private Sub txtAbility3_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3.Tap
        If txtAbility3.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.AbilityHidden - 1), txtAbility3.Text, MessageBoxButton.OK)
        Exit Sub
    End Sub

    Private Sub lstEvoRot_Tap(sender As Object, e As GestureEventArgs) Handles lstEvoRot.Tap
        If lstEvoRot.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim i As Integer
        i = lstEvoRot.SelectedIndex
        If i >= 0 Then
            If EvoluteToNumers(i).StartsWith(EvolutionDestNumberSuffix) Then
                imgArrowDown.Visibility = System.Windows.Visibility.Visible
                imgArrowUp.Visibility = System.Windows.Visibility.Collapsed
                rectImgEvo_Dest.Visibility = System.Windows.Visibility.Visible
                imgEvoDest.Visibility = System.Windows.Visibility.Visible
                txtName_EVODest.Visibility = System.Windows.Visibility.Visible
                txtNum_EVODest.Visibility = System.Windows.Visibility.Visible
                lblEvolution.Visibility = System.Windows.Visibility.Visible
                lblEvolution.Text = lstEvoRot.SelectedItem
                Dim lpEvoDestNum As Integer
                lpEvoDestNum = CInt(EvoluteToNumers(i).Replace(EvolutionDestNumberSuffix, ""))
                Dim imgPokemonEvoDest As Imaging.BitmapImage
                txtName_EVODest.Text = CurrentPokemonTranslationForCommonUse(lpEvoDestNum - 1)
                imgPokemonEvoDest = New Imaging.BitmapImage
                imgPokemonEvoDest.UriSource = New Uri("/Pokemons/" & EvoluteToNumers(i).Replace(EvolutionDestNumberSuffix, "") & ".png", UriKind.RelativeOrAbsolute)
                imgEvoDest.Source = imgPokemonEvoDest
                txtNum_EVODest.Text = "全國圖鑑登錄號 " & EvoluteToNumers(i).Replace(EvolutionDestNumberSuffix, "")
            ElseIf EvoluteToNumers(i).StartsWith(EvolutionSrcNumberSuffix) Then
                imgArrowDown.Visibility = System.Windows.Visibility.Collapsed
                imgArrowUp.Visibility = System.Windows.Visibility.Visible
                rectImgEvo_Dest.Visibility = System.Windows.Visibility.Visible
                imgEvoDest.Visibility = System.Windows.Visibility.Visible
                txtName_EVODest.Visibility = System.Windows.Visibility.Visible
                txtNum_EVODest.Visibility = System.Windows.Visibility.Visible
                lblEvolution.Visibility = System.Windows.Visibility.Visible
                lblEvolution.Text = lstEvoRot.SelectedItem
                Dim lpEvoDestNum As Integer
                lpEvoDestNum = CInt(EvoluteToNumers(i).Replace(EvolutionSrcNumberSuffix, ""))
                Dim imgPokemonEvoDest As Imaging.BitmapImage
                txtName_EVODest.Text = CurrentPokemonTranslationForCommonUse(lpEvoDestNum - 1)
                imgPokemonEvoDest = New Imaging.BitmapImage
                imgPokemonEvoDest.UriSource = New Uri("/Pokemons/" & EvoluteToNumers(i).Replace(EvolutionSrcNumberSuffix, "") & ".png", UriKind.RelativeOrAbsolute)
                imgEvoDest.Source = imgPokemonEvoDest
                txtNum_EVODest.Text = "全國圖鑑登錄號 " & EvoluteToNumers(i).Replace(EvolutionSrcNumberSuffix, "")
            End If
        End If
    End Sub

    Private Sub ApplicationBarMenuItem_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/PagePokemonOnlineSearchCfg.xaml", UriKind.RelativeOrAbsolute))
        Exit Sub
    End Sub

    Private Sub ApplicationBarMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim TileToPin As FlipTileData
        TileToPin = New FlipTileData
        Dim PokemonID As String
        PokemonID = PokemonInformationShared.DexIDNumber
        With TileToPin
            .BackgroundImage = New Uri("/PokemonTilesStandard/" & PokemonID & ".png", UriKind.RelativeOrAbsolute)
            .SmallBackgroundImage = New Uri("/PokemonTilesStandard/" & PokemonID & ".png", UriKind.RelativeOrAbsolute)
            .WideBackgroundImage = New Uri("/PokemonTilesLarge/" & PokemonID & ".png", UriKind.RelativeOrAbsolute)
            .Title = CurrentPokemonTranslationForCommonUse(CInt(PokemonInformationShared.DexIDNumber) - 1)
        End With
        ShellTile.Create(New Uri("/PageTileLauncher.xaml?TileIndex=" & CurrentPinnedTileIndex.ToString & "&PokemonID=" & PokemonID, UriKind.RelativeOrAbsolute), TileToPin, True)
        CurrentPinnedTileIndex = CurrentPinnedTileIndex + 1
        TileIndexCounter(CurrentPinnedTileIndexKey) = CurrentPinnedTileIndex
    End Sub

    Private Sub ApplicationBarMenuItem_Click_2(sender As Object, e As EventArgs)
        Dim TileToPin As FlipTileData
        TileToPin = New FlipTileData
        Dim PokemonID As String
        PokemonID = PokemonInformationShared.DexIDNumber
        With TileToPin
            .BackgroundImage = New Uri("/PokemonTilesStandard/" & PokemonID & ".png", UriKind.RelativeOrAbsolute)
            .SmallBackgroundImage = New Uri("/PokemonTilesStandard/" & PokemonID & ".png", UriKind.RelativeOrAbsolute)
            .WideBackgroundImage = New Uri("/PokemonTilesLarge/" & PokemonID & ".png", UriKind.RelativeOrAbsolute)
            .Title = ""
        End With
        ShellTile.Create(New Uri("/PageTileLauncher.xaml?TileIndex=" & CurrentPinnedTileIndex.ToString & "&PokemonID=" & PokemonID, UriKind.RelativeOrAbsolute), TileToPin, True)
        CurrentPinnedTileIndex = CurrentPinnedTileIndex + 1
        TileIndexCounter(CurrentPinnedTileIndexKey) = CurrentPinnedTileIndex
    End Sub

    Private Sub txtAbility2_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2.Tap
        If txtAbility2.Text = "---" Then
            Exit Sub
        End If
        MessageBox.Show(AbilityDescriptions(PokemonInformationShared.Ability2 - 1), txtAbility2.Text, MessageBoxButton.OK)
        Exit Sub
    End Sub

    Private Sub lstFormDifferences_DoubleTap(sender As Object, e As GestureEventArgs) Handles lstFormDifferences.DoubleTap
        If lstFormDifferences.SelectedIndex >= 0 Then
            SharedFormDifferenceInformation = FormDifferenceInformationList(lstFormDifferences.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedFormDifferenceInformation.ImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
            SharedFormDifferenceInformation.FormName = FormDifferenceList.Item(lstFormDifferences.SelectedIndex)
            NavigationService.Navigate(New Uri("/PagePokemonFormDifferenceInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub lstFormDifferences_Tap(sender As Object, e As GestureEventArgs) Handles lstFormDifferences.Tap
        If lstFormDifferences.SelectedIndex >= 0 Then
            SharedFormDifferenceInformation = FormDifferenceInformationList(lstFormDifferences.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedFormDifferenceInformation.ImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
        Else
            Exit Sub
            'NavigationService.Navigate(New Uri("/PagePokemonFormDifferenceInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub btnRGBY_Tap(sender As Object, e As GestureEventArgs) Handles btnRGBY.Tap
        GeneratePokemonMovesIDListByPMID_RGBY(PokemonInformationShared.DexIDNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnGSC_Tap(sender As Object, e As GestureEventArgs) Handles btnGSC.Tap
        GeneratePokemonMovesIDListByPMID_GSC(PokemonInformationShared.DexIDNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnRSE_Tap(sender As Object, e As GestureEventArgs) Handles btnRSE.Tap
        GeneratePokemonMovesIDListByPMID_RSE(PokemonInformationShared.DexIDNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnDPT_Tap(sender As Object, e As GestureEventArgs) Handles btnDPT.Tap
        GeneratePokemonMovesIDListByPMID_DPT(PokemonInformationShared.DexIDNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnBW_Tap(sender As Object, e As GestureEventArgs) Handles btnBW.Tap
        GeneratePokemonMovesIDListByPMID_BW(PokemonInformationShared.DexIDNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnXY_Tap(sender As Object, e As GestureEventArgs) Handles btnXY.Tap
        GeneratePokemonMovesIDListByPMID_XY(PokemonInformationShared.DexIDNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub btnSM_Tap(sender As Object, e As GestureEventArgs) Handles btnSM.Tap
        GeneratePokemonMovesIDListByPMID_SM(PokemonInformationShared.DexIDNumber)
        NavigationService.Navigate(New Uri("/PagePokemonMoveList.xaml", UriKind.RelativeOrAbsolute))
    End Sub
    Private Sub btnSS_Tap(sender As Object, e As GestureEventArgs) Handles btnSS.Tap
        MessageBox.Show("離線資訊目前尚不可用，請嘗試連線到線上資料庫。", "錯誤", MessageBoxButton.OK)
    End Sub
    Private Sub btnSV_Tap(sender As Object, e As GestureEventArgs) Handles btnSV.Tap
        MessageBox.Show("離線資訊目前尚不可用，請嘗試連線到線上資料庫。", "錯誤", MessageBoxButton.OK)
    End Sub

    Private Sub imgPokemon_Tap(sender As Object, e As GestureEventArgs) Handles imgPokemon.Tap
        If lstFormDifferences.SelectedIndex >= 0 Then
            SharedFormDifferenceInformation = FormDifferenceInformationList(lstFormDifferences.SelectedIndex)
            Dim imgPokemonURI As Media.Imaging.BitmapImage
            imgPokemonURI = New Imaging.BitmapImage
            imgPokemonURI.UriSource = New Uri(SharedFormDifferenceInformation.ImagePath, UriKind.RelativeOrAbsolute)
            imgPokemon.Source = imgPokemonURI
            imgPokemon.Source = imgPokemonURI
            SharedFormDifferenceInformation.FormName = FormDifferenceList.Item(lstFormDifferences.SelectedIndex)
            NavigationService.Navigate(New Uri("/PagePokemonFormDifferenceInfo.xaml", UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub txtCHTOfficial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHTOfficial.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHTOfficial_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHTOfficial.TextChanged
        txtCHTOfficial.Text = PokemonInformationShared.NameCHTOfficial
    End Sub

    Private Sub txtCHTOfficial_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHTOfficial.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHTOfficial_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHTOfficial.TextInputStart
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHSOfficial.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtCHSOfficial.TextChanged
        txtCHSOfficial.Text = PokemonInformationShared.NameCHSOfficial
    End Sub

    Private Sub txtCHSOfficial_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCHSOfficial.TextInput
        e.Handled = True
    End Sub

    Private Sub txtCHSOfficial_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtCHSOfficial.TextInputStart
        e.Handled = True
    End Sub
End Class
