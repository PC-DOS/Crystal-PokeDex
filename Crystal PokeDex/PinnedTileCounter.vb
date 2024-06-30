Module PinnedTileCounter
    Public CurrentPinnedTileIndex As Long
    Public TileIndexCounter As IO.IsolatedStorage.IsolatedStorageSettings
    Public IsLaunchedFromPinned As Boolean = False
    Public Const CurrentPinnedTileIndexKey As String = "CurrentPinnedTileIndex"
    Public Sub InitializeTileIndexServer()
        TileIndexCounter = IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings
        Try
            TileIndexCounter.Add(CurrentPinnedTileIndexKey, 0)
        Catch ex As Exception

        End Try
        CurrentPinnedTileIndex = TileIndexCounter(CurrentPinnedTileIndexKey)
    End Sub
End Module
