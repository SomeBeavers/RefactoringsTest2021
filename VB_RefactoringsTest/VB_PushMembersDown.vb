Imports System

Namespace RefactoringsTest2021
    Public Class PushMembersDown
        Protected ProtectedField As Integer
        Public Property PublicProperty As Integer

        Public Overridable Sub Test()
        End Sub

        Public Sub Test2()
            Throw New NotImplementedException()
        End Sub

        Private Sub PrivateMethod()
            PublicProperty = 1
        End Sub

        Public Sub PublicVirtualMethod()
            PublicProperty = 1
            PrivateMethod()
        End Sub

        Public Sub PublicMethod()
            PublicProperty = 1
            ProtectedField = 1
            PublicVirtualMethod()
        End Sub
    End Class

    Interface IPushMembersDown
        Property PublicProperty As Integer
        Sub Test()
        Sub Test2()
        Sub PrivateMethod()
        Sub PublicVirtualMethod()
        Sub PublicMethod()
    End Interface

    Friend Class PushMembersDown1
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown2
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown3
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown4
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown5
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown6
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown7
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown8
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown9
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown11
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown12
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown13
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown14
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown15
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown16
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown17
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown18
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown19
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown10
        Inherits PushMembersDown
    End Class

    Friend Class PushMembersDown5_1
        Inherits PushMembersDown5
    End Class

    Friend Interface IPushMembersDown_1
        Inherits IPushMembersDown
    End Interface
End Namespace
