Module libEvolutions
    Public IsEvolutionsAvailable As Boolean
    Public EvolutionRoutins As New List(Of String)
    Public EvoluteToNumers As New List(Of String)
    Public Sub GenerateEvolutionData(lpPokemonNumber As Integer)
        IsEvolutionsAvailable = False
        EvoluteToNumers.Clear()
        EvolutionRoutins.Clear()
        If lpPokemonNumber <= 809 Then
            GenerateEvolutionDataPreSS(lpPokemonNumber)
            'Elseif lpPokemonNumber <= {$SS_PMINDEX_MAX} Then
            'GenerateEvolutionDataSS(lpPokemonNumber)
        End If
    End Sub
    Public Sub GenerateEvolutionDataPreSS(lpPokemonNumber As Integer)
        IsEvolutionsAvailable = False
        EvoluteToNumers.Clear()
        EvolutionRoutins.Clear()
        Select Case lpPokemonNumber
            Case 1
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("002")
                    .Add("003")
                End With
            Case 2
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("003")
                End With
            Case 3
                IsEvolutionsAvailable = False
            Case 4
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("005")
                    .Add("006")
                End With
            Case 5
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    '.Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    '.Add("002")
                    .Add("006")
                End With
            Case 6
                IsEvolutionsAvailable = False
            Case 7
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("008")
                    .Add("009")
                End With
            Case 8
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    '.Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    '.Add("002")
                    .Add("009")
                End With
            Case 9
                IsEvolutionsAvailable = False
            Case 10
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumers
                    .Add("011")
                    .Add("012")
                End With
            Case 11
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    '.Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumers
                    '.Add("011")
                    .Add("012")
                End With
            Case 12
                IsEvolutionsAvailable = False
            Case 13
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumers
                    .Add("014")
                    .Add("015")
                End With
            Case 14
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    '.Add("升級到LV7")
                    .Add("升級到LV10")
                End With
                With EvoluteToNumers
                    '.Add("011")
                    .Add("014")
                End With
            Case 15
                IsEvolutionsAvailable = False
            Case 16
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("017")
                    .Add("018")
                End With
            Case 17
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    '.Add("升級到L")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("018")
                    '.Add("")
                End With
            Case 18
                IsEvolutionsAvailable = False
            Case 19
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    '.Add("升級到LV7")
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    '.Add("")
                    .Add("020")
                End With
            Case 20
                IsEvolutionsAvailable = False
            Case 21
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                    '.Add("升級到LV10")
                End With
                With EvoluteToNumers
                    .Add("022")
                    '.Add("")
                End With
            Case 22
                IsEvolutionsAvailable = False
            Case 23
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                End With
                With EvoluteToNumers
                    .Add("024")
                End With
            Case 24
                IsEvolutionsAvailable = False
            Case 25
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[雷之石]")
                End With
                With EvoluteToNumers
                    .Add("026")
                End With
            Case 26
                IsEvolutionsAvailable = False
            Case 27
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                End With
                With EvoluteToNumers
                    .Add("028")
                End With
            Case 28
                IsEvolutionsAvailable = False
            Case 29
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                End With
                With EvoluteToNumers
                    .Add("030")
                End With
            Case 30
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumers
                    .Add("031")
                End With
            Case 31
                IsEvolutionsAvailable = False
            Case 32
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                End With
                With EvoluteToNumers
                    .Add("033")
                End With
            Case 33
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumers
                    .Add("034")
                End With
            Case 34
                IsEvolutionsAvailable = False
            Case 35
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumers
                    .Add("036")
                End With
            Case 36
                IsEvolutionsAvailable = False
            Case 37
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[火之石]")
                End With
                With EvoluteToNumers
                    .Add("038")
                End With
            Case 38
                IsEvolutionsAvailable = False
            Case 39
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumers
                    .Add("040")
                End With
            Case 40
                IsEvolutionsAvailable = False
            Case 41
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                End With
                With EvoluteToNumers
                    .Add("042")
                End With
            Case 42
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("169")
                End With
            Case 43
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV21")
                End With
                With EvoluteToNumers
                    .Add("044")
                End With
            Case 44
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[葉之石]")
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumers
                    .Add("045")
                    .Add("182")
                End With
            Case 45
                IsEvolutionsAvailable = False
            Case 46
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV24")
                End With
                With EvoluteToNumers
                    .Add("047")
                End With
            Case 47
                IsEvolutionsAvailable = False
            Case 48
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV31")
                End With
                With EvoluteToNumers
                    .Add("049")
                End With
            Case 49
                IsEvolutionsAvailable = False
            Case 50
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV26")
                End With
                With EvoluteToNumers
                    .Add("051")
                End With
            Case 51
                IsEvolutionsAvailable = False
            Case 52
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("053")
                End With
            Case 53
                IsEvolutionsAvailable = False
            Case 54
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV33")
                End With
                With EvoluteToNumers
                    .Add("055")
                End With
            Case 55
                IsEvolutionsAvailable = False
            Case 56
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("057")
                End With
            Case 57
                IsEvolutionsAvailable = False
            Case 58
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[火之石]")
                End With
                With EvoluteToNumers
                    .Add("059")
                End With
            Case 59
                IsEvolutionsAvailable = False
            Case 60
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("061")
                End With
            Case 61
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[水之石]")
                    .Add("攜帶[王者之印]通信進化")
                End With
                With EvoluteToNumers
                    .Add("062")
                    .Add("186")
                End With
            Case 62
                IsEvolutionsAvailable = False
            Case 63
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                End With
                With EvoluteToNumers
                    .Add("064")
                End With
            Case 64
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("065")
                End With
            Case 65
                IsEvolutionsAvailable = False
            Case 66
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("067")
                End With
            Case 67
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("068")
                End With
            Case 68
                IsEvolutionsAvailable = False
            Case 69
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV21")
                End With
                With EvoluteToNumers
                    .Add("070")
                End With
            Case 70
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumers
                    .Add("071")
                End With
            Case 71
                IsEvolutionsAvailable = False
            Case 72
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("073")
                End With
            Case 73
                IsEvolutionsAvailable = False
            Case 74
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("075")
                End With
            Case 75
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("076")
                End With
            Case 76
                IsEvolutionsAvailable = False
            Case 77
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("078")
                End With
            Case 78
                IsEvolutionsAvailable = False
            Case 79
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                    .Add("攜帶[王者之印]通信進化")
                End With
                With EvoluteToNumers
                    .Add("080")
                    .Add("199")
                End With
            Case 80
                IsEvolutionsAvailable = False
            Case 81
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("082")
                End With
            Case 82
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("強磁場區域升級進化")
                End With
                With EvoluteToNumers
                    .Add("462")
                End With
            Case 83
                IsEvolutionsAvailable = False
            Case 84
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV31")
                End With
                With EvoluteToNumers
                    .Add("085")
                End With
            Case 85
                IsEvolutionsAvailable = False
            Case 86
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("087")
                End With
            Case 88
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV38")
                End With
                With EvoluteToNumers
                    .Add("089")
                End With
            Case 89
                IsEvolutionsAvailable = False
            Case 90
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumers
                    .Add("091")
                End With
            Case 91
                IsEvolutionsAvailable = False
            Case 92
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("093")
                End With
            Case 93
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("094")
                End With
            Case 94
                IsEvolutionsAvailable = False
            Case 95
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[金屬外套]通信進化")
                End With
                With EvoluteToNumers
                    .Add("208")
                End With
            Case 96
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("097")
                End With
            Case 97
                IsEvolutionsAvailable = False
            Case 98
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("099")
                End With
            Case 99
                IsEvolutionsAvailable = False
            Case 100
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("101")
                End With
            Case 101
                IsEvolutionsAvailable = False
            Case 102
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumers
                    .Add("103")
                End With
            Case 103
                IsEvolutionsAvailable = False
            Case 104
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("105")
                End With
            Case 105
                IsEvolutionsAvailable = False
            Case 106
                IsEvolutionsAvailable = False
            Case 107
                IsEvolutionsAvailable = False
            Case 108
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[滾動]")
                End With
                With EvoluteToNumers
                    .Add("463")
                End With
            Case 109
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("110")
                End With
            Case 110
                IsEvolutionsAvailable = False
            Case 111
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV42")
                End With
                With EvoluteToNumers
                    .Add("112")
                End With
            Case 112
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[鐵衣甲]通信進化")
                End With
                With EvoluteToNumers
                    .Add("464")
                End With
            Case 113
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("242")
                End With
            Case 114
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[原始之力]")
                End With
                With EvoluteToNumers
                    .Add("465")
                End With
            Case 115
                IsEvolutionsAvailable = False
            Case 116
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("117")
                End With
            Case 117
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[龍鱗]通信進化")
                End With
                With EvoluteToNumers
                    .Add("230")
                End With
            Case 118
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV33")
                End With
                With EvoluteToNumers
                    .Add("119")
                End With
            Case 119
                IsEvolutionsAvailable = False
            Case 120
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumers
                    .Add("121")
                End With
            Case 121
                IsEvolutionsAvailable = False
            Case 122
                IsEvolutionsAvailable = False
            Case 123
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[金屬外套]通信進化")
                End With
                With EvoluteToNumers
                    .Add("212")
                End With
            Case 124
                IsEvolutionsAvailable = False
            Case 125
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[電力發動機]通信進化")
                End With
                With EvoluteToNumers
                    .Add("466")
                End With
            Case 126
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[火力發動機]通信進化")
                End With
                With EvoluteToNumers
                    .Add("467")
                End With
            Case 127
                IsEvolutionsAvailable = False
            Case 128
                IsEvolutionsAvailable = False
            Case 129
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("130")
                End With
            Case 130
                IsEvolutionsAvailable = False
            Case 131
                IsEvolutionsAvailable = False
            Case 132
                IsEvolutionsAvailable = False
            Case 133
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[水之石]")
                    .Add("使用[雷之石]")
                    .Add("使用[火之石]")
                    .Add("白天親密度進化")
                    .Add("夜晚親密度進化")
                    .Add("苔蘚石附近升級進化")
                    .Add("冰雪石附近升級進化")
                    .Add("羈絆值2心及以上且有妖精屬性技能時升級進化")
                End With
                With EvoluteToNumers
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
                IsEvolutionsAvailable = False
            Case 135
                IsEvolutionsAvailable = False
            Case 136
                IsEvolutionsAvailable = False
            Case 137
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[升級資料]通信進化")
                End With
                With EvoluteToNumers
                    .Add("233")
                End With
            Case 138
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("139")
                End With
            Case 139
                IsEvolutionsAvailable = False
            Case 140
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("141")
                End With
            Case 141
                IsEvolutionsAvailable = False
            Case 142
                IsEvolutionsAvailable = False
            Case 143
                IsEvolutionsAvailable = False
            Case 144
                IsEvolutionsAvailable = False
            Case 145
                IsEvolutionsAvailable = False
            Case 146
                IsEvolutionsAvailable = False
            Case 147
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                    .Add("升級到LV55")
                End With
                With EvoluteToNumers
                    .Add("148")
                    .Add("149")
                End With
            Case 148
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV55")
                End With
                With EvoluteToNumers
                    .Add("149")
                End With
            Case 149
                IsEvolutionsAvailable = False
            Case 150
                IsEvolutionsAvailable = False
            Case 151
                IsEvolutionsAvailable = False
            Case 152
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("153")
                    .Add("154")
                End With
            Case 153
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("154")
                End With
            Case 154
                IsEvolutionsAvailable = False
            Case 155
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV14")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("156")
                    .Add("157")
                End With
            Case 156
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("157")
                End With
            Case 157
                IsEvolutionsAvailable = False
            Case 158
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("159")
                    .Add("160")
                End With
            Case 159
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("160")
                End With
            Case 160
                IsEvolutionsAvailable = False
            Case 161
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV15")
                End With
                With EvoluteToNumers
                    .Add("162")
                End With
            Case 162
                IsEvolutionsAvailable = False
            Case 163
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("164")
                End With
            Case 164
                IsEvolutionsAvailable = False
            Case 165
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                End With
                With EvoluteToNumers
                    .Add("166")
                End With
            Case 166
                IsEvolutionsAvailable = False
            Case 168
                IsEvolutionsAvailable = False
            Case 167
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                End With
                With EvoluteToNumers
                    .Add("168")
                End With
            Case 169
                IsEvolutionsAvailable = False
            Case 170
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV27")
                End With
                With EvoluteToNumers
                    .Add("171")
                End With
            Case 171
                IsEvolutionsAvailable = False
            Case 172
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("025")
                End With
            Case 173
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("035")
                End With
            Case 174
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("039")
                End With
            Case 175
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("176")
                End With
            Case 176
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[光之石]")
                End With
                With EvoluteToNumers
                    .Add("468")
                End With
            Case 177
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("178")
                End With
            Case 178
                IsEvolutionsAvailable = False
            Case 179
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV15")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("180")
                    .Add("181")
                End With
            Case 180
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("181")
                End With
            Case 181
                IsEvolutionsAvailable = False
            Case 182
                IsEvolutionsAvailable = False
            Case 183
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                End With
                With EvoluteToNumers
                    .Add("184")
                End With
            Case 184
                IsEvolutionsAvailable = False
            Case 185
                IsEvolutionsAvailable = False
            Case 186
                IsEvolutionsAvailable = False
            Case 187
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                    .Add("升級到LV27")
                End With
                With EvoluteToNumers
                    .Add("188")
                    .Add("189")
                End With
            Case 188
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV27")
                End With
                With EvoluteToNumers
                    .Add("189")
                End With
            Case 189
                IsEvolutionsAvailable = False
            Case 190
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[雙重攻擊]")
                End With
                With EvoluteToNumers
                    .Add("424")
                End With
            Case 191
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumers
                    .Add("192")
                End With
            Case 192
                IsEvolutionsAvailable = False
            Case 193
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[原始之力]")
                End With
                With EvoluteToNumers
                    .Add("469")
                End With
            Case 194
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("195")
                End With
            Case 195
                IsEvolutionsAvailable = False
            Case 196
                IsEvolutionsAvailable = False
            Case 197
                IsEvolutionsAvailable = False
            Case 198
                IsEvolutionsAvailable = False
            Case 199
                IsEvolutionsAvailable = False
            Case 200
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[暗之石]")
                End With
                With EvoluteToNumers
                    .Add("429")
                End With
            Case 201
                IsEvolutionsAvailable = False
            Case 202
                IsEvolutionsAvailable = False
            Case 203
                IsEvolutionsAvailable = False
            Case 204
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV31")
                End With
                With EvoluteToNumers
                    .Add("205")
                End With
            Case 205
                IsEvolutionsAvailable = False
            Case 206
                IsEvolutionsAvailable = False
            Case 207
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("夜晚持有道具[尖牙]升級進化")
                End With
                With EvoluteToNumers
                    .Add("472")
                End With
            Case 208
                IsEvolutionsAvailable = False
            Case 209
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV23")
                End With
                With EvoluteToNumers
                    .Add("210")
                End With
            Case 210
                IsEvolutionsAvailable = False
            Case 211
                IsEvolutionsAvailable = False
            Case 212
                IsEvolutionsAvailable = False
            Case 213
                IsEvolutionsAvailable = False
            Case 214
                IsEvolutionsAvailable = False
            Case 215
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("夜晚持有道具[尖牙]升級進化")
                End With
                With EvoluteToNumers
                    .Add("461")
                End With
            Case 216
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("217")
                End With
            Case 217
                IsEvolutionsAvailable = False
            Case 218
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV38")
                End With
                With EvoluteToNumers
                    .Add("219")
                End With
            Case 219
                IsEvolutionsAvailable = False
            Case 220
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV33")
                End With
                With EvoluteToNumers
                    .Add("221")
                End With
            Case 221
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[原始之力]")
                End With
                With EvoluteToNumers
                    .Add("473")
                End With
            Case 222
                IsEvolutionsAvailable = False
            Case 223
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("224")
                End With
            Case 224
                IsEvolutionsAvailable = False
            Case 225
                IsEvolutionsAvailable = False
            Case 226
                IsEvolutionsAvailable = False
            Case 227
                IsEvolutionsAvailable = False
            Case 228
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV24")
                End With
                With EvoluteToNumers
                    .Add("229")
                End With
            Case 229
                IsEvolutionsAvailable = False
            Case 230
                IsEvolutionsAvailable = False
            Case 231
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("232")
                End With
            Case 232
                IsEvolutionsAvailable = False
            Case 233
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[奇異更新]通信進化")
                End With
                With EvoluteToNumers
                    .Add("474")
                End With
            Case 234
                IsEvolutionsAvailable = False
            Case 235
                IsEvolutionsAvailable = False
            Case 236
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20且攻擊力大於防禦力")
                    .Add("升級到LV20且攻擊力小於防禦力")
                    .Add("升級到LV20且攻擊力等於防禦力")
                End With
                With EvoluteToNumers
                    .Add("106")
                    .Add("107")
                    .Add("237")
                End With
            Case 237
                IsEvolutionsAvailable = False
            Case 238
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("124")
                End With
            Case 239
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("125")
                End With
            Case 240
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("126")
                End With
            Case 240
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("126")
                End With
            Case 241
                IsEvolutionsAvailable = False
            Case 242
                IsEvolutionsAvailable = False
            Case 243
                IsEvolutionsAvailable = False
            Case 244
                IsEvolutionsAvailable = False
            Case 245 '君兒
                IsEvolutionsAvailable = False
            Case 246
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                    .Add("升級到LV55")
                End With
                With EvoluteToNumers
                    .Add("247")
                    .Add("248")
                End With
            Case 247
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV55")
                End With
                With EvoluteToNumers
                    .Add("248")
                End With
            Case 248
                IsEvolutionsAvailable = False
            Case 249
                IsEvolutionsAvailable = False
            Case 250
                IsEvolutionsAvailable = False
            Case 251
                IsEvolutionsAvailable = False
            Case 252
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("253")
                    .Add("254")
                End With
            Case 253
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("254")
                End With
            Case 254
                IsEvolutionsAvailable = False
            Case 255
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("256")
                    .Add("257")
                End With
            Case 256
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("257")
                End With
            Case 257
                IsEvolutionsAvailable = False
            Case 258
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("259")
                    .Add("260")
                End With
            Case 259
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("260")
                End With
            Case 260
                IsEvolutionsAvailable = False
            Case 261
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                End With
                With EvoluteToNumers
                    .Add("262")
                End With
            Case 262
                IsEvolutionsAvailable = False
            Case 263
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("264")
                End With
            Case 264
                IsEvolutionsAvailable = False
            Case 265
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("LV7時性格值尾數大於等於5")
                    .Add("LV7時性格值尾數小於5")
                End With
                With EvoluteToNumers
                    .Add("266")
                    .Add("268")
                End With
            Case 266
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV10")
                End With
                With EvoluteToNumers
                    .Add("267")
                End With
            Case 267
                IsEvolutionsAvailable = False
            Case 268
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV10")
                End With
                With EvoluteToNumers
                    .Add("269")
                End With
            Case 269
                IsEvolutionsAvailable = False
            Case 270
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV14")
                End With
                With EvoluteToNumers
                    .Add("271")
                End With
            Case 271
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumers
                    .Add("272")
                End With
            Case 272
                IsEvolutionsAvailable = False
            Case 273
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV14")
                End With
                With EvoluteToNumers
                    .Add("274")
                End With
            Case 274
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumers
                    .Add("275")
                End With
            Case 275
                IsEvolutionsAvailable = False
            Case 276
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                End With
                With EvoluteToNumers
                    .Add("277")
                End With
            Case 277
                IsEvolutionsAvailable = False
            Case 278
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("279")
                End With
            Case 279
                IsEvolutionsAvailable = False
            Case 280
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("281")
                End With
            Case 281
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                    .Add("雄性使用[覺醒石]")
                End With
                With EvoluteToNumers
                    .Add("282")
                    .Add("475")
                End With
            Case 282
                IsEvolutionsAvailable = False
            Case 283
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                End With
                With EvoluteToNumers
                    .Add("284")
                End With
            Case 284
                IsEvolutionsAvailable = False
            Case 285
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV23")
                End With
                With EvoluteToNumers
                    .Add("286")
                End With
            Case 286
                IsEvolutionsAvailable = False
            Case 287
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("288")
                    .Add("289")
                End With
            Case 288
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("289")
                End With
            Case 289
                IsEvolutionsAvailable = False
            Case 290
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20(本體)")
                    .Add("升級到LV20('殼')")
                End With
                With EvoluteToNumers
                    .Add("291")
                    .Add("292")
                End With
            Case 291
                IsEvolutionsAvailable = False
            Case 292
                IsEvolutionsAvailable = False
            Case 293
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("294")
                    .Add("295")
                End With
            Case 294
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("295")
                End With
            Case 295
                IsEvolutionsAvailable = False
            Case 296
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV24")
                End With
                With EvoluteToNumers
                    .Add("297")
                End With
            Case 297
                IsEvolutionsAvailable = False
            Case 298
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("183")
                End With
            Case 299
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("強磁場區域升級進化")
                End With
                With EvoluteToNumers
                    .Add("476")
                End With
            Case 300
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumers
                    .Add("301")
                End With
            Case 301
                IsEvolutionsAvailable = False
            Case 302
                IsEvolutionsAvailable = False
            Case 303
                IsEvolutionsAvailable = False
            Case 304
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                    .Add("升級到LV42")
                End With
                With EvoluteToNumers
                    .Add("305")
                    .Add("306")
                End With
            Case 305
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV42")
                End With
                With EvoluteToNumers
                    .Add("306")
                End With
            Case 306
                IsEvolutionsAvailable = False
            Case 307
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("308")
                End With
            Case 308
                IsEvolutionsAvailable = False
            Case 309
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV26")
                End With
                With EvoluteToNumers
                    .Add("310")
                End With
            Case 310
                IsEvolutionsAvailable = False
            Case 311
                IsEvolutionsAvailable = False
            Case 312
                IsEvolutionsAvailable = False
            Case 313
                IsEvolutionsAvailable = False
            Case 314
                IsEvolutionsAvailable = False
            Case 315
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[光之石]")
                End With
                With EvoluteToNumers
                    .Add("407")
                End With
            Case 316
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV26")
                End With
                With EvoluteToNumers
                    .Add("317")
                End With
            Case 317
                IsEvolutionsAvailable = False
            Case 318
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("319")
                End With
            Case 319
                IsEvolutionsAvailable = False
            Case 320
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("321")
                End With
            Case 321
                IsEvolutionsAvailable = False
            Case 322
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV33")
                End With
                With EvoluteToNumers
                    .Add("323")
                End With
            Case 323
                IsEvolutionsAvailable = False
            Case 324
                IsEvolutionsAvailable = False
            Case 325
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("326")
                End With
            Case 327
                IsEvolutionsAvailable = False
            Case 328
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                    .Add("升級到LV45")
                End With
                With EvoluteToNumers
                    .Add("329")
                    .Add("330")
                End With
            Case 329
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV45")
                End With
                With EvoluteToNumers
                    .Add("330")
                End With
            Case 330
                IsEvolutionsAvailable = False
            Case 331
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("332")
                End With
            Case 332
                IsEvolutionsAvailable = False
            Case 333
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("334")
                End With
            Case 334
                IsEvolutionsAvailable = False
            Case 335
                IsEvolutionsAvailable = False
            Case 336
                IsEvolutionsAvailable = False
            Case 337
                IsEvolutionsAvailable = False
            Case 338
                IsEvolutionsAvailable = False
            Case 339
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("340")
                End With
            Case 340
                IsEvolutionsAvailable = False
            Case 341
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("342")
                End With
            Case 342
                IsEvolutionsAvailable = False
            Case 343
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("344")
                End With
            Case 344
                IsEvolutionsAvailable = False
            Case 345
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("346")
                End With
            Case 346
                IsEvolutionsAvailable = False
            Case 347
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("348")
                End With
            Case 348
                IsEvolutionsAvailable = False
            Case 349
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[美麗鱗片]通信進化")
                End With
                With EvoluteToNumers
                    .Add("350")
                End With
            Case 350
                IsEvolutionsAvailable = False
            Case 351
                IsEvolutionsAvailable = False
            Case 352
                IsEvolutionsAvailable = False
            Case 353
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("354")
                End With
            Case 354
                IsEvolutionsAvailable = False
            Case 355
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("356")
                End With
            Case 356
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[靈界幕布]通信進化")
                End With
                With EvoluteToNumers
                    .Add("477")
                End With
            Case 357
                IsEvolutionsAvailable = False
            Case 358
                IsEvolutionsAvailable = False
            Case 359
                IsEvolutionsAvailable = False
            Case 360
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV15")
                End With
                With EvoluteToNumers
                    .Add("202")
                End With
            Case 361
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV42")
                    .Add("雌性使用[覺醒石]進化")
                End With
                With EvoluteToNumers
                    .Add("362")
                    .Add("478")
                End With
            Case 362
                IsEvolutionsAvailable = False
            Case 363
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                    .Add("升級到LV44")
                End With
                With EvoluteToNumers
                    .Add("364")
                    .Add("365")
                End With
            Case 364
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV44")
                End With
                With EvoluteToNumers
                    .Add("365")
                End With
            Case 365
                IsEvolutionsAvailable = False
            Case 366
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[深海之牙]通信進化")
                    .Add("攜帶[深海之鱗]通信進化")
                End With
                With EvoluteToNumers
                    .Add("367")
                    .Add("368")
                End With
            Case 367
                IsEvolutionsAvailable = False
            Case 368
                IsEvolutionsAvailable = False
            Case 369
                IsEvolutionsAvailable = False
            Case 370
                IsEvolutionsAvailable = False
            Case 371
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                    .Add("升級到LV50")
                End With
                With EvoluteToNumers
                    .Add("372")
                    .Add("373")
                End With
            Case 372
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV50")
                End With
                With EvoluteToNumers
                    .Add("373")
                End With
            Case 373
                IsEvolutionsAvailable = False
            Case 374
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                    .Add("升級到LV45")
                End With
                With EvoluteToNumers
                    .Add("375")
                    .Add("376")
                End With
            Case 375
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV45")
                End With
                With EvoluteToNumers
                    .Add("376")
                End With
            Case 376
                IsEvolutionsAvailable = False
            Case 377
                IsEvolutionsAvailable = False
            Case 378
                IsEvolutionsAvailable = False
            Case 379
                IsEvolutionsAvailable = False
            Case 380
                IsEvolutionsAvailable = False
            Case 381
                IsEvolutionsAvailable = False
            Case 382
                IsEvolutionsAvailable = False
            Case 383
                IsEvolutionsAvailable = False
            Case 384
                IsEvolutionsAvailable = False
            Case 385
                IsEvolutionsAvailable = False
            Case 386
                IsEvolutionsAvailable = False
            Case 387
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("388")
                    .Add("389")
                End With
            Case 388
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("389")
                End With
            Case 389
                IsEvolutionsAvailable = False
            Case 390
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV14")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("391")
                    .Add("392")
                End With
            Case 391
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("392")
                End With
            Case 392
                IsEvolutionsAvailable = False
            Case 393
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("394")
                    .Add("395")
                End With
            Case 394
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("395")
                End With
            Case 395
                IsEvolutionsAvailable = False
            Case 396
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV14")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("397")
                    .Add("398")
                End With
            Case 397
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("399")
                End With
            Case 398
                IsEvolutionsAvailable = False
            Case 399
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV15")
                End With
                With EvoluteToNumers
                    .Add("400")
                End With
            Case 400
                IsEvolutionsAvailable = False
            Case 401
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV10")
                End With
                With EvoluteToNumers
                    .Add("402")
                End With
            Case 402
                IsEvolutionsAvailable = False
            Case 403
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV15")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("404")
                    .Add("405")
                End With
            Case 404
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("405")
                End With
            Case 405
                IsEvolutionsAvailable = False
            Case 406
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("白天親密度進化")
                End With
                With EvoluteToNumers
                    .Add("315")
                End With
            Case 407
                IsEvolutionsAvailable = False
            Case 408
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("409")
                End With
            Case 409
                IsEvolutionsAvailable = False
            Case 410
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("411")
                End With
            Case 411
                IsEvolutionsAvailable = False
            Case 412
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("雌性升級到LV20")
                    .Add("雄性草木蓑衣型態升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("413")
                    .Add("414")
                End With
            Case 413
                IsEvolutionsAvailable = False
            Case 414
                IsEvolutionsAvailable = False
            Case 415
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("雌性升級到LV21")
                End With
                With EvoluteToNumers
                    .Add("416")
                End With
            Case 416
                IsEvolutionsAvailable = False
            Case 417
                IsEvolutionsAvailable = False
            Case 418
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV26")
                End With
                With EvoluteToNumers
                    .Add("419")
                End With
            Case 419
                IsEvolutionsAvailable = False
            Case 420
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("421")
                End With
            Case 421
                IsEvolutionsAvailable = False
            Case 422
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("423")
                End With
            Case 423
                IsEvolutionsAvailable = False
            Case 424
                IsEvolutionsAvailable = False
            Case 425
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("426")
                End With
            Case 426
                IsEvolutionsAvailable = False
            Case 427
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("428")
                End With
            Case 428
                IsEvolutionsAvailable = False
            Case 429
                IsEvolutionsAvailable = False
            Case 430
                IsEvolutionsAvailable = False
            Case 431
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV38")
                End With
                With EvoluteToNumers
                    .Add("432")
                End With
            Case 432
                IsEvolutionsAvailable = False
            Case 433
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("夜晚親密度進化")
                End With
                With EvoluteToNumers
                    .Add("358")
                End With
            Case 434
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("435")
                End With
            Case 435
                IsEvolutionsAvailable = False
            Case 436
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV33")
                End With
                With EvoluteToNumers
                    .Add("437")
                End With
            Case 437
                IsEvolutionsAvailable = False
            Case 438
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[模仿]")
                End With
                With EvoluteToNumers
                    .Add("185")
                End With
            Case 439
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[模仿]")
                End With
                With EvoluteToNumers
                    .Add("122")
                End With
            Case 440
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("白天攜帶[圓石]升級進化")
                End With
                With EvoluteToNumers
                    .Add("113")
                End With
            Case 441
                IsEvolutionsAvailable = False
            Case 442
                IsEvolutionsAvailable = False
            Case 443
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV24")
                    .Add("升級到LV48")
                End With
                With EvoluteToNumers
                    .Add("444")
                    .Add("445")
                End With
            Case 444
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV48")
                End With
                With EvoluteToNumers
                    .Add("445")
                End With
            Case 445
                IsEvolutionsAvailable = False
            Case 446
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("143")
                End With
            Case 447
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("白天親密度進化")
                End With
                With EvoluteToNumers
                    .Add("448")
                End With
            Case 448
                IsEvolutionsAvailable = False
            Case 449
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("450")
                End With
            Case 450
                IsEvolutionsAvailable = False
            Case 451
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("452")
                End With
            Case 452
                IsEvolutionsAvailable = False
            Case 453
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("454")
                End With
            Case 454
                IsEvolutionsAvailable = False
            Case 455
                IsEvolutionsAvailable = False
            Case 456
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV31")
                End With
                With EvoluteToNumers
                    .Add("457")
                End With
            Case 457
                IsEvolutionsAvailable = False
            Case 458
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("隊伍中有No.223[鐵炮魚]時進化")
                End With
                With EvoluteToNumers
                    .Add("226")
                End With
            Case 459
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("460")
                End With
            Case 460
                IsEvolutionsAvailable = False
            Case 461
                IsEvolutionsAvailable = False
            Case 462
                IsEvolutionsAvailable = False
            Case 463
                IsEvolutionsAvailable = False
            Case 464
                IsEvolutionsAvailable = False
            Case 465
                IsEvolutionsAvailable = False
            Case 466
                IsEvolutionsAvailable = False
            Case 467
                IsEvolutionsAvailable = False
            Case 468
                IsEvolutionsAvailable = False
            Case 469
                IsEvolutionsAvailable = False
            Case 470
                IsEvolutionsAvailable = False
            Case 471
                IsEvolutionsAvailable = False
            Case 472
                IsEvolutionsAvailable = False
            Case 473
                IsEvolutionsAvailable = False
            Case 474
                IsEvolutionsAvailable = False
            Case 475
                IsEvolutionsAvailable = False
            Case 476
                IsEvolutionsAvailable = False
            Case 477
                IsEvolutionsAvailable = False
            Case 478
                IsEvolutionsAvailable = False
            Case 479
                IsEvolutionsAvailable = False
            Case 480
                IsEvolutionsAvailable = False
            Case 481
                IsEvolutionsAvailable = False
            Case 482
                IsEvolutionsAvailable = False
            Case 483
                IsEvolutionsAvailable = False
            Case 484
                IsEvolutionsAvailable = False
            Case 485
                IsEvolutionsAvailable = False
            Case 486
                IsEvolutionsAvailable = False
            Case 487
                IsEvolutionsAvailable = False
            Case 488
                IsEvolutionsAvailable = False
            Case 489
                IsEvolutionsAvailable = False
            Case 490
                IsEvolutionsAvailable = False
            Case 491
                IsEvolutionsAvailable = False
            Case 492
                IsEvolutionsAvailable = False
            Case 493
                IsEvolutionsAvailable = False
            Case 494
                IsEvolutionsAvailable = False
            Case 495
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV17")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("496")
                    .Add("497")
                End With
            Case 496
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("497")
                End With
            Case 497
                IsEvolutionsAvailable = False
            Case 498
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV17")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("499")
                    .Add("500")
                End With
            Case 499
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("500")
                End With
            Case 500
                IsEvolutionsAvailable = False
            Case 501
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV17")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("502")
                    .Add("503")
                End With
            Case 502
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("503")
                End With
            Case 503
                IsEvolutionsAvailable = False
            Case 504
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("505")
                End With
            Case 505
                IsEvolutionsAvailable = False
            Case 506
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("507")
                    .Add("508")
                End With
            Case 507
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("508")
                End With
            Case 508
                IsEvolutionsAvailable = False
            Case 509
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("510")
                End With
            Case 510
                IsEvolutionsAvailable = False
            Case 511
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[葉之石]")
                End With
                With EvoluteToNumers
                    .Add("512")
                End With
            Case 512
                IsEvolutionsAvailable = False
            Case 513
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[火之石]")
                End With
                With EvoluteToNumers
                    .Add("514")
                End With
            Case 514
                IsEvolutionsAvailable = False
            Case 515
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[水之石]")
                End With
                With EvoluteToNumers
                    .Add("516")
                End With
            Case 516
                IsEvolutionsAvailable = False
            Case 517
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[月之石]")
                End With
                With EvoluteToNumers
                    .Add("518")
                End With
            Case 518
                IsEvolutionsAvailable = False
            Case 519
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV21")
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("520")
                    .Add("521")
                End With
            Case 520
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("521")
                End With
            Case 521
                IsEvolutionsAvailable = False
            Case 522
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV27")
                End With
                With EvoluteToNumers
                    .Add("523")
                End With
            Case 523
                IsEvolutionsAvailable = False
            Case 524
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("525")
                End With
            Case 525
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("526")
                End With
            Case 526
                IsEvolutionsAvailable = False
            Case 527
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("528")
                End With
            Case 528
                IsEvolutionsAvailable = False
            Case 529
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV31")
                End With
                With EvoluteToNumers
                    .Add("530")
                End With
            Case 531
                IsEvolutionsAvailable = False
            Case 532
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("533")
                End With
            Case 533
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("534")
                End With
            Case 534
                IsEvolutionsAvailable = False
            Case 535
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("536")
                    .Add("537")
                End With
            Case 536
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("537")
                End With
            Case 537
                IsEvolutionsAvailable = False
            Case 538
                IsEvolutionsAvailable = False
            Case 539
                IsEvolutionsAvailable = False
            Case 540
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("541")
                End With
            Case 541
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("542")
                End With
            Case 542
                IsEvolutionsAvailable = False
            Case 543
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("544")
                    .Add("545")
                End With
            Case 544
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("545")
                End With
            Case 545
                IsEvolutionsAvailable = False
            Case 546
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumers
                    .Add("547")
                End With
            Case 547
                IsEvolutionsAvailable = False
            Case 548
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumers
                    .Add("549")
                End With
            Case 549
                IsEvolutionsAvailable = False
            Case 550
                IsEvolutionsAvailable = False
            Case 551
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV29")
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("552")
                    .Add("553")
                End With
            Case 552
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("553")
                End With
            Case 553
                IsEvolutionsAvailable = False
            Case 554
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("555")
                End With
            Case 555
                IsEvolutionsAvailable = False
            Case 556
                IsEvolutionsAvailable = False
            Case 557
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("558")
                End With
            Case 558
                IsEvolutionsAvailable = False
            Case 559
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV39")
                End With
                With EvoluteToNumers
                    .Add("560")
                End With
            Case 560
                IsEvolutionsAvailable = False
            Case 561
                IsEvolutionsAvailable = False
            Case 562
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("563")
                End With
            Case 563
                IsEvolutionsAvailable = False
            Case 564
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("565")
                End With
            Case 565
                IsEvolutionsAvailable = False
            Case 566
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("567")
                End With
            Case 567
                IsEvolutionsAvailable = False
            Case 568
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("569")
                End With
            Case 569
                IsEvolutionsAvailable = False
            Case 570
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("571")
                End With
            Case 571
                IsEvolutionsAvailable = False
            Case 572
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[光只石]")
                End With
                With EvoluteToNumers
                    .Add("573")
                End With
            Case 573
                IsEvolutionsAvailable = False
            Case 574
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                    .Add("升級到LV41")
                End With
                With EvoluteToNumers
                    .Add("575")
                    .Add("576")
                End With
            Case 575
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV41")
                End With
                With EvoluteToNumers
                    .Add("576")
                End With
            Case 576
                IsEvolutionsAvailable = False
            Case 577
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                    .Add("升級到LV41")
                End With
                With EvoluteToNumers
                    .Add("578")
                    .Add("579")
                End With
            Case 578
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV41")
                End With
                With EvoluteToNumers
                    .Add("579")
                End With
            Case 579
                IsEvolutionsAvailable = False
            Case 580
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("581")
                End With
            Case 581
                IsEvolutionsAvailable = False
            Case 582
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                    .Add("升級到LV47")
                End With
                With EvoluteToNumers
                    .Add("583")
                    .Add("584")
                End With
            Case 583
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV47")
                End With
                With EvoluteToNumers
                    .Add("584")
                End With
            Case 584
                IsEvolutionsAvailable = False
            Case 585
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("586")
                End With
            Case 586
                IsEvolutionsAvailable = False
            Case 587
                IsEvolutionsAvailable = False
            Case 588
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("與No.616[小嘴蜗]通信進化")
                End With
                With EvoluteToNumers
                    .Add("589")
                End With
            Case 589
                IsEvolutionsAvailable = False
            Case 590
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV39")
                End With
                With EvoluteToNumers
                    .Add("591")
                End With
            Case 591
                IsEvolutionsAvailable = False
            Case 592
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("593")
                End With
            Case 593
                IsEvolutionsAvailable = False
            Case 594
                IsEvolutionsAvailable = False
            Case 595
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("596")
                End With
            Case 596
                IsEvolutionsAvailable = False
            Case 597
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("598")
                End With
            Case 598
                IsEvolutionsAvailable = False
            Case 599
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV38")
                    .Add("升級到LV49")
                End With
                With EvoluteToNumers
                    .Add("600")
                    .Add("601")
                End With
            Case 600
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV49")
                End With
                With EvoluteToNumers
                    .Add("601")
                End With
            Case 601
                IsEvolutionsAvailable = False
            Case 602
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV39")
                End With
                With EvoluteToNumers
                    .Add("603")
                End With
            Case 603
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[雷之石]")
                End With
                With EvoluteToNumers
                    .Add("604")
                End With
            Case 604
                IsEvolutionsAvailable = False
            Case 605
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV42")
                End With
                With EvoluteToNumers
                    .Add("606")
                End With
            Case 606
                IsEvolutionsAvailable = False
            Case 607
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV41")
                End With
                With EvoluteToNumers
                    .Add("608")
                End With
            Case 608
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[暗之石]")
                End With
                With EvoluteToNumers
                    .Add("609")
                End With
            Case 609
                IsEvolutionsAvailable = False
            Case 610
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV38")
                    .Add("升級到LV48")
                End With
                With EvoluteToNumers
                    .Add("611")
                    .Add("612")
                End With
            Case 611
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV48")
                End With
                With EvoluteToNumers
                    .Add("612")
                End With
            Case 612
                IsEvolutionsAvailable = False
            Case 613
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("614")
                End With
            Case 614
                IsEvolutionsAvailable = False
            Case 615
                IsEvolutionsAvailable = False
            Case 616
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("與No.588[蓋蓋蟲]通信進化")
                End With
                With EvoluteToNumers
                    .Add("617")
                End With
            Case 617
                IsEvolutionsAvailable = False
            Case 618
                IsEvolutionsAvailable = False
            Case 619
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV50")
                End With
                With EvoluteToNumers
                    .Add("620")
                End With
            Case 620
                IsEvolutionsAvailable = False
            Case 621
                IsEvolutionsAvailable = False
            Case 622
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV43")
                End With
                With EvoluteToNumers
                    .Add("623")
                End With
            Case 623
                IsEvolutionsAvailable = False
            Case 624
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV52")
                End With
                With EvoluteToNumers
                    .Add("625")
                End With
            Case 625
                IsEvolutionsAvailable = False
            Case 626
                IsEvolutionsAvailable = False
            Case 627
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV54")
                End With
                With EvoluteToNumers
                    .Add("628")
                End With
            Case 628
                IsEvolutionsAvailable = False
            Case 629
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV54")
                End With
                With EvoluteToNumers
                    .Add("630")
                End With
            Case 630
                IsEvolutionsAvailable = False
            Case 631
                IsEvolutionsAvailable = False
            Case 632
                IsEvolutionsAvailable = False
            Case 633
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV50")
                    .Add("升級到LV64")
                End With
                With EvoluteToNumers
                    .Add("634")
                    .Add("635")
                End With
            Case 634
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV64")
                End With
                With EvoluteToNumers
                    .Add("635")
                End With
            Case 635
                IsEvolutionsAvailable = False
            Case 636
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV59")
                End With
                With EvoluteToNumers
                    .Add("637")
                End With
            Case 638
                IsEvolutionsAvailable = False
            Case 639
                IsEvolutionsAvailable = False
            Case 640
                IsEvolutionsAvailable = False
            Case 641
                IsEvolutionsAvailable = False
            Case 642
                IsEvolutionsAvailable = False
            Case 643
                IsEvolutionsAvailable = False
            Case 644
                IsEvolutionsAvailable = False
            Case 645
                IsEvolutionsAvailable = False
            Case 646
                IsEvolutionsAvailable = False
            Case 647
                IsEvolutionsAvailable = False
            Case 648
                IsEvolutionsAvailable = False
            Case 649
                IsEvolutionsAvailable = False
            Case 650
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("651")
                    .Add("652")
                End With
            Case 651
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("652")
                End With
            Case 652
                IsEvolutionsAvailable = False
            Case 653
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("654")
                    .Add("655")
                End With
            Case 654
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("655")
                End With
            Case 655
                IsEvolutionsAvailable = False
            Case 656
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV16")
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("657")
                    .Add("658")
                End With
            Case 657
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV36")
                End With
                With EvoluteToNumers
                    .Add("658")
                End With
            Case 658
                IsEvolutionsAvailable = False
            Case 659
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("660")
                End With
            Case 660
                IsEvolutionsAvailable = False
            Case 661
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV17")
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("662")
                    .Add("663")
                End With
            Case 662
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("663")
                End With
            Case 663
                IsEvolutionsAvailable = False
            Case 664
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV9")
                End With
                With EvoluteToNumers
                    .Add("665")
                End With
            Case 665
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV12")
                End With
                With EvoluteToNumers
                    .Add("666")
                End With
            Case 666
                IsEvolutionsAvailable = False
            Case 667
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("668")
                End With
            Case 668
                IsEvolutionsAvailable = False
            Case 669
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV19")
                End With
                With EvoluteToNumers
                    .Add("670")
                End With
            Case 670
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[光之石]")
                End With
                With EvoluteToNumers
                    .Add("671")
                End With
            Case 671
                IsEvolutionsAvailable = False
            Case 672
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("673")
                End With
            Case 673
                IsEvolutionsAvailable = False
            Case 674
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("隊伍中有惡屬性神奇寶貝且升級到LV32")
                End With
                With EvoluteToNumers
                    .Add("675")
                End With
            Case 675
                IsEvolutionsAvailable = False
            Case 676
                IsEvolutionsAvailable = False
            Case 677
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("678")
                End With
            Case 678
                IsEvolutionsAvailable = False
            Case 679
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                End With
                With EvoluteToNumers
                    .Add("680")
                End With
            Case 680
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[暗之石]")
                End With
                With EvoluteToNumers
                    .Add("681")
                End With
            Case 681
                IsEvolutionsAvailable = False
            Case 682
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[香囊]通信進化")
                End With
                With EvoluteToNumers
                    .Add("683")
                End With
            Case 683
                IsEvolutionsAvailable = False
            Case 684
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("攜帶[奶油棒糖]通信進化")
                End With
                With EvoluteToNumers
                    .Add("685")
                End With
            Case 685
                IsEvolutionsAvailable = False
            Case 686
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30且遊戲機倒置")
                End With
                With EvoluteToNumers
                    .Add("687")
                End With
            Case 687
                IsEvolutionsAvailable = False
            Case 688
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV39")
                End With
                With EvoluteToNumers
                    .Add("689")
                End With
            Case 689
                IsEvolutionsAvailable = False
            Case 690
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV48")
                End With
                With EvoluteToNumers
                    .Add("691")
                End With
            Case 691
                IsEvolutionsAvailable = False
            Case 692
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("693")
                End With
            Case 693
                IsEvolutionsAvailable = False
            Case 694
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("使用[太陽之石]")
                End With
                With EvoluteToNumers
                    .Add("695")
                End With
            Case 695
                IsEvolutionsAvailable = False
            Case 696
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV39")
                End With
                With EvoluteToNumers
                    .Add("697")
                End With
            Case 697
                IsEvolutionsAvailable = False
            Case 698
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("夜晚升級到LV39")
                End With
                With EvoluteToNumers
                    .Add("699")
                End With
            Case 699
                IsEvolutionsAvailable = False
            Case 700
                IsEvolutionsAvailable = False
            Case 701
                IsEvolutionsAvailable = False
            Case 702
                IsEvolutionsAvailable = False
            Case 703
                IsEvolutionsAvailable = False
            Case 704
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV40")
                End With
                With EvoluteToNumers
                    .Add("705")
                End With
            Case 705
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("下雨時升級到LV50")
                End With
                With EvoluteToNumers
                    .Add("706")
                End With
            Case 706
                IsEvolutionsAvailable = False
            Case 707
                IsEvolutionsAvailable = False
            Case 708
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("709")
                End With
            Case 709
                IsEvolutionsAvailable = False
            Case 710
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("通信進化")
                End With
                With EvoluteToNumers
                    .Add("711")
                End With
            Case 711
                IsEvolutionsAvailable = False
            Case 712
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV37")
                End With
                With EvoluteToNumers
                    .Add("713")
                End With
            Case 713
                IsEvolutionsAvailable = False
            Case 714
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV48")
                End With
                With EvoluteToNumers
                    .Add("715")
                End With
            Case 715
                IsEvolutionsAvailable = False
            Case 716
                IsEvolutionsAvailable = False
            Case 717
                IsEvolutionsAvailable = False
            Case 718
                IsEvolutionsAvailable = False
            Case 719
                IsEvolutionsAvailable = False
            Case 720
                IsEvolutionsAvailable = False
            Case 721
                IsEvolutionsAvailable = False
            Case 722
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV17")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("723")
                    .Add("724")
                End With
            Case 723
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("724")
                End With
            Case 724
                IsEvolutionsAvailable = False
            Case 725
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV17")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("726")
                    .Add("727")
                End With
            Case 726
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("726")
                End With
            Case 727
                IsEvolutionsAvailable = False
            Case 728
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV17")
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("729")
                    .Add("730")
                End With
            Case 729
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("730")
                End With
            Case 730
                IsEvolutionsAvailable = False
            Case 731
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV14")
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("732")
                    .Add("733")
                End With
            Case 732
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV28")
                End With
                With EvoluteToNumers
                    .Add("733")
                End With
            Case 733
                IsEvolutionsAvailable = False
            Case 734
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("白天升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("735")
                End With
            Case 735
                IsEvolutionsAvailable = False
            Case 736
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("737")
                End With
            Case 737
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("強磁場區域升級進化")
                End With
                With EvoluteToNumers
                    .Add("738")
                End With
            Case 738
                IsEvolutionsAvailable = False
            Case 739
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("拉納基拉山升級進化")
                End With
                With EvoluteToNumers
                    .Add("740")
                End With
            Case 740
                IsEvolutionsAvailable = False
            Case 741
                IsEvolutionsAvailable = False
            Case 742
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV20")
                End With
                With EvoluteToNumers
                    .Add("743")
                End With
            Case 743
                IsEvolutionsAvailable = False
            Case 744
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV25")
                End With
                With EvoluteToNumers
                    .Add("745")
                End With
            Case 745
                IsEvolutionsAvailable = False
            Case 746
                IsEvolutionsAvailable = False
            Case 747
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV38")
                End With
                With EvoluteToNumers
                    .Add("748")
                End With
            Case 748
                IsEvolutionsAvailable = False
            Case 749
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("750")
                End With
            Case 750
                IsEvolutionsAvailable = False
            Case 751
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV22")
                End With
                With EvoluteToNumers
                    .Add("752")
                End With
            Case 752
                IsEvolutionsAvailable = False
            Case 753
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("白天升級到LV34")
                End With
                With EvoluteToNumers
                    .Add("754")
                End With
            Case 754
                IsEvolutionsAvailable = False
            Case 755
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV24")
                End With
                With EvoluteToNumers
                    .Add("756")
                End With
            Case 756
                IsEvolutionsAvailable = False
            Case 757
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("雌性升級到LV33")
                End With
                With EvoluteToNumers
                    .Add("758")
                End With
            Case 758
                IsEvolutionsAvailable = False
            Case 759
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV27")
                End With
                With EvoluteToNumers
                    .Add("760")
                End With
            Case 760
                IsEvolutionsAvailable = False
            Case 761
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV18")
                End With
                With EvoluteToNumers
                    .Add("762")
                End With
            Case 762
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[踩踏]")
                End With
                With EvoluteToNumers
                    .Add("763")
                End With
            Case 763
                IsEvolutionsAvailable = False
            Case 764
                IsEvolutionsAvailable = False
            Case 765
                IsEvolutionsAvailable = False
            Case 766
                IsEvolutionsAvailable = False
            Case 767
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV30")
                End With
                With EvoluteToNumers
                    .Add("768")
                End With
            Case 768
                IsEvolutionsAvailable = False
            Case 769
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV42")
                End With
                With EvoluteToNumers
                    .Add("770")
                End With
            Case 770
                IsEvolutionsAvailable = False
            Case 771
                IsEvolutionsAvailable = False
            Case 772
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("親密度進化")
                End With
                With EvoluteToNumers
                    .Add("773")
                End With
            Case 773
                IsEvolutionsAvailable = False
            Case 774
                IsEvolutionsAvailable = False
            Case 775
                IsEvolutionsAvailable = False
            Case 776
                IsEvolutionsAvailable = False
            Case 777
                IsEvolutionsAvailable = False
            Case 778
                IsEvolutionsAvailable = False
            Case 779
                IsEvolutionsAvailable = False
            Case 780
                IsEvolutionsAvailable = False
            Case 781
                IsEvolutionsAvailable = False
            Case 782
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV35")
                    .Add("升級到LV45")
                End With
                With EvoluteToNumers
                    .Add("783")
                    .Add("784")
                End With
            Case 783
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV45")
                End With
                With EvoluteToNumers
                    .Add("784")
                End With
            Case 784
                IsEvolutionsAvailable = False
            Case 785
                IsEvolutionsAvailable = False
            Case 786
                IsEvolutionsAvailable = False
            Case 787
                IsEvolutionsAvailable = False
            Case 788
                IsEvolutionsAvailable = False
            Case 789
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("升級到LV43")
                End With
                With EvoluteToNumers
                    .Add("790")
                End With
            Case 790
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("太陽版升級到LV53")
                    .Add("月亮版升級到LV53")
                End With
                With EvoluteToNumers
                    .Add("791")
                    .Add("792")
                End With
            Case 791
                IsEvolutionsAvailable = False
            Case 792
                IsEvolutionsAvailable = False
            Case 793
                IsEvolutionsAvailable = False
            Case 794
                IsEvolutionsAvailable = False
            Case 795
                IsEvolutionsAvailable = False
            Case 796
                IsEvolutionsAvailable = False
            Case 797
                IsEvolutionsAvailable = False
            Case 798
                IsEvolutionsAvailable = False
            Case 799
                IsEvolutionsAvailable = False
            Case 800
                IsEvolutionsAvailable = False
            Case 801
                IsEvolutionsAvailable = False
            Case 802
                IsEvolutionsAvailable = False
            Case 803
                IsEvolutionsAvailable = True
                With EvolutionRoutins
                    .Add("習得技能[龍之波動]")
                End With
                With EvoluteToNumers
                    .Add("804")
                End With
            Case 804
                IsEvolutionsAvailable = False
            Case 805
                IsEvolutionsAvailable = False
            Case 806
                IsEvolutionsAvailable = False
            Case 807
                IsEvolutionsAvailable = False
            Case 808
                IsEvolutionsAvailable = False
            Case 809
                IsEvolutionsAvailable = False
        End Select
    End Sub
End Module
