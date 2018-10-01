Public Class Calculator

    Private _memory As Double
    Private _operatorAsStrings As List(Of String)
    Private _numberAsStrings As List(Of String)
    Private _numbers As List(Of Double)

    Public Property Memory As Double
        Get
            Return _memory
        End Get
        Set(value As Double)
            _memory = value
        End Set
    End Property

End Class
