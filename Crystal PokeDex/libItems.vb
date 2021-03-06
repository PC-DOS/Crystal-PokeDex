Module libItems
    Public lpSelectedItemNumber As Integer
    Public ItemNamesCHT As New List(Of String)
    Public ItemNamesENG As New List(Of String)
    Public ItemNamesJPN As New List(Of String)
    Public ItemDescriptions As New List(Of String)
    Public Sub InitializeItemInformation()
        With ItemNamesCHT
            .Clear()
            .Add("除蟲噴霧器")
            .Add("白銀噴霧器")
            .Add("黃金噴霧器")
            .Add("脫離洞穴的繩子")
            .Add("黑色哨子")
            .Add("白色哨子")
            .Add("淺灘海鹽")
            .Add("淺灘貝殼")
            .Add("紅色碎片")
            .Add("藍色碎片")
            .Add("黃色碎片")
            .Add("綠色碎片")
            .Add("學習裝置")
            .Add("木箱")
            .Add("桐木箱")
            .Add("美味尾巴")
            .Add("甜蜜")
            .Add("穩穩肥")
            .Add("溼溼肥")
            .Add("長長肥")
            .Add("黏黏肥")
            .Add("楔石")
            .Add("釋出之玉")
            .Add("荒誕肥")
            .Add("勁勁肥")
            .Add("碩果肥")
            .Add("驚訝肥")
            .Add("特價券")
            .Add("神奇擺設")
            .Add("貝之化石")
            .Add("龜殼化石")
            .Add("秘密琥珀")
            .Add("樹根化石")
            .Add("尖爪化石")
            .Add("盾牌化石")
            .Add("頭蓋化石")
            .Add("蓋狀化石")
            .Add("羽之化石")
            .Add("顎之化石")
            .Add("鰭之化石")
            .Add("太陽之石")
            .Add("月之石")
            .Add("火之石")
            .Add("雷之石")
            .Add("水之石")
            .Add("葉之石")
            .Add("光之石")
            .Add("闇之石")
            .Add("覺醒之石")
            .Add("小蘑菇")
            .Add("大蘑菇")
            .Add("珍珠")
            .Add("大珍珠")
            .Add("星星的沙子")
            .Add("星星的碎片")
            .Add("金葉")
            .Add("銀葉")
            .Add("磚瓦碎片")
            .Add("金色珠")
            .Add("心之鱗片")
            .Add("貴重骨頭")
            .Add("美麗羽毛")
            .Add("芳香蘑菇")
            .Add("大金色珠")
            .Add("珍珠團子")
            .Add("彗星碎片")
            .Add("古代銅幣")
            .Add("古代銀幣")
            .Add("古代金幣")
            .Add("古代之壺")
            .Add("古代手鐲")
            .Add("古代石像")
            .Add("古代王冠")
        End With
        With ItemNamesENG
            .Clear()
            .Add("Repel")
            .Add("Super Repel")
            .Add("Max Repel")
            .Add("Escape Rope")
            .Add("Black Flute")
            .Add("White Flute")
            .Add("Shoal Salt")
            .Add("Shoal Shell")
            .Add("Red Shard")
            .Add("Blue Shard")
            .Add("Yellow Shard")
            .Add("Green Shard")
            .Add("Exp. Share")
            .Add("Normal Box")
            .Add("Gorgeous Box")
            .Add("Slowpoketail")
            .Add("Honey")
            .Add("Growth Mulch")
            .Add("Damp Mulch")
            .Add("Stable Mulch")
            .Add("Gooey Mulch")
            .Add("Odd Keystone")
            .Add("Pass Orb")
            .Add("Amaze Mulch")
            .Add("Boost Mulch")
            .Add("Rich Mulch")
            .Add("Surprise Mulch")
            .Add("Discount Coupon")
            .Add("Strange Souvenir")
            .Add("Helix Fossil")
            .Add("Dome Fossil")
            .Add("Old Amber")
            .Add("Root Fossil")
            .Add("Claw Fossil")
            .Add("Armor Fossil")
            .Add("Skull Fossil")
            .Add("Cover Fossil")
            .Add("Plume Fossil")
            .Add("Jaw Fossil")
            .Add("Sail Fossil")
            .Add("Sun Stone")
            .Add("Moon Stone")
            .Add("Fire Stone")
            .Add("Thunderstone")
            .Add("Water Stone")
            .Add("Leaf Stone")
            .Add("Shiny Stone")
            .Add("Dusk Stone")
            .Add("Dawn Stone")
            .Add("Tiny mushroom")
            .Add("Big Mushroom")
            .Add("Pearl")
            .Add("Big Pearl")
            .Add("Stardust")
            .Add("Star Piece")
            .Add("Gold Leaf")
            .Add("Silver Leaf")
            .Add("Brick Piece")
            .Add("Nugget")
            .Add("Heart Scale")
            .Add("Rare Bone")
            .Add("Pretty Wing")
            .Add("BalmMushroom")
            .Add("Big Nugget")
            .Add("Pearl String")
            .Add("Comet Shard")
            .Add("Relic Copper")
            .Add("Relic Silver")
            .Add("Relic Gold")
            .Add("Relic Vase")
            .Add("Relic Band")
            .Add("Relic Statue")
            .Add("Relic Crown")
        End With
        With ItemNamesJPN
            .Clear()
            .Add("むしよけスプレー")
            .Add("シルバースプレー")
            .Add("ゴールドスプレー")
            .Add("あなぬけのヒモ")
            .Add("くろいビードロ")
            .Add("しろいビードロ")
            .Add("あさせのしお")
            .Add("あさせのかいがら")
            .Add("あかいかけら")
            .Add("あおいかけら")
            .Add("きいろいかけら")
            .Add("みどりのかけら")
            .Add("がくしゅうそうち")
            .Add("きのはこ")
            .Add("きりのはこ")
            .Add("おいしいシッポ")
            .Add("あまいミツ")
            .Add("すくすくこやし")
            .Add("じめじめこやし")
            .Add("ながながこやし")
            .Add("ねばねばこやし")
            .Add("かなめいし")
            .Add("デルダマ")
            .Add("とんでもこやし")
            .Add("ぐんぐんこやし")
            .Add("たわわこやし")
            .Add("びっくりこやし")
            .Add("バーゲンチケット")
            .Add("ふしぎなおきもの")
            .Add("かいのカセキ")
            .Add("こうらのカセキ")
            .Add("ひみつのコハク")
            .Add("ねっこのカセキ")
            .Add("ツメのカセキ")
            .Add("たてのカセキ")
            .Add("ずがいのカセキ")
            .Add("ふたのカセキ")
            .Add("はねのカセキ")
            .Add("アゴのカセキ")
            .Add("ヒレのカセキ")
            .Add("たいようのいし")
            .Add("つきのいし")
            .Add("ほのおのいし")
            .Add("かみなりのいし")
            .Add("みずのいし")
            .Add("リーフのいし")
            .Add("ひかりのいし")
            .Add("やみのいし")
            .Add("めざめいし")
            .Add("ちいさなキノコ")
            .Add("おおきなキノコ")
            .Add("しんじゅ")
            .Add("おおきなしんじゅ")
            .Add("ほしのすな")
            .Add("ほしのかけら")
            .Add("きんのはっぱ")
            .Add("ぎんのはっぱ")
            .Add("かわらのかけら")
            .Add("きんのたま")
            .Add("ハートのウロコ")
            .Add("きちょうなホネ")
            .Add("きれいなハネ")
            .Add("かおるキノコ")
            .Add("でかいきんのたま")
            .Add("おだんごしんじゅ")
            .Add("すいせいのかけら")
            .Add("こだいのどうか")
            .Add("こだいのぎんか")
            .Add("こだいのきんか")
            .Add("こだいのツボ")
            .Add("こだいのうでわ")
            .Add("こだいのせきそう")
            .Add("こだいのおうかん")
        End With
        With ItemDescriptions
            .Clear()
            .Add("一種使用後100步之內等級低的野生神奇寶貝不會出現的道具。")
            .Add("一種使用後200步之內等級低的野生神奇寶貝不會出現的道具。")
            .Add("一種使用後250步之內等級低的野生神奇寶貝不會出現的道具。")
            .Add("一根長而結實的繩子，用它可以瞬間逃出迷宮或洞窟。")
            .Add("一個由黑色玻璃製成的哨子，用它更容易遇到強大的野生神奇寶貝。")
            .Add("一個由白色玻璃製成的哨子，用它能喚醒處於睡眠狀態的神奇寶貝。")
            .Add("在淺灘洞穴深處可以找到的純淨海鹽。")
            .Add("在淺灘洞穴深處可以找到的美麗海貝。")
            .Add("一小片紅色碎片，似乎是某種遠古器具殘片的一部分。")
            .Add("一小片藍色碎片，似乎是某種遠古器具殘片的一部分。")
            .Add("一小片黃色碎片，似乎是某種遠古器具殘片的一部分。")
            .Add("一小片綠色碎片，似乎是某種遠古器具殘片的一部分。")
            .Add("打開這個特殊的裝置後隊伍裡的神奇寶貝都可以得到在對戰中獲得的經驗值。")
            .Add("打開它後看看它的裡面。")
            .Add("打開它後看看它的裡面。")
            .Add("某物的尾巴，美味非凡，能夠以高昂的價格出售。")
            .Add("帶著濃郁香氣的甜蜜，它可以吸引在特殊的樹木和草叢以及洞窟裡的野生神奇寶貝。")
            .Add("向種了樹果的土地施的肥料。")
            .Add("向種了樹果的土地施的肥料。")
            .Add("向種了樹果的土地施的肥料。")
            .Add("向種了樹果的土地施的肥料。")
            .Add("一個有生命跡象的道具，沒有的話石塔就會崩塌的重要的石頭，有時可以從石頭中聽到聲音。")
            .Add("一顆注入了神秘的合眾能量的寶玉，在光輝能量發生時才能使用。")
            .Add("樹果田裡使用的同時擁有勁勁肥、驚訝肥和碩果肥的作用效果的超級化肥。")
            .Add("樹果田裡使用的越勤勞的澆水，收穫的樹果量就越多的化肥。")
            .Add("樹果田裡使用的不需要勤勞的照顧樹果，就能大豐收的化肥。")
            .Add("樹果田裡使用的能引發樹果變異的化肥。")
            .Add("有了這種特殊的優惠劵，可以使購買的服裝打折。")
            .Add("描述某個神奇寶貝的紀念品，這個神奇寶貝在遠離卡洛斯的地方被尊為守護者。")
            .Add("遠古時住在海洋裡的神奇寶貝的化石，可能是一個貝殼。")
            .Add("遠古時住在海洋裡的神奇寶貝的化石，可能是一個甲殼。")
            .Add("一快仍然包含了古代生物基因的晶瑩剔透的琥珀。")
            .Add("遠古時住在海洋裡的神奇寶貝的化石，可能是一個植物的根部。")
            .Add("遠古時住在海洋裡的神奇寶貝的化石，似乎個爪子的一部分。")
            .Add("遠古時住在陸地上的神奇寶貝的化石，似乎是頭的一部分。")
            .Add("遠古時住在陸地上的神奇寶貝的化石，看起像一個盾牌。")
            .Add("遠古時住在陸地上的神奇寶貝的化石，似乎是後背的一部分。")
            .Add("遠古時住在天空中的神奇寶貝的化石，看起像羽毛的一部分。")
            .Add("遠古時住在陸地上的神奇寶貝的化石，看起像一塊下顎。")
            .Add("遠古時住在陸地上的神奇寶貝的化石，看起像一個皮質帆。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，明如太陽。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，黑如夜空。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，中心橘紅。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，石上有雷紋。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，藍如碧水。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，石上有葉紋。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，耀眼如光。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，黑如陰影。")
            .Add("能使特定種類的神奇寶貝進化的奇怪石頭，它如目光般閃爍。")
            .Add("稀有的小蘑菇，收藏家會以高價收購。")
            .Add("稀有的大蘑菇，收藏家會以高價收購。")
            .Add("閃耀著美麗銀光的有點小的珍珠，能以低價出售給商店。")
            .Add("閃耀著美麗銀光的相當大的珍珠，能以高價出售給商店。")
            .Add("有著絲綢般順滑手感的可愛紅砂，能以高價賣給商店。")
            .Add("閃爍著紅色光芒的美麗寶石的碎片，能以高價出售給商店。")
            .Add("奇怪的金色葉子。")
            .Add("奇怪的銀色葉子。")
            .Add("稀有的磚塊。")
            .Add("金光閃閃的純金塊，能以高價賣給商店。")
            .Add("美麗的心形鱗片，極其稀有。微微閃爍著彩虹色的光芒。")
            .Add("對神奇寶貝考古學家來說是有著非凡價值的骨頭，能以高價出售給商店。")
            .Add("雖然這根羽毛很漂亮，但似乎只是普通的羽毛，對神奇寶貝沒有作用。")
            .Add("一種發出芳香能擴散方圓十裡的罕見蘑菇，能以高價出售給商店。")
            .Add("散發耀眼金色光芒的大顆純金圓珠，能以高價賣給商店。")
            .Add("散發銀色光輝的大粒珍珠，能以高價賣給商店。")
            .Add("彗星接近時掉落在地表的碎片，能以高價賣給商店。")
            .Add("大約三千年前的古代文明使用的銅幣。")
            .Add("大約三千年前的古代文明使用的銀幣。")
            .Add("大約三千年前的古代文明使用的金幣。")
            .Add("大約三千年前的古代文明使用的花瓶。")
            .Add("大約三千年前的古代文明使用的手鐲。")
            .Add("大約三千年前的古代文明使用的石像。")
            .Add("大約三千年前的古代文明使用的王冠。")
        End With
    End Sub
End Module
