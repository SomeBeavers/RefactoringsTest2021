Imports System

Namespace RefactoringsTest2021
    Public Class PullMembersUp
        Inherits PullMembersUpBase
        Implements IPullMembersUp, IPullMembersUp1, IPullMembersUp2, IPullMembersUp3, IPullMembersUp4, IPullMembersUp5

        Public Sub Test()
            Test2()
        End Sub

        Public Sub Test2()
            Throw New NotImplementedException()
        End Sub

        Private Sub PrivateMethod()
            PublicProperty = 1
        End Sub

        Public Overrides Sub PublicVirtualMethod()
            PublicProperty = 1
            PrivateMethod()
        End Sub

        Public Sub PublicMethod()
            PublicProperty = 1
            ProtectedField = 1
            PublicVirtualMethod()
        End Sub

        Public Property PublicProperty As Integer
        Protected ProtectedField As Integer
    End Class

    Public MustInherit Class PullMembersUpAbstract
        Inherits PullMembersUpBase
        Implements IPullMembersUp

        Public MustOverride Sub PublicVirtualMethod()
    End Class

    Interface IPullMembersUpInterface
    End Interface

    Interface IPullMembersUpInterface1
    End Interface

    Interface IPullMembersUpInterface2
    End Interface

    Interface IPullMembersUpInterface3
    End Interface

    Interface IPullMembersUpInterface4
    End Interface

    Interface IPullMembersUpInterface5
    End Interface

    Interface IPullMembersUp1
        Inherits IPullMembersUpInterface, IPullMembersUpInterface1, IPullMembersUpInterface2, IPullMembersUpInterface3, IPullMembersUpInterface4, IPullMembersUpInterface5
    End Interface

    Interface IPullMembersUp5
    End Interface

    Interface IPullMembersUp2
    End Interface

    Interface IPullMembersUp3
    End Interface

    Interface IPullMembersUp4
    End Interface

    Interface IPullMembersUp
    End Interface

    Interface IPullMembersUpBase
    End Interface

    Interface IPullMembersUpBase1
    End Interface

    Interface IPullMembersUpBase2
    End Interface

    Interface IPullMembersUpBase3
    End Interface

    Interface IPullMembersUpBase4
    End Interface

    Interface IPullMembersUpBase5
    End Interface

    Public Class PullMembersUpBase
        Implements IPullMembersUpBase, IPullMembersUpBase1, IPullMembersUpBase2, IPullMembersUpBase3, IPullMembersUpBase4, IPullMembersUpBase5

        Public Overridable Sub PublicVirtualMethod()
            Throw New System.NotImplementedException()
        End Sub
    End Class
End Namespace
