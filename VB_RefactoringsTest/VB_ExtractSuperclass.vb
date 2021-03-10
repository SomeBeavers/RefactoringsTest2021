Namespace RefactoringsTest2021
    Public Class ExtractSuperclass
        Protected ProtectedField As Integer
        Public Property PublicProperty As Integer

        Private Sub PrivateMethod()
            PublicProperty = 1
        End Sub

        Public Overridable Sub PublicVirtualMethod()
            PublicMethod()
        End Sub

        Public Sub PublicMethod()
            PrivateMethod()
        End Sub
    End Class

    Public MustInherit Class AbstractExtractSuperclass
        Implements IAbstractExtractSuperclass

        Private ic As InnerClass
        Public MustOverride Function ReturnInnerClass() As InnerClass

        Public Class InnerClass
        End Class

        Public Function IAbstractExtractSuperclass_ReturnInnerClass() As InnerClass Implements IAbstractExtractSuperclass.ReturnInnerClass
            Throw New NotImplementedException
        End Function
    End Class

    Public Class ExtractSuperclassManyMembers
        Protected ProtectedField As Integer
        Public Property PublicProperty As Integer

        Private Sub PrivateMethod()
            PublicProperty = 1
        End Sub

        Public Overridable Sub PublicVirtualMethod()
            PublicMethod()
        End Sub

        Public Sub PublicMethod()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod1()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod2()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod3()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod4()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod5()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod6()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod7()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod8()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod9()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod21()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod22()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod23()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod24()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod25()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod26()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod27()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod28()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod29()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod11()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod12()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod13()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod14()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod15()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod16()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod17()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod18()
            PrivateMethod()
        End Sub

        Public Sub PublicMethod19()
            PrivateMethod()
        End Sub
    End Class

    Interface IAbstractExtractSuperclass
        Function ReturnInnerClass() As AbstractExtractSuperclass.InnerClass
    End Interface
End Namespace
