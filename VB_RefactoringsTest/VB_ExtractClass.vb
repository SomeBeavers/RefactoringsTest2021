Imports System
Imports System.IO

Namespace RefactoringsTest2021
    Public Class ExtractClass
        Private ReadOnly usedPrivateField As Integer
        Public Property PublicProperty As String

        Private Sub UsePrivateField()
            Console.WriteLine(usedPrivateField)
        End Sub

        Public Sub UsePrivateField2()
            Console.WriteLine(usedPrivateField)
        End Sub

        Public Sub UseMethod()
            PublicProperty = ""
            UsePrivateField2()
        End Sub

        Public Sub NotUsedMethod()
        End Sub
    End Class

    Public Class ExtractClassGeneric(Of T)
        Private ReadOnly usedPrivateField As T
        Public Property PublicProperty As String

        Private Sub UsePrivateField(Of U)(ByVal u1 As U)
            Console.WriteLine(usedPrivateField.ToString() & u1?.ToString())
        End Sub

        Public Sub UsePrivateField2()
            Console.WriteLine(usedPrivateField)
        End Sub

        Public Sub UseMethod()
            PublicProperty = ""
            UsePrivateField2()
        End Sub

        Public Sub NotUsedMethod()
        End Sub
    End Class

    Class ExtractClassWithManyMembers
        Private ReadOnly innerClass1 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass2 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass3 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass4 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass5 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass6 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass7 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass8 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass9 As LastInnerClass = New LastInnerClass()
        Private ReadOnly innerClass10 As LastInnerClass = New LastInnerClass()

        Public Sub UseInnerClass1()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass12()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass13()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass14()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass15()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass16()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass17()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass18()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass19()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass20()
            Console.WriteLine(innerClass1)
        End Sub

        Public Sub UseInnerClass2()
            Console.WriteLine(innerClass2)
        End Sub

        Public Sub UseInnerClass3()
            Console.WriteLine(innerClass3)
        End Sub

        Public Sub UseInnerClass4()
            Console.WriteLine(innerClass4)
        End Sub

        Public Sub UseInnerClass5()
            Console.WriteLine(innerClass5)
        End Sub

        Public Sub UseInnerClass6()
            Console.WriteLine(innerClass6)
        End Sub

        Public Sub UseInnerClass7()
            Console.WriteLine(innerClass7)
        End Sub

        Public Sub UseInnerClass8()
            Console.WriteLine(innerClass8)
        End Sub

        Public Sub UseInnerClass9()
            Console.WriteLine(innerClass9)
        End Sub

        Public Sub UseInnerClass10()
            Console.WriteLine(innerClass10)
        End Sub

        Private Class LastInnerClass
            Public Sub Draw()
                LogError("")
            End Sub

            Public Shared Sub LogError(ByVal e As String)
            End Sub
        End Class
    End Class
End Namespace
