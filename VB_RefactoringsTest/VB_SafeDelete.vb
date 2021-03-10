Namespace RefactoringsTest2021
    Public Class SafeDelete
        Inherits SafeDeleteBase

        Public Sub New(ByVal name As String)
        End Sub

        Public Sub New(ByVal name As String, ByVal age As Integer)
            Me.New(name)
        End Sub

        Public Overrides Sub SafeDeleteMethod()
        End Sub

        Public Overrides Sub SafeDeleteMethod(ByVal s As String)
            SafeDeleteMethod()
        End Sub
    End Class

    Public Class UseSafeDelete
        Private Sub UseSafeDelete1()
            Dim safeDelete = New SafeDelete("Jane Doe")
        End Sub
    End Class

    Public Class TestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongName
    End Class

    Public MustInherit Class SafeDeleteBase
        Public MustOverride Sub SafeDeleteMethod()
        Public MustOverride Sub SafeDeleteMethod(ByVal s As String)
    End Class

    Public Class BC
        Inherits TestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongName
    End Class
End Namespace
