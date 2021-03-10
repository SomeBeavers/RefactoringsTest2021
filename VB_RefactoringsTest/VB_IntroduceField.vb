Imports System

Namespace RefactoringsTest2021
    Public Class IntroduceField
        Private Protected Shared t As Integer = New Integer()

        Private Sub IntroduceField1(ByVal age As Integer)
            Dim test As Integer = 2
            Dim test2 = New Exception().Data
            Dim test3 = New Exception()
            Dim test4 = New Exception()
            age += 1
            test += 1
            t += 1
        End Sub

        Private Sub IntroduceField2(ByVal age As Integer)
            Dim test As Integer = 2
            Dim test2 = New Exception()
            Dim test3 = New Exception()
            Dim test4 = New Exception()
            age += 1
            test += 1
            t += 1
        End Sub
    End Class
End Namespace
