Imports System.Runtime.Serialization

Public Module libColors
    <DataContract> Public Class RGBColor
        <DataMember> Public Red As Integer
        <DataMember> Public Green As Integer
        <DataMember> Public Blue As Integer
        Public Sub New()
            Red = 0
            Green = 0
            Blue = 0
        End Sub
    End Class
    <DataContract> Public Class ColorSetting
        <DataMember> Public IsSystemAccent As Boolean
        <DataMember> Public ColorSettingsRGB As New RGBColor
        Public Sub New()
            IsSystemAccent = True
        End Sub
    End Class
    Public Enum ColorEditingTargets
        ColorHP = 0
        ColorAttack = 1
        ColorDefence = 2
        ColorSpecialAttack = 3
        ColorSpecialDefence = 4
        ColorSpeed = 5
        ColorTotal = 6
    End Enum
    Public CurrentColorEditingTarget As ColorEditingTargets
    Public ColorHP As ColorSetting
    Public ColorAttack As ColorSetting
    Public ColorDefence As ColorSetting
    Public ColorSpecialAttack As ColorSetting
    Public ColorSpecialDefence As ColorSetting
    Public ColorSpeed As ColorSetting
    Public ColorTotal As ColorSetting
    Public Sub InitColorSettings()
        If Not IsoSettingsLib.Contains(ColorSpeciesStrengthHPKey) Then
            ColorHP = New ColorSetting
            IsoSettingsLib.Add(ColorSpeciesStrengthHPKey, ColorHP)
        Else
            ColorHP = IsoSettingsLib(ColorSpeciesStrengthHPKey)
        End If
        If Not IsoSettingsLib.Contains(ColorSpeciesStrengthAttackKey) Then
            ColorAttack = New ColorSetting
            IsoSettingsLib.Add(ColorSpeciesStrengthAttackKey, ColorAttack)
        Else
            ColorAttack = IsoSettingsLib(ColorSpeciesStrengthAttackKey)
        End If
        If Not IsoSettingsLib.Contains(ColorSpeciesStrengthDefenceKey) Then
            ColorDefence = New ColorSetting
            IsoSettingsLib.Add(ColorSpeciesStrengthDefenceKey, ColorDefence)
        Else
            ColorDefence = IsoSettingsLib(ColorSpeciesStrengthDefenceKey)
        End If
        If Not IsoSettingsLib.Contains(ColorSpeciesStrengthSpecialAttackKey) Then
            ColorSpecialAttack = New ColorSetting
            IsoSettingsLib.Add(ColorSpeciesStrengthSpecialAttackKey, ColorSpecialAttack)
        Else
            ColorSpecialAttack = IsoSettingsLib(ColorSpeciesStrengthSpecialAttackKey)
        End If
        If Not IsoSettingsLib.Contains(ColorSpeciesStrengthSpecialDefenceKey) Then
            ColorSpecialDefence = New ColorSetting
            IsoSettingsLib.Add(ColorSpeciesStrengthSpecialDefenceKey, ColorSpecialDefence)
        Else
            ColorSpecialDefence = IsoSettingsLib(ColorSpeciesStrengthSpecialDefenceKey)
        End If
        If Not IsoSettingsLib.Contains(ColorSpeciesStrengthSpeedKey) Then
            ColorSpeed = New ColorSetting
            IsoSettingsLib.Add(ColorSpeciesStrengthSpeedKey, ColorSpeed)
        Else
            ColorSpeed = IsoSettingsLib(ColorSpeciesStrengthSpeedKey)
        End If
        If Not IsoSettingsLib.Contains(ColorSpeciesStrengthTotalKey) Then
            ColorTotal = New ColorSetting
            IsoSettingsLib.Add(ColorSpeciesStrengthTotalKey, ColorTotal)
        Else
            ColorTotal = IsoSettingsLib(ColorSpeciesStrengthTotalKey)
        End If
    End Sub
    Public Sub SaveColor(lpTarget As ColorEditingTargets)
        Select Case lpTarget
            Case ColorEditingTargets.ColorHP
                IsoSettingsLib(ColorSpeciesStrengthHPKey) = ColorHP
            Case ColorEditingTargets.ColorAttack
                IsoSettingsLib(ColorSpeciesStrengthAttackKey) = ColorAttack
            Case ColorEditingTargets.ColorDefence
                IsoSettingsLib(ColorSpeciesStrengthDefenceKey) = ColorDefence
            Case ColorEditingTargets.ColorSpecialAttack
                IsoSettingsLib(ColorSpeciesStrengthSpecialAttackKey) = ColorSpecialAttack
            Case ColorEditingTargets.ColorSpecialDefence
                IsoSettingsLib(ColorSpeciesStrengthSpecialDefenceKey) = ColorSpecialDefence
            Case ColorEditingTargets.ColorSpeed
                IsoSettingsLib(ColorSpeciesStrengthSpeedKey) = ColorSpeed
            Case ColorEditingTargets.ColorTotal
                IsoSettingsLib(ColorSpeciesStrengthTotalKey) = ColorTotal
        End Select

    End Sub

End Module
