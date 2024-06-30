Partial Public Class PagePokemonFormDifferenceInfo
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PagePokemonFormDifferenceInfo_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        txtPMName.Text = CurrentPokemonTranslationForCommonUse(CInt(PokemonInformationShared.DexIDNumber) - 1)
        txtStateName.Text = SharedFormDifferenceInformation.FormName
        Dim imgPokemonURI As Media.Imaging.BitmapImage
        imgPokemonURI = New Imaging.BitmapImage
        imgPokemonURI.UriSource = New Uri(SharedFormDifferenceInformation.ImagePath, UriKind.RelativeOrAbsolute)
        imgPokemon.Source = imgPokemonURI
        With ColorHP
            If .IsSystemAccent Then
                prgSVHP.Foreground = prgEXP.Foreground
                'prgSVHP_MORAS.Foreground = prgEXP.Foreground
                'prgSVHP_MX.Foreground = prgEXP.Foreground
                'prgSVHP_MY.Foreground = prgEXP.Foreground
                'prgSVHP_OS.Foreground = prgEXP.Foreground
            Else
                prgSVHP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVHP_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorAttack
            If .IsSystemAccent Then
                prgSVATK.Foreground = prgEXP.Foreground
                'prgSVATK_MORAS.Foreground = prgEXP.Foreground
                'prgSVATK_MX.Foreground = prgEXP.Foreground
                'prgSVATK_MY.Foreground = prgEXP.Foreground
                'prgSVATK_OS.Foreground = prgEXP.Foreground
            Else
                prgSVATK.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVATK_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorDefence
            If .IsSystemAccent Then
                prgSVDEF.Foreground = prgEXP.Foreground
                'prgSVDEF_MORAS.Foreground = prgEXP.Foreground
                'prgSVDEF_MX.Foreground = prgEXP.Foreground
                'prgSVDEF_MY.Foreground = prgEXP.Foreground
                'prgSVDEF_OS.Foreground = prgEXP.Foreground
            Else
                prgSVDEF.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVDEF_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorSpecialAttack
            If .IsSystemAccent Then
                prgSVSA.Foreground = prgEXP.Foreground
                'prgSVSA_MORAS.Foreground = prgEXP.Foreground
                'prgSVSA_MX.Foreground = prgEXP.Foreground
                'prgSVSA_MY.Foreground = prgEXP.Foreground
                'prgSVSA_OS.Foreground = prgEXP.Foreground
            Else
                prgSVSA.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSA_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorSpecialDefence
            If .IsSystemAccent Then
                prgSVSD.Foreground = prgEXP.Foreground
                'prgSVSD_MORAS.Foreground = prgEXP.Foreground
                'prgSVSD_MX.Foreground = prgEXP.Foreground
                'prgSVSD_MY.Foreground = prgEXP.Foreground
                'prgSVSD_OS.Foreground = prgEXP.Foreground
            Else
                prgSVSD.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSD_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorSpeed
            If .IsSystemAccent Then
                prgSVSP.Foreground = prgEXP.Foreground
                'prgSVSP_MORAS.Foreground = prgEXP.Foreground
                'prgSVSP_MX.Foreground = prgEXP.Foreground
                'prgSVSP_MY.Foreground = prgEXP.Foreground
                'prgSVSP_OS.Foreground = prgEXP.Foreground
            Else
                prgSVSP.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVSP_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
        End With
        With ColorTotal
            If .IsSystemAccent Then
                prgSVT.Foreground = prgEXP.Foreground
                'prgSVT_MORAS.Foreground = prgEXP.Foreground
                'prgSVT_MX.Foreground = prgEXP.Foreground
                'prgSVT_MY.Foreground = prgEXP.Foreground
                'prgSVT_OS.Foreground = prgEXP.Foreground
            Else
                prgSVT.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_MORAS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_MX.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_MY.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
                'prgSVT_OS.Foreground = New SolidColorBrush(Color.FromArgb(255, .ColorSettingsRGB.Red, .ColorSettingsRGB.Green, .ColorSettingsRGB.Blue))
            End If
            If SharedFormDifferenceInformation.IsUniqueDescriptionAvailable Then
                txtDescription.Visibility = System.Windows.Visibility.Visible
                txtDescription.Text = SharedFormDifferenceInformation.UniqueDescription
            Else
                txtDescription.Visibility = System.Windows.Visibility.Collapsed
            End If
            With SharedFormDifferenceInformation.SpeciesStrengthValues
                txtSVATK.Text = .Attack.ToString
                txtSVDEF.Text = .Defence.ToString
                txtSVHP.Text = .HP.ToString
                txtSVSA.Text = .SpecialAttack.ToString
                txtSVSD.Text = .SpecialDefence.ToString
                txtSVSP.Text = .Speed
                txtSVT.Text = .Total.ToString
            End With
            With SharedFormDifferenceInformation
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
                txtHeight.Text = .Height
                txtWeight.Text = .Weight
                txtCategory.Text = .Category
                txtBodyColor.Text = .BodyColor
                If IsNumber(.Ability1) Then
                    txtAbility1.Text = CurrentAbility(CInt(.Ability1) - 1)
                Else
                    txtAbility1.Text = .Ability1
                End If
                If IsNumber(.Ability2) Then
                    txtAbility2.Text = CurrentAbility(CInt(.Ability2) - 1)
                Else
                    txtAbility2.Text = .Ability2
                End If
                If IsNumber(.AbilityHidden) Then
                    txtAbility3.Text = CurrentAbility(CInt(.AbilityHidden) - 1)
                Else
                    txtAbility3.Text = .AbilityHidden
                End If
                With .SpeciesStrengthValues
                    prgSVATK.Value = .Attack
                    prgSVDEF.Value = .Defence
                    prgSVHP.Value = .HP
                    prgSVSA.Value = .SpecialAttack
                    prgSVSD.Value = .SpecialDefence
                    prgSVSP.Value = .Speed
                    prgSVT.Value = .Total
                End With
            End With

        End With
    End Sub


    Private Sub txtAbility1_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility1.Tap
        If IsNumber(SharedFormDifferenceInformation.Ability1) Then
            MessageBox.Show(AbilityDescriptions(SharedFormDifferenceInformation.Ability1 - 1), txtAbility1.Text, MessageBoxButton.OK)
        End If
    End Sub

    Private Sub txtAbility2_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility2.Tap
        If IsNumber(SharedFormDifferenceInformation.Ability2) Then
            MessageBox.Show(AbilityDescriptions(SharedFormDifferenceInformation.Ability2 - 1), txtAbility2.Text, MessageBoxButton.OK)
        End If
    End Sub

    Private Sub txtAbility3_Tap(sender As Object, e As GestureEventArgs) Handles txtAbility3.Tap
        If IsNumber(SharedFormDifferenceInformation.AbilityHidden) Then
            MessageBox.Show(AbilityDescriptions(SharedFormDifferenceInformation.AbilityHidden - 1), txtAbility3.Text, MessageBoxButton.OK)
        End If
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
        txtDescription.Text = SharedFormDifferenceInformation.UniqueDescription
    End Sub
    Private Sub txtDescription_TextInput(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInput
        e.Handled = True
    End Sub
    Private Sub txtDescription_TextInputStart(sender As Object, e As TextCompositionEventArgs) Handles txtDescription.TextInputStart
        e.Handled = True
    End Sub
End Class
