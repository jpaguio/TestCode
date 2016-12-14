Imports System

Public Class Calc
    Private m_numberOne As Integer = 0
    Private m_numberTwo As Integer = 0

    Public Property NumberOne() As Integer
        Get
            Return m_numberOne
        End Get
        Set(value As Integer)
            m_numberOne = value
        End Set
    End Property

    Public Property NumberTwo() As Integer
        Get
            Return m_numberTwo
        End Get
        Set(value As Integer)
            m_numberTwo = value
        End Set
    End Property

    Public ReadOnly Property OneAddTwo()
        Get
            Return m_numberOne + m_numberTwo
        End Get
    End Property
End Class

