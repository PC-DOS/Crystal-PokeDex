Public Module libTypeRepresentativeColorProvider
    Public Structure SingleTypeRepresentativeColor
        Public Red As Integer
        Public Green As Integer
        Public Blue As Integer
    End Structure
    Public Structure TypeData
        Public TypeString1 As String
        Public TypeString2 As String
        Public TypeColor1 As SingleTypeRepresentativeColor
        Public TypeColor2 As SingleTypeRepresentativeColor
        Public IsType2Available As Boolean
    End Structure
    Public Function GetSingleTypeRepresentativeColor(TypeString As String) As SingleTypeRepresentativeColor
        Dim ColorReturn As SingleTypeRepresentativeColor
        Select Case TypeString
            Case "[一般]"
                With ColorReturn
                    .Red = 165
                    .Green = 165
                    .Blue = 125
                End With
            Case "一般"
                With ColorReturn
                    .Red = 165
                    .Green = 165
                    .Blue = 125
                End With
            Case "[格鬥]"
                With ColorReturn
                    .Red = 190
                    .Green = 50
                    .Blue = 40
                End With
            Case "格鬥"
                With ColorReturn
                    .Red = 190
                    .Green = 50
                    .Blue = 40
                End With
            Case "[飛行]"
                With ColorReturn
                    .Red = 165
                    .Green = 145
                    .Blue = 240
                End With
            Case "飛行"
                With ColorReturn
                    .Red = 165
                    .Green = 145
                    .Blue = 240
                End With
            Case "[毒]"
                With ColorReturn
                    .Red = 160
                    .Green = 65
                    .Blue = 160
                End With
            Case "毒"
                With ColorReturn
                    .Red = 160
                    .Green = 65
                    .Blue = 160
                End With
            Case "[地面]"
                With ColorReturn
                    .Red = 225
                    .Green = 190
                    .Blue = 105
                End With
            Case "地面"
                With ColorReturn
                    .Red = 225
                    .Green = 190
                    .Blue = 105
                End With
            Case "[岩石]"
                With ColorReturn
                    .Red = 185
                    .Green = 160
                    .Blue = 55
                End With
            Case "岩石"
                With ColorReturn
                    .Red = 185
                    .Green = 160
                    .Blue = 55
                End With
            Case "[蟲]"
                With ColorReturn
                    .Red = 165
                    .Green = 185
                    .Blue = 30
                End With
            Case "蟲"
                With ColorReturn
                    .Red = 165
                    .Green = 185
                    .Blue = 30
                End With
            Case "[幽靈]"
                With ColorReturn
                    .Red = 110
                    .Green = 90
                    .Blue = 150
                End With
            Case "幽靈"
                With ColorReturn
                    .Red = 110
                    .Green = 90
                    .Blue = 150
                End With
            Case "[鋼]"
                With ColorReturn
                    .Red = 185
                    .Green = 185
                    .Blue = 210
                End With
            Case "鋼"
                With ColorReturn
                    .Red = 185
                    .Green = 185
                    .Blue = 210
                End With
            Case "[火]"
                With ColorReturn
                    .Red = 240
                    .Green = 125
                    .Blue = 50
                End With
            Case "火"
                With ColorReturn
                    .Red = 240
                    .Green = 125
                    .Blue = 50
                End With
            Case "[水]"
                With ColorReturn
                    .Red = 105
                    .Green = 145
                    .Blue = 240
                End With
            Case "水"
                With ColorReturn
                    .Red = 105
                    .Green = 145
                    .Blue = 240
                End With
            Case "[草]"
                With ColorReturn
                    .Red = 120
                    .Green = 200
                    .Blue = 80
                End With
            Case "草"
                With ColorReturn
                    .Red = 120
                    .Green = 200
                    .Blue = 80
                End With
            Case "[電]"
                With ColorReturn
                    .Red = 250
                    .Green = 210
                    .Blue = 50
                End With
            Case "電"
                With ColorReturn
                    .Red = 250
                    .Green = 210
                    .Blue = 50
                End With
            Case "[超能]"
                With ColorReturn
                    .Red = 250
                    .Green = 90
                    .Blue = 135
                End With
            Case "超能"
                With ColorReturn
                    .Red = 250
                    .Green = 90
                    .Blue = 135
                End With
            Case "[超能力]"
                With ColorReturn
                    .Red = 250
                    .Green = 90
                    .Blue = 135
                End With
            Case "超能力"
                With ColorReturn
                    .Red = 250
                    .Green = 90
                    .Blue = 135
                End With
            Case "[冰]"
                With ColorReturn
                    .Red = 150
                    .Green = 225
                    .Blue = 225
                End With
            Case "冰"
                With ColorReturn
                    .Red = 150
                    .Green = 225
                    .Blue = 225
                End With
            Case "[龍]"
                With ColorReturn
                    .Red = 110
                    .Green = 55
                    .Blue = 250
                End With
            Case "龍"
                With ColorReturn
                    .Red = 110
                    .Green = 55
                    .Blue = 250
                End With
            Case "[惡]"
                With ColorReturn
                    .Red = 110
                    .Green = 90
                    .Blue = 70
                End With
            Case "惡"
                With ColorReturn
                    .Red = 110
                    .Green = 90
                    .Blue = 70
                End With
            Case "[妖精]"
                With ColorReturn
                    .Red = 240
                    .Green = 165
                    .Blue = 225
                End With
            Case "妖精"
                With ColorReturn
                    .Red = 240
                    .Green = 165
                    .Blue = 225
                End With
            Case Else
                With ColorReturn
                    .Red = 0
                    .Green = 0
                    .Blue = 0
                End With
        End Select
        Return ColorReturn
    End Function
    Public Function ParseTypeString(TypeString As String) As TypeData
        Dim TypeDataReturn As TypeData
        If TypeString.Contains("+") Then
            TypeDataReturn.IsType2Available = True
            With TypeDataReturn
                .TypeString1 = TypeString.Split("+")(0)
                .TypeString2 = TypeString.Split("+")(1)
                .TypeString1 = .TypeString1.Substring(1, .TypeString1.Length - 2)
                .TypeString2 = .TypeString2.Substring(1, .TypeString2.Length - 2)
                .TypeColor1 = GetSingleTypeRepresentativeColor(.TypeString1)
                .TypeColor2 = GetSingleTypeRepresentativeColor(.TypeString2)
            End With
        Else
            TypeDataReturn.IsType2Available = False
            With TypeDataReturn
                .TypeString1 = TypeString
                .TypeString2 = ""
                .TypeString1 = .TypeString1.Substring(1, .TypeString1.Length - 2)
                .TypeString2 = ""
                .TypeColor1 = GetSingleTypeRepresentativeColor(.TypeString1)
                .TypeColor2 = GetSingleTypeRepresentativeColor(.TypeString2)
            End With
        End If
        Return TypeDataReturn
    End Function
End Module
