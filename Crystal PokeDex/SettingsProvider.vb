Public Module SettingsProvider
    Public IsoSettingsLib As IO.IsolatedStorage.IsolatedStorageSettings

    '設定索引常數
    Public Const PokemonNameUseSimplifiedChineseKey = "PokemonNameUseSimplifiedChinese"
    Public Const PokemonNameUseOfficialTranslationKey = "PokemonNameUseOfficialTranslation"
    Public Const AbilityNameUseSimplifiedChineseKey = "AbilityNameUseSimplifiedChinese"
    Public Const AbilityNameUseOfficialTranslationKey = "AbilityNameUseOfficialTranslation"
    Public Const MoveNameUseSimplifiedChineseKey = "MoveNameUseSimplifiedChinese"
    Public Const MoveNameUseOfficialTranslationKey = "MoveNameUseOfficialTranslation"
    Public Const ColorSpeciesStrengthHPKey = "ColorSpeciesStrengthHP"
    Public Const ColorSpeciesStrengthAttackKey = "ColorSpeciesStrengthAttack"
    Public Const ColorSpeciesStrengthDefenceKey = "ColorSpeciesStrengthDefence"
    Public Const ColorSpeciesStrengthSpecialAttackKey = "ColorSpeciesStrengthSpecialAttack"
    Public Const ColorSpeciesStrengthSpecialDefenceKey = "ColorSpeciesStrengthSpecialDefence"
    Public Const ColorSpeciesStrengthSpeedKey = "ColorSpeciesStrengthSpeed"
    Public Const ColorSpeciesStrengthTotalKey = "ColorSpeciesStrengthTotal"
    Public Const ShowDebugMessageKey = "ShowDebugMessageKey"

    '設定項
    Public IsDebugMessageEnabled As Boolean

    Public Enum ChineseDisplayConfig
        DefaultConfig = 0 '默認
        ChineseTraditionalInformal = 1 '民間翻譯,繁體
        ChineseTraditionalOfficial = 2 '官方翻譯,繁體
        ChineseSimplifiedInformal = 3 '民間翻譯,簡體
        ChineseSimplifiedOfficial = 4 '民間翻譯,簡體
    End Enum

    Public Sub InitializeSettings()
        IsoSettingsLib = IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings

        InitPokemonNameSettings()
        SetCurrentPokemonNameDisplay()
        InitAbilitySettings()
        SetCurrentAbilityNameDisplay()
        InitMoveSettings()
        SetCurrentMoveNameDisplay()
        InitColorSettings()

        If Not IsoSettingsLib.Contains(ShowDebugMessageKey) Then
            IsoSettingsLib.Add(ShowDebugMessageKey, False)
        End If
        IsDebugMessageEnabled = IsoSettingsLib(ShowDebugMessageKey)
    End Sub
    Public Sub SaveSettings()
        IsoSettingsLib(ShowDebugMessageKey) = IsDebugMessageEnabled
    End Sub
End Module
