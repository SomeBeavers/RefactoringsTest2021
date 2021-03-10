Namespace RefactoringsTest2021
    Public MustInherit Class ConvertAbstractClassToInterface
        Public MustOverride Property Id As Integer

        Public Overridable Sub Register()
        End Sub

        Public MustOverride Sub UnRegister()
    End Class

    Class ConvertAbstractClassToInterfaceImpl
        Inherits ConvertAbstractClassToInterface

        Public Overrides Property Id As Integer

        Public Overrides Sub Register()
            Throw New System.NotImplementedException()
        End Sub

        Public Overrides Sub UnRegister()
            Throw New System.NotImplementedException()
        End Sub
    End Class
End Namespace
