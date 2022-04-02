Imports System.ComponentModel

Public Class ItemViewModel
    Implements INotifyPropertyChanged
    Private _lineOne As String
    ''' <summary>
    ''' 範例 ViewModel 屬性; 這個屬性是用在檢視中，以使用繫結來顯示其值。
    ''' </summary>
    ''' <returns></returns>
    Public Property LineOne() As String
        Get
            Return _lineOne
        End Get
        Set(ByVal value As String)
            If Not value.Equals(_lineOne) Then
                _lineOne = value
                NotifyPropertyChanged("LineOne")
            End If
        End Set
    End Property

    Private _lineTwo As String
    ''' <summary>
    ''' 範例 ViewModel 屬性; 這個屬性是用在檢視中，以使用繫結來顯示其值。
    ''' </summary>
    ''' <returns></returns>
    Public Property LineTwo() As String
        Get
            Return _lineTwo
        End Get
        Set(ByVal value As String)
            If Not value.Equals(_lineTwo) Then
                _lineTwo = value
                NotifyPropertyChanged("LineTwo")
            End If
        End Set
    End Property

    Private _lineThree As String
    ''' <summary>
    ''' 範例 ViewModel 屬性; 這個屬性是用在檢視中，以使用繫結來顯示其值。
    ''' </summary>
    ''' <returns></returns>
    Public Property LineThree() As String
        Get
            Return _lineThree
        End Get
        Set(ByVal value As String)
            If Not value.Equals(_lineThree) Then
                _lineThree = value
                NotifyPropertyChanged("LineThree")
            End If
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub NotifyPropertyChanged(ByVal propertyName As String)
        Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
        If Nothing IsNot handler Then
            handler(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class