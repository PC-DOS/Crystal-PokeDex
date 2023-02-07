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
                End With
                'Specific info done in libPokemon
            Case 6
                With States
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                End With
                'Specific info done in libPokemon
            Case 9
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 15
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 18
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
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
            Case 65
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
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
            Case 80
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
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
                End With
                'Specific info done in libPokemon
            Case 103
                With States
                    .Add("阿羅拉的樣子")
                End With
                With StateInformation(0)
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
            Case 115
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 127
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 130
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 142
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 150
                With States
                    .Add("超進化 - X")
                    .Add("超進化 - Y")
                End With
                'Specific info done in libPokemon
            Case 181
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
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
                'Specific info done in libPokemon
            Case 212
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 214
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 229
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 248
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 254
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 257
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
            Case 260
                With States
                    .Add("超進化")
                End With
                'Specific info done in libPokemon
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
