Imports System

Namespace RefactoringsTest2021
    Public Class UseBaseTypeWherePossible
        Inherits UseBaseTypeWherePossibleBase
        Implements ISomeInterface, IFormatProvider

        Public Sub Use()
        End Sub

        Public Function GetFormat(ByVal formatType As Type) As Object
            Throw New NotImplementedException()
        End Function

        Public Function IFormatProvider_GetFormat(formatType As Type) As Object Implements IFormatProvider.GetFormat
            Throw New NotImplementedException
        End Function
    End Class

    Public Class UseBaseTypeWherePossibleBase
    End Class

    Interface ISomeInterface
    End Interface
End Namespace
