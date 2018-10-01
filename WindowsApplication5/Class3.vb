Public Class Token

    Public Enum TokenType
        Digit
        LeftParenthesis
        [Operator]
        RightParenthesis
    End Enum

    Public Delegate Function MathOperation(ByVal value1 As Double, ByVal value2 As Double) As Double

    Private _operation As MathOperation
    Public Property Operation() As MathOperation
        Get
            Return _operation
        End Get
        Set(ByVal value As MathOperation)
            _operation = value
        End Set
    End Property

    Private _pattern As String
    Public Property Pattern() As String
        Get
            Return _pattern
        End Get
        Set(ByVal value As String)
            _pattern = value
        End Set
    End Property

    Private _precedence As Integer
    Public Property Precedence() As Integer
        Get
            Return _precedence
        End Get
        Set(ByVal value As Integer)
            _precedence = value
        End Set
    End Property

    Private _type As TokenType
    Public Property Type() As TokenType
        Get
            Return _type
        End Get
        Set(ByVal value As TokenType)
            _type = value
        End Set
    End Property

    Private _value As String
    Public Property Value() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
        End Set
    End Property

End Class

