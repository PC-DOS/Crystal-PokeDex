Public Module OnlineSearchProvider
    Public Enum PokemonSearchRequestLanguages
        PokemonNameCHTInformal = 1
        PokemonNameCHTOfficial = 2
        PokemonNameCHSInformal = 3
        PokemonNameCHSOfficial = 4
        PokemonNameENG = 5
        PokemonNameKOR = 6
        PokemonNameJPN = 7
        PokemonNameFRA = 8
        PokemonNameGER = 9
    End Enum
    Public Enum MoveSearchRequestLanguages
        MoveNameCHTInformal = 1
        MoveNameCHTOfficial = 2
        MoveNameCHSInformal = 3
        MoveNameCHSOfficial = 4
        MoveNameENG = 5
        MoveNameJPN = 6
    End Enum
    Public Enum ItemSearchRequestLanguages
        ItemNameCHT = 1
        ItemNameENG = 2
        ItemNameJPN = 3
    End Enum
    Public Enum AbilitySearchRequestLanguages
        AbilityNameCHTInformal = 1
        AbilityNameCHTOfficial = 2
        AbilityNameCHSInformal = 3
        AbilityNameCHSOfficial = 4
        AbilityNameENG = 5
        AbilityNameJPN = 6
    End Enum

    Public PokemonSearchRequest As PokemonSearchRequestLanguages
    Public MoveSearchRequest As MoveSearchRequestLanguages
    Public ItemSearchRequest As ItemSearchRequestLanguages
    Public AbilitySearchRequest As AbilitySearchRequestLanguages
End Module
