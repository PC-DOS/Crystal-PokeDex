Module libMultiStatesProvider
    Public Structure PokemonBaseStatsValues
        Dim HP As Integer
        Dim ATTACK As Integer
        Dim DEFEND As Integer
        Dim SPATTACK As Integer
        Dim SPDEFEND As Integer
        Dim SPEED As Integer
        Dim TOTAL As Integer
    End Structure
    Public Structure StateInfo
        Dim lpStateName As String
        Dim lpType As String
        Dim lpImagePath As String
        Dim lpAbility1 As String
        Dim lpAbility2 As String
        Dim lpAbilityHidden As String
        Dim lpHeight As String
        Dim lpWeight As String
        Dim IsUniqueDescriptionAvailable As Boolean
        Dim lpUniqueDescription As String
        Dim lpBaseStatsValues As PokemonBaseStatsValues
    End Structure
    Public States As New List(Of String)
    Public StateInformation(0 To 30) As StateInfo
    Public SharedStateInformation As New StateInfo
    Public UniversalLoopCounter As Integer
    Public PokemonTypes As New List(Of String)
    Public Sub GenerateSpecificStateInfo(lpSelectedPokemonNumber As Long)
        States.Clear()
        InitPokemonTypes()
        If lpSelectedPokemonNumber <= TotalPokemonCountPerVersion.DPT Then
            GenerateSpecificStateInfoPreBW(lpSelectedPokemonNumber)
        ElseIf lpSelectedPokemonNumber <= TotalPokemonCountPerVersion.SM Then
            GenerateSpecificStateInfoBWXYSM(lpSelectedPokemonNumber)
        End If
    End Sub
    Public Sub GenerateSpecificStateInfoPreBW(lpSelectedPokemonNumber As Long)
        Select Case lpSelectedPokemonNumber
            Case 3
                With States
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 47
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.4 m"
                    .lpWeight = "155.5 kg"
                    .lpType = "[草]+[毒]"
                    .lpImagePath = "/MultiStatesImages/003/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "為了支撐超級進化之後變得更大的花，下盤的筋骨變得更加強壯了。"
                    With .lpBaseStatsValues
                        .HP = 80
                        .ATTACK = 100
                        .DEFEND = 123
                        .SPATTACK = 122
                        .SPDEFEND = 120
                        .SPEED = 80
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "透過揮舞２根粗大的藤蔓來戰鬥。力道之強，甚至能夠輕輕鬆鬆揮倒１０層樓高的大廈。會像火山噴發般猛烈地散播大量的花粉。要是吸進太多花粉是會昏倒的。"
                    .lpAbility1 = 65
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 35
                    .lpHeight = "24.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpType = "[草]+[毒]"
                    .lpImagePath = "/MultiStatesImages/003/Gigantamax.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 181
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "110.5 kg"
                    .lpType = "[火]+[龍]"
                    .lpImagePath = "/MultiStatesImages/006/MegaX.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "全身湧出超乎尋常的力量，將身體染成了黑色，同時熊熊燃燒著藍色的火焰。"
                    With .lpBaseStatsValues
                        .HP = 78
                        .ATTACK = 130
                        .DEFEND = 111
                        .SPATTACK = 130
                        .SPDEFEND = 85
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 70
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "100.5 kg"
                    .lpType = "[火]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/006/MegaY.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "與訓練家的牽絆是牠力量的泉源。引以為傲的飛行能力甚至凌駕於噴射機之上。"
                    With .lpBaseStatsValues
                        .HP = 78
                        .ATTACK = 104
                        .DEFEND = 78
                        .SPATTACK = 159
                        .SPDEFEND = 115
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "超極巨化之力不僅讓噴火龍變得更加巨大，還讓牠獲得了熊熊燃燒的翅膀。攝氏２０００度的火焰在體內形成了旋渦。當牠咆哮的時候，火力還會進一步提升。"
                    .lpAbility1 = 66
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 94
                    .lpHeight = "28.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpType = "[火]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/006/Gigantamax.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 178
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[水]"
                    .lpHeight = "1.6 m"
                    .lpWeight = "101.1 kg"
                    .lpImagePath = "/MultiStatesImages/009/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "甲殼上的大砲有著不遜於戰車的威力。靠著強韌的下盤筋骨承受大砲發射時的衝擊力。"
                    With .lpBaseStatsValues
                        .HP = 79
                        .ATTACK = 103
                        .DEFEND = 120
                        .SPATTACK = 135
                        .SPDEFEND = 115
                        .SPEED = 78
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "不擅長精準的射擊。使用３１門大砲射啊射啊射個不停，才是牠的攻擊風格。從中央的主砲發射的水槍破壞力十足，能夠貫穿山體開出山洞。"
                    .lpAbility1 = 67
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 44
                    .lpHeight = "25.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpType = "[水]"
                    .lpImagePath = "/MultiStatesImages/009/Gigantamax.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 91
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[蟲]+[毒]"
                    .lpHeight = "1.4 m"
                    .lpWeight = "40.5 kg"
                    .lpImagePath = "/MultiStatesImages/015/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "雙腳也變成了毒針。會先用手腳的針猛刺一通，然後用臀部的毒針給予致命一擊。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 99
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.2 m"
                    .lpWeight = "50.5 kg"
                    .lpType = "[一般]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/018/Mega.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[惡]+[一般]"
                    .lpAbility1 = "082"
                    .lpAbility2 = "055"
                    .lpAbilityHidden = "047"
                    .lpHeight = "0.3 m"
                    .lpWeight = "3.8 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "用門牙咬破大門侵入民宅。扯動鬍鬚尋找出食物然後偷走。太陽下山後才活動。為了幫群體的老大拉達尋找好的食物而在街上跑來跑去。"
                    .lpImagePath = "/MultiStatesImages/019/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[惡]+[一般]"
                    .lpAbility1 = "050"
                    .lpAbility2 = "062"
                    .lpAbilityHidden = "055"
                    .lpHeight = "0.7 m"
                    .lpWeight = "25.5 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "率領小拉達組成團隊。每個團隊各有自己的地盤，會為了爭奪食物而發生爭鬥。對食物的味道和新鮮度非常講究的美食家寶可夢。據說有拉達棲息的餐廳肯定是好餐廳。"
                    .lpImagePath = "/MultiStatesImages/020/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("第六世代之前的種族值")
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .lpType = "[電]"
                    .lpAbility1 = 9
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 31
                    .IsUniqueDescriptionAvailable = False
                    .lpUniqueDescription = ""
                    .lpImagePath = "/Pokemons/025.png"
                    .lpHeight = "0.4 m"
                    .lpWeight = "6.0 kg"
                    With .lpBaseStatsValues
                        .HP = 35
                        .ATTACK = 55
                        .DEFEND = 30
                        .SPATTACK = 50
                        .SPDEFEND = 40
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .lpType = "[電]"
                    .lpAbility1 = 9
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 31
                    .lpHeight = "21.0 m以上"
                    .lpWeight = "<缺數據>"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "膨脹的超極巨化之力使得牠的身體變大，尾巴也變得高聳入雲。當牠用閃電狀的尾巴擊中目標時，不亞於雷擊的電壓和電流便會貫穿對方的全身。"
                    .lpImagePath = "/MultiStatesImages/025/Gigantamax.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[電]+[超能]"
                    .lpAbility1 = "207"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .lpHeight = "0.7 m"
                    .lpWeight = "21.0 kg"
                    .lpUniqueDescription = "只有在阿羅拉地區才會進化成這個樣子。研究者說，其主要原因之一是食物。透過念力操縱電力。乘在尾巴上，利用精神力量浮起來進行移動。"
                    .lpImagePath = "/MultiStatesImages/026/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[冰]+[鋼]"
                    .lpAbility1 = "081"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "202"
                    .lpHeight = "0.7 m"
                    .lpWeight = "40.0 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "棲息在雪山。鋼鐵的甲殼非常堅固，但因為過於堅硬，身體沒法蜷縮起來。讓穿山鼠在冰上滑行，比賽滑行的距離。這是阿羅拉自古就有的慶典之一。"
                    .lpImagePath = "/MultiStatesImages/027/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[冰]+[鋼]"
                    .lpAbility1 = "081"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "202"
                    .lpHeight = "1.2 m"
                    .lpWeight = "55.0 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "從火山爆發逃難的最後，在雪山棲息定居下來。會濺起雪花在雪原上奔馳。鋼針被冰覆蓋著。被刺中時不但會造成很深的傷口，同時也會凍傷。"
                    .lpImagePath = "/MultiStatesImages/028/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[冰]"
                    .lpAbility1 = "081"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "117"
                    .lpHeight = "0.6 m"
                    .lpWeight = "9.9 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "會噴出零下５０度的冷氣。阿羅拉的老人也會用凱歐凱歐這個過去的名字稱呼牠。天氣熱的時候會用６根尾巴製造冰礫再撒向周圍，藉此讓身體冷卻下來。"
                    .lpImagePath = "/MultiStatesImages/037/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[冰]"
                    .lpAbility1 = "081"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "117"
                    .IsUniqueDescriptionAvailable = True
                    .lpHeight = "1.1 m"
                    .lpWeight = "19.9 kg"
                    .lpUniqueDescription = "從體毛中生出冰粒，潑向敵人。如果惹惱牠，一瞬間就會被冰鎮。性格穩重。被人知道是九尾的地區形態之前，一直被尊敬為神的化身。"
                    .lpImagePath = "/MultiStatesImages/038/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[地面]+[鋼]"
                    .lpAbility1 = "008"
                    .lpAbility2 = "221"
                    .lpAbilityHidden = "159"
                    .lpHeight = "0.2 m"
                    .lpWeight = "1.0 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "從頭上長出來的是鬍鬚變化而來的金屬物體。隨著擺動跟夥伴進行交流。金色的鬍子擁有感應器的功能。會從洞裡伸出，查探周圍的狀態。"
                    .lpImagePath = "/MultiStatesImages/050/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[地面]+[鋼]"
                    .lpAbility1 = "008"
                    .lpAbility2 = "221"
                    .lpAbilityHidden = "159"
                    .lpHeight = "0.7 m"
                    .lpWeight = "66.6 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "用金光閃爍的鬍子保護身體。聽說如果把脫落的鬍鬚帶回家，會招來不幸。被認為是大地女神們的化身，在阿羅拉地區非常受重視。"
                    .lpImagePath = "/MultiStatesImages/051/Alola.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                    .Add("伽勒爾的樣子")
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .lpType = "[惡]"
                    .lpAbility1 = "053"
                    .lpAbility2 = "101"
                    .lpAbilityHidden = "155"
                    .lpHeight = "0.4 m"
                    .lpWeight = "4.2 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "原本不棲息在阿羅拉，是人為引進後在野外繁殖而來的。性格聰明狡猾，自尊心很強。如果被傷到高傲的自尊心，或是額頭上的金幣被弄髒時，就會發狂般情緒失控。"
                    .lpImagePath = "/MultiStatesImages/052/Alola.png"
                    With .lpBaseStatsValues
                        .HP = 40
                        .ATTACK = 35
                        .DEFEND = 35
                        .SPATTACK = 50
                        .SPDEFEND = 40
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .lpType = "[鋼]"
                    .lpAbility1 = 53
                    .lpAbility2 = 181
                    .lpAbilityHidden = 127
                    .lpHeight = "0.4 m"
                    .lpWeight = "7.5 kg"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "和好戰的海洋民族一起生活，久而久之身體的各個地方就都變成了黑鐵。額頭上的金幣越黑就越硬，也越能受到夥伴的尊敬。性情勇猛，什麼都不怕。"
                    .lpImagePath = "/MultiStatesImages/052/Galar.png"
                    With .lpBaseStatsValues
                        .HP = 40
                        .ATTACK = 45
                        .DEFEND = 35
                        .SPATTACK = 40
                        .SPDEFEND = 40
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .lpType = "[一般]"
                    .lpAbility1 = 53
                    .lpAbility2 = 101
                    .lpAbilityHidden = 127
                    .lpHeight = "33.0 m以上"
                    .lpWeight = "<缺數據>"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "人們認為牠額頭上金幣浮現出的紋路中蘊藏著解開極巨化之謎的關鍵。受超極巨化之力的影響，身體越長越高，額頭上的金幣也變成了大金幣。"
                    .lpImagePath = "/MultiStatesImages/052/Gigantamax.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[惡]"
                    .lpAbility1 = "169"
                    .lpAbility2 = "101"
                    .lpAbilityHidden = "155"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "圓圓的臉孔，比最高級的天鵝絨還光滑的毛髮，在阿羅拉是非常受歡迎的寶可夢。蔑視自己之外的一切。喜歡採用突襲和夜襲等卑劣無恥的戰法。"
                    .lpImagePath = "/MultiStatesImages/053/Alola.png"
                    .lpHeight = "1.1 m"
                    .lpWeight = "33.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("洗翠的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[火]+[岩石]"
                    .lpAbility1 = 22
                    .lpAbility2 = 18
                    .lpAbilityHidden = 69
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "兩隻一組共同負責地盤的警戒工作。體毛中混有火成岩的成分，可以推想這是受到火山活動的影響。 "
                    .lpImagePath = "/MultiStatesImages/058/Hisui.png"
                    .lpHeight = "0.8 m"
                    .lpWeight = "22.7 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("洗翠的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[火]+[岩石]"
                    .lpAbility1 = 22
                    .lpAbility2 = 18
                    .lpAbilityHidden = 69
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = ""
                    .lpImagePath = "/MultiStatesImages/059/Hisui.png"
                    .lpHeight = "2.0 m"
                    .lpWeight = "168.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 36
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.2 m"
                    .lpWeight = "48.0 kg"
                    .lpType = "[超能力]"
                    .lpImagePath = "/MultiStatesImages/065/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "透過超級進化，牠的力量全部變換為精神力量。甚至連肌肉力量也失去了。釋放蘊藏著的精神力量。只要看一眼就能知道對手由生到死的全部事情。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 62
                    .lpAbility2 = 99
                    .lpAbilityHidden = 80
                    .lpHeight = "25.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpType = "[格鬥]"
                    .lpImagePath = "/MultiStatesImages/068/Gigantamax.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "手臂裡充斥著超極巨化之力，因此能施展出破壞力不亞於炸彈的拳擊。怪力提升到了驚人境界，甚至曾經把受困的大型船隻整艘扛到了港口。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[岩石]+[電]"
                    .lpAbility1 = "042"
                    .lpAbility2 = "005"
                    .lpAbilityHidden = "206"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "石頭身體帶有磁力。在磁力特別強的部分附著密密麻麻的鐵砂哦。如果踩到在地面睡覺的小拳石，就會發出叮──的響聲，全身會一下子變得麻痺。"
                    .lpImagePath = "/MultiStatesImages/074/Alola.png"
                    .lpHeight = "0.4 m"
                    .lpWeight = "20.3 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[岩石]+[電]"
                    .lpAbility1 = "042"
                    .lpAbility2 = "005"
                    .lpAbilityHidden = "206"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "很喜歡吃鎂電氣石，吃下的成分會變為結晶，在身體的一部分上浮現出來。為尋找吃的石頭而打架。隆隆石們每次互相碰撞都會發出爆炸聲和耀眼的光芒。"
                    .lpImagePath = "/MultiStatesImages/075/Alola.png"
                    .lpHeight = "1.0 m"
                    .lpWeight = "110.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[岩石]+[電]"
                    .lpAbility1 = "042"
                    .lpAbility2 = "005"
                    .lpAbilityHidden = "206"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "發射出帶著電的岩石。即使沒有擊中，只是擦到就能令對手因麻痺而失去意識。因無法連續發射岩石，所以有時候會捕捉附近的小拳石，裝在背上用來發射。"
                    .lpImagePath = "/MultiStatesImages/076/Alola.png"
                    .lpHeight = "1.7 m"
                    .lpWeight = "316.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[超能力]"
                    .lpAbility1 = 50
                    .lpAbility2 = 257
                    .lpAbilityHidden = 107
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "小小的角裡蘊藏著治癒之力。如果只是一點小傷，牠只要用角輕擦傷口就能治癒。能從眼神中讀取對方的內心。如果發現了邪惡的想法，就會在轉眼間消失不見。"
                    .lpImagePath = "/MultiStatesImages/077/Galar.png"
                    .lpHeight = "0.8 m"
                    .lpWeight = "24.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[超能力]+[妖精]"
                    .lpAbility1 = 50
                    .lpAbility2 = 257
                    .lpAbilityHidden = 107
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "會從角發射強力的精神利刃。那超群的破壞力甚至可以在厚厚的鐵板上開出洞來。勇猛果敢，自尊心強。會在蹄上的毛裡儲存精神力量，在森林中輕快地奔跑。"
                    .lpImagePath = "/MultiStatesImages/078/Galar.png"
                    .lpHeight = "0.8 m"
                    .lpWeight = "24.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[超能力]"
                    .lpAbility1 = 82
                    .lpAbility2 = 20
                    .lpAbilityHidden = 144
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "平時一直都在發呆，但偶爾會突然露出銳利的神色。據說這和牠所吃的食物有關。牠以只生長在伽勒爾地區的植物的種子為食，因此尾巴是辣味的。"
                    .lpImagePath = "/MultiStatesImages/079/Galar.png"
                    .lpHeight = "1.2 m"
                    .lpWeight = "36.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpAbility1 = 75
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.0 m"
                    .lpWeight = "120.0 kg"
                    .lpType = "[水]+[超能力]"
                    .lpImagePath = "/MultiStatesImages/080/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "超級進化的能量全部被注入到了尾部的大舌貝裡。然後呆呆獸被整個吞下。吸收了超級進化能量的大舌貝成了銅牆鐵壁般的鎧甲。呆呆獸本身並沒有什麼變化。"
                    With .lpBaseStatsValues
                        .HP = 95
                        .ATTACK = 75
                        .DEFEND = 180
                        .SPATTACK = 130
                        .SPDEFEND = 80
                        .SPEED = 30
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .lpType = "[毒]+[超能力]"
                    .lpAbility1 = 259
                    .lpAbility2 = 20
                    .lpAbilityHidden = 144
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "被大舌貝咬住的刺激和體內的香料發生化學反應，讓牠變成了毒屬性。當牠捏住咬著自己的大舌貝的舌頭，螺旋狀的貝殼尖端就會噴射出有劇毒的液體。"
                    .lpImagePath = "/MultiStatesImages/080/Galar.png"
                    .lpHeight = "1.6 m"
                    .lpWeight = "70.5 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("第七世代之前的種族值")
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[一般]+[飛行]"
                    .lpAbility1 = 51
                    .lpAbility2 = 39
                    .lpAbilityHidden = 128
                    .IsUniqueDescriptionAvailable = False
                    .lpUniqueDescription = ""
                    .lpImagePath = "/Pokemons/083.png"
                    .lpHeight = "0.8 m"
                    .lpWeight = "42.0 kg"
                    With .lpBaseStatsValues
                        .HP = 52
                        .ATTACK = 65
                        .DEFEND = 55
                        .SPATTACK = 58
                        .SPDEFEND = 62
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .lpType = "[格鬥]"
                    .lpAbility1 = 80
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 113
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "生活在伽勒爾的大蔥鴨。揮舞著又粗又壯的大蔥，是英勇奮戰的戰士。在不斷活用又粗又長的伽勒爾大蔥的過程中，大蔥鴨演化成了獨特的樣子。"
                    .lpImagePath = "/MultiStatesImages/083/Galar.png"
                    .lpHeight = "0.8 m"
                    .lpWeight = "42.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[毒]+[惡]"
                    .lpAbility1 = "143"
                    .lpAbility2 = "082"
                    .lpAbilityHidden = "223"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "為了解決垃圾問題從其他地區帶來的臭泥不知不覺就變成了這個樣子。結晶是毒素塊。如果從臭泥的身上落下，就會流出足以致死的毒素。"
                    .lpImagePath = "/MultiStatesImages/088/Alola.png"
                    .lpHeight = "0.7 m"
                    .lpWeight = "42.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[毒]+[惡]"
                    .lpAbility1 = "143"
                    .lpAbility2 = "082"
                    .lpAbilityHidden = "223"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "極度鮮豔的身體顏色是因為吃下的垃圾不斷在體內引起化學反應。意外地沉穩且友善，但若一直不給牠垃圾吃，牠就會破壞傢具，把傢具當食物吃掉。"
                    .lpImagePath = "/MultiStatesImages/089/Alola.png"
                    .lpHeight = "1.0 m"
                    .lpWeight = "52.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .lpAbility1 = 23
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.4 m"
                    .lpWeight = "40.5 kg"
                    .lpType = "[幽靈]+[毒]"
                    .lpImagePath = "/MultiStatesImages/094/Mega.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "耿鬼的愛是扭曲的。聽說耿鬼只會對自己當成狩獵目標的對手萌生愛意。因超級進化的能量而覺醒。潛伏在異次元，一直靜靜地等待著攻擊的機會。"
                    With .lpBaseStatsValues
                        .HP = 60
                        .ATTACK = 65
                        .DEFEND = 80
                        .SPATTACK = 170
                        .SPDEFEND = 95
                        .SPEED = 130
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .lpAbility1 = 130
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "20.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpType = "[幽靈]+[毒]"
                    .lpImagePath = "/MultiStatesImages/094/Gigantamax.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "身體裡填滿了詛咒的能量。據說牠巨大嘴巴的另一端連接著死後的世界。會設下致命的陷阱。如果站在牠的嘴巴前面，就會聽見心愛之人呼喚自己的聲音。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .lpAbility1 = 52
                    .lpAbility2 = 75
                    .lpAbilityHidden = 125
                    .lpHeight = "19.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpType = "[水]"
                    .lpImagePath = "/MultiStatesImages/099/Gigantamax.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "受到超極巨化之力影響而變得巨大的左鉗可以把任何東西都夾得粉碎。會吐出強鹼性的泡沫，對手一旦被泡沫沾上，身體就會立刻溶化。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("洗翠的樣子")
                End With
                With StateInformation(0)
                    .lpAbility1 = 43
                    .lpAbility2 = 9
                    .lpAbilityHidden = 106
                    .lpHeight = "0.5 m"
                    .lpWeight = "13.0 kg"
                    .lpType = "[電]+[草]"
                    .lpImagePath = "/MultiStatesImages/100/Hisui.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = ""
                    With .lpBaseStatsValues
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
                With States
                    .Add("第七世代之前的種族值")
                    .Add("洗翠的樣子")
                End With
                With StateInformation(0)
                    .lpAbility1 = 43
                    .lpAbility2 = 9
                    .lpAbilityHidden = 106
                    .lpHeight = "1.2 m"
                    .lpWeight = "66.6 kg"
                    .lpType = "[電]"
                    .lpImagePath = "/Pokemons/101.png"
                    .IsUniqueDescriptionAvailable = False
                    .lpUniqueDescription = ""
                    With .lpBaseStatsValues
                        .HP = 60
                        .ATTACK = 50
                        .DEFEND = 70
                        .SPATTACK = 80
                        .SPDEFEND = 80
                        .SPEED = 140
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .lpAbility1 = 43
                    .lpAbility2 = 9
                    .lpAbilityHidden = 106
                    .lpHeight = "1.2 m"
                    .lpWeight = "71.0 kg"
                    .lpType = "[電]+[草]"
                    .lpImagePath = "/MultiStatesImages/101/Hisui.png"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "體表的組織與球果的成分極為接近，實在不可思議。當牠情緒焦躁時所放出的電流，能量足以匹敵２０次的落雷。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("第七世代之前的種族值")
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[草]+[超能力]"
                    .lpAbility1 = 34
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 139
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = ""
                    .lpImagePath = "/Pokemons/103.png"
                    .lpHeight = "2.0 m"
                    .lpWeight = "120.0 kg"
                    With .lpBaseStatsValues
                        .HP = 95
                        .ATTACK = 95
                        .DEFEND = 85
                        .SPATTACK = 125
                        .SPDEFEND = 65
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .lpType = "[草]+[龍]"
                    .lpAbility1 = "119"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "139"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "對牠來說，阿羅拉是最棒的環境。當地的人們誇讚說這才是椰蛋樹原本該有的樣子。悠悠地成長，變得不再需要精神力量，沉睡的龍之力也覺醒了。"
                    .lpImagePath = "/MultiStatesImages/103/Alola.png"
                    .lpHeight = "10.9 m"
                    .lpWeight = "415.6 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[火]+[幽靈]"
                    .lpAbility1 = "130"
                    .lpAbility2 = "031"
                    .lpAbilityHidden = "069"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "手裡的骨頭是母親的骸骨。死後還思念著孩子的母親帶著遺憾，化為火焰守護著嘎啦嘎啦。有哀悼夥伴的習性。若路邊有隆起的土，那是嘎啦嘎啦的墳墓。"
                    .lpImagePath = "/MultiStatesImages/105/Alola.png"
                    .lpHeight = "1.0 m"
                    .lpWeight = "34.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[毒]+[妖精]"
                    .lpAbility1 = 26
                    .lpAbility2 = 256
                    .lpAbilityHidden = 228
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "在往昔工廠林立、空氣嚴重污染的時代，雙彈瓦斯不知道為什麼變成了這個樣子。會吸收大氣中的污染成分，然後吐出新鮮的空氣，這就是牠的排泄方式。"
                    .lpImagePath = "/MultiStatesImages/110/Galar.png"
                    .lpHeight = "3.0 m"
                    .lpWeight = "16.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 185
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[一般]"
                    .lpHeight = "2.2 m"
                    .lpWeight = "100.0 kg"
                    .lpImagePath = "/MultiStatesImages/115/Mega.png"
                    .lpUniqueDescription = "超級袋獸之所以強大，是母親因孩子的成長而感到喜悅，變得幹勁十足的緣故。孩子因超級進化而成長，但總是爭強好勝，所以母親對孩子的將來有點擔心。看到孩子超級進化後的背影，母親就會不禁想像起終將來臨的別離之日。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[冰]+[超能力]"
                    .lpAbility1 = 72
                    .lpAbility2 = 251
                    .lpAbilityHidden = 115
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "擅長踢踏舞。會用冷氣製造出冰之地板並將其踢起，以此作為保護自己的障壁。"
                    .lpImagePath = "/MultiStatesImages/122/Galar.png"
                    .lpHeight = "1.4 m"
                    .lpWeight = "56.8 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 184
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[蟲]+[飛行]"
                    .lpHeight = "1.7 m"
                    .lpWeight = "59.0 kg"
                    .lpImagePath = "/MultiStatesImages/127/Mega.png"
                    .lpUniqueDescription = "受到超級進化的影響，隨時都處於興奮狀態。會用２隻大角將敵人刺穿後撕裂。翅膀變得異常發達。能以大約５０公里的時速飛行。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("帕底亞的樣子 - 鬥戰種")
                    .Add("帕底亞的樣子 - 火熾種")
                    .Add("帕底亞的樣子 - 水瀾種")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 22
                    .lpAbility2 = 83
                    .lpAbilityHidden = 291
                    .lpType = "[格鬥]"
                    .lpHeight = "1.4 m"
                    .lpWeight = "115.0 kg"
                    .lpImagePath = "/MultiStatesImages/128/PaldeaCombat.png"
                    .lpUniqueDescription = "特徵是厚實有力的肌肉，以及粗魯暴躁的性格。這種樣子被稱為鬥戰種。擅長以肌肉發達的身體打格鬥戰。會用短短的角瞄準對手的要害。"
                    With .lpBaseStatsValues
                        .HP = 75
                        .ATTACK = 110
                        .DEFEND = 105
                        .SPATTACK = 30
                        .SPDEFEND = 70
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 22
                    .lpAbility2 = 83
                    .lpAbilityHidden = 291
                    .lpType = "[格鬥]+[火]"
                    .lpHeight = "1.4 m"
                    .lpWeight = "85.0 kg"
                    .lpImagePath = "/MultiStatesImages/128/PaldeaBlaze.png"
                    .lpUniqueDescription = "噴出的鼻息溫度很高，因此被命名為火熾種。３根尾巴總是束在一起。會用火焰能量將角加熱到攝氏１０００度，被刺中的敵人會受創傷和灼傷所苦。"
                    With .lpBaseStatsValues
                        .HP = 75
                        .ATTACK = 110
                        .DEFEND = 105
                        .SPATTACK = 30
                        .SPDEFEND = 70
                        .SPEED = 100
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 22
                    .lpAbility2 = 83
                    .lpAbilityHidden = 291
                    .lpType = "[格鬥]+[水]"
                    .lpHeight = "1.4 m"
                    .lpWeight = "110.0 kg"
                    .lpImagePath = "/MultiStatesImages/128/PaldeaAqua.png"
                    .lpUniqueDescription = "會從角噴出水來游泳。脂肪含量高而容易浮在水上是水瀾種的特徵。會從角尖端的洞噴射出力道強勁的水流，以其高壓來貫穿敵人的身體。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 104
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[水]+[飛行]"
                    .lpHeight = "6.5 m"
                    .lpWeight = "305.0 kg"
                    .lpImagePath = "/MultiStatesImages/130/Mega.png"
                    .lpUniqueDescription = "超級進化對牠的身體造成了負擔，對大腦也會起副作用。只剩下將一切都燒毀破壞的本能。從身體側面的噴射口噴出水來，沿著水面飛行。那速度超過了音速。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 11
                    .lpAbility2 = 75
                    .lpAbilityHidden = 93
                    .lpType = "[水]+[冰]"
                    .lpHeight = "24.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpImagePath = "/MultiStatesImages/131/Gigantamax.png"
                    .lpUniqueDescription = "可以讓超過５０００個人乘坐在自己背部的甲殼上。完全不會搖晃，坐起來非常舒適。冰粒集中在身體周圍，形成巨大的圓環。會一邊用圓環擊碎冰山，一邊悠然地游泳。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 50
                    .lpAbility2 = 91
                    .lpAbilityHidden = 107
                    .lpType = "[一般]"
                    .lpHeight = "18.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpImagePath = "/MultiStatesImages/133/Gigantamax.png"
                    .lpUniqueDescription = "超極巨化之力使得頸部的絨毛變得更加地毛茸茸。會用絨毛包住敵人，同時擄獲牠的心。性情變得更加天真無邪。不管遇到誰都會撲上去玩耍，但巨大的身體往往會把對方壓垮。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 181
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.1 m"
                    .lpWeight = "79.0 kg"
                    .lpType = "[岩石]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/142/Mega.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超極巨化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 17
                    .lpAbility2 = 47
                    .lpAbilityHidden = 82
                    .lpType = "[一般]"
                    .lpHeight = "35.0 m以上"
                    .lpWeight = "<缺數據>"
                    .lpImagePath = "/MultiStatesImages/143/Gigantamax.png"
                    .lpUniqueDescription = "在超極巨化之力的影響下，吃東西時掉在肚子上的種子和黏在身上的小石子也一起變大了。擁有駭人的力量。體型像山一樣巨大，而且不動如山。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[超能力]+[飛行]"
                    .lpAbility1 = 172
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "用精神力量製作的羽毛狀利刃，就連厚厚的鐵板都能像紙片般割開。射出的光束會讓對方的身體像結凍似地失去自由。"
                    .lpImagePath = "/MultiStatesImages/144/Galar.png"
                    .lpHeight = "1.7 m"
                    .lpWeight = "50.9 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[格鬥]+[飛行]"
                    .lpAbility1 = 128
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "由於羽毛相擦時會發出像電流般的劈哩啪啦聲，因此一直被稱為閃電鳥。擁有能夠一腳踢毀砂石車的強勁腳力。據說能以時速３００公里在山中奔跑。"
                    .lpImagePath = "/MultiStatesImages/145/Galar.png"
                    .lpHeight = "1.6 m"
                    .lpWeight = "58.2 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[惡]+[飛行]"
                    .lpAbility1 = 201
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "釋放著像火焰般燃起的邪惡氣場。這樣的外觀讓牠得到了火焰鳥之名。如果被牠烈火般的邪惡氣場掃到，就會精疲力竭，鬥志燒盡只剩下雪白的灰。"
                    .lpImagePath = "/MultiStatesImages/146/Galar.png"
                    .lpHeight = "2.0 m"
                    .lpWeight = "66.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 80
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.3 m"
                    .lpWeight = "127.0 kg"
                    .lpType = "[超能力]+[格鬥]"
                    .lpImagePath = "/MultiStatesImages/150/MegaX.png"
                    .lpUniqueDescription = "精神力量增強了牠身上的肌肉。牠的握力強達１噸，100公尺的距離只要２秒就能跑完。"
                    With .lpBaseStatsValues
                        .HP = 106
                        .ATTACK = 190
                        .DEFEND = 100
                        .SPATTACK = 154
                        .SPDEFEND = 100
                        .SPEED = 130
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 15
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[超能力]"
                    .lpHeight = "1.5 m"
                    .lpWeight = "33.0 kg"
                    .lpImagePath = "/MultiStatesImages/150/MegaY.png"
                    .lpUniqueDescription = "雖然身體變小，力量卻大到難以估計。只要稍微使出一些念力就能將高樓大廈化成灰燼。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("洗翠的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[火]+[幽靈]"
                    .lpAbility1 = 66
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 119
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "據考察，牠是受到聳立於洗翠中心的靈山所發之氣的影響，才形成了現在的模樣。據說會用自己的火焰淨化並超渡無處可去的靈魂。"
                    .lpImagePath = "/MultiStatesImages/157/Hisui.png"
                    .lpHeight = "1.6 m"
                    .lpWeight = "69.8 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 104
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[電]+[龍]"
                    .lpHeight = "1.4 m"
                    .lpWeight = "61.5 kg"
                    .lpImagePath = "/MultiStatesImages/181/Mega.png"
                    .lpUniqueDescription = "超級進化帶來的過剩能量刺激了牠的基因，使得原本已經脫落的體毛重新長了出來。龐大的能量激烈地刺激細胞。沉睡在體內的龍血似乎因此而覺醒了。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("帕底亞的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[毒]+[地面]"
                    .lpAbility1 = 38
                    .lpAbility2 = 11
                    .lpAbilityHidden = 109
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "因搶輸地盤而到陸地上生活，久而久之變成了是用帶毒的黏膜來保護身體。由於單獨行動很危險，因此在沼地裡行走時會３、４隻排成一列來彼此扶持。"
                    .lpImagePath = "/MultiStatesImages/194/Paldea.png"
                    .lpHeight = "0.4 m"
                    .lpWeight = "11.0 kg"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .lpType = "[毒]+[超能力]"
                    .lpAbility1 = 261
                    .lpAbility2 = 20
                    .lpAbilityHidden = 144
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "受到進化的衝擊和毒素的影響，大舌貝的智力飆升到了可以控制呆呆王的程度。會一邊吟唱詭怪的咒語，一邊混合吃進的東西和體內的毒素來製造可疑的藥。"
                    .lpImagePath = "/MultiStatesImages/194/Paldea.png"
                    .lpHeight = "1.8 m"
                    .lpWeight = "79.5 kg"
                    With .lpBaseStatsValues
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
                With States
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
                UniversalLoopCounter = 0
                For UniversalLoopCounter = 0 To 27
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "026"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "0.5 m"
                        .lpWeight = "5.0 kg"
                        .lpType = "[超能]"
                        .lpImagePath = "/MultiStatesImages/201/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 159
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[鋼]+[地面]"
                    .lpHeight = "10.5 m"
                    .lpWeight = "740.0 kg"
                    .lpImagePath = "/MultiStatesImages/208/Mega.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("第七世代之前的種族值")
                    .Add("洗翠的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 38
                    .lpAbility2 = 33
                    .lpAbilityHidden = 22
                    .lpType = "[水]+[毒]"
                    .lpHeight = "0.5 m"
                    .lpWeight = "3.9 kg"
                    .lpImagePath = "/Pokemons/211.png"
                    .lpUniqueDescription = ""
                    With .lpBaseStatsValues
                        .HP = 65
                        .ATTACK = 95
                        .DEFEND = 75
                        .SPATTACK = 55
                        .SPDEFEND = 55
                        .SPEED = 85
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 38
                    .lpAbility2 = 33
                    .lpAbilityHidden = 22
                    .lpType = "[惡]+[毒]"
                    .lpHeight = "0.5 m"
                    .lpWeight = "3.9 kg"
                    .lpImagePath = "/MultiStatesImages/211/Hisui.png"
                    .lpUniqueDescription = "會用針散布毒素的棘手傢伙，因而受到漁民們的厭惡。棲息在其他地區的千針魚則是呈現著不同的姿態。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 101
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[蟲]+[鋼]"
                    .lpHeight = "2.0 m"
                    .lpWeight = "125.0 kg"
                    .lpImagePath = "/MultiStatesImages/212/Mega.png"
                    .lpUniqueDescription = ""
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 92
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[蟲]+[格鬥]"
                    .lpHeight = "1.7 m"
                    .lpWeight = "62.5 kg"
                    .lpImagePath = "/MultiStatesImages/214/Mega.png"
                    .lpUniqueDescription = "會用２隻角夾住東西舉起來。牠甚至能舉起比自己體重重５００倍的重量。在驚人能量的洗禮下變得更健壯。在超級進化結束後，牠會受強烈的肌肉酸痛所苦。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("洗翠的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 39
                    .lpAbility2 = 51
                    .lpAbilityHidden = 124
                    .lpType = "[格鬥]+[毒]"
                    .lpHeight = "0.5 m"
                    .lpWeight = "3.9 kg"
                    .lpImagePath = "/MultiStatesImages/215/Hisui.png"
                    .lpUniqueDescription = "強健的爪子形狀有助於在斷崖絕壁上行動自如。爪子尖端滴出的毒液會在捉住獵物時侵襲其神經。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("第七世代之前的種族值")
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 55
                    .lpAbility2 = 30
                    .lpAbilityHidden = 144
                    .lpType = "[水]+[岩石]"
                    .lpHeight = "0.6 m"
                    .lpWeight = "5.0 kg"
                    .lpImagePath = "/Pokemons/222.png"
                    .lpUniqueDescription = ""
                    With .lpBaseStatsValues
                        .HP = 55
                        .ATTACK = 55
                        .DEFEND = 85
                        .SPATTACK = 65
                        .SPDEFEND = 85
                        .SPEED = 35
                        .TOTAL = .ATTACK + .DEFEND + .HP + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 133
                    .lpAbility2 = "---"
                    .lpAbilityHidden = 130
                    .lpType = "[幽靈]"
                    .lpHeight = "0.6 m"
                    .lpWeight = "0.5 kg"
                    .lpImagePath = "/MultiStatesImages/222/Galar.png"
                    .lpUniqueDescription = "常出現在從前曾是大海的地方。如果不小心錯把牠當成石頭踢，就會遭到牠的詛咒。牠是因急遽環境變化而死去的遠古太陽珊瑚。會用珊瑚枝吸取人的精氣。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("第七世代之前的種族值")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 33
                    .lpAbility2 = 11
                    .lpAbilityHidden = 41
                    .lpType = "[水]+[飛行]"
                    .lpHeight = "2.1 m"
                    .lpWeight = "220.0 kg"
                    .lpImagePath = "/Pokemons/226.png"
                    .lpUniqueDescription = ""
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 94
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[惡]+[火]"
                    .lpHeight = "1.9 m"
                    .lpWeight = "49.5 kg"
                    .lpImagePath = "/MultiStatesImages/229/Mega.png"
                    .lpUniqueDescription = "在黑魯加自己都吃不消的高溫下，牠的紅色爪子和尾巴前端已經開始融化了。全身因超級進化而發熱。能吐出猛烈的火焰，把對手燒成焦炭。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 45
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.5 m"
                    .lpWeight = "255.0 kg"
                    .lpType = "[岩石]+[惡]"
                    .lpImagePath = "/MultiStatesImages/248/Mega.png"
                    .lpUniqueDescription = "體內注入了驚人的能量，使得牠的背部裂開，只剩下破壞的本能驅使著牠行動。就連牠聽不聽得見訓練家的命令都不清楚。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 31
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[草]+[龍]"
                    .lpHeight = "1.9 m"
                    .lpWeight = "55.2 kg"
                    .lpImagePath = "/MultiStatesImages/254/Mega.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 3
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[火]+[格鬥]"
                    .lpHeight = "1.9 m"
                    .lpWeight = "52.0 kg"
                    .lpImagePath = "/MultiStatesImages/257/Mega.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = 33
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpType = "[水]+[格鬥]"
                    .lpHeight = "1.9 m"
                    .lpWeight = "102.0 kg"
                    .lpImagePath = "/MultiStatesImages/260/Mega.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 53
                    .lpAbility2 = 82
                    .lpAbilityHidden = 95
                    .lpType = "[惡]+[一般]"
                    .lpHeight = "0.4 m"
                    .lpWeight = "17.5 kg"
                    .lpImagePath = "/MultiStatesImages/263/Galar.png"
                    .lpUniqueDescription = "一直在奔跑，永遠靜不下來。如果發現了其他的寶可夢，就會故意撞上去挑起事端。這似乎是蛇紋熊最古老的樣子。會之字形亂走，把周圍弄得一團糟。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("伽勒爾的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpAbility1 = 53
                    .lpAbility2 = 82
                    .lpAbilityHidden = 95
                    .lpType = "[惡]+[一般]"
                    .lpHeight = "0.5 m"
                    .lpWeight = "32.5 kg"
                    .lpImagePath = "/MultiStatesImages/264/Galar.png"
                    .lpUniqueDescription = "會用長舌頭挑釁獵物。一旦獵物被自己激怒，便會猛烈地衝撞上去。有著十分好戰的性情。即使是比自己強的對手也會魯莽地發起挑戰。"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 302
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 303
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 306
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 308
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 310
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 319
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 323
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 334
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 351
                With States
                    .Add("太陽的樣子")
                    .Add("雨水的樣子")
                    .Add("雪雲的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "059"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.8 kg"
                    .lpType = "[火]"
                    .lpImagePath = "/MultiStatesImages/351/1.png"
                    With .lpBaseStatsValues
                        .HP = 70
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 70
                        .SPDEFEND = 70
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "059"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.8 kg"
                    .lpType = "[水]"
                    .lpImagePath = "/MultiStatesImages/351/2.png"
                    With .lpBaseStatsValues
                        .HP = 70
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 70
                        .SPDEFEND = 70
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "059"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.8 kg"
                    .lpType = "[冰]"
                    .lpImagePath = "/MultiStatesImages/351/2.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 359
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 362
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 373
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 376
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 380
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 381
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 382
                With States
                    .Add("原始回歸型態")
                End With
                'Specific info done in libPokemon
            Case 383
                With States
                    .Add("原始回歸型態")
                End With
                'Specific info done in libPokemon
            Case 384
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 386
                With States
                    .Add("普通型態")
                    .Add("攻擊型態")
                    .Add("防禦型態")
                    .Add("速度型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "046"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "60.8 kg"
                    .lpType = "[超能]"
                    .lpImagePath = "/MultiStatesImages/386/1.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 150
                        .DEFEND = 50
                        .SPATTACK = 150
                        .SPDEFEND = 50
                        .SPEED = 150
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "046"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "60.8 kg"
                    .lpType = "[超能]"
                    .lpImagePath = "/MultiStatesImages/386/2.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 180
                        .DEFEND = 20
                        .SPATTACK = 180
                        .SPDEFEND = 20
                        .SPEED = 150
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "046"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "60.8 kg"
                    .lpType = "[超能]"
                    .lpImagePath = "/MultiStatesImages/386/3.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 70
                        .DEFEND = 160
                        .SPATTACK = 70
                        .SPDEFEND = 160
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "046"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "60.8 kg"
                    .lpType = "[超能]"
                    .lpImagePath = "/MultiStatesImages/386/4.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("草木蓑衣")
                    .Add("砂土蓑衣")
                    .Add("垃圾蓑衣")
                End With
                For UniversalLoopCounter = 0 To 2
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "061"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "142"
                        .lpHeight = "0.2 m"
                        .lpWeight = "3.4 kg"
                        .lpType = "[蟲]"
                        .lpImagePath = "/MultiStatesImages/412/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 40
                            .ATTACK = 29
                            .DEFEND = 45
                            .SPATTACK = 29
                            .SPDEFEND = 45
                            .SPEED = 36
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 413
                With States
                    .Add("草木蓑衣")
                    .Add("砂土蓑衣")
                    .Add("垃圾蓑衣")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "107"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "142"
                    .lpHeight = "0.5 m"
                    .lpWeight = "6.5 kg"
                    .lpType = "[蟲]+[草]"
                    .lpImagePath = "/MultiStatesImages/413/1.png"
                    With .lpBaseStatsValues
                        .HP = 60
                        .ATTACK = 59
                        .DEFEND = 85
                        .SPATTACK = 79
                        .SPDEFEND = 105
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "107"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "142"
                    .lpHeight = "0.5 m"
                    .lpWeight = "6.5 kg"
                    .lpType = "[蟲]+[地面]"
                    .lpImagePath = "/MultiStatesImages/413/2.png"
                    With .lpBaseStatsValues
                        .HP = 60
                        .ATTACK = 79
                        .DEFEND = 105
                        .SPATTACK = 59
                        .SPDEFEND = 85
                        .SPEED = 36
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "107"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "142"
                    .lpHeight = "0.5 m"
                    .lpWeight = "6.5 kg"
                    .lpType = "[蟲]+[鋼]"
                    .lpImagePath = "/MultiStatesImages/413/3.png"
                    With .lpBaseStatsValues
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
                For UniversalLoopCounter = 0 To 1
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "122"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "0.5 m"
                        .lpWeight = "9.3 kg"
                        .lpType = "[草]"
                        .lpImagePath = "/MultiStatesImages/421/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 70
                            .ATTACK = 60
                            .DEFEND = 70
                            .SPATTACK = 87
                            .SPDEFEND = 78
                            .SPEED = 85
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 422
                With States
                    .Add("西海")
                    .Add("東海")
                End With
                For UniversalLoopCounter = 0 To 1
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "069"
                        .lpAbility2 = "114"
                        .lpAbilityHidden = "159"
                        .lpHeight = "0.3 m"
                        .lpWeight = "6.3 kg"
                        .lpType = "[水]"
                        .lpImagePath = "/MultiStatesImages/422/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 76
                            .ATTACK = 48
                            .DEFEND = 48
                            .SPATTACK = 57
                            .SPDEFEND = 62
                            .SPEED = 34
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 423
                With States
                    .Add("西海")
                    .Add("東海")
                End With
                For UniversalLoopCounter = 0 To 1
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "069"
                        .lpAbility2 = "114"
                        .lpAbilityHidden = "159"
                        .lpHeight = "0.9 m"
                        .lpWeight = "29.9 kg"
                        .lpType = "[水]+[地面]"
                        .lpImagePath = "/MultiStatesImages/423/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 111
                            .ATTACK = 83
                            .DEFEND = 68
                            .SPATTACK = 92
                            .SPDEFEND = 82
                            .SPEED = 39
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 428
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 445
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 448
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 460
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 475
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 479
                With States
                    .Add("加熱洛托姆")
                    .Add("清洗洛托姆")
                    .Add("結冰洛托姆")
                    .Add("旋轉洛托姆")
                    .Add("切割洛托姆")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "026"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.3 kg"
                    .lpType = "[電]+[火]"
                    .lpImagePath = "/MultiStatesImages/479/1.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "026"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.3 kg"
                    .lpType = "[電]+[水]"
                    .lpImagePath = "/MultiStatesImages/479/2.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "026"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.3 kg"
                    .lpType = "[電]+[冰]"
                    .lpImagePath = "/MultiStatesImages/479/3.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "026"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.3 kg"
                    .lpType = "[電]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/479/4.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(4)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "026"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "0.3 kg"
                    .lpType = "[電]+[草]"
                    .lpImagePath = "/MultiStatesImages/479/5.png"
                    With .lpBaseStatsValues
                        .HP = 50
                        .ATTACK = 65
                        .DEFEND = 107
                        .SPATTACK = 105
                        .SPDEFEND = 107
                        .SPEED = 86
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 487
                With States
                    .Add("別種型態")
                    .Add("起源型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "046"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "140"
                    .lpHeight = "4.5 m"
                    .lpWeight = "750.0 kg"
                    .lpType = "[幽靈]+[龍]"
                    .lpImagePath = "/MultiStatesImages/487/1.png"
                    With .lpBaseStatsValues
                        .HP = 150
                        .ATTACK = 100
                        .DEFEND = 120
                        .SPATTACK = 100
                        .SPDEFEND = 120
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "026"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "6.9 m"
                    .lpWeight = "650.0 kg"
                    .lpType = "[幽靈]+[龍]"
                    .lpImagePath = "/MultiStatesImages/487/2.png"
                    With .lpBaseStatsValues
                        .HP = 150
                        .ATTACK = 120
                        .DEFEND = 100
                        .SPATTACK = 120
                        .SPDEFEND = 100
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 492
                With States
                    .Add("陸上型態")
                    .Add("天空型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "030"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.2 m"
                    .lpWeight = "2.1 kg"
                    .lpType = "[草]"
                    .lpImagePath = "/MultiStatesImages/492/1.png"
                    With .lpBaseStatsValues
                        .HP = 100
                        .ATTACK = 100
                        .DEFEND = 100
                        .SPATTACK = 100
                        .SPDEFEND = 100
                        .SPEED = 100
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "032"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.4 m"
                    .lpWeight = "5.2 kg"
                    .lpType = "[草]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/492/2.png"
                    With .lpBaseStatsValues
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
                For UniversalLoopCounter = 0 To 17
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "121"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "3.2 m"
                        .lpWeight = "320.0 kg"
                        .lpType = "[" & PokemonTypes(UniversalLoopCounter) & "]"
                        .lpImagePath = "/MultiStatesImages/493/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                GenerateSpecificStateInfoBWXYSM(lpSelectedPokemonNumber)
        End Select
    End Sub
    Sub GenerateSpecificStateInfoBWXYSM(lpSelectedPokemonNumber As Long)
        Select Case lpSelectedPokemonNumber
            Case 531
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 550
                With States
                    .Add("紅條紋")
                    .Add("藍條紋")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "120"
                    .lpAbility2 = "091"
                    .lpAbilityHidden = "104"
                    .lpHeight = "1.0 m"
                    .lpWeight = "18.0 kg"
                    .lpType = "[水]"
                    .lpImagePath = "/MultiStatesImages/550/1.png"
                    With .lpBaseStatsValues
                        .HP = 70
                        .ATTACK = 92
                        .DEFEND = 65
                        .SPATTACK = 80
                        .SPDEFEND = 55
                        .SPEED = 98
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "069"
                    .lpAbility2 = "091"
                    .lpAbilityHidden = "104"
                    .lpHeight = "1.0 m"
                    .lpWeight = "18.0 kg"
                    .lpType = "[水]"
                    .lpImagePath = "/MultiStatesImages/550/2.png"
                    With .lpBaseStatsValues
                        .HP = 70
                        .ATTACK = 92
                        .DEFEND = 65
                        .SPATTACK = 80
                        .SPDEFEND = 55
                        .SPEED = 98
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 555
                With States
                    .Add("普通模式")
                    .Add("達摩模式")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "125"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "161"
                    .lpHeight = "1.3 m"
                    .lpWeight = "92.9 kg"
                    .lpType = "[火]"
                    .lpImagePath = "/MultiStatesImages/555/1.png"
                    With .lpBaseStatsValues
                        .HP = 105
                        .ATTACK = 140
                        .DEFEND = 55
                        .SPATTACK = 30
                        .SPDEFEND = 55
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "125"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "161"
                    .lpHeight = "1.3 m"
                    .lpWeight = "92.9 kg"
                    .lpType = "[火]+[超能]"
                    .lpImagePath = "/MultiStatesImages/555/2.png"
                    With .lpBaseStatsValues
                        .HP = 105
                        .ATTACK = 30
                        .DEFEND = 105
                        .SPATTACK = 140
                        .SPDEFEND = 105
                        .SPEED = 55
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 585
                With States
                    .Add("春天的樣子")
                    .Add("夏天的樣子")
                    .Add("秋天的樣子")
                    .Add("冬天的樣子")
                End With
                For UniversalLoopCounter = 0 To 3
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "034"
                        .lpAbility2 = "157"
                        .lpAbilityHidden = "032"
                        .lpHeight = "0.6 m"
                        .lpWeight = "19.5 kg"
                        .lpType = "[草]+[一般]"
                        .lpImagePath = "/MultiStatesImages/585/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 60
                            .ATTACK = 60
                            .DEFEND = 50
                            .SPATTACK = 40
                            .SPDEFEND = 50
                            .SPEED = 75
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 586
                With States
                    .Add("春天的樣子")
                    .Add("夏天的樣子")
                    .Add("秋天的樣子")
                    .Add("冬天的樣子")
                End With
                For UniversalLoopCounter = 0 To 3
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "034"
                        .lpAbility2 = "157"
                        .lpAbilityHidden = "032"
                        .lpHeight = "1.9 m"
                        .lpWeight = "92.5 kg"
                        .lpType = "[草]+[一般]"
                        .lpImagePath = "/MultiStatesImages/586/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 80
                            .ATTACK = 100
                            .DEFEND = 70
                            .SPATTACK = 60
                            .SPDEFEND = 70
                            .SPEED = 95
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 641
                With States
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "158"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "128"
                    .lpHeight = "1.5 m"
                    .lpWeight = "63.0 kg"
                    .lpType = "[飛行]"
                    .lpImagePath = "/MultiStatesImages/641/1.png"
                    With .lpBaseStatsValues
                        .HP = 79
                        .ATTACK = 115
                        .DEFEND = 70
                        .SPATTACK = 125
                        .SPDEFEND = 80
                        .SPEED = 111
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "144"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.4 m"
                    .lpWeight = "63.0 kg"
                    .lpType = "[飛行]"
                    .lpImagePath = "/MultiStatesImages/641/2.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "158"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "128"
                    .lpHeight = "1.5 m"
                    .lpWeight = "61.0 kg"
                    .lpType = "[電]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/642/1.png"
                    With .lpBaseStatsValues
                        .HP = 79
                        .ATTACK = 115
                        .DEFEND = 70
                        .SPATTACK = 125
                        .SPDEFEND = 80
                        .SPEED = 111
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "010"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "3.0 m"
                    .lpWeight = "61.0 kg"
                    .lpType = "[電]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/642/2.png"
                    With .lpBaseStatsValues
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
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "163"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "3.2 m"
                    .lpWeight = "330.0 kg"
                    .lpType = "[龍]+[火]"
                    .lpImagePath = "/MultiStatesImages/643/1.png"
                    With .lpBaseStatsValues
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
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "164"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.9 m"
                    .lpWeight = "345.0 kg"
                    .lpType = "[龍]+[電]"
                    .lpImagePath = "/MultiStatesImages/644/1.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("化身型態")
                    .Add("靈獸型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "159"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "125"
                    .lpHeight = "1.5 m"
                    .lpWeight = "68.0 kg"
                    .lpType = "[地面]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/645/1.png"
                    With .lpBaseStatsValues
                        .HP = 89
                        .ATTACK = 125
                        .DEFEND = 90
                        .SPATTACK = 115
                        .SPDEFEND = 80
                        .SPEED = 101
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "022"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.3 m"
                    .lpWeight = "68.0 kg"
                    .lpType = "[地面]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/645/2.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("焰白酋雷姆 (一般模式)")
                    .Add("焰白酋雷姆 (超速驅動模式)")
                    .Add("暗黑酋雷姆 (一般模式)")
                    .Add("暗黑酋雷姆 (超速驅動模式)")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "163"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "3.6 m"
                    .lpWeight = "325.0 kg"
                    .lpType = "[龍]+[冰]"
                    .lpImagePath = "/MultiStatesImages/646/1.png"
                    With .lpBaseStatsValues
                        .HP = 125
                        .ATTACK = 120
                        .DEFEND = 90
                        .SPATTACK = 170
                        .SPDEFEND = 100
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "163"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "3.6 m"
                    .lpWeight = "325.0 kg"
                    .lpType = "[龍]+[冰]"
                    .lpImagePath = "/MultiStatesImages/646/2.png"
                    With .lpBaseStatsValues
                        .HP = 125
                        .ATTACK = 120
                        .DEFEND = 90
                        .SPATTACK = 170
                        .SPDEFEND = 100
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "164"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "3.3 m"
                    .lpWeight = "325.0 kg"
                    .lpType = "[龍]+[冰]"
                    .lpImagePath = "/MultiStatesImages/646/3.png"
                    With .lpBaseStatsValues
                        .HP = 125
                        .ATTACK = 170
                        .DEFEND = 100
                        .SPATTACK = 120
                        .SPDEFEND = 90
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "164"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "3.3 m"
                    .lpWeight = "325.0 kg"
                    .lpType = "[龍]+[冰]"
                    .lpImagePath = "/MultiStatesImages/646/4.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("普通的樣子")
                    .Add("覺悟的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "154"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.4 m"
                    .lpWeight = "48.5 kg"
                    .lpType = "[水]+[格鬥]"
                    .lpImagePath = "/MultiStatesImages/647/1.png"
                    With .lpBaseStatsValues
                        .HP = 91
                        .ATTACK = 72
                        .DEFEND = 90
                        .SPATTACK = 129
                        .SPDEFEND = 90
                        .SPEED = 108
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "154"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.4 m"
                    .lpWeight = "48.5 kg"
                    .lpType = "[水]+[格鬥]"
                    .lpImagePath = "/MultiStatesImages/647/2.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("歌聲型態")
                    .Add("舞步型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "032"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.6 m"
                    .lpWeight = "6.5 kg"
                    .lpType = "[一般]+[超能]"
                    .lpImagePath = "/MultiStatesImages/648/1.png"
                    With .lpBaseStatsValues
                        .HP = 100
                        .ATTACK = 77
                        .DEFEND = 77
                        .SPATTACK = 128
                        .SPDEFEND = 128
                        .SPEED = 90
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "032"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.6 m"
                    .lpWeight = "6.5 kg"
                    .lpType = "[一般]+[格鬥]"
                    .lpImagePath = "/MultiStatesImages/648/2.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("搭載水流卡帶")
                    .Add("搭載閃電卡帶")
                    .Add("搭載火焰卡帶")
                    .Add("搭載冰凍卡帶")
                End With
                For UniversalLoopCounter = 0 To 3
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "088"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "1.5 m"
                        .lpWeight = "82.5 kg"
                        .lpType = "[蟲]+[鋼]"
                        .lpImagePath = "/MultiStatesImages/649/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
                    .Add("小智版甲賀忍蛙")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "067"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "168"
                    .lpHeight = "1.5 m"
                    .lpWeight = "40.0 kg"
                    .lpType = "[水]+[惡]"
                    .lpImagePath = "/MultiStatesImages/658/1.png"
                    With .lpBaseStatsValues
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
                With States
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
                For UniversalLoopCounter = 0 To 19
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "019"
                        .lpAbility2 = "014"
                        .lpAbilityHidden = "132"
                        .lpHeight = "1.2 m"
                        .lpWeight = "17.0 kg"
                        .lpType = "[蟲]+[飛行]"
                        .lpImagePath = "/MultiStatesImages/666/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
                    .Add("紅花")
                    .Add("黃花")
                    .Add("橙花")
                    .Add("藍花")
                    .Add("白花")
                End With
                For UniversalLoopCounter = 0 To 4
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "166"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "180"
                        .lpHeight = "0.1 m"
                        .lpWeight = "0.1 kg"
                        .lpType = "[妖精]"
                        .lpImagePath = "/MultiStatesImages/669/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
                    .Add("紅花")
                    .Add("黃花")
                    .Add("橙花")
                    .Add("藍花")
                    .Add("白花")
                    .Add("永恆之花")
                End With
                For UniversalLoopCounter = 0 To 4
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "166"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "180"
                        .lpHeight = "0.2 m"
                        .lpWeight = "0.9 kg"
                        .lpType = "[妖精]"
                        .lpImagePath = "/MultiStatesImages/670/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With StateInformation(5)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "166"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "180"
                    .lpHeight = "0.2 m"
                    .lpWeight = "0.9 kg"
                    .lpType = "[妖精]"
                    .lpImagePath = "/MultiStatesImages/670/6.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("紅花")
                    .Add("黃花")
                    .Add("橙花")
                    .Add("藍花")
                    .Add("白花")
                End With
                For UniversalLoopCounter = 0 To 4
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "166"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "180"
                        .lpHeight = "1.1 m"
                        .lpWeight = "10.0 kg"
                        .lpType = "[妖精]"
                        .lpImagePath = "/MultiStatesImages/671/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
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
                For UniversalLoopCounter = 0 To 8
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "169"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "1.2 m"
                        .lpWeight = "28.0 kg"
                        .lpType = "[一般]"
                        .lpImagePath = "/MultiStatesImages/676/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
                    .Add("刀劍型態")
                    .Add("盾牌型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "176"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "53.0 kg"
                    .lpType = "[鋼]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/681/1.png"
                    With .lpBaseStatsValues
                        .HP = 60
                        .ATTACK = 150
                        .DEFEND = 50
                        .SPATTACK = 150
                        .SPDEFEND = 50
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "176"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "1.7 m"
                    .lpWeight = "53.0 kg"
                    .lpType = "[鋼]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/681/2.png"
                    With .lpBaseStatsValues
                        .HP = 60
                        .ATTACK = 50
                        .DEFEND = 150
                        .SPATTACK = 50
                        .SPDEFEND = 150
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 710
                With States
                    .Add("普通尺寸")
                    .Add("小尺寸")
                    .Add("大尺寸")
                    .Add("特大尺寸")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "0.3 m"
                    .lpWeight = "3.5 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/710/1.png"
                    With .lpBaseStatsValues
                        .HP = 44
                        .ATTACK = 66
                        .DEFEND = 70
                        .SPATTACK = 44
                        .SPDEFEND = 55
                        .SPEED = 56
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "0.4 m"
                    .lpWeight = "5.0 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/710/2.png"
                    With .lpBaseStatsValues
                        .HP = 49
                        .ATTACK = 66
                        .DEFEND = 70
                        .SPATTACK = 44
                        .SPDEFEND = 55
                        .SPEED = 51
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "0.5 m"
                    .lpWeight = "7.5 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/710/3.png"
                    With .lpBaseStatsValues
                        .HP = 54
                        .ATTACK = 66
                        .DEFEND = 70
                        .SPATTACK = 44
                        .SPDEFEND = 55
                        .SPEED = 46
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "0.8 m"
                    .lpWeight = "15.0 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/710/4.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("普通尺寸")
                    .Add("小尺寸")
                    .Add("大尺寸")
                    .Add("特大尺寸")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "0.7 m"
                    .lpWeight = "9.5 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/711/1.png"
                    With .lpBaseStatsValues
                        .HP = 55
                        .ATTACK = 85
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 99
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "0.9 m"
                    .lpWeight = "12.5 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/711/2.png"
                    With .lpBaseStatsValues
                        .HP = 65
                        .ATTACK = 90
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 84
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "1.1 m"
                    .lpWeight = "14.0 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/711/3.png"
                    With .lpBaseStatsValues
                        .HP = 75
                        .ATTACK = 95
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 69
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "053"
                    .lpAbility2 = "119"
                    .lpAbilityHidden = "015"
                    .lpHeight = "1.7 m"
                    .lpWeight = "39.0 kg"
                    .lpType = "[草]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/711/4.png"
                    With .lpBaseStatsValues
                        .HP = 85
                        .ATTACK = 100
                        .DEFEND = 122
                        .SPATTACK = 58
                        .SPDEFEND = 75
                        .SPEED = 54
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 716
                With States
                    .Add("放鬆模式")
                    .Add("活躍模式")
                End With
                For UniversalLoopCounter = 0 To 1
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "187"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "3.0 m"
                        .lpWeight = "215.0 kg"
                        .lpType = "[妖精]"
                        .lpImagePath = "/MultiStatesImages/716/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 126
                            .ATTACK = 131
                            .DEFEND = 95
                            .SPATTACK = 131
                            .SPDEFEND = 98
                            .SPEED = 99
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 718
                With States
                    .Add("細胞型態")
                    .Add("核心型態")
                    .Add("10% 型態")
                    .Add("50% 型態")
                    .Add("完全體型態")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "基格爾德的最基本形態，沒有自我意識也無法使用招式，平時以隱形狀態分布於各地。"
                    .lpAbility1 = "188"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "211"
                    .lpHeight = "<缺數據>"
                    .lpWeight = "<缺數據>"
                    .lpType = "[龍]+[地面]"
                    .lpImagePath = "/MultiStatesImages/718/1.png"
                    With .lpBaseStatsValues
                        .HP = 0
                        .ATTACK = 0
                        .DEFEND = 0
                        .SPATTACK = 0
                        .SPDEFEND = 0
                        .SPEED = 0
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "基格爾德的首腦，能與細胞進行感應從而召集細胞以及共享細胞的視覺。 "
                    .lpAbility1 = "188"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "211"
                    .lpHeight = "<缺數據>"
                    .lpWeight = "<缺數據>"
                    .lpType = "[龍]+[地面]"
                    .lpImagePath = "/MultiStatesImages/718/2.png"
                    With .lpBaseStatsValues
                        .HP = 0
                        .ATTACK = 0
                        .DEFEND = 0
                        .SPATTACK = 0
                        .SPDEFEND = 0
                        .SPEED = 0
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "用鋒利的牙齒了結敵人。無法一直維持這個身體，一段時間後就會變得七零八落。基格爾德組成分子「細胞」聚集了１０％左右的樣子。會以１００公里的時速在地面奔馳。"
                    .lpAbility1 = "188"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "211"
                    .lpHeight = "1.2 m"
                    .lpWeight = "33.5 kg"
                    .lpType = "[龍]+[地面]"
                    .lpImagePath = "/MultiStatesImages/718/3.png"
                    With .lpBaseStatsValues
                        .HP = 54
                        .ATTACK = 100
                        .DEFEND = 71
                        .SPATTACK = 61
                        .SPDEFEND = 85
                        .SPEED = 115
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "細胞聚集了５０％的樣子。會毫不留情地把敵對者全部消滅。被認為監視著生態系統。有傳言說牠蘊藏著更為強大的力量。"
                    .lpAbility1 = "188"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "211"
                    .lpHeight = "5.0 m"
                    .lpWeight = "305.0 kg"
                    .lpType = "[龍]+[地面]"
                    .lpImagePath = "/MultiStatesImages/718/4.png"
                    With .lpBaseStatsValues
                        .HP = 108
                        .ATTACK = 100
                        .DEFEND = 121
                        .SPATTACK = 81
                        .SPDEFEND = 95
                        .SPEED = 95
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(4)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "１００％的基格爾德的樣子。擁有連哲爾尼亞斯和伊裴爾塔爾都能壓倒的力量。"
                    .lpAbility1 = "211"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "4.5 m"
                    .lpWeight = "610.0 kg"
                    .lpType = "[龍]+[地面]"
                    .lpImagePath = "/MultiStatesImages/718/5.png"
                    With .lpBaseStatsValues
                        .HP = 216
                        .ATTACK = 100
                        .DEFEND = 121
                        .SPATTACK = 91
                        .SPDEFEND = 95
                        .SPEED = 85
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 720
                With States
                    .Add("懲戒胡帕")
                    .Add("解放胡帕")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "170"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.5 m"
                    .lpWeight = "9.0 kg"
                    .lpType = "[超能]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/720/1.png"
                    With .lpBaseStatsValues
                        .HP = 80
                        .ATTACK = 110
                        .DEFEND = 60
                        .SPATTACK = 150
                        .SPDEFEND = 130
                        .SPEED = 70
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = False
                    .lpAbility1 = "170"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "6.5 m"
                    .lpWeight = "490.0 kg"
                    .lpType = "[超能]+[惡]"
                    .lpImagePath = "/MultiStatesImages/720/2.png"
                    With .lpBaseStatsValues
                        .HP = 80
                        .ATTACK = 160
                        .DEFEND = 60
                        .SPATTACK = 170
                        .SPDEFEND = 130
                        .SPEED = 80
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
            Case 741
                With States
                    .Add("熱辣熱辣風格")
                    .Add("啪滋啪滋風格")
                    .Add("呼拉呼啦風格")
                    .Add("輕盈輕盈風格")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "拍打翅膀生火。一邊踩著華麗的步伐，一邊灑下猛烈的火焰。吸食了朱紅色花蜜的花舞鳥。以熱情的舞步將敵人的身心全部燃燒殆盡。"
                    .lpAbility1 = "216"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.6 m"
                    .lpWeight = "3.4 kg"
                    .lpType = "[火]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/741/1.png"
                    With .lpBaseStatsValues
                        .HP = 75
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 98
                        .SPDEFEND = 70
                        .SPEED = 93
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "吸食了金黃色花蜜的花舞鳥。以輕快歡樂的舞蹈讓敵人的身心都徹底得到釋放。摩擦羽毛生電。像跳舞一樣接近敵人，施展出電擊拳。"
                    .lpAbility1 = "216"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.6 m"
                    .lpWeight = "3.4 kg"
                    .lpType = "[電]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/741/2.png"
                    With .lpBaseStatsValues
                        .HP = 75
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 98
                        .SPDEFEND = 70
                        .SPEED = 93
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "搖搖擺擺地放鬆自己。之後瞄準敵人將提升的精神力量發射出去。吸食了桃粉色花蜜的花舞鳥。輕柔地擺動腰部，讓敵人的身心都溶化。"
                    .lpAbility1 = "216"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.6 m"
                    .lpWeight = "3.4 kg"
                    .lpType = "[超能]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/741/3.png"
                    With .lpBaseStatsValues
                        .HP = 75
                        .ATTACK = 70
                        .DEFEND = 70
                        .SPATTACK = 98
                        .SPDEFEND = 70
                        .SPEED = 93
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "吸食了蘭紫色花蜜的花舞鳥。用優雅華麗的舞蹈將敵人的身心都誘惑到異世界。用充滿幻想的舞蹈召喚死者。借助這股怨念的力量對敵人施加詛咒。"
                    .lpAbility1 = "216"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.6 m"
                    .lpWeight = "3.4 kg"
                    .lpType = "[幽靈]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/741/4.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("白晝的樣子")
                    .Add("黑夜的樣子")
                    .Add("黃昏的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "快速移動迷惑敵人。除了爪子和牙齒之外，鬃毛裡的尖銳岩石也是武器之一。從小開始好好培育的話，會成為絕不背叛訓練家，值得信賴的好夥伴。鬃毛裡的岩石像刀子一樣鋒利。會對獵物窮追不捨，等獵物筋疲力盡時再給予致命一擊。鬃毛裡的岩石比刀子還要鋒利。掉落的碎片會被人當成護身符好好收藏著。"
                    .lpAbility1 = "051"
                    .lpAbility2 = "146"
                    .lpAbilityHidden = "080"
                    .lpHeight = "0.8 m"
                    .lpWeight = "25.0 kg"
                    .lpType = "[岩石]"
                    .lpImagePath = "/MultiStatesImages/745/1.png"
                    With .lpBaseStatsValues
                        .HP = 75
                        .ATTACK = 115
                        .DEFEND = 65
                        .SPATTACK = 55
                        .SPDEFEND = 65
                        .SPEED = 112
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "面前的對手越是強大，越是熱血沸騰。為了取勝，會奮不顧身發動襲擊。挑釁敵人來襲擊自己。在敵人砍中自己的同時用頭錘攻擊，再用鬃毛裡的岩石將骨頭壓碎。會毫不猶豫地忽視自己不喜歡的命令。只要能解決對手，就算自己受傷也完全不在意。不集結成群，而是單獨生活。只會聽命於能夠引出自己力量的訓練家。"
                    .lpAbility1 = "051"
                    .lpAbility2 = "072"
                    .lpAbilityHidden = "099"
                    .lpHeight = "1.1 m"
                    .lpWeight = "25.0 kg"
                    .lpType = "[岩石]"
                    .lpImagePath = "/MultiStatesImages/745/2.png"
                    With .lpBaseStatsValues
                        .HP = 85
                        .ATTACK = 115
                        .DEFEND = 75
                        .SPATTACK = 55
                        .SPDEFEND = 75
                        .SPEED = 82
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "在夕陽照射下完成特殊進化的鬃岩狼人。舉止沉穩，但蘊藏著強烈的鬥志。在黃昏時進化的結果，不知為何變成這種奇特的樣子。在阿羅拉地區是很難得一見的。"
                    .lpAbility1 = "181"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.8 m"
                    .lpWeight = "25.0 kg"
                    .lpType = "[岩石]"
                    .lpImagePath = "/MultiStatesImages/745/3.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("單獨的樣子")
                    .Add("魚群的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "一旦陷入危機，眼睛就會變得濕潤並發光。和被光亮召集來的夥伴們一起對抗敵人。牠非常弱小，又非常美味，所以總是成為被攻擊的目標，不過若欺負牠，只會吃苦頭哦。"
                    .lpAbility1 = "208"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.2 m"
                    .lpWeight = "0.3 kg"
                    .lpType = "[水]"
                    .lpImagePath = "/MultiStatesImages/746/1.png"
                    With .lpBaseStatsValues
                        .HP = 45
                        .ATTACK = 20
                        .DEFEND = 20
                        .SPATTACK = 25
                        .SPDEFEND = 25
                        .SPEED = 40
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "弱小的弱丁魚們聚在一起，把力量集合起來。擁有足以被稱為海中魔物的可怕力量。這個樣子連暴鯉龍看了都會逃跑。齊心協力發射出的水槍擁有超越水炮的威力。"
                    .lpAbility1 = "208"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "8.2 m"
                    .lpWeight = "78.6 kg"
                    .lpType = "[水]"
                    .lpImagePath = "/MultiStatesImages/746/2.png"
                    With .lpBaseStatsValues
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
                With States
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
                For UniversalLoopCounter = 0 To 17
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "225"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "2.3 m"
                        .lpWeight = "100.5 kg"
                        .lpType = "[" & PokemonTypes(UniversalLoopCounter) & "]"
                        .lpImagePath = "/MultiStatesImages/773/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
                    .Add("流星的樣子")
                    .Add("紅色核心")
                    .Add("橙色核心")
                    .Add("黃色核心")
                    .Add("綠色核心")
                    .Add("淺藍色核心")
                    .Add("藍色核心")
                    .Add("紫色核心")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "原本棲息在臭氧層，身體的外殼變重後，就會向著地面落下。若受到強烈的衝擊，外殼就會剝落。是奈米粒子突變而誕生的寶可夢。"
                    .lpAbility1 = "197"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.3 m"
                    .lpWeight = "40.0 kg"
                    .lpType = "[岩石]+[飛行]"
                    .lpImagePath = "/MultiStatesImages/774/1.png"
                    With .lpBaseStatsValues
                        .HP = 60
                        .ATTACK = 60
                        .DEFEND = 100
                        .SPATTACK = 60
                        .SPDEFEND = 100
                        .SPEED = 60
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                For UniversalLoopCounter = 1 To 7
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = True
                        .lpUniqueDescription = "會吃下大氣中的塵埃，並依照吃下的塵埃成分來決定核心的色調。核心如果一直處在外露狀態，就會很快消散。聽說趕緊放進精靈球就能讓牠活下來。"
                        .lpAbility1 = "197"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "0.3 m"
                        .lpWeight = "0.3 kg"
                        .lpType = "[岩石]+[飛行]"
                        .lpImagePath = "/MultiStatesImages/774/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
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
                With States
                    .Add("化形的樣子")
                    .Add("現形的樣子")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "真面目是個謎。某個看過破布裡面的學者因為太可怕而被活活嚇死了。用破破爛爛的布隱藏起可怕的模樣，接近人類和其他寶可夢的寂寞傢伙。"
                    .lpAbility1 = "209"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.2 m"
                    .lpWeight = "0.7 kg"
                    .lpType = "[幽靈]+[妖精]"
                    .lpImagePath = "/MultiStatesImages/778/1.png"
                    With .lpBaseStatsValues
                        .HP = 55
                        .ATTACK = 90
                        .DEFEND = 80
                        .SPATTACK = 50
                        .SPDEFEND = 105
                        .SPEED = 96
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "特地喬裝打扮，脖子卻折斷了。布裡面的牠應該沒事，但感覺牠很傷心。被攻擊後脖子折斷，或是身上披的布破了的話，本體就會熬夜進行修補。"
                    .lpAbility1 = "209"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "0.2 m"
                    .lpWeight = "0.7 kg"
                    .lpType = "[幽靈]+[妖精]"
                    .lpImagePath = "/MultiStatesImages/778/2.png"
                    With .lpBaseStatsValues
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
                With States
                    .Add("一般狀態")
                    .Add("旭日狀態")
                End With
                For UniversalLoopCounter = 0 To 1
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "230"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "3.4 m"
                        .lpWeight = "230.0 kg"
                        .lpType = "[超能]+[鋼]"
                        .lpImagePath = "/MultiStatesImages/791/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 137
                            .ATTACK = 137
                            .DEFEND = 107
                            .SPATTACK = 113
                            .SPDEFEND = 89
                            .SPEED = 97
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 792
                With States
                    .Add("一般狀態")
                    .Add("滿月狀態")
                End With
                For UniversalLoopCounter = 0 To 1
                    With StateInformation(UniversalLoopCounter)
                        .IsUniqueDescriptionAvailable = False
                        .lpAbility1 = "231"
                        .lpAbility2 = "---"
                        .lpAbilityHidden = "---"
                        .lpHeight = "4.0 m"
                        .lpWeight = "120.0 kg"
                        .lpType = "[超能]+[幽靈]"
                        .lpImagePath = "/MultiStatesImages/792/" & (UniversalLoopCounter + 1).ToString & ".png"
                        With .lpBaseStatsValues
                            .HP = 137
                            .ATTACK = 113
                            .DEFEND = 89
                            .SPATTACK = 137
                            .SPDEFEND = 107
                            .SPEED = 97
                            .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                        End With
                    End With
                Next
            Case 800
                With States
                    .Add("一般型態")
                    .Add("黃昏之鬃 (日蝕)")
                    .Add("拂曉之翼 (月蝕)")
                    .Add("究極奈克洛茲瑪")
                End With
                With StateInformation(0)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "好像一直都沉睡在地底下。被認為是在太古時代從另一個世界來到此地，是種類似ＵＢ的生物。 光似乎是牠的能量來源。毫無節制地不停發射雷射，性格非常凶暴。 為了尋求作為能量的光而發狂的牠看起來有些痛苦。似乎是來自於其他世界。光是牠的能量來源。如果一段時間沒吃到光，雜質就會逐漸累積，使得牠身體發黑且變得無法動彈。"
                    .lpAbility1 = "232"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.4 m"
                    .lpWeight = "230.0 kg"
                    .lpType = "[超能]"
                    .lpImagePath = "/MultiStatesImages/800/1.png"
                    With .lpBaseStatsValues
                        .HP = 97
                        .ATTACK = 107
                        .DEFEND = 101
                        .SPATTACK = 127
                        .SPDEFEND = 89
                        .SPEED = 79
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(1)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "不斷吞食著索爾迦雷歐的光。會撲向敵人，用背上和四肢的爪子將對手斬斷。吸收了壓倒性的光能量之後變化而成的樣子。能從全身發射雷射光。"
                    .lpAbility1 = "232"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "3.8 m"
                    .lpWeight = "460.0 kg"
                    .lpType = "[超能]+[鋼]"
                    .lpImagePath = "/MultiStatesImages/800/2.png"
                    With .lpBaseStatsValues
                        .HP = 97
                        .ATTACK = 157
                        .DEFEND = 127
                        .SPATTACK = 113
                        .SPDEFEND = 109
                        .SPEED = 77
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(2)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "不斷吞噬露奈雅拉的光的樣子。會用巨大的爪子抓住敵人，然後用力將對手撕裂。露奈雅拉已經沒有自我意識。在奈克洛茲瑪的支配之下，不斷釋放出全部的能量。"
                    .lpAbility1 = "232"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "4.2 m"
                    .lpWeight = "350.0 kg"
                    .lpType = "[超能]+[幽靈]"
                    .lpImagePath = "/MultiStatesImages/800/3.png"
                    With .lpBaseStatsValues
                        .HP = 97
                        .ATTACK = 113
                        .DEFEND = 109
                        .SPATTACK = 157
                        .SPDEFEND = 127
                        .SPEED = 77
                        .TOTAL = .HP + .ATTACK + .DEFEND + .SPATTACK + .SPDEFEND + .SPEED
                    End With
                End With
                With StateInformation(3)
                    .IsUniqueDescriptionAvailable = True
                    .lpUniqueDescription = "吸收了壓倒性的光能量之後變化而成的樣子。能從全身發射雷射光。全身放出的光會對生物和自然界產生作用，造成各式各樣的影響。"
                    .lpAbility1 = "233"
                    .lpAbility2 = "---"
                    .lpAbilityHidden = "---"
                    .lpHeight = "2.4 m"
                    .lpWeight = "230.0 kg"
                    .lpType = "[超能]+[龍]"
                    .lpImagePath = "/MultiStatesImages/800/4.png"
                    With .lpBaseStatsValues
                        .HP = 97
                        .ATTACK = 167
                        .DEFEND = 97
                        .SPATTACK = 167
                        .SPDEFEND = 97
                        .SPEED = 129
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
            .Add("超能")
            .Add("冰")
            .Add("龍")
            .Add("惡")
            .Add("妖精")
        End With
    End Sub
End Module
