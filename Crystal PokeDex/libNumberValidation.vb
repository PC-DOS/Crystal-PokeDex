Module libNumberValidation
    Public Function IsNumber(lpTest As String) As Integer
        Dim t As Long
        Try
            t = lpTest * 0
            IsNumber = 1
        Catch ex As Exception
            IsNumber = 0
        End Try
    End Function
    Public Function IsNumberBool(lpTest As String) As Boolean
        Dim t As Long
        Try
            t = lpTest * 0
            IsNumberBool = True
        Catch ex As Exception
            IsNumberBool = False
        End Try
    End Function
End Module
