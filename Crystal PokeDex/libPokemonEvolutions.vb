Module libPokemonEvolutions
    Private IsEvolutionsAvailableTemp As Boolean
    Private EvolutionRoutinsTemp As New List(Of String)
    Private EvoluteToNumersTemp As New List(Of String)
    Public IsEvolutionsAvailable As Boolean
    Public EvolutionRoutins As New List(Of String)
    Public EvoluteToNumers As New List(Of String) '使用"<FROM>"、"<TO>"區分是進化來源還是進化目標
    Public Const EvolutionDestNumberSuffix As String = "<TO>"
    Public Const EvolutionSrcNumberSuffix As String = "<FROM>"
    Public Sub GenerateEvolutionData(PokemonNationalDexNumberToQuery As Integer)
        IsEvolutionsAvailable = False
        EvoluteToNumers.Clear()
        EvolutionRoutins.Clear()
        '建立單向的進化目標清單
        GenerateSingleLinkEvolutionData(PokemonNationalDexNumberToQuery)
        If IsEvolutionsAvailableTemp Then
            IsEvolutionsAvailable = True
            For i As Integer = 0 To EvolutionRoutinsTemp.Count - 1
                EvolutionRoutins.Add(EvolutionRoutinsTemp(i))
                EvoluteToNumers.Add(EvolutionDestNumberSuffix & EvoluteToNumersTemp(i))
            Next
        End If
        '反向檢查受否存在以當前神奇寶貝為目標的進化項目
        For i As Integer = 1 To CurrentPokemonCount
            If i = PokemonNationalDexNumberToQuery Then
                Continue For
            End If
            GenerateSingleLinkEvolutionData(i)
            If IsEvolutionsAvailableTemp Then
                For j As Integer = 0 To EvolutionRoutinsTemp.Count - 1
                    If CInt(EvoluteToNumersTemp(j)) = PokemonNationalDexNumberToQuery Then
                        IsEvolutionsAvailable = True
                        EvolutionRoutins.Add("[" & CurrentTranslationForCommonUse(i - 1) & "] " & EvolutionRoutinsTemp(j))
                        EvoluteToNumers.Add(EvolutionSrcNumberSuffix & i.ToString("D3"))
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub GenerateSingleLinkEvolutionData(PokemonNationalDexNumberToQuery As Integer)
        IsEvolutionsAvailableTemp = False
        EvoluteToNumersTemp.Clear()
        EvolutionRoutinsTemp.Clear()
        If PokemonNationalDexNumberToQuery <= TotalPokemonCountPerVersion.SM Then
            GenerateSingleLinkEvolutionDataPreSS(PokemonNationalDexNumberToQuery)
        ElseIf PokemonNationalDexNumberToQuery <= TotalPokemonCountPerVersion.SV Then
            GenerateSingleLinkEvolutionDataSSSV(PokemonNationalDexNumberToQuery)
            'ElseIf PokemonNationalDexNumberToQuery <= {$SS_PMINDEX_MAX} Then
            'GenerateSingleLinkEvolutionDataSS(PokemonNationalDexNumberToQuery)
        End If
    End Sub
    Private Sub GenerateSingleLinkEvolutionDataPreSS(PokemonNationalDexNumberToQuery As Integer)
        IsEvolutionsAvailableTemp = False
        EvoluteToNumersTemp.Clear()
        EvolutionRoutinsTemp.Clear()
        Select Case PokemonNationalDexNumberToQuery
            Case 1
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("002")
                    .Add("003")
                End With
            Case 2
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("003")
                End With
            Case 3
                IsEvolutionsAvailableTemp = False
            Case 4
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("005")
                    .Add("006")
                End With
            Case 5
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    '.Add("002")
                    .Add("006")
                End With
            Case 6
                IsEvolutionsAvailableTemp = False
            Case 7
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("008")
                    .Add("009")
                End With
            Case 8
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    '.Add("002")
                    .Add("009")
                End With
            Case 9
                IsEvolutionsAvailableTemp = False
            Case 10
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumersTemp
                    .Add("011")
                    .Add("012")
                End With
            Case 11
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumersTemp
                    '.Add("011")
                    .Add("012")
                End With
            Case 12
                IsEvolutionsAvailableTemp = False
            Case 13
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumersTemp
                    .Add("014")
                    .Add("015")
                End With
            Case 14
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumersTemp
                    '.Add("011")
                    .Add("014")
                End With
            Case 15
                IsEvolutionsAvailableTemp = False
            Case 16
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("017")
                    .Add("018")
                End With
            Case 17
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到L")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("018")
                    '.Add("")
                End With
            Case 18
                IsEvolutionsAvailableTemp = False
            Case 19
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                    .Add("(阿羅拉的樣子)在夜晚升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("020")
                    .Add("020")
                End With
            Case 20
                IsEvolutionsAvailableTemp = False
            Case 21
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("022")
                End With
            Case 22
                IsEvolutionsAvailableTemp = False
            Case 23
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                End With
                With EvoluteToNumersTemp
                    .Add("024")
                End With
            Case 24
                IsEvolutionsAvailableTemp = False
            Case 25
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[雷之石]")
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("026")
                    .Add("172")
                End With
            Case 26
                IsEvolutionsAvailableTemp = False
            Case 27
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                    .Add("(阿羅拉的樣子)使用[冰之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("028")
                    .Add("028")
                End With
            Case 28
                IsEvolutionsAvailableTemp = False
            Case 29
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                End With
                With EvoluteToNumersTemp
                    .Add("030")
                End With
            Case 30
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("031")
                End With
            Case 31
                IsEvolutionsAvailableTemp = False
            Case 32
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                End With
                With EvoluteToNumersTemp
                    .Add("033")
                End With
            Case 33
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("034")
                End With
            Case 34
                IsEvolutionsAvailableTemp = False
            Case 35
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[月之石]")
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("036")
                    .Add("173")
                End With
            Case 36
                IsEvolutionsAvailableTemp = False
            Case 37
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[火之石]")
                    .Add("(阿羅拉的樣子)使用[冰之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("038")
                    .Add("038")
                End With
            Case 38
                IsEvolutionsAvailableTemp = False
            Case 39
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[月之石]")
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("040")
                    .Add("174")
                End With
            Case 40
                IsEvolutionsAvailableTemp = False
            Case 41
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                End With
                With EvoluteToNumersTemp
                    .Add("042")
                End With
            Case 42
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("169")
                End With
            Case 43
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV21")
                End With
                With EvoluteToNumersTemp
                    .Add("044")
                End With
            Case 44
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[葉之石]")
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("045")
                    .Add("182")
                End With
            Case 45
                IsEvolutionsAvailableTemp = False
            Case 46
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                End With
                With EvoluteToNumersTemp
                    .Add("047")
                End With
            Case 47
                IsEvolutionsAvailableTemp = False
            Case 48
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV31")
                End With
                With EvoluteToNumersTemp
                    .Add("049")
                End With
            Case 49
                IsEvolutionsAvailableTemp = False
            Case 50
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV26")
                End With
                With EvoluteToNumersTemp
                    .Add("051")
                End With
            Case 51
                IsEvolutionsAvailableTemp = False
            Case 52
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                    .Add("(伽勒爾的樣子)升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("053")
                    .Add("863")
                End With
            Case 53
                IsEvolutionsAvailableTemp = False
            Case 54
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV33")
                End With
                With EvoluteToNumersTemp
                    .Add("055")
                End With
            Case 55
                IsEvolutionsAvailableTemp = False
            Case 56
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("057")
                End With
            Case 57
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使出20次[憤怒之拳]後提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("979")
                End With
            Case 58
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[火之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("059")
                End With
            Case 59
                IsEvolutionsAvailableTemp = False
            Case 60
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("061")
                End With
            Case 61
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[水之石]")
                    .Add("攜帶[王者之印]通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("062")
                    .Add("186")
                End With
            Case 62
                IsEvolutionsAvailableTemp = False
            Case 63
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                End With
                With EvoluteToNumersTemp
                    .Add("064")
                End With
            Case 64
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("065")
                End With
            Case 65
                IsEvolutionsAvailableTemp = False
            Case 66
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("067")
                End With
            Case 67
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("068")
                End With
            Case 68
                IsEvolutionsAvailableTemp = False
            Case 69
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV21")
                End With
                With EvoluteToNumersTemp
                    .Add("070")
                End With
            Case 70
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("071")
                End With
            Case 71
                IsEvolutionsAvailableTemp = False
            Case 72
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("073")
                End With
            Case 73
                IsEvolutionsAvailableTemp = False
            Case 74
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("075")
                End With
            Case 75
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("076")
                End With
            Case 76
                IsEvolutionsAvailableTemp = False
            Case 77
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("078")
                End With
            Case 78
                IsEvolutionsAvailableTemp = False
            Case 79
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                    .Add("攜帶[王者之印]通信進化")
                    .Add("(伽勒爾的樣子)使用[伽勒荳蔻手環]")
                    .Add("(伽勒爾的樣子)使用[伽勒荳蔻花圈]")
                End With
                With EvoluteToNumersTemp
                    .Add("080")
                    .Add("199")
                    .Add("080")
                    .Add("199")
                End With
            Case 80
                IsEvolutionsAvailableTemp = False
            Case 81
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("082")
                End With
            Case 82
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("強磁場區域升級進化")
                    .Add("使用[雷之石](第八世代起)")
                End With
                With EvoluteToNumersTemp
                    .Add("462")
                    .Add("462")
                End With
            Case 83
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("(伽勒爾的樣子)對戰中擊中要害3次或以上結束對戰")
                End With
                With EvoluteToNumersTemp
                    .Add("865")
                End With
            Case 84
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV31")
                End With
                With EvoluteToNumersTemp
                    .Add("085")
                End With
            Case 85
                IsEvolutionsAvailableTemp = False
            Case 86
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("087")
                End With
            Case 88
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("089")
                End With
            Case 89
                IsEvolutionsAvailableTemp = False
            Case 90
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("091")
                End With
            Case 91
                IsEvolutionsAvailableTemp = False
            Case 92
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("093")
                End With
            Case 93
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化或使用[聯繫繩]")
                End With
                With EvoluteToNumersTemp
                    .Add("094")
                End With
            Case 94
                IsEvolutionsAvailableTemp = False
            Case 95
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[金屬膜]通信進化或在《傳說 阿爾宙斯》版中使用[金屬膜]")
                End With
                With EvoluteToNumersTemp
                    .Add("208")
                End With
            Case 96
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("097")
                End With
            Case 97
                IsEvolutionsAvailableTemp = False
            Case 98
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("099")
                End With
            Case 99
                IsEvolutionsAvailableTemp = False
            Case 100
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                    .Add("(洗翠的樣子)使用[葉之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("101")
                    .Add("101")
                End With
            Case 101
                IsEvolutionsAvailableTemp = False
            Case 102
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("103")
                End With
            Case 103
                IsEvolutionsAvailableTemp = False
            Case 104
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("105")
                End With
            Case 105
                IsEvolutionsAvailableTemp = False
            Case 106
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("236")
                End With
            Case 107
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("236")
                End With
            Case 108
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[滾動]")
                End With
                With EvoluteToNumersTemp
                    .Add("463")
                End With
            Case 109
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("110")
                End With
            Case 110
                IsEvolutionsAvailableTemp = False
            Case 111
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    .Add("112")
                End With
            Case 112
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[護具]通信進化或在《傳說 阿爾宙斯》版中使用[護具]")
                End With
                With EvoluteToNumersTemp
                    .Add("464")
                End With
            Case 113
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                    .Add("第九世代以前攜帶[幸運薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("242")
                    .Add("440")
                End With
            Case 114
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[原始之力]時提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("465")
                End With
            Case 115
                IsEvolutionsAvailableTemp = False
            Case 116
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("117")
                End With
            Case 117
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[龍鱗]通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("230")
                End With
            Case 118
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV33")
                End With
                With EvoluteToNumersTemp
                    .Add("119")
                End With
            Case 119
                IsEvolutionsAvailableTemp = False
            Case 120
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("121")
                End With
            Case 121
                IsEvolutionsAvailableTemp = False
            Case 122
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("(伽勒爾的樣子)升級到LV42")
                    .Add("第九世代以前攜帶[幸運薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("866")
                    .Add("439")
                End With
            Case 123
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[金屬膜]通信進化或在《傳說 阿爾宙斯》版中使用[金屬膜]")
                    .Add("使用[黑奇石]")
                End With
                With EvoluteToNumersTemp
                    .Add("212")
                    .Add("900")
                End With
            Case 124
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("238")
                End With
            Case 125
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[電力增幅器]通信進化或在《傳說 阿爾宙斯》版中使用[電力增幅器]")
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("466")
                    .Add("239")
                End With
            Case 126
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[熔岩增幅器]通信進化或在《傳說 阿爾宙斯》版中使用[熔岩增幅器]")
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("467")
                    .Add("240")
                End With
            Case 127
                IsEvolutionsAvailableTemp = False
            Case 128
                IsEvolutionsAvailableTemp = False
            Case 129
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("130")
                End With
            Case 130
                IsEvolutionsAvailableTemp = False
            Case 131
                IsEvolutionsAvailableTemp = False
            Case 132
                IsEvolutionsAvailableTemp = False
            Case 133
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[水之石]")
                    .Add("使用[雷之石]")
                    .Add("使用[火之石]")
                    .Add("白天親密度220以上或友好度158以上提升等級")
                    .Add("夜晚親密度220以上或友好度158以上提升等級")
                    .Add("苔蘚石附近升級進化或第八世代之後使用[葉之石]")
                    .Add("冰雪石附近升級進化或第八世代之後使用[冰之石]")
                    .Add("羈絆值2心及以上(友好度50或158以上)且有妖精屬性技能時升級進化")
                End With
                With EvoluteToNumersTemp
                    .Add("134")
                    .Add("135")
                    .Add("136")
                    .Add("196")
                    .Add("197")
                    .Add("470")
                    .Add("471")
                    .Add("700")
                End With
            Case 134
                IsEvolutionsAvailableTemp = False
            Case 135
                IsEvolutionsAvailableTemp = False
            Case 136
                IsEvolutionsAvailableTemp = False
            Case 137
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[升級資料]通信進化或在《傳說 阿爾宙斯》版中使用[升級資料]")
                End With
                With EvoluteToNumersTemp
                    .Add("233")
                End With
            Case 138
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("139")
                End With
            Case 139
                IsEvolutionsAvailableTemp = False
            Case 140
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("141")
                End With
            Case 141
                IsEvolutionsAvailableTemp = False
            Case 142
                IsEvolutionsAvailableTemp = False
            Case 143
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("第九世代以前攜帶[幸運薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("446")
                End With
            Case 144
                IsEvolutionsAvailableTemp = False
            Case 145
                IsEvolutionsAvailableTemp = False
            Case 146
                IsEvolutionsAvailableTemp = False
            Case 147
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                    .Add("升級到LV55")
                End With
                With EvoluteToNumersTemp
                    .Add("148")
                    .Add("149")
                End With
            Case 148
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV55")
                End With
                With EvoluteToNumersTemp
                    .Add("149")
                End With
            Case 149
                IsEvolutionsAvailableTemp = False
            Case 150
                IsEvolutionsAvailableTemp = False
            Case 151
                IsEvolutionsAvailableTemp = False
            Case 152
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("153")
                    .Add("154")
                End With
            Case 153
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("154")
                End With
            Case 154
                IsEvolutionsAvailableTemp = False
            Case 155
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV14")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("156")
                    .Add("157")
                End With
            Case 156
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("157")
                End With
            Case 157
                IsEvolutionsAvailableTemp = False
            Case 158
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("159")
                    .Add("160")
                End With
            Case 159
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("160")
                End With
            Case 160
                IsEvolutionsAvailableTemp = False
            Case 161
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV15")
                End With
                With EvoluteToNumersTemp
                    .Add("162")
                End With
            Case 162
                IsEvolutionsAvailableTemp = False
            Case 163
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("164")
                End With
            Case 164
                IsEvolutionsAvailableTemp = False
            Case 165
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                End With
                With EvoluteToNumersTemp
                    .Add("166")
                End With
            Case 166
                IsEvolutionsAvailableTemp = False
            Case 168
                IsEvolutionsAvailableTemp = False
            Case 167
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                End With
                With EvoluteToNumersTemp
                    .Add("168")
                End With
            Case 169
                IsEvolutionsAvailableTemp = False
            Case 170
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV27")
                End With
                With EvoluteToNumersTemp
                    .Add("171")
                End With
            Case 171
                IsEvolutionsAvailableTemp = False
            Case 172
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("025")
                End With
            Case 173
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("035")
                End With
            Case 174
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("039")
                End With
            Case 175
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("176")
                End With
            Case 176
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[光之石]")
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("468")
                    .Add("175")
                End With
            Case 177
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("178")
                End With
            Case 178
                IsEvolutionsAvailableTemp = False
            Case 179
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV15")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("180")
                    .Add("181")
                End With
            Case 180
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("181")
                End With
            Case 181
                IsEvolutionsAvailableTemp = False
            Case 182
                IsEvolutionsAvailableTemp = False
            Case 183
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("第九世代以前攜帶[海潮薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("184")
                    .Add("298")
                End With
            Case 184
                IsEvolutionsAvailableTemp = False
            Case 185
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("第九世代以前攜帶[岩石薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("438")
                End With
            Case 186
                IsEvolutionsAvailableTemp = False
            Case 187
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("升級到LV27")
                End With
                With EvoluteToNumersTemp
                    .Add("188")
                    .Add("189")
                End With
            Case 188
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV27")
                End With
                With EvoluteToNumersTemp
                    .Add("189")
                End With
            Case 189
                IsEvolutionsAvailableTemp = False
            Case 190
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[雙重攻擊]")
                End With
                With EvoluteToNumersTemp
                    .Add("424")
                End With
            Case 191
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("192")
                End With
            Case 192
                IsEvolutionsAvailableTemp = False
            Case 193
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[原始之力]")
                End With
                With EvoluteToNumersTemp
                    .Add("469")
                End With
            Case 194
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                    .Add("(帕底亞的樣子)升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("195")
                    .Add("980")
                End With
            Case 195
                IsEvolutionsAvailableTemp = False
            Case 196
                IsEvolutionsAvailableTemp = False
            Case 197
                IsEvolutionsAvailableTemp = False
            Case 198
                IsEvolutionsAvailableTemp = False
            Case 199
                IsEvolutionsAvailableTemp = False
            Case 200
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[暗之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("429")
                End With
            Case 201
                IsEvolutionsAvailableTemp = False
            Case 202
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("第九世代以前攜帶[悠閒薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("360")
                End With
            Case 203
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("學會[雙光束]時提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("981")
                End With
            Case 204
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV31")
                End With
                With EvoluteToNumersTemp
                    .Add("205")
                End With
            Case 205
                IsEvolutionsAvailableTemp = False
            Case 206
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("學會[強力鑽]時提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("982")
                End With
            Case 207
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("夜晚持有道具[銳利之牙]升級進化或夜晚在《傳說 阿爾宙斯》版中使用[銳利之牙]")
                End With
                With EvoluteToNumersTemp
                    .Add("472")
                End With
            Case 208
                IsEvolutionsAvailableTemp = False
            Case 209
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV23")
                End With
                With EvoluteToNumersTemp
                    .Add("210")
                End With
            Case 210
                IsEvolutionsAvailableTemp = False
            Case 211
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("(洗翠的樣子)以剛猛的方式使出20次[毒千針]")
                End With
                With EvoluteToNumersTemp
                    .Add("904")
                End With
            Case 212
                IsEvolutionsAvailableTemp = False
            Case 213
                IsEvolutionsAvailableTemp = False
            Case 214
                IsEvolutionsAvailableTemp = False
            Case 215
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("夜晚持有道具[尖牙]升級進化")
                    .Add("(洗翠的樣子)在白天攜帶[銳利之爪]提升等級，或在《傳說 阿爾宙斯》版中使用[銳利之爪]")
                End With
                With EvoluteToNumersTemp
                    .Add("461")
                    .Add("903")
                End With
            Case 216
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("217")
                End With
            Case 217
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("滿月的夜晚使用[泥炭塊]")
                End With
                With EvoluteToNumersTemp
                    .Add("901")
                End With
            Case 218
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("219")
                End With
            Case 219
                IsEvolutionsAvailableTemp = False
            Case 220
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV33")
                End With
                With EvoluteToNumersTemp
                    .Add("221")
                End With
            Case 221
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[原始之力]")
                End With
                With EvoluteToNumersTemp
                    .Add("473")
                End With
            Case 222
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("(伽勒爾的樣子)升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("864")
                End With
            Case 223
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("224")
                End With
            Case 224
                IsEvolutionsAvailableTemp = False
            Case 225
                IsEvolutionsAvailableTemp = False
            Case 226
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("第九世代以前攜帶[漣漪薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("458")
                End With
            Case 227
                IsEvolutionsAvailableTemp = False
            Case 228
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                End With
                With EvoluteToNumersTemp
                    .Add("229")
                End With
            Case 229
                IsEvolutionsAvailableTemp = False
            Case 230
                IsEvolutionsAvailableTemp = False
            Case 231
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("232")
                End With
            Case 232
                IsEvolutionsAvailableTemp = False
            Case 233
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[可疑修正檔]通信進化或在《傳說 阿爾宙斯》版中使用[可疑修正檔]")
                End With
                With EvoluteToNumersTemp
                    .Add("474")
                End With
            Case 234
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("以迅疾的方式使出20次[屏障猛攻]")
                End With
                With EvoluteToNumersTemp
                    .Add("899")
                End With
            Case 235
                IsEvolutionsAvailableTemp = False
            Case 236
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20且攻擊力大於防禦力")
                    .Add("升級到LV20且攻擊力小於防禦力")
                    .Add("升級到LV20且攻擊力等於防禦力")
                End With
                With EvoluteToNumersTemp
                    .Add("106")
                    .Add("107")
                    .Add("237")
                End With
            Case 237
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("236")
                End With
            Case 238
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("124")
                End With
            Case 239
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("125")
                End With
            Case 240
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("126")
                End With
            Case 240
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("126")
                End With
            Case 241
                IsEvolutionsAvailableTemp = False
            Case 242
                IsEvolutionsAvailableTemp = False
            Case 243
                IsEvolutionsAvailableTemp = False
            Case 244
                IsEvolutionsAvailableTemp = False
            Case 245 '君兒
                IsEvolutionsAvailableTemp = False
            Case 246
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                    .Add("升級到LV55")
                End With
                With EvoluteToNumersTemp
                    .Add("247")
                    .Add("248")
                End With
            Case 247
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV55")
                End With
                With EvoluteToNumersTemp
                    .Add("248")
                End With
            Case 248
                IsEvolutionsAvailableTemp = False
            Case 249
                IsEvolutionsAvailableTemp = False
            Case 250 '塔主
                IsEvolutionsAvailableTemp = False
            Case 251
                IsEvolutionsAvailableTemp = False
            Case 252
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("253")
                    .Add("254")
                End With
            Case 253
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("254")
                End With
            Case 254
                IsEvolutionsAvailableTemp = False
            Case 255
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("256")
                    .Add("257")
                End With
            Case 256
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("257")
                End With
            Case 257
                IsEvolutionsAvailableTemp = False
            Case 258
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("259")
                    .Add("260")
                End With
            Case 259
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("260")
                End With
            Case 260
                IsEvolutionsAvailableTemp = False
            Case 261
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                End With
                With EvoluteToNumersTemp
                    .Add("262")
                End With
            Case 262
                IsEvolutionsAvailableTemp = False
            Case 263
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("264")
                End With
            Case 264
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("(伽勒爾的樣子)夜晚升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("862")
                End With
            Case 265
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("LV7時性格值尾數大於等於5/隨機")
                    .Add("LV7時性格值尾數小於5/隨機")
                End With
                With EvoluteToNumersTemp
                    .Add("266")
                    .Add("268")
                End With
            Case 266
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV10")
                End With
                With EvoluteToNumersTemp
                    .Add("267")
                End With
            Case 267
                IsEvolutionsAvailableTemp = False
            Case 268
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV10")
                End With
                With EvoluteToNumersTemp
                    .Add("269")
                End With
            Case 269
                IsEvolutionsAvailableTemp = False
            Case 270
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV14")
                End With
                With EvoluteToNumersTemp
                    .Add("271")
                End With
            Case 271
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("272")
                End With
            Case 272
                IsEvolutionsAvailableTemp = False
            Case 273
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV14")
                End With
                With EvoluteToNumersTemp
                    .Add("274")
                End With
            Case 274
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("275")
                End With
            Case 275
                IsEvolutionsAvailableTemp = False
            Case 276
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                End With
                With EvoluteToNumersTemp
                    .Add("277")
                End With
            Case 277
                IsEvolutionsAvailableTemp = False
            Case 278
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("279")
                End With
            Case 279
                IsEvolutionsAvailableTemp = False
            Case 280
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("281")
                End With
            Case 281
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                    .Add("雄性使用[覺醒石]")
                End With
                With EvoluteToNumersTemp
                    .Add("282")
                    .Add("475")
                End With
            Case 282
                IsEvolutionsAvailableTemp = False
            Case 283
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                End With
                With EvoluteToNumersTemp
                    .Add("284")
                End With
            Case 284
                IsEvolutionsAvailableTemp = False
            Case 285
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV23")
                End With
                With EvoluteToNumersTemp
                    .Add("286")
                End With
            Case 286
                IsEvolutionsAvailableTemp = False
            Case 287
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("288")
                    .Add("289")
                End With
            Case 288
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("289")
                End With
            Case 289
                IsEvolutionsAvailableTemp = False
            Case 290
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20(本體)")
                    .Add("升級到LV20('殼')：進化時，如果包包中有精靈球且同行寶可夢中有空位")
                End With
                With EvoluteToNumersTemp
                    .Add("291")
                    .Add("292")
                End With
            Case 291
                IsEvolutionsAvailableTemp = False
            Case 292
                IsEvolutionsAvailableTemp = False
            Case 293
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("294")
                    .Add("295")
                End With
            Case 294
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("295")
                End With
            Case 295
                IsEvolutionsAvailableTemp = False
            Case 296
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                End With
                With EvoluteToNumersTemp
                    .Add("297")
                End With
            Case 297
                IsEvolutionsAvailableTemp = False
            Case 298
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("183")
                End With
            Case 299
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("強磁場區域升級進化或在《傳說 阿爾宙斯》版中使用[雷之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("476")
                End With
            Case 300
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("301")
                End With
            Case 301
                IsEvolutionsAvailableTemp = False
            Case 302
                IsEvolutionsAvailableTemp = False
            Case 303
                IsEvolutionsAvailableTemp = False
            Case 304
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    .Add("305")
                    .Add("306")
                End With
            Case 305
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    .Add("306")
                End With
            Case 306
                IsEvolutionsAvailableTemp = False
            Case 307
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("308")
                End With
            Case 308
                IsEvolutionsAvailableTemp = False
            Case 309
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV26")
                End With
                With EvoluteToNumersTemp
                    .Add("310")
                End With
            Case 310
                IsEvolutionsAvailableTemp = False
            Case 311
                IsEvolutionsAvailableTemp = False
            Case 312
                IsEvolutionsAvailableTemp = False
            Case 313
                IsEvolutionsAvailableTemp = False
            Case 314
                IsEvolutionsAvailableTemp = False
            Case 315
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[光之石]")
                    .Add("第九世代以前攜帶[花朵薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("407")
                    .Add("406")
                End With
            Case 316
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV26")
                End With
                With EvoluteToNumersTemp
                    .Add("317")
                End With
            Case 317
                IsEvolutionsAvailableTemp = False
            Case 318
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("319")
                End With
            Case 319
                IsEvolutionsAvailableTemp = False
            Case 320
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("321")
                End With
            Case 321
                IsEvolutionsAvailableTemp = False
            Case 322
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV33")
                End With
                With EvoluteToNumersTemp
                    .Add("323")
                End With
            Case 323
                IsEvolutionsAvailableTemp = False
            Case 324
                IsEvolutionsAvailableTemp = False
            Case 325
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("326")
                End With
            Case 327
                IsEvolutionsAvailableTemp = False
            Case 328
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                    .Add("升級到LV45")
                End With
                With EvoluteToNumersTemp
                    .Add("329")
                    .Add("330")
                End With
            Case 329
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV45")
                End With
                With EvoluteToNumersTemp
                    .Add("330")
                End With
            Case 330
                IsEvolutionsAvailableTemp = False
            Case 331
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("332")
                End With
            Case 332
                IsEvolutionsAvailableTemp = False
            Case 333
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("334")
                End With
            Case 334
                IsEvolutionsAvailableTemp = False
            Case 335
                IsEvolutionsAvailableTemp = False
            Case 336
                IsEvolutionsAvailableTemp = False
            Case 337
                IsEvolutionsAvailableTemp = False
            Case 338
                IsEvolutionsAvailableTemp = False
            Case 339
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("340")
                End With
            Case 340
                IsEvolutionsAvailableTemp = False
            Case 341
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("342")
                End With
            Case 342
                IsEvolutionsAvailableTemp = False
            Case 343
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("344")
                End With
            Case 344
                IsEvolutionsAvailableTemp = False
            Case 345
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("346")
                End With
            Case 346
                IsEvolutionsAvailableTemp = False
            Case 347
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("348")
                End With
            Case 348
                IsEvolutionsAvailableTemp = False
            Case 349
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[美麗鱗片]通信進化或美麗度達到170以上提升等級 ")
                End With
                With EvoluteToNumersTemp
                    .Add("350")
                End With
            Case 350
                IsEvolutionsAvailableTemp = False
            Case 351
                IsEvolutionsAvailableTemp = False
            Case 352
                IsEvolutionsAvailableTemp = False
            Case 353
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("354")
                End With
            Case 354
                IsEvolutionsAvailableTemp = False
            Case 355
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("356")
                End With
            Case 356
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[靈界幕布]通信進化或在《傳說 阿爾宙斯》版中使用[靈界幕布]")
                End With
                With EvoluteToNumersTemp
                    .Add("477")
                End With
            Case 357
                IsEvolutionsAvailableTemp = False
            Case 358
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("第九世代以前攜帶[潔淨薰香]生蛋或(第九世代及以後)生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("433")
                End With
            Case 359
                IsEvolutionsAvailableTemp = False
            Case 360
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV15")
                End With
                With EvoluteToNumersTemp
                    .Add("202")
                End With
            Case 361
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV42")
                    .Add("雌性使用[覺醒石]進化")
                End With
                With EvoluteToNumersTemp
                    .Add("362")
                    .Add("478")
                End With
            Case 362
                IsEvolutionsAvailableTemp = False
            Case 363
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                    .Add("升級到LV44")
                End With
                With EvoluteToNumersTemp
                    .Add("364")
                    .Add("365")
                End With
            Case 364
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV44")
                End With
                With EvoluteToNumersTemp
                    .Add("365")
                End With
            Case 365
                IsEvolutionsAvailableTemp = False
            Case 366
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[深海之牙]通信進化")
                    .Add("攜帶[深海之鱗]通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("367")
                    .Add("368")
                End With
            Case 367
                IsEvolutionsAvailableTemp = False
            Case 368
                IsEvolutionsAvailableTemp = False
            Case 369
                IsEvolutionsAvailableTemp = False
            Case 370
                IsEvolutionsAvailableTemp = False
            Case 371
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                    .Add("升級到LV50")
                End With
                With EvoluteToNumersTemp
                    .Add("372")
                    .Add("373")
                End With
            Case 372
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV50")
                End With
                With EvoluteToNumersTemp
                    .Add("373")
                End With
            Case 373
                IsEvolutionsAvailableTemp = False
            Case 374
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                    .Add("升級到LV45")
                End With
                With EvoluteToNumersTemp
                    .Add("375")
                    .Add("376")
                End With
            Case 375
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV45")
                End With
                With EvoluteToNumersTemp
                    .Add("376")
                End With
            Case 376
                IsEvolutionsAvailableTemp = False
            Case 377
                IsEvolutionsAvailableTemp = False
            Case 378
                IsEvolutionsAvailableTemp = False
            Case 379
                IsEvolutionsAvailableTemp = False
            Case 380
                IsEvolutionsAvailableTemp = False
            Case 381
                IsEvolutionsAvailableTemp = False
            Case 382
                IsEvolutionsAvailableTemp = False
            Case 383
                IsEvolutionsAvailableTemp = False
            Case 384
                IsEvolutionsAvailableTemp = False
            Case 385
                IsEvolutionsAvailableTemp = False
            Case 386
                IsEvolutionsAvailableTemp = False
            Case 387
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("388")
                    .Add("389")
                End With
            Case 388
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("389")
                End With
            Case 389
                IsEvolutionsAvailableTemp = False
            Case 390
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV14")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("391")
                    .Add("392")
                End With
            Case 391
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("392")
                End With
            Case 392
                IsEvolutionsAvailableTemp = False
            Case 393
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("394")
                    .Add("395")
                End With
            Case 394
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("395")
                End With
            Case 395
                IsEvolutionsAvailableTemp = False
            Case 396
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV14")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("397")
                    .Add("398")
                End With
            Case 397
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("399")
                End With
            Case 398
                IsEvolutionsAvailableTemp = False
            Case 399
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV15")
                End With
                With EvoluteToNumersTemp
                    .Add("400")
                End With
            Case 400
                IsEvolutionsAvailableTemp = False
            Case 401
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV10")
                End With
                With EvoluteToNumersTemp
                    .Add("402")
                End With
            Case 402
                IsEvolutionsAvailableTemp = False
            Case 403
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV15")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("404")
                    .Add("405")
                End With
            Case 404
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("405")
                End With
            Case 405
                IsEvolutionsAvailableTemp = False
            Case 406
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("白天親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("315")
                End With
            Case 407
                IsEvolutionsAvailableTemp = False
            Case 408
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("409")
                End With
            Case 409
                IsEvolutionsAvailableTemp = False
            Case 410
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("411")
                End With
            Case 411
                IsEvolutionsAvailableTemp = False
            Case 412
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("雌性升級到LV20")
                    .Add("雄性草木蓑衣型態升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("413")
                    .Add("414")
                End With
            Case 413
                IsEvolutionsAvailableTemp = False
            Case 414
                IsEvolutionsAvailableTemp = False
            Case 415
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("雌性升級到LV21")
                End With
                With EvoluteToNumersTemp
                    .Add("416")
                End With
            Case 416
                IsEvolutionsAvailableTemp = False
            Case 417
                IsEvolutionsAvailableTemp = False
            Case 418
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV26")
                End With
                With EvoluteToNumersTemp
                    .Add("419")
                End With
            Case 419
                IsEvolutionsAvailableTemp = False
            Case 420
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("421")
                End With
            Case 421
                IsEvolutionsAvailableTemp = False
            Case 422
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("423")
                End With
            Case 423
                IsEvolutionsAvailableTemp = False
            Case 424
                IsEvolutionsAvailableTemp = False
            Case 425
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("426")
                End With
            Case 426
                IsEvolutionsAvailableTemp = False
            Case 427
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("428")
                End With
            Case 428
                IsEvolutionsAvailableTemp = False
            Case 429
                IsEvolutionsAvailableTemp = False
            Case 430
                IsEvolutionsAvailableTemp = False
            Case 431
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("432")
                End With
            Case 432
                IsEvolutionsAvailableTemp = False
            Case 433
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("夜晚親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("358")
                End With
            Case 434
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("435")
                End With
            Case 435
                IsEvolutionsAvailableTemp = False
            Case 436
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV33")
                End With
                With EvoluteToNumersTemp
                    .Add("437")
                End With
            Case 437
                IsEvolutionsAvailableTemp = False
            Case 438
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[模仿]")
                End With
                With EvoluteToNumersTemp
                    .Add("185")
                End With
            Case 439
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[模仿]")
                End With
                With EvoluteToNumersTemp
                    .Add("122")
                End With
            Case 440
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("白天攜帶[渾圓之石]升級進化或白天在《傳說 阿爾宙斯》版中使用[渾圓之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("113")
                End With
            Case 441
                IsEvolutionsAvailableTemp = False
            Case 442
                IsEvolutionsAvailableTemp = False
            Case 443
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                    .Add("升級到LV48")
                End With
                With EvoluteToNumersTemp
                    .Add("444")
                    .Add("445")
                End With
            Case 444
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV48")
                End With
                With EvoluteToNumersTemp
                    .Add("445")
                End With
            Case 445
                IsEvolutionsAvailableTemp = False
            Case 446
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("143")
                End With
            Case 447
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("白天親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("448")
                End With
            Case 448
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("447")
                End With
            Case 449
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("450")
                End With
            Case 450
                IsEvolutionsAvailableTemp = False
            Case 451
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("452")
                End With
            Case 452
                IsEvolutionsAvailableTemp = False
            Case 453
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("454")
                End With
            Case 454
                IsEvolutionsAvailableTemp = False
            Case 455
                IsEvolutionsAvailableTemp = False
            Case 456
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV31")
                End With
                With EvoluteToNumersTemp
                    .Add("457")
                End With
            Case 457
                IsEvolutionsAvailableTemp = False
            Case 458
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("隊伍中有No.223[鐵炮魚]時進化")
                End With
                With EvoluteToNumersTemp
                    .Add("226")
                End With
            Case 459
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("460")
                End With
            Case 460
                IsEvolutionsAvailableTemp = False
            Case 461
                IsEvolutionsAvailableTemp = False
            Case 462
                IsEvolutionsAvailableTemp = False
            Case 463
                IsEvolutionsAvailableTemp = False
            Case 464
                IsEvolutionsAvailableTemp = False
            Case 465
                IsEvolutionsAvailableTemp = False
            Case 466
                IsEvolutionsAvailableTemp = False
            Case 467
                IsEvolutionsAvailableTemp = False
            Case 468
                IsEvolutionsAvailableTemp = False
            Case 469
                IsEvolutionsAvailableTemp = False
            Case 470
                IsEvolutionsAvailableTemp = False
            Case 471
                IsEvolutionsAvailableTemp = False
            Case 472
                IsEvolutionsAvailableTemp = False
            Case 473
                IsEvolutionsAvailableTemp = False
            Case 474
                IsEvolutionsAvailableTemp = False
            Case 475
                IsEvolutionsAvailableTemp = False
            Case 476
                IsEvolutionsAvailableTemp = False
            Case 477
                IsEvolutionsAvailableTemp = False
            Case 478
                IsEvolutionsAvailableTemp = False
            Case 479
                IsEvolutionsAvailableTemp = False
            Case 480
                IsEvolutionsAvailableTemp = False
            Case 481
                IsEvolutionsAvailableTemp = False
            Case 482
                IsEvolutionsAvailableTemp = False
            Case 483
                IsEvolutionsAvailableTemp = False
            Case 484
                IsEvolutionsAvailableTemp = False
            Case 485
                IsEvolutionsAvailableTemp = False
            Case 486
                IsEvolutionsAvailableTemp = False
            Case 487
                IsEvolutionsAvailableTemp = False
            Case 488
                IsEvolutionsAvailableTemp = False
            Case 489
                IsEvolutionsAvailableTemp = False
            Case 490
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("和百變怪生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("489")
                End With
            Case 491
                IsEvolutionsAvailableTemp = False
            Case 492
                IsEvolutionsAvailableTemp = False
            Case 493
                IsEvolutionsAvailableTemp = False
            Case 494
                IsEvolutionsAvailableTemp = False
            Case 495
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV17")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("496")
                    .Add("497")
                End With
            Case 496
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("497")
                End With
            Case 497
                IsEvolutionsAvailableTemp = False
            Case 498
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV17")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("499")
                    .Add("500")
                End With
            Case 499
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("500")
                End With
            Case 500
                IsEvolutionsAvailableTemp = False
            Case 501
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV17")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("502")
                    .Add("503")
                End With
            Case 502
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("503")
                End With
            Case 503
                IsEvolutionsAvailableTemp = False
            Case 504
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("505")
                End With
            Case 505
                IsEvolutionsAvailableTemp = False
            Case 506
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("507")
                    .Add("508")
                End With
            Case 507
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("508")
                End With
            Case 508
                IsEvolutionsAvailableTemp = False
            Case 509
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("510")
                End With
            Case 510
                IsEvolutionsAvailableTemp = False
            Case 511
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("512")
                End With
            Case 512
                IsEvolutionsAvailableTemp = False
            Case 513
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[火之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("514")
                End With
            Case 514
                IsEvolutionsAvailableTemp = False
            Case 515
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("516")
                End With
            Case 516
                IsEvolutionsAvailableTemp = False
            Case 517
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("518")
                End With
            Case 518
                IsEvolutionsAvailableTemp = False
            Case 519
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV21")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("520")
                    .Add("521")
                End With
            Case 520
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("521")
                End With
            Case 521
                IsEvolutionsAvailableTemp = False
            Case 522
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV27")
                End With
                With EvoluteToNumersTemp
                    .Add("523")
                End With
            Case 523
                IsEvolutionsAvailableTemp = False
            Case 524
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("525")
                End With
            Case 525
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("526")
                End With
            Case 526
                IsEvolutionsAvailableTemp = False
            Case 527
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("528")
                End With
            Case 528
                IsEvolutionsAvailableTemp = False
            Case 529
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV31")
                End With
                With EvoluteToNumersTemp
                    .Add("530")
                End With
            Case 531
                IsEvolutionsAvailableTemp = False
            Case 532
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("533")
                End With
            Case 533
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("534")
                End With
            Case 534
                IsEvolutionsAvailableTemp = False
            Case 535
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("536")
                    .Add("537")
                End With
            Case 536
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("537")
                End With
            Case 537
                IsEvolutionsAvailableTemp = False
            Case 538
                IsEvolutionsAvailableTemp = False
            Case 539
                IsEvolutionsAvailableTemp = False
            Case 540
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("541")
                End With
            Case 541
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("542")
                End With
            Case 542
                IsEvolutionsAvailableTemp = False
            Case 543
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("544")
                    .Add("545")
                End With
            Case 544
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("545")
                End With
            Case 545
                IsEvolutionsAvailableTemp = False
            Case 546
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("547")
                End With
            Case 547
                IsEvolutionsAvailableTemp = False
            Case 548
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("549")
                End With
            Case 549
                IsEvolutionsAvailableTemp = False
            Case 550
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("(白條紋的樣子)累計受到至少294點反作用力傷害(不計造成自己瀕死的傷害)")
                End With
                With EvoluteToNumersTemp
                    .Add("902")
                End With
            Case 551
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV29")
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("552")
                    .Add("553")
                End With
            Case 552
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("553")
                End With
            Case 553
                IsEvolutionsAvailableTemp = False
            Case 554
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("555")
                End With
            Case 555
                IsEvolutionsAvailableTemp = False
            Case 556
                IsEvolutionsAvailableTemp = False
            Case 557
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                    .Add("(伽勒爾的樣子)使用[冰之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("558")
                    .Add("558")
                End With
            Case 558
                IsEvolutionsAvailableTemp = False
            Case 559
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV39")
                End With
                With EvoluteToNumersTemp
                    .Add("560")
                End With
            Case 560
                IsEvolutionsAvailableTemp = False
            Case 561
                IsEvolutionsAvailableTemp = False
            Case 562
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                    .Add("(伽勒爾的樣子)受到至少50傷害後來到沙塵窪地岩門附近")
                End With
                With EvoluteToNumersTemp
                    .Add("563")
                    .Add("867")
                End With
            Case 563
                IsEvolutionsAvailableTemp = False
            Case 564
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("565")
                End With
            Case 565
                IsEvolutionsAvailableTemp = False
            Case 566
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("567")
                End With
            Case 567
                IsEvolutionsAvailableTemp = False
            Case 568
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("569")
                End With
            Case 569
                IsEvolutionsAvailableTemp = False
            Case 570
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("571")
                End With
            Case 571
                IsEvolutionsAvailableTemp = False
            Case 572
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[光只石]")
                End With
                With EvoluteToNumersTemp
                    .Add("573")
                End With
            Case 573
                IsEvolutionsAvailableTemp = False
            Case 574
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                    .Add("升級到LV41")
                End With
                With EvoluteToNumersTemp
                    .Add("575")
                    .Add("576")
                End With
            Case 575
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV41")
                End With
                With EvoluteToNumersTemp
                    .Add("576")
                End With
            Case 576
                IsEvolutionsAvailableTemp = False
            Case 577
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                    .Add("升級到LV41")
                End With
                With EvoluteToNumersTemp
                    .Add("578")
                    .Add("579")
                End With
            Case 578
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV41")
                End With
                With EvoluteToNumersTemp
                    .Add("579")
                End With
            Case 579
                IsEvolutionsAvailableTemp = False
            Case 580
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("581")
                End With
            Case 581
                IsEvolutionsAvailableTemp = False
            Case 582
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                    .Add("升級到LV47")
                End With
                With EvoluteToNumersTemp
                    .Add("583")
                    .Add("584")
                End With
            Case 583
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV47")
                End With
                With EvoluteToNumersTemp
                    .Add("584")
                End With
            Case 584
                IsEvolutionsAvailableTemp = False
            Case 585
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("586")
                End With
            Case 586
                IsEvolutionsAvailableTemp = False
            Case 587
                IsEvolutionsAvailableTemp = False
            Case 588
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("與No.616[小嘴蜗]通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("589")
                End With
            Case 589
                IsEvolutionsAvailableTemp = False
            Case 590
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV39")
                End With
                With EvoluteToNumersTemp
                    .Add("591")
                End With
            Case 591
                IsEvolutionsAvailableTemp = False
            Case 592
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("593")
                End With
            Case 593
                IsEvolutionsAvailableTemp = False
            Case 594
                IsEvolutionsAvailableTemp = False
            Case 595
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("596")
                End With
            Case 596
                IsEvolutionsAvailableTemp = False
            Case 597
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("598")
                End With
            Case 598
                IsEvolutionsAvailableTemp = False
            Case 599
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV38")
                    .Add("升級到LV49")
                End With
                With EvoluteToNumersTemp
                    .Add("600")
                    .Add("601")
                End With
            Case 600
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV49")
                End With
                With EvoluteToNumersTemp
                    .Add("601")
                End With
            Case 601
                IsEvolutionsAvailableTemp = False
            Case 602
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV39")
                End With
                With EvoluteToNumersTemp
                    .Add("603")
                End With
            Case 603
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[雷之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("604")
                End With
            Case 604
                IsEvolutionsAvailableTemp = False
            Case 605
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    .Add("606")
                End With
            Case 606
                IsEvolutionsAvailableTemp = False
            Case 607
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV41")
                End With
                With EvoluteToNumersTemp
                    .Add("608")
                End With
            Case 608
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[暗之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("609")
                End With
            Case 609
                IsEvolutionsAvailableTemp = False
            Case 610
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV38")
                    .Add("升級到LV48")
                End With
                With EvoluteToNumersTemp
                    .Add("611")
                    .Add("612")
                End With
            Case 611
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV48")
                End With
                With EvoluteToNumersTemp
                    .Add("612")
                End With
            Case 612
                IsEvolutionsAvailableTemp = False
            Case 613
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("614")
                End With
            Case 614
                IsEvolutionsAvailableTemp = False
            Case 615
                IsEvolutionsAvailableTemp = False
            Case 616
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("與No.588[蓋蓋蟲]通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("617")
                End With
            Case 617
                IsEvolutionsAvailableTemp = False
            Case 618
                IsEvolutionsAvailableTemp = False
            Case 619
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV50")
                End With
                With EvoluteToNumersTemp
                    .Add("620")
                End With
            Case 620
                IsEvolutionsAvailableTemp = False
            Case 621
                IsEvolutionsAvailableTemp = False
            Case 622
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV43")
                End With
                With EvoluteToNumersTemp
                    .Add("623")
                End With
            Case 623
                IsEvolutionsAvailableTemp = False
            Case 624
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV52")
                End With
                With EvoluteToNumersTemp
                    .Add("625")
                End With
            Case 625
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("擊倒3隻群體中攜帶有[頭領憑證]的[劈斬司令]後提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("983")
                End With
            Case 626
                IsEvolutionsAvailableTemp = False
            Case 627
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV54")
                End With
                With EvoluteToNumersTemp
                    .Add("628")
                End With
            Case 628
                IsEvolutionsAvailableTemp = False
            Case 629
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV54")
                End With
                With EvoluteToNumersTemp
                    .Add("630")
                End With
            Case 630
                IsEvolutionsAvailableTemp = False
            Case 631
                IsEvolutionsAvailableTemp = False
            Case 632
                IsEvolutionsAvailableTemp = False
            Case 633
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV50")
                    .Add("升級到LV64")
                End With
                With EvoluteToNumersTemp
                    .Add("634")
                    .Add("635")
                End With
            Case 634
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV64")
                End With
                With EvoluteToNumersTemp
                    .Add("635")
                End With
            Case 635
                IsEvolutionsAvailableTemp = False
            Case 636
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV59")
                End With
                With EvoluteToNumersTemp
                    .Add("637")
                End With
            Case 638
                IsEvolutionsAvailableTemp = False
            Case 639
                IsEvolutionsAvailableTemp = False
            Case 640
                IsEvolutionsAvailableTemp = False
            Case 641
                IsEvolutionsAvailableTemp = False
            Case 642
                IsEvolutionsAvailableTemp = False
            Case 643
                IsEvolutionsAvailableTemp = False
            Case 644
                IsEvolutionsAvailableTemp = False
            Case 645
                IsEvolutionsAvailableTemp = False
            Case 646
                IsEvolutionsAvailableTemp = False
            Case 647
                IsEvolutionsAvailableTemp = False
            Case 648
                IsEvolutionsAvailableTemp = False
            Case 649
                IsEvolutionsAvailableTemp = False
            Case 650
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("651")
                    .Add("652")
                End With
            Case 651
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("652")
                End With
            Case 652
                IsEvolutionsAvailableTemp = False
            Case 653
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("654")
                    .Add("655")
                End With
            Case 654
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("655")
                End With
            Case 655
                IsEvolutionsAvailableTemp = False
            Case 656
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("657")
                    .Add("658")
                End With
            Case 657
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("658")
                End With
            Case 658
                IsEvolutionsAvailableTemp = False
            Case 659
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("660")
                End With
            Case 660
                IsEvolutionsAvailableTemp = False
            Case 661
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV17")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("662")
                    .Add("663")
                End With
            Case 662
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("663")
                End With
            Case 663
                IsEvolutionsAvailableTemp = False
            Case 664
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV9")
                End With
                With EvoluteToNumersTemp
                    .Add("665")
                End With
            Case 665
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV12")
                End With
                With EvoluteToNumersTemp
                    .Add("666")
                End With
            Case 666
                IsEvolutionsAvailableTemp = False
            Case 667
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("668")
                End With
            Case 668
                IsEvolutionsAvailableTemp = False
            Case 669
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV19")
                End With
                With EvoluteToNumersTemp
                    .Add("670")
                End With
            Case 670
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[光之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("671")
                End With
            Case 671
                IsEvolutionsAvailableTemp = False
            Case 672
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("673")
                End With
            Case 673
                IsEvolutionsAvailableTemp = False
            Case 674
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("隊伍中有惡屬性神奇寶貝且升級到LV32")
                End With
                With EvoluteToNumersTemp
                    .Add("675")
                End With
            Case 675
                IsEvolutionsAvailableTemp = False
            Case 676
                IsEvolutionsAvailableTemp = False
            Case 677
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("678")
                End With
            Case 678
                IsEvolutionsAvailableTemp = False
            Case 679
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("680")
                End With
            Case 680
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[暗之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("681")
                End With
            Case 681
                IsEvolutionsAvailableTemp = False
            Case 682
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[香囊]通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("683")
                End With
            Case 683
                IsEvolutionsAvailableTemp = False
            Case 684
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[奶油棒糖]通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("685")
                End With
            Case 685
                IsEvolutionsAvailableTemp = False
            Case 686
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30且遊戲機倒置")
                End With
                With EvoluteToNumersTemp
                    .Add("687")
                End With
            Case 687
                IsEvolutionsAvailableTemp = False
            Case 688
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV39")
                End With
                With EvoluteToNumersTemp
                    .Add("689")
                End With
            Case 689
                IsEvolutionsAvailableTemp = False
            Case 690
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV48")
                End With
                With EvoluteToNumersTemp
                    .Add("691")
                End With
            Case 691
                IsEvolutionsAvailableTemp = False
            Case 692
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("693")
                End With
            Case 693
                IsEvolutionsAvailableTemp = False
            Case 694
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("695")
                End With
            Case 695
                IsEvolutionsAvailableTemp = False
            Case 696
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV39")
                End With
                With EvoluteToNumersTemp
                    .Add("697")
                End With
            Case 697
                IsEvolutionsAvailableTemp = False
            Case 698
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("夜晚升級到LV39")
                End With
                With EvoluteToNumersTemp
                    .Add("699")
                End With
            Case 699
                IsEvolutionsAvailableTemp = False
            Case 700
                IsEvolutionsAvailableTemp = False
            Case 701
                IsEvolutionsAvailableTemp = False
            Case 702
                IsEvolutionsAvailableTemp = False
            Case 703
                IsEvolutionsAvailableTemp = False
            Case 704
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("705")
                End With
            Case 705
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("下雨時升級到LV50")
                End With
                With EvoluteToNumersTemp
                    .Add("706")
                End With
            Case 706
                IsEvolutionsAvailableTemp = False
            Case 707
                IsEvolutionsAvailableTemp = False
            Case 708
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("709")
                End With
            Case 709
                IsEvolutionsAvailableTemp = False
            Case 710
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("通信進化")
                End With
                With EvoluteToNumersTemp
                    .Add("711")
                End With
            Case 711
                IsEvolutionsAvailableTemp = False
            Case 712
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV37")
                End With
                With EvoluteToNumersTemp
                    .Add("713")
                End With
            Case 713
                IsEvolutionsAvailableTemp = False
            Case 714
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV48")
                End With
                With EvoluteToNumersTemp
                    .Add("715")
                End With
            Case 715
                IsEvolutionsAvailableTemp = False
            Case 716
                IsEvolutionsAvailableTemp = False
            Case 717
                IsEvolutionsAvailableTemp = False
            Case 718
                IsEvolutionsAvailableTemp = False
            Case 719
                IsEvolutionsAvailableTemp = False
            Case 720
                IsEvolutionsAvailableTemp = False
            Case 721
                IsEvolutionsAvailableTemp = False
            Case 722
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV17")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("723")
                    .Add("724")
                End With
            Case 723
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("724")
                End With
            Case 724
                IsEvolutionsAvailableTemp = False
            Case 725
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV17")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("726")
                    .Add("727")
                End With
            Case 726
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("726")
                End With
            Case 727
                IsEvolutionsAvailableTemp = False
            Case 728
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV17")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("729")
                    .Add("730")
                End With
            Case 729
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("730")
                End With
            Case 730
                IsEvolutionsAvailableTemp = False
            Case 731
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV14")
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("732")
                    .Add("733")
                End With
            Case 732
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("733")
                End With
            Case 733
                IsEvolutionsAvailableTemp = False
            Case 734
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("白天升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("735")
                End With
            Case 735
                IsEvolutionsAvailableTemp = False
            Case 736
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("737")
                End With
            Case 737
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("強磁場區域升級進化或(第八世代起)使用[雷之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("738")
                End With
            Case 738
                IsEvolutionsAvailableTemp = False
            Case 739
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("拉納基拉山升級進化或(第九世代起)使用[冰之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("740")
                End With
            Case 740
                IsEvolutionsAvailableTemp = False
            Case 741
                IsEvolutionsAvailableTemp = False
            Case 742
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("743")
                End With
            Case 743
                IsEvolutionsAvailableTemp = False
            Case 744
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("745")
                End With
            Case 745
                IsEvolutionsAvailableTemp = False
            Case 746
                IsEvolutionsAvailableTemp = False
            Case 747
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("748")
                End With
            Case 748
                IsEvolutionsAvailableTemp = False
            Case 749
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("750")
                End With
            Case 750
                IsEvolutionsAvailableTemp = False
            Case 751
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                End With
                With EvoluteToNumersTemp
                    .Add("752")
                End With
            Case 752
                IsEvolutionsAvailableTemp = False
            Case 753
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("白天升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("754")
                End With
            Case 754
                IsEvolutionsAvailableTemp = False
            Case 755
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                End With
                With EvoluteToNumersTemp
                    .Add("756")
                End With
            Case 756
                IsEvolutionsAvailableTemp = False
            Case 757
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("雌性升級到LV33")
                End With
                With EvoluteToNumersTemp
                    .Add("758")
                End With
            Case 758
                IsEvolutionsAvailableTemp = False
            Case 759
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV27")
                End With
                With EvoluteToNumersTemp
                    .Add("760")
                End With
            Case 760
                IsEvolutionsAvailableTemp = False
            Case 761
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                End With
                With EvoluteToNumersTemp
                    .Add("762")
                End With
            Case 762
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[踩踏]")
                End With
                With EvoluteToNumersTemp
                    .Add("763")
                End With
            Case 763
                IsEvolutionsAvailableTemp = False
            Case 764
                IsEvolutionsAvailableTemp = False
            Case 765
                IsEvolutionsAvailableTemp = False
            Case 766
                IsEvolutionsAvailableTemp = False
            Case 767
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("768")
                End With
            Case 768
                IsEvolutionsAvailableTemp = False
            Case 769
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    .Add("770")
                End With
            Case 770
                IsEvolutionsAvailableTemp = False
            Case 771
                IsEvolutionsAvailableTemp = False
            Case 772
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度220以上或友好度158以上提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("773")
                End With
            Case 773
                IsEvolutionsAvailableTemp = False
            Case 774
                IsEvolutionsAvailableTemp = False
            Case 775
                IsEvolutionsAvailableTemp = False
            Case 776
                IsEvolutionsAvailableTemp = False
            Case 777
                IsEvolutionsAvailableTemp = False
            Case 778
                IsEvolutionsAvailableTemp = False
            Case 779
                IsEvolutionsAvailableTemp = False
            Case 780
                IsEvolutionsAvailableTemp = False
            Case 781
                IsEvolutionsAvailableTemp = False
            Case 782
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                    .Add("升級到LV45")
                End With
                With EvoluteToNumersTemp
                    .Add("783")
                    .Add("784")
                End With
            Case 783
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV45")
                End With
                With EvoluteToNumersTemp
                    .Add("784")
                End With
            Case 784
                IsEvolutionsAvailableTemp = False
            Case 785
                IsEvolutionsAvailableTemp = False
            Case 786
                IsEvolutionsAvailableTemp = False
            Case 787
                IsEvolutionsAvailableTemp = False
            Case 788
                IsEvolutionsAvailableTemp = False
            Case 789
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV43")
                End With
                With EvoluteToNumersTemp
                    .Add("790")
                End With
            Case 790
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("太陽版升級到LV53")
                    .Add("月亮版升級到LV53")
                End With
                With EvoluteToNumersTemp
                    .Add("791")
                    .Add("792")
                End With
            Case 791
                IsEvolutionsAvailableTemp = False
            Case 792
                IsEvolutionsAvailableTemp = False
            Case 793
                IsEvolutionsAvailableTemp = False
            Case 794
                IsEvolutionsAvailableTemp = False
            Case 795
                IsEvolutionsAvailableTemp = False
            Case 796
                IsEvolutionsAvailableTemp = False
            Case 797
                IsEvolutionsAvailableTemp = False
            Case 798
                IsEvolutionsAvailableTemp = False
            Case 799
                IsEvolutionsAvailableTemp = False
            Case 800
                IsEvolutionsAvailableTemp = False
            Case 801
                IsEvolutionsAvailableTemp = False
            Case 802
                IsEvolutionsAvailableTemp = False
            Case 803
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("習得技能[龍之波動]")
                End With
                With EvoluteToNumersTemp
                    .Add("804")
                End With
            Case 804
                IsEvolutionsAvailableTemp = False
            Case 805
                IsEvolutionsAvailableTemp = False
            Case 806
                IsEvolutionsAvailableTemp = False
            Case 807
                IsEvolutionsAvailableTemp = False
            Case 808
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("在Pokémon GO中消耗400個美錄坦的糖果")
                End With
                With EvoluteToNumersTemp
                    .Add("809")
                End With
            Case 809
                IsEvolutionsAvailableTemp = False
        End Select
    End Sub
    Private Sub GenerateSingleLinkEvolutionDataSSSV(PokemonNationalDexNumberToQuery As Integer)
        IsEvolutionsAvailableTemp = False
        EvoluteToNumersTemp.Clear()
        EvolutionRoutinsTemp.Clear()
        Select Case PokemonNationalDexNumberToQuery
            Case 810
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("811")
                    .Add("812")
                End With
            Case 811
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    '.Add("811")
                    .Add("812")
                End With
            Case 812
                IsEvolutionsAvailableTemp = False
            Case 813
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("814")
                    .Add("815")
                End With
            Case 814
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    '.Add("814")
                    .Add("815")
                End With
            Case 815
                IsEvolutionsAvailableTemp = False
            Case 816
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("817")
                    .Add("818")
                End With
            Case 817
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    '.Add("817")
                    .Add("818")
                End With
            Case 818
                IsEvolutionsAvailableTemp = False
            Case 819
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                End With
                With EvoluteToNumersTemp
                    .Add("820")
                End With
            Case 820
                IsEvolutionsAvailableTemp = False
            Case 821
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("822")
                    .Add("823")
                End With
            Case 822
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV18")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    '.Add("822")
                    .Add("823")
                End With
            Case 823
                IsEvolutionsAvailableTemp = False
            Case 824
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV10")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("825")
                    .Add("826")
                End With
            Case 825
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV10")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    '.Add("825")
                    .Add("826")
                End With
            Case 826
                IsEvolutionsAvailableTemp = False
            Case 827
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                End With
                With EvoluteToNumersTemp
                    .Add("828")
                End With
            Case 828
                IsEvolutionsAvailableTemp = False
            Case 829
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV20")
                End With
                With EvoluteToNumersTemp
                    .Add("830")
                End With
            Case 830
                IsEvolutionsAvailableTemp = False
            Case 831
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                End With
                With EvoluteToNumersTemp
                    .Add("832")
                End With
            Case 832
                IsEvolutionsAvailableTemp = False
            Case 833
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV22")
                End With
                With EvoluteToNumersTemp
                    .Add("834")
                End With
            Case 834
                IsEvolutionsAvailableTemp = False
            Case 835
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("836")
                End With
            Case 836
                IsEvolutionsAvailableTemp = False
            Case 837
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("838")
                    .Add("839")
                End With
            Case 838
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV18")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    '.Add("838")
                    .Add("839")
                End With
            Case 839
                IsEvolutionsAvailableTemp = False
            Case 840
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用酸酸蘋果")
                    .Add("使用甜甜蘋果")
                End With
                With EvoluteToNumersTemp
                    .Add("841")
                    .Add("842")
                End With
            Case 841
                IsEvolutionsAvailableTemp = False
            Case 842
                IsEvolutionsAvailableTemp = False
            Case 843
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("844")
                End With
            Case 844
                IsEvolutionsAvailableTemp = False
            Case 845
                IsEvolutionsAvailableTemp = False
            Case 846
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV26")
                End With
                With EvoluteToNumersTemp
                    .Add("847")
                End With
            Case 847
                IsEvolutionsAvailableTemp = False
            Case 848
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("849")
                End With
            Case 849
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("生蛋")
                End With
                With EvoluteToNumersTemp
                    .Add("848")
                End With
            Case 850
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("851")
                End With
            Case 851
                IsEvolutionsAvailableTemp = False
            Case 852
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("學會[挑釁]時提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("853")
                End With
            Case 853
                IsEvolutionsAvailableTemp = False
            Case 854
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[破裂的茶壺]或[缺損的茶壺]")
                End With
                With EvoluteToNumersTemp
                    .Add("855")
                End With
            Case 855
                IsEvolutionsAvailableTemp = False
            Case 856
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    .Add("857")
                    .Add("858")
                End With
            Case 857
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV32")
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    '.Add("857")
                    .Add("858")
                End With
            Case 858
                IsEvolutionsAvailableTemp = False
            Case 859
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV32")
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    .Add("860")
                    .Add("861")
                End With
            Case 860
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV32")
                    .Add("升級到LV42")
                End With
                With EvoluteToNumersTemp
                    '.Add("860")
                    .Add("861")
                End With
            Case 861
                IsEvolutionsAvailableTemp = False
            Case 862
                IsEvolutionsAvailableTemp = False
            Case 863
                IsEvolutionsAvailableTemp = False
            Case 864
                IsEvolutionsAvailableTemp = False
            Case 865
                IsEvolutionsAvailableTemp = False
            Case 866
                IsEvolutionsAvailableTemp = False
            Case 867
                IsEvolutionsAvailableTemp = False
            Case 868
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("攜帶[糖飾]的條件下主角結束原地旋轉")
                End With
                With EvoluteToNumersTemp
                    .Add("869")
                End With
            Case 869
                IsEvolutionsAvailableTemp = False
            Case 870
                IsEvolutionsAvailableTemp = False
            Case 871
                IsEvolutionsAvailableTemp = False
            Case 872
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("親密度158以上或友好度158以上在夜晚提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("873")
                End With
            Case 873
                IsEvolutionsAvailableTemp = False
            Case 874
                IsEvolutionsAvailableTemp = False
            Case 875
                IsEvolutionsAvailableTemp = False
            Case 876
                IsEvolutionsAvailableTemp = False
            Case 877
                IsEvolutionsAvailableTemp = False
            Case 878
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV34")
                End With
                With EvoluteToNumersTemp
                    .Add("879")
                End With
            Case 879
                IsEvolutionsAvailableTemp = False
            Case 880
                IsEvolutionsAvailableTemp = False
            Case 881
                IsEvolutionsAvailableTemp = False
            Case 882
                IsEvolutionsAvailableTemp = False
            Case 883
                IsEvolutionsAvailableTemp = False
            Case 884
                IsEvolutionsAvailableTemp = False
            Case 885
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV50")
                    .Add("升級到LV60")
                End With
                With EvoluteToNumersTemp
                    .Add("886")
                    .Add("887")
                End With
            Case 886
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV50")
                    .Add("升級到LV60")
                End With
                With EvoluteToNumersTemp
                    '.Add("886")
                    .Add("887")
                End With
            Case 887
                IsEvolutionsAvailableTemp = False
            Case 888
                IsEvolutionsAvailableTemp = False
            Case 889
                IsEvolutionsAvailableTemp = False
            Case 890
                IsEvolutionsAvailableTemp = False
            Case 891
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用/查看[惡之掛軸]或[水之掛軸]")
                End With
                With EvoluteToNumersTemp
                    .Add("892")
                End With
            Case 892
                IsEvolutionsAvailableTemp = False
            Case 893
                IsEvolutionsAvailableTemp = False
            Case 894
                IsEvolutionsAvailableTemp = False
            Case 895
                IsEvolutionsAvailableTemp = False
            Case 896
                IsEvolutionsAvailableTemp = False
            Case 897
                IsEvolutionsAvailableTemp = False
            Case 898
                IsEvolutionsAvailableTemp = False
            Case 899
                IsEvolutionsAvailableTemp = False
            Case 900
                IsEvolutionsAvailableTemp = False
            Case 901
                IsEvolutionsAvailableTemp = False
            Case 902
                IsEvolutionsAvailableTemp = False
            Case 903
                IsEvolutionsAvailableTemp = False
            Case 904
                IsEvolutionsAvailableTemp = False
            Case 905
                IsEvolutionsAvailableTemp = False
            Case 906
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("907")
                    .Add("908")
                End With
            Case 907
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    '.Add("907")
                    .Add("908")
                End With
            Case 908
                IsEvolutionsAvailableTemp = False
            Case 909
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("910")
                    .Add("911")
                End With
            Case 910
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    '.Add("910")
                    .Add("911")
                End With
            Case 911
                IsEvolutionsAvailableTemp = False
            Case 912
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumersTemp
                    .Add("913")
                    .Add("914")
                End With
            Case 913
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV16")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    '.Add("913")
                    .Add("914")
                End With
            Case 914
                IsEvolutionsAvailableTemp = False
            Case 915
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                End With
                With EvoluteToNumersTemp
                    .Add("916")
                End With
            Case 916
                IsEvolutionsAvailableTemp = False
            Case 917
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV15")
                End With
                With EvoluteToNumersTemp
                    .Add("918")
                End With
            Case 918
                IsEvolutionsAvailableTemp = False
            Case 919
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                End With
                With EvoluteToNumersTemp
                    .Add("920")
                End With
            Case 920
                IsEvolutionsAvailableTemp = False
            Case 921
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV18")
                End With
                With EvoluteToNumersTemp
                    .Add("922")
                End With
            Case 922
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("在Let's Go模式中行走1000步後提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("923")
                End With
            Case 923
                IsEvolutionsAvailableTemp = False
            Case 924
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("等級通過對戰達到25以上")
                End With
                With EvoluteToNumersTemp
                    .Add("925")
                End With
            Case 925
                IsEvolutionsAvailableTemp = False
            Case 926
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV26")
                End With
                With EvoluteToNumersTemp
                    .Add("927")
                End With
            Case 927
                IsEvolutionsAvailableTemp = False
            Case 928
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("929")
                    .Add("930")
                End With
            Case 929
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV25")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    '.Add("929")
                    .Add("930")
                End With
            Case 930
                IsEvolutionsAvailableTemp = False
            Case 931
                IsEvolutionsAvailableTemp = False
            Case 932
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("933")
                    .Add("934")
                End With
            Case 933
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV24")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    '.Add("933")
                    .Add("934")
                End With
            Case 934
                IsEvolutionsAvailableTemp = False
            Case 935
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[慶祝之鎧]")
                    .Add("使用[詛咒之鎧]")
                End With
                With EvoluteToNumersTemp
                    .Add("936")
                    .Add("937")
                End With
            Case 936
                IsEvolutionsAvailableTemp = False
            Case 937
                IsEvolutionsAvailableTemp = False
            Case 938
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[雷之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("939")
                End With
            Case 939
                IsEvolutionsAvailableTemp = False
            Case 940
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV25")
                End With
                With EvoluteToNumersTemp
                    .Add("941")
                End With
            Case 941
                IsEvolutionsAvailableTemp = False
            Case 942
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("943")
                End With
            Case 943
                IsEvolutionsAvailableTemp = False
            Case 944
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("945")
                End With
            Case 945
                IsEvolutionsAvailableTemp = False
            Case 946
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("在Let's Go模式中行走1000步後提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("947")
                End With
            Case 947
                IsEvolutionsAvailableTemp = False
            Case 948
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("949")
                End With
            Case 949
                IsEvolutionsAvailableTemp = False
            Case 950
                IsEvolutionsAvailableTemp = False
            Case 951
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[火之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("952")
                End With
            Case 952
                IsEvolutionsAvailableTemp = False
            Case 953
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("在Let's Go模式中行走1000步後提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("954")
                End With
            Case 954
                IsEvolutionsAvailableTemp = False
            Case 955
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("956")
                End With
            Case 956
                IsEvolutionsAvailableTemp = False
            Case 957
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("958")
                    .Add("959")
                End With
            Case 958
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV24")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    '.Add("958")
                    .Add("959")
                End With
            Case 959
                IsEvolutionsAvailableTemp = False
            Case 960
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV26")
                End With
                With EvoluteToNumersTemp
                    .Add("961")
                End With
            Case 961
                IsEvolutionsAvailableTemp = False
            Case 962
                IsEvolutionsAvailableTemp = False
            Case 963
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("在聯機遊玩中升級到LV28")
                End With
                With EvoluteToNumersTemp
                    .Add("964")
                End With
            Case 964
                IsEvolutionsAvailableTemp = False
            Case 965
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV40")
                End With
                With EvoluteToNumersTemp
                    .Add("966")
                End With
            Case 966
                IsEvolutionsAvailableTemp = False
            Case 967
                IsEvolutionsAvailableTemp = False
            Case 968
                IsEvolutionsAvailableTemp = False
            Case 969
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV35")
                End With
                With EvoluteToNumersTemp
                    .Add("970")
                End With
            Case 970
                IsEvolutionsAvailableTemp = False
            Case 971
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV30")
                End With
                With EvoluteToNumersTemp
                    .Add("972")
                End With
            Case 972
                IsEvolutionsAvailableTemp = False
            Case 973
                IsEvolutionsAvailableTemp = False
            Case 974
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("使用[冰之石]")
                End With
                With EvoluteToNumersTemp
                    .Add("975")
                End With
            Case 975
                IsEvolutionsAvailableTemp = False
            Case 976
                IsEvolutionsAvailableTemp = False
            Case 977
                IsEvolutionsAvailableTemp = False
            Case 978
                IsEvolutionsAvailableTemp = False
            Case 979
                IsEvolutionsAvailableTemp = False
            Case 980
                IsEvolutionsAvailableTemp = False
            Case 981
                IsEvolutionsAvailableTemp = False
            Case 982
                IsEvolutionsAvailableTemp = False
            Case 983
                IsEvolutionsAvailableTemp = False
            Case 984
                IsEvolutionsAvailableTemp = False
            Case 985
                IsEvolutionsAvailableTemp = False
            Case 986
                IsEvolutionsAvailableTemp = False
            Case 987
                IsEvolutionsAvailableTemp = False
            Case 988
                IsEvolutionsAvailableTemp = False
            Case 989
                IsEvolutionsAvailableTemp = False
            Case 990
                IsEvolutionsAvailableTemp = False
            Case 991
                IsEvolutionsAvailableTemp = False
            Case 992
                IsEvolutionsAvailableTemp = False
            Case 993
                IsEvolutionsAvailableTemp = False
            Case 994
                IsEvolutionsAvailableTemp = False
            Case 995
                IsEvolutionsAvailableTemp = False
            Case 996
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("升級到LV24")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    .Add("997")
                    .Add("998")
                End With
            Case 997
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    '.Add("升級到LV24")
                    .Add("升級到LV38")
                End With
                With EvoluteToNumersTemp
                    '.Add("997")
                    .Add("998")
                End With
            Case 998
                IsEvolutionsAvailableTemp = False
            Case 999
                IsEvolutionsAvailableTemp = True
                With EvolutionRoutinsTemp
                    .Add("收集[索財靈的硬幣]×999後提升等級")
                End With
                With EvoluteToNumersTemp
                    .Add("1000")
                End With
            Case 1000
                IsEvolutionsAvailableTemp = False
            Case 1001
                IsEvolutionsAvailableTemp = False
            Case 1002
                IsEvolutionsAvailableTemp = False
            Case 1003
                IsEvolutionsAvailableTemp = False
            Case 1004
                IsEvolutionsAvailableTemp = False
            Case 1005
                IsEvolutionsAvailableTemp = False
            Case 1006
                IsEvolutionsAvailableTemp = False
            Case 1007
                IsEvolutionsAvailableTemp = False
            Case 1008
                IsEvolutionsAvailableTemp = False
        End Select
    End Sub
End Module
