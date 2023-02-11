Imports System.Runtime.Serialization

Public Module libPokemonFormDifferenceProvider
    Public Structure PokemonFormDifferenceInfo
        Public FormName As String
        Public Type As String
        Public ImagePath As String
        Public Ability1 As String
        Public Ability2 As String
        Public AbilityHidden As String
        Public Height As String
        Public Weight As String
        Public Category As String
        Public BodyColor As String
        Public IsUniqueDescriptionAvailable As Boolean
        Public UniqueDescription As String
        Public SpeciesStrengthValues As PokemonSpeciesStrengthValues
    End Structure
    Public FormDifferenceList As New List(Of String)
    Public FormDifferenceInformationList As New List(Of PokemonFormDifferenceInfo)
    Public SharedFormDifferenceInformation As New PokemonFormDifferenceInfo
    Public FormDifferenceInfoTemp As New PokemonFormDifferenceInfo
    Public PokemonTypes As New List(Of String)
    Public Sub GenerateSpecificFormDifferenceInfo(PokemonNationalDexNumberToQuery As Integer)
        FormDifferenceList.Clear()
        FormDifferenceInformationList.Clear()
        InitPokemonTypes()
        If PokemonNationalDexNumberToQuery <= TotalPokemonCountPerVersion.DPT Then
            GenerateSpecificFormDifferenceInfoPreBW(PokemonNationalDexNumberToQuery)
        ElseIf PokemonNationalDexNumberToQuery <= TotalPokemonCountPerVersion.SM Then
            GenerateSpecificFormDifferenceInfoBWXYSM(PokemonNationalDexNumberToQuery)
        ElseIf PokemonNationalDexNumberToQuery <= TotalPokemonCountPerVersion.SV Then
            GenerateSpecificFormDifferenceInfoSSSV(PokemonNationalDexNumberToQuery)
        End If
    End Sub
    Private Sub GenerateSpecificFormDifferenceInfoPreBW(PokemonNationalDexNumberToQuery As Integer)
        Select Case PokemonNationalDexNumberToQuery
            Case 3
                With FormDifferenceList
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 47
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.4 m"
                    .Weight = "155.5 kg"
                    .Type = "[草]+[毒]"
                    .Category = "種子神奇寶貝"
                    .BodyColor = "綠"
                    .ImagePath = "/FormDifferenceImages/003/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "為了支撐超級進化之後變得更大的花，下盤的筋骨變得更加強壯了。"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 100
                        .Defence = 123
                        .SpecialAttack = 122
                        .SpecialDefence = 120
                        .Speed = 80
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "透過揮舞２根粗大的藤蔓來戰鬥。力道之強，甚至能夠輕輕鬆鬆揮倒１０層樓高的大廈。會像火山噴發般猛烈地散播大量的花粉。要是吸進太多花粉是會昏倒的。"
                    .Ability1 = 65
                    .Ability2 = "---"
                    .AbilityHidden = 35
                    .Height = "24.0 m以上"
                    .Weight = "<缺數據>"
                    .Type = "[草]+[毒]"
                    .Category = "種子神奇寶貝"
                    .BodyColor = "綠"
                    .ImagePath = "/FormDifferenceImages/003/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .Attack = 82
                        .Defence = 83
                        .HP = 80
                        .SpecialAttack = 100
                        .SpecialDefence = 100
                        .Speed = 80
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 6
                With FormDifferenceList
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 181
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "110.5 kg"
                    .Type = "[火]+[龍]"
                    .ImagePath = "/FormDifferenceImages/006/MegaX.png"
                    .Category = "火焰神奇寶貝"
                    .BodyColor = "黑"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "全身湧出超乎尋常的力量，將身體染成了黑色，同時熊熊燃燒著藍色的火焰。"
                    With .SpeciesStrengthValues
                        .HP = 78
                        .Attack = 130
                        .Defence = 111
                        .SpecialAttack = 130
                        .SpecialDefence = 85
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 70
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "100.5 kg"
                    .Type = "[火]+[飛行]"
                    .Category = "火焰神奇寶貝"
                    .BodyColor = "紅"
                    .ImagePath = "/FormDifferenceImages/006/MegaY.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "與訓練家的牽絆是牠力量的泉源。引以為傲的飛行能力甚至凌駕於噴射機之上。"
                    With .SpeciesStrengthValues
                        .HP = 78
                        .Attack = 104
                        .Defence = 78
                        .SpecialAttack = 159
                        .SpecialDefence = 115
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超極巨化之力不僅讓噴火龍變得更加巨大，還讓牠獲得了熊熊燃燒的翅膀。攝氏２０００度的火焰在體內形成了旋渦。當牠咆哮的時候，火力還會進一步提升。"
                    .Ability1 = 66
                    .Ability2 = "---"
                    .AbilityHidden = 94
                    .Height = "28.0 m以上"
                    .Weight = "<缺數據>"
                    .Type = "[火]+[飛行]"
                    .Category = "火焰神奇寶貝"
                    .BodyColor = "紅"
                    .ImagePath = "/FormDifferenceImages/006/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .Attack = 84
                        .Defence = 78
                        .HP = 78
                        .SpecialAttack = 109
                        .SpecialDefence = 85
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 9
                With FormDifferenceList
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 178
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[水]"
                    .Height = "1.6 m"
                    .Weight = "101.1 kg"
                    .ImagePath = "/FormDifferenceImages/009/Mega.png"
                    .Category = "甲殼神奇寶貝"
                    .BodyColor = "藍"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "甲殼上的大砲有著不遜於戰車的威力。靠著強韌的下盤筋骨承受大砲發射時的衝擊力。"
                    With .SpeciesStrengthValues
                        .HP = 79
                        .Attack = 103
                        .Defence = 120
                        .SpecialAttack = 135
                        .SpecialDefence = 115
                        .Speed = 78
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "不擅長精準的射擊。使用３１門大砲射啊射啊射個不停，才是牠的攻擊風格。從中央的主砲發射的水槍破壞力十足，能夠貫穿山體開出山洞。"
                    .Ability1 = 67
                    .Ability2 = "---"
                    .AbilityHidden = 44
                    .Height = "25.0 m以上"
                    .Weight = "<缺數據>"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/009/Gigantamax.png"
                    .Category = "甲殼神奇寶貝"
                    .BodyColor = "藍"
                    With .SpeciesStrengthValues
                        .Attack = 83
                        .Defence = 100
                        .HP = 79
                        .SpecialAttack = 85
                        .SpecialDefence = 105
                        .Speed = 78
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 15
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 91
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[蟲]+[毒]"
                    .Height = "1.4 m"
                    .Weight = "40.5 kg"
                    .Category = "毒蜂神奇寶貝"
                    .BodyColor = "黃"
                    .ImagePath = "/FormDifferenceImages/015/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "雙腳也變成了毒針。會先用手腳的針猛刺一通，然後用臀部的毒針給予致命一擊。"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 150
                        .Defence = 40
                        .SpecialAttack = 15
                        .SpecialDefence = 80
                        .Speed = 145
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 18
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 99
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.2 m"
                    .Weight = "50.5 kg"
                    .Type = "[一般]+[飛行]"
                    .Category = "鳥神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/018/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 83
                        .Attack = 80
                        .Defence = 80
                        .SpecialAttack = 135
                        .SpecialDefence = 80
                        .Speed = 121
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 19
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[惡]+[一般]"
                    .Ability1 = 82
                    .Ability2 = 55
                    .AbilityHidden = 47
                    .Height = "0.3 m"
                    .Weight = "3.8 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黑"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用門牙咬破大門侵入民宅。扯動鬍鬚尋找出食物然後偷走。太陽下山後才活動。為了幫群體的老大拉達尋找好的食物而在街上跑來跑去。"
                    .ImagePath = "/FormDifferenceImages/019/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 30
                        .Attack = 56
                        .Defence = 35
                        .SpecialAttack = 25
                        .SpecialDefence = 35
                        .Speed = 72
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 20
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[惡]+[一般]"
                    .Ability1 = "050"
                    .Ability2 = "062"
                    .AbilityHidden = "055"
                    .Height = "0.7 m"
                    .Weight = "25.5 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黑"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "率領小拉達組成團隊。每個團隊各有自己的地盤，會為了爭奪食物而發生爭鬥。對食物的味道和新鮮度非常講究的美食家神奇寶貝。據說有拉達棲息的餐廳肯定是好餐廳。"
                    .ImagePath = "/FormDifferenceImages/020/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 71
                        .Defence = 70
                        .SpecialAttack = 40
                        .SpecialDefence = 80
                        .Speed = 77
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 25
                With FormDifferenceList
                    .Add("第六世代之前的種族值")
                    .Add("搭檔皮卡丘")
                    .Add("超極巨化")
                    .Add("換裝皮卡丘")
                    .Add("換裝皮卡丘 - 流行偶像")
                    .Add("換裝皮卡丘 - 博士")
                    .Add("換裝皮卡丘 - 面罩摔角手")
                    .Add("換裝皮卡丘 - 貴婦")
                    .Add("換裝皮卡丘 - 搖滾巨星")
                    .Add("戴著帽子的皮卡丘 - 世界")
                    .Add("戴著帽子的皮卡丘 - 就決定是你了")
                    .Add("戴著帽子的皮卡丘 - 初始")
                    .Add("戴著帽子的皮卡丘 - 豐緣")
                    .Add("戴著帽子的皮卡丘 - 神奧")
                    .Add("戴著帽子的皮卡丘 - 合眾")
                    .Add("戴著帽子的皮卡丘 - 卡洛斯")
                    .Add("戴著帽子的皮卡丘 - 阿羅拉")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/Pokemons/025.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 30
                        .SpecialAttack = 50
                        .SpecialDefence = 40
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/Pokemons/025.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 45
                        .Attack = 80
                        .Defence = 50
                        .SpecialAttack = 75
                        .SpecialDefence = 60
                        .Speed = 120
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .Height = "21.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "膨脹的超極巨化之力使得牠的身體變大，尾巴也變得高聳入雲。當牠用閃電狀的尾巴擊中目標時，不亞於雷擊的電壓和電流便會貫穿對方的全身。"
                    .ImagePath = "/FormDifferenceImages/025/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/FormDifferenceImages/025/Cosplay.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/FormDifferenceImages/025/Cosplay-PopStar.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/FormDifferenceImages/025/Cosplay-PhD.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/FormDifferenceImages/025/Cosplay-Libre.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/FormDifferenceImages/025/Cosplay-Belle.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/FormDifferenceImages/025/Cosplay-RockStar.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多在各種世界冒險的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-World.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多與夥伴相遇時的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-Partner.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多在各個地區冒險的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-Original.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多在豐緣地區冒險的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-Hoenn.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多在神奧地區冒險的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-Sinnoh.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多在合眾地區冒險的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-Unova.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多在卡洛斯地區冒險的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-Kalos.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[電]"
                    .Ability1 = 9
                    .Ability2 = "---"
                    .AbilityHidden = 31
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "戴著同伴訓練家的帽子，樣子有點珍稀的皮卡丘。因為尺寸不太合適，戴起來有點鬆垮垮的。帽子上承載著許許多多在阿羅拉地區冒險的回憶。"
                    .ImagePath = "/FormDifferenceImages/025/Cap-Alola.png"
                    .Height = "0.4 m"
                    .Weight = "6.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 55
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 26
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[電]+[超能力]"
                    .Ability1 = "207"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .Height = "0.7 m"
                    .Weight = "21.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "褐"
                    .UniqueDescription = "只有在阿羅拉地區才會進化成這個樣子。研究者說，其主要原因之一是食物。透過念力操縱電力。乘在尾巴上，利用精神力量浮起來進行移動。"
                    .ImagePath = "/FormDifferenceImages/026/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 85
                        .Defence = 50
                        .SpecialAttack = 95
                        .SpecialDefence = 85
                        .Speed = 110
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 27
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[冰]+[鋼]"
                    .Ability1 = "081"
                    .Ability2 = "---"
                    .AbilityHidden = "202"
                    .Height = "0.7 m"
                    .Weight = "40.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "白"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "棲息在雪山。鋼鐵的甲殼非常堅固，但因為過於堅硬，身體沒法蜷縮起來。讓穿山鼠在冰上滑行，比賽滑行的距離。這是阿羅拉自古就有的慶典之一。"
                    .ImagePath = "/FormDifferenceImages/027/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 75
                        .Defence = 90
                        .SpecialAttack = 10
                        .SpecialDefence = 35
                        .Speed = 40
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 28
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[冰]+[鋼]"
                    .Ability1 = "081"
                    .Ability2 = "---"
                    .AbilityHidden = "202"
                    .Height = "1.2 m"
                    .Weight = "55.0 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "白"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "從火山爆發逃難的最後，在雪山棲息定居下來。會濺起雪花在雪原上奔馳。鋼針被冰覆蓋著。被刺中時不但會造成很深的傷口，同時也會凍傷。"
                    .ImagePath = "/FormDifferenceImages/028/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 100
                        .Defence = 120
                        .SpecialAttack = 25
                        .SpecialDefence = 65
                        .Speed = 65
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 37
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[冰]"
                    .Ability1 = "081"
                    .Ability2 = "---"
                    .AbilityHidden = "117"
                    .Height = "0.6 m"
                    .Weight = "9.9 kg"
                    .Category = "狐狸神奇寶貝"
                    .BodyColor = "白"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會噴出零下５０度的冷氣。阿羅拉的老人也會用凱歐凱歐這個過去的名字稱呼牠。天氣熱的時候會用６根尾巴製造冰礫再撒向周圍，藉此讓身體冷卻下來。"
                    .ImagePath = "/FormDifferenceImages/037/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 38
                        .Attack = 41
                        .Defence = 40
                        .SpecialAttack = 50
                        .SpecialDefence = 65
                        .Speed = 65
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 38
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[冰]"
                    .Ability1 = "081"
                    .Ability2 = "---"
                    .AbilityHidden = "117"
                    .IsUniqueDescriptionAvailable = True
                    .Height = "1.1 m"
                    .Weight = "19.9 kg"
                    .Category = "狐狸神奇寶貝"
                    .BodyColor = "白"
                    .UniqueDescription = "從體毛中生出冰粒，潑向敵人。如果惹惱牠，一瞬間就會被冰鎮。性格穩重。被人知道是九尾的地區形態之前，一直被尊敬為神的化身。"
                    .ImagePath = "/FormDifferenceImages/038/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 73
                        .Attack = 67
                        .Defence = 75
                        .SpecialAttack = 81
                        .SpecialDefence = 100
                        .Speed = 109
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 50
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[地面]+[鋼]"
                    .Ability1 = "008"
                    .Ability2 = "221"
                    .AbilityHidden = "159"
                    .Height = "0.2 m"
                    .Weight = "1.0 kg"
                    .Category = "鼴鼠神奇寶貝"
                    .BodyColor = "褐"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "從頭上長出來的是鬍鬚變化而來的金屬物體。隨著擺動跟夥伴進行交流。金色的鬍子擁有感應器的功能。會從洞裡伸出，查探周圍的狀態。"
                    .ImagePath = "/FormDifferenceImages/050/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 10
                        .Attack = 55
                        .Defence = 30
                        .SpecialAttack = 35
                        .SpecialDefence = 45
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 51
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[地面]+[鋼]"
                    .Ability1 = "008"
                    .Ability2 = "221"
                    .AbilityHidden = "159"
                    .Height = "0.7 m"
                    .Weight = "66.6 kg"
                    .Category = "鼴鼠神奇寶貝"
                    .BodyColor = "褐"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用金光閃爍的鬍子保護身體。聽說如果把脫落的鬍鬚帶回家，會招來不幸。被認為是大地女神們的化身，在阿羅拉地區非常受重視。"
                    .ImagePath = "/FormDifferenceImages/051/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 100
                        .Defence = 60
                        .SpecialAttack = 50
                        .SpecialDefence = 70
                        .Speed = 110
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 52
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                    .Add("伽勒爾的樣子")
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[惡]"
                    .Ability1 = "053"
                    .Ability2 = "101"
                    .AbilityHidden = "155"
                    .Height = "0.4 m"
                    .Weight = "4.2 kg"
                    .Category = "妖怪貓神奇寶貝"
                    .BodyColor = "藍"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "原本不棲息在阿羅拉，是人為引進後在野外繁殖而來的。性格聰明狡猾，自尊心很強。如果被傷到高傲的自尊心，或是額頭上的金幣被弄髒時，就會發狂般情緒失控。"
                    .ImagePath = "/FormDifferenceImages/052/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 35
                        .Defence = 35
                        .SpecialAttack = 50
                        .SpecialDefence = 40
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[鋼]"
                    .Ability1 = 53
                    .Ability2 = 181
                    .AbilityHidden = 127
                    .Height = "0.4 m"
                    .Weight = "7.5 kg"
                    .Category = "妖怪貓神奇寶貝"
                    .BodyColor = "褐"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "和好戰的海洋民族一起生活，久而久之身體的各個地方就都變成了黑鐵。額頭上的金幣越黑就越硬，也越能受到夥伴的尊敬。性情勇猛，什麼都不怕。"
                    .ImagePath = "/FormDifferenceImages/052/Galar.png"
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 45
                        .Defence = 35
                        .SpecialAttack = 40
                        .SpecialDefence = 40
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[一般]"
                    .Ability1 = 53
                    .Ability2 = 101
                    .AbilityHidden = 127
                    .Height = "33.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "妖怪貓神奇寶貝"
                    .BodyColor = "黃"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "人們認為牠額頭上金幣浮現出的紋路中蘊藏著解開極巨化之謎的關鍵。受超極巨化之力的影響，身體越長越高，額頭上的金幣也變成了大金幣。"
                    .ImagePath = "/FormDifferenceImages/052/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 45
                        .Defence = 35
                        .SpecialAttack = 40
                        .SpecialDefence = 40
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 53
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[惡]"
                    .Ability1 = "169"
                    .Ability2 = "101"
                    .AbilityHidden = "155"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "圓圓的臉孔，比最高級的天鵝絨還光滑的毛髮，在阿羅拉是非常受歡迎的神奇寶貝。蔑視自己之外的一切。喜歡採用突襲和夜襲等卑劣無恥的戰法。"
                    .ImagePath = "/FormDifferenceImages/053/Alola.png"
                    .Height = "1.1 m"
                    .Weight = "33.0 kg"
                    .Category = "暹羅貓神奇寶貝"
                    .BodyColor = "藍"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 60
                        .Defence = 60
                        .SpecialAttack = 75
                        .SpecialDefence = 65
                        .Speed = 115
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 58
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[火]+[岩石]"
                    .Ability1 = 22
                    .Ability2 = 18
                    .AbilityHidden = 69
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "兩隻一組共同負責地盤的警戒工作。體毛中混有火成岩的成分，可以推想這是受到火山活動的影響。 "
                    .ImagePath = "/FormDifferenceImages/058/Hisui.png"
                    .Height = "0.8 m"
                    .Weight = "22.7 kg"
                    .Category = "放哨神奇寶貝"
                    .BodyColor = "褐"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 75
                        .Defence = 45
                        .SpecialAttack = 65
                        .SpecialDefence = 50
                        .Speed = 55
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 59
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[火]+[岩石]"
                    .Ability1 = 22
                    .Ability2 = 18
                    .AbilityHidden = 69
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "將猛烈燃燒的火焰纏繞在牙齒上撲向獵物。雖然體型很大，卻能以靈巧的假動作戲弄敵手，那姿態就像是舞蹈一般。"
                    .ImagePath = "/FormDifferenceImages/059/Hisui.png"
                    .Height = "2.0 m"
                    .Weight = "168.0 kg"
                    .Category = "傳說神奇寶貝"
                    .BodyColor = "褐"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 115
                        .Defence = 80
                        .SpecialAttack = 95
                        .SpecialDefence = 80
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 65
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 36
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.2 m"
                    .Weight = "48.0 kg"
                    .Category = "念力神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[超能力]"
                    .ImagePath = "/FormDifferenceImages/065/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "透過超級進化，牠的力量全部變換為精神力量。甚至連肌肉力量也失去了。釋放蘊藏著的精神力量。只要看一眼就能知道對手由生到死的全部事情。"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 50
                        .Defence = 65
                        .SpecialAttack = 175
                        .SpecialDefence = 95
                        .Speed = 150
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 68
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 62
                    .Ability2 = 99
                    .AbilityHidden = 80
                    .Height = "25.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "怪力神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[格鬥]"
                    .ImagePath = "/FormDifferenceImages/068/Gigantamax.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "手臂裡充斥著超極巨化之力，因此能施展出破壞力不亞於炸彈的拳擊。怪力提升到了驚人境界，甚至曾經把受困的大型船隻整艘扛到了港口。"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 130
                        .Defence = 80
                        .SpecialAttack = 65
                        .SpecialDefence = 85
                        .Speed = 55
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 74
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[岩石]+[電]"
                    .Ability1 = 42
                    .Ability2 = 5
                    .AbilityHidden = 206
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "石頭身體帶有磁力。在磁力特別強的部分附著密密麻麻的鐵砂哦。如果踩到在地面睡覺的小拳石，就會發出叮──的響聲，全身會一下子變得麻痺。"
                    .ImagePath = "/FormDifferenceImages/074/Alola.png"
                    .Height = "0.4 m"
                    .Weight = "20.3 kg"
                    .Category = "岩石神奇寶貝"
                    .BodyColor = "灰"
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 80
                        .Defence = 100
                        .SpecialAttack = 30
                        .SpecialDefence = 30
                        .Speed = 20
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 75
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[岩石]+[電]"
                    .Ability1 = 42
                    .Ability2 = 5
                    .AbilityHidden = 206
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "很喜歡吃鎂電氣石，吃下的成分會變為結晶，在身體的一部分上浮現出來。為尋找吃的石頭而打架。隆隆石們每次互相碰撞都會發出爆炸聲和耀眼的光芒。"
                    .ImagePath = "/FormDifferenceImages/075/Alola.png"
                    .Height = "1.0 m"
                    .Weight = "110.0 kg"
                    .Category = "岩石神奇寶貝"
                    .BodyColor = "灰"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 95
                        .Defence = 115
                        .SpecialAttack = 45
                        .SpecialDefence = 45
                        .Speed = 35
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 76
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[岩石]+[電]"
                    .Ability1 = "042"
                    .Ability2 = "005"
                    .AbilityHidden = "206"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "發射出帶著電的岩石。即使沒有擊中，只是擦到就能令對手因麻痺而失去意識。因無法連續發射岩石，所以有時候會捕捉附近的小拳石，裝在背上用來發射。"
                    .ImagePath = "/FormDifferenceImages/076/Alola.png"
                    .Height = "1.7 m"
                    .Weight = "316.0 kg"
                    .Category = "岩石神奇寶貝"
                    .BodyColor = "灰"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 120
                        .Defence = 130
                        .SpecialAttack = 55
                        .SpecialDefence = 65
                        .Speed = 45
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 77
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[超能力]"
                    .Ability1 = 50
                    .Ability2 = 257
                    .AbilityHidden = 107
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "小小的角裡蘊藏著治癒之力。如果只是一點小傷，牠只要用角輕擦傷口就能治癒。能從眼神中讀取對方的內心。如果發現了邪惡的想法，就會在轉眼間消失不見。"
                    .ImagePath = "/FormDifferenceImages/077/Galar.png"
                    .Height = "0.8 m"
                    .Weight = "24.0 kg"
                    .Category = "一角神奇寶貝"
                    .BodyColor = "白"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 85
                        .Defence = 55
                        .SpecialAttack = 65
                        .SpecialDefence = 65
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 78
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[超能力]+[妖精]"
                    .Ability1 = 50
                    .Ability2 = 257
                    .AbilityHidden = 107
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會從角發射強力的精神利刃。那超群的破壞力甚至可以在厚厚的鐵板上開出洞來。勇猛果敢，自尊心強。會在蹄上的毛裡儲存精神力量，在森林中輕快地奔跑。"
                    .ImagePath = "/FormDifferenceImages/078/Galar.png"
                    .Height = "0.8 m"
                    .Weight = "24.0 kg"
                    .Category = "一角神奇寶貝"
                    .BodyColor = "白"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 100
                        .Defence = 70
                        .SpecialAttack = 80
                        .SpecialDefence = 80
                        .Speed = 105
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 79
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[超能力]"
                    .Ability1 = 82
                    .Ability2 = 20
                    .AbilityHidden = 144
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "平時一直都在發呆，但偶爾會突然露出銳利的神色。據說這和牠所吃的食物有關。牠以只生長在伽勒爾地區的植物的種子為食，因此尾巴是辣味的。"
                    .ImagePath = "/FormDifferenceImages/079/Galar.png"
                    .Height = "1.2 m"
                    .Weight = "36.0 kg"
                    .Category = "憨憨神奇寶貝"
                    .BodyColor = "粉"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 65
                        .Defence = 65
                        .SpecialAttack = 40
                        .SpecialDefence = 40
                        .Speed = 15
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 80
                With FormDifferenceList
                    .Add("超進化")
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Ability1 = 75
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.0 m"
                    .Weight = "120.0 kg"
                    .Category = "寄居蟹神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[水]+[超能力]"
                    .ImagePath = "/FormDifferenceImages/080/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超級進化的能量全部被注入到了尾部的大舌貝裡。然後呆呆獸被整個吞下。吸收了超級進化能量的大舌貝成了銅牆鐵壁般的鎧甲。呆呆獸本身並沒有什麼變化。"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 75
                        .Defence = 180
                        .SpecialAttack = 130
                        .SpecialDefence = 80
                        .Speed = 30
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[毒]+[超能力]"
                    .Ability1 = 259
                    .Ability2 = 20
                    .AbilityHidden = 144
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "被大舌貝咬住的刺激和體內的香料發生化學反應，讓牠變成了毒屬性。當牠捏住咬著自己的大舌貝的舌頭，螺旋狀的貝殼尖端就會噴射出有劇毒的液體。"
                    .ImagePath = "/FormDifferenceImages/080/Galar.png"
                    .Height = "1.6 m"
                    .Weight = "70.5 kg"
                    .Category = "寄居蟹神奇寶貝"
                    .BodyColor = "粉"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 100
                        .Defence = 95
                        .SpecialAttack = 100
                        .SpecialDefence = 70
                        .Speed = 30
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 83
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[一般]+[飛行]"
                    .Ability1 = 51
                    .Ability2 = 39
                    .AbilityHidden = 128
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .ImagePath = "/Pokemons/083.png"
                    .Height = "0.8 m"
                    .Weight = "42.0 kg"
                    .Category = "黃嘴鴨神奇寶貝"
                    .BodyColor = "褐"
                    With .SpeciesStrengthValues
                        .HP = 52
                        .Attack = 65
                        .Defence = 55
                        .SpecialAttack = 58
                        .SpecialDefence = 62
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[格鬥]"
                    .Ability1 = 80
                    .Ability2 = "---"
                    .AbilityHidden = 113
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "生活在伽勒爾的大蔥鴨。揮舞著又粗又壯的大蔥，是英勇奮戰的戰士。在不斷活用又粗又長的伽勒爾大蔥的過程中，大蔥鴨演化成了獨特的樣子。"
                    .ImagePath = "/FormDifferenceImages/083/Galar.png"
                    .Height = "0.8 m"
                    .Weight = "42.0 kg"
                    .Category = "黃嘴鴨神奇寶貝"
                    .BodyColor = "褐"
                    With .SpeciesStrengthValues
                        .HP = 52
                        .Attack = 95
                        .Defence = 55
                        .SpecialAttack = 58
                        .SpecialDefence = 62
                        .Speed = 55
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 88
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[毒]+[惡]"
                    .Ability1 = 143
                    .Ability2 = 82
                    .AbilityHidden = 223
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "為了解決垃圾問題從其他地區帶來的臭泥不知不覺就變成了這個樣子。結晶是毒素塊。如果從臭泥的身上落下，就會流出足以致死的毒素。"
                    .ImagePath = "/FormDifferenceImages/088/Alola.png"
                    .Height = "0.7 m"
                    .Weight = "42.0 kg"
                    .Category = "污泥神奇寶貝"
                    .BodyColor = "綠"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 80
                        .Defence = 50
                        .SpecialAttack = 40
                        .SpecialDefence = 50
                        .Speed = 25
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 89
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[毒]+[惡]"
                    .Ability1 = 143
                    .Ability2 = 82
                    .AbilityHidden = 223
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "極度鮮豔的身體顏色是因為吃下的垃圾不斷在體內引起化學反應。意外地沉穩且友善，但若一直不給牠垃圾吃，牠就會破壞傢具，把傢具當食物吃掉。"
                    .ImagePath = "/FormDifferenceImages/089/Alola.png"
                    .Height = "1.0 m"
                    .Weight = "52.0 kg"
                    .Category = "污泥神奇寶貝"
                    .BodyColor = "綠"
                    With .SpeciesStrengthValues
                        .HP = 105
                        .Attack = 105
                        .Defence = 75
                        .SpecialAttack = 65
                        .SpecialDefence = 100
                        .Speed = 50
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 94
                With FormDifferenceList
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .Ability1 = 23
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.4 m"
                    .Weight = "40.5 kg"
                    .Category = "影子神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[幽靈]+[毒]"
                    .ImagePath = "/FormDifferenceImages/094/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "耿鬼的愛是扭曲的。聽說耿鬼只會對自己當成狩獵目標的對手萌生愛意。因超級進化的能量而覺醒。潛伏在異次元，一直靜靜地等待著攻擊的機會。"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 65
                        .Defence = 80
                        .SpecialAttack = 170
                        .SpecialDefence = 95
                        .Speed = 130
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Ability1 = 130
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "20.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "影子神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[幽靈]+[毒]"
                    .ImagePath = "/FormDifferenceImages/094/Gigantamax.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "身體裡填滿了詛咒的能量。據說牠巨大嘴巴的另一端連接著死後的世界。會設下致命的陷阱。如果站在牠的嘴巴前面，就會聽見心愛之人呼喚自己的聲音。"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 65
                        .Defence = 60
                        .SpecialAttack = 130
                        .SpecialDefence = 75
                        .Speed = 110
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 99
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .Ability1 = 52
                    .Ability2 = 75
                    .AbilityHidden = 125
                    .Height = "19.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "鉗子神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/099/Gigantamax.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "受到超極巨化之力影響而變得巨大的左鉗可以把任何東西都夾得粉碎。會吐出強鹼性的泡沫，對手一旦被泡沫沾上，身體就會立刻溶化。"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 130
                        .Defence = 115
                        .SpecialAttack = 50
                        .SpecialDefence = 50
                        .Speed = 75
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 100
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Ability1 = 43
                    .Ability2 = 9
                    .AbilityHidden = 106
                    .Height = "0.5 m"
                    .Weight = "13.0 kg"
                    .Category = "丸神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]+[草]"
                    .ImagePath = "/FormDifferenceImages/100/Hisui.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 30
                        .Defence = 50
                        .SpecialAttack = 55
                        .SpecialDefence = 55
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 101
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Ability1 = 43
                    .Ability2 = 9
                    .AbilityHidden = 106
                    .Height = "1.2 m"
                    .Weight = "66.6 kg"
                    .Category = "球神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]"
                    .ImagePath = "/Pokemons/101.png"
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 50
                        .Defence = 70
                        .SpecialAttack = 80
                        .SpecialDefence = 80
                        .Speed = 140
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Ability1 = 43
                    .Ability2 = 9
                    .AbilityHidden = 106
                    .Height = "1.2 m"
                    .Weight = "71.0 kg"
                    .Category = "丸神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]+[草]"
                    .ImagePath = "/FormDifferenceImages/101/Hisui.png"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "體表的組織與球果的成分極為接近，實在不可思議。當牠情緒焦躁時所放出的電流，能量足以匹敵２０次的落雷。"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 50
                        .Defence = 70
                        .SpecialAttack = 80
                        .SpecialDefence = 80
                        .Speed = 150
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 103
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[草]+[超能力]"
                    .Ability1 = 34
                    .Ability2 = "---"
                    .AbilityHidden = 139
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = ""
                    .ImagePath = "/Pokemons/103.png"
                    .Height = "2.0 m"
                    .Weight = "120.0 kg"
                    .Category = "椰子神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 95
                        .Defence = 85
                        .SpecialAttack = 125
                        .SpecialDefence = 65
                        .Speed = 55
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[草]+[龍]"
                    .Ability1 = 119
                    .Ability2 = "---"
                    .AbilityHidden = 139
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "對牠來說，阿羅拉是最棒的環境。當地的人們誇讚說這才是椰蛋樹原本該有的樣子。悠悠地成長，變得不再需要精神力量，沉睡的龍之力也覺醒了。"
                    .ImagePath = "/FormDifferenceImages/103/Alola.png"
                    .Height = "10.9 m"
                    .Weight = "415.6 kg"
                    .Category = "椰子神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 105
                        .Defence = 85
                        .SpecialAttack = 125
                        .SpecialDefence = 75
                        .Speed = 45
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 105
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[火]+[幽靈]"
                    .Ability1 = 130
                    .Ability2 = 31
                    .AbilityHidden = 69
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "手裡的骨頭是母親的骸骨。死後還思念著孩子的母親帶著遺憾，化為火焰守護著嘎啦嘎啦。有哀悼夥伴的習性。若路邊有隆起的土，那是嘎啦嘎啦的墳墓。"
                    .ImagePath = "/FormDifferenceImages/105/Alola.png"
                    .Height = "1.0 m"
                    .Weight = "34.0 kg"
                    .Category = "愛骨神奇寶貝"
                    .BodyColor = "紫"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 80
                        .Defence = 110
                        .SpecialAttack = 50
                        .SpecialDefence = 80
                        .Speed = 45
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 110
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[毒]+[妖精]"
                    .Ability1 = 26
                    .Ability2 = 256
                    .AbilityHidden = 228
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "在往昔工廠林立、空氣嚴重污染的時代，雙彈瓦斯不知道為什麼變成了這個樣子。會吸收大氣中的污染成分，然後吐出新鮮的空氣，這就是牠的排泄方式。"
                    .ImagePath = "/FormDifferenceImages/110/Galar.png"
                    .Height = "3.0 m"
                    .Weight = "16.0 kg"
                    .Category = "毒氣神奇寶貝"
                    .BodyColor = "灰"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 90
                        .Defence = 120
                        .SpecialAttack = 85
                        .SpecialDefence = 70
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 115
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 185
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[一般]"
                    .Height = "2.2 m"
                    .Weight = "100.0 kg"
                    .Category = "親子神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/115/Mega.png"
                    .UniqueDescription = "超級袋獸之所以強大，是母親因孩子的成長而感到喜悅，變得幹勁十足的緣故。孩子因超級進化而成長，但總是爭強好勝，所以母親對孩子的將來有點擔心。看到孩子超級進化後的背影，母親就會不禁想像起終將來臨的別離之日。"
                    With .SpeciesStrengthValues
                        .HP = 105
                        .Attack = 125
                        .Defence = 100
                        .SpecialAttack = 60
                        .SpecialDefence = 100
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 122
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[冰]+[超能力]"
                    .Ability1 = 72
                    .Ability2 = 251
                    .AbilityHidden = 115
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "擅長踢踏舞。會用冷氣製造出冰之地板並將其踢起，以此作為保護自己的障壁。"
                    .ImagePath = "/FormDifferenceImages/122/Galar.png"
                    .Height = "1.4 m"
                    .Weight = "56.8 kg"
                    .Category = "舞蹈神奇寶貝"
                    .BodyColor = "白"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 65
                        .Defence = 65
                        .SpecialAttack = 90
                        .SpecialDefence = 90
                        .Speed = 100
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 127
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 184
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[蟲]+[飛行]"
                    .Height = "1.7 m"
                    .Weight = "59.0 kg"
                    .Category = "鍬形蟲神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/127/Mega.png"
                    .UniqueDescription = "受到超級進化的影響，隨時都處於興奮狀態。會用２隻大角將敵人刺穿後撕裂。翅膀變得異常發達。能以大約５０公里的時速飛行。"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 155
                        .Defence = 120
                        .SpecialAttack = 65
                        .SpecialDefence = 90
                        .Speed = 105
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 128
                With FormDifferenceList
                    .Add("帕底亞的樣子 - 鬥戰種")
                    .Add("帕底亞的樣子 - 火熾種")
                    .Add("帕底亞的樣子 - 水瀾種")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 22
                    .Ability2 = 83
                    .AbilityHidden = 291
                    .Type = "[格鬥]"
                    .Height = "1.4 m"
                    .Weight = "115.0 kg"
                    .Category = "暴牛神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/128/PaldeaCombat.png"
                    .UniqueDescription = "特徵是厚實有力的肌肉，以及粗魯暴躁的性格。這種樣子被稱為鬥戰種。擅長以肌肉發達的身體打格鬥戰。會用短短的角瞄準對手的要害。"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 110
                        .Defence = 105
                        .SpecialAttack = 30
                        .SpecialDefence = 70
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 22
                    .Ability2 = 83
                    .AbilityHidden = 291
                    .Type = "[格鬥]+[火]"
                    .Height = "1.4 m"
                    .Weight = "85.0 kg"
                    .Category = "暴牛神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/128/PaldeaBlaze.png"
                    .UniqueDescription = "噴出的鼻息溫度很高，因此被命名為火熾種。３根尾巴總是束在一起。會用火焰能量將角加熱到攝氏１０００度，被刺中的敵人會受創傷和灼傷所苦。"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 110
                        .Defence = 105
                        .SpecialAttack = 30
                        .SpecialDefence = 70
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 22
                    .Ability2 = 83
                    .AbilityHidden = 291
                    .Type = "[格鬥]+[水]"
                    .Height = "1.4 m"
                    .Weight = "110.0 kg"
                    .Category = "暴牛神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/128/PaldeaAqua.png"
                    .UniqueDescription = "會從角噴出水來游泳。脂肪含量高而容易浮在水上是水瀾種的特徵。會從角尖端的洞噴射出力道強勁的水流，以其高壓來貫穿敵人的身體。"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 110
                        .Defence = 105
                        .SpecialAttack = 30
                        .SpecialDefence = 70
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 130
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 104
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[水]+[飛行]"
                    .Height = "6.5 m"
                    .Weight = "305.0 kg"
                    .Category = "兇惡神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/130/Mega.png"
                    .UniqueDescription = "超級進化對牠的身體造成了負擔，對大腦也會起副作用。只剩下將一切都燒毀破壞的本能。從身體側面的噴射口噴出水來，沿著水面飛行。那速度超過了音速。"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 155
                        .Defence = 109
                        .SpecialAttack = 70
                        .SpecialDefence = 130
                        .Speed = 81
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 131
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 11
                    .Ability2 = 75
                    .AbilityHidden = 93
                    .Type = "[水]+[冰]"
                    .Height = "24.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "承載神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/131/Gigantamax.png"
                    .UniqueDescription = "可以讓超過５０００個人乘坐在自己背部的甲殼上。完全不會搖晃，坐起來非常舒適。冰粒集中在身體周圍，形成巨大的圓環。會一邊用圓環擊碎冰山，一邊悠然地游泳。"
                    With .SpeciesStrengthValues
                        .HP = 130
                        .Attack = 85
                        .Defence = 80
                        .SpecialAttack = 85
                        .SpecialDefence = 95
                        .Speed = 60
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 133
                With FormDifferenceList
                    .Add("搭檔伊布")
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 50
                    .Ability2 = 91
                    .AbilityHidden = 107
                    .Type = "[一般]"
                    .Height = "0.3 m"
                    .Weight = "6.5 kg"
                    .Category = "進化神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/Pokemons/133.png"
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 75
                        .Defence = 70
                        .SpecialAttack = 65
                        .SpecialDefence = 85
                        .Speed = 75
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 50
                    .Ability2 = 91
                    .AbilityHidden = 107
                    .Type = "[一般]"
                    .Height = "18.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "進化神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/133/Gigantamax.png"
                    .UniqueDescription = "超極巨化之力使得頸部的絨毛變得更加地毛茸茸。會用絨毛包住敵人，同時擄獲牠的心。性情變得更加天真無邪。不管遇到誰都會撲上去玩耍，但巨大的身體往往會把對方壓垮。"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 55
                        .Defence = 50
                        .SpecialAttack = 45
                        .SpecialDefence = 65
                        .Speed = 66
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 142
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 181
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.1 m"
                    .Weight = "79.0 kg"
                    .Category = "化石神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[岩石]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/142/Mega.png"
                    .UniqueDescription = "身體的一部分變成了石頭。也有學者主張這才是化石翼龍真正的模樣。超級進化後，粗暴的脾氣比以前更勝一籌。據說那是因為力量過剩讓牠感到痛苦的緣故。"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 135
                        .Defence = 85
                        .SpecialAttack = 70
                        .SpecialDefence = 95
                        .Speed = 150
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 143
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 17
                    .Ability2 = 47
                    .AbilityHidden = 82
                    .Type = "[一般]"
                    .Height = "35.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "睡覺神奇寶貝"
                    .BodyColor = "黑"
                    .ImagePath = "/FormDifferenceImages/143/Gigantamax.png"
                    .UniqueDescription = "在超極巨化之力的影響下，吃東西時掉在肚子上的種子和黏在身上的小石子也一起變大了。擁有駭人的力量。體型像山一樣巨大，而且不動如山。"
                    With .SpeciesStrengthValues
                        .HP = 160
                        .Attack = 110
                        .Defence = 65
                        .SpecialAttack = 65
                        .SpecialDefence = 110
                        .Speed = 30
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 144
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[超能力]+[飛行]"
                    .Ability1 = 172
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用精神力量製作的羽毛狀利刃，就連厚厚的鐵板都能像紙片般割開。射出的光束會讓對方的身體像結凍似地失去自由。"
                    .ImagePath = "/FormDifferenceImages/144/Galar.png"
                    .Height = "1.7 m"
                    .Weight = "50.9 kg"
                    .Category = "冷酷神奇寶貝"
                    .BodyColor = "紫"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 85
                        .Defence = 85
                        .SpecialAttack = 125
                        .SpecialDefence = 100
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 145
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[格鬥]+[飛行]"
                    .Ability1 = 128
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "由於羽毛相擦時會發出像電流般的劈哩啪啦聲，因此一直被稱為閃電鳥。擁有能夠一腳踢毀砂石車的強勁腳力。據說能以時速３００公里在山中奔跑。"
                    .ImagePath = "/FormDifferenceImages/145/Galar.png"
                    .Height = "1.6 m"
                    .Weight = "58.2 kg"
                    .Category = "健腳神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 125
                        .Defence = 90
                        .SpecialAttack = 85
                        .SpecialDefence = 90
                        .Speed = 100
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 146
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[惡]+[飛行]"
                    .Ability1 = 201
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "釋放著像火焰般燃起的邪惡氣場。這樣的外觀讓牠得到了火焰鳥之名。如果被牠烈火般的邪惡氣場掃到，就會精疲力竭，鬥志燒盡只剩下雪白的灰。"
                    .ImagePath = "/FormDifferenceImages/146/Galar.png"
                    .Height = "2.0 m"
                    .Weight = "66.0 kg"
                    .Category = "邪惡神奇寶貝"
                    .BodyColor = "紅"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 85
                        .Defence = 90
                        .SpecialAttack = 100
                        .SpecialDefence = 125
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 150
                With FormDifferenceList
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 80
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.3 m"
                    .Weight = "127.0 kg"
                    .Category = "基因神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[超能力]+[格鬥]"
                    .ImagePath = "/FormDifferenceImages/150/MegaX.png"
                    .UniqueDescription = "精神力量增強了牠身上的肌肉。牠的握力強達１噸，100公尺的距離只要２秒就能跑完。"
                    With .SpeciesStrengthValues
                        .HP = 106
                        .Attack = 190
                        .Defence = 100
                        .SpecialAttack = 154
                        .SpecialDefence = 100
                        .Speed = 130
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 15
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[超能力]"
                    .Height = "1.5 m"
                    .Weight = "33.0 kg"
                    .Category = "基因神奇寶貝"
                    .BodyColor = "紫"
                    .ImagePath = "/FormDifferenceImages/150/MegaY.png"
                    .UniqueDescription = "雖然身體變小，力量卻大到難以估計。只要稍微使出一些念力就能將高樓大廈化成灰燼。"
                    With .SpeciesStrengthValues
                        .HP = 106
                        .Attack = 150
                        .Defence = 70
                        .SpecialAttack = 194
                        .SpecialDefence = 120
                        .Speed = 140
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 157
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[火]+[幽靈]"
                    .Ability1 = 66
                    .Ability2 = "---"
                    .AbilityHidden = 119
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "據考察，牠是受到聳立於洗翠中心的靈山所發之氣的影響，才形成了現在的模樣。據說會用自己的火焰淨化並超渡無處可去的靈魂。"
                    .ImagePath = "/FormDifferenceImages/157/Hisui.png"
                    .Height = "1.6 m"
                    .Weight = "69.8 kg"
                    .Category = "鬼火神奇寶貝"
                    .BodyColor = "黃"
                    With .SpeciesStrengthValues
                        .HP = 73
                        .Attack = 84
                        .Defence = 78
                        .SpecialAttack = 119
                        .SpecialDefence = 85
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 181
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 104
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[電]+[龍]"
                    .Height = "1.4 m"
                    .Weight = "61.5 kg"
                    .Category = "燈神奇寶貝"
                    .BodyColor = "黃"
                    .ImagePath = "/FormDifferenceImages/181/Mega.png"
                    .UniqueDescription = "超級進化帶來的過剩能量刺激了牠的基因，使得原本已經脫落的體毛重新長了出來。龐大的能量激烈地刺激細胞。沉睡在體內的龍血似乎因此而覺醒了。"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 95
                        .Defence = 105
                        .SpecialAttack = 165
                        .SpecialDefence = 110
                        .Speed = 45
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 194
                With FormDifferenceList
                    .Add("帕底亞的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[毒]+[地面]"
                    .Ability1 = 38
                    .Ability2 = 11
                    .AbilityHidden = 109
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "因搶輸地盤而到陸地上生活，久而久之變成了是用帶毒的黏膜來保護身體。由於單獨行動很危險，因此在沼地裡行走時會３、４隻排成一列來彼此扶持。"
                    .ImagePath = "/FormDifferenceImages/194/Paldea.png"
                    .Height = "0.4 m"
                    .Weight = "11.0 kg"
                    .Category = "毒魚神奇寶貝"
                    .BodyColor = "藍"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 45
                        .Defence = 45
                        .SpecialAttack = 25
                        .SpecialDefence = 25
                        .Speed = 15
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 199
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[毒]+[超能力]"
                    .Ability1 = 261
                    .Ability2 = 20
                    .AbilityHidden = 144
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "受到進化的衝擊和毒素的影響，大舌貝的智力飆升到了可以控制呆呆王的程度。會一邊吟唱詭怪的咒語，一邊混合吃進的東西和體內的毒素來製造可疑的藥。"
                    .ImagePath = "/FormDifferenceImages/194/Paldea.png"
                    .Height = "1.8 m"
                    .Weight = "79.5 kg"
                    .Category = "詛咒師神奇寶貝"
                    .BodyColor = "粉"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 65
                        .Defence = 80
                        .SpecialAttack = 110
                        .SpecialDefence = 110
                        .Speed = 30
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 201
                With FormDifferenceList
                    .Add("A")
                    .Add("B")
                    .Add("C")
                    .Add("D")
                    .Add("E")
                    .Add("F")
                    .Add("G")
                    .Add("H")
                    .Add("I")
                    .Add("J")
                    .Add("K")
                    .Add("L")
                    .Add("M")
                    .Add("N")
                    .Add("O")
                    .Add("P")
                    .Add("Q")
                    .Add("R")
                    .Add("S")
                    .Add("T")
                    .Add("U")
                    .Add("V")
                    .Add("W")
                    .Add("X")
                    .Add("Y")
                    .Add("Z")
                    .Add("!")
                    .Add("?")
                End With
                For i As Integer = 0 To 27
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = "026"
                        .Ability2 = "---"
                        .AbilityHidden = "---"
                        .Height = "0.5 m"
                        .Weight = "5.0 kg"
                        .Category = "象徵神奇寶貝"
                        .BodyColor = "黑"
                        .Type = "[超能力]"
                        .ImagePath = "/FormDifferenceImages/201/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 48
                            .Attack = 72
                            .Defence = 48
                            .SpecialAttack = 72
                            .SpecialDefence = 48
                            .Speed = 48
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 208
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 159
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[鋼]+[地面]"
                    .Height = "10.5 m"
                    .Weight = "740.0 kg"
                    .Category = "鐵蛇神奇寶貝"
                    .BodyColor = "灰"
                    .ImagePath = "/FormDifferenceImages/208/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 125
                        .Defence = 230
                        .SpecialAttack = 55
                        .SpecialDefence = 95
                        .Speed = 30
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 211
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 38
                    .Ability2 = 33
                    .AbilityHidden = 22
                    .Type = "[水]+[毒]"
                    .Height = "0.5 m"
                    .Weight = "3.9 kg"
                    .Category = "氣球神奇寶貝"
                    .BodyColor = "灰"
                    .ImagePath = "/Pokemons/211.png"
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 95
                        .Defence = 75
                        .SpecialAttack = 55
                        .SpecialDefence = 55
                        .Speed = 85
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 38
                    .Ability2 = 33
                    .AbilityHidden = 22
                    .Type = "[惡]+[毒]"
                    .Height = "0.5 m"
                    .Weight = "3.9 kg"
                    .Category = "氣球神奇寶貝"
                    .BodyColor = "黑"
                    .ImagePath = "/FormDifferenceImages/211/Hisui.png"
                    .UniqueDescription = "會用針散布毒素的棘手傢伙，因而受到漁民們的厭惡。棲息在其他地區的千針魚則是呈現著不同的姿態。"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 95
                        .Defence = 85
                        .SpecialAttack = 55
                        .SpecialDefence = 55
                        .Speed = 85
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 212
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 101
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[蟲]+[鋼]"
                    .Height = "2.0 m"
                    .Weight = "125.0 kg"
                    .Category = "鉗子神奇寶貝"
                    .BodyColor = "紅"
                    .ImagePath = "/FormDifferenceImages/212/Mega.png"
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 150
                        .Defence = 140
                        .SpecialAttack = 65
                        .SpecialDefence = 100
                        .Speed = 75
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 214
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 92
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[蟲]+[格鬥]"
                    .Height = "1.7 m"
                    .Weight = "62.5 kg"
                    .Category = "獨角神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/214/Mega.png"
                    .UniqueDescription = "會用２隻角夾住東西舉起來。牠甚至能舉起比自己體重重５００倍的重量。在驚人能量的洗禮下變得更健壯。在超級進化結束後，牠會受強烈的肌肉酸痛所苦。"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 185
                        .Defence = 115
                        .SpecialAttack = 40
                        .SpecialDefence = 110
                        .Speed = 45
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 215
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 39
                    .Ability2 = 51
                    .AbilityHidden = 124
                    .Type = "[格鬥]+[毒]"
                    .Height = "0.5 m"
                    .Weight = "3.9 kg"
                    .Category = "尖爪神奇寶貝"
                    .BodyColor = "黑"
                    .ImagePath = "/FormDifferenceImages/215/Hisui.png"
                    .UniqueDescription = "強健的爪子形狀有助於在斷崖絕壁上行動自如。爪子尖端滴出的毒液會在捉住獵物時侵襲其神經。"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 95
                        .Defence = 55
                        .SpecialAttack = 35
                        .SpecialDefence = 75
                        .Speed = 115
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 222
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 55
                    .Ability2 = 30
                    .AbilityHidden = 144
                    .Type = "[水]+[岩石]"
                    .Height = "0.6 m"
                    .Weight = "5.0 kg"
                    .Category = "珊瑚神奇寶貝"
                    .BodyColor = "粉"
                    .ImagePath = "/Pokemons/222.png"
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 55
                        .Defence = 85
                        .SpecialAttack = 65
                        .SpecialDefence = 85
                        .Speed = 35
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 133
                    .Ability2 = "---"
                    .AbilityHidden = 130
                    .Type = "[幽靈]"
                    .Height = "0.6 m"
                    .Weight = "0.5 kg"
                    .Category = "珊瑚神奇寶貝"
                    .BodyColor = "白"
                    .ImagePath = "/FormDifferenceImages/222/Galar.png"
                    .UniqueDescription = "常出現在從前曾是大海的地方。如果不小心錯把牠當成石頭踢，就會遭到牠的詛咒。牠是因急遽環境變化而死去的遠古太陽珊瑚。會用珊瑚枝吸取人的精氣。"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 55
                        .Defence = 100
                        .SpecialAttack = 65
                        .SpecialDefence = 100
                        .Speed = 30
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 226
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 33
                    .Ability2 = 11
                    .AbilityHidden = 41
                    .Type = "[水]+[飛行]"
                    .Height = "2.1 m"
                    .Weight = "220.0 kg"
                    .Category = "風箏神奇寶貝"
                    .BodyColor = "紫"
                    .ImagePath = "/Pokemons/226.png"
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 40
                        .Defence = 70
                        .SpecialAttack = 80
                        .SpecialDefence = 140
                        .Speed = 70
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 229
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 94
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[惡]+[火]"
                    .Height = "1.9 m"
                    .Weight = "49.5 kg"
                    .Category = "暗神奇寶貝"
                    .BodyColor = "黑"
                    .ImagePath = "/FormDifferenceImages/229/Mega.png"
                    .UniqueDescription = "在黑魯加自己都吃不消的高溫下，牠的紅色爪子和尾巴前端已經開始融化了。全身因超級進化而發熱。能吐出猛烈的火焰，把對手燒成焦炭。"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 90
                        .Defence = 90
                        .SpecialAttack = 140
                        .SpecialDefence = 90
                        .Speed = 115
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 248
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 45
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.5 m"
                    .Weight = "255.0 kg"
                    .Type = "[岩石]+[惡]"
                    .Category = "鎧甲神奇寶貝"
                    .BodyColor = "綠"
                    .ImagePath = "/FormDifferenceImages/248/Mega.png"
                    .UniqueDescription = "體內注入了驚人的能量，使得牠的背部裂開，只剩下破壞的本能驅使著牠行動。就連牠聽不聽得見訓練家的命令都不清楚。"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 164
                        .Defence = 150
                        .SpecialAttack = 95
                        .SpecialDefence = 120
                        .Speed = 71
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 254
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 31
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[草]+[龍]"
                    .Height = "1.9 m"
                    .Weight = "55.2 kg"
                    .Category = "密林神奇寶貝"
                    .BodyColor = "綠"
                    .ImagePath = "/FormDifferenceImages/254/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 110
                        .Defence = 75
                        .SpecialAttack = 145
                        .SpecialDefence = 85
                        .Speed = 145
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 257
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 3
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[火]+[格鬥]"
                    .Height = "1.9 m"
                    .Weight = "52.0 kg"
                    .Category = "猛火神奇寶貝"
                    .BodyColor = "紅"
                    .ImagePath = "/FormDifferenceImages/257/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 160
                        .Defence = 80
                        .SpecialAttack = 130
                        .SpecialDefence = 80
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 260
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 33
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[水]+[格鬥]"
                    .Height = "1.9 m"
                    .Weight = "102.0 kg"
                    .Category = "沼魚神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/260/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 150
                        .Defence = 110
                        .SpecialAttack = 95
                        .SpecialDefence = 110
                        .Speed = 70
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 263
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 53
                    .Ability2 = 82
                    .AbilityHidden = 95
                    .Type = "[惡]+[一般]"
                    .Height = "0.4 m"
                    .Weight = "17.5 kg"
                    .Category = "豆狸神奇寶貝"
                    .BodyColor = "白"
                    .ImagePath = "/FormDifferenceImages/263/Galar.png"
                    .UniqueDescription = "一直在奔跑，永遠靜不下來。如果發現了其他的神奇寶貝，就會故意撞上去挑起事端。這似乎是蛇紋熊最古老的樣子。會之字形亂走，把周圍弄得一團糟。"
                    With .SpeciesStrengthValues
                        .HP = 38
                        .Attack = 30
                        .Defence = 41
                        .SpecialAttack = 30
                        .SpecialDefence = 41
                        .Speed = 60
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 264
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 53
                    .Ability2 = 82
                    .AbilityHidden = 95
                    .Type = "[惡]+[一般]"
                    .Height = "0.5 m"
                    .Weight = "32.5 kg"
                    .Category = "猛衝神奇寶貝"
                    .BodyColor = "白"
                    .ImagePath = "/FormDifferenceImages/264/Galar.png"
                    .UniqueDescription = "會用長舌頭挑釁獵物。一旦獵物被自己激怒，便會猛烈地衝撞上去。有著十分好戰的性情。即使是比自己強的對手也會魯莽地發起挑戰。"
                    With .SpeciesStrengthValues
                        .HP = 78
                        .Attack = 70
                        .Defence = 61
                        .SpecialAttack = 50
                        .SpecialDefence = 61
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 282
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 182
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[超能力]+[妖精]"
                    .Height = "1.6 m"
                    .Weight = "48.4 kg"
                    .Category = "包容神奇寶貝"
                    .BodyColor = "白"
                    .ImagePath = "/FormDifferenceImages/282/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 68
                        .Attack = 85
                        .Defence = 65
                        .SpecialAttack = 165
                        .SpecialDefence = 135
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 302
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 156
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.5 m"
                    .Weight = "161.0 kg"
                    .Category = "黑暗神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[惡]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/302/Mega.png"
                    .UniqueDescription = "胸口的寶石在沐浴了超級進化的能量之後膨脹，撐破皮膚冒了出來。無論怎樣的攻擊都能反射回去。"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 85
                        .Defence = 125
                        .SpecialAttack = 85
                        .SpecialDefence = 115
                        .Speed = 20
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 303
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 37
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[鋼]+[妖精]"
                    .Height = "1.0 m"
                    .Weight = "23.5 kg"
                    .Category = "欺騙神奇寶貝"
                    .BodyColor = "黑"
                    .ImagePath = "/FormDifferenceImages/303/Mega.png"
                    .UniqueDescription = "具有強大的攻擊性。會用２個大顎夾住獵物，然後使盡力量把對手撕碎。"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 105
                        .Defence = 125
                        .SpecialAttack = 55
                        .SpecialDefence = 95
                        .Speed = 50
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 306
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 111
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[鋼]"
                    .Height = "2.2 m"
                    .Weight = "395.0 kg"
                    .Category = "鐵鎧神奇寶貝"
                    .BodyColor = "灰"
                    .ImagePath = "/FormDifferenceImages/306/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 140
                        .Defence = 230
                        .SpecialAttack = 60
                        .SpecialDefence = 80
                        .Speed = 50
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 308
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 74
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.3 m"
                    .Weight = "31.5 kg"
                    .Type = "[格鬥]+[超能力]"
                    .Category = "冥想神奇寶貝"
                    .BodyColor = "紅"
                    .ImagePath = "/FormDifferenceImages/308/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 100
                        .Defence = 85
                        .SpecialAttack = 80
                        .SpecialDefence = 85
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 310
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 22
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.8 m"
                    .Weight = "44.0 kg"
                    .Category = "放電神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[電]"
                    .ImagePath = "/FormDifferenceImages/310/Mega.png"
                    .UniqueDescription = "藉由超級進化在體內儲存了驚人的電量，但卻沒有能力好好加以運用。因為體內儲存了過多電力而焦躁不安。有著與落雷相同速度的瞬間爆發力。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 75
                        .Defence = 80
                        .SpecialAttack = 135
                        .SpecialDefence = 80
                        .Speed = 135
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 319
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 173
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[水]+[惡]"
                    .Height = "2.5 m"
                    .Weight = "130.3 kg"
                    .Category = "凶暴神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/319/Mega.png"
                    .UniqueDescription = "長在頭部的尖刺是牙齒變化而來的。即使受傷折斷，也能無數次地立刻長回來。黃色紋路是過去留下的舊傷。超級進化的能量流過時似乎會陣陣抽痛，讓牠苦不堪言。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 140
                        .Defence = 70
                        .SpecialAttack = 110
                        .SpecialDefence = 65
                        .Speed = 105
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 323
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 125
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[火]+[地面]"
                    .Height = "2.5 m"
                    .Weight = "320.5 kg"
                    .Category = "噴火神奇寶貝"
                    .BodyColor = "紅"
                    .ImagePath = "/FormDifferenceImages/323/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 120
                        .Defence = 100
                        .SpecialAttack = 145
                        .SpecialDefence = 105
                        .Speed = 20
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 334
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 182
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.5 m"
                    .Weight = "20.6 kg"
                    .Category = "哼唱神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[龍]+[妖精]"
                    .ImagePath = "/FormDifferenceImages/334/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 110
                        .Defence = 110
                        .SpecialAttack = 110
                        .SpecialDefence = 105
                        .Speed = 80
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 351
                With FormDifferenceList
                    .Add("太陽的樣子")
                    .Add("雨水的樣子")
                    .Add("雪雲的樣子")
                    .Add("其他天氣的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 59
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.8 kg"
                    .Category = "天氣神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[火]"
                    .ImagePath = "/FormDifferenceImages/351/Sunny.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 70
                        .SpecialDefence = 70
                        .Speed = 70
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 59
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.8 kg"
                    .Category = "天氣神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/351/Rainy.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 70
                        .SpecialDefence = 70
                        .Speed = 70
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 59
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.8 kg"
                    .Category = "天氣神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[冰]"
                    .ImagePath = "/FormDifferenceImages/351/Snowy.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 70
                        .SpecialDefence = 70
                        .Speed = 70
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 59
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.8 kg"
                    .Category = "天氣神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[一般]"
                    .ImagePath = "/FormDifferenceImages/351/General.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 70
                        .SpecialDefence = 70
                        .Speed = 70
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 354
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 158
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.2 m"
                    .Weight = "13.0 kg"
                    .Category = "布偶神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[幽靈]"
                    .ImagePath = "/FormDifferenceImages/354/Mega.png"
                    .UniqueDescription = "超級進化使得怨念增強，導致原本收在拉鍊裡的詛咒之力滿了出來。過大的能量讓詛咒增強到無法抑制的地步，使得牠連自己的訓練家也開始憎恨。"
                    With .SpeciesStrengthValues
                        .HP = 64
                        .Attack = 165
                        .Defence = 75
                        .SpecialAttack = 93
                        .SpecialDefence = 83
                        .Speed = 75
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 359
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 156
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.2 m"
                    .Weight = "49.0 kg"
                    .Category = "災禍神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[惡]"
                    .ImagePath = "/FormDifferenceImages/359/Mega.png"
                    .UniqueDescription = "超級進化的能量高漲，全身的體毛都豎立起來。因為不是翅膀，所以無法飛行。因為本性不喜歡爭鬥，所以非常討厭為了戰鬥而變成這個樣子。將超級進化的能量化成威嚇的氣場四處散佈。膽怯的人甚至會驚嚇致死。"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 150
                        .Defence = 60
                        .SpecialAttack = 115
                        .SpecialDefence = 60
                        .Speed = 115
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 362
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 174
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[冰]"
                    .Height = "2.1 m"
                    .Weight = "350.2 kg"
                    .Category = "假面神奇寶貝"
                    .BodyColor = "灰"
                    .ImagePath = "/FormDifferenceImages/362/Mega.png"
                    .UniqueDescription = "過剩的超級進化能量從口中溢出，擊碎下顎。隨時都噴著暴風雪。把獵物放入口中的瞬間就會讓其凍結，但因下顎脫臼所以沒辦法吃。"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 120
                        .Defence = 80
                        .SpecialAttack = 120
                        .SpecialDefence = 80
                        .Speed = 100
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 373
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 184
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[龍]+[飛行]"
                    .Height = "1.8 m"
                    .Weight = "112.6 kg"
                    .Category = "龍神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/373/Mega.png"
                    .UniqueDescription = "牠引以為傲的一對翅膀因強大的能量而扭曲相黏。備感壓力的牠為此四處大鬧。用刀刃般鋒利的翅膀不斷飛行，同時將擋路的一切全都切成兩半。變得更為粗暴，連培育牠的訓練家也會不留情地襲擊。別名是「染血的新月」。採取將前腳搭在外殼間隙的姿勢來飛行。即使面對複雜的地形也能以高速飛來飛去。"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 145
                        .Defence = 130
                        .SpecialAttack = 120
                        .SpecialDefence = 90
                        .Speed = 120
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 376
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 181
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[鋼]+[超能力]"
                    .Height = "2.5 m"
                    .Weight = "942.9 kg"
                    .Category = "鐵足神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/376/Mega.png"
                    .UniqueDescription = "是１隻巨金怪、１隻金屬怪和２隻鐵啞鈴結合在一起的樣子。超級進化使得大腦受到刺激，變成了為勝利而不擇手段的冷酷性格。"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 145
                        .Defence = 150
                        .SpecialAttack = 105
                        .SpecialDefence = 110
                        .Speed = 110
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 380
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[龍]+[超能力]"
                    .Height = "1.8 m"
                    .Weight = "52.0 kg"
                    .Category = "無限神奇寶貝"
                    .BodyColor = "紫"
                    .ImagePath = "/FormDifferenceImages/380/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 100
                        .Defence = 120
                        .SpecialAttack = 140
                        .SpecialDefence = 150
                        .Speed = 110
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 381
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[龍]+[超能力]"
                    .Height = "2.3 m"
                    .Weight = "70.0 kg"
                    .Category = "無限神奇寶貝"
                    .BodyColor = "紫"
                    .ImagePath = "/FormDifferenceImages/381/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 130
                        .Defence = 100
                        .SpecialAttack = 160
                        .SpecialDefence = 120
                        .Speed = 110
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 382
                With FormDifferenceList
                    .Add("原始回歸型態")
                End With
                With FormDifferenceInfoTemp
                    .Ability1 = 189
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[水]"
                    .Height = "9.8 m"
                    .Weight = "430.0 kg"
                    .Category = "海底神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/382/Primal.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 150
                        .Defence = 90
                        .SpecialAttack = 180
                        .SpecialDefence = 160
                        .Speed = 90
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "利用自然能量進行原始回歸，回到了原本的樣子。擁有呼風喚雨擴張海洋的力量。"
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 383
                With FormDifferenceList
                    .Add("原始回歸型態")
                End With
                With FormDifferenceInfoTemp
                    .ImagePath = "/FormDifferenceImages/383/Primal.png"
                    .Ability1 = 190
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[地面]+[火]"
                    .Height = "5.0 m"
                    .Weight = "999.7 kg"
                    .Category = "大陸神奇寶貝"
                    .BodyColor = "紅"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 180
                        .Defence = 160
                        .SpecialAttack = 150
                        .SpecialDefence = 90
                        .Speed = 90
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "利用自然能量進行原始回歸，回到了原本的樣子。擁有產生熔岩擴張大地的力量。"
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 384
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .ImagePath = "/FormDifferenceImages/384/Mega.png"
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 191
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[龍]+[飛行]"
                    .Height = "10.8 m"
                    .Weight = "392.0 kg"
                    .Category = "天空神奇寶貝"
                    .BodyColor = "綠"
                    With .SpeciesStrengthValues
                        .HP = 105
                        .Attack = 180
                        .Defence = 100
                        .SpecialAttack = 180
                        .SpecialDefence = 100
                        .Speed = 115
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 386
                With FormDifferenceList
                    .Add("普通型態")
                    .Add("攻擊型態")
                    .Add("防禦型態")
                    .Add("速度型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "046"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "60.8 kg"
                    .Category = "DNA神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[超能力]"
                    .ImagePath = "/FormDifferenceImages/386/Common.png"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 150
                        .Defence = 50
                        .SpecialAttack = 150
                        .SpecialDefence = 50
                        .Speed = 150
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "046"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "60.8 kg"
                    .Category = "DNA神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[超能力]"
                    .ImagePath = "/FormDifferenceImages/386/Attack.png"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 180
                        .Defence = 20
                        .SpecialAttack = 180
                        .SpecialDefence = 20
                        .Speed = 150
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "046"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "60.8 kg"
                    .Category = "DNA神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[超能力]"
                    .ImagePath = "/FormDifferenceImages/386/Defence.png"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 70
                        .Defence = 160
                        .SpecialAttack = 70
                        .SpecialDefence = 160
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "046"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "60.8 kg"
                    .Category = "DNA神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[超能力]"
                    .ImagePath = "/FormDifferenceImages/386/Speed.png"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 95
                        .Defence = 90
                        .SpecialAttack = 95
                        .SpecialDefence = 90
                        .Speed = 180
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 412
                With FormDifferenceList
                    .Add("草木蓑衣")
                    .Add("砂土蓑衣")
                    .Add("垃圾蓑衣")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "061"
                    .Ability2 = "---"
                    .AbilityHidden = "142"
                    .Height = "0.2 m"
                    .Weight = "3.4 kg"
                    .Category = "蓑衣蟲神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[蟲]"
                    .ImagePath = "/FormDifferenceImages/412/Plant.png"
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 29
                        .Defence = 45
                        .SpecialAttack = 29
                        .SpecialDefence = 45
                        .Speed = 36
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "061"
                    .Ability2 = "---"
                    .AbilityHidden = "142"
                    .Height = "0.2 m"
                    .Weight = "3.4 kg"
                    .Category = "蓑衣蟲神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[蟲]"
                    .ImagePath = "/FormDifferenceImages/412/Sand.png"
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 29
                        .Defence = 45
                        .SpecialAttack = 29
                        .SpecialDefence = 45
                        .Speed = 36
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "061"
                    .Ability2 = "---"
                    .AbilityHidden = "142"
                    .Height = "0.2 m"
                    .Weight = "3.4 kg"
                    .Category = "蓑衣蟲神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[蟲]"
                    .ImagePath = "/FormDifferenceImages/412/Trash.png"
                    With .SpeciesStrengthValues
                        .HP = 40
                        .Attack = 29
                        .Defence = 45
                        .SpecialAttack = 29
                        .SpecialDefence = 45
                        .Speed = 36
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 413
                With FormDifferenceList
                    .Add("草木蓑衣")
                    .Add("砂土蓑衣")
                    .Add("垃圾蓑衣")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "107"
                    .Ability2 = "---"
                    .AbilityHidden = "142"
                    .Height = "0.5 m"
                    .Weight = "6.5 kg"
                    .Category = "蓑衣蟲神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[蟲]+[草]"
                    .ImagePath = "/FormDifferenceImages/413/Plant.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 59
                        .Defence = 85
                        .SpecialAttack = 79
                        .SpecialDefence = 105
                        .Speed = 36
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "107"
                    .Ability2 = "---"
                    .AbilityHidden = "142"
                    .Height = "0.5 m"
                    .Weight = "6.5 kg"
                    .Category = "蓑衣蟲神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[蟲]+[地面]"
                    .ImagePath = "/FormDifferenceImages/413/Sand.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 79
                        .Defence = 105
                        .SpecialAttack = 59
                        .SpecialDefence = 85
                        .Speed = 36
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "107"
                    .Ability2 = "---"
                    .AbilityHidden = "142"
                    .Height = "0.5 m"
                    .Weight = "6.5 kg"
                    .Category = "蓑衣蟲神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[蟲]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/413/Trash.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 69
                        .Defence = 95
                        .SpecialAttack = 69
                        .SpecialDefence = 95
                        .Speed = 36
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 421
                With FormDifferenceList
                    .Add("陰天形態")
                    .Add("晴天形態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "122"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.5 m"
                    .Weight = "9.3 kg"
                    .Category = "櫻花神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[草]"
                    .ImagePath = "/FormDifferenceImages/421/Overcast.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 60
                        .Defence = 70
                        .SpecialAttack = 87
                        .SpecialDefence = 78
                        .Speed = 85
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "122"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.5 m"
                    .Weight = "9.3 kg"
                    .Category = "櫻花神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[草]"
                    .ImagePath = "/FormDifferenceImages/421/Sunshine.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 60
                        .Defence = 70
                        .SpecialAttack = 87
                        .SpecialDefence = 78
                        .Speed = 85
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 422
                With FormDifferenceList
                    .Add("西海")
                    .Add("東海")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "069"
                    .Ability2 = "114"
                    .AbilityHidden = "159"
                    .Height = "0.3 m"
                    .Weight = "6.3 kg"
                    .Category = "海兔神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/422/West.png"
                    With .SpeciesStrengthValues
                        .HP = 76
                        .Attack = 48
                        .Defence = 48
                        .SpecialAttack = 57
                        .SpecialDefence = 62
                        .Speed = 34
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "069"
                    .Ability2 = "114"
                    .AbilityHidden = "159"
                    .Height = "0.3 m"
                    .Weight = "6.3 kg"
                    .Category = "海兔神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/422/East.png"
                    With .SpeciesStrengthValues
                        .HP = 76
                        .Attack = 48
                        .Defence = 48
                        .SpecialAttack = 57
                        .SpecialDefence = 62
                        .Speed = 34
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 423
                With FormDifferenceList
                    .Add("西海")
                    .Add("東海")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "069"
                    .Ability2 = "114"
                    .AbilityHidden = "159"
                    .Height = "0.9 m"
                    .Weight = "29.9 kg"
                    .Category = "海兔神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[水]+[地面]"
                    .ImagePath = "/FormDifferenceImages/423/West.png"
                    With .SpeciesStrengthValues
                        .HP = 111
                        .Attack = 83
                        .Defence = 68
                        .SpecialAttack = 92
                        .SpecialDefence = 82
                        .Speed = 39
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "069"
                    .Ability2 = "114"
                    .AbilityHidden = "159"
                    .Height = "0.9 m"
                    .Weight = "29.9 kg"
                    .Category = "海兔神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]+[地面]"
                    .ImagePath = "/FormDifferenceImages/423/East.png"
                    With .SpeciesStrengthValues
                        .HP = 111
                        .Attack = 83
                        .Defence = 68
                        .SpecialAttack = 92
                        .SpecialDefence = 82
                        .Speed = 39
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 428
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 113
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[一般]+[格鬥]"
                    .Height = "1.3 m"
                    .Weight = "28.3 kg"
                    .Category = "兔子神奇寶貝"
                    .BodyColor = "褐"
                    .ImagePath = "/FormDifferenceImages/428/Mega.png"
                    .UniqueDescription = "戰鬥的本能因為超級進化而覺醒。捨棄了會妨礙攻擊的毛皮。會像鞭子一樣揮動耳朵鞭打敵人。性情暴躁而好戰。"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 136
                        .Defence = 94
                        .SpecialAttack = 54
                        .SpecialDefence = 96
                        .Speed = 135
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 445
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 159
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[龍]+[地面]"
                    .Height = "1.9 m"
                    .Weight = "95.0 kg"
                    .Category = "超音速神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/445/Mega.png"
                    .UniqueDescription = "因為引以為傲的翅膀變成鐮刀而大發雷霆。揮舞鐮刀，把大地剁成粉末。性情比超級進化之前更加兇暴。會用雙臂的鐮刀把敵人切成碎片。"
                    With .SpeciesStrengthValues
                        .HP = 108
                        .Attack = 170
                        .Defence = 115
                        .SpecialAttack = 120
                        .SpecialDefence = 95
                        .Speed = 92
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 448
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 91
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[格鬥]+[鋼]"
                    .Height = "1.3 m"
                    .Weight = "57.5 kg"
                    .Category = "波導神奇寶貝"
                    .BodyColor = "蓝"
                    .ImagePath = "/FormDifferenceImages/448/Mega.png"
                    .UniqueDescription = "超級進化的能量和波導交互混合在體內流竄，讓全身留下黑色的痕跡。全神貫注，向眼前的敵人挑戰。戰鬥風格只能用「無情」兩字形容。超級進化使得波導膨脹。牠會在鬥爭本能的驅使之下，以無情的手段打倒敵人。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 145
                        .Defence = 88
                        .SpecialAttack = 140
                        .SpecialDefence = 70
                        .Speed = 112
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 460
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 117
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[草]+[冰]"
                    .Height = "2.7 m"
                    .Weight = "185.0 kg"
                    .Category = "樹冰神奇寶貝"
                    .BodyColor = "白"
                    .ImagePath = "/FormDifferenceImages/460/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 132
                        .Defence = 105
                        .SpecialAttack = 132
                        .SpecialDefence = 105
                        .Speed = 30
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 475
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 39
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[超能力]+[格鬥]"
                    .Height = "1.6 m"
                    .Weight = "56.4 kg"
                    .Category = "刀刃神奇寶貝"
                    .BodyColor = "白"
                    .ImagePath = "/FormDifferenceImages/475/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 68
                        .Attack = 165
                        .Defence = 95
                        .SpecialAttack = 65
                        .SpecialDefence = 115
                        .Speed = 110
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 479
                With FormDifferenceList
                    .Add("加熱洛托姆")
                    .Add("清洗洛托姆")
                    .Add("結冰洛托姆")
                    .Add("旋轉洛托姆")
                    .Add("切割洛托姆")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.3 kg"
                    .Category = "等離子神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]+[火]"
                    .ImagePath = "/FormDifferenceImages/479/Heat.png"
                    .UniqueDescription = "鑽進由特殊馬達驅動的烤箱微波爐裡的洛托姆。十分擅長控制火焰。會烤焦你最愛的衣服。喜歡用加熱來惡作劇的洛托姆。"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 65
                        .Defence = 107
                        .SpecialAttack = 105
                        .SpecialDefence = 107
                        .Speed = 86
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.3 kg"
                    .Category = "等離子神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]+[水]"
                    .ImagePath = "/FormDifferenceImages/479/Wash.png"
                    .UniqueDescription = "鑽進由特殊馬達驅動的洗衣機裡的洛托姆。會放水威嚇對手。會讓房間淹大水。喜歡利用水來惡作劇的洛托姆。"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 65
                        .Defence = 107
                        .SpecialAttack = 105
                        .SpecialDefence = 107
                        .Speed = 86
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.3 kg"
                    .Category = "等離子神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]+[冰]"
                    .ImagePath = "/FormDifferenceImages/479/Frost.png"
                    .UniqueDescription = "鑽進由特殊馬達驅動的電冰箱裡的洛托姆。會吐出冷氣戰鬥。會凍住浴缸裡放好的熱水。喜歡用冷氣來惡作劇的洛托姆。"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 65
                        .Defence = 107
                        .SpecialAttack = 105
                        .SpecialDefence = 107
                        .Speed = 86
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.3 kg"
                    .Category = "等離子神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/479/Fan.png"
                    .UniqueDescription = "鑽進由特殊馬達驅動的電風扇裡的洛托姆。會製造強風來吹飛敵人。會吹走重要的資料。喜歡利用颳風來惡作劇的洛托姆。"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 65
                        .Defence = 107
                        .SpecialAttack = 105
                        .SpecialDefence = 107
                        .Speed = 86
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "0.3 kg"
                    .Category = "等離子神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[電]+[草]"
                    .ImagePath = "/FormDifferenceImages/479/Mow.png"
                    .UniqueDescription = "鑽進由特殊馬達驅動的割草機裡的洛托姆。會把割下的草到處亂撒。會割掉你種好的花。喜歡與草有關的惡作劇的洛托姆。"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 65
                        .Defence = 107
                        .SpecialAttack = 105
                        .SpecialDefence = 107
                        .Speed = 86
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 483
                With FormDifferenceList
                    .Add("起源型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 46
                    .Ability2 = "---"
                    .AbilityHidden = 140
                    .Height = "7.0 m"
                    .Weight = "850.0 kg"
                    .Category = "時間神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[鋼]+[龍]"
                    .ImagePath = "/FormDifferenceImages/483/Origin.png"
                    .UniqueDescription = "光明乃是促使形態變化的導火線。此形態所能發揮的強大力量，令人不得不認為如此酷似創造神的姿態才是其真身。"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 100
                        .Defence = 120
                        .SpecialAttack = 150
                        .SpecialDefence = 120
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 484
                With FormDifferenceList
                    .Add("起源型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 46
                    .Ability2 = "---"
                    .AbilityHidden = 140
                    .Height = "6.3 m"
                    .Weight = "660.0 kg"
                    .Category = "空間神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[水]+[龍]"
                    .ImagePath = "/FormDifferenceImages/484/Origin.png"
                    .UniqueDescription = "翱翔天際的姿態令人聯想起萬物的創造主。吾人推測，模仿創造主的模樣正是將其力化為己有的方法。"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 100
                        .Defence = 100
                        .SpecialAttack = 150
                        .SpecialDefence = 120
                        .Speed = 120
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 487
                With FormDifferenceList
                    .Add("別種型態")
                    .Add("起源型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 46
                    .Ability2 = "---"
                    .AbilityHidden = "140"
                    .Height = "4.5 m"
                    .Weight = "750.0 kg"
                    .Category = "反抗神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[幽靈]+[龍]"
                    .ImagePath = "/FormDifferenceImages/487/Altered.png"
                    With .SpeciesStrengthValues
                        .HP = 150
                        .Attack = 100
                        .Defence = 120
                        .SpecialAttack = 100
                        .SpecialDefence = 120
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "6.9 m"
                    .Weight = "650.0 kg"
                    .Type = "[幽靈]+[龍]"
                    .Category = "反抗神奇寶貝"
                    .BodyColor = "黑"
                    .ImagePath = "/FormDifferenceImages/487/Origin.png"
                    With .SpeciesStrengthValues
                        .HP = 150
                        .Attack = 120
                        .Defence = 100
                        .SpecialAttack = 120
                        .SpecialDefence = 100
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 488
                With FormDifferenceList
                    .Add("第九世代之前的種族值")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.6 m"
                    .Weight = "85.6 kg"
                    .Category = "新月神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[超能力]"
                    .ImagePath = "/Pokemons/488.png"
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 120
                        .Attack = 70
                        .Defence = 120
                        .SpecialAttack = 75
                        .SpecialDefence = 130
                        .Speed = 85
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 492
                With FormDifferenceList
                    .Add("陸上型態")
                    .Add("天空型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 30
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.2 m"
                    .Weight = "2.1 kg"
                    .Category = "感謝神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[草]"
                    .ImagePath = "/FormDifferenceImages/492/Land.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 100
                        .Defence = 100
                        .SpecialAttack = 100
                        .SpecialDefence = 100
                        .Speed = 100
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 32
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.4 m"
                    .Weight = "5.2 kg"
                    .Category = "感謝神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[草]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/492/Sky.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 103
                        .Defence = 75
                        .SpecialAttack = 120
                        .SpecialDefence = 75
                        .Speed = 127
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 493
                With FormDifferenceList
                    .Add("一般")
                    .Add("火")
                    .Add("水")
                    .Add("電")
                    .Add("草")
                    .Add("冰")
                    .Add("格鬥")
                    .Add("毒")
                    .Add("地面")
                    .Add("飛行")
                    .Add("超能力")
                    .Add("蟲")
                    .Add("岩石")
                    .Add("幽靈")
                    .Add("龍")
                    .Add("惡")
                    .Add("鋼")
                    .Add("妖精")
                End With
                For i As Integer = 0 To 17
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = 121
                        .Ability2 = "---"
                        .AbilityHidden = "---"
                        .Height = "3.2 m"
                        .Weight = "320.0 kg"
                        .Category = "創造神奇寶貝"
                        .BodyColor = "白"
                        .Type = "[" & FormDifferenceList(i) & "]"
                        .ImagePath = "/FormDifferenceImages/493/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 120
                            .Attack = 120
                            .Defence = 120
                            .SpecialAttack = 120
                            .SpecialDefence = 120
                            .Speed = 120
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case Else
                GenerateSpecificFormDifferenceInfoBWXYSM(PokemonNationalDexNumberToQuery)
        End Select
    End Sub
    Private Sub GenerateSpecificFormDifferenceInfoBWXYSM(PokemonNationalDexNumberToQuery As Integer)
        Select Case PokemonNationalDexNumberToQuery
            Case 503
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[水]+[惡]"
                    .Ability1 = 67
                    .Ability2 = "---"
                    .AbilityHidden = 292
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "性情與刀路皆是殘酷無情。連綿不斷的攻擊彷如千層浪濤。此乃只在洗翠進化而成的稀有姿態。"
                    .ImagePath = "/FormDifferenceImages/503/Hisui.png"
                    .Height = "1.5 m"
                    .Weight = "58.2 kg"
                    .Category = "威嚴神奇寶貝"
                    .BodyColor = "藍"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 108
                        .Defence = 80
                        .SpecialAttack = 100
                        .SpecialDefence = 65
                        .Speed = 85
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 531
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 91
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[一般]+[妖精]"
                    .Height = "1.5 m"
                    .Weight = "32.0 kg"
                    .Category = "聽覺神奇寶貝"
                    .BodyColor = "粉"
                    .ImagePath = "/FormDifferenceImages/531/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 103
                        .Attack = 60
                        .Defence = 126
                        .SpecialAttack = 80
                        .SpecialDefence = 126
                        .Speed = 50
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 549
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[草]+[格鬥]"
                    .Ability1 = 34
                    .Ability2 = 55
                    .AbilityHidden = 102
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "據考察，雪山深處的棲息環境為其帶來了發達的腳力。會從頭冠般的花中發出鼓舞周遭夥伴的香氣。"
                    .ImagePath = "/FormDifferenceImages/549/Hisui.png"
                    .Height = "1.2 m"
                    .Weight = "19.2 kg"
                    .Category = "旋轉神奇寶貝"
                    .BodyColor = "綠"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 105
                        .Defence = 75
                        .SpecialAttack = 50
                        .SpecialDefence = 75
                        .Speed = 105
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 550
                With FormDifferenceList
                    .Add("紅條紋")
                    .Add("藍條紋")
                    .Add("白條紋")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "120"
                    .Ability2 = "091"
                    .AbilityHidden = "104"
                    .Height = "1.0 m"
                    .Weight = "18.0 kg"
                    .Category = "粗暴神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/550/Red.png"
                    .UniqueDescription = "猙獰凶猛，甚至被稱為河裡的小混混，然而卻是吃吼霸和下石鳥的襲擊對象。性情暴躁，極具攻擊性。同時還擁有極高的生命力，數量會在不知不覺間增多。從前也曾經登上餐桌。紅條紋野蠻鱸魚的肉脂肪含量高，適合年輕人食用。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 92
                        .Defence = 65
                        .SpecialAttack = 80
                        .SpecialDefence = 55
                        .Speed = 98
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "069"
                    .Ability2 = "091"
                    .AbilityHidden = "104"
                    .Height = "1.0 m"
                    .Weight = "18.0 kg"
                    .Category = "粗暴神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/550/Blue.png"
                    .UniqueDescription = "凶暴出了名的神奇寶貝。牠們最常和紅條紋野蠻鱸魚打群架。從前經常被拿來食用。據說藍條紋野蠻鱸魚的肉滋味清淡，容易入口。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 92
                        .Defence = 65
                        .SpecialAttack = 80
                        .SpecialDefence = 55
                        .Speed = 98
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 155
                    .Ability2 = 91
                    .AbilityHidden = 104
                    .Height = "1.0 m"
                    .Weight = "18.0 kg"
                    .Category = "粗暴神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/550/White.png"
                    .UniqueDescription = "此神奇寶貝具有多項野蠻鱸魚的特徵，雖然有性情溫馴等不同點存在，吾人仍將其定義為野蠻鱸魚的地區形態。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 92
                        .Defence = 65
                        .SpecialAttack = 80
                        .SpecialDefence = 55
                        .Speed = 98
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 554
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[冰]"
                    .Ability1 = 55
                    .Ability2 = "---"
                    .AbilityHidden = 39
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "由於居住在積雪深厚的地域，火囊也因受到冷卻而退化了。取而代之的是製造冷氣的器官。身體越冷就越有活力。會把呼出來的氣凍起來做成雪球和夥伴互相扔著玩。"
                    .ImagePath = "/FormDifferenceImages/554/Galar.png"
                    .Height = "0.7 m"
                    .Weight = "40.0 kg"
                    .Category = "不倒翁神奇寶貝"
                    .BodyColor = "白"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 90
                        .Defence = 45
                        .SpecialAttack = 15
                        .SpecialDefence = 45
                        .Speed = 50
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 555
                With FormDifferenceList
                    .Add("普通模式")
                    .Add("達摩模式")
                    .Add("伽勒爾的樣子(普通模式)")
                    .Add("伽勒爾的樣子(達摩模式)")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "125"
                    .Ability2 = "---"
                    .AbilityHidden = "161"
                    .Height = "1.3 m"
                    .Weight = "92.9 kg"
                    .Category = "爆燃神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[火]"
                    .ImagePath = "/FormDifferenceImages/555/Standard.png"
                    With .SpeciesStrengthValues
                        .HP = 105
                        .Attack = 140
                        .Defence = 55
                        .SpecialAttack = 30
                        .SpecialDefence = 55
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "125"
                    .Ability2 = "---"
                    .AbilityHidden = "161"
                    .Height = "1.3 m"
                    .Weight = "92.9 kg"
                    .Category = "爆燃神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[火]+[超能力]"
                    .ImagePath = "/FormDifferenceImages/555/Zen.png"
                    With .SpeciesStrengthValues
                        .HP = 105
                        .Attack = 30
                        .Defence = 105
                        .SpecialAttack = 140
                        .SpecialDefence = 105
                        .Speed = 55
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[冰]"
                    .Ability1 = 255
                    .Ability2 = "---"
                    .AbilityHidden = 161
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會把食物裝到頭頂的雪球裡帶回家。在暴風雪的日子會下山來到人類居住的村落。性情敦厚的大力士。會一口氣凍住頭上的雪球，然後用頭錘撞擊對手。"
                    .ImagePath = "/FormDifferenceImages/555/GalarStandard.png"
                    .Height = "1.7 m"
                    .Weight = "120.0 kg"
                    .Category = "不倒翁神奇寶貝"
                    .BodyColor = "白"
                    With .SpeciesStrengthValues
                        .HP = 105
                        .Attack = 140
                        .Defence = 55
                        .SpecialAttack = 30
                        .SpecialDefence = 55
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .Type = "[火]+[冰]"
                    .Ability1 = 161
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "達摩狒狒情緒激昂的樣子。在怒氣平息之前，即使身體融化也會不斷噴出火焰。原本已經退化的火囊因憤怒而重生。在所到之處胡亂噴火大鬧一番。"
                    .ImagePath = "/FormDifferenceImages/555/GalarZen.png"
                    .Height = "1.7 m"
                    .Weight = "120.0 kg"
                    .Category = "爆燃神奇寶貝"
                    .BodyColor = "白"
                    With .SpeciesStrengthValues
                        .HP = 105
                        .Attack = 160
                        .Defence = 55
                        .SpecialAttack = 30
                        .SpecialDefence = 55
                        .Speed = 135
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 562
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[地面]+[幽靈]"
                    .Ability1 = 254
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "據說牠是古代黏土板被帶有強烈怨念的靈魂吸引後誕生的神奇寶貝。刻有詛咒的黏土板附在了哭哭面具上。據說會吸收怨念的能量。"
                    .ImagePath = "/FormDifferenceImages/562/Galar.png"
                    .Height = "0.5 m"
                    .Weight = "1.5 kg"
                    .Category = "魂神奇寶貝"
                    .BodyColor = "黑"
                    With .SpeciesStrengthValues
                        .HP = 38
                        .Attack = 55
                        .Defence = 85
                        .SpecialAttack = 30
                        .SpecialDefence = 65
                        .Speed = 30
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 569
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[毒]"
                    .Ability1 = 1
                    .Ability2 = 133
                    .AbilityHidden = 106
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "受超極巨化之力的影響，濃度上升的毒氣凝固成了被丟棄的玩具的形狀。如果沾到牠從嘴和手指噴射出來的毒氣，毒素會蔓延到你的骨髓裡。"
                    .ImagePath = "/FormDifferenceImages/569/Gigantamax.png"
                    .Height = "21.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "垃圾場神奇寶貝"
                    .BodyColor = "綠"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 95
                        .Defence = 82
                        .SpecialAttack = 60
                        .SpecialDefence = 82
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 570
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[一般]+[幽靈]"
                    .Ability1 = 149
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "死後靈魂在洗翠地區復甦。怨恨化為力量，從其頭部冉冉飄升。會化成對手的樣貌去洗刷仇恨。"
                    .ImagePath = "/FormDifferenceImages/570/Hisui.png"
                    .Height = "0.7 m"
                    .Weight = "12.5 kg"
                    .Category = "怨狐神奇寶貝"
                    .BodyColor = "灰"
                    With .SpeciesStrengthValues
                        .HP = 35
                        .Attack = 60
                        .Defence = 40
                        .SpecialAttack = 85
                        .SpecialDefence = 40
                        .Speed = 70
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 571
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[一般]+[幽靈]"
                    .Ability1 = 149
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "瘋狂舞動白髮的姿態如同死神。在足以撕裂己身的深刻仇怨驅使下，抱定同歸於盡之心襲殺仇敵。"
                    .ImagePath = "/FormDifferenceImages/571/Hisui.png"
                    .Height = "1.6 m"
                    .Weight = "73.0 kg"
                    .Category = "咒狐神奇寶貝"
                    .BodyColor = "灰"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 100
                        .Defence = 60
                        .SpecialAttack = 125
                        .SpecialDefence = 60
                        .Speed = 110
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 585
                With FormDifferenceList
                    .Add("春天的樣子")
                    .Add("夏天的樣子")
                    .Add("秋天的樣子")
                    .Add("冬天的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "0.6 m"
                    .Weight = "19.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "氣味會隨季節變遷而改變。初春的氣味略帶香甜，能使情緒穩定下來。雖然長相可愛，卻因為喜歡吃草木長出的新芽而遭到農民們的疏遠。"
                    .ImagePath = "/FormDifferenceImages/585/Spring.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 60
                        .Defence = 50
                        .SpecialAttack = 40
                        .SpecialDefence = 50
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "0.6 m"
                    .Weight = "19.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "隨著季節，氣味也會有變化。如果牠身上散發出了獨特的青草味，就代表夏天到了。為了防止田地受牠入侵，有不少農家都會拜託天敵的鬃岩狼人來站崗。"
                    .ImagePath = "/FormDifferenceImages/585/Summer.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 60
                        .Defence = 50
                        .SpecialAttack = 40
                        .SpecialDefence = 50
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "0.6 m"
                    .Weight = "19.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "隨著季節，氣味也會有變化。這個樣子的四季鹿散發的氣味香甜濃郁，會持續蔓延在鼻內。毫不怕生的性格使牠在人類面前也是我行我素。只要給牠食物，就能立刻與牠拉近關係。"
                    .ImagePath = "/FormDifferenceImages/585/Autumn.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 60
                        .Defence = 50
                        .SpecialAttack = 40
                        .SpecialDefence = 50
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "0.6 m"
                    .Weight = "19.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .ImagePath = "/FormDifferenceImages/585/Winter.png"
                    .UniqueDescription = "四季鹿的體味會隨季節而變，但當牠是冬天的樣子時，卻幾乎沒有任何氣味。感情變好後會用頭錘來鬧著玩。頭上有角，但被花蓋住難以察覺，因此挨到牠的頭錘其實還挺痛的。"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 60
                        .Defence = 50
                        .SpecialAttack = 40
                        .SpecialDefence = 50
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 586
                With FormDifferenceList
                    .Add("春天的樣子")
                    .Add("夏天的樣子")
                    .Add("秋天的樣子")
                    .Add("冬天的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的神奇寶貝。愛好者們認為牠角上綻放的淡紅色花朵顏色越淡越是美麗。角上有很多花的萌芽鹿由於會被花搶走養分，而導致成長速度略顯緩慢。"
                    .ImagePath = "/FormDifferenceImages/586/Spring.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 100
                        .Defence = 70
                        .SpecialAttack = 60
                        .SpecialDefence = 70
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的神奇寶貝。愛好者們認為牠角上的枝葉越厚大越是美麗。牠的葉子能用來做成紅茶。其風味根據產地而不同，產自帕底亞的帶有濃濃香氣。"
                    .ImagePath = "/FormDifferenceImages/586/Summer.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 100
                        .Defence = 70
                        .SpecialAttack = 60
                        .SpecialDefence = 70
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的神奇寶貝。愛好者們認為牠角上垂下的枝葉顏色越紅越是氣派。秋天的樣子的萌芽鹿以性情粗暴聞名。雄性間一天到晚都在打架。"
                    .ImagePath = "/FormDifferenceImages/586/Autumn.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 100
                        .Defence = 70
                        .SpecialAttack = 60
                        .SpecialDefence = 70
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的神奇寶貝。但唯獨這個季節的樣子卻偏偏沒什麼人喜歡。據說變成這個樣子的時期性情較為穩重、極易馴化，是與牠成為夥伴的好機會。"
                    .ImagePath = "/FormDifferenceImages/586/Winter.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 100
                        .Defence = 70
                        .SpecialAttack = 60
                        .SpecialDefence = 70
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 615
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 26
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.1 m"
                    .Weight = "148.0 kg"
                    .Category = "結晶神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[冰]"
                    .ImagePath = "/Pokemons/615.png"
                    .UniqueDescription = ""
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 50
                        .Defence = 30
                        .SpecialAttack = 95
                        .SpecialDefence = 135
                        .Speed = 105
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 618
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 250
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.7 m"
                    .Weight = "20.5 kg"
                    .Category = "陷阱神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[冰]"
                    .ImagePath = "/FormDifferenceImages/618/Galar.png"
                    .UniqueDescription = "棲息在富含鐵質的泥巴裡，因此獲得了結實堅固的鋼鐵身軀。會藏在泥巴裡，用顯眼的嘴唇吸引獵物接近自己，接著用鋸齒般的鋼鰭將對手緊緊夾住。"
                    With .SpeciesStrengthValues
                        .HP = 109
                        .Attack = 81
                        .Defence = 99
                        .SpecialAttack = 66
                        .SpecialDefence = 84
                        .Speed = 32
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 628
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = 51
                    .Ability2 = 125
                    .AbilityHidden = 110
                    .Height = "1.7 m"
                    .Weight = "43.4 kg"
                    .Category = "戰吼神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[超能力]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/628/Hisui.png"
                    .UniqueDescription = "勇猛的大鳥。狩獵時會發出氣勢駭人的戰吼，朝湖水發出衝擊波，捕捉浮出水面的獵物。"
                    With .SpeciesStrengthValues
                        .HP = 110
                        .Attack = 83
                        .Defence = 70
                        .SpecialAttack = 112
                        .SpecialDefence = 70
                        .Speed = 65
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 641
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "158"
                    .Ability2 = "---"
                    .AbilityHidden = "128"
                    .Height = "1.5 m"
                    .Weight = "63.0 kg"
                    .Category = "旋風神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[飛行]"
                    .ImagePath = "/FormDifferenceImages/641/Incarnate.png"
                    .UniqueDescription = "引發風暴的神奇寶貝。傳說由於牠攪拌大氣，季節因此得以循環不息。據吾人考察，近似人類的形態才是假象而非真身。"
                    With .SpeciesStrengthValues
                        .HP = 79
                        .Attack = 115
                        .Defence = 70
                        .SpecialAttack = 125
                        .SpecialDefence = 80
                        .Speed = 111
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "144"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.4 m"
                    .Weight = "63.0 kg"
                    .Category = "旋風神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[飛行]"
                    .ImagePath = "/FormDifferenceImages/641/Therian.png"
                    .UniqueDescription = "此乃被稱為形態變化的現象。據考察，此一形同怪鳥的姿態才是其真正樣貌。曾被目擊以此姿態橫越大海。"
                    With .SpeciesStrengthValues
                        .HP = 79
                        .Attack = 100
                        .Defence = 80
                        .SpecialAttack = 110
                        .SpecialDefence = 90
                        .Speed = 121
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 642
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "158"
                    .Ability2 = "---"
                    .AbilityHidden = "128"
                    .Height = "1.5 m"
                    .Weight = "61.0 kg"
                    .Category = "雷擊神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[電]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/642/Incarnate.png"
                    .UniqueDescription = "引發風暴的神奇寶貝。傳說由於牠攪拌大氣，季節因此得以循環不息。據吾人考察，近似人類的形態才是假象而非真身。"
                    With .SpeciesStrengthValues
                        .HP = 79
                        .Attack = 115
                        .Defence = 70
                        .SpecialAttack = 125
                        .SpecialDefence = 80
                        .Speed = 111
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "010"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.0 m"
                    .Weight = "61.0 kg"
                    .Category = "雷擊神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[電]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/642/Therian.png"
                    .UniqueDescription = "在閃電霹靂中現身。會自尾部的連串珠子降下雷擊掃蕩敵手。驚人的威力足以令敵手片甲不留。"
                    With .SpeciesStrengthValues
                        .HP = 79
                        .Attack = 105
                        .Defence = 70
                        .SpecialAttack = 145
                        .SpecialDefence = 80
                        .Speed = 101
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 643
                With FormDifferenceList
                    .Add("超頻驅動狀態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "163"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.2 m"
                    .Weight = "330.0 kg"
                    .Category = "白陽神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[龍]+[火]"
                    .ImagePath = "/FormDifferenceImages/643/Activated.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 120
                        .Defence = 100
                        .SpecialAttack = 150
                        .SpecialDefence = 120
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 644
                With FormDifferenceList
                    .Add("超頻驅動狀態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "164"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.9 m"
                    .Weight = "345.0 kg"
                    .Category = "黑陰神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[龍]+[電]"
                    .ImagePath = "/FormDifferenceImages/644/Activated.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 150
                        .Defence = 120
                        .SpecialAttack = 120
                        .SpecialDefence = 100
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 645
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "159"
                    .Ability2 = "---"
                    .AbilityHidden = "125"
                    .Height = "1.5 m"
                    .Weight = "68.0 kg"
                    .Type = "[地面]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/645/Incarnate.png"
                    .UniqueDescription = "會在旋風與電擊的化身互相鬥爭之時現身並加以平息。在風暴與雷電過後，大地必將迎來豐收。"
                    With .SpeciesStrengthValues
                        .HP = 89
                        .Attack = 125
                        .Defence = 90
                        .SpecialAttack = 115
                        .SpecialDefence = 80
                        .Speed = 101
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "022"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.3 m"
                    .Weight = "68.0 kg"
                    .Type = "[地面]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/645/Therian.png"
                    .UniqueDescription = "以靈獸之姿翱翔天際時，會為大地帶來豐收，因而受到眾人崇敬。只需一刻光陰便能縱斷洗翠大地。"
                    With .SpeciesStrengthValues
                        .HP = 89
                        .Attack = 145
                        .Defence = 90
                        .SpecialAttack = 105
                        .SpecialDefence = 80
                        .Speed = 91
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 646
                With FormDifferenceList
                    .Add("焰白酋雷姆 (一般模式)")
                    .Add("焰白酋雷姆 (超頻驅動狀態)")
                    .Add("暗黑酋雷姆 (一般模式)")
                    .Add("暗黑酋雷姆 (超頻驅動狀態)")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "163"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.6 m"
                    .Weight = "325.0 kg"
                    .Category = "境界神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[龍]+[冰]"
                    .ImagePath = "/FormDifferenceImages/646/White.png"
                    .UniqueDescription = "吸收了與自己擁有相同基因的萊希拉姆，因此能使用火與冰的能量。已經看出神奇寶貝和人類之間的真實世界將會到來，牠試圖去保護這樣的未來。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .Attack = 120
                        .Defence = 90
                        .SpecialAttack = 170
                        .SpecialDefence = 100
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "163"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.6 m"
                    .Weight = "325.0 kg"
                    .Category = "境界神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[龍]+[冰]"
                    .ImagePath = "/FormDifferenceImages/646/WhiteActivated.png"
                    .UniqueDescription = "吸收了與自己擁有相同基因的萊希拉姆，因此能使用火與冰的能量。已經看出神奇寶貝和人類之間的真實世界將會到來，牠試圖去保護這樣的未來。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .Attack = 120
                        .Defence = 90
                        .SpecialAttack = 170
                        .SpecialDefence = 100
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "164"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.3 m"
                    .Weight = "325.0 kg"
                    .Category = "境界神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[龍]+[冰]"
                    .ImagePath = "/FormDifferenceImages/646/Black.png"
                    .UniqueDescription = "吸收了與自己擁有相同基因的捷克羅姆，因此能使用電與冰的能量。傳說牠是為了保護神奇寶貝與人類之間那將在未來實現的理想世界而戰鬥。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .Attack = 170
                        .Defence = 100
                        .SpecialAttack = 120
                        .SpecialDefence = 90
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "164"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.3 m"
                    .Weight = "325.0 kg"
                    .Category = "境界神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[龍]+[冰]"
                    .ImagePath = "/FormDifferenceImages/646/BlackActivated.png"
                    .UniqueDescription = "吸收了與自己擁有相同基因的捷克羅姆，因此能使用電與冰的能量。傳說牠是為了保護神奇寶貝與人類之間那將在未來實現的理想世界而戰鬥。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .Attack = 170
                        .Defence = 100
                        .SpecialAttack = 120
                        .SpecialDefence = 90
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 647
                With FormDifferenceList
                    .Add("普通的樣子")
                    .Add("覺悟的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "154"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.4 m"
                    .Weight = "48.5 kg"
                    .Category = "幼馬神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[水]+[格鬥]"
                    .ImagePath = "/FormDifferenceImages/647/Ordinary.png"
                    .UniqueDescription = "從勾帕路翁、代拉基翁和畢力吉翁那裡學會了戰鬥。馳騁全世界，不斷修行。據說當牠挺過了艱難的戰鬥，額頭上的角就能得到鍛鍊，從而激發出自己真正的力量。"
                    With .SpeciesStrengthValues
                        .HP = 91
                        .Attack = 72
                        .Defence = 90
                        .SpecialAttack = 129
                        .SpecialDefence = 90
                        .Speed = 108
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "154"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.4 m"
                    .Weight = "48.5 kg"
                    .Category = "幼馬神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[水]+[格鬥]"
                    .ImagePath = "/FormDifferenceImages/647/Resolute.png"
                    .UniqueDescription = "透過下定戰鬥的決心讓自己全身充滿力量，並改變了自己的樣子。沉睡在身體深處的力量包裹住了牠額頭上的角，形成了能撕裂一切的劍。"
                    With .SpeciesStrengthValues
                        .HP = 91
                        .Attack = 72
                        .Defence = 90
                        .SpecialAttack = 129
                        .SpecialDefence = 90
                        .Speed = 108
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 648
                With FormDifferenceList
                    .Add("歌聲型態")
                    .Add("舞步型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "032"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.6 m"
                    .Weight = "6.5 kg"
                    .Category = "旋律神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[一般]+[超能力]"
                    .ImagePath = "/FormDifferenceImages/648/Aria.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 77
                        .Defence = 77
                        .SpecialAttack = 128
                        .SpecialDefence = 128
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "032"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.6 m"
                    .Weight = "6.5 kg"
                    .Category = "旋律神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[一般]+[格鬥]"
                    .ImagePath = "/FormDifferenceImages/648/Pirouette.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 128
                        .Defence = 90
                        .SpecialAttack = 77
                        .SpecialDefence = 77
                        .Speed = 128
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 649
                With FormDifferenceList
                    .Add("搭載水流卡帶")
                    .Add("搭載閃電卡帶")
                    .Add("搭載火焰卡帶")
                    .Add("搭載冰凍卡帶")
                End With
                For i As Integer = 0 To 3
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = "088"
                        .Ability2 = "---"
                        .AbilityHidden = "---"
                        .Height = "1.5 m"
                        .Weight = "82.5 kg"
                        .Category = "古生代神奇寶貝"
                        .BodyColor = "紫"
                        .Type = "[蟲]+[鋼]"
                        .ImagePath = "/FormDifferenceImages/649/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 71
                            .Attack = 120
                            .Defence = 95
                            .SpecialAttack = 120
                            .SpecialDefence = 95
                            .Speed = 99
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 658
                With FormDifferenceList
                    .Add("小智版甲賀忍蛙")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "067"
                    .Ability2 = "---"
                    .AbilityHidden = "168"
                    .Height = "1.5 m"
                    .Weight = "40.0 kg"
                    .Category = "忍者神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]+[惡]"
                    .ImagePath = "/FormDifferenceImages/658/Ash.png"
                    With .SpeciesStrengthValues
                        .HP = 72
                        .Attack = 95
                        .Defence = 67
                        .SpecialAttack = 103
                        .SpecialDefence = 71
                        .Speed = 122
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 666
                With FormDifferenceList
                    .Add("冰雪花紋")
                    .Add("雪國花紋")
                    .Add("雪原花紋")
                    .Add("大陸花紋")
                    .Add("庭園花紋")
                    .Add("高雅花紋")
                    .Add("花園花紋")
                    .Add("摩登花紋")
                    .Add("大海花紋")
                    .Add("群島花紋")
                    .Add("荒野花紋")
                    .Add("沙塵花紋")
                    .Add("大河花紋")
                    .Add("驟雨花紋")
                    .Add("熱帶草原花紋")
                    .Add("太陽花紋")
                    .Add("大洋花紋")
                    .Add("熱帶雨林花紋")
                    .Add("幻彩花紋")
                    .Add("球球花紋")
                End With
                For i As Integer = 0 To 19
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = "019"
                        .Ability2 = "014"
                        .AbilityHidden = "132"
                        .Height = "1.2 m"
                        .Weight = "17.0 kg"
                        .Category = "鱗粉神奇寶貝"
                        .BodyColor = "黑"
                        .Type = "[蟲]+[飛行]"
                        .ImagePath = "/FormDifferenceImages/666/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 80
                            .Attack = 52
                            .Defence = 50
                            .SpecialAttack = 90
                            .SpecialDefence = 50
                            .Speed = 89
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 669
                With FormDifferenceList
                    .Add("紅花")
                    .Add("黃花")
                    .Add("橙花")
                    .Add("藍花")
                    .Add("白花")
                End With
                For i As Integer = 0 To 4
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = "166"
                        .Ability2 = "---"
                        .AbilityHidden = "180"
                        .Height = "0.1 m"
                        .Weight = "0.1 kg"
                        .Category = "單朵神奇寶貝"
                        .BodyColor = "白"
                        .Type = "[妖精]"
                        .ImagePath = "/FormDifferenceImages/669/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 44
                            .Attack = 38
                            .Defence = 39
                            .SpecialAttack = 61
                            .SpecialDefence = 75
                            .Speed = 42
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 670
                With FormDifferenceList
                    .Add("紅花")
                    .Add("黃花")
                    .Add("橙花")
                    .Add("藍花")
                    .Add("白花")
                    .Add("永恆之花")
                End With
                For i As Integer = 0 To 4
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = "166"
                        .Ability2 = "---"
                        .AbilityHidden = "180"
                        .Height = "0.2 m"
                        .Weight = "0.9 kg"
                        .Category = "單朵神奇寶貝"
                        .BodyColor = "白"
                        .Type = "[妖精]"
                        .ImagePath = "/FormDifferenceImages/670/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 54
                            .Attack = 45
                            .Defence = 47
                            .SpecialAttack = 75
                            .SpecialDefence = 98
                            .Speed = 52
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "166"
                    .Ability2 = "---"
                    .AbilityHidden = "180"
                    .Height = "0.2 m"
                    .Weight = "0.9 kg"
                    .Category = "單朵神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[妖精]"
                    .ImagePath = "/FormDifferenceImages/670/6.png"
                    With .SpeciesStrengthValues
                        .HP = 74
                        .Attack = 65
                        .Defence = 67
                        .SpecialAttack = 125
                        .SpecialDefence = 128
                        .Speed = 92
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 671
                With FormDifferenceList
                    .Add("紅花")
                    .Add("黃花")
                    .Add("橙花")
                    .Add("藍花")
                    .Add("白花")
                End With
                For i As Integer = 0 To 4
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = "166"
                        .Ability2 = "---"
                        .AbilityHidden = "180"
                        .Height = "1.1 m"
                        .Weight = "10.0 kg"
                        .Category = "花園神奇寶貝"
                        .BodyColor = "白"
                        .Type = "[妖精]"
                        .ImagePath = "/FormDifferenceImages/671/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 78
                            .Attack = 65
                            .Defence = 68
                            .SpecialAttack = 112
                            .SpecialDefence = 154
                            .Speed = 75
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 676
                With FormDifferenceList
                    .Add("心形造型")
                    .Add("星形造型")
                    .Add("菱形造型")
                    .Add("淑女造型")
                    .Add("貴婦造型")
                    .Add("紳士造型")
                    .Add("女王造型")
                    .Add("歌舞妓造型")
                    .Add("國王造型")
                End With
                For i As Integer = 0 To 8
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = "169"
                        .Ability2 = "---"
                        .AbilityHidden = "---"
                        .Height = "1.2 m"
                        .Weight = "28.0 kg"
                        .Category = "貴賓犬神奇寶貝"
                        .BodyColor = "白"
                        .Type = "[一般]"
                        .ImagePath = "/FormDifferenceImages/676/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 75
                            .Attack = 80
                            .Defence = 60
                            .SpecialAttack = 65
                            .SpecialDefence = 90
                            .Speed = 102
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 681
                With FormDifferenceList
                    .Add("刀劍型態")
                    .Add("盾牌型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "176"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "53.0 kg"
                    .Category = "王劍神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[鋼]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/681/Blade.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 150
                        .Defence = 50
                        .SpecialAttack = 150
                        .SpecialDefence = 50
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "176"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.7 m"
                    .Weight = "53.0 kg"
                    .Category = "王劍神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[鋼]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/681/Shield.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 50
                        .Defence = 150
                        .SpecialAttack = 50
                        .SpecialDefence = 150
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 705
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[鋼]+[龍]"
                    .Ability1 = 157
                    .Ability2 = 75
                    .AbilityHidden = 183
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "性情陰沉。據考察，洗翠地區的水中含有的鐵質對皮膚的黏液產生作用，使其變化成了金屬外殼。"
                    .ImagePath = "/FormDifferenceImages/705/Hisui.png"
                    .Height = "0.7 m"
                    .Weight = "68.5 kg"
                    .Category = "蝸牛神奇寶貝"
                    .BodyColor = "紫"
                    With .SpeciesStrengthValues
                        .HP = 58
                        .Attack = 75
                        .Defence = 83
                        .SpecialAttack = 83
                        .SpecialDefence = 113
                        .Speed = 40
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 706
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[鋼]+[龍]"
                    .Ability1 = 157
                    .Ability2 = 75
                    .AbilityHidden = 183
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "能自在操縱可剛可柔的金屬外殼。性情執著且厭惡孤獨，一旦喜愛的對象離開自己便會怒不可遏。"
                    .ImagePath = "/FormDifferenceImages/706/Hisui.png"
                    .Height = "1.7 m"
                    .Weight = "334.1 kg"
                    .Category = "窩殼神奇寶貝"
                    .BodyColor = "紫"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 100
                        .Defence = 100
                        .SpecialAttack = 110
                        .SpecialDefence = 150
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 710
                With FormDifferenceList
                    .Add("小尺寸")
                    .Add("普通尺寸")
                    .Add("大尺寸")
                    .Add("特大尺寸")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "0.3 m"
                    .Weight = "3.5 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/710/SmallSize.png"
                    With .SpeciesStrengthValues
                        .HP = 44
                        .Attack = 66
                        .Defence = 70
                        .SpecialAttack = 44
                        .SpecialDefence = 55
                        .Speed = 56
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "0.4 m"
                    .Weight = "5.0 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/710/AverageSize.png"
                    With .SpeciesStrengthValues
                        .HP = 49
                        .Attack = 66
                        .Defence = 70
                        .SpecialAttack = 44
                        .SpecialDefence = 55
                        .Speed = 51
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "0.5 m"
                    .Weight = "7.5 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/710/LargeSize.png"
                    With .SpeciesStrengthValues
                        .HP = 54
                        .Attack = 66
                        .Defence = 70
                        .SpecialAttack = 44
                        .SpecialDefence = 55
                        .Speed = 46
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "0.8 m"
                    .Weight = "15.0 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/710/SuperSize.png"
                    With .SpeciesStrengthValues
                        .HP = 59
                        .Attack = 66
                        .Defence = 70
                        .SpecialAttack = 44
                        .SpecialDefence = 55
                        .Speed = 41
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 711
                With FormDifferenceList
                    .Add("小尺寸")
                    .Add("普通尺寸")
                    .Add("大尺寸")
                    .Add("特大尺寸")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "0.7 m"
                    .Weight = "9.5 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/711/SmallSize.png"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 85
                        .Defence = 122
                        .SpecialAttack = 58
                        .SpecialDefence = 75
                        .Speed = 99
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "0.9 m"
                    .Weight = "12.5 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/711/AverageSize.png"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 90
                        .Defence = 122
                        .SpecialAttack = 58
                        .SpecialDefence = 75
                        .Speed = 84
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "1.1 m"
                    .Weight = "14.0 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/711/LargeSize.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 95
                        .Defence = 122
                        .SpecialAttack = 58
                        .SpecialDefence = 75
                        .Speed = 69
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "053"
                    .Ability2 = "119"
                    .AbilityHidden = "015"
                    .Height = "1.7 m"
                    .Weight = "39.0 kg"
                    .Category = "南瓜神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/711/SuperSize.png"
                    With .SpeciesStrengthValues
                        .HP = 85
                        .Attack = 100
                        .Defence = 122
                        .SpecialAttack = 58
                        .SpecialDefence = 75
                        .Speed = 54
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 713
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[冰]+[岩石]"
                    .Ability1 = 173
                    .Ability2 = 115
                    .AbilityHidden = 5
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "包覆下顎的冰塊裝甲硬度更勝鋼鐵，能輕易地擊碎岩石。冰岩怪藉此剷開厚重積雪，在險峻的山路上猛衝。"
                    .ImagePath = "/FormDifferenceImages/713/Hisui.png"
                    .Height = "1.4 m"
                    .Weight = "262.4 kg"
                    .Category = "冰山神奇寶貝"
                    .BodyColor = "藍"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 127
                        .Defence = 184
                        .SpecialAttack = 34
                        .SpecialDefence = 36
                        .Speed = 38
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 716
                With FormDifferenceList
                    .Add("活躍模式")
                    .Add("放鬆模式")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "187"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.0 m"
                    .Weight = "215.0 kg"
                    .Category = "生命神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[妖精]"
                    .ImagePath = "/FormDifferenceImages/716/Active.png"
                    With .SpeciesStrengthValues
                        .HP = 126
                        .Attack = 131
                        .Defence = 95
                        .SpecialAttack = 131
                        .SpecialDefence = 98
                        .Speed = 99
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "187"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.0 m"
                    .Weight = "215.0 kg"
                    .Category = "生命神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[妖精]"
                    .ImagePath = "/FormDifferenceImages/716/Neutral.png"
                    With .SpeciesStrengthValues
                        .HP = 126
                        .Attack = 131
                        .Defence = 95
                        .SpecialAttack = 131
                        .SpecialDefence = 98
                        .Speed = 99
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 718
                With FormDifferenceList
                    .Add("細胞型態")
                    .Add("核心型態")
                    .Add("10% 型態")
                    .Add("50% 型態")
                    .Add("完全體型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "基格爾德的最基本形態，沒有自我意識也無法使用招式，平時以隱形狀態分布於各地。"
                    .Ability1 = "188"
                    .Ability2 = "---"
                    .AbilityHidden = "211"
                    .Height = "<缺數據>"
                    .Weight = "<缺數據>"
                    .Category = "秩序神奇寶貝"
                    .BodyColor = "<未知>"
                    .Type = "[龍]+[地面]"
                    .ImagePath = "/FormDifferenceImages/718/Cell.png"
                    With .SpeciesStrengthValues
                        .HP = 0
                        .Attack = 0
                        .Defence = 0
                        .SpecialAttack = 0
                        .SpecialDefence = 0
                        .Speed = 0
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "基格爾德的首腦，能與細胞進行感應從而召集細胞以及共享細胞的視覺。 "
                    .Ability1 = "188"
                    .Ability2 = "---"
                    .AbilityHidden = "211"
                    .Height = "<缺數據>"
                    .Weight = "<缺數據>"
                    .Category = "秩序神奇寶貝"
                    .BodyColor = "<未知>"
                    .Type = "[龍]+[地面]"
                    .ImagePath = "/FormDifferenceImages/718/Core.png"
                    With .SpeciesStrengthValues
                        .HP = 0
                        .Attack = 0
                        .Defence = 0
                        .SpecialAttack = 0
                        .SpecialDefence = 0
                        .Speed = 0
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用鋒利的牙齒了結敵人。無法一直維持這個身體，一段時間後就會變得七零八落。基格爾德組成分子「細胞」聚集了１０％左右的樣子。會以１００公里的時速在地面奔馳。"
                    .Ability1 = "188"
                    .Ability2 = "---"
                    .AbilityHidden = "211"
                    .Height = "1.2 m"
                    .Weight = "33.5 kg"
                    .Category = "秩序神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[龍]+[地面]"
                    .ImagePath = "/FormDifferenceImages/718/10Percent.png"
                    With .SpeciesStrengthValues
                        .HP = 54
                        .Attack = 100
                        .Defence = 71
                        .SpecialAttack = 61
                        .SpecialDefence = 85
                        .Speed = 115
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "細胞聚集了５０％的樣子。會毫不留情地把敵對者全部消滅。被認為監視著生態系統。有傳言說牠蘊藏著更為強大的力量。"
                    .Ability1 = "188"
                    .Ability2 = "---"
                    .AbilityHidden = "211"
                    .Height = "5.0 m"
                    .Weight = "305.0 kg"
                    .Category = "秩序神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[龍]+[地面]"
                    .ImagePath = "/FormDifferenceImages/718/50Percent.png"
                    With .SpeciesStrengthValues
                        .HP = 108
                        .Attack = 100
                        .Defence = 121
                        .SpecialAttack = 81
                        .SpecialDefence = 95
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "１００％的基格爾德的樣子。擁有連哲爾尼亞斯和伊裴爾塔爾都能壓倒的力量。"
                    .Ability1 = "211"
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "4.5 m"
                    .Weight = "610.0 kg"
                    .Category = "秩序神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[龍]+[地面]"
                    .ImagePath = "/FormDifferenceImages/718/Complete.png"
                    With .SpeciesStrengthValues
                        .HP = 216
                        .Attack = 100
                        .Defence = 121
                        .SpecialAttack = 91
                        .SpecialDefence = 95
                        .Speed = 85
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 719
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 156
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Type = "[岩石]+[妖精]"
                    .Height = "1.1 m"
                    .Weight = "27.8 kg"
                    .Category = "寶石神奇寶貝"
                    .BodyColor = "粉"
                    .ImagePath = "/FormDifferenceImages/719/Mega.png"
                    With .SpeciesStrengthValues
                        .HP = 50
                        .Attack = 160
                        .Defence = 110
                        .SpecialAttack = 160
                        .SpecialDefence = 110
                        .Speed = 110
                        .Total = .Attack + .Defence + .HP + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 720
                With FormDifferenceList
                    .Add("懲戒胡帕")
                    .Add("解放胡帕")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 170
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.5 m"
                    .Weight = "9.0 kg"
                    .Category = "頑童神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[超能力]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/720/Confined.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 110
                        .Defence = 60
                        .SpecialAttack = 150
                        .SpecialDefence = 130
                        .Speed = 70
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 170
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "6.5 m"
                    .Weight = "490.0 kg"
                    .Category = "魔神神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[超能力]+[惡]"
                    .ImagePath = "/FormDifferenceImages/720/Unbound.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 160
                        .Defence = 60
                        .SpecialAttack = 170
                        .SpecialDefence = 130
                        .Speed = 80
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 724
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInfoTemp
                    .Type = "[草]+[格鬥]"
                    .Ability1 = 65
                    .Ability2 = "---"
                    .AbilityHidden = 113
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "為抵抗洗翠的嚴寒氣候，羽毛的芯中含有空氣，因而能夠防寒。由此可見環境會對進化產生影響。"
                    .ImagePath = "/FormDifferenceImages/724/Hisui.png"
                    .Height = "1.6 m"
                    .Weight = "37.0 kg"
                    .Category = "箭羽神奇寶貝"
                    .BodyColor = "褐"
                    With .SpeciesStrengthValues
                        .HP = 88
                        .Attack = 112
                        .Defence = 80
                        .SpecialAttack = 95
                        .SpecialDefence = 95
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 741
                With FormDifferenceList
                    .Add("熱辣熱辣風格")
                    .Add("啪滋啪滋風格")
                    .Add("呼拉呼啦風格")
                    .Add("輕盈輕盈風格")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "拍打翅膀生火。一邊踩著華麗的步伐，一邊灑下猛烈的火焰。吸食了朱紅色花蜜的花舞鳥。以熱情的舞步將敵人的身心全部燃燒殆盡。"
                    .Ability1 = 216
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.6 m"
                    .Weight = "3.4 kg"
                    .Category = "舞蹈神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[火]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/741/Baile.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 98
                        .SpecialDefence = 70
                        .Speed = 93
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "吸食了金黃色花蜜的花舞鳥。以輕快歡樂的舞蹈讓敵人的身心都徹底得到釋放。摩擦羽毛生電。像跳舞一樣接近敵人，施展出電擊拳。"
                    .Ability1 = 216
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.6 m"
                    .Weight = "3.4 kg"
                    .Category = "舞蹈神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[電]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/741/Pom-Pom.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 98
                        .SpecialDefence = 70
                        .Speed = 93
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "搖搖擺擺地放鬆自己。之後瞄準敵人將提升的精神力量發射出去。吸食了桃粉色花蜜的花舞鳥。輕柔地擺動腰部，讓敵人的身心都溶化。"
                    .Ability1 = 216
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.6 m"
                    .Weight = "3.4 kg"
                    .Category = "舞蹈神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[超能力]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/741/Pau.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 98
                        .SpecialDefence = 70
                        .Speed = 93
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "吸食了蘭紫色花蜜的花舞鳥。用優雅華麗的舞蹈將敵人的身心都誘惑到異世界。用充滿幻想的舞蹈召喚死者。借助這股怨念的力量對敵人施加詛咒。"
                    .Ability1 = 216
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.6 m"
                    .Weight = "3.4 kg"
                    .Category = "舞蹈神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[幽靈]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/741/Sensu.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 70
                        .Defence = 70
                        .SpecialAttack = 98
                        .SpecialDefence = 70
                        .Speed = 93
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 745
                With FormDifferenceList
                    .Add("白晝的樣子")
                    .Add("黑夜的樣子")
                    .Add("黃昏的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "快速移動迷惑敵人。除了爪子和牙齒之外，鬃毛裡的尖銳岩石也是武器之一。從小開始好好培育的話，會成為絕不背叛訓練家，值得信賴的好夥伴。鬃毛裡的岩石像刀子一樣鋒利。會對獵物窮追不捨，等獵物筋疲力盡時再給予致命一擊。鬃毛裡的岩石比刀子還要鋒利。掉落的碎片會被人當成護身符好好收藏著。"
                    .Ability1 = 51
                    .Ability2 = 146
                    .AbilityHidden = 80
                    .Height = "0.8 m"
                    .Weight = "25.0 kg"
                    .Category = "狼神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[岩石]"
                    .ImagePath = "/FormDifferenceImages/745/Midday.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 115
                        .Defence = 65
                        .SpecialAttack = 55
                        .SpecialDefence = 65
                        .Speed = 112
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "面前的對手越是強大，越是熱血沸騰。為了取勝，會奮不顧身發動襲擊。挑釁敵人來襲擊自己。在敵人砍中自己的同時用頭錘攻擊，再用鬃毛裡的岩石將骨頭壓碎。會毫不猶豫地忽視自己不喜歡的命令。只要能解決對手，就算自己受傷也完全不在意。不集結成群，而是單獨生活。只會聽命於能夠引出自己力量的訓練家。"
                    .Ability1 = 51
                    .Ability2 = 72
                    .AbilityHidden = 99
                    .Height = "1.1 m"
                    .Weight = "25.0 kg"
                    .Category = "狼神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[岩石]"
                    .ImagePath = "/FormDifferenceImages/745/Midnight.png"
                    With .SpeciesStrengthValues
                        .HP = 85
                        .Attack = 115
                        .Defence = 75
                        .SpecialAttack = 55
                        .SpecialDefence = 75
                        .Speed = 82
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "在夕陽照射下完成特殊進化的鬃岩狼人。舉止沉穩，但蘊藏著強烈的鬥志。在黃昏時進化的結果，不知為何變成這種奇特的樣子。在阿羅拉地區是很難得一見的。"
                    .Ability1 = 181
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.8 m"
                    .Weight = "25.0 kg"
                    .Category = "狼神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[岩石]"
                    .ImagePath = "/FormDifferenceImages/745/Dusk.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 117
                        .Defence = 65
                        .SpecialAttack = 55
                        .SpecialDefence = 65
                        .Speed = 110
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 746
                With FormDifferenceList
                    .Add("單獨的樣子")
                    .Add("魚群的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "一旦陷入危機，眼睛就會變得濕潤並發光。和被光亮召集來的夥伴們一起對抗敵人。牠非常弱小，又非常美味，所以總是成為被攻擊的目標，不過若欺負牠，只會吃苦頭哦。"
                    .Ability1 = 208
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.2 m"
                    .Weight = "0.3 kg"
                    .Category = "小魚神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/746/Solo.png"
                    With .SpeciesStrengthValues
                        .HP = 45
                        .Attack = 20
                        .Defence = 20
                        .SpecialAttack = 25
                        .SpecialDefence = 25
                        .Speed = 40
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "弱小的弱丁魚們聚在一起，把力量集合起來。擁有足以被稱為海中魔物的可怕力量。這個樣子連暴鯉龍看了都會逃跑。齊心協力發射出的水槍擁有超越水炮的威力。"
                    .Ability1 = 208
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "8.2 m"
                    .Weight = "78.6 kg"
                    .Category = "小魚神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/746/School.png"
                    With .SpeciesStrengthValues
                        .HP = 45
                        .Attack = 140
                        .Defence = 130
                        .SpecialAttack = 140
                        .SpecialDefence = 135
                        .Speed = 30
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 773
                With FormDifferenceList
                    .Add("屬性: 一般")
                    .Add("屬性: 戰鬥")
                    .Add("屬性: 飛翔")
                    .Add("屬性: 毒")
                    .Add("屬性: 大地")
                    .Add("屬性: 岩石")
                    .Add("屬性: 蟲子")
                    .Add("屬性: 幽靈")
                    .Add("屬性: 鋼鐵")
                    .Add("屬性: 火焰")
                    .Add("屬性: 清水")
                    .Add("屬性: 青草")
                    .Add("屬性: 電子")
                    .Add("屬性: 精神")
                    .Add("屬性: 冰雪")
                    .Add("屬性: 龍")
                    .Add("屬性: 黑暗")
                    .Add("屬性: 妖精")
                End With
                For i As Integer = 0 To 17
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = False
                        .Ability1 = 225
                        .Ability2 = "---"
                        .AbilityHidden = "---"
                        .Height = "2.3 m"
                        .Weight = "100.5 kg"
                        .Category = "人工神奇寶貝"
                        .BodyColor = "灰"
                        .Type = "[" & PokemonTypes(i) & "]"
                        .ImagePath = "/FormDifferenceImages/773/" & (i + 1).ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 95
                            .Attack = 95
                            .Defence = 95
                            .SpecialAttack = 95
                            .SpecialDefence = 95
                            .Speed = 95
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 774
                With FormDifferenceList
                    .Add("流星的樣子")
                    .Add("紅色核心")
                    .Add("橙色核心")
                    .Add("黃色核心")
                    .Add("綠色核心")
                    .Add("淺藍色核心")
                    .Add("藍色核心")
                    .Add("紫色核心")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "原本棲息在臭氧層，身體的外殼變重後，就會向著地面落下。若受到強烈的衝擊，外殼就會剝落。是奈米粒子突變而誕生的神奇寶貝。"
                    .Ability1 = 197
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "40.0 kg"
                    .Category = "流星神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[岩石]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/774/Meteor.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 60
                        .Defence = 100
                        .SpecialAttack = 60
                        .SpecialDefence = 100
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                For i As Integer = 1 To 7
                    With FormDifferenceInfoTemp
                        .IsUniqueDescriptionAvailable = True
                        .UniqueDescription = "會吃下大氣中的塵埃，並依照吃下的塵埃成分來決定核心的色調。核心如果一直處在外露狀態，就會很快消散。聽說趕緊放進精靈球就能讓牠活下來。"
                        .Ability1 = 197
                        .Ability2 = "---"
                        .AbilityHidden = "---"
                        .Height = "0.3 m"
                        .Weight = "0.3 kg"
                        .Category = "流星神奇寶貝"
                        .BodyColor = "<未知>"
                        .Type = "[岩石]+[飛行]"
                        .ImagePath = "/FormDifferenceImages/774/Core" & i.ToString & ".png"
                        With .SpeciesStrengthValues
                            .HP = 60
                            .Attack = 100
                            .Defence = 60
                            .SpecialAttack = 100
                            .SpecialDefence = 60
                            .Speed = 120
                            .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                        End With
                    End With
                    FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                Next
            Case 778
                With FormDifferenceList
                    .Add("化形的樣子")
                    .Add("現形的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "真面目是個謎。某個看過破布裡面的學者因為太可怕而被活活嚇死了。用破破爛爛的布隱藏起可怕的模樣，接近人類和其他神奇寶貝的寂寞傢伙。"
                    .Ability1 = 209
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.2 m"
                    .Weight = "0.7 kg"
                    .Category = "畫皮神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[幽靈]+[妖精]"
                    .ImagePath = "/FormDifferenceImages/778/Disguised.png"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 90
                        .Defence = 80
                        .SpecialAttack = 50
                        .SpecialDefence = 105
                        .Speed = 96
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "特地喬裝打扮，脖子卻折斷了。布裡面的牠應該沒事，但感覺牠很傷心。被攻擊後脖子折斷，或是身上披的布破了的話，本體就會熬夜進行修補。"
                    .Ability1 = 209
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.2 m"
                    .Weight = "0.7 kg"
                    .Category = "畫皮神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[幽靈]+[妖精]"
                    .ImagePath = "/FormDifferenceImages/778/Busted.png"
                    With .SpeciesStrengthValues
                        .HP = 55
                        .Attack = 90
                        .Defence = 80
                        .SpecialAttack = 50
                        .SpecialDefence = 105
                        .Speed = 96
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 791
                With FormDifferenceList
                    .Add("一般狀態")
                    .Add("旭日狀態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 230
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.4 m"
                    .Weight = "230.0 kg"
                    .Category = "日輪神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[超能力]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/791/Common.png"
                    With .SpeciesStrengthValues
                        .HP = 137
                        .Attack = 137
                        .Defence = 107
                        .SpecialAttack = 113
                        .SpecialDefence = 89
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 230
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.4 m"
                    .Weight = "230.0 kg"
                    .Category = "日輪神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[超能力]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/791/RadiantSun.png"
                    With .SpeciesStrengthValues
                        .HP = 137
                        .Attack = 137
                        .Defence = 107
                        .SpecialAttack = 113
                        .SpecialDefence = 89
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 792
                With FormDifferenceList
                    .Add("一般狀態")
                    .Add("滿月狀態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 231
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "4.0 m"
                    .Weight = "120.0 kg"
                    .Category = "月輪神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[超能力]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/792/Common.png"
                    With .SpeciesStrengthValues
                        .HP = 137
                        .Attack = 113
                        .Defence = 89
                        .SpecialAttack = 137
                        .SpecialDefence = 107
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = 231
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "4.0 m"
                    .Weight = "120.0 kg"
                    .Category = "月輪神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[超能力]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/792/FullMoon.png"
                    With .SpeciesStrengthValues
                        .HP = 137
                        .Attack = 113
                        .Defence = 89
                        .SpecialAttack = 137
                        .SpecialDefence = 107
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 800
                With FormDifferenceList
                    .Add("一般型態")
                    .Add("黃昏之鬃 (日蝕)")
                    .Add("拂曉之翼 (月蝕)")
                    .Add("究極奈克洛茲瑪")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "好像一直都沉睡在地底下。被認為是在太古時代從另一個世界來到此地，是種類似ＵＢ的生物。 光似乎是牠的能量來源。毫無節制地不停發射雷射，性格非常凶暴。 為了尋求作為能量的光而發狂的牠看起來有些痛苦。似乎是來自於其他世界。光是牠的能量來源。如果一段時間沒吃到光，雜質就會逐漸累積，使得牠身體發黑且變得無法動彈。"
                    .Ability1 = 232
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.4 m"
                    .Weight = "230.0 kg"
                    .Category = "稜鏡神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[超能力]"
                    .ImagePath = "/FormDifferenceImages/800/Common.png"
                    With .SpeciesStrengthValues
                        .HP = 97
                        .Attack = 107
                        .Defence = 101
                        .SpecialAttack = 127
                        .SpecialDefence = 89
                        .Speed = 79
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "不斷吞食著索爾迦雷歐的光。會撲向敵人，用背上和四肢的爪子將對手斬斷。吸收了壓倒性的光能量之後變化而成的樣子。能從全身發射雷射光。"
                    .Ability1 = 232
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "3.8 m"
                    .Weight = "460.0 kg"
                    .Category = "稜鏡神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[超能力]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/800/DuskMane.png"
                    With .SpeciesStrengthValues
                        .HP = 97
                        .Attack = 157
                        .Defence = 127
                        .SpecialAttack = 113
                        .SpecialDefence = 109
                        .Speed = 77
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "不斷吞噬露奈雅拉的光的樣子。會用巨大的爪子抓住敵人，然後用力將對手撕裂。露奈雅拉已經沒有自我意識。在奈克洛茲瑪的支配之下，不斷釋放出全部的能量。"
                    .Ability1 = 232
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "4.2 m"
                    .Weight = "350.0 kg"
                    .Category = "稜鏡神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[超能力]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/800/DawnWings.png"
                    With .SpeciesStrengthValues
                        .HP = 97
                        .Attack = 113
                        .Defence = 109
                        .SpecialAttack = 157
                        .SpecialDefence = 127
                        .Speed = 77
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "吸收了壓倒性的光能量之後變化而成的樣子。能從全身發射雷射光。全身放出的光會對生物和自然界產生作用，造成各式各樣的影響。"
                    .Ability1 = 233
                    .Ability2 = " - --"""
                    .AbilityHidden = "---"
                    .Height = "2.4 m"
                    .Weight = "230.0 kg"
                    .Category = "稜鏡神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[超能力]+[龍]"
                    .ImagePath = "/FormDifferenceImages/800/Ultra.png"
                    With .SpeciesStrengthValues
                        .HP = 97
                        .Attack = 167
                        .Defence = 97
                        .SpecialAttack = 167
                        .SpecialDefence = 97
                        .Speed = 129
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 801
                With FormDifferenceList
                    .Add("500年前的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .Ability1 = 220
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.0 m"
                    .Weight = "80.5 kg"
                    .Category = "人造神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[鋼]+[妖精]"
                    .ImagePath = "/FormDifferenceImages/801/500YearsAgo.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 95
                        .Defence = 115
                        .SpecialAttack = 130
                        .SpecialDefence = 115
                        .Speed = 95
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 802
                With FormDifferenceList
                    .Add("棲影瑪夏多")
                    .Add("全力瑪夏多")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .Ability1 = 101
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.7 m"
                    .Weight = "22.2 kg"
                    .Type = "[格鬥]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/802/1.png"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 125
                        .Defence = 80
                        .SpecialAttack = 90
                        .SpecialDefence = 90
                        .Speed = 125
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .Ability1 = 101
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.7 m"
                    .Weight = "22.2 kg"
                    .Type = "[格鬥]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/802/2.png"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 125
                        .Defence = 80
                        .SpecialAttack = 90
                        .SpecialDefence = 90
                        .Speed = 125
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 809
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "遙遠地區的神話中所描述的獨眼巨人其實就是美錄梅塔超極巨化之後的樣子。會從腹部的孔洞裡發出電力強大的光束，只需一擊就能讓對手蒸發。"
                    .Ability1 = 42
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "25.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "螺帽神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[鋼]"
                    .ImagePath = "/FormDifferenceImages/809/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 135
                        .Attack = 143
                        .Defence = 143
                        .SpecialAttack = 80
                        .SpecialDefence = 65
                        .Speed = 34
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
        End Select
    End Sub
    Private Sub GenerateSpecificFormDifferenceInfoSSSV(PokemonNationalDexNumberToQuery As Integer)
        Select Case PokemonNationalDexNumberToQuery
            Case 812
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超極巨化的力量讓牠的樹樁急速生長，變成一套猶如森林的鼓。轟擂金剛猩會與森林之鼓合而為一，不斷地擊打出震撼伽勒爾全境的節奏。"
                    .Ability1 = 65
                    .Ability2 = "---"
                    .AbilityHidden = 229
                    .Height = "28.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "鼓手神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[草]"
                    .ImagePath = "/FormDifferenceImages/812/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 125
                        .Defence = 90
                        .SpecialAttack = 60
                        .SpecialDefence = 70
                        .Speed = 85
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 815
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超極巨火焰球會載著閃焰王牌熊熊燃燒的鬥志，百發百中地將對手烤焦。超極巨化的力量會讓牠的火焰球變大，有時甚至超過直徑１００公尺。"
                    .Ability1 = 66
                    .Ability2 = "---"
                    .AbilityHidden = 236
                    .Height = "27.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "前鋒神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[火]"
                    .ImagePath = "/FormDifferenceImages/815/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .Attack = 116
                        .Defence = 75
                        .SpecialAttack = 65
                        .SpecialDefence = 75
                        .Speed = 119
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 818
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "水槍的速度可達音速的７倍。能一邊利用頭上的冠感測風和氣溫，一邊瞄準目標。狙擊的技術出類拔萃。要射穿掉落在１５公里外的樹果也是小事一樁。"
                    .Ability1 = 67
                    .Ability2 = "---"
                    .AbilityHidden = 97
                    .Height = "40.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "特工神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/818/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 85
                        .Defence = 65
                        .SpecialAttack = 125
                        .SpecialDefence = 65
                        .Speed = 120
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 823
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "在超極巨化之力的影響之下，只要拍打翅膀，就能製造出不遜於颶風的強風，吹走一切。能讓背部被稱為「刃鳥」的８根羽毛脫離身體，各自獨立去襲擊敵人。"
                    .Ability1 = 46
                    .Ability2 = 127
                    .AbilityHidden = 240
                    .Height = "14.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "烏鴉神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[飛行]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/823/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 98
                        .Attack = 87
                        .Defence = 105
                        .SpecialAttack = 53
                        .SpecialDefence = 85
                        .Speed = 67
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 826
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "全身以大腦為中心巨大化。擁有無與倫比的智力，和龐大的精神能量。在牠使盡全力時，能夠操縱自己周圍一切生物的心靈。"
                    .Ability1 = 68
                    .Ability2 = 119
                    .AbilityHidden = 140
                    .Height = "14.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "七星神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[蟲]+[超能力]"
                    .ImagePath = "/FormDifferenceImages/826/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 60
                        .Attack = 45
                        .Defence = 110
                        .SpecialAttack = 80
                        .SpecialDefence = 120
                        .Speed = 90
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 834
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超極巨化之力使牠開始用後腳站立。會壓住敵人，用巨大的顎部解決對方。古時候牠咬崩一座山阻止洪水蔓延的故事在伽勒爾地區代代相傳。"
                    .Ability1 = 173
                    .Ability2 = 75
                    .AbilityHidden = 33
                    .Height = "24.0 m以上"
                    .Weight = "<缺數據>"
                    .Type = "[水]+[岩石]"
                    .Category = "緊咬神奇寶貝"
                    .BodyColor = "綠"
                    .ImagePath = "/FormDifferenceImages/834/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 90
                        .Attack = 115
                        .Defence = 90
                        .SpecialAttack = 48
                        .SpecialDefence = 68
                        .Speed = 74
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 839
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "身體是巨大的火爐。超極巨化的力量激發牠燃燒起了２０００度的爐火。據說在大寒流席捲伽勒爾時，是牠變成巨大的火爐拯救了許許多多的生命。"
                    .Ability1 = 243
                    .Ability2 = 49
                    .AbilityHidden = 18
                    .Height = "42.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "煤炭神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[岩石]+[火]"
                    .ImagePath = "/FormDifferenceImages/839/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 110
                        .Attack = 80
                        .Defence = 120
                        .SpecialAttack = 80
                        .SpecialDefence = 90
                        .Speed = 30
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 841
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超極巨化之力使牠的蜜量增加，最後外貌變成了巨大的蘋果。當牠把脖子伸長時，會散發出強烈的蜜汁甜味，讓聞到的神奇寶貝失去知覺。"
                    .Ability1 = 247
                    .Ability2 = 82
                    .AbilityHidden = 55
                    .Height = "24.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "蘋果翅神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[草]+[龍]"
                    .ImagePath = "/FormDifferenceImages/841/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 110
                        .Defence = 80
                        .SpecialAttack = 95
                        .SpecialDefence = 60
                        .Speed = 70
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 842
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會向敵人大量噴射體內的蜜，讓對方在黏糊糊的黏液裡窒息。在超極巨化之力的影響下，蜜汁的黏度進一步提升，能夠吸收受到的傷害。"
                    .Ability1 = 247
                    .Ability2 = 82
                    .AbilityHidden = 47
                    .Height = "24.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "蘋果汁神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[草]+[龍]"
                    .ImagePath = "/FormDifferenceImages/842/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 110
                        .Attack = 85
                        .Defence = 80
                        .SpecialAttack = 100
                        .SpecialDefence = 80
                        .Speed = 30
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 844
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "沙囊也變得巨大無比。圍繞在身上的沙土重量超過１００萬噸。在牠身體四周高速旋轉著的沙子擁有極強的破壞力，甚至連高樓大廈都能粉碎。"
                    .Ability1 = 245
                    .Ability2 = 61
                    .AbilityHidden = 8
                    .Height = "22.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "沙蛇神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[地面]"
                    .ImagePath = "/FormDifferenceImages/844/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 72
                        .Attack = 107
                        .Defence = 125
                        .SpecialAttack = 65
                        .SpecialDefence = 70
                        .Speed = 71
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 849
                With FormDifferenceList
                    .Add("高調的樣子")
                    .Add("低調的樣子")
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "當牠用力抓撓胸部的突起物來製造電力時，四周會響起如同吉他演奏般的聲音。氣勢洶洶的急性子。會大口喝下混濁的水，吸收其中所含的毒素。"
                    .Ability1 = 244
                    .Ability2 = 57
                    .AbilityHidden = 101
                    .Height = "1.6 m"
                    .Weight = "40.0 kg"
                    .Category = "龐克神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[電]+[毒]"
                    .ImagePath = "/FormDifferenceImages/849/Amped.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 98
                        .Defence = 70
                        .SpecialAttack = 114
                        .SpecialDefence = 70
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "牠能夠製造出１５０００伏特的電流，任何對手都不放在眼裡。發電器官長在胸部。當牠製造出電力的時候，會發出貝斯般的聲音。"
                    .Ability1 = 244
                    .Ability2 = 58
                    .AbilityHidden = 101
                    .Height = "1.6 m"
                    .Weight = "40.0 kg"
                    .Category = "龐克神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[電]+[毒]"
                    .ImagePath = "/FormDifferenceImages/849/LowKey.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 98
                        .Defence = 70
                        .SpecialAttack = 114
                        .SpecialDefence = 70
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "過剩的電力是牠的武器。牠所儲備的電量甚至凌駕於雷雨雲之上。因毒素蔓延到了大腦而失去控制。發狂的時候會排出毒汗污染大地。"
                    .Ability1 = 244
                    .Ability2 = 57
                    .AbilityHidden = 101
                    .Height = "24.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "龐克神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[電]+[毒]"
                    .ImagePath = "/FormDifferenceImages/849/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 98
                        .Defence = 70
                        .SpecialAttack = 114
                        .SpecialDefence = 70
                        .Speed = 75
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 851
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超極巨化之力使牠的體溫超過了攝氏１０００度。會用熱浪燒焦對手。超極巨化的焚焰蚣釋放出的熱輻射會擾亂氣流，有時甚至還會引發暴風雨。"
                    .Ability1 = 18
                    .Ability2 = 73
                    .AbilityHidden = 49
                    .Height = "75.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "發熱神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[火]+[蟲]"
                    .ImagePath = "/FormDifferenceImages/851/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 115
                        .Defence = 65
                        .SpecialAttack = 90
                        .SpecialDefence = 90
                        .Speed = 65
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 858
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "能夠讀取５０公里之外的生物的情感。只要感受到敵意，就會立刻開始攻擊。能從觸手釋放出如同閃電一般的光束，也被稱為是狂暴的女神。"
                    .Ability1 = 131
                    .Ability2 = 107
                    .AbilityHidden = 156
                    .Height = "36.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "寂靜神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[超能力]+[妖精]"
                    .ImagePath = "/FormDifferenceImages/858/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 57
                        .Attack = 90
                        .Defence = 95
                        .SpecialAttack = 136
                        .SpecialDefence = 103
                        .Speed = 29
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 861
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會透過讓腿部的體毛變形來使出強力的鑽踢，威力甚至能在伽勒爾的大地上鑽出大洞來。全身的毛因超極巨化而增多。即使是全世界最高的建築也能一躍而過。"
                    .Ability1 = 159
                    .Ability2 = 119
                    .AbilityHidden = 124
                    .Height = "32.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "健美神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[惡]+[妖精]"
                    .ImagePath = "/FormDifferenceImages/861/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .Attack = 120
                        .Defence = 65
                        .SpecialAttack = 95
                        .SpecialDefence = 75
                        .Speed = 60
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 869
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "身體會溢出無限的鮮奶油。受到的衝擊越大，鮮奶油就會變得越堅硬。會胡亂發射１發熱量高達１０萬大卡的鮮奶油飛彈。如果被擊中就會頭昏眼花。"
                    .Ability1 = 175
                    .Ability2 = "---"
                    .AbilityHidden = 165
                    .Height = "30.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "鮮奶油神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[妖精]"
                    .ImagePath = "/FormDifferenceImages/869/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .Attack = 60
                        .Defence = 75
                        .SpecialAttack = 110
                        .SpecialDefence = 121
                        .Speed = 64
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 875
                With FormDifferenceList
                    .Add("結凍型態")
                    .Add("解凍型態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "從非常寒冷的地方漂流而來。隨時都用冰塊冰鎮著自己的臉。無論何時都用冰塊冰鎮著自己怕熱的臉。會把頭頂上的毛垂到海裡釣食物吃。"
                    .Ability1 = 248
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.4 m"
                    .Weight = "89.0 kg"
                    .Category = "企鵝神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[冰]"
                    .ImagePath = "/FormDifferenceImages/875/IceFace.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 80
                        .Defence = 110
                        .SpecialAttack = 65
                        .SpecialDefence = 90
                        .Speed = 50
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "臉上的冰塊碎掉的樣子。牠那一臉惆悵的表情讓許多人為之著迷。頭上的毛連接著大腦的表層，一旦開始動腦思考就會產生冷氣。"
                    .Ability1 = 248
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.4 m"
                    .Weight = "89.0 kg"
                    .Category = "企鵝神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[冰]"
                    .ImagePath = "/FormDifferenceImages/875/NoIceFace.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .Attack = 80
                        .Defence = 70
                        .SpecialAttack = 65
                        .SpecialDefence = 50
                        .Speed = 130
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 877
                With FormDifferenceList
                    .Add("滿腹花紋")
                    .Add("空腹花紋")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "總是餓著肚子。會吃掉裝在像口袋一樣的袋子裡的種子來發電。無論怎麼吃都會馬上肚子餓。十分珍愛自己用電烘烤過的種子，隨時都帶在身上。"
                    .Ability1 = 258
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "3.0 kg"
                    .Category = "雙面神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[電]+[惡]"
                    .ImagePath = "/FormDifferenceImages/877/FullBelly.png"
                    With .SpeciesStrengthValues
                        .HP = 58
                        .Attack = 95
                        .Defence = 58
                        .SpecialAttack = 70
                        .SpecialDefence = 58
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "饑餓荷爾蒙改變了牠的性情。牠會做盡一切的壞事，直到把肚子填飽為止。頰囊中的電能轉化成了惡屬性的能量。因為肚子餓扁了，所以非常凶暴。"
                    .Ability1 = 258
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "3.0 kg"
                    .Category = "雙面神奇寶貝"
                    .BodyColor = "紫"
                    .Type = "[電]+[惡]"
                    .ImagePath = "/FormDifferenceImages/877/Hangry.png"
                    With .SpeciesStrengthValues
                        .HP = 58
                        .Attack = 95
                        .Defence = 58
                        .SpecialAttack = 70
                        .SpecialDefence = 58
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 879
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "鼻子裡儲存著滿滿的能量。一旦將能量噴射出去，甚至能推平山岳，改變地形。超極巨化後，只要用巨大的象鼻攻擊一次，就能拆毀高大的建築。"
                    .Ability1 = 125
                    .Ability2 = "---"
                    .AbilityHidden = 134
                    .Height = "23.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "像銅神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[鋼]"
                    .ImagePath = "/FormDifferenceImages/879/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 122
                        .Attack = 130
                        .Defence = 69
                        .SpecialAttack = 80
                        .SpecialDefence = 69
                        .Speed = 30
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 884
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "變得如同摩天大樓般高大。受到體內能量溢出的影響，身體的一部分會發出亮光。細胞的硬度在鋼屬性神奇寶貝之中也是頂級的。擁有抗震的構造。"
                    .Ability1 = 135
                    .Ability2 = 134
                    .AbilityHidden = 242
                    .Height = "43.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "合金神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[鋼]"
                    .ImagePath = "/FormDifferenceImages/884/Gigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .Attack = 95
                        .Defence = 115
                        .SpecialAttack = 120
                        .SpecialDefence = 50
                        .Speed = 85
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 888
                With FormDifferenceList
                    .Add("百戰勇者 (第九世代起)")
                    .Add("劍之王 (第九世代起)")
                    .Add("百戰勇者 (第九世代之前)")
                    .Add("劍之王 (第九世代之前)")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "被稱為傳說中的英雄。能夠吸收金屬，並將之轉化為武器来戰鬥。這隻神奇寶貝被認為是沉睡已久的藏瑪然特的姐姐，也有人認為牠們之間是勁敵關係。"
                    .Ability1 = 234
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.8 m"
                    .Weight = "110.0 kg"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[妖精]"
                    .ImagePath = "/FormDifferenceImages/888/HeroOfManyBattles.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 120
                        .Defence = 115
                        .SpecialAttack = 80
                        .SpecialDefence = 115
                        .Speed = 138
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用過去使用的兵器武裝自己。即使是超極巨化神奇寶貝，也能以一劍將之拿下。能斬斷世間萬物，因此被稱為妖精王之劍，讓敵友都對牠敬畏不已。"
                    .Ability1 = 234
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.8 m"
                    .Weight = "355.0 kg"
                    .Type = "[妖精]+[鋼]"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "藍"
                    .ImagePath = "/FormDifferenceImages/888/CrownedSword.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 150
                        .Defence = 115
                        .SpecialAttack = 80
                        .SpecialDefence = 115
                        .Speed = 148
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "被稱為傳說中的英雄。能夠吸收金屬，並將之轉化為武器来戰鬥。這隻神奇寶貝被認為是沉睡已久的藏瑪然特的姐姐，也有人認為牠們之間是勁敵關係。"
                    .Ability1 = 234
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.8 m"
                    .Weight = "110.0 kg"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[妖精]"
                    .ImagePath = "/FormDifferenceImages/888/HeroOfManyBattles.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 130
                        .Defence = 115
                        .SpecialAttack = 80
                        .SpecialDefence = 115
                        .Speed = 138
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用過去使用的兵器武裝自己。即使是超極巨化神奇寶貝，也能以一劍將之拿下。能斬斷世間萬物，因此被稱為妖精王之劍，讓敵友都對牠敬畏不已。"
                    .Ability1 = 234
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.8 m"
                    .Weight = "355.0 kg"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[妖精]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/888/CrownedSword.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 170
                        .Defence = 115
                        .SpecialAttack = 80
                        .SpecialDefence = 115
                        .Speed = 148
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 889
                With FormDifferenceList
                    .Add("百戰勇者 (第九世代起)")
                    .Add("盾之王 (第九世代起)")
                    .Add("百戰勇者 (第九世代之前)")
                    .Add("盾之王 (第九世代之前)")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "與眾人之王協力拯救了伽勒爾的神奇寶貝。吸收金屬來進行戰鬥。以石像般的姿態陷入長久沉眠的神奇寶貝。幾乎就要被人們所遺忘。"
                    .Ability1 = 235
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.9 m"
                    .Weight = "210.0 kg"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[格鬥]"
                    .ImagePath = "/FormDifferenceImages/889/HeroOfManyBattles.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 120
                        .Defence = 115
                        .SpecialAttack = 80
                        .SpecialDefence = 115
                        .Speed = 138
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "能夠反彈一切的攻擊，因此被稱為格鬥王之盾，受到人們的畏懼與尊崇。全副武裝的樣子。即使是極巨化神奇寶貝的攻擊也能輕易抵擋。"
                    .Ability1 = 235
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.9 m"
                    .Weight = "785.0 kg"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[格鬥]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/889/CrownedShield.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 120
                        .Defence = 140
                        .SpecialAttack = 80
                        .SpecialDefence = 140
                        .Speed = 128
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "與眾人之王協力拯救了伽勒爾的神奇寶貝。吸收金屬來進行戰鬥。以石像般的姿態陷入長久沉眠的神奇寶貝。幾乎就要被人們所遺忘。"
                    .Ability1 = 235
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.9 m"
                    .Weight = "210.0 kg"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[格鬥]"
                    .ImagePath = "/FormDifferenceImages/889/HeroOfManyBattles.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 130
                        .Defence = 115
                        .SpecialAttack = 80
                        .SpecialDefence = 115
                        .Speed = 138
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "能夠反彈一切的攻擊，因此被稱為格鬥王之盾，受到人們的畏懼與尊崇。全副武裝的樣子。即使是極巨化神奇寶貝的攻擊也能輕易抵擋。"
                    .Ability1 = 235
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.9 m"
                    .Weight = "785.0 kg"
                    .Category = "強者神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[格鬥]+[鋼]"
                    .ImagePath = "/FormDifferenceImages/889/CrownedShield.png"
                    With .SpeciesStrengthValues
                        .HP = 92
                        .Attack = 130
                        .Defence = 145
                        .SpecialAttack = 80
                        .SpecialDefence = 145
                        .Speed = 128
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 890
                With FormDifferenceList
                    .Add("無極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "在洛茲的計畫下，吸收了伽勒爾全域能源後負荷超載的樣子。巨大化的核心釋放出無限的能量，扭曲了周圍的時空。"
                    .Ability1 = 46
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "100.0 m"
                    .Weight = "<缺數據>"
                    .Type = "[毒]+[龍]"
                    .ImagePath = "/FormDifferenceImages/890/Eternamax.png"
                    With .SpeciesStrengthValues
                        .HP = 255
                        .Attack = 115
                        .Defence = 250
                        .SpecialAttack = 125
                        .SpecialDefence = 250
                        .Speed = 130
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 892
                With FormDifferenceList
                    .Add("一擊流")
                    .Add("連擊流")
                    .Add("一擊流 - 超極巨化")
                    .Add("連擊流 - 超極巨化")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = ""
                    .Ability1 = 260
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.9 m"
                    .Weight = "105.0 kg"
                    .Category = "拳法神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[格鬥]+[惡]"
                    .ImagePath = "/FormDifferenceImages/892/SingleStrike.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 130
                        .Defence = 100
                        .SpecialAttack = 63
                        .SpecialDefence = 60
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = ""
                    .Ability1 = 260
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.9 m"
                    .Weight = "105.0 kg"
                    .Category = "拳法神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[格鬥]+[水]"
                    .ImagePath = "/FormDifferenceImages/892/RapidStrike.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 130
                        .Defence = 100
                        .SpecialAttack = 63
                        .SpecialDefence = 60
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = ""
                    .Ability1 = 260
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "29.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "拳法神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[格鬥]+[惡]"
                    .ImagePath = "/FormDifferenceImages/892/SingleStrikeGigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 130
                        .Defence = 100
                        .SpecialAttack = 63
                        .SpecialDefence = 60
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = ""
                    .Ability1 = 260
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "26.0 m以上"
                    .Weight = "<缺數據>"
                    .Category = "拳法神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[格鬥]+[水]"
                    .ImagePath = "/FormDifferenceImages/892/RapidStrikeGigantamax.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 130
                        .Defence = 100
                        .SpecialAttack = 63
                        .SpecialDefence = 60
                        .Speed = 97
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 898
                With FormDifferenceList
                    .Add("騎白馬的樣子")
                    .Add("騎黑馬的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "據說牠對於擋路之徒是毫不留情，但戰鬥結束後會不計前嫌地幫敵方療傷。據說牠曾在一夕之間，將遼闊的森林和棲息其中的生物一併移動到了別處。"
                    .Ability1 = 266
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.4 m"
                    .Weight = "809.1 kg"
                    .Category = "國王神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[超能力]+[冰]"
                    .ImagePath = "/FormDifferenceImages/898/IceRider.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 165
                        .Defence = 150
                        .SpecialAttack = 85
                        .SpecialDefence = 130
                        .Speed = 50
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "據說牠為了讓荒地長出綠意，曾與牽絆深厚的神奇寶貝一同馳騁在伽勒爾的大地。據說牠曾利用能夠看穿過去和未來所有事情的能力，在隕石掉落時拯救了森林的生物。"
                    .Ability1 = 267
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "2.4 m"
                    .Weight = "53.6 kg"
                    .Category = "國王神奇寶貝"
                    .BodyColor = "黑"
                    .Type = "[超能力]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/898/ShadowRider.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 85
                        .Defence = 80
                        .SpecialAttack = 165
                        .SpecialDefence = 100
                        .Speed = 150
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 902
                With FormDifferenceList
                    .Add("雄性的樣子")
                    .Add("雌性的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .Ability1 = 155
                    .Ability2 = 91
                    .AbilityHidden = 104
                    .Height = "3.0 m"
                    .Weight = "110.0 kg"
                    .Category = "大魚神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[水]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/902/Male.png"
                    With .SpeciesStrengthValues
                        .HP = 120
                        .Attack = 112
                        .Defence = 65
                        .SpecialAttack = 80
                        .SpecialDefence = 75
                        .Speed = 78
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = False
                    .UniqueDescription = ""
                    .Ability1 = 155
                    .Ability2 = 91
                    .AbilityHidden = 104
                    .Height = "3.0 m"
                    .Weight = "110.0 kg"
                    .Category = "大魚神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[水]+[幽靈]"
                    .ImagePath = "/FormDifferenceImages/902/Female.png"
                    With .SpeciesStrengthValues
                        .HP = 120
                        .Attack = 92
                        .Defence = 65
                        .SpecialAttack = 100
                        .SpecialDefence = 75
                        .Speed = 78
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 905
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸形態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "當牠越過大海飛來，便代表嚴寒的冬季即將終結。傳說中其慈愛將使新的生命在洗翠大地上萌芽。"
                    .Ability1 = 131
                    .Ability2 = "---"
                    .AbilityHidden = 126
                    .Height = "1.6 m"
                    .Weight = "48.0 kg"
                    .Category = "愛憎神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[妖精]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/905/Incarnate.png"
                    With .SpeciesStrengthValues
                        .HP = 74
                        .Attack = 115
                        .Defence = 70
                        .SpecialAttack = 135
                        .SpecialDefence = 80
                        .Speed = 106
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "自女人的姿態變化而成。若有誰做出糟蹋生命之事，便會從雲海中現身，憤怒地降下無情的懲罰。"
                    .Ability1 = 142
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.6 m"
                    .Weight = "48.0 kg"
                    .Category = "愛憎神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[妖精]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/905/Therian.png"
                    With .SpeciesStrengthValues
                        .HP = 74
                        .Attack = 115
                        .Defence = 110
                        .SpecialAttack = 135
                        .SpecialDefence = 100
                        .Speed = 46
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 916
                With FormDifferenceList
                    .Add("雄性的樣子")
                    .Add("雌性的樣子")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "以自己細緻透亮的肌膚為傲。會從尾巴的前端釋放出凝縮的香氣。會從全身散發出香甜妖豔的氣味，令雌性的神奇寶貝為牠神魂顛倒。"
                    .Ability1 = 268
                    .Ability2 = 82
                    .AbilityHidden = 47
                    .Height = "1.0 m"
                    .Weight = "120.0 kg"
                    .Category = "豬神奇寶貝"
                    .BodyColor = "灰"
                    .Type = "[一般]"
                    .ImagePath = "/FormDifferenceImages/916/Male.png"
                    With .SpeciesStrengthValues
                        .HP = 110
                        .Attack = 100
                        .Defence = 75
                        .SpecialAttack = 59
                        .SpecialDefence = 80
                        .Speed = 65
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會釋放出如花般的香氣。腿部肌肉發達，要跳超過５公尺高也是輕而易舉。喜好乾淨，個性一絲不苟。會讓花香包覆全身來療癒周圍的神奇寶貝們。"
                    .Ability1 = 165
                    .Ability2 = 82
                    .AbilityHidden = 47
                    .Height = "1.0 m"
                    .Weight = "120.0 kg"
                    .Category = "豬神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[一般]"
                    .ImagePath = "/FormDifferenceImages/916/Female.png"
                    With .SpeciesStrengthValues
                        .HP = 115
                        .Attack = 90
                        .Defence = 70
                        .SpecialAttack = 59
                        .SpecialDefence = 90
                        .Speed = 65
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 925
                With FormDifferenceList
                    .Add("三隻家庭")
                    .Add("四隻家庭")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "在自己所建的巨大巢穴裡，會有配合睡眠和用餐等用途所分出的多個房間。不知不覺間多了個小孩。雖然像家族一樣生活，但３隻的關係仍然是個謎。"
                    .Ability1 = 268
                    .Ability2 = 82
                    .AbilityHidden = 47
                    .Height = "0.3 m"
                    .Weight = "2.3 kg"
                    .Category = "家族神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[一般]"
                    .ImagePath = "/FormDifferenceImages/925/Three.png"
                    With .SpeciesStrengthValues
                        .HP = 74
                        .Attack = 75
                        .Defence = 70
                        .SpecialAttack = 65
                        .SpecialDefence = 75
                        .Speed = 111
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "在不知不覺間多了２隻小孩。看起來像是一個家族，但真相如何無人知曉。身型大的２隻會在戰鬥的同時保護著孩子。對抗實力強大的對手時會集體出陣。"
                    .Ability1 = 268
                    .Ability2 = 82
                    .AbilityHidden = 47
                    .Height = "0.3 m"
                    .Weight = "2.8 kg"
                    .Category = "家族神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[一般]"
                    .ImagePath = "/FormDifferenceImages/925/Four.png"
                    With .SpeciesStrengthValues
                        .HP = 74
                        .Attack = 75
                        .Defence = 70
                        .SpecialAttack = 65
                        .SpecialDefence = 75
                        .Speed = 111
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 931
                With FormDifferenceList
                    .Add("綠羽毛")
                    .Add("藍羽毛")
                    .Add("黃羽毛")
                    .Add("白羽毛")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "綠色羽毛的怒鸚哥勢力最為龐大。在覓食時段的早晨和夜晚會非常吵鬧。喜歡棲息在街上。會以羽毛的顏色組隊，展開爭奪地盤之戰。"
                    .Ability1 = 22
                    .Ability2 = 55
                    .AbilityHidden = 62
                    .Height = "0.6 m"
                    .Weight = "2.4 kg"
                    .Category = "鸚鵡神奇寶貝"
                    .BodyColor = "綠"
                    .Type = "[一般]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/931/Green.png"
                    With .SpeciesStrengthValues
                        .HP = 82
                        .Attack = 96
                        .Defence = 51
                        .SpecialAttack = 45
                        .SpecialDefence = 51
                        .Speed = 92
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "藍色羽毛的群體將勢力最大的綠色羽毛的群體視為勁敵。龐大的團隊能達到５０隻以上。覓食時會在街上或森林裡吵吵鬧鬧地四處盤旋。"
                    .Ability1 = 22
                    .Ability2 = 55
                    .AbilityHidden = 62
                    .Height = "0.6 m"
                    .Weight = "2.4 kg"
                    .Category = "鸚鵡神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[一般]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/931/Blue.png"
                    With .SpeciesStrengthValues
                        .HP = 82
                        .Attack = 96
                        .Defence = 51
                        .SpecialAttack = 45
                        .SpecialDefence = 51
                        .Speed = 92
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "黃色的怒鸚哥最為粗暴。有時還會把其他鳥神奇寶貝趕到城鎮外面去。性情和戰鬥方式都很粗暴。會衝進對手的懷裡，以自己的肉身發動攻擊。"
                    .Ability1 = 22
                    .Ability2 = 55
                    .AbilityHidden = 62
                    .Height = "0.6 m"
                    .Weight = "2.4 kg"
                    .Category = "鸚鵡神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[一般]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/931/Yellow.png"
                    With .SpeciesStrengthValues
                        .HP = 82
                        .Attack = 96
                        .Defence = 51
                        .SpecialAttack = 45
                        .SpecialDefence = 51
                        .Speed = 92
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "雖然這種顏色的數量最少，但因為能融入建築物的顏色裡，待在城鎮生活起來會容易許多。不擅長單獨行動。凝聚力很強，靠著與夥伴互助合作而生存了下來。"
                    .Ability1 = 22
                    .Ability2 = 55
                    .AbilityHidden = 62
                    .Height = "0.6 m"
                    .Weight = "2.4 kg"
                    .Category = "鸚鵡神奇寶貝"
                    .BodyColor = "白"
                    .Type = "[一般]+[飛行]"
                    .ImagePath = "/FormDifferenceImages/931/White.png"
                    With .SpeciesStrengthValues
                        .HP = 82
                        .Attack = 96
                        .Defence = 51
                        .SpecialAttack = 45
                        .SpecialDefence = 51
                        .Speed = 92
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 964
                With FormDifferenceList
                    .Add("平凡型態")
                    .Add("全能形態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "只要聽見夥伴求助的聲音，就會改變自己的樣子。那瞬間絕不會讓誰看見。體能與波普海豚不相上下，但一旦夥伴陷入了危機，就會變身來提高自己的力量。"
                    .Ability1 = 278
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.3 m"
                    .Weight = "60.2 kg"
                    .Category = "海豚神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/964/Zero.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 70
                        .Defence = 72
                        .SpecialAttack = 53
                        .SpecialDefence = 62
                        .Speed = 100
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "太古基因覺醒之後的樣子。力氣很大，只用單邊的鰭也可以輕輕鬆鬆舉起遊輪。會以５０節的泳速來救助溺水的人類和神奇寶貝，可以說是大海英雄。"
                    .Ability1 = 278
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "1.8 m"
                    .Weight = "97.4 kg"
                    .Category = "英雄神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[水]"
                    .ImagePath = "/FormDifferenceImages/964/Hero.png"
                    With .SpeciesStrengthValues
                        .HP = 100
                        .Attack = 160
                        .Defence = 97
                        .SpecialAttack = 106
                        .SpecialDefence = 87
                        .Speed = 100
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 978
                With FormDifferenceList
                    .Add("上弓姿勢")
                    .Add("下垂姿勢")
                    .Add("平挺姿勢")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "小型的龍神奇寶貝。會住在吃吼霸嘴裡，保護自己免於外敵襲擊。極為奸詐狡猾的神奇寶貝。會假裝虛弱來吸引獵物接近，接著讓同夥的神奇寶貝發動攻擊。"
                    .Ability1 = 279
                    .Ability2 = "---"
                    .AbilityHidden = 114
                    .Height = "0.3 m"
                    .Weight = "8.0 kg"
                    .Category = "擬態神奇寶貝"
                    .BodyColor = "粉"
                    .Type = "[龍]+[水]"
                    .ImagePath = "/FormDifferenceImages/978/Curly.png"
                    With .SpeciesStrengthValues
                        .HP = 68
                        .Attack = 50
                        .Defence = 60
                        .SpecialAttack = 120
                        .SpecialDefence = 95
                        .Speed = 82
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "體色和模樣會有差異，似乎是為了便於引誘獵物，而配合了其喜好的結果。會裝死來欺騙對手。雖然體型小又沒力氣，卻懂得運用智慧來求生。"
                    .Ability1 = 279
                    .Ability2 = "---"
                    .AbilityHidden = 114
                    .Height = "0.3 m"
                    .Weight = "8.0 kg"
                    .Category = "擬態神奇寶貝"
                    .BodyColor = "紅"
                    .Type = "[龍]+[水]"
                    .ImagePath = "/FormDifferenceImages/978/Droopy.png"
                    With .SpeciesStrengthValues
                        .HP = 68
                        .Attack = 50
                        .Defence = 60
                        .SpecialAttack = 120
                        .SpecialDefence = 95
                        .Speed = 82
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "鳥神奇寶貝是牠主要的獵物。對自己的弱小心知肚明，因此都會和夥伴結伴狩獵。牠的智商即使在龍神奇寶貝中也可以說是數一數二。會鼓起喉囊來擬態。"
                    .Ability1 = 279
                    .Ability2 = "---"
                    .AbilityHidden = 114
                    .Height = "0.3 m"
                    .Weight = "8.0 kg"
                    .Category = "擬態神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[龍]+[水]"
                    .ImagePath = "/FormDifferenceImages/978/Stretchy.png"
                    With .SpeciesStrengthValues
                        .HP = 68
                        .Attack = 50
                        .Defence = 60
                        .SpecialAttack = 120
                        .SpecialDefence = 95
                        .Speed = 82
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 982
                With FormDifferenceList
                    .Add("二節形態")
                    .Add("三節形態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會用堅硬的尾巴挖穿地下深處的岩盤來築巢。巢穴可以長達１０公里。會吸進空氣充滿細長的肺部，然後掀起強烈的爆炸氣浪將敵人趕出自己的巢穴。"
                    .Ability1 = 32
                    .Ability2 = 50
                    .AbilityHidden = 155
                    .Height = "3.6 m"
                    .Weight = "39.2 kg"
                    .Category = "地蛇神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[一般]"
                    .ImagePath = "/FormDifferenceImages/982/Seg2.png"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .Attack = 100
                        .Defence = 80
                        .SpecialAttack = 85
                        .SpecialDefence = 75
                        .Speed = 55
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "性格溫馴，會讓誤闖進巢穴的神奇寶貝乘在自己的背上，將其送到入口。最近的研究發現，牠的身體會有幾節，全是由基因決定的。"
                    .Ability1 = 32
                    .Ability2 = 50
                    .AbilityHidden = 155
                    .Height = "4.5 m"
                    .Weight = "47.4 kg"
                    .Category = "地蛇神奇寶貝"
                    .BodyColor = "黃"
                    .Type = "[一般]"
                    .ImagePath = "/FormDifferenceImages/982/Seg3.png"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .Attack = 100
                        .Defence = 80
                        .SpecialAttack = 85
                        .SpecialDefence = 75
                        .Speed = 55
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
            Case 999
                With FormDifferenceList
                    .Add("寶箱形態")
                    .Add("徒步形態")
                End With
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "約１５００年前出生在寶箱裡。如果有惡棍打算偷走寶藏，就會被牠吸走精氣。棲息在老舊的寶箱中。有時會因沒人注意到自己是神奇寶貝，而被擱置在道具店的角落。"
                    .Ability1 = 155
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.3 m"
                    .Weight = "5.0 kg"
                    .Category = "寶箱神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[幽靈]"
                    .ImagePath = "/FormDifferenceImages/999/Chest.png"
                    With .SpeciesStrengthValues
                        .HP = 45
                        .Attack = 30
                        .Defence = 70
                        .SpecialAttack = 75
                        .SpecialDefence = 70
                        .Speed = 10
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
                FormDifferenceInformationList.Add(FormDifferenceInfoTemp)
                With FormDifferenceInfoTemp
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "從滲入硬幣裡的熱情中誕生。為了回到原來的寶箱，似乎會在四處徘徊。背著古老的硬幣到處徘徊。會吸取試圖撿起硬幣的人的生命力來維生。"
                    .Ability1 = 50
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "0.1 m"
                    .Weight = "0.1 kg"
                    .Category = "尋寶神奇寶貝"
                    .BodyColor = "藍"
                    .Type = "[幽靈]"
                    .ImagePath = "/FormDifferenceImages/999/Roaming.png"
                    With .SpeciesStrengthValues
                        .HP = 45
                        .Attack = 30
                        .Defence = 25
                        .SpecialAttack = 75
                        .SpecialDefence = 45
                        .Speed = 80
                        .Total = .HP + .Attack + .Defence + .SpecialAttack + .SpecialDefence + .Speed
                    End With
                End With
        End Select
    End Sub
    Sub InitPokemonTypes()
        With PokemonTypes
            .Clear()
            .Add("一般")
            .Add("格鬥")
            .Add("飛行")
            .Add("毒")
            .Add("地面")
            .Add("岩石")
            .Add("蟲")
            .Add("幽靈")
            .Add("鋼")
            .Add("火")
            .Add("水")
            .Add("草")
            .Add("電")
            .Add("超能力")
            .Add("冰")
            .Add("龍")
            .Add("惡")
            .Add("妖精")
        End With
    End Sub
End Module
