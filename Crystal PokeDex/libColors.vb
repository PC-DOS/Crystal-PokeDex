Module libColors
    Public Structure RGBColor
        Dim Red As Integer
        Dim Green As Integer
        Dim Blue As Integer
    End Structure
    Public Structure ValueProgressBarColorSettings
        Dim IsSystemAccent As Boolean
        Dim ColorSettingsRGB As RGBColor
    End Structure
    Public Enum EditingTargets
        HP = 0
        ATK = 1
        DEF = 2
        SATK = 3
        SDEF = 4
        SPD = 5
        TOTAL = 6
    End Enum
    Public EditingTarget As EditingTargets
    Public ValueHP As ValueProgressBarColorSettings
    Public ValueAttack As ValueProgressBarColorSettings
    Public ValueDefence As ValueProgressBarColorSettings
    Public ValueSpecialAttack As ValueProgressBarColorSettings
    Public ValueSpecialDefence As ValueProgressBarColorSettings
    Public ValueSpeed As ValueProgressBarColorSettings
    Public ValueTotal As ValueProgressBarColorSettings
    Public ColorSotrage As IO.IsolatedStorage.IsolatedStorageFile
    Dim IsoStoreStream As IO.IsolatedStorage.IsolatedStorageFileStream
    Dim FileWriter As System.IO.StreamWriter
    Dim FileReader As System.IO.StreamReader
    Public Sub InitFirstLaunch()
        With ValueHP
            .IsSystemAccent = True
            With .ColorSettingsRGB
                .Blue = 0
                .Red = 0
                .Green = 0
            End With
        End With
        With ValueAttack
            .IsSystemAccent = True
            With .ColorSettingsRGB
                .Blue = 0
                .Red = 0
                .Green = 0
            End With
        End With
        With ValueDefence
            .IsSystemAccent = True
            With .ColorSettingsRGB
                .Blue = 0
                .Red = 0
                .Green = 0
            End With
        End With
        With ValueSpecialAttack
            .IsSystemAccent = True
            With .ColorSettingsRGB
                .Blue = 0
                .Red = 0
                .Green = 0
            End With
        End With
        With ValueSpecialDefence
            .IsSystemAccent = True
            With .ColorSettingsRGB
                .Blue = 0
                .Red = 0
                .Green = 0
            End With
        End With
        With ValueSpeed
            .IsSystemAccent = True
            With .ColorSettingsRGB
                .Blue = 0
                .Red = 0
                .Green = 0
            End With
        End With
        With ValueTotal
            .IsSystemAccent = True
            With .ColorSettingsRGB
                .Blue = 0
                .Red = 0
                .Green = 0
            End With
        End With
    End Sub
    Public Sub InitColors()
        ValueHP = IsoSettingsLib("ColorHP")
        ValueAttack = IsoSettingsLib("ColorATK")
        ValueDefence = IsoSettingsLib("ColorDEF")
        ValueSpecialAttack = IsoSettingsLib("ColorSATK")
        ValueSpecialDefence = IsoSettingsLib("ColorSDEF")
        ValueSpeed = IsoSettingsLib("ColorSPD")
        ValueTotal = IsoSettingsLib("ColorTotal")
    End Sub
    Public Sub InitColorStorage()
        ColorSotrage = IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication
        If Not ColorSotrage.DirectoryExists("ColorHP") Then
            ColorSotrage.CreateDirectory("ColorHP")
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("1")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\R", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\G", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\B", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
        End If
        If Not ColorSotrage.DirectoryExists("ColorATK") Then
            ColorSotrage.CreateDirectory("ColorATK")
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("1")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\R", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\G", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\B", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
        End If
        If Not ColorSotrage.DirectoryExists("ColorDEF") Then
            ColorSotrage.CreateDirectory("ColorDEF")
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("1")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\R", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\G", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\B", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
        End If
        If Not ColorSotrage.DirectoryExists("ColorSATK") Then
            ColorSotrage.CreateDirectory("ColorSATK")
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("1")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\R", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\G", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\B", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
        End If
        If Not ColorSotrage.DirectoryExists("ColorSDEF") Then
            ColorSotrage.CreateDirectory("ColorSDEF")
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("1")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\R", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\G", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\B", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
        End If
        If Not ColorSotrage.DirectoryExists("ColorSPD") Then
            ColorSotrage.CreateDirectory("ColorSPD")
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("1")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\R", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\G", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\B", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
        End If
        If Not ColorSotrage.DirectoryExists("ColorTOTAL") Then
            ColorSotrage.CreateDirectory("ColorTOTAL")
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("1")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\R", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\G", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
            IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\B", IO.FileMode.OpenOrCreate, ColorSotrage)
            FileWriter = New System.IO.StreamWriter(IsoStoreStream)
            FileWriter.Write("0")
            FileWriter.Close()
            IsoStoreStream.Close()
        End If
        Dim IsDefaultTmp As String
        Dim R As String
        Dim G As String
        Dim B As String
        Dim RGB As RGBColor
        'HP
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        IsDefaultTmp = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\R", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        R = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\G", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        G = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\B", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        B = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        With RGB
            .Red = CInt(R)
            .Green = CInt(G)
            .Blue = CInt(B)
        End With
        With ValueHP
            If IsDefaultTmp = "0" Then
                .IsSystemAccent = False
            Else
                .IsSystemAccent = True
            End If
            .ColorSettingsRGB = RGB
        End With
        'Attack
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        IsDefaultTmp = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\R", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        R = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\G", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        G = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\B", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        B = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        With RGB
            .Red = CInt(R)
            .Green = CInt(G)
            .Blue = CInt(B)
        End With
        With ValueAttack
            If IsDefaultTmp = "0" Then
                .IsSystemAccent = False
            Else
                .IsSystemAccent = True
            End If
            .ColorSettingsRGB = RGB
        End With
        'Defence
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        IsDefaultTmp = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\R", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        R = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\G", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        G = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\B", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        B = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        With RGB
            .Red = CInt(R)
            .Green = CInt(G)
            .Blue = CInt(B)
        End With
        With ValueDefence
            If IsDefaultTmp = "0" Then
                .IsSystemAccent = False
            Else
                .IsSystemAccent = True
            End If
            .ColorSettingsRGB = RGB
        End With
        'SATK
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        IsDefaultTmp = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\R", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        R = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\G", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        G = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\B", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        B = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        With RGB
            .Red = CInt(R)
            .Green = CInt(G)
            .Blue = CInt(B)
        End With
        With ValueSpecialAttack
            If IsDefaultTmp = "0" Then
                .IsSystemAccent = False
            Else
                .IsSystemAccent = True
            End If
            .ColorSettingsRGB = RGB
        End With
        'SDEF
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        IsDefaultTmp = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\R", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        R = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\G", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        G = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\B", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        B = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        With RGB
            .Red = CInt(R)
            .Green = CInt(G)
            .Blue = CInt(B)
        End With
        With ValueSpecialDefence
            If IsDefaultTmp = "0" Then
                .IsSystemAccent = False
            Else
                .IsSystemAccent = True
            End If
            .ColorSettingsRGB = RGB
        End With
        'Speed
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        IsDefaultTmp = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\R", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        R = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\G", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        G = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\B", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        B = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        With RGB
            .Red = CInt(R)
            .Green = CInt(G)
            .Blue = CInt(B)
        End With
        With ValueSpeed
            If IsDefaultTmp = "0" Then
                .IsSystemAccent = False
            Else
                .IsSystemAccent = True
            End If
            .ColorSettingsRGB = RGB
        End With
        'Total
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        IsDefaultTmp = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\R", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        R = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\G", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        G = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\B", IO.FileMode.OpenOrCreate, ColorSotrage)
        FileReader = New IO.StreamReader(IsoStoreStream)
        B = FileReader.ReadLine
        FileReader.Close()
        IsoStoreStream.Close()
        With RGB
            .Red = CInt(R)
            .Green = CInt(G)
            .Blue = CInt(B)
        End With
        With ValueTotal
            If IsDefaultTmp = "0" Then
                .IsSystemAccent = False
            Else
                .IsSystemAccent = True
            End If
            .ColorSettingsRGB = RGB
        End With
    End Sub
    Public Sub SaveColor(lpTarget As EditingTargets)
        Select Case lpTarget
            Case EditingTargets.HP
                ColorSotrage.DeleteFile("ColorHP\IsSys")
                ColorSotrage.DeleteFile("ColorHP\R")
                ColorSotrage.DeleteFile("ColorHP\G")
                ColorSotrage.DeleteFile("ColorHP\B")
                ColorSotrage.DeleteDirectory("ColorHP")
                With ValueHP
                    ColorSotrage.CreateDirectory("ColorHP")
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    If Not .IsSystemAccent Then
                        FileWriter.Write("0")
                    Else
                        FileWriter.Write("1")
                    End If
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\R", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Red)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\G", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Green)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorHP\B", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Blue)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                End With
            Case EditingTargets.ATK
                ColorSotrage.DeleteFile("ColorATK\IsSys")
                ColorSotrage.DeleteFile("ColorATK\R")
                ColorSotrage.DeleteFile("ColorATK\G")
                ColorSotrage.DeleteFile("ColorATK\B")
                ColorSotrage.DeleteDirectory("ColorATK")
                With ValueAttack
                    ColorSotrage.CreateDirectory("ColorATK")
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    If Not .IsSystemAccent Then
                        FileWriter.Write("0")
                    Else
                        FileWriter.Write("1")
                    End If
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\R", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Red)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\G", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Green)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorATK\B", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Blue)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                End With
            Case EditingTargets.DEF
                ColorSotrage.DeleteFile("ColorDEF\IsSys")
                ColorSotrage.DeleteFile("ColorDEF\R")
                ColorSotrage.DeleteFile("ColorDEF\G")
                ColorSotrage.DeleteFile("ColorDEF\B")
                ColorSotrage.DeleteDirectory("ColorDEF")
                With ValueDefence
                    ColorSotrage.CreateDirectory("ColorDEF")
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    If Not .IsSystemAccent Then
                        FileWriter.Write("0")
                    Else
                        FileWriter.Write("1")
                    End If
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\R", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Red)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\G", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Green)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorDEF\B", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Blue)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                End With
            Case EditingTargets.SATK
                ColorSotrage.DeleteFile("ColorSATK\IsSys")
                ColorSotrage.DeleteFile("ColorSATK\R")
                ColorSotrage.DeleteFile("ColorSATK\G")
                ColorSotrage.DeleteFile("ColorSATK\B")
                ColorSotrage.DeleteDirectory("ColorSATK")
                With ValueSpecialAttack
                    ColorSotrage.CreateDirectory("ColorSATK")
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    If Not .IsSystemAccent Then
                        FileWriter.Write("0")
                    Else
                        FileWriter.Write("1")
                    End If
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\R", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Red)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\G", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Green)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSATK\B", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Blue)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                End With
            Case EditingTargets.SDEF
                ColorSotrage.DeleteFile("ColorSDEF\IsSys")
                ColorSotrage.DeleteFile("ColorSDEF\R")
                ColorSotrage.DeleteFile("ColorSDEF\G")
                ColorSotrage.DeleteFile("ColorSDEF\B")
                ColorSotrage.DeleteDirectory("ColorSDEF")
                With ValueSpecialDefence
                    ColorSotrage.CreateDirectory("ColorSDEF")
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    If Not .IsSystemAccent Then
                        FileWriter.Write("0")
                    Else
                        FileWriter.Write("1")
                    End If
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\R", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Red)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\G", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Green)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSDEF\B", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Blue)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                End With
            Case EditingTargets.SPD
                ColorSotrage.DeleteFile("ColorSPD\IsSys")
                ColorSotrage.DeleteFile("ColorSPD\R")
                ColorSotrage.DeleteFile("ColorSPD\G")
                ColorSotrage.DeleteFile("ColorSPD\B")
                ColorSotrage.DeleteDirectory("ColorSPD")
                With ValueSpeed
                    ColorSotrage.CreateDirectory("ColorSPD")
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    If Not .IsSystemAccent Then
                        FileWriter.Write("0")
                    Else
                        FileWriter.Write("1")
                    End If
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\R", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Red)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\G", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Green)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorSPD\B", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Blue)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                End With
            Case EditingTargets.TOTAL
                ColorSotrage.DeleteFile("ColorTOTAL\IsSys")
                ColorSotrage.DeleteFile("ColorTOTAL\R")
                ColorSotrage.DeleteFile("ColorTOTAL\G")
                ColorSotrage.DeleteFile("ColorTOTAL\B")
                ColorSotrage.DeleteDirectory("ColorTOTAL")
                With ValueTotal
                    ColorSotrage.CreateDirectory("ColorTOTAL")
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\IsSys", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    If Not .IsSystemAccent Then
                        FileWriter.Write("0")
                    Else
                        FileWriter.Write("1")
                    End If
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\R", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Red)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\G", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Green)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                    IsoStoreStream = New IO.IsolatedStorage.IsolatedStorageFileStream("ColorTOTAL\B", IO.FileMode.OpenOrCreate, ColorSotrage)
                    FileWriter = New System.IO.StreamWriter(IsoStoreStream)
                    FileWriter.Write(.ColorSettingsRGB.Blue)
                    FileWriter.Close()
                    IsoStoreStream.Close()
                End With
        End Select

    End Sub

End Module
