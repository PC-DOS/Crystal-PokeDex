Module modOnlineSearch
    Public Enum PokemonSearchRequestLanguages
        PokemonNameCHT = 1
        PokemonNameCHS = 2
        PokemonNameENG = 3
        PokemonNameKOR = 4
        PokemonNameJPN = 5
        PokemonNameFRA = 6
        PokemonNameGER = 7
        PokemonNameCHTO = 8
        PokemonNameCHSO = 9
    End Enum
    Public Enum MoveSearchRequestLanguages
        MoveNameCHT = 1
        MoveNameCHS = 2
        MoveNameENG = 3
        MoveNameJPN = 4
        MoveNameCHTO = 5
        MoveNameCHSO = 6
    End Enum
    Public Enum ItemSearchRequestLanguages
        ItemNameCHT = 1
        ItemNameENG = 2
        ItemNameJPN = 3
    End Enum
    Public Enum AbilitySearchRequestLanguages
        AbilityNameCHT = 1
        AbilityNameCHS = 2
        AbilityNameENG = 3
        AbilityNameJPN = 4
        AbilityNameCHTO = 5
        AbilityNameCHSO = 6
    End Enum

    Public PokemonSearchRequest As PokemonSearchRequestLanguages
    Public MoveSearchRequest As MoveSearchRequestLanguages
    Public ItemSearchRequest As ItemSearchRequestLanguages
    Public AbilitySearchRequest As AbilitySearchRequestLanguages
End Module
