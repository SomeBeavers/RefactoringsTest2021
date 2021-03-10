Imports System

Namespace RefactoringsTest2021
    Public Class ExtractInterface
        Private t As Integer

        Private ReadOnly Property Name As String
            Get
                Return Name2
            End Get
        End Property

        Public Property Name2 As String
        Public Property NamePublic As String

        Public Sub Test()
            Test2()
            Console.WriteLine(t)
            Console.WriteLine(Name)
        End Sub

        Private Sub Test2()
            NamePublic = ""
        End Sub
    End Class

    Public Class ExtractInterfaceWithManyMembers
        Public Property Name As String
        Public Property Name1 As String
        Public Property Name2 As String
        Public Property Name3 As String
        Public Property Name4 As String
        Public Property Name5 As String
        Public Property Name6 As String
        Public Property Name7 As String
        Public Property Name8 As String
        Public Property Name9 As String
        Public Property Name10 As String
        Private Property Name11 As String
        Private Property Name12 As String
        Private Property Name13 As String
        Private Property Name14 As String
        Private Property Name15 As String
        Private Property Name16 As String
        Private Property Name17 As String
        Private Property Name18 As String
        Public Property Name19 As String

        Public Sub Use()
            Name = ""
        End Sub

        Public Sub Use1()
            Name1 = ""
        End Sub

        Public Sub Use2()
            Name2 = ""
        End Sub

        Public Sub Use3()
            Name3 = ""
        End Sub

        Public Sub Use4()
            Name4 = ""
        End Sub

        Public Sub Use5()
            Name5 = ""
        End Sub

        Public Sub Use6()
            Name6 = ""
        End Sub

        Public Sub Use7()
            Name7 = ""
        End Sub

        Public Sub Use8()
            Name8 = ""
        End Sub

        Public Sub Use9()
            Name9 = ""
        End Sub

        Public Sub Use10()
            Name10 = ""
        End Sub

        Public Sub Use11()
            Name11 = ""
        End Sub

        Public Sub Use12()
            Name12 = ""
        End Sub

        Public Sub Use13()
            Name13 = ""
        End Sub

        Public Sub Use14()
            Name14 = ""
        End Sub

        Public Sub Use15()
            Name15 = ""
        End Sub

        Public Sub Use16()
            Name16 = ""
        End Sub

        Public Sub Use17()
            Name17 = ""
        End Sub

        Public Sub Use18()
            Name18 = ""
        End Sub

        Private Class InnerClass
        End Class
    End Class
End Namespace
