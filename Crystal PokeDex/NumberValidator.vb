Public Module NumberValidator
    Public Function IsNumber(StringToTest As String) As Integer
        Dim NumTest As Long
        Try
            NumTest = StringToTest * 0
            IsNumber = 1
        Catch ex As Exception
            IsNumber = 0
        End Try
    End Function
    Public Function IsNumberBool(StringToTest As String) As Boolean
        Dim NumTest As Long
        Try
            NumTest = StringToTest * 0
            IsNumberBool = True
        Catch ex As Exception
            IsNumberBool = False
        End Try
    End Function
End Module
