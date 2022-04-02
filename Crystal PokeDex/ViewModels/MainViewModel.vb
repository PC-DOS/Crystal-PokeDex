Imports System.ComponentModel
Imports System.Collections.ObjectModel

Public Class MainViewModel
    Implements INotifyPropertyChanged

    Public Sub New()
        Me.Items = New ObservableCollection(Of ItemViewModel)()
    End Sub

    ''' <summary>
    ''' ItemViewModel 物件的集合。
    ''' </summary>
    Public Property Items() As ObservableCollection(Of ItemViewModel)

    Private _sampleProperty As String = "Sample Runtime Property Value"
    ''' <summary>
    ''' 範例 ViewModel 屬性; 這個屬性是用在檢視中，以使用繫結來顯示其值
    ''' </summary>
    ''' <returns></returns>
    Public Property SampleProperty() As String
        Get
            Return _sampleProperty
        End Get
        Set(ByVal value As String)
            If Not value.Equals(_sampleProperty) Then
                _sampleProperty = value
                NotifyPropertyChanged("SampleProperty")
            End If
        End Set
    End Property

    ''' <summary>
    ''' 傳回當地語系化字串的範例屬性
    ''' </summary>
    Public ReadOnly Property LocalizedSampleProperty() As String
        Get
            Return AppResources.SampleProperty
        End Get
    End Property

    Public Property IsDataLoaded() As Boolean

    ''' <summary>
    ''' 建立並加入一些 ItemViewModel 物件到 Items 集合。
    ''' </summary>
    Public Sub LoadData()
        ' 範例資料; 以真實資料取代
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime one", .LineTwo = "Maecenas praesent accumsan bibendum", .LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime two", .LineTwo = "Dictumst eleifend facilisi faucibus", .LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime three", .LineTwo = "Habitant inceptos interdum lobortis", .LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime four", .LineTwo = "Nascetur pharetra placerat pulvinar", .LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime five", .LineTwo = "Maecenas praesent accumsan bibendum", .LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime six", .LineTwo = "Dictumst eleifend facilisi faucibus", .LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime seven", .LineTwo = "Habitant inceptos interdum lobortis", .LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime eight", .LineTwo = "Nascetur pharetra placerat pulvinar", .LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime nine", .LineTwo = "Maecenas praesent accumsan bibendum", .LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime ten", .LineTwo = "Dictumst eleifend facilisi faucibus", .LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime eleven", .LineTwo = "Habitant inceptos interdum lobortis", .LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime twelve", .LineTwo = "Nascetur pharetra placerat pulvinar", .LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime thirteen", .LineTwo = "Maecenas praesent accumsan bibendum", .LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime fourteen", .LineTwo = "Dictumst eleifend facilisi faucibus", .LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime fifteen", .LineTwo = "Habitant inceptos interdum lobortis", .LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"})
        Me.Items.Add(New ItemViewModel() With {.LineOne = "runtime sixteen", .LineTwo = "Nascetur pharetra placerat pulvinar", .LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"})

        Me.IsDataLoaded = True
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub NotifyPropertyChanged(ByVal propertyName As String)
        Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
        If Nothing IsNot handler Then
            handler(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class