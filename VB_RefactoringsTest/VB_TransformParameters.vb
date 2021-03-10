Imports System.Runtime.InteropServices

Namespace RefactoringsTest2021
    Public Class TransformParameters
        Public Function TransformParametersManyParameters(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByRef tri As TransformClassReturnInner, ByVal t1 As Integer, ByVal t2 As Integer, ByVal t3 As Integer, ByVal t4 As Integer, ByVal t5 As Integer, ByVal t6 As Integer, ByVal t7 As Integer, ByVal t8 As Integer, ByVal t9 As Integer, ByVal t10 As Integer, ByVal t11 As Integer, ByVal t12 As Integer, ByVal t13 As Integer, ByVal t14 As Integer, ByVal t15 As Integer, ByVal t16 As Integer, ByVal t17 As Integer, ByVal t18 As Integer, ByVal t19 As Integer, ByVal t20 As Integer, ByVal t21 As Integer, ByVal t22 As Integer, ByVal t23 As Integer, ByVal t24 As Integer, ByVal t25 As Integer, ByVal t26 As Integer, ByVal t27 As Integer, ByVal t28 As Integer, ByVal t29 As Integer, ByVal t30 As Integer, ParamArray tpri As TransformClassReturnInner()) As TransformClassReturnInner1
            res = False
            res1 = False
            Return Nothing
        End Function

        Public Sub TransformParameters1(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, ByRef tcr As TransformClassReturn)
            res = True
        End Sub

        Public Sub UseTransformParameters()
            Dim tcr As TransformClassReturn = Nothing
            Dim res As Boolean
            TransformParameters1(Nothing, 0, res, tcr)
        End Sub

        Public Sub Test7(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean)
            res = False
            res1 = False
        End Sub

        Public Function Test8(ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean) As Integer
            res = False
            res1 = False
            Return 0
        End Function

        Public Function Test9(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean) As TransformClassReturn
            res = False
            res1 = False
            Return Nothing
        End Function

        Public Sub Test10(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByVal Optional t As Integer = 0)
            res = False
            res1 = False
        End Sub

        Public Function Test11(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByVal Optional t As Integer = 0) As Integer
            res = False
            res1 = False
            Return 0
        End Function

        Public Function Test12(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByVal Optional t As Integer = 0) As TransformClassReturnInner
            res = False
            res1 = False
            Return Nothing
        End Function

        Public Sub Test13(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByRef tri As TransformClassReturnInner, ByVal Optional t As Integer = 0)
            res = False
            res1 = False
        End Sub

        Public Function Test14(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByRef tri As TransformClassReturnInner, ByVal Optional t As Integer = 0) As Integer
            res = False
            res1 = False
            Return 0
        End Function

        Public Function Test15(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByRef tri As TransformClassReturnInner, ByVal Optional t As Integer = 0) As TransformClassReturnInner
            res = False
            res1 = False
            Return Nothing
        End Function

        Public Sub Test16(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByRef tri As TransformClassReturnInner, ParamArray tpri As TransformClassReturnInner())
            res = False
            res1 = False
        End Sub

        Public Function Test17(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByRef tri As TransformClassReturnInner, ParamArray tpri As TransformClassReturnInner()) As Integer
            res = False
            res1 = False
            Return 0
        End Function

        Public Function Test19(ByRef tcri As TransformClassReturnInner) As TransformClassReturnInner1
            Return Nothing
        End Function

        Public Function Test18(ByVal ctr As Point, ByVal rad As Single, <Out> ByRef res As Boolean, <Out> ByRef res1 As Boolean, ByRef tri As TransformClassReturnInner, ParamArray tpri As TransformClassReturnInner()) As TransformClassReturnInner1
            res = False
            res1 = False
            Return Nothing
        End Function

        Public Class Point
        End Class

        Public Class TransformClassReturnInner1
        End Class

        Public Class TransformClassReturnInner
        End Class
    End Class

    Public Class TransformClassReturn
    End Class
End Namespace
