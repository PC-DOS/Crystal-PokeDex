Module TileCountMgmt
    Public currentTileIndex As Long
    Public indexManage As IO.IsolatedStorage.IsolatedStorageSettings
    Public IsLaunchedFromPinned As Boolean = False
    Public Sub InitializeTileIndexServer()
        indexManage = IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings
        Try
            indexManage.Add("Index", 0)
        Catch ex As Exception

        End Try
        currentTileIndex = indexManage("Index")
    End Sub
End Module
