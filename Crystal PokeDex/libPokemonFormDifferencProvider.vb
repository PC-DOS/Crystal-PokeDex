Module libPokemonFormDifferencProvider
    Public Structure PokemonSpeciesStrengthValues
        Dim HP As Integer
        Dim ATTACK As Integer
        Dim DEFEND As Integer
        Dim SPATTACK As Integer
        Dim SPDEFEND As Integer
        Dim SPEED As Integer
        Dim TOTAL As Integer
    End Structure
    Public Structure PokemonDifferenceInfo
        Dim FormName As String
        Dim Type As String
        Dim ImagePath As String
        Dim Ability1 As String
        Dim Ability2 As String
        Dim AbilityHidden As String
        Dim Height As String
        Dim Weight As String
        Dim Category As String
        Dim BodyColor As String
        Dim IsUniqueDescriptionAvailable As Boolean
        Dim UniqueDescription As String
        Dim SpeciesStrengthValues As PokemonSpeciesStrengthValues
    End Structure
    Public FormDifferenceList As New List(Of String)
    Public FormDifferenceInformation(0 To 30) As PokemonDifferenceInfo
    Public SharedFormDifferenceInformation As New PokemonDifferenceInfo
    Public PokemonTypes As New List(Of String)
    Public Sub GenerateSpecificFormDifferenceInfo(PokemonNationalDexNumberToQuery As Integer)
        FormDifferenceList.Clear()
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
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 123
                        .SPATTACK = 122
                        .SPDEFEND = 120
                        .SPEED = 80
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 82
                        .DEFEND = 83
                        .HP = 80
                        .SPATTACK = 100
                        .SPDEFEND = 100
                        .SPEED = 80
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 6
                With FormDifferenceList
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 130
                        .DEFEND = 111
                        .SPATTACK = 130
                        .SPDEFEND = 85
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 104
                        .DEFEND = 78
                        .SPATTACK = 159
                        .SPDEFEND = 115
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 84
                        .DEFEND = 78
                        .HP = 78
                        .SPATTACK = 109
                        .SPDEFEND = 85
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 9
                With FormDifferenceList
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 103
                        .DEFEND = 120
                        .SPATTACK = 135
                        .SPDEFEND = 115
                        .SPEED = 78
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 83
                        .DEFEND = 100
                        .HP = 79
                        .SPATTACK = 85
                        .SPDEFEND = 105
                        .SPEED = 78
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 15
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 40
                        .SPATTACK = 15
                        .SPDEFEND = 80
                        .SPEED = 145
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 18
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 80
                        .DEFEND = 80
                        .SPATTACK = 135
                        .SPDEFEND = 80
                        .SPEED = 121
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 19
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 56
                        .DEFEND = 35
                        .SPATTACK = 25
                        .SPDEFEND = 35
                        .SPEED = 72
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 20
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
                    .Type = "[惡]+[一般]"
                    .Ability1 = "050"
                    .Ability2 = "062"
                    .AbilityHidden = "055"
                    .Height = "0.7 m"
                    .Weight = "25.5 kg"
                    .Category = "鼠神奇寶貝"
                    .BodyColor = "黑"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "率領小拉達組成團隊。每個團隊各有自己的地盤，會為了爭奪食物而發生爭鬥。對食物的味道和新鮮度非常講究的美食家寶可夢。據說有拉達棲息的餐廳肯定是好餐廳。"
                    .ImagePath = "/FormDifferenceImages/020/Alola.png"
                    With .SpeciesStrengthValues
                        .HP = 75
                        .ATTACK = 71
                        .DEFEND = 70
                        .SPATTACK = 40
                        .SPDEFEND = 80
                        .SPEED = 77
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 25
                With FormDifferenceList
                    .Add("第六世代之前的種族值")
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 55
                        .DEFEND = 30
                        .SPATTACK = 50
                        .SPDEFEND = 40
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 55
                        .DEFEND = 40
                        .SPATTACK = 50
                        .SPDEFEND = 50
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 26
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 50
                        .SPATTACK = 95
                        .SPDEFEND = 85
                        .SPEED = 110
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 27
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 75
                        .DEFEND = 90
                        .SPATTACK = 10
                        .SPDEFEND = 35
                        .SPEED = 40
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 28
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 120
                        .SPATTACK = 25
                        .SPDEFEND = 65
                        .SPEED = 65
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 37
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 41
                        .DEFEND = 40
                        .SPATTACK = 50
                        .SPDEFEND = 65
                        .SPEED = 65
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 38
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 67
                        .DEFEND = 75
                        .SPATTACK = 81
                        .SPDEFEND = 100
                        .SPEED = 109
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 50
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 55
                        .DEFEND = 30
                        .SPATTACK = 35
                        .SPDEFEND = 45
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 51
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 60
                        .SPATTACK = 50
                        .SPDEFEND = 70
                        .SPEED = 110
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 52
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                    .Add("伽勒爾的樣子")
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 35
                        .DEFEND = 35
                        .SPATTACK = 50
                        .SPDEFEND = 40
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 45
                        .DEFEND = 35
                        .SPATTACK = 40
                        .SPDEFEND = 40
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 45
                        .DEFEND = 35
                        .SPATTACK = 40
                        .SPDEFEND = 40
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 53
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
                    .Type = "[惡]"
                    .Ability1 = "169"
                    .Ability2 = "101"
                    .AbilityHidden = "155"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "圓圓的臉孔，比最高級的天鵝絨還光滑的毛髮，在阿羅拉是非常受歡迎的寶可夢。蔑視自己之外的一切。喜歡採用突襲和夜襲等卑劣無恥的戰法。"
                    .ImagePath = "/FormDifferenceImages/053/Alola.png"
                    .Height = "1.1 m"
                    .Weight = "33.0 kg"
                    .Category = "暹羅貓神奇寶貝"
                    .BodyColor = "藍"
                    With .SpeciesStrengthValues
                        .HP = 65
                        .ATTACK = 60
                        .DEFEND = 60
                        .SPATTACK = 75
                        .SPDEFEND = 65
                        .SPEED = 115
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 58
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 75
                        .DEFEND = 45
                        .SPATTACK = 65
                        .SPDEFEND = 50
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 59
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
                    .Type = "[火]+[岩石]"
                    .Ability1 = 22
                    .Ability2 = 18
                    .AbilityHidden = 69
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = ""
                    .ImagePath = "/FormDifferenceImages/059/Hisui.png"
                    .Height = "2.0 m"
                    .Weight = "168.0 kg"
                    .Category = "傳說神奇寶貝"
                    .BodyColor = "褐"
                    With .SpeciesStrengthValues
                        .HP = 95
                        .ATTACK = 115
                        .DEFEND = 80
                        .SPATTACK = 95
                        .SPDEFEND = 80
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 65
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 50
                        .DEFEND = 65
                        .SPATTACK = 175
                        .SPDEFEND = 95
                        .SPEED = 150
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 68
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 130
                        .DEFEND = 80
                        .SPATTACK = 65
                        .SPDEFEND = 85
                        .SPEED = 55
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 74
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 80
                        .DEFEND = 100
                        .SPATTACK = 30
                        .SPDEFEND = 30
                        .SPEED = 20
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 75
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 115
                        .SPATTACK = 45
                        .SPDEFEND = 45
                        .SPEED = 35
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 76
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 120
                        .DEFEND = 130
                        .SPATTACK = 55
                        .SPDEFEND = 65
                        .SPEED = 45
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 77
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 55
                        .SPATTACK = 65
                        .SPDEFEND = 65
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 78
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 70
                        .SPATTACK = 80
                        .SPDEFEND = 80
                        .SPEED = 105
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 79
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 65
                        .DEFEND = 65
                        .SPATTACK = 40
                        .SPDEFEND = 40
                        .SPEED = 15
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 80
                With FormDifferenceList
                    .Add("超進化")
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 75
                        .DEFEND = 180
                        .SPATTACK = 130
                        .SPDEFEND = 80
                        .SPEED = 30
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 100
                        .DEFEND = 95
                        .SPATTACK = 100
                        .SPDEFEND = 70
                        .SPEED = 30
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 83
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 65
                        .DEFEND = 55
                        .SPATTACK = 58
                        .SPDEFEND = 62
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 95
                        .DEFEND = 55
                        .SPATTACK = 58
                        .SPDEFEND = 62
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 88
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 80
                        .DEFEND = 50
                        .SPATTACK = 40
                        .SPDEFEND = 50
                        .SPEED = 25
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 89
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 105
                        .DEFEND = 75
                        .SPATTACK = 65
                        .SPDEFEND = 100
                        .SPEED = 50
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 94
                With FormDifferenceList
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 65
                        .DEFEND = 80
                        .SPATTACK = 170
                        .SPDEFEND = 95
                        .SPEED = 130
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 65
                        .DEFEND = 60
                        .SPATTACK = 130
                        .SPDEFEND = 75
                        .SPEED = 110
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 99
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 130
                        .DEFEND = 115
                        .SPATTACK = 50
                        .SPDEFEND = 50
                        .SPEED = 75
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 100
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 30
                        .DEFEND = 50
                        .SPATTACK = 55
                        .SPDEFEND = 55
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 101
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 50
                        .DEFEND = 70
                        .SPATTACK = 80
                        .SPDEFEND = 80
                        .SPEED = 140
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 50
                        .DEFEND = 70
                        .SPATTACK = 80
                        .SPDEFEND = 80
                        .SPEED = 150
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 103
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 85
                        .SPATTACK = 125
                        .SPDEFEND = 65
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 105
                        .DEFEND = 85
                        .SPATTACK = 125
                        .SPDEFEND = 75
                        .SPEED = 45
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 105
                With FormDifferenceList
                    .Add("阿羅拉的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 80
                        .DEFEND = 110
                        .SPATTACK = 50
                        .SPDEFEND = 80
                        .SPEED = 45
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 110
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 90
                        .DEFEND = 120
                        .SPATTACK = 85
                        .SPDEFEND = 70
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 115
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 125
                        .DEFEND = 100
                        .SPATTACK = 60
                        .SPDEFEND = 100
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 122
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 65
                        .DEFEND = 65
                        .SPATTACK = 90
                        .SPDEFEND = 90
                        .SPEED = 100
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 127
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 155
                        .DEFEND = 120
                        .SPATTACK = 65
                        .SPDEFEND = 90
                        .SPEED = 105
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 128
                With FormDifferenceList
                    .Add("帕底亞的樣子 - 鬥戰種")
                    .Add("帕底亞的樣子 - 火熾種")
                    .Add("帕底亞的樣子 - 水瀾種")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 110
                        .DEFEND = 105
                        .SPATTACK = 30
                        .SPDEFEND = 70
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 110
                        .DEFEND = 105
                        .SPATTACK = 30
                        .SPDEFEND = 70
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 110
                        .DEFEND = 105
                        .SPATTACK = 30
                        .SPDEFEND = 70
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 130
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 155
                        .DEFEND = 109
                        .SPATTACK = 70
                        .SPDEFEND = 130
                        .SPEED = 81
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 131
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 80
                        .SPATTACK = 85
                        .SPDEFEND = 95
                        .SPEED = 60
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 133
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 55
                        .DEFEND = 50
                        .SPATTACK = 45
                        .SPDEFEND = 65
                        .SPEED = 66
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 142
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 135
                        .DEFEND = 85
                        .SPATTACK = 70
                        .SPDEFEND = 95
                        .SPEED = 150
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 143
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 110
                        .DEFEND = 65
                        .SPATTACK = 65
                        .SPDEFEND = 110
                        .SPEED = 30
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 144
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 85
                        .SPATTACK = 125
                        .SPDEFEND = 100
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 145
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 125
                        .DEFEND = 90
                        .SPATTACK = 85
                        .SPDEFEND = 90
                        .SPEED = 100
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 146
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 90
                        .SPATTACK = 100
                        .SPDEFEND = 125
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 150
                With FormDifferenceList
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 190
                        .DEFEND = 100
                        .SPATTACK = 154
                        .SPDEFEND = 100
                        .SPEED = 130
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 150
                        .DEFEND = 70
                        .SPATTACK = 194
                        .SPDEFEND = 120
                        .SPEED = 140
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 157
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 84
                        .DEFEND = 78
                        .SPATTACK = 119
                        .SPDEFEND = 85
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 181
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 105
                        .SPATTACK = 165
                        .SPDEFEND = 110
                        .SPEED = 45
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 194
                With FormDifferenceList
                    .Add("帕底亞的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 45
                        .DEFEND = 45
                        .SPATTACK = 25
                        .SPDEFEND = 25
                        .SPEED = 15
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 199
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 65
                        .DEFEND = 80
                        .SPATTACK = 110
                        .SPDEFEND = 110
                        .SPEED = 30
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
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
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 72
                            .DEFEND = 48
                            .SPATTACK = 72
                            .SPDEFEND = 48
                            .SPEED = 48
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 208
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 125
                        .DEFEND = 230
                        .SPATTACK = 55
                        .SPDEFEND = 95
                        .SPEED = 30
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 211
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 75
                        .SPATTACK = 55
                        .SPDEFEND = 55
                        .SPEED = 85
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 95
                        .DEFEND = 85
                        .SPATTACK = 55
                        .SPDEFEND = 55
                        .SPEED = 85
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 212
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 140
                        .SPATTACK = 65
                        .SPDEFEND = 100
                        .SPEED = 75
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 214
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 185
                        .DEFEND = 115
                        .SPATTACK = 40
                        .SPDEFEND = 110
                        .SPEED = 45
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 215
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 55
                        .SPATTACK = 35
                        .SPDEFEND = 75
                        .SPEED = 115
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 222
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 55
                        .DEFEND = 85
                        .SPATTACK = 65
                        .SPDEFEND = 85
                        .SPEED = 35
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 55
                        .DEFEND = 100
                        .SPATTACK = 65
                        .SPDEFEND = 100
                        .SPEED = 30
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 226
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 40
                        .DEFEND = 70
                        .SPATTACK = 80
                        .SPDEFEND = 140
                        .SPEED = 70
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 229
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 90
                        .DEFEND = 90
                        .SPATTACK = 140
                        .SPDEFEND = 90
                        .SPEED = 115
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 248
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 164
                        .DEFEND = 150
                        .SPATTACK = 95
                        .SPDEFEND = 120
                        .SPEED = 71
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 254
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 110
                        .DEFEND = 75
                        .SPATTACK = 145
                        .SPDEFEND = 85
                        .SPEED = 145
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 257
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 160
                        .DEFEND = 80
                        .SPATTACK = 130
                        .SPDEFEND = 80
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 260
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 110
                        .SPATTACK = 95
                        .SPDEFEND = 110
                        .SPEED = 70
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 263
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                    .UniqueDescription = "一直在奔跑，永遠靜不下來。如果發現了其他的寶可夢，就會故意撞上去挑起事端。這似乎是蛇紋熊最古老的樣子。會之字形亂走，把周圍弄得一團糟。"
                    With .SpeciesStrengthValues
                        .HP = 38
                        .ATTACK = 30
                        .DEFEND = 41
                        .SPATTACK = 30
                        .SPDEFEND = 41
                        .SPEED = 60
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 264
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 70
                        .DEFEND = 61
                        .SPATTACK = 50
                        .SPDEFEND = 61
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 282
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 65
                        .SPATTACK = 165
                        .SPDEFEND = 135
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 302
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 125
                        .SPATTACK = 85
                        .SPDEFEND = 115
                        .SPEED = 20
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 303
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 105
                        .DEFEND = 125
                        .SPATTACK = 55
                        .SPDEFEND = 95
                        .SPEED = 50
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 306
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 140
                        .DEFEND = 230
                        .SPATTACK = 60
                        .SPDEFEND = 80
                        .SPEED = 50
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 308
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 85
                        .SPATTACK = 80
                        .SPDEFEND = 85
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 310
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 75
                        .DEFEND = 80
                        .SPATTACK = 135
                        .SPDEFEND = 80
                        .SPEED = 135
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 319
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 140
                        .DEFEND = 70
                        .SPATTACK = 110
                        .SPDEFEND = 65
                        .SPEED = 105
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 323
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 120
                        .DEFEND = 100
                        .SPATTACK = 145
                        .SPDEFEND = 105
                        .SPEED = 20
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 334
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 110
                        .DEFEND = 110
                        .SPATTACK = 110
                        .SPDEFEND = 105
                        .SPEED = 80
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 351
                With FormDifferenceList
                    .Add("太陽的樣子")
                    .Add("雨水的樣子")
                    .Add("雪雲的樣子")
                    .Add("其他天氣的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 70
                        .SPDEFEND = 70
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 70
                        .SPDEFEND = 70
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 70
                        .SPDEFEND = 70
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 70
                        .SPDEFEND = 70
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 354
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 165
                        .DEFEND = 75
                        .SPATTACK = 93
                        .SPDEFEND = 83
                        .SPEED = 75
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 359
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 60
                        .SPATTACK = 115
                        .SPDEFEND = 60
                        .SPEED = 115
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 362
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 120
                        .DEFEND = 80
                        .SPATTACK = 120
                        .SPDEFEND = 80
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 373
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 145
                        .DEFEND = 130
                        .SPATTACK = 120
                        .SPDEFEND = 90
                        .SPEED = 120
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 376
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 145
                        .DEFEND = 150
                        .SPATTACK = 105
                        .SPDEFEND = 110
                        .SPEED = 110
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 380
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 120
                        .SPATTACK = 140
                        .SPDEFEND = 150
                        .SPEED = 110
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 381
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 130
                        .DEFEND = 100
                        .SPATTACK = 160
                        .SPDEFEND = 120
                        .SPEED = 110
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 382
                With FormDifferenceList
                    .Add("原始回歸型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 90
                        .SPATTACK = 180
                        .SPDEFEND = 160
                        .SPEED = 90
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "利用自然能量進行原始回歸，回到了原本的樣子。擁有呼風喚雨擴張海洋的力量。"
                End With
            Case 383
                With FormDifferenceList
                    .Add("原始回歸型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 180
                        .DEFEND = 160
                        .SPATTACK = 150
                        .SPDEFEND = 90
                        .SPEED = 90
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "利用自然能量進行原始回歸，回到了原本的樣子。擁有產生熔岩擴張大地的力量。"
                End With
            Case 384
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 180
                        .DEFEND = 100
                        .SPATTACK = 180
                        .SPDEFEND = 100
                        .SPEED = 115
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 386
                With FormDifferenceList
                    .Add("普通型態")
                    .Add("攻擊型態")
                    .Add("防禦型態")
                    .Add("速度型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 50
                        .SPATTACK = 150
                        .SPDEFEND = 50
                        .SPEED = 150
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 180
                        .DEFEND = 20
                        .SPATTACK = 180
                        .SPDEFEND = 20
                        .SPEED = 150
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 70
                        .DEFEND = 160
                        .SPATTACK = 70
                        .SPDEFEND = 160
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 95
                        .DEFEND = 90
                        .SPATTACK = 95
                        .SPDEFEND = 90
                        .SPEED = 180
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 412
                With FormDifferenceList
                    .Add("草木蓑衣")
                    .Add("砂土蓑衣")
                    .Add("垃圾蓑衣")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 29
                        .DEFEND = 45
                        .SPATTACK = 29
                        .SPDEFEND = 45
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 29
                        .DEFEND = 45
                        .SPATTACK = 29
                        .SPDEFEND = 45
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 29
                        .DEFEND = 45
                        .SPATTACK = 29
                        .SPDEFEND = 45
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 413
                With FormDifferenceList
                    .Add("草木蓑衣")
                    .Add("砂土蓑衣")
                    .Add("垃圾蓑衣")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 59
                        .DEFEND = 85
                        .SPATTACK = 79
                        .SPDEFEND = 105
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 79
                        .DEFEND = 105
                        .SPATTACK = 59
                        .SPDEFEND = 85
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 69
                        .DEFEND = 95
                        .SPATTACK = 69
                        .SPDEFEND = 95
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 421
                With FormDifferenceList
                    .Add("陰天形態")
                    .Add("晴天形態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 60
                        .DEFEND = 70
                        .SPATTACK = 87
                        .SPDEFEND = 78
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 60
                        .DEFEND = 70
                        .SPATTACK = 87
                        .SPDEFEND = 78
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 422
                With FormDifferenceList
                    .Add("西海")
                    .Add("東海")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 48
                        .DEFEND = 48
                        .SPATTACK = 57
                        .SPDEFEND = 62
                        .SPEED = 34
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 48
                        .DEFEND = 48
                        .SPATTACK = 57
                        .SPDEFEND = 62
                        .SPEED = 34
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 423
                With FormDifferenceList
                    .Add("西海")
                    .Add("東海")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 83
                        .DEFEND = 68
                        .SPATTACK = 92
                        .SPDEFEND = 82
                        .SPEED = 39
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 83
                        .DEFEND = 68
                        .SPATTACK = 92
                        .SPDEFEND = 82
                        .SPEED = 39
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 428
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 136
                        .DEFEND = 94
                        .SPATTACK = 54
                        .SPDEFEND = 96
                        .SPEED = 135
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 445
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 170
                        .DEFEND = 115
                        .SPATTACK = 120
                        .SPDEFEND = 95
                        .SPEED = 92
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 448
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 145
                        .DEFEND = 88
                        .SPATTACK = 140
                        .SPDEFEND = 70
                        .SPEED = 112
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 460
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 132
                        .DEFEND = 105
                        .SPATTACK = 132
                        .SPDEFEND = 105
                        .SPEED = 30
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 475
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 165
                        .DEFEND = 95
                        .SPATTACK = 65
                        .SPDEFEND = 115
                        .SPEED = 110
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 479
                With FormDifferenceList
                    .Add("加熱洛托姆")
                    .Add("清洗洛托姆")
                    .Add("結冰洛托姆")
                    .Add("旋轉洛托姆")
                    .Add("切割洛托姆")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(4)
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
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 483
                With FormDifferenceList
                    .Add("起源型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 120
                        .SPATTACK = 150
                        .SPDEFEND = 120
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 484
                With FormDifferenceList
                    .Add("起源型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 100
                        .SPATTACK = 150
                        .SPDEFEND = 120
                        .SPEED = 120
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 487
                With FormDifferenceList
                    .Add("別種型態")
                    .Add("起源型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 120
                        .SPATTACK = 100
                        .SPDEFEND = 120
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 120
                        .DEFEND = 100
                        .SPATTACK = 120
                        .SPDEFEND = 100
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 488
                With FormDifferenceList
                    .Add("第九世代之前的種族值")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 70
                        .DEFEND = 120
                        .SPATTACK = 75
                        .SPDEFEND = 130
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 492
                With FormDifferenceList
                    .Add("陸上型態")
                    .Add("天空型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 100
                        .SPATTACK = 100
                        .SPDEFEND = 100
                        .SPEED = 100
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 103
                        .DEFEND = 75
                        .SPATTACK = 120
                        .SPDEFEND = 75
                        .SPEED = 127
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
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
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 120
                            .DEFEND = 120
                            .SPATTACK = 120
                            .SPDEFEND = 120
                            .SPEED = 120
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
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
                With FormDifferenceInformation(0)
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
                        .ATTACK = 108
                        .DEFEND = 80
                        .SPATTACK = 100
                        .SPDEFEND = 65
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 531
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 60
                        .DEFEND = 126
                        .SPATTACK = 80
                        .SPDEFEND = 126
                        .SPEED = 50
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 549
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 105
                        .DEFEND = 75
                        .SPATTACK = 50
                        .SPDEFEND = 75
                        .SPEED = 105
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 550
                With FormDifferenceList
                    .Add("紅條紋")
                    .Add("藍條紋")
                    .Add("白條紋")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 92
                        .DEFEND = 65
                        .SPATTACK = 80
                        .SPDEFEND = 55
                        .SPEED = 98
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                    .UniqueDescription = "凶暴出了名的寶可夢。牠們最常和紅條紋野蠻鱸魚打群架。從前經常被拿來食用。據說藍條紋野蠻鱸魚的肉滋味清淡，容易入口。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .ATTACK = 92
                        .DEFEND = 65
                        .SPATTACK = 80
                        .SPDEFEND = 55
                        .SPEED = 98
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                    .UniqueDescription = "此寶可夢具有多項野蠻鱸魚的特徵，雖然有性情溫馴等不同點存在，吾人仍將其定義為野蠻鱸魚的地區形態。"
                    With .SpeciesStrengthValues
                        .HP = 70
                        .ATTACK = 92
                        .DEFEND = 65
                        .SPATTACK = 80
                        .SPDEFEND = 55
                        .SPEED = 98
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 554
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 90
                        .DEFEND = 45
                        .SPATTACK = 15
                        .SPDEFEND = 45
                        .SPEED = 50
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 555
                With FormDifferenceList
                    .Add("普通模式")
                    .Add("達摩模式")
                    .Add("伽勒爾的樣子(普通模式)")
                    .Add("伽勒爾的樣子(達摩模式)")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 140
                        .DEFEND = 55
                        .SPATTACK = 30
                        .SPDEFEND = 55
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 30
                        .DEFEND = 105
                        .SPATTACK = 140
                        .SPDEFEND = 105
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 140
                        .DEFEND = 55
                        .SPATTACK = 30
                        .SPDEFEND = 55
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 160
                        .DEFEND = 55
                        .SPATTACK = 30
                        .SPDEFEND = 55
                        .SPEED = 135
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 562
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
                    .Type = "[地面]+[幽靈]"
                    .Ability1 = 254
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "據說牠是古代黏土板被帶有強烈怨念的靈魂吸引後誕生的寶可夢。刻有詛咒的黏土板附在了哭哭面具上。據說會吸收怨念的能量。"
                    .ImagePath = "/FormDifferenceImages/562/Galar.png"
                    .Height = "0.5 m"
                    .Weight = "1.5 kg"
                    .Category = "魂神奇寶貝"
                    .BodyColor = "黑"
                    With .SpeciesStrengthValues
                        .HP = 38
                        .ATTACK = 55
                        .DEFEND = 85
                        .SPATTACK = 30
                        .SPDEFEND = 65
                        .SPEED = 30
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 569
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 82
                        .SPATTACK = 60
                        .SPDEFEND = 82
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 570
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 60
                        .DEFEND = 40
                        .SPATTACK = 85
                        .SPDEFEND = 40
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 571
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 60
                        .SPATTACK = 125
                        .SPDEFEND = 60
                        .SPEED = 110
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 585
                With FormDifferenceList
                    .Add("春天的樣子")
                    .Add("夏天的樣子")
                    .Add("秋天的樣子")
                    .Add("冬天的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 60
                        .DEFEND = 50
                        .SPATTACK = 40
                        .SPDEFEND = 50
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 60
                        .DEFEND = 50
                        .SPATTACK = 40
                        .SPDEFEND = 50
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 60
                        .DEFEND = 50
                        .SPATTACK = 40
                        .SPDEFEND = 50
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 60
                        .DEFEND = 50
                        .SPATTACK = 40
                        .SPDEFEND = 50
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 586
                With FormDifferenceList
                    .Add("春天的樣子")
                    .Add("夏天的樣子")
                    .Add("秋天的樣子")
                    .Add("冬天的樣子")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的寶可夢。愛好者們認為牠角上綻放的淡紅色花朵顏色越淡越是美麗。角上有很多花的萌芽鹿由於會被花搶走養分，而導致成長速度略顯緩慢。"
                    .ImagePath = "/FormDifferenceImages/586/Spring.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .ATTACK = 100
                        .DEFEND = 70
                        .SPATTACK = 60
                        .SPDEFEND = 70
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的寶可夢。愛好者們認為牠角上的枝葉越厚大越是美麗。牠的葉子能用來做成紅茶。其風味根據產地而不同，產自帕底亞的帶有濃濃香氣。"
                    .ImagePath = "/FormDifferenceImages/586/Summer.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .ATTACK = 100
                        .DEFEND = 70
                        .SPATTACK = 60
                        .SPDEFEND = 70
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的寶可夢。愛好者們認為牠角上垂下的枝葉顏色越紅越是氣派。秋天的樣子的萌芽鹿以性情粗暴聞名。雄性間一天到晚都在打架。"
                    .ImagePath = "/FormDifferenceImages/586/Autumn.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .ATTACK = 100
                        .DEFEND = 70
                        .SPATTACK = 60
                        .SPDEFEND = 70
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
                    .IsUniqueDescriptionAvailable = False
                    .Ability1 = "034"
                    .Ability2 = "157"
                    .AbilityHidden = "032"
                    .Height = "1.9 m"
                    .Weight = "92.5 kg"
                    .Category = "季節神奇寶貝"
                    .BodyColor = "褐"
                    .Type = "[草]+[一般]"
                    .UniqueDescription = "有許多愛好者的寶可夢。但唯獨這個季節的樣子卻偏偏沒什麼人喜歡。據說變成這個樣子的時期性情較為穩重、極易馴化，是與牠成為夥伴的好機會。"
                    .ImagePath = "/FormDifferenceImages/586/Winter.png"
                    With .SpeciesStrengthValues
                        .HP = 80
                        .ATTACK = 100
                        .DEFEND = 70
                        .SPATTACK = 60
                        .SPDEFEND = 70
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 615
                With FormDifferenceList
                    .Add("第七世代之前的種族值")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 50
                        .DEFEND = 30
                        .SPATTACK = 95
                        .SPDEFEND = 135
                        .SPEED = 105
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 618
                With FormDifferenceList
                    .Add("伽勒爾的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 81
                        .DEFEND = 99
                        .SPATTACK = 66
                        .SPDEFEND = 84
                        .SPEED = 32
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 628
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 83
                        .DEFEND = 70
                        .SPATTACK = 112
                        .SPDEFEND = 70
                        .SPEED = 65
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 641
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With FormDifferenceInformation(0)
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
                    .UniqueDescription = "引發風暴的寶可夢。傳說由於牠攪拌大氣，季節因此得以循環不息。據吾人考察，近似人類的形態才是假象而非真身。"
                    With .SpeciesStrengthValues
                        .HP = 79
                        .ATTACK = 115
                        .DEFEND = 70
                        .SPATTACK = 125
                        .SPDEFEND = 80
                        .SPEED = 111
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 100
                        .DEFEND = 80
                        .SPATTACK = 110
                        .SPDEFEND = 90
                        .SPEED = 121
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 642
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With FormDifferenceInformation(0)
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
                    .UniqueDescription = "引發風暴的寶可夢。傳說由於牠攪拌大氣，季節因此得以循環不息。據吾人考察，近似人類的形態才是假象而非真身。"
                    With .SpeciesStrengthValues
                        .HP = 79
                        .ATTACK = 115
                        .DEFEND = 70
                        .SPATTACK = 125
                        .SPDEFEND = 80
                        .SPEED = 111
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 105
                        .DEFEND = 70
                        .SPATTACK = 145
                        .SPDEFEND = 80
                        .SPEED = 101
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 643
                With FormDifferenceList
                    .Add("超頻驅動狀態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 120
                        .DEFEND = 100
                        .SPATTACK = 150
                        .SPDEFEND = 120
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 644
                With FormDifferenceList
                    .Add("超頻驅動狀態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 120
                        .SPATTACK = 120
                        .SPDEFEND = 100
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 645
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 125
                        .DEFEND = 90
                        .SPATTACK = 115
                        .SPDEFEND = 80
                        .SPEED = 101
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 145
                        .DEFEND = 90
                        .SPATTACK = 105
                        .SPDEFEND = 80
                        .SPEED = 91
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 646
                With FormDifferenceList
                    .Add("焰白酋雷姆 (一般模式)")
                    .Add("焰白酋雷姆 (超頻驅動狀態)")
                    .Add("暗黑酋雷姆 (一般模式)")
                    .Add("暗黑酋雷姆 (超頻驅動狀態)")
                End With
                With FormDifferenceInformation(0)
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
                    .UniqueDescription = "吸收了與自己擁有相同基因的萊希拉姆，因此能使用火與冰的能量。已經看出寶可夢和人類之間的真實世界將會到來，牠試圖去保護這樣的未來。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .ATTACK = 120
                        .DEFEND = 90
                        .SPATTACK = 170
                        .SPDEFEND = 100
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                    .UniqueDescription = "吸收了與自己擁有相同基因的萊希拉姆，因此能使用火與冰的能量。已經看出寶可夢和人類之間的真實世界將會到來，牠試圖去保護這樣的未來。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .ATTACK = 120
                        .DEFEND = 90
                        .SPATTACK = 170
                        .SPDEFEND = 100
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                    .UniqueDescription = "吸收了與自己擁有相同基因的捷克羅姆，因此能使用電與冰的能量。傳說牠是為了保護寶可夢與人類之間那將在未來實現的理想世界而戰鬥。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .ATTACK = 170
                        .DEFEND = 100
                        .SPATTACK = 120
                        .SPDEFEND = 90
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                    .UniqueDescription = "吸收了與自己擁有相同基因的捷克羅姆，因此能使用電與冰的能量。傳說牠是為了保護寶可夢與人類之間那將在未來實現的理想世界而戰鬥。"
                    With .SpeciesStrengthValues
                        .HP = 125
                        .ATTACK = 170
                        .DEFEND = 100
                        .SPATTACK = 120
                        .SPDEFEND = 90
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 647
                With FormDifferenceList
                    .Add("普通的樣子")
                    .Add("覺悟的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 72
                        .DEFEND = 90
                        .SPATTACK = 129
                        .SPDEFEND = 90
                        .SPEED = 108
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 72
                        .DEFEND = 90
                        .SPATTACK = 129
                        .SPDEFEND = 90
                        .SPEED = 108
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 648
                With FormDifferenceList
                    .Add("歌聲型態")
                    .Add("舞步型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 77
                        .DEFEND = 77
                        .SPATTACK = 128
                        .SPDEFEND = 128
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 128
                        .DEFEND = 90
                        .SPATTACK = 77
                        .SPDEFEND = 77
                        .SPEED = 128
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 649
                With FormDifferenceList
                    .Add("搭載水流卡帶")
                    .Add("搭載閃電卡帶")
                    .Add("搭載火焰卡帶")
                    .Add("搭載冰凍卡帶")
                End With
                For i As Integer = 0 To 3
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 120
                            .DEFEND = 95
                            .SPATTACK = 120
                            .SPDEFEND = 95
                            .SPEED = 99
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 658
                With FormDifferenceList
                    .Add("小智版甲賀忍蛙")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 67
                        .SPATTACK = 103
                        .SPDEFEND = 71
                        .SPEED = 122
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
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
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 52
                            .DEFEND = 50
                            .SPATTACK = 90
                            .SPDEFEND = 50
                            .SPEED = 89
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
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
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 38
                            .DEFEND = 39
                            .SPATTACK = 61
                            .SPDEFEND = 75
                            .SPEED = 42
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
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
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 45
                            .DEFEND = 47
                            .SPATTACK = 75
                            .SPDEFEND = 98
                            .SPEED = 52
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
                With FormDifferenceInformation(5)
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
                        .ATTACK = 65
                        .DEFEND = 67
                        .SPATTACK = 125
                        .SPDEFEND = 128
                        .SPEED = 92
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 671
                With FormDifferenceList
                    .Add("紅花")
                    .Add("黃花")
                    .Add("橙花")
                    .Add("藍花")
                    .Add("白花")
                End With
                For i As Integer = 0 To 4
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 65
                            .DEFEND = 68
                            .SPATTACK = 112
                            .SPDEFEND = 154
                            .SPEED = 75
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
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
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 80
                            .DEFEND = 60
                            .SPATTACK = 65
                            .SPDEFEND = 90
                            .SPEED = 102
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 681
                With FormDifferenceList
                    .Add("刀劍型態")
                    .Add("盾牌型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 150
                        .DEFEND = 50
                        .SPATTACK = 150
                        .SPDEFEND = 50
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 50
                        .DEFEND = 150
                        .SPATTACK = 50
                        .SPDEFEND = 150
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 705
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 75
                        .DEFEND = 83
                        .SPATTACK = 83
                        .SPDEFEND = 113
                        .SPEED = 40
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 706
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 100
                        .SPATTACK = 110
                        .SPDEFEND = 150
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 710
                With FormDifferenceList
                    .Add("小尺寸")
                    .Add("普通尺寸")
                    .Add("大尺寸")
                    .Add("特大尺寸")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 66
                        .DEFEND = 70
                        .SPATTACK = 44
                        .SPDEFEND = 55
                        .SPEED = 56
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 66
                        .DEFEND = 70
                        .SPATTACK = 44
                        .SPDEFEND = 55
                        .SPEED = 51
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 66
                        .DEFEND = 70
                        .SPATTACK = 44
                        .SPDEFEND = 55
                        .SPEED = 46
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 66
                        .DEFEND = 70
                        .SPATTACK = 44
                        .SPDEFEND = 55
                        .SPEED = 41
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 711
                With FormDifferenceList
                    .Add("小尺寸")
                    .Add("普通尺寸")
                    .Add("大尺寸")
                    .Add("特大尺寸")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 99
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 90
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 84
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 95
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 69
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 100
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 54
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 713
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 127
                        .DEFEND = 184
                        .SPATTACK = 34
                        .SPDEFEND = 36
                        .SPEED = 38
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 716
                With FormDifferenceList
                    .Add("活躍模式")
                    .Add("放鬆模式")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 131
                        .DEFEND = 95
                        .SPATTACK = 131
                        .SPDEFEND = 98
                        .SPEED = 99
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 131
                        .DEFEND = 95
                        .SPATTACK = 131
                        .SPDEFEND = 98
                        .SPEED = 99
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 718
                With FormDifferenceList
                    .Add("細胞型態")
                    .Add("核心型態")
                    .Add("10% 型態")
                    .Add("50% 型態")
                    .Add("完全體型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 0
                        .DEFEND = 0
                        .SPATTACK = 0
                        .SPDEFEND = 0
                        .SPEED = 0
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 0
                        .DEFEND = 0
                        .SPATTACK = 0
                        .SPDEFEND = 0
                        .SPEED = 0
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 100
                        .DEFEND = 71
                        .SPATTACK = 61
                        .SPDEFEND = 85
                        .SPEED = 115
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 100
                        .DEFEND = 121
                        .SPATTACK = 81
                        .SPDEFEND = 95
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(4)
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
                        .ATTACK = 100
                        .DEFEND = 121
                        .SPATTACK = 91
                        .SPDEFEND = 95
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 719
                With FormDifferenceList
                    .Add("超進化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 160
                        .DEFEND = 110
                        .SPATTACK = 160
                        .SPDEFEND = 110
                        .SPEED = 110
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 720
                With FormDifferenceList
                    .Add("懲戒胡帕")
                    .Add("解放胡帕")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 110
                        .DEFEND = 60
                        .SPATTACK = 150
                        .SPDEFEND = 130
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 160
                        .DEFEND = 60
                        .SPATTACK = 170
                        .SPDEFEND = 130
                        .SPEED = 80
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 724
                With FormDifferenceList
                    .Add("洗翠的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 112
                        .DEFEND = 80
                        .SPATTACK = 95
                        .SPDEFEND = 95
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 741
                With FormDifferenceList
                    .Add("熱辣熱辣風格")
                    .Add("啪滋啪滋風格")
                    .Add("呼拉呼啦風格")
                    .Add("輕盈輕盈風格")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 98
                        .SPDEFEND = 70
                        .SPEED = 93
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 98
                        .SPDEFEND = 70
                        .SPEED = 93
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 98
                        .SPDEFEND = 70
                        .SPEED = 93
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 98
                        .SPDEFEND = 70
                        .SPEED = 93
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 745
                With FormDifferenceList
                    .Add("白晝的樣子")
                    .Add("黑夜的樣子")
                    .Add("黃昏的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 115
                        .DEFEND = 65
                        .SPATTACK = 55
                        .SPDEFEND = 65
                        .SPEED = 112
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 115
                        .DEFEND = 75
                        .SPATTACK = 55
                        .SPDEFEND = 75
                        .SPEED = 82
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 117
                        .DEFEND = 65
                        .SPATTACK = 55
                        .SPDEFEND = 65
                        .SPEED = 110
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 746
                With FormDifferenceList
                    .Add("單獨的樣子")
                    .Add("魚群的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 20
                        .DEFEND = 20
                        .SPATTACK = 25
                        .SPDEFEND = 25
                        .SPEED = 40
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 140
                        .DEFEND = 130
                        .SPATTACK = 140
                        .SPDEFEND = 135
                        .SPEED = 30
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
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
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 95
                            .DEFEND = 95
                            .SPATTACK = 95
                            .SPDEFEND = 95
                            .SPEED = 95
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
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
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "原本棲息在臭氧層，身體的外殼變重後，就會向著地面落下。若受到強烈的衝擊，外殼就會剝落。是奈米粒子突變而誕生的寶可夢。"
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
                        .ATTACK = 60
                        .DEFEND = 100
                        .SPATTACK = 60
                        .SPDEFEND = 100
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                For i As Integer = 1 To 7
                    With FormDifferenceInformation(i)
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
                            .ATTACK = 100
                            .DEFEND = 60
                            .SPATTACK = 100
                            .SPDEFEND = 60
                            .SPEED = 120
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 778
                With FormDifferenceList
                    .Add("化形的樣子")
                    .Add("現形的樣子")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "真面目是個謎。某個看過破布裡面的學者因為太可怕而被活活嚇死了。用破破爛爛的布隱藏起可怕的模樣，接近人類和其他寶可夢的寂寞傢伙。"
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
                        .ATTACK = 90
                        .DEFEND = 80
                        .SPATTACK = 50
                        .SPDEFEND = 105
                        .SPEED = 96
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 90
                        .DEFEND = 80
                        .SPATTACK = 50
                        .SPDEFEND = 105
                        .SPEED = 96
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 791
                With FormDifferenceList
                    .Add("一般狀態")
                    .Add("旭日狀態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 137
                        .DEFEND = 107
                        .SPATTACK = 113
                        .SPDEFEND = 89
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 137
                        .DEFEND = 107
                        .SPATTACK = 113
                        .SPDEFEND = 89
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 792
                With FormDifferenceList
                    .Add("一般狀態")
                    .Add("滿月狀態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 113
                        .DEFEND = 89
                        .SPATTACK = 137
                        .SPDEFEND = 107
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 113
                        .DEFEND = 89
                        .SPATTACK = 137
                        .SPDEFEND = 107
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 800
                With FormDifferenceList
                    .Add("一般型態")
                    .Add("黃昏之鬃 (日蝕)")
                    .Add("拂曉之翼 (月蝕)")
                    .Add("究極奈克洛茲瑪")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 107
                        .DEFEND = 101
                        .SPATTACK = 127
                        .SPDEFEND = 89
                        .SPEED = 79
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 157
                        .DEFEND = 127
                        .SPATTACK = 113
                        .SPDEFEND = 109
                        .SPEED = 77
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 113
                        .DEFEND = 109
                        .SPATTACK = 157
                        .SPDEFEND = 127
                        .SPEED = 77
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 167
                        .DEFEND = 97
                        .SPATTACK = 167
                        .SPDEFEND = 97
                        .SPEED = 129
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 801
                With FormDifferenceList
                    .Add("500年前的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 115
                        .SPATTACK = 130
                        .SPDEFEND = 115
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 802
                With FormDifferenceList
                    .Add("棲影瑪夏多")
                    .Add("全力瑪夏多")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 125
                        .DEFEND = 80
                        .SPATTACK = 90
                        .SPDEFEND = 90
                        .SPEED = 125
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 125
                        .DEFEND = 80
                        .SPATTACK = 90
                        .SPDEFEND = 90
                        .SPEED = 125
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 809
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 143
                        .DEFEND = 143
                        .SPATTACK = 80
                        .SPDEFEND = 65
                        .SPEED = 34
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
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
                With FormDifferenceInformation(0)
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
                        .ATTACK = 125
                        .DEFEND = 90
                        .SPATTACK = 60
                        .SPDEFEND = 70
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 815
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 116
                        .DEFEND = 75
                        .SPATTACK = 65
                        .SPDEFEND = 75
                        .SPEED = 119
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 818
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 65
                        .SPATTACK = 125
                        .SPDEFEND = 65
                        .SPEED = 120
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 823
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 87
                        .DEFEND = 105
                        .SPATTACK = 53
                        .SPDEFEND = 85
                        .SPEED = 67
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 826
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 45
                        .DEFEND = 110
                        .SPATTACK = 80
                        .SPDEFEND = 120
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 834
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 115
                        .DEFEND = 90
                        .SPATTACK = 48
                        .SPDEFEND = 68
                        .SPEED = 74
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 839
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 80
                        .DEFEND = 120
                        .SPATTACK = 80
                        .SPDEFEND = 90
                        .SPEED = 30
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 841
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "超極巨化之力使牠的蜜量增加，最後外貌變成了巨大的蘋果。當牠把脖子伸長時，會散發出強烈的蜜汁甜味，讓聞到的寶可夢失去知覺。"
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
                        .ATTACK = 110
                        .DEFEND = 80
                        .SPATTACK = 95
                        .SPDEFEND = 60
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 842
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 85
                        .DEFEND = 80
                        .SPATTACK = 100
                        .SPDEFEND = 80
                        .SPEED = 30
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 844
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 107
                        .DEFEND = 125
                        .SPATTACK = 65
                        .SPDEFEND = 70
                        .SPEED = 71
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 849
                With FormDifferenceList
                    .Add("高調的樣子")
                    .Add("低調的樣子")
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 98
                        .DEFEND = 70
                        .SPATTACK = 114
                        .SPDEFEND = 70
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 98
                        .DEFEND = 70
                        .SPATTACK = 114
                        .SPDEFEND = 70
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 98
                        .DEFEND = 70
                        .SPATTACK = 114
                        .SPDEFEND = 70
                        .SPEED = 75
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 851
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 115
                        .DEFEND = 65
                        .SPATTACK = 90
                        .SPDEFEND = 90
                        .SPEED = 65
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 858
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 90
                        .DEFEND = 95
                        .SPATTACK = 136
                        .SPDEFEND = 103
                        .SPEED = 29
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 861
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 120
                        .DEFEND = 65
                        .SPATTACK = 95
                        .SPDEFEND = 75
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 869
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 60
                        .DEFEND = 75
                        .SPATTACK = 110
                        .SPDEFEND = 121
                        .SPEED = 64
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 875
                With FormDifferenceList
                    .Add("結凍型態")
                    .Add("解凍型態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 80
                        .DEFEND = 110
                        .SPATTACK = 65
                        .SPDEFEND = 90
                        .SPEED = 50
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 80
                        .DEFEND = 70
                        .SPATTACK = 65
                        .SPDEFEND = 50
                        .SPEED = 130
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 877
                With FormDifferenceList
                    .Add("滿腹花紋")
                    .Add("空腹花紋")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 95
                        .DEFEND = 58
                        .SPATTACK = 70
                        .SPDEFEND = 58
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 95
                        .DEFEND = 58
                        .SPATTACK = 70
                        .SPDEFEND = 58
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 879
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 130
                        .DEFEND = 69
                        .SPATTACK = 80
                        .SPDEFEND = 69
                        .SPEED = 30
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 884
                With FormDifferenceList
                    .Add("超極巨化")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "變得如同摩天大樓般高大。受到體內能量溢出的影響，身體的一部分會發出亮光。細胞的硬度在鋼屬性寶可夢之中也是頂級的。擁有抗震的構造。"
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
                        .ATTACK = 95
                        .DEFEND = 115
                        .SPATTACK = 120
                        .SPDEFEND = 50
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 888
                With FormDifferenceList
                    .Add("百戰勇者 (第九世代起)")
                    .Add("劍之王 (第九世代起)")
                    .Add("百戰勇者 (第九世代之前)")
                    .Add("劍之王 (第九世代之前)")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "被稱為傳說中的英雄。能夠吸收金屬，並將之轉化為武器来戰鬥。這隻寶可夢被認為是沉睡已久的藏瑪然特的姐姐，也有人認為牠們之間是勁敵關係。"
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
                        .ATTACK = 120
                        .DEFEND = 115
                        .SPATTACK = 80
                        .SPDEFEND = 115
                        .SPEED = 138
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用過去使用的兵器武裝自己。即使是超極巨化寶可夢，也能以一劍將之拿下。能斬斷世間萬物，因此被稱為妖精王之劍，讓敵友都對牠敬畏不已。"
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
                        .ATTACK = 150
                        .DEFEND = 115
                        .SPATTACK = 80
                        .SPDEFEND = 115
                        .SPEED = 148
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "被稱為傳說中的英雄。能夠吸收金屬，並將之轉化為武器来戰鬥。這隻寶可夢被認為是沉睡已久的藏瑪然特的姐姐，也有人認為牠們之間是勁敵關係。"
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
                        .ATTACK = 130
                        .DEFEND = 115
                        .SPATTACK = 80
                        .SPDEFEND = 115
                        .SPEED = 138
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "用過去使用的兵器武裝自己。即使是超極巨化寶可夢，也能以一劍將之拿下。能斬斷世間萬物，因此被稱為妖精王之劍，讓敵友都對牠敬畏不已。"
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
                        .ATTACK = 170
                        .DEFEND = 115
                        .SPATTACK = 80
                        .SPDEFEND = 115
                        .SPEED = 148
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 889
                With FormDifferenceList
                    .Add("百戰勇者 (第九世代起)")
                    .Add("盾之王 (第九世代起)")
                    .Add("百戰勇者 (第九世代之前)")
                    .Add("盾之王 (第九世代之前)")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "與眾人之王協力拯救了伽勒爾的寶可夢。吸收金屬來進行戰鬥。以石像般的姿態陷入長久沉眠的寶可夢。幾乎就要被人們所遺忘。"
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
                        .ATTACK = 120
                        .DEFEND = 115
                        .SPATTACK = 80
                        .SPDEFEND = 115
                        .SPEED = 138
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "能夠反彈一切的攻擊，因此被稱為格鬥王之盾，受到人們的畏懼與尊崇。全副武裝的樣子。即使是極巨化寶可夢的攻擊也能輕易抵擋。"
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
                        .ATTACK = 120
                        .DEFEND = 140
                        .SPATTACK = 80
                        .SPDEFEND = 140
                        .SPEED = 128
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "與眾人之王協力拯救了伽勒爾的寶可夢。吸收金屬來進行戰鬥。以石像般的姿態陷入長久沉眠的寶可夢。幾乎就要被人們所遺忘。"
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
                        .ATTACK = 130
                        .DEFEND = 115
                        .SPATTACK = 80
                        .SPDEFEND = 115
                        .SPEED = 138
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "能夠反彈一切的攻擊，因此被稱為格鬥王之盾，受到人們的畏懼與尊崇。全副武裝的樣子。即使是極巨化寶可夢的攻擊也能輕易抵擋。"
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
                        .ATTACK = 130
                        .DEFEND = 145
                        .SPATTACK = 80
                        .SPDEFEND = 145
                        .SPEED = 128
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 890
                With FormDifferenceList
                    .Add("無極巨化")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "在洛茲的計畫下，吸收了伽勒爾全域能源後負荷超載的樣子。巨大化的核心釋放出無限的能量，扭曲了周圍的時空。"
                    .Ability1 = 46
                    .Ability2 = "---"
                    .AbilityHidden = "---"
                    .Height = "100.0 m"
                    .Weight = "<缺數據>"
                    .Type = "[毒]+[龍]"
                    .ImagePath = "/FormDifferenceImages/884/Eternamax.png"
                    With .SpeciesStrengthValues
                        .HP = 255
                        .ATTACK = 115
                        .DEFEND = 250
                        .SPATTACK = 125
                        .SPDEFEND = 250
                        .SPEED = 130
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 892
                With FormDifferenceList
                    .Add("一擊流")
                    .Add("連擊流")
                    .Add("一擊流 - 超極巨化")
                    .Add("連擊流 - 超極巨化")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 130
                        .DEFEND = 100
                        .SPATTACK = 63
                        .SPDEFEND = 60
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 130
                        .DEFEND = 100
                        .SPATTACK = 63
                        .SPDEFEND = 60
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
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
                        .ATTACK = 130
                        .DEFEND = 100
                        .SPATTACK = 63
                        .SPDEFEND = 60
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 130
                        .DEFEND = 100
                        .SPATTACK = 63
                        .SPDEFEND = 60
                        .SPEED = 97
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 898
                With FormDifferenceList
                    .Add("騎白馬的樣子")
                    .Add("騎黑馬的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 165
                        .DEFEND = 150
                        .SPATTACK = 85
                        .SPDEFEND = 130
                        .SPEED = 50
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "據說牠為了讓荒地長出綠意，曾與牽絆深厚的寶可夢一同馳騁在伽勒爾的大地。據說牠曾利用能夠看穿過去和未來所有事情的能力，在隕石掉落時拯救了森林的生物。"
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
                        .ATTACK = 85
                        .DEFEND = 80
                        .SPATTACK = 165
                        .SPDEFEND = 100
                        .SPEED = 150
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 902
                With FormDifferenceList
                    .Add("雄性的樣子")
                    .Add("雌性的樣子")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 112
                        .DEFEND = 65
                        .SPATTACK = 80
                        .SPDEFEND = 75
                        .SPEED = 78
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 92
                        .DEFEND = 65
                        .SPATTACK = 100
                        .SPDEFEND = 75
                        .SPEED = 78
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 905
                With FormDifferenceList
                    .Add("化身型態")
                    .Add("靈獸形態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 115
                        .DEFEND = 70
                        .SPATTACK = 135
                        .SPDEFEND = 80
                        .SPEED = 106
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 115
                        .DEFEND = 110
                        .SPATTACK = 135
                        .SPDEFEND = 100
                        .SPEED = 46
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 916
                With FormDifferenceList
                    .Add("雄性的樣子")
                    .Add("雌性的樣子")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "以自己細緻透亮的肌膚為傲。會從尾巴的前端釋放出凝縮的香氣。會從全身散發出香甜妖豔的氣味，令雌性的寶可夢為牠神魂顛倒。"
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
                        .ATTACK = 100
                        .DEFEND = 75
                        .SPATTACK = 59
                        .SPDEFEND = 80
                        .SPEED = 65
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "會釋放出如花般的香氣。腿部肌肉發達，要跳超過５公尺高也是輕而易舉。喜好乾淨，個性一絲不苟。會讓花香包覆全身來療癒周圍的寶可夢們。"
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
                        .ATTACK = 90
                        .DEFEND = 70
                        .SPATTACK = 59
                        .SPDEFEND = 90
                        .SPEED = 65
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 925
                With FormDifferenceList
                    .Add("三隻家庭")
                    .Add("四隻家庭")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 75
                        .DEFEND = 70
                        .SPATTACK = 65
                        .SPDEFEND = 75
                        .SPEED = 111
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 75
                        .DEFEND = 70
                        .SPATTACK = 65
                        .SPDEFEND = 75
                        .SPEED = 111
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 931
                With FormDifferenceList
                    .Add("綠羽毛")
                    .Add("藍羽毛")
                    .Add("黃羽毛")
                    .Add("白羽毛")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 96
                        .DEFEND = 51
                        .SPATTACK = 45
                        .SPDEFEND = 51
                        .SPEED = 92
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 96
                        .DEFEND = 51
                        .SPATTACK = 45
                        .SPDEFEND = 51
                        .SPEED = 92
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "黃色的怒鸚哥最為粗暴。有時還會把其他鳥寶可夢趕到城鎮外面去。性情和戰鬥方式都很粗暴。會衝進對手的懷裡，以自己的肉身發動攻擊。"
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
                        .ATTACK = 96
                        .DEFEND = 51
                        .SPATTACK = 45
                        .SPDEFEND = 51
                        .SPEED = 92
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(3)
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
                        .ATTACK = 96
                        .DEFEND = 51
                        .SPATTACK = 45
                        .SPDEFEND = 51
                        .SPEED = 92
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 964
                With FormDifferenceList
                    .Add("平凡型態")
                    .Add("全能形態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 70
                        .DEFEND = 72
                        .SPATTACK = 53
                        .SPDEFEND = 62
                        .SPEED = 100
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "太古基因覺醒之後的樣子。力氣很大，只用單邊的鰭也可以輕輕鬆鬆舉起遊輪。會以５０節的泳速來救助溺水的人類和寶可夢，可以說是大海英雄。"
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
                        .ATTACK = 160
                        .DEFEND = 97
                        .SPATTACK = 106
                        .SPDEFEND = 87
                        .SPEED = 100
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 978
                With FormDifferenceList
                    .Add("上弓姿勢")
                    .Add("下垂姿勢")
                    .Add("平挺姿勢")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "小型的龍寶可夢。會住在吃吼霸嘴裡，保護自己免於外敵襲擊。極為奸詐狡猾的寶可夢。會假裝虛弱來吸引獵物接近，接著讓同夥的寶可夢發動攻擊。"
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
                        .ATTACK = 50
                        .DEFEND = 60
                        .SPATTACK = 120
                        .SPDEFEND = 95
                        .SPEED = 82
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 50
                        .DEFEND = 60
                        .SPATTACK = 120
                        .SPDEFEND = 95
                        .SPEED = 82
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "鳥寶可夢是牠主要的獵物。對自己的弱小心知肚明，因此都會和夥伴結伴狩獵。牠的智商即使在龍寶可夢中也可以說是數一數二。會鼓起喉囊來擬態。"
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
                        .ATTACK = 50
                        .DEFEND = 60
                        .SPATTACK = 120
                        .SPDEFEND = 95
                        .SPEED = 82
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 982
                With FormDifferenceList
                    .Add("二節形態")
                    .Add("三節形態")
                End With
                With FormDifferenceInformation(0)
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
                        .ATTACK = 100
                        .DEFEND = 80
                        .SPATTACK = 85
                        .SPDEFEND = 75
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "性格溫馴，會讓誤闖進巢穴的寶可夢乘在自己的背上，將其送到入口。最近的研究發現，牠的身體會有幾節，全是由基因決定的。"
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
                        .ATTACK = 100
                        .DEFEND = 80
                        .SPATTACK = 85
                        .SPDEFEND = 75
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 999
                With FormDifferenceList
                    .Add("寶箱形態")
                    .Add("徒步形態")
                End With
                With FormDifferenceInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .UniqueDescription = "約１５００年前出生在寶箱裡。如果有惡棍打算偷走寶藏，就會被牠吸走精氣。棲息在老舊的寶箱中。有時會因沒人注意到自己是寶可夢，而被擱置在道具店的角落。"
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
                        .ATTACK = 30
                        .DEFEND = 70
                        .SPATTACK = 75
                        .SPDEFEND = 70
                        .SPEED = 10
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With FormDifferenceInformation(1)
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
                        .ATTACK = 30
                        .DEFEND = 25
                        .SPATTACK = 75
                        .SPDEFEND = 45
                        .SPEED = 80
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
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
